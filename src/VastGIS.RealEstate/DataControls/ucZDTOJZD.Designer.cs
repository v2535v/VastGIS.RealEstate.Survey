using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZDTOJZD
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
        private void InitializeComponent()
        {
            this.intID = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtZD_WYDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZD_WYDM = new System.Windows.Forms.Label();
            this.txtJZD_WYDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJZD_WYDM = new System.Windows.Forms.Label();
            this.txtSXH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSXH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZD_WYDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZD_WYDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSXH)).BeginInit();           
            this.SuspendLayout();
            // 
            // intID
            // 
            this.intID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intID.EnableTouchMode = true;
            this.intID.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intID.Location = new System.Drawing.Point(100, 20);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";           
            this.intID.Size = new System.Drawing.Size(152, 21);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 1;
            this.intID.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intID.Text = "1.00";           
            this.intID.NullString = "";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 12);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtZD_WYDM
            // 
            this.txtZD_WYDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZD_WYDM.EnableTouchMode = true;
            this.txtZD_WYDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZD_WYDM.Location = new System.Drawing.Point(100, 55);
            this.txtZD_WYDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZD_WYDM.Name = "txtZD_WYDM";           
            this.txtZD_WYDM.Size = new System.Drawing.Size(152, 21);
            this.txtZD_WYDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZD_WYDM.TabIndex = 3;
            this.txtZD_WYDM.Text = "";   
            // 
            // lblZD_WYDM
            // 
            this.lblZD_WYDM.AutoSize = true;
            this.lblZD_WYDM.Location = new System.Drawing.Point(10, 59);
            this.lblZD_WYDM.Name = "lblZD_WYDM";
            this.lblZD_WYDM.Size = new System.Drawing.Size(65, 12);
            this.lblZD_WYDM.TabIndex = 4;
            this.lblZD_WYDM.Text = "ZD_WYDM";
            // 
            // txtJZD_WYDM
            // 
            this.txtJZD_WYDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtJZD_WYDM.EnableTouchMode = true;
            this.txtJZD_WYDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtJZD_WYDM.Location = new System.Drawing.Point(100, 90);
            this.txtJZD_WYDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJZD_WYDM.Name = "txtJZD_WYDM";           
            this.txtJZD_WYDM.Size = new System.Drawing.Size(152, 21);
            this.txtJZD_WYDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJZD_WYDM.TabIndex = 5;
            this.txtJZD_WYDM.Text = "";   
            // 
            // lblJZD_WYDM
            // 
            this.lblJZD_WYDM.AutoSize = true;
            this.lblJZD_WYDM.Location = new System.Drawing.Point(10, 94);
            this.lblJZD_WYDM.Name = "lblJZD_WYDM";
            this.lblJZD_WYDM.Size = new System.Drawing.Size(65, 12);
            this.lblJZD_WYDM.TabIndex = 6;
            this.lblJZD_WYDM.Text = "JZD_WYDM";
            // 
            // txtSXH
            // 
            this.txtSXH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtSXH.EnableTouchMode = true;
            this.txtSXH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtSXH.Location = new System.Drawing.Point(100, 125);
            this.txtSXH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSXH.Name = "txtSXH";           
            this.txtSXH.Size = new System.Drawing.Size(152, 21);
            this.txtSXH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSXH.TabIndex = 7;
            this.txtSXH.Text = "";   
            // 
            // lblSXH
            // 
            this.lblSXH.AutoSize = true;
            this.lblSXH.Location = new System.Drawing.Point(10, 129);
            this.lblSXH.Name = "lblSXH";
            this.lblSXH.Size = new System.Drawing.Size(65, 12);
            this.lblSXH.TabIndex = 8;
            this.lblSXH.Text = "SXH";
            
            // 
            // ucZDTOJZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZD_WYDM);                
            this.Controls.Add(this.lblZD_WYDM);            
            this.Controls.Add(this.txtJZD_WYDM);                
            this.Controls.Add(this.lblJZD_WYDM);            
            this.Controls.Add(this.txtSXH);                
            this.Controls.Add(this.lblSXH);            
            this.Name = "ucZDTOJZD";
            this.Size = new System.Drawing.Size(260, 170);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZD_WYDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZD_WYDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSXH)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZD_WYDM; 
        private System.Windows.Forms.Label lblZD_WYDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJZD_WYDM; 
        private System.Windows.Forms.Label lblJZD_WYDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSXH; 
        private System.Windows.Forms.Label lblSXH; 
    }

}