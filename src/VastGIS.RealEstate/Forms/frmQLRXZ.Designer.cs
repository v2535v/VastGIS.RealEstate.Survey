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
            this.chkQlrwbh = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBhyy = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBhyy)).BeginInit();
            this.SuspendLayout();
            // 
            // lstQLR
            // 
            this.lstQLR.FormattingEnabled = true;
            this.lstQLR.Location = new System.Drawing.Point(13, 13);
            this.lstQLR.Name = "lstQLR";
            this.lstQLR.Size = new System.Drawing.Size(259, 180);
            this.lstQLR.TabIndex = 0;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnSelectAll.EnableTouchMode = true;
            this.btnSelectAll.IsBackStageButton = false;
            this.btnSelectAll.Location = new System.Drawing.Point(13, 260);
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
            this.btnOK.Location = new System.Drawing.Point(110, 260);
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
            this.btnCancel.Location = new System.Drawing.Point(194, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkQlrwbh
            // 
            this.chkQlrwbh.AutoSize = true;
            this.chkQlrwbh.Checked = true;
            this.chkQlrwbh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQlrwbh.Location = new System.Drawing.Point(13, 199);
            this.chkQlrwbh.Name = "chkQlrwbh";
            this.chkQlrwbh.Size = new System.Drawing.Size(120, 16);
            this.chkQlrwbh.TabIndex = 4;
            this.chkQlrwbh.Text = "权利人未发生变化";
            this.chkQlrwbh.UseVisualStyleBackColor = true;
            this.chkQlrwbh.CheckedChanged += new System.EventHandler(this.chkQlrwbh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "变化原因：";
            // 
            // cmbBhyy
            // 
            this.cmbBhyy.BeforeTouchSize = new System.Drawing.Size(205, 20);
            this.cmbBhyy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBhyy.EnableTouchMode = true;
            this.cmbBhyy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBhyy.Items.AddRange(new object[] {
            "原权利人已故",
            "分家析产",
            "房屋买卖",
            "房屋交换",
            "房屋抵押",
            "权利人名字登记错误",
            "赠与"});
            this.cmbBhyy.Location = new System.Drawing.Point(67, 221);
            this.cmbBhyy.Name = "cmbBhyy";
            this.cmbBhyy.Size = new System.Drawing.Size(205, 26);
            this.cmbBhyy.TabIndex = 5;
            // 
            // frmQLRXZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.cmbBhyy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkQlrwbh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lstQLR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLRXZ";
            this.Text = "权利人";
            ((System.ComponentModel.ISupportInitialize)(this.cmbBhyy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstQLR;
        private Syncfusion.Windows.Forms.ButtonAdv btnSelectAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private System.Windows.Forms.CheckBox chkQlrwbh;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbBhyy;
    }
}