using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Configuration;
using VastGIS.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Services.Helpers;
using VastGIS.Shared;
using VastGIS.UI.Helpers;
using VastGIS.UI.Style;
using VastGIS.Views.Abstract;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace VastGIS.Views
{
    internal class ConfigPresenter: ComplexPresenter<IConfigView, ConfigCommand, ConfigViewModel>
    {
        private readonly IAppContext _context;
        private readonly IConfigService _configService;
        private readonly IStyleService _styleService;
        private readonly IPluginManager _pluginManger;
        private readonly IMuteMap _map;

        public ConfigPresenter( IAppContext context, IConfigView view, IConfigService configService, 
        IStyleService styleService, IPluginManager pluginManger, IMuteMap map)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (view == null) throw new ArgumentNullException("view");
            if (configService == null) throw new ArgumentNullException("configService");
            if (styleService == null) throw new ArgumentNullException("styleService");
            if (pluginManger == null) throw new ArgumentNullException("pluginManger");
            if (map == null) throw new ArgumentNullException("map");

            _context = context;
            _configService = configService;
            _styleService = styleService;
            _pluginManger = pluginManger;
            _map = map;

            view.PageShown += OnPageShown;
        }

        public override void RunCommand(ConfigCommand command)
        {
            switch (command)
            {
                case ConfigCommand.RestoreToolbars:
                    if (MessageService.Current.Ask("Do you want to restore default location of toolbars?"))
                    {
                        var view = _context.Container.Resolve<IMainView>();
                        var manager = view.MenuManager as MainFrameBarManager;
                        if (manager != null)
                        {
                            manager.RestoreLayout(MainView.SerializationKey, true);
                        }
                    }
                    break;
                case ConfigCommand.RestorePlugins:
                    RestorePlugins();
                    break;
                case ConfigCommand.Save:
                    ApplySettings();

                    bool result = _configService.SaveConfig();
                    if (result)
                    {
                        MessageService.Current.Info("Configuration was saved successfully.");
                    }
                    break;
                case ConfigCommand.SetDefaults:
                    if (MessageService.Current.Ask("Do you want to reset default value of all settings?"))
                    {
                        _configService.Config.SetDefaults();
                        foreach (var page in Model.Pages)
                        {
                            page.Initialize();
                        }
                    }

                    ApplySettings();

                    break;
                case ConfigCommand.OpenFolder:
                    string path = _configService.ConfigPath;
                    PathHelper.OpenFolderWithExplorer(path);
                    break;
            }
        }

        private void RestorePlugins()
        {
            if (!MessageService.Current.Ask("Do you want to restore default set of plugins and location of their panels?"))
            {
                return;
            }

            try
            {
                var guids = AppConfig.Instance.DefaultApplicationPlugins;
                _pluginManger.RestoreApplicationPlugins(guids, _context);
                Model.ReloadPage(ConfigPageType.Plugins);

                // restoring layout
                var view = _context.Container.Resolve<IMainView>();
                var manager = view.DockingManager as DockingManager;
                manager.RestoreLayout(MainView.SerializationKey, true);
            }
            catch (Exception ex)
            {
                Logger.Current.Error("Failed to restore dock panel layout.", ex);
            }
        }

        private void OnPageShown()
        {
            _styleService.ApplyStyle(View as Form);
        }

        private void ApplySettings()
        {
            foreach (var page in Model.Pages)
            {
                page.Save();
            }

            _map.ApplyConfig(_configService);
        }

        public override bool ViewOkClicked()
        {
            ApplySettings();
            _configService.SaveAll();
            return true;
        }
    }
}
