using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucQtxgql
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
            this.lblQlqssj = new System.Windows.Forms.Label();
            this.datQlqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblQljssj = new System.Windows.Forms.Label();
            this.datQljssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblQsfs = new System.Windows.Forms.Label();
            this.txtQsfs = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSylx = new System.Windows.Forms.Label();
            this.txtSylx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQsl = new System.Windows.Forms.Label();
            this.dblQsl = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblQsyt = new System.Windows.Forms.Label();
            this.txtQsyt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblKcmj = new System.Windows.Forms.Label();
            this.dblKcmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblKcfs = new System.Windows.Forms.Label();
            this.txtKcfs = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblKckz = new System.Windows.Forms.Label();
            this.txtKckz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblScgm = new System.Windows.Forms.Label();
            this.txtScgm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            this.lblFt = new System.Windows.Forms.Label();
            this.txtFt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.datQlqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQljssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSylx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblKcmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKcfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKckz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFt)).BeginInit();
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
            this.lblQlqssj.AutoSize = true;
            this.lblQlqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlqssj.Location = new System.Drawing.Point(0,0);
            this.lblQlqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlqssj.Name = "lblQlqssj";
            this.lblQlqssj.Size = new System.Drawing.Size(41, 20);
            this.lblQlqssj.TabIndex = 15;
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
            this.datQlqssj.TabIndex = 16;
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
            this.lblQljssj.TabIndex = 17;
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
            this.datQljssj.TabIndex = 18;
            this.datQljssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datQljssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblQsfs.AutoSize = true;
            this.lblQsfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsfs.Location = new System.Drawing.Point(0,0);
            this.lblQsfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsfs.Name = "lblQsfs";
            this.lblQsfs.Size = new System.Drawing.Size(41, 20);
            this.lblQsfs.TabIndex = 19;
            this.lblQsfs.Text = "取水方式";
            // 
            // txtQsfs
            // 
            this.txtQsfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsfs.EnableTouchMode = true;
            this.txtQsfs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsfs.Location =  new System.Drawing.Point(0,0);
            this.txtQsfs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsfs.Name = "txtQsfs";
            this.txtQsfs.Size = new System.Drawing.Size(152, 28);
            this.txtQsfs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsfs.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblSylx.AutoSize = true;
            this.lblSylx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSylx.Location = new System.Drawing.Point(0,0);
            this.lblSylx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSylx.Name = "lblSylx";
            this.lblSylx.Size = new System.Drawing.Size(41, 20);
            this.lblSylx.TabIndex = 21;
            this.lblSylx.Text = "水源类型";
            // 
            // txtSylx
            // 
            this.txtSylx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSylx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSylx.EnableTouchMode = true;
            this.txtSylx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSylx.Location =  new System.Drawing.Point(0,0);
            this.txtSylx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSylx.Name = "txtSylx";
            this.txtSylx.Size = new System.Drawing.Size(152, 28);
            this.txtSylx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSylx.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblQsl.AutoSize = true;
            this.lblQsl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsl.Location = new System.Drawing.Point(0,0);
            this.lblQsl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsl.Name = "lblQsl";
            this.lblQsl.Size = new System.Drawing.Size(41, 20);
            this.lblQsl.TabIndex = 23;
            this.lblQsl.Text = "取水量";
            // 
            // dblQsl
            // 
            this.dblQsl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblQsl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblQsl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblQsl.DoubleValue = 1D;
            this.dblQsl.EnableTouchMode = true;
            this.dblQsl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblQsl.Location =  new System.Drawing.Point(0,0);
            this.dblQsl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblQsl.Name = "dblQsl";
            this.dblQsl.NullString = "";
            this.dblQsl.Size = new System.Drawing.Size(152, 28);
            this.dblQsl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblQsl.TabIndex = 24;
            this.dblQsl.Text = "1.00";
            // 
            // lblID
            // 
            this.lblQsyt.AutoSize = true;
            this.lblQsyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsyt.Location = new System.Drawing.Point(0,0);
            this.lblQsyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsyt.Name = "lblQsyt";
            this.lblQsyt.Size = new System.Drawing.Size(41, 20);
            this.lblQsyt.TabIndex = 25;
            this.lblQsyt.Text = "取水用途";
            // 
            // txtQsyt
            // 
            this.txtQsyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsyt.EnableTouchMode = true;
            this.txtQsyt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsyt.Location =  new System.Drawing.Point(0,0);
            this.txtQsyt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsyt.Name = "txtQsyt";
            this.txtQsyt.Size = new System.Drawing.Size(152, 28);
            this.txtQsyt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsyt.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblKcmj.AutoSize = true;
            this.lblKcmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKcmj.Location = new System.Drawing.Point(0,0);
            this.lblKcmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblKcmj.Name = "lblKcmj";
            this.lblKcmj.Size = new System.Drawing.Size(41, 20);
            this.lblKcmj.TabIndex = 27;
            this.lblKcmj.Text = "勘查面积";
            // 
            // dblKcmj
            // 
            this.dblKcmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblKcmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblKcmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblKcmj.DoubleValue = 1D;
            this.dblKcmj.EnableTouchMode = true;
            this.dblKcmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblKcmj.Location =  new System.Drawing.Point(0,0);
            this.dblKcmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblKcmj.Name = "dblKcmj";
            this.dblKcmj.NullString = "";
            this.dblKcmj.Size = new System.Drawing.Size(152, 28);
            this.dblKcmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblKcmj.TabIndex = 28;
            this.dblKcmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblKcfs.AutoSize = true;
            this.lblKcfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKcfs.Location = new System.Drawing.Point(0,0);
            this.lblKcfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblKcfs.Name = "lblKcfs";
            this.lblKcfs.Size = new System.Drawing.Size(41, 20);
            this.lblKcfs.TabIndex = 29;
            this.lblKcfs.Text = "开采方式";
            // 
            // txtKcfs
            // 
            this.txtKcfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKcfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtKcfs.EnableTouchMode = true;
            this.txtKcfs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKcfs.Location =  new System.Drawing.Point(0,0);
            this.txtKcfs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtKcfs.Name = "txtKcfs";
            this.txtKcfs.Size = new System.Drawing.Size(152, 28);
            this.txtKcfs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtKcfs.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblKckz.AutoSize = true;
            this.lblKckz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKckz.Location = new System.Drawing.Point(0,0);
            this.lblKckz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblKckz.Name = "lblKckz";
            this.lblKckz.Size = new System.Drawing.Size(41, 20);
            this.lblKckz.TabIndex = 31;
            this.lblKckz.Text = "开采矿种";
            // 
            // txtKckz
            // 
            this.txtKckz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKckz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtKckz.EnableTouchMode = true;
            this.txtKckz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKckz.Location =  new System.Drawing.Point(0,0);
            this.txtKckz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtKckz.Name = "txtKckz";
            this.txtKckz.Size = new System.Drawing.Size(152, 28);
            this.txtKckz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtKckz.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblScgm.AutoSize = true;
            this.lblScgm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScgm.Location = new System.Drawing.Point(0,0);
            this.lblScgm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScgm.Name = "lblScgm";
            this.lblScgm.Size = new System.Drawing.Size(41, 20);
            this.lblScgm.TabIndex = 33;
            this.lblScgm.Text = "生产规模";
            // 
            // txtScgm
            // 
            this.txtScgm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScgm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtScgm.EnableTouchMode = true;
            this.txtScgm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtScgm.Location =  new System.Drawing.Point(0,0);
            this.txtScgm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtScgm.Name = "txtScgm";
            this.txtScgm.Size = new System.Drawing.Size(152, 28);
            this.txtScgm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtScgm.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(0,0);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcqzh.TabIndex = 35;
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
            this.txtBdcqzh.TabIndex = 36;
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
            this.lblFt.AutoSize = true;
            this.lblFt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFt.Location = new System.Drawing.Point(0,0);
            this.lblFt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFt.Name = "lblFt";
            this.lblFt.Size = new System.Drawing.Size(41, 20);
            this.lblFt.TabIndex = 47;
            this.lblFt.Text = "附图";
            // 
            // txtFt
            // 
            this.txtFt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFt.EnableTouchMode = true;
            this.txtFt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFt.Location =  new System.Drawing.Point(0,0);
            this.txtFt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(152, 28);
            this.txtFt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFt.TabIndex = 48;
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
            this.tableLayoutPanel1.Controls.Add(this.lblQlqssj, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.datQlqssj, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblQljssj, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.datQljssj, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblQsfs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQsfs, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSylx, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSylx, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQsl, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblQsl, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQsyt, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQsyt, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblKcmj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblKcmj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblKcfs, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtKcfs, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblKckz, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtKckz, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblScgm, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtScgm, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFt, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFt, 7, 5);
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
            // ucQtxgql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQtxgql";
            this.Size = new System.Drawing.Size(750, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQlqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datQljssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSylx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblKcmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKcfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKckz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datQlqssj;	
        private System.Windows.Forms.Label lblQlqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datQljssj;	
        private System.Windows.Forms.Label lblQljssj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsfs;	
        private System.Windows.Forms.Label lblQsfs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSylx;	
        private System.Windows.Forms.Label lblSylx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblQsl;	
        private System.Windows.Forms.Label lblQsl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsyt;	
        private System.Windows.Forms.Label lblQsyt;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblKcmj;	
        private System.Windows.Forms.Label lblKcmj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKcfs;	
        private System.Windows.Forms.Label lblKcfs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKckz;	
        private System.Windows.Forms.Label lblKckz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtScgm;	
        private System.Windows.Forms.Label lblScgm;
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFt;	
        private System.Windows.Forms.Label lblFt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}