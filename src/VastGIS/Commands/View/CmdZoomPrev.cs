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
            base._icon = Resources.img_zoom_prev24;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToPrev();
        }
    }
}