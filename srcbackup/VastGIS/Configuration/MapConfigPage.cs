﻿using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Helpers;
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
    public partial class MapConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public MapConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");

            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private void InitControls()
        {
            cboAnimationOnZooming.AddItemsFromEnum<AutoToggle>();
            cboInertiaOnPanning.AddItemsFromEnum<AutoToggle>();
            cboMapResizeBehavior.AddItemsFromEnum<ResizeBehavior>();
            
            cboZoomBoxStyle.AddItemsFromEnum<ZoomBoxStyle>();
            cboZoomBehavior.AddItemsFromEnum<ZoomBehavior>();
            cboMouseWheelDirection.AddItemsFromEnum<MouseWheelDirection>();
        }

        public void Initialize()
        {
            var config = _configService.Config;
            
            cboAnimationOnZooming.SetValue(config.AnimationOnZooming);
            cboMapResizeBehavior.SetValue(config.ResizeBehavior);
           
            cboZoomBoxStyle.SetValue(config.ZoomBoxStyle);
            cboInertiaOnPanning.SetValue(config.InnertiaOnPanning);
            cboZoomBehavior.SetValue(config.ZoomBehavior);
            cboMouseWheelDirection.SetValue(config.MouseWheelDirection);
            txtMouseTolerance.IntegerValue = config.MouseTolerance;

            chkReuseTileBuffer.Checked = config.ReuseTileBuffer;

            clpBackground.Color = config.MapBackgroundColor;
        }

        public string PageName
        {
            get { return "Map"; }
        }

        public void Save()
        {
            var config = _configService.Config;

            config.AnimationOnZooming = cboAnimationOnZooming.GetValue<AutoToggle>();
            config.ResizeBehavior = cboMapResizeBehavior.GetValue<ResizeBehavior>();
            
            config.ZoomBoxStyle = cboZoomBoxStyle.GetValue<ZoomBoxStyle>();
            config.InnertiaOnPanning = cboInertiaOnPanning.GetValue<AutoToggle>();
            config.ZoomBehavior = cboZoomBehavior.GetValue<ZoomBehavior>();
            config.MouseWheelDirection = cboMouseWheelDirection.GetValue<MouseWheelDirection>();

            config.ReuseTileBuffer = chkReuseTileBuffer.Checked;

            config.MapBackgroundColor = clpBackground.Color;
            config.MouseTolerance = Convert.ToInt32(txtMouseTolerance.IntegerValue);
        }

        public Bitmap Icon
        {
            get { return Resources.img_globe32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.General; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Map; }
        }

        public string Description
        {
            get { return "Settings that change appearance, behavior and widgets shown on the map."; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
