using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.Services.Views;

namespace VastGIS.Commands.File
{
    public class CmdImportDXF : BaseCommand
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        public CmdImportDXF(IAppContext context, RealEstateEditor plugin)
        {
            base._text = "µº»ÎDXF";
            base._key = MenuKeys.ImportDXF;
            base._icon = Resources.img_dxf;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
            _plugin = plugin;
        }

        public override void OnClick()
        {
            frmImportDXF frm = new frmImportDXF(_context, _plugin);
            frm.ShowDialog();
        }
    }
}