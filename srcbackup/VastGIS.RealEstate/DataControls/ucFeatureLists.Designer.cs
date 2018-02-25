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
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnSelectClear = new System.Windows.Forms.Button();
            this.btnSelectUnAll = new System.Windows.Forms.Button();
            this.btnSelectReserve = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(4, 4);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "要素列表";
            // 
            // chkLstFeatures
            // 
            this.chkLstFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLstFeatures.FormattingEnabled = true;
            this.chkLstFeatures.Location = new System.Drawing.Point(6, 20);
            this.chkLstFeatures.Name = "chkLstFeatures";
            this.chkLstFeatures.Size = new System.Drawing.Size(192, 132);
            this.chkLstFeatures.TabIndex = 1;
            this.chkLstFeatures.SelectedIndexChanged += new System.EventHandler(this.chkLstFeatures_SelectedIndexChanged);
            // 
            // lstFeatures
            // 
            this.lstFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFeatures.FormattingEnabled = true;
            this.lstFeatures.ItemHeight = 12;
            this.lstFeatures.Location = new System.Drawing.Point(6, 20);
            this.lstFeatures.Name = "lstFeatures";
            this.lstFeatures.Size = new System.Drawing.Size(192, 136);
            this.lstFeatures.TabIndex = 5;
            this.lstFeatures.SelectedIndexChanged += new System.EventHandler(this.lstFeatures_SelectedIndexChanged);
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnSelectClear);
            this.panButtons.Controls.Add(this.btnSelectUnAll);
            this.panButtons.Controls.Add(this.btnSelectReserve);
            this.panButtons.Controls.Add(this.btnSelectAll);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panButtons.Location = new System.Drawing.Point(0, 164);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(201, 38);
            this.panButtons.TabIndex = 6;
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
            // ucFeatureLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.lstFeatures);
            this.Controls.Add(this.chkLstFeatures);
            this.Controls.Add(this.lblList);
            this.Name = "ucFeatureLists";
            this.Size = new System.Drawing.Size(201, 202);
            this.Resize += new System.EventHandler(this.ucFeatureLists_Resize);
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.CheckedListBox chkLstFeatures;
        private System.Windows.Forms.ListBox lstFeatures;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectClear;
        private System.Windows.Forms.Button btnSelectUnAll;
        private System.Windows.Forms.Button btnSelectReserve;
    }
}
