using VastGIS.Controls;
using VastGIS.Menu;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Tiles.Views;
using VastGIS.Tiles.Views.Abstract;
using VastGIS.UI.Forms;
using VastGIS.UI.Helpers;
using VastGIS.Views;
using VastGIS.Views.Abstract;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace VastGIS
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IMainView, MainView>()
                .RegisterSingleton<IAppContext, AppContext>()
                .RegisterView<ISetProjectionView, SetProjectionView>()
                .RegisterView<ILegendGroupView, LegendGroupView>()
                .RegisterView<IMeasuringView, MeasuringView>()
                .RegisterView<IAboutView, AboutView>()
                .RegisterView<IWelcomeView, WelcomeView>()
                .RegisterView<IConfigView, ConfigView>()
                .RegisterView<IGeoLocationView, GeoLocationView>()
                .RegisterView<ICreatePyramidsView, CreatePyramidsView>()
                .RegisterView<ISpatialIndexView, SpatialIndexView>()
                .RegisterView<ISetScaleView, SetScaleView>()
                
                .RegisterSingleton<IAppView, AppView>()
                .RegisterInstance<IApplicationContainer>(container)
                .RegisterService<LegendPresenter>()
                .RegisterService<LegendDockPanel>()
                .RegisterService<ContextMenuView>()
                .RegisterService<ContextMenuPresenter>();
            
            Services.CompositionRoot.Compose(container);
            Plugins.CompositionRoot.Compose(container);
            Projections.CompositionRoot.Compose(container);
            UI.CompositionRoot.Compose(container);
            Data.CompositionRoot.Compose(container);
            Tools.CompositionRoot.Compose(container);
            Gdal.CompositionRoot.Compose(container);
            Attributes.CompositionRoot.Compose(container);
            Tiles.CompositionRoot.Compose(container);

            //增加
            Property.CompositionRoot.Compose(container);

            CommandBarHelper.InitMenuColors();

            GridEngineFactory.Factory = new AllowResizingIndividualRows();
        }
    }
}
