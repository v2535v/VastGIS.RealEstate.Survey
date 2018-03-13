using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSurveyEntity
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
            this.lblFwlx = new System.Windows.Forms.Label();
            this.cmbFwlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJsbl = new System.Windows.Forms.Label();
            this.dblJsbl = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCh = new System.Windows.Forms.Label();
            this.txtCh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZrzh = new System.Windows.Forms.Label();
            this.txtZrzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSjc = new System.Windows.Forms.Label();
            this.intSjc = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblMyc = new System.Windows.Forms.Label();
            this.txtMyc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCjzmj = new System.Windows.Forms.Label();
            this.dblCjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCtnjzmj = new System.Windows.Forms.Label();
            this.dblCtnjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCytmj = new System.Windows.Forms.Label();
            this.dblCytmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCgyjzmj = new System.Windows.Forms.Label();
            this.dblCgyjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCftjzmj = new System.Windows.Forms.Label();
            this.dblCftjzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCbqmj = new System.Windows.Forms.Label();
            this.dblCbqmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblCg = new System.Windows.Forms.Label();
            this.dblCg = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSptymj = new System.Windows.Forms.Label();
            this.dblSptymj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJsbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSjc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMyc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCtnjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCytmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCgyjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCftjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCbqmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSptymj)).BeginInit();
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
            this.intID.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // lblFwlx
            // 
            this.lblFwlx.AutoSize = true;
            this.lblFwlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwlx.Location = new System.Drawing.Point(24, 45);
            this.lblFwlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwlx.Name = "lblFwlx";
            this.lblFwlx.Size = new System.Drawing.Size(53, 25);
            this.lblFwlx.TabIndex = 3;
            this.lblFwlx.Text = "房屋类型";
            // 
            // cmbFwlx
            // 
            this.cmbFwlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwlx.EnableTouchMode = true;
            this.cmbFwlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwlx.Location = new System.Drawing.Point(83, 38);
            this.cmbFwlx.Name = "cmbFwlx";
            this.cmbFwlx.Size = new System.Drawing.Size(158, 20);
            this.cmbFwlx.TabIndex = 4;
            // 
            // lblJsbl
            // 
            this.lblJsbl.AutoSize = true;
            this.lblJsbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJsbl.Location = new System.Drawing.Point(24, 80);
            this.lblJsbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJsbl.Name = "lblJsbl";
            this.lblJsbl.Size = new System.Drawing.Size(53, 25);
            this.lblJsbl.TabIndex = 5;
            this.lblJsbl.Text = "计算比例";
            // 
            // dblJsbl
            // 
            this.dblJsbl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJsbl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJsbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJsbl.DoubleValue = 1D;
            this.dblJsbl.EnableTouchMode = true;
            this.dblJsbl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJsbl.Location = new System.Drawing.Point(83, 73);
            this.dblJsbl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJsbl.Name = "dblJsbl";
            this.dblJsbl.NullString = "";
            this.dblJsbl.Size = new System.Drawing.Size(158, 28);
            this.dblJsbl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJsbl.TabIndex = 6;
            this.dblJsbl.Text = "1.00";
            // 
            // lblCh
            // 
            this.lblCh.AutoSize = true;
            this.lblCh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCh.Location = new System.Drawing.Point(48, 115);
            this.lblCh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCh.Name = "lblCh";
            this.lblCh.Size = new System.Drawing.Size(29, 25);
            this.lblCh.TabIndex = 7;
            this.lblCh.Text = "层号";
            // 
            // txtCh
            // 
            this.txtCh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCh.EnableTouchMode = true;
            this.txtCh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCh.Location = new System.Drawing.Point(83, 108);
            this.txtCh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(158, 28);
            this.txtCh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCh.TabIndex = 8;
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
            this.txtZrzh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZrzh.Location = new System.Drawing.Point(83, 143);
            this.txtZrzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZrzh.Name = "txtZrzh";
            this.txtZrzh.Size = new System.Drawing.Size(158, 28);
            this.txtZrzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZrzh.TabIndex = 10;
            // 
            // lblYsdm
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(24, 185);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(53, 25);
            this.lblYsdm.TabIndex = 11;
            this.lblYsdm.Text = "要素代码";
            // 
            // txtYsdm
            // 
            this.txtYsdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsdm.EnableTouchMode = true;
            this.txtYsdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsdm.Location = new System.Drawing.Point(83, 178);
            this.txtYsdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsdm.Name = "txtYsdm";
            this.txtYsdm.Size = new System.Drawing.Size(158, 28);
            this.txtYsdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsdm.TabIndex = 12;
            // 
            // lblSjc
            // 
            this.lblSjc.AutoSize = true;
            this.lblSjc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjc.Location = new System.Drawing.Point(36, 220);
            this.lblSjc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjc.Name = "lblSjc";
            this.lblSjc.Size = new System.Drawing.Size(41, 25);
            this.lblSjc.TabIndex = 13;
            this.lblSjc.Text = "实际层";
            // 
            // intSjc
            // 
            this.intSjc.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSjc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSjc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSjc.EnableTouchMode = true;
            this.intSjc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSjc.IntegerValue = ((long)(0));
            this.intSjc.Location = new System.Drawing.Point(83, 213);
            this.intSjc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSjc.Name = "intSjc";
            this.intSjc.NullString = "";
            this.intSjc.Size = new System.Drawing.Size(158, 28);
            this.intSjc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSjc.TabIndex = 14;
            this.intSjc.Text = "0";
            // 
            // lblMyc
            // 
            this.lblMyc.AutoSize = true;
            this.lblMyc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMyc.Location = new System.Drawing.Point(36, 255);
            this.lblMyc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMyc.Name = "lblMyc";
            this.lblMyc.Size = new System.Drawing.Size(41, 41);
            this.lblMyc.TabIndex = 15;
            this.lblMyc.Text = "名义层";
            // 
            // txtMyc
            // 
            this.txtMyc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtMyc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMyc.EnableTouchMode = true;
            this.txtMyc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMyc.Location = new System.Drawing.Point(83, 248);
            this.txtMyc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMyc.Name = "txtMyc";
            this.txtMyc.Size = new System.Drawing.Size(158, 28);
            this.txtMyc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMyc.TabIndex = 16;
            // 
            // lblCjzmj
            // 
            this.lblCjzmj.AutoSize = true;
            this.lblCjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCjzmj.Location = new System.Drawing.Point(261, 10);
            this.lblCjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCjzmj.Name = "lblCjzmj";
            this.lblCjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblCjzmj.TabIndex = 17;
            this.lblCjzmj.Text = "层建筑面积";
            // 
            // dblCjzmj
            // 
            this.dblCjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCjzmj.DoubleValue = 1D;
            this.dblCjzmj.EnableTouchMode = true;
            this.dblCjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCjzmj.Location = new System.Drawing.Point(332, 3);
            this.dblCjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCjzmj.Name = "dblCjzmj";
            this.dblCjzmj.NullString = "";
            this.dblCjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblCjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCjzmj.TabIndex = 18;
            this.dblCjzmj.Text = "1.00";
            // 
            // lblCtnjzmj
            // 
            this.lblCtnjzmj.AutoSize = true;
            this.lblCtnjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCtnjzmj.Location = new System.Drawing.Point(261, 45);
            this.lblCtnjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCtnjzmj.Name = "lblCtnjzmj";
            this.lblCtnjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblCtnjzmj.TabIndex = 19;
            this.lblCtnjzmj.Text = "层套内建筑面积";
            // 
            // dblCtnjzmj
            // 
            this.dblCtnjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCtnjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCtnjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCtnjzmj.DoubleValue = 1D;
            this.dblCtnjzmj.EnableTouchMode = true;
            this.dblCtnjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCtnjzmj.Location = new System.Drawing.Point(332, 38);
            this.dblCtnjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCtnjzmj.Name = "dblCtnjzmj";
            this.dblCtnjzmj.NullString = "";
            this.dblCtnjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblCtnjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCtnjzmj.TabIndex = 20;
            this.dblCtnjzmj.Text = "1.00";
            // 
            // lblCytmj
            // 
            this.lblCytmj.AutoSize = true;
            this.lblCytmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCytmj.Location = new System.Drawing.Point(261, 80);
            this.lblCytmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCytmj.Name = "lblCytmj";
            this.lblCytmj.Size = new System.Drawing.Size(65, 25);
            this.lblCytmj.TabIndex = 21;
            this.lblCytmj.Text = "层阳台面积";
            // 
            // dblCytmj
            // 
            this.dblCytmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCytmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCytmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCytmj.DoubleValue = 1D;
            this.dblCytmj.EnableTouchMode = true;
            this.dblCytmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCytmj.Location = new System.Drawing.Point(332, 73);
            this.dblCytmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCytmj.Name = "dblCytmj";
            this.dblCytmj.NullString = "";
            this.dblCytmj.Size = new System.Drawing.Size(158, 28);
            this.dblCytmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCytmj.TabIndex = 22;
            this.dblCytmj.Text = "1.00";
            // 
            // lblCgyjzmj
            // 
            this.lblCgyjzmj.AutoSize = true;
            this.lblCgyjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCgyjzmj.Location = new System.Drawing.Point(261, 115);
            this.lblCgyjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCgyjzmj.Name = "lblCgyjzmj";
            this.lblCgyjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblCgyjzmj.TabIndex = 23;
            this.lblCgyjzmj.Text = "层共有建筑面积";
            // 
            // dblCgyjzmj
            // 
            this.dblCgyjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCgyjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCgyjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCgyjzmj.DoubleValue = 1D;
            this.dblCgyjzmj.EnableTouchMode = true;
            this.dblCgyjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCgyjzmj.Location = new System.Drawing.Point(332, 108);
            this.dblCgyjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCgyjzmj.Name = "dblCgyjzmj";
            this.dblCgyjzmj.NullString = "";
            this.dblCgyjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblCgyjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCgyjzmj.TabIndex = 24;
            this.dblCgyjzmj.Text = "1.00";
            // 
            // lblCftjzmj
            // 
            this.lblCftjzmj.AutoSize = true;
            this.lblCftjzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCftjzmj.Location = new System.Drawing.Point(261, 150);
            this.lblCftjzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCftjzmj.Name = "lblCftjzmj";
            this.lblCftjzmj.Size = new System.Drawing.Size(65, 25);
            this.lblCftjzmj.TabIndex = 25;
            this.lblCftjzmj.Text = "层分摊建筑面积";
            // 
            // dblCftjzmj
            // 
            this.dblCftjzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCftjzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCftjzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCftjzmj.DoubleValue = 1D;
            this.dblCftjzmj.EnableTouchMode = true;
            this.dblCftjzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCftjzmj.Location = new System.Drawing.Point(332, 143);
            this.dblCftjzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCftjzmj.Name = "dblCftjzmj";
            this.dblCftjzmj.NullString = "";
            this.dblCftjzmj.Size = new System.Drawing.Size(158, 28);
            this.dblCftjzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCftjzmj.TabIndex = 26;
            this.dblCftjzmj.Text = "1.00";
            // 
            // lblCbqmj
            // 
            this.lblCbqmj.AutoSize = true;
            this.lblCbqmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCbqmj.Location = new System.Drawing.Point(261, 185);
            this.lblCbqmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCbqmj.Name = "lblCbqmj";
            this.lblCbqmj.Size = new System.Drawing.Size(65, 25);
            this.lblCbqmj.TabIndex = 27;
            this.lblCbqmj.Text = "层半墙面积";
            // 
            // dblCbqmj
            // 
            this.dblCbqmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCbqmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCbqmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCbqmj.DoubleValue = 1D;
            this.dblCbqmj.EnableTouchMode = true;
            this.dblCbqmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCbqmj.Location = new System.Drawing.Point(332, 178);
            this.dblCbqmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCbqmj.Name = "dblCbqmj";
            this.dblCbqmj.NullString = "";
            this.dblCbqmj.Size = new System.Drawing.Size(158, 28);
            this.dblCbqmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCbqmj.TabIndex = 28;
            this.dblCbqmj.Text = "1.00";
            // 
            // lblCg
            // 
            this.lblCg.AutoSize = true;
            this.lblCg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCg.Location = new System.Drawing.Point(297, 220);
            this.lblCg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCg.Name = "lblCg";
            this.lblCg.Size = new System.Drawing.Size(29, 25);
            this.lblCg.TabIndex = 29;
            this.lblCg.Text = "层高";
            // 
            // dblCg
            // 
            this.dblCg.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblCg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblCg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblCg.DoubleValue = 1D;
            this.dblCg.EnableTouchMode = true;
            this.dblCg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblCg.Location = new System.Drawing.Point(332, 213);
            this.dblCg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblCg.Name = "dblCg";
            this.dblCg.NullString = "";
            this.dblCg.Size = new System.Drawing.Size(158, 28);
            this.dblCg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblCg.TabIndex = 30;
            this.dblCg.Text = "1.00";
            // 
            // lblSptymj
            // 
            this.lblSptymj.AutoSize = true;
            this.lblSptymj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSptymj.Location = new System.Drawing.Point(261, 255);
            this.lblSptymj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSptymj.Name = "lblSptymj";
            this.lblSptymj.Size = new System.Drawing.Size(65, 41);
            this.lblSptymj.TabIndex = 31;
            this.lblSptymj.Text = "水平投影面积";
            // 
            // dblSptymj
            // 
            this.dblSptymj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSptymj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSptymj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSptymj.DoubleValue = 1D;
            this.dblSptymj.EnableTouchMode = true;
            this.dblSptymj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSptymj.Location = new System.Drawing.Point(332, 248);
            this.dblSptymj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSptymj.Name = "dblSptymj";
            this.dblSptymj.NullString = "";
            this.dblSptymj.Size = new System.Drawing.Size(158, 28);
            this.dblSptymj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSptymj.TabIndex = 32;
            this.dblSptymj.Text = "1.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFwlx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwlx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJsbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblJsbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZrzh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZrzh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSjc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.intSjc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMyc, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtMyc, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblCjzmj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblCjzmj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCtnjzmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblCtnjzmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCytmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblCytmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCgyjzmj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblCgyjzmj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCftjzmj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblCftjzmj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCbqmj, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblCbqmj, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCg, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblCg, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSptymj, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblSptymj, 4, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 296);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // ucSurveyEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSurveyEntity";
            this.Size = new System.Drawing.Size(500, 296);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJsbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZrzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSjc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMyc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCtnjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCytmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCgyjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCftjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCbqmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblCg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSptymj)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwlx;	
        private System.Windows.Forms.Label lblFwlx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJsbl;	
        private System.Windows.Forms.Label lblJsbl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCh;	
        private System.Windows.Forms.Label lblCh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZrzh;	
        private System.Windows.Forms.Label lblZrzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSjc;	
        private System.Windows.Forms.Label lblSjc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMyc;	
        private System.Windows.Forms.Label lblMyc;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCjzmj;	
        private System.Windows.Forms.Label lblCjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCtnjzmj;	
        private System.Windows.Forms.Label lblCtnjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCytmj;	
        private System.Windows.Forms.Label lblCytmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCgyjzmj;	
        private System.Windows.Forms.Label lblCgyjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCftjzmj;	
        private System.Windows.Forms.Label lblCftjzmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCbqmj;	
        private System.Windows.Forms.Label lblCbqmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblCg;	
        private System.Windows.Forms.Label lblCg;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSptymj;	
        private System.Windows.Forms.Label lblSptymj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}