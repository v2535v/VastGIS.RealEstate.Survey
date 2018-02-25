// -------------------------------------------------------------------------------------------
// <copyright file="AppContext.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;

using VastGIS.Services.Serialization;
using VastGIS.Shared;
using VastGIS.UI.Docking;
using VastGIS.UI.Forms;
using VastGIS.UI.Menu;
using VastGIS.UI.Style;
using ICommand = VastGIS.Plugins.Interfaces.ICommand;

namespace VastGIS
{
    /// <summary>
    /// Central class storing all the resource avaialable for plugins.
    /// </summary>
    public class AppContext : ISimpleAppContext
    {
        private readonly IApplicationContainer _container;
        private readonly IStyleService _styleService;
        private IConfigService _configService;
        private IMainView _mainView;
        private IProjectService _project;
        private List<ICommand> _commands;

        public AppContext(
            IApplicationContainer container,
            IStyleService styleService)
        {
            Logger.Current.Trace("In AppContext");
            if (container == null) throw new ArgumentNullException("container");
            if (styleService == null) throw new ArgumentNullException("styleService");
            

            _container = container;
           
            _styleService = styleService;
         
            _commands=new List<ICommand>();
        }

        public IBroadcasterService Broadcaster { get; private set; }

        public IApplicationContainer Container
        {
            get { return _container; }
        }
       
        public IAppView View { get; private set; }
       
        public IStatusBar StatusBar { get; private set; }

        public IMenu Menu { get; private set; }

        public IToolbarCollection Toolbars { get; private set; }

        public IDockPanelCollection DockPanels { get; private set; }

        public IRepository Repository { get; private set; }

        public SynchronizationContext SynchronizationContext { get; private set; }

        public IRibbonMenu RibbonMenu
        {
            get;
            private set;
        }

     

        public List<ICommand> Commands
        {
            get { return _commands; }
            set { _commands = value; }
        }

        public bool Initialized { get; private set; }

     
        public IPluginManager PluginManager { get; private set; }

        public Control GetDockPanelObject(DefaultDockPanel panel)
        {
            switch (panel)
            {
                //case DefaultDockPanel.Legend:
                //    return _legendPresenter.Legend as Control;
             
                default:
                    throw new ArgumentOutOfRangeException("panel");
            }
        }

        public void Close()
        {
            _mainView.Close();
        }

        /// <summary>
        /// Sets all the necessary references from the main view. 
        /// </summary>
        /// <remarks>We don't use contructor injection here since most of other services use this one as a parameter.
        /// Perhaps property injection can be used.</remarks>
        internal void Init(
            IMainView mainView,
            IConfigService configService)
        {
            Logger.Current.Trace("Start AppContext.Init()");
            if (mainView == null) throw new ArgumentNullException("mainView");
            // it's expected here that we are on the UI thread
            SynchronizationContext = SynchronizationContext.Current;

            PluginManager = _container.GetSingleton<IPluginManager>();
            Broadcaster = _container.GetSingleton<IBroadcasterService>();
         
            _mainView = mainView;
            View = new AppView(mainView, _styleService);
          _configService = configService;
          
                DockPanels = new DockPanelCollection(mainView.DockingManager, mainView as Form, Broadcaster,
                    _styleService);
                //创建Ribbon主菜单
                RibbonMenu = MenuFactory.CreateRibbonMenu(mainView.RibbonControlAdv);

          
            StatusBar = MenuFactory.CreateStatusBar(mainView.StatusBar, PluginIdentity.Default);

      
            //this.InitDocking();

            Initialized = true;
            Logger.Current.Trace("End AppContext.Init()");
        }

        internal void InitPlugins(IConfigService configService)
        {
            var pluginManager = PluginManager;
            pluginManager.PluginUnloaded += ManagerPluginUnloaded;
            pluginManager.AssemblePlugins();

            var guids = configService.Config.ApplicationPlugins;
            if (guids != null)
            {
                PluginManager.RestoreApplicationPlugins(guids, this);
            }
        }

        private void ManagerPluginUnloaded(object sender, PluginEventArgs e)
        {
            if(Toolbars!=null)
            Toolbars.RemoveItemsForPlugin(e.Identity);
            DockPanels.RemoveItemsForPlugin(e.Identity);
            StatusBar.RemoveItemsForPlugin(e.Identity);
        }
    }
}