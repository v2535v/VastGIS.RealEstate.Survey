using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdNewJZD:BaseTool
    {
        private IAppContext _context;

        private RealEstateEditor _plugin;
        //public CmdNewJZD(IAppContext context)
        //{
        //    base._key = "reNewJZD";
        //    base._text = "新建界址点";
        //    base._icon = Properties.Resources.LayerTool32;
        //    _context = context;
        //}

        public CmdNewJZD(IAppContext context, RealEstateEditor plugin)
        {
            base._key = "reNewJZD";
            base._text = "新建界址点";
            base._icon = Properties.Resources.LayerTool32;
            _context = context;
            _plugin = plugin;
            base._cursor=MapCursor.AddShape;
        }

        public override void OnClick()
        {
            //将该工具设置为当前工具
            _context.SetCurrentTool(this);
        }

        public override void Activiate()
        {
            //((IMap)_context.Map).MouseDown += CmdNewJZD_MouseDown;
            if (_plugin != null)
            {
                _plugin.MouseUp += OnMouseUp;
            }
        }

       

        public override void Deactiviate()
        {
         
            if (_plugin != null)
            {
                _plugin.MouseDown -= OnMouseDown;
            }
        }

        

        public override void OnMouseUp(Api.Interfaces.IMuteMap map, System.Windows.Forms.MouseEventArgs e)
        {
            double px = 0.0;
            double py = 0.0;
            map.PixelToProj(e.X,e.Y,out px,out py);
            MessageService.Current.Info("X="+px.ToString()+";Y="+py.ToString());
        }
    }
}
