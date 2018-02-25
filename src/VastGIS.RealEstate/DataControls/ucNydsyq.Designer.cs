using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucNydsyq
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
            this.lblZl = new System.Windows.Forms.Label();
            this.txtZl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFbfdm = new System.Windows.Forms.Label();
            this.txtFbfdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFbfmc = new System.Windows.Forms.Label();
            this.txtFbfmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCbmj = new System.Windows.Forms.Label();
            this.dblCbmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCbqssj = new System.Windows.Forms.Label();
            this.datCbqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblCbjssj = new System.Windows.Forms.Label();
            this.datCbjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblTdsyqxz = new System.Windows.Forms.Label();
            this.cmbTdsyqxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSyttlx = new System.Windows.Forms.Label();
            this.cmbSyttlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYzyfs = new System.Windows.Forms.Label();
            this.cmbYzyfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblCyzl = new System.Windows.Forms.Label();
            this.txtCyzl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSyzcl = new System.Windows.Forms.Label();
            this.intSyzcl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbfdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbfmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCbmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCbqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCbjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTdsyqxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSyttlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYzyfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCyzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSyzcl)).BeginInit();
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
            this.lblZl.AutoSize = true;
            this.lblZl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZl.Location = new System.Drawing.Point(0,0);
            this.lblZl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZl.Name = "lblZl";
            this.lblZl.Size = new System.Drawing.Size(41, 20);
            this.lblZl.TabIndex = 15;
            this.lblZl.Text = "坐落";
            // 
            // txtZl
            // 
            this.txtZl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZl.EnableTouchMode = true;
            this.txtZl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZl.Location =  new System.Drawing.Point(0,0);
            this.txtZl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZl.Name = "txtZl";
            this.txtZl.Size = new System.Drawing.Size(152, 28);
            this.txtZl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZl.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblFbfdm.AutoSize = true;
            this.lblFbfdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFbfdm.Location = new System.Drawing.Point(0,0);
            this.lblFbfdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFbfdm.Name = "lblFbfdm";
            this.lblFbfdm.Size = new System.Drawing.Size(41, 20);
            this.lblFbfdm.TabIndex = 17;
            this.lblFbfdm.Text = "发包方代码";
            // 
            // txtFbfdm
            // 
            this.txtFbfdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFbfdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFbfdm.EnableTouchMode = true;
            this.txtFbfdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFbfdm.Location =  new System.Drawing.Point(0,0);
            this.txtFbfdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFbfdm.Name = "txtFbfdm";
            this.txtFbfdm.Size = new System.Drawing.Size(152, 28);
            this.txtFbfdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFbfdm.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblFbfmc.AutoSize = true;
            this.lblFbfmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFbfmc.Location = new System.Drawing.Point(0,0);
            this.lblFbfmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFbfmc.Name = "lblFbfmc";
            this.lblFbfmc.Size = new System.Drawing.Size(41, 20);
            this.lblFbfmc.TabIndex = 19;
            this.lblFbfmc.Text = "发包方名称";
            // 
            // txtFbfmc
            // 
            this.txtFbfmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFbfmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFbfmc.EnableTouchMode = true;
            this.txtFbfmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFbfmc.Location =  new System.Drawing.Point(0,0);
            this.txtFbfmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFbfmc.Name = "txtFbfmc";
            this.txtFbfmc.Size = new System.Drawing.Size(152, 28);
            this.txtFbfmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFbfmc.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblCbmj.AutoSize = true;
            this.lblCbmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCbmj.Location = new System.Drawing.Point(0,0);
            this.lblCbmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCbmj.Name = "lblCbmj";
            this.lblCbmj.Size = new System.Drawing.Size(41, 20);
            this.lblCbmj.TabIndex = 21;
            this.lblCbmj.Text = "承包（使用权）面积";
            // 
            // dblCbmj
            // 
            this.dblCbmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCbmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCbmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCbmj.DoubleValue = 1D;
            this.dblCbmj.EnableTouchMode = true;
            this.dblCbmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCbmj.Location =  new System.Drawing.Point(0,0);
            this.dblCbmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCbmj.Name = "dblCbmj";
            this.dblCbmj.NullString = "";
            this.dblCbmj.Size = new System.Drawing.Size(152, 28);
            this.dblCbmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCbmj.TabIndex = 22;
            this.dblCbmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblCbqssj.AutoSize = true;
            this.lblCbqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCbqssj.Location = new System.Drawing.Point(0,0);
            this.lblCbqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCbqssj.Name = "lblCbqssj";
            this.lblCbqssj.Size = new System.Drawing.Size(41, 20);
            this.lblCbqssj.TabIndex = 23;
            this.lblCbqssj.Text = "承包(使用)起始时间";
            // 
            // datCbqssj
            // 
            this.datCbqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datCbqssj.BorderColor = System.Drawing.Color.Empty;
            this.datCbqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datCbqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datCbqssj.DropDownImage = null;
            this.datCbqssj.EnableTouchMode = true;
            this.datCbqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datCbqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datCbqssj.Location =  new System.Drawing.Point(0,0);
            this.datCbqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datCbqssj.MinValue = new System.DateTime(((long)(0)));
            this.datCbqssj.Name = "datCbqssj";
            this.datCbqssj.Size = new System.Drawing.Size(152, 20);
            this.datCbqssj.TabIndex = 24;
            this.datCbqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datCbqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblCbjssj.AutoSize = true;
            this.lblCbjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCbjssj.Location = new System.Drawing.Point(0,0);
            this.lblCbjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCbjssj.Name = "lblCbjssj";
            this.lblCbjssj.Size = new System.Drawing.Size(41, 20);
            this.lblCbjssj.TabIndex = 25;
            this.lblCbjssj.Text = "承包(使用)结束时间";
            // 
            // datCbjssj
            // 
            this.datCbjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datCbjssj.BorderColor = System.Drawing.Color.Empty;
            this.datCbjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datCbjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datCbjssj.DropDownImage = null;
            this.datCbjssj.EnableTouchMode = true;
            this.datCbjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datCbjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datCbjssj.Location =  new System.Drawing.Point(0,0);
            this.datCbjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datCbjssj.MinValue = new System.DateTime(((long)(0)));
            this.datCbjssj.Name = "datCbjssj";
            this.datCbjssj.Size = new System.Drawing.Size(152, 20);
            this.datCbjssj.TabIndex = 26;
            this.datCbjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datCbjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblTdsyqxz.AutoSize = true;
            this.lblTdsyqxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdsyqxz.Location = new System.Drawing.Point(0,0);
            this.lblTdsyqxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdsyqxz.Name = "lblTdsyqxz";
            this.lblTdsyqxz.Size = new System.Drawing.Size(41, 20);
            this.lblTdsyqxz.TabIndex = 27;
            this.lblTdsyqxz.Text = "土地所有权性质";
            // 
            // cmbTdsyqxz
            // 
            this.cmbTdsyqxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTdsyqxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbTdsyqxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTdsyqxz.EnableTouchMode = true;
            this.cmbTdsyqxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTdsyqxz.Location =  new System.Drawing.Point(0,0);
            this.cmbTdsyqxz.Name = "cmbTdsyqxz";
            this.cmbTdsyqxz.Size = new System.Drawing.Size(152, 20);
            this.cmbTdsyqxz.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblSyttlx.AutoSize = true;
            this.lblSyttlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyttlx.Location = new System.Drawing.Point(0,0);
            this.lblSyttlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyttlx.Name = "lblSyttlx";
            this.lblSyttlx.Size = new System.Drawing.Size(41, 20);
            this.lblSyttlx.TabIndex = 29;
            this.lblSyttlx.Text = "水域滩涂类型";
            // 
            // cmbSyttlx
            // 
            this.cmbSyttlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSyttlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSyttlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSyttlx.EnableTouchMode = true;
            this.cmbSyttlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSyttlx.Location =  new System.Drawing.Point(0,0);
            this.cmbSyttlx.Name = "cmbSyttlx";
            this.cmbSyttlx.Size = new System.Drawing.Size(152, 20);
            this.cmbSyttlx.TabIndex =  30;            
            // 
            // lblID
            // 
            this.lblYzyfs.AutoSize = true;
            this.lblYzyfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYzyfs.Location = new System.Drawing.Point(0,0);
            this.lblYzyfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYzyfs.Name = "lblYzyfs";
            this.lblYzyfs.Size = new System.Drawing.Size(41, 20);
            this.lblYzyfs.TabIndex = 31;
            this.lblYzyfs.Text = "养殖业方式";
            // 
            // cmbYzyfs
            // 
            this.cmbYzyfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYzyfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYzyfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYzyfs.EnableTouchMode = true;
            this.cmbYzyfs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYzyfs.Location =  new System.Drawing.Point(0,0);
            this.cmbYzyfs.Name = "cmbYzyfs";
            this.cmbYzyfs.Size = new System.Drawing.Size(152, 20);
            this.cmbYzyfs.TabIndex =  32;            
            // 
            // lblID
            // 
            this.lblCyzl.AutoSize = true;
            this.lblCyzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCyzl.Location = new System.Drawing.Point(0,0);
            this.lblCyzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCyzl.Name = "lblCyzl";
            this.lblCyzl.Size = new System.Drawing.Size(41, 20);
            this.lblCyzl.TabIndex = 33;
            this.lblCyzl.Text = "草原质量";
            // 
            // txtCyzl
            // 
            this.txtCyzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCyzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCyzl.EnableTouchMode = true;
            this.txtCyzl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCyzl.Location =  new System.Drawing.Point(0,0);
            this.txtCyzl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCyzl.Name = "txtCyzl";
            this.txtCyzl.Size = new System.Drawing.Size(152, 28);
            this.txtCyzl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCyzl.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblSyzcl.AutoSize = true;
            this.lblSyzcl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyzcl.Location = new System.Drawing.Point(0,0);
            this.lblSyzcl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyzcl.Name = "lblSyzcl";
            this.lblSyzcl.Size = new System.Drawing.Size(41, 20);
            this.lblSyzcl.TabIndex = 35;
            this.lblSyzcl.Text = "适宜载畜量";
            // 
            // intSyzcl
            // 
            this.intSyzcl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSyzcl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSyzcl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSyzcl.EnableTouchMode = true;
            this.intSyzcl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSyzcl.IntegerValue = ((long)(0));
            this.intSyzcl.Location = new System.Drawing.Point(0,0);
            this.intSyzcl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSyzcl.Name = "intSyzcl";
            this.intSyzcl.NullString = "";
            this.intSyzcl.Size = new System.Drawing.Size(152, 28);
            this.intSyzcl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSyzcl.TabIndex = 36;
            this.intSyzcl.Text = "0";
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 37;
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
            this.txtBdcqzh.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 39;
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
            this.cmbQxdm.TabIndex =  40;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 41;
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
            this.txtDjjg.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 43;
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
            this.txtDbr.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 45;
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
            this.datDjsj.TabIndex = 46;
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
            this.lblFj.TabIndex = 47;
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
            this.txtFj.TabIndex = 48;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 49;
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
            this.cmbQszt.TabIndex =  50;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblZl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtZl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFbfdm, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtFbfdm, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblFbfmc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFbfmc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCbmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblCbmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCbqssj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.datCbqssj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCbjssj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datCbjssj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTdsyqxz, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbTdsyqxz, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSyttlx, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSyttlx, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYzyfs, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbYzyfs, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCyzl, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCyzl, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSyzcl, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.intSyzcl, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 6);
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
            this.tableLayoutPanel1.TabIndex = 51; 
            //
            // ucNydsyq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucNydsyq";
            this.Size = new System.Drawing.Size(750, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbfdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbfmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCbmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCbqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCbjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTdsyqxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSyttlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYzyfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCyzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSyzcl)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZl;	
        private System.Windows.Forms.Label lblZl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFbfdm;	
        private System.Windows.Forms.Label lblFbfdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFbfmc;	
        private System.Windows.Forms.Label lblFbfmc;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCbmj;	
        private System.Windows.Forms.Label lblCbmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datCbqssj;	
        private System.Windows.Forms.Label lblCbqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datCbjssj;	
        private System.Windows.Forms.Label lblCbjssj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbTdsyqxz;	
        private System.Windows.Forms.Label lblTdsyqxz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSyttlx;	
        private System.Windows.Forms.Label lblSyttlx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYzyfs;	
        private System.Windows.Forms.Label lblYzyfs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCyzl;	
        private System.Windows.Forms.Label lblCyzl;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSyzcl;	
        private System.Windows.Forms.Label lblSyzcl;
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