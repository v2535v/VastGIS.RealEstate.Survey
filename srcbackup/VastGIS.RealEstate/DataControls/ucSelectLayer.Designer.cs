namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSelectLayer
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
            this.btnTargetLayer = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTargetLayer
            // 
            this.btnTargetLayer.Location = new System.Drawing.Point(0, 1);
            this.btnTargetLayer.Name = "btnTargetLayer";
            this.btnTargetLayer.Size = new System.Drawing.Size(76, 23);
            this.btnTargetLayer.TabIndex = 6;
            this.btnTargetLayer.Text = "目标图层";
            this.btnTargetLayer.UseVisualStyleBackColor = true;
            this.btnTargetLayer.Click += new System.EventHandler(this.btnTargetLayer_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(82, 2);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(168, 21);
            this.txtTarget.TabIndex = 7;
            // 
            // ucSelectLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnTargetLayer);
            this.Name = "ucSelectLayer";
            this.Size = new System.Drawing.Size(250, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTargetLayer;
        private System.Windows.Forms.TextBox txtTarget;
    }
}
