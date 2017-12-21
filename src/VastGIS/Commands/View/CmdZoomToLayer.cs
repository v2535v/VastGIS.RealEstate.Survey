using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomToLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomToLayer(IAppContext context)
        {
            base._text = "全图";
            base._key = MenuKeys.ZoomToLayer;
            base._icon = Resources.icon_zoom_to_layer;
            _context = context;
        }

        public override void OnClick()
        {
            if(_context.Legend!=null)
                _context.Map.ZoomToLayer(_context.Legend.SelectedLayerHandle);
        }
    }
}