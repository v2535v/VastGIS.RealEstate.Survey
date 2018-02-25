﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Properties;
using VastGIS.Shared;

namespace VastGIS.Plugins.Symbology.Services
{
    public class LabelMover
    {
        private const int MOUSE_TOLERANCE = 0;

        private readonly IAppContext _context;
        private readonly SymbologyPlugin _plugin;
        private readonly IMuteMap _map;
        private LabelMoveData _currentLabel = new LabelMoveData();        // The label being moved currently

        public LabelMover(IAppContext context, SymbologyPlugin plugin)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            _context = context;
            _plugin = plugin;
            _map = context.Map;

            plugin.MouseDown += MapMouseDown;
            plugin.MouseUp += MapMouseUp;
            plugin.MouseMove += MapMouseMove;
        }

        /// <summary>
        /// Gets value indicating whether label mover is currently active.
        /// </summary>
        public bool Active
        {
            get { return _map.CustomCursor == LabelMoverCursor.Instance; }
        }

        /// <summary>
        /// Start the dragging operation.
        /// </summary>
        private void MapMouseDown(IMuteMap map, MouseEventArgs e)
        {
            if (!Active)
            {
                return;
            }

            var data = FindMovableItem(e.X, e.Y);

            if (data == null)
            {
                return;
            }

            _currentLabel = data;

            var fs = _map.GetFeatureSet(_currentLabel.LayerHandle);
            if (fs == null)
            {
                return;
            }

            IEnvelope env = null;
            if (_currentLabel.IsChart)
            {
                var chart = fs.Diagrams[_currentLabel.LabelIndex];
                env = chart.ScreenExtents;
            }
            else
            {
                var label = fs.Labels.Items[_currentLabel.LabelIndex, _currentLabel.PartIndex];
                env = label.ScreenExtents;
            }

            _currentLabel.Rect = env.ToRectangle();

            DrawLabelRectangle(_currentLabel.Rect);
        }

        private void MapMouseMove(IMuteMap map, MouseEventArgs e)
        {
            if (!Active || _currentLabel.LayerHandle == -1)
            {
                return;
            }

            if (e.X != _currentLabel.X || e.Y != _currentLabel.Y)
            {
                int dx = -_currentLabel.X + e.X;
                int dy = -_currentLabel.Y + e.Y;
                var r = _currentLabel.Rect.CloneWithOffset(dx, dy);
                DrawLabelRectangle(r);
            }
        }

        /// <summary>
        /// Finishes the label moving operation.
        /// </summary>
        private void MapMouseUp(IMuteMap map, MouseEventArgs e)
        {
            if (!Active || _currentLabel.LayerHandle == -1)
            {
                return;
            }

            if (e.X == _currentLabel.X || e.Y == _currentLabel.Y)
            {
                Clear();
                return;
            }

            // check that new position is within map
            if (e.X < 0 || e.Y < 0 || e.X > map.Width || e.Y > map.Height)
            {
                Clear();
                return;
            }

            var fs = map.GetFeatureSet(_currentLabel.LayerHandle);

            if (_currentLabel.IsChart)
            {
                var chart = fs.Diagrams[_currentLabel.LabelIndex];
                if (chart != null)
                {
                    double x1, x2, y1, y2;
                    map.PixelToProj(_currentLabel.X, _currentLabel.Y, out x1, out y1);
                    map.PixelToProj(e.X, e.Y, out x2, out y2);
                    chart.PositionX = chart.PositionX - x1 + x2;
                    chart.PositionY = chart.PositionY - y1 + y2;
                    fs.Diagrams.SavingMode = PersistenceType.XmlOverwrite; // .chart file should be overwritten
                    _context.Project.SetModified();
                    map.Redraw();
                }
            }
            else
            {
                var lb = fs.Labels.Items[_currentLabel.LabelIndex, _currentLabel.PartIndex];
                if (lb != null)
                {
                    double x1, x2, y1, y2;
                    map.PixelToProj(_currentLabel.X, _currentLabel.Y, out x1, out y1);
                    map.PixelToProj(e.X, e.Y, out x2, out y2);
                    lb.X = lb.X - x1 + x2;
                    lb.Y = lb.Y - y1 + y2;
                    fs.Labels.SavingMode = PersistenceType.XmlOverwrite; // .lbl file should be overwritten
                    _context.Project.SetModified();
                    map.Redraw();
                }
            }

            Clear();
        }

        private void Clear()
        {
            _currentLabel.Clear();
            _map.FocusRectangle.Visible = false;
            _map.Redraw(RedrawType.Minimal);
        }

        private LabelMoveData FindMovableItem(int x, int y)
        {
            // Actually, collision avoidance is turned on for all layers now
            // and Labels.Select, Charts.Select return only visible objects
            // so it's not possible to have 2 candidate labels for draging
            // so we can have much easier code here, but better still to consider 
            // thу more difficult situation in case somebody will turn off collision
            // avoidance form plugin

            // 1 - vpAboveAll layers (considered first)                                                    
            // 0 - above current layer

            var data = new LabelMoveData() { X = x, Y = y };

            for (int z = 1; z >= 0; z--)        // Considering position above the layer and above all layers
            {
                int layerCount = _map.Layers.Count;

                for (int i = layerCount - 1; i >= 0; i--)    // we are starting from the layers which were drawn last
                {
                    var layer = _map.Layers[i];
                    if (layer == null || !layer.IsVector || layer.FeatureSet == null)
                    {
                        continue;
                    }

                    var fs = layer.FeatureSet;

                    var env = new Envelope();
                    env.SetBounds(x, x, y, y);

                    var position = (VerticalPosition)z;

                    int chartIndex = FindChart(fs, env, position);
                    if (chartIndex != -1)
                    {
                        data.LayerHandle = layer.Handle;
                        data.LabelIndex = chartIndex;
                        data.IsChart = true;
                        return data;
                    }

                    var info = FindLabel(fs, env, position);
                    if (info != null)
                    {
                        data.LayerHandle = layer.Handle;
                        data.LabelIndex = info.LabelIndex;
                        data.PartIndex = info.PartIndex;
                        data.IsChart = false;
                        return data;
                    }
                }
            }

            return null;
        }

        private LabelInfo FindLabel(IFeatureSet fs, IEnvelope envelope, VerticalPosition position)
        {
            if (fs.Labels.VerticalPosition != position)
            {
                return null;
            }

            var lb = fs.Labels;
            var labelList = lb.Select(envelope).ToList();
            if (labelList.Any())
            {
                var info = labelList[labelList.Count - 1];
                return info;
            }

            return null;
        }

        private int FindChart(IFeatureSet fs, IEnvelope envelope, VerticalPosition position)
        {
            // analyzing charts: they are drawn on the top of the labels
            if (position == fs.Diagrams.VerticalPosition)
            {
                int[] indices = fs.Diagrams.Select(envelope, MOUSE_TOLERANCE, MapSelectionMode.Intersection);
                if (indices != null && indices.Length > 0)
                {
                    // in case severral charts are selected we have to choose the one with the largest id
                    // as it will be drawn on the top of others
                    int index = indices[indices.Length - 1];
                    return index;
                }
            }
            return -1;
        }

        /// <summary>
        /// Draws rectangle around chosen label
        /// </summary>
        private void DrawLabelRectangle(Rectangle rect)
        {
            var r = _context.Map.FocusRectangle; 
            r.Visible = true;
            r.X = rect.X;
            r.Y = rect.Y;
            r.Width = rect.Width;
            r.Height = rect.Height;
            r.FillTransparency = 150;
            _context.Map.Redraw(RedrawType.Minimal);
        }
    }
}
