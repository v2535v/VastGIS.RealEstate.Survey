using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.Views;

namespace VastGIS.Commands.File
{
    public class CmdSettings : BaseCommand
    {
        private IAppContext _context;
        public CmdSettings(IAppContext context)
        {
            base._text = "设置";
            base._key = MenuKeys.Settings;
            base._icon = Resources.icon_settings;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
        }

        public override void OnClick()
        {
            var model = _context.Container.GetInstance<ConfigViewModel>();
            _context.Container.Run<ConfigPresenter, ConfigViewModel>(model);
        }
    }
}