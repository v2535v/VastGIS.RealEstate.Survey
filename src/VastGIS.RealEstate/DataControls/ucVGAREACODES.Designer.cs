using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGAREACODES
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
            this.txtXZQHMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXZQHMC = new System.Windows.Forms.Label();
            this.txtXZQHDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXZQHDM = new System.Windows.Forms.Label();
            this.intXZQHJB = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblXZQHJB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQHMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQHDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXZQHJB)).BeginInit();           
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
            // txtXZQHMC
            // 
            this.txtXZQHMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXZQHMC.EnableTouchMode = true;
            this.txtXZQHMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXZQHMC.Location = new System.Drawing.Point(100, 55);
            this.txtXZQHMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXZQHMC.Name = "txtXZQHMC";           
            this.txtXZQHMC.Size = new System.Drawing.Size(152, 21);
            this.txtXZQHMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXZQHMC.TabIndex = 3;
            this.txtXZQHMC.Text = "";   
            // 
            // lblXZQHMC
            // 
            this.lblXZQHMC.AutoSize = true;
            this.lblXZQHMC.Location = new System.Drawing.Point(10, 59);
            this.lblXZQHMC.Name = "lblXZQHMC";
            this.lblXZQHMC.Size = new System.Drawing.Size(65, 12);
            this.lblXZQHMC.TabIndex = 4;
            this.lblXZQHMC.Text = "XZQHMC";
            // 
            // txtXZQHDM
            // 
            this.txtXZQHDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXZQHDM.EnableTouchMode = true;
            this.txtXZQHDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXZQHDM.Location = new System.Drawing.Point(100, 90);
            this.txtXZQHDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXZQHDM.Name = "txtXZQHDM";           
            this.txtXZQHDM.Size = new System.Drawing.Size(152, 21);
            this.txtXZQHDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXZQHDM.TabIndex = 5;
            this.txtXZQHDM.Text = "";   
            // 
            // lblXZQHDM
            // 
            this.lblXZQHDM.AutoSize = true;
            this.lblXZQHDM.Location = new System.Drawing.Point(10, 94);
            this.lblXZQHDM.Name = "lblXZQHDM";
            this.lblXZQHDM.Size = new System.Drawing.Size(65, 12);
            this.lblXZQHDM.TabIndex = 6;
            this.lblXZQHDM.Text = "XZQHDM";
            // 
            // intXZQHJB
            // 
            this.intXZQHJB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intXZQHJB.EnableTouchMode = true;
            this.intXZQHJB.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intXZQHJB.Location = new System.Drawing.Point(100, 125);
            this.intXZQHJB.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXZQHJB.Name = "intXZQHJB";           
            this.intXZQHJB.Size = new System.Drawing.Size(152, 21);
            this.intXZQHJB.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXZQHJB.TabIndex = 7;
            this.intXZQHJB.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXZQHJB.Text = "1.00";           
            this.intXZQHJB.NullString = "";
            // 
            // lblXZQHJB
            // 
            this.lblXZQHJB.AutoSize = true;
            this.lblXZQHJB.Location = new System.Drawing.Point(10, 129);
            this.lblXZQHJB.Name = "lblXZQHJB";
            this.lblXZQHJB.Size = new System.Drawing.Size(65, 12);
            this.lblXZQHJB.TabIndex = 8;
            this.lblXZQHJB.Text = "XZQHJB";
            
            // 
            // ucVG_AREACODES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtXZQHMC);                
            this.Controls.Add(this.lblXZQHMC);            
            this.Controls.Add(this.txtXZQHDM);                
            this.Controls.Add(this.lblXZQHDM);            
            this.Controls.Add(this.intXZQHJB);                
            this.Controls.Add(this.lblXZQHJB);            
            this.Name = "ucVG_AREACODES";
            this.Size = new System.Drawing.Size(260, 170);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQHMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQHDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXZQHJB)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXZQHMC; 
        private System.Windows.Forms.Label lblXZQHMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXZQHDM; 
        private System.Windows.Forms.Label lblXZQHDM; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXZQHJB; 
        private System.Windows.Forms.Label lblXZQHJB; 
    }

}