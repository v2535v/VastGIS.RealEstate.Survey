using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.Services.Views;

namespace VastGIS.Commands.File
{
    public class CmdSplitCAD : BaseCommand
    {
        private IAppContext _context;
        public CmdSplitCAD(IAppContext context)
        {
            base._text = "¡Ÿ ±CAD∑÷≤„";
            base._key = MenuKeys.SplitCAD;
            base._icon = Resources.LayerTool32;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
        }

        public override void OnClick()
        {
            frmSplitCAD frm=new frmSplitCAD(_context);
            _context.View.ShowChildView(frm);
          

        }
    }
}