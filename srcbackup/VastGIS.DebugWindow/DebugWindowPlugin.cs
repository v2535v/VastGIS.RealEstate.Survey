// -------------------------------------------------------------------------------------------
// <copyright file="DebugWindowPlugin.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.DebugWindow.Menu;
using VastGIS.Plugins.DebugWindow.Services;
using VastGIS.Plugins.DebugWindow.Views;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mef;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.DebugWindow
{
    /// <summary>
    /// The debug window plugin.
    /// </summary>
    [MapWindowPlugin(loadOnStartUp: true)]
    public class DebugWindowPlugin : BasePlugin
    {
        private IAppContext _context;
        private DockPanelService _dockPanelService;
        private DebugPresenter _presenter;
        private StatusBarListener _statusBarListener;

        /// <summary>
        /// The initialize method, called when the plug-in is loaded
        /// </summary>
        public override void Initialize(IAppContext context)
        {
            _context = context;

            _presenter = context.Container.GetInstance<DebugPresenter>();
            _dockPanelService = context.Container.GetInstance<DockPanelService>();
            _statusBarListener = context.Container.GetInstance<StatusBarListener>();
        }

        /// <summary>
        /// Set up container for dependency injection:
        /// </summary>
        protected override void RegisterServices(IApplicationContainer container)
        {
            CompositionRoot.Compose(container);
        }
    }
}