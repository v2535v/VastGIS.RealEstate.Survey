using VastGIS.Plugins.ImageRegistration.Services;
using VastGIS.Plugins.ImageRegistration.Views;
using VastGIS.Plugins.ImageRegistration.Views.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.ImageRegistration
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<IImageRegistrationView, ImageRegistrationView>()
                     .RegisterService<ILeastSquaresSolver, GaussEliminationSolver>();
        }
    }
}
