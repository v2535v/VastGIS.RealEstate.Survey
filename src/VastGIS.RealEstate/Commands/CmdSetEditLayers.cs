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
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdSetEditLayers : BaseCommand
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private List<VgObjectclass> _vgObjectclasses;
        public CmdSetEditLayers(IAppContext context, RealEstateEditor plugin)
        {
            base._text = "编辑图层";
            base._key = MenuKeys.SetEditLayers;
            base._icon = Resources.icon_EditLayer;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripSet";
            _context = context;
            _plugin = plugin;
        }

        public override void OnClick()
        {
            IREDatabase database = ((IRealEstateContext)_context).RealEstateDatabase;
            _vgObjectclasses = database.SystemService.GetVgObjectclasses(" Editable = 1 And DXLX=1").ToList();
            if (_vgObjectclasses == null || _vgObjectclasses.Count <= 0)
                return;


            List<VgObjectclass> editLayers = _context.Config.EditLayers == null?new List<VgObjectclass>() : _vgObjectclasses.Where(c => _context.Config.EditLayers.Contains(c.Mc)).ToList();

            frmSetEditLayers frm = new frmSetEditLayers(_vgObjectclasses, editLayers);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                _context.Config.EditLayers = frm.GetEditLayers().Select(c => c.Mc).ToList();
            }

        }
    }
}
