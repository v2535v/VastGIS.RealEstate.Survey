﻿// -------------------------------------------------------------------------------------------
// <copyright file="ChartStyleForm.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.Symbology.Forms
{
    public partial class ChartStyleForm : MapWindowForm
    {
        private static int _selectedTab;
        private readonly DiagramsLayer _charts;
        private readonly ILayer _layer;

        private readonly IFeatureSet _shapefile;
        private string _initState;

        private bool _noEvents;

        /// <summary>
        /// Initializes a new instance of the ChartStyleForm class
        /// </summary>
        public ChartStyleForm(IAppContext context, ILayer layer)
            : base(context)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layer == null || layer.FeatureSet == null)
            {
                throw new ArgumentNullException("layer");
            }

            InitializeComponent();
            _shapefile = layer.FeatureSet;
            _charts = _shapefile.Diagrams;
            _layer = layer;

            var mode = _charts.SavingMode;
            _charts.SavingMode = PersistenceType.None;
            _initState = _charts.Serialize();
            _charts.SavingMode = mode;

            _noEvents = true;

            panelPieChart.Top = panelBarChart.Top;
            panelPieChart.Left = panelBarChart.Left;

            foreach (FontFamily family in FontFamily.Families)
            {
                cboFontName.Items.Add(family.Name);
            }

            cboValuesStyle.Items.Clear();
            cboValuesStyle.Items.Add("Horizontal");
            cboValuesStyle.Items.Add("Vertical");

            cboChartVerticalPosition.Items.Clear();
            cboChartVerticalPosition.Items.Add("Above current layer");
            cboChartVerticalPosition.Items.Add("Above all layers");

            optBarCharts.Checked = _charts.Bars;
            optPieCharts.Checked = !_charts.Bars;

            // initializing for list of color schemes
            icbColors.Target = SchemeTarget.Charts;

            if (icbColors.Items.Count > 0)
            {
                icbColors.SelectedIndex = 0;
            }

            string[] scales =
                {
                    "1", "10", "100", "1000", "5000", "10000", "25000", "50000", "100000", "250000",
                    "500000", "1000000", "10000000"
                };
            cboMinScale.Items.Clear();
            cboMaxScale.Items.Clear();
            for (int i = 0; i < scales.Length; i++)
            {
                cboMinScale.Items.Add(scales[i]);
                cboMaxScale.Items.Add(scales[i]);
            }

            txtChartExpression.Text = _shapefile.Diagrams.VisibilityExpression;

            SetChartsType();

            InitFields();

            _noEvents = false;

            Settings2Ui();

            Draw();

            RefreshControlsState();

            tabControl1.SelectedIndex = _selectedTab;
        }

        /// <summary>
        /// Applies options, generates charts if needed
        /// </summary>
        private bool ApplyOptions()
        {
            if (_charts.Fields.Count == 0)
            {
                if (_charts.Count == 0)
                {
                    MessageService.Current.Info("No fields were chosen. No charts will be displayed.");
                    return false;
                }

                if (MessageService.Current.Ask("No fields were chosen. Do you want to remove all charts?"))
                {
                    _charts.Clear();
                    return true;
                }
                return false;
            }

            bool empty = _charts.Count == 0;
            if (empty)
            {
                if (_shapefile.PointOrMultiPoint)
                {
                    // start generation, no need to prompt the user for position
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        _shapefile.Diagrams.Generate(LabelPosition.Centroid);
                    }
                    finally
                    {
                        Enabled = true;
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    // prompting user for charts position
                    using (var form = new AddChartsForm(_shapefile))
                    {
                        if (!_context.View.ShowChildView(form, this))
                        {
                            return false;
                        }
                    }
                }
            }

            if (empty || _charts.Serialize() != _initState)
            {
                _context.Legend.Redraw(LegendRedraw.LegendAndMapForce);
                _context.Project.SetModified();
            }

            return true;
        }

        /// <summary>
        /// Applies options and redraws map without closing the form
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ApplyOptions())
            {
                _context.Legend.Redraw(LegendRedraw.LegendAndMap);
                _context.Project.SetModified();
                _initState = _charts.Serialize();
                btnApply.Enabled = false;
            }
        }

        /// <summary>
        /// Opens window to edit the list of color schemes for charts
        /// </summary>
        private void btnChangeScheme_Click(object sender, EventArgs e)
        {
            _noEvents = true;
            FormHelper.EditColorSchemes(_context, SchemeTarget.Charts, this);
            _noEvents = false;
        }

        /// <summary>
        /// Building chart expression
        /// </summary>
        private void btnChartExpression_Click(object sender, EventArgs e)
        {
            string s = txtChartExpression.Text;

            if (FormHelper.ShowQueryBuilder(_context, _layer, this, ref s, false))
            {
                txtChartExpression.Text = s;
                _shapefile.Diagrams.VisibilityExpression = txtChartExpression.Text;
                btnApply.Enabled = true;
            }
        }

        /// <summary>
        /// Clears the charts expression
        /// </summary>
        private void btnClearChartsExpression_Click(object sender, EventArgs e)
        {
            txtChartExpression.Clear();
            _shapefile.Diagrams.VisibilityExpression = "";
            btnApply.Enabled = true;
        }

        /// <summary>
        /// Saves the settings
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ApplyOptions())
            {
                return;
            }

            _selectedTab = tabControl1.SelectedIndex;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Sets max visible scale to current scale
        /// </summary>
        private void btnSetMaxScale_Click(object sender, EventArgs e)
        {
            var map = _context.Map;
            if (map != null)
            {
                cboMaxScale.Text = map.CurrentScale.ToString(CultureInfo.InvariantCulture);
                btnApply.Enabled = true;
            }
        }

        /// <summary>
        /// Sets min visible scale to current scale
        /// </summary>
        private void btnSetMinScale_Click(object sender, EventArgs e)
        {
            var map = _context.Map;
            if (map != null)
            {
                cboMinScale.Text = map.CurrentScale.ToString(CultureInfo.InvariantCulture);
                btnApply.Enabled = true;
            }
        }

        /// <summary>
        /// Performs drawing
        /// </summary>
        private void Draw()
        {
            var width = pictureBox1.ClientRectangle.Width;
            var height = pictureBox1.ClientRectangle.Height;

            var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            var g = Graphics.FromImage(bmp);

            if (_charts.Visible)
            {
                _charts.DrawChart(g, (width - _charts.IconWidth) / 2, (height - _charts.IconHeight) / 2, false,
                    BackColor);
            }

            pictureBox1.Image = bmp;
        }

        /// <summary>
        /// Reverts changes if cancel was chosen
        /// </summary>
        private void frmChartStyle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Cancel) return;

            var mode = _charts.SavingMode;
            _charts.SavingMode = PersistenceType.None;
            _charts.Deserialize(_initState);
            _charts.SavingMode = mode;
        }

        /// <summary>
        /// Updating colors of the charts
        /// </summary>
        private void icbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_noEvents) return;

            btnApply.Enabled = true;
            UpdateFieldColors();

            // updating preview
            Draw();
        }

        /// <summary>
        /// Fills the fields tab
        /// </summary>
        private void InitFields()
        {
            // building list of fields
            listLeft.Items.Clear();
            listRight.Items.Clear();

            foreach (var fld in _shapefile.Table.Fields)
            {
                if (fld.Type != AttributeType.String)
                {
                    listLeft.Items.Add(fld.Name);
                }
            }

            // in case some fields have been chosen we must show them
            foreach (var fld in _shapefile.Diagrams.Fields)
            {
                string name = fld.Name.ToLower();
                for (int j = 0; j < listLeft.Items.Count; j++)
                {
                    if (listLeft.Items[j].ToString().ToLower() == name)
                    {
                        listRight.Items.Add(listLeft.Items[j]);
                        listLeft.Items.Remove(listLeft.Items[j]);
                        break;
                    }
                }
            }

            if (listLeft.Items.Count > 0)
            {
                listLeft.SelectedIndex = 0;
            }

            if (listRight.Items.Count > 0)
            {
                listRight.SelectedIndex = 0;
            }

            // Filling size and normalization fields
            cboChartSizeField.Items.Clear();
            cboChartNormalizationField.Items.Clear();

            cboChartSizeField.Items.Add("<None>"); // default
            cboChartNormalizationField.Items.Add("<None>");

            foreach (var fld in _shapefile.Table.Fields)
            {
                if (fld.Type != AttributeType.String)
                {
                    cboChartSizeField.Items.Add(fld.Name);
                    cboChartNormalizationField.Items.Add(fld.Name);
                }
            }

            if (cboChartSizeField.Items.Count >= 0) cboChartSizeField.SelectedIndex = 0;

            if (cboChartNormalizationField.Items.Count >= 0) cboChartNormalizationField.SelectedIndex = 0;

            // size field
            var charts = _shapefile.Diagrams;
            if (charts.SizeField >= 0 && charts.SizeField < cboChartSizeField.Items.Count - 1) // first item is <none>
            {
                var fld = _shapefile.Table.Fields[charts.SizeField];
                if (fld != null)
                {
                    for (int i = 2; i < cboChartSizeField.Items.Count; i++) // 2 = <none> and <sum of fields>
                    {
                        if (fld.Name == cboChartSizeField.Items[i].ToString())
                        {
                            cboChartSizeField.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                cboChartSizeField.SelectedIndex = 0;
            }

            // normalization field
            if (charts.NormalizationField >= 0 && charts.NormalizationField < cboChartNormalizationField.Items.Count - 1)
                // first item is <none>
            {
                var fld = _shapefile.Table.Fields[charts.NormalizationField];
                if (fld != null)
                {
                    for (int i = 2; i < cboChartNormalizationField.Items.Count; i++) // 2 = <none> and <sum of fields>
                    {
                        if (fld.Name == cboChartNormalizationField.Items[i].ToString())
                        {
                            cboChartNormalizationField.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                cboChartNormalizationField.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Activating bar charts
        /// </summary>
        private void optBarCharts_CheckedChanged(object sender, EventArgs e)
        {
            _charts.DiagramType = DiagramType.Bar;
            SetChartsType();
        }

        /// <summary>
        /// Activating pie charts
        /// </summary>
        private void optPieCharts_CheckedChanged(object sender, EventArgs e)
        {
            _charts.DiagramType = DiagramType.Pie;
            SetChartsType();
        }

        /// <summary>
        /// Updates the enabled state of the controls
        /// </summary>
        private void RefreshControlsState()
        {
            cboValuesStyle.Enabled = chkValuesVisible.Checked && (_charts.Bars);
            groupBox4.Enabled = chkValuesVisible.Checked;
            groupBox5.Enabled = chkValuesVisible.Checked;

            udThickness.Enabled = chk3DMode.Checked;
            udTilt.Enabled = chk3DMode.Checked;

            cboChartSizeField.Enabled = _shapefile.Diagrams.DiagramType == DiagramType.Pie;

            cboMinScale.Enabled = chkDynamicVisibility.Checked;
            cboMaxScale.Enabled = chkDynamicVisibility.Checked;

            bool haveFields = _charts.Fields.Any();
            groupBox4.Enabled = haveFields;
            groupBox5.Enabled = haveFields;
            groupBox6.Enabled = haveFields;
            groupBox7.Enabled = haveFields;
            groupBox10.Enabled = haveFields;
            chkValuesVisible.Enabled = haveFields;
            cboValuesStyle.Enabled = haveFields;
            label10.Enabled = haveFields;
            icbColors.Enabled = haveFields;
            label1.Enabled = haveFields;
            
            groupboxChartsOffset.Enabled = haveFields;

            groupBox9.Enabled = haveFields;
            groupBox11.Enabled = haveFields;
            groupBox2.Enabled = haveFields;
            groupBox3.Enabled = haveFields;
            groupBox8.Enabled = haveFields;
            groupBox13.Enabled = haveFields;

            btnChangeScheme.Enabled = haveFields;
            
        }

        /// <summary>
        /// Chosing the type of charts
        /// </summary>
        private void SetChartsType()
        {
            if (_charts.Bars)
            {
                tabControl1.TabPages[1].Text = @"Bar charts";
                panelBarChart.Visible = true;
                panelPieChart.Visible = false;
            }

            if (!_charts.Bars)
            {
                tabControl1.TabPages[1].Text = @"Pie charts";
                panelPieChart.Visible = true;
                panelBarChart.Visible = false;
            }

            if (!_noEvents)
            {
                btnApply.Enabled = true;
            }

            RefreshControlsState();
            Draw();
        }

        /// <summary>
        /// Copies settings from the charts class to the controls
        /// </summary>
        private void Settings2Ui()
        {
            if (_charts == null)
            {
                return;
            }

            _noEvents = true;
            udBarHeight.SetValue(_charts.BarHeight);
            udBarWidth.SetValue(_charts.BarWidth);

            cboChartVerticalPosition.SelectedIndex = (int)_charts.VerticalPosition;
            udChartsOffsetX.SetValue(_charts.OffsetX);
            udChartsOffsetY.SetValue(_charts.OffsetY);
            udChartsBuffer.SetValue(_charts.CollisionBuffer);

            udPieRadius.SetValue(_charts.PieRadius);
            udPieRadius2.SetValue(_charts.PieRadius2);
            udThickness.SetValue(_charts.Thickness);
            udTilt.SetValue(_charts.Tilt);
            chk3DMode.Checked = _charts.Use3DMode;
            chkVisible.Checked = _charts.Visible;

            chkFontBold.Checked = _charts.ValuesFontBold;
            clpFont.Color = _charts.ValuesFontColor;
            chkFontItalic.Checked = _charts.ValuesFontItalic;
            udFontSize.SetValue(_charts.ValuesFontSize);

            clpFrame.Color = _charts.ValuesFrameColor;
            chkValuesFrame.Checked = _charts.ValuesFrameVisible;
            chkValuesVisible.Checked = _charts.ValuesVisible;
            cboValuesStyle.SelectedIndex = (int)_charts.ValuesStyle;

            // looking for the font
            var name = _charts.ValuesFontName.ToLower();
            for (var i = 0; i < cboFontName.Items.Count; i++)
            {
                if (cboFontName.Items[i].ToString().ToLower() == name)
                {
                    cboFontName.SelectedIndex = i;
                    break;
                }
            }

            if (cboFontName.SelectedIndex < 0)
            {
                cboFontName.Text = @"Arial";
            }

            // transparency
            transparencyControl1.Value = _charts.AlphaTransparency;

            cboMinScale.Text = _shapefile.Diagrams.MinVisibleScale.ToString(CultureInfo.InvariantCulture);
            cboMaxScale.Text = _shapefile.Diagrams.MaxVisibleScale.ToString(CultureInfo.InvariantCulture);
            chkDynamicVisibility.Checked = _shapefile.Diagrams.DynamicVisibility;

            _noEvents = false;
        }

        /// <summary>
        /// Applies trasnparency set by user
        /// </summary>
        private void transparencyControl1_ValueChanged(object sender, byte value)
        {
            Ui2Settings(null, null);
        }

        /// <summary>
        /// Copies chart settings from the controls to the charts class
        /// </summary>
        private void Ui2Settings(object sender, EventArgs e)
        {
            if (_charts == null) return;

            if (_noEvents) return;

            _charts.BarHeight = (int)udBarHeight.Value;
            _charts.BarWidth = (int)udBarWidth.Value;
            _charts.PieRadius = (int)udPieRadius.Value;
            _charts.PieRadius2 = (int)udPieRadius2.Value;
            _charts.Thickness = (double)udThickness.Value;
            _charts.Tilt = (double)udTilt.Value;

            _charts.Use3DMode = chk3DMode.Checked;
            _charts.Visible = chkVisible.Checked;

            _charts.ValuesFontBold = chkFontBold.Checked;
            _charts.ValuesFontColor = clpFont.Color;

            _charts.ValuesFontItalic = chkFontItalic.Checked;
            _charts.ValuesFontName = cboFontName.Text;
            _charts.ValuesFontSize = (int)udFontSize.Value;

            _charts.ValuesFrameColor = clpFrame.Color;
            _charts.ValuesFrameVisible = chkValuesFrame.Checked;
            _charts.ValuesVisible = chkValuesVisible.Checked;
            _charts.ValuesStyle = (DiagramValuesStyle)cboValuesStyle.SelectedIndex;

            _charts.UseVariableRadius = (cboChartSizeField.SelectedIndex > 0);
            _charts.OffsetX = (int)udChartsOffsetX.Value;
            _charts.OffsetY = (int)udChartsOffsetY.Value;
            _charts.CollisionBuffer = (int)udChartsBuffer.Value;
            _charts.AlphaTransparency = transparencyControl1.Value;

            double val;
            if (double.TryParse(cboMinScale.Text, out val))
            {
                _shapefile.Diagrams.MinVisibleScale = val;
            }

            if (double.TryParse(cboMaxScale.Text, out val))
            {
                _shapefile.Diagrams.MaxVisibleScale = val;
            }
            _shapefile.Diagrams.DynamicVisibility = chkDynamicVisibility.Checked;

            // size field
            if (cboChartSizeField.SelectedIndex > 0)
            {
                string name = (string)cboChartSizeField.SelectedItem;

                int fieldCount = _shapefile.Table.Fields.Count;
                for (int i = 0; i < fieldCount; i++)
                {
                    var fld = _shapefile.Table.Fields[i];
                    if (fld != null)
                    {
                        if (fld.Name == name)
                        {
                            _charts.SizeField = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                _charts.SizeField = -1;
            }

            // normalization field
            if (cboChartNormalizationField.SelectedIndex > 0)
            {
                string name = (string)cboChartNormalizationField.SelectedItem;

                int fieldCount = _shapefile.Table.Fields.Count;
                for (int i = 0; i < fieldCount; i++)
                {
                    var fld = _shapefile.Table.Fields[i];
                    if (fld != null)
                    {
                        if (fld.Name == name)
                        {
                            _charts.NormalizationField = i;
                            break;
                        }
                    }
                }
            }
            else
            {
                _charts.NormalizationField = -1;
            }

            btnApply.Enabled = true;

            RefreshControlsState();

            Draw();
        }

        private void UpdateFieldColors()
        {
            if (icbColors.ColorSchemes != null && icbColors.SelectedIndex >= 0)
            {
                var blend = icbColors.ColorSchemes[icbColors.SelectedIndex];
                var scheme = blend.ToColorScheme();
                if (scheme != null)
                {
                    var fields = _charts.Fields;
                    for (int i = 0; i < fields.Count; i++)
                    {
                        var field = fields[i];
                        double value = i / (double)(fields.Count - 1);
                        field.Color = scheme.GetGraduatedColor(value);
                    }
                }
            }
        }

        #region "Fields"

        /// <summary>
        /// Adds selected field to the chart
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedIndex >= 0)
            {
                int index = listLeft.SelectedIndex;
                listRight.Items.Add(listLeft.SelectedItem);
                listLeft.Items.Remove(listLeft.SelectedItem);

                if (index < listLeft.Items.Count)
                {
                    listLeft.SelectedIndex = index;
                }
                else if (index - 1 >= 0)
                {
                    listLeft.SelectedIndex = index - 1;
                }

                listRight.SelectedIndex = listRight.Items.Count - 1;

                if (!_noEvents)
                {
                    btnApply.Enabled = true;
                }
            }

            RefreshFields();
            RefreshControlsState();
            Draw();
        }

        /// <summary>
        /// Updates fields chosen by user
        /// </summary>
        private void RefreshFields()
        {
            _shapefile.Diagrams.Fields.Clear();

            // adding selected fields
            for (int i = 0; i < listRight.Items.Count; i++)
            {
                var fields = _shapefile.Fields;
                for (int j = 0; j < fields.Count; j++)
                {
                    if (listRight.Items[i].ToString().ToLower() == fields[j].Name.ToLower())
                    {
                        // double val = i / (double)(listRight.Items.Count - 1);

                        var field = new DiagramField { Index = j, Name = fields[j].Name };
                        _shapefile.Diagrams.Fields.Add(field);
                    }
                }
            }

            UpdateFieldColors();
        }

        /// <summary>
        /// Removes selected field form the chart
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listRight.SelectedIndex >= 0)
            {
                int index = listRight.SelectedIndex;
                listLeft.Items.Add(listRight.SelectedItem);
                listRight.Items.Remove(listRight.SelectedItem);

                if (index < listRight.Items.Count)
                {
                    listRight.SelectedIndex = index;
                }
                else if (index - 1 >= 0)
                {
                    listRight.SelectedIndex = index - 1;
                }

                listLeft.SelectedIndex = listLeft.Items.Count - 1;

                if (!_noEvents)
                {
                    btnApply.Enabled = true;
                }
            }
            RefreshFields();
            RefreshControlsState();
            Draw();
        }

        /// <summary>
        /// Adds all the fields to the chart
        /// </summary>
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (!_noEvents && listLeft.Items.Count > 0)
            {
                btnApply.Enabled = true;
            }

            for (int i = 0; i < listLeft.Items.Count; i++)
            {
                listRight.Items.Add(listLeft.Items[i]);
            }
            listLeft.Items.Clear();

            if (listRight.Items.Count > 0)
            {
                listRight.SelectedIndex = listRight.Items.Count - 1;
            }
            RefreshFields();
            RefreshControlsState();
            Draw();
        }

        /// <summary>
        ///  Removes all the fields from the chart
        /// </summary>
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (!_noEvents && listRight.Items.Count > 0)
            {
                btnApply.Enabled = true;
            }

            for (int i = 0; i < listRight.Items.Count; i++)
            {
                listLeft.Items.Add(listRight.Items[i]);
            }
            listRight.Items.Clear();

            if (listLeft.Items.Count > 0)
            {
                listLeft.SelectedIndex = listLeft.Items.Count - 1;
            }

            RefreshFields();
            RefreshControlsState();
            Draw();
        }

        #endregion

        private void ChartStyleForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}