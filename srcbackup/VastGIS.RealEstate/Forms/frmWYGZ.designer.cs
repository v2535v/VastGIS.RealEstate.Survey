namespace VastGIS.Plugins.RealEstate.Forms
{
   
    partial class frmWYGZ
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
            this.ucEdgeList1 = new VastGIS.Plugins.RealEstate.DataControls.ucEdgeList();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModifyType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.dblDistance = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModifyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(164, 396);
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
            this.btnOK.Location = new System.Drawing.Point(74, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "改正";
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
            // ucSelectLayer1
            // 
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.Location = new System.Drawing.Point(5, 3);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.SingleSelect = false;
            this.ucSelectLayer1.Size = new System.Drawing.Size(250, 25);
            this.ucSelectLayer1.TabIndex = 4;
            // 
            // ucEdgeList1
            // 
            this.ucEdgeList1.Location = new System.Drawing.Point(5, 35);
            this.ucEdgeList1.Name = "ucEdgeList1";
            this.ucEdgeList1.Size = new System.Drawing.Size(251, 267);
            this.ucEdgeList1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "改正方向：";
            // 
            // cmbModifyType
            // 
            this.cmbModifyType.BeforeTouchSize = new System.Drawing.Size(121, 20);
            this.cmbModifyType.EnableTouchMode = true;
            this.cmbModifyType.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbModifyType.Items.AddRange(new object[] {
            "右侧改正",
            "左侧改正"});
            this.cmbModifyType.Location = new System.Drawing.Point(69, 308);
            this.cmbModifyType.Name = "cmbModifyType";
            this.cmbModifyType.Size = new System.Drawing.Size(181, 26);
            this.cmbModifyType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "改正距离：";
            // 
            // dblDistance
            // 
            this.dblDistance.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDistance.BeforeTouchSize = new System.Drawing.Size(181, 21);
            this.dblDistance.DoubleValue = 1D;
            this.dblDistance.EnableTouchMode = true;
            this.dblDistance.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDistance.Location = new System.Drawing.Point(69, 341);
            this.dblDistance.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDistance.Name = "dblDistance";
            this.dblDistance.NullString = "";
            this.dblDistance.Size = new System.Drawing.Size(181, 28);
            this.dblDistance.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDistance.TabIndex = 9;
            this.dblDistance.Text = "1.00";
            // 
            // frmWYGZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 427);
            this.Controls.Add(this.dblDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModifyType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucEdgeList1);
            this.Controls.Add(this.ucSelectLayer1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWYGZ";
            this.Text = "屋檐改正";
            ((System.ComponentModel.ISupportInitialize)(this.cmbModifyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.ucSelectLayer ucSelectLayer1;
        private DataControls.ucEdgeList ucEdgeList1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbModifyType;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDistance;
    }

}