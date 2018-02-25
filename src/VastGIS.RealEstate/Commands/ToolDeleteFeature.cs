// -------------------------------------------------------------------------------------------
// <copyright file="ToolDeleteFeature.cs" company="VastGIS">
//  VastGIS OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------

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
    public class ToolDeleteFeature : BaseTool
    {
        private readonly IAppContext _context;
        private RealEstateEditor _plugin;
        private IEditForm _editForm;

        public ToolDeleteFeature(IAppContext context,RealEstateEditor plugin)
        {
            _context = context;
            _text = "要素删除";
            _key = MenuKeys.DeleteFeature;
            _icon = Resources.FeatureDelete;
            _headerName = "tabZD";
            _toolStripExName = "toolStripExZDCommon";
            _plugin = plugin;
        }

        public override void Activiate()
        {
            IMap map = _context.Map as IMap;
            map.MapCursor = MapCursor.None;
            if ((_editForm == null) || ((Form)_editForm).IsDisposed)
            {
                _editForm = new frmDeleteFeature2(_context,_plugin);

                map.MouseUp += Map_MouseUp;
            }
            if (_editForm.Visible == false)
                _context.View.ShowChildView((Form)_editForm, false);

        }

        public override void Deactiviate()
        {
            if (_editForm != null && _editForm.Visible)
            {
                _editForm.Visible = false;
                _editForm = null;
            }
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
        }

        public override void OnClick()
        {
            _context.CurrentTool = this;
        }

        public override void OnMouseUp(IMuteMap map, MouseEventArgs e)
        {
            MessageBox.Show(e.X + " " + e.Y);
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