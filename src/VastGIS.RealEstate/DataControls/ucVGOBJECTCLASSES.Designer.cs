using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGOBJECTCLASSES
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
            this.txtMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMC = new System.Windows.Forms.Label();
            this.txtDXLX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDXLX = new System.Windows.Forms.Label();
            this.txtZWMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZWMC = new System.Windows.Forms.Label();
            this.txtFBMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFBMC = new System.Windows.Forms.Label();
            this.txtXHZDMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXHZDMC = new System.Windows.Forms.Label();
            this.txtTXZDMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTXZDMC = new System.Windows.Forms.Label();
            this.txtTXLX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTXLX = new System.Windows.Forms.Label();
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
            this.intXSSX = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblXSSX = new System.Windows.Forms.Label();
            this.txtFILTER = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFILTER = new System.Windows.Forms.Label();
            this.txtQSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSDM = new System.Windows.Forms.Label();
            this.txtBJCT = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBJCT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDXLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZWMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFBMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXHZDMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXZDMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkIDENTIFY)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkEDITABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkQUERYABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSNAPABLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkVISIBLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXSSX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILTER)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBJCT)).BeginInit();           
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
            // txtMC
            // 
            this.txtMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtMC.EnableTouchMode = true;
            this.txtMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtMC.Location = new System.Drawing.Point(100, 55);
            this.txtMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMC.Name = "txtMC";           
            this.txtMC.Size = new System.Drawing.Size(152, 21);
            this.txtMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMC.TabIndex = 3;
            this.txtMC.Text = "";   
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Location = new System.Drawing.Point(10, 59);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(65, 12);
            this.lblMC.TabIndex = 4;
            this.lblMC.Text = "MC";
            // 
            // txtDXLX
            // 
            this.txtDXLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDXLX.EnableTouchMode = true;
            this.txtDXLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDXLX.Location = new System.Drawing.Point(100, 90);
            this.txtDXLX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDXLX.Name = "txtDXLX";           
            this.txtDXLX.Size = new System.Drawing.Size(152, 21);
            this.txtDXLX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDXLX.TabIndex = 5;
            this.txtDXLX.Text = "";   
            // 
            // lblDXLX
            // 
            this.lblDXLX.AutoSize = true;
            this.lblDXLX.Location = new System.Drawing.Point(10, 94);
            this.lblDXLX.Name = "lblDXLX";
            this.lblDXLX.Size = new System.Drawing.Size(65, 12);
            this.lblDXLX.TabIndex = 6;
            this.lblDXLX.Text = "DXLX";
            // 
            // txtZWMC
            // 
            this.txtZWMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZWMC.EnableTouchMode = true;
            this.txtZWMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZWMC.Location = new System.Drawing.Point(100, 125);
            this.txtZWMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZWMC.Name = "txtZWMC";           
            this.txtZWMC.Size = new System.Drawing.Size(152, 21);
            this.txtZWMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZWMC.TabIndex = 7;
            this.txtZWMC.Text = "";   
            // 
            // lblZWMC
            // 
            this.lblZWMC.AutoSize = true;
            this.lblZWMC.Location = new System.Drawing.Point(10, 129);
            this.lblZWMC.Name = "lblZWMC";
            this.lblZWMC.Size = new System.Drawing.Size(65, 12);
            this.lblZWMC.TabIndex = 8;
            this.lblZWMC.Text = "ZWMC";
            // 
            // txtFBMC
            // 
            this.txtFBMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFBMC.EnableTouchMode = true;
            this.txtFBMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFBMC.Location = new System.Drawing.Point(100, 160);
            this.txtFBMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFBMC.Name = "txtFBMC";           
            this.txtFBMC.Size = new System.Drawing.Size(152, 21);
            this.txtFBMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFBMC.TabIndex = 9;
            this.txtFBMC.Text = "";   
            // 
            // lblFBMC
            // 
            this.lblFBMC.AutoSize = true;
            this.lblFBMC.Location = new System.Drawing.Point(10, 164);
            this.lblFBMC.Name = "lblFBMC";
            this.lblFBMC.Size = new System.Drawing.Size(65, 12);
            this.lblFBMC.TabIndex = 10;
            this.lblFBMC.Text = "FBMC";
            // 
            // txtXHZDMC
            // 
            this.txtXHZDMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXHZDMC.EnableTouchMode = true;
            this.txtXHZDMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXHZDMC.Location = new System.Drawing.Point(100, 195);
            this.txtXHZDMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXHZDMC.Name = "txtXHZDMC";           
            this.txtXHZDMC.Size = new System.Drawing.Size(152, 21);
            this.txtXHZDMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXHZDMC.TabIndex = 11;
            this.txtXHZDMC.Text = "";   
            // 
            // lblXHZDMC
            // 
            this.lblXHZDMC.AutoSize = true;
            this.lblXHZDMC.Location = new System.Drawing.Point(10, 199);
            this.lblXHZDMC.Name = "lblXHZDMC";
            this.lblXHZDMC.Size = new System.Drawing.Size(65, 12);
            this.lblXHZDMC.TabIndex = 12;
            this.lblXHZDMC.Text = "XHZDMC";
            // 
            // txtTXZDMC
            // 
            this.txtTXZDMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTXZDMC.EnableTouchMode = true;
            this.txtTXZDMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTXZDMC.Location = new System.Drawing.Point(100, 230);
            this.txtTXZDMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTXZDMC.Name = "txtTXZDMC";           
            this.txtTXZDMC.Size = new System.Drawing.Size(152, 21);
            this.txtTXZDMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTXZDMC.TabIndex = 13;
            this.txtTXZDMC.Text = "";   
            // 
            // lblTXZDMC
            // 
            this.lblTXZDMC.AutoSize = true;
            this.lblTXZDMC.Location = new System.Drawing.Point(10, 234);
            this.lblTXZDMC.Name = "lblTXZDMC";
            this.lblTXZDMC.Size = new System.Drawing.Size(65, 12);
            this.lblTXZDMC.TabIndex = 14;
            this.lblTXZDMC.Text = "TXZDMC";
            // 
            // txtTXLX
            // 
            this.txtTXLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTXLX.EnableTouchMode = true;
            this.txtTXLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTXLX.Location = new System.Drawing.Point(100, 265);
            this.txtTXLX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTXLX.Name = "txtTXLX";           
            this.txtTXLX.Size = new System.Drawing.Size(152, 21);
            this.txtTXLX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTXLX.TabIndex = 15;
            this.txtTXLX.Text = "";   
            // 
            // lblTXLX
            // 
            this.lblTXLX.AutoSize = true;
            this.lblTXLX.Location = new System.Drawing.Point(10, 269);
            this.lblTXLX.Name = "lblTXLX";
            this.lblTXLX.Size = new System.Drawing.Size(65, 12);
            this.lblTXLX.TabIndex = 16;
            this.lblTXLX.Text = "TXLX";
            // 
            // chkIDENTIFY
            // 
            this.chkIDENTIFY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkIDENTIFY.EnableTouchMode = true;
            this.chkIDENTIFY.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkIDENTIFY.Location = new System.Drawing.Point(100, 300);
            this.chkIDENTIFY.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkIDENTIFY.Name = "chkIDENTIFY";           
            this.chkIDENTIFY.Size = new System.Drawing.Size(152, 21);
            this.chkIDENTIFY.TabIndex = 17;
            this.chkIDENTIFY.Text = "";  
            this.chkIDENTIFY.ThemesEnabled = false;
             this.chkIDENTIFY.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblIDENTIFY
            // 
            this.lblIDENTIFY.AutoSize = true;
            this.lblIDENTIFY.Location = new System.Drawing.Point(10, 304);
            this.lblIDENTIFY.Name = "lblIDENTIFY";
            this.lblIDENTIFY.Size = new System.Drawing.Size(65, 12);
            this.lblIDENTIFY.TabIndex = 18;
            this.lblIDENTIFY.Text = "IDENTIFY";
            // 
            // chkEDITABLE
            // 
            this.chkEDITABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkEDITABLE.EnableTouchMode = true;
            this.chkEDITABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkEDITABLE.Location = new System.Drawing.Point(100, 335);
            this.chkEDITABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkEDITABLE.Name = "chkEDITABLE";           
            this.chkEDITABLE.Size = new System.Drawing.Size(152, 21);
            this.chkEDITABLE.TabIndex = 19;
            this.chkEDITABLE.Text = "";  
            this.chkEDITABLE.ThemesEnabled = false;
             this.chkEDITABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblEDITABLE
            // 
            this.lblEDITABLE.AutoSize = true;
            this.lblEDITABLE.Location = new System.Drawing.Point(10, 339);
            this.lblEDITABLE.Name = "lblEDITABLE";
            this.lblEDITABLE.Size = new System.Drawing.Size(65, 12);
            this.lblEDITABLE.TabIndex = 20;
            this.lblEDITABLE.Text = "EDITABLE";
            // 
            // chkQUERYABLE
            // 
            this.chkQUERYABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkQUERYABLE.EnableTouchMode = true;
            this.chkQUERYABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkQUERYABLE.Location = new System.Drawing.Point(100, 370);
            this.chkQUERYABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkQUERYABLE.Name = "chkQUERYABLE";           
            this.chkQUERYABLE.Size = new System.Drawing.Size(152, 21);
            this.chkQUERYABLE.TabIndex = 21;
            this.chkQUERYABLE.Text = "";  
            this.chkQUERYABLE.ThemesEnabled = false;
             this.chkQUERYABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblQUERYABLE
            // 
            this.lblQUERYABLE.AutoSize = true;
            this.lblQUERYABLE.Location = new System.Drawing.Point(10, 374);
            this.lblQUERYABLE.Name = "lblQUERYABLE";
            this.lblQUERYABLE.Size = new System.Drawing.Size(65, 12);
            this.lblQUERYABLE.TabIndex = 22;
            this.lblQUERYABLE.Text = "QUERYABLE";
            // 
            // chkSNAPABLE
            // 
            this.chkSNAPABLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkSNAPABLE.EnableTouchMode = true;
            this.chkSNAPABLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkSNAPABLE.Location = new System.Drawing.Point(100, 405);
            this.chkSNAPABLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSNAPABLE.Name = "chkSNAPABLE";           
            this.chkSNAPABLE.Size = new System.Drawing.Size(152, 21);
            this.chkSNAPABLE.TabIndex = 23;
            this.chkSNAPABLE.Text = "";  
            this.chkSNAPABLE.ThemesEnabled = false;
             this.chkSNAPABLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblSNAPABLE
            // 
            this.lblSNAPABLE.AutoSize = true;
            this.lblSNAPABLE.Location = new System.Drawing.Point(10, 409);
            this.lblSNAPABLE.Name = "lblSNAPABLE";
            this.lblSNAPABLE.Size = new System.Drawing.Size(65, 12);
            this.lblSNAPABLE.TabIndex = 24;
            this.lblSNAPABLE.Text = "SNAPABLE";
            // 
            // chkVISIBLE
            // 
            this.chkVISIBLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkVISIBLE.EnableTouchMode = true;
            this.chkVISIBLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkVISIBLE.Location = new System.Drawing.Point(100, 440);
            this.chkVISIBLE.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkVISIBLE.Name = "chkVISIBLE";           
            this.chkVISIBLE.Size = new System.Drawing.Size(152, 21);
            this.chkVISIBLE.TabIndex = 25;
            this.chkVISIBLE.Text = "";  
            this.chkVISIBLE.ThemesEnabled = false;
             this.chkVISIBLE.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblVISIBLE
            // 
            this.lblVISIBLE.AutoSize = true;
            this.lblVISIBLE.Location = new System.Drawing.Point(10, 444);
            this.lblVISIBLE.Name = "lblVISIBLE";
            this.lblVISIBLE.Size = new System.Drawing.Size(65, 12);
            this.lblVISIBLE.TabIndex = 26;
            this.lblVISIBLE.Text = "VISIBLE";
            // 
            // intXSSX
            // 
            this.intXSSX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intXSSX.EnableTouchMode = true;
            this.intXSSX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intXSSX.Location = new System.Drawing.Point(100, 475);
            this.intXSSX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXSSX.Name = "intXSSX";           
            this.intXSSX.Size = new System.Drawing.Size(152, 21);
            this.intXSSX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXSSX.TabIndex = 27;
            this.intXSSX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXSSX.Text = "1.00";           
            this.intXSSX.NullString = "";
            // 
            // lblXSSX
            // 
            this.lblXSSX.AutoSize = true;
            this.lblXSSX.Location = new System.Drawing.Point(10, 479);
            this.lblXSSX.Name = "lblXSSX";
            this.lblXSSX.Size = new System.Drawing.Size(65, 12);
            this.lblXSSX.TabIndex = 28;
            this.lblXSSX.Text = "XSSX";
            // 
            // txtFILTER
            // 
            this.txtFILTER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFILTER.EnableTouchMode = true;
            this.txtFILTER.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFILTER.Location = new System.Drawing.Point(100, 510);
            this.txtFILTER.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFILTER.Name = "txtFILTER";           
            this.txtFILTER.Size = new System.Drawing.Size(152, 21);
            this.txtFILTER.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFILTER.TabIndex = 29;
            this.txtFILTER.Text = "";   
            // 
            // lblFILTER
            // 
            this.lblFILTER.AutoSize = true;
            this.lblFILTER.Location = new System.Drawing.Point(10, 514);
            this.lblFILTER.Name = "lblFILTER";
            this.lblFILTER.Size = new System.Drawing.Size(65, 12);
            this.lblFILTER.TabIndex = 30;
            this.lblFILTER.Text = "FILTER";
            // 
            // txtQSDM
            // 
            this.txtQSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSDM.EnableTouchMode = true;
            this.txtQSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSDM.Location = new System.Drawing.Point(100, 545);
            this.txtQSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSDM.Name = "txtQSDM";           
            this.txtQSDM.Size = new System.Drawing.Size(152, 21);
            this.txtQSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSDM.TabIndex = 31;
            this.txtQSDM.Text = "";   
            // 
            // lblQSDM
            // 
            this.lblQSDM.AutoSize = true;
            this.lblQSDM.Location = new System.Drawing.Point(10, 549);
            this.lblQSDM.Name = "lblQSDM";
            this.lblQSDM.Size = new System.Drawing.Size(65, 12);
            this.lblQSDM.TabIndex = 32;
            this.lblQSDM.Text = "QSDM";
            // 
            // txtBJCT
            // 
            this.txtBJCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBJCT.EnableTouchMode = true;
            this.txtBJCT.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBJCT.Location = new System.Drawing.Point(100, 580);
            this.txtBJCT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBJCT.Name = "txtBJCT";           
            this.txtBJCT.Size = new System.Drawing.Size(152, 21);
            this.txtBJCT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBJCT.TabIndex = 33;
            this.txtBJCT.Text = "";   
            // 
            // lblBJCT
            // 
            this.lblBJCT.AutoSize = true;
            this.lblBJCT.Location = new System.Drawing.Point(10, 584);
            this.lblBJCT.Name = "lblBJCT";
            this.lblBJCT.Size = new System.Drawing.Size(65, 12);
            this.lblBJCT.TabIndex = 34;
            this.lblBJCT.Text = "BJCT";
            
            // 
            // ucVG_OBJECTCLASSES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtMC);                
            this.Controls.Add(this.lblMC);            
            this.Controls.Add(this.txtDXLX);                
            this.Controls.Add(this.lblDXLX);            
            this.Controls.Add(this.txtZWMC);                
            this.Controls.Add(this.lblZWMC);            
            this.Controls.Add(this.txtFBMC);                
            this.Controls.Add(this.lblFBMC);            
            this.Controls.Add(this.txtXHZDMC);                
            this.Controls.Add(this.lblXHZDMC);            
            this.Controls.Add(this.txtTXZDMC);                
            this.Controls.Add(this.lblTXZDMC);            
            this.Controls.Add(this.txtTXLX);                
            this.Controls.Add(this.lblTXLX);            
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
            this.Controls.Add(this.intXSSX);                
            this.Controls.Add(this.lblXSSX);            
            this.Controls.Add(this.txtFILTER);                
            this.Controls.Add(this.lblFILTER);            
            this.Controls.Add(this.txtQSDM);                
            this.Controls.Add(this.lblQSDM);            
            this.Controls.Add(this.txtBJCT);                
            this.Controls.Add(this.lblBJCT);            
            this.Name = "ucVG_OBJECTCLASSES";
            this.Size = new System.Drawing.Size(260, 625);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDXLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZWMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFBMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXHZDMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXZDMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkIDENTIFY)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkEDITABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkQUERYABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSNAPABLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkVISIBLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXSSX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILTER)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBJCT)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMC; 
        private System.Windows.Forms.Label lblMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDXLX; 
        private System.Windows.Forms.Label lblDXLX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZWMC; 
        private System.Windows.Forms.Label lblZWMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFBMC; 
        private System.Windows.Forms.Label lblFBMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXHZDMC; 
        private System.Windows.Forms.Label lblXHZDMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTXZDMC; 
        private System.Windows.Forms.Label lblTXZDMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTXLX; 
        private System.Windows.Forms.Label lblTXLX; 
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
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXSSX; 
        private System.Windows.Forms.Label lblXSSX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFILTER; 
        private System.Windows.Forms.Label lblFILTER; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSDM; 
        private System.Windows.Forms.Label lblQSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBJCT; 
        private System.Windows.Forms.Label lblBJCT; 
    }

}