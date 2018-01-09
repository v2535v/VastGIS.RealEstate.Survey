using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.EditSettings;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class ToolCopyFeature : BaseTool
    {
        private IAppContext _context;
        private frmCopyFeature _copyForm;

        public ToolCopyFeature(IAppContext context)
        {
            _context = context;
            base._text = "要素拷贝";
            base._key = MenuKeys.CopyFeature;
            base._icon = Resources.LayerTool32;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
        }

        public override void OnClick()
        {
            _context.CurrentTool = this;

        }

        public override void Activiate()
        {
            if (_copyForm == null)
            {
                _copyForm = new frmCopyFeature(_context);

            }
            if(_copyForm.Visible==false)
                _context.View.ShowChildView(_copyForm, false);
            IMap map = _context.Map as IMap;
            map.MapCursor = MapCursor.None;
            map.MouseUp += Map_MouseUp;
        }

        public override void Deactiviate()
        {
            if (_copyForm != null) _copyForm.Visible = false;
           IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            _copyForm.SetQueryPoint(dx, dy);
        }

        public override void OnMouseUp(IMuteMap map, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + " " + e.Y.ToString());
        }
    }
}
