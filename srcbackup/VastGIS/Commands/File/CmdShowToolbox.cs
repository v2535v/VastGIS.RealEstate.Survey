using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.UI.Docking;

namespace VastGIS.Commands.File
{
    public class CmdShowToolbox : BaseCommand
    {
        private IAppContext _context;
        public CmdShowToolbox(IAppContext context)
        {
            base._text = "œ‘ æπ§æﬂœ‰";
            base._key = MenuKeys.ShowToolbox;
            base._icon = Resources.img_toolbox24;
            _context = context;
        }

        public override void OnClick()
        {
            DockPanelHelper.ShowPanel(_context, DockPanelKeys.Toolbox);
        }
    }
}