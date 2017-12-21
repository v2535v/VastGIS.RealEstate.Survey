using VastGIS.Api.Enums;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Commands.View
{
    public class CmdShowScalebar : BaseCommand
    {
        private IAppContext _context;
        public CmdShowScalebar(IAppContext context)
        {
            base._text = "显示比例尺";
            base._key = MenuKeys.ShowScalebar;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowScalebar = !AppConfig.Instance.ShowScalebar;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }
}