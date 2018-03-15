﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class ToolSelectFeatureByPoint:BaseTool
    {
        private IAppContext _context;
        private IEditForm _editForm;
        private RealEstateEditor _plugin;
        public ToolSelectFeatureByPoint(IAppContext context, RealEstateEditor plugin)
        {
            _plugin = plugin;
            _context = context;
            base._text = "选择要素";
            base._key = MenuKeys.SelectFeatureByPoint;
            base._icon = Resources.icon_select;
            base._headerName = "tabEdit";
            base._toolStripExName = "toolStripExEdit";
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
                _editForm = new frmSelectFeature(_context, _plugin);
                map.MouseUp += Map_MouseUp;
            }
            if (_editForm.Visible == false)
                _context.View.ShowChildView(_editForm as Form, false);

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
            ((IMap)_context.Map).MapCursor = MapCursor.Pan;
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            double dx = 0.0;
            double dy = 0.0;
            if ((_editForm == null) || _editForm.IsDisposed)
            {
                _editForm = new frmSelectFeature(_context, _plugin);
            }
            _context.Map.PixelToProj(e.X, e.Y, out dx, out dy);
                _editForm.SetQueryPoint(dx, dy);
        }
    }
}
