using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZdjbxx
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
            this.lblZdtzm = new System.Windows.Forms.Label();
            this.cmbZdtzm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZl = new System.Windows.Forms.Label();
            this.txtZl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdmj = new System.Windows.Forms.Label();
            this.dblZdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblMjdw = new System.Windows.Forms.Label();
            this.cmbMjdw = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYt = new System.Windows.Forms.Label();
            this.txtYt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDj = new System.Windows.Forms.Label();
            this.cmbDj = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJg = new System.Windows.Forms.Label();
            this.dblJg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblQllx = new System.Windows.Forms.Label();
            this.cmbQllx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQlxz = new System.Windows.Forms.Label();
            this.cmbQlxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQlsdfs = new System.Windows.Forms.Label();
            this.cmbQlsdfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblRjl = new System.Windows.Forms.Label();
            this.dblRjl = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJzmd = new System.Windows.Forms.Label();
            this.dblJzmd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJzxg = new System.Windows.Forms.Label();
            this.dblJzxg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZdszd = new System.Windows.Forms.Label();
            this.txtZdszd = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdszn = new System.Windows.Forms.Label();
            this.txtZdszn = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdszx = new System.Windows.Forms.Label();
            this.txtZdszx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdszb = new System.Windows.Forms.Label();
            this.txtZdszb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdt = new System.Windows.Forms.Label();
            this.txtZdt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTfh = new System.Windows.Forms.Label();
            this.txtTfh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjh = new System.Windows.Forms.Label();
            this.txtDjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDah = new System.Windows.Forms.Label();
            this.txtDah = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.cmbZt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZdtzm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlsdfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblRjl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzxg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTfh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblID.Location = new System.Drawing.Point(36, 10);
            this.lblID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "标识码";
            // 
            // intID
            // 
            this.intID.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intID.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intID.EnableTouchMode = true;
            this.intID.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intID.IntegerValue = ((long)(0));
            this.intID.Location = new System.Drawing.Point(83, 3);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";
            this.intID.NullString = "";
            this.intID.Size = new System.Drawing.Size(158, 28);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 2;
            this.intID.Text = "0";
            // 
            // lblYsdm
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(24, 45);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(53, 25);
            this.lblYsdm.TabIndex = 3;
            this.lblYsdm.Text = "要素代码";
            // 
            // txtYsdm
            // 
            this.txtYsdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsdm.EnableTouchMode = true;
            this.txtYsdm.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsdm.Location = new System.Drawing.Point(83, 38);
            this.txtYsdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsdm.Name = "txtYsdm";
            this.txtYsdm.Size = new System.Drawing.Size(158, 28);
            this.txtYsdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsdm.TabIndex = 4;
            // 
            // lblZddm
            // 
            this.lblZddm.AutoSize = true;
            this.lblZddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZddm.Location = new System.Drawing.Point(24, 80);
            this.lblZddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZddm.Name = "lblZddm";
            this.lblZddm.Size = new System.Drawing.Size(53, 25);
            this.lblZddm.TabIndex = 5;
            this.lblZddm.Text = "宗地代码";
            // 
            // txtZddm
            // 
            this.txtZddm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZddm.EnableTouchMode = true;
            this.txtZddm.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZddm.Location = new System.Drawing.Point(83, 73);
            this.txtZddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZddm.Name = "txtZddm";
            this.txtZddm.Size = new System.Drawing.Size(158, 28);
            this.txtZddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZddm.TabIndex = 6;
            // 
            // lblBdcdyh
            // 
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(12, 115);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(65, 25);
            this.lblBdcdyh.TabIndex = 7;
            this.lblBdcdyh.Text = "不动产单元号";
            // 
            // txtBdcdyh
            // 
            this.txtBdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdyh.EnableTouchMode = true;
            this.txtBdcdyh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdyh.Location = new System.Drawing.Point(83, 108);
            this.txtBdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdyh.Name = "txtBdcdyh";
            this.txtBdcdyh.Size = new System.Drawing.Size(158, 28);
            this.txtBdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdyh.TabIndex = 8;
            // 
            // lblZdtzm
            // 
            this.lblZdtzm.AutoSize = true;
            this.lblZdtzm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdtzm.Location = new System.Drawing.Point(12, 150);
            this.lblZdtzm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdtzm.Name = "lblZdtzm";
            this.lblZdtzm.Size = new System.Drawing.Size(65, 25);
            this.lblZdtzm.TabIndex = 9;
            this.lblZdtzm.Text = "宗地特征码";
            // 
            // cmbZdtzm
            // 
            this.cmbZdtzm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZdtzm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZdtzm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZdtzm.EnableTouchMode = true;
            this.cmbZdtzm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZdtzm.Location = new System.Drawing.Point(83, 143);
            this.cmbZdtzm.Name = "cmbZdtzm";
            this.cmbZdtzm.Size = new System.Drawing.Size(158, 20);
            this.cmbZdtzm.TabIndex = 10;
            // 
            // lblZl
            // 
            this.lblZl.AutoSize = true;
            this.lblZl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZl.Location = new System.Drawing.Point(48, 185);
            this.lblZl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZl.Name = "lblZl";
            this.lblZl.Size = new System.Drawing.Size(29, 25);
            this.lblZl.TabIndex = 11;
            this.lblZl.Text = "坐落";
            // 
            // txtZl
            // 
            this.txtZl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZl.EnableTouchMode = true;
            this.txtZl.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZl.Location = new System.Drawing.Point(83, 178);
            this.txtZl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZl.Name = "txtZl";
            this.txtZl.Size = new System.Drawing.Size(158, 28);
            this.txtZl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZl.TabIndex = 12;
            // 
            // lblZdmj
            // 
            this.lblZdmj.AutoSize = true;
            this.lblZdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdmj.Location = new System.Drawing.Point(24, 220);
            this.lblZdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdmj.Name = "lblZdmj";
            this.lblZdmj.Size = new System.Drawing.Size(53, 25);
            this.lblZdmj.TabIndex = 13;
            this.lblZdmj.Text = "宗地面积";
            // 
            // dblZdmj
            // 
            this.dblZdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZdmj.DoubleValue = 1D;
            this.dblZdmj.EnableTouchMode = true;
            this.dblZdmj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZdmj.Location = new System.Drawing.Point(83, 213);
            this.dblZdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZdmj.Name = "dblZdmj";
            this.dblZdmj.NullString = "";
            this.dblZdmj.Size = new System.Drawing.Size(158, 28);
            this.dblZdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZdmj.TabIndex = 14;
            this.dblZdmj.Text = "1.00";
            // 
            // lblMjdw
            // 
            this.lblMjdw.AutoSize = true;
            this.lblMjdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMjdw.Location = new System.Drawing.Point(24, 255);
            this.lblMjdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMjdw.Name = "lblMjdw";
            this.lblMjdw.Size = new System.Drawing.Size(53, 25);
            this.lblMjdw.TabIndex = 15;
            this.lblMjdw.Text = "面积单位";
            // 
            // cmbMjdw
            // 
            this.cmbMjdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbMjdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMjdw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMjdw.EnableTouchMode = true;
            this.cmbMjdw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMjdw.Location = new System.Drawing.Point(83, 248);
            this.cmbMjdw.Name = "cmbMjdw";
            this.cmbMjdw.Size = new System.Drawing.Size(158, 20);
            this.cmbMjdw.TabIndex = 16;
            // 
            // lblYt
            // 
            this.lblYt.AutoSize = true;
            this.lblYt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYt.Location = new System.Drawing.Point(48, 290);
            this.lblYt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYt.Name = "lblYt";
            this.lblYt.Size = new System.Drawing.Size(29, 41);
            this.lblYt.TabIndex = 17;
            this.lblYt.Text = "用途";
            // 
            // txtYt
            // 
            this.txtYt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYt.EnableTouchMode = true;
            this.txtYt.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYt.Location = new System.Drawing.Point(83, 283);
            this.txtYt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYt.Name = "txtYt";
            this.txtYt.Size = new System.Drawing.Size(158, 28);
            this.txtYt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYt.TabIndex = 18;
            // 
            // lblDj
            // 
            this.lblDj.AutoSize = true;
            this.lblDj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDj.Location = new System.Drawing.Point(297, 10);
            this.lblDj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDj.Name = "lblDj";
            this.lblDj.Size = new System.Drawing.Size(29, 25);
            this.lblDj.TabIndex = 19;
            this.lblDj.Text = "等级";
            // 
            // cmbDj
            // 
            this.cmbDj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDj.EnableTouchMode = true;
            this.cmbDj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDj.Location = new System.Drawing.Point(332, 3);
            this.cmbDj.Name = "cmbDj";
            this.cmbDj.Size = new System.Drawing.Size(158, 20);
            this.cmbDj.TabIndex = 20;
            // 
            // lblJg
            // 
            this.lblJg.AutoSize = true;
            this.lblJg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJg.Location = new System.Drawing.Point(297, 45);
            this.lblJg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJg.Name = "lblJg";
            this.lblJg.Size = new System.Drawing.Size(29, 25);
            this.lblJg.TabIndex = 21;
            this.lblJg.Text = "价格";
            // 
            // dblJg
            // 
            this.dblJg.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJg.DoubleValue = 1D;
            this.dblJg.EnableTouchMode = true;
            this.dblJg.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJg.Location = new System.Drawing.Point(332, 38);
            this.dblJg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJg.Name = "dblJg";
            this.dblJg.NullString = "";
            this.dblJg.Size = new System.Drawing.Size(158, 28);
            this.dblJg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJg.TabIndex = 22;
            this.dblJg.Text = "1.00";
            // 
            // lblQllx
            // 
            this.lblQllx.AutoSize = true;
            this.lblQllx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQllx.Location = new System.Drawing.Point(273, 80);
            this.lblQllx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQllx.Name = "lblQllx";
            this.lblQllx.Size = new System.Drawing.Size(53, 25);
            this.lblQllx.TabIndex = 23;
            this.lblQllx.Text = "权利类型";
            // 
            // cmbQllx
            // 
            this.cmbQllx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQllx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQllx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQllx.EnableTouchMode = true;
            this.cmbQllx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQllx.Location = new System.Drawing.Point(332, 73);
            this.cmbQllx.Name = "cmbQllx";
            this.cmbQllx.Size = new System.Drawing.Size(158, 20);
            this.cmbQllx.TabIndex = 24;
            // 
            // lblQlxz
            // 
            this.lblQlxz.AutoSize = true;
            this.lblQlxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlxz.Location = new System.Drawing.Point(273, 115);
            this.lblQlxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlxz.Name = "lblQlxz";
            this.lblQlxz.Size = new System.Drawing.Size(53, 25);
            this.lblQlxz.TabIndex = 25;
            this.lblQlxz.Text = "权利性质";
            // 
            // cmbQlxz
            // 
            this.cmbQlxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQlxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQlxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQlxz.EnableTouchMode = true;
            this.cmbQlxz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQlxz.Location = new System.Drawing.Point(332, 108);
            this.cmbQlxz.Name = "cmbQlxz";
            this.cmbQlxz.Size = new System.Drawing.Size(158, 20);
            this.cmbQlxz.TabIndex = 26;
            // 
            // lblQlsdfs
            // 
            this.lblQlsdfs.AutoSize = true;
            this.lblQlsdfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlsdfs.Location = new System.Drawing.Point(261, 150);
            this.lblQlsdfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlsdfs.Name = "lblQlsdfs";
            this.lblQlsdfs.Size = new System.Drawing.Size(65, 25);
            this.lblQlsdfs.TabIndex = 27;
            this.lblQlsdfs.Text = "权利设定方式";
            // 
            // cmbQlsdfs
            // 
            this.cmbQlsdfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQlsdfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQlsdfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQlsdfs.EnableTouchMode = true;
            this.cmbQlsdfs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQlsdfs.Location = new System.Drawing.Point(332, 143);
            this.cmbQlsdfs.Name = "cmbQlsdfs";
            this.cmbQlsdfs.Size = new System.Drawing.Size(158, 20);
            this.cmbQlsdfs.TabIndex = 28;
            // 
            // lblRjl
            // 
            this.lblRjl.AutoSize = true;
            this.lblRjl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRjl.Location = new System.Drawing.Point(285, 185);
            this.lblRjl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblRjl.Name = "lblRjl";
            this.lblRjl.Size = new System.Drawing.Size(41, 25);
            this.lblRjl.TabIndex = 29;
            this.lblRjl.Text = "容积率";
            // 
            // dblRjl
            // 
            this.dblRjl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblRjl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblRjl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblRjl.DoubleValue = 1D;
            this.dblRjl.EnableTouchMode = true;
            this.dblRjl.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblRjl.Location = new System.Drawing.Point(332, 178);
            this.dblRjl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblRjl.Name = "dblRjl";
            this.dblRjl.NullString = "";
            this.dblRjl.Size = new System.Drawing.Size(158, 28);
            this.dblRjl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblRjl.TabIndex = 30;
            this.dblRjl.Text = "1.00";
            // 
            // lblJzmd
            // 
            this.lblJzmd.AutoSize = true;
            this.lblJzmd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzmd.Location = new System.Drawing.Point(273, 220);
            this.lblJzmd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzmd.Name = "lblJzmd";
            this.lblJzmd.Size = new System.Drawing.Size(53, 25);
            this.lblJzmd.TabIndex = 31;
            this.lblJzmd.Text = "建筑密度";
            // 
            // dblJzmd
            // 
            this.dblJzmd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzmd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzmd.DoubleValue = 1D;
            this.dblJzmd.EnableTouchMode = true;
            this.dblJzmd.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzmd.Location = new System.Drawing.Point(332, 213);
            this.dblJzmd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzmd.Name = "dblJzmd";
            this.dblJzmd.NullString = "";
            this.dblJzmd.Size = new System.Drawing.Size(158, 28);
            this.dblJzmd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzmd.TabIndex = 32;
            this.dblJzmd.Text = "1.00";
            // 
            // lblJzxg
            // 
            this.lblJzxg.AutoSize = true;
            this.lblJzxg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzxg.Location = new System.Drawing.Point(273, 255);
            this.lblJzxg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzxg.Name = "lblJzxg";
            this.lblJzxg.Size = new System.Drawing.Size(53, 25);
            this.lblJzxg.TabIndex = 33;
            this.lblJzxg.Text = "建筑限高";
            // 
            // dblJzxg
            // 
            this.dblJzxg.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzxg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzxg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzxg.DoubleValue = 1D;
            this.dblJzxg.EnableTouchMode = true;
            this.dblJzxg.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzxg.Location = new System.Drawing.Point(332, 248);
            this.dblJzxg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzxg.Name = "dblJzxg";
            this.dblJzxg.NullString = "";
            this.dblJzxg.Size = new System.Drawing.Size(158, 28);
            this.dblJzxg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzxg.TabIndex = 34;
            this.dblJzxg.Text = "1.00";
            // 
            // lblZdszd
            // 
            this.lblZdszd.AutoSize = true;
            this.lblZdszd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdszd.Location = new System.Drawing.Point(255, 290);
            this.lblZdszd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdszd.Name = "lblZdszd";
            this.lblZdszd.Size = new System.Drawing.Size(71, 41);
            this.lblZdszd.TabIndex = 35;
            this.lblZdszd.Text = "宗地四至-东";
            // 
            // txtZdszd
            // 
            this.txtZdszd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdszd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdszd.EnableTouchMode = true;
            this.txtZdszd.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdszd.Location = new System.Drawing.Point(332, 283);
            this.txtZdszd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdszd.Name = "txtZdszd";
            this.txtZdszd.Size = new System.Drawing.Size(158, 28);
            this.txtZdszd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdszd.TabIndex = 36;
            // 
            // lblZdszn
            // 
            this.lblZdszn.AutoSize = true;
            this.lblZdszn.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdszn.Location = new System.Drawing.Point(504, 10);
            this.lblZdszn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdszn.Name = "lblZdszn";
            this.lblZdszn.Size = new System.Drawing.Size(71, 25);
            this.lblZdszn.TabIndex = 37;
            this.lblZdszn.Text = "宗地四至-南";
            // 
            // txtZdszn
            // 
            this.txtZdszn.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdszn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdszn.EnableTouchMode = true;
            this.txtZdszn.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdszn.Location = new System.Drawing.Point(581, 3);
            this.txtZdszn.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdszn.Name = "txtZdszn";
            this.txtZdszn.Size = new System.Drawing.Size(158, 28);
            this.txtZdszn.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdszn.TabIndex = 38;
            // 
            // lblZdszx
            // 
            this.lblZdszx.AutoSize = true;
            this.lblZdszx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdszx.Location = new System.Drawing.Point(504, 45);
            this.lblZdszx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdszx.Name = "lblZdszx";
            this.lblZdszx.Size = new System.Drawing.Size(71, 25);
            this.lblZdszx.TabIndex = 39;
            this.lblZdszx.Text = "宗地四至-西";
            // 
            // txtZdszx
            // 
            this.txtZdszx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdszx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdszx.EnableTouchMode = true;
            this.txtZdszx.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdszx.Location = new System.Drawing.Point(581, 38);
            this.txtZdszx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdszx.Name = "txtZdszx";
            this.txtZdszx.Size = new System.Drawing.Size(158, 28);
            this.txtZdszx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdszx.TabIndex = 40;
            // 
            // lblZdszb
            // 
            this.lblZdszb.AutoSize = true;
            this.lblZdszb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdszb.Location = new System.Drawing.Point(504, 80);
            this.lblZdszb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdszb.Name = "lblZdszb";
            this.lblZdszb.Size = new System.Drawing.Size(71, 25);
            this.lblZdszb.TabIndex = 41;
            this.lblZdszb.Text = "宗地四至-北";
            // 
            // txtZdszb
            // 
            this.txtZdszb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdszb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdszb.EnableTouchMode = true;
            this.txtZdszb.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdszb.Location = new System.Drawing.Point(581, 73);
            this.txtZdszb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdszb.Name = "txtZdszb";
            this.txtZdszb.Size = new System.Drawing.Size(158, 28);
            this.txtZdszb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdszb.TabIndex = 42;
            // 
            // lblZdt
            // 
            this.lblZdt.AutoSize = true;
            this.lblZdt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdt.Location = new System.Drawing.Point(534, 115);
            this.lblZdt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdt.Name = "lblZdt";
            this.lblZdt.Size = new System.Drawing.Size(41, 25);
            this.lblZdt.TabIndex = 43;
            this.lblZdt.Text = "宗地图";
            // 
            // txtZdt
            // 
            this.txtZdt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdt.EnableTouchMode = true;
            this.txtZdt.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdt.Location = new System.Drawing.Point(581, 108);
            this.txtZdt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdt.Name = "txtZdt";
            this.txtZdt.Size = new System.Drawing.Size(158, 28);
            this.txtZdt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdt.TabIndex = 44;
            // 
            // lblTfh
            // 
            this.lblTfh.AutoSize = true;
            this.lblTfh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTfh.Location = new System.Drawing.Point(534, 150);
            this.lblTfh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTfh.Name = "lblTfh";
            this.lblTfh.Size = new System.Drawing.Size(41, 25);
            this.lblTfh.TabIndex = 45;
            this.lblTfh.Text = "图幅号";
            // 
            // txtTfh
            // 
            this.txtTfh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTfh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTfh.EnableTouchMode = true;
            this.txtTfh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTfh.Location = new System.Drawing.Point(581, 143);
            this.txtTfh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTfh.Name = "txtTfh";
            this.txtTfh.Size = new System.Drawing.Size(158, 28);
            this.txtTfh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTfh.TabIndex = 46;
            // 
            // lblDjh
            // 
            this.lblDjh.AutoSize = true;
            this.lblDjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjh.Location = new System.Drawing.Point(534, 185);
            this.lblDjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjh.Name = "lblDjh";
            this.lblDjh.Size = new System.Drawing.Size(41, 25);
            this.lblDjh.TabIndex = 47;
            this.lblDjh.Text = "地籍号";
            // 
            // txtDjh
            // 
            this.txtDjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjh.EnableTouchMode = true;
            this.txtDjh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjh.Location = new System.Drawing.Point(581, 178);
            this.txtDjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjh.Name = "txtDjh";
            this.txtDjh.Size = new System.Drawing.Size(158, 28);
            this.txtDjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjh.TabIndex = 48;
            // 
            // lblDah
            // 
            this.lblDah.AutoSize = true;
            this.lblDah.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDah.Location = new System.Drawing.Point(534, 220);
            this.lblDah.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDah.Name = "lblDah";
            this.lblDah.Size = new System.Drawing.Size(41, 25);
            this.lblDah.TabIndex = 49;
            this.lblDah.Text = "档案号";
            // 
            // txtDah
            // 
            this.txtDah.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDah.EnableTouchMode = true;
            this.txtDah.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDah.Location = new System.Drawing.Point(581, 213);
            this.txtDah.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDah.Name = "txtDah";
            this.txtDah.Size = new System.Drawing.Size(158, 28);
            this.txtDah.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDah.TabIndex = 50;
            // 
            // lblBz
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(546, 255);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(29, 25);
            this.lblBz.TabIndex = 51;
            this.lblBz.Text = "备注";
            // 
            // txtBz
            // 
            this.txtBz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBz.EnableTouchMode = true;
            this.txtBz.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBz.Location = new System.Drawing.Point(581, 248);
            this.txtBz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(158, 28);
            this.txtBz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBz.TabIndex = 52;
            // 
            // lblZt
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(546, 290);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(29, 41);
            this.lblZt.TabIndex = 53;
            this.lblZt.Text = "状态";
            // 
            // cmbZt
            // 
            this.cmbZt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.EnableTouchMode = true;
            this.cmbZt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.Location = new System.Drawing.Point(581, 283);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(158, 20);
            this.cmbZt.TabIndex = 54;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZddm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZddm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZdtzm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbZdtzm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtZl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZdmj, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblZdmj, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMjdw, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbMjdw, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYt, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtYt, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblJg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblJg, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQllx, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbQllx, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQlxz, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbQlxz, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQlsdfs, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbQlsdfs, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblRjl, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblRjl, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJzmd, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblJzmd, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJzxg, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblJzxg, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZdszd, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtZdszd, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblZdszn, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtZdszn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdszx, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZdszx, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZdszb, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZdszb, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZdt, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZdt, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTfh, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTfh, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjh, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDjh, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDah, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDah, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbZt, 7, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 331);
            this.tableLayoutPanel1.TabIndex = 55;
            // 
            // ucZdjbxx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucZdjbxx";
            this.Size = new System.Drawing.Size(750, 331);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZdtzm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlsdfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblRjl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzxg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdszb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTfh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZdtzm;	
        private System.Windows.Forms.Label lblZdtzm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZl;	
        private System.Windows.Forms.Label lblZl;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZdmj;	
        private System.Windows.Forms.Label lblZdmj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbMjdw;	
        private System.Windows.Forms.Label lblMjdw;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYt;	
        private System.Windows.Forms.Label lblYt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDj;	
        private System.Windows.Forms.Label lblDj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJg;	
        private System.Windows.Forms.Label lblJg;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQllx;	
        private System.Windows.Forms.Label lblQllx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQlxz;	
        private System.Windows.Forms.Label lblQlxz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQlsdfs;	
        private System.Windows.Forms.Label lblQlsdfs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblRjl;	
        private System.Windows.Forms.Label lblRjl;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzmd;	
        private System.Windows.Forms.Label lblJzmd;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzxg;	
        private System.Windows.Forms.Label lblJzxg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdszd;	
        private System.Windows.Forms.Label lblZdszd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdszn;	
        private System.Windows.Forms.Label lblZdszn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdszx;	
        private System.Windows.Forms.Label lblZdszx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdszb;	
        private System.Windows.Forms.Label lblZdszb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdt;	
        private System.Windows.Forms.Label lblZdt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTfh;	
        private System.Windows.Forms.Label lblTfh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjh;	
        private System.Windows.Forms.Label lblDjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDah;	
        private System.Windows.Forms.Label lblDah;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZt;	
        private System.Windows.Forms.Label lblZt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}