using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomOut : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomOut(IAppContext context)
        {
            base._text = "��С";
            base._key = MenuKeys.ZoomOut;
            base._icon = Resources.img_zoomout;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.ZoomOut;
        }
    }
}