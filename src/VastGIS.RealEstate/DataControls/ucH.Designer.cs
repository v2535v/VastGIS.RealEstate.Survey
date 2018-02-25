using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucH
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
            this.lblBdcdyh = new System.Windows.Forms.Label();
            this.txtBdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFwbm = new System.Windows.Forms.Label();
            this.txtFwbm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZrzh = new System.Windows.Forms.Label();
            this.txtZrzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLjzh = new System.Windows.Forms.Label();
            this.txtLjzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCh = new System.Windows.Forms.Label();
            this.txtCh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZl = new System.Windows.Forms.Label();
            this.txtZl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMjdw = new System.Windows.Forms.Label();
            this.cmbMjdw = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSjcs = new System.Windows.Forms.Label();
            this.dblSjcs = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblHh = new System.Windows.Forms.Label();
            this.intHh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblShbw = new System.Windows.Forms.Label();
            this.txtShbw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHx = new System.Windows.Forms.Label();
            this.cmbHx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblHxjg = new System.Windows.Forms.Label();
            this.cmbHxjg = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt1 = new System.Windows.Forms.Label();
            this.cmbFwyt1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt2 = new System.Windows.Forms.Label();
            this.cmbFwyt2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt3 = new System.Windows.Forms.Label();
            this.cmbFwyt3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYcjzmj = new System.Windows.Forms.Label();
            this.dblYcjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYctnjzmj = new System.Windows.Forms.Label();
            this.dblYctnjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcftjzmj = new System.Windows.Forms.Label();
            this.dblYcftjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcdxbfjzmj = new System.Windows.Forms.Label();
            this.dblYcdxbfjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcqtjzmj = new System.Windows.Forms.Label();
            this.dblYcqtjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcftxs = new System.Windows.Forms.Label();
            this.dblYcftxs = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScjzmj = new System.Windows.Forms.Label();
            this.dblScjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSctnjzmj = new System.Windows.Forms.Label();
            this.dblSctnjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScftjzmj = new System.Windows.Forms.Label();
            this.dblScftjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScdxbfjzmj = new System.Windows.Forms.Label();
            this.dblScdxbfjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScqtjzmj = new System.Windows.Forms.Label();
            this.dblScqtjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScftxs = new System.Windows.Forms.Label();
            this.dblScftxs = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblGytdmj = new System.Windows.Forms.Label();
            this.dblGytdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFttdmj = new System.Windows.Forms.Label();
            this.dblFttdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblDytdmj = new System.Windows.Forms.Label();
            this.dblDytdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFwlx = new System.Windows.Forms.Label();
            this.cmbFwlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwxz = new System.Windows.Forms.Label();
            this.cmbFwxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFcfht = new System.Windows.Forms.Label();
            this.txtFcfht = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.cmbZt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFwbm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLjzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSjcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intHh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShbw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHxjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYctnjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcftjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcdxbfjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcqtjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcftxs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSctnjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScftjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScdxbfjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScqtjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScftxs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGytdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDytdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFcfht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).BeginInit();
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
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdyh.TabIndex = 3;
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
            this.txtBdcdyh.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblFwbm.AutoSize = true;
            this.lblFwbm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwbm.Location = new System.Drawing.Point(0,0);
            this.lblFwbm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwbm.Name = "lblFwbm";
            this.lblFwbm.Size = new System.Drawing.Size(41, 20);
            this.lblFwbm.TabIndex = 5;
            this.lblFwbm.Text = "房屋编码";
            // 
            // txtFwbm
            // 
            this.txtFwbm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFwbm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFwbm.EnableTouchMode = true;
            this.txtFwbm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFwbm.Location =  new System.Drawing.Point(0,0);
            this.txtFwbm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFwbm.Name = "txtFwbm";
            this.txtFwbm.Size = new System.Drawing.Size(152, 28);
            this.txtFwbm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFwbm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 7;
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
            this.txtYsdm.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblZrzh.AutoSize = true;
            this.lblZrzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZrzh.Location = new System.Drawing.Point(0,0);
            this.lblZrzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZrzh.Name = "lblZrzh";
            this.lblZrzh.Size = new System.Drawing.Size(41, 20);
            this.lblZrzh.TabIndex = 9;
            this.lblZrzh.Text = "自然幢号";
            // 
            // txtZrzh
            // 
            this.txtZrzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZrzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZrzh.EnableTouchMode = true;
            this.txtZrzh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZrzh.Location =  new System.Drawing.Point(0,0);
            this.txtZrzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZrzh.Name = "txtZrzh";
            this.txtZrzh.Size = new System.Drawing.Size(152, 28);
            this.txtZrzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZrzh.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblLjzh.AutoSize = true;
            this.lblLjzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLjzh.Location = new System.Drawing.Point(0,0);
            this.lblLjzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLjzh.Name = "lblLjzh";
            this.lblLjzh.Size = new System.Drawing.Size(41, 20);
            this.lblLjzh.TabIndex = 11;
            this.lblLjzh.Text = "逻辑幢号";
            // 
            // txtLjzh
            // 
            this.txtLjzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLjzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLjzh.EnableTouchMode = true;
            this.txtLjzh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLjzh.Location =  new System.Drawing.Point(0,0);
            this.txtLjzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLjzh.Name = "txtLjzh";
            this.txtLjzh.Size = new System.Drawing.Size(152, 28);
            this.txtLjzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLjzh.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCh.Location = new System.Drawing.Point(0,0);
            this.lblCh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(41, 20);
            this.lblCh.TabIndex = 13;
            this.lblCh.Text = "层号";
            // 
            // txtCh
            // 
            this.txtCh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCh.EnableTouchMode = true;
            this.txtCh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCh.Location =  new System.Drawing.Point(0,0);
            this.txtCh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(152, 28);
            this.txtCh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCh.TabIndex = 14;
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
            this.lblSjcs.AutoSize = true;
            this.lblSjcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjcs.Location = new System.Drawing.Point(0,0);
            this.lblSjcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjcs.Name = "lblSjcs";
            this.lblSjcs.Size = new System.Drawing.Size(41, 20);
            this.lblSjcs.TabIndex = 19;
            this.lblSjcs.Text = "实际层数";
            // 
            // dblSjcs
            // 
            this.dblSjcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSjcs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSjcs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSjcs.DoubleValue = 1D;
            this.dblSjcs.EnableTouchMode = true;
            this.dblSjcs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSjcs.Location =  new System.Drawing.Point(0,0);
            this.dblSjcs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSjcs.Name = "dblSjcs";
            this.dblSjcs.NullString = "";
            this.dblSjcs.Size = new System.Drawing.Size(152, 28);
            this.dblSjcs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSjcs.TabIndex = 20;
            this.dblSjcs.Text = "1.00";
            // 
            // lblID
            // 
            this.lblHh.AutoSize = true;
            this.lblHh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHh.Location = new System.Drawing.Point(0,0);
            this.lblHh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHh.Name = "lblHh";
            this.lblHh.Size = new System.Drawing.Size(41, 20);
            this.lblHh.TabIndex = 21;
            this.lblHh.Text = "户号";
            // 
            // intHh
            // 
            this.intHh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intHh.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intHh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intHh.EnableTouchMode = true;
            this.intHh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intHh.IntegerValue = ((long)(0));
            this.intHh.Location = new System.Drawing.Point(0,0);
            this.intHh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intHh.Name = "intHh";
            this.intHh.NullString = "";
            this.intHh.Size = new System.Drawing.Size(152, 28);
            this.intHh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intHh.TabIndex = 22;
            this.intHh.Text = "0";
            // 
            // lblID
            // 
            this.lblShbw.AutoSize = true;
            this.lblShbw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblShbw.Location = new System.Drawing.Point(0,0);
            this.lblShbw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShbw.Name = "lblShbw";
            this.lblShbw.Size = new System.Drawing.Size(41, 20);
            this.lblShbw.TabIndex = 23;
            this.lblShbw.Text = "室号部位";
            // 
            // txtShbw
            // 
            this.txtShbw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShbw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtShbw.EnableTouchMode = true;
            this.txtShbw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShbw.Location =  new System.Drawing.Point(0,0);
            this.txtShbw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtShbw.Name = "txtShbw";
            this.txtShbw.Size = new System.Drawing.Size(152, 28);
            this.txtShbw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtShbw.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblHx.AutoSize = true;
            this.lblHx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHx.Location = new System.Drawing.Point(0,0);
            this.lblHx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHx.Name = "lblHx";
            this.lblHx.Size = new System.Drawing.Size(41, 20);
            this.lblHx.TabIndex = 25;
            this.lblHx.Text = "户型";
            // 
            // cmbHx
            // 
            this.cmbHx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbHx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHx.EnableTouchMode = true;
            this.cmbHx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHx.Location =  new System.Drawing.Point(0,0);
            this.cmbHx.Name = "cmbHx";
            this.cmbHx.Size = new System.Drawing.Size(152, 20);
            this.cmbHx.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblHxjg.AutoSize = true;
            this.lblHxjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHxjg.Location = new System.Drawing.Point(0,0);
            this.lblHxjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHxjg.Name = "lblHxjg";
            this.lblHxjg.Size = new System.Drawing.Size(41, 20);
            this.lblHxjg.TabIndex = 27;
            this.lblHxjg.Text = "户型结构";
            // 
            // cmbHxjg
            // 
            this.cmbHxjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHxjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbHxjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHxjg.EnableTouchMode = true;
            this.cmbHxjg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHxjg.Location =  new System.Drawing.Point(0,0);
            this.cmbHxjg.Name = "cmbHxjg";
            this.cmbHxjg.Size = new System.Drawing.Size(152, 20);
            this.cmbHxjg.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblFwyt1.AutoSize = true;
            this.lblFwyt1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt1.Location = new System.Drawing.Point(0,0);
            this.lblFwyt1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt1.Name = "lblFwyt1";
            this.lblFwyt1.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt1.TabIndex = 29;
            this.lblFwyt1.Text = "房屋用途1";
            // 
            // cmbFwyt1
            // 
            this.cmbFwyt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwyt1.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwyt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwyt1.EnableTouchMode = true;
            this.cmbFwyt1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwyt1.Location =  new System.Drawing.Point(0,0);
            this.cmbFwyt1.Name = "cmbFwyt1";
            this.cmbFwyt1.Size = new System.Drawing.Size(152, 20);
            this.cmbFwyt1.TabIndex =  30;            
            // 
            // lblID
            // 
            this.lblFwyt2.AutoSize = true;
            this.lblFwyt2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt2.Location = new System.Drawing.Point(0,0);
            this.lblFwyt2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt2.Name = "lblFwyt2";
            this.lblFwyt2.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt2.TabIndex = 31;
            this.lblFwyt2.Text = "房屋用途2";
            // 
            // cmbFwyt2
            // 
            this.cmbFwyt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwyt2.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwyt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwyt2.EnableTouchMode = true;
            this.cmbFwyt2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwyt2.Location =  new System.Drawing.Point(0,0);
            this.cmbFwyt2.Name = "cmbFwyt2";
            this.cmbFwyt2.Size = new System.Drawing.Size(152, 20);
            this.cmbFwyt2.TabIndex =  32;            
            // 
            // lblID
            // 
            this.lblFwyt3.AutoSize = true;
            this.lblFwyt3.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt3.Location = new System.Drawing.Point(0,0);
            this.lblFwyt3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt3.Name = "lblFwyt3";
            this.lblFwyt3.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt3.TabIndex = 33;
            this.lblFwyt3.Text = "房屋用途3";
            // 
            // cmbFwyt3
            // 
            this.cmbFwyt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwyt3.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwyt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwyt3.EnableTouchMode = true;
            this.cmbFwyt3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwyt3.Location =  new System.Drawing.Point(0,0);
            this.cmbFwyt3.Name = "cmbFwyt3";
            this.cmbFwyt3.Size = new System.Drawing.Size(152, 20);
            this.cmbFwyt3.TabIndex =  34;            
            // 
            // lblID
            // 
            this.lblYcjzmj.AutoSize = true;
            this.lblYcjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYcjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcjzmj.Name = "lblYcjzmj";
            this.lblYcjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcjzmj.TabIndex = 35;
            this.lblYcjzmj.Text = "预测建筑面积";
            // 
            // dblYcjzmj
            // 
            this.dblYcjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcjzmj.DoubleValue = 1D;
            this.dblYcjzmj.EnableTouchMode = true;
            this.dblYcjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcjzmj.Name = "dblYcjzmj";
            this.dblYcjzmj.NullString = "";
            this.dblYcjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcjzmj.TabIndex = 36;
            this.dblYcjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYctnjzmj.AutoSize = true;
            this.lblYctnjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYctnjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYctnjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYctnjzmj.Name = "lblYctnjzmj";
            this.lblYctnjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYctnjzmj.TabIndex = 37;
            this.lblYctnjzmj.Text = "预测套内建筑面积";
            // 
            // dblYctnjzmj
            // 
            this.dblYctnjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYctnjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYctnjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYctnjzmj.DoubleValue = 1D;
            this.dblYctnjzmj.EnableTouchMode = true;
            this.dblYctnjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYctnjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYctnjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYctnjzmj.Name = "dblYctnjzmj";
            this.dblYctnjzmj.NullString = "";
            this.dblYctnjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYctnjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYctnjzmj.TabIndex = 38;
            this.dblYctnjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcftjzmj.AutoSize = true;
            this.lblYcftjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcftjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYcftjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcftjzmj.Name = "lblYcftjzmj";
            this.lblYcftjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcftjzmj.TabIndex = 39;
            this.lblYcftjzmj.Text = "预测分摊建筑面积";
            // 
            // dblYcftjzmj
            // 
            this.dblYcftjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcftjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcftjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcftjzmj.DoubleValue = 1D;
            this.dblYcftjzmj.EnableTouchMode = true;
            this.dblYcftjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcftjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcftjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcftjzmj.Name = "dblYcftjzmj";
            this.dblYcftjzmj.NullString = "";
            this.dblYcftjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcftjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcftjzmj.TabIndex = 40;
            this.dblYcftjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcdxbfjzmj.AutoSize = true;
            this.lblYcdxbfjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcdxbfjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYcdxbfjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcdxbfjzmj.Name = "lblYcdxbfjzmj";
            this.lblYcdxbfjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcdxbfjzmj.TabIndex = 41;
            this.lblYcdxbfjzmj.Text = "预测地下部分建筑面积";
            // 
            // dblYcdxbfjzmj
            // 
            this.dblYcdxbfjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcdxbfjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcdxbfjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcdxbfjzmj.DoubleValue = 1D;
            this.dblYcdxbfjzmj.EnableTouchMode = true;
            this.dblYcdxbfjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcdxbfjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcdxbfjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcdxbfjzmj.Name = "dblYcdxbfjzmj";
            this.dblYcdxbfjzmj.NullString = "";
            this.dblYcdxbfjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcdxbfjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcdxbfjzmj.TabIndex = 42;
            this.dblYcdxbfjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcqtjzmj.AutoSize = true;
            this.lblYcqtjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcqtjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYcqtjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcqtjzmj.Name = "lblYcqtjzmj";
            this.lblYcqtjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcqtjzmj.TabIndex = 43;
            this.lblYcqtjzmj.Text = "预测其它建筑面积";
            // 
            // dblYcqtjzmj
            // 
            this.dblYcqtjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcqtjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcqtjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcqtjzmj.DoubleValue = 1D;
            this.dblYcqtjzmj.EnableTouchMode = true;
            this.dblYcqtjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcqtjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcqtjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcqtjzmj.Name = "dblYcqtjzmj";
            this.dblYcqtjzmj.NullString = "";
            this.dblYcqtjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcqtjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcqtjzmj.TabIndex = 44;
            this.dblYcqtjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcftxs.AutoSize = true;
            this.lblYcftxs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcftxs.Location = new System.Drawing.Point(0,0);
            this.lblYcftxs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcftxs.Name = "lblYcftxs";
            this.lblYcftxs.Size = new System.Drawing.Size(41, 20);
            this.lblYcftxs.TabIndex = 45;
            this.lblYcftxs.Text = "预测分摊系数";
            // 
            // dblYcftxs
            // 
            this.dblYcftxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcftxs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcftxs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcftxs.DoubleValue = 1D;
            this.dblYcftxs.EnableTouchMode = true;
            this.dblYcftxs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcftxs.Location =  new System.Drawing.Point(0,0);
            this.dblYcftxs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcftxs.Name = "dblYcftxs";
            this.dblYcftxs.NullString = "";
            this.dblYcftxs.Size = new System.Drawing.Size(152, 28);
            this.dblYcftxs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcftxs.TabIndex = 46;
            this.dblYcftxs.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScjzmj.AutoSize = true;
            this.lblScjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScjzmj.Location = new System.Drawing.Point(0,0);
            this.lblScjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScjzmj.Name = "lblScjzmj";
            this.lblScjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblScjzmj.TabIndex = 47;
            this.lblScjzmj.Text = "实测建筑面积";
            // 
            // dblScjzmj
            // 
            this.dblScjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScjzmj.DoubleValue = 1D;
            this.dblScjzmj.EnableTouchMode = true;
            this.dblScjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblScjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScjzmj.Name = "dblScjzmj";
            this.dblScjzmj.NullString = "";
            this.dblScjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblScjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScjzmj.TabIndex = 48;
            this.dblScjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblSctnjzmj.AutoSize = true;
            this.lblSctnjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSctnjzmj.Location = new System.Drawing.Point(0,0);
            this.lblSctnjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSctnjzmj.Name = "lblSctnjzmj";
            this.lblSctnjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblSctnjzmj.TabIndex = 49;
            this.lblSctnjzmj.Text = "实测套内建筑面积";
            // 
            // dblSctnjzmj
            // 
            this.dblSctnjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSctnjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSctnjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSctnjzmj.DoubleValue = 1D;
            this.dblSctnjzmj.EnableTouchMode = true;
            this.dblSctnjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSctnjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblSctnjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSctnjzmj.Name = "dblSctnjzmj";
            this.dblSctnjzmj.NullString = "";
            this.dblSctnjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblSctnjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSctnjzmj.TabIndex = 50;
            this.dblSctnjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScftjzmj.AutoSize = true;
            this.lblScftjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScftjzmj.Location = new System.Drawing.Point(0,0);
            this.lblScftjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScftjzmj.Name = "lblScftjzmj";
            this.lblScftjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblScftjzmj.TabIndex = 51;
            this.lblScftjzmj.Text = "实测分摊建筑面积";
            // 
            // dblScftjzmj
            // 
            this.dblScftjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScftjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScftjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScftjzmj.DoubleValue = 1D;
            this.dblScftjzmj.EnableTouchMode = true;
            this.dblScftjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScftjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblScftjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScftjzmj.Name = "dblScftjzmj";
            this.dblScftjzmj.NullString = "";
            this.dblScftjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblScftjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScftjzmj.TabIndex = 52;
            this.dblScftjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScdxbfjzmj.AutoSize = true;
            this.lblScdxbfjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScdxbfjzmj.Location = new System.Drawing.Point(0,0);
            this.lblScdxbfjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScdxbfjzmj.Name = "lblScdxbfjzmj";
            this.lblScdxbfjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblScdxbfjzmj.TabIndex = 53;
            this.lblScdxbfjzmj.Text = "实测地下部分建筑面积";
            // 
            // dblScdxbfjzmj
            // 
            this.dblScdxbfjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScdxbfjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScdxbfjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScdxbfjzmj.DoubleValue = 1D;
            this.dblScdxbfjzmj.EnableTouchMode = true;
            this.dblScdxbfjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScdxbfjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblScdxbfjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScdxbfjzmj.Name = "dblScdxbfjzmj";
            this.dblScdxbfjzmj.NullString = "";
            this.dblScdxbfjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblScdxbfjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScdxbfjzmj.TabIndex = 54;
            this.dblScdxbfjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScqtjzmj.AutoSize = true;
            this.lblScqtjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScqtjzmj.Location = new System.Drawing.Point(0,0);
            this.lblScqtjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScqtjzmj.Name = "lblScqtjzmj";
            this.lblScqtjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblScqtjzmj.TabIndex = 55;
            this.lblScqtjzmj.Text = "实测其它建筑面积";
            // 
            // dblScqtjzmj
            // 
            this.dblScqtjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScqtjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScqtjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScqtjzmj.DoubleValue = 1D;
            this.dblScqtjzmj.EnableTouchMode = true;
            this.dblScqtjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScqtjzmj.Location =  new System.Drawing.Point(0,0);
            this.dblScqtjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScqtjzmj.Name = "dblScqtjzmj";
            this.dblScqtjzmj.NullString = "";
            this.dblScqtjzmj.Size = new System.Drawing.Size(152, 28);
            this.dblScqtjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScqtjzmj.TabIndex = 56;
            this.dblScqtjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScftxs.AutoSize = true;
            this.lblScftxs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScftxs.Location = new System.Drawing.Point(0,0);
            this.lblScftxs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScftxs.Name = "lblScftxs";
            this.lblScftxs.Size = new System.Drawing.Size(41, 20);
            this.lblScftxs.TabIndex = 57;
            this.lblScftxs.Text = "实测分摊系数";
            // 
            // dblScftxs
            // 
            this.dblScftxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScftxs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScftxs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScftxs.DoubleValue = 1D;
            this.dblScftxs.EnableTouchMode = true;
            this.dblScftxs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScftxs.Location =  new System.Drawing.Point(0,0);
            this.dblScftxs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScftxs.Name = "dblScftxs";
            this.dblScftxs.NullString = "";
            this.dblScftxs.Size = new System.Drawing.Size(152, 28);
            this.dblScftxs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScftxs.TabIndex = 58;
            this.dblScftxs.Text = "1.00";
            // 
            // lblID
            // 
            this.lblGytdmj.AutoSize = true;
            this.lblGytdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGytdmj.Location = new System.Drawing.Point(0,0);
            this.lblGytdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGytdmj.Name = "lblGytdmj";
            this.lblGytdmj.Size = new System.Drawing.Size(41, 20);
            this.lblGytdmj.TabIndex = 59;
            this.lblGytdmj.Text = "共有土地面积";
            // 
            // dblGytdmj
            // 
            this.dblGytdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblGytdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblGytdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblGytdmj.DoubleValue = 1D;
            this.dblGytdmj.EnableTouchMode = true;
            this.dblGytdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblGytdmj.Location =  new System.Drawing.Point(0,0);
            this.dblGytdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblGytdmj.Name = "dblGytdmj";
            this.dblGytdmj.NullString = "";
            this.dblGytdmj.Size = new System.Drawing.Size(152, 28);
            this.dblGytdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblGytdmj.TabIndex = 60;
            this.dblGytdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblFttdmj.AutoSize = true;
            this.lblFttdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFttdmj.Location = new System.Drawing.Point(0,0);
            this.lblFttdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFttdmj.Name = "lblFttdmj";
            this.lblFttdmj.Size = new System.Drawing.Size(41, 20);
            this.lblFttdmj.TabIndex = 61;
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
            this.dblFttdmj.TabIndex = 62;
            this.dblFttdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblDytdmj.AutoSize = true;
            this.lblDytdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDytdmj.Location = new System.Drawing.Point(0,0);
            this.lblDytdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDytdmj.Name = "lblDytdmj";
            this.lblDytdmj.Size = new System.Drawing.Size(41, 20);
            this.lblDytdmj.TabIndex = 63;
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
            this.dblDytdmj.TabIndex = 64;
            this.dblDytdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblFwlx.AutoSize = true;
            this.lblFwlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwlx.Location = new System.Drawing.Point(0,0);
            this.lblFwlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwlx.Name = "lblFwlx";
            this.lblFwlx.Size = new System.Drawing.Size(41, 20);
            this.lblFwlx.TabIndex = 65;
            this.lblFwlx.Text = "房屋类型";
            // 
            // cmbFwlx
            // 
            this.cmbFwlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwlx.EnableTouchMode = true;
            this.cmbFwlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwlx.Location =  new System.Drawing.Point(0,0);
            this.cmbFwlx.Name = "cmbFwlx";
            this.cmbFwlx.Size = new System.Drawing.Size(152, 20);
            this.cmbFwlx.TabIndex =  66;            
            // 
            // lblID
            // 
            this.lblFwxz.AutoSize = true;
            this.lblFwxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwxz.Location = new System.Drawing.Point(0,0);
            this.lblFwxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwxz.Name = "lblFwxz";
            this.lblFwxz.Size = new System.Drawing.Size(41, 20);
            this.lblFwxz.TabIndex = 67;
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
            this.cmbFwxz.TabIndex =  68;            
            // 
            // lblID
            // 
            this.lblFcfht.AutoSize = true;
            this.lblFcfht.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFcfht.Location = new System.Drawing.Point(0,0);
            this.lblFcfht.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFcfht.Name = "lblFcfht";
            this.lblFcfht.Size = new System.Drawing.Size(41, 20);
            this.lblFcfht.TabIndex = 69;
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
            this.txtFcfht.TabIndex = 70;
            // 
            // lblID
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(0,0);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(41, 20);
            this.lblZt.TabIndex = 71;
            this.lblZt.Text = "状态";
            // 
            // cmbZt
            // 
            this.cmbZt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.EnableTouchMode = true;
            this.cmbZt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.Location =  new System.Drawing.Point(0,0);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(152, 20);
            this.cmbZt.TabIndex =  72;            
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFwbm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFwbm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZrzh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZrzh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLjzh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtLjzh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtCh, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblZl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtZl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblMjdw, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbMjdw, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSjcs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblSjcs, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.intHh, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblShbw, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtShbw, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHx, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbHx, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHxjg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbHxjg, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt1, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt2, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt2, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt3, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt3, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYcjzmj, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblYcjzmj, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblYctnjzmj, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblYctnjzmj, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYcftjzmj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblYcftjzmj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYcdxbfjzmj, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblYcdxbfjzmj, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYcqtjzmj, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblYcqtjzmj, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYcftxs, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblYcftxs, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblScjzmj, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblScjzmj, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSctnjzmj, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblSctnjzmj, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblScftjzmj, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblScftjzmj, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblScdxbfjzmj, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblScdxbfjzmj, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblScqtjzmj, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblScqtjzmj, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblScftxs, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblScftxs, 10, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGytdmj, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblGytdmj, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFttdmj, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblFttdmj, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDytdmj, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblDytdmj, 10, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFwlx, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwlx, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFwxz, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwxz, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFcfht, 9, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFcfht, 10, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 9, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbZt, 10, 8);
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
            this.tableLayoutPanel1.TabIndex = 73; 
            //
            // ucH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucH";
            this.Size = new System.Drawing.Size(1000, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFwbm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLjzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSjcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intHh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShbw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHxjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYctnjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcftjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcdxbfjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcqtjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcftxs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSctnjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScftjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScdxbfjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScqtjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScftxs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGytdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDytdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFcfht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFwbm;	
        private System.Windows.Forms.Label lblFwbm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZrzh;	
        private System.Windows.Forms.Label lblZrzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLjzh;	
        private System.Windows.Forms.Label lblLjzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCh;	
        private System.Windows.Forms.Label lblCh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZl;	
        private System.Windows.Forms.Label lblZl;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbMjdw;	
        private System.Windows.Forms.Label lblMjdw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSjcs;	
        private System.Windows.Forms.Label lblSjcs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intHh;	
        private System.Windows.Forms.Label lblHh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtShbw;	
        private System.Windows.Forms.Label lblShbw;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbHx;	
        private System.Windows.Forms.Label lblHx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbHxjg;	
        private System.Windows.Forms.Label lblHxjg;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt1;	
        private System.Windows.Forms.Label lblFwyt1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt2;	
        private System.Windows.Forms.Label lblFwyt2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt3;	
        private System.Windows.Forms.Label lblFwyt3;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcjzmj;	
        private System.Windows.Forms.Label lblYcjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYctnjzmj;	
        private System.Windows.Forms.Label lblYctnjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcftjzmj;	
        private System.Windows.Forms.Label lblYcftjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcdxbfjzmj;	
        private System.Windows.Forms.Label lblYcdxbfjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcqtjzmj;	
        private System.Windows.Forms.Label lblYcqtjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcftxs;	
        private System.Windows.Forms.Label lblYcftxs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScjzmj;	
        private System.Windows.Forms.Label lblScjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSctnjzmj;	
        private System.Windows.Forms.Label lblSctnjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScftjzmj;	
        private System.Windows.Forms.Label lblScftjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScdxbfjzmj;	
        private System.Windows.Forms.Label lblScdxbfjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScqtjzmj;	
        private System.Windows.Forms.Label lblScqtjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScftxs;	
        private System.Windows.Forms.Label lblScftxs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblGytdmj;	
        private System.Windows.Forms.Label lblGytdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFttdmj;	
        private System.Windows.Forms.Label lblFttdmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDytdmj;	
        private System.Windows.Forms.Label lblDytdmj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwlx;	
        private System.Windows.Forms.Label lblFwlx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwxz;	
        private System.Windows.Forms.Label lblFwxz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFcfht;	
        private System.Windows.Forms.Label lblFcfht;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZt;	
        private System.Windows.Forms.Label lblZt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}