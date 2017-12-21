using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Commands.View
{
    public class CmdSelectByRectangle : BaseCommand
    {
        private IAppContext _context;
        public CmdSelectByRectangle(IAppContext context)
        {
            base._text = "矩形选择";
            base._key = MenuKeys.SelectByRectangle;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.Selection;
        }
    }
}