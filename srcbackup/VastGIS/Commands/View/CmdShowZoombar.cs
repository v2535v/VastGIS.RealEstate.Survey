using VastGIS.Api.Enums;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Commands.View
{
    public class CmdShowZoombar : BaseCommand
    {
        private IAppContext _context;
        public CmdShowZoombar(IAppContext context)
        {
            base._text = "显示放大工具条";
            base._key = MenuKeys.ShowZoombar;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            config.ShowZoombar = !AppConfig.Instance.ShowZoombar;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }
}