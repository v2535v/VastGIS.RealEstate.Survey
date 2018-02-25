namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucCoordinateList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panButtons = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.dblX = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dblY = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.gridPoints = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.btnSelectClear = new System.Windows.Forms.Button();
            this.btnSelectUnAll = new System.Windows.Forms.Button();
            this.btnSelectReserve = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnVertexPick = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVertexUpdate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dblX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnSelectClear);
            this.panButtons.Controls.Add(this.btnSelectUnAll);
            this.panButtons.Controls.Add(this.btnSelectReserve);
            this.panButtons.Controls.Add(this.btnSelectAll);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(0, 303);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(201, 38);
            this.panButtons.TabIndex = 10;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(4, 2);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 7;
            this.lblList.Text = "坐标列表";
            // 
            // dblX
            // 
            this.dblX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dblX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblX.BeforeTouchSize = new System.Drawing.Size(95, 21);
            this.dblX.DoubleValue = 1D;
            this.dblX.Location = new System.Drawing.Point(27, 254);
            this.dblX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblX.Name = "dblX";
            this.dblX.NullString = "";
            this.dblX.Size = new System.Drawing.Size(95, 21);
            this.dblX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblX.TabIndex = 12;
            this.dblX.Text = "1.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "X=";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y=";
            // 
            // dblY
            // 
            this.dblY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dblY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblY.BeforeTouchSize = new System.Drawing.Size(95, 21);
            this.dblY.DoubleValue = 1D;
            this.dblY.Location = new System.Drawing.Point(27, 277);
            this.dblY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblY.Name = "dblY";
            this.dblY.NullString = "";
            this.dblY.Size = new System.Drawing.Size(95, 21);
            this.dblY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblY.TabIndex = 14;
            this.dblY.Text = "1.00";
            // 
            // gridPoints
            // 
            this.gridPoints.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPoints.BackColor = System.Drawing.SystemColors.Window;
            this.gridPoints.Location = new System.Drawing.Point(4, 18);
            this.gridPoints.Name = "gridPoints";
            this.gridPoints.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridPoints.Size = new System.Drawing.Size(192, 230);
            this.gridPoints.TabIndex = 16;
            this.gridPoints.UseRightToLeftCompatibleTextBox = true;
            this.gridPoints.VersionInfo = "15.1460.0.33";
            this.gridPoints.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridPoints_SelectedRecordsChanged);
            // 
            // btnSelectClear
            // 
            this.btnSelectClear.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_clear_24;
            this.btnSelectClear.Location = new System.Drawing.Point(153, 1);
            this.btnSelectClear.Name = "btnSelectClear";
            this.btnSelectClear.Size = new System.Drawing.Size(43, 34);
            this.btnSelectClear.TabIndex = 3;
            this.btnSelectClear.UseVisualStyleBackColor = true;
            this.btnSelectClear.Click += new System.EventHandler(this.btnSelectClear_Click);
            // 
            // btnSelectUnAll
            // 
            this.btnSelectUnAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_unselect_24;
            this.btnSelectUnAll.Location = new System.Drawing.Point(104, 1);
            this.btnSelectUnAll.Name = "btnSelectUnAll";
            this.btnSelectUnAll.Size = new System.Drawing.Size(43, 34);
            this.btnSelectUnAll.TabIndex = 2;
            this.btnSelectUnAll.UseVisualStyleBackColor = true;
            this.btnSelectUnAll.Click += new System.EventHandler(this.btnSelectUnAll_Click);
            // 
            // btnSelectReserve
            // 
            this.btnSelectReserve.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_reserve_24;
            this.btnSelectReserve.Location = new System.Drawing.Point(55, 1);
            this.btnSelectReserve.Name = "btnSelectReserve";
            this.btnSelectReserve.Size = new System.Drawing.Size(43, 34);
            this.btnSelectReserve.TabIndex = 1;
            this.btnSelectReserve.UseVisualStyleBackColor = true;
            this.btnSelectReserve.Click += new System.EventHandler(this.btnSelectReserve_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_all_24;
            this.btnSelectAll.Location = new System.Drawing.Point(6, 1);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(43, 34);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnVertexPick
            // 
            this.btnVertexPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVertexPick.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexPick.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexPick.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexPick.EnableTouchMode = true;
            this.btnVertexPick.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.FeaturePick;
            this.btnVertexPick.IsBackStageButton = false;
            this.btnVertexPick.Location = new System.Drawing.Point(114, 254);
            this.btnVertexPick.Name = "btnVertexPick";
            this.btnVertexPick.PushButton = true;
            this.btnVertexPick.Size = new System.Drawing.Size(45, 44);
            this.btnVertexPick.TabIndex = 19;
            this.btnVertexPick.Click += new System.EventHandler(this.btnVertexPick_Click);
            // 
            // btnVertexUpdate
            // 
            this.btnVertexUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVertexUpdate.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexUpdate.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexUpdate.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexUpdate.EnableTouchMode = true;
            this.btnVertexUpdate.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.FeatureUpdate;
            this.btnVertexUpdate.IsBackStageButton = false;
            this.btnVertexUpdate.Location = new System.Drawing.Point(153, 253);
            this.btnVertexUpdate.Name = "btnVertexUpdate";
            this.btnVertexUpdate.PushButton = true;
            this.btnVertexUpdate.Size = new System.Drawing.Size(45, 44);
            this.btnVertexUpdate.TabIndex = 20;
            this.btnVertexUpdate.Click += new System.EventHandler(this.btnVertexUpdate_Click);
            // 
            // ucCoordinateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVertexUpdate);
            this.Controls.Add(this.btnVertexPick);
            this.Controls.Add(this.gridPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dblY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dblX);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.lblList);
            this.Name = "ucCoordinateList";
            this.Size = new System.Drawing.Size(201, 341);
            this.panButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dblX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnSelectClear;
        private System.Windows.Forms.Button btnSelectUnAll;
        private System.Windows.Forms.Button btnSelectReserve;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label lblList;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblY;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridPoints;
        private Syncfusion.Windows.Forms.ButtonAdv btnVertexPick;
        private Syncfusion.Windows.Forms.ButtonAdv btnVertexUpdate;
    }
}
