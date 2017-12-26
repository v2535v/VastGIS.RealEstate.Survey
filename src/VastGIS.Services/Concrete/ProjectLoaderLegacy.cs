using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Legend;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Services.Serialization;
using VastGIS.Services.Serialization.Legacy;
using VastGIS.Shared;

namespace VastGIS.Services.Concrete
{
    public class ProjectLoaderLegacy: ProjectLoaderBase
    {
        private readonly ImageSerializationService _imageSerializationService;
        private readonly ILayerService _layerService;
        private readonly ISecureContext _context;

        public ProjectLoaderLegacy(IAppContext context, ImageSerializationService imageSerializationService, ILayerService layerService)
        {
            if (imageSerializationService == null) throw new ArgumentNullException("imageSerializationService");
            if (layerService == null) throw new ArgumentNullException("layerService");
            _imageSerializationService = imageSerializationService;
            _layerService = layerService;

            _context = context as ISecureContext;
            if (_context == null)
            {
                throw new InvalidCastException("Application context must support ISerializable_context interface.");
            }
        }

        /// <summary>
        /// Restores the state of application by populating application _context after project file was deserialized.
        /// </summary>
        public bool Restore(VastGISProject project, string filename)
        {
            if (project == null)
            {
                return false;
            }

            _context.Map.Lock();
            _context.Legend.Lock();

            string path = Path.GetDirectoryName(filename);

            try
            {
                _layerService.BeginBatch();

                RestoreMapProjection(project, filename);

                RestoreLayers(project, path);

                RestoreGroups(project);

                MapLayerToGroups(project);

                RestoreExtents(project);

                RestoreLocator(project);

                return true;
            }
            finally
            {
                _layerService.EndBatch();
                _context.Map.Unlock();
                _context.Legend.Unlock();
                _context.Legend.Redraw(LegendRedraw.LegendAndMap);
                
            }
        }

        private void RestoreExtents(VastGISProject project)
        {
            if (project.MapwinGis == null || project.MapwinGis.Mapstate == null)
            {
                return;
            }

            var state = project.MapwinGis.Mapstate;

            try
            {
                var env = new Envelope(double.Parse(state.ExtentsLeft),
                    double.Parse(state.ExtentsRight),
                    double.Parse(state.ExtentsBottom),
                    double.Parse(state.ExtentsTop));

                _context.Map.ZoomToExtents(env);
            }
            catch (Exception ex)
            {
                Logger.Current.Info("Failed to parse project extents: " + ex.Message);
            }
        }

        private void RestoreMapProjection(VastGISProject project, string filename)
        {
            if (project.VastGis == null)
            {
                return;
            }

            if (project.VastGis.ProjectProjectionWKT == null && project.VastGis.ProjectProjection == null)
            {
                Logger.Current.Info("No projection found int the project file: " + filename);
                return;
            }

                    
            var sr = new SpatialReference();
            if (!sr.ImportFromAutoDetect(project.VastGis.ProjectProjectionWKT))
            {
                if (!sr.ImportFromAutoDetect(project.VastGis.ProjectProjection))
                {
                    Logger.Current.Info("Failed to parse project projection: " + filename);
                    return;
                }
            }

            _context.SetMapProjection(sr);
        }

        private void RestoreLocator(VastGISProject project)
        {
            if (project.VastGis == null || project.VastGis.PreviewMap == null)
            {
                return;
            }

            var xmlPreview = project.VastGis.PreviewMap;
            var bitmap = _imageSerializationService.ConvertStringToImage(xmlPreview.Image.Value, xmlPreview.Image.Type);

            double dx = NumericHelper.Parse(xmlPreview.Dx, 1.0);
            double dy = NumericHelper.Parse(xmlPreview.Dy, 1.0);
            double xll = NumericHelper.Parse(xmlPreview.XllCenter, 0.0);
            double yll = NumericHelper.Parse(xmlPreview.YllCenter, 0.0);

            _context.Locator.RestorePicture(bitmap as System.Drawing.Image, dx, dy, xll, yll);
        }

        private void RestoreLayers(VastGISProject project, string path)
        {
            if (project.MapwinGis == null || project.MapwinGis.Layers == null)
            {
                Logger.Current.Info("Failed to find Layers node in the legacy project file.");
                return;
            }

            var layers = project.MapwinGis.Layers;
            int step = 0;
            int count = layers.Count;
            
            foreach (var xmlLayer in layers)
            {
                step++;
                FireProgressChanged(step, count, "Loading layer: " + xmlLayer.LayerName);

                if (string.IsNullOrWhiteSpace(xmlLayer.Filename))
                {
                    Logger.Current.Info("Failed to load layer: " + (xmlLayer.LayerName ?? ""));
                    continue;
                }

                string filename = Path.Combine(path, xmlLayer.Filename);
                if (!File.Exists(filename))
                {
                    Logger.Current.Info("Layer isn't found: " + filename);
                    continue;
                }

                if (_layerService.AddLayersFromFilename(filename))
                {
                    var layer = _context.Layers.ItemByHandle(_layerService.LastLayerHandle);

                    if (layer == null) continue;
                    layer.Name = xmlLayer.LayerName;

                    string state = xmlLayer.SerializeToXml();
                    layer.Deserialize(state);
                }
                else if (_layerService.Aborted)
                {
                    return;
                }
            }
        }

        private void RestoreGroups(VastGISProject project)
        {
            if (project.VastGis == null || project.VastGis.Groups == null || project.VastGis.Layers == null)
            {
                Logger.Current.Info("Failed to find Groups node in the legacy project file.");
                return;
            }
            
            var xmlGroups = project.VastGis.Groups;
            var groups = _context.Legend.Groups;

            foreach (var xmlGroup in xmlGroups)
            {
                var group = groups.Add(xmlGroup.Name);
                group.Expanded = xmlGroup.IsExpanded();
            }
        }

        private void MapLayerToGroups(VastGISProject project)
        {
            var groups = _context.Legend.Groups;
            if (project.VastGis == null) return;
            var layers = project.VastGis.Layers;
            var legendLayers = _context.Legend.Layers;

            foreach (var xmlLayer in layers)
            {
                var layer = legendLayers.FirstOrDefault(l => l.Name.EqualsIgnoreCase(xmlLayer.Name));
                if (layer != null)
                {
                    var g = groups.GetGroupSafe(xmlLayer.GroupIndex + 1);
                    if (g != null)
                    {
                        _context.Layers.MoveLayer(layer.Handle, g.Handle);
                        layer.Expanded = xmlLayer.IsExpanded();
                    }
                }
            }

            // removing data layers group to which layers are added originally
            if (groups.Count > 1 && !groups[0].Layers.Any())
            {
                groups.Remove(groups[0].Handle);
            }
        }
    }
}
