using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucLjz
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
            this.lblLjzh = new System.Windows.Forms.Label();
            this.txtLjzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZrzh = new System.Windows.Forms.Label();
            this.txtZrzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMph = new System.Windows.Forms.Label();
            this.txtMph = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYcjzmj = new System.Windows.Forms.Label();
            this.dblYcjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcdxmj = new System.Windows.Forms.Label();
            this.dblYcdxmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYcqtmj = new System.Windows.Forms.Label();
            this.dblYcqtmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScjzmj = new System.Windows.Forms.Label();
            this.dblScjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScdxmj = new System.Windows.Forms.Label();
            this.dblScdxmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblScqtmj = new System.Windows.Forms.Label();
            this.dblScqtmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJgrq = new System.Windows.Forms.Label();
            this.datJgrq = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFwjg1 = new System.Windows.Forms.Label();
            this.cmbFwjg1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwjg2 = new System.Windows.Forms.Label();
            this.cmbFwjg2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwjg3 = new System.Windows.Forms.Label();
            this.cmbFwjg3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJzwzt = new System.Windows.Forms.Label();
            this.cmbJzwzt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt1 = new System.Windows.Forms.Label();
            this.cmbFwyt1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt2 = new System.Windows.Forms.Label();
            this.cmbFwyt2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwyt3 = new System.Windows.Forms.Label();
            this.cmbFwyt3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZcs = new System.Windows.Forms.Label();
            this.intZcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblDscs = new System.Windows.Forms.Label();
            this.intDscs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblDxcs = new System.Windows.Forms.Label();
            this.intDxcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLjzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcdxmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcqtmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScdxmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScqtmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgrq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzwzt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDscs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxcs)).BeginInit();
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
            this.lblLjzh.AutoSize = true;
            this.lblLjzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLjzh.Location = new System.Drawing.Point(0,0);
            this.lblLjzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLjzh.Name = "lblLjzh";
            this.lblLjzh.Size = new System.Drawing.Size(41, 20);
            this.lblLjzh.TabIndex = 3;
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
            this.txtLjzh.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblZrzh.AutoSize = true;
            this.lblZrzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZrzh.Location = new System.Drawing.Point(0,0);
            this.lblZrzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZrzh.Name = "lblZrzh";
            this.lblZrzh.Size = new System.Drawing.Size(41, 20);
            this.lblZrzh.TabIndex = 5;
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
            this.txtZrzh.TabIndex = 6;
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
            this.lblMph.AutoSize = true;
            this.lblMph.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMph.Location = new System.Drawing.Point(0,0);
            this.lblMph.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMph.Name = "lblMph";
            this.lblMph.Size = new System.Drawing.Size(41, 20);
            this.lblMph.TabIndex = 9;
            this.lblMph.Text = "门牌号";
            // 
            // txtMph
            // 
            this.txtMph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMph.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtMph.EnableTouchMode = true;
            this.txtMph.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMph.Location =  new System.Drawing.Point(0,0);
            this.txtMph.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMph.Name = "txtMph";
            this.txtMph.Size = new System.Drawing.Size(152, 28);
            this.txtMph.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMph.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblYcjzmj.AutoSize = true;
            this.lblYcjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcjzmj.Location = new System.Drawing.Point(0,0);
            this.lblYcjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcjzmj.Name = "lblYcjzmj";
            this.lblYcjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcjzmj.TabIndex = 11;
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
            this.dblYcjzmj.TabIndex = 12;
            this.dblYcjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcdxmj.AutoSize = true;
            this.lblYcdxmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcdxmj.Location = new System.Drawing.Point(0,0);
            this.lblYcdxmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcdxmj.Name = "lblYcdxmj";
            this.lblYcdxmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcdxmj.TabIndex = 13;
            this.lblYcdxmj.Text = "预测地下面积";
            // 
            // dblYcdxmj
            // 
            this.dblYcdxmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcdxmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcdxmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcdxmj.DoubleValue = 1D;
            this.dblYcdxmj.EnableTouchMode = true;
            this.dblYcdxmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcdxmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcdxmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcdxmj.Name = "dblYcdxmj";
            this.dblYcdxmj.NullString = "";
            this.dblYcdxmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcdxmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcdxmj.TabIndex = 14;
            this.dblYcdxmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYcqtmj.AutoSize = true;
            this.lblYcqtmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYcqtmj.Location = new System.Drawing.Point(0,0);
            this.lblYcqtmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYcqtmj.Name = "lblYcqtmj";
            this.lblYcqtmj.Size = new System.Drawing.Size(41, 20);
            this.lblYcqtmj.TabIndex = 15;
            this.lblYcqtmj.Text = "预测其它面积";
            // 
            // dblYcqtmj
            // 
            this.dblYcqtmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYcqtmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYcqtmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYcqtmj.DoubleValue = 1D;
            this.dblYcqtmj.EnableTouchMode = true;
            this.dblYcqtmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYcqtmj.Location =  new System.Drawing.Point(0,0);
            this.dblYcqtmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYcqtmj.Name = "dblYcqtmj";
            this.dblYcqtmj.NullString = "";
            this.dblYcqtmj.Size = new System.Drawing.Size(152, 28);
            this.dblYcqtmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYcqtmj.TabIndex = 16;
            this.dblYcqtmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScjzmj.AutoSize = true;
            this.lblScjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScjzmj.Location = new System.Drawing.Point(0,0);
            this.lblScjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScjzmj.Name = "lblScjzmj";
            this.lblScjzmj.Size = new System.Drawing.Size(41, 20);
            this.lblScjzmj.TabIndex = 17;
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
            this.dblScjzmj.TabIndex = 18;
            this.dblScjzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScdxmj.AutoSize = true;
            this.lblScdxmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScdxmj.Location = new System.Drawing.Point(0,0);
            this.lblScdxmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScdxmj.Name = "lblScdxmj";
            this.lblScdxmj.Size = new System.Drawing.Size(41, 20);
            this.lblScdxmj.TabIndex = 19;
            this.lblScdxmj.Text = "实测地下面积";
            // 
            // dblScdxmj
            // 
            this.dblScdxmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScdxmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScdxmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScdxmj.DoubleValue = 1D;
            this.dblScdxmj.EnableTouchMode = true;
            this.dblScdxmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScdxmj.Location =  new System.Drawing.Point(0,0);
            this.dblScdxmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScdxmj.Name = "dblScdxmj";
            this.dblScdxmj.NullString = "";
            this.dblScdxmj.Size = new System.Drawing.Size(152, 28);
            this.dblScdxmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScdxmj.TabIndex = 20;
            this.dblScdxmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblScqtmj.AutoSize = true;
            this.lblScqtmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScqtmj.Location = new System.Drawing.Point(0,0);
            this.lblScqtmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblScqtmj.Name = "lblScqtmj";
            this.lblScqtmj.Size = new System.Drawing.Size(41, 20);
            this.lblScqtmj.TabIndex = 21;
            this.lblScqtmj.Text = "实测其它面积";
            // 
            // dblScqtmj
            // 
            this.dblScqtmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblScqtmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblScqtmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblScqtmj.DoubleValue = 1D;
            this.dblScqtmj.EnableTouchMode = true;
            this.dblScqtmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblScqtmj.Location =  new System.Drawing.Point(0,0);
            this.dblScqtmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblScqtmj.Name = "dblScqtmj";
            this.dblScqtmj.NullString = "";
            this.dblScqtmj.Size = new System.Drawing.Size(152, 28);
            this.dblScqtmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblScqtmj.TabIndex = 22;
            this.dblScqtmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJgrq.AutoSize = true;
            this.lblJgrq.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgrq.Location = new System.Drawing.Point(0,0);
            this.lblJgrq.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgrq.Name = "lblJgrq";
            this.lblJgrq.Size = new System.Drawing.Size(41, 20);
            this.lblJgrq.TabIndex = 23;
            this.lblJgrq.Text = "竣工日期";
            // 
            // datJgrq
            // 
            this.datJgrq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJgrq.BorderColor = System.Drawing.Color.Empty;
            this.datJgrq.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJgrq.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJgrq.DropDownImage = null;
            this.datJgrq.EnableTouchMode = true;
            this.datJgrq.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJgrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJgrq.Location =  new System.Drawing.Point(0,0);
            this.datJgrq.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJgrq.MinValue = new System.DateTime(((long)(0)));
            this.datJgrq.Name = "datJgrq";
            this.datJgrq.Size = new System.Drawing.Size(152, 20);
            this.datJgrq.TabIndex = 24;
            this.datJgrq.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJgrq.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFwjg1.AutoSize = true;
            this.lblFwjg1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg1.Location = new System.Drawing.Point(0,0);
            this.lblFwjg1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg1.Name = "lblFwjg1";
            this.lblFwjg1.Size = new System.Drawing.Size(41, 20);
            this.lblFwjg1.TabIndex = 25;
            this.lblFwjg1.Text = "房屋结构1";
            // 
            // cmbFwjg1
            // 
            this.cmbFwjg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg1.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg1.EnableTouchMode = true;
            this.cmbFwjg1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg1.Location =  new System.Drawing.Point(0,0);
            this.cmbFwjg1.Name = "cmbFwjg1";
            this.cmbFwjg1.Size = new System.Drawing.Size(152, 20);
            this.cmbFwjg1.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblFwjg2.AutoSize = true;
            this.lblFwjg2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg2.Location = new System.Drawing.Point(0,0);
            this.lblFwjg2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg2.Name = "lblFwjg2";
            this.lblFwjg2.Size = new System.Drawing.Size(41, 20);
            this.lblFwjg2.TabIndex = 27;
            this.lblFwjg2.Text = "房屋结构2";
            // 
            // cmbFwjg2
            // 
            this.cmbFwjg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg2.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg2.EnableTouchMode = true;
            this.cmbFwjg2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg2.Location =  new System.Drawing.Point(0,0);
            this.cmbFwjg2.Name = "cmbFwjg2";
            this.cmbFwjg2.Size = new System.Drawing.Size(152, 20);
            this.cmbFwjg2.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblFwjg3.AutoSize = true;
            this.lblFwjg3.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg3.Location = new System.Drawing.Point(0,0);
            this.lblFwjg3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg3.Name = "lblFwjg3";
            this.lblFwjg3.Size = new System.Drawing.Size(41, 20);
            this.lblFwjg3.TabIndex = 29;
            this.lblFwjg3.Text = "房屋结构3";
            // 
            // cmbFwjg3
            // 
            this.cmbFwjg3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg3.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg3.EnableTouchMode = true;
            this.cmbFwjg3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg3.Location =  new System.Drawing.Point(0,0);
            this.cmbFwjg3.Name = "cmbFwjg3";
            this.cmbFwjg3.Size = new System.Drawing.Size(152, 20);
            this.cmbFwjg3.TabIndex =  30;            
            // 
            // lblID
            // 
            this.lblJzwzt.AutoSize = true;
            this.lblJzwzt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzwzt.Location = new System.Drawing.Point(0,0);
            this.lblJzwzt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzwzt.Name = "lblJzwzt";
            this.lblJzwzt.Size = new System.Drawing.Size(41, 20);
            this.lblJzwzt.TabIndex = 31;
            this.lblJzwzt.Text = "建筑物状态";
            // 
            // cmbJzwzt
            // 
            this.cmbJzwzt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJzwzt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJzwzt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJzwzt.EnableTouchMode = true;
            this.cmbJzwzt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJzwzt.Location =  new System.Drawing.Point(0,0);
            this.cmbJzwzt.Name = "cmbJzwzt";
            this.cmbJzwzt.Size = new System.Drawing.Size(152, 20);
            this.cmbJzwzt.TabIndex =  32;            
            // 
            // lblID
            // 
            this.lblFwyt1.AutoSize = true;
            this.lblFwyt1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt1.Location = new System.Drawing.Point(0,0);
            this.lblFwyt1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt1.Name = "lblFwyt1";
            this.lblFwyt1.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt1.TabIndex = 33;
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
            this.cmbFwyt1.TabIndex =  34;            
            // 
            // lblID
            // 
            this.lblFwyt2.AutoSize = true;
            this.lblFwyt2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt2.Location = new System.Drawing.Point(0,0);
            this.lblFwyt2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt2.Name = "lblFwyt2";
            this.lblFwyt2.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt2.TabIndex = 35;
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
            this.cmbFwyt2.TabIndex =  36;            
            // 
            // lblID
            // 
            this.lblFwyt3.AutoSize = true;
            this.lblFwyt3.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwyt3.Location = new System.Drawing.Point(0,0);
            this.lblFwyt3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwyt3.Name = "lblFwyt3";
            this.lblFwyt3.Size = new System.Drawing.Size(41, 20);
            this.lblFwyt3.TabIndex = 37;
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
            this.cmbFwyt3.TabIndex =  38;            
            // 
            // lblID
            // 
            this.lblZcs.AutoSize = true;
            this.lblZcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZcs.Location = new System.Drawing.Point(0,0);
            this.lblZcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZcs.Name = "lblZcs";
            this.lblZcs.Size = new System.Drawing.Size(41, 20);
            this.lblZcs.TabIndex = 39;
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
            this.intZcs.TabIndex = 40;
            this.intZcs.Text = "0";
            // 
            // lblID
            // 
            this.lblDscs.AutoSize = true;
            this.lblDscs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDscs.Location = new System.Drawing.Point(0,0);
            this.lblDscs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDscs.Name = "lblDscs";
            this.lblDscs.Size = new System.Drawing.Size(41, 20);
            this.lblDscs.TabIndex = 41;
            this.lblDscs.Text = "地上层数";
            // 
            // intDscs
            // 
            this.intDscs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDscs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDscs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDscs.EnableTouchMode = true;
            this.intDscs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDscs.IntegerValue = ((long)(0));
            this.intDscs.Location = new System.Drawing.Point(0,0);
            this.intDscs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDscs.Name = "intDscs";
            this.intDscs.NullString = "";
            this.intDscs.Size = new System.Drawing.Size(152, 28);
            this.intDscs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDscs.TabIndex = 42;
            this.intDscs.Text = "0";
            // 
            // lblID
            // 
            this.lblDxcs.AutoSize = true;
            this.lblDxcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDxcs.Location = new System.Drawing.Point(0,0);
            this.lblDxcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDxcs.Name = "lblDxcs";
            this.lblDxcs.Size = new System.Drawing.Size(41, 20);
            this.lblDxcs.TabIndex = 43;
            this.lblDxcs.Text = "地下层数";
            // 
            // intDxcs
            // 
            this.intDxcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDxcs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDxcs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDxcs.EnableTouchMode = true;
            this.intDxcs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDxcs.IntegerValue = ((long)(0));
            this.intDxcs.Location = new System.Drawing.Point(0,0);
            this.intDxcs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDxcs.Name = "intDxcs";
            this.intDxcs.NullString = "";
            this.intDxcs.Size = new System.Drawing.Size(152, 28);
            this.intDxcs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDxcs.TabIndex = 44;
            this.intDxcs.Text = "0";
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 45;
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
            this.txtBz.TabIndex = 46;
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
            this.tableLayoutPanel1.Controls.Add(this.lblLjzh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLjzh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZrzh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZrzh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMph, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMph, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYcjzmj, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblYcjzmj, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblYcdxmj, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblYcdxmj, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblYcqtmj, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblYcqtmj, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblScjzmj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblScjzmj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblScdxmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblScdxmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblScqtmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblScqtmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJgrq, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datJgrq, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg1, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg2, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg2, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg3, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg3, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJzwzt, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbJzwzt, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt1, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt2, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt2, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFwyt3, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwyt3, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZcs, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.intZcs, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDscs, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.intDscs, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDxcs, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.intDxcs, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 7, 6);
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
            // ucLjz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucLjz";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLjzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcdxmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYcqtmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScdxmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblScqtmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgrq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzwzt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwyt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDscs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLjzh;	
        private System.Windows.Forms.Label lblLjzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZrzh;	
        private System.Windows.Forms.Label lblZrzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMph;	
        private System.Windows.Forms.Label lblMph;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcjzmj;	
        private System.Windows.Forms.Label lblYcjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcdxmj;	
        private System.Windows.Forms.Label lblYcdxmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYcqtmj;	
        private System.Windows.Forms.Label lblYcqtmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScjzmj;	
        private System.Windows.Forms.Label lblScjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScdxmj;	
        private System.Windows.Forms.Label lblScdxmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblScqtmj;	
        private System.Windows.Forms.Label lblScqtmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJgrq;	
        private System.Windows.Forms.Label lblJgrq;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg1;	
        private System.Windows.Forms.Label lblFwjg1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg2;	
        private System.Windows.Forms.Label lblFwjg2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg3;	
        private System.Windows.Forms.Label lblFwjg3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJzwzt;	
        private System.Windows.Forms.Label lblJzwzt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt1;	
        private System.Windows.Forms.Label lblFwyt1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt2;	
        private System.Windows.Forms.Label lblFwyt2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwyt3;	
        private System.Windows.Forms.Label lblFwyt3;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZcs;	
        private System.Windows.Forms.Label lblZcs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDscs;	
        private System.Windows.Forms.Label lblDscs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDxcs;	
        private System.Windows.Forms.Label lblDxcs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}