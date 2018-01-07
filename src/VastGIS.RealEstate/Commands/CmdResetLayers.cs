using System;
using System.Collections.Generic;
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
           
            _context.Legend.Layers.Clear();
            //_context.Map.Layers.Clear();
           
            _layerService = _context.Container.GetSingleton<ILayerService>();
            ((IRealEstateContext)_context).RealEstateDatabase.DatabaseName =
                ReProjectHelper.GetProjectDatabase(_context.Project.Filename);
            List<VgObjectclasses> classes = ((IRealEstateContext)_context).RealEstateDatabase.SystemService
                .GetObjectclasseses(true);
            string connectionString = "Data Source=" +
                                      ((IRealEstateContext)_context).RealEstateDatabase.DatabaseName;
            var ds = GeoSource.Open(((IRealEstateContext)_context).RealEstateDatabase.DatabaseName);
            foreach (var oneclass in classes)
            {
                LoadDataToMap(ds, connectionString, oneclass);
            }

        }


        private void LoadDataToMap(IDatasource ds, string connectionString, VgObjectclasses oneclass)
        {
            if (oneclass.Dxlx == 0)
            {
                if (oneclass.SubClasses == null) return;
                foreach (var subClass in oneclass.SubClasses)
                {
                    LoadDataToMap(ds, connectionString, subClass);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(oneclass.Filter))
                {
                    IVectorLayer vectorLayer = ((IVectorDatasource)ds).RunQuery(oneclass.Filter);
                    vectorLayer.DynamicLoading = true;
                    _context.Map.Layers.Add(vectorLayer, (bool)oneclass.Visible);
                }
                else
                {
                    IVectorLayer vectorLayer = ((IVectorDatasource)ds).GetLayerByName(oneclass.Mc, false);
                    vectorLayer.DynamicLoading = true;
                    _context.Map.Layers.Add(vectorLayer, (bool)oneclass.Visible);
                }

            }

        }


    }
}
