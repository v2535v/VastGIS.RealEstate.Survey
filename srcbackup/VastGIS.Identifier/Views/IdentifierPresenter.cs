﻿// -------------------------------------------------------------------------------------------
// <copyright file="IdentifierPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Identifier.Controls;
using VastGIS.Plugins.Identifier.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.UI.Docking;

namespace VastGIS.Plugins.Identifier.Views
{
    public class IdentifierPresenter : CommandDispatcher<IIdentifierView, IdentifierCommand>, IDockPanelPresenter
    {
        private readonly IAppContext _context;

        public IdentifierPresenter(IAppContext context, IIdentifierView view)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            view.ModeChanged += OnIdentifierModeChanged;
            view.ItemSelected += OnItemSelected;
        }

        public Control GetInternalObject()
        {
            return View as Control;
        }

        public void RemoveLayer(int layerHandle)
        {
            _context.Map.IdentifiedShapes.RemoveByLayerHandle(layerHandle);
            View.UpdateView();
        }

        public override void RunCommand(IdentifierCommand command)
        {
            switch (command)
            {
                case IdentifierCommand.Clear:
                    _context.Map.IdentifiedShapes.Clear();
                    View.Clear();
                    _context.Map.Redraw(RedrawType.SkipDataLayers);
                    break;
            }
        }

        public void ShapeIdentified()
        {
            View.UpdateView();

            ActivatePanel();
        }

        private void ActivatePanel()
        {
            var panel = _context.DockPanels.Find(DockPanelKeys.Identifier);
            if (panel != null)
            {
                panel.Visible = true;
                panel.Activate();
            }
        }

        private void OnIdentifierModeChanged()
        {
            _context.Map.Identifier.Mode = View.Mode;
        }

        private void OnItemSelected()
        {
            var item = View.SelectedItem;
            if (item != null)
            {
                switch (item.NodeType)
                {
                    case IdentifierNodeType.Layer:
                        OnLayerSelected(item);
                        break;
                    case IdentifierNodeType.Geometry:
                        OnShapeSelected(item);
                        break;
                    case IdentifierNodeType.Attribute:
                        break;
                    case IdentifierNodeType.Pixel:
                        OnPixelSelected(item);
                        break;
                }
            }
        }

        private void OnLayerSelected(IdentifierNodeMetadata layer)
        {
            var shapes = _context.Map.IdentifiedShapes;
            shapes.Clear();

            var items = View.GetLayerItems(layer.LayerHandle);
            foreach (var item in items)
            {
                switch (item.NodeType)
                {
                    case IdentifierNodeType.Geometry:
                        shapes.AddShape(item.LayerHandle, item.ShapeIndex);
                        break;
                    case IdentifierNodeType.Pixel:
                        shapes.AddPixel(item.LayerHandle, item.RasterX, item.RasterY);
                        break;
                }
            }

            _context.Map.Redraw(RedrawType.SkipDataLayers);
        }

        private void OnPixelSelected(IdentifierNodeMetadata pixel)
        {
            var shapes = _context.Map.IdentifiedShapes;
            shapes.Clear();
            shapes.AddPixel(pixel.LayerHandle, pixel.RasterX, pixel.RasterY);

            if (View.ZoomToShape)
            {
                var img = _context.Map.GetImage(pixel.LayerHandle);
                if (img != null)
                {
                    var bounds = img.GetPixelBounds(pixel.RasterX, pixel.RasterY);
                    bounds = bounds.Inflate(bounds.Width * 10, bounds.Height * 10);
                    _context.Map.ZoomToExtents(bounds);
                }
            }
            else
            {
                _context.Map.Redraw(RedrawType.SkipDataLayers);
            }
        }

        private void OnShapeSelected(IdentifierNodeMetadata shape)
        {
            var shapes = _context.Map.IdentifiedShapes;
            shapes.Clear();
            shapes.AddShape(shape.LayerHandle, shape.ShapeIndex);

            if (View.ZoomToShape)
            {
                _context.Map.ZoomToShape(shape.LayerHandle, shape.ShapeIndex);
            }
            else
            {
                _context.Map.Redraw(RedrawType.SkipDataLayers);
            }
        }
    }
}