using System.Collections.Generic;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;

using VastGIS.Plugins.RealEstate.Menu;

namespace VastGIS.Plugins.RealEstate
{
    [MapWindowPlugin(loadOnStartUp: true)]
    public class RealEstateEditor : BasePlugin
    {
        private IAppContext _context;
        private MapListener _mapListener;
        private MenuGenerator _menuGenerator;
        private MenuListener _menuListener;
        private ProjectListener _projectListener;
        // private MenuUpdater _menuUpdater;
        private List<ICommand> _commands;

        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }

        public override void Initialize(IAppContext context)
        {
            _context = context;

            var container = context.Container;
            _commands = new List<ICommand>();
            _mapListener = container.GetInstance<MapListener>();
            _menuGenerator = container.GetInstance<MenuGenerator>();
            _menuListener = container.GetInstance<MenuListener>();
            _projectListener = container.GetInstance<ProjectListener>();
            // _menuUpdater = container.GetInstance<MenuUpdater>();
            _commands.AddRange(_menuGenerator.MenuCommands.GetCommands());
        }

        public override List<ICommand> Commands { get { return _commands; } }

        public MapListener MapListener
        {
            get { return _mapListener; }
            set { _mapListener = value; }
        }

        //public override IEnumerable<IConfigPage> ConfigPages
        //{
        //    get { yield return _context.Container.GetInstance<RealEstateEditorConfigPage>(); }
        //}
    }
}
