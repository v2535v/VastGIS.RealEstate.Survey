using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSqr
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
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrmc = new System.Windows.Forms.Label();
            this.txtQlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrzjzl = new System.Windows.Forms.Label();
            this.cmbQlrzjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQlrzjh = new System.Windows.Forms.Label();
            this.txtQlrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrtxdz = new System.Windows.Forms.Label();
            this.txtQlrtxdz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlryb = new System.Windows.Forms.Label();
            this.txtQlryb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrfrmc = new System.Windows.Forms.Label();
            this.txtQlrfrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrfrdh = new System.Windows.Forms.Label();
            this.txtQlrfrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrdlrmc = new System.Windows.Forms.Label();
            this.txtQlrdlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrdlrdh = new System.Windows.Forms.Label();
            this.txtQlrdlrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrdljg = new System.Windows.Forms.Label();
            this.txtQlrdljg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrmc = new System.Windows.Forms.Label();
            this.txtYwrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrzjzl = new System.Windows.Forms.Label();
            this.cmbYwrzjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYwrzjh = new System.Windows.Forms.Label();
            this.txtYwrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrtxdz = new System.Windows.Forms.Label();
            this.txtYwrtxdz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwryb = new System.Windows.Forms.Label();
            this.txtYwryb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrfrmc = new System.Windows.Forms.Label();
            this.txtYwrfrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrfrdh = new System.Windows.Forms.Label();
            this.txtYwrfrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrdlrmc = new System.Windows.Forms.Label();
            this.txtYwrdlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrdlrdh = new System.Windows.Forms.Label();
            this.txtYwrdlrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrdljg = new System.Windows.Forms.Label();
            this.txtYwrdljg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlrzjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrtxdz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlryb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrfrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrfrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdlrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdljg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYwrzjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrtxdz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwryb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrfrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrfrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdlrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdljg)).BeginInit();
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
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 3;
            this.lblYwh.Text = "业务号";
            // 
            // txtYwh
            // 
            this.txtYwh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwh.EnableTouchMode = true;
            this.txtYwh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwh.Location =  new System.Drawing.Point(0,0);
            this.txtYwh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwh.Name = "txtYwh";
            this.txtYwh.Size = new System.Drawing.Size(152, 28);
            this.txtYwh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwh.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 5;
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
            this.txtYsdm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblQlrmc.AutoSize = true;
            this.lblQlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrmc.Location = new System.Drawing.Point(0,0);
            this.lblQlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrmc.Name = "lblQlrmc";
            this.lblQlrmc.Size = new System.Drawing.Size(41, 20);
            this.lblQlrmc.TabIndex = 7;
            this.lblQlrmc.Text = "权利人名称";
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
            this.txtQlrmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblQlrzjzl.AutoSize = true;
            this.lblQlrzjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrzjzl.Location = new System.Drawing.Point(0,0);
            this.lblQlrzjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrzjzl.Name = "lblQlrzjzl";
            this.lblQlrzjzl.Size = new System.Drawing.Size(41, 20);
            this.lblQlrzjzl.TabIndex = 9;
            this.lblQlrzjzl.Text = "权利人证件种类";
            // 
            // cmbQlrzjzl
            // 
            this.cmbQlrzjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQlrzjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQlrzjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQlrzjzl.EnableTouchMode = true;
            this.cmbQlrzjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQlrzjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbQlrzjzl.Name = "cmbQlrzjzl";
            this.cmbQlrzjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbQlrzjzl.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblQlrzjh.AutoSize = true;
            this.lblQlrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrzjh.Location = new System.Drawing.Point(0,0);
            this.lblQlrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrzjh.Name = "lblQlrzjh";
            this.lblQlrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblQlrzjh.TabIndex = 11;
            this.lblQlrzjh.Text = "权利人证件号";
            // 
            // txtQlrzjh
            // 
            this.txtQlrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrzjh.EnableTouchMode = true;
            this.txtQlrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtQlrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrzjh.Name = "txtQlrzjh";
            this.txtQlrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtQlrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrzjh.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblQlrtxdz.AutoSize = true;
            this.lblQlrtxdz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrtxdz.Location = new System.Drawing.Point(0,0);
            this.lblQlrtxdz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrtxdz.Name = "lblQlrtxdz";
            this.lblQlrtxdz.Size = new System.Drawing.Size(41, 20);
            this.lblQlrtxdz.TabIndex = 13;
            this.lblQlrtxdz.Text = "权利人通讯地址";
            // 
            // txtQlrtxdz
            // 
            this.txtQlrtxdz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrtxdz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrtxdz.EnableTouchMode = true;
            this.txtQlrtxdz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrtxdz.Location =  new System.Drawing.Point(0,0);
            this.txtQlrtxdz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrtxdz.Name = "txtQlrtxdz";
            this.txtQlrtxdz.Size = new System.Drawing.Size(152, 28);
            this.txtQlrtxdz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrtxdz.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblQlryb.AutoSize = true;
            this.lblQlryb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlryb.Location = new System.Drawing.Point(0,0);
            this.lblQlryb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlryb.Name = "lblQlryb";
            this.lblQlryb.Size = new System.Drawing.Size(41, 20);
            this.lblQlryb.TabIndex = 15;
            this.lblQlryb.Text = "权利人邮编";
            // 
            // txtQlryb
            // 
            this.txtQlryb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlryb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlryb.EnableTouchMode = true;
            this.txtQlryb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlryb.Location =  new System.Drawing.Point(0,0);
            this.txtQlryb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlryb.Name = "txtQlryb";
            this.txtQlryb.Size = new System.Drawing.Size(152, 28);
            this.txtQlryb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlryb.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblQlrfrmc.AutoSize = true;
            this.lblQlrfrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrfrmc.Location = new System.Drawing.Point(0,0);
            this.lblQlrfrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrfrmc.Name = "lblQlrfrmc";
            this.lblQlrfrmc.Size = new System.Drawing.Size(41, 20);
            this.lblQlrfrmc.TabIndex = 17;
            this.lblQlrfrmc.Text = "权利人法人名称";
            // 
            // txtQlrfrmc
            // 
            this.txtQlrfrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrfrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrfrmc.EnableTouchMode = true;
            this.txtQlrfrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrfrmc.Location =  new System.Drawing.Point(0,0);
            this.txtQlrfrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrfrmc.Name = "txtQlrfrmc";
            this.txtQlrfrmc.Size = new System.Drawing.Size(152, 28);
            this.txtQlrfrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrfrmc.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblQlrfrdh.AutoSize = true;
            this.lblQlrfrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrfrdh.Location = new System.Drawing.Point(0,0);
            this.lblQlrfrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrfrdh.Name = "lblQlrfrdh";
            this.lblQlrfrdh.Size = new System.Drawing.Size(41, 20);
            this.lblQlrfrdh.TabIndex = 19;
            this.lblQlrfrdh.Text = "权利人法人电话";
            // 
            // txtQlrfrdh
            // 
            this.txtQlrfrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrfrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrfrdh.EnableTouchMode = true;
            this.txtQlrfrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrfrdh.Location =  new System.Drawing.Point(0,0);
            this.txtQlrfrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrfrdh.Name = "txtQlrfrdh";
            this.txtQlrfrdh.Size = new System.Drawing.Size(152, 28);
            this.txtQlrfrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrfrdh.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblQlrdlrmc.AutoSize = true;
            this.lblQlrdlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrdlrmc.Location = new System.Drawing.Point(0,0);
            this.lblQlrdlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrdlrmc.Name = "lblQlrdlrmc";
            this.lblQlrdlrmc.Size = new System.Drawing.Size(41, 20);
            this.lblQlrdlrmc.TabIndex = 21;
            this.lblQlrdlrmc.Text = "权利人代理人名称";
            // 
            // txtQlrdlrmc
            // 
            this.txtQlrdlrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrdlrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrdlrmc.EnableTouchMode = true;
            this.txtQlrdlrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrdlrmc.Location =  new System.Drawing.Point(0,0);
            this.txtQlrdlrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrdlrmc.Name = "txtQlrdlrmc";
            this.txtQlrdlrmc.Size = new System.Drawing.Size(152, 28);
            this.txtQlrdlrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrdlrmc.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblQlrdlrdh.AutoSize = true;
            this.lblQlrdlrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrdlrdh.Location = new System.Drawing.Point(0,0);
            this.lblQlrdlrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrdlrdh.Name = "lblQlrdlrdh";
            this.lblQlrdlrdh.Size = new System.Drawing.Size(41, 20);
            this.lblQlrdlrdh.TabIndex = 23;
            this.lblQlrdlrdh.Text = "权利人代理人电话";
            // 
            // txtQlrdlrdh
            // 
            this.txtQlrdlrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrdlrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrdlrdh.EnableTouchMode = true;
            this.txtQlrdlrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrdlrdh.Location =  new System.Drawing.Point(0,0);
            this.txtQlrdlrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrdlrdh.Name = "txtQlrdlrdh";
            this.txtQlrdlrdh.Size = new System.Drawing.Size(152, 28);
            this.txtQlrdlrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrdlrdh.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblQlrdljg.AutoSize = true;
            this.lblQlrdljg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrdljg.Location = new System.Drawing.Point(0,0);
            this.lblQlrdljg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrdljg.Name = "lblQlrdljg";
            this.lblQlrdljg.Size = new System.Drawing.Size(41, 20);
            this.lblQlrdljg.TabIndex = 25;
            this.lblQlrdljg.Text = "权利人代理机构";
            // 
            // txtQlrdljg
            // 
            this.txtQlrdljg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrdljg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrdljg.EnableTouchMode = true;
            this.txtQlrdljg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrdljg.Location =  new System.Drawing.Point(0,0);
            this.txtQlrdljg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrdljg.Name = "txtQlrdljg";
            this.txtQlrdljg.Size = new System.Drawing.Size(152, 28);
            this.txtQlrdljg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrdljg.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblYwrmc.AutoSize = true;
            this.lblYwrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrmc.Location = new System.Drawing.Point(0,0);
            this.lblYwrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrmc.Name = "lblYwrmc";
            this.lblYwrmc.Size = new System.Drawing.Size(41, 20);
            this.lblYwrmc.TabIndex = 27;
            this.lblYwrmc.Text = "义务人名称";
            // 
            // txtYwrmc
            // 
            this.txtYwrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrmc.EnableTouchMode = true;
            this.txtYwrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrmc.Location =  new System.Drawing.Point(0,0);
            this.txtYwrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrmc.Name = "txtYwrmc";
            this.txtYwrmc.Size = new System.Drawing.Size(152, 28);
            this.txtYwrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrmc.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblYwrzjzl.AutoSize = true;
            this.lblYwrzjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrzjzl.Location = new System.Drawing.Point(0,0);
            this.lblYwrzjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrzjzl.Name = "lblYwrzjzl";
            this.lblYwrzjzl.Size = new System.Drawing.Size(41, 20);
            this.lblYwrzjzl.TabIndex = 29;
            this.lblYwrzjzl.Text = "义务人证件种类";
            // 
            // cmbYwrzjzl
            // 
            this.cmbYwrzjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYwrzjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYwrzjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYwrzjzl.EnableTouchMode = true;
            this.cmbYwrzjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYwrzjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbYwrzjzl.Name = "cmbYwrzjzl";
            this.cmbYwrzjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbYwrzjzl.TabIndex =  30;            
            // 
            // lblID
            // 
            this.lblYwrzjh.AutoSize = true;
            this.lblYwrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrzjh.Location = new System.Drawing.Point(0,0);
            this.lblYwrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrzjh.Name = "lblYwrzjh";
            this.lblYwrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblYwrzjh.TabIndex = 31;
            this.lblYwrzjh.Text = "义务人证件号";
            // 
            // txtYwrzjh
            // 
            this.txtYwrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrzjh.EnableTouchMode = true;
            this.txtYwrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtYwrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrzjh.Name = "txtYwrzjh";
            this.txtYwrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtYwrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrzjh.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblYwrtxdz.AutoSize = true;
            this.lblYwrtxdz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrtxdz.Location = new System.Drawing.Point(0,0);
            this.lblYwrtxdz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrtxdz.Name = "lblYwrtxdz";
            this.lblYwrtxdz.Size = new System.Drawing.Size(41, 20);
            this.lblYwrtxdz.TabIndex = 33;
            this.lblYwrtxdz.Text = "义务人通讯地址";
            // 
            // txtYwrtxdz
            // 
            this.txtYwrtxdz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrtxdz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrtxdz.EnableTouchMode = true;
            this.txtYwrtxdz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrtxdz.Location =  new System.Drawing.Point(0,0);
            this.txtYwrtxdz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrtxdz.Name = "txtYwrtxdz";
            this.txtYwrtxdz.Size = new System.Drawing.Size(152, 28);
            this.txtYwrtxdz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrtxdz.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblYwryb.AutoSize = true;
            this.lblYwryb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwryb.Location = new System.Drawing.Point(0,0);
            this.lblYwryb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwryb.Name = "lblYwryb";
            this.lblYwryb.Size = new System.Drawing.Size(41, 20);
            this.lblYwryb.TabIndex = 35;
            this.lblYwryb.Text = "义务人邮编";
            // 
            // txtYwryb
            // 
            this.txtYwryb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwryb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwryb.EnableTouchMode = true;
            this.txtYwryb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwryb.Location =  new System.Drawing.Point(0,0);
            this.txtYwryb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwryb.Name = "txtYwryb";
            this.txtYwryb.Size = new System.Drawing.Size(152, 28);
            this.txtYwryb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwryb.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblYwrfrmc.AutoSize = true;
            this.lblYwrfrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrfrmc.Location = new System.Drawing.Point(0,0);
            this.lblYwrfrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrfrmc.Name = "lblYwrfrmc";
            this.lblYwrfrmc.Size = new System.Drawing.Size(41, 20);
            this.lblYwrfrmc.TabIndex = 37;
            this.lblYwrfrmc.Text = "义务人法人名称";
            // 
            // txtYwrfrmc
            // 
            this.txtYwrfrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrfrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrfrmc.EnableTouchMode = true;
            this.txtYwrfrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrfrmc.Location =  new System.Drawing.Point(0,0);
            this.txtYwrfrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrfrmc.Name = "txtYwrfrmc";
            this.txtYwrfrmc.Size = new System.Drawing.Size(152, 28);
            this.txtYwrfrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrfrmc.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblYwrfrdh.AutoSize = true;
            this.lblYwrfrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrfrdh.Location = new System.Drawing.Point(0,0);
            this.lblYwrfrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrfrdh.Name = "lblYwrfrdh";
            this.lblYwrfrdh.Size = new System.Drawing.Size(41, 20);
            this.lblYwrfrdh.TabIndex = 39;
            this.lblYwrfrdh.Text = "义务人法人电话";
            // 
            // txtYwrfrdh
            // 
            this.txtYwrfrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrfrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrfrdh.EnableTouchMode = true;
            this.txtYwrfrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrfrdh.Location =  new System.Drawing.Point(0,0);
            this.txtYwrfrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrfrdh.Name = "txtYwrfrdh";
            this.txtYwrfrdh.Size = new System.Drawing.Size(152, 28);
            this.txtYwrfrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrfrdh.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblYwrdlrmc.AutoSize = true;
            this.lblYwrdlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrdlrmc.Location = new System.Drawing.Point(0,0);
            this.lblYwrdlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrdlrmc.Name = "lblYwrdlrmc";
            this.lblYwrdlrmc.Size = new System.Drawing.Size(41, 20);
            this.lblYwrdlrmc.TabIndex = 41;
            this.lblYwrdlrmc.Text = "义务人代理人名称";
            // 
            // txtYwrdlrmc
            // 
            this.txtYwrdlrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrdlrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrdlrmc.EnableTouchMode = true;
            this.txtYwrdlrmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrdlrmc.Location =  new System.Drawing.Point(0,0);
            this.txtYwrdlrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrdlrmc.Name = "txtYwrdlrmc";
            this.txtYwrdlrmc.Size = new System.Drawing.Size(152, 28);
            this.txtYwrdlrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrdlrmc.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblYwrdlrdh.AutoSize = true;
            this.lblYwrdlrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrdlrdh.Location = new System.Drawing.Point(0,0);
            this.lblYwrdlrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrdlrdh.Name = "lblYwrdlrdh";
            this.lblYwrdlrdh.Size = new System.Drawing.Size(41, 20);
            this.lblYwrdlrdh.TabIndex = 43;
            this.lblYwrdlrdh.Text = "义务人代理人电话";
            // 
            // txtYwrdlrdh
            // 
            this.txtYwrdlrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrdlrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrdlrdh.EnableTouchMode = true;
            this.txtYwrdlrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrdlrdh.Location =  new System.Drawing.Point(0,0);
            this.txtYwrdlrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrdlrdh.Name = "txtYwrdlrdh";
            this.txtYwrdlrdh.Size = new System.Drawing.Size(152, 28);
            this.txtYwrdlrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrdlrdh.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblYwrdljg.AutoSize = true;
            this.lblYwrdljg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrdljg.Location = new System.Drawing.Point(0,0);
            this.lblYwrdljg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrdljg.Name = "lblYwrdljg";
            this.lblYwrdljg.Size = new System.Drawing.Size(41, 20);
            this.lblYwrdljg.TabIndex = 45;
            this.lblYwrdljg.Text = "义务人代理机构";
            // 
            // txtYwrdljg
            // 
            this.txtYwrdljg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrdljg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrdljg.EnableTouchMode = true;
            this.txtYwrdljg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrdljg.Location =  new System.Drawing.Point(0,0);
            this.txtYwrdljg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrdljg.Name = "txtYwrdljg";
            this.txtYwrdljg.Size = new System.Drawing.Size(152, 28);
            this.txtYwrdljg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrdljg.TabIndex = 46;
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 47;
            this.lblBz.Text = "备注";
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
            this.txtBz.TabIndex = 48;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrzjzl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbQlrzjzl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrzjh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrzjh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrtxdz, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrtxdz, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQlryb, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtQlryb, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrfrmc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrfrmc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrfrdh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrfrdh, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrdlrmc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrdlrmc, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrdlrdh, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrdlrdh, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrdljg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrdljg, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrmc, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrmc, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrzjzl, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbYwrzjzl, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrzjh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrzjh, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrtxdz, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrtxdz, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYwryb, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwryb, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrfrmc, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrfrmc, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrfrdh, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrfrdh, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrdlrmc, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrdlrmc, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrdlrdh, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrdlrdh, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrdljg, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrdljg, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 7);
            this.tableLayoutPanel1.RowCount = 8;
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
            this.tableLayoutPanel1.TabIndex = 49; 
            //
            // ucSqr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSqr";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlrzjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrtxdz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlryb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrfrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrfrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdlrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrdljg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYwrzjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrtxdz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwryb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrfrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrfrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdlrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrdljg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrmc;	
        private System.Windows.Forms.Label lblQlrmc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQlrzjzl;	
        private System.Windows.Forms.Label lblQlrzjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrzjh;	
        private System.Windows.Forms.Label lblQlrzjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrtxdz;	
        private System.Windows.Forms.Label lblQlrtxdz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlryb;	
        private System.Windows.Forms.Label lblQlryb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrfrmc;	
        private System.Windows.Forms.Label lblQlrfrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrfrdh;	
        private System.Windows.Forms.Label lblQlrfrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrdlrmc;	
        private System.Windows.Forms.Label lblQlrdlrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrdlrdh;	
        private System.Windows.Forms.Label lblQlrdlrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrdljg;	
        private System.Windows.Forms.Label lblQlrdljg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrmc;	
        private System.Windows.Forms.Label lblYwrmc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYwrzjzl;	
        private System.Windows.Forms.Label lblYwrzjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrzjh;	
        private System.Windows.Forms.Label lblYwrzjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrtxdz;	
        private System.Windows.Forms.Label lblYwrtxdz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwryb;	
        private System.Windows.Forms.Label lblYwryb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrfrmc;	
        private System.Windows.Forms.Label lblYwrfrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrfrdh;	
        private System.Windows.Forms.Label lblYwrfrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrdlrmc;	
        private System.Windows.Forms.Label lblYwrdlrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrdlrdh;	
        private System.Windows.Forms.Label lblYwrdlrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrdljg;	
        private System.Windows.Forms.Label lblYwrdljg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}