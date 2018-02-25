namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmSplitCAD
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
            this.lstLayers = new System.Windows.Forms.CheckedListBox();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.txtPair = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分层配置";
            // 
            // lstLayers
            // 
            this.lstLayers.FormattingEnabled = true;
            this.lstLayers.Location = new System.Drawing.Point(15, 40);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(347, 228);
            this.lstLayers.TabIndex = 2;
            this.lstLayers.SelectedIndexChanged += new System.EventHandler(this.lstLayers_SelectedIndexChanged);
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.Checked = true;
            this.chkClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClear.Location = new System.Drawing.Point(86, 12);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(144, 16);
            this.chkClear.TabIndex = 3;
            this.chkClear.Text = "同时删除临时表内数据";
            this.chkClear.UseVisualStyleBackColor = true;
            // 
            // txtPair
            // 
            this.txtPair.Location = new System.Drawing.Point(15, 275);
            this.txtPair.Name = "txtPair";
            this.txtPair.Size = new System.Drawing.Size(261, 21);
            this.txtPair.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(201, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "分层";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(283, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Checked = true;
            this.chkOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOther.Location = new System.Drawing.Point(246, 12);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(96, 16);
            this.chkOther.TabIndex = 8;
            this.chkOther.Text = "使用其他图层";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // frmSplitCAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 366);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPair);
            this.Controls.Add(this.chkClear);
            this.Controls.Add(this.lstLayers);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplitCAD";
            this.Text = "临时CAD分层处理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstLayers;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.TextBox txtPair;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkOther;
    }
}