﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Services.Config;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Configuration
{
    public partial class MeasuringConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _service;

        public MeasuringConfigPage(IConfigService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _service = service;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        public string PageName
        {
            get { return "Measuring"; }
        }

        private void InitControls()
        {
            cboAngleFormat.AddItemsFromEnum<AngleFormat>();
            cboBearingType.AddItemsFromEnum<BearingType>();
            cboLengthUnits.AddItemsFromEnum<LengthDisplay>();
            cboAreaUnits.AddItemsFromEnum<AreaDisplay>();
        }

        public void Initialize()
        {
            var config = _service.Config;

            cboAngleFormat.SetValue(config.MeasuringAngleFormat);
            cboBearingType.SetValue(config.MeasuringBearingType);
            cboLengthUnits.SetValue(config.MeasuringLengthUnits);
            cboAreaUnits.SetValue(config.MeasuringAreaUnits);

            chkShowBearing.Checked = config.MeasuringShowBearing;
            chkShowLength.Checked = config.MeasuringShowLength;
            chkShowTotalLength.Checked = config.MeasuringShowTotalLength;

            udLengthPrecision.Value = config.MeasuringLengthPrecision;
            udBearingPrecision.Value = config.MeasuringAnglePrecision;
            udAreaPrecision.Value = config.MeasuringAreaPrecision;

            chkShowPoints.Checked = config.MeasuringPointsVisible;
            chkShowPointLabels.Checked = config.MeasuringPointLabelsVisible;

            clpFillColor.Color = config.MeasuringFillColor;
            clpLineColor.Color = config.MeasuringLineColor;

            cboLineStyle.SelectedIndex = (int)config.MeasuringLineStyle;
            cboLineWidth.SelectedIndex = config.MeasuringLineWidth - 1;

            fillTransparency.Value = config.MeasuringFillTransparency;
        }

        public void Save()
        {
            var config = _service.Config;

            config.MeasuringShowBearing = chkShowBearing.Checked;
            config.MeasuringShowLength = chkShowLength.Checked;
            config.MeasuringShowTotalLength = chkShowTotalLength.Checked;

            config.MeasuringAngleFormat = cboAngleFormat.GetValue<AngleFormat>();
            config.MeasuringBearingType = cboBearingType.GetValue<BearingType>();
            config.MeasuringLengthUnits = cboLengthUnits.GetValue<LengthDisplay>();
            config.MeasuringAreaUnits = cboAreaUnits.GetValue<AreaDisplay>();

            config.MeasuringLengthPrecision = (int)udLengthPrecision.Value;
            config.MeasuringAnglePrecision = (int)udBearingPrecision.Value;
            config.MeasuringAreaPrecision = (int)udAreaPrecision.Value;

            config.MeasuringPointsVisible = chkShowPoints.Checked;
            config.MeasuringPointLabelsVisible = chkShowPointLabels.Checked;

            config.MeasuringFillColor = clpFillColor.Color;
            config.MeasuringLineColor = clpLineColor.Color;
            config.MeasuringFillTransparency = fillTransparency.Value;

            config.MeasuringLineWidth = cboLineWidth.SelectedIndex + 1;
            config.MeasuringLineStyle = (DashStyle)cboLineStyle.SelectedIndex;
        }

        public Bitmap Icon
        {
            get { return Resources.img_measure32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.Tools; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Measuring; }
        }

        public string Description
        {
            get { return "Properties of the tools that measure distance and area on the map"; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
