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
    public partial class RasterConfigPage : ConfigPageBase, IConfigPage
    {
        private readonly IConfigService _configService;

        public RasterConfigPage(IConfigService configService)
        {
            if (configService == null) throw new ArgumentNullException("configService");
            _configService = configService;

            InitializeComponent();

            InitControls();

            Initialize();
        }

        private  void InitControls()
        {
            cboDownsampling.AddItemsFromEnum<InterpolationType>();
            cboUpsampling.AddItemsFromEnum<InterpolationType>();
            cboDefaultColorScheme.AddItemsFromEnum<PredefinedColors>();
            cboPyramidCompression.AddItemsFromEnum<TiffCompression>();
            cboPyramidsSampling.AddItemsFromEnum<RasterOverviewSampling>();
            
            chkCreateColorScheme.CheckedChanged += (s, e) => RefreshControls();
            chkRandomColorScheme.CheckedChanged += (s, e) => RefreshControls();
        }

        private void RefreshControls()
        {
            chkRandomColorScheme.Enabled = chkCreateColorScheme.Checked;
            cboDefaultColorScheme.Enabled = chkCreateColorScheme.Checked && !chkRandomColorScheme.Checked;
        }

        public void Initialize()
        {
            var config = _configService.Config;
            cboUpsampling.SetValue(config.RasterUpsamplingMode);
            cboDownsampling.SetValue(config.RasterDownsamplingMode);
            cboDefaultColorScheme.SetValue(config.GridDefaultColorScheme);
            cboPyramidCompression.SetValue(config.PyramidCompression);
            cboPyramidsSampling.SetValue(config.PyramidSampling);
            
            chkCreatePyramids.Checked = config.CreatePyramidsOnOpening;
            chkPyramidsDialog.Checked = config.ShowPyramidDialog;
            chkUseHistogram.Checked = config.GridUseHistogram;
            chkRandomColorScheme.Checked = config.GridRandomColorScheme;
            chkCreateColorScheme.Checked = !config.GridFavorGreyscale;

            RefreshControls();
        }

        public void Save()
        {
            var config = _configService.Config;

            config.RasterUpsamplingMode = cboUpsampling.GetValue<InterpolationType>();
            config.RasterDownsamplingMode = cboDownsampling.GetValue<InterpolationType>();
            config.GridDefaultColorScheme = cboDefaultColorScheme.GetValue<PredefinedColors>();
            config.PyramidCompression = cboPyramidCompression.GetValue<TiffCompression>();
            config.PyramidSampling = cboPyramidsSampling.GetValue<RasterOverviewSampling>();
            
            config.CreatePyramidsOnOpening = chkCreatePyramids.Checked;
            config.ShowPyramidDialog = chkPyramidsDialog.Checked;
            config.GridUseHistogram = chkUseHistogram.Checked;
            config.GridRandomColorScheme = chkRandomColorScheme.Checked;
            config.GridFavorGreyscale = !chkCreateColorScheme.Checked;
        }

        public string PageName
        {
            get { return "Raster"; }
        }

        public Bitmap Icon
        {
            get { return Resources.img_picture32; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.DataFormats; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Projections; }
        }

        public string Description
        {
            get { return "Defines default settings for raster display and opening."; }
        }

        public bool VariableHeight
        {
            get { return false; }
        }
    }
}
