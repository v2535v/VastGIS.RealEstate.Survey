using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.ShapeEditor.Controls;
using VastGIS.Plugins.ShapeEditor.Menu;

namespace VastGIS.Plugins.ShapeEditor
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class ShapeEditor: BasePlugin
    {
        private IAppContext _context;
        private MapListener _mapListener;
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;
        private ProjectListener _projectListener;
        private MenuUpdater _menuUpdater;

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override void Initialize(IAppContext context)
        {
            _context = context;
            
            var container = context.Container;
            
            _mapListener = container.GetInstance<MapListener>();
            _menuGenerator = container.GetInstance<MenuGenerator>();
            _menuListener = container.GetInstance<MenuListener>();
            _projectListener = container.GetInstance<ProjectListener>();
            _menuUpdater = container.GetInstance<MenuUpdater>();
        }

        public override IEnumerable<IConfigPage> ConfigPages
        {
            get { yield return _context.Container.GetInstance<ShapeEditorConfigPage>(); }
        }
    }
}
