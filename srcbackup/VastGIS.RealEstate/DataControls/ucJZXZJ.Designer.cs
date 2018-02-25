using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJZXZJ
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
            this.txtGLYSBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGLYSBH = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            this.txtZJNR = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZJNR = new System.Windows.Forms.Label();
            this.txtZT = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZT = new System.Windows.Forms.Label();
            this.txtYS = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYS = new System.Windows.Forms.Label();
            this.intBS = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblBS = new System.Windows.Forms.Label();
            this.txtXZ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXZ = new System.Windows.Forms.Label();
            this.txtXHX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXHX = new System.Windows.Forms.Label();
            this.dblKD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblKD = new System.Windows.Forms.Label();
            this.dblGD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblGD = new System.Windows.Forms.Label();
            this.dblZJDZXJXZB = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZJDZXJXZB = new System.Windows.Forms.Label();
            this.dblZJDZXJYZB = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZJDZXJYZB = new System.Windows.Forms.Label();
            this.dblZJFX = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZJFX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtGLYSBH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZJNR)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZT)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intBS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXHX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblKD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblGD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJDZXJXZB)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJDZXJYZB)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJFX)).BeginInit();           
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
            // txtGLYSBH
            // 
            this.txtGLYSBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtGLYSBH.EnableTouchMode = true;
            this.txtGLYSBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtGLYSBH.Location = new System.Drawing.Point(100, 55);
            this.txtGLYSBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGLYSBH.Name = "txtGLYSBH";           
            this.txtGLYSBH.Size = new System.Drawing.Size(152, 21);
            this.txtGLYSBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGLYSBH.TabIndex = 3;
            this.txtGLYSBH.Text = "";   
            // 
            // lblGLYSBH
            // 
            this.lblGLYSBH.AutoSize = true;
            this.lblGLYSBH.Location = new System.Drawing.Point(10, 59);
            this.lblGLYSBH.Name = "lblGLYSBH";
            this.lblGLYSBH.Size = new System.Drawing.Size(65, 12);
            this.lblGLYSBH.TabIndex = 4;
            this.lblGLYSBH.Text = "GLYSBH";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSDM.Location = new System.Drawing.Point(100, 90);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";           
            this.txtYSDM.Size = new System.Drawing.Size(152, 21);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 5;
            this.txtYSDM.Text = "";   
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 94);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(65, 12);
            this.lblYSDM.TabIndex = 6;
            this.lblYSDM.Text = "YSDM";
            // 
            // txtZJNR
            // 
            this.txtZJNR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZJNR.EnableTouchMode = true;
            this.txtZJNR.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZJNR.Location = new System.Drawing.Point(100, 125);
            this.txtZJNR.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZJNR.Name = "txtZJNR";           
            this.txtZJNR.Size = new System.Drawing.Size(152, 21);
            this.txtZJNR.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZJNR.TabIndex = 7;
            this.txtZJNR.Text = "";   
            // 
            // lblZJNR
            // 
            this.lblZJNR.AutoSize = true;
            this.lblZJNR.Location = new System.Drawing.Point(10, 129);
            this.lblZJNR.Name = "lblZJNR";
            this.lblZJNR.Size = new System.Drawing.Size(65, 12);
            this.lblZJNR.TabIndex = 8;
            this.lblZJNR.Text = "ZJNR";
            // 
            // txtZT
            // 
            this.txtZT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZT.EnableTouchMode = true;
            this.txtZT.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZT.Location = new System.Drawing.Point(100, 160);
            this.txtZT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZT.Name = "txtZT";           
            this.txtZT.Size = new System.Drawing.Size(152, 21);
            this.txtZT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZT.TabIndex = 9;
            this.txtZT.Text = "";   
            // 
            // lblZT
            // 
            this.lblZT.AutoSize = true;
            this.lblZT.Location = new System.Drawing.Point(10, 164);
            this.lblZT.Name = "lblZT";
            this.lblZT.Size = new System.Drawing.Size(65, 12);
            this.lblZT.TabIndex = 10;
            this.lblZT.Text = "ZT";
            // 
            // txtYS
            // 
            this.txtYS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYS.EnableTouchMode = true;
            this.txtYS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYS.Location = new System.Drawing.Point(100, 195);
            this.txtYS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYS.Name = "txtYS";           
            this.txtYS.Size = new System.Drawing.Size(152, 21);
            this.txtYS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYS.TabIndex = 11;
            this.txtYS.Text = "";   
            // 
            // lblYS
            // 
            this.lblYS.AutoSize = true;
            this.lblYS.Location = new System.Drawing.Point(10, 199);
            this.lblYS.Name = "lblYS";
            this.lblYS.Size = new System.Drawing.Size(65, 12);
            this.lblYS.TabIndex = 12;
            this.lblYS.Text = "YS";
            // 
            // intBS
            // 
            this.intBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intBS.EnableTouchMode = true;
            this.intBS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intBS.Location = new System.Drawing.Point(100, 230);
            this.intBS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intBS.Name = "intBS";           
            this.intBS.Size = new System.Drawing.Size(152, 21);
            this.intBS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intBS.TabIndex = 13;
            this.intBS.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intBS.Text = "1.00";           
            this.intBS.NullString = "";
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(10, 234);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(65, 12);
            this.lblBS.TabIndex = 14;
            this.lblBS.Text = "BS";
            // 
            // txtXZ
            // 
            this.txtXZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXZ.EnableTouchMode = true;
            this.txtXZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXZ.Location = new System.Drawing.Point(100, 265);
            this.txtXZ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXZ.Name = "txtXZ";           
            this.txtXZ.Size = new System.Drawing.Size(152, 21);
            this.txtXZ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXZ.TabIndex = 15;
            this.txtXZ.Text = "";   
            // 
            // lblXZ
            // 
            this.lblXZ.AutoSize = true;
            this.lblXZ.Location = new System.Drawing.Point(10, 269);
            this.lblXZ.Name = "lblXZ";
            this.lblXZ.Size = new System.Drawing.Size(65, 12);
            this.lblXZ.TabIndex = 16;
            this.lblXZ.Text = "XZ";
            // 
            // txtXHX
            // 
            this.txtXHX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXHX.EnableTouchMode = true;
            this.txtXHX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXHX.Location = new System.Drawing.Point(100, 300);
            this.txtXHX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXHX.Name = "txtXHX";           
            this.txtXHX.Size = new System.Drawing.Size(152, 21);
            this.txtXHX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXHX.TabIndex = 17;
            this.txtXHX.Text = "";   
            // 
            // lblXHX
            // 
            this.lblXHX.AutoSize = true;
            this.lblXHX.Location = new System.Drawing.Point(10, 304);
            this.lblXHX.Name = "lblXHX";
            this.lblXHX.Size = new System.Drawing.Size(65, 12);
            this.lblXHX.TabIndex = 18;
            this.lblXHX.Text = "XHX";
            // 
            // dblKD
            // 
            this.dblKD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblKD.EnableTouchMode = true;
            this.dblKD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblKD.Location = new System.Drawing.Point(100, 335);
            this.dblKD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblKD.Name = "dblKD";           
            this.dblKD.Size = new System.Drawing.Size(152, 21);
            this.dblKD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblKD.TabIndex = 19;
            this.dblKD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblKD.Text = "1.00";
            this.dblKD.DoubleValue = 1D;
            this.dblKD.NullString = "";
            // 
            // lblKD
            // 
            this.lblKD.AutoSize = true;
            this.lblKD.Location = new System.Drawing.Point(10, 339);
            this.lblKD.Name = "lblKD";
            this.lblKD.Size = new System.Drawing.Size(65, 12);
            this.lblKD.TabIndex = 20;
            this.lblKD.Text = "KD";
            // 
            // dblGD
            // 
            this.dblGD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblGD.EnableTouchMode = true;
            this.dblGD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblGD.Location = new System.Drawing.Point(100, 370);
            this.dblGD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblGD.Name = "dblGD";           
            this.dblGD.Size = new System.Drawing.Size(152, 21);
            this.dblGD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblGD.TabIndex = 21;
            this.dblGD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblGD.Text = "1.00";
            this.dblGD.DoubleValue = 1D;
            this.dblGD.NullString = "";
            // 
            // lblGD
            // 
            this.lblGD.AutoSize = true;
            this.lblGD.Location = new System.Drawing.Point(10, 374);
            this.lblGD.Name = "lblGD";
            this.lblGD.Size = new System.Drawing.Size(65, 12);
            this.lblGD.TabIndex = 22;
            this.lblGD.Text = "GD";
            // 
            // dblZJDZXJXZB
            // 
            this.dblZJDZXJXZB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblZJDZXJXZB.EnableTouchMode = true;
            this.dblZJDZXJXZB.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblZJDZXJXZB.Location = new System.Drawing.Point(100, 405);
            this.dblZJDZXJXZB.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZJDZXJXZB.Name = "dblZJDZXJXZB";           
            this.dblZJDZXJXZB.Size = new System.Drawing.Size(152, 21);
            this.dblZJDZXJXZB.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZJDZXJXZB.TabIndex = 23;
            this.dblZJDZXJXZB.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZJDZXJXZB.Text = "1.00";
            this.dblZJDZXJXZB.DoubleValue = 1D;
            this.dblZJDZXJXZB.NullString = "";
            // 
            // lblZJDZXJXZB
            // 
            this.lblZJDZXJXZB.AutoSize = true;
            this.lblZJDZXJXZB.Location = new System.Drawing.Point(10, 409);
            this.lblZJDZXJXZB.Name = "lblZJDZXJXZB";
            this.lblZJDZXJXZB.Size = new System.Drawing.Size(65, 12);
            this.lblZJDZXJXZB.TabIndex = 24;
            this.lblZJDZXJXZB.Text = "ZJDZXJXZB";
            // 
            // dblZJDZXJYZB
            // 
            this.dblZJDZXJYZB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblZJDZXJYZB.EnableTouchMode = true;
            this.dblZJDZXJYZB.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblZJDZXJYZB.Location = new System.Drawing.Point(100, 440);
            this.dblZJDZXJYZB.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZJDZXJYZB.Name = "dblZJDZXJYZB";           
            this.dblZJDZXJYZB.Size = new System.Drawing.Size(152, 21);
            this.dblZJDZXJYZB.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZJDZXJYZB.TabIndex = 25;
            this.dblZJDZXJYZB.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZJDZXJYZB.Text = "1.00";
            this.dblZJDZXJYZB.DoubleValue = 1D;
            this.dblZJDZXJYZB.NullString = "";
            // 
            // lblZJDZXJYZB
            // 
            this.lblZJDZXJYZB.AutoSize = true;
            this.lblZJDZXJYZB.Location = new System.Drawing.Point(10, 444);
            this.lblZJDZXJYZB.Name = "lblZJDZXJYZB";
            this.lblZJDZXJYZB.Size = new System.Drawing.Size(65, 12);
            this.lblZJDZXJYZB.TabIndex = 26;
            this.lblZJDZXJYZB.Text = "ZJDZXJYZB";
            // 
            // dblZJFX
            // 
            this.dblZJFX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblZJFX.EnableTouchMode = true;
            this.dblZJFX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblZJFX.Location = new System.Drawing.Point(100, 475);
            this.dblZJFX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZJFX.Name = "dblZJFX";           
            this.dblZJFX.Size = new System.Drawing.Size(152, 21);
            this.dblZJFX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZJFX.TabIndex = 27;
            this.dblZJFX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZJFX.Text = "1.00";
            this.dblZJFX.DoubleValue = 1D;
            this.dblZJFX.NullString = "";
            // 
            // lblZJFX
            // 
            this.lblZJFX.AutoSize = true;
            this.lblZJFX.Location = new System.Drawing.Point(10, 479);
            this.lblZJFX.Name = "lblZJFX";
            this.lblZJFX.Size = new System.Drawing.Size(65, 12);
            this.lblZJFX.TabIndex = 28;
            this.lblZJFX.Text = "ZJFX";
            
            // 
            // ucJZXZJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtGLYSBH);                
            this.Controls.Add(this.lblGLYSBH);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtZJNR);                
            this.Controls.Add(this.lblZJNR);            
            this.Controls.Add(this.txtZT);                
            this.Controls.Add(this.lblZT);            
            this.Controls.Add(this.txtYS);                
            this.Controls.Add(this.lblYS);            
            this.Controls.Add(this.intBS);                
            this.Controls.Add(this.lblBS);            
            this.Controls.Add(this.txtXZ);                
            this.Controls.Add(this.lblXZ);            
            this.Controls.Add(this.txtXHX);                
            this.Controls.Add(this.lblXHX);            
            this.Controls.Add(this.dblKD);                
            this.Controls.Add(this.lblKD);            
            this.Controls.Add(this.dblGD);                
            this.Controls.Add(this.lblGD);            
            this.Controls.Add(this.dblZJDZXJXZB);                
            this.Controls.Add(this.lblZJDZXJXZB);            
            this.Controls.Add(this.dblZJDZXJYZB);                
            this.Controls.Add(this.lblZJDZXJYZB);            
            this.Controls.Add(this.dblZJFX);                
            this.Controls.Add(this.lblZJFX);            
            this.Name = "ucJZXZJ";
            this.Size = new System.Drawing.Size(260, 520);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtGLYSBH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZJNR)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZT)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intBS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXHX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblKD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblGD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJDZXJXZB)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJDZXJYZB)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZJFX)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGLYSBH; 
        private System.Windows.Forms.Label lblGLYSBH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZJNR; 
        private System.Windows.Forms.Label lblZJNR; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZT; 
        private System.Windows.Forms.Label lblZT; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYS; 
        private System.Windows.Forms.Label lblYS; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intBS; 
        private System.Windows.Forms.Label lblBS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXZ; 
        private System.Windows.Forms.Label lblXZ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXHX; 
        private System.Windows.Forms.Label lblXHX; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblKD; 
        private System.Windows.Forms.Label lblKD; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblGD; 
        private System.Windows.Forms.Label lblGD; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZJDZXJXZB; 
        private System.Windows.Forms.Label lblZJDZXJXZB; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZJDZXJYZB; 
        private System.Windows.Forms.Label lblZJDZXJYZB; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZJFX; 
        private System.Windows.Forms.Label lblZJFX; 
    }

}