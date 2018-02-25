using System.Diagnostics;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Interface;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdZoomToDbMax : BaseCommand
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        public CmdZoomToDbMax(IAppContext context, RealEstateEditor plugin)
        {
            base._text = "数据库全图";
            base._key = MenuKeys.ZoomToDbMax;
            base._icon = Resources.img_fullextent;
            base._headerName = "tabZD";
            base._toolStripExName = "toolStripExZDCommon";
            _context = context;
            _plugin = plugin;
        }

        public override void OnClick()
        {
            IEnvelope envelope = ((IRealEstateContext)_context).RealEstateDatabase.GetDatabaseEnvelope();
            //foreach (var layer in _context.Map.Layers)
            //{
            //    layer.VectorSource.ReloadFromSource();

            //    var data = layer.VectorSource.Data;
            //    if (data.NumFeatures > 0)
            //        Debug.WriteLine(string.Format("{0} has {1} features", layer.Name, data.NumFeatures));
            //}
            _context.Map.ZoomToExtents(envelope);
        }
    }
}