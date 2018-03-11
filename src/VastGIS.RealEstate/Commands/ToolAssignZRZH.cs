using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class ToolAssignZRZH : BaseTool
    {
        private IAppContext _context;
        private IEditForm _editForm;
        private RealEstateEditor _plugin;

        public ToolAssignZRZH(IAppContext context, RealEstateEditor plugin)
        {
            _plugin = plugin;
            _context = context;
            base._text = "自然幢号赋值";
            base._key = MenuKeys.AssignZRZH;
            base._icon = Resources.icon_zrzh;
            base._headerName = "tabZD";
            base._toolStripExName = "toolStripExZDCommon";
        }

        public override void OnClick()
        {
            _context.CurrentTool = this;
        }

        public override void Activiate()
        {
            IMap map = _context.Map as IMap;
            map.MapCursor = MapCursor.None;
            if ((_editForm == null) || _editForm.IsDisposed)
            {
                _editForm = new frmAssignZRZH(_context, _plugin);
                map.MouseUp += Map_MouseUp;
            }
            if (_editForm.Visible == false)
                _context.View.ShowChildView(_editForm as Form, false);

        }

        public override void Deactiviate()
        {
            if (_editForm != null && _editForm.Visible)
            {
                _editForm.ClearDrawing();
                _editForm.Visible = false;
                _editForm = null;
            }
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            _editForm.SetQueryPoint(dx, dy);
        }
    }
}