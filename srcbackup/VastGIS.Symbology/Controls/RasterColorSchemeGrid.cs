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
using VastGIS.Plugins.Mvp;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace VastGIS.Plugins.Symbology.Controls
{
    public partial class RasterColorSchemeGrid : StronglyTypedGrid<RasterInterval>
    {
        public const string ModelName = "ColorModel";
        public const int RowHeight = 20;
        public const int ColorColumnWidth = 70;
        private bool _showGradient = true;

        public RasterColorSchemeGrid()
        {
            InitializeComponent();

            Extended = false;

            Table.DefaultRecordRowHeight = RowHeight;

            var model = new GridCellColorModel(TableControl.Model);
            TableControl.Model.CellModels.Add(ModelName, model);

            TableControlCellDoubleClick += Grid_TableControlCellDoubleClick;
        }

        public bool Extended { get; set; }

        protected override void UpdateColumns()
        {
            AdjustColumnsWidth();

            UpdateColumnVisibility();

            UpdateColumnFormat();
        }

        public bool ShowGradient
        {
            get { return _showGradient; }
            set
            {
                _showGradient = value;
                UpdateColumnVisibility();
            }
        }

        private void AdjustColumnsWidth()
        {
            this.AdjustColumnWidths();

            GridColumnDescriptor[] columns =
            {
                Adapter.GetColumn(item => item.LowColor),
                Adapter.GetColumn(item => item.HighColor)
            };

            foreach (var cmn in columns.Where(cmn => cmn != null))
            {
                cmn.Appearance.AnyRecordFieldCell.CellType = ModelName;
                cmn.Width = Adapter.ReadOnly ? 40 : 70;
            }

            var cmn2 = Adapter.GetColumn(item => item.Visible);
            if (cmn2 != null)
            {
                cmn2.Width = 30;
            }
        }

        private void UpdateColumnFormat()
        {
            GridColumnDescriptor[] columns =
            {
                Adapter.GetColumn(item => item.LowValue),
                Adapter.GetColumn(item => item.HighValue)
            };

            foreach (var cmn in columns.Where(cmn => cmn != null))
            {
                cmn.Appearance.AnyCell.Format = "g6";
            }
        }

        private void UpdateColumnVisibility()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(item => item.Visible);
            Adapter.ShowColumn(item => item.LowColor);

            if (ShowGradient)
            {
                Adapter.ShowColumn(item => item.HighColor);
            }

            if (!Extended)
            {
                Adapter.ShowColumn(item => item.Range);
            }
            else
            {
                Adapter.ShowColumn(item => item.LowValue);
                Adapter.ShowColumn(item => item.HighValue);
                Adapter.ShowColumn(item => item.Caption);
            }
        }

        public void ShowDropDowns(bool value)
        {
            var model = TableControl.Model.CellModels[ModelName] as GridCellColorModel;
            if (model != null)
            {
                model.ShowDropDowns = value;
            }
        }

        public void RefreshGrid()
        {
            Refresh();
        }

        private void Grid_TableControlCellDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            if (Adapter.ReadOnly)
            {
                return;
            }

            int cmnIndex1 = Adapter.GetColumnIndex(item => item.LowColor);
            int cmnIndex2 = Adapter.GetColumnIndex(item => item.HighColor);
            if (e.Inner.ColIndex != cmnIndex1 && e.Inner.ColIndex != cmnIndex2)
            {
                return;
            }

            int recIndex = Adapter.RowIndexToRecordIndex(e.Inner.RowIndex);
            if (recIndex == -1)
            {
                return;
            }

            var interval = Adapter[recIndex];

            using (var dialog = new ColorDialog())
            {
                dialog.Color = interval.LowColor;
                dialog.FullOpen = true;
                dialog.AnyColor = true;
                if (dialog.ShowDialog(AppViewFactory.Instance.MainForm) == DialogResult.OK)
                {
                    Adapter.SetProperty(item => item.LowColor, dialog.Color);
                    Refresh();
                }
            }
        }
    }
}
