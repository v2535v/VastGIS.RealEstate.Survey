using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Repository.Services;
using VastGIS.Plugins.Repository.Views;

namespace VastGIS.Plugins.Repository
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class RepositoryPlugin: BasePlugin
    {
        private RepositoryPresenter _repositoryPresenter;
        private DockPanelService _dockPanelService;
        private LegendListener _legendListener;

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override void Initialize(IAppContext context)
        {
            _repositoryPresenter = context.Container.GetSingleton<RepositoryPresenter>();
            _dockPanelService = context.Container.GetInstance<DockPanelService>();
            _legendListener = context.Container.GetSingleton<LegendListener>();
        }
    }
}
