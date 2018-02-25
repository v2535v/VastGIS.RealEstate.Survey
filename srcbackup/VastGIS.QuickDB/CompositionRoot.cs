using VastGIS.QuickDB.Interface;
using VastGIS.QuickDB.Views;

namespace VastGIS.QuickDB
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<IMainView, MainView>()
                .RegisterSingleton<IAppContext, AppContext>()
                .RegisterSingleton<IAppView, AppView>()
                .RegisterInstance<IApplicationContainer>(container)
                ;
        }
    }
}