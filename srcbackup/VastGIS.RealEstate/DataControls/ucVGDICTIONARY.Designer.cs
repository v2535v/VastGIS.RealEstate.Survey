using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGDICTIONARY
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
            this.txtZDZ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDZ = new System.Windows.Forms.Label();
            this.txtZDSM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSM = new System.Windows.Forms.Label();
            this.chkSFQS = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblSFQS = new System.Windows.Forms.Label();
            this.txtPX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblPX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSFQS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtPX)).BeginInit();           
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
            // txtZDZ
            // 
            this.txtZDZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDZ.EnableTouchMode = true;
            this.txtZDZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDZ.Location = new System.Drawing.Point(100, 90);
            this.txtZDZ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDZ.Name = "txtZDZ";           
            this.txtZDZ.Size = new System.Drawing.Size(152, 21);
            this.txtZDZ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDZ.TabIndex = 5;
            this.txtZDZ.Text = "";   
            // 
            // lblZDZ
            // 
            this.lblZDZ.AutoSize = true;
            this.lblZDZ.Location = new System.Drawing.Point(10, 94);
            this.lblZDZ.Name = "lblZDZ";
            this.lblZDZ.Size = new System.Drawing.Size(65, 12);
            this.lblZDZ.TabIndex = 6;
            this.lblZDZ.Text = "字典值";
            // 
            // txtZDSM
            // 
            this.txtZDSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSM.EnableTouchMode = true;
            this.txtZDSM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSM.Location = new System.Drawing.Point(100, 125);
            this.txtZDSM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSM.Name = "txtZDSM";           
            this.txtZDSM.Size = new System.Drawing.Size(152, 21);
            this.txtZDSM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSM.TabIndex = 7;
            this.txtZDSM.Text = "";   
            // 
            // lblZDSM
            // 
            this.lblZDSM.AutoSize = true;
            this.lblZDSM.Location = new System.Drawing.Point(10, 129);
            this.lblZDSM.Name = "lblZDSM";
            this.lblZDSM.Size = new System.Drawing.Size(65, 12);
            this.lblZDSM.TabIndex = 8;
            this.lblZDSM.Text = "字典值说明";
            // 
            // chkSFQS
            // 
            this.chkSFQS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkSFQS.EnableTouchMode = true;
            this.chkSFQS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkSFQS.Location = new System.Drawing.Point(100, 160);
            this.chkSFQS.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSFQS.Name = "chkSFQS";           
            this.chkSFQS.Size = new System.Drawing.Size(152, 21);
            this.chkSFQS.TabIndex = 9;
            this.chkSFQS.Text = "";  
            this.chkSFQS.ThemesEnabled = false;
             this.chkSFQS.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblSFQS
            // 
            this.lblSFQS.AutoSize = true;
            this.lblSFQS.Location = new System.Drawing.Point(10, 164);
            this.lblSFQS.Name = "lblSFQS";
            this.lblSFQS.Size = new System.Drawing.Size(65, 12);
            this.lblSFQS.TabIndex = 10;
            this.lblSFQS.Text = "是否缺省";
            // 
            // txtPX
            // 
            this.txtPX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtPX.EnableTouchMode = true;
            this.txtPX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtPX.Location = new System.Drawing.Point(100, 195);
            this.txtPX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPX.Name = "txtPX";           
            this.txtPX.Size = new System.Drawing.Size(152, 21);
            this.txtPX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPX.TabIndex = 11;
            this.txtPX.Text = "";   
            // 
            // lblPX
            // 
            this.lblPX.AutoSize = true;
            this.lblPX.Location = new System.Drawing.Point(10, 199);
            this.lblPX.Name = "lblPX";
            this.lblPX.Size = new System.Drawing.Size(65, 12);
            this.lblPX.TabIndex = 12;
            this.lblPX.Text = "排序";
            
            // 
            // ucVG_DICTIONARY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZDMC);                
            this.Controls.Add(this.lblZDMC);            
            this.Controls.Add(this.txtZDZ);                
            this.Controls.Add(this.lblZDZ);            
            this.Controls.Add(this.txtZDSM);                
            this.Controls.Add(this.lblZDSM);            
            this.Controls.Add(this.chkSFQS);                
            this.Controls.Add(this.lblSFQS);            
            this.Controls.Add(this.txtPX);                
            this.Controls.Add(this.lblPX);            
            this.Name = "ucVG_DICTIONARY";
            this.Size = new System.Drawing.Size(260, 240);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSFQS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtPX)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDMC; 
        private System.Windows.Forms.Label lblZDMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDZ; 
        private System.Windows.Forms.Label lblZDZ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSM; 
        private System.Windows.Forms.Label lblZDSM; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSFQS; 
        private System.Windows.Forms.Label lblSFQS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPX; 
        private System.Windows.Forms.Label lblPX; 
    }

}