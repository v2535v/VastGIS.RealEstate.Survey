using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.ImageRegistration.Menu;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Tools.Helpers;

namespace VastGIS.Plugins.ImageRegistration
{
    [MapWindowPlugin()]
    public class ImageRegistrationPlugin: BasePlugin
    {
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;

        public override void Initialize(IAppContext context)
        {
            _menuGenerator = context.Container.GetInstance<MenuGenerator>();
            _menuListener = context.Container.GetInstance<MenuListener>();

            context.Toolbox.AddTools(GetType().Assembly.GetTools());
        }

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }
    }
}
