// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   Manages the startup of the application and interaction with main view.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Controls;
using VastGIS.Helpers;
using VastGIS.Listeners;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Toolbox;

namespace VastGIS.Views
{
    /// <summary>
    /// Manages the startup of the application and interaction with main view.
    /// </summary>
    public class MainPresenter : BasePresenter<IMainView>
    {
        private readonly IConfigService _configService;
        private readonly IAppContext _context;
        private readonly LegendListener _legendListener;
        private readonly MainPluginListener _mainPluginListener;
        private readonly MapListener _mapListener;
        private readonly MenuGenerator _menuGenerator;
        private readonly MenuListener _menuListener;
        private readonly MenuUpdater _menuUpdater;
        private readonly IProjectService _projectService;
        private readonly StatusBarListener _statusBarListener;

        public MainPresenter(
            IAppContext context, 
            IMainView view, 
            IProjectService projectService, 
            IConfigService configService, 
            LegendPresenter legendPresenter, 
            ToolboxPresenter toolboxPresenter, 
            IRepository repository)
            : base(view)
        {
            Logger.Current.Trace("Start MainPresenter");
            if (view == null) throw new ArgumentNullException("view");
            if (projectService == null) throw new ArgumentNullException("projectService");
            if (configService == null) throw new ArgumentNullException("configService");
            if (repository == null) throw new ArgumentNullException("repository");

            // PM 2016-03-02 Added:
            //修改，依据界面类型来判断是否为一般形态还是Ribbon
            if (view.ViewType == MainViewType.Normal)
            {
                if (legendPresenter == null) throw new ArgumentNullException("legendPresenter");
                if (toolboxPresenter == null) throw new ArgumentNullException("toolboxPresenter");
            }

            _context = context;
            _projectService = projectService;
            _configService = configService;

            GlobalListeners.Attach(Logger.Current);

            view.Map.Lock();
            try
            {
                var appContext = context as AppContext;
                if (appContext == null)
                {
                    throw new InvalidCastException("Invalid type of IAppContext instance");
                }

                appContext.Init(view, projectService, configService, legendPresenter, toolboxPresenter, repository);

                view.Map.Initialize();
                view.Map.ApplyConfig(configService);
                

                view.ViewClosing += OnViewClosing;
                view.ViewUpdating += OnViewUpdating;
                view.BeforeShow += OnBeforeShow;

                var container = context.Container;
                _statusBarListener = container.GetSingleton<StatusBarListener>();
                _menuGenerator = container.GetSingleton<MenuGenerator>();
                _menuListener = container.GetSingleton<MenuListener>();
                _mapListener = container.GetSingleton<MapListener>();
                _mainPluginListener = container.GetSingleton<MainPluginListener>();
                
                _legendListener = container.GetSingleton<LegendListener>();
               

                _menuUpdater = new MenuUpdater(_context, PluginIdentity.Default);

                SplashView.Instance.ShowStatus("Loading plugins");
                appContext.InitPlugins(configService); // must be called after docking is initialized

                // this will display progress updates and debug window
                // file based-logger is already working
                Logger.Current.Init(appContext);
            }
            finally
            {
                view.Map.Unlock();
                context.Legend.Unlock();
            }

            View.AsForm.Shown += ViewShown;
            Logger.Current.Trace("End MainPresenter");
        }

        private void ViewShown(object sender, EventArgs e)
        {
            Application.DoEvents();

            LoadLastProject();
        }

        public override bool ViewOkClicked()
        {
            return true; // there is no ok button
        }

        private void LoadLastProject()
        {
            // for development only
            var config = _configService.Config;
            if (!config.LoadLastProject || !File.Exists(config.LastProjectPath))
            {
                return;
            }

            try
            {
                _projectService.Open(config.LastProjectPath, true);
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Error on project loading: <{0}>", ex, config.LastProjectPath);
            }
        }

        private void OnBeforeShow()
        {
            if (AppConfig.Instance.ShowWelcomeDialog)
            {
                _menuListener.RunCommand(MenuKeys.Welcome);
            }

            UpdaterHelper.GetLatestVersion();
        }

        private void OnViewClosing(object sender, CancelEventArgs e)
        {
            _configService.Config.LastProjectPath = _projectService.Filename;
            _configService.SaveAll();

            if (!_projectService.TryClose())
            {
                e.Cancel = true;
            }

            // Check if a new installer is still downloading:
            //if (AppConfig.Instance.UpdaterIsDownloading)
            //{
            //    if (
            //        MessageService.Current.Ask(
            //            "A new version of MapWindow is being downloaded, but hasn't finished yet. Do you want to wait for it? In the debug window a message will be added when the download is finished."))
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
            //}

            // Check if a new installer is downloaded and can be installed:
            //if (AppConfig.Instance.UpdaterHasNewInstaller)
            //{
            //    var filename = AppConfig.Instance.UpdaterInstallername;
            //    if (File.Exists(filename))
            //    {
            //        if (MessageService.Current.Ask("A new installer is downloaded do you want to install it now?"))
            //        {
            //            AppConfig.Instance.UpdaterHasNewInstaller = false;
            //            _configService.SaveAll();
            //            var myProcess = new Process { StartInfo = { UseShellExecute = false, FileName = filename, CreateNoWindow = true } };
            //            myProcess.Start();
            //        }
            //    }
            //}

            if (_context.Tasks.All(t => t.IsFinished))
            {
                return;
            }

            if (MessageService.Current.Ask("系统发现有未结束的任务正在运行，继续退出吗?"))
            {
                _context.Tasks.CancelAll();

                // TODO: think of the cleaner way to close it
                // All tasks are run by background threads so they won't obstruct the closing.
                // However if the task is within unmanaged code or rarely checks the cancellation token, 
                // it won't be cancelled, which may lead to undefined behavior.
                // Possible solution may include:
                // - waiting for cancelled notification (which may take long time);
                // - calling Thread.Abort (which is generally not recommended);
                // - probably the best choice is to make sure that all tasks check
                // cancellation often enough and wait for explicit notifications from them.

                // at least give them some time to finish, which will work for significant part of them
                Thread.Sleep(1000);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void OnViewUpdating(object sender, RenderedEventArgs e)
        {
            _menuUpdater.Update(e.Rendered);

            _statusBarListener.Update();

            var appContext = _context as AppContext;
            if (appContext != null)
            {
                appContext.Broadcaster.BroadcastEvent(p => p.ViewUpdating_, sender, e);
            }
        }
    }
}