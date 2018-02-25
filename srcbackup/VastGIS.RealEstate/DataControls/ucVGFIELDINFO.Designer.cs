using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGFIELDINFO
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
            this.txtBM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBM = new System.Windows.Forms.Label();
            this.intBNSX = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblBNSX = new System.Windows.Forms.Label();
            this.txtZDZWMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDZWMC = new System.Windows.Forms.Label();
            this.txtZDMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDMC = new System.Windows.Forms.Label();
            this.txtZDLX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDLX = new System.Windows.Forms.Label();
            this.intZDCD = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZDCD = new System.Windows.Forms.Label();
            this.intZDXSWS = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZDXSWS = new System.Windows.Forms.Label();
            this.txtSYZD = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSYZD = new System.Windows.Forms.Label();
            this.txtYS = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYS = new System.Windows.Forms.Label();
            this.txtSYZDYW = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSYZDYW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intBNSX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZWMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intZDCD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intZDXSWS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSYZD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSYZDYW)).BeginInit();           
            this.SuspendLayout();
            // 
            // txtBM
            // 
            this.txtBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBM.EnableTouchMode = true;
            this.txtBM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBM.Location = new System.Drawing.Point(100, 20);
            this.txtBM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBM.Name = "txtBM";           
            this.txtBM.Size = new System.Drawing.Size(152, 21);
            this.txtBM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBM.TabIndex = 1;
            this.txtBM.Text = "";   
            // 
            // lblBM
            // 
            this.lblBM.AutoSize = true;
            this.lblBM.Location = new System.Drawing.Point(10, 24);
            this.lblBM.Name = "lblBM";
            this.lblBM.Size = new System.Drawing.Size(65, 12);
            this.lblBM.TabIndex = 2;
            this.lblBM.Text = "表名";
            // 
            // intBNSX
            // 
            this.intBNSX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intBNSX.EnableTouchMode = true;
            this.intBNSX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intBNSX.Location = new System.Drawing.Point(100, 55);
            this.intBNSX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intBNSX.Name = "intBNSX";           
            this.intBNSX.Size = new System.Drawing.Size(152, 21);
            this.intBNSX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intBNSX.TabIndex = 3;
            this.intBNSX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intBNSX.Text = "1.00";           
            this.intBNSX.NullString = "";
            // 
            // lblBNSX
            // 
            this.lblBNSX.AutoSize = true;
            this.lblBNSX.Location = new System.Drawing.Point(10, 59);
            this.lblBNSX.Name = "lblBNSX";
            this.lblBNSX.Size = new System.Drawing.Size(65, 12);
            this.lblBNSX.TabIndex = 4;
            this.lblBNSX.Text = "表内顺序";
            // 
            // txtZDZWMC
            // 
            this.txtZDZWMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDZWMC.EnableTouchMode = true;
            this.txtZDZWMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDZWMC.Location = new System.Drawing.Point(100, 90);
            this.txtZDZWMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDZWMC.Name = "txtZDZWMC";           
            this.txtZDZWMC.Size = new System.Drawing.Size(152, 21);
            this.txtZDZWMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDZWMC.TabIndex = 5;
            this.txtZDZWMC.Text = "";   
            // 
            // lblZDZWMC
            // 
            this.lblZDZWMC.AutoSize = true;
            this.lblZDZWMC.Location = new System.Drawing.Point(10, 94);
            this.lblZDZWMC.Name = "lblZDZWMC";
            this.lblZDZWMC.Size = new System.Drawing.Size(65, 12);
            this.lblZDZWMC.TabIndex = 6;
            this.lblZDZWMC.Text = "字段中文名称";
            // 
            // txtZDMC
            // 
            this.txtZDMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDMC.EnableTouchMode = true;
            this.txtZDMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDMC.Location = new System.Drawing.Point(100, 125);
            this.txtZDMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDMC.Name = "txtZDMC";           
            this.txtZDMC.Size = new System.Drawing.Size(152, 21);
            this.txtZDMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDMC.TabIndex = 7;
            this.txtZDMC.Text = "";   
            // 
            // lblZDMC
            // 
            this.lblZDMC.AutoSize = true;
            this.lblZDMC.Location = new System.Drawing.Point(10, 129);
            this.lblZDMC.Name = "lblZDMC";
            this.lblZDMC.Size = new System.Drawing.Size(65, 12);
            this.lblZDMC.TabIndex = 8;
            this.lblZDMC.Text = "字段名称";
            // 
            // txtZDLX
            // 
            this.txtZDLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDLX.EnableTouchMode = true;
            this.txtZDLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDLX.Location = new System.Drawing.Point(100, 160);
            this.txtZDLX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDLX.Name = "txtZDLX";           
            this.txtZDLX.Size = new System.Drawing.Size(152, 21);
            this.txtZDLX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDLX.TabIndex = 9;
            this.txtZDLX.Text = "";   
            // 
            // lblZDLX
            // 
            this.lblZDLX.AutoSize = true;
            this.lblZDLX.Location = new System.Drawing.Point(10, 164);
            this.lblZDLX.Name = "lblZDLX";
            this.lblZDLX.Size = new System.Drawing.Size(65, 12);
            this.lblZDLX.TabIndex = 10;
            this.lblZDLX.Text = "字段类型";
            // 
            // intZDCD
            // 
            this.intZDCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intZDCD.EnableTouchMode = true;
            this.intZDCD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intZDCD.Location = new System.Drawing.Point(100, 195);
            this.intZDCD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZDCD.Name = "intZDCD";           
            this.intZDCD.Size = new System.Drawing.Size(152, 21);
            this.intZDCD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZDCD.TabIndex = 11;
            this.intZDCD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZDCD.Text = "1.00";           
            this.intZDCD.NullString = "";
            // 
            // lblZDCD
            // 
            this.lblZDCD.AutoSize = true;
            this.lblZDCD.Location = new System.Drawing.Point(10, 199);
            this.lblZDCD.Name = "lblZDCD";
            this.lblZDCD.Size = new System.Drawing.Size(65, 12);
            this.lblZDCD.TabIndex = 12;
            this.lblZDCD.Text = "字段长度";
            // 
            // intZDXSWS
            // 
            this.intZDXSWS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intZDXSWS.EnableTouchMode = true;
            this.intZDXSWS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intZDXSWS.Location = new System.Drawing.Point(100, 230);
            this.intZDXSWS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZDXSWS.Name = "intZDXSWS";           
            this.intZDXSWS.Size = new System.Drawing.Size(152, 21);
            this.intZDXSWS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZDXSWS.TabIndex = 13;
            this.intZDXSWS.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZDXSWS.Text = "1.00";           
            this.intZDXSWS.NullString = "";
            // 
            // lblZDXSWS
            // 
            this.lblZDXSWS.AutoSize = true;
            this.lblZDXSWS.Location = new System.Drawing.Point(10, 234);
            this.lblZDXSWS.Name = "lblZDXSWS";
            this.lblZDXSWS.Size = new System.Drawing.Size(65, 12);
            this.lblZDXSWS.TabIndex = 14;
            this.lblZDXSWS.Text = "字段显示顺序";
            // 
            // txtSYZD
            // 
            this.txtSYZD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtSYZD.EnableTouchMode = true;
            this.txtSYZD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtSYZD.Location = new System.Drawing.Point(100, 265);
            this.txtSYZD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSYZD.Name = "txtSYZD";           
            this.txtSYZD.Size = new System.Drawing.Size(152, 21);
            this.txtSYZD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSYZD.TabIndex = 15;
            this.txtSYZD.Text = "";   
            // 
            // lblSYZD
            // 
            this.lblSYZD.AutoSize = true;
            this.lblSYZD.Location = new System.Drawing.Point(10, 269);
            this.lblSYZD.Name = "lblSYZD";
            this.lblSYZD.Size = new System.Drawing.Size(65, 12);
            this.lblSYZD.TabIndex = 16;
            this.lblSYZD.Text = "使用字典";
            // 
            // txtYS
            // 
            this.txtYS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYS.EnableTouchMode = true;
            this.txtYS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYS.Location = new System.Drawing.Point(100, 300);
            this.txtYS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYS.Name = "txtYS";           
            this.txtYS.Size = new System.Drawing.Size(152, 21);
            this.txtYS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYS.TabIndex = 17;
            this.txtYS.Text = "";   
            // 
            // lblYS
            // 
            this.lblYS.AutoSize = true;
            this.lblYS.Location = new System.Drawing.Point(10, 304);
            this.lblYS.Name = "lblYS";
            this.lblYS.Size = new System.Drawing.Size(65, 12);
            this.lblYS.TabIndex = 18;
            this.lblYS.Text = "可选";
            // 
            // txtSYZDYW
            // 
            this.txtSYZDYW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtSYZDYW.EnableTouchMode = true;
            this.txtSYZDYW.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtSYZDYW.Location = new System.Drawing.Point(100, 335);
            this.txtSYZDYW.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSYZDYW.Name = "txtSYZDYW";           
            this.txtSYZDYW.Size = new System.Drawing.Size(152, 21);
            this.txtSYZDYW.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSYZDYW.TabIndex = 19;
            this.txtSYZDYW.Text = "";   
            // 
            // lblSYZDYW
            // 
            this.lblSYZDYW.AutoSize = true;
            this.lblSYZDYW.Location = new System.Drawing.Point(10, 339);
            this.lblSYZDYW.Name = "lblSYZDYW";
            this.lblSYZDYW.Size = new System.Drawing.Size(65, 12);
            this.lblSYZDYW.TabIndex = 20;
            this.lblSYZDYW.Text = "使用字典英文";
            
            // 
            // ucVG_FIELDINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBM);                
            this.Controls.Add(this.lblBM);            
            this.Controls.Add(this.intBNSX);                
            this.Controls.Add(this.lblBNSX);            
            this.Controls.Add(this.txtZDZWMC);                
            this.Controls.Add(this.lblZDZWMC);            
            this.Controls.Add(this.txtZDMC);                
            this.Controls.Add(this.lblZDMC);            
            this.Controls.Add(this.txtZDLX);                
            this.Controls.Add(this.lblZDLX);            
            this.Controls.Add(this.intZDCD);                
            this.Controls.Add(this.lblZDCD);            
            this.Controls.Add(this.intZDXSWS);                
            this.Controls.Add(this.lblZDXSWS);            
            this.Controls.Add(this.txtSYZD);                
            this.Controls.Add(this.lblSYZD);            
            this.Controls.Add(this.txtYS);                
            this.Controls.Add(this.lblYS);            
            this.Controls.Add(this.txtSYZDYW);                
            this.Controls.Add(this.lblSYZDYW);            
            this.Name = "ucVG_FIELDINFO";
            this.Size = new System.Drawing.Size(260, 380);
            
            ((System.ComponentModel.ISupportInitialize)(this.txtBM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intBNSX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZWMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intZDCD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intZDXSWS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSYZD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtSYZDYW)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBM; 
        private System.Windows.Forms.Label lblBM; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intBNSX; 
        private System.Windows.Forms.Label lblBNSX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDZWMC; 
        private System.Windows.Forms.Label lblZDZWMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDMC; 
        private System.Windows.Forms.Label lblZDMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDLX; 
        private System.Windows.Forms.Label lblZDLX; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZDCD; 
        private System.Windows.Forms.Label lblZDCD; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZDXSWS; 
        private System.Windows.Forms.Label lblZDXSWS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSYZD; 
        private System.Windows.Forms.Label lblSYZD; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYS; 
        private System.Windows.Forms.Label lblYS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSYZDYW; 
        private System.Windows.Forms.Label lblSYZDYW; 
    }

}