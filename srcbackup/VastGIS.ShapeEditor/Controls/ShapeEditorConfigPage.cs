﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.ShapeEditor.Properties;
using VastGIS.Shared;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Plugins.ShapeEditor.Controls
{
    public partial class ShapeEditorConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _service;

        public ShapeEditorConfigPage(IConfigService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _service = service;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        public string PageName
        {
            get { return "Shape Editor"; }
        }

        private void InitControls()
        {
            cboAngleFormat.AddItemsFromEnum<AngleFormat>();
            cboBearingType.AddItemsFromEnum<BearingType>();
            cboLengthUnits.AddItemsFromEnum<LengthDisplay>();
        }

        public void Initialize()
        {
            var config = _service.Config;

            cboAngleFormat.SetValue(config.ShapeEditorAngleFormat);
            cboBearingType.SetValue(config.ShapeEditorBearingType);
            cboLengthUnits.SetValue(config.ShapeEditorUnits);

            chkShowBearing.Checked = config.ShapeEditorShowBearing;
            chkShowLength.Checked = config.ShapeEditorShowLength;
            chkShowArea.Checked = config.ShapeEditorShowArea;

            udLengthPrecision.Value = config.ShapeEditorUnitPrecision;
            udBearingPrecision.Value = config.ShapeEditorBearingPrecision;

            chkShowPointLabels.Checked = config.ShapeEditorShowLabels;

            chkShowAttributesDialog.Checked = config.ShapeEditorShowAttributeDialog;
        }

        public void Save()
        {
            var config = _service.Config;

            config.ShapeEditorShowBearing = chkShowBearing.Checked;
            config.ShapeEditorShowLength = chkShowLength.Checked;
            config.ShapeEditorShowArea = chkShowArea.Checked;

            config.ShapeEditorAngleFormat = cboAngleFormat.GetValue<AngleFormat>();
            config.ShapeEditorBearingType = cboBearingType.GetValue<BearingType>();
            config.ShapeEditorUnits = cboLengthUnits.GetValue<LengthDisplay>();

            config.ShapeEditorUnitPrecision = (int)udLengthPrecision.Value;
            config.ShapeEditorBearingPrecision = (int)udBearingPrecision.Value;

            config.ShapeEditorShowLabels = chkShowPointLabels.Checked;

            config.ShapeEditorShowAttributeDialog = chkShowAttributesDialog.Checked;
        }

        public Bitmap Icon
        {
            get { return Resources.img_shape_editor32; }
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
            get { return "Settings of the interactive Shape editor"; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
