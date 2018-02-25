using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Services.Concrete;
using VastGIS.Services.Helpers;
using VastGIS.Services.Serialization;
using VastGIS.Services.Views;
using VastGIS.Services.Views.Abstract;
using VastGIS.Shared;
using VastGIS.Shared.Log;

namespace VastGIS.Services
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterService<IFileDialogService, FileDialogService>()
                .RegisterService<IMessageService, MessageService>() // FlexibleMessageService
                .RegisterSingleton<ILayerService, LayerService>()
                .RegisterSingleton<IGeoLocationService, NominatimGeoLocationService>()
                .RegisterSingleton<ILoggingService, LoggingService>()
                .RegisterSingleton<ISelectLayerService, SelectLayerService>()
                .RegisterSingleton<IProjectService, ProjectService>()
                .RegisterService<ICreateLayerView, CreateLayerView>()
                .RegisterService<ImageSerializationService>()
                .RegisterService<ProjectLoaderLegacy>()
                .RegisterSingleton<ITempFileService, TempFileService>()
                .RegisterSingleton<IConfigService, ConfigService>()
                .RegisterSingleton<IProjectLoader, ProjectLoader>()
                .RegisterView<IMissingLayersView, MissingLayersView>()
                .RegisterView<ISelectLayerView, SelectLayerView>();

            EnumHelper.RegisterConverter(new SelectionOperationConverter());
            EnumHelper.RegisterConverter(new AreaUnitsConverter());
            EnumHelper.RegisterConverter(new LogLevelConverter());
            EnumHelper.RegisterConverter(new GeometryTypeConverter());
            EnumHelper.RegisterConverter(new SaveResultConverter());
            EnumHelper.RegisterConverter(new TileProviderConverter());
            EnumHelper.RegisterConverter(new InterpolationTypeConverter());
            EnumHelper.RegisterConverter(new RasterOverviewSamplingConverter());
            EnumHelper.RegisterConverter(new RasterOverviewTypeConverter());
            EnumHelper.RegisterConverter(new DynamicVisiblityModeConverter());
        }
    }
}
