using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucGd
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
            this.lblDjdl = new System.Windows.Forms.Label();
            this.cmbDjdl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjxl = new System.Windows.Forms.Label();
            this.intDjxl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZl = new System.Windows.Forms.Label();
            this.txtZl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQzhm = new System.Windows.Forms.Label();
            this.txtQzhm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblWjjs = new System.Windows.Forms.Label();
            this.intWjjs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZys = new System.Windows.Forms.Label();
            this.intZys = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblGdry = new System.Windows.Forms.Label();
            this.txtGdry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGdsj = new System.Windows.Forms.Label();
            this.datGdsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjdl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDjxl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQzhm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intWjjs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGdry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGdsj)).BeginInit();
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
            // intDjxl
            // 
            this.intDjxl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDjxl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDjxl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDjxl.EnableTouchMode = true;
            this.intDjxl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDjxl.IntegerValue = ((long)(0));
            this.intDjxl.Location = new System.Drawing.Point(0,0);
            this.intDjxl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDjxl.Name = "intDjxl";
            this.intDjxl.NullString = "";
            this.intDjxl.Size = new System.Drawing.Size(152, 28);
            this.intDjxl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDjxl.TabIndex = 10;
            this.intDjxl.Text = "0";
            // 
            // lblID
            // 
            this.lblZl.AutoSize = true;
            this.lblZl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZl.Location = new System.Drawing.Point(0,0);
            this.lblZl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZl.Name = "lblZl";
            this.lblZl.Size = new System.Drawing.Size(41, 20);
            this.lblZl.TabIndex = 11;
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
            this.txtZl.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblQzhm.AutoSize = true;
            this.lblQzhm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQzhm.Location = new System.Drawing.Point(0,0);
            this.lblQzhm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQzhm.Name = "lblQzhm";
            this.lblQzhm.Size = new System.Drawing.Size(41, 20);
            this.lblQzhm.TabIndex = 13;
            this.lblQzhm.Text = "权证号码";
            // 
            // txtQzhm
            // 
            this.txtQzhm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQzhm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQzhm.EnableTouchMode = true;
            this.txtQzhm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQzhm.Location =  new System.Drawing.Point(0,0);
            this.txtQzhm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQzhm.Name = "txtQzhm";
            this.txtQzhm.Size = new System.Drawing.Size(152, 28);
            this.txtQzhm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQzhm.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblWjjs.AutoSize = true;
            this.lblWjjs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWjjs.Location = new System.Drawing.Point(0,0);
            this.lblWjjs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblWjjs.Name = "lblWjjs";
            this.lblWjjs.Size = new System.Drawing.Size(41, 20);
            this.lblWjjs.TabIndex = 15;
            this.lblWjjs.Text = "文件件数";
            // 
            // intWjjs
            // 
            this.intWjjs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intWjjs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intWjjs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intWjjs.EnableTouchMode = true;
            this.intWjjs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intWjjs.IntegerValue = ((long)(0));
            this.intWjjs.Location = new System.Drawing.Point(0,0);
            this.intWjjs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intWjjs.Name = "intWjjs";
            this.intWjjs.NullString = "";
            this.intWjjs.Size = new System.Drawing.Size(152, 28);
            this.intWjjs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intWjjs.TabIndex = 16;
            this.intWjjs.Text = "0";
            // 
            // lblID
            // 
            this.lblZys.AutoSize = true;
            this.lblZys.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZys.Location = new System.Drawing.Point(0,0);
            this.lblZys.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZys.Name = "lblZys";
            this.lblZys.Size = new System.Drawing.Size(41, 20);
            this.lblZys.TabIndex = 17;
            this.lblZys.Text = "总页数";
            // 
            // intZys
            // 
            this.intZys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZys.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZys.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZys.EnableTouchMode = true;
            this.intZys.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZys.IntegerValue = ((long)(0));
            this.intZys.Location = new System.Drawing.Point(0,0);
            this.intZys.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZys.Name = "intZys";
            this.intZys.NullString = "";
            this.intZys.Size = new System.Drawing.Size(152, 28);
            this.intZys.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZys.TabIndex = 18;
            this.intZys.Text = "0";
            // 
            // lblID
            // 
            this.lblGdry.AutoSize = true;
            this.lblGdry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGdry.Location = new System.Drawing.Point(0,0);
            this.lblGdry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGdry.Name = "lblGdry";
            this.lblGdry.Size = new System.Drawing.Size(41, 20);
            this.lblGdry.TabIndex = 19;
            this.lblGdry.Text = "归档人员";
            // 
            // txtGdry
            // 
            this.txtGdry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGdry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGdry.EnableTouchMode = true;
            this.txtGdry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGdry.Location =  new System.Drawing.Point(0,0);
            this.txtGdry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGdry.Name = "txtGdry";
            this.txtGdry.Size = new System.Drawing.Size(152, 28);
            this.txtGdry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGdry.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblGdsj.AutoSize = true;
            this.lblGdsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGdsj.Location = new System.Drawing.Point(0,0);
            this.lblGdsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGdsj.Name = "lblGdsj";
            this.lblGdsj.Size = new System.Drawing.Size(41, 20);
            this.lblGdsj.TabIndex = 21;
            this.lblGdsj.Text = "归档时间";
            // 
            // datGdsj
            // 
            this.datGdsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datGdsj.BorderColor = System.Drawing.Color.Empty;
            this.datGdsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datGdsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datGdsj.DropDownImage = null;
            this.datGdsj.EnableTouchMode = true;
            this.datGdsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datGdsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datGdsj.Location =  new System.Drawing.Point(0,0);
            this.datGdsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datGdsj.MinValue = new System.DateTime(((long)(0)));
            this.datGdsj.Name = "datGdsj";
            this.datGdsj.Size = new System.Drawing.Size(152, 20);
            this.datGdsj.TabIndex = 22;
            this.datGdsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datGdsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 23;
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
            this.txtBz.TabIndex = 24;
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
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDjdl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjdl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjxl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.intDjxl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtZl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQzhm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQzhm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWjjs, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.intWjjs, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZys, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.intZys, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGdry, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGdry, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGdsj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.datGdsj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 4, 5);
            this.tableLayoutPanel1.RowCount = 6;
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
            this.tableLayoutPanel1.TabIndex = 25; 
            //
            // ucGd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucGd";
            this.Size = new System.Drawing.Size(500, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjdl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDjxl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQzhm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intWjjs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGdry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datGdsj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjdl;	
        private System.Windows.Forms.Label lblDjdl;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDjxl;	
        private System.Windows.Forms.Label lblDjxl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZl;	
        private System.Windows.Forms.Label lblZl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQzhm;	
        private System.Windows.Forms.Label lblQzhm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intWjjs;	
        private System.Windows.Forms.Label lblWjjs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZys;	
        private System.Windows.Forms.Label lblZys;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGdry;	
        private System.Windows.Forms.Label lblGdry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datGdsj;	
        private System.Windows.Forms.Label lblGdsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}