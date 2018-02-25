using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucLq
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
            this.lblBdcdyh = new System.Windows.Forms.Label();
            this.txtBdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQllx = new System.Windows.Forms.Label();
            this.cmbQllx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjlx = new System.Windows.Forms.Label();
            this.cmbDjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjyy = new System.Windows.Forms.Label();
            this.txtDjyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFbf = new System.Windows.Forms.Label();
            this.txtFbf = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSyqmj = new System.Windows.Forms.Label();
            this.dblSyqmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblLdsyqssj = new System.Windows.Forms.Label();
            this.datLdsyqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblLdsyjssj = new System.Windows.Forms.Label();
            this.datLdsyjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblLdsyqxz = new System.Windows.Forms.Label();
            this.cmbLdsyqxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSllmsyqr1 = new System.Windows.Forms.Label();
            this.txtSllmsyqr1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSllmsyqr2 = new System.Windows.Forms.Label();
            this.txtSllmsyqr2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZysz = new System.Windows.Forms.Label();
            this.txtZysz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZs = new System.Windows.Forms.Label();
            this.intZs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblLz = new System.Windows.Forms.Label();
            this.cmbLz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQy = new System.Windows.Forms.Label();
            this.cmbQy = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZlnd = new System.Windows.Forms.Label();
            this.intZlnd = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblLb = new System.Windows.Forms.Label();
            this.txtLb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXb = new System.Windows.Forms.Label();
            this.txtXb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXdm = new System.Windows.Forms.Label();
            this.txtXdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdcqzh = new System.Windows.Forms.Label();
            this.txtBdcqzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyqmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datLdsyqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datLdsyjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLdsyqxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSllmsyqr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSllmsyqr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZysz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZlnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).BeginInit();
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
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdyh.TabIndex = 5;
            this.lblBdcdyh.Text = "不动产单元号";
            // 
            // txtBdcdyh
            // 
            this.txtBdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdyh.EnableTouchMode = true;
            this.txtBdcdyh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdyh.Location =  new System.Drawing.Point(0,0);
            this.txtBdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdyh.Name = "txtBdcdyh";
            this.txtBdcdyh.Size = new System.Drawing.Size(152, 28);
            this.txtBdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdyh.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 7;
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
            this.txtYwh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblQllx.AutoSize = true;
            this.lblQllx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQllx.Location = new System.Drawing.Point(0,0);
            this.lblQllx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQllx.Name = "lblQllx";
            this.lblQllx.Size = new System.Drawing.Size(41, 20);
            this.lblQllx.TabIndex = 9;
            this.lblQllx.Text = "权利类型";
            // 
            // cmbQllx
            // 
            this.cmbQllx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQllx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQllx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQllx.EnableTouchMode = true;
            this.cmbQllx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQllx.Location =  new System.Drawing.Point(0,0);
            this.cmbQllx.Name = "cmbQllx";
            this.cmbQllx.Size = new System.Drawing.Size(152, 20);
            this.cmbQllx.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblDjlx.AutoSize = true;
            this.lblDjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjlx.Location = new System.Drawing.Point(0,0);
            this.lblDjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjlx.Name = "lblDjlx";
            this.lblDjlx.Size = new System.Drawing.Size(41, 20);
            this.lblDjlx.TabIndex = 11;
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
            this.cmbDjlx.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblDjyy.AutoSize = true;
            this.lblDjyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjyy.Location = new System.Drawing.Point(0,0);
            this.lblDjyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjyy.Name = "lblDjyy";
            this.lblDjyy.Size = new System.Drawing.Size(41, 20);
            this.lblDjyy.TabIndex = 13;
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
            this.txtDjyy.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblFbf.AutoSize = true;
            this.lblFbf.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFbf.Location = new System.Drawing.Point(0,0);
            this.lblFbf.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFbf.Name = "lblFbf";
            this.lblFbf.Size = new System.Drawing.Size(41, 20);
            this.lblFbf.TabIndex = 15;
            this.lblFbf.Text = "发包方";
            // 
            // txtFbf
            // 
            this.txtFbf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFbf.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFbf.EnableTouchMode = true;
            this.txtFbf.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFbf.Location =  new System.Drawing.Point(0,0);
            this.txtFbf.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFbf.Name = "txtFbf";
            this.txtFbf.Size = new System.Drawing.Size(152, 28);
            this.txtFbf.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFbf.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblSyqmj.AutoSize = true;
            this.lblSyqmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyqmj.Location = new System.Drawing.Point(0,0);
            this.lblSyqmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyqmj.Name = "lblSyqmj";
            this.lblSyqmj.Size = new System.Drawing.Size(41, 20);
            this.lblSyqmj.TabIndex = 17;
            this.lblSyqmj.Text = "使用权（承包）面积";
            // 
            // dblSyqmj
            // 
            this.dblSyqmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSyqmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSyqmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSyqmj.DoubleValue = 1D;
            this.dblSyqmj.EnableTouchMode = true;
            this.dblSyqmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSyqmj.Location =  new System.Drawing.Point(0,0);
            this.dblSyqmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSyqmj.Name = "dblSyqmj";
            this.dblSyqmj.NullString = "";
            this.dblSyqmj.Size = new System.Drawing.Size(152, 28);
            this.dblSyqmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSyqmj.TabIndex = 18;
            this.dblSyqmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblLdsyqssj.AutoSize = true;
            this.lblLdsyqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLdsyqssj.Location = new System.Drawing.Point(0,0);
            this.lblLdsyqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLdsyqssj.Name = "lblLdsyqssj";
            this.lblLdsyqssj.Size = new System.Drawing.Size(41, 20);
            this.lblLdsyqssj.TabIndex = 19;
            this.lblLdsyqssj.Text = "林地使用（承包）起始时间";
            // 
            // datLdsyqssj
            // 
            this.datLdsyqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datLdsyqssj.BorderColor = System.Drawing.Color.Empty;
            this.datLdsyqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datLdsyqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datLdsyqssj.DropDownImage = null;
            this.datLdsyqssj.EnableTouchMode = true;
            this.datLdsyqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datLdsyqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datLdsyqssj.Location =  new System.Drawing.Point(0,0);
            this.datLdsyqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datLdsyqssj.MinValue = new System.DateTime(((long)(0)));
            this.datLdsyqssj.Name = "datLdsyqssj";
            this.datLdsyqssj.Size = new System.Drawing.Size(152, 20);
            this.datLdsyqssj.TabIndex = 20;
            this.datLdsyqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datLdsyqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblLdsyjssj.AutoSize = true;
            this.lblLdsyjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLdsyjssj.Location = new System.Drawing.Point(0,0);
            this.lblLdsyjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLdsyjssj.Name = "lblLdsyjssj";
            this.lblLdsyjssj.Size = new System.Drawing.Size(41, 20);
            this.lblLdsyjssj.TabIndex = 21;
            this.lblLdsyjssj.Text = "林地使用（承包）结束时间";
            // 
            // datLdsyjssj
            // 
            this.datLdsyjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datLdsyjssj.BorderColor = System.Drawing.Color.Empty;
            this.datLdsyjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datLdsyjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datLdsyjssj.DropDownImage = null;
            this.datLdsyjssj.EnableTouchMode = true;
            this.datLdsyjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datLdsyjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datLdsyjssj.Location =  new System.Drawing.Point(0,0);
            this.datLdsyjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datLdsyjssj.MinValue = new System.DateTime(((long)(0)));
            this.datLdsyjssj.Name = "datLdsyjssj";
            this.datLdsyjssj.Size = new System.Drawing.Size(152, 20);
            this.datLdsyjssj.TabIndex = 22;
            this.datLdsyjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datLdsyjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblLdsyqxz.AutoSize = true;
            this.lblLdsyqxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLdsyqxz.Location = new System.Drawing.Point(0,0);
            this.lblLdsyqxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLdsyqxz.Name = "lblLdsyqxz";
            this.lblLdsyqxz.Size = new System.Drawing.Size(41, 20);
            this.lblLdsyqxz.TabIndex = 23;
            this.lblLdsyqxz.Text = "林地所有权性质";
            // 
            // cmbLdsyqxz
            // 
            this.cmbLdsyqxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLdsyqxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbLdsyqxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLdsyqxz.EnableTouchMode = true;
            this.cmbLdsyqxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLdsyqxz.Location =  new System.Drawing.Point(0,0);
            this.cmbLdsyqxz.Name = "cmbLdsyqxz";
            this.cmbLdsyqxz.Size = new System.Drawing.Size(152, 20);
            this.cmbLdsyqxz.TabIndex =  24;            
            // 
            // lblID
            // 
            this.lblSllmsyqr1.AutoSize = true;
            this.lblSllmsyqr1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSllmsyqr1.Location = new System.Drawing.Point(0,0);
            this.lblSllmsyqr1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSllmsyqr1.Name = "lblSllmsyqr1";
            this.lblSllmsyqr1.Size = new System.Drawing.Size(41, 20);
            this.lblSllmsyqr1.TabIndex = 25;
            this.lblSllmsyqr1.Text = "森林、林木所有权人";
            // 
            // txtSllmsyqr1
            // 
            this.txtSllmsyqr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSllmsyqr1.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSllmsyqr1.EnableTouchMode = true;
            this.txtSllmsyqr1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSllmsyqr1.Location =  new System.Drawing.Point(0,0);
            this.txtSllmsyqr1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSllmsyqr1.Name = "txtSllmsyqr1";
            this.txtSllmsyqr1.Size = new System.Drawing.Size(152, 28);
            this.txtSllmsyqr1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSllmsyqr1.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblSllmsyqr2.AutoSize = true;
            this.lblSllmsyqr2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSllmsyqr2.Location = new System.Drawing.Point(0,0);
            this.lblSllmsyqr2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSllmsyqr2.Name = "lblSllmsyqr2";
            this.lblSllmsyqr2.Size = new System.Drawing.Size(41, 20);
            this.lblSllmsyqr2.TabIndex = 27;
            this.lblSllmsyqr2.Text = "森林、林木使用权人";
            // 
            // txtSllmsyqr2
            // 
            this.txtSllmsyqr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSllmsyqr2.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSllmsyqr2.EnableTouchMode = true;
            this.txtSllmsyqr2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSllmsyqr2.Location =  new System.Drawing.Point(0,0);
            this.txtSllmsyqr2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSllmsyqr2.Name = "txtSllmsyqr2";
            this.txtSllmsyqr2.Size = new System.Drawing.Size(152, 28);
            this.txtSllmsyqr2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSllmsyqr2.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblZysz.AutoSize = true;
            this.lblZysz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZysz.Location = new System.Drawing.Point(0,0);
            this.lblZysz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZysz.Name = "lblZysz";
            this.lblZysz.Size = new System.Drawing.Size(41, 20);
            this.lblZysz.TabIndex = 29;
            this.lblZysz.Text = "主要树种";
            // 
            // txtZysz
            // 
            this.txtZysz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZysz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZysz.EnableTouchMode = true;
            this.txtZysz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZysz.Location =  new System.Drawing.Point(0,0);
            this.txtZysz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZysz.Name = "txtZysz";
            this.txtZysz.Size = new System.Drawing.Size(152, 28);
            this.txtZysz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZysz.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblZs.AutoSize = true;
            this.lblZs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZs.Location = new System.Drawing.Point(0,0);
            this.lblZs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZs.Name = "lblZs";
            this.lblZs.Size = new System.Drawing.Size(41, 20);
            this.lblZs.TabIndex = 31;
            this.lblZs.Text = "株数";
            // 
            // intZs
            // 
            this.intZs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZs.EnableTouchMode = true;
            this.intZs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZs.IntegerValue = ((long)(0));
            this.intZs.Location = new System.Drawing.Point(0,0);
            this.intZs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZs.Name = "intZs";
            this.intZs.NullString = "";
            this.intZs.Size = new System.Drawing.Size(152, 28);
            this.intZs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZs.TabIndex = 32;
            this.intZs.Text = "0";
            // 
            // lblID
            // 
            this.lblLz.AutoSize = true;
            this.lblLz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLz.Location = new System.Drawing.Point(0,0);
            this.lblLz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLz.Name = "lblLz";
            this.lblLz.Size = new System.Drawing.Size(41, 20);
            this.lblLz.TabIndex = 33;
            this.lblLz.Text = "林种";
            // 
            // cmbLz
            // 
            this.cmbLz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbLz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLz.EnableTouchMode = true;
            this.cmbLz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLz.Location =  new System.Drawing.Point(0,0);
            this.cmbLz.Name = "cmbLz";
            this.cmbLz.Size = new System.Drawing.Size(152, 20);
            this.cmbLz.TabIndex =  34;            
            // 
            // lblID
            // 
            this.lblQy.AutoSize = true;
            this.lblQy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQy.Location = new System.Drawing.Point(0,0);
            this.lblQy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQy.Name = "lblQy";
            this.lblQy.Size = new System.Drawing.Size(41, 20);
            this.lblQy.TabIndex = 35;
            this.lblQy.Text = "起源";
            // 
            // cmbQy
            // 
            this.cmbQy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQy.EnableTouchMode = true;
            this.cmbQy.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQy.Location =  new System.Drawing.Point(0,0);
            this.cmbQy.Name = "cmbQy";
            this.cmbQy.Size = new System.Drawing.Size(152, 20);
            this.cmbQy.TabIndex =  36;            
            // 
            // lblID
            // 
            this.lblZlnd.AutoSize = true;
            this.lblZlnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZlnd.Location = new System.Drawing.Point(0,0);
            this.lblZlnd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZlnd.Name = "lblZlnd";
            this.lblZlnd.Size = new System.Drawing.Size(41, 20);
            this.lblZlnd.TabIndex = 37;
            this.lblZlnd.Text = "造林年度";
            // 
            // intZlnd
            // 
            this.intZlnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZlnd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZlnd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZlnd.EnableTouchMode = true;
            this.intZlnd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZlnd.IntegerValue = ((long)(0));
            this.intZlnd.Location = new System.Drawing.Point(0,0);
            this.intZlnd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZlnd.Name = "intZlnd";
            this.intZlnd.NullString = "";
            this.intZlnd.Size = new System.Drawing.Size(152, 28);
            this.intZlnd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZlnd.TabIndex = 38;
            this.intZlnd.Text = "0";
            // 
            // lblID
            // 
            this.lblLb.AutoSize = true;
            this.lblLb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLb.Location = new System.Drawing.Point(0,0);
            this.lblLb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLb.Name = "lblLb";
            this.lblLb.Size = new System.Drawing.Size(41, 20);
            this.lblLb.TabIndex = 39;
            this.lblLb.Text = "林班";
            // 
            // txtLb
            // 
            this.txtLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLb.EnableTouchMode = true;
            this.txtLb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLb.Location =  new System.Drawing.Point(0,0);
            this.txtLb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLb.Name = "txtLb";
            this.txtLb.Size = new System.Drawing.Size(152, 28);
            this.txtLb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLb.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblXb.AutoSize = true;
            this.lblXb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXb.Location = new System.Drawing.Point(0,0);
            this.lblXb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXb.Name = "lblXb";
            this.lblXb.Size = new System.Drawing.Size(41, 20);
            this.lblXb.TabIndex = 41;
            this.lblXb.Text = "小班";
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
            this.txtXb.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblXdm.AutoSize = true;
            this.lblXdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXdm.Location = new System.Drawing.Point(0,0);
            this.lblXdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXdm.Name = "lblXdm";
            this.lblXdm.Size = new System.Drawing.Size(41, 20);
            this.lblXdm.TabIndex = 43;
            this.lblXdm.Text = "小地名";
            // 
            // txtXdm
            // 
            this.txtXdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXdm.EnableTouchMode = true;
            this.txtXdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXdm.Location =  new System.Drawing.Point(0,0);
            this.txtXdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXdm.Name = "txtXdm";
            this.txtXdm.Size = new System.Drawing.Size(152, 28);
            this.txtXdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXdm.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 45;
            this.lblBdcqzh.Text = "不动产权证号";
            // 
            // txtBdcqzh
            // 
            this.txtBdcqzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcqzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcqzh.EnableTouchMode = true;
            this.txtBdcqzh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcqzh.Location =  new System.Drawing.Point(0,0);
            this.txtBdcqzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcqzh.Name = "txtBdcqzh";
            this.txtBdcqzh.Size = new System.Drawing.Size(152, 28);
            this.txtBdcqzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcqzh.TabIndex = 46;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 47;
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
            this.cmbQxdm.TabIndex =  48;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 49;
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
            this.txtDjjg.TabIndex = 50;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 51;
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
            this.txtDbr.TabIndex = 52;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 53;
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
            this.datDjsj.TabIndex = 54;
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
            this.lblFj.TabIndex = 55;
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
            this.txtFj.TabIndex = 56;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 57;
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
            this.cmbQszt.TabIndex =  58;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQllx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbQllx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjlx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjlx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDjyy, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDjyy, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFbf, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFbf, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSyqmj, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblSyqmj, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblLdsyqssj, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.datLdsyqssj, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblLdsyjssj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.datLdsyjssj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLdsyqxz, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLdsyqxz, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSllmsyqr1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSllmsyqr1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSllmsyqr2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSllmsyqr2, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZysz, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZysz, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZs, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.intZs, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLz, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbLz, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQy, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbQy, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZlnd, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.intZlnd, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblLb, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtLb, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblXb, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtXb, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXdm, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXdm, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 8);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
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
            this.tableLayoutPanel1.TabIndex = 59; 
            //
            // ucLq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucLq";
            this.Size = new System.Drawing.Size(750, 366);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyqmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datLdsyqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datLdsyjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLdsyqxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSllmsyqr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSllmsyqr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZysz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZlnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQllx;	
        private System.Windows.Forms.Label lblQllx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjlx;	
        private System.Windows.Forms.Label lblDjlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjyy;	
        private System.Windows.Forms.Label lblDjyy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFbf;	
        private System.Windows.Forms.Label lblFbf;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSyqmj;	
        private System.Windows.Forms.Label lblSyqmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datLdsyqssj;	
        private System.Windows.Forms.Label lblLdsyqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datLdsyjssj;	
        private System.Windows.Forms.Label lblLdsyjssj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLdsyqxz;	
        private System.Windows.Forms.Label lblLdsyqxz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSllmsyqr1;	
        private System.Windows.Forms.Label lblSllmsyqr1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSllmsyqr2;	
        private System.Windows.Forms.Label lblSllmsyqr2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZysz;	
        private System.Windows.Forms.Label lblZysz;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZs;	
        private System.Windows.Forms.Label lblZs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLz;	
        private System.Windows.Forms.Label lblLz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQy;	
        private System.Windows.Forms.Label lblQy;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZlnd;	
        private System.Windows.Forms.Label lblZlnd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLb;	
        private System.Windows.Forms.Label lblLb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXb;	
        private System.Windows.Forms.Label lblXb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXdm;	
        private System.Windows.Forms.Label lblXdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcqzh;	
        private System.Windows.Forms.Label lblBdcqzh;
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