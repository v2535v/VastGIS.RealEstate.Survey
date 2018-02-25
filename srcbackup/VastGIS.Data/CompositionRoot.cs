using VastGIS.Api.Helpers;
using VastGIS.Data.Enums;
using VastGIS.Data.Repository;
using VastGIS.Data.Services;
using VastGIS.Data.Views;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Data
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<IAddConnectionView, AddConnectionView>()
                .RegisterView<IDriversView, DriversView>()
                .RegisterView<IGdalInfoView, GdalInfoView>()
                .RegisterSingleton<IRepository, DataRepository>()
                .RegisterService<IGeoDatabaseService, GeoDatabaseService>()
                .RegisterService<AddConnectionModel>()
                .RegisterService<IImportLayerView, ImportLayerView>()
                .RegisterService<IDatabaseLayersView, DatabaseLayersView>();

            EnumHelper.RegisterConverter(new RepositoryItemTypeConverter());
            EnumHelper.RegisterConverter(new DriverFilterConverter());
        }
    }
}
