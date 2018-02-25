using System;
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
    public class CmdZoomCenter : BaseTool
    {
        private IAppContext _context;
        private bool _fireEvent = false;
        private CustomCursor cursor;
        public CmdZoomCenter(IAppContext context)
        {
            base._text = "ÖÐÐÄÆ½ÒÆ";
            base._key = MenuKeys.ZoomCenter;
            base._icon = Resources.img_zoomcenter;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
            _fireEvent = false;
            Cursor myCursor = new Cursor(base.GetType().Assembly.GetManifestResourceStream("VastGIS.Resources.Cursor.targetcenter.cur"));
            cursor = new CustomCursor(Guid.NewGuid(), myCursor);
        }

        public override void OnClick()
        {
            _context.Map.MapCursor = MapCursor.None;
            _context.CurrentTool = this;
        }

        public override void Activiate()
        {
            IMap map = _context.Map as IMap;
            map.CustomCursor = cursor;
            if (_fireEvent == false)
            {
                map.MouseUp += Map_MouseUp;
                _fireEvent = true;
            }
           

        }

        public override void Deactiviate()
        {
            IMap map = _context.Map as IMap;
            map.MouseUp -= Map_MouseUp;
            _fireEvent = false;
            map.SystemCursor = SystemCursor.MapDefault;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            //MessageBox.Show("Click:" + e.X.ToString() + "," + e.Y.ToString());
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
            IEnvelope env = _context.Map.Extents;
            env.MoveCenterTo(dx, dy);
            _context.Map.ZoomToExtents(env);
        }
    }
}