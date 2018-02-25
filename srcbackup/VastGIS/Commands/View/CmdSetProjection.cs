using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Projections.Helpers;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdSetProjection : BaseCommand
    {
        private IAppContext _context;
        public CmdSetProjection(IAppContext context)
        {
            base._text = "底图投影";
            base._key = MenuKeys.SetProjection;
            base._icon = Resources.icon_crs_change;
            _context = context;
        }

        public override void OnClick()
        {
            if (_context.Map.Projection.IsEmpty)
            {
                _context.ChangeProjection();
            }
            else
            {
                _context.ShowMapProjectionProperties();
            }
        }
    }
}