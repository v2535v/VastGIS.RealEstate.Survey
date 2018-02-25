using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucDyiq
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
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGydbdcdyh = new System.Windows.Forms.Label();
            this.txtGydbdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGydqlr = new System.Windows.Forms.Label();
            this.txtGydqlr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGydqlrzjzl = new System.Windows.Forms.Label();
            this.cmbGydqlrzjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblGydqlrzjh = new System.Windows.Forms.Label();
            this.txtGydqlrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXydbdcdyh = new System.Windows.Forms.Label();
            this.txtXydbdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXydzl = new System.Windows.Forms.Label();
            this.txtXydzl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXydqlr = new System.Windows.Forms.Label();
            this.txtXydqlr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXydqlrzjzl = new System.Windows.Forms.Label();
            this.cmbXydqlrzjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblXydqlrzjh = new System.Windows.Forms.Label();
            this.txtXydqlrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjlx = new System.Windows.Forms.Label();
            this.cmbDjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjyy = new System.Windows.Forms.Label();
            this.txtDjyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDyqnr = new System.Windows.Forms.Label();
            this.txtDyqnr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdcdjzmh = new System.Windows.Forms.Label();
            this.txtBdcdjzmh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlqssj = new System.Windows.Forms.Label();
            this.datQlqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblQljssj = new System.Windows.Forms.Label();
            this.datQljssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblQxdm = new System.Windows.Forms.Label();
            this.cmbQxdm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjjg = new System.Windows.Forms.Label();
            this.txtDjjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDbr = new System.Windows.Forms.Label();
            this.txtDbr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjsj = new System.Windows.Forms.Label();
            this.datDjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFj = new System.Windows.Forms.Label();
            this.txtFj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQszt = new System.Windows.Forms.Label();
            this.cmbQszt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydbdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydqlr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGydqlrzjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydqlrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydbdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydqlr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXydqlrzjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydqlrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDyqnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQlqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQljssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQszt)).BeginInit();
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
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 5;
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
            this.txtYwh.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblGydbdcdyh.AutoSize = true;
            this.lblGydbdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGydbdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblGydbdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGydbdcdyh.Name = "lblGydbdcdyh";
            this.lblGydbdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblGydbdcdyh.TabIndex = 7;
            this.lblGydbdcdyh.Text = "供役地不动产单元号";
            // 
            // txtGydbdcdyh
            // 
            this.txtGydbdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGydbdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGydbdcdyh.EnableTouchMode = true;
            this.txtGydbdcdyh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGydbdcdyh.Location =  new System.Drawing.Point(0,0);
            this.txtGydbdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGydbdcdyh.Name = "txtGydbdcdyh";
            this.txtGydbdcdyh.Size = new System.Drawing.Size(152, 28);
            this.txtGydbdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGydbdcdyh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblGydqlr.AutoSize = true;
            this.lblGydqlr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGydqlr.Location = new System.Drawing.Point(0,0);
            this.lblGydqlr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGydqlr.Name = "lblGydqlr";
            this.lblGydqlr.Size = new System.Drawing.Size(41, 20);
            this.lblGydqlr.TabIndex = 9;
            this.lblGydqlr.Text = "供役地权利人";
            // 
            // txtGydqlr
            // 
            this.txtGydqlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGydqlr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGydqlr.EnableTouchMode = true;
            this.txtGydqlr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGydqlr.Location =  new System.Drawing.Point(0,0);
            this.txtGydqlr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGydqlr.Name = "txtGydqlr";
            this.txtGydqlr.Size = new System.Drawing.Size(152, 28);
            this.txtGydqlr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGydqlr.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblGydqlrzjzl.AutoSize = true;
            this.lblGydqlrzjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGydqlrzjzl.Location = new System.Drawing.Point(0,0);
            this.lblGydqlrzjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGydqlrzjzl.Name = "lblGydqlrzjzl";
            this.lblGydqlrzjzl.Size = new System.Drawing.Size(41, 20);
            this.lblGydqlrzjzl.TabIndex = 11;
            this.lblGydqlrzjzl.Text = "供役地权利人证件种类";
            // 
            // cmbGydqlrzjzl
            // 
            this.cmbGydqlrzjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGydqlrzjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGydqlrzjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGydqlrzjzl.EnableTouchMode = true;
            this.cmbGydqlrzjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGydqlrzjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbGydqlrzjzl.Name = "cmbGydqlrzjzl";
            this.cmbGydqlrzjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbGydqlrzjzl.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblGydqlrzjh.AutoSize = true;
            this.lblGydqlrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGydqlrzjh.Location = new System.Drawing.Point(0,0);
            this.lblGydqlrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGydqlrzjh.Name = "lblGydqlrzjh";
            this.lblGydqlrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblGydqlrzjh.TabIndex = 13;
            this.lblGydqlrzjh.Text = "供役地权利人证件号";
            // 
            // txtGydqlrzjh
            // 
            this.txtGydqlrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGydqlrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGydqlrzjh.EnableTouchMode = true;
            this.txtGydqlrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGydqlrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtGydqlrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGydqlrzjh.Name = "txtGydqlrzjh";
            this.txtGydqlrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtGydqlrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGydqlrzjh.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblXydbdcdyh.AutoSize = true;
            this.lblXydbdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXydbdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblXydbdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXydbdcdyh.Name = "lblXydbdcdyh";
            this.lblXydbdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblXydbdcdyh.TabIndex = 15;
            this.lblXydbdcdyh.Text = "需役地不动产单元号";
            // 
            // txtXydbdcdyh
            // 
            this.txtXydbdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXydbdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXydbdcdyh.EnableTouchMode = true;
            this.txtXydbdcdyh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXydbdcdyh.Location =  new System.Drawing.Point(0,0);
            this.txtXydbdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXydbdcdyh.Name = "txtXydbdcdyh";
            this.txtXydbdcdyh.Size = new System.Drawing.Size(152, 28);
            this.txtXydbdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXydbdcdyh.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblXydzl.AutoSize = true;
            this.lblXydzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXydzl.Location = new System.Drawing.Point(0,0);
            this.lblXydzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXydzl.Name = "lblXydzl";
            this.lblXydzl.Size = new System.Drawing.Size(41, 20);
            this.lblXydzl.TabIndex = 17;
            this.lblXydzl.Text = "需役地坐落";
            // 
            // txtXydzl
            // 
            this.txtXydzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXydzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXydzl.EnableTouchMode = true;
            this.txtXydzl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXydzl.Location =  new System.Drawing.Point(0,0);
            this.txtXydzl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXydzl.Name = "txtXydzl";
            this.txtXydzl.Size = new System.Drawing.Size(152, 28);
            this.txtXydzl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXydzl.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblXydqlr.AutoSize = true;
            this.lblXydqlr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXydqlr.Location = new System.Drawing.Point(0,0);
            this.lblXydqlr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXydqlr.Name = "lblXydqlr";
            this.lblXydqlr.Size = new System.Drawing.Size(41, 20);
            this.lblXydqlr.TabIndex = 19;
            this.lblXydqlr.Text = "需役地权利人";
            // 
            // txtXydqlr
            // 
            this.txtXydqlr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXydqlr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXydqlr.EnableTouchMode = true;
            this.txtXydqlr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXydqlr.Location =  new System.Drawing.Point(0,0);
            this.txtXydqlr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXydqlr.Name = "txtXydqlr";
            this.txtXydqlr.Size = new System.Drawing.Size(152, 28);
            this.txtXydqlr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXydqlr.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblXydqlrzjzl.AutoSize = true;
            this.lblXydqlrzjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXydqlrzjzl.Location = new System.Drawing.Point(0,0);
            this.lblXydqlrzjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXydqlrzjzl.Name = "lblXydqlrzjzl";
            this.lblXydqlrzjzl.Size = new System.Drawing.Size(41, 20);
            this.lblXydqlrzjzl.TabIndex = 21;
            this.lblXydqlrzjzl.Text = "需役地权利人证件种类";
            // 
            // cmbXydqlrzjzl
            // 
            this.cmbXydqlrzjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbXydqlrzjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbXydqlrzjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXydqlrzjzl.EnableTouchMode = true;
            this.cmbXydqlrzjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXydqlrzjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbXydqlrzjzl.Name = "cmbXydqlrzjzl";
            this.cmbXydqlrzjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbXydqlrzjzl.TabIndex =  22;            
            // 
            // lblID
            // 
            this.lblXydqlrzjh.AutoSize = true;
            this.lblXydqlrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXydqlrzjh.Location = new System.Drawing.Point(0,0);
            this.lblXydqlrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXydqlrzjh.Name = "lblXydqlrzjh";
            this.lblXydqlrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblXydqlrzjh.TabIndex = 23;
            this.lblXydqlrzjh.Text = "需役地权利人证件号";
            // 
            // txtXydqlrzjh
            // 
            this.txtXydqlrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXydqlrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXydqlrzjh.EnableTouchMode = true;
            this.txtXydqlrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXydqlrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtXydqlrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXydqlrzjh.Name = "txtXydqlrzjh";
            this.txtXydqlrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtXydqlrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXydqlrzjh.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblDjlx.AutoSize = true;
            this.lblDjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjlx.Location = new System.Drawing.Point(0,0);
            this.lblDjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjlx.Name = "lblDjlx";
            this.lblDjlx.Size = new System.Drawing.Size(41, 20);
            this.lblDjlx.TabIndex = 25;
            this.lblDjlx.Text = "登记类型";
            // 
            // cmbDjlx
            // 
            this.cmbDjlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDjlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDjlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDjlx.EnableTouchMode = true;
            this.cmbDjlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDjlx.Location =  new System.Drawing.Point(0,0);
            this.cmbDjlx.Name = "cmbDjlx";
            this.cmbDjlx.Size = new System.Drawing.Size(152, 20);
            this.cmbDjlx.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblDjyy.AutoSize = true;
            this.lblDjyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjyy.Location = new System.Drawing.Point(0,0);
            this.lblDjyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjyy.Name = "lblDjyy";
            this.lblDjyy.Size = new System.Drawing.Size(41, 20);
            this.lblDjyy.TabIndex = 27;
            this.lblDjyy.Text = "登记原因";
            // 
            // txtDjyy
            // 
            this.txtDjyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjyy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjyy.EnableTouchMode = true;
            this.txtDjyy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjyy.Location =  new System.Drawing.Point(0,0);
            this.txtDjyy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjyy.Name = "txtDjyy";
            this.txtDjyy.Size = new System.Drawing.Size(152, 28);
            this.txtDjyy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjyy.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblDyqnr.AutoSize = true;
            this.lblDyqnr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDyqnr.Location = new System.Drawing.Point(0,0);
            this.lblDyqnr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDyqnr.Name = "lblDyqnr";
            this.lblDyqnr.Size = new System.Drawing.Size(41, 20);
            this.lblDyqnr.TabIndex = 29;
            this.lblDyqnr.Text = "地役权内容";
            // 
            // txtDyqnr
            // 
            this.txtDyqnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDyqnr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDyqnr.EnableTouchMode = true;
            this.txtDyqnr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDyqnr.Location =  new System.Drawing.Point(0,0);
            this.txtDyqnr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDyqnr.Name = "txtDyqnr";
            this.txtDyqnr.Size = new System.Drawing.Size(152, 28);
            this.txtDyqnr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDyqnr.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblBdcdjzmh.AutoSize = true;
            this.lblBdcdjzmh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdjzmh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdjzmh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdjzmh.Name = "lblBdcdjzmh";
            this.lblBdcdjzmh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdjzmh.TabIndex = 31;
            this.lblBdcdjzmh.Text = "不动产登记证明号";
            // 
            // txtBdcdjzmh
            // 
            this.txtBdcdjzmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdjzmh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdjzmh.EnableTouchMode = true;
            this.txtBdcdjzmh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdjzmh.Location =  new System.Drawing.Point(0,0);
            this.txtBdcdjzmh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdjzmh.Name = "txtBdcdjzmh";
            this.txtBdcdjzmh.Size = new System.Drawing.Size(152, 28);
            this.txtBdcdjzmh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdjzmh.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblQlqssj.AutoSize = true;
            this.lblQlqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlqssj.Location = new System.Drawing.Point(0,0);
            this.lblQlqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlqssj.Name = "lblQlqssj";
            this.lblQlqssj.Size = new System.Drawing.Size(41, 20);
            this.lblQlqssj.TabIndex = 33;
            this.lblQlqssj.Text = "权利起始时间";
            // 
            // datQlqssj
            // 
            this.datQlqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datQlqssj.BorderColor = System.Drawing.Color.Empty;
            this.datQlqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datQlqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datQlqssj.DropDownImage = null;
            this.datQlqssj.EnableTouchMode = true;
            this.datQlqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datQlqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datQlqssj.Location =  new System.Drawing.Point(0,0);
            this.datQlqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datQlqssj.MinValue = new System.DateTime(((long)(0)));
            this.datQlqssj.Name = "datQlqssj";
            this.datQlqssj.Size = new System.Drawing.Size(152, 20);
            this.datQlqssj.TabIndex = 34;
            this.datQlqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datQlqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblQljssj.AutoSize = true;
            this.lblQljssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQljssj.Location = new System.Drawing.Point(0,0);
            this.lblQljssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQljssj.Name = "lblQljssj";
            this.lblQljssj.Size = new System.Drawing.Size(41, 20);
            this.lblQljssj.TabIndex = 35;
            this.lblQljssj.Text = "权利结束时间";
            // 
            // datQljssj
            // 
            this.datQljssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datQljssj.BorderColor = System.Drawing.Color.Empty;
            this.datQljssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datQljssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datQljssj.DropDownImage = null;
            this.datQljssj.EnableTouchMode = true;
            this.datQljssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datQljssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datQljssj.Location =  new System.Drawing.Point(0,0);
            this.datQljssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datQljssj.MinValue = new System.DateTime(((long)(0)));
            this.datQljssj.Name = "datQljssj";
            this.datQljssj.Size = new System.Drawing.Size(152, 20);
            this.datQljssj.TabIndex = 36;
            this.datQljssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datQljssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 37;
            this.lblQxdm.Text = "区县代码";
            // 
            // cmbQxdm
            // 
            this.cmbQxdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQxdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQxdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQxdm.EnableTouchMode = true;
            this.cmbQxdm.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQxdm.Location =  new System.Drawing.Point(0,0);
            this.cmbQxdm.Name = "cmbQxdm";
            this.cmbQxdm.Size = new System.Drawing.Size(152, 20);
            this.cmbQxdm.TabIndex =  38;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 39;
            this.lblDjjg.Text = "登记机构";
            // 
            // txtDjjg
            // 
            this.txtDjjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjjg.EnableTouchMode = true;
            this.txtDjjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjjg.Location =  new System.Drawing.Point(0,0);
            this.txtDjjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjjg.Name = "txtDjjg";
            this.txtDjjg.Size = new System.Drawing.Size(152, 28);
            this.txtDjjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjjg.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 41;
            this.lblDbr.Text = "登簿人";
            // 
            // txtDbr
            // 
            this.txtDbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDbr.EnableTouchMode = true;
            this.txtDbr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDbr.Location =  new System.Drawing.Point(0,0);
            this.txtDbr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDbr.Name = "txtDbr";
            this.txtDbr.Size = new System.Drawing.Size(152, 28);
            this.txtDbr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDbr.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 43;
            this.lblDjsj.Text = "登记时间";
            // 
            // datDjsj
            // 
            this.datDjsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datDjsj.BorderColor = System.Drawing.Color.Empty;
            this.datDjsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datDjsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datDjsj.DropDownImage = null;
            this.datDjsj.EnableTouchMode = true;
            this.datDjsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datDjsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDjsj.Location =  new System.Drawing.Point(0,0);
            this.datDjsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datDjsj.MinValue = new System.DateTime(((long)(0)));
            this.datDjsj.Name = "datDjsj";
            this.datDjsj.Size = new System.Drawing.Size(152, 20);
            this.datDjsj.TabIndex = 44;
            this.datDjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datDjsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFj.AutoSize = true;
            this.lblFj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFj.Location = new System.Drawing.Point(0,0);
            this.lblFj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFj.Name = "lblFj";
            this.lblFj.Size = new System.Drawing.Size(41, 20);
            this.lblFj.TabIndex = 45;
            this.lblFj.Text = "附记";
            // 
            // txtFj
            // 
            this.txtFj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFj.EnableTouchMode = true;
            this.txtFj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFj.Location =  new System.Drawing.Point(0,0);
            this.txtFj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFj.Name = "txtFj";
            this.txtFj.Size = new System.Drawing.Size(152, 28);
            this.txtFj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFj.TabIndex = 46;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 47;
            this.lblQszt.Text = "权属状态";
            // 
            // cmbQszt
            // 
            this.cmbQszt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQszt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQszt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQszt.EnableTouchMode = true;
            this.cmbQszt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQszt.Location =  new System.Drawing.Point(0,0);
            this.cmbQszt.Name = "cmbQszt";
            this.cmbQszt.Size = new System.Drawing.Size(152, 20);
            this.cmbQszt.TabIndex =  48;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGydbdcdyh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGydbdcdyh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGydqlr, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtGydqlr, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGydqlrzjzl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbGydqlrzjzl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGydqlrzjh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGydqlrzjh, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblXydbdcdyh, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtXydbdcdyh, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblXydzl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtXydzl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXydqlr, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXydqlr, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblXydqlrzjzl, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbXydqlrzjzl, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblXydqlrzjh, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtXydqlrzjh, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjlx, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjlx, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjyy, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDjyy, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDyqnr, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDyqnr, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdjzmh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdjzmh, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblQlqssj, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.datQlqssj, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQljssj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.datQljssj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 7);
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
            // ucDyiq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDyiq";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydbdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydqlr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGydqlrzjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGydqlrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydbdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydqlr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXydqlrzjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXydqlrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDyqnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQlqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQljssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQszt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGydbdcdyh;	
        private System.Windows.Forms.Label lblGydbdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGydqlr;	
        private System.Windows.Forms.Label lblGydqlr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGydqlrzjzl;	
        private System.Windows.Forms.Label lblGydqlrzjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGydqlrzjh;	
        private System.Windows.Forms.Label lblGydqlrzjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXydbdcdyh;	
        private System.Windows.Forms.Label lblXydbdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXydzl;	
        private System.Windows.Forms.Label lblXydzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXydqlr;	
        private System.Windows.Forms.Label lblXydqlr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbXydqlrzjzl;	
        private System.Windows.Forms.Label lblXydqlrzjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXydqlrzjh;	
        private System.Windows.Forms.Label lblXydqlrzjh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjlx;	
        private System.Windows.Forms.Label lblDjlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjyy;	
        private System.Windows.Forms.Label lblDjyy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDyqnr;	
        private System.Windows.Forms.Label lblDyqnr;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdjzmh;	
        private System.Windows.Forms.Label lblBdcdjzmh;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datQlqssj;	
        private System.Windows.Forms.Label lblQlqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datQljssj;	
        private System.Windows.Forms.Label lblQljssj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQxdm;	
        private System.Windows.Forms.Label lblQxdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjjg;	
        private System.Windows.Forms.Label lblDjjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDbr;	
        private System.Windows.Forms.Label lblDbr;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datDjsj;	
        private System.Windows.Forms.Label lblDjsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFj;	
        private System.Windows.Forms.Label lblFj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}