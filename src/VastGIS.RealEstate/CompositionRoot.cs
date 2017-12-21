using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.RealEstate.Services;
using VastGIS.Plugins.Services;

namespace VastGIS.Plugins.RealEstate
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IRealEstateEditingService, RealEstateEditingService>();
            //    .RegisterSingleton<ILayerEditingService, LayerEditingService>()
            //    .RegisterService<ContextMenuView>()
            //    .RegisterSingleton<ContextMenuPresenter>()
            //    .RegisterService<IAttributeView, AttributeView>();
        }
    }
}


