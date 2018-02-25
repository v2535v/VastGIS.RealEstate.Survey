using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomIn : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomIn(IAppContext context)
        {
            base._text = "放大";
            base._key = MenuKeys.ZoomIn;
            base._icon = Resources.img_zoomin;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.ZoomIn;
        }
    }
}