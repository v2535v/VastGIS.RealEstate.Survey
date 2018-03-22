using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZrz
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
            this.lblZddm = new System.Windows.Forms.Label();
            this.txtZddm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZrzh = new System.Windows.Forms.Label();
            this.txtZrzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXmmc = new System.Windows.Forms.Label();
            this.txtXmmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJzwmc = new System.Windows.Forms.Label();
            this.txtJzwmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJgrq = new System.Windows.Forms.Label();
            this.datJgrq = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblJzwgd = new System.Windows.Forms.Label();
            this.dblJzwgd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZzdmj = new System.Windows.Forms.Label();
            this.dblZzdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZydmj = new System.Windows.Forms.Label();
            this.dblZydmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcjzmj = new System.Windows.Forms.Label();
            this.dblYcjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScjzmj = new System.Windows.Forms.Label();
            this.dblScjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZcs = new System.Windows.Forms.Label();
            this.intZcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblDscs = new System.Windows.Forms.Label();
            this.intDscs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblDxcs = new System.Windows.Forms.Label();
            this.intDxcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblDxsd = new System.Windows.Forms.Label();
            this.dblDxsd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblGhyt = new System.Windows.Forms.Label();
            this.cmbGhyt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwjg = new System.Windows.Forms.Label();
            this.cmbFwjg = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZts = new System.Windows.Forms.Label();
            this.intZts = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblJzwjbyt = new System.Windows.Forms.Label();
            this.txtJzwjbyt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDah = new System.Windows.Forms.Label();
            this.txtDah = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.cmbZt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzwmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgrq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzwgd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZzdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZydmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDscs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzwjbyt)).BeginInit();
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
            // lblBdcdyh
            // 
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(12, 80);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(65, 25);
            this.lblBdcdyh.TabIndex = 5;
            this.lblBdcdyh.Text = "不动产单元号";
            // 
            // txtBdcdyh
            // 
            this.txtBdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdyh.EnableTouchMode = true;
            this.txtBdcdyh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdyh.Location = new System.Drawing.Point(83, 73);
            this.txtBdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdyh.Name = "txtBdcdyh";
            this.txtBdcdyh.Size = new System.Drawing.Size(158, 28);
            this.txtBdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdyh.TabIndex = 6;
            // 
            // lblZddm
            // 
            this.lblZddm.AutoSize = true;
            this.lblZddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZddm.Location = new System.Drawing.Point(24, 115);
            this.lblZddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZddm.Name = "lblZddm";
            this.lblZddm.Size = new System.Drawing.Size(53, 25);
            this.lblZddm.TabIndex = 7;
            this.lblZddm.Text = "宗地代码";
            // 
            // txtZddm
            // 
            this.txtZddm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZddm.EnableTouchMode = true;
            this.txtZddm.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZddm.Location = new System.Drawing.Point(83, 108);
            this.txtZddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZddm.Name = "txtZddm";
            this.txtZddm.Size = new System.Drawing.Size(158, 28);
            this.txtZddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZddm.TabIndex = 8;
            // 
            // lblZrzh
            // 
            this.lblZrzh.AutoSize = true;
            this.lblZrzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZrzh.Location = new System.Drawing.Point(24, 150);
            this.lblZrzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZrzh.Name = "lblZrzh";
            this.lblZrzh.Size = new System.Drawing.Size(53, 25);
            this.lblZrzh.TabIndex = 9;
            this.lblZrzh.Text = "自然幢号";
            // 
            // txtZrzh
            // 
            this.txtZrzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZrzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZrzh.EnableTouchMode = true;
            this.txtZrzh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZrzh.Location = new System.Drawing.Point(83, 143);
            this.txtZrzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZrzh.Name = "txtZrzh";
            this.txtZrzh.Size = new System.Drawing.Size(158, 28);
            this.txtZrzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZrzh.TabIndex = 10;
            // 
            // lblXmmc
            // 
            this.lblXmmc.AutoSize = true;
            this.lblXmmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXmmc.Location = new System.Drawing.Point(24, 185);
            this.lblXmmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXmmc.Name = "lblXmmc";
            this.lblXmmc.Size = new System.Drawing.Size(53, 25);
            this.lblXmmc.TabIndex = 11;
            this.lblXmmc.Text = "项目名称";
            // 
            // txtXmmc
            // 
            this.txtXmmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXmmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXmmc.EnableTouchMode = true;
            this.txtXmmc.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXmmc.Location = new System.Drawing.Point(83, 178);
            this.txtXmmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXmmc.Name = "txtXmmc";
            this.txtXmmc.Size = new System.Drawing.Size(158, 28);
            this.txtXmmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXmmc.TabIndex = 12;
            // 
            // lblJzwmc
            // 
            this.lblJzwmc.AutoSize = true;
            this.lblJzwmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzwmc.Location = new System.Drawing.Point(12, 220);
            this.lblJzwmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzwmc.Name = "lblJzwmc";
            this.lblJzwmc.Size = new System.Drawing.Size(65, 25);
            this.lblJzwmc.TabIndex = 13;
            this.lblJzwmc.Text = "建筑物名称";
            // 
            // txtJzwmc
            // 
            this.txtJzwmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJzwmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJzwmc.EnableTouchMode = true;
            this.txtJzwmc.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJzwmc.Location = new System.Drawing.Point(83, 213);
            this.txtJzwmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJzwmc.Name = "txtJzwmc";
            this.txtJzwmc.Size = new System.Drawing.Size(158, 28);
            this.txtJzwmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJzwmc.TabIndex = 14;
            // 
            // lblJgrq
            // 
            this.lblJgrq.AutoSize = true;
            this.lblJgrq.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgrq.Location = new System.Drawing.Point(24, 255);
            this.lblJgrq.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgrq.Name = "lblJgrq";
            this.lblJgrq.Size = new System.Drawing.Size(53, 41);
            this.lblJgrq.TabIndex = 15;
            this.lblJgrq.Text = "竣工日期";
            // 
            // datJgrq
            // 
            this.datJgrq.BorderColor = System.Drawing.Color.Empty;
            this.datJgrq.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJgrq.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJgrq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJgrq.DropDownImage = null;
            this.datJgrq.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.datJgrq.EnableTouchMode = true;
            this.datJgrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJgrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJgrq.Location = new System.Drawing.Point(83, 248);
            this.datJgrq.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJgrq.MinValue = new System.DateTime(((long)(0)));
            this.datJgrq.Name = "datJgrq";
            this.datJgrq.Size = new System.Drawing.Size(158, 45);
            this.datJgrq.TabIndex = 16;
            this.datJgrq.UseCurrentCulture = true;
            this.datJgrq.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            // 
            // lblJzwgd
            // 
            this.lblJzwgd.AutoSize = true;
            this.lblJzwgd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzwgd.Location = new System.Drawing.Point(261, 10);
            this.lblJzwgd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzwgd.Name = "lblJzwgd";
            this.lblJzwgd.Size = new System.Drawing.Size(65, 25);
            this.lblJzwgd.TabIndex = 17;
            this.lblJzwgd.Text = "建筑物高度";
            // 
            // dblJzwgd
            // 
            this.dblJzwgd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzwgd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzwgd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzwgd.DoubleValue = 1D;
            this.dblJzwgd.EnableTouchMode = true;
            this.dblJzwgd.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzwgd.Location = new System.Drawing.Point(332, 3);
            this.dblJzwgd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzwgd.Name = "dblJzwgd";
            this.dblJzwgd.NullString = "";
            this.dblJzwgd.Size = new System.Drawing.Size(158, 28);
            this.dblJzwgd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzwgd.TabIndex = 18;
            this.dblJzwgd.Text = "1.00";
            // 
            // lblZzdmj
            // 
            this.lblZzdmj.AutoSize = true;
            this.lblZzdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZzdmj.Location = new System.Drawing.Point(261, 45);
            this.lblZzdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZzdmj.Name = "lblZzdmj";
            this.lblZzdmj.Size = new System.Drawing.Size(65, 25);
            this.lblZzdmj.TabIndex = 19;
            this.lblZzdmj.Text = "幢占地面积";
            // 
            // dblZzdmj
            // 
            this.dblZzdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZzdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZzdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZzdmj.DoubleValue = 1D;
            this.dblZzdmj.EnableTouchMode = true;
            this.dblZzdmj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZzdmj.Location = new System.Drawing.Point(332, 38);
            this.dblZzdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZzdmj.Name = "dblZzdmj";
            this.dblZzdmj.NullString = "";
            this.dblZzdmj.Size = new System.Drawing.Size(158, 28);
            this.dblZzdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZzdmj.TabIndex = 20;
            this.dblZzdmj.Text = "1.00";
            // 
            // lblZydmj
            // 
            this.lblZydmj.AutoSize = true;
            this.lblZydmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZydmj.Location = new System.Drawing.Point(261, 80);
            this.lblZydmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZydmj.Name = "lblZydmj";
            this.lblZydmj.Size = new System.Drawing.Size(65, 25);
            this.lblZydmj.TabIndex = 21;
            this.lblZydmj.Text = "幢用地面积";
            // 
            // dblZydmj
            // 
            this.dblZydmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZydmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZydmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZydmj.DoubleValue = 1D;
            this.dblZydmj.EnableTouchMode = true;
            this.dblZydmj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZydmj.Location = new System.Drawing.Point(332, 73);
            this.dblZydmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZydmj.Name = "dblZydmj";
            this.dblZydmj.NullString = "";
            this.dblZydmj.Size = new System.Drawing.Size(158, 28);
            this.dblZydmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZydmj.TabIndex = 22;
            this.dblZydmj.Text = "1.00";
            // 
            // lblYcjzmj
            // 
            this.lblYcjzmj.AutoSize = true;
            this.lblYcjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcjzmj.Location = new System.Drawing.Point(261, 115);
            this.lblYcjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcjzmj.Name = "lblYcjzmj";
            this.lblYcjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblYcjzmj.TabIndex = 23;
            this.lblYcjzmj.Text = "预测建筑面积";
            // 
            // dblYcjzmj
            // 
            this.dblYcjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcjzmj.DoubleValue = 1D;
            this.dblYcjzmj.EnableTouchMode = true;
            this.dblYcjzmj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcjzmj.Location = new System.Drawing.Point(332, 108);
            this.dblYcjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcjzmj.Name = "dblYcjzmj";
            this.dblYcjzmj.NullString = "";
            this.dblYcjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblYcjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcjzmj.TabIndex = 24;
            this.dblYcjzmj.Text = "1.00";
            // 
            // lblScjzmj
            // 
            this.lblScjzmj.AutoSize = true;
            this.lblScjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScjzmj.Location = new System.Drawing.Point(261, 150);
            this.lblScjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScjzmj.Name = "lblScjzmj";
            this.lblScjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblScjzmj.TabIndex = 25;
            this.lblScjzmj.Text = "实测建筑面积";
            // 
            // dblScjzmj
            // 
            this.dblScjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScjzmj.DoubleValue = 1D;
            this.dblScjzmj.EnableTouchMode = true;
            this.dblScjzmj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScjzmj.Location = new System.Drawing.Point(332, 143);
            this.dblScjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScjzmj.Name = "dblScjzmj";
            this.dblScjzmj.NullString = "";
            this.dblScjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblScjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScjzmj.TabIndex = 26;
            this.dblScjzmj.Text = "1.00";
            // 
            // lblZcs
            // 
            this.lblZcs.AutoSize = true;
            this.lblZcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZcs.Location = new System.Drawing.Point(285, 185);
            this.lblZcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZcs.Name = "lblZcs";
            this.lblZcs.Size = new System.Drawing.Size(41, 25);
            this.lblZcs.TabIndex = 27;
            this.lblZcs.Text = "总层数";
            // 
            // intZcs
            // 
            this.intZcs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZcs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZcs.EnableTouchMode = true;
            this.intZcs.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZcs.IntegerValue = ((long)(0));
            this.intZcs.Location = new System.Drawing.Point(332, 178);
            this.intZcs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZcs.Name = "intZcs";
            this.intZcs.NullString = "";
            this.intZcs.Size = new System.Drawing.Size(158, 28);
            this.intZcs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZcs.TabIndex = 28;
            this.intZcs.Text = "0";
            // 
            // lblDscs
            // 
            this.lblDscs.AutoSize = true;
            this.lblDscs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDscs.Location = new System.Drawing.Point(273, 220);
            this.lblDscs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDscs.Name = "lblDscs";
            this.lblDscs.Size = new System.Drawing.Size(53, 25);
            this.lblDscs.TabIndex = 29;
            this.lblDscs.Text = "地上层数";
            // 
            // intDscs
            // 
            this.intDscs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDscs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDscs.EnableTouchMode = true;
            this.intDscs.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDscs.IntegerValue = ((long)(0));
            this.intDscs.Location = new System.Drawing.Point(332, 213);
            this.intDscs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDscs.Name = "intDscs";
            this.intDscs.NullString = "";
            this.intDscs.Size = new System.Drawing.Size(158, 28);
            this.intDscs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDscs.TabIndex = 30;
            this.intDscs.Text = "0";
            // 
            // lblDxcs
            // 
            this.lblDxcs.AutoSize = true;
            this.lblDxcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDxcs.Location = new System.Drawing.Point(273, 255);
            this.lblDxcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDxcs.Name = "lblDxcs";
            this.lblDxcs.Size = new System.Drawing.Size(53, 41);
            this.lblDxcs.TabIndex = 31;
            this.lblDxcs.Text = "地下层数";
            // 
            // intDxcs
            // 
            this.intDxcs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDxcs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDxcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDxcs.EnableTouchMode = true;
            this.intDxcs.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDxcs.IntegerValue = ((long)(0));
            this.intDxcs.Location = new System.Drawing.Point(332, 248);
            this.intDxcs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDxcs.Name = "intDxcs";
            this.intDxcs.NullString = "";
            this.intDxcs.Size = new System.Drawing.Size(158, 28);
            this.intDxcs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDxcs.TabIndex = 32;
            this.intDxcs.Text = "0";
            // 
            // lblDxsd
            // 
            this.lblDxsd.AutoSize = true;
            this.lblDxsd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDxsd.Location = new System.Drawing.Point(522, 10);
            this.lblDxsd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDxsd.Name = "lblDxsd";
            this.lblDxsd.Size = new System.Drawing.Size(53, 25);
            this.lblDxsd.TabIndex = 33;
            this.lblDxsd.Text = "地下深度";
            // 
            // dblDxsd
            // 
            this.dblDxsd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDxsd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblDxsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblDxsd.DoubleValue = 1D;
            this.dblDxsd.EnableTouchMode = true;
            this.dblDxsd.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDxsd.Location = new System.Drawing.Point(581, 3);
            this.dblDxsd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDxsd.Name = "dblDxsd";
            this.dblDxsd.NullString = "";
            this.dblDxsd.Size = new System.Drawing.Size(158, 28);
            this.dblDxsd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDxsd.TabIndex = 34;
            this.dblDxsd.Text = "1.00";
            // 
            // lblGhyt
            // 
            this.lblGhyt.AutoSize = true;
            this.lblGhyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGhyt.Location = new System.Drawing.Point(522, 45);
            this.lblGhyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGhyt.Name = "lblGhyt";
            this.lblGhyt.Size = new System.Drawing.Size(53, 25);
            this.lblGhyt.TabIndex = 35;
            this.lblGhyt.Text = "规划用途";
            // 
            // cmbGhyt
            // 
            this.cmbGhyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGhyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGhyt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGhyt.EnableTouchMode = true;
            this.cmbGhyt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGhyt.Location = new System.Drawing.Point(581, 38);
            this.cmbGhyt.Name = "cmbGhyt";
            this.cmbGhyt.Size = new System.Drawing.Size(158, 20);
            this.cmbGhyt.TabIndex = 36;
            // 
            // lblFwjg
            // 
            this.lblFwjg.AutoSize = true;
            this.lblFwjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg.Location = new System.Drawing.Point(522, 80);
            this.lblFwjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg.Name = "lblFwjg";
            this.lblFwjg.Size = new System.Drawing.Size(53, 25);
            this.lblFwjg.TabIndex = 37;
            this.lblFwjg.Text = "房屋结构";
            // 
            // cmbFwjg
            // 
            this.cmbFwjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg.EnableTouchMode = true;
            this.cmbFwjg.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg.Location = new System.Drawing.Point(581, 73);
            this.cmbFwjg.Name = "cmbFwjg";
            this.cmbFwjg.Size = new System.Drawing.Size(158, 20);
            this.cmbFwjg.TabIndex = 38;
            // 
            // lblZts
            // 
            this.lblZts.AutoSize = true;
            this.lblZts.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZts.Location = new System.Drawing.Point(534, 115);
            this.lblZts.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZts.Name = "lblZts";
            this.lblZts.Size = new System.Drawing.Size(41, 25);
            this.lblZts.TabIndex = 39;
            this.lblZts.Text = "总套数";
            // 
            // intZts
            // 
            this.intZts.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZts.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZts.EnableTouchMode = true;
            this.intZts.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZts.IntegerValue = ((long)(0));
            this.intZts.Location = new System.Drawing.Point(581, 108);
            this.intZts.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZts.Name = "intZts";
            this.intZts.NullString = "";
            this.intZts.Size = new System.Drawing.Size(158, 28);
            this.intZts.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZts.TabIndex = 40;
            this.intZts.Text = "0";
            // 
            // lblJzwjbyt
            // 
            this.lblJzwjbyt.AutoSize = true;
            this.lblJzwjbyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzwjbyt.Location = new System.Drawing.Point(510, 150);
            this.lblJzwjbyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzwjbyt.Name = "lblJzwjbyt";
            this.lblJzwjbyt.Size = new System.Drawing.Size(65, 25);
            this.lblJzwjbyt.TabIndex = 41;
            this.lblJzwjbyt.Text = "建筑物基本用途";
            // 
            // txtJzwjbyt
            // 
            this.txtJzwjbyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJzwjbyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJzwjbyt.EnableTouchMode = true;
            this.txtJzwjbyt.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJzwjbyt.Location = new System.Drawing.Point(581, 143);
            this.txtJzwjbyt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJzwjbyt.Name = "txtJzwjbyt";
            this.txtJzwjbyt.Size = new System.Drawing.Size(158, 28);
            this.txtJzwjbyt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJzwjbyt.TabIndex = 42;
            // 
            // lblDah
            // 
            this.lblDah.AutoSize = true;
            this.lblDah.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDah.Location = new System.Drawing.Point(534, 185);
            this.lblDah.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDah.Name = "lblDah";
            this.lblDah.Size = new System.Drawing.Size(41, 25);
            this.lblDah.TabIndex = 43;
            this.lblDah.Text = "档案号";
            // 
            // txtDah
            // 
            this.txtDah.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDah.EnableTouchMode = true;
            this.txtDah.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDah.Location = new System.Drawing.Point(581, 178);
            this.txtDah.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDah.Name = "txtDah";
            this.txtDah.Size = new System.Drawing.Size(158, 28);
            this.txtDah.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDah.TabIndex = 44;
            // 
            // lblBz
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(546, 220);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(29, 25);
            this.lblBz.TabIndex = 45;
            this.lblBz.Text = "备注";
            // 
            // txtBz
            // 
            this.txtBz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBz.EnableTouchMode = true;
            this.txtBz.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBz.Location = new System.Drawing.Point(581, 213);
            this.txtBz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(158, 28);
            this.txtBz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBz.TabIndex = 46;
            // 
            // lblZt
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(546, 255);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(29, 41);
            this.lblZt.TabIndex = 47;
            this.lblZt.Text = "状态";
            // 
            // cmbZt
            // 
            this.cmbZt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.EnableTouchMode = true;
            this.cmbZt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.Location = new System.Drawing.Point(581, 248);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(158, 20);
            this.cmbZt.TabIndex = 48;
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
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZddm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZddm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZrzh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZrzh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblXmmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtXmmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJzwmc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtJzwmc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJgrq, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.datJgrq, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblJzwgd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblJzwgd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZzdmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblZzdmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZydmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblZydmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYcjzmj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblYcjzmj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblScjzmj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblScjzmj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZcs, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.intZcs, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDscs, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.intDscs, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDxcs, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.intDxcs, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDxsd, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblDxsd, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGhyt, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbGhyt, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZts, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.intZts, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJzwjbyt, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtJzwjbyt, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDah, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDah, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbZt, 7, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 296);
            this.tableLayoutPanel1.TabIndex = 49;
            // 
            // ucZrz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucZrz";
            this.Size = new System.Drawing.Size(750, 296);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzwmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgrq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzwgd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZzdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZydmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDscs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzwjbyt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZddm;	
        private System.Windows.Forms.Label lblZddm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZrzh;	
        private System.Windows.Forms.Label lblZrzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXmmc;	
        private System.Windows.Forms.Label lblXmmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJzwmc;	
        private System.Windows.Forms.Label lblJzwmc;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJgrq;	
        private System.Windows.Forms.Label lblJgrq;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzwgd;	
        private System.Windows.Forms.Label lblJzwgd;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZzdmj;	
        private System.Windows.Forms.Label lblZzdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZydmj;	
        private System.Windows.Forms.Label lblZydmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcjzmj;	
        private System.Windows.Forms.Label lblYcjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScjzmj;	
        private System.Windows.Forms.Label lblScjzmj;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZcs;	
        private System.Windows.Forms.Label lblZcs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDscs;	
        private System.Windows.Forms.Label lblDscs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDxcs;	
        private System.Windows.Forms.Label lblDxcs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDxsd;	
        private System.Windows.Forms.Label lblDxsd;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGhyt;	
        private System.Windows.Forms.Label lblGhyt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg;	
        private System.Windows.Forms.Label lblFwjg;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZts;	
        private System.Windows.Forms.Label lblZts;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJzwjbyt;	
        private System.Windows.Forms.Label lblJzwjbyt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDah;	
        private System.Windows.Forms.Label lblDah;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZt;	
        private System.Windows.Forms.Label lblZt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}