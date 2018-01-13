using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGLAYERGROUPDETAIL
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
            this.txtZM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZM = new System.Windows.Forms.Label();
            this.txtMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMC = new System.Windows.Forms.Label();
            this.chkIDENTIFY = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblIDENTIFY = new System.Windows.Forms.Label();
            this.chkEDITABLE = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblEDITABLE = new System.Windows.Forms.Label();
            this.chkQUERYABLE = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblQUERYABLE = new System.Windows.Forms.Label();
            this.chkSNAPABLE = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblSNAPABLE = new System.Windows.Forms.Label();
            this.chkVISIBLE = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblVISIBLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkIDENTIFY)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkEDITABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkQUERYABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSNAPABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkVISIBLE)).BeginInit();           
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
            // txtZM
            // 
            this.txtZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZM.EnableTouchMode = true;
            this.txtZM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZM.Location = new System.Drawing.Point(100, 55);
            this.txtZM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZM.Name = "txtZM";           
            this.txtZM.Size = new System.Drawing.Size(152, 21);
            this.txtZM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZM.TabIndex = 3;
            this.txtZM.Text = "";   
            // 
            // lblZM
            // 
            this.lblZM.AutoSize = true;
            this.lblZM.Location = new System.Drawing.Point(10, 59);
            this.lblZM.Name = "lblZM";
            this.lblZM.Size = new System.Drawing.Size(65, 12);
            this.lblZM.TabIndex = 4;
            this.lblZM.Text = "ZM";
            // 
            // txtMC
            // 
            this.txtMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtMC.EnableTouchMode = true;
            this.txtMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtMC.Location = new System.Drawing.Point(100, 90);
            this.txtMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMC.Name = "txtMC";           
            this.txtMC.Size = new System.Drawing.Size(152, 21);
            this.txtMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMC.TabIndex = 5;
            this.txtMC.Text = "";   
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Location = new System.Drawing.Point(10, 94);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(65, 12);
            this.lblMC.TabIndex = 6;
            this.lblMC.Text = "MC";
            // 
            // chkIDENTIFY
            // 
            this.chkIDENTIFY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkIDENTIFY.EnableTouchMode = true;
            this.chkIDENTIFY.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkIDENTIFY.Location = new System.Drawing.Point(100, 125);
            this.chkIDENTIFY.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIDENTIFY.Name = "chkIDENTIFY";           
            this.chkIDENTIFY.Size = new System.Drawing.Size(152, 21);
            this.chkIDENTIFY.TabIndex = 7;
            this.chkIDENTIFY.Text = "";  
            this.chkIDENTIFY.ThemesEnabled = false;
             this.chkIDENTIFY.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblIDENTIFY
            // 
            this.lblIDENTIFY.AutoSize = true;
            this.lblIDENTIFY.Location = new System.Drawing.Point(10, 129);
            this.lblIDENTIFY.Name = "lblIDENTIFY";
            this.lblIDENTIFY.Size = new System.Drawing.Size(65, 12);
            this.lblIDENTIFY.TabIndex = 8;
            this.lblIDENTIFY.Text = "IDENTIFY";
            // 
            // chkEDITABLE
            // 
            this.chkEDITABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkEDITABLE.EnableTouchMode = true;
            this.chkEDITABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkEDITABLE.Location = new System.Drawing.Point(100, 160);
            this.chkEDITABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkEDITABLE.Name = "chkEDITABLE";           
            this.chkEDITABLE.Size = new System.Drawing.Size(152, 21);
            this.chkEDITABLE.TabIndex = 9;
            this.chkEDITABLE.Text = "";  
            this.chkEDITABLE.ThemesEnabled = false;
             this.chkEDITABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblEDITABLE
            // 
            this.lblEDITABLE.AutoSize = true;
            this.lblEDITABLE.Location = new System.Drawing.Point(10, 164);
            this.lblEDITABLE.Name = "lblEDITABLE";
            this.lblEDITABLE.Size = new System.Drawing.Size(65, 12);
            this.lblEDITABLE.TabIndex = 10;
            this.lblEDITABLE.Text = "EDITABLE";
            // 
            // chkQUERYABLE
            // 
            this.chkQUERYABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkQUERYABLE.EnableTouchMode = true;
            this.chkQUERYABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkQUERYABLE.Location = new System.Drawing.Point(100, 195);
            this.chkQUERYABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkQUERYABLE.Name = "chkQUERYABLE";           
            this.chkQUERYABLE.Size = new System.Drawing.Size(152, 21);
            this.chkQUERYABLE.TabIndex = 11;
            this.chkQUERYABLE.Text = "";  
            this.chkQUERYABLE.ThemesEnabled = false;
             this.chkQUERYABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblQUERYABLE
            // 
            this.lblQUERYABLE.AutoSize = true;
            this.lblQUERYABLE.Location = new System.Drawing.Point(10, 199);
            this.lblQUERYABLE.Name = "lblQUERYABLE";
            this.lblQUERYABLE.Size = new System.Drawing.Size(65, 12);
            this.lblQUERYABLE.TabIndex = 12;
            this.lblQUERYABLE.Text = "QUERYABLE";
            // 
            // chkSNAPABLE
            // 
            this.chkSNAPABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkSNAPABLE.EnableTouchMode = true;
            this.chkSNAPABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkSNAPABLE.Location = new System.Drawing.Point(100, 230);
            this.chkSNAPABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSNAPABLE.Name = "chkSNAPABLE";           
            this.chkSNAPABLE.Size = new System.Drawing.Size(152, 21);
            this.chkSNAPABLE.TabIndex = 13;
            this.chkSNAPABLE.Text = "";  
            this.chkSNAPABLE.ThemesEnabled = false;
             this.chkSNAPABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblSNAPABLE
            // 
            this.lblSNAPABLE.AutoSize = true;
            this.lblSNAPABLE.Location = new System.Drawing.Point(10, 234);
            this.lblSNAPABLE.Name = "lblSNAPABLE";
            this.lblSNAPABLE.Size = new System.Drawing.Size(65, 12);
            this.lblSNAPABLE.TabIndex = 14;
            this.lblSNAPABLE.Text = "SNAPABLE";
            // 
            // chkVISIBLE
            // 
            this.chkVISIBLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkVISIBLE.EnableTouchMode = true;
            this.chkVISIBLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkVISIBLE.Location = new System.Drawing.Point(100, 265);
            this.chkVISIBLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkVISIBLE.Name = "chkVISIBLE";           
            this.chkVISIBLE.Size = new System.Drawing.Size(152, 21);
            this.chkVISIBLE.TabIndex = 15;
            this.chkVISIBLE.Text = "";  
            this.chkVISIBLE.ThemesEnabled = false;
             this.chkVISIBLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblVISIBLE
            // 
            this.lblVISIBLE.AutoSize = true;
            this.lblVISIBLE.Location = new System.Drawing.Point(10, 269);
            this.lblVISIBLE.Name = "lblVISIBLE";
            this.lblVISIBLE.Size = new System.Drawing.Size(65, 12);
            this.lblVISIBLE.TabIndex = 16;
            this.lblVISIBLE.Text = "VISIBLE";
            
            // 
            // ucVG_LAYERGROUPDETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZM);                
            this.Controls.Add(this.lblZM);            
            this.Controls.Add(this.txtMC);                
            this.Controls.Add(this.lblMC);            
            this.Controls.Add(this.chkIDENTIFY);                
            this.Controls.Add(this.lblIDENTIFY);            
            this.Controls.Add(this.chkEDITABLE);                
            this.Controls.Add(this.lblEDITABLE);            
            this.Controls.Add(this.chkQUERYABLE);                
            this.Controls.Add(this.lblQUERYABLE);            
            this.Controls.Add(this.chkSNAPABLE);                
            this.Controls.Add(this.lblSNAPABLE);            
            this.Controls.Add(this.chkVISIBLE);                
            this.Controls.Add(this.lblVISIBLE);            
            this.Name = "ucVG_LAYERGROUPDETAIL";
            this.Size = new System.Drawing.Size(260, 310);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkIDENTIFY)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkEDITABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkQUERYABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSNAPABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkVISIBLE)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZM; 
        private System.Windows.Forms.Label lblZM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMC; 
        private System.Windows.Forms.Label lblMC; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkIDENTIFY; 
        private System.Windows.Forms.Label lblIDENTIFY; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkEDITABLE; 
        private System.Windows.Forms.Label lblEDITABLE; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkQUERYABLE; 
        private System.Windows.Forms.Label lblQUERYABLE; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSNAPABLE; 
        private System.Windows.Forms.Label lblSNAPABLE; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkVISIBLE; 
        private System.Windows.Forms.Label lblVISIBLE; 
    }

}