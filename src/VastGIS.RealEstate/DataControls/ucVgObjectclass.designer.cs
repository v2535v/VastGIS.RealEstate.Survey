using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgObjectclass
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
            this.lblMc = new System.Windows.Forms.Label();
            this.txtMc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDxlx = new System.Windows.Forms.Label();
            this.intDxlx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZwmc = new System.Windows.Forms.Label();
            this.txtZwmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFbmc = new System.Windows.Forms.Label();
            this.txtFbmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXhzdmc = new System.Windows.Forms.Label();
            this.txtXhzdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTxzdmc = new System.Windows.Forms.Label();
            this.txtTxzdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTxlx = new System.Windows.Forms.Label();
            this.intTxlx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblIdentify = new System.Windows.Forms.Label();
            this.txtIdentify = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblEditable = new System.Windows.Forms.Label();
            this.txtEditable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQueryable = new System.Windows.Forms.Label();
            this.txtQueryable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSnapable = new System.Windows.Forms.Label();
            this.txtSnapable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblVisible = new System.Windows.Forms.Label();
            this.txtVisible = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXssx = new System.Windows.Forms.Label();
            this.intXssx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQsdm = new System.Windows.Forms.Label();
            this.txtQsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBjct = new System.Windows.Forms.Label();
            this.txtBjct = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBhfj = new System.Windows.Forms.Label();
            this.txtBhfj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZwmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXhzdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTxzdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTxlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXssx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBjct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhfj)).BeginInit();
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
            this.lblMc.AutoSize = true;
            this.lblMc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMc.Location = new System.Drawing.Point(0,0);
            this.lblMc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMc.Name = "lblMc";
            this.lblMc.Size = new System.Drawing.Size(41, 20);
            this.lblMc.TabIndex = 3;
            this.lblMc.Text = "名称";
            // 
            // txtMc
            // 
            this.txtMc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtMc.EnableTouchMode = true;
            this.txtMc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMc.Location =  new System.Drawing.Point(0,0);
            this.txtMc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(152, 28);
            this.txtMc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMc.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblDxlx.AutoSize = true;
            this.lblDxlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDxlx.Location = new System.Drawing.Point(0,0);
            this.lblDxlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDxlx.Name = "lblDxlx";
            this.lblDxlx.Size = new System.Drawing.Size(41, 20);
            this.lblDxlx.TabIndex = 5;
            this.lblDxlx.Text = "对象类型";
            // 
            // intDxlx
            // 
            this.intDxlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intDxlx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intDxlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intDxlx.EnableTouchMode = true;
            this.intDxlx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intDxlx.IntegerValue = ((long)(0));
            this.intDxlx.Location = new System.Drawing.Point(0,0);
            this.intDxlx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intDxlx.Name = "intDxlx";
            this.intDxlx.NullString = "";
            this.intDxlx.Size = new System.Drawing.Size(152, 28);
            this.intDxlx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intDxlx.TabIndex = 6;
            this.intDxlx.Text = "0";
            // 
            // lblID
            // 
            this.lblZwmc.AutoSize = true;
            this.lblZwmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZwmc.Location = new System.Drawing.Point(0,0);
            this.lblZwmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZwmc.Name = "lblZwmc";
            this.lblZwmc.Size = new System.Drawing.Size(41, 20);
            this.lblZwmc.TabIndex = 7;
            this.lblZwmc.Text = "中文名称";
            // 
            // txtZwmc
            // 
            this.txtZwmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZwmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZwmc.EnableTouchMode = true;
            this.txtZwmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZwmc.Location =  new System.Drawing.Point(0,0);
            this.txtZwmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZwmc.Name = "txtZwmc";
            this.txtZwmc.Size = new System.Drawing.Size(152, 28);
            this.txtZwmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZwmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblFbmc.AutoSize = true;
            this.lblFbmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFbmc.Location = new System.Drawing.Point(0,0);
            this.lblFbmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFbmc.Name = "lblFbmc";
            this.lblFbmc.Size = new System.Drawing.Size(41, 20);
            this.lblFbmc.TabIndex = 9;
            this.lblFbmc.Text = "父表名称";
            // 
            // txtFbmc
            // 
            this.txtFbmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFbmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFbmc.EnableTouchMode = true;
            this.txtFbmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFbmc.Location =  new System.Drawing.Point(0,0);
            this.txtFbmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFbmc.Name = "txtFbmc";
            this.txtFbmc.Size = new System.Drawing.Size(152, 28);
            this.txtFbmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFbmc.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblXhzdmc.AutoSize = true;
            this.lblXhzdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXhzdmc.Location = new System.Drawing.Point(0,0);
            this.lblXhzdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXhzdmc.Name = "lblXhzdmc";
            this.lblXhzdmc.Size = new System.Drawing.Size(41, 20);
            this.lblXhzdmc.TabIndex = 11;
            this.lblXhzdmc.Text = "序号字段名称";
            // 
            // txtXhzdmc
            // 
            this.txtXhzdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXhzdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXhzdmc.EnableTouchMode = true;
            this.txtXhzdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXhzdmc.Location =  new System.Drawing.Point(0,0);
            this.txtXhzdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXhzdmc.Name = "txtXhzdmc";
            this.txtXhzdmc.Size = new System.Drawing.Size(152, 28);
            this.txtXhzdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXhzdmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblTxzdmc.AutoSize = true;
            this.lblTxzdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTxzdmc.Location = new System.Drawing.Point(0,0);
            this.lblTxzdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTxzdmc.Name = "lblTxzdmc";
            this.lblTxzdmc.Size = new System.Drawing.Size(41, 20);
            this.lblTxzdmc.TabIndex = 13;
            this.lblTxzdmc.Text = "图形字段名称";
            // 
            // txtTxzdmc
            // 
            this.txtTxzdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTxzdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTxzdmc.EnableTouchMode = true;
            this.txtTxzdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTxzdmc.Location =  new System.Drawing.Point(0,0);
            this.txtTxzdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTxzdmc.Name = "txtTxzdmc";
            this.txtTxzdmc.Size = new System.Drawing.Size(152, 28);
            this.txtTxzdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTxzdmc.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblTxlx.AutoSize = true;
            this.lblTxlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTxlx.Location = new System.Drawing.Point(0,0);
            this.lblTxlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTxlx.Name = "lblTxlx";
            this.lblTxlx.Size = new System.Drawing.Size(41, 20);
            this.lblTxlx.TabIndex = 15;
            this.lblTxlx.Text = "图形类型";
            // 
            // intTxlx
            // 
            this.intTxlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intTxlx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intTxlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intTxlx.EnableTouchMode = true;
            this.intTxlx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intTxlx.IntegerValue = ((long)(0));
            this.intTxlx.Location = new System.Drawing.Point(0,0);
            this.intTxlx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intTxlx.Name = "intTxlx";
            this.intTxlx.NullString = "";
            this.intTxlx.Size = new System.Drawing.Size(152, 28);
            this.intTxlx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intTxlx.TabIndex = 16;
            this.intTxlx.Text = "0";
            // 
            // lblID
            // 
            this.lblIdentify.AutoSize = true;
            this.lblIdentify.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIdentify.Location = new System.Drawing.Point(0,0);
            this.lblIdentify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblIdentify.Name = "lblIdentify";
            this.lblIdentify.Size = new System.Drawing.Size(41, 20);
            this.lblIdentify.TabIndex = 17;
            this.lblIdentify.Text = "可检索";
            // 
            // txtIdentify
            // 
            this.txtIdentify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdentify.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtIdentify.EnableTouchMode = true;
            this.txtIdentify.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdentify.Location =  new System.Drawing.Point(0,0);
            this.txtIdentify.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtIdentify.Name = "txtIdentify";
            this.txtIdentify.Size = new System.Drawing.Size(152, 28);
            this.txtIdentify.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtIdentify.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblEditable.AutoSize = true;
            this.lblEditable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEditable.Location = new System.Drawing.Point(0,0);
            this.lblEditable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEditable.Name = "lblEditable";
            this.lblEditable.Size = new System.Drawing.Size(41, 20);
            this.lblEditable.TabIndex = 19;
            this.lblEditable.Text = "可编辑";
            // 
            // txtEditable
            // 
            this.txtEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtEditable.EnableTouchMode = true;
            this.txtEditable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEditable.Location =  new System.Drawing.Point(0,0);
            this.txtEditable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEditable.Name = "txtEditable";
            this.txtEditable.Size = new System.Drawing.Size(152, 28);
            this.txtEditable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEditable.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblQueryable.AutoSize = true;
            this.lblQueryable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQueryable.Location = new System.Drawing.Point(0,0);
            this.lblQueryable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQueryable.Name = "lblQueryable";
            this.lblQueryable.Size = new System.Drawing.Size(41, 20);
            this.lblQueryable.TabIndex = 21;
            this.lblQueryable.Text = "可查询";
            // 
            // txtQueryable
            // 
            this.txtQueryable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQueryable.EnableTouchMode = true;
            this.txtQueryable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryable.Location =  new System.Drawing.Point(0,0);
            this.txtQueryable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQueryable.Name = "txtQueryable";
            this.txtQueryable.Size = new System.Drawing.Size(152, 28);
            this.txtQueryable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQueryable.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblSnapable.AutoSize = true;
            this.lblSnapable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSnapable.Location = new System.Drawing.Point(0,0);
            this.lblSnapable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSnapable.Name = "lblSnapable";
            this.lblSnapable.Size = new System.Drawing.Size(41, 20);
            this.lblSnapable.TabIndex = 23;
            this.lblSnapable.Text = "可捕捉";
            // 
            // txtSnapable
            // 
            this.txtSnapable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSnapable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSnapable.EnableTouchMode = true;
            this.txtSnapable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSnapable.Location =  new System.Drawing.Point(0,0);
            this.txtSnapable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSnapable.Name = "txtSnapable";
            this.txtSnapable.Size = new System.Drawing.Size(152, 28);
            this.txtSnapable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSnapable.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVisible.Location = new System.Drawing.Point(0,0);
            this.lblVisible.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(41, 20);
            this.lblVisible.TabIndex = 25;
            this.lblVisible.Text = "可显示";
            // 
            // txtVisible
            // 
            this.txtVisible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVisible.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtVisible.EnableTouchMode = true;
            this.txtVisible.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVisible.Location =  new System.Drawing.Point(0,0);
            this.txtVisible.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVisible.Name = "txtVisible";
            this.txtVisible.Size = new System.Drawing.Size(152, 28);
            this.txtVisible.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVisible.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblXssx.AutoSize = true;
            this.lblXssx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXssx.Location = new System.Drawing.Point(0,0);
            this.lblXssx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXssx.Name = "lblXssx";
            this.lblXssx.Size = new System.Drawing.Size(41, 20);
            this.lblXssx.TabIndex = 27;
            this.lblXssx.Text = "显示顺序";
            // 
            // intXssx
            // 
            this.intXssx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intXssx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXssx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intXssx.EnableTouchMode = true;
            this.intXssx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intXssx.IntegerValue = ((long)(0));
            this.intXssx.Location = new System.Drawing.Point(0,0);
            this.intXssx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXssx.Name = "intXssx";
            this.intXssx.NullString = "";
            this.intXssx.Size = new System.Drawing.Size(152, 28);
            this.intXssx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXssx.TabIndex = 28;
            this.intXssx.Text = "0";
            // 
            // lblID
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFilter.Location = new System.Drawing.Point(0,0);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(41, 20);
            this.lblFilter.TabIndex = 29;
            this.lblFilter.Text = "过滤";
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFilter.EnableTouchMode = true;
            this.txtFilter.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFilter.Location =  new System.Drawing.Point(0,0);
            this.txtFilter.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(152, 28);
            this.txtFilter.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFilter.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblQsdm.AutoSize = true;
            this.lblQsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsdm.Location = new System.Drawing.Point(0,0);
            this.lblQsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsdm.Name = "lblQsdm";
            this.lblQsdm.Size = new System.Drawing.Size(41, 20);
            this.lblQsdm.TabIndex = 31;
            this.lblQsdm.Text = "缺省代码";
            // 
            // txtQsdm
            // 
            this.txtQsdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsdm.EnableTouchMode = true;
            this.txtQsdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsdm.Location =  new System.Drawing.Point(0,0);
            this.txtQsdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsdm.Name = "txtQsdm";
            this.txtQsdm.Size = new System.Drawing.Size(152, 28);
            this.txtQsdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsdm.TabIndex = 32;
            // 
            // lblID
            // 
            this.lblBjct.AutoSize = true;
            this.lblBjct.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBjct.Location = new System.Drawing.Point(0,0);
            this.lblBjct.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBjct.Name = "lblBjct";
            this.lblBjct.Size = new System.Drawing.Size(41, 20);
            this.lblBjct.TabIndex = 33;
            this.lblBjct.Text = "编辑窗体";
            // 
            // txtBjct
            // 
            this.txtBjct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBjct.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBjct.EnableTouchMode = true;
            this.txtBjct.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBjct.Location =  new System.Drawing.Point(0,0);
            this.txtBjct.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBjct.Name = "txtBjct";
            this.txtBjct.Size = new System.Drawing.Size(152, 28);
            this.txtBjct.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBjct.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblBhfj.AutoSize = true;
            this.lblBhfj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBhfj.Location = new System.Drawing.Point(0,0);
            this.lblBhfj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBhfj.Name = "lblBhfj";
            this.lblBhfj.Size = new System.Drawing.Size(41, 20);
            this.lblBhfj.TabIndex = 35;
            this.lblBhfj.Text = "包含附件";
            // 
            // txtBhfj
            // 
            this.txtBhfj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBhfj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBhfj.EnableTouchMode = true;
            this.txtBhfj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBhfj.Location =  new System.Drawing.Point(0,0);
            this.txtBhfj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBhfj.Name = "txtBhfj";
            this.txtBhfj.Size = new System.Drawing.Size(152, 28);
            this.txtBhfj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBhfj.TabIndex = 36;
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
            this.tableLayoutPanel1.Controls.Add(this.lblMc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDxlx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.intDxlx, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZwmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZwmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFbmc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFbmc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblXhzdmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtXhzdmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTxzdmc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtTxzdmc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTxlx, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.intTxlx, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblIdentify, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtIdentify, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblEditable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEditable, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueryable, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQueryable, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSnapable, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSnapable, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVisible, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtVisible, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblXssx, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.intXssx, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFilter, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFilter, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQsdm, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtQsdm, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblBjct, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBjct, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBhfj, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBhfj, 4, 8);
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
            this.tableLayoutPanel1.TabIndex = 37; 
            //
            // ucVgObjectclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgObjectclass";
            this.Size = new System.Drawing.Size(500, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDxlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZwmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFbmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXhzdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTxzdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intTxlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXssx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBjct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhfj)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMc;	
        private System.Windows.Forms.Label lblMc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intDxlx;	
        private System.Windows.Forms.Label lblDxlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZwmc;	
        private System.Windows.Forms.Label lblZwmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFbmc;	
        private System.Windows.Forms.Label lblFbmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXhzdmc;	
        private System.Windows.Forms.Label lblXhzdmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTxzdmc;	
        private System.Windows.Forms.Label lblTxzdmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intTxlx;	
        private System.Windows.Forms.Label lblTxlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtIdentify;	
        private System.Windows.Forms.Label lblIdentify;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEditable;	
        private System.Windows.Forms.Label lblEditable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQueryable;	
        private System.Windows.Forms.Label lblQueryable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSnapable;	
        private System.Windows.Forms.Label lblSnapable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtVisible;	
        private System.Windows.Forms.Label lblVisible;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXssx;	
        private System.Windows.Forms.Label lblXssx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFilter;	
        private System.Windows.Forms.Label lblFilter;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsdm;	
        private System.Windows.Forms.Label lblQsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBjct;	
        private System.Windows.Forms.Label lblBjct;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBhfj;	
        private System.Windows.Forms.Label lblBhfj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}