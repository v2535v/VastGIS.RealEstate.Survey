namespace VastGIS.Plugins.RealEstate.Forms
{
   
    partial class frmEditFeature
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ucSelectLayer1 = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.ucFeatureLists1 = new VastGIS.Plugins.RealEstate.DataControls.ucFeatureLists();
            this.btnCogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(188, 265);
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
            this.btnOK.Location = new System.Drawing.Point(101, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "编辑属性";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 3;
            // 
            // ucSelectLayer1
            // 
            this.ucSelectLayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.Location = new System.Drawing.Point(12, 6);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.SingleSelect = false;
            this.ucSelectLayer1.Size = new System.Drawing.Size(248, 28);
            this.ucSelectLayer1.TabIndex = 4;
            // 
            // ucFeatureLists1
            // 
            this.ucFeatureLists1.CanMultiSelect = false;
            this.ucFeatureLists1.IsDraw = true;
            this.ucFeatureLists1.Location = new System.Drawing.Point(12, 40);
            this.ucFeatureLists1.Name = "ucFeatureLists1";
            this.ucFeatureLists1.Size = new System.Drawing.Size(248, 202);
            this.ucFeatureLists1.TabIndex = 5;
            // 
            // btnCogo
            // 
            this.btnCogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCogo.Location = new System.Drawing.Point(14, 265);
            this.btnCogo.Name = "btnCogo";
            this.btnCogo.Size = new System.Drawing.Size(81, 23);
            this.btnCogo.TabIndex = 6;
            this.btnCogo.Text = "编辑图形";
            this.btnCogo.UseVisualStyleBackColor = true;
            // 
            // frmEditFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 296);
            this.Controls.Add(this.btnCogo);
            this.Controls.Add(this.ucFeatureLists1);
            this.Controls.Add(this.ucSelectLayer1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditFeature";
            this.Text = "要素编辑选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.ucSelectLayer ucSelectLayer1;
        private DataControls.ucFeatureLists ucFeatureLists1;
        private System.Windows.Forms.Button btnCogo;
    }

}