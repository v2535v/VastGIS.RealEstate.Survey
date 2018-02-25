using VastGIS.Api.Enums;
using VastGIS.Helpers;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Docking;

namespace VastGIS.Commands.View
{
    public class CmdShowCoordinates : BaseCommand
    {
        private IAppContext _context;
        public CmdShowCoordinates(IAppContext context)
        {
            base._text = "显示坐标";
            base._key = MenuKeys.ShowCoordinates;
            base._icon = null;
            _context = context;
        }

        public override void OnClick()
        {
            var config = AppConfig.Instance;
            AppConfig.Instance.ShowCoordinates = !AppConfig.Instance.ShowCoordinates;
            _context.Map.ApplyConfig(config);
            _context.Map.Redraw(RedrawType.SkipAllLayers);
        }
    }


    public class CmdShowLegend : BaseCommand
    {
        private IAppContext _context;
        public CmdShowLegend(IAppContext context)
        {
            base._text = "图例窗口";
            base._key = MenuKeys.ShowLegendControl;
            base._icon = Properties.Resources.img_layers32;
            base._headerName = "tabView";
            base._toolStripExName = "toolStripView";
            _context = context;
        }

        public override void OnClick()
        {
            //var config = AppConfig.Instance;
            //AppConfig.Instance.ShowCoordinates = !AppConfig.Instance.ShowCoordinates;
            //_context.Map.ApplyConfig(config);
            //_context.Map.Redraw(RedrawType.SkipAllLayers);
            DockPanelHelper.ShowPanel(_context,DockPanelKeys.Legend);
        }
    }
}