using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucGjzwsyq
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
            this.lblTdhysyqr = new System.Windows.Forms.Label();
            this.txtTdhysyqr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTdhysymj = new System.Windows.Forms.Label();
            this.dblTdhysymj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblTdhysyqssj = new System.Windows.Forms.Label();
            this.datTdhysyqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblTdhysyjssj = new System.Windows.Forms.Label();
            this.datTdhysyjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblGjzwlx = new System.Windows.Forms.Label();
            this.cmbGjzwlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblGjzwghyt = new System.Windows.Forms.Label();
            this.txtGjzwghyt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGjzwmj = new System.Windows.Forms.Label();
            this.dblGjzwmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJgsj = new System.Windows.Forms.Label();
            this.datJgsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
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
            this.lblGjzwpmt = new System.Windows.Forms.Label();
            this.txtGjzwpmt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtTdhysyqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblTdhysymj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdhysyqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdhysyjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGjzwlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGjzwghyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGjzwmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGjzwpmt)).BeginInit();
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
            this.lblTdhysyqr.AutoSize = true;
            this.lblTdhysyqr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdhysyqr.Location = new System.Drawing.Point(0,0);
            this.lblTdhysyqr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdhysyqr.Name = "lblTdhysyqr";
            this.lblTdhysyqr.Size = new System.Drawing.Size(41, 20);
            this.lblTdhysyqr.TabIndex = 17;
            this.lblTdhysyqr.Text = "土地/海域使用权人";
            // 
            // txtTdhysyqr
            // 
            this.txtTdhysyqr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTdhysyqr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTdhysyqr.EnableTouchMode = true;
            this.txtTdhysyqr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTdhysyqr.Location =  new System.Drawing.Point(0,0);
            this.txtTdhysyqr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTdhysyqr.Name = "txtTdhysyqr";
            this.txtTdhysyqr.Size = new System.Drawing.Size(152, 28);
            this.txtTdhysyqr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTdhysyqr.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblTdhysymj.AutoSize = true;
            this.lblTdhysymj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdhysymj.Location = new System.Drawing.Point(0,0);
            this.lblTdhysymj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdhysymj.Name = "lblTdhysymj";
            this.lblTdhysymj.Size = new System.Drawing.Size(41, 20);
            this.lblTdhysymj.TabIndex = 19;
            this.lblTdhysymj.Text = "土地/海域使用面积";
            // 
            // dblTdhysymj
            // 
            this.dblTdhysymj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblTdhysymj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblTdhysymj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblTdhysymj.DoubleValue = 1D;
            this.dblTdhysymj.EnableTouchMode = true;
            this.dblTdhysymj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblTdhysymj.Location =  new System.Drawing.Point(0,0);
            this.dblTdhysymj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblTdhysymj.Name = "dblTdhysymj";
            this.dblTdhysymj.NullString = "";
            this.dblTdhysymj.Size = new System.Drawing.Size(152, 28);
            this.dblTdhysymj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblTdhysymj.TabIndex = 20;
            this.dblTdhysymj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblTdhysyqssj.AutoSize = true;
            this.lblTdhysyqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdhysyqssj.Location = new System.Drawing.Point(0,0);
            this.lblTdhysyqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdhysyqssj.Name = "lblTdhysyqssj";
            this.lblTdhysyqssj.Size = new System.Drawing.Size(41, 20);
            this.lblTdhysyqssj.TabIndex = 21;
            this.lblTdhysyqssj.Text = "土地/海域使用起始时间";
            // 
            // datTdhysyqssj
            // 
            this.datTdhysyqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datTdhysyqssj.BorderColor = System.Drawing.Color.Empty;
            this.datTdhysyqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datTdhysyqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datTdhysyqssj.DropDownImage = null;
            this.datTdhysyqssj.EnableTouchMode = true;
            this.datTdhysyqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datTdhysyqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTdhysyqssj.Location =  new System.Drawing.Point(0,0);
            this.datTdhysyqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datTdhysyqssj.MinValue = new System.DateTime(((long)(0)));
            this.datTdhysyqssj.Name = "datTdhysyqssj";
            this.datTdhysyqssj.Size = new System.Drawing.Size(152, 20);
            this.datTdhysyqssj.TabIndex = 22;
            this.datTdhysyqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datTdhysyqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblTdhysyjssj.AutoSize = true;
            this.lblTdhysyjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdhysyjssj.Location = new System.Drawing.Point(0,0);
            this.lblTdhysyjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdhysyjssj.Name = "lblTdhysyjssj";
            this.lblTdhysyjssj.Size = new System.Drawing.Size(41, 20);
            this.lblTdhysyjssj.TabIndex = 23;
            this.lblTdhysyjssj.Text = "土地/海域使用结束时间";
            // 
            // datTdhysyjssj
            // 
            this.datTdhysyjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datTdhysyjssj.BorderColor = System.Drawing.Color.Empty;
            this.datTdhysyjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datTdhysyjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datTdhysyjssj.DropDownImage = null;
            this.datTdhysyjssj.EnableTouchMode = true;
            this.datTdhysyjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datTdhysyjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTdhysyjssj.Location =  new System.Drawing.Point(0,0);
            this.datTdhysyjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datTdhysyjssj.MinValue = new System.DateTime(((long)(0)));
            this.datTdhysyjssj.Name = "datTdhysyjssj";
            this.datTdhysyjssj.Size = new System.Drawing.Size(152, 20);
            this.datTdhysyjssj.TabIndex = 24;
            this.datTdhysyjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datTdhysyjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblGjzwlx.AutoSize = true;
            this.lblGjzwlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGjzwlx.Location = new System.Drawing.Point(0,0);
            this.lblGjzwlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGjzwlx.Name = "lblGjzwlx";
            this.lblGjzwlx.Size = new System.Drawing.Size(41, 20);
            this.lblGjzwlx.TabIndex = 25;
            this.lblGjzwlx.Text = "构（建）筑物类型";
            // 
            // cmbGjzwlx
            // 
            this.cmbGjzwlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGjzwlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGjzwlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGjzwlx.EnableTouchMode = true;
            this.cmbGjzwlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGjzwlx.Location =  new System.Drawing.Point(0,0);
            this.cmbGjzwlx.Name = "cmbGjzwlx";
            this.cmbGjzwlx.Size = new System.Drawing.Size(152, 20);
            this.cmbGjzwlx.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblGjzwghyt.AutoSize = true;
            this.lblGjzwghyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGjzwghyt.Location = new System.Drawing.Point(0,0);
            this.lblGjzwghyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGjzwghyt.Name = "lblGjzwghyt";
            this.lblGjzwghyt.Size = new System.Drawing.Size(41, 20);
            this.lblGjzwghyt.TabIndex = 27;
            this.lblGjzwghyt.Text = "构（建）筑物规划用途";
            // 
            // txtGjzwghyt
            // 
            this.txtGjzwghyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGjzwghyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGjzwghyt.EnableTouchMode = true;
            this.txtGjzwghyt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGjzwghyt.Location =  new System.Drawing.Point(0,0);
            this.txtGjzwghyt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGjzwghyt.Name = "txtGjzwghyt";
            this.txtGjzwghyt.Size = new System.Drawing.Size(152, 28);
            this.txtGjzwghyt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGjzwghyt.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblGjzwmj.AutoSize = true;
            this.lblGjzwmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGjzwmj.Location = new System.Drawing.Point(0,0);
            this.lblGjzwmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGjzwmj.Name = "lblGjzwmj";
            this.lblGjzwmj.Size = new System.Drawing.Size(41, 20);
            this.lblGjzwmj.TabIndex = 29;
            this.lblGjzwmj.Text = "构(建)筑物面积";
            // 
            // dblGjzwmj
            // 
            this.dblGjzwmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblGjzwmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblGjzwmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblGjzwmj.DoubleValue = 1D;
            this.dblGjzwmj.EnableTouchMode = true;
            this.dblGjzwmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblGjzwmj.Location =  new System.Drawing.Point(0,0);
            this.dblGjzwmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblGjzwmj.Name = "dblGjzwmj";
            this.dblGjzwmj.NullString = "";
            this.dblGjzwmj.Size = new System.Drawing.Size(152, 28);
            this.dblGjzwmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblGjzwmj.TabIndex = 30;
            this.dblGjzwmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJgsj.AutoSize = true;
            this.lblJgsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgsj.Location = new System.Drawing.Point(0,0);
            this.lblJgsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgsj.Name = "lblJgsj";
            this.lblJgsj.Size = new System.Drawing.Size(41, 20);
            this.lblJgsj.TabIndex = 31;
            this.lblJgsj.Text = "竣工时间";
            // 
            // datJgsj
            // 
            this.datJgsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJgsj.BorderColor = System.Drawing.Color.Empty;
            this.datJgsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJgsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJgsj.DropDownImage = null;
            this.datJgsj.EnableTouchMode = true;
            this.datJgsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJgsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJgsj.Location =  new System.Drawing.Point(0,0);
            this.datJgsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJgsj.MinValue = new System.DateTime(((long)(0)));
            this.datJgsj.Name = "datJgsj";
            this.datJgsj.Size = new System.Drawing.Size(152, 20);
            this.datJgsj.TabIndex = 32;
            this.datJgsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJgsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 33;
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
            this.txtBdcqzh.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 35;
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
            this.cmbQxdm.TabIndex =  36;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 37;
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
            this.txtDjjg.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 39;
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
            this.txtDbr.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 41;
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
            this.datDjsj.TabIndex = 42;
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
            this.lblFj.TabIndex = 43;
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
            this.txtFj.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblGjzwpmt.AutoSize = true;
            this.lblGjzwpmt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGjzwpmt.Location = new System.Drawing.Point(0,0);
            this.lblGjzwpmt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGjzwpmt.Name = "lblGjzwpmt";
            this.lblGjzwpmt.Size = new System.Drawing.Size(41, 20);
            this.lblGjzwpmt.TabIndex = 45;
            this.lblGjzwpmt.Text = "构（建）筑物平面图";
            // 
            // txtGjzwpmt
            // 
            this.txtGjzwpmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGjzwpmt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGjzwpmt.EnableTouchMode = true;
            this.txtGjzwpmt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGjzwpmt.Location =  new System.Drawing.Point(0,0);
            this.txtGjzwpmt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGjzwpmt.Name = "txtGjzwpmt";
            this.txtGjzwpmt.Size = new System.Drawing.Size(152, 28);
            this.txtGjzwpmt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGjzwpmt.TabIndex = 46;
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
            this.tableLayoutPanel1.Controls.Add(this.lblTdhysyqr, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTdhysyqr, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTdhysymj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblTdhysymj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTdhysyqssj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.datTdhysyqssj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTdhysyjssj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datTdhysyjssj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGjzwlx, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbGjzwlx, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGjzwghyt, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtGjzwghyt, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGjzwmj, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblGjzwmj, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJgsj, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.datJgsj, 4, 7);
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
            this.tableLayoutPanel1.Controls.Add(this.lblGjzwpmt, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGjzwpmt, 7, 6);
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
            // ucGjzwsyq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucGjzwsyq";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTdhysyqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblTdhysymj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdhysyqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datTdhysyjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGjzwlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGjzwghyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGjzwmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGjzwpmt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTdhysyqr;	
        private System.Windows.Forms.Label lblTdhysyqr;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblTdhysymj;	
        private System.Windows.Forms.Label lblTdhysymj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datTdhysyqssj;	
        private System.Windows.Forms.Label lblTdhysyqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datTdhysyjssj;	
        private System.Windows.Forms.Label lblTdhysyjssj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGjzwlx;	
        private System.Windows.Forms.Label lblGjzwlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGjzwghyt;	
        private System.Windows.Forms.Label lblGjzwghyt;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblGjzwmj;	
        private System.Windows.Forms.Label lblGjzwmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJgsj;	
        private System.Windows.Forms.Label lblJgsj;
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGjzwpmt;	
        private System.Windows.Forms.Label lblGjzwpmt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}