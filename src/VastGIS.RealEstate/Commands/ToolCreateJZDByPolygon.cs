using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.EditSettings;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class ToolCreateJZDByPolygon:BaseTool
    {
        private IAppContext _context;
        private EditingCreateJZDByPolygon _editingForm;
        public ToolCreateJZDByPolygon(IAppContext context)
        {
            _context = context;
            base._text = "依据多边形创建界址点";
            base._key = MenuKeys.CreateJZDByPolygon;
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
            if (_editingForm == null)
            {
                _editingForm=new EditingCreateJZDByPolygon(_context);
                
            }
            _context.View.ShowChildView(_editingForm, false);
            IMap map = _context.Map as IMap;
            map.MapCursor=MapCursor.None;
            map.MouseUp += Map_MouseUp;
        }

        public override void Deactiviate()
        {
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
            ((IMap)_context.Map).MapCursor = MapCursor.Pan;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            _context.Map.PixelToProj(e.X,e.Y,out dx,out dy);
            _editingForm.SetQueryPoint(dx, dy);
        }

        public override void OnMouseUp(IMuteMap map, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString() + " " + e.Y.ToString());
        }
    }
}
