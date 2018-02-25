namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmNewFeature
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
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ucCoordinateList1 = new VastGIS.Plugins.RealEstate.DataControls.ucCoordinateList();
            this.ucSelectLayer1 = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.snapCheckbox1 = new VastGIS.Plugins.RealEstate.DataControls.SnapCheckbox(this.components);
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(131, 401);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(81, 23);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "关闭";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(41, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "生成";
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
            this.lblInfo.TabIndex = 7;
            // 
            // ucCoordinateList1
            // 
            this.ucCoordinateList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCoordinateList1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucCoordinateList1.IsDraw = true;
            this.ucCoordinateList1.Location = new System.Drawing.Point(12, 54);
            this.ucCoordinateList1.Name = "ucCoordinateList1";
            this.ucCoordinateList1.Size = new System.Drawing.Size(207, 341);
            this.ucCoordinateList1.TabIndex = 1;
            // 
            // ucSelectLayer1
            // 
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.Location = new System.Drawing.Point(12, 24);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.SingleSelect = false;
            this.ucSelectLayer1.Size = new System.Drawing.Size(201, 35);
            this.ucSelectLayer1.TabIndex = 0;
            // 
            // snapCheckbox1
            // 
            this.snapCheckbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.snapCheckbox1.AutoSize = true;
            this.snapCheckbox1.Location = new System.Drawing.Point(164, 6);
            this.snapCheckbox1.Name = "snapCheckbox1";
            this.snapCheckbox1.Size = new System.Drawing.Size(48, 16);
            this.snapCheckbox1.TabIndex = 8;
            this.snapCheckbox1.Text = "捕捉";
            this.snapCheckbox1.UseVisualStyleBackColor = true;
            // 
            // frmNewFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 432);
            this.Controls.Add(this.snapCheckbox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ucCoordinateList1);
            this.Controls.Add(this.ucSelectLayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewFeature";
            this.Text = "新建要素";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataControls.ucSelectLayer ucSelectLayer1;
        private DataControls.ucCoordinateList ucCoordinateList1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.SnapCheckbox snapCheckbox1;
    }
}