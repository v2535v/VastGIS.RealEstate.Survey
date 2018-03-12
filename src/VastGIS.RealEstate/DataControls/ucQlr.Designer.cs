using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucQlr
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
            this.lblSxh = new System.Windows.Forms.Label();
            this.intSxh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblQlrmc = new System.Windows.Forms.Label();
            this.txtQlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdcqzh = new System.Windows.Forms.Label();
            this.txtBdcqzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQzysxlh = new System.Windows.Forms.Label();
            this.txtQzysxlh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfczr = new System.Windows.Forms.Label();
            this.cmbSfczr = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZjzl = new System.Windows.Forms.Label();
            this.cmbZjzl = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZjh = new System.Windows.Forms.Label();
            this.txtZjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFzjg = new System.Windows.Forms.Label();
            this.txtFzjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSshy = new System.Windows.Forms.Label();
            this.txtSshy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGj = new System.Windows.Forms.Label();
            this.cmbGj = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblHjszss = new System.Windows.Forms.Label();
            this.cmbHjszss = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblXb = new System.Windows.Forms.Label();
            this.cmbXb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDh = new System.Windows.Forms.Label();
            this.txtDh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDz = new System.Windows.Forms.Label();
            this.txtDz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYb = new System.Windows.Forms.Label();
            this.txtYb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGzdw = new System.Windows.Forms.Label();
            this.txtGzdw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDzyj = new System.Windows.Forms.Label();
            this.txtDzyj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQlrlx = new System.Windows.Forms.Label();
            this.cmbQlrlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQlbl = new System.Windows.Forms.Label();
            this.txtQlbl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGyfs = new System.Windows.Forms.Label();
            this.cmbGyfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblGyqk = new System.Windows.Forms.Label();
            this.txtGyqk = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQzysxlh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfczr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZjzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSshy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHjszss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGzdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzyj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlrlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGyfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGyqk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).BeginInit();
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
            // lblSxh
            // 
            this.lblSxh.AutoSize = true;
            this.lblSxh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSxh.Location = new System.Drawing.Point(36, 115);
            this.lblSxh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSxh.Name = "lblSxh";
            this.lblSxh.Size = new System.Drawing.Size(41, 25);
            this.lblSxh.TabIndex = 7;
            this.lblSxh.Text = "顺序号";
            // 
            // intSxh
            // 
            this.intSxh.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSxh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSxh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSxh.EnableTouchMode = true;
            this.intSxh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSxh.IntegerValue = ((long)(0));
            this.intSxh.Location = new System.Drawing.Point(83, 108);
            this.intSxh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSxh.Name = "intSxh";
            this.intSxh.NullString = "";
            this.intSxh.Size = new System.Drawing.Size(158, 28);
            this.intSxh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSxh.TabIndex = 8;
            this.intSxh.Text = "0";
            // 
            // lblQlrmc
            // 
            this.lblQlrmc.AutoSize = true;
            this.lblQlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrmc.Location = new System.Drawing.Point(12, 150);
            this.lblQlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrmc.Name = "lblQlrmc";
            this.lblQlrmc.Size = new System.Drawing.Size(65, 25);
            this.lblQlrmc.TabIndex = 9;
            this.lblQlrmc.Text = "权利人名称";
            // 
            // txtQlrmc
            // 
            this.txtQlrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrmc.EnableTouchMode = true;
            this.txtQlrmc.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrmc.Location = new System.Drawing.Point(83, 143);
            this.txtQlrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrmc.Name = "txtQlrmc";
            this.txtQlrmc.Size = new System.Drawing.Size(158, 28);
            this.txtQlrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrmc.TabIndex = 10;
            // 
            // lblBdcqzh
            // 
            this.lblBdcqzh.AutoSize = true;
            this.lblBdcqzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcqzh.Location = new System.Drawing.Point(12, 185);
            this.lblBdcqzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcqzh.Name = "lblBdcqzh";
            this.lblBdcqzh.Size = new System.Drawing.Size(65, 25);
            this.lblBdcqzh.TabIndex = 11;
            this.lblBdcqzh.Text = "不动产权证号";
            // 
            // txtBdcqzh
            // 
            this.txtBdcqzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcqzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcqzh.EnableTouchMode = true;
            this.txtBdcqzh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcqzh.Location = new System.Drawing.Point(83, 178);
            this.txtBdcqzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcqzh.Name = "txtBdcqzh";
            this.txtBdcqzh.Size = new System.Drawing.Size(158, 28);
            this.txtBdcqzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcqzh.TabIndex = 12;
            // 
            // lblQzysxlh
            // 
            this.lblQzysxlh.AutoSize = true;
            this.lblQzysxlh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQzysxlh.Location = new System.Drawing.Point(12, 220);
            this.lblQzysxlh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQzysxlh.Name = "lblQzysxlh";
            this.lblQzysxlh.Size = new System.Drawing.Size(65, 25);
            this.lblQzysxlh.TabIndex = 13;
            this.lblQzysxlh.Text = "权证印刷序列号";
            // 
            // txtQzysxlh
            // 
            this.txtQzysxlh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQzysxlh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQzysxlh.EnableTouchMode = true;
            this.txtQzysxlh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQzysxlh.Location = new System.Drawing.Point(83, 213);
            this.txtQzysxlh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQzysxlh.Name = "txtQzysxlh";
            this.txtQzysxlh.Size = new System.Drawing.Size(158, 28);
            this.txtQzysxlh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQzysxlh.TabIndex = 14;
            // 
            // lblSfczr
            // 
            this.lblSfczr.AutoSize = true;
            this.lblSfczr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfczr.Location = new System.Drawing.Point(12, 255);
            this.lblSfczr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfczr.Name = "lblSfczr";
            this.lblSfczr.Size = new System.Drawing.Size(65, 25);
            this.lblSfczr.TabIndex = 15;
            this.lblSfczr.Text = "是否持证人";
            // 
            // cmbSfczr
            // 
            this.cmbSfczr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfczr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfczr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfczr.EnableTouchMode = true;
            this.cmbSfczr.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfczr.Location = new System.Drawing.Point(83, 248);
            this.cmbSfczr.Name = "cmbSfczr";
            this.cmbSfczr.Size = new System.Drawing.Size(158, 20);
            this.cmbSfczr.TabIndex = 16;
            // 
            // lblZjzl
            // 
            this.lblZjzl.AutoSize = true;
            this.lblZjzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjzl.Location = new System.Drawing.Point(24, 290);
            this.lblZjzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjzl.Name = "lblZjzl";
            this.lblZjzl.Size = new System.Drawing.Size(53, 41);
            this.lblZjzl.TabIndex = 17;
            this.lblZjzl.Text = "证件种类";
            // 
            // cmbZjzl
            // 
            this.cmbZjzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZjzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZjzl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZjzl.EnableTouchMode = true;
            this.cmbZjzl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZjzl.Location = new System.Drawing.Point(83, 283);
            this.cmbZjzl.Name = "cmbZjzl";
            this.cmbZjzl.Size = new System.Drawing.Size(158, 20);
            this.cmbZjzl.TabIndex = 18;
            // 
            // lblZjh
            // 
            this.lblZjh.AutoSize = true;
            this.lblZjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjh.Location = new System.Drawing.Point(285, 10);
            this.lblZjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjh.Name = "lblZjh";
            this.lblZjh.Size = new System.Drawing.Size(41, 25);
            this.lblZjh.TabIndex = 19;
            this.lblZjh.Text = "证件号";
            // 
            // txtZjh
            // 
            this.txtZjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjh.EnableTouchMode = true;
            this.txtZjh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjh.Location = new System.Drawing.Point(332, 3);
            this.txtZjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjh.Name = "txtZjh";
            this.txtZjh.Size = new System.Drawing.Size(158, 28);
            this.txtZjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjh.TabIndex = 20;
            // 
            // lblFzjg
            // 
            this.lblFzjg.AutoSize = true;
            this.lblFzjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzjg.Location = new System.Drawing.Point(273, 45);
            this.lblFzjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzjg.Name = "lblFzjg";
            this.lblFzjg.Size = new System.Drawing.Size(53, 25);
            this.lblFzjg.TabIndex = 21;
            this.lblFzjg.Text = "发证机关";
            // 
            // txtFzjg
            // 
            this.txtFzjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFzjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFzjg.EnableTouchMode = true;
            this.txtFzjg.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFzjg.Location = new System.Drawing.Point(332, 38);
            this.txtFzjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFzjg.Name = "txtFzjg";
            this.txtFzjg.Size = new System.Drawing.Size(158, 28);
            this.txtFzjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFzjg.TabIndex = 22;
            // 
            // lblSshy
            // 
            this.lblSshy.AutoSize = true;
            this.lblSshy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSshy.Location = new System.Drawing.Point(273, 80);
            this.lblSshy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSshy.Name = "lblSshy";
            this.lblSshy.Size = new System.Drawing.Size(53, 25);
            this.lblSshy.TabIndex = 23;
            this.lblSshy.Text = "所属行业";
            // 
            // txtSshy
            // 
            this.txtSshy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSshy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSshy.EnableTouchMode = true;
            this.txtSshy.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSshy.Location = new System.Drawing.Point(332, 73);
            this.txtSshy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSshy.Name = "txtSshy";
            this.txtSshy.Size = new System.Drawing.Size(158, 28);
            this.txtSshy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSshy.TabIndex = 24;
            // 
            // lblGj
            // 
            this.lblGj.AutoSize = true;
            this.lblGj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGj.Location = new System.Drawing.Point(267, 115);
            this.lblGj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGj.Name = "lblGj";
            this.lblGj.Size = new System.Drawing.Size(59, 25);
            this.lblGj.TabIndex = 25;
            this.lblGj.Text = "国家/地区";
            // 
            // cmbGj
            // 
            this.cmbGj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGj.EnableTouchMode = true;
            this.cmbGj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGj.Location = new System.Drawing.Point(332, 108);
            this.cmbGj.Name = "cmbGj";
            this.cmbGj.Size = new System.Drawing.Size(158, 20);
            this.cmbGj.TabIndex = 26;
            // 
            // lblHjszss
            // 
            this.lblHjszss.AutoSize = true;
            this.lblHjszss.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHjszss.Location = new System.Drawing.Point(261, 150);
            this.lblHjszss.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHjszss.Name = "lblHjszss";
            this.lblHjszss.Size = new System.Drawing.Size(65, 25);
            this.lblHjszss.TabIndex = 27;
            this.lblHjszss.Text = "户籍所在省市";
            // 
            // cmbHjszss
            // 
            this.cmbHjszss.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbHjszss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHjszss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHjszss.EnableTouchMode = true;
            this.cmbHjszss.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHjszss.Location = new System.Drawing.Point(332, 143);
            this.cmbHjszss.Name = "cmbHjszss";
            this.cmbHjszss.Size = new System.Drawing.Size(158, 20);
            this.cmbHjszss.TabIndex = 28;
            // 
            // lblXb
            // 
            this.lblXb.AutoSize = true;
            this.lblXb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXb.Location = new System.Drawing.Point(297, 185);
            this.lblXb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXb.Name = "lblXb";
            this.lblXb.Size = new System.Drawing.Size(29, 25);
            this.lblXb.TabIndex = 29;
            this.lblXb.Text = "性别";
            // 
            // cmbXb
            // 
            this.cmbXb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbXb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbXb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXb.EnableTouchMode = true;
            this.cmbXb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXb.Location = new System.Drawing.Point(332, 178);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.Size = new System.Drawing.Size(158, 20);
            this.cmbXb.TabIndex = 30;
            // 
            // lblDh
            // 
            this.lblDh.AutoSize = true;
            this.lblDh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDh.Location = new System.Drawing.Point(297, 220);
            this.lblDh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDh.Name = "lblDh";
            this.lblDh.Size = new System.Drawing.Size(29, 25);
            this.lblDh.TabIndex = 31;
            this.lblDh.Text = "电话";
            // 
            // txtDh
            // 
            this.txtDh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDh.EnableTouchMode = true;
            this.txtDh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDh.Location = new System.Drawing.Point(332, 213);
            this.txtDh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDh.Name = "txtDh";
            this.txtDh.Size = new System.Drawing.Size(158, 28);
            this.txtDh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDh.TabIndex = 32;
            // 
            // lblDz
            // 
            this.lblDz.AutoSize = true;
            this.lblDz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDz.Location = new System.Drawing.Point(297, 255);
            this.lblDz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDz.Name = "lblDz";
            this.lblDz.Size = new System.Drawing.Size(29, 25);
            this.lblDz.TabIndex = 33;
            this.lblDz.Text = "地址";
            // 
            // txtDz
            // 
            this.txtDz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDz.EnableTouchMode = true;
            this.txtDz.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDz.Location = new System.Drawing.Point(332, 248);
            this.txtDz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(158, 28);
            this.txtDz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDz.TabIndex = 34;
            // 
            // lblYb
            // 
            this.lblYb.AutoSize = true;
            this.lblYb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYb.Location = new System.Drawing.Point(297, 290);
            this.lblYb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYb.Name = "lblYb";
            this.lblYb.Size = new System.Drawing.Size(29, 41);
            this.lblYb.TabIndex = 35;
            this.lblYb.Text = "邮编";
            // 
            // txtYb
            // 
            this.txtYb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYb.EnableTouchMode = true;
            this.txtYb.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYb.Location = new System.Drawing.Point(332, 283);
            this.txtYb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(158, 28);
            this.txtYb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYb.TabIndex = 36;
            // 
            // lblGzdw
            // 
            this.lblGzdw.AutoSize = true;
            this.lblGzdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGzdw.Location = new System.Drawing.Point(522, 10);
            this.lblGzdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGzdw.Name = "lblGzdw";
            this.lblGzdw.Size = new System.Drawing.Size(53, 25);
            this.lblGzdw.TabIndex = 37;
            this.lblGzdw.Text = "工作单位";
            // 
            // txtGzdw
            // 
            this.txtGzdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGzdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGzdw.EnableTouchMode = true;
            this.txtGzdw.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGzdw.Location = new System.Drawing.Point(581, 3);
            this.txtGzdw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGzdw.Name = "txtGzdw";
            this.txtGzdw.Size = new System.Drawing.Size(158, 28);
            this.txtGzdw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGzdw.TabIndex = 38;
            // 
            // lblDzyj
            // 
            this.lblDzyj.AutoSize = true;
            this.lblDzyj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDzyj.Location = new System.Drawing.Point(522, 45);
            this.lblDzyj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDzyj.Name = "lblDzyj";
            this.lblDzyj.Size = new System.Drawing.Size(53, 25);
            this.lblDzyj.TabIndex = 39;
            this.lblDzyj.Text = "电子邮件";
            // 
            // txtDzyj
            // 
            this.txtDzyj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDzyj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDzyj.EnableTouchMode = true;
            this.txtDzyj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDzyj.Location = new System.Drawing.Point(581, 38);
            this.txtDzyj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDzyj.Name = "txtDzyj";
            this.txtDzyj.Size = new System.Drawing.Size(158, 28);
            this.txtDzyj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDzyj.TabIndex = 40;
            // 
            // lblQlrlx
            // 
            this.lblQlrlx.AutoSize = true;
            this.lblQlrlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrlx.Location = new System.Drawing.Point(510, 80);
            this.lblQlrlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrlx.Name = "lblQlrlx";
            this.lblQlrlx.Size = new System.Drawing.Size(65, 25);
            this.lblQlrlx.TabIndex = 41;
            this.lblQlrlx.Text = "权利人类型";
            // 
            // cmbQlrlx
            // 
            this.cmbQlrlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQlrlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQlrlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQlrlx.EnableTouchMode = true;
            this.cmbQlrlx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQlrlx.Location = new System.Drawing.Point(581, 73);
            this.cmbQlrlx.Name = "cmbQlrlx";
            this.cmbQlrlx.Size = new System.Drawing.Size(158, 20);
            this.cmbQlrlx.TabIndex = 42;
            // 
            // lblQlbl
            // 
            this.lblQlbl.AutoSize = true;
            this.lblQlbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlbl.Location = new System.Drawing.Point(522, 115);
            this.lblQlbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlbl.Name = "lblQlbl";
            this.lblQlbl.Size = new System.Drawing.Size(53, 25);
            this.lblQlbl.TabIndex = 43;
            this.lblQlbl.Text = "权利比例";
            // 
            // txtQlbl
            // 
            this.txtQlbl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlbl.EnableTouchMode = true;
            this.txtQlbl.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlbl.Location = new System.Drawing.Point(581, 108);
            this.txtQlbl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlbl.Name = "txtQlbl";
            this.txtQlbl.Size = new System.Drawing.Size(158, 28);
            this.txtQlbl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlbl.TabIndex = 44;
            // 
            // lblGyfs
            // 
            this.lblGyfs.AutoSize = true;
            this.lblGyfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGyfs.Location = new System.Drawing.Point(522, 150);
            this.lblGyfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGyfs.Name = "lblGyfs";
            this.lblGyfs.Size = new System.Drawing.Size(53, 25);
            this.lblGyfs.TabIndex = 45;
            this.lblGyfs.Text = "共有方式";
            // 
            // cmbGyfs
            // 
            this.cmbGyfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGyfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGyfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGyfs.EnableTouchMode = true;
            this.cmbGyfs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGyfs.Location = new System.Drawing.Point(581, 143);
            this.cmbGyfs.Name = "cmbGyfs";
            this.cmbGyfs.Size = new System.Drawing.Size(158, 20);
            this.cmbGyfs.TabIndex = 46;
            // 
            // lblGyqk
            // 
            this.lblGyqk.AutoSize = true;
            this.lblGyqk.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGyqk.Location = new System.Drawing.Point(522, 185);
            this.lblGyqk.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGyqk.Name = "lblGyqk";
            this.lblGyqk.Size = new System.Drawing.Size(53, 25);
            this.lblGyqk.TabIndex = 47;
            this.lblGyqk.Text = "共有情况";
            // 
            // txtGyqk
            // 
            this.txtGyqk.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGyqk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGyqk.EnableTouchMode = true;
            this.txtGyqk.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGyqk.Location = new System.Drawing.Point(581, 178);
            this.txtGyqk.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGyqk.Name = "txtGyqk";
            this.txtGyqk.Size = new System.Drawing.Size(158, 28);
            this.txtGyqk.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGyqk.TabIndex = 48;
            // 
            // lblBz
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(546, 220);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(29, 25);
            this.lblBz.TabIndex = 49;
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
            this.txtBz.TabIndex = 50;
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
            this.tableLayoutPanel1.Controls.Add(this.lblSxh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.intSxh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrmc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrmc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcqzh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcqzh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQzysxlh, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtQzysxlh, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSfczr, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfczr, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZjzl, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbZjzl, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblZjh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtZjh, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFzjg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFzjg, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSshy, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSshy, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbGj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHjszss, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbHjszss, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblXb, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbXb, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDh, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDh, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDz, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDz, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYb, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtYb, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblGzdw, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGzdw, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDzyj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDzyj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQlrlx, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbQlrlx, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQlbl, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQlbl, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGyfs, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbGyfs, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGyqk, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtGyqk, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 6);
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
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // ucQlr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQlr";
            this.Size = new System.Drawing.Size(750, 331);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcqzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQzysxlh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfczr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZjzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSshy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHjszss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGzdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzyj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQlrlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGyfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGyqk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSxh;	
        private System.Windows.Forms.Label lblSxh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrmc;	
        private System.Windows.Forms.Label lblQlrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcqzh;	
        private System.Windows.Forms.Label lblBdcqzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQzysxlh;	
        private System.Windows.Forms.Label lblQzysxlh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfczr;	
        private System.Windows.Forms.Label lblSfczr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZjzl;	
        private System.Windows.Forms.Label lblZjzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjh;	
        private System.Windows.Forms.Label lblZjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFzjg;	
        private System.Windows.Forms.Label lblFzjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSshy;	
        private System.Windows.Forms.Label lblSshy;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGj;	
        private System.Windows.Forms.Label lblGj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbHjszss;	
        private System.Windows.Forms.Label lblHjszss;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbXb;	
        private System.Windows.Forms.Label lblXb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDh;	
        private System.Windows.Forms.Label lblDh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDz;	
        private System.Windows.Forms.Label lblDz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYb;	
        private System.Windows.Forms.Label lblYb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGzdw;	
        private System.Windows.Forms.Label lblGzdw;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDzyj;	
        private System.Windows.Forms.Label lblDzyj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQlrlx;	
        private System.Windows.Forms.Label lblQlrlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlbl;	
        private System.Windows.Forms.Label lblQlbl;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGyfs;	
        private System.Windows.Forms.Label lblGyfs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGyqk;	
        private System.Windows.Forms.Label lblGyqk;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}