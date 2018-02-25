using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFdcq1
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
            this.lblFdzl = new System.Windows.Forms.Label();
            this.txtFdzl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTdsyqr = new System.Windows.Forms.Label();
            this.txtTdsyqr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDytdmj = new System.Windows.Forms.Label();
            this.dblDytdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFttdmj = new System.Windows.Forms.Label();
            this.dblFttdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblTdsyqssj = new System.Windows.Forms.Label();
            this.datTdsyqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblTdsyjssj = new System.Windows.Forms.Label();
            this.datTdsyjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFdcjyjg = new System.Windows.Forms.Label();
            this.dblFdcjyjg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
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
            this.lblFcfht = new System.Windows.Forms.Label();
            this.txtFcfht = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtFdzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTdsyqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDytdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdsyqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdsyjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFdcjyjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFcfht)).BeginInit();
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
            this.lblFdzl.AutoSize = true;
            this.lblFdzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFdzl.Location = new System.Drawing.Point(0,0);
            this.lblFdzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFdzl.Name = "lblFdzl";
            this.lblFdzl.Size = new System.Drawing.Size(41, 20);
            this.lblFdzl.TabIndex = 15;
            this.lblFdzl.Text = "房地坐落";
            // 
            // txtFdzl
            // 
            this.txtFdzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFdzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFdzl.EnableTouchMode = true;
            this.txtFdzl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFdzl.Location =  new System.Drawing.Point(0,0);
            this.txtFdzl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFdzl.Name = "txtFdzl";
            this.txtFdzl.Size = new System.Drawing.Size(152, 28);
            this.txtFdzl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFdzl.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblTdsyqr.AutoSize = true;
            this.lblTdsyqr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdsyqr.Location = new System.Drawing.Point(0,0);
            this.lblTdsyqr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdsyqr.Name = "lblTdsyqr";
            this.lblTdsyqr.Size = new System.Drawing.Size(41, 20);
            this.lblTdsyqr.TabIndex = 17;
            this.lblTdsyqr.Text = "土地使用权人";
            // 
            // txtTdsyqr
            // 
            this.txtTdsyqr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTdsyqr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTdsyqr.EnableTouchMode = true;
            this.txtTdsyqr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTdsyqr.Location =  new System.Drawing.Point(0,0);
            this.txtTdsyqr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTdsyqr.Name = "txtTdsyqr";
            this.txtTdsyqr.Size = new System.Drawing.Size(152, 28);
            this.txtTdsyqr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTdsyqr.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblDytdmj.AutoSize = true;
            this.lblDytdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDytdmj.Location = new System.Drawing.Point(0,0);
            this.lblDytdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDytdmj.Name = "lblDytdmj";
            this.lblDytdmj.Size = new System.Drawing.Size(41, 20);
            this.lblDytdmj.TabIndex = 19;
            this.lblDytdmj.Text = "独用土地面积";
            // 
            // dblDytdmj
            // 
            this.dblDytdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblDytdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDytdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblDytdmj.DoubleValue = 1D;
            this.dblDytdmj.EnableTouchMode = true;
            this.dblDytdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDytdmj.Location =  new System.Drawing.Point(0,0);
            this.dblDytdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDytdmj.Name = "dblDytdmj";
            this.dblDytdmj.NullString = "";
            this.dblDytdmj.Size = new System.Drawing.Size(152, 28);
            this.dblDytdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDytdmj.TabIndex = 20;
            this.dblDytdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblFttdmj.AutoSize = true;
            this.lblFttdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFttdmj.Location = new System.Drawing.Point(0,0);
            this.lblFttdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFttdmj.Name = "lblFttdmj";
            this.lblFttdmj.Size = new System.Drawing.Size(41, 20);
            this.lblFttdmj.TabIndex = 21;
            this.lblFttdmj.Text = "分摊土地面积";
            // 
            // dblFttdmj
            // 
            this.dblFttdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblFttdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFttdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblFttdmj.DoubleValue = 1D;
            this.dblFttdmj.EnableTouchMode = true;
            this.dblFttdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblFttdmj.Location =  new System.Drawing.Point(0,0);
            this.dblFttdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFttdmj.Name = "dblFttdmj";
            this.dblFttdmj.NullString = "";
            this.dblFttdmj.Size = new System.Drawing.Size(152, 28);
            this.dblFttdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFttdmj.TabIndex = 22;
            this.dblFttdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblTdsyqssj.AutoSize = true;
            this.lblTdsyqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdsyqssj.Location = new System.Drawing.Point(0,0);
            this.lblTdsyqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdsyqssj.Name = "lblTdsyqssj";
            this.lblTdsyqssj.Size = new System.Drawing.Size(41, 20);
            this.lblTdsyqssj.TabIndex = 23;
            this.lblTdsyqssj.Text = "土地使用起始时间";
            // 
            // datTdsyqssj
            // 
            this.datTdsyqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datTdsyqssj.BorderColor = System.Drawing.Color.Empty;
            this.datTdsyqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datTdsyqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datTdsyqssj.DropDownImage = null;
            this.datTdsyqssj.EnableTouchMode = true;
            this.datTdsyqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datTdsyqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTdsyqssj.Location =  new System.Drawing.Point(0,0);
            this.datTdsyqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datTdsyqssj.MinValue = new System.DateTime(((long)(0)));
            this.datTdsyqssj.Name = "datTdsyqssj";
            this.datTdsyqssj.Size = new System.Drawing.Size(152, 20);
            this.datTdsyqssj.TabIndex = 24;
            this.datTdsyqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datTdsyqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblTdsyjssj.AutoSize = true;
            this.lblTdsyjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdsyjssj.Location = new System.Drawing.Point(0,0);
            this.lblTdsyjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdsyjssj.Name = "lblTdsyjssj";
            this.lblTdsyjssj.Size = new System.Drawing.Size(41, 20);
            this.lblTdsyjssj.TabIndex = 25;
            this.lblTdsyjssj.Text = "土地使用结束时间";
            // 
            // datTdsyjssj
            // 
            this.datTdsyjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datTdsyjssj.BorderColor = System.Drawing.Color.Empty;
            this.datTdsyjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datTdsyjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datTdsyjssj.DropDownImage = null;
            this.datTdsyjssj.EnableTouchMode = true;
            this.datTdsyjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datTdsyjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTdsyjssj.Location =  new System.Drawing.Point(0,0);
            this.datTdsyjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datTdsyjssj.MinValue = new System.DateTime(((long)(0)));
            this.datTdsyjssj.Name = "datTdsyjssj";
            this.datTdsyjssj.Size = new System.Drawing.Size(152, 20);
            this.datTdsyjssj.TabIndex = 26;
            this.datTdsyjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datTdsyjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFdcjyjg.AutoSize = true;
            this.lblFdcjyjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFdcjyjg.Location = new System.Drawing.Point(0,0);
            this.lblFdcjyjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFdcjyjg.Name = "lblFdcjyjg";
            this.lblFdcjyjg.Size = new System.Drawing.Size(41, 20);
            this.lblFdcjyjg.TabIndex = 27;
            this.lblFdcjyjg.Text = "房地产交易价格";
            // 
            // dblFdcjyjg
            // 
            this.dblFdcjyjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblFdcjyjg.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFdcjyjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblFdcjyjg.DoubleValue = 1D;
            this.dblFdcjyjg.EnableTouchMode = true;
            this.dblFdcjyjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblFdcjyjg.Location =  new System.Drawing.Point(0,0);
            this.dblFdcjyjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFdcjyjg.Name = "dblFdcjyjg";
            this.dblFdcjyjg.NullString = "";
            this.dblFdcjyjg.Size = new System.Drawing.Size(152, 28);
            this.dblFdcjyjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFdcjyjg.TabIndex = 28;
            this.dblFdcjyjg.Text = "1.00";
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 29;
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
            this.txtBdcqzh.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 31;
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
            this.cmbQxdm.TabIndex =  32;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 33;
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
            this.txtDjjg.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 35;
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
            this.txtDbr.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 37;
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
            this.datDjsj.TabIndex = 38;
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
            this.lblFj.TabIndex = 39;
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
            this.txtFj.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblFcfht.AutoSize = true;
            this.lblFcfht.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFcfht.Location = new System.Drawing.Point(0,0);
            this.lblFcfht.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFcfht.Name = "lblFcfht";
            this.lblFcfht.Size = new System.Drawing.Size(41, 20);
            this.lblFcfht.TabIndex = 41;
            this.lblFcfht.Text = "房产分户图";
            // 
            // txtFcfht
            // 
            this.txtFcfht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFcfht.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFcfht.EnableTouchMode = true;
            this.txtFcfht.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFcfht.Location =  new System.Drawing.Point(0,0);
            this.txtFcfht.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFcfht.Name = "txtFcfht";
            this.txtFcfht.Size = new System.Drawing.Size(152, 28);
            this.txtFcfht.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFcfht.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 43;
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
            this.cmbQszt.TabIndex =  44;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblFdzl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFdzl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblTdsyqr, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTdsyqr, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDytdmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblDytdmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFttdmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblFttdmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTdsyqssj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datTdsyqssj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTdsyjssj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.datTdsyjssj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFdcjyjg, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblFdcjyjg, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFcfht, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFcfht, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 5);
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
            this.tableLayoutPanel1.TabIndex = 45; 
            //
            // ucFdcq1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFdcq1";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFdzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTdsyqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDytdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdsyqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdsyjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFdcjyjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFcfht)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFdzl;	
        private System.Windows.Forms.Label lblFdzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTdsyqr;	
        private System.Windows.Forms.Label lblTdsyqr;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDytdmj;	
        private System.Windows.Forms.Label lblDytdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFttdmj;	
        private System.Windows.Forms.Label lblFttdmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datTdsyqssj;	
        private System.Windows.Forms.Label lblTdsyqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datTdsyjssj;	
        private System.Windows.Forms.Label lblTdsyjssj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFdcjyjg;	
        private System.Windows.Forms.Label lblFdcjyjg;
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFcfht;	
        private System.Windows.Forms.Label lblFcfht;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}