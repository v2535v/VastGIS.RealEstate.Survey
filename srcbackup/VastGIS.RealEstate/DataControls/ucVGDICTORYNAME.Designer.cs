using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGDICTORYNAME
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
            this.txtZDMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDMC = new System.Windows.Forms.Label();
            this.txtZDSM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSM)).BeginInit();           
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
            // txtZDMC
            // 
            this.txtZDMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDMC.EnableTouchMode = true;
            this.txtZDMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDMC.Location = new System.Drawing.Point(100, 55);
            this.txtZDMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDMC.Name = "txtZDMC";           
            this.txtZDMC.Size = new System.Drawing.Size(152, 21);
            this.txtZDMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDMC.TabIndex = 3;
            this.txtZDMC.Text = "";   
            // 
            // lblZDMC
            // 
            this.lblZDMC.AutoSize = true;
            this.lblZDMC.Location = new System.Drawing.Point(10, 59);
            this.lblZDMC.Name = "lblZDMC";
            this.lblZDMC.Size = new System.Drawing.Size(65, 12);
            this.lblZDMC.TabIndex = 4;
            this.lblZDMC.Text = "字典名称";
            // 
            // txtZDSM
            // 
            this.txtZDSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSM.EnableTouchMode = true;
            this.txtZDSM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSM.Location = new System.Drawing.Point(100, 90);
            this.txtZDSM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSM.Name = "txtZDSM";           
            this.txtZDSM.Size = new System.Drawing.Size(152, 21);
            this.txtZDSM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSM.TabIndex = 5;
            this.txtZDSM.Text = "";   
            // 
            // lblZDSM
            // 
            this.lblZDSM.AutoSize = true;
            this.lblZDSM.Location = new System.Drawing.Point(10, 94);
            this.lblZDSM.Name = "lblZDSM";
            this.lblZDSM.Size = new System.Drawing.Size(65, 12);
            this.lblZDSM.TabIndex = 6;
            this.lblZDSM.Text = "ZDSM";
            
            // 
            // ucVG_DICTORYNAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZDMC);                
            this.Controls.Add(this.lblZDMC);            
            this.Controls.Add(this.txtZDSM);                
            this.Controls.Add(this.lblZDSM);            
            this.Name = "ucVG_DICTORYNAME";
            this.Size = new System.Drawing.Size(260, 135);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSM)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDMC; 
        private System.Windows.Forms.Label lblZDMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSM; 
        private System.Windows.Forms.Label lblZDSM; 
    }

}