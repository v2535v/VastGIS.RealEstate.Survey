namespace VastGIS.Plugins.RealEstate.Forms
{
	
    partial class frmSplitPolygon
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
            this.ucSelectLayer1 = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.btnApply = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dblDist2 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.cmbPoint2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbLine2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbPoint1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmbLine1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblPart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dblDist1 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.chkSelFeature = new System.Windows.Forms.CheckBox();
            this.txtFeature = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dblDist2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPoint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDist1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancle.Location = new System.Drawing.Point(205, 197);
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
            this.btnOK.Location = new System.Drawing.Point(115, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
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
            this.ucSelectLayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.None;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.Location = new System.Drawing.Point(5, 3);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.SingleSelect = false;
            this.ucSelectLayer1.Size = new System.Drawing.Size(289, 25);
            this.ucSelectLayer1.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(5, 197);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(81, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "预览";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dblDist2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPoint2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbLine2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPoint1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLine1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblDist1, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 103);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // dblDist2
            // 
            this.dblDist2.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDist2.BeforeTouchSize = new System.Drawing.Size(181, 21);
            this.dblDist2.DoubleValue = 1D;
            this.dblDist2.EnableTouchMode = true;
            this.dblDist2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDist2.Location = new System.Drawing.Point(203, 73);
            this.dblDist2.MaxValue = 1000D;
            this.dblDist2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDist2.MinValue = 0D;
            this.dblDist2.Name = "dblDist2";
            this.dblDist2.NullString = "";
            this.dblDist2.Size = new System.Drawing.Size(83, 28);
            this.dblDist2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDist2.TabIndex = 14;
            this.dblDist2.Text = "1.00";
            // 
            // cmbPoint2
            // 
            this.cmbPoint2.BeforeTouchSize = new System.Drawing.Size(221, 20);
            this.cmbPoint2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPoint2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoint2.EnableTouchMode = true;
            this.cmbPoint2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPoint2.Items.AddRange(new object[] {
            "起点",
            "终点"});
            this.cmbPoint2.Location = new System.Drawing.Point(133, 73);
            this.cmbPoint2.Name = "cmbPoint2";
            this.cmbPoint2.Size = new System.Drawing.Size(64, 26);
            this.cmbPoint2.TabIndex = 13;
            this.cmbPoint2.Text = "起点";
            // 
            // cmbLine2
            // 
            this.cmbLine2.BeforeTouchSize = new System.Drawing.Size(221, 20);
            this.cmbLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLine2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLine2.EnableTouchMode = true;
            this.cmbLine2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLine2.Location = new System.Drawing.Point(53, 73);
            this.cmbLine2.Name = "cmbLine2";
            this.cmbLine2.Size = new System.Drawing.Size(74, 26);
            this.cmbLine2.TabIndex = 12;
            // 
            // cmbPoint1
            // 
            this.cmbPoint1.BeforeTouchSize = new System.Drawing.Size(221, 20);
            this.cmbPoint1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPoint1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoint1.EnableTouchMode = true;
            this.cmbPoint1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPoint1.Items.AddRange(new object[] {
            "起点",
            "终点"});
            this.cmbPoint1.Location = new System.Drawing.Point(133, 38);
            this.cmbPoint1.Name = "cmbPoint1";
            this.cmbPoint1.Size = new System.Drawing.Size(64, 26);
            this.cmbPoint1.TabIndex = 10;
            this.cmbPoint1.Text = "起点";
            // 
            // cmbLine1
            // 
            this.cmbLine1.BeforeTouchSize = new System.Drawing.Size(221, 20);
            this.cmbLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLine1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLine1.EnableTouchMode = true;
            this.cmbLine1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLine1.Location = new System.Drawing.Point(53, 38);
            this.cmbLine1.Name = "cmbLine1";
            this.cmbLine1.Size = new System.Drawing.Size(74, 26);
            this.cmbLine1.TabIndex = 9;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(3, 13);
            this.lblPart.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(41, 12);
            this.lblPart.TabIndex = 3;
            this.lblPart.Text = "分割线";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "线段";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "计算点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "距离";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "起点";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 13, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "终点";
            // 
            // dblDist1
            // 
            this.dblDist1.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDist1.BeforeTouchSize = new System.Drawing.Size(181, 21);
            this.dblDist1.DoubleValue = 1D;
            this.dblDist1.EnableTouchMode = true;
            this.dblDist1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDist1.Location = new System.Drawing.Point(203, 38);
            this.dblDist1.MaxValue = 1000D;
            this.dblDist1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDist1.MinValue = 0D;
            this.dblDist1.Name = "dblDist1";
            this.dblDist1.NullString = "";
            this.dblDist1.Size = new System.Drawing.Size(83, 28);
            this.dblDist1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDist1.TabIndex = 11;
            this.dblDist1.Text = "1.00";
            // 
            // chkSelFeature
            // 
            this.chkSelFeature.AutoSize = true;
            this.chkSelFeature.Location = new System.Drawing.Point(10, 38);
            this.chkSelFeature.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.chkSelFeature.Name = "chkSelFeature";
            this.chkSelFeature.Size = new System.Drawing.Size(72, 16);
            this.chkSelFeature.TabIndex = 0;
            this.chkSelFeature.Text = "选取要素";
            this.chkSelFeature.UseVisualStyleBackColor = true;
            // 
            // txtFeature
            // 
            this.txtFeature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeature.BeforeTouchSize = new System.Drawing.Size(181, 21);
            this.txtFeature.EnableTouchMode = true;
            this.txtFeature.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFeature.Location = new System.Drawing.Point(90, 32);
            this.txtFeature.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(203, 28);
            this.txtFeature.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFeature.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 21;
            // 
            // frmSplitPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 228);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFeature);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chkSelFeature);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.ucSelectLayer1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplitPolygon";
            this.Text = "多边形分割";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dblDist2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPoint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDist1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblInfo;
        private DataControls.ucSelectLayer ucSelectLayer1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkSelFeature;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFeature;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDist2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbPoint2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLine2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbPoint1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLine1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDist1;
        private System.Windows.Forms.Label label6;
    }
}