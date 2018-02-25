namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFeatureLists
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
            this.lblList = new System.Windows.Forms.Label();
            this.chkLstFeatures = new System.Windows.Forms.CheckedListBox();
            this.lstFeatures = new System.Windows.Forms.ListBox();
            this.btnSelectClear = new System.Windows.Forms.Button();
            this.btnSelectUnAll = new System.Windows.Forms.Button();
            this.btnSelectReserve = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblList, 6);
            this.lblList.Location = new System.Drawing.Point(3, 8);
            this.lblList.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "要素列表";
            // 
            // chkLstFeatures
            // 
            this.chkLstFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstFeatures.FormattingEnabled = true;
            this.chkLstFeatures.Location = new System.Drawing.Point(0, 0);
            this.chkLstFeatures.Name = "chkLstFeatures";
            this.chkLstFeatures.Size = new System.Drawing.Size(253, 125);
            this.chkLstFeatures.TabIndex = 1;
            this.chkLstFeatures.SelectedIndexChanged += new System.EventHandler(this.chkLstFeatures_SelectedIndexChanged);
            // 
            // lstFeatures
            // 
            this.lstFeatures.DisplayMember = "FullLabelString";
            this.lstFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFeatures.FormattingEnabled = true;
            this.lstFeatures.ItemHeight = 12;
            this.lstFeatures.Location = new System.Drawing.Point(0, 0);
            this.lstFeatures.Name = "lstFeatures";
            this.lstFeatures.Size = new System.Drawing.Size(253, 125);
            this.lstFeatures.TabIndex = 5;
            this.lstFeatures.ValueMember = "ID";
            this.lstFeatures.SelectedIndexChanged += new System.EventHandler(this.lstFeatures_SelectedIndexChanged);
            // 
            // btnSelectClear
            // 
            this.btnSelectClear.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_clear_24;
            this.btnSelectClear.Location = new System.Drawing.Point(172, 159);
            this.btnSelectClear.Name = "btnSelectClear";
            this.btnSelectClear.Size = new System.Drawing.Size(34, 34);
            this.btnSelectClear.TabIndex = 3;
            this.btnSelectClear.UseVisualStyleBackColor = true;
            this.btnSelectClear.Click += new System.EventHandler(this.btnSelectClear_Click);
            // 
            // btnSelectUnAll
            // 
            this.btnSelectUnAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_unselect_24;
            this.btnSelectUnAll.Location = new System.Drawing.Point(132, 159);
            this.btnSelectUnAll.Name = "btnSelectUnAll";
            this.btnSelectUnAll.Size = new System.Drawing.Size(34, 34);
            this.btnSelectUnAll.TabIndex = 2;
            this.btnSelectUnAll.UseVisualStyleBackColor = true;
            this.btnSelectUnAll.Click += new System.EventHandler(this.btnSelectUnAll_Click);
            // 
            // btnSelectReserve
            // 
            this.btnSelectReserve.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_reserve_24;
            this.btnSelectReserve.Location = new System.Drawing.Point(92, 159);
            this.btnSelectReserve.Name = "btnSelectReserve";
            this.btnSelectReserve.Size = new System.Drawing.Size(34, 34);
            this.btnSelectReserve.TabIndex = 1;
            this.btnSelectReserve.UseVisualStyleBackColor = true;
            this.btnSelectReserve.Click += new System.EventHandler(this.btnSelectReserve_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.icon_select_all_24;
            this.btnSelectAll.Location = new System.Drawing.Point(52, 159);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(34, 34);
            this.btnSelectAll.TabIndex = 0;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSelectClear, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectUnAll, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectReserve, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 196);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.lstFeatures);
            this.panel1.Controls.Add(this.chkLstFeatures);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 125);
            this.panel1.TabIndex = 4;
            // 
            // ucFeatureLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFeatureLists";
            this.Size = new System.Drawing.Size(259, 196);
            this.Resize += new System.EventHandler(this.ucFeatureLists_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.CheckedListBox chkLstFeatures;
        private System.Windows.Forms.ListBox lstFeatures;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectClear;
        private System.Windows.Forms.Button btnSelectUnAll;
        private System.Windows.Forms.Button btnSelectReserve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
