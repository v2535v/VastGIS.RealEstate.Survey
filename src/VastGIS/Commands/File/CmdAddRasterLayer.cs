using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdAddRasterLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddRasterLayer(IAppContext context)
        {
            base._text = "添加栅格图层";
            base._key = MenuKeys.AddRasterLayer;
            base._icon = Resources.icon_layer_raster_add;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExLayer";
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.Raster);
        }
    }
}