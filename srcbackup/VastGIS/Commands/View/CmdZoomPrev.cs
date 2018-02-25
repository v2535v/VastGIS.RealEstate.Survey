using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomPrev : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomPrev(IAppContext context)
        {
            base._text = "иор╩йсм╪";
            base._key = MenuKeys.ZoomPrev;
            base._icon = Resources.img_preview;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToPrev();
        }
    }
}