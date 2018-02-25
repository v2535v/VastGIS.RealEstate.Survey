using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucTMPCADXDATA
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
            this.txtHANDLE = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHANDLE = new System.Windows.Forms.Label();
            this.txtTC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtWBNR = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblWBNR = new System.Windows.Forms.Label();
            this.txtCASSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCASSDM = new System.Windows.Forms.Label();
            this.txtFSXX1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFSXX1 = new System.Windows.Forms.Label();
            this.txtFSXX2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFSXX2 = new System.Windows.Forms.Label();
            this.dblXZJD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblXZJD = new System.Windows.Forms.Label();
            this.txtFH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFH = new System.Windows.Forms.Label();
            this.dblFHDX = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFHDX = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            this.txtFILENAME = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFILENAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtHANDLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtWBNR)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX1)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX2)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblXZJD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblFHDX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILENAME)).BeginInit();           
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
            // txtHANDLE
            // 
            this.txtHANDLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtHANDLE.EnableTouchMode = true;
            this.txtHANDLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtHANDLE.Location = new System.Drawing.Point(100, 55);
            this.txtHANDLE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHANDLE.Name = "txtHANDLE";           
            this.txtHANDLE.Size = new System.Drawing.Size(152, 21);
            this.txtHANDLE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHANDLE.TabIndex = 3;
            this.txtHANDLE.Text = "";   
            // 
            // lblHANDLE
            // 
            this.lblHANDLE.AutoSize = true;
            this.lblHANDLE.Location = new System.Drawing.Point(10, 59);
            this.lblHANDLE.Name = "lblHANDLE";
            this.lblHANDLE.Size = new System.Drawing.Size(65, 12);
            this.lblHANDLE.TabIndex = 4;
            this.lblHANDLE.Text = "HANDLE";
            // 
            // txtTC
            // 
            this.txtTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTC.EnableTouchMode = true;
            this.txtTC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTC.Location = new System.Drawing.Point(100, 90);
            this.txtTC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTC.Name = "txtTC";           
            this.txtTC.Size = new System.Drawing.Size(152, 21);
            this.txtTC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTC.TabIndex = 5;
            this.txtTC.Text = "";   
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(10, 94);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(65, 12);
            this.lblTC.TabIndex = 6;
            this.lblTC.Text = "TC";
            // 
            // txtWBNR
            // 
            this.txtWBNR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtWBNR.EnableTouchMode = true;
            this.txtWBNR.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtWBNR.Location = new System.Drawing.Point(100, 125);
            this.txtWBNR.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWBNR.Name = "txtWBNR";           
            this.txtWBNR.Size = new System.Drawing.Size(152, 21);
            this.txtWBNR.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWBNR.TabIndex = 7;
            this.txtWBNR.Text = "";   
            // 
            // lblWBNR
            // 
            this.lblWBNR.AutoSize = true;
            this.lblWBNR.Location = new System.Drawing.Point(10, 129);
            this.lblWBNR.Name = "lblWBNR";
            this.lblWBNR.Size = new System.Drawing.Size(65, 12);
            this.lblWBNR.TabIndex = 8;
            this.lblWBNR.Text = "WBNR";
            // 
            // txtCASSDM
            // 
            this.txtCASSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtCASSDM.EnableTouchMode = true;
            this.txtCASSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtCASSDM.Location = new System.Drawing.Point(100, 160);
            this.txtCASSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASSDM.Name = "txtCASSDM";           
            this.txtCASSDM.Size = new System.Drawing.Size(152, 21);
            this.txtCASSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASSDM.TabIndex = 9;
            this.txtCASSDM.Text = "";   
            // 
            // lblCASSDM
            // 
            this.lblCASSDM.AutoSize = true;
            this.lblCASSDM.Location = new System.Drawing.Point(10, 164);
            this.lblCASSDM.Name = "lblCASSDM";
            this.lblCASSDM.Size = new System.Drawing.Size(65, 12);
            this.lblCASSDM.TabIndex = 10;
            this.lblCASSDM.Text = "CASSDM";
            // 
            // txtFSXX1
            // 
            this.txtFSXX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFSXX1.EnableTouchMode = true;
            this.txtFSXX1.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFSXX1.Location = new System.Drawing.Point(100, 195);
            this.txtFSXX1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFSXX1.Name = "txtFSXX1";           
            this.txtFSXX1.Size = new System.Drawing.Size(152, 21);
            this.txtFSXX1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFSXX1.TabIndex = 11;
            this.txtFSXX1.Text = "";   
            // 
            // lblFSXX1
            // 
            this.lblFSXX1.AutoSize = true;
            this.lblFSXX1.Location = new System.Drawing.Point(10, 199);
            this.lblFSXX1.Name = "lblFSXX1";
            this.lblFSXX1.Size = new System.Drawing.Size(65, 12);
            this.lblFSXX1.TabIndex = 12;
            this.lblFSXX1.Text = "FSXX1";
            // 
            // txtFSXX2
            // 
            this.txtFSXX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFSXX2.EnableTouchMode = true;
            this.txtFSXX2.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFSXX2.Location = new System.Drawing.Point(100, 230);
            this.txtFSXX2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFSXX2.Name = "txtFSXX2";           
            this.txtFSXX2.Size = new System.Drawing.Size(152, 21);
            this.txtFSXX2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFSXX2.TabIndex = 13;
            this.txtFSXX2.Text = "";   
            // 
            // lblFSXX2
            // 
            this.lblFSXX2.AutoSize = true;
            this.lblFSXX2.Location = new System.Drawing.Point(10, 234);
            this.lblFSXX2.Name = "lblFSXX2";
            this.lblFSXX2.Size = new System.Drawing.Size(65, 12);
            this.lblFSXX2.TabIndex = 14;
            this.lblFSXX2.Text = "FSXX2";
            // 
            // dblXZJD
            // 
            this.dblXZJD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblXZJD.EnableTouchMode = true;
            this.dblXZJD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblXZJD.Location = new System.Drawing.Point(100, 265);
            this.dblXZJD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXZJD.Name = "dblXZJD";           
            this.dblXZJD.Size = new System.Drawing.Size(152, 21);
            this.dblXZJD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXZJD.TabIndex = 15;
            this.dblXZJD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXZJD.Text = "1.00";
            this.dblXZJD.DoubleValue = 1D;
            this.dblXZJD.NullString = "";
            // 
            // lblXZJD
            // 
            this.lblXZJD.AutoSize = true;
            this.lblXZJD.Location = new System.Drawing.Point(10, 269);
            this.lblXZJD.Name = "lblXZJD";
            this.lblXZJD.Size = new System.Drawing.Size(65, 12);
            this.lblXZJD.TabIndex = 16;
            this.lblXZJD.Text = "XZJD";
            // 
            // txtFH
            // 
            this.txtFH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFH.EnableTouchMode = true;
            this.txtFH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFH.Location = new System.Drawing.Point(100, 300);
            this.txtFH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFH.Name = "txtFH";           
            this.txtFH.Size = new System.Drawing.Size(152, 21);
            this.txtFH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFH.TabIndex = 17;
            this.txtFH.Text = "";   
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.Location = new System.Drawing.Point(10, 304);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(65, 12);
            this.lblFH.TabIndex = 18;
            this.lblFH.Text = "FH";
            // 
            // dblFHDX
            // 
            this.dblFHDX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblFHDX.EnableTouchMode = true;
            this.dblFHDX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblFHDX.Location = new System.Drawing.Point(100, 335);
            this.dblFHDX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFHDX.Name = "dblFHDX";           
            this.dblFHDX.Size = new System.Drawing.Size(152, 21);
            this.dblFHDX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFHDX.TabIndex = 19;
            this.dblFHDX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFHDX.Text = "1.00";
            this.dblFHDX.DoubleValue = 1D;
            this.dblFHDX.NullString = "";
            // 
            // lblFHDX
            // 
            this.lblFHDX.AutoSize = true;
            this.lblFHDX.Location = new System.Drawing.Point(10, 339);
            this.lblFHDX.Name = "lblFHDX";
            this.lblFHDX.Size = new System.Drawing.Size(65, 12);
            this.lblFHDX.TabIndex = 20;
            this.lblFHDX.Text = "FHDX";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSDM.Location = new System.Drawing.Point(100, 370);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";           
            this.txtYSDM.Size = new System.Drawing.Size(152, 21);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 21;
            this.txtYSDM.Text = "";   
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 374);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(65, 12);
            this.lblYSDM.TabIndex = 22;
            this.lblYSDM.Text = "YSDM";
            // 
            // txtFILENAME
            // 
            this.txtFILENAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFILENAME.EnableTouchMode = true;
            this.txtFILENAME.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFILENAME.Location = new System.Drawing.Point(100, 405);
            this.txtFILENAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFILENAME.Name = "txtFILENAME";           
            this.txtFILENAME.Size = new System.Drawing.Size(152, 21);
            this.txtFILENAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFILENAME.TabIndex = 23;
            this.txtFILENAME.Text = "";   
            // 
            // lblFILENAME
            // 
            this.lblFILENAME.AutoSize = true;
            this.lblFILENAME.Location = new System.Drawing.Point(10, 409);
            this.lblFILENAME.Name = "lblFILENAME";
            this.lblFILENAME.Size = new System.Drawing.Size(65, 12);
            this.lblFILENAME.TabIndex = 24;
            this.lblFILENAME.Text = "FILENAME";
            
            // 
            // ucTMPCADXDATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtHANDLE);                
            this.Controls.Add(this.lblHANDLE);            
            this.Controls.Add(this.txtTC);                
            this.Controls.Add(this.lblTC);            
            this.Controls.Add(this.txtWBNR);                
            this.Controls.Add(this.lblWBNR);            
            this.Controls.Add(this.txtCASSDM);                
            this.Controls.Add(this.lblCASSDM);            
            this.Controls.Add(this.txtFSXX1);                
            this.Controls.Add(this.lblFSXX1);            
            this.Controls.Add(this.txtFSXX2);                
            this.Controls.Add(this.lblFSXX2);            
            this.Controls.Add(this.dblXZJD);                
            this.Controls.Add(this.lblXZJD);            
            this.Controls.Add(this.txtFH);                
            this.Controls.Add(this.lblFH);            
            this.Controls.Add(this.dblFHDX);                
            this.Controls.Add(this.lblFHDX);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtFILENAME);                
            this.Controls.Add(this.lblFILENAME);            
            this.Name = "ucTMPCADXDATA";
            this.Size = new System.Drawing.Size(260, 450);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtHANDLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtWBNR)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX1)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX2)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblXZJD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblFHDX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILENAME)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHANDLE; 
        private System.Windows.Forms.Label lblHANDLE; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTC; 
        private System.Windows.Forms.Label lblTC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtWBNR; 
        private System.Windows.Forms.Label lblWBNR; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCASSDM; 
        private System.Windows.Forms.Label lblCASSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFSXX1; 
        private System.Windows.Forms.Label lblFSXX1; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFSXX2; 
        private System.Windows.Forms.Label lblFSXX2; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXZJD; 
        private System.Windows.Forms.Label lblXZJD; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFH; 
        private System.Windows.Forms.Label lblFH; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFHDX; 
        private System.Windows.Forms.Label lblFHDX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFILENAME; 
        private System.Windows.Forms.Label lblFILENAME; 
    }

}