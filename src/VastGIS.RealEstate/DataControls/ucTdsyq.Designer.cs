using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucTdsyq
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
            this.lblMjdw = new System.Windows.Forms.Label();
            this.cmbMjdw = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblNydmj = new System.Windows.Forms.Label();
            this.dblNydmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblGdmj = new System.Windows.Forms.Label();
            this.dblGdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblLdmj = new System.Windows.Forms.Label();
            this.dblLdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCdmj = new System.Windows.Forms.Label();
            this.dblCdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblQtnydmj = new System.Windows.Forms.Label();
            this.dblQtnydmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJsydmj = new System.Windows.Forms.Label();
            this.dblJsydmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblWlydmj = new System.Windows.Forms.Label();
            this.dblWlydmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblNydmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblLdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQtnydmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJsydmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblWlydmj)).BeginInit();
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
            this.lblMjdw.AutoSize = true;
            this.lblMjdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMjdw.Location = new System.Drawing.Point(0,0);
            this.lblMjdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMjdw.Name = "lblMjdw";
            this.lblMjdw.Size = new System.Drawing.Size(41, 20);
            this.lblMjdw.TabIndex = 17;
            this.lblMjdw.Text = "面积单位";
            // 
            // cmbMjdw
            // 
            this.cmbMjdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMjdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbMjdw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMjdw.EnableTouchMode = true;
            this.cmbMjdw.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMjdw.Location =  new System.Drawing.Point(0,0);
            this.cmbMjdw.Name = "cmbMjdw";
            this.cmbMjdw.Size = new System.Drawing.Size(152, 20);
            this.cmbMjdw.TabIndex =  18;            
            // 
            // lblID
            // 
            this.lblNydmj.AutoSize = true;
            this.lblNydmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNydmj.Location = new System.Drawing.Point(0,0);
            this.lblNydmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblNydmj.Name = "lblNydmj";
            this.lblNydmj.Size = new System.Drawing.Size(41, 20);
            this.lblNydmj.TabIndex = 19;
            this.lblNydmj.Text = "农用地面积";
            // 
            // dblNydmj
            // 
            this.dblNydmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblNydmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblNydmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblNydmj.DoubleValue = 1D;
            this.dblNydmj.EnableTouchMode = true;
            this.dblNydmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblNydmj.Location =  new System.Drawing.Point(0,0);
            this.dblNydmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblNydmj.Name = "dblNydmj";
            this.dblNydmj.NullString = "";
            this.dblNydmj.Size = new System.Drawing.Size(152, 28);
            this.dblNydmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblNydmj.TabIndex = 20;
            this.dblNydmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblGdmj.AutoSize = true;
            this.lblGdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGdmj.Location = new System.Drawing.Point(0,0);
            this.lblGdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGdmj.Name = "lblGdmj";
            this.lblGdmj.Size = new System.Drawing.Size(41, 20);
            this.lblGdmj.TabIndex = 21;
            this.lblGdmj.Text = "耕地面积";
            // 
            // dblGdmj
            // 
            this.dblGdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblGdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblGdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblGdmj.DoubleValue = 1D;
            this.dblGdmj.EnableTouchMode = true;
            this.dblGdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblGdmj.Location =  new System.Drawing.Point(0,0);
            this.dblGdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblGdmj.Name = "dblGdmj";
            this.dblGdmj.NullString = "";
            this.dblGdmj.Size = new System.Drawing.Size(152, 28);
            this.dblGdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblGdmj.TabIndex = 22;
            this.dblGdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblLdmj.AutoSize = true;
            this.lblLdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLdmj.Location = new System.Drawing.Point(0,0);
            this.lblLdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLdmj.Name = "lblLdmj";
            this.lblLdmj.Size = new System.Drawing.Size(41, 20);
            this.lblLdmj.TabIndex = 23;
            this.lblLdmj.Text = "林地面积";
            // 
            // dblLdmj
            // 
            this.dblLdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblLdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblLdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblLdmj.DoubleValue = 1D;
            this.dblLdmj.EnableTouchMode = true;
            this.dblLdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblLdmj.Location =  new System.Drawing.Point(0,0);
            this.dblLdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblLdmj.Name = "dblLdmj";
            this.dblLdmj.NullString = "";
            this.dblLdmj.Size = new System.Drawing.Size(152, 28);
            this.dblLdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblLdmj.TabIndex = 24;
            this.dblLdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblCdmj.AutoSize = true;
            this.lblCdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCdmj.Location = new System.Drawing.Point(0,0);
            this.lblCdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCdmj.Name = "lblCdmj";
            this.lblCdmj.Size = new System.Drawing.Size(41, 20);
            this.lblCdmj.TabIndex = 25;
            this.lblCdmj.Text = "草地面积";
            // 
            // dblCdmj
            // 
            this.dblCdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCdmj.DoubleValue = 1D;
            this.dblCdmj.EnableTouchMode = true;
            this.dblCdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCdmj.Location =  new System.Drawing.Point(0,0);
            this.dblCdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCdmj.Name = "dblCdmj";
            this.dblCdmj.NullString = "";
            this.dblCdmj.Size = new System.Drawing.Size(152, 28);
            this.dblCdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCdmj.TabIndex = 26;
            this.dblCdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblQtnydmj.AutoSize = true;
            this.lblQtnydmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQtnydmj.Location = new System.Drawing.Point(0,0);
            this.lblQtnydmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQtnydmj.Name = "lblQtnydmj";
            this.lblQtnydmj.Size = new System.Drawing.Size(41, 20);
            this.lblQtnydmj.TabIndex = 27;
            this.lblQtnydmj.Text = "其它农用地面积";
            // 
            // dblQtnydmj
            // 
            this.dblQtnydmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblQtnydmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblQtnydmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblQtnydmj.DoubleValue = 1D;
            this.dblQtnydmj.EnableTouchMode = true;
            this.dblQtnydmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblQtnydmj.Location =  new System.Drawing.Point(0,0);
            this.dblQtnydmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblQtnydmj.Name = "dblQtnydmj";
            this.dblQtnydmj.NullString = "";
            this.dblQtnydmj.Size = new System.Drawing.Size(152, 28);
            this.dblQtnydmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblQtnydmj.TabIndex = 28;
            this.dblQtnydmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJsydmj.AutoSize = true;
            this.lblJsydmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJsydmj.Location = new System.Drawing.Point(0,0);
            this.lblJsydmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJsydmj.Name = "lblJsydmj";
            this.lblJsydmj.Size = new System.Drawing.Size(41, 20);
            this.lblJsydmj.TabIndex = 29;
            this.lblJsydmj.Text = "建设用地面积";
            // 
            // dblJsydmj
            // 
            this.dblJsydmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJsydmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJsydmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJsydmj.DoubleValue = 1D;
            this.dblJsydmj.EnableTouchMode = true;
            this.dblJsydmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJsydmj.Location =  new System.Drawing.Point(0,0);
            this.dblJsydmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJsydmj.Name = "dblJsydmj";
            this.dblJsydmj.NullString = "";
            this.dblJsydmj.Size = new System.Drawing.Size(152, 28);
            this.dblJsydmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJsydmj.TabIndex = 30;
            this.dblJsydmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblWlydmj.AutoSize = true;
            this.lblWlydmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWlydmj.Location = new System.Drawing.Point(0,0);
            this.lblWlydmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblWlydmj.Name = "lblWlydmj";
            this.lblWlydmj.Size = new System.Drawing.Size(41, 20);
            this.lblWlydmj.TabIndex = 31;
            this.lblWlydmj.Text = "未利用地面积";
            // 
            // dblWlydmj
            // 
            this.dblWlydmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblWlydmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblWlydmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblWlydmj.DoubleValue = 1D;
            this.dblWlydmj.EnableTouchMode = true;
            this.dblWlydmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblWlydmj.Location =  new System.Drawing.Point(0,0);
            this.dblWlydmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblWlydmj.Name = "dblWlydmj";
            this.dblWlydmj.NullString = "";
            this.dblWlydmj.Size = new System.Drawing.Size(152, 28);
            this.dblWlydmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblWlydmj.TabIndex = 32;
            this.dblWlydmj.Text = "1.00";
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
            this.tableLayoutPanel1.Controls.Add(this.lblMjdw, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbMjdw, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNydmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblNydmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGdmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblGdmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLdmj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblLdmj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCdmj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblCdmj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQtnydmj, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblQtnydmj, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJsydmj, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblJsydmj, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblWlydmj, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblWlydmj, 4, 7);
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
            // ucTdsyq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTdsyq";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblNydmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblLdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblQtnydmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJsydmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblWlydmj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbMjdw;	
        private System.Windows.Forms.Label lblMjdw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblNydmj;	
        private System.Windows.Forms.Label lblNydmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblGdmj;	
        private System.Windows.Forms.Label lblGdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblLdmj;	
        private System.Windows.Forms.Label lblLdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCdmj;	
        private System.Windows.Forms.Label lblCdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblQtnydmj;	
        private System.Windows.Forms.Label lblQtnydmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJsydmj;	
        private System.Windows.Forms.Label lblJsydmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblWlydmj;	
        private System.Windows.Forms.Label lblWlydmj;
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