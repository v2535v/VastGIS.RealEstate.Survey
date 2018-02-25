﻿// -------------------------------------------------------------------------------------------
// <copyright file="DatabaseLayersView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Data.Model;
using VastGIS.Data.Views.Abstract;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.UI.Forms;
using VastGIS.UI.Helpers;

namespace VastGIS.Data.Views
{
    public partial class DatabaseLayersView : DatabaseLayersViewBase, IDatabaseLayersView
    {
        private readonly BindingList<VectorLayerGridAdapter> _layers = new BindingList<VectorLayerGridAdapter>();
        private SynchronizationContext _syncContext;

        public DatabaseLayersView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            Text = @"Database Layers: " + Model.Connection.Name;

            _syncContext = SynchronizationContext.Current;

            StartWait();

            InitGrid();

            LoadLayersAsync();
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle(true); }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public IEnumerable<VectorLayerGridAdapter> Layers
        {
            get { return _layers; }
        }

        private int GetIcon(VectorLayerGridAdapter info)
        {
            switch (info.GeometryType)
            {
                case GeometryType.Point:
                case GeometryType.MultiPoint:
                    return 0;
                case GeometryType.Polyline:
                    return 1;
                case GeometryType.Polygon:
                    return 2;
                case GeometryType.None:
                    return 3;
            }

            return -1;
        }

        private void InitGrid()
        {
            databaseLayersGrid1.DataSource = _layers;

            var style = databaseLayersGrid1.Adapter.GetColumnStyle(r => r.Name);
            style.ImageList = imageList1;
            style.ImageIndex = 0;

            databaseLayersGrid1.Adapter.SetColumnIcon(r => r.Name, GetIcon);
            databaseLayersGrid1.Adapter.HotTracking = true;
        }

        private void LoadLayers()
        {
            var enumerator = Model.Datasource.GetFastEnumerator();

            while (enumerator.MoveNext())
            {
                // TODO: right now it will list only the geometry type of the layer
                var layer = new VectorLayerGridAdapter(enumerator.Current);
                _syncContext.Post(o =>
                    {
                        _layers.Add(o as VectorLayerGridAdapter);
                        databaseLayersGrid1.AdjustColumnWidths();
                    }, layer);
            }
        }

        private void LoadLayersAsync()
        {
            Task<bool>.Factory.StartNew(() =>
                {
                    if (Model.Datasource.Open(Model.Connection.ConnectionString))
                    {
                        LoadLayers();
                        return true;
                    }
                    const string msg = "Failed to open database connection.";
                    Logger.Current.Warn(msg + ": " + Model.Datasource.GdalLastErrorMsg);
                    MessageService.Current.Info(msg);
                    return false;
                }).ContinueWith(t =>
                    {
                        StopWait();
                        databaseLayersGrid1.Enabled = true;
                    }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void OnSelectAllChecked(object sender, EventArgs e)
        {
            databaseLayersGrid1.Adapter.SetPropertyForEach(item => item.Selected, chkSelectAll.Checked);
        }
    }

    public class DatabaseLayersViewBase : MapWindowView<DatabaseLayersModel>
    {
    }
}