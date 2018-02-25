using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucCfdj
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
            this.lblCfjg = new System.Windows.Forms.Label();
            this.txtCfjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCflx = new System.Windows.Forms.Label();
            this.cmbCflx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblCfwj = new System.Windows.Forms.Label();
            this.txtCfwj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCfwh = new System.Windows.Forms.Label();
            this.txtCfwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCfqssj = new System.Windows.Forms.Label();
            this.datCfqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblCfjssj = new System.Windows.Forms.Label();
            this.datCfjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblCffw = new System.Windows.Forms.Label();
            this.txtCffw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQxdm = new System.Windows.Forms.Label();
            this.cmbQxdm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjjg = new System.Windows.Forms.Label();
            this.txtDjjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDbr = new System.Windows.Forms.Label();
            this.txtDbr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjsj = new System.Windows.Forms.Label();
            this.datDjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblJfywh = new System.Windows.Forms.Label();
            this.txtJfywh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfjg = new System.Windows.Forms.Label();
            this.txtJfjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfwj = new System.Windows.Forms.Label();
            this.txtJfwj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfwh = new System.Windows.Forms.Label();
            this.txtJfwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfdbr = new System.Windows.Forms.Label();
            this.txtJfdbr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfdjsj = new System.Windows.Forms.Label();
            this.datJfdjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFj = new System.Windows.Forms.Label();
            this.txtFj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQszt = new System.Windows.Forms.Label();
            this.cmbQszt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCflx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfwj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCfqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCfjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCffw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfywh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfwj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfdbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJfdjsj)).BeginInit();
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
            this.lblCfjg.AutoSize = true;
            this.lblCfjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCfjg.Location = new System.Drawing.Point(0,0);
            this.lblCfjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCfjg.Name = "lblCfjg";
            this.lblCfjg.Size = new System.Drawing.Size(41, 20);
            this.lblCfjg.TabIndex = 9;
            this.lblCfjg.Text = "查封机关";
            // 
            // txtCfjg
            // 
            this.txtCfjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCfjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCfjg.EnableTouchMode = true;
            this.txtCfjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCfjg.Location =  new System.Drawing.Point(0,0);
            this.txtCfjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCfjg.Name = "txtCfjg";
            this.txtCfjg.Size = new System.Drawing.Size(152, 28);
            this.txtCfjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCfjg.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblCflx.AutoSize = true;
            this.lblCflx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCflx.Location = new System.Drawing.Point(0,0);
            this.lblCflx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCflx.Name = "lblCflx";
            this.lblCflx.Size = new System.Drawing.Size(41, 20);
            this.lblCflx.TabIndex = 11;
            this.lblCflx.Text = "查封类型";
            // 
            // cmbCflx
            // 
            this.cmbCflx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCflx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbCflx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCflx.EnableTouchMode = true;
            this.cmbCflx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCflx.Location =  new System.Drawing.Point(0,0);
            this.cmbCflx.Name = "cmbCflx";
            this.cmbCflx.Size = new System.Drawing.Size(152, 20);
            this.cmbCflx.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblCfwj.AutoSize = true;
            this.lblCfwj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCfwj.Location = new System.Drawing.Point(0,0);
            this.lblCfwj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCfwj.Name = "lblCfwj";
            this.lblCfwj.Size = new System.Drawing.Size(41, 20);
            this.lblCfwj.TabIndex = 13;
            this.lblCfwj.Text = "查封文件";
            // 
            // txtCfwj
            // 
            this.txtCfwj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCfwj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCfwj.EnableTouchMode = true;
            this.txtCfwj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCfwj.Location =  new System.Drawing.Point(0,0);
            this.txtCfwj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCfwj.Name = "txtCfwj";
            this.txtCfwj.Size = new System.Drawing.Size(152, 28);
            this.txtCfwj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCfwj.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblCfwh.AutoSize = true;
            this.lblCfwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCfwh.Location = new System.Drawing.Point(0,0);
            this.lblCfwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCfwh.Name = "lblCfwh";
            this.lblCfwh.Size = new System.Drawing.Size(41, 20);
            this.lblCfwh.TabIndex = 15;
            this.lblCfwh.Text = "查封文号";
            // 
            // txtCfwh
            // 
            this.txtCfwh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCfwh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCfwh.EnableTouchMode = true;
            this.txtCfwh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCfwh.Location =  new System.Drawing.Point(0,0);
            this.txtCfwh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCfwh.Name = "txtCfwh";
            this.txtCfwh.Size = new System.Drawing.Size(152, 28);
            this.txtCfwh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCfwh.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblCfqssj.AutoSize = true;
            this.lblCfqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCfqssj.Location = new System.Drawing.Point(0,0);
            this.lblCfqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCfqssj.Name = "lblCfqssj";
            this.lblCfqssj.Size = new System.Drawing.Size(41, 20);
            this.lblCfqssj.TabIndex = 17;
            this.lblCfqssj.Text = "查封起始时间";
            // 
            // datCfqssj
            // 
            this.datCfqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datCfqssj.BorderColor = System.Drawing.Color.Empty;
            this.datCfqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datCfqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datCfqssj.DropDownImage = null;
            this.datCfqssj.EnableTouchMode = true;
            this.datCfqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datCfqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datCfqssj.Location =  new System.Drawing.Point(0,0);
            this.datCfqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datCfqssj.MinValue = new System.DateTime(((long)(0)));
            this.datCfqssj.Name = "datCfqssj";
            this.datCfqssj.Size = new System.Drawing.Size(152, 20);
            this.datCfqssj.TabIndex = 18;
            this.datCfqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datCfqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblCfjssj.AutoSize = true;
            this.lblCfjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCfjssj.Location = new System.Drawing.Point(0,0);
            this.lblCfjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCfjssj.Name = "lblCfjssj";
            this.lblCfjssj.Size = new System.Drawing.Size(41, 20);
            this.lblCfjssj.TabIndex = 19;
            this.lblCfjssj.Text = "查封结束时间";
            // 
            // datCfjssj
            // 
            this.datCfjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datCfjssj.BorderColor = System.Drawing.Color.Empty;
            this.datCfjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datCfjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datCfjssj.DropDownImage = null;
            this.datCfjssj.EnableTouchMode = true;
            this.datCfjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datCfjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datCfjssj.Location =  new System.Drawing.Point(0,0);
            this.datCfjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datCfjssj.MinValue = new System.DateTime(((long)(0)));
            this.datCfjssj.Name = "datCfjssj";
            this.datCfjssj.Size = new System.Drawing.Size(152, 20);
            this.datCfjssj.TabIndex = 20;
            this.datCfjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datCfjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblCffw.AutoSize = true;
            this.lblCffw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCffw.Location = new System.Drawing.Point(0,0);
            this.lblCffw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCffw.Name = "lblCffw";
            this.lblCffw.Size = new System.Drawing.Size(41, 20);
            this.lblCffw.TabIndex = 21;
            this.lblCffw.Text = "查封范围";
            // 
            // txtCffw
            // 
            this.txtCffw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCffw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCffw.EnableTouchMode = true;
            this.txtCffw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCffw.Location =  new System.Drawing.Point(0,0);
            this.txtCffw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCffw.Name = "txtCffw";
            this.txtCffw.Size = new System.Drawing.Size(152, 28);
            this.txtCffw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCffw.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 23;
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
            this.cmbQxdm.TabIndex =  24;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 25;
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
            this.txtDjjg.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 27;
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
            this.txtDbr.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 29;
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
            this.datDjsj.TabIndex = 30;
            this.datDjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datDjsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblJfywh.AutoSize = true;
            this.lblJfywh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfywh.Location = new System.Drawing.Point(0,0);
            this.lblJfywh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfywh.Name = "lblJfywh";
            this.lblJfywh.Size = new System.Drawing.Size(41, 20);
            this.lblJfywh.TabIndex = 31;
            this.lblJfywh.Text = "解封业务号";
            // 
            // txtJfywh
            // 
            this.txtJfywh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfywh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfywh.EnableTouchMode = true;
            this.txtJfywh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfywh.Location =  new System.Drawing.Point(0,0);
            this.txtJfywh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfywh.Name = "txtJfywh";
            this.txtJfywh.Size = new System.Drawing.Size(152, 28);
            this.txtJfywh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfywh.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblJfjg.AutoSize = true;
            this.lblJfjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfjg.Location = new System.Drawing.Point(0,0);
            this.lblJfjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfjg.Name = "lblJfjg";
            this.lblJfjg.Size = new System.Drawing.Size(41, 20);
            this.lblJfjg.TabIndex = 33;
            this.lblJfjg.Text = "解封机关";
            // 
            // txtJfjg
            // 
            this.txtJfjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfjg.EnableTouchMode = true;
            this.txtJfjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfjg.Location =  new System.Drawing.Point(0,0);
            this.txtJfjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfjg.Name = "txtJfjg";
            this.txtJfjg.Size = new System.Drawing.Size(152, 28);
            this.txtJfjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfjg.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblJfwj.AutoSize = true;
            this.lblJfwj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfwj.Location = new System.Drawing.Point(0,0);
            this.lblJfwj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfwj.Name = "lblJfwj";
            this.lblJfwj.Size = new System.Drawing.Size(41, 20);
            this.lblJfwj.TabIndex = 35;
            this.lblJfwj.Text = "解封文件";
            // 
            // txtJfwj
            // 
            this.txtJfwj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfwj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfwj.EnableTouchMode = true;
            this.txtJfwj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfwj.Location =  new System.Drawing.Point(0,0);
            this.txtJfwj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfwj.Name = "txtJfwj";
            this.txtJfwj.Size = new System.Drawing.Size(152, 28);
            this.txtJfwj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfwj.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblJfwh.AutoSize = true;
            this.lblJfwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfwh.Location = new System.Drawing.Point(0,0);
            this.lblJfwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfwh.Name = "lblJfwh";
            this.lblJfwh.Size = new System.Drawing.Size(41, 20);
            this.lblJfwh.TabIndex = 37;
            this.lblJfwh.Text = "解封文号";
            // 
            // txtJfwh
            // 
            this.txtJfwh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfwh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfwh.EnableTouchMode = true;
            this.txtJfwh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfwh.Location =  new System.Drawing.Point(0,0);
            this.txtJfwh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfwh.Name = "txtJfwh";
            this.txtJfwh.Size = new System.Drawing.Size(152, 28);
            this.txtJfwh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfwh.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblJfdbr.AutoSize = true;
            this.lblJfdbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfdbr.Location = new System.Drawing.Point(0,0);
            this.lblJfdbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfdbr.Name = "lblJfdbr";
            this.lblJfdbr.Size = new System.Drawing.Size(41, 20);
            this.lblJfdbr.TabIndex = 39;
            this.lblJfdbr.Text = "解封登簿人";
            // 
            // txtJfdbr
            // 
            this.txtJfdbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfdbr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfdbr.EnableTouchMode = true;
            this.txtJfdbr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfdbr.Location =  new System.Drawing.Point(0,0);
            this.txtJfdbr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfdbr.Name = "txtJfdbr";
            this.txtJfdbr.Size = new System.Drawing.Size(152, 28);
            this.txtJfdbr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfdbr.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblJfdjsj.AutoSize = true;
            this.lblJfdjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfdjsj.Location = new System.Drawing.Point(0,0);
            this.lblJfdjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfdjsj.Name = "lblJfdjsj";
            this.lblJfdjsj.Size = new System.Drawing.Size(41, 20);
            this.lblJfdjsj.TabIndex = 41;
            this.lblJfdjsj.Text = "解封登记时间";
            // 
            // datJfdjsj
            // 
            this.datJfdjsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJfdjsj.BorderColor = System.Drawing.Color.Empty;
            this.datJfdjsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJfdjsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJfdjsj.DropDownImage = null;
            this.datJfdjsj.EnableTouchMode = true;
            this.datJfdjsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJfdjsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJfdjsj.Location =  new System.Drawing.Point(0,0);
            this.datJfdjsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJfdjsj.MinValue = new System.DateTime(((long)(0)));
            this.datJfdjsj.Name = "datJfdjsj";
            this.datJfdjsj.Size = new System.Drawing.Size(152, 20);
            this.datJfdjsj.TabIndex = 42;
            this.datJfdjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJfdjsj.UseCurrentCulture = true;
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
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 45;
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
            this.cmbQszt.TabIndex =  46;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblCfjg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCfjg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCflx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbCflx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCfwj, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCfwj, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblCfwh, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCfwh, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCfqssj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.datCfqssj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCfjssj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.datCfjssj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCffw, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCffw, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJfywh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtJfywh, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblJfjg, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtJfjg, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblJfwj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtJfwj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJfwh, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtJfwh, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJfdbr, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtJfdbr, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJfdjsj, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.datJfdjsj, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 6);
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
            this.tableLayoutPanel1.TabIndex = 47; 
            //
            // ucCfdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucCfdj";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCflx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfwj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCfwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCfqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datCfjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCffw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfywh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfwj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfdbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJfdjsj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCfjg;	
        private System.Windows.Forms.Label lblCfjg;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbCflx;	
        private System.Windows.Forms.Label lblCflx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCfwj;	
        private System.Windows.Forms.Label lblCfwj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCfwh;	
        private System.Windows.Forms.Label lblCfwh;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datCfqssj;	
        private System.Windows.Forms.Label lblCfqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datCfjssj;	
        private System.Windows.Forms.Label lblCfjssj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCffw;	
        private System.Windows.Forms.Label lblCffw;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQxdm;	
        private System.Windows.Forms.Label lblQxdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjjg;	
        private System.Windows.Forms.Label lblDjjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDbr;	
        private System.Windows.Forms.Label lblDbr;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datDjsj;	
        private System.Windows.Forms.Label lblDjsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfywh;	
        private System.Windows.Forms.Label lblJfywh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfjg;	
        private System.Windows.Forms.Label lblJfjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfwj;	
        private System.Windows.Forms.Label lblJfwj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfwh;	
        private System.Windows.Forms.Label lblJfwh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfdbr;	
        private System.Windows.Forms.Label lblJfdbr;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJfdjsj;	
        private System.Windows.Forms.Label lblJfdjsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFj;	
        private System.Windows.Forms.Label lblFj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}