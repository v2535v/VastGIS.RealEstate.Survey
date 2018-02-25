﻿using VastGIS.Api.Map;
using VastGIS.Plugins.Symbology.Properties;

namespace VastGIS.Plugins.Symbology.Forms
{
    partial class OptionsManagerForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDescription = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axMap1 = new VastGIS.Api.Map.MapControl();
            this.btnMakDefault = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.door_open;
            this.btnClose.Location = new System.Drawing.Point(543, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 41);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close dialog";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
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
            this.listView1.Size = new System.Drawing.Size(160, 358);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.dgv_CurrentCellChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Available options";
            this.columnHeader1.Width = 155;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDescription});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtDescription
            // 
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(615, 17);
            this.txtDescription.Spring = true;
            this.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axMap1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(530, 360);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 31;
            // 
            // axMap1
            // 
            this.axMap1.AllowDrop = true;
            this.axMap1.AnimationOnZooming = VastGIS.Api.Enums.AutoToggle.Auto;
            this.axMap1.BackgroundColor = System.Drawing.Color.White;
            this.axMap1.CurrentScale = 17.10495014402257D;
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
            this.axMap1.Size = new System.Drawing.Size(362, 358);
            this.axMap1.SystemCursor = VastGIS.Api.Enums.SystemCursor.MapDefault;
            this.axMap1.TabIndex = 1;
            this.axMap1.Tag = "";
            this.axMap1.TileProvider = VastGIS.Api.Enums.TileProvider.OpenStreetMap;
            this.axMap1.UdCursorHandle = 474372008;
            this.axMap1.UseSeamlessPan = false;
            this.axMap1.ZoomBehavior = VastGIS.Api.Enums.ZoomBehavior.UseTileLevels;
            this.axMap1.ZoomBoxStyle = VastGIS.Api.Enums.ZoomBoxStyle.Blue;
            this.axMap1.ZoomPercent = 0.3D;
            // 
            // btnMakDefault
            // 
            this.btnMakDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakDefault.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.application_link;
            this.btnMakDefault.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMakDefault.Location = new System.Drawing.Point(543, 146);
            this.btnMakDefault.Name = "btnMakDefault";
            this.btnMakDefault.Size = new System.Drawing.Size(81, 41);
            this.btnMakDefault.TabIndex = 26;
            this.btnMakDefault.Text = "Make default";
            this.btnMakDefault.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMakDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMakDefault.UseVisualStyleBackColor = true;
            this.btnMakDefault.Click += new System.EventHandler(this.btnMakDefault_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.ok2;
            this.btnApply.Location = new System.Drawing.Point(543, 278);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 41);
            this.btnApply.TabIndex = 23;
            this.btnApply.Text = "Apply options";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.application_add;
            this.btnSave.Location = new System.Drawing.Point(543, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Add current";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.application_edit;
            this.btnRename.Location = new System.Drawing.Point(543, 99);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(81, 41);
            this.btnRename.TabIndex = 18;
            this.btnRename.Text = "Rename";
            this.btnRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::VastGIS.Plugins.Symbology.Properties.Resources.application_delete;
            this.btnRemove.Location = new System.Drawing.Point(542, 52);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 41);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // OptionsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMakDefault);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnRemove);
            this.MinimizeBox = false;
            this.Name = "OptionsManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Symbology manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOptionsManager_FormClosed);
            this.Load += new System.EventHandler(this.OptionsManagerForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnMakDefault;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtDescription;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MapControl axMap1;
    }
}