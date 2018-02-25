using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZhjbxx
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
            this.lblZhdm = new System.Windows.Forms.Label();
            this.txtZhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdcdyh = new System.Windows.Forms.Label();
            this.txtBdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZhtzm = new System.Windows.Forms.Label();
            this.cmbZhtzm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblXmmc = new System.Windows.Forms.Label();
            this.txtXmmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXmxz = new System.Windows.Forms.Label();
            this.cmbXmxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYhzmj = new System.Windows.Forms.Label();
            this.dblYhzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZhmj = new System.Windows.Forms.Label();
            this.dblZhmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.cmbDb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZhax = new System.Windows.Forms.Label();
            this.dblZhax = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYhlxa = new System.Windows.Forms.Label();
            this.cmbYhlxa = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYhlxb = new System.Windows.Forms.Label();
            this.cmbYhlxb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYhwzsm = new System.Windows.Forms.Label();
            this.txtYhwzsm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHdmc = new System.Windows.Forms.Label();
            this.txtHdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHddm = new System.Windows.Forms.Label();
            this.txtHddm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYdfw = new System.Windows.Forms.Label();
            this.txtYdfw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYdmj = new System.Windows.Forms.Label();
            this.dblYdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblHdwz = new System.Windows.Forms.Label();
            this.txtHdwz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHdyt = new System.Windows.Forms.Label();
            this.cmbHdyt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZht = new System.Windows.Forms.Label();
            this.txtZht = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDah = new System.Windows.Forms.Label();
            this.txtDah = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.cmbZt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZhtzm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXmxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYhzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZhmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZhax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhlxa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhlxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYhwzsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYdfw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdwz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHdyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).BeginInit();
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
            this.lblZhdm.AutoSize = true;
            this.lblZhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhdm.Location = new System.Drawing.Point(0,0);
            this.lblZhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhdm.Name = "lblZhdm";
            this.lblZhdm.Size = new System.Drawing.Size(41, 20);
            this.lblZhdm.TabIndex = 5;
            this.lblZhdm.Text = "宗海代码";
            // 
            // txtZhdm
            // 
            this.txtZhdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZhdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZhdm.EnableTouchMode = true;
            this.txtZhdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZhdm.Location =  new System.Drawing.Point(0,0);
            this.txtZhdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZhdm.Name = "txtZhdm";
            this.txtZhdm.Size = new System.Drawing.Size(152, 28);
            this.txtZhdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZhdm.TabIndex = 6;
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
            this.lblZhtzm.AutoSize = true;
            this.lblZhtzm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhtzm.Location = new System.Drawing.Point(0,0);
            this.lblZhtzm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhtzm.Name = "lblZhtzm";
            this.lblZhtzm.Size = new System.Drawing.Size(41, 20);
            this.lblZhtzm.TabIndex = 9;
            this.lblZhtzm.Text = "宗海特征码";
            // 
            // cmbZhtzm
            // 
            this.cmbZhtzm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZhtzm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZhtzm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZhtzm.EnableTouchMode = true;
            this.cmbZhtzm.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZhtzm.Location =  new System.Drawing.Point(0,0);
            this.cmbZhtzm.Name = "cmbZhtzm";
            this.cmbZhtzm.Size = new System.Drawing.Size(152, 20);
            this.cmbZhtzm.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblXmmc.AutoSize = true;
            this.lblXmmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXmmc.Location = new System.Drawing.Point(0,0);
            this.lblXmmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXmmc.Name = "lblXmmc";
            this.lblXmmc.Size = new System.Drawing.Size(41, 20);
            this.lblXmmc.TabIndex = 11;
            this.lblXmmc.Text = "项目名称";
            // 
            // txtXmmc
            // 
            this.txtXmmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXmmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXmmc.EnableTouchMode = true;
            this.txtXmmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXmmc.Location =  new System.Drawing.Point(0,0);
            this.txtXmmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXmmc.Name = "txtXmmc";
            this.txtXmmc.Size = new System.Drawing.Size(152, 28);
            this.txtXmmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXmmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblXmxz.AutoSize = true;
            this.lblXmxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXmxz.Location = new System.Drawing.Point(0,0);
            this.lblXmxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXmxz.Name = "lblXmxz";
            this.lblXmxz.Size = new System.Drawing.Size(41, 20);
            this.lblXmxz.TabIndex = 13;
            this.lblXmxz.Text = "项目性质";
            // 
            // cmbXmxz
            // 
            this.cmbXmxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbXmxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbXmxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXmxz.EnableTouchMode = true;
            this.cmbXmxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXmxz.Location =  new System.Drawing.Point(0,0);
            this.cmbXmxz.Name = "cmbXmxz";
            this.cmbXmxz.Size = new System.Drawing.Size(152, 20);
            this.cmbXmxz.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblYhzmj.AutoSize = true;
            this.lblYhzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhzmj.Location = new System.Drawing.Point(0,0);
            this.lblYhzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhzmj.Name = "lblYhzmj";
            this.lblYhzmj.Size = new System.Drawing.Size(41, 20);
            this.lblYhzmj.TabIndex = 15;
            this.lblYhzmj.Text = "用海总面积";
            // 
            // dblYhzmj
            // 
            this.dblYhzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYhzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYhzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYhzmj.DoubleValue = 1D;
            this.dblYhzmj.EnableTouchMode = true;
            this.dblYhzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYhzmj.Location =  new System.Drawing.Point(0,0);
            this.dblYhzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYhzmj.Name = "dblYhzmj";
            this.dblYhzmj.NullString = "";
            this.dblYhzmj.Size = new System.Drawing.Size(152, 28);
            this.dblYhzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYhzmj.TabIndex = 16;
            this.dblYhzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZhmj.AutoSize = true;
            this.lblZhmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhmj.Location = new System.Drawing.Point(0,0);
            this.lblZhmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhmj.Name = "lblZhmj";
            this.lblZhmj.Size = new System.Drawing.Size(41, 20);
            this.lblZhmj.TabIndex = 17;
            this.lblZhmj.Text = "宗海面积";
            // 
            // dblZhmj
            // 
            this.dblZhmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZhmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZhmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZhmj.DoubleValue = 1D;
            this.dblZhmj.EnableTouchMode = true;
            this.dblZhmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZhmj.Location =  new System.Drawing.Point(0,0);
            this.dblZhmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZhmj.Name = "dblZhmj";
            this.dblZhmj.NullString = "";
            this.dblZhmj.Size = new System.Drawing.Size(152, 28);
            this.dblZhmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZhmj.TabIndex = 18;
            this.dblZhmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDb.Location = new System.Drawing.Point(0,0);
            this.lblDb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(41, 20);
            this.lblDb.TabIndex = 19;
            this.lblDb.Text = "等别";
            // 
            // cmbDb
            // 
            this.cmbDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDb.EnableTouchMode = true;
            this.cmbDb.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDb.Location =  new System.Drawing.Point(0,0);
            this.cmbDb.Name = "cmbDb";
            this.cmbDb.Size = new System.Drawing.Size(152, 20);
            this.cmbDb.TabIndex =  20;            
            // 
            // lblID
            // 
            this.lblZhax.AutoSize = true;
            this.lblZhax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhax.Location = new System.Drawing.Point(0,0);
            this.lblZhax.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhax.Name = "lblZhax";
            this.lblZhax.Size = new System.Drawing.Size(41, 20);
            this.lblZhax.TabIndex = 21;
            this.lblZhax.Text = "占海岸线";
            // 
            // dblZhax
            // 
            this.dblZhax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZhax.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZhax.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZhax.DoubleValue = 1D;
            this.dblZhax.EnableTouchMode = true;
            this.dblZhax.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZhax.Location =  new System.Drawing.Point(0,0);
            this.dblZhax.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZhax.Name = "dblZhax";
            this.dblZhax.NullString = "";
            this.dblZhax.Size = new System.Drawing.Size(152, 28);
            this.dblZhax.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZhax.TabIndex = 22;
            this.dblZhax.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYhlxa.AutoSize = true;
            this.lblYhlxa.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhlxa.Location = new System.Drawing.Point(0,0);
            this.lblYhlxa.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhlxa.Name = "lblYhlxa";
            this.lblYhlxa.Size = new System.Drawing.Size(41, 20);
            this.lblYhlxa.TabIndex = 23;
            this.lblYhlxa.Text = "用海类型A";
            // 
            // cmbYhlxa
            // 
            this.cmbYhlxa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYhlxa.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYhlxa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYhlxa.EnableTouchMode = true;
            this.cmbYhlxa.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYhlxa.Location =  new System.Drawing.Point(0,0);
            this.cmbYhlxa.Name = "cmbYhlxa";
            this.cmbYhlxa.Size = new System.Drawing.Size(152, 20);
            this.cmbYhlxa.TabIndex =  24;            
            // 
            // lblID
            // 
            this.lblYhlxb.AutoSize = true;
            this.lblYhlxb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhlxb.Location = new System.Drawing.Point(0,0);
            this.lblYhlxb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhlxb.Name = "lblYhlxb";
            this.lblYhlxb.Size = new System.Drawing.Size(41, 20);
            this.lblYhlxb.TabIndex = 25;
            this.lblYhlxb.Text = "用海类型B";
            // 
            // cmbYhlxb
            // 
            this.cmbYhlxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYhlxb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYhlxb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYhlxb.EnableTouchMode = true;
            this.cmbYhlxb.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYhlxb.Location =  new System.Drawing.Point(0,0);
            this.cmbYhlxb.Name = "cmbYhlxb";
            this.cmbYhlxb.Size = new System.Drawing.Size(152, 20);
            this.cmbYhlxb.TabIndex =  26;            
            // 
            // lblID
            // 
            this.lblYhwzsm.AutoSize = true;
            this.lblYhwzsm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhwzsm.Location = new System.Drawing.Point(0,0);
            this.lblYhwzsm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhwzsm.Name = "lblYhwzsm";
            this.lblYhwzsm.Size = new System.Drawing.Size(41, 20);
            this.lblYhwzsm.TabIndex = 27;
            this.lblYhwzsm.Text = "用海位置说明";
            // 
            // txtYhwzsm
            // 
            this.txtYhwzsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYhwzsm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYhwzsm.EnableTouchMode = true;
            this.txtYhwzsm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYhwzsm.Location =  new System.Drawing.Point(0,0);
            this.txtYhwzsm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYhwzsm.Name = "txtYhwzsm";
            this.txtYhwzsm.Size = new System.Drawing.Size(152, 28);
            this.txtYhwzsm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYhwzsm.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblHdmc.AutoSize = true;
            this.lblHdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHdmc.Location = new System.Drawing.Point(0,0);
            this.lblHdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHdmc.Name = "lblHdmc";
            this.lblHdmc.Size = new System.Drawing.Size(41, 20);
            this.lblHdmc.TabIndex = 29;
            this.lblHdmc.Text = "海岛名称";
            // 
            // txtHdmc
            // 
            this.txtHdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHdmc.EnableTouchMode = true;
            this.txtHdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHdmc.Location =  new System.Drawing.Point(0,0);
            this.txtHdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHdmc.Name = "txtHdmc";
            this.txtHdmc.Size = new System.Drawing.Size(152, 28);
            this.txtHdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHdmc.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblHddm.AutoSize = true;
            this.lblHddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHddm.Location = new System.Drawing.Point(0,0);
            this.lblHddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHddm.Name = "lblHddm";
            this.lblHddm.Size = new System.Drawing.Size(41, 20);
            this.lblHddm.TabIndex = 31;
            this.lblHddm.Text = "海岛代码";
            // 
            // txtHddm
            // 
            this.txtHddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHddm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHddm.EnableTouchMode = true;
            this.txtHddm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHddm.Location =  new System.Drawing.Point(0,0);
            this.txtHddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHddm.Name = "txtHddm";
            this.txtHddm.Size = new System.Drawing.Size(152, 28);
            this.txtHddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHddm.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblYdfw.AutoSize = true;
            this.lblYdfw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYdfw.Location = new System.Drawing.Point(0,0);
            this.lblYdfw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYdfw.Name = "lblYdfw";
            this.lblYdfw.Size = new System.Drawing.Size(41, 20);
            this.lblYdfw.TabIndex = 33;
            this.lblYdfw.Text = "用岛范围";
            // 
            // txtYdfw
            // 
            this.txtYdfw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYdfw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYdfw.EnableTouchMode = true;
            this.txtYdfw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYdfw.Location =  new System.Drawing.Point(0,0);
            this.txtYdfw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYdfw.Name = "txtYdfw";
            this.txtYdfw.Size = new System.Drawing.Size(152, 28);
            this.txtYdfw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYdfw.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblYdmj.AutoSize = true;
            this.lblYdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYdmj.Location = new System.Drawing.Point(0,0);
            this.lblYdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYdmj.Name = "lblYdmj";
            this.lblYdmj.Size = new System.Drawing.Size(41, 20);
            this.lblYdmj.TabIndex = 35;
            this.lblYdmj.Text = "用岛面积";
            // 
            // dblYdmj
            // 
            this.dblYdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYdmj.DoubleValue = 1D;
            this.dblYdmj.EnableTouchMode = true;
            this.dblYdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYdmj.Location =  new System.Drawing.Point(0,0);
            this.dblYdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYdmj.Name = "dblYdmj";
            this.dblYdmj.NullString = "";
            this.dblYdmj.Size = new System.Drawing.Size(152, 28);
            this.dblYdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYdmj.TabIndex = 36;
            this.dblYdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblHdwz.AutoSize = true;
            this.lblHdwz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHdwz.Location = new System.Drawing.Point(0,0);
            this.lblHdwz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHdwz.Name = "lblHdwz";
            this.lblHdwz.Size = new System.Drawing.Size(41, 20);
            this.lblHdwz.TabIndex = 37;
            this.lblHdwz.Text = "海岛位置";
            // 
            // txtHdwz
            // 
            this.txtHdwz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHdwz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHdwz.EnableTouchMode = true;
            this.txtHdwz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHdwz.Location =  new System.Drawing.Point(0,0);
            this.txtHdwz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHdwz.Name = "txtHdwz";
            this.txtHdwz.Size = new System.Drawing.Size(152, 28);
            this.txtHdwz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHdwz.TabIndex = 38;
            // 
            // lblID
            // 
            this.lblHdyt.AutoSize = true;
            this.lblHdyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHdyt.Location = new System.Drawing.Point(0,0);
            this.lblHdyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHdyt.Name = "lblHdyt";
            this.lblHdyt.Size = new System.Drawing.Size(41, 20);
            this.lblHdyt.TabIndex = 39;
            this.lblHdyt.Text = "海岛用途";
            // 
            // cmbHdyt
            // 
            this.cmbHdyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbHdyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbHdyt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHdyt.EnableTouchMode = true;
            this.cmbHdyt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHdyt.Location =  new System.Drawing.Point(0,0);
            this.cmbHdyt.Name = "cmbHdyt";
            this.cmbHdyt.Size = new System.Drawing.Size(152, 20);
            this.cmbHdyt.TabIndex =  40;            
            // 
            // lblID
            // 
            this.lblZht.AutoSize = true;
            this.lblZht.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZht.Location = new System.Drawing.Point(0,0);
            this.lblZht.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZht.Name = "lblZht";
            this.lblZht.Size = new System.Drawing.Size(41, 20);
            this.lblZht.TabIndex = 41;
            this.lblZht.Text = "宗海图";
            // 
            // txtZht
            // 
            this.txtZht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZht.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZht.EnableTouchMode = true;
            this.txtZht.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZht.Location =  new System.Drawing.Point(0,0);
            this.txtZht.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZht.Name = "txtZht";
            this.txtZht.Size = new System.Drawing.Size(152, 28);
            this.txtZht.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZht.TabIndex = 42;
            // 
            // lblID
            // 
            this.lblDah.AutoSize = true;
            this.lblDah.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDah.Location = new System.Drawing.Point(0,0);
            this.lblDah.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDah.Name = "lblDah";
            this.lblDah.Size = new System.Drawing.Size(41, 20);
            this.lblDah.TabIndex = 43;
            this.lblDah.Text = "档案号";
            // 
            // txtDah
            // 
            this.txtDah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDah.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDah.EnableTouchMode = true;
            this.txtDah.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDah.Location =  new System.Drawing.Point(0,0);
            this.txtDah.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDah.Name = "txtDah";
            this.txtDah.Size = new System.Drawing.Size(152, 28);
            this.txtDah.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDah.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(0,0);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(41, 20);
            this.lblZt.TabIndex = 45;
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
            this.cmbZt.TabIndex =  46;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblZhdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZhdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZhtzm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbZhtzm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblXmmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtXmmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblXmxz, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbXmxz, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblYhzmj, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblYhzmj, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZhmj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblZhmj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDb, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbDb, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZhax, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblZhax, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYhlxa, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbYhlxa, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYhlxb, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbYhlxb, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYhwzsm, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYhwzsm, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblHdmc, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtHdmc, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblHddm, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtHddm, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYdfw, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtYdfw, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYdmj, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblYdmj, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHdwz, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHdwz, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHdyt, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbHdyt, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZht, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZht, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDah, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDah, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbZt, 7, 6);
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
            // ucZhjbxx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucZhjbxx";
            this.Size = new System.Drawing.Size(750, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZhtzm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbXmxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYhzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZhmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZhax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhlxa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhlxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYhwzsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYdfw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHdwz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHdyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZhdm;	
        private System.Windows.Forms.Label lblZhdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZhtzm;	
        private System.Windows.Forms.Label lblZhtzm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXmmc;	
        private System.Windows.Forms.Label lblXmmc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbXmxz;	
        private System.Windows.Forms.Label lblXmxz;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYhzmj;	
        private System.Windows.Forms.Label lblYhzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZhmj;	
        private System.Windows.Forms.Label lblZhmj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDb;	
        private System.Windows.Forms.Label lblDb;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZhax;	
        private System.Windows.Forms.Label lblZhax;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYhlxa;	
        private System.Windows.Forms.Label lblYhlxa;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYhlxb;	
        private System.Windows.Forms.Label lblYhlxb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYhwzsm;	
        private System.Windows.Forms.Label lblYhwzsm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHdmc;	
        private System.Windows.Forms.Label lblHdmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHddm;	
        private System.Windows.Forms.Label lblHddm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYdfw;	
        private System.Windows.Forms.Label lblYdfw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYdmj;	
        private System.Windows.Forms.Label lblYdmj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHdwz;	
        private System.Windows.Forms.Label lblHdwz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbHdyt;	
        private System.Windows.Forms.Label lblHdyt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZht;	
        private System.Windows.Forms.Label lblZht;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDah;	
        private System.Windows.Forms.Label lblDah;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZt;	
        private System.Windows.Forms.Label lblZt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}