namespace VastGIS.Views
{
    partial class AboutView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.lblGdalVersion = new System.Windows.Forms.Label();
            this.lblOcxVersion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.assembliesGrid1 = new VastGIS.Controls.AssembliesGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAssemblyFilter = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new Syncfusion.Windows.Forms.ButtonAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assembliesGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssemblyFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(595, 321);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(120, 80);
            this.tabControlAdv1.Location = new System.Drawing.Point(4, 11);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.RotateTextWhenVertical = true;
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(595, 321);
            this.tabControlAdv1.TabIndex = 0;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.lblGdalVersion);
            this.tabPageAdv1.Controls.Add(this.lblOcxVersion);
            this.tabPageAdv1.Controls.Add(this.lblVersion);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.label3);
            this.tabPageAdv1.Controls.Add(this.pictureBox1);
            this.tabPageAdv1.Image = global::VastGIS.Properties.Resources.img_logo24;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv1.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(470, 318);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "General";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // lblGdalVersion
            // 
            this.lblGdalVersion.AutoSize = true;
            this.lblGdalVersion.Location = new System.Drawing.Point(24, 201);
            this.lblGdalVersion.Name = "lblGdalVersion";
            this.lblGdalVersion.Size = new System.Drawing.Size(65, 12);
            this.lblGdalVersion.TabIndex = 5;
            this.lblGdalVersion.Text = "GDAL 版本:";
            // 
            // lblOcxVersion
            // 
            this.lblOcxVersion.AutoSize = true;
            this.lblOcxVersion.Location = new System.Drawing.Point(24, 176);
            this.lblOcxVersion.Name = "lblOcxVersion";
            this.lblOcxVersion.Size = new System.Drawing.Size(77, 12);
            this.lblOcxVersion.TabIndex = 4;
            this.lblOcxVersion.Text = "GIS平台版本:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(24, 151);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 12);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "版本:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "浙江未见空间科技有限公司开发";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "未见房地一体化野外调查系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VastGIS.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(38, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.assembliesGrid1);
            this.tabPageAdv2.Controls.Add(this.panel1);
            this.tabPageAdv2.Image = global::VastGIS.Properties.Resources.img_component32;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(24, 24);
            this.tabPageAdv2.Location = new System.Drawing.Point(123, 1);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(470, 318);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "Assemblies";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // assembliesGrid1
            // 
            this.assembliesGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.None;
            this.assembliesGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.assembliesGrid1.Appearance.AnyCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            this.assembliesGrid1.Appearance.AnyCell.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.assembliesGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.assembliesGrid1.BrowseOnly = true;
            this.assembliesGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assembliesGrid1.GridLineColor = System.Drawing.Color.White;
            this.assembliesGrid1.Location = new System.Drawing.Point(0, 39);
            this.assembliesGrid1.Name = "assembliesGrid1";
            this.assembliesGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.assembliesGrid1.ShowRowHeaders = false;
            this.assembliesGrid1.Size = new System.Drawing.Size(470, 279);
            this.assembliesGrid1.TabIndex = 0;
            this.assembliesGrid1.TableDescriptor.AllowEdit = false;
            this.assembliesGrid1.TableDescriptor.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.None;
            this.assembliesGrid1.TableOptions.AllowDropDownCell = false;
            this.assembliesGrid1.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            this.assembliesGrid1.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor;
            this.assembliesGrid1.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One;
            this.assembliesGrid1.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.assembliesGrid1.TableOptions.SelectionTextColor = System.Drawing.Color.Black;
            this.assembliesGrid1.Text = "assembliesGrid1";
            this.assembliesGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.assembliesGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.assembliesGrid1.TopLevelGroupOptions.ShowColumnHeaders = true;
            this.assembliesGrid1.UseRightToLeftCompatibleTextBox = true;
            this.assembliesGrid1.VersionInfo = "5.0.1.0";
            this.assembliesGrid1.WrapWithPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboAssemblyFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 39);
            this.panel1.TabIndex = 3;
            // 
            // cboAssemblyFilter
            // 
            this.cboAssemblyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAssemblyFilter.BeforeTouchSize = new System.Drawing.Size(170, 21);
            this.cboAssemblyFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssemblyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboAssemblyFilter.Location = new System.Drawing.Point(297, 9);
            this.cboAssemblyFilter.Name = "cboAssemblyFilter";
            this.cboAssemblyFilter.Size = new System.Drawing.Size(170, 21);
            this.cboAssemblyFilter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BeforeTouchSize = new System.Drawing.Size(90, 24);
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.IsBackStageButton = false;
            this.btnOk.Location = new System.Drawing.Point(509, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 24);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "关闭";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_options.png");
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "AboutView";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assembliesGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssemblyFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv btnOk;
        private System.Windows.Forms.ImageList imageList1;
        private Controls.AssembliesGrid assembliesGrid1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboAssemblyFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGdalVersion;
        private System.Windows.Forms.Label lblOcxVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}