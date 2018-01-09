namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmDeleteFeature
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
            this.btnTargetLayer = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnTargetLayer
            // 
            this.btnTargetLayer.Location = new System.Drawing.Point(12, 10);
            this.btnTargetLayer.Name = "btnTargetLayer";
            this.btnTargetLayer.Size = new System.Drawing.Size(76, 23);
            this.btnTargetLayer.TabIndex = 5;
            this.btnTargetLayer.Text = "目标图层";
            this.btnTargetLayer.UseVisualStyleBackColor = true;
            this.btnTargetLayer.Click += new System.EventHandler(this.btnTargetLayer_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(94, 12);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(157, 21);
            this.txtTarget.TabIndex = 4;
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(191, 126);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(60, 23);
            this.btnCanel.TabIndex = 21;
            this.btnCanel.Text = "退出";
            this.btnCanel.UseVisualStyleBackColor = true;
            this.btnCanel.Click += new System.EventHandler(this.btnCanel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "选择要素：";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(12, 56);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(238, 68);
            this.lstSource.TabIndex = 22;
            this.lstSource.SelectedIndexChanged += new System.EventHandler(this.lstSource_SelectedIndexChanged);
            // 
            // frmDeleteFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 158);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTargetLayer);
            this.Controls.Add(this.txtTarget);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteFeature";
            this.Text = "删除要素";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTargetLayer;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox lstSource;
    }
}