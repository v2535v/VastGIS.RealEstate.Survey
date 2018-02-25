using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSj
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
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSjsj = new System.Windows.Forms.Label();
            this.datSjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblSjlx = new System.Windows.Forms.Label();
            this.cmbSjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSjmc = new System.Windows.Forms.Label();
            this.txtSjmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSjsl = new System.Windows.Forms.Label();
            this.intSjsl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblSfsjsy = new System.Windows.Forms.Label();
            this.cmbSfsjsy = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSfewsj = new System.Windows.Forms.Label();
            this.cmbSfewsj = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSfbcsj = new System.Windows.Forms.Label();
            this.cmbSfbcsj = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYs = new System.Windows.Forms.Label();
            this.intYs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSjsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfsjsy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfewsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfbcsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intYs)).BeginInit();
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
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 3;
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
            this.txtYwh.TabIndex = 4;
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
            this.lblSjsj.AutoSize = true;
            this.lblSjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjsj.Location = new System.Drawing.Point(0,0);
            this.lblSjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjsj.Name = "lblSjsj";
            this.lblSjsj.Size = new System.Drawing.Size(41, 20);
            this.lblSjsj.TabIndex = 7;
            this.lblSjsj.Text = "收件时间";
            // 
            // datSjsj
            // 
            this.datSjsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSjsj.BorderColor = System.Drawing.Color.Empty;
            this.datSjsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSjsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSjsj.DropDownImage = null;
            this.datSjsj.EnableTouchMode = true;
            this.datSjsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSjsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSjsj.Location =  new System.Drawing.Point(0,0);
            this.datSjsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSjsj.MinValue = new System.DateTime(((long)(0)));
            this.datSjsj.Name = "datSjsj";
            this.datSjsj.Size = new System.Drawing.Size(152, 20);
            this.datSjsj.TabIndex = 8;
            this.datSjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSjsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblSjlx.AutoSize = true;
            this.lblSjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjlx.Location = new System.Drawing.Point(0,0);
            this.lblSjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjlx.Name = "lblSjlx";
            this.lblSjlx.Size = new System.Drawing.Size(41, 20);
            this.lblSjlx.TabIndex = 9;
            this.lblSjlx.Text = "收件类型";
            // 
            // cmbSjlx
            // 
            this.cmbSjlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSjlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSjlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSjlx.EnableTouchMode = true;
            this.cmbSjlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSjlx.Location =  new System.Drawing.Point(0,0);
            this.cmbSjlx.Name = "cmbSjlx";
            this.cmbSjlx.Size = new System.Drawing.Size(152, 20);
            this.cmbSjlx.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblSjmc.AutoSize = true;
            this.lblSjmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjmc.Location = new System.Drawing.Point(0,0);
            this.lblSjmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjmc.Name = "lblSjmc";
            this.lblSjmc.Size = new System.Drawing.Size(41, 20);
            this.lblSjmc.TabIndex = 11;
            this.lblSjmc.Text = "收件名称";
            // 
            // txtSjmc
            // 
            this.txtSjmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSjmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSjmc.EnableTouchMode = true;
            this.txtSjmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSjmc.Location =  new System.Drawing.Point(0,0);
            this.txtSjmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSjmc.Name = "txtSjmc";
            this.txtSjmc.Size = new System.Drawing.Size(152, 28);
            this.txtSjmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSjmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSjsl.AutoSize = true;
            this.lblSjsl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjsl.Location = new System.Drawing.Point(0,0);
            this.lblSjsl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjsl.Name = "lblSjsl";
            this.lblSjsl.Size = new System.Drawing.Size(41, 20);
            this.lblSjsl.TabIndex = 13;
            this.lblSjsl.Text = "收件数量";
            // 
            // intSjsl
            // 
            this.intSjsl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSjsl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSjsl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSjsl.EnableTouchMode = true;
            this.intSjsl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSjsl.IntegerValue = ((long)(0));
            this.intSjsl.Location = new System.Drawing.Point(0,0);
            this.intSjsl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSjsl.Name = "intSjsl";
            this.intSjsl.NullString = "";
            this.intSjsl.Size = new System.Drawing.Size(152, 28);
            this.intSjsl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSjsl.TabIndex = 14;
            this.intSjsl.Text = "0";
            // 
            // lblID
            // 
            this.lblSfsjsy.AutoSize = true;
            this.lblSfsjsy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfsjsy.Location = new System.Drawing.Point(0,0);
            this.lblSfsjsy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfsjsy.Name = "lblSfsjsy";
            this.lblSfsjsy.Size = new System.Drawing.Size(41, 20);
            this.lblSfsjsy.TabIndex = 15;
            this.lblSfsjsy.Text = "是否收缴收验";
            // 
            // cmbSfsjsy
            // 
            this.cmbSfsjsy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfsjsy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfsjsy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfsjsy.EnableTouchMode = true;
            this.cmbSfsjsy.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfsjsy.Location =  new System.Drawing.Point(0,0);
            this.cmbSfsjsy.Name = "cmbSfsjsy";
            this.cmbSfsjsy.Size = new System.Drawing.Size(152, 20);
            this.cmbSfsjsy.TabIndex =  16;            
            // 
            // lblID
            // 
            this.lblSfewsj.AutoSize = true;
            this.lblSfewsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfewsj.Location = new System.Drawing.Point(0,0);
            this.lblSfewsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfewsj.Name = "lblSfewsj";
            this.lblSfewsj.Size = new System.Drawing.Size(41, 20);
            this.lblSfewsj.TabIndex = 17;
            this.lblSfewsj.Text = "是否额外收件";
            // 
            // cmbSfewsj
            // 
            this.cmbSfewsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfewsj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfewsj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfewsj.EnableTouchMode = true;
            this.cmbSfewsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfewsj.Location =  new System.Drawing.Point(0,0);
            this.cmbSfewsj.Name = "cmbSfewsj";
            this.cmbSfewsj.Size = new System.Drawing.Size(152, 20);
            this.cmbSfewsj.TabIndex =  18;            
            // 
            // lblID
            // 
            this.lblSfbcsj.AutoSize = true;
            this.lblSfbcsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfbcsj.Location = new System.Drawing.Point(0,0);
            this.lblSfbcsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfbcsj.Name = "lblSfbcsj";
            this.lblSfbcsj.Size = new System.Drawing.Size(41, 20);
            this.lblSfbcsj.TabIndex = 19;
            this.lblSfbcsj.Text = "是否补充收件";
            // 
            // cmbSfbcsj
            // 
            this.cmbSfbcsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfbcsj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfbcsj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfbcsj.EnableTouchMode = true;
            this.cmbSfbcsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfbcsj.Location =  new System.Drawing.Point(0,0);
            this.cmbSfbcsj.Name = "cmbSfbcsj";
            this.cmbSfbcsj.Size = new System.Drawing.Size(152, 20);
            this.cmbSfbcsj.TabIndex =  20;            
            // 
            // lblID
            // 
            this.lblYs.AutoSize = true;
            this.lblYs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYs.Location = new System.Drawing.Point(0,0);
            this.lblYs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYs.Name = "lblYs";
            this.lblYs.Size = new System.Drawing.Size(41, 20);
            this.lblYs.TabIndex = 21;
            this.lblYs.Text = "页数";
            // 
            // intYs
            // 
            this.intYs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intYs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intYs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intYs.EnableTouchMode = true;
            this.intYs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intYs.IntegerValue = ((long)(0));
            this.intYs.Location = new System.Drawing.Point(0,0);
            this.intYs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intYs.Name = "intYs";
            this.intYs.NullString = "";
            this.intYs.Size = new System.Drawing.Size(152, 28);
            this.intYs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intYs.TabIndex = 22;
            this.intYs.Text = "0";
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 23;
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
            this.txtBz.TabIndex = 24;
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
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSjsj, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.datSjsj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSjlx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbSjlx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSjmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSjmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSjsl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.intSjsl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSfsjsy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfsjsy, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSfewsj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfewsj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSfbcsj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfbcsj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYs, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.intYs, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 4, 5);
            this.tableLayoutPanel1.RowCount = 6;
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
            this.tableLayoutPanel1.TabIndex = 25; 
            //
            // ucSj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSj";
            this.Size = new System.Drawing.Size(500, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSjsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfsjsy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfewsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfbcsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intYs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSjsj;	
        private System.Windows.Forms.Label lblSjsj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSjlx;	
        private System.Windows.Forms.Label lblSjlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSjmc;	
        private System.Windows.Forms.Label lblSjmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSjsl;	
        private System.Windows.Forms.Label lblSjsl;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfsjsy;	
        private System.Windows.Forms.Label lblSfsjsy;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfewsj;	
        private System.Windows.Forms.Label lblSfewsj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfbcsj;	
        private System.Windows.Forms.Label lblSfbcsj;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intYs;	
        private System.Windows.Forms.Label lblYs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}