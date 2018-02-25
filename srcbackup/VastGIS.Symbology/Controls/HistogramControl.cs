﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Views;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace VastGIS.Plugins.Symbology.Controls
{
    public partial class HistogramControl : UserControl
    {
        private IApplicationContainer _container;
        private IRasterSource _raster;
        private HistogramOptionsModel _model;

        public HistogramControl()
        {
            InitializeComponent();
        }

        public void Initialize(IApplicationContainer container, IRasterSource raster)
        {
            if (raster == null) return;

            if (container == null) throw new ArgumentNullException("container");

            _container = container;
            _raster = raster;

            cboBand.AddRasterBands(raster);

            var band = ActiveBand;
            if (band != null)
            {
                SetHistogram(band.GetDefaultHistogram());
            }
        }

        private void SetHistogram(RasterHistogram ht)
        {
            chartControl1.Series.Clear();
            var series = new ChartSeries();
            series.Style.Interior = new BrushInfo(Color.Red);

            if (ht != null)
            {
                for (int i = 0; i < ht.NumBuckets; i++)
                {
                    series.Points.Add(ht.get_Value(i), ht.get_Count(i));
                }
            }

            chartControl1.Series.Add(series);
            chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double;
        }

        public RasterBand ActiveBand
        {
            get
            {
                int index = cboBand.SelectedIndex + 1;
                return _raster.Bands[index];
            }
        }

        private void btnCalculateHistogram_Click(object sender, EventArgs e)
        {
            var band = ActiveBand;
            
            if (band == null)
            {
                MessageService.Current.Info("Failed to retrieve raster band.");
                return;
            }

            if (_model == null)
            {
                _model = new HistogramOptionsModel {Mimimum = band.Minimum, Maximum = band.Maximum, NumBuckets = 256};
            }

            if (_container.Run<HistogramOptionsPresenter, HistogramOptionsModel>(_model))
            {
                var ht = band.GetHistogram(_model.Mimimum, _model.Maximum, _model.NumBuckets);
                SetHistogram(ht);
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            var band = ActiveBand;

            if (band == null)
            {
                MessageService.Current.Info("Failed to retrieve raster band.");
                return;
            }

            var ht = band.GetDefaultHistogram();
            SetHistogram(ht);
        }
    }
}
