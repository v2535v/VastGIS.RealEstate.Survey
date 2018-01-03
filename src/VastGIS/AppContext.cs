// -------------------------------------------------------------------------------------------
// <copyright file="AppContext.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Controls;
using VastGIS.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Interfaces.Projections;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Projections.Helpers;
using VastGIS.RealEstate.Api;
using VastGIS.RealEstate.Api.Concrete;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.Services.Serialization;
using VastGIS.Shared;
using VastGIS.Tools.Toolbox;
using VastGIS.UI.Docking;
using VastGIS.UI.Forms;
using VastGIS.UI.Menu;
using VastGIS.UI.Style;

namespace VastGIS
{
    /// <summary>
    /// Central class storing all the resource avaialable for plugins.
    /// </summary>
    public class AppContext : ISecureContext, IRealEstateContext
    {
        private readonly IApplicationContainer _container;
        private readonly IProjectionDatabase _projectionDatabase;
        private readonly IStyleService _styleService;
        private readonly ITaskCollection _tasks;
        private IConfigService _configService;

        private LegendPresenter _legendPresenter;
        private LocatorPresenter _locator;
        private IMainView _mainView;

        private IMap _map;
        private IProjectService _project;
        private ToolboxPresenter _toolboxPresenter;
        private IMapTool _currentTool;
        private List<ICommand> _commands;
       

        private IREDatabase _realEstateDatabase;
        private XmlProject _vastProject;

        public AppContext(
            IApplicationContainer container,
            IProjectionDatabase projectionDatabase,
            IStyleService styleService,
            ITaskCollection tasks)
        {
            Logger.Current.Trace("In AppContext");
            if (container == null) throw new ArgumentNullException("container");
            if (styleService == null) throw new ArgumentNullException("styleService");
            if (tasks == null) throw new ArgumentNullException("tasks");

            _container = container;
            _projectionDatabase = projectionDatabase;
            _styleService = styleService;
            _tasks = tasks;
            _commands = new List<ICommand>();
        }

        public IBroadcasterService Broadcaster { get; private set; }

        public IApplicationContainer Container
        {
            get { return _container; }
        }

        public IProject Project
        {
            get { return _project as IProject; }
        }

        public IAppView View { get; private set; }

        public IMuteMap Map
        {
            get { return _map; }
        }

        public IMuteLegend Legend
        {
            get { return _legendPresenter.Legend; }
        }

        public IStatusBar StatusBar { get; private set; }

        public IMenu Menu { get; private set; }

        public IToolbarCollection Toolbars { get; private set; }

        public ILayerCollection<ILayer> Layers
        {
            get { return _map.Layers; }
        }

        public IDockPanelCollection DockPanels { get; private set; }

        public IProjectionDatabase Projections
        {
            get { return _projectionDatabase; }
        }

        public AppConfig Config
        {
            get { return _configService.Config; }
        }

        public ITaskCollection Tasks
        {
            get { return _tasks; }
        }

        public IRepository Repository { get; private set; }

        public SynchronizationContext SynchronizationContext { get; private set; }

        public void SetMapProjection(ISpatialReference projection)
        {
            this.SetProjection(projection);
            Map.Redraw();
            View.Update();
        }

        public MainViewType ViewType
        {
            get { return _mainView.ViewType; }
        }

        public IRibbonMenu RibbonMenu { get; private set; }

        public IMapTool CurrentTool
        {
            get { return _currentTool; }
            set
            {
                if (_currentTool != null)
                {
                    _currentTool.Deactiviate();
                }
                _currentTool = value;
                _currentTool?.Activiate();
            }
        }

        public bool SetCurrentTool(IMapTool tool)
        {
            if (_currentTool != null)
            {
                _currentTool.Deactiviate();
            }
            _currentTool = tool;
            _currentTool.Activiate();
            _map.MapCursor = tool.MapCursor;
            return true;
        }

        public List<ICommand> Commands
        {
            get { return _commands; }
            set { _commands = value; }
        }

        public bool Initialized { get; private set; }

        public ILocator Locator
        {
            get { return _locator; }
        }

        public IToolbox Toolbox
        {
            get { return _toolboxPresenter.View; }
        }

        public IPluginManager PluginManager { get; private set; }

        public Control GetDockPanelObject(DefaultDockPanel panel)
        {
            switch (panel)
            {
                case DefaultDockPanel.Legend: return _legendPresenter.Legend as Control;
                case DefaultDockPanel.Toolbox: return _toolboxPresenter.View;
                case DefaultDockPanel.Locator: return _locator != null ? _locator.GetInternalObject() : null;
                default: throw new ArgumentOutOfRangeException("panel");
            }
        }

