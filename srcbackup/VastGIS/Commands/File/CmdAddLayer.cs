using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdAddLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddLayer(IAppContext context)
        {
            base._text = "Ìí¼ÓÊý¾Ý";
            base._key = MenuKeys.AddLayer;
            base._icon = Resources.icon_layer_add;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExLayer";
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.All);
        }
    }
}