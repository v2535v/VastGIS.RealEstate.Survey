using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Plugins.RealEstate.Commands
{
    class CmdLayerManagement : BaseCommand
    {
        private IAppContext _context;
        public CmdLayerManagement(IAppContext context)
        {
            base._text = "图层管理";
            base._key = MenuKeys.LayerManagement;
            base._icon = Resources.LayerManagement;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
            
        }

        public override void OnClick()
        {
            frmLayerManagement frm = new frmLayerManagement(_context);
            _context.View.ShowChildView(frm);
        }
    }
}
