using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdTestOgrChinese:BaseCommand
    {
        private IAppContext _context;
        public CmdTestOgrChinese(IAppContext context)
        {
            base._text = "测试OGR";
            base._key = MenuKeys.TestOgrChinese;
            base._icon = Resources.chinese;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
        }

        public override void OnClick()
        {

            frmTestOgrChinese frm = new frmTestOgrChinese();
            frm.Show();
        }
    }
}
