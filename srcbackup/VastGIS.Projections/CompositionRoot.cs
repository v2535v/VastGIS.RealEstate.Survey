using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Projections.Services;
using VastGIS.Projections.Services.Abstract;
using VastGIS.Projections.Views;
using VastGIS.Projections.Views.Abstract;

namespace VastGIS.Projections
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IProjectionDatabase, ProjectionDatabase>()
                .RegisterService<IReprojectingService, ReprojectingService>()
                .RegisterService<IProjectionMismatchService, ProjectionMismatchService>()
                .RegisterView<IProjectionMismatchView, ProjectionMismatchView>()
                .RegisterView<IProjectionInfoView, ProjectionInfoView>();
        }
    }
}
