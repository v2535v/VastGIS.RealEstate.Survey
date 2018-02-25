using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdClearSelection : BaseCommand
    {
        private IAppContext _context;
        public CmdClearSelection(IAppContext context)
        {
            base._text = "清除选择集";
            base._key = MenuKeys.ClearSelection;
            base._icon = Resources.icon_clear_selection;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.ClearSelection();
        }
    }
}