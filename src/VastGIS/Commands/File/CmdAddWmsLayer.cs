using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.Tiles.Views;

namespace VastGIS.Commands.File
{
    public class CmdAddWmsLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddWmsLayer(IAppContext context)
        {
            base._text = "Ìí¼ÓWMSÍ¼²ã";
            base._key = MenuKeys.AddWmsLayer;
            base._icon = Resources.img_wms_add24;
            _context = context;
        }

        public override void OnClick()
        {
            var model = new WmsCapabilitiesModel(_context.Repository);
            _context.Container.Run<WmsCapabilitiesPresenter, WmsCapabilitiesModel>(model);
        }
    }
}