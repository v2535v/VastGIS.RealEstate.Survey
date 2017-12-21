using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.UI.Docking;

namespace VastGIS.Commands.File
{
    public class CmdShowRepository:BaseCommand
    {
        private IAppContext _context;
        public CmdShowRepository(IAppContext context)
        {
            base._text = "显示目录窗口";
            base._key = MenuKeys.ShowRepository;
            base._icon = Resources.icon_folder;
            _context = context;
        }

        public override void OnClick()
        {
            DockPanelHelper.ShowPanel(_context, DockPanelKeys.Repository);
        }
    }
}
