using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJzxzj
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
            this.lblGlysbh = new System.Windows.Forms.Label();
            this.txtGlysbh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZjnr = new System.Windows.Forms.Label();
            this.txtZjnr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.txtZt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYs = new System.Windows.Forms.Label();
            this.txtYs = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBs = new System.Windows.Forms.Label();
            this.intBs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblXz = new System.Windows.Forms.Label();
            this.txtXz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXhx = new System.Windows.Forms.Label();
            this.txtXhx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblKd = new System.Windows.Forms.Label();
            this.dblKd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblGd = new System.Windows.Forms.Label();
            this.dblGd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZjdzxjxzb = new System.Windows.Forms.Label();
            this.dblZjdzxjxzb = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZjdzxjyzb = new System.Windows.Forms.Label();
            this.dblZjdzxjyzb = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZjfx = new System.Windows.Forms.Label();
            this.dblZjfx = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlysbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXhx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjdzxjxzb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjdzxjyzb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjfx)).BeginInit();
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
            this.lblGlysbh.AutoSize = true;
            this.lblGlysbh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGlysbh.Location = new System.Drawing.Point(0,0);
            this.lblGlysbh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGlysbh.Name = "lblGlysbh";
            this.lblGlysbh.Size = new System.Drawing.Size(41, 20);
            this.lblGlysbh.TabIndex = 3;
            this.lblGlysbh.Text = "内部要素编号";
            // 
            // txtGlysbh
            // 
            this.txtGlysbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlysbh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGlysbh.EnableTouchMode = true;
            this.txtGlysbh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGlysbh.Location =  new System.Drawing.Point(0,0);
            this.txtGlysbh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGlysbh.Name = "txtGlysbh";
            this.txtGlysbh.Size = new System.Drawing.Size(152, 28);
            this.txtGlysbh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGlysbh.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 5;
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
            this.txtYsdm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblZjnr.AutoSize = true;
            this.lblZjnr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjnr.Location = new System.Drawing.Point(0,0);
            this.lblZjnr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjnr.Name = "lblZjnr";
            this.lblZjnr.Size = new System.Drawing.Size(41, 20);
            this.lblZjnr.TabIndex = 7;
            this.lblZjnr.Text = "注记内容";
            // 
            // txtZjnr
            // 
            this.txtZjnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjnr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjnr.EnableTouchMode = true;
            this.txtZjnr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjnr.Location =  new System.Drawing.Point(0,0);
            this.txtZjnr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjnr.Name = "txtZjnr";
            this.txtZjnr.Size = new System.Drawing.Size(152, 28);
            this.txtZjnr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjnr.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(0,0);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(41, 20);
            this.lblZt.TabIndex = 9;
            this.lblZt.Text = "字体";
            // 
            // txtZt
            // 
            this.txtZt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZt.EnableTouchMode = true;
            this.txtZt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZt.Location =  new System.Drawing.Point(0,0);
            this.txtZt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZt.Name = "txtZt";
            this.txtZt.Size = new System.Drawing.Size(152, 28);
            this.txtZt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZt.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblYs.AutoSize = true;
            this.lblYs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYs.Location = new System.Drawing.Point(0,0);
            this.lblYs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYs.Name = "lblYs";
            this.lblYs.Size = new System.Drawing.Size(41, 20);
            this.lblYs.TabIndex = 11;
            this.lblYs.Text = "颜色";
            // 
            // txtYs
            // 
            this.txtYs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYs.EnableTouchMode = true;
            this.txtYs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYs.Location =  new System.Drawing.Point(0,0);
            this.txtYs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYs.Name = "txtYs";
            this.txtYs.Size = new System.Drawing.Size(152, 28);
            this.txtYs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYs.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblBs.AutoSize = true;
            this.lblBs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBs.Location = new System.Drawing.Point(0,0);
            this.lblBs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBs.Name = "lblBs";
            this.lblBs.Size = new System.Drawing.Size(41, 20);
            this.lblBs.TabIndex = 13;
            this.lblBs.Text = "磅数";
            // 
            // intBs
            // 
            this.intBs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intBs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intBs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intBs.EnableTouchMode = true;
            this.intBs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intBs.IntegerValue = ((long)(0));
            this.intBs.Location = new System.Drawing.Point(0,0);
            this.intBs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intBs.Name = "intBs";
            this.intBs.NullString = "";
            this.intBs.Size = new System.Drawing.Size(152, 28);
            this.intBs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intBs.TabIndex = 14;
            this.intBs.Text = "0";
            // 
            // lblID
            // 
            this.lblXz.AutoSize = true;
            this.lblXz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXz.Location = new System.Drawing.Point(0,0);
            this.lblXz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXz.Name = "lblXz";
            this.lblXz.Size = new System.Drawing.Size(41, 20);
            this.lblXz.TabIndex = 15;
            this.lblXz.Text = "形状";
            // 
            // txtXz
            // 
            this.txtXz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXz.EnableTouchMode = true;
            this.txtXz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXz.Location =  new System.Drawing.Point(0,0);
            this.txtXz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXz.Name = "txtXz";
            this.txtXz.Size = new System.Drawing.Size(152, 28);
            this.txtXz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXz.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblXhx.AutoSize = true;
            this.lblXhx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXhx.Location = new System.Drawing.Point(0,0);
            this.lblXhx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXhx.Name = "lblXhx";
            this.lblXhx.Size = new System.Drawing.Size(41, 20);
            this.lblXhx.TabIndex = 17;
            this.lblXhx.Text = "下划线";
            // 
            // txtXhx
            // 
            this.txtXhx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXhx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXhx.EnableTouchMode = true;
            this.txtXhx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXhx.Location =  new System.Drawing.Point(0,0);
            this.txtXhx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXhx.Name = "txtXhx";
            this.txtXhx.Size = new System.Drawing.Size(152, 28);
            this.txtXhx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXhx.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblKd.AutoSize = true;
            this.lblKd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblKd.Location = new System.Drawing.Point(0,0);
            this.lblKd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblKd.Name = "lblKd";
            this.lblKd.Size = new System.Drawing.Size(41, 20);
            this.lblKd.TabIndex = 19;
            this.lblKd.Text = "宽度";
            // 
            // dblKd
            // 
            this.dblKd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblKd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblKd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblKd.DoubleValue = 1D;
            this.dblKd.EnableTouchMode = true;
            this.dblKd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblKd.Location =  new System.Drawing.Point(0,0);
            this.dblKd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblKd.Name = "dblKd";
            this.dblKd.NullString = "";
            this.dblKd.Size = new System.Drawing.Size(152, 28);
            this.dblKd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblKd.TabIndex = 20;
            this.dblKd.Text = "1.00";
            // 
            // lblID
            // 
            this.lblGd.AutoSize = true;
            this.lblGd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGd.Location = new System.Drawing.Point(0,0);
            this.lblGd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGd.Name = "lblGd";
            this.lblGd.Size = new System.Drawing.Size(41, 20);
            this.lblGd.TabIndex = 21;
            this.lblGd.Text = "高度";
            // 
            // dblGd
            // 
            this.dblGd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblGd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblGd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblGd.DoubleValue = 1D;
            this.dblGd.EnableTouchMode = true;
            this.dblGd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblGd.Location =  new System.Drawing.Point(0,0);
            this.dblGd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblGd.Name = "dblGd";
            this.dblGd.NullString = "";
            this.dblGd.Size = new System.Drawing.Size(152, 28);
            this.dblGd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblGd.TabIndex = 22;
            this.dblGd.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZjdzxjxzb.AutoSize = true;
            this.lblZjdzxjxzb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjdzxjxzb.Location = new System.Drawing.Point(0,0);
            this.lblZjdzxjxzb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjdzxjxzb.Name = "lblZjdzxjxzb";
            this.lblZjdzxjxzb.Size = new System.Drawing.Size(41, 20);
            this.lblZjdzxjxzb.TabIndex = 23;
            this.lblZjdzxjxzb.Text = "注记点左下角X坐标";
            // 
            // dblZjdzxjxzb
            // 
            this.dblZjdzxjxzb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZjdzxjxzb.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZjdzxjxzb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZjdzxjxzb.DoubleValue = 1D;
            this.dblZjdzxjxzb.EnableTouchMode = true;
            this.dblZjdzxjxzb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZjdzxjxzb.Location =  new System.Drawing.Point(0,0);
            this.dblZjdzxjxzb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZjdzxjxzb.Name = "dblZjdzxjxzb";
            this.dblZjdzxjxzb.NullString = "";
            this.dblZjdzxjxzb.Size = new System.Drawing.Size(152, 28);
            this.dblZjdzxjxzb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZjdzxjxzb.TabIndex = 24;
            this.dblZjdzxjxzb.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZjdzxjyzb.AutoSize = true;
            this.lblZjdzxjyzb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjdzxjyzb.Location = new System.Drawing.Point(0,0);
            this.lblZjdzxjyzb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjdzxjyzb.Name = "lblZjdzxjyzb";
            this.lblZjdzxjyzb.Size = new System.Drawing.Size(41, 20);
            this.lblZjdzxjyzb.TabIndex = 25;
            this.lblZjdzxjyzb.Text = "注记点左下角Y坐标";
            // 
            // dblZjdzxjyzb
            // 
            this.dblZjdzxjyzb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZjdzxjyzb.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZjdzxjyzb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZjdzxjyzb.DoubleValue = 1D;
            this.dblZjdzxjyzb.EnableTouchMode = true;
            this.dblZjdzxjyzb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZjdzxjyzb.Location =  new System.Drawing.Point(0,0);
            this.dblZjdzxjyzb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZjdzxjyzb.Name = "dblZjdzxjyzb";
            this.dblZjdzxjyzb.NullString = "";
            this.dblZjdzxjyzb.Size = new System.Drawing.Size(152, 28);
            this.dblZjdzxjyzb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZjdzxjyzb.TabIndex = 26;
            this.dblZjdzxjyzb.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZjfx.AutoSize = true;
            this.lblZjfx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjfx.Location = new System.Drawing.Point(0,0);
            this.lblZjfx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjfx.Name = "lblZjfx";
            this.lblZjfx.Size = new System.Drawing.Size(41, 20);
            this.lblZjfx.TabIndex = 27;
            this.lblZjfx.Text = "注记方向";
            // 
            // dblZjfx
            // 
            this.dblZjfx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZjfx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZjfx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZjfx.DoubleValue = 1D;
            this.dblZjfx.EnableTouchMode = true;
            this.dblZjfx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZjfx.Location =  new System.Drawing.Point(0,0);
            this.dblZjfx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZjfx.Name = "dblZjfx";
            this.dblZjfx.NullString = "";
            this.dblZjfx.Size = new System.Drawing.Size(152, 28);
            this.dblZjfx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZjfx.TabIndex = 28;
            this.dblZjfx.Text = "1.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGlysbh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGlysbh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZjnr, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZjnr, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYs, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYs, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBs, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.intBs, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblXz, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtXz, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXhx, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXhx, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblKd, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblKd, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblGd, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZjdzxjxzb, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblZjdzxjxzb, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZjdzxjyzb, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblZjdzxjyzb, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZjfx, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblZjfx, 4, 6);
            this.tableLayoutPanel1.RowCount = 7;
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
            this.tableLayoutPanel1.TabIndex = 29; 
            //
            // ucJzxzj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucJzxzj";
            this.Size = new System.Drawing.Size(500, 261);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlysbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXhx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblGd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjdzxjxzb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjdzxjyzb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZjfx)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGlysbh;	
        private System.Windows.Forms.Label lblGlysbh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjnr;	
        private System.Windows.Forms.Label lblZjnr;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZt;	
        private System.Windows.Forms.Label lblZt;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYs;	
        private System.Windows.Forms.Label lblYs;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intBs;	
        private System.Windows.Forms.Label lblBs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXz;	
        private System.Windows.Forms.Label lblXz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXhx;	
        private System.Windows.Forms.Label lblXhx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblKd;	
        private System.Windows.Forms.Label lblKd;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblGd;	
        private System.Windows.Forms.Label lblGd;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZjdzxjxzb;	
        private System.Windows.Forms.Label lblZjdzxjxzb;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZjdzxjyzb;	
        private System.Windows.Forms.Label lblZjdzxjyzb;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZjfx;	
        private System.Windows.Forms.Label lblZjfx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}