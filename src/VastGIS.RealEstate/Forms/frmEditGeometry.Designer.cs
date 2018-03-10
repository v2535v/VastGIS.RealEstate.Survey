namespace VastGIS.Plugins.RealEstate.Forms
{
	
    partial class frmEditGeometry
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReorder = new System.Windows.Forms.Button();
            this.snapCheckbox1 = new VastGIS.Plugins.RealEstate.DataControls.SnapCheckbox(this.components);
            this.ucCoordinateList1 = new VastGIS.Plugins.RealEstate.DataControls.ucCoordinateList();
            this.ucSelectLayer1 = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.chkSelectFeature = new VastGIS.Plugins.RealEstate.DataControls.SnapCheckbox(this.components);
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(194, 390);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(74, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "关闭";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(87, 390);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 374);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 12);
            this.lblInfo.TabIndex = 3;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(5, 390);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(61, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "预览";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReorder
            // 
            this.btnReorder.Location = new System.Drawing.Point(68, 35);
            this.btnReorder.Name = "btnReorder";
            this.btnReorder.Size = new System.Drawing.Size(80, 23);
            this.btnReorder.TabIndex = 10;
            this.btnReorder.Text = "坐标排序";
            this.btnReorder.UseVisualStyleBackColor = true;
            this.btnReorder.Click += new System.EventHandler(this.btnReorder_Click);
            // 
            // snapCheckbox1
            // 
            this.snapCheckbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snapCheckbox1.AutoSize = true;
            this.snapCheckbox1.Location = new System.Drawing.Point(154, 39);
            this.snapCheckbox1.Name = "snapCheckbox1";
            this.snapCheckbox1.Size = new System.Drawing.Size(48, 16);
            this.snapCheckbox1.TabIndex = 9;
            this.snapCheckbox1.Text = "捕捉";
            this.snapCheckbox1.UseVisualStyleBackColor = true;
            // 
            // ucCoordinateList1
            // 
            this.ucCoordinateList1.Editable = false;
            this.ucCoordinateList1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucCoordinateList1.IsDraw = true;
            this.ucCoordinateList1.IsUpdate = false;
            this.ucCoordinateList1.Location = new System.Drawing.Point(5, 35);
            this.ucCoordinateList1.Name = "ucCoordinateList1";
            this.ucCoordinateList1.Size = new System.Drawing.Size(271, 336);
            this.ucCoordinateList1.TabIndex = 6;
            // 
            // ucSelectLayer1
            // 
            this.ucSelectLayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.LimitedGeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Location = new System.Drawing.Point(5, 3);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.SingleSelect = false;
            this.ucSelectLayer1.Size = new System.Drawing.Size(271, 25);
            this.ucSelectLayer1.TabIndex = 4;
            // 
            // chkSelectFeature
            // 
            this.chkSelectFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectFeature.AutoSize = true;
            this.chkSelectFeature.Location = new System.Drawing.Point(208, 39);
            this.chkSelectFeature.Name = "chkSelectFeature";
            this.chkSelectFeature.Size = new System.Drawing.Size(72, 16);
            this.chkSelectFeature.TabIndex = 11;
            this.chkSelectFeature.Text = "选择图形";
            this.chkSelectFeature.UseVisualStyleBackColor = true;
            // 
            // frmEditGeometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 421);
            this.Controls.Add(this.chkSelectFeature);
            this.Controls.Add(this.btnReorder);
            this.Controls.Add(this.snapCheckbox1);
            this.Controls.Add(this.ucCoordinateList1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.ucSelectLayer1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditGeometry";
            this.Text = "图形编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.ucSelectLayer ucSelectLayer1;
        private System.Windows.Forms.Button btnApply;
        private DataControls.ucCoordinateList ucCoordinateList1;
        private DataControls.SnapCheckbox snapCheckbox1;
        private System.Windows.Forms.Button btnReorder;
        private DataControls.SnapCheckbox chkSelectFeature;
    }
}