﻿// -------------------------------------------------------------------------------------------
// <copyright file="TilesConfigPage.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Data.Helpers;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.Shared;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Configuration
{
    /// <summary>
    /// UI for tiles configuration settings.
    /// </summary>
    public partial class TilesConfigPage : ConfigPageBase, IConfigPage
    {
        public const string TilesDatabaseFilter = "MapWinGIS tile cache (*.db3)|*.db3";
        private readonly IConfigService _configService;
        private readonly TileManager _tileManager;

        public TilesConfigPage(IConfigService configService, TileManager tileManager)
        {
            if (configService == null) throw new ArgumentNullException("configService");
            if (tileManager == null) throw new ArgumentNullException("tileManager");

            _configService = configService;
            _tileManager = tileManager;

            InitializeComponent();

            InitControls();

            Initialize();

            RefreshControls(null, null);
        }

        public string Description
        {
            get { return "Settings that control how data downloaded from TMS servers is cached for faster loading."; }
        }

        public Bitmap Icon
        {
            get { return Resources.img_tiles32; }
        }

        public string PageName
        {
            get { return "TMS"; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.DataFormats; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Tiles; }
        }

        /// <summary>
        /// Gets a value indicating whether the page height can be adjusted to fit the the parent.
        /// </summary>
        public bool VariableHeight
        {
            get { return false; }
        }

        public void Initialize()
        {
            var config = _configService.Config;

            chkUseDiskCache.Checked = config.TilesUseDiskCache;
            txtMaxDiskSize.DoubleValue = config.TilesMaxDiskSize;
            cboMaxAge.SetValue(config.TilesMaxDiskAge);
            txtDiskSize.Text = _tileManager.get_CacheSize(CacheType.Disk).ToString("f2");
            txtFilename.Text = _tileManager.DiskCacheFilename;
            chkUseProxy.Checked = config.TilesUseProxy;
            chkAutodetectProxy.Checked = config.TilesAutoDetectProxy;
            txtProxyAddress.Text = config.TilesProxyAddress;
            txtProxyPassword.Text = config.TilesProxyPassword;
            txtProxyUserName.Text = config.TilesProxyUserName;
            chkWmsCaching.Checked = config.WmsDiskCaching;
        }

        public void Save()
        {
            var config = _configService.Config;

            config.TilesUseDiskCache = chkUseDiskCache.Checked;
            config.TilesMaxDiskSize = txtMaxDiskSize.DoubleValue;
            config.TilesMaxDiskAge = cboMaxAge.GetValue<TilesMaxAge>();
            config.TilesDatabase = txtFilename.Text;
            config.TilesUseProxy = chkUseProxy.Checked;
            config.TilesAutoDetectProxy = chkAutodetectProxy.Checked;
            config.TilesProxyAddress = txtProxyAddress.Text;
            config.TilesProxyPassword = txtProxyPassword.Text;
            config.TilesProxyUserName = txtProxyUserName.Text;
            config.WmsDiskCaching = chkWmsCaching.Checked;
        }

        private void RefreshControls(object sender, EventArgs e)
        {
            txtProxyUserName.Enabled = chkUseProxy.Checked && !chkAutodetectProxy.Checked;
            txtProxyPassword.Enabled = chkUseProxy.Checked && !chkAutodetectProxy.Checked;
            txtProxyAddress.Enabled = chkUseProxy.Checked;
        }

        private void InitControls()
        {
            cboMaxAge.AddItemsFromEnum<TilesMaxAge>();
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            if (MessageService.Current.Ask("Do you want to clear the tile cache database?"))
            {
                _tileManager.ClearCache(CacheType.Disk);
            }
        }

        private void OnCreateClick(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog { Filter = TilesDatabaseFilter };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = dialog.FileName;
            }
        }

        private void OnFilenameChanged(object sender, EventArgs e)
        {
            string filename = txtFilename.Text;

            if (File.Exists(filename))
            {
                var info = new FileInfo(filename);
                double size = info.Length / (double)(0x1 << 20);
                txtDiskSize.Text = size.ToString("0.0");
            }
            else
            {
                txtDiskSize.Text = 0.ToString("0.0");
            }
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Filter = TilesDatabaseFilter };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (TileCacheHelper.ValidateDatabase(dialog.FileName))
                {
                    txtFilename.Text = dialog.FileName;
                }
            }
        }
    }
}