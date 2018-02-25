using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.Views;

namespace VastGIS.Commands.View
{
    public class CmdFindLocation : BaseCommand
    {
        private IAppContext _context;
        public CmdFindLocation(IAppContext context)
        {
            base._text = "查找";
            base._key = MenuKeys.FindLocation;
            base._icon = Resources.icon_search;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Container.Run<GeoLocationPresenter>();
        }
    }
}