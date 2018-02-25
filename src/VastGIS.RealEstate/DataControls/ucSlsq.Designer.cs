using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSlsq
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
            this.lblDjdl = new System.Windows.Forms.Label();
            this.cmbDjdl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjxl = new System.Windows.Forms.Label();
            this.txtDjxl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSqzsbs = new System.Windows.Forms.Label();
            this.cmbSqzsbs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSqfbcz = new System.Windows.Forms.Label();
            this.cmbSqfbcz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQxdm = new System.Windows.Forms.Label();
            this.cmbQxdm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSlry = new System.Windows.Forms.Label();
            this.txtSlry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSlsj = new System.Windows.Forms.Label();
            this.datSlsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblZl = new System.Windows.Forms.Label();
            this.txtZl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTzrxm = new System.Windows.Forms.Label();
            this.txtTzrxm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTzfs = new System.Windows.Forms.Label();
            this.cmbTzfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblTzrdh = new System.Windows.Forms.Label();
            this.txtTzrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTzryddh = new System.Windows.Forms.Label();
            this.txtTzryddh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTzrdzyj = new System.Windows.Forms.Label();
            this.txtTzrdzyj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfwtaj = new System.Windows.Forms.Label();
            this.cmbSfwtaj = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJssj = new System.Windows.Forms.Label();
            this.datJssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblAjzt = new System.Windows.Forms.Label();
            this.cmbAjzt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjdl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjxl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqzsbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqfbcz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSlsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTzfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzryddh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrdzyj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfwtaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAjzt)).BeginInit();
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
            this.lblDjdl.AutoSize = true;
            this.lblDjdl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjdl.Location = new System.Drawing.Point(0,0);
            this.lblDjdl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjdl.Name = "lblDjdl";
            this.lblDjdl.Size = new System.Drawing.Size(41, 20);
            this.lblDjdl.TabIndex = 7;
            this.lblDjdl.Text = "登记大类";
            // 
            // cmbDjdl
            // 
            this.cmbDjdl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDjdl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDjdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDjdl.EnableTouchMode = true;
            this.cmbDjdl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDjdl.Location =  new System.Drawing.Point(0,0);
            this.cmbDjdl.Name = "cmbDjdl";
            this.cmbDjdl.Size = new System.Drawing.Size(152, 20);
            this.cmbDjdl.TabIndex =  8;            
            // 
            // lblID
            // 
            this.lblDjxl.AutoSize = true;
            this.lblDjxl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjxl.Location = new System.Drawing.Point(0,0);
            this.lblDjxl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjxl.Name = "lblDjxl";
            this.lblDjxl.Size = new System.Drawing.Size(41, 20);
            this.lblDjxl.TabIndex = 9;
            this.lblDjxl.Text = "登记小类";
            // 
            // txtDjxl
            // 
            this.txtDjxl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjxl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjxl.EnableTouchMode = true;
            this.txtDjxl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjxl.Location =  new System.Drawing.Point(0,0);
            this.txtDjxl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjxl.Name = "txtDjxl";
            this.txtDjxl.Size = new System.Drawing.Size(152, 28);
            this.txtDjxl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjxl.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblSqzsbs.AutoSize = true;
            this.lblSqzsbs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSqzsbs.Location = new System.Drawing.Point(0,0);
            this.lblSqzsbs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSqzsbs.Name = "lblSqzsbs";
            this.lblSqzsbs.Size = new System.Drawing.Size(41, 20);
            this.lblSqzsbs.TabIndex = 11;
            this.lblSqzsbs.Text = "申请证书版式";
            // 
            // cmbSqzsbs
            // 
            this.cmbSqzsbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSqzsbs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSqzsbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSqzsbs.EnableTouchMode = true;
            this.cmbSqzsbs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSqzsbs.Location =  new System.Drawing.Point(0,0);
            this.cmbSqzsbs.Name = "cmbSqzsbs";
            this.cmbSqzsbs.Size = new System.Drawing.Size(152, 20);
            this.cmbSqzsbs.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblSqfbcz.AutoSize = true;
            this.lblSqfbcz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSqfbcz.Location = new System.Drawing.Point(0,0);
            this.lblSqfbcz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSqfbcz.Name = "lblSqfbcz";
            this.lblSqfbcz.Size = new System.Drawing.Size(41, 20);
            this.lblSqfbcz.TabIndex = 13;
            this.lblSqfbcz.Text = "申请分别持证";
            // 
            // cmbSqfbcz
            // 
            this.cmbSqfbcz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSqfbcz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSqfbcz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSqfbcz.EnableTouchMode = true;
            this.cmbSqfbcz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSqfbcz.Location =  new System.Drawing.Point(0,0);
            this.cmbSqfbcz.Name = "cmbSqfbcz";
            this.cmbSqfbcz.Size = new System.Drawing.Size(152, 20);
            this.cmbSqfbcz.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 15;
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
            this.cmbQxdm.TabIndex =  16;            
            // 
            // lblID
            // 
            this.lblSlry.AutoSize = true;
            this.lblSlry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSlry.Location = new System.Drawing.Point(0,0);
            this.lblSlry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSlry.Name = "lblSlry";
            this.lblSlry.Size = new System.Drawing.Size(41, 20);
            this.lblSlry.TabIndex = 17;
            this.lblSlry.Text = "受理人员";
            // 
            // txtSlry
            // 
            this.txtSlry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSlry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSlry.EnableTouchMode = true;
            this.txtSlry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSlry.Location =  new System.Drawing.Point(0,0);
            this.txtSlry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSlry.Name = "txtSlry";
            this.txtSlry.Size = new System.Drawing.Size(152, 28);
            this.txtSlry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSlry.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblSlsj.AutoSize = true;
            this.lblSlsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSlsj.Location = new System.Drawing.Point(0,0);
            this.lblSlsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSlsj.Name = "lblSlsj";
            this.lblSlsj.Size = new System.Drawing.Size(41, 20);
            this.lblSlsj.TabIndex = 19;
            this.lblSlsj.Text = "受理时间";
            // 
            // datSlsj
            // 
            this.datSlsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSlsj.BorderColor = System.Drawing.Color.Empty;
            this.datSlsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSlsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSlsj.DropDownImage = null;
            this.datSlsj.EnableTouchMode = true;
            this.datSlsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSlsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSlsj.Location =  new System.Drawing.Point(0,0);
            this.datSlsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSlsj.MinValue = new System.DateTime(((long)(0)));
            this.datSlsj.Name = "datSlsj";
            this.datSlsj.Size = new System.Drawing.Size(152, 20);
            this.datSlsj.TabIndex = 20;
            this.datSlsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSlsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblZl.AutoSize = true;
            this.lblZl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZl.Location = new System.Drawing.Point(0,0);
            this.lblZl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZl.Name = "lblZl";
            this.lblZl.Size = new System.Drawing.Size(41, 20);
            this.lblZl.TabIndex = 21;
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
            this.txtZl.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblTzrxm.AutoSize = true;
            this.lblTzrxm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTzrxm.Location = new System.Drawing.Point(0,0);
            this.lblTzrxm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTzrxm.Name = "lblTzrxm";
            this.lblTzrxm.Size = new System.Drawing.Size(41, 20);
            this.lblTzrxm.TabIndex = 23;
            this.lblTzrxm.Text = "通知人姓名";
            // 
            // txtTzrxm
            // 
            this.txtTzrxm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTzrxm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTzrxm.EnableTouchMode = true;
            this.txtTzrxm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTzrxm.Location =  new System.Drawing.Point(0,0);
            this.txtTzrxm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTzrxm.Name = "txtTzrxm";
            this.txtTzrxm.Size = new System.Drawing.Size(152, 28);
            this.txtTzrxm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTzrxm.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblTzfs.AutoSize = true;
            this.lblTzfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTzfs.Location = new System.Drawing.Point(0,0);
            this.lblTzfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTzfs.Name = "lblTzfs";
            this.lblTzfs.Size = new System.Drawing.Size(41, 20);
            this.lblTzfs.TabIndex = 25;
            this.lblTzfs.Text = "通知方式";
            // 
            // cmbTzfs
            // 
            this.cmbTzfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTzfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbTzfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTzfs.EnableTouchMode = true;
            this.cmbTzfs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTzfs.Location =  new System.Drawing.Point(0,0);
            this.cmbTzfs.Name = "cmbTzfs";
            this.cmbTzfs.Size = new System.Drawing.Size(152, 20);
            this.cmbTzfs.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblTzrdh.AutoSize = true;
            this.lblTzrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTzrdh.Location = new System.Drawing.Point(0,0);
            this.lblTzrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTzrdh.Name = "lblTzrdh";
            this.lblTzrdh.Size = new System.Drawing.Size(41, 20);
            this.lblTzrdh.TabIndex = 27;
            this.lblTzrdh.Text = "通知人电话";
            // 
            // txtTzrdh
            // 
            this.txtTzrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTzrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTzrdh.EnableTouchMode = true;
            this.txtTzrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTzrdh.Location =  new System.Drawing.Point(0,0);
            this.txtTzrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTzrdh.Name = "txtTzrdh";
            this.txtTzrdh.Size = new System.Drawing.Size(152, 28);
            this.txtTzrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTzrdh.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblTzryddh.AutoSize = true;
            this.lblTzryddh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTzryddh.Location = new System.Drawing.Point(0,0);
            this.lblTzryddh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTzryddh.Name = "lblTzryddh";
            this.lblTzryddh.Size = new System.Drawing.Size(41, 20);
            this.lblTzryddh.TabIndex = 29;
            this.lblTzryddh.Text = "通知人移动电话";
            // 
            // txtTzryddh
            // 
            this.txtTzryddh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTzryddh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTzryddh.EnableTouchMode = true;
            this.txtTzryddh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTzryddh.Location =  new System.Drawing.Point(0,0);
            this.txtTzryddh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTzryddh.Name = "txtTzryddh";
            this.txtTzryddh.Size = new System.Drawing.Size(152, 28);
            this.txtTzryddh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTzryddh.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblTzrdzyj.AutoSize = true;
            this.lblTzrdzyj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTzrdzyj.Location = new System.Drawing.Point(0,0);
            this.lblTzrdzyj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTzrdzyj.Name = "lblTzrdzyj";
            this.lblTzrdzyj.Size = new System.Drawing.Size(41, 20);
            this.lblTzrdzyj.TabIndex = 31;
            this.lblTzrdzyj.Text = "通知人电子邮件";
            // 
            // txtTzrdzyj
            // 
            this.txtTzrdzyj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTzrdzyj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTzrdzyj.EnableTouchMode = true;
            this.txtTzrdzyj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTzrdzyj.Location =  new System.Drawing.Point(0,0);
            this.txtTzrdzyj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTzrdzyj.Name = "txtTzrdzyj";
            this.txtTzrdzyj.Size = new System.Drawing.Size(152, 28);
            this.txtTzrdzyj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTzrdzyj.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblSfwtaj.AutoSize = true;
            this.lblSfwtaj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfwtaj.Location = new System.Drawing.Point(0,0);
            this.lblSfwtaj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfwtaj.Name = "lblSfwtaj";
            this.lblSfwtaj.Size = new System.Drawing.Size(41, 20);
            this.lblSfwtaj.TabIndex = 33;
            this.lblSfwtaj.Text = "是否问题案件";
            // 
            // cmbSfwtaj
            // 
            this.cmbSfwtaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfwtaj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfwtaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfwtaj.EnableTouchMode = true;
            this.cmbSfwtaj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfwtaj.Location =  new System.Drawing.Point(0,0);
            this.cmbSfwtaj.Name = "cmbSfwtaj";
            this.cmbSfwtaj.Size = new System.Drawing.Size(152, 20);
            this.cmbSfwtaj.TabIndex =  34;            
            // 
            // lblID
            // 
            this.lblJssj.AutoSize = true;
            this.lblJssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJssj.Location = new System.Drawing.Point(0,0);
            this.lblJssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJssj.Name = "lblJssj";
            this.lblJssj.Size = new System.Drawing.Size(41, 20);
            this.lblJssj.TabIndex = 35;
            this.lblJssj.Text = "结束时间";
            // 
            // datJssj
            // 
            this.datJssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJssj.BorderColor = System.Drawing.Color.Empty;
            this.datJssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJssj.DropDownImage = null;
            this.datJssj.EnableTouchMode = true;
            this.datJssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJssj.Location =  new System.Drawing.Point(0,0);
            this.datJssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJssj.MinValue = new System.DateTime(((long)(0)));
            this.datJssj.Name = "datJssj";
            this.datJssj.Size = new System.Drawing.Size(152, 20);
            this.datJssj.TabIndex = 36;
            this.datJssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblAjzt.AutoSize = true;
            this.lblAjzt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAjzt.Location = new System.Drawing.Point(0,0);
            this.lblAjzt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblAjzt.Name = "lblAjzt";
            this.lblAjzt.Size = new System.Drawing.Size(41, 20);
            this.lblAjzt.TabIndex = 37;
            this.lblAjzt.Text = "案件状态";
            // 
            // cmbAjzt
            // 
            this.cmbAjzt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAjzt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbAjzt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAjzt.EnableTouchMode = true;
            this.cmbAjzt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAjzt.Location =  new System.Drawing.Point(0,0);
            this.cmbAjzt.Name = "cmbAjzt";
            this.cmbAjzt.Size = new System.Drawing.Size(152, 20);
            this.cmbAjzt.TabIndex =  38;            
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 39;
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
            this.txtBz.TabIndex = 40;
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
            this.tableLayoutPanel1.Controls.Add(this.lblDjdl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjdl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjxl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDjxl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSqzsbs, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSqzsbs, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSqfbcz, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbSqfbcz, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSlry, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSlry, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSlsj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.datSlsj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZl, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZl, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTzrxm, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTzrxm, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTzfs, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTzfs, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTzrdh, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtTzrdh, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTzryddh, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTzryddh, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTzrdzyj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTzrdzyj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSfwtaj, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfwtaj, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJssj, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.datJssj, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAjzt, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbAjzt, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 5);
            this.tableLayoutPanel1.RowCount = 7;
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
            this.tableLayoutPanel1.TabIndex = 41; 
            //
            // ucSlsq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSlsq";
            this.Size = new System.Drawing.Size(750, 261);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjdl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjxl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqzsbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSqfbcz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSlsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrxm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTzfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzryddh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTzrdzyj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfwtaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAjzt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjdl;	
        private System.Windows.Forms.Label lblDjdl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjxl;	
        private System.Windows.Forms.Label lblDjxl;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSqzsbs;	
        private System.Windows.Forms.Label lblSqzsbs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSqfbcz;	
        private System.Windows.Forms.Label lblSqfbcz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQxdm;	
        private System.Windows.Forms.Label lblQxdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSlry;	
        private System.Windows.Forms.Label lblSlry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSlsj;	
        private System.Windows.Forms.Label lblSlsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZl;	
        private System.Windows.Forms.Label lblZl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTzrxm;	
        private System.Windows.Forms.Label lblTzrxm;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbTzfs;	
        private System.Windows.Forms.Label lblTzfs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTzrdh;	
        private System.Windows.Forms.Label lblTzrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTzryddh;	
        private System.Windows.Forms.Label lblTzryddh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTzrdzyj;	
        private System.Windows.Forms.Label lblTzrdzyj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfwtaj;	
        private System.Windows.Forms.Label lblSfwtaj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJssj;	
        private System.Windows.Forms.Label lblJssj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbAjzt;	
        private System.Windows.Forms.Label lblAjzt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}