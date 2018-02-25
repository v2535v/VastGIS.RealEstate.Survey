namespace VastGIS.Plugins.RealEstate.Viewer
{
    partial class frmImageViewer
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
            this.ucImageViewer1 = new VastGIS.Plugins.RealEstate.Viewer.ucImageViewer();
            this.SuspendLayout();
            // 
            // ucImageViewer1
            // 
            this.ucImageViewer1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ucImageViewer1.CurrentImageIndex = 0;
            this.ucImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucImageViewer1.GifAnimation = false;
            this.ucImageViewer1.GifFPS = 15D;
            this.ucImageViewer1.Image = null;
            this.ucImageViewer1.Location = new System.Drawing.Point(0, 0);
            this.ucImageViewer1.Name = "ucImageViewer1";
            this.ucImageViewer1.Rotation = 0;
            this.ucImageViewer1.Scrollbars = false;
            this.ucImageViewer1.Size = new System.Drawing.Size(600, 415);
            this.ucImageViewer1.TabIndex = 0;
            this.ucImageViewer1.Zoom = 100D;
            // 
            // frmImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 415);
            this.Controls.Add(this.ucImageViewer1);
            this.Name = "frmImageViewer";
            this.Text = "图片查看器";
            this.ResumeLayout(false);

        }

        #endregion

        private ucImageViewer ucImageViewer1;
    }
}