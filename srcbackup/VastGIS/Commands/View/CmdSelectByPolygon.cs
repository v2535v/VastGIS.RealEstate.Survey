using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Commands.View
{
    public class CmdSelectByPolygon : BaseCommand
    {
        private IAppContext _context;
        public CmdSelectByPolygon(IAppContext context)
        {
            base._text = "¶à±ßÐÎÑ¡Ôñ";
            base._key = MenuKeys.SelectByPolygon;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.SelectByPolygon;
        }
    }
}