using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgFieldinfo
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
            this.lblBm = new System.Windows.Forms.Label();
            this.txtBm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBnsx = new System.Windows.Forms.Label();
            this.intBnsx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZdzwmc = new System.Windows.Forms.Label();
            this.txtZdzwmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdmc = new System.Windows.Forms.Label();
            this.txtZdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdlx = new System.Windows.Forms.Label();
            this.txtZdlx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdcd = new System.Windows.Forms.Label();
            this.intZdcd = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblZdxsws = new System.Windows.Forms.Label();
            this.intZdxsws = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblSyzd = new System.Windows.Forms.Label();
            this.txtSyzd = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYs = new System.Windows.Forms.Label();
            this.txtYs = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSyzdyw = new System.Windows.Forms.Label();
            this.txtSyzdyw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBnsx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzwmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZdcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZdxsws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyzd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyzdyw)).BeginInit();
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
            this.lblBm.AutoSize = true;
            this.lblBm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBm.Location = new System.Drawing.Point(0,0);
            this.lblBm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBm.Name = "lblBm";
            this.lblBm.Size = new System.Drawing.Size(41, 20);
            this.lblBm.TabIndex = 3;
            this.lblBm.Text = "表名";
            // 
            // txtBm
            // 
            this.txtBm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBm.EnableTouchMode = true;
            this.txtBm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBm.Location =  new System.Drawing.Point(0,0);
            this.txtBm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(152, 28);
            this.txtBm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblBnsx.AutoSize = true;
            this.lblBnsx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBnsx.Location = new System.Drawing.Point(0,0);
            this.lblBnsx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBnsx.Name = "lblBnsx";
            this.lblBnsx.Size = new System.Drawing.Size(41, 20);
            this.lblBnsx.TabIndex = 5;
            this.lblBnsx.Text = "表内顺序";
            // 
            // intBnsx
            // 
            this.intBnsx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intBnsx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intBnsx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intBnsx.EnableTouchMode = true;
            this.intBnsx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intBnsx.IntegerValue = ((long)(0));
            this.intBnsx.Location = new System.Drawing.Point(0,0);
            this.intBnsx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intBnsx.Name = "intBnsx";
            this.intBnsx.NullString = "";
            this.intBnsx.Size = new System.Drawing.Size(152, 28);
            this.intBnsx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intBnsx.TabIndex = 6;
            this.intBnsx.Text = "0";
            // 
            // lblID
            // 
            this.lblZdzwmc.AutoSize = true;
            this.lblZdzwmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdzwmc.Location = new System.Drawing.Point(0,0);
            this.lblZdzwmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdzwmc.Name = "lblZdzwmc";
            this.lblZdzwmc.Size = new System.Drawing.Size(41, 20);
            this.lblZdzwmc.TabIndex = 7;
            this.lblZdzwmc.Text = "字段中文名称";
            // 
            // txtZdzwmc
            // 
            this.txtZdzwmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdzwmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdzwmc.EnableTouchMode = true;
            this.txtZdzwmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdzwmc.Location =  new System.Drawing.Point(0,0);
            this.txtZdzwmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdzwmc.Name = "txtZdzwmc";
            this.txtZdzwmc.Size = new System.Drawing.Size(152, 28);
            this.txtZdzwmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdzwmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblZdmc.AutoSize = true;
            this.lblZdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdmc.Location = new System.Drawing.Point(0,0);
            this.lblZdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdmc.Name = "lblZdmc";
            this.lblZdmc.Size = new System.Drawing.Size(41, 20);
            this.lblZdmc.TabIndex = 9;
            this.lblZdmc.Text = "字段名称";
            // 
            // txtZdmc
            // 
            this.txtZdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdmc.EnableTouchMode = true;
            this.txtZdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdmc.Location =  new System.Drawing.Point(0,0);
            this.txtZdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdmc.Name = "txtZdmc";
            this.txtZdmc.Size = new System.Drawing.Size(152, 28);
            this.txtZdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdmc.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblZdlx.AutoSize = true;
            this.lblZdlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdlx.Location = new System.Drawing.Point(0,0);
            this.lblZdlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdlx.Name = "lblZdlx";
            this.lblZdlx.Size = new System.Drawing.Size(41, 20);
            this.lblZdlx.TabIndex = 11;
            this.lblZdlx.Text = "字段类型";
            // 
            // txtZdlx
            // 
            this.txtZdlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdlx.EnableTouchMode = true;
            this.txtZdlx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdlx.Location =  new System.Drawing.Point(0,0);
            this.txtZdlx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdlx.Name = "txtZdlx";
            this.txtZdlx.Size = new System.Drawing.Size(152, 28);
            this.txtZdlx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdlx.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblZdcd.AutoSize = true;
            this.lblZdcd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdcd.Location = new System.Drawing.Point(0,0);
            this.lblZdcd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdcd.Name = "lblZdcd";
            this.lblZdcd.Size = new System.Drawing.Size(41, 20);
            this.lblZdcd.TabIndex = 13;
            this.lblZdcd.Text = "字段长度";
            // 
            // intZdcd
            // 
            this.intZdcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZdcd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZdcd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZdcd.EnableTouchMode = true;
            this.intZdcd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZdcd.IntegerValue = ((long)(0));
            this.intZdcd.Location = new System.Drawing.Point(0,0);
            this.intZdcd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZdcd.Name = "intZdcd";
            this.intZdcd.NullString = "";
            this.intZdcd.Size = new System.Drawing.Size(152, 28);
            this.intZdcd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZdcd.TabIndex = 14;
            this.intZdcd.Text = "0";
            // 
            // lblID
            // 
            this.lblZdxsws.AutoSize = true;
            this.lblZdxsws.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdxsws.Location = new System.Drawing.Point(0,0);
            this.lblZdxsws.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdxsws.Name = "lblZdxsws";
            this.lblZdxsws.Size = new System.Drawing.Size(41, 20);
            this.lblZdxsws.TabIndex = 15;
            this.lblZdxsws.Text = "字段显示顺序";
            // 
            // intZdxsws
            // 
            this.intZdxsws.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZdxsws.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZdxsws.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZdxsws.EnableTouchMode = true;
            this.intZdxsws.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZdxsws.IntegerValue = ((long)(0));
            this.intZdxsws.Location = new System.Drawing.Point(0,0);
            this.intZdxsws.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZdxsws.Name = "intZdxsws";
            this.intZdxsws.NullString = "";
            this.intZdxsws.Size = new System.Drawing.Size(152, 28);
            this.intZdxsws.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZdxsws.TabIndex = 16;
            this.intZdxsws.Text = "0";
            // 
            // lblID
            // 
            this.lblSyzd.AutoSize = true;
            this.lblSyzd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyzd.Location = new System.Drawing.Point(0,0);
            this.lblSyzd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyzd.Name = "lblSyzd";
            this.lblSyzd.Size = new System.Drawing.Size(41, 20);
            this.lblSyzd.TabIndex = 17;
            this.lblSyzd.Text = "使用字典";
            // 
            // txtSyzd
            // 
            this.txtSyzd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSyzd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSyzd.EnableTouchMode = true;
            this.txtSyzd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSyzd.Location =  new System.Drawing.Point(0,0);
            this.txtSyzd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSyzd.Name = "txtSyzd";
            this.txtSyzd.Size = new System.Drawing.Size(152, 28);
            this.txtSyzd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSyzd.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblYs.AutoSize = true;
            this.lblYs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYs.Location = new System.Drawing.Point(0,0);
            this.lblYs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYs.Name = "lblYs";
            this.lblYs.Size = new System.Drawing.Size(41, 20);
            this.lblYs.TabIndex = 19;
            this.lblYs.Text = "可选";
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
            this.txtYs.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblSyzdyw.AutoSize = true;
            this.lblSyzdyw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyzdyw.Location = new System.Drawing.Point(0,0);
            this.lblSyzdyw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyzdyw.Name = "lblSyzdyw";
            this.lblSyzdyw.Size = new System.Drawing.Size(41, 20);
            this.lblSyzdyw.TabIndex = 21;
            this.lblSyzdyw.Text = "使用字典英文";
            // 
            // txtSyzdyw
            // 
            this.txtSyzdyw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSyzdyw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSyzdyw.EnableTouchMode = true;
            this.txtSyzdyw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSyzdyw.Location =  new System.Drawing.Point(0,0);
            this.txtSyzdyw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSyzdyw.Name = "txtSyzdyw";
            this.txtSyzdyw.Size = new System.Drawing.Size(152, 28);
            this.txtSyzdyw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSyzdyw.TabIndex = 22;
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
            this.tableLayoutPanel1.Controls.Add(this.lblBm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBnsx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.intBnsx, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZdzwmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZdzwmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZdmc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtZdmc, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZdlx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtZdlx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZdcd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.intZdcd, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdxsws, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.intZdxsws, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSyzd, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSyzd, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYs, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYs, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSyzdyw, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSyzdyw, 4, 4);
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
            this.tableLayoutPanel1.TabIndex = 23; 
            //
            // ucVgFieldinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgFieldinfo";
            this.Size = new System.Drawing.Size(500, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intBnsx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzwmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZdcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZdxsws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyzd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyzdyw)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBm;	
        private System.Windows.Forms.Label lblBm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intBnsx;	
        private System.Windows.Forms.Label lblBnsx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdzwmc;	
        private System.Windows.Forms.Label lblZdzwmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdmc;	
        private System.Windows.Forms.Label lblZdmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdlx;	
        private System.Windows.Forms.Label lblZdlx;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZdcd;	
        private System.Windows.Forms.Label lblZdcd;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZdxsws;	
        private System.Windows.Forms.Label lblZdxsws;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSyzd;	
        private System.Windows.Forms.Label lblSyzd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYs;	
        private System.Windows.Forms.Label lblYs;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSyzdyw;	
        private System.Windows.Forms.Label lblSyzdyw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}