﻿using System;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Legend.Events;
using VastGIS.Plugins.Identifier.Enums;
using VastGIS.Plugins.Identifier.Views;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.Identifier.Listeners
{
    public class MapListener
    {
        private readonly IAppContext _context;
        private readonly IdentifierPresenter _identifierPresenter;
        // ReSharper disable once NotAccessedField.Local
        private readonly IConfigService _configService;

        public MapListener(IAppContext context, IdentifierPlugin plugin, IdentifierPresenter identifierPresenter,
                            IConfigService configService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (identifierPresenter == null) throw new ArgumentNullException("identifierPresenter");
            if (configService == null) throw new ArgumentNullException("configService");

            _context = context;
            _identifierPresenter = identifierPresenter;
            _configService = configService;

            plugin.ShapeIdentified += plugin_ShapeIdentified;
            plugin.ProjectClosed += plugin_ProjectClosed;
            plugin.LayerRemoved += plugin_LayerRemoved;
            plugin.MouseMove += plugin_MouseMove;
        }

        private void plugin_MouseMove(IMuteMap map, System.Windows.Forms.MouseEventArgs e)
        {
            if (map.MapCursor != MapCursor.Identify)
            {
                return;
            }

            if (_identifierPresenter.View.Mode == IdentifierMode.CurrentLayer /*&& _configService.Config.ShowValuesOnMouseMove*/)
            {
                DisplayCurrentPixelValue(map, e.X, e.Y);
            }
        }

        private void plugin_LayerRemoved(IMuteLegend legend, LayerEventArgs e)
        {
            _identifierPresenter.RemoveLayer(e.LayerHandle);
        }

        private void plugin_ProjectClosed(object sender, EventArgs e)
        {
            _identifierPresenter.RunCommand(IdentifierCommand.Clear);
        }

        private void plugin_ShapeIdentified(IMuteMap map, Api.Events.ShapeIdentifiedEventArgs e)
        {
            _identifierPresenter.ShapeIdentified();
        }

        /// <remarks>
        /// TODO: think of a better place for it to allow reuse        
        /// </remarks>
        private void DisplayCurrentPixelValue(IMuteMap map, int pixelX, int pixelY)
        {
            var layer = map.Layers.Current;
            if (layer == null)
            {
                return;
            }

            var raster = layer.Raster;
            if (raster == null)
            {
                return;
            }

            if (raster.RenderingType == RasterRendering.Rgb)
            {
                return;
            }

            double projX, projY;
            map.PixelToProj(pixelX, pixelY, out projX, out projY);

            int column, row;
            if (raster.ProjectionToImage(projX, projY, out column, out row))
            {
                var band = raster.ActiveBand;
                double value;
                if (band.GetValue(column, row, out value))
                {
                    string msg = string.Format("Raster info. Row: {0}; Column: {1}; Value: {2}", row, column, value);
                    _context.StatusBar.ShowInfo(msg);
                }
            }
            else
            {
                _context.StatusBar.ShowInfo("");
            }
        }
    }
}
