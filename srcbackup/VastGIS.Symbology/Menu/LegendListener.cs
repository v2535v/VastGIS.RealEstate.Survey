﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Legend.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Symbology.Forms;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Services;
using VastGIS.Plugins.Symbology.Views;
using VastGIS.Plugins.Symbology.Views.Abstract;

namespace VastGIS.Plugins.Symbology.Menu
{
    public class LegendListener
    {
        private readonly IAppContext _context;
        private readonly SymbologyMetadataService _metadataService;

        public LegendListener(IAppContext context, SymbologyPlugin plugin, SymbologyMetadataService metadataService)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            _context = context;
            _metadataService = metadataService;

            plugin.LayerDoubleClicked += LayerDoubleClicked;
            plugin.LayerStyleClicked += LayerStyleClicked;
            plugin.LayerLabelsClicked += LayerLabelsClicked;
            plugin.LayerDiagramsClicked += LayerDiagramsClicked;
            plugin.LayerCategoryClicked += LayerCategoryClicked;
        }

        private void LayerCategoryClicked(IMuteLegend legend, LayerCategoryEventArgs e)
        {
            var fs = legend.Map.GetFeatureSet(e.LayerHandle);
            if (fs != null)
            {
                var ct = fs.Categories[e.CategoryIndex];
                if (ct != null)
                {
                    using (var form = _context.GetSymbologyForm(e.LayerHandle, ct.Style, false))
                    {
                        _context.View.ShowChildView(form);
                    }
                    e.Handled = true;
                }
            }
        }

        private void LayerDiagramsClicked(IMuteLegend legend, LayerEventArgs e)
        {
            var fs = legend.Map.GetFeatureSet(e.LayerHandle);
            if (fs != null)
            {
                var layer = legend.Map.Layers.ItemByHandle(e.LayerHandle);
                using (var form = new ChartStyleForm(_context, layer))
                {
                    _context.View.ShowChildView(form);
                }
                e.Handled = true;
            }
        }

        private void LayerLabelsClicked(IMuteLegend legend, LayerEventArgs e)
        {
            var fs = legend.Map.GetFeatureSet(e.LayerHandle);
            if (fs != null)
            {
                var layer = legend.Map.Layers.ItemByHandle(e.LayerHandle);
                using (var form = new LabelStyleForm(_context, layer))
                {
                    _context.View.ShowChildView(form);
                }
                e.Handled = true;
            }
        }

        private void LayerStyleClicked(IMuteLegend legend, LayerEventArgs e)
        {
            var layer = legend.Layers.ItemByHandle(e.LayerHandle);
            if (layer.LayerType == LayerType.Image || layer.LayerType == LayerType.Grid)
            {
                var p = _context.Container.GetInstance<RasterStylePresenter>();
                p.View.InitialTab = RasterStyleTab.Colors;
                p.Run(layer);
                e.Handled = true;
                return;
            }
            
            var fs = legend.Map.GetFeatureSet(e.LayerHandle);
            if (fs != null)
            {
                _context.ShowDefaultStyleDialog(e.LayerHandle, false, null);
                
                

                e.Handled = true;
            }
        }

        private void LayerDoubleClicked(IMuteLegend legend, LayerEventArgs e)
        {
            if (FormHelper.ShowLayerProperties(_context))
            {
                e.Handled = true;
            }
        }
    }
}
