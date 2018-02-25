﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.UI.Forms;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    internal partial class SetScaleView : MapWindowView, ISetScaleView
    {
        private static bool _snapToZoomLevels = false;
        private readonly IMuteMap _map;

        public SetScaleView(IMuteMap map)
        {
            if (map == null) throw new ArgumentNullException("map");
            _map = map;

            InitializeComponent();

            InitControls();

            FormClosed += (s, e) => _snapToZoomLevels = chkSnap.Checked;
        }

        private void InitControls()
        {
            txtScale.Text = _map.CurrentScale.ToString("f2");

            var scales = new[]
                               {
                                   100, 
                                   500, 
                                   1000, 
                                   5000, 
                                   10000, 
                                   25000, 
                                   50000, 
                                   100000, 
                                   250000, 
                                   500000, 
                                   1000000, 
                                   2500000, 
                                   5000000, 
                                   10000000, 
                                   25000000, 
                                   50000000,
                                   100000000, 
                                   250000000, 
                                   500000000
                               };

            cboScale.DataSource = scales;

            SetInitialScale(scales);

            chkSnap.Checked = _snapToZoomLevels;

        }

        private void SetInitialScale(IEnumerable<int> scales)
        {
            double scale = _map.CurrentScale;

            var list = scales.Select((item, index) => new { Value = Math.Abs(scale - item), Index = index });

            var newScale = list.OrderBy(item => item.Value).FirstOrDefault();

            if (newScale != null)
            {
                cboScale.SelectedIndex = newScale.Index;
            }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public string NewScale
        {
            get { return cboScale.Text; }
        }

        public bool SnapToZoomLevel
        {
            get { return chkSnap.Checked; }
        }
    }
}
