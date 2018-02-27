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
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.lblList = new System.Windows.Forms.Label();
            this.dblX = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dblY = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.gridPoints = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVertexDown = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnInsertVertex = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVertexUpdate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVertexPick = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemoveVertex = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnVertexUp = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSelectClear = new System.Windows.Forms.Button();
            this.btnSelectUnAll = new System.Windows.Forms.Button();
            this.btnSelectReserve = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(null);
            ((System.ComponentModel.ISupportInitialize)(this.dblX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblList, 5);
            this.lblList.Location = new System.Drawing.Point(3, 6);
            this.lblList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 7;
            this.lblList.Text = "坐标列表";
            // 
            // dblX
            // 
            this.dblX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblX.BeforeTouchSize = new System.Drawing.Size(74, 21);
            this.tableLayoutPanel1.SetColumnSpan(this.dblX, 2);
            this.dblX.DoubleValue = 1D;
            this.dblX.Location = new System.Drawing.Point(43, 291);
            this.dblX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblX.Name = "dblX";
            this.dblX.NullString = "";
            this.dblX.Size = new System.Drawing.Size(74, 21);
            this.dblX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblX.TabIndex = 12;
            this.dblX.Text = "1.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "X=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y=";
            // 
            // dblY
            // 
            this.dblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dblY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblY.BeforeTouchSize = new System.Drawing.Size(74, 21);
            this.tableLayoutPanel1.SetColumnSpan(this.dblY, 2);
            this.dblY.DoubleValue = 1D;
            this.dblY.Location = new System.Drawing.Point(43, 328);
            this.dblY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblY.Name = "dblY";
            this.dblY.NullString = "";
            this.dblY.Size = new System.Drawing.Size(74, 21);
            this.dblY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblY.TabIndex = 14;
            this.dblY.Text = "1.00";
            // 
            // gridPoints
            // 
            this.gridPoints.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridPoints.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.gridPoints, 6);
            this.gridPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPoints.Location = new System.Drawing.Point(3, 28);
            this.gridPoints.Name = "gridPoints";
            this.gridPoints.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridPoints.Size = new System.Drawing.Size(231, 257);
            this.gridPoints.TabIndex = 16;
            this.gridPoints.UseRightToLeftCompatibleTextBox = true;
            this.gridPoints.VersionInfo = "15.1460.0.33";
            this.gridPoints.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridPoints_SelectedRecordsChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9619157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.07693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9611539F));
            this.tableLayoutPanel1.Controls.Add(this.btnVertexDown, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnInsertVertex, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVertexUpdate, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVertexPick, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblX, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblY, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveVertex, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVertexUp, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectClear, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectUnAll, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectReserve, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectAll, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 392);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // btnVertexDown
            // 
            this.btnVertexDown.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexDown.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexDown.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexDown.EnableTouchMode = true;
            this.btnVertexDown.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_down;
            this.btnVertexDown.IsBackStageButton = false;
            this.btnVertexDown.Location = new System.Drawing.Point(203, 323);
            this.btnVertexDown.Name = "btnVertexDown";
            this.btnVertexDown.PushButton = true;
            this.btnVertexDown.Size = new System.Drawing.Size(31, 26);
            this.btnVertexDown.TabIndex = 24;
            this.btnVertexDown.Click += new System.EventHandler(this.btnVertexDown_Click);
            // 
            // btnInsertVertex
            // 
            this.btnInsertVertex.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnInsertVertex.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnInsertVertex.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnInsertVertex.EnableTouchMode = true;
            this.btnInsertVertex.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_add;
            this.btnInsertVertex.IsBackStageButton = false;
            this.btnInsertVertex.Location = new System.Drawing.Point(123, 323);
            this.btnInsertVertex.Name = "btnInsertVertex";
            this.btnInsertVertex.PushButton = true;
            this.btnInsertVertex.Size = new System.Drawing.Size(32, 26);
            this.btnInsertVertex.TabIndex = 21;
            this.btnInsertVertex.Click += new System.EventHandler(this.btnInsertVertex_Click);
            // 
            // btnVertexUpdate
            // 
            this.btnVertexUpdate.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexUpdate.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexUpdate.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexUpdate.EnableTouchMode = true;
            this.btnVertexUpdate.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_update;
            this.btnVertexUpdate.IsBackStageButton = false;
            this.btnVertexUpdate.Location = new System.Drawing.Point(163, 291);
            this.btnVertexUpdate.Name = "btnVertexUpdate";
            this.btnVertexUpdate.PushButton = true;
            this.btnVertexUpdate.Size = new System.Drawing.Size(32, 26);
            this.btnVertexUpdate.TabIndex = 20;
            toolTipInfo1.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Body.Text = "更新节点";
            toolTipInfo1.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo1.Header.Size = new System.Drawing.Size(20, 20);
            this.superToolTip1.SetToolTip(this.btnVertexUpdate, toolTipInfo1);
            this.btnVertexUpdate.Click += new System.EventHandler(this.btnVertexUpdate_Click);
            // 
            // btnVertexPick
            // 
            this.btnVertexPick.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexPick.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexPick.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexPick.EnableTouchMode = true;
            this.btnVertexPick.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_pickfeature;
            this.btnVertexPick.IsBackStageButton = false;
            this.btnVertexPick.Location = new System.Drawing.Point(123, 291);
            this.btnVertexPick.Name = "btnVertexPick";
            this.btnVertexPick.PushButton = true;
            this.btnVertexPick.Size = new System.Drawing.Size(32, 26);
            this.btnVertexPick.TabIndex = 19;
            toolTipInfo2.Body.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Body.Text = "在图形窗口点击位置获取坐标";
            toolTipInfo2.Footer.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Size = new System.Drawing.Size(20, 20);
            toolTipInfo2.Header.Text = "坐标获取";
            this.superToolTip1.SetToolTip(this.btnVertexPick, toolTipInfo2);
            this.btnVertexPick.Click += new System.EventHandler(this.btnVertexPick_Click);
            // 
            // btnRemoveVertex
            // 
            this.btnRemoveVertex.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnRemoveVertex.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnRemoveVertex.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnRemoveVertex.EnableTouchMode = true;
            this.btnRemoveVertex.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_delete;
            this.btnRemoveVertex.IsBackStageButton = false;
            this.btnRemoveVertex.Location = new System.Drawing.Point(163, 323);
            this.btnRemoveVertex.Name = "btnRemoveVertex";
            this.btnRemoveVertex.PushButton = true;
            this.btnRemoveVertex.Size = new System.Drawing.Size(32, 26);
            this.btnRemoveVertex.TabIndex = 22;
            this.btnRemoveVertex.Click += new System.EventHandler(this.btnRemoveVertex_Click);
            // 
            // btnVertexUp
            // 
            this.btnVertexUp.BeforeTouchSize = new System.Drawing.Size(30, 33);
            this.btnVertexUp.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Solid;
            this.btnVertexUp.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.btnVertexUp.EnableTouchMode = true;
            this.btnVertexUp.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_up;
            this.btnVertexUp.IsBackStageButton = false;
            this.btnVertexUp.Location = new System.Drawing.Point(203, 291);
            this.btnVertexUp.Name = "btnVertexUp";
            this.btnVertexUp.PushButton = true;
            this.btnVertexUp.Size = new System.Drawing.Size(31, 26);
            this.btnVertexUp.TabIndex = 23;
            this.btnVertexUp.Click += new System.EventHandler(this.btnVertexUp_Click);
            // 
            // btnSelectClear
            // 
            this.btnSelectClear.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_clear_24;
            this.btnSelectClear.Location = new System.Drawing.Point(163, 355);
            this.btnSelectClear.Name = "btnSelectClear";
            this.btnSelectClear.Size = new System.Drawing.Size(34, 34);
            this.btnSelectClear.TabIndex = 3;
            this.btnSelectClear.UseVisualStyleBackColor = true;
            this.btnSelectClear.Click += new System.EventHandler(this.btnSelectClear_Click);
            // 
            // btnSelectUnAll
            // 
            this.btnSelectUnAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_unselect_24;
            this.btnSelectUnAll.Location = new System.Drawing.Point(123, 355);
            this.btnSelectUnAll.Name = "btnSelectUnAll";
            this.btnSelectUnAll.Size = new System.Drawing.Size(34, 34);
            this.btnSelectUnAll.TabIndex = 2;
            this.btnSelectUnAll.UseVisualStyleBackColor = true;
            this.btnSelectUnAll.Click += new System.EventHandler(this.btnSelectUnAll_Click);
            // 
            // btnSelectReserve
            // 
            this.btnSelectReserve.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_reserve_24;
            this.btnSelectReserve.Location = new System.Drawing.Point(83, 355);
            this.btnSelectReserve.Name = "btnSelectReserve";
            this.btnSelectReserve.Size = new System.Drawing.Size(34, 34);
            this.btnSelectReserve.TabIndex = 1;
            this.btnSelectReserve.UseVisualStyleBackColor = true;
            this.btnSelectReserve.Click += new System.EventHandler(this.btnSelectReserve_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_all_24;
            this.btnSelectAll.Location = new System.Drawing.Point(43, 355);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(34, 34);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // superToolTip1
            // 
            this.superToolTip1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            // 
            // ucCoordinateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucCoordinateList";
            this.Size = new System.Drawing.Size(238, 392);
            ((System.ComponentModel.ISupportInitialize)(this.dblX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPoints)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnVertexDown;
        private Syncfusion.Windows.Forms.ButtonAdv btnInsertVertex;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemoveVertex;
        private Syncfusion.Windows.Forms.ButtonAdv btnVertexUp;
        private Syncfusion.Windows.Forms.Tools.SuperToolTip superToolTip1;
    }
}
