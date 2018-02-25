using VastGIS.Api.Enums;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Commands.View
{
    public class CmdShowRedrawTime : BaseCommand
    {
        private IAppContext _context;
        public CmdShowRedrawTime(IAppContext context)
        {
            base._text = "显示绘制时间";
            base._key = MenuKeys.ShowRedrawTime;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowRedrawTime = !AppConfig.Instance.ShowRedrawTime;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }
}