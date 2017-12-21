using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdQuit : BaseCommand
    {
        private IAppContext _context;
        public CmdQuit(IAppContext context)
        {
            base._text = "退出系统";
            base._key = Plugins.Menu.MenuKeys.Quit;
            base._icon = Resources.icon_quit;
            _context = context;
        }

        public override void OnClick()
        {
            var appContext = _context as AppContext;
            if (appContext != null)
            {
                appContext.Close();
            }
        }
    }
}