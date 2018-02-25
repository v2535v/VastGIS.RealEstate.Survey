using VastGIS.Data.Enums;
using VastGIS.Data.Repository;
using VastGIS.Data.Services;
using VastGIS.Data.Views;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Property.Services;
using VastGIS.Shared;

namespace VastGIS.Property
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterService<IBDCDatabaseService, BDCDatabaseService>();

        }
    }
}
