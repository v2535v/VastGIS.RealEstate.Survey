﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Symbology.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.Symbology.Views
{
    public partial class RasterColorSchemeView : RasterColorSchemeViewBase, IRasterColorSchemeView
    {
        private BindingList<RasterInterval> _intervals;

        public RasterColorSchemeView()
        {
            InitializeComponent();
            rasterColorSchemeGrid1.Extended = true;
            rasterColorSchemeGrid1.Adapter.ReadOnly = false;
            rasterColorSchemeGrid1.ShowDropDowns(true);
        }

        public override ViewStyle Style
        {
            get
            {
                return new ViewStyle()
                {
                    Modal = true,
                    Sizable = true,
                };
            }
        }

        public void Initialize()
        {
            if (Model == null)
            {
                _intervals = null;
                rasterColorSchemeGrid1.DataSource = _intervals;
                return;
            }
            
            _intervals = new BindingList<RasterInterval>(Model.ToList());
            rasterColorSchemeGrid1.DataSource = _intervals;
            chkGradientWithinCategory.Checked = Model.ColoringType != GridColoringType.Random;
            rasterColorSchemeGrid1.ShowGradient = chkGradientWithinCategory.Checked;
        }

        public BindingList<RasterInterval> Intervals
        {
            get { return _intervals; }
        }

        public RasterInterval SelectedInterval
        {
            get { return rasterColorSchemeGrid1.Adapter.SelectedItem; }
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield break; }
        }

        public IEnumerable<Control> Buttons
        {
            get
            {
                yield return btnAddInterval;
                yield return btnRemoveInterval;
                yield return btnClear;
            }
        }

        private void chkGradientWithinCategory_CheckStateChanged(object sender, EventArgs e)
        {
            rasterColorSchemeGrid1.ShowGradient = chkGradientWithinCategory.Checked;

            foreach (var item in _intervals)
            {
                item.ColoringType = chkGradientWithinCategory.Checked
                    ? GridColoringType.Gradient
                    : GridColoringType.Random;
            }
        }
    }

    public class RasterColorSchemeViewBase : MapWindowView<RasterColorScheme> { }
}