        public XmlProject VastProject
        {
            get { return _vastProject; }
            set
            {
                _vastProject = value;
                string parentPath = Path.GetDirectoryName(_project.Filename);
                string dbPath = Path.Combine(parentPath, @"Database\redatabase.db");
                _realEstateDatabase = new ReDatabase(dbPath);
                _realEstateDatabase.CheckDatabase();
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
            IProjectService project,
            IConfigService configService,
            LegendPresenter legendPresenter,
            ToolboxPresenter toolboxPresenter,
            IRepository repository)
        {
            Logger.Current.Trace("Start AppContext.Init()");
            if (mainView == null) throw new ArgumentNullException("mainView");
            if (project == null) throw new ArgumentNullException("project");

            if (mainView.ViewType == MainViewType.Normal)
            {
                if (legendPresenter == null) throw new ArgumentNullException("legendPresenter");
                if (toolboxPresenter == null) throw new ArgumentNullException("toolboxPresenter");
                _toolboxPresenter = toolboxPresenter;
                _legendPresenter = legendPresenter;
                var legend = _legendPresenter.Legend;
                mainView.Map.Legend = legend;
                legend.Map = mainView.Map;
            }
            else
            {
                _toolboxPresenter = toolboxPresenter;
                _legendPresenter = legendPresenter;
                var legend = _legendPresenter.Legend;
                mainView.Map.Legend = legend;
                legend.Map = mainView.Map;
            }

            //获得当前的Ogr的编码
            string defaultEncoding = OSGeo.GDAL.Gdal.GetConfigOption("SHAPE_ENCODING", "");
            OSGeo.GDAL.Gdal.GetConfigOption("SHAPE_ENCODING", "gb2312");
            // it's expected here that we are on the UI thread
            SynchronizationContext = SynchronizationContext.Current;

            PluginManager = _container.GetSingleton<IPluginManager>();
            Broadcaster = _container.GetSingleton<IBroadcasterService>();
            _container.RegisterInstance<IMuteMap>(mainView.Map);

            _mainView = mainView;
            View = new AppView(mainView, _styleService);
            _project = project;
            _map = mainView.Map;
            _configService = configService;
            Repository = repository;

            if (mainView.ViewType == MainViewType.Normal)
            {
                Legend.Lock();
                DockPanels = new DockPanelCollection(mainView.DockingManager, mainView as Form, Broadcaster,
                    _styleService);
                Menu = MenuFactory.CreateMainMenu(mainView.MenuManager);
                Toolbars = MenuFactory.CreateMainToolbars(mainView.MenuManager);
            }
            else
            {
                Legend.Lock();
                DockPanels = new DockPanelCollection(mainView.DockingManager, mainView as Form, Broadcaster,
                    _styleService);
                //创建Ribbon主菜单
                RibbonMenu = MenuFactory.CreateRibbonMenu(mainView.RibbonControlAdv);
            }
            StatusBar = MenuFactory.CreateStatusBar(mainView.StatusBar, PluginIdentity.Default);
            _projectionDatabase.ReadFromExecutablePath(Application.ExecutablePath);
            Repository.Initialize(this);

            // comment this line to prevent locator loading            
            // may be useful for ocx debugging to not create additional 
            // instance of map
            _locator = new LocatorPresenter(_map);
            this.InitDocking();
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
            if (Toolbars != null) Toolbars.RemoveItemsForPlugin(e.Identity);
            if (ViewType == MainViewType.Normal) Menu.RemoveItemsForPlugin(e.Identity);
            else
            {
            }
            DockPanels.RemoveItemsForPlugin(e.Identity);
            if (Toolbars != null) Toolbox.RemoveItemsForPlugin(e.Identity);
            StatusBar.RemoveItemsForPlugin(e.Identity);
        }

        public IREDatabase RealEstateDatabase
        {
            get
            {
                if (_realEstateDatabase == null) CheckDatabase();
                return _realEstateDatabase;
            }
            set { _realEstateDatabase = value; }
        }

        public bool CheckDatabase()
        {
            string parentPath = Path.GetDirectoryName(_project.Filename);
            string dbPath = Path.Combine(parentPath, @"Database\redatabase.db");
            _realEstateDatabase = new ReDatabase(dbPath);
            _realEstateDatabase.CheckDatabase();
            return true;
        }
    }
}