namespace VastGIS.Plugins.Symbology.Controls
{
    partial class PointIconControl
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
            this.iconControl1 = new VastGIS.Plugins.Symbology.Controls.ListControls.IconControl();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.chkScaleIcons = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboIconCollection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // iconControl1
            // 
            this.iconControl1.BackColor = System.Drawing.Color.Transparent;
            this.iconControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconControl1.CellHeight = 24;
            this.iconControl1.CellWidth = 24;
            this.iconControl1.FilePath = "";
            this.iconControl1.Font = new System.Drawing.Font("Arial", 25.6F);
            this.iconControl1.GridColor = System.Drawing.Color.Black;
            this.iconControl1.GridVisible = true;
            this.iconControl1.ItemCount = 0;
            this.iconControl1.Location = new System.Drawing.Point(0, 36);
            this.iconControl1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.iconControl1.Name = "iconControl1";
            this.iconControl1.SelectedIndex = -1;
            this.iconControl1.SelectedPath = "";
            this.iconControl1.Size = new System.Drawing.Size(395, 236);
            this.iconControl1.TabIndex = 77;
            this.iconControl1.Textures = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(394, 263);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(10, 9);
            this.lblCopyright.TabIndex = 74;
            // 
            // chkScaleIcons
            // 
            this.chkScaleIcons.AutoSize = true;
            this.chkScaleIcons.Location = new System.Drawing.Point(284, 9);
            this.chkScaleIcons.Name = "chkScaleIcons";
            this.chkScaleIcons.Size = new System.Drawing.Size(72, 16);
            this.chkScaleIcons.TabIndex = 78;
            this.chkScaleIcons.Text = "比例显示";
            this.chkScaleIcons.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "集合";
            // 
            // cboIconCollection
            // 
            this.cboIconCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIconCollection.FormattingEnabled = true;
            this.cboIconCollection.Location = new System.Drawing.Point(92, 7);
            this.cboIconCollection.Name = "cboIconCollection";
            this.cboIconCollection.Size = new System.Drawing.Size(177, 20);
            this.cboIconCollection.TabIndex = 75;
            // 
            // PointIconControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconControl1);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.chkScaleIcons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboIconCollection);
            this.Name = "PointIconControl";
            this.Size = new System.Drawing.Size(397, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListControls.IconControl iconControl1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.CheckBox chkScaleIcons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboIconCollection;
    }
}
