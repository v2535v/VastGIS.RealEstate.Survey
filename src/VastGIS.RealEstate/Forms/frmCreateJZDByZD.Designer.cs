namespace VastGIS.Plugins.RealEstate.Forms
{
	
    partial class frmCreateJZDByZD
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageJZD = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLocateJzd = new System.Windows.Forms.Button();
            this.btnAttributeJzd = new System.Windows.Forms.Button();
            this.gridJzds = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.btnCreateAllJzd = new System.Windows.Forms.Button();
            this.btnSelectNewJzd = new System.Windows.Forms.Button();
            this.btnSelectAllJzd = new System.Windows.Forms.Button();
            this.btnCreateNowJzd = new System.Windows.Forms.Button();
            this.pageJZX = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLocateJzx = new System.Windows.Forms.Button();
            this.btnAttributeJzx = new System.Windows.Forms.Button();
            this.gridJzxs = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.btnCreateAllJzx = new System.Windows.Forms.Button();
            this.btnSelectNewJzx = new System.Windows.Forms.Button();
            this.btnSelectAllJzx = new System.Windows.Forms.Button();
            this.btnCreateNowJzx = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkSelFeature = new System.Windows.Forms.CheckBox();
            this.txtFeature = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnQueryDX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.pageJZD.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJzds)).BeginInit();
            this.pageJZX.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJzxs)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 380);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 3;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(304, 331);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel2.SetColumnSpan(this.tabControlAdv1, 3);
            this.tabControlAdv1.Controls.Add(this.pageJZD);
            this.tabControlAdv1.Controls.Add(this.pageJZX);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(6, 46);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(304, 331);
            this.tabControlAdv1.TabIndex = 24;
            // 
            // pageJZD
            // 
            this.pageJZD.Controls.Add(this.tableLayoutPanel1);
            this.pageJZD.Image = null;
            this.pageJZD.ImageSize = new System.Drawing.Size(16, 16);
            this.pageJZD.Location = new System.Drawing.Point(1, 24);
            this.pageJZD.Name = "pageJZD";
            this.pageJZD.ShowCloseButton = true;
            this.pageJZD.Size = new System.Drawing.Size(301, 305);
            this.pageJZD.TabIndex = 1;
            this.pageJZD.Text = "界址点";
            this.pageJZD.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.btnLocateJzd, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAttributeJzd, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridJzds, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateAllJzd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectNewJzd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectAllJzd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateNowJzd, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLocateJzd
            // 
            this.btnLocateJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_pickfeature;
            this.btnLocateJzd.Location = new System.Drawing.Point(249, 273);
            this.btnLocateJzd.Name = "btnLocateJzd";
            this.btnLocateJzd.Size = new System.Drawing.Size(28, 29);
            this.btnLocateJzd.TabIndex = 33;
            this.btnLocateJzd.UseVisualStyleBackColor = true;
            this.btnLocateJzd.Click += new System.EventHandler(this.btnLocateJzd_Click);
            // 
            // btnAttributeJzd
            // 
            this.btnAttributeJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.FeatureSX;
            this.btnAttributeJzd.Location = new System.Drawing.Point(201, 273);
            this.btnAttributeJzd.Name = "btnAttributeJzd";
            this.btnAttributeJzd.Size = new System.Drawing.Size(28, 29);
            this.btnAttributeJzd.TabIndex = 32;
            this.btnAttributeJzd.UseVisualStyleBackColor = true;
            this.btnAttributeJzd.Click += new System.EventHandler(this.btnAttributeJzd_Click);
            // 
            // gridJzds
            // 
            this.gridJzds.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridJzds.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.gridJzds, 6);
            this.gridJzds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJzds.EnableTouchMode = true;
            this.gridJzds.Location = new System.Drawing.Point(9, 3);
            this.gridJzds.Name = "gridJzds";
            this.gridJzds.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridJzds.Size = new System.Drawing.Size(282, 264);
            this.gridJzds.TabIndex = 31;
            this.gridJzds.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridJzds.TableOptions.AllowDragColumns = false;
            this.gridJzds.TableOptions.AllowDropDownCell = false;
            this.gridJzds.TableOptions.AllowMultiColumnSort = false;
            this.gridJzds.TableOptions.AllowSortColumns = false;
            this.gridJzds.UseRightToLeftCompatibleTextBox = true;
            this.gridJzds.VersionInfo = "15.1460.0.33";
            // 
            // btnCreateAllJzd
            // 
            this.btnCreateAllJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_createall;
            this.btnCreateAllJzd.Location = new System.Drawing.Point(105, 273);
            this.btnCreateAllJzd.Name = "btnCreateAllJzd";
            this.btnCreateAllJzd.Size = new System.Drawing.Size(28, 29);
            this.btnCreateAllJzd.TabIndex = 30;
            this.btnCreateAllJzd.UseVisualStyleBackColor = true;
            this.btnCreateAllJzd.Click += new System.EventHandler(this.btnCreateAllJzd_Click);
            // 
            // btnSelectNewJzd
            // 
            this.btnSelectNewJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_unselect_24;
            this.btnSelectNewJzd.Location = new System.Drawing.Point(57, 273);
            this.btnSelectNewJzd.Name = "btnSelectNewJzd";
            this.btnSelectNewJzd.Size = new System.Drawing.Size(28, 29);
            this.btnSelectNewJzd.TabIndex = 29;
            this.btnSelectNewJzd.UseVisualStyleBackColor = true;
            this.btnSelectNewJzd.Click += new System.EventHandler(this.btnSelectNewJzd_Click);
            // 
            // btnSelectAllJzd
            // 
            this.btnSelectAllJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_all_24;
            this.btnSelectAllJzd.Location = new System.Drawing.Point(9, 273);
            this.btnSelectAllJzd.Name = "btnSelectAllJzd";
            this.btnSelectAllJzd.Size = new System.Drawing.Size(28, 29);
            this.btnSelectAllJzd.TabIndex = 28;
            this.btnSelectAllJzd.UseVisualStyleBackColor = true;
            this.btnSelectAllJzd.Click += new System.EventHandler(this.btnSelectAllJzd_Click);
            // 
            // btnCreateNowJzd
            // 
            this.btnCreateNowJzd.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_createone;
            this.btnCreateNowJzd.Location = new System.Drawing.Point(153, 273);
            this.btnCreateNowJzd.Name = "btnCreateNowJzd";
            this.btnCreateNowJzd.Size = new System.Drawing.Size(28, 29);
            this.btnCreateNowJzd.TabIndex = 27;
            this.btnCreateNowJzd.UseVisualStyleBackColor = true;
            this.btnCreateNowJzd.Click += new System.EventHandler(this.btnCreateNowJzd_Click);
            // 
            // pageJZX
            // 
            this.pageJZX.Controls.Add(this.tableLayoutPanel3);
            this.pageJZX.Image = null;
            this.pageJZX.ImageSize = new System.Drawing.Size(16, 16);
            this.pageJZX.Location = new System.Drawing.Point(1, 24);
            this.pageJZX.Name = "pageJZX";
            this.pageJZX.ShowCloseButton = true;
            this.pageJZX.Size = new System.Drawing.Size(301, 305);
            this.pageJZX.TabIndex = 2;
            this.pageJZX.Text = "界址线";
            this.pageJZX.ThemesEnabled = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.Controls.Add(this.btnLocateJzx, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAttributeJzx, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.gridJzxs, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCreateAllJzx, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectNewJzx, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectAllJzx, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCreateNowJzx, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(301, 305);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnLocateJzx
            // 
            this.btnLocateJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_pickfeature;
            this.btnLocateJzx.Location = new System.Drawing.Point(249, 273);
            this.btnLocateJzx.Name = "btnLocateJzx";
            this.btnLocateJzx.Size = new System.Drawing.Size(28, 29);
            this.btnLocateJzx.TabIndex = 33;
            this.btnLocateJzx.UseVisualStyleBackColor = true;
            this.btnLocateJzx.Click += new System.EventHandler(this.btnLocateJzx_Click);
            // 
            // btnAttributeJzx
            // 
            this.btnAttributeJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.FeatureSX;
            this.btnAttributeJzx.Location = new System.Drawing.Point(201, 273);
            this.btnAttributeJzx.Name = "btnAttributeJzx";
            this.btnAttributeJzx.Size = new System.Drawing.Size(28, 29);
            this.btnAttributeJzx.TabIndex = 32;
            this.btnAttributeJzx.UseVisualStyleBackColor = true;
            this.btnAttributeJzx.Click += new System.EventHandler(this.btnAttributeJzx_Click);
            // 
            // gridJzxs
            // 
            this.gridJzxs.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridJzxs.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel3.SetColumnSpan(this.gridJzxs, 6);
            this.gridJzxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJzxs.EnableTouchMode = true;
            this.gridJzxs.Location = new System.Drawing.Point(9, 3);
            this.gridJzxs.Name = "gridJzxs";
            this.gridJzxs.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridJzxs.Size = new System.Drawing.Size(282, 264);
            this.gridJzxs.TabIndex = 31;
            this.gridJzxs.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridJzxs.TableOptions.AllowDragColumns = false;
            this.gridJzxs.TableOptions.AllowDropDownCell = false;
            this.gridJzxs.TableOptions.AllowMultiColumnSort = false;
            this.gridJzxs.TableOptions.AllowSortColumns = false;
            this.gridJzxs.UseRightToLeftCompatibleTextBox = true;
            this.gridJzxs.VersionInfo = "15.1460.0.33";
            // 
            // btnCreateAllJzx
            // 
            this.btnCreateAllJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_createall;
            this.btnCreateAllJzx.Location = new System.Drawing.Point(105, 273);
            this.btnCreateAllJzx.Name = "btnCreateAllJzx";
            this.btnCreateAllJzx.Size = new System.Drawing.Size(28, 29);
            this.btnCreateAllJzx.TabIndex = 30;
            this.btnCreateAllJzx.UseVisualStyleBackColor = true;
            this.btnCreateAllJzx.Click += new System.EventHandler(this.btnCreateAllJzx_Click);
            // 
            // btnSelectNewJzx
            // 
            this.btnSelectNewJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_unselect_24;
            this.btnSelectNewJzx.Location = new System.Drawing.Point(57, 273);
            this.btnSelectNewJzx.Name = "btnSelectNewJzx";
            this.btnSelectNewJzx.Size = new System.Drawing.Size(28, 29);
            this.btnSelectNewJzx.TabIndex = 29;
            this.btnSelectNewJzx.UseVisualStyleBackColor = true;
            this.btnSelectNewJzx.Click += new System.EventHandler(this.btnSelectNewJzx_Click);
            // 
            // btnSelectAllJzx
            // 
            this.btnSelectAllJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_all_24;
            this.btnSelectAllJzx.Location = new System.Drawing.Point(9, 273);
            this.btnSelectAllJzx.Name = "btnSelectAllJzx";
            this.btnSelectAllJzx.Size = new System.Drawing.Size(28, 29);
            this.btnSelectAllJzx.TabIndex = 28;
            this.btnSelectAllJzx.UseVisualStyleBackColor = true;
            this.btnSelectAllJzx.Click += new System.EventHandler(this.btnSelectAllJzx_Click);
            // 
            // btnCreateNowJzx
            // 
            this.btnCreateNowJzx.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_createone;
            this.btnCreateNowJzx.Location = new System.Drawing.Point(153, 273);
            this.btnCreateNowJzx.Name = "btnCreateNowJzx";
            this.btnCreateNowJzx.Size = new System.Drawing.Size(28, 29);
            this.btnCreateNowJzx.TabIndex = 27;
            this.btnCreateNowJzx.UseVisualStyleBackColor = true;
            this.btnCreateNowJzx.Click += new System.EventHandler(this.btnCreateNowJzx_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.chkSelFeature, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControlAdv1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtFeature, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQueryDX, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(316, 383);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // chkSelFeature
            // 
            this.chkSelFeature.AutoSize = true;
            this.chkSelFeature.Location = new System.Drawing.Point(6, 16);
            this.chkSelFeature.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.chkSelFeature.Name = "chkSelFeature";
            this.chkSelFeature.Size = new System.Drawing.Size(72, 16);
            this.chkSelFeature.TabIndex = 22;
            this.chkSelFeature.Text = "选取要素";
            this.chkSelFeature.UseVisualStyleBackColor = true;
            // 
            // txtFeature
            // 
            this.txtFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeature.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFeature.EnableTouchMode = true;
            this.txtFeature.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFeature.Location = new System.Drawing.Point(86, 11);
            this.txtFeature.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtFeature.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(104, 28);
            this.txtFeature.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFeature.TabIndex = 23;
            // 
            // btnQueryDX
            // 
            this.btnQueryDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQueryDX.Location = new System.Drawing.Point(196, 11);
            this.btnQueryDX.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnQueryDX.Name = "btnQueryDX";
            this.btnQueryDX.Size = new System.Drawing.Size(114, 29);
            this.btnQueryDX.TabIndex = 24;
            this.btnQueryDX.Text = "检索界址点、线";
            this.btnQueryDX.UseVisualStyleBackColor = true;
            this.btnQueryDX.Click += new System.EventHandler(this.btnQueryDX_Click);
            // 
            // frmCreateJZDByZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 383);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateJZDByZD";
            this.Text = "宗地生成界址点、线";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateJZDByZD_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.pageJZD.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJzds)).EndInit();
            this.pageJZX.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJzxs)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label lblInfo;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageJZD;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageJZX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkSelFeature;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFeature;
        private System.Windows.Forms.Button btnQueryDX;
        private System.Windows.Forms.Button btnCreateAllJzd;
        private System.Windows.Forms.Button btnSelectNewJzd;
        private System.Windows.Forms.Button btnSelectAllJzd;
        private System.Windows.Forms.Button btnCreateNowJzd;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridJzds;
        private System.Windows.Forms.Button btnAttributeJzd;
        private System.Windows.Forms.Button btnLocateJzd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnLocateJzx;
        private System.Windows.Forms.Button btnAttributeJzx;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridJzxs;
        private System.Windows.Forms.Button btnCreateAllJzx;
        private System.Windows.Forms.Button btnSelectNewJzx;
        private System.Windows.Forms.Button btnSelectAllJzx;
        private System.Windows.Forms.Button btnCreateNowJzx;
    }
}