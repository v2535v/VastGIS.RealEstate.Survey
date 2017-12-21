using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.View
{
    public class CmdZoomToSelected : BaseCommand
    {
        private IAppContext _context;
        public CmdZoomToSelected(IAppContext context)
        {
            base._text = "放大到选择集";
            base._key = MenuKeys.ZoomToSelected;
            base._icon = Resources.icon_zoom_to_selection;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.ZoomToSelected();
        }
    }
}