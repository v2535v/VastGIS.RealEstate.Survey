using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucR
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
            this.lblID = new System.Windows.Forms.Label();
            this.intID = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrmc = new System.Windows.Forms.Label();
            this.txtQlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrpy = new System.Windows.Forms.Label();
            this.txtQlrpy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblPysx = new System.Windows.Forms.Label();
            this.txtPysx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZjzl = new System.Windows.Forms.Label();
            this.txtZjzl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZjh = new System.Windows.Forms.Label();
            this.txtZjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFzjg = new System.Windows.Forms.Label();
            this.txtFzjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSshy = new System.Windows.Forms.Label();
            this.txtSshy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGj = new System.Windows.Forms.Label();
            this.txtGj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHjszss = new System.Windows.Forms.Label();
            this.txtHjszss = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXb = new System.Windows.Forms.Label();
            this.txtXb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDh = new System.Windows.Forms.Label();
            this.txtDh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDz = new System.Windows.Forms.Label();
            this.txtDz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYb = new System.Windows.Forms.Label();
            this.txtYb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGzdw = new System.Windows.Forms.Label();
            this.txtGzdw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDzyj = new System.Windows.Forms.Label();
            this.txtDzyj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPysx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSshy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHjszss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGzdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzyj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblID.Location = new System.Drawing.Point(0,0);
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "标识码";
            // 
            // intID
            // 
            this.intID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intID.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intID.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intID.EnableTouchMode = true;
            this.intID.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intID.IntegerValue = ((long)(0));
            this.intID.Location = new System.Drawing.Point(0,0);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";
            this.intID.NullString = "";
            this.intID.Size = new System.Drawing.Size(152, 28);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 2;
            this.intID.Text = "0";
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 3;
            this.lblYsdm.Text = "要素代码";
            // 
            // txtYsdm
            // 
            this.txtYsdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsdm.EnableTouchMode = true;
            this.txtYsdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsdm.Location =  new System.Drawing.Point(0,0);
            this.txtYsdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsdm.Name = "txtYsdm";
            this.txtYsdm.Size = new System.Drawing.Size(152, 28);
            this.txtYsdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsdm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblQlrmc.AutoSize = true;
            this.lblQlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrmc.Location = new System.Drawing.Point(0,0);
            this.lblQlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrmc.Name = "lblQlrmc";
            this.lblQlrmc.Size = new System.Drawing.Size(41, 20);
            this.lblQlrmc.TabIndex = 5;
            this.lblQlrmc.Text = "QLRMC";
            // 
            // txtQlrmc
            // 
            this.txtQlrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrmc.EnableTouchMode = true;
            this.txtQlrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrmc.Location =  new System.Drawing.Point(0,0);
            this.txtQlrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrmc.Name = "txtQlrmc";
            this.txtQlrmc.Size = new System.Drawing.Size(152, 28);
            this.txtQlrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrmc.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblQlrpy.AutoSize = true;
            this.lblQlrpy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrpy.Location = new System.Drawing.Point(0,0);
            this.lblQlrpy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrpy.Name = "lblQlrpy";
            this.lblQlrpy.Size = new System.Drawing.Size(41, 20);
            this.lblQlrpy.TabIndex = 7;
            this.lblQlrpy.Text = "拼音";
            // 
            // txtQlrpy
            // 
            this.txtQlrpy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrpy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrpy.EnableTouchMode = true;
            this.txtQlrpy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrpy.Location =  new System.Drawing.Point(0,0);
            this.txtQlrpy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrpy.Name = "txtQlrpy";
            this.txtQlrpy.Size = new System.Drawing.Size(152, 28);
            this.txtQlrpy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrpy.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblPysx.AutoSize = true;
            this.lblPysx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPysx.Location = new System.Drawing.Point(0,0);
            this.lblPysx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblPysx.Name = "lblPysx";
            this.lblPysx.Size = new System.Drawing.Size(41, 20);
            this.lblPysx.TabIndex = 9;
            this.lblPysx.Text = "拼音缩写";
            // 
            // txtPysx
            // 
            this.txtPysx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPysx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtPysx.EnableTouchMode = true;
            this.txtPysx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPysx.Location =  new System.Drawing.Point(0,0);
            this.txtPysx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtPysx.Name = "txtPysx";
            this.txtPysx.Size = new System.Drawing.Size(152, 28);
            this.txtPysx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtPysx.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblZjzl.AutoSize = true;
            this.lblZjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjzl.Location = new System.Drawing.Point(0,0);
            this.lblZjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjzl.Name = "lblZjzl";
            this.lblZjzl.Size = new System.Drawing.Size(41, 20);
            this.lblZjzl.TabIndex = 11;
            this.lblZjzl.Text = "ZJZL";
            // 
            // txtZjzl
            // 
            this.txtZjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjzl.EnableTouchMode = true;
            this.txtZjzl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjzl.Location =  new System.Drawing.Point(0,0);
            this.txtZjzl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjzl.Name = "txtZjzl";
            this.txtZjzl.Size = new System.Drawing.Size(152, 28);
            this.txtZjzl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjzl.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblZjh.AutoSize = true;
            this.lblZjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjh.Location = new System.Drawing.Point(0,0);
            this.lblZjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjh.Name = "lblZjh";
            this.lblZjh.Size = new System.Drawing.Size(41, 20);
            this.lblZjh.TabIndex = 13;
            this.lblZjh.Text = "ZJH";
            // 
            // txtZjh
            // 
            this.txtZjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjh.EnableTouchMode = true;
            this.txtZjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjh.Location =  new System.Drawing.Point(0,0);
            this.txtZjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjh.Name = "txtZjh";
            this.txtZjh.Size = new System.Drawing.Size(152, 28);
            this.txtZjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjh.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblFzjg.AutoSize = true;
            this.lblFzjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzjg.Location = new System.Drawing.Point(0,0);
            this.lblFzjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzjg.Name = "lblFzjg";
            this.lblFzjg.Size = new System.Drawing.Size(41, 20);
            this.lblFzjg.TabIndex = 15;
            this.lblFzjg.Text = "FZJG";
            // 
            // txtFzjg
            // 
            this.txtFzjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFzjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFzjg.EnableTouchMode = true;
            this.txtFzjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFzjg.Location =  new System.Drawing.Point(0,0);
            this.txtFzjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFzjg.Name = "txtFzjg";
            this.txtFzjg.Size = new System.Drawing.Size(152, 28);
            this.txtFzjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFzjg.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblSshy.AutoSize = true;
            this.lblSshy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSshy.Location = new System.Drawing.Point(0,0);
            this.lblSshy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSshy.Name = "lblSshy";
            this.lblSshy.Size = new System.Drawing.Size(41, 20);
            this.lblSshy.TabIndex = 17;
            this.lblSshy.Text = "SSHY";
            // 
            // txtSshy
            // 
            this.txtSshy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSshy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSshy.EnableTouchMode = true;
            this.txtSshy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSshy.Location =  new System.Drawing.Point(0,0);
            this.txtSshy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSshy.Name = "txtSshy";
            this.txtSshy.Size = new System.Drawing.Size(152, 28);
            this.txtSshy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSshy.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblGj.AutoSize = true;
            this.lblGj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGj.Location = new System.Drawing.Point(0,0);
            this.lblGj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGj.Name = "lblGj";
            this.lblGj.Size = new System.Drawing.Size(41, 20);
            this.lblGj.TabIndex = 19;
            this.lblGj.Text = "GJ";
            // 
            // txtGj
            // 
            this.txtGj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGj.EnableTouchMode = true;
            this.txtGj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGj.Location =  new System.Drawing.Point(0,0);
            this.txtGj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGj.Name = "txtGj";
            this.txtGj.Size = new System.Drawing.Size(152, 28);
            this.txtGj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGj.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblHjszss.AutoSize = true;
            this.lblHjszss.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHjszss.Location = new System.Drawing.Point(0,0);
            this.lblHjszss.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHjszss.Name = "lblHjszss";
            this.lblHjszss.Size = new System.Drawing.Size(41, 20);
            this.lblHjszss.TabIndex = 21;
            this.lblHjszss.Text = "HJSZSS";
            // 
            // txtHjszss
            // 
            this.txtHjszss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHjszss.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHjszss.EnableTouchMode = true;
            this.txtHjszss.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHjszss.Location =  new System.Drawing.Point(0,0);
            this.txtHjszss.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHjszss.Name = "txtHjszss";
            this.txtHjszss.Size = new System.Drawing.Size(152, 28);
            this.txtHjszss.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHjszss.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblXb.AutoSize = true;
            this.lblXb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXb.Location = new System.Drawing.Point(0,0);
            this.lblXb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXb.Name = "lblXb";
            this.lblXb.Size = new System.Drawing.Size(41, 20);
            this.lblXb.TabIndex = 23;
            this.lblXb.Text = "XB";
            // 
            // txtXb
            // 
            this.txtXb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXb.EnableTouchMode = true;
            this.txtXb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXb.Location =  new System.Drawing.Point(0,0);
            this.txtXb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXb.Name = "txtXb";
            this.txtXb.Size = new System.Drawing.Size(152, 28);
            this.txtXb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXb.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblDh.AutoSize = true;
            this.lblDh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDh.Location = new System.Drawing.Point(0,0);
            this.lblDh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDh.Name = "lblDh";
            this.lblDh.Size = new System.Drawing.Size(41, 20);
            this.lblDh.TabIndex = 25;
            this.lblDh.Text = "DH";
            // 
            // txtDh
            // 
            this.txtDh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDh.EnableTouchMode = true;
            this.txtDh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDh.Location =  new System.Drawing.Point(0,0);
            this.txtDh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDh.Name = "txtDh";
            this.txtDh.Size = new System.Drawing.Size(152, 28);
            this.txtDh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDh.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblDz.AutoSize = true;
            this.lblDz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDz.Location = new System.Drawing.Point(0,0);
            this.lblDz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDz.Name = "lblDz";
            this.lblDz.Size = new System.Drawing.Size(41, 20);
            this.lblDz.TabIndex = 27;
            this.lblDz.Text = "DZ";
            // 
            // txtDz
            // 
            this.txtDz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDz.EnableTouchMode = true;
            this.txtDz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDz.Location =  new System.Drawing.Point(0,0);
            this.txtDz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(152, 28);
            this.txtDz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDz.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblYb.AutoSize = true;
            this.lblYb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYb.Location = new System.Drawing.Point(0,0);
            this.lblYb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYb.Name = "lblYb";
            this.lblYb.Size = new System.Drawing.Size(41, 20);
            this.lblYb.TabIndex = 29;
            this.lblYb.Text = "YB";
            // 
            // txtYb
            // 
            this.txtYb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYb.EnableTouchMode = true;
            this.txtYb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYb.Location =  new System.Drawing.Point(0,0);
            this.txtYb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(152, 28);
            this.txtYb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYb.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblGzdw.AutoSize = true;
            this.lblGzdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGzdw.Location = new System.Drawing.Point(0,0);
            this.lblGzdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGzdw.Name = "lblGzdw";
            this.lblGzdw.Size = new System.Drawing.Size(41, 20);
            this.lblGzdw.TabIndex = 31;
            this.lblGzdw.Text = "GZDW";
            // 
            // txtGzdw
            // 
            this.txtGzdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGzdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGzdw.EnableTouchMode = true;
            this.txtGzdw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGzdw.Location =  new System.Drawing.Point(0,0);
            this.txtGzdw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGzdw.Name = "txtGzdw";
            this.txtGzdw.Size = new System.Drawing.Size(152, 28);
            this.txtGzdw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGzdw.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblDzyj.AutoSize = true;
            this.lblDzyj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDzyj.Location = new System.Drawing.Point(0,0);
            this.lblDzyj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDzyj.Name = "lblDzyj";
            this.lblDzyj.Size = new System.Drawing.Size(41, 20);
            this.lblDzyj.TabIndex = 33;
            this.lblDzyj.Text = "DZYJ";
            // 
            // txtDzyj
            // 
            this.txtDzyj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDzyj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDzyj.EnableTouchMode = true;
            this.txtDzyj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDzyj.Location =  new System.Drawing.Point(0,0);
            this.txtDzyj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDzyj.Name = "txtDzyj";
            this.txtDzyj.Size = new System.Drawing.Size(152, 28);
            this.txtDzyj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDzyj.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 35;
            this.lblBz.Text = "BZ";
            // 
            // txtBz
            // 
            this.txtBz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBz.EnableTouchMode = true;
            this.txtBz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBz.Location =  new System.Drawing.Point(0,0);
            this.txtBz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(152, 28);
            this.txtBz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBz.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrmc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrmc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrpy, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrpy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPysx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPysx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZjzl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtZjzl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZjh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtZjh, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFzjg, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFzjg, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSshy, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtSshy, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblGj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHjszss, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHjszss, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblXb, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtXb, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDh, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDh, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDz, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDz, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYb, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYb, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGzdw, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGzdw, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDzyj, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDzyj, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 4, 8);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);            
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";            
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 364);
            this.tableLayoutPanel1.TabIndex = 37; 
            //
            // ucR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucR";
            this.Size = new System.Drawing.Size(500, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPysx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSshy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHjszss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGzdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzyj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrmc;	
        private System.Windows.Forms.Label lblQlrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrpy;	
        private System.Windows.Forms.Label lblQlrpy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPysx;	
        private System.Windows.Forms.Label lblPysx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjzl;	
        private System.Windows.Forms.Label lblZjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjh;	
        private System.Windows.Forms.Label lblZjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFzjg;	
        private System.Windows.Forms.Label lblFzjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSshy;	
        private System.Windows.Forms.Label lblSshy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGj;	
        private System.Windows.Forms.Label lblGj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHjszss;	
        private System.Windows.Forms.Label lblHjszss;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXb;	
        private System.Windows.Forms.Label lblXb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDh;	
        private System.Windows.Forms.Label lblDh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDz;	
        private System.Windows.Forms.Label lblDz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYb;	
        private System.Windows.Forms.Label lblYb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGzdw;	
        private System.Windows.Forms.Label lblGzdw;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDzyj;	
        private System.Windows.Forms.Label lblDzyj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}