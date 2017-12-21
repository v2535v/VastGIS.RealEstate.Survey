using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomMax : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomMax(IAppContext context)
        {
            base._text = "全图";
            base._key = MenuKeys.ZoomMax;
            base._icon = Resources.icon_zoom_max_extents;
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToMaxExtents();
        }
    }
}