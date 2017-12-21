using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdRemoveLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdRemoveLayer(IAppContext context)
        {
            base._text = "删除图层";
            base._key = MenuKeys.RemoveLayer;
            base._icon = Resources.icon_layer_remove;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.RemoveSelectedLayer();
        }
    }
}