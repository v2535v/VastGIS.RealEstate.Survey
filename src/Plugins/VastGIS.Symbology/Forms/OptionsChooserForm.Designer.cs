﻿using VastGIS.Api.Map;

namespace VastGIS.Plugins.Symbology.Forms
{
    partial class OptionsChooserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            VastGIS.Api.Concrete.Envelope envelope1 = new VastGIS.Api.Concrete.Envelope();
            VastGIS.Api.Concrete.SpatialReference spatialReference1 = new VastGIS.Api.Concrete.SpatialReference();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axMap1 = new VastGIS.Api.Map.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择可视化参数设置并应用于新图层";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(347, 282);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 24);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(448, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(12, 246);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(531, 28);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "说明: ";
            // 
            // chkDontShow
            // 
            this.chkDontShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDontShow.AutoSize = true;
            this.chkDontShow.Location = new System.Drawing.Point(15, 288);
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.Size = new System.Drawing.Size(132, 16);
            this.chkDontShow.TabIndex = 14;
            this.chkDontShow.Text = "加载时不显示该窗体";
            this.chkDontShow.UseVisualStyleBackColor = true;
            this.chkDontShow.CheckedChanged += new System.EventHandler(this.chkDontShow_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(167, 211);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.dgv_CurrentCellChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Available options";
            this.columnHeader1.Width = 155;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axMap1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(530, 213);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 30;
            // 
            // axMap1
            // 
            this.axMap1.AllowDrop = true;
            this.axMap1.AnimationOnZooming = VastGIS.Api.Enums.AutoToggle.Auto;
            this.axMap1.BackgroundColor = System.Drawing.Color.White;
            this.axMap1.CurrentScale = 20.453312703628921D;
            this.axMap1.CurrentZoom = -1;
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.ExpandLayersOnAdding = true;
            this.axMap1.ExtentHistory = 20;
            this.axMap1.ExtentPad = 0.02D;
            envelope1.Tag = "";
            this.axMap1.Extents = envelope1;
            this.axMap1.GrabProjectionFromData = true;
            this.axMap1.InertiaOnPanning = VastGIS.Api.Enums.AutoToggle.Auto;
            this.axMap1.KnownExtents = VastGIS.Api.Enums.KnownExtents.None;
            this.axMap1.Latitude = 0F;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Longitude = 0F;
            this.axMap1.MapCursor = VastGIS.Api.Enums.MapCursor.ZoomIn;
            this.axMap1.MapProjection = VastGIS.Api.Enums.MapProjection.None;
            this.axMap1.MapUnits = VastGIS.Api.Enums.LengthUnits.Meters;
            this.axMap1.MouseWheelSpeed = 0.5D;
            this.axMap1.Name = "axMap1";
            spatialReference1.Tag = "";
            this.axMap1.Projection = spatialReference1;
            this.axMap1.ResizeBehavior = VastGIS.Api.Enums.ResizeBehavior.Classic;
            this.axMap1.ReuseTileBuffer = true;
            this.axMap1.ScalebarUnits = VastGIS.Api.Enums.ScalebarUnits.GoogleStyle;
            this.axMap1.ScalebarVisible = true;
            this.axMap1.ShowCoordinates = VastGIS.Api.Enums.CoordinatesDisplay.Auto;
            this.axMap1.ShowCoordinatesFormat = VastGIS.Api.Enums.AngleFormat.Degrees;
            this.axMap1.ShowRedrawTime = false;
            this.axMap1.ShowVersionNumber = false;
            this.axMap1.Size = new System.Drawing.Size(355, 211);
            this.axMap1.SystemCursor = VastGIS.Api.Enums.SystemCursor.MapDefault;
            this.axMap1.TabIndex = 1;
            this.axMap1.Tag = "";
            this.axMap1.TileProvider = VastGIS.Api.Enums.TileProvider.OpenStreetMap;
            this.axMap1.UdCursorHandle = 0;
            this.axMap1.UseSeamlessPan = false;
            this.axMap1.ZoomBehavior = VastGIS.Api.Enums.ZoomBehavior.UseTileLevels;
            this.axMap1.ZoomBoxStyle = VastGIS.Api.Enums.ZoomBoxStyle.Blue;
            this.axMap1.ZoomPercent = 0.3D;
            // 
            // OptionsChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(551, 315);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "OptionsChooserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "符号选择";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptionsChooser_FormClosing);
            this.Load += new System.EventHandler(this.OptionsChooserForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox chkDontShow;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MapControl axMap1;
    }
}