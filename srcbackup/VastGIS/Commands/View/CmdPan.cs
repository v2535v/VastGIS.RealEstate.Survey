using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdPan : BaseCommand
    {
        private IAppContext _context;
        private bool _fireEvent = false;

        public CmdPan(IAppContext context)
        {
            base._text = "Æ½ÒÆ";
            base._key = MenuKeys.Pan;
            base._icon = Resources.icon_pan;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
            _fireEvent = false;
        }

        public override void OnClick()
        {
            _context.CurrentTool = null;
            _context.Map.MapCursor = MapCursor.Pan;
           
        }
    }
}