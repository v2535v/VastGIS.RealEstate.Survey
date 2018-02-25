namespace VastGIS.Plugins.RealEstate.EditSettings
{
    partial class EditingCreateJZDByPolygon
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
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnGetDJZQ = new System.Windows.Forms.Button();
            this.txtDJZQ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.lblSelectedLayer = new System.Windows.Forms.Label();
            this.lstSelectedLayers = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDJZQ)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(295, 261);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(13, 13);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(295, 261);
            this.tabControlAdv1.TabIndex = 0;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.dataGridView1);
            this.tabPageAdv1.Controls.Add(this.btnGetDJZQ);
            this.tabPageAdv1.Controls.Add(this.txtDJZQ);
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(292, 235);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "界址点";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // btnGetDJZQ
            // 
            this.btnGetDJZQ.Location = new System.Drawing.Point(228, 196);
            this.btnGetDJZQ.Name = "btnGetDJZQ";
            this.btnGetDJZQ.Size = new System.Drawing.Size(54, 23);
            this.btnGetDJZQ.TabIndex = 3;
            this.btnGetDJZQ.Text = "获取";
            this.btnGetDJZQ.UseVisualStyleBackColor = true;
            // 
            // txtDJZQ
            // 
            this.txtDJZQ.BeforeTouchSize = new System.Drawing.Size(132, 21);
            this.txtDJZQ.Location = new System.Drawing.Point(90, 196);
            this.txtDJZQ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDJZQ.Name = "txtDJZQ";
            this.txtDJZQ.Size = new System.Drawing.Size(132, 21);
            this.txtDJZQ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDJZQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "所在地籍子区：";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.lblSelectedLayer);
            this.tabPageAdv2.Controls.Add(this.lstSelectedLayers);
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.ShowCloseButton = true;
            this.tabPageAdv2.Size = new System.Drawing.Size(292, 235);
            this.tabPageAdv2.TabIndex = 2;
            this.tabPageAdv2.Text = "选择设置";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // lblSelectedLayer
            // 
            this.lblSelectedLayer.AutoSize = true;
            this.lblSelectedLayer.Location = new System.Drawing.Point(13, 4);
            this.lblSelectedLayer.Name = "lblSelectedLayer";
            this.lblSelectedLayer.Size = new System.Drawing.Size(53, 12);
            this.lblSelectedLayer.TabIndex = 1;
            this.lblSelectedLayer.Text = "选择图层";
            // 
            // lstSelectedLayers
            // 
            this.lstSelectedLayers.FormattingEnabled = true;
            this.lstSelectedLayers.Location = new System.Drawing.Point(13, 23);
            this.lstSelectedLayers.Name = "lstSelectedLayers";
            this.lstSelectedLayers.Size = new System.Drawing.Size(264, 196);
            this.lstSelectedLayers.TabIndex = 0;
            this.lstSelectedLayers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstSelectedLayers_ItemCheck);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(273, 177);
            this.dataGridView1.TabIndex = 4;
            // 
            // EditingCreateJZDByPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 320);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "EditingCreateJZDByPolygon";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.Text = "依据多边形生成界址点";
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDJZQ)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetDJZQ;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDJZQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedLayer;
        private System.Windows.Forms.CheckedListBox lstSelectedLayers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}