using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomInBox : BaseTool
    {
        private IAppContext _context;
        private int boxStep = -1;
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private int _layer=-1;
        private bool _fireEvent = false;
        private CustomCursor cursor = null;
        public CmdZoomInBox(IAppContext context)
        {
            base._text = "窗口放大";
            base._key = MenuKeys.ZoomInBox;
            base._icon = Resources.img_zoominbox;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
            _fireEvent = false;
            Cursor myCursor=new Cursor(base.GetType().Assembly.GetManifestResourceStream("VastGIS.Resources.Cursor.ZoomIn.cur"));
            cursor=new CustomCursor(Guid.NewGuid(), myCursor);
        }

        public override void OnClick()
        {
            boxStep = 0;
            _layer = -1;
            _context.Map.MapCursor = MapCursor.None;
            _context.Map.CustomCursor= cursor;
            _context.CurrentTool = this;
           
        }

        public override void Activiate()
        {
            IMap map = _context.Map as IMap;
            map.MapCursor = MapCursor.None;
            if (_fireEvent == false)
            {
                map.MouseUp += Map_MouseUp;
                map.MouseMove += Map_MouseMove;
                _fireEvent = true;
            }
            if(_layer<0)
            _layer=map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (boxStep < 1) return;
            double dx = 0.0;
            double dy = 0.0;
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            DrawingRectangle(x1, y1, dx, dy);
        }

        private void DrawingRectangle(double dx1, double dy1, double dx2, double dy2)
        {
            _context.Map.Drawing.RemoveLayer(_layer);
            _layer = _context.Map.Drawing.AddLayer(DrawReferenceList.SpatiallyReferencedList);
            double xx1 = Math.Min(dx1, dx2);
            double xx2 = Math.Max(dx1, dx2);
            double yy1 = Math.Min(dy1, dy2);
            double yy2 = Math.Max(dy1, dy2);
            _context.Map.Drawing.DrawLine(_layer,xx1,yy1,xx2,yy1,2,Color.Red);
            _context.Map.Drawing.DrawLine(_layer, xx2, yy1, xx2, yy2, 2, Color.Red);
            _context.Map.Drawing.DrawLine(_layer, xx2, yy2, xx1, yy2, 2, Color.Red);
            _context.Map.Drawing.DrawLine(_layer, xx1, yy2, xx1, yy1, 2, Color.Red);
        }

        public override void Deactiviate()
        {
            boxStep = -1;
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
            map.MouseMove -= Map_MouseMove;
            if (_layer >= 0)
            {
                map.Drawing.RemoveLayer(_layer);
                _layer = -1;
            }
            _fireEvent = false;
            map.SystemCursor = SystemCursor.MapDefault;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            if (boxStep < 0) return;
            double dx = 0.0;
            double dy = 0.0;
            //MessageBox.Show("Click:" + e.X.ToString() + "," + e.Y.ToString());
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            if (boxStep==0)
            {
                x1 = dx;
                y1 = dy;
                boxStep = 1;
                return;
            }

            double width = Math.Abs(x1 - dx);
            double height = Math.Abs(y1 - dy);
            if (width < 0.1 || height < 0.1) return;

            double xx1 = Math.Min(x1,dx);
            double xx2 = Math.Max(x1, dx);

            double yy1 = Math.Min(y1, dy);
            double yy2 = Math.Max(y1, dy);

            IEnvelope pEnv=new Envelope(xx1,xx2,yy1,yy2);
            _context.Map.ZoomToExtents(pEnv);
            boxStep = 0;
            _context.Map.Drawing.RemoveLayer(_layer);
            _layer = -1;
        }
    }
}