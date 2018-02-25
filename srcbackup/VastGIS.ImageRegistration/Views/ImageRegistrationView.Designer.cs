﻿using VastGIS.Plugins.ImageRegistration.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Plugins.ImageRegistration.Views
{
    partial class ImageRegistrationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            VastGIS.Api.Concrete.Envelope envelope1 = new VastGIS.Api.Concrete.Envelope();
            VastGIS.Api.Concrete.SpatialReference spatialReference1 = new VastGIS.Api.Concrete.SpatialReference();
            VastGIS.Api.Concrete.Envelope envelope2 = new VastGIS.Api.Concrete.Envelope();
            VastGIS.Api.Concrete.SpatialReference spatialReference2 = new VastGIS.Api.Concrete.SpatialReference();
            this.splitContainer1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.mapControl1 = new VastGIS.Api.Map.MapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.mapControl2 = new VastGIS.Api.Map.MapControl();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusPointCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.status1 = new Syncfusion.Windows.Forms.Tools.StatusStripButton();
            this.statusError = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pointPairGrid1 = new PointPairGrid();
            this.btnZoomToPoint = new System.Windows.Forms.Button();
            this.btnClearPoints = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnApply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLoadImage = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnZoomMax = new System.Windows.Forms.Button();
            this.mnuZoomIn = new System.Windows.Forms.RadioButton();
            this.mnuZoomOut = new System.Windows.Forms.RadioButton();
            this.mnuPan = new System.Windows.Forms.RadioButton();
            this.mnuSelect = new System.Windows.Forms.RadioButton();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointPairGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BeforeTouchSize = 7;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 163);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.mapControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.mapControl2);
            this.splitContainer1.Size = new System.Drawing.Size(955, 420);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(209, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 18;
            this.label3.Tag = "<has background color>";
            this.label3.Text = "Map";
            // 
            // mapControl1
            // 
            this.mapControl1.AllowDrop = true;
            this.mapControl1.AnimationOnZooming = VastGIS.Api.Enums.AutoToggle.Auto;
            this.mapControl1.BackgroundColor = System.Drawing.Color.White;
            this.mapControl1.CurrentScale = 13.11862701723765D;
            this.mapControl1.CurrentZoom = -1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.ExtentHistory = 20;
            this.mapControl1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.mapControl1.Extents = envelope1;
            this.mapControl1.GrabProjectionFromData = true;
            this.mapControl1.InertiaOnPanning = VastGIS.Api.Enums.AutoToggle.Auto;
            this.mapControl1.KnownExtents = VastGIS.Api.Enums.KnownExtents.None;
            this.mapControl1.Latitude = 0F;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Longitude = 0F;
            this.mapControl1.MapCursor = VastGIS.Api.Enums.MapCursor.ZoomIn;
            this.mapControl1.MapProjection = VastGIS.Api.Enums.MapProjection.None;
            this.mapControl1.MapUnits = VastGIS.Api.Enums.LengthUnits.Meters;
            this.mapControl1.MouseWheelSpeed = 0.5D;
            this.mapControl1.Name = "mapControl1";
            spatialReference1.Tag = "";
            this.mapControl1.Projection = spatialReference1;
            this.mapControl1.ResizeBehavior = VastGIS.Api.Enums.ResizeBehavior.Classic;
            this.mapControl1.ReuseTileBuffer = true;
            this.mapControl1.ScalebarUnits = VastGIS.Api.Enums.ScalebarUnits.GoogleStyle;
            this.mapControl1.ScalebarVisible = false;
            this.mapControl1.ShowCoordinates = VastGIS.Api.Enums.CoordinatesDisplay.Auto;
            this.mapControl1.ShowCoordinatesFormat = VastGIS.Api.Enums.AngleFormat.Degrees;
            this.mapControl1.ShowRedrawTime = false;
            this.mapControl1.ShowVersionNumber = false;
            this.mapControl1.Size = new System.Drawing.Size(472, 418);
            this.mapControl1.SystemCursor = VastGIS.Api.Enums.SystemCursor.MapDefault;
            this.mapControl1.TabIndex = 19;
            this.mapControl1.Tag = "";
            this.mapControl1.TileProvider = VastGIS.Api.Enums.TileProvider.OpenStreetMap;
            this.mapControl1.UdCursorHandle = 0;
            this.mapControl1.UseSeamlessPan = false;
            this.mapControl1.ZoomBehavior = VastGIS.Api.Enums.ZoomBehavior.Default;
            this.mapControl1.ZoomBoxStyle = VastGIS.Api.Enums.ZoomBoxStyle.Blue;
            this.mapControl1.ZoomPercent = 0.3D;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 19;
            this.label4.Tag = "<has background color>";
            this.label4.Text = "Image";
            // 
            // mapControl2
            // 
            this.mapControl2.AllowDrop = true;
            this.mapControl2.AnimationOnZooming = VastGIS.Api.Enums.AutoToggle.Auto;
            this.mapControl2.BackgroundColor = System.Drawing.Color.White;
            this.mapControl2.CurrentScale = 13.11862701723765D;
            this.mapControl2.CurrentZoom = -1;
            this.mapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl2.ExtentHistory = 20;
            this.mapControl2.ExtentPad = 0.02D;
            envelope2.Tag = "";
            this.mapControl2.Extents = envelope2;
            this.mapControl2.GrabProjectionFromData = true;
            this.mapControl2.InertiaOnPanning = VastGIS.Api.Enums.AutoToggle.Auto;
            this.mapControl2.KnownExtents = VastGIS.Api.Enums.KnownExtents.None;
            this.mapControl2.Latitude = 0F;
            this.mapControl2.Location = new System.Drawing.Point(0, 0);
            this.mapControl2.Longitude = 0F;
            this.mapControl2.MapCursor = VastGIS.Api.Enums.MapCursor.ZoomIn;
            this.mapControl2.MapProjection = VastGIS.Api.Enums.MapProjection.None;
            this.mapControl2.MapUnits = VastGIS.Api.Enums.LengthUnits.Meters;
            this.mapControl2.MouseWheelSpeed = 0.5D;
            this.mapControl2.Name = "mapControl2";
            spatialReference2.Tag = "";
            this.mapControl2.Projection = spatialReference2;
            this.mapControl2.ResizeBehavior = VastGIS.Api.Enums.ResizeBehavior.Classic;
            this.mapControl2.ReuseTileBuffer = true;
            this.mapControl2.ScalebarUnits = VastGIS.Api.Enums.ScalebarUnits.GoogleStyle;
            this.mapControl2.ScalebarVisible = false;
            this.mapControl2.ShowCoordinates = VastGIS.Api.Enums.CoordinatesDisplay.Auto;
            this.mapControl2.ShowCoordinatesFormat = VastGIS.Api.Enums.AngleFormat.Degrees;
            this.mapControl2.ShowRedrawTime = false;
            this.mapControl2.ShowVersionNumber = false;
            this.mapControl2.Size = new System.Drawing.Size(472, 418);
            this.mapControl2.SystemCursor = VastGIS.Api.Enums.SystemCursor.MapDefault;
            this.mapControl2.TabIndex = 20;
            this.mapControl2.Tag = "";
            this.mapControl2.TileProvider = VastGIS.Api.Enums.TileProvider.OpenStreetMap;
            this.mapControl2.UdCursorHandle = 0;
            this.mapControl2.UseSeamlessPan = false;
            this.mapControl2.ZoomBehavior = VastGIS.Api.Enums.ZoomBehavior.UseTileLevels;
            this.mapControl2.ZoomBoxStyle = VastGIS.Api.Enums.ZoomBoxStyle.Blue;
            this.mapControl2.ZoomPercent = 0.3D;
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(656, 7);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(93, 31);
            this.btnRemovePoint.TabIndex = 5;
            this.btnRemovePoint.Text = "Remove point";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.OnRemoveClick);
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.BackColor = System.Drawing.Color.PaleGreen;
            this.statusStripEx1.BeforeTouchSize = new System.Drawing.Size(961, 26);
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPointCount,
            this.status1,
            this.statusError});
            this.statusStripEx1.Location = new System.Drawing.Point(0, 584);
            this.statusStripEx1.MetroColor = System.Drawing.Color.PaleGreen;
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(961, 26);
            this.statusStripEx1.TabIndex = 31;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // statusPointCount
            // 
            this.statusPointCount.Name = "statusPointCount";
            this.statusPointCount.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.statusPointCount.Size = new System.Drawing.Size(113, 21);
            this.statusPointCount.Text = "Number of Points: 0";
            // 
            // status1
            // 
            this.status1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(113, 19);
            this.status1.Text = "Please select image";
            // 
            // statusError
            // 
            this.statusError.Name = "statusError";
            this.statusError.Size = new System.Drawing.Size(57, 15);
            this.statusError.Text = "Error: n/d";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(129, 31);
            this.btnCancel.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_cancel24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(823, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(129, 31);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCancel, "Remove tranformed image fromt he map and continue editing the points");
            // 
            // pointPairGrid1
            // 
            this.pointPairGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.pointPairGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.pointPairGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.pointPairGrid1.FreezeCaption = false;
            this.pointPairGrid1.Location = new System.Drawing.Point(4, 7);
            this.pointPairGrid1.Name = "pointPairGrid1";
            this.pointPairGrid1.Size = new System.Drawing.Size(645, 150);
            this.pointPairGrid1.TabIndex = 35;
            this.pointPairGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.pointPairGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.pointPairGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.pointPairGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pointPairGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.pointPairGrid1.Text = "pointPairGrid1";
            this.pointPairGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.pointPairGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.pointPairGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.pointPairGrid1.VersionInfo = "0.0.1.0";
            this.pointPairGrid1.WrapWithPanel = true;
            // 
            // btnZoomToPoint
            // 
            this.btnZoomToPoint.Location = new System.Drawing.Point(656, 44);
            this.btnZoomToPoint.Name = "btnZoomToPoint";
            this.btnZoomToPoint.Size = new System.Drawing.Size(93, 31);
            this.btnZoomToPoint.TabIndex = 36;
            this.btnZoomToPoint.Text = "Zoom to point";
            this.btnZoomToPoint.UseVisualStyleBackColor = true;
            this.btnZoomToPoint.Click += new System.EventHandler(this.OnZoomToPointClick);
            // 
            // btnClearPoints
            // 
            this.btnClearPoints.Location = new System.Drawing.Point(656, 81);
            this.btnClearPoints.Name = "btnClearPoints";
            this.btnClearPoints.Size = new System.Drawing.Size(93, 31);
            this.btnClearPoints.TabIndex = 37;
            this.btnClearPoints.Text = "Clear";
            this.btnClearPoints.UseVisualStyleBackColor = true;
            this.btnClearPoints.Click += new System.EventHandler(this.OnClearPointsClick);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BeforeTouchSize = new System.Drawing.Size(129, 31);
            this.btnApply.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_apply24;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.IsBackStageButton = false;
            this.btnApply.Location = new System.Drawing.Point(822, 44);
            this.btnApply.Name = "btnApply";
            this.btnApply.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApply.Size = new System.Drawing.Size(129, 31);
            this.btnApply.TabIndex = 32;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnApply, "Apply tranformation and save the world file");
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImage.BeforeTouchSize = new System.Drawing.Size(129, 31);
            this.btnLoadImage.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_folder24;
            this.btnLoadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadImage.IsBackStageButton = false;
            this.btnLoadImage.Location = new System.Drawing.Point(822, 7);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoadImage.Size = new System.Drawing.Size(129, 31);
            this.btnLoadImage.TabIndex = 33;
            this.btnLoadImage.Text = "Choose Image";
            this.btnLoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnLoadImage, "Choose image to register");
            // 
            // btnZoomMax
            // 
            this.btnZoomMax.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_zoom_max24;
            this.btnZoomMax.Location = new System.Drawing.Point(841, 124);
            this.btnZoomMax.Name = "btnZoomMax";
            this.btnZoomMax.Size = new System.Drawing.Size(40, 33);
            this.btnZoomMax.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnZoomMax, "Zoom to Maximum Extents");
            this.btnZoomMax.UseVisualStyleBackColor = true;
            this.btnZoomMax.Click += new System.EventHandler(this.OnZoomMaxClick);
            // 
            // mnuZoomIn
            // 
            this.mnuZoomIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.mnuZoomIn.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_zoom_in24;
            this.mnuZoomIn.Location = new System.Drawing.Point(702, 124);
            this.mnuZoomIn.Name = "mnuZoomIn";
            this.mnuZoomIn.Size = new System.Drawing.Size(40, 33);
            this.mnuZoomIn.TabIndex = 26;
            this.toolTip1.SetToolTip(this.mnuZoomIn, "Zoom In");
            this.mnuZoomIn.UseVisualStyleBackColor = true;
            this.mnuZoomIn.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // mnuZoomOut
            // 
            this.mnuZoomOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.mnuZoomOut.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_zoom_out24;
            this.mnuZoomOut.Location = new System.Drawing.Point(748, 124);
            this.mnuZoomOut.Name = "mnuZoomOut";
            this.mnuZoomOut.Size = new System.Drawing.Size(40, 33);
            this.mnuZoomOut.TabIndex = 25;
            this.toolTip1.SetToolTip(this.mnuZoomOut, "Zoom Out");
            this.mnuZoomOut.UseVisualStyleBackColor = true;
            this.mnuZoomOut.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // mnuPan
            // 
            this.mnuPan.Appearance = System.Windows.Forms.Appearance.Button;
            this.mnuPan.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_pan24;
            this.mnuPan.Location = new System.Drawing.Point(795, 124);
            this.mnuPan.Name = "mnuPan";
            this.mnuPan.Size = new System.Drawing.Size(40, 33);
            this.mnuPan.TabIndex = 24;
            this.toolTip1.SetToolTip(this.mnuPan, "Pan");
            this.mnuPan.UseVisualStyleBackColor = true;
            this.mnuPan.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // mnuSelect
            // 
            this.mnuSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.mnuSelect.Checked = true;
            this.mnuSelect.Image = global::VastGIS.Plugins.ImageRegistration.Properties.Resources.img_cursor24;
            this.mnuSelect.Location = new System.Drawing.Point(656, 124);
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.Size = new System.Drawing.Size(40, 33);
            this.mnuSelect.TabIndex = 23;
            this.mnuSelect.TabStop = true;
            this.toolTip1.SetToolTip(this.mnuSelect, "Select Point");
            this.mnuSelect.UseVisualStyleBackColor = true;
            this.mnuSelect.CheckedChanged += new System.EventHandler(this.MnuSelectCheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(129, 33);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(823, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(129, 33);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // ImageRegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(961, 610);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClearPoints);
            this.Controls.Add(this.btnZoomToPoint);
            this.Controls.Add(this.pointPairGrid1);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.statusStripEx1);
            this.Controls.Add(this.btnZoomMax);
            this.Controls.Add(this.mnuZoomIn);
            this.Controls.Add(this.mnuZoomOut);
            this.Controls.Add(this.mnuPan);
            this.Controls.Add(this.mnuSelect);
            this.Controls.Add(this.btnRemovePoint);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.MinimizeBox = false;
            this.Name = "ImageRegistrationView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStripEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointPairGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainerAdv splitContainer1;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton mnuSelect;
        private System.Windows.Forms.RadioButton mnuPan;
        private System.Windows.Forms.RadioButton mnuZoomOut;
        private System.Windows.Forms.RadioButton mnuZoomIn;
        private System.Windows.Forms.Button btnZoomMax;
        private Api.Map.MapControl mapControl1;
        private Api.Map.MapControl mapControl2;
        private StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.ButtonAdv btnApply;
        private Syncfusion.Windows.Forms.ButtonAdv btnLoadImage;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private System.Windows.Forms.ToolStripStatusLabel statusPointCount;
        private StatusStripButton status1;
        private PointPairGrid pointPairGrid1;
        private System.Windows.Forms.ToolStripStatusLabel statusError;
        private System.Windows.Forms.Button btnZoomToPoint;
        private System.Windows.Forms.Button btnClearPoints;
        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
    }
}