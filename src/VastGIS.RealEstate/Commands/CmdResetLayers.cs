using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Service;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdResetLayers:BaseCommand
    {
        private IAppContext _context;
        private ILayerService _layerService;
        private RealEstateEditor _plugin;
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

            IEnvelope envelope = ((IRealEstateContext)_context).RealEstateDatabase.GetDatabaseEnvelope();

            foreach (var layer in _context.Map.Layers)
            {
                layer.VectorSource.ReloadFromSource();
                
                   var data=layer.VectorSource.Data;
                if(data.NumFeatures>0)
                    Debug.WriteLine(string.Format("{0} has {1} features",layer.Name,data.NumFeatures));
            }
            _context.Map.ZoomToExtents(envelope);

        }


       

    }
}
