using VastGIS.Plugins.Identifier.Enums;
using VastGIS.Plugins.Identifier.Views;
using VastGIS.Plugins.Mvp;
using VastGIS.Shared;

namespace VastGIS.Plugins.Identifier
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            EnumHelper.RegisterConverter(new IdentifierModeConverter());

            container.RegisterService<IIdentifierView, IdentifierDockPanel>()
            .RegisterSingleton<IdentifierPresenter>();
        }
    }
}
