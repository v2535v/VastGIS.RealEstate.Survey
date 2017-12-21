using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;

namespace VastGIS.Commands.File
{
    public class CmdAddVectorLayer : BaseCommand
    {
        private IAppContext _context;
        public CmdAddVectorLayer(IAppContext context)
        {
            base._text = "添加矢量图层";
            base._key = MenuKeys.AddVectorLayer;
            base._icon = Resources.icon_layer_vector_add;
            _context = context;
        }

        public override void OnClick()
        {
            ILayerService _layerService = _context.Container.GetSingleton<ILayerService>();
            _layerService.AddLayer(DataSourceType.Vector);
        }
    }
}