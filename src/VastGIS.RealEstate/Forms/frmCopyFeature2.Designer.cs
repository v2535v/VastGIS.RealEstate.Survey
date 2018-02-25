namespace VastGIS.Plugins.RealEstate.Forms
{
   
    partial class frmCopyFeature2
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
            this.btnUnion = new System.Windows.Forms.Button();
            this.chkIsMoving = new System.Windows.Forms.CheckBox();
            this.ucFeatureLists1 = new VastGIS.Plugins.RealEstate.DataControls.ucFeatureLists();
            this.selSourceLayer = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.selTargetLayer = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(180, 308);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(72, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "关闭";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(102, 308);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(19, 287);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 3;
            // 
            // btnUnion
            // 
            this.btnUnion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnion.Enabled = false;
            this.btnUnion.Location = new System.Drawing.Point(17, 308);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(72, 23);
            this.btnUnion.TabIndex = 19;
            this.btnUnion.Text = "合并拷贝";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // chkIsMoving
            // 
            this.chkIsMoving.AutoSize = true;
            this.chkIsMoving.Location = new System.Drawing.Point(21, 268);
            this.chkIsMoving.Name = "chkIsMoving";
            this.chkIsMoving.Size = new System.Drawing.Size(108, 16);
            this.chkIsMoving.TabIndex = 20;
            this.chkIsMoving.Text = "从现有图层移除";
            this.chkIsMoving.UseVisualStyleBackColor = true;
            this.chkIsMoving.CheckedChanged += new System.EventHandler(this.chkIsMoving_CheckedChanged);
            // 
            // ucFeatureLists1
            // 
            this.ucFeatureLists1.CanMultiSelect = false;
            this.ucFeatureLists1.IsDraw = true;
            this.ucFeatureLists1.Location = new System.Drawing.Point(14, 74);
            this.ucFeatureLists1.Name = "ucFeatureLists1";
            this.ucFeatureLists1.Size = new System.Drawing.Size(237, 188);
            this.ucFeatureLists1.TabIndex = 18;
            // 
            // selSourceLayer
            // 
            this.selSourceLayer.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.selSourceLayer.Label = "来源图层";
            this.selSourceLayer.Location = new System.Drawing.Point(12, 45);
            this.selSourceLayer.Name = "selSourceLayer";
            this.selSourceLayer.SelectedClass = null;
            this.selSourceLayer.SelectedClasses = null;
            this.selSourceLayer.SingleSelect = false;
            this.selSourceLayer.Size = new System.Drawing.Size(239, 35);
            this.selSourceLayer.TabIndex = 6;
            // 
            // selTargetLayer
            // 
            this.selTargetLayer.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.selTargetLayer.Label = "目标图层";
            this.selTargetLayer.Location = new System.Drawing.Point(12, 12);
            this.selTargetLayer.Name = "selTargetLayer";
            this.selTargetLayer.SelectedClass = null;
            this.selTargetLayer.SelectedClasses = null;
            this.selTargetLayer.SingleSelect = true;
            this.selTargetLayer.Size = new System.Drawing.Size(239, 35);
            this.selTargetLayer.TabIndex = 5;
            // 
            // frmCopyFeature2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 339);
            this.Controls.Add(this.chkIsMoving);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.ucFeatureLists1);
            this.Controls.Add(this.selSourceLayer);
            this.Controls.Add(this.selTargetLayer);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCopyFeature2";
            this.Text = "拷贝要素";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.ucSelectLayer selTargetLayer;
        private DataControls.ucSelectLayer selSourceLayer;
        private DataControls.ucFeatureLists ucFeatureLists1;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.CheckBox chkIsMoving;
    }

}