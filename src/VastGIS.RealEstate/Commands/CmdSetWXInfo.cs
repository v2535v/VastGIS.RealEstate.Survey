using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdSetWXInfo : BaseCommand
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;

        public CmdSetWXInfo(IAppContext context, RealEstateEditor plugin)
        {
            base._text = "作业信息";
            base._key = MenuKeys.SetWXInfo;
            base._icon = Resources.icon_wxinfo;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripSet";
            _context = context;
            _plugin = plugin;
        }

        public override void OnClick()
        {
            frmWXInfo frm = new frmWXInfo();
            frm.WxCly = _context.Config.WxCly;
            frm.WxDcy = _context.Config.WxDcy;
            frm.WxZty = _context.Config.WxZty;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _context.Config.WxCly = frm.WxCly;
                _context.Config.WxDcy = frm.WxDcy;
                _context.Config.WxZty = frm.WxZty;
            }
        }
    }
}
