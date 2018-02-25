namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmSelectLayer
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
            this.lstLayers = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRevSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstLayers
            // 
            this.lstLayers.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstLayers.FormattingEnabled = true;
            this.lstLayers.ItemHeight = 16;
            this.lstLayers.Location = new System.Drawing.Point(124, 36);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(151, 244);
            this.lstLayers.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "选择";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 288);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(12, 7);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRevSelect
            // 
            this.btnRevSelect.Location = new System.Drawing.Point(102, 7);
            this.btnRevSelect.Name = "btnRevSelect";
            this.btnRevSelect.Size = new System.Drawing.Size(77, 23);
            this.btnRevSelect.TabIndex = 5;
            this.btnRevSelect.Text = "反选";
            this.btnRevSelect.UseVisualStyleBackColor = true;
            this.btnRevSelect.Click += new System.EventHandler(this.btnRevSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清空选择";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstGroup
            // 
            this.lstGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.ItemHeight = 16;
            this.lstGroup.Location = new System.Drawing.Point(12, 36);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(106, 244);
            this.lstGroup.TabIndex = 7;
            this.lstGroup.SelectedIndexChanged += new System.EventHandler(this.lstGroup_SelectedIndexChanged);
            // 
            // frmSelectLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 318);
            this.Controls.Add(this.lstGroup);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRevSelect);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstLayers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLayer";
            this.Text = "选择图层";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstLayers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnRevSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstGroup;
    }
}