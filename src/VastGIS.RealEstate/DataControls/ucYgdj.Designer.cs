using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucYgdj
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
            this.lblBdczl = new System.Windows.Forms.Label();
            this.txtBdczl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwr = new System.Windows.Forms.Label();
            this.txtYwr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwrzjzl = new System.Windows.Forms.Label();
            this.cmbYwrzjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYwrzjh = new System.Windows.Forms.Label();
            this.txtYwrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYgdjzl = new System.Windows.Forms.Label();
            this.cmbYgdjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjlx = new System.Windows.Forms.Label();
            this.cmbDjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjyy = new System.Windows.Forms.Label();
            this.txtDjyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTdsyqr = new System.Windows.Forms.Label();
            this.txtTdsyqr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGhyt = new System.Windows.Forms.Label();
            this.cmbGhyt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwxz = new System.Windows.Forms.Label();
            this.cmbFwxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwjg = new System.Windows.Forms.Label();
            this.cmbFwjg = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSzc = new System.Windows.Forms.Label();
            this.intSzc = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZcs = new System.Windows.Forms.Label();
            this.intZcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblJzmj = new System.Windows.Forms.Label();
            this.dblJzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblQdjg = new System.Windows.Forms.Label();
            this.dblQdjg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblBdcdjzmh = new System.Windows.Forms.Label();
            this.txtBdcdjzmh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBdczl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYwrzjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYgdjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTdsyqr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSzc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQdjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).BeginInit();
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
            this.lblBdczl.AutoSize = true;
            this.lblBdczl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdczl.Location = new System.Drawing.Point(0,0);
            this.lblBdczl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdczl.Name = "lblBdczl";
            this.lblBdczl.Size = new System.Drawing.Size(41, 20);
            this.lblBdczl.TabIndex = 9;
            this.lblBdczl.Text = "不动产坐落";
            // 
            // txtBdczl
            // 
            this.txtBdczl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdczl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdczl.EnableTouchMode = true;
            this.txtBdczl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdczl.Location =  new System.Drawing.Point(0,0);
            this.txtBdczl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdczl.Name = "txtBdczl";
            this.txtBdczl.Size = new System.Drawing.Size(152, 28);
            this.txtBdczl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdczl.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblYwr.AutoSize = true;
            this.lblYwr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwr.Location = new System.Drawing.Point(0,0);
            this.lblYwr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwr.Name = "lblYwr";
            this.lblYwr.Size = new System.Drawing.Size(41, 20);
            this.lblYwr.TabIndex = 11;
            this.lblYwr.Text = "义务人";
            // 
            // txtYwr
            // 
            this.txtYwr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwr.EnableTouchMode = true;
            this.txtYwr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwr.Location =  new System.Drawing.Point(0,0);
            this.txtYwr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwr.Name = "txtYwr";
            this.txtYwr.Size = new System.Drawing.Size(152, 28);
            this.txtYwr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwr.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblYwrzjzl.AutoSize = true;
            this.lblYwrzjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrzjzl.Location = new System.Drawing.Point(0,0);
            this.lblYwrzjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrzjzl.Name = "lblYwrzjzl";
            this.lblYwrzjzl.Size = new System.Drawing.Size(41, 20);
            this.lblYwrzjzl.TabIndex = 13;
            this.lblYwrzjzl.Text = "义务人证件种类";
            // 
            // cmbYwrzjzl
            // 
            this.cmbYwrzjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYwrzjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYwrzjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYwrzjzl.EnableTouchMode = true;
            this.cmbYwrzjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYwrzjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbYwrzjzl.Name = "cmbYwrzjzl";
            this.cmbYwrzjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbYwrzjzl.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblYwrzjh.AutoSize = true;
            this.lblYwrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwrzjh.Location = new System.Drawing.Point(0,0);
            this.lblYwrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwrzjh.Name = "lblYwrzjh";
            this.lblYwrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblYwrzjh.TabIndex = 15;
            this.lblYwrzjh.Text = "义务人证件号";
            // 
            // txtYwrzjh
            // 
            this.txtYwrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwrzjh.EnableTouchMode = true;
            this.txtYwrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtYwrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwrzjh.Name = "txtYwrzjh";
            this.txtYwrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtYwrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwrzjh.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblYgdjzl.AutoSize = true;
            this.lblYgdjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYgdjzl.Location = new System.Drawing.Point(0,0);
            this.lblYgdjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYgdjzl.Name = "lblYgdjzl";
            this.lblYgdjzl.Size = new System.Drawing.Size(41, 20);
            this.lblYgdjzl.TabIndex = 17;
            this.lblYgdjzl.Text = "预告登记种类";
            // 
            // cmbYgdjzl
            // 
            this.cmbYgdjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYgdjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYgdjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYgdjzl.EnableTouchMode = true;
            this.cmbYgdjzl.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYgdjzl.Location =  new System.Drawing.Point(0,0);
            this.cmbYgdjzl.Name = "cmbYgdjzl";
            this.cmbYgdjzl.Size = new System.Drawing.Size(152, 20);
            this.cmbYgdjzl.TabIndex =  18;            
            // 
            // lblID
            // 
            this.lblDjlx.AutoSize = true;
            this.lblDjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjlx.Location = new System.Drawing.Point(0,0);
            this.lblDjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjlx.Name = "lblDjlx";
            this.lblDjlx.Size = new System.Drawing.Size(41, 20);
            this.lblDjlx.TabIndex = 19;
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
            this.cmbDjlx.TabIndex =  20;            
            // 
            // lblID
            // 
            this.lblDjyy.AutoSize = true;
            this.lblDjyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjyy.Location = new System.Drawing.Point(0,0);
            this.lblDjyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjyy.Name = "lblDjyy";
            this.lblDjyy.Size = new System.Drawing.Size(41, 20);
            this.lblDjyy.TabIndex = 21;
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
            this.txtDjyy.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblTdsyqr.AutoSize = true;
            this.lblTdsyqr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTdsyqr.Location = new System.Drawing.Point(0,0);
            this.lblTdsyqr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTdsyqr.Name = "lblTdsyqr";
            this.lblTdsyqr.Size = new System.Drawing.Size(41, 20);
            this.lblTdsyqr.TabIndex = 23;
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
            this.txtTdsyqr.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblGhyt.AutoSize = true;
            this.lblGhyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGhyt.Location = new System.Drawing.Point(0,0);
            this.lblGhyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGhyt.Name = "lblGhyt";
            this.lblGhyt.Size = new System.Drawing.Size(41, 20);
            this.lblGhyt.TabIndex = 25;
            this.lblGhyt.Text = "规划用途";
            // 
            // cmbGhyt
            // 
            this.cmbGhyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGhyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGhyt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGhyt.EnableTouchMode = true;
            this.cmbGhyt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGhyt.Location =  new System.Drawing.Point(0,0);
            this.cmbGhyt.Name = "cmbGhyt";
            this.cmbGhyt.Size = new System.Drawing.Size(152, 20);
            this.cmbGhyt.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblFwxz.AutoSize = true;
            this.lblFwxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwxz.Location = new System.Drawing.Point(0,0);
            this.lblFwxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwxz.Name = "lblFwxz";
            this.lblFwxz.Size = new System.Drawing.Size(41, 20);
            this.lblFwxz.TabIndex = 27;
            this.lblFwxz.Text = "房屋性质";
            // 
            // cmbFwxz
            // 
            this.cmbFwxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwxz.EnableTouchMode = true;
            this.cmbFwxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwxz.Location =  new System.Drawing.Point(0,0);
            this.cmbFwxz.Name = "cmbFwxz";
            this.cmbFwxz.Size = new System.Drawing.Size(152, 20);
            this.cmbFwxz.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblFwjg.AutoSize = true;
            this.lblFwjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg.Location = new System.Drawing.Point(0,0);
            this.lblFwjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg.Name = "lblFwjg";
            this.lblFwjg.Size = new System.Drawing.Size(41, 20);
            this.lblFwjg.TabIndex = 29;
            this.lblFwjg.Text = "房屋结构";
            // 
            // cmbFwjg
            // 
            this.cmbFwjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg.EnableTouchMode = true;
            this.cmbFwjg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg.Location =  new System.Drawing.Point(0,0);
            this.cmbFwjg.Name = "cmbFwjg";
            this.cmbFwjg.Size = new System.Drawing.Size(152, 20);
            this.cmbFwjg.TabIndex =  30;            
            // 
            // lblID
            // 
            this.lblSzc.AutoSize = true;
            this.lblSzc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSzc.Location = new System.Drawing.Point(0,0);
            this.lblSzc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSzc.Name = "lblSzc";
            this.lblSzc.Size = new System.Drawing.Size(41, 20);
            this.lblSzc.TabIndex = 31;
            this.lblSzc.Text = "所在层";
            // 
            // intSzc
            // 
            this.intSzc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSzc.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSzc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSzc.EnableTouchMode = true;
            this.intSzc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSzc.IntegerValue = ((long)(0));
            this.intSzc.Location = new System.Drawing.Point(0,0);
            this.intSzc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSzc.Name = "intSzc";
            this.intSzc.NullString = "";
            this.intSzc.Size = new System.Drawing.Size(152, 28);
            this.intSzc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSzc.TabIndex = 32;
            this.intSzc.Text = "0";
            // 
            // lblID
            // 
            this.lblZcs.AutoSize = true;
            this.lblZcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZcs.Location = new System.Drawing.Point(0,0);
            this.lblZcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZcs.Name = "lblZcs";
            this.lblZcs.Size = new System.Drawing.Size(41, 20);
            this.lblZcs.TabIndex = 33;
            this.lblZcs.Text = "总层数";
            // 
            // intZcs
            // 
            this.intZcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZcs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZcs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZcs.EnableTouchMode = true;
            this.intZcs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZcs.IntegerValue = ((long)(0));
            this.intZcs.Location = new System.Drawing.Point(0,0);
            this.intZcs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZcs.Name = "intZcs";
            this.intZcs.NullString = "";
            this.intZcs.Size = new System.Drawing.Size(152, 28);
            this.intZcs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZcs.TabIndex = 34;
            this.intZcs.Text = "0";
            // 
            // lblID
            // 
            this.lblJzmj.AutoSize = true;
            this.lblJzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzmj.Location = new System.Drawing.Point(0,0);
            this.lblJzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzmj.Name = "lblJzmj";
            this.lblJzmj.Size = new System.Drawing.Size(41, 20);
            this.lblJzmj.TabIndex = 35;
            this.lblJzmj.Text = "建筑面积";
            // 
            // dblJzmj
            // 
            this.dblJzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzmj.DoubleValue = 1D;
            this.dblJzmj.EnableTouchMode = true;
            this.dblJzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzmj.Location =  new System.Drawing.Point(0,0);
            this.dblJzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzmj.Name = "dblJzmj";
            this.dblJzmj.NullString = "";
            this.dblJzmj.Size = new System.Drawing.Size(152, 28);
            this.dblJzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzmj.TabIndex = 36;
            this.dblJzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblQdjg.AutoSize = true;
            this.lblQdjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQdjg.Location = new System.Drawing.Point(0,0);
            this.lblQdjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQdjg.Name = "lblQdjg";
            this.lblQdjg.Size = new System.Drawing.Size(41, 20);
            this.lblQdjg.TabIndex = 37;
            this.lblQdjg.Text = "取得价格/被担保主债权数额";
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
            this.dblQdjg.TabIndex = 38;
            this.dblQdjg.Text = "1.00";
            // 
            // lblID
            // 
            this.lblBdcdjzmh.AutoSize = true;
            this.lblBdcdjzmh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdjzmh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdjzmh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdjzmh.Name = "lblBdcdjzmh";
            this.lblBdcdjzmh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdjzmh.TabIndex = 39;
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
            this.txtBdcdjzmh.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 41;
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
            this.cmbQxdm.TabIndex =  42;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 43;
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
            this.txtDjjg.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 45;
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
            this.txtDbr.TabIndex = 46;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 47;
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
            this.datDjsj.TabIndex = 48;
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
            this.lblFj.TabIndex = 49;
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
            this.txtFj.TabIndex = 50;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 51;
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
            this.cmbQszt.TabIndex =  52;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblBdczl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBdczl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYwr, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYwr, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrzjzl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbYwrzjzl, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblYwrzjh, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtYwrzjh, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYgdjzl, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbYgdjzl, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDjlx, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjlx, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDjyy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDjyy, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTdsyqr, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTdsyqr, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGhyt, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbGhyt, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFwxz, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwxz, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSzc, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.intSzc, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblZcs, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.intZcs, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblJzmj, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblJzmj, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblQdjg, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblQdjg, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdjzmh, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdjzmh, 7, 1);
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
            this.tableLayoutPanel1.TabIndex = 53; 
            //
            // ucYgdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucYgdj";
            this.Size = new System.Drawing.Size(750, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdczl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYwrzjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYgdjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTdsyqr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSzc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQdjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdczl;	
        private System.Windows.Forms.Label lblBdczl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwr;	
        private System.Windows.Forms.Label lblYwr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYwrzjzl;	
        private System.Windows.Forms.Label lblYwrzjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwrzjh;	
        private System.Windows.Forms.Label lblYwrzjh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYgdjzl;	
        private System.Windows.Forms.Label lblYgdjzl;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjlx;	
        private System.Windows.Forms.Label lblDjlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjyy;	
        private System.Windows.Forms.Label lblDjyy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTdsyqr;	
        private System.Windows.Forms.Label lblTdsyqr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGhyt;	
        private System.Windows.Forms.Label lblGhyt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwxz;	
        private System.Windows.Forms.Label lblFwxz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg;	
        private System.Windows.Forms.Label lblFwjg;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSzc;	
        private System.Windows.Forms.Label lblSzc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZcs;	
        private System.Windows.Forms.Label lblZcs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzmj;	
        private System.Windows.Forms.Label lblJzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblQdjg;	
        private System.Windows.Forms.Label lblQdjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdjzmh;	
        private System.Windows.Forms.Label lblBdcdjzmh;
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