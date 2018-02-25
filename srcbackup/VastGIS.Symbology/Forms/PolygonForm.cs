﻿// -------------------------------------------------------------------------------------------
// <copyright file="PolygonForm.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Model;
using VastGIS.Plugins.Symbology.Services;
using VastGIS.UI.Enums;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.Symbology.Forms
{
    public partial class PolygonForm : MapWindowForm
    {
        private static int _tabPage;

        private readonly IMuteLegend _legend;
        private readonly ILegendLayer _layer;
        private readonly SymbologyMetadata _metadata;
        private readonly IGeometryStyle _style;
        private string _initState;
        private bool _noEvents;

        /// <summary>
        /// Creates a new instance of PolygonForm class
        /// </summary>
        public PolygonForm(IMuteLegend legend, ILegendLayer layer, IGeometryStyle style, bool applyDisabled)
        {
            if (legend == null) throw new ArgumentNullException("legend");
            if (layer == null) throw new ArgumentNullException("layer");
            if (style == null) throw new ArgumentNullException("style");

            InitializeComponent();

            _style = style;
            _metadata = SymbologyPlugin.GetMetadata(layer.Handle);
            _legend = legend;
            _layer = layer;

            _initState = style.Serialize();

            _noEvents = true;

            Initialize();

            btnApply.Visible = !applyDisabled;
            tabControl1.SelectedIndex = _tabPage;
        }

        private void Initialize()
        {
            InitControls();

            InitTextures();

            _noEvents = false;

            cboFillType.SelectedIndexChanged += FillTypeSelectedIndexChanged;

            Options2Ui();

            AttachListeners();

            DrawPreview();
        }

        private void AttachListeners()
        {
            // fill
            chkFillVisible.CheckedChanged += Ui2Options;
            clpFill.SelectedColorChanged += Ui2Options;

            // hatch
            icbHatchStyle.SelectedIndexChanged += Ui2Options;
            chkFillBgTransparent.CheckedChanged += Ui2Options;
            clpHatchBack.SelectedColorChanged += Ui2Options;

            // gradient
            clpGradient2.SelectedColorChanged += Ui2Options;
            udGradientRotation.ValueChanged += Ui2Options;
            cboGradientType.SelectedIndexChanged += Ui2Options;
            cboGradientBounds.SelectedIndexChanged += Ui2Options;

            // outline
            chkOutlineVisible.CheckedChanged += Ui2Options;
            icbLineType.SelectedIndexChanged += Ui2Options;
            icbLineWidth.SelectedIndexChanged += Ui2Options;
            clpOutline.SelectedColorChanged += Ui2Options;

            // vertices
            chkVerticesVisible.CheckedChanged += Ui2Options;
            cboVerticesType.SelectedIndexChanged += Ui2Options;
            clpVerticesColor.SelectedColorChanged += Ui2Options;
            chkVerticesFillVisible.CheckedChanged += Ui2Options;
            udVerticesSize.ValueChanged += Ui2Options;

            udScaleX.ValueChanged += Ui2Options;
            udScaleY.ValueChanged += Ui2Options;

            textureControl1.SelectionChanged += SelectionTextureChanged;
        }

        /// <summary>
        /// Draws preview based on the chosen options
        /// </summary>
        private void DrawPreview()
        {
            if (_noEvents)
            {
                return;
            }

            if (pctPreview.Image != null)
            {
                pctPreview.Image.Dispose();
            }

            var rect = pctPreview.ClientRectangle;
            var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(bmp))
            {
                _style.DrawRectangle(g, 40.0f, 40.0f, rect.Width - 80, rect.Height - 80, true, rect.Width, rect.Height, BackColor);
            }

            pctPreview.Image = bmp;
        }

        /// <summary>
        /// Changes available fill options
        /// </summary>
        private void FillTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            groupHatch.Visible = false;
            groupPicture.Visible = false;
            groupGradient.Visible = false;
            pnlFillPicture.Visible = false;
            clpFill.Visible = true;
            label6.Visible = true;

            if (cboFillType.SelectedIndex == (int)FillType.Hatch)
            {
                groupHatch.Visible = true;
            }
            else if (cboFillType.SelectedIndex == (int)FillType.Gradient)
            {
                groupGradient.Visible = true;
            }
            else if (cboFillType.SelectedIndex == (int)FillType.Picture)
            {
                groupPicture.Visible = true;
                pnlFillPicture.Visible = true;
                clpFill.Visible = false;
                label6.Visible = false;
            }

            if (cboFillType.SelectedIndex >= 0)
            {
                _style.Fill.Type = (FillType)cboFillType.SelectedIndex;
            }

            if (!_noEvents)
            {
                btnApply.Enabled = true;
            }

            DrawPreview();
        }

        private void InitControls()
        {
            groupPicture.Parent = tabPage2;
            groupPicture.Top = groupGradient.Top;
            groupPicture.Left = groupGradient.Left;

            groupHatch.Parent = tabPage2;
            groupHatch.Top = groupGradient.Top;
            groupHatch.Left = groupGradient.Left;

            cboFillType.Items.Clear();
            cboFillType.Items.Add("Solid");
            cboFillType.Items.Add("Hatch");
            cboFillType.Items.Add("Gradient");
            cboFillType.Items.Add("Texture");

            cboGradientType.Items.Clear();
            cboGradientType.Items.Add("Linear");
            cboGradientType.Items.Add("Rectangular");
            cboGradientType.Items.Add("Circle");

            cboGradientBounds.Items.Clear();
            cboGradientBounds.Items.Add("Whole layer");
            cboGradientBounds.Items.Add("Per-shape");

            cboVerticesType.Items.Clear();
            cboVerticesType.Items.Add("Square");
            cboVerticesType.Items.Add("Circle");

            icbHatchStyle.ComboStyle = ImageComboStyle.HatchStyle;
            icbLineType.ComboStyle = ImageComboStyle.LineStyle;
            icbLineWidth.ComboStyle = ImageComboStyle.LineWidth;
        }

        private void InitTextures()
        {
            string path = ResourcePathHelper.GetTexturesPath();
            if (Directory.Exists(path))
            {
                textureControl1.FilePath = path;
                textureControl1.Textures = true;
                textureControl1.SelectedIndex = _metadata.IconIndex;
            }
            else
            {
                udScaleX.Enabled = false;
                udScaleY.Enabled = false;
            }
        }

        /// <summary>
        /// Loads the values of the class instance to the controls
        /// </summary>
        private void Options2Ui()
        {
            _noEvents = true;

            // options
            icbLineType.SelectedIndex = (int)_style.Line.DashStyle;
            icbLineWidth.SelectedIndex = (int)_style.Line.Width - 1;
            cboFillType.SelectedIndex = (int)_style.Fill.Type;
            chkOutlineVisible.Checked = _style.Line.Visible;
            clpOutline.Color = _style.Line.Color;
            chkFillVisible.Checked = _style.Fill.Visible;

            // hatch
            icbHatchStyle.SelectedIndex = (int)_style.Fill.HatchStyle;
            chkFillBgTransparent.Checked = _style.Fill.BgTransparent;
            clpHatchBack.Color = _style.Fill.BgColor;

            // gradient
            cboGradientType.SelectedIndex = (int)_style.Fill.GradientType;
            clpGradient2.Color = _style.Fill.Color2;
            udGradientRotation.Value = (decimal)_style.Fill.Rotation;

            clpFill.Color = _style.Fill.Color;
            cboGradientBounds.SelectedIndex = (int)_style.Fill.GradientBounds;
            chkOutlineVisible.Checked = _style.Line.Visible;

            // texture
            udScaleX.SetValue(_style.Marker.IconScaleX);
            udScaleY.SetValue(_style.Marker.IconScaleY);

            // vertices
            chkVerticesVisible.Checked = _style.Vertices.Visible;
            chkVerticesFillVisible.Checked = _style.Vertices.FillVisible;
            udVerticesSize.SetValue(_style.Vertices.Size);
            clpVerticesColor.Color = _style.Vertices.Color;
            cboVerticesType.SelectedIndex = (int)_style.Vertices.VertexType;

            transpFill.Value = _style.Fill.Transparency;
            transpOutline.Value = _style.Line.Transparency;

            _noEvents = false;
        }

        private void RefreshCategories()
        {
            if (_layer.FeatureSet.Style.InternalObject == _style.InternalObject)
            {
                _layer.FeatureSet.ApplyDefaultStyleToCategories();
            }
        }

        private void SaveState()
        {
            _metadata.IconIndex = textureControl1.SelectedIndex;
            _tabPage = tabControl1.SelectedIndex;
        }

        /// <summary>
        /// Changes the texture
        /// </summary>
        private void SelectionTextureChanged()
        {
            string filename = textureControl1.SelectedPath;
            if (string.IsNullOrWhiteSpace(filename))
            {
                return;
            }

            var clrTransparent = GdiPlusHelper.GetTransparentColor(filename);

            var img = BitmapSource.Open(filename, true);
            {
                img.TransparentColorFrom = clrTransparent;
                img.TransparentColorTo = clrTransparent;
                img.UseTransparentColor = true;

                _style.Marker.Icon = img;

                DrawPreview();
            }

            btnApply.Enabled = true;
        }

        /// <summary>
        /// Sets the values entered by user to the class
        /// </summary>
        private void Ui2Options(object sender, EventArgs e)
        {
            if (_noEvents)
            {
                return;
            }

            // fill
            _style.Fill.Visible = chkFillVisible.Checked;
            _style.Fill.Type = (FillType)cboFillType.SelectedIndex;
            _style.Fill.Color = clpFill.Color;

            // hatch
            _style.Fill.HatchStyle = (HatchStyle)icbHatchStyle.SelectedIndex;
            _style.Fill.BgTransparent = chkFillBgTransparent.Checked;
            _style.Fill.BgColor = clpHatchBack.Color;

            // gradient
            _style.Fill.GradientType = (GradientType)cboGradientType.SelectedIndex;
            _style.Fill.Color2 = clpGradient2.Color;
            _style.Fill.Rotation = (double)udGradientRotation.Value;
            _style.Fill.GradientBounds = (GradientBounds)cboGradientBounds.SelectedIndex;

            // texture
            _style.Marker.IconScaleX = (double)udScaleX.Value;
            _style.Marker.IconScaleY = (double)udScaleY.Value;

            // outline
            _style.Line.DashStyle = (DashStyle)icbLineType.SelectedIndex;
            _style.Line.Width = (float)icbLineWidth.SelectedIndex + 1;
            _style.Line.Visible = chkOutlineVisible.Checked;
            _style.Line.Color = clpOutline.Color;

            // vertices
            _style.Vertices.Visible = chkVerticesVisible.Checked;
            _style.Vertices.FillVisible = chkVerticesFillVisible.Checked;
            _style.Vertices.Size = (int)udVerticesSize.Value;
            _style.Vertices.Color = clpVerticesColor.Color;
            _style.Vertices.VertexType = (VertexType)cboVerticesType.SelectedIndex;

            // transparency
            _style.Line.Transparency = transpOutline.Value;
            _style.Fill.Transparency = transpFill.Value;

            btnApply.Enabled = true;

            DrawPreview();
        }

        /// <summary>
        /// Applies the changes and updates the map
        /// </summary>
        private void btnApply_Click(object sender, EventArgs e)
        {
            RefreshCategories();

            _legend.Redraw(LegendRedraw.LegendAndMap);

            SaveState();

            _initState = _style.Serialize();
            btnApply.Enabled = false;
        }

        /// <summary>
        /// Saves the window state
        /// </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            RefreshCategories();

            if (_style.Serialize() != _initState)
            {
                _legend.Redraw(LegendRedraw.LegendAndMap);
            }

            SaveState();
        }

        /// <summary>
        /// Reverts the changes if cancel was hit
        /// </summary>
        private void frmPolygons_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                _tabPage = tabControl1.SelectedIndex;
                _style.Deserialize(_initState);
            }
        }

        /// <summary>
        /// Handles the changes of the transparency by user
        /// </summary>
        private void transpOutline_ValueChanged(object sender, byte value)
        {
            Ui2Options(sender, null);
        }

        private void PolygonForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}