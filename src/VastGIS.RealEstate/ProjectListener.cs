using System;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Config;
using VastGIS.Plugins.RealEstate.Services;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.RealEstate
{
    public class ProjectListener
    {
        private readonly IAppContext _context;
        private readonly IRealEstateEditingService _layerService;
        private RealEstateEditor _plugin;

        public ProjectListener(IAppContext context, RealEstateEditor plugin, IRealEstateEditingService layerService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");

            _context = context;
            _layerService = layerService;
            _plugin = plugin;
            plugin.ProjectChanged += Plugin_ProjectChanged;
            plugin.ProjectClosing += plugin_ProjectClosing;
            plugin.BeforeRemoveLayer += plugin_BeforeRemoveLayer;
        }

        private void Plugin_ProjectChanged(object sender, EventArgs e)
        {
            if (_context.Map.Layers.Count <= 0)
            {
                if (string.IsNullOrEmpty(_context.Project.Filename) == false)
                {
                    VGLayerConfig config = new VGLayerConfig(_context, _plugin);
                    config.AddLayersFromDb();
                }
            }
        }

        private void plugin_BeforeRemoveLayer(object sender, LayerCancelEventArgs e)
        {
            if (_context.Map.GeometryEditor.LayerHandle == e.LayerHandle)
            {
                if (!_context.Map.GeometryEditor.SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }

            var layer = _context.Map.Layers.ItemByHandle(e.LayerHandle);
            if (layer != null && layer.FeatureSet != null && layer.FeatureSet.InteractiveEditing)
            {
                if (!_layerService.SaveEditing(true))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void plugin_ProjectClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_context.Map.GeometryEditor.SaveChanges())
            {
                e.Cancel = true;
                return;
            }
            
            var layers = _context.Map.Layers;

            foreach (var layer in layers)
            {
                var fs = layer.FeatureSet;
                if (fs != null && fs.InteractiveEditing)
                {
                    if (!_layerService.SaveEditing(true))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }
    }
}
