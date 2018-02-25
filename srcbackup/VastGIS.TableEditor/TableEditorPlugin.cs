using System;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Menu;
using VastGIS.Plugins.TableEditor.Services;

namespace VastGIS.Plugins.TableEditor
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class TableEditorPlugin: BasePlugin
    {
        private IAppContext _context;
        private MenuListener _menuListener;
        private MapListener _mapListener;
        private MenuGenerator _menuGenerator;
        private ProjectListener _projectListener;
        private DockPanelService _dockPanelService;

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override void Initialize(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            _menuGenerator = _context.Container.GetInstance<MenuGenerator>();
            _menuListener = _context.Container.GetSingleton<MenuListener>();
            _mapListener = _context.Container.GetSingleton<MapListener>();
            _projectListener = _context.Container.GetSingleton<ProjectListener>();
            _dockPanelService = _context.Container.GetInstance<DockPanelService>();
        }
    }
}
