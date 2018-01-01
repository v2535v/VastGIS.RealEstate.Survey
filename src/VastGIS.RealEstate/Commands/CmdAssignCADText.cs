using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Commands.File
{
    public class CmdAssignCADText : BaseCommand
    {
        private IAppContext _context;
        public CmdAssignCADText(IAppContext context)
        {
            base._text = "CAD文字属性识别";
            base._key = MenuKeys.AssignCADText;
            base._icon = Resources.LayerTool32;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
        }

        public override void OnClick()
        {
            frmAssignText frm = new frmAssignText(_context);
            _context.View.ShowChildView(frm);


        }
    }
}