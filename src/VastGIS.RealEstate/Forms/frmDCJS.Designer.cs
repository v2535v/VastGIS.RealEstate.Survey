namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmDCJS
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
            this.txtJS = new System.Windows.Forms.RichTextBox();
            this.btnQLR = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnZJ = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGKJ = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnMJSZ = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClear = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCreate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // txtJS
            // 
            this.txtJS.Location = new System.Drawing.Point(13, 13);
            this.txtJS.Name = "txtJS";
            this.txtJS.Size = new System.Drawing.Size(389, 264);
            this.txtJS.TabIndex = 0;
            this.txtJS.Text = "";
            // 
            // btnQLR
            // 
            this.btnQLR.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnQLR.EnableTouchMode = true;
            this.btnQLR.IsBackStageButton = false;
            this.btnQLR.Location = new System.Drawing.Point(13, 284);
            this.btnQLR.Name = "btnQLR";
            this.btnQLR.Size = new System.Drawing.Size(88, 34);
            this.btnQLR.TabIndex = 1;
            this.btnQLR.Text = "权利人";
            this.btnQLR.Click += new System.EventHandler(this.btnQLR_Click);
            // 
            // btnZJ
            // 
            this.btnZJ.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnZJ.EnableTouchMode = true;
            this.btnZJ.IsBackStageButton = false;
            this.btnZJ.Location = new System.Drawing.Point(113, 284);
            this.btnZJ.Name = "btnZJ";
            this.btnZJ.Size = new System.Drawing.Size(88, 34);
            this.btnZJ.TabIndex = 2;
            this.btnZJ.Text = "证件";
            this.btnZJ.Click += new System.EventHandler(this.btnZJ_Click);
            // 
            // btnGKJ
            // 
            this.btnGKJ.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnGKJ.EnableTouchMode = true;
            this.btnGKJ.IsBackStageButton = false;
            this.btnGKJ.Location = new System.Drawing.Point(213, 284);
            this.btnGKJ.Name = "btnGKJ";
            this.btnGKJ.Size = new System.Drawing.Size(88, 34);
            this.btnGKJ.TabIndex = 3;
            this.btnGKJ.Text = "改扩建";
            // 
            // btnMJSZ
            // 
            this.btnMJSZ.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnMJSZ.EnableTouchMode = true;
            this.btnMJSZ.IsBackStageButton = false;
            this.btnMJSZ.Location = new System.Drawing.Point(313, 284);
            this.btnMJSZ.Name = "btnMJSZ";
            this.btnMJSZ.Size = new System.Drawing.Size(88, 34);
            this.btnMJSZ.TabIndex = 4;
            this.btnMJSZ.Text = "面积四至";
            // 
            // btnCancel
            // 
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancel.EnableTouchMode = true;
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(313, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.EnableTouchMode = true;
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(213, 333);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 34);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            // 
            // btnClear
            // 
            this.btnClear.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClear.EnableTouchMode = true;
            this.btnClear.IsBackStageButton = false;
            this.btnClear.Location = new System.Drawing.Point(13, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空";
            // 
            // btnCreate
            // 
            this.btnCreate.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCreate.EnableTouchMode = true;
            this.btnCreate.IsBackStageButton = false;
            this.btnCreate.Location = new System.Drawing.Point(113, 331);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 34);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "生成";
            // 
            // frmDCJS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 377);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnMJSZ);
            this.Controls.Add(this.btnGKJ);
            this.Controls.Add(this.btnZJ);
            this.Controls.Add(this.btnQLR);
            this.Controls.Add(this.txtJS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDCJS";
            this.Text = "调查记事生成器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtJS;
        private Syncfusion.Windows.Forms.ButtonAdv btnQLR;
        private Syncfusion.Windows.Forms.ButtonAdv btnZJ;
        private Syncfusion.Windows.Forms.ButtonAdv btnGKJ;
        private Syncfusion.Windows.Forms.ButtonAdv btnMJSZ;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.ButtonAdv btnClear;
        private Syncfusion.Windows.Forms.ButtonAdv btnCreate;
    }
}