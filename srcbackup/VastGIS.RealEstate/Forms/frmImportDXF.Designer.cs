namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmImportDXF
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDXF = new System.Windows.Forms.TextBox();
            this.btnDXF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCodepages = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInsertMethod = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCAD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "DXF文档：";
            // 
            // txtDXF
            // 
            this.txtDXF.Location = new System.Drawing.Point(89, 23);
            this.txtDXF.Name = "txtDXF";
            this.txtDXF.Size = new System.Drawing.Size(306, 21);
            this.txtDXF.TabIndex = 1;
            // 
            // btnDXF
            // 
            this.btnDXF.Location = new System.Drawing.Point(401, 21);
            this.btnDXF.Name = "btnDXF";
            this.btnDXF.Size = new System.Drawing.Size(75, 23);
            this.btnDXF.TabIndex = 2;
            this.btnDXF.Text = "选择...";
            this.btnDXF.UseVisualStyleBackColor = true;
            this.btnDXF.Click += new System.EventHandler(this.btnDXF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件编码：";
            // 
            // cmbCodepages
            // 
            this.cmbCodepages.FormattingEnabled = true;
            this.cmbCodepages.Items.AddRange(new object[] {
            "ASCII",
            "CP936",
            "GB2312",
            "UTF-8"});
            this.cmbCodepages.Location = new System.Drawing.Point(89, 54);
            this.cmbCodepages.Name = "cmbCodepages";
            this.cmbCodepages.Size = new System.Drawing.Size(130, 20);
            this.cmbCodepages.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "库内操作：";
            // 
            // cmbInsertMethod
            // 
            this.cmbInsertMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsertMethod.FormattingEnabled = true;
            this.cmbInsertMethod.Items.AddRange(new object[] {
            "清空同名文件数据",
            "清空原有数据",
            "不修改原有数据"});
            this.cmbInsertMethod.Location = new System.Drawing.Point(89, 89);
            this.cmbInsertMethod.Name = "cmbInsertMethod";
            this.cmbInsertMethod.Size = new System.Drawing.Size(214, 20);
            this.cmbInsertMethod.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "导入";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(401, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCAD
            // 
            this.lblCAD.AutoSize = true;
            this.lblCAD.Location = new System.Drawing.Point(28, 135);
            this.lblCAD.Name = "lblCAD";
            this.lblCAD.Size = new System.Drawing.Size(0, 12);
            this.lblCAD.TabIndex = 9;
            // 
            // frmImportDXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 165);
            this.Controls.Add(this.lblCAD);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbInsertMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCodepages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDXF);
            this.Controls.Add(this.txtDXF);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportDXF";
            this.Text = "DXF文件导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDXF;
        private System.Windows.Forms.Button btnDXF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCodepages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInsertMethod;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCAD;
    }
}