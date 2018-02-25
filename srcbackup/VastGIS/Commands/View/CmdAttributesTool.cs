using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdAttributesTool : BaseCommand
    {
        private IAppContext _context;
        public CmdAttributesTool(IAppContext context)
        {
            base._text = " Ù–‘";
            base._key = MenuKeys.AttributesTool;
            base._icon = Resources.icon_identify;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.Identify;
        }
    }
}