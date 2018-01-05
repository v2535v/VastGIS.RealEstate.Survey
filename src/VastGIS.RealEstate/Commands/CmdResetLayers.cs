using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Legend;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Service;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdResetLayers:BaseCommand
    {
        private IAppContext _context;
        private ILayerService _layerService;
        public CmdResetLayers(IAppContext context)
        {
            base._text = "重新引导图层";
            base._key = MenuKeys.ReOrginzeLayers;
            base._icon = Resources.DatabaseServersFolder32;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
        }

        public override void OnClick()
        {
            SystemService service = ServiceFactory.GetSystemService();
            List<VgObjectclasses> objectClasseses = service.GetObjectclasseses();
            _context.Legend.Layers.Clear();
            //_context.Map.Layers.Clear();
            string dbPath = string.Format("{0}\\Database\\redatabase.db", Path.GetDirectoryName(_context.Project.Filename));
            if (!File.Exists(dbPath))
                return;
            _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayersFromFilename(dbPath);
            foreach (var objectClass in objectClasseses)
            {
               
               // _context.Map.Layers.Add(layer.LayerSource,true);
            }

        }

       
    }
}
