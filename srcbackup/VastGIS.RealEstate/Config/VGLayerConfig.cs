using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Api.Legend.Events;
using VastGIS.Api.Map;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Services.Serialization;

namespace VastGIS.Plugins.RealEstate.Config
{
    public class VGLayerConfig
    {
        private VGLayer _vgLayer;
        private string _folder;
        private IAppContext _context;
        private ILayerService _layerService;
        private RealEstateEditor _plugin;
        public VGLayerConfig(IAppContext context, RealEstateEditor plugin)
        {
            _context = context;
            _plugin = plugin;
            _folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fileName = string.Format("{0}\\Styles\\survey.vglayers", _folder);
            if (!File.Exists(fileName))
                return;
            _vgLayer = new VGLayer();
            _vgLayer.LoadFromXml(fileName, Path.GetDirectoryName(_context.Project.Filename));
        }

        public void AddLayersFromDb()
        {
            string dbPath = string.Format("{0}\\Database\\redatabase.db", Path.GetDirectoryName(_context.Project.Filename));
            if (!File.Exists(dbPath))
                return;
            _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayersFromFilename(dbPath);

            foreach (VGXmlGroup layerGroup in _vgLayer.Groups)
            {
                ILegendGroup legendGroup = _context.Legend.Groups.Add(layerGroup.Name, layerGroup.Position);
                layerGroup.Handle = legendGroup.Handle;
            }

            for (int i = _context.Legend.Layers.Count - 1; i >= 0; i--)
            {
                ILegendLayer legendLayer = _context.Legend.Layers[i];
                VGXmlGroup xmlGroup = _vgLayer.Groups.FirstOrDefault(c => c.Layers.Any(d => d.Name.ToUpper() == legendLayer.Name.ToUpper()));

                if (xmlGroup == null)
                {
                    _context.Map.Layers.Remove(legendLayer.Handle);
                }
                else
                {
                    VGXmlLayer vgXmlLayer = xmlGroup.Layers.FirstOrDefault(c => c.Name.ToUpper() == legendLayer.Name.ToUpper());
                    if (vgXmlLayer == null)
                    {
                        _context.Map.Layers.Remove(legendLayer.Handle);
                    }
                    else
                    {
                        vgXmlLayer.XmlLayer.RestoreLayer(legendLayer, _plugin.MapListener.Broadcaster);
                        _context.Layers.MoveLayer(legendLayer.Handle, xmlGroup.Handle, vgXmlLayer.Position);
                    }
                }
            }


            for (int i = _context.Legend.Groups.Count - 1; i >= 0; i--)
            {
                ILegendGroup legendGroup = _context.Legend.Groups[i];
                VGXmlGroup xmlGroup = _vgLayer.Groups.FirstOrDefault(c => c.Name.ToUpper() == legendGroup.Text.ToUpper());
                if (xmlGroup == null)
                {
                    _context.Legend.Groups.Remove(legendGroup.Handle);
                }
                else
                {
                    _context.Legend.Groups.MoveGroup(legendGroup.Handle, xmlGroup.Position);
                }
            }
        }
    }
}
