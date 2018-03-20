namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmQLRXZ
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
            this.lstQLR = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.chkQlrbh = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBhyy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSyr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyr)).BeginInit();
            this.SuspendLayout();
            // 
            // lstQLR
            // 
            this.lstQLR.FormattingEnabled = true;
            this.lstQLR.Location = new System.Drawing.Point(13, 13);
            this.lstQLR.Name = "lstQLR";
            this.lstQLR.Size = new System.Drawing.Size(259, 116);
            this.lstQLR.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnSelectAll.EnableTouchMode = true;
            this.btnSelectAll.IsBackStageButton = false;
            this.btnSelectAll.Location = new System.Drawing.Point(13, 263);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(78, 34);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnOK
            // 
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.EnableTouchMode = true;
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(110, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 34);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancel.EnableTouchMode = true;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(194, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkQlrbh
            // 
            this.chkQlrbh.AutoSize = true;
            this.chkQlrbh.Location = new System.Drawing.Point(13, 135);
            this.chkQlrbh.Name = "chkQlrbh";
            this.chkQlrbh.Size = new System.Drawing.Size(108, 16);
            this.chkQlrbh.TabIndex = 4;
            this.chkQlrbh.Text = "权利人发生变化";
            this.chkQlrbh.UseVisualStyleBackColor = true;
            this.chkQlrbh.CheckedChanged += new System.EventHandler(this.chkQlrbh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "变化原因：";
            // 
            // cmbBhyy
            // 
            this.cmbBhyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBhyy.Enabled = false;
            this.cmbBhyy.FormattingEnabled = true;
            this.cmbBhyy.Items.AddRange(new object[] {
            "原权利人已故",
            "分家析产",
            "房屋买卖",
            "房屋交换",
            "房屋抵押",
            "权利人名字登记错误",
            "赠与"});
            this.cmbBhyy.Location = new System.Drawing.Point(82, 157);
            this.cmbBhyy.Name = "cmbBhyy";
            this.cmbBhyy.Size = new System.Drawing.Size(190, 20);
            this.cmbBhyy.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "现使用人：";
            // 
            // txtSyr
            // 
            this.txtSyr.BeforeTouchSize = new System.Drawing.Size(258, 21);
            this.txtSyr.Enabled = false;
            this.txtSyr.EnableTouchMode = true;
            this.txtSyr.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSyr.Location = new System.Drawing.Point(14, 205);
            this.txtSyr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSyr.Name = "txtSyr";
            this.txtSyr.Size = new System.Drawing.Size(258, 28);
            this.txtSyr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSyr.TabIndex = 8;
            // 
            // frmQLRXZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 304);
            this.Controls.Add(this.txtSyr);
            this.Controls.Add(this.cmbBhyy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkQlrbh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lstQLR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLRXZ";
            this.Text = "权利人";
            ((System.ComponentModel.ISupportInitialize)(this.txtSyr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstQLR;
        private Syncfusion.Windows.Forms.ButtonAdv btnSelectAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private System.Windows.Forms.CheckBox chkQlrbh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBhyy;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSyr;
    }
}