﻿using VastGIS.UI.Controls;

namespace VastGIS.UI.Forms
{
    partial class OptionsForm
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblColorText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkDontShow = new System.Windows.Forms.CheckBox();
            this.colorPicker = new VastGIS.UI.Controls.Office2007ColorPicker();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(18, 18);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(274, 32);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Please select the option:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(180, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(276, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkDontShow
            // 
            this.chkDontShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDontShow.AutoSize = true;
            this.chkDontShow.Location = new System.Drawing.Point(21, 189);
            this.chkDontShow.Name = "chkDontShow";
            this.chkDontShow.Size = new System.Drawing.Size(127, 17);
            this.chkDontShow.TabIndex = 7;
            this.chkDontShow.Text = "Always use this value";
            this.chkDontShow.UseVisualStyleBackColor = true;
            this.chkDontShow.Visible = false;
            // 
            // lblColorText
            // 
            this.lblColorText.Location = new System.Drawing.Point(18, 150);
            this.lblColorText.Name = "lblColorText";
            this.lblColorText.Size = new System.Drawing.Size(174, 32);
            this.lblColorText.TabIndex = 8;
            this.lblColorText.Text = "Please select the selection color:";
            // 
            // colorPicker
            // 
            this.colorPicker.Color = System.Drawing.Color.Yellow;
            this.colorPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorPicker.DropDownHeight = 1;
            this.colorPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPicker.FormattingEnabled = true;
            this.colorPicker.IntegralHeight = false;
            this.colorPicker.Items.AddRange(new object[] { "Color" });
            this.colorPicker.Location = new System.Drawing.Point(190, 150);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(74, 21);
            this.colorPicker.TabIndex = 120;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.CaptionFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(378, 217);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.lblColorText);
            this.Controls.Add(this.chkDontShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MapWindow";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblColorText;
        protected System.Windows.Forms.Label lblText;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.CheckBox chkDontShow;
        protected Office2007ColorPicker colorPicker;

    }
}