﻿using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomNext : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomNext(IAppContext context)
        {
            base._text = "下一视图";
            base._key = MenuKeys.ZoomNext;
            base._icon = Resources.img_nextview;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
        }

        public override void OnClick()
        {
            _context.Map.ZoomToNext();
        }
    }
}