namespace VastGIS.Plugins.RealEstate.Forms
{
	
    partial class frmAssignPhoto
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbObjectClasses = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkSelectFeature = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.imageListView1 = new Manina.Windows.Forms.ImageListView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(310, 420);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(81, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "关闭";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(220, 420);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "拍照";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(5, 420);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "目标图层：";
            // 
            // cmbObjectClasses
            // 
            this.cmbObjectClasses.BeforeTouchSize = new System.Drawing.Size(173, 20);
            this.cmbObjectClasses.EnableTouchMode = true;
            this.cmbObjectClasses.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbObjectClasses.Location = new System.Drawing.Point(76, 6);
            this.cmbObjectClasses.Name = "cmbObjectClasses";
            this.cmbObjectClasses.Size = new System.Drawing.Size(242, 26);
            this.cmbObjectClasses.TabIndex = 7;
            this.cmbObjectClasses.SelectedIndexChanged += new System.EventHandler(this.cmbObjectClasses_SelectedIndexChanged);
            // 
            // chkSelectFeature
            // 
            this.chkSelectFeature.BeforeTouchSize = new System.Drawing.Size(150, 21);
            this.chkSelectFeature.EnableTouchMode = true;
            this.chkSelectFeature.ImageCheckBoxSize = new System.Drawing.Size(19, 19);
            this.chkSelectFeature.Location = new System.Drawing.Point(324, 4);
            this.chkSelectFeature.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkSelectFeature.Name = "chkSelectFeature";
            this.chkSelectFeature.Size = new System.Drawing.Size(82, 31);
            this.chkSelectFeature.TabIndex = 8;
            this.chkSelectFeature.Text = "选择要素";
            this.chkSelectFeature.ThemesEnabled = false;
            // 
            // imageListView1
            // 
            this.imageListView1.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imageListView1.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.imageListView1.Location = new System.Drawing.Point(7, 42);
            this.imageListView1.MultiSelect = false;
            this.imageListView1.Name = "imageListView1";
            this.imageListView1.PersistentCacheDirectory = "";
            this.imageListView1.PersistentCacheSize = ((long)(100));
            this.imageListView1.Size = new System.Drawing.Size(387, 372);
            this.imageListView1.TabIndex = 9;
            this.imageListView1.View = Manina.Windows.Forms.View.Gallery;
            // 
            // frmAssignPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 451);
            this.Controls.Add(this.imageListView1);
            this.Controls.Add(this.chkSelectFeature);
            this.Controls.Add(this.cmbObjectClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssignPhoto";
            this.Text = "快速照片加载";
            ((System.ComponentModel.ISupportInitialize)(this.cmbObjectClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectFeature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbObjectClasses;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSelectFeature;
        private Manina.Windows.Forms.ImageListView imageListView1;
    }
}