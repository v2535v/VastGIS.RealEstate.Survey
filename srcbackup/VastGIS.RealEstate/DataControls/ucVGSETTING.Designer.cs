using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGSETTING
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
            this.txtCSMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCSMC = new System.Windows.Forms.Label();
            this.txtCSZ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCSZ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCSMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCSZ)).BeginInit();           
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
            this.lblID.Text = "标识码";
            // 
            // txtCSMC
            // 
            this.txtCSMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtCSMC.EnableTouchMode = true;
            this.txtCSMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtCSMC.Location = new System.Drawing.Point(100, 55);
            this.txtCSMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCSMC.Name = "txtCSMC";           
            this.txtCSMC.Size = new System.Drawing.Size(152, 21);
            this.txtCSMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCSMC.TabIndex = 3;
            this.txtCSMC.Text = "";   
            // 
            // lblCSMC
            // 
            this.lblCSMC.AutoSize = true;
            this.lblCSMC.Location = new System.Drawing.Point(10, 59);
            this.lblCSMC.Name = "lblCSMC";
            this.lblCSMC.Size = new System.Drawing.Size(65, 12);
            this.lblCSMC.TabIndex = 4;
            this.lblCSMC.Text = "参数名称";
            // 
            // txtCSZ
            // 
            this.txtCSZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtCSZ.EnableTouchMode = true;
            this.txtCSZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtCSZ.Location = new System.Drawing.Point(100, 90);
            this.txtCSZ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCSZ.Name = "txtCSZ";           
            this.txtCSZ.Size = new System.Drawing.Size(152, 21);
            this.txtCSZ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCSZ.TabIndex = 5;
            this.txtCSZ.Text = "";   
            // 
            // lblCSZ
            // 
            this.lblCSZ.AutoSize = true;
            this.lblCSZ.Location = new System.Drawing.Point(10, 94);
            this.lblCSZ.Name = "lblCSZ";
            this.lblCSZ.Size = new System.Drawing.Size(65, 12);
            this.lblCSZ.TabIndex = 6;
            this.lblCSZ.Text = "参数值";
            
            // 
            // ucVG_SETTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtCSMC);                
            this.Controls.Add(this.lblCSMC);            
            this.Controls.Add(this.txtCSZ);                
            this.Controls.Add(this.lblCSZ);            
            this.Name = "ucVG_SETTING";
            this.Size = new System.Drawing.Size(260, 135);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCSMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCSZ)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCSMC; 
        private System.Windows.Forms.Label lblCSMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCSZ; 
        private System.Windows.Forms.Label lblCSZ; 
    }

}