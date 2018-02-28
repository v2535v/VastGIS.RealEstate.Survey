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
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.Config
{
    public class VGLayerConfig
    {
        private string _folder;
        private IAppContext _context;
        private RealEstateEditor _plugin;

        public VGLayerConfig(IAppContext context, RealEstateEditor plugin)
        {
            _context = context;
            _plugin = plugin;
            _folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public void Restore(int layerHandle)
        {
            ILegendLayer legendLayer = _context.Legend.Layers.ItemByHandle(layerHandle);
            string filename = string.Format("{0}\\Styles\\Layers\\{1}.vglayer", _folder, legendLayer.Identity.Query);
            if (string.IsNullOrWhiteSpace(filename) || !File.Exists(filename)) return;
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    string xml = reader.ReadToEnd();
                    xml = xml.Replace("{ProjectPath}", Path.GetDirectoryName(_context.Project.Filename));
                    XmlLayer xmlLayer = xml.Deserialize<XmlLayer>();
                    xmlLayer.RestoreLayer(legendLayer, _plugin.MapListener.Broadcaster);
                    legendLayer.Name = xmlLayer.Name;
                }
            }
            catch (Exception ex)
            {
                const string msg = "Failed to deserialize layer";
                Logger.Current.Warn(msg, ex);
            }
        }
    }
}
