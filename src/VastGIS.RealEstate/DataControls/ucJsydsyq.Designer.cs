using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJsydsyq
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
            this.lblZddm = new System.Windows.Forms.Label();
            this.txtZddm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            this.lblSyqmj = new System.Windows.Forms.Label();
            this.dblSyqmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSyqqssj = new System.Windows.Forms.Label();
            this.datSyqqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblSyqjssj = new System.Windows.Forms.Label();
            this.datSyqjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblQdjg = new System.Windows.Forms.Label();
            this.dblQdjg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyqmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSyqqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSyqjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQdjg)).BeginInit();
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
            this.lblZddm.AutoSize = true;
            this.lblZddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZddm.Location = new System.Drawing.Point(0,0);
            this.lblZddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZddm.Name = "lblZddm";
            this.lblZddm.Size = new System.Drawing.Size(41, 20);
            this.lblZddm.TabIndex = 5;
            this.lblZddm.Text = "宗地代码";
            // 
            // txtZddm
            // 
            this.txtZddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZddm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZddm.EnableTouchMode = true;
            this.txtZddm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZddm.Location =  new System.Drawing.Point(0,0);
            this.txtZddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZddm.Name = "txtZddm";
            this.txtZddm.Size = new System.Drawing.Size(152, 28);
            this.txtZddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZddm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdyh.TabIndex = 7;
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
            this.txtBdcdyh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 9;
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
            this.txtYwh.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblQllx.AutoSize = true;
            this.lblQllx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQllx.Location = new System.Drawing.Point(0,0);
            this.lblQllx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQllx.Name = "lblQllx";
            this.lblQllx.Size = new System.Drawing.Size(41, 20);
            this.lblQllx.TabIndex = 11;
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
            this.cmbQllx.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblDjlx.AutoSize = true;
            this.lblDjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjlx.Location = new System.Drawing.Point(0,0);
            this.lblDjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjlx.Name = "lblDjlx";
            this.lblDjlx.Size = new System.Drawing.Size(41, 20);
            this.lblDjlx.TabIndex = 13;
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
            this.cmbDjlx.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblDjyy.AutoSize = true;
            this.lblDjyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjyy.Location = new System.Drawing.Point(0,0);
            this.lblDjyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjyy.Name = "lblDjyy";
            this.lblDjyy.Size = new System.Drawing.Size(41, 20);
            this.lblDjyy.TabIndex = 15;
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
            this.txtDjyy.TabIndex = 16;
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
            this.lblSyqmj.Text = "使用权面积";
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
            this.lblSyqqssj.AutoSize = true;
            this.lblSyqqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyqqssj.Location = new System.Drawing.Point(0,0);
            this.lblSyqqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyqqssj.Name = "lblSyqqssj";
            this.lblSyqqssj.Size = new System.Drawing.Size(41, 20);
            this.lblSyqqssj.TabIndex = 19;
            this.lblSyqqssj.Text = "使用权起始时间";
            // 
            // datSyqqssj
            // 
            this.datSyqqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSyqqssj.BorderColor = System.Drawing.Color.Empty;
            this.datSyqqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSyqqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSyqqssj.DropDownImage = null;
            this.datSyqqssj.EnableTouchMode = true;
            this.datSyqqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSyqqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSyqqssj.Location =  new System.Drawing.Point(0,0);
            this.datSyqqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSyqqssj.MinValue = new System.DateTime(((long)(0)));
            this.datSyqqssj.Name = "datSyqqssj";
            this.datSyqqssj.Size = new System.Drawing.Size(152, 20);
            this.datSyqqssj.TabIndex = 20;
            this.datSyqqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSyqqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblSyqjssj.AutoSize = true;
            this.lblSyqjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyqjssj.Location = new System.Drawing.Point(0,0);
            this.lblSyqjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyqjssj.Name = "lblSyqjssj";
            this.lblSyqjssj.Size = new System.Drawing.Size(41, 20);
            this.lblSyqjssj.TabIndex = 21;
            this.lblSyqjssj.Text = "使用权结束时间";
            // 
            // datSyqjssj
            // 
            this.datSyqjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSyqjssj.BorderColor = System.Drawing.Color.Empty;
            this.datSyqjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSyqjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSyqjssj.DropDownImage = null;
            this.datSyqjssj.EnableTouchMode = true;
            this.datSyqjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSyqjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSyqjssj.Location =  new System.Drawing.Point(0,0);
            this.datSyqjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSyqjssj.MinValue = new System.DateTime(((long)(0)));
            this.datSyqjssj.Name = "datSyqjssj";
            this.datSyqjssj.Size = new System.Drawing.Size(152, 20);
            this.datSyqjssj.TabIndex = 22;
            this.datSyqjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSyqjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblQdjg.AutoSize = true;
            this.lblQdjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQdjg.Location = new System.Drawing.Point(0,0);
            this.lblQdjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQdjg.Name = "lblQdjg";
            this.lblQdjg.Size = new System.Drawing.Size(41, 20);
            this.lblQdjg.TabIndex = 23;
            this.lblQdjg.Text = "取得价格";
            // 
            // dblQdjg
            // 
            this.dblQdjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblQdjg.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblQdjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblQdjg.DoubleValue = 1D;
            this.dblQdjg.EnableTouchMode = true;
            this.dblQdjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblQdjg.Location =  new System.Drawing.Point(0,0);
            this.dblQdjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblQdjg.Name = "dblQdjg";
            this.dblQdjg.NullString = "";
            this.dblQdjg.Size = new System.Drawing.Size(152, 28);
            this.dblQdjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblQdjg.TabIndex = 24;
            this.dblQdjg.Text = "1.00";
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 25;
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
            this.txtBdcqzh.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 27;
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
            this.cmbQxdm.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 29;
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
            this.txtDjjg.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 31;
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
            this.txtDbr.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 33;
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
            this.datDjsj.TabIndex = 34;
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
            this.lblFj.TabIndex = 35;
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
            this.txtFj.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 37;
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
            this.cmbQszt.TabIndex =  38;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblZddm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZddm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQllx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbQllx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDjlx, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjlx, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDjyy, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDjyy, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSyqmj, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblSyqmj, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSyqqssj, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.datSyqqssj, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblSyqjssj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.datSyqjssj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQdjg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblQdjg, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 4, 8);
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
            this.tableLayoutPanel1.TabIndex = 39; 
            //
            // ucJsydsyq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucJsydsyq";
            this.Size = new System.Drawing.Size(500, 366);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyqmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSyqqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSyqjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQdjg)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZddm;	
        private System.Windows.Forms.Label lblZddm;
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
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSyqmj;	
        private System.Windows.Forms.Label lblSyqmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSyqqssj;	
        private System.Windows.Forms.Label lblSyqqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSyqjssj;	
        private System.Windows.Forms.Label lblSyqjssj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblQdjg;	
        private System.Windows.Forms.Label lblQdjg;
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