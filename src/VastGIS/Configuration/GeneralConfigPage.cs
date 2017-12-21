using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Helpers;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Services.Config;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Configuration
{
    public partial class GeneralConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public GeneralConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");
            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private void InitControls()
        {
            cboSymbologyStorage.AddItemsFromEnum<SymbologyStorage>();
        }

        public void Initialize()
        {
            var config = _configService.Config;
            chkLoadLastProject.Checked = config.LoadLastProject;
            chkLoadSymbology.Checked = config.LoadSymbology;
            chkShowWelcomeDialog.Checked = config.ShowWelcomeDialog;
            cboSymbologyStorage.SetValue(config.SymbolobyStorage);
            chkShowPluginInToolTip.Checked = config.ShowPluginInToolTip;
            chkShowMenuToolTips.Checked = config.ShowMenuToolTips;
            chkDynamicVisibilityWarnings.Checked = config.DisplayDynamicVisibilityWarnings;
            chkLocalDocumentation.Checked = config.LocalDocumentation;
            chkNewVersion.Checked = config.UpdaterCheckNewVersion;
            chkLegendExpanded.Checked = config.LegendExpandLayersOnAdding;
        }

        public string PageName
        {
            get { return "General"; }
        }

        public void Save()
        {
            var config = _configService.Config;
            config.LoadLastProject = chkLoadLastProject.Checked;
            config.LoadSymbology = chkLoadSymbology.Checked;
            config.ShowWelcomeDialog = chkShowWelcomeDialog.Checked;
            config.ShowPluginInToolTip = chkShowPluginInToolTip.Checked;
            config.ShowMenuToolTips = chkShowMenuToolTips.Checked;
            config.DisplayDynamicVisibilityWarnings = chkDynamicVisibilityWarnings.Checked;
            config.SymbolobyStorage = cboSymbologyStorage.GetValue<SymbologyStorage>();
            config.LocalDocumentation = chkLocalDocumentation.Checked;
            config.UpdaterCheckNewVersion = chkNewVersion.Checked;
            config.LegendExpandLayersOnAdding = chkLegendExpanded.Checked;
        }

        public Bitmap Icon
        {
            get { return Resources.img_component32; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.General; }
        }

        public string Description
        {
            get { return "Here is a description of general settings."; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
