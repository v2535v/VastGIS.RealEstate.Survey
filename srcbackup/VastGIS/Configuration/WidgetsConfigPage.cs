﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Services.Config;
using VastGIS.Shared;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Configuration
{
    public partial class WidgetsConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public WidgetsConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");
            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private void InitControls()
        {
            cboScalebarUnits.AddItemsFromEnum<ScalebarUnits>();
            cboZoombarVerbosity.AddItemsFromEnum<ZoomBarVerbosity>();
            cboAngleFormat.AddItemsFromEnum<AngleFormat>();

            var list = new List<CoordinatesDisplay>()
            {
                CoordinatesDisplay.Auto,
                CoordinatesDisplay.Degrees,
                CoordinatesDisplay.MapUnits
            };
            cboCoordinateDisplay.AddItemsFromEnum(list);
        }

        public void Initialize()
        {
            var config = _configService.Config;

            chkShowRedrawTime.Checked = config.ShowRedrawTime;
            chkShowScalebar.Checked = config.ShowScalebar;
            chkShowZoombar.Checked = config.ShowZoombar;
            chkShowCoordinates.Checked = config.ShowCoordinates;
            
            cboScalebarUnits.SetValue(config.ScalebarUnits);
            cboZoombarVerbosity.SetValue(config.ZoomBarVerbosity);
            cboCoordinateDisplay.SetValue(config.CoordinatesDisplay);
            cboAngleFormat.SetValue(config.CoordinateAngleFormat);

            udCoordinatePrecision.SetValue(config.CoordinatePrecision);
        }

        public string PageName
        {
            get { return "View"; }
        }

        public void Save()
        {
            var config = _configService.Config;

            config.ShowRedrawTime = chkShowRedrawTime.Checked;
            config.ShowZoombar = chkShowZoombar.Checked;
            config.ShowScalebar = chkShowScalebar.Checked;
            config.ShowCoordinates = chkShowCoordinates.Checked;
            config.ScalebarUnits = cboScalebarUnits.GetValue<ScalebarUnits>();
            config.ZoomBarVerbosity = cboZoombarVerbosity.GetValue<ZoomBarVerbosity>();
            config.CoordinatesDisplay = cboCoordinateDisplay.GetValue<CoordinatesDisplay>();
            config.CoordinateAngleFormat = cboAngleFormat.GetValue<AngleFormat>();

            config.CoordinatePrecision = (int)udCoordinatePrecision.Value;
        }

        public Bitmap Icon
        {
            get { return Resources.img_eye32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.General; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Widgets; }
        }

        public string Description
        {
            get { return "Widgets and information that can be displayed on the map."; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
