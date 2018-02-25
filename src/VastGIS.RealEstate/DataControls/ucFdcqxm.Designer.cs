using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFdcqxm
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
            this.lblXmmc = new System.Windows.Forms.Label();
            this.txtXmmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZh = new System.Windows.Forms.Label();
            this.txtZh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZcs = new System.Windows.Forms.Label();
            this.intZcs = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblGhyt = new System.Windows.Forms.Label();
            this.cmbGhyt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFwjg = new System.Windows.Forms.Label();
            this.cmbFwjg = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJzmj = new System.Windows.Forms.Label();
            this.dblJzmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJgsj = new System.Windows.Forms.Label();
            this.datJgsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblZts = new System.Windows.Forms.Label();
            this.intZts = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZts)).BeginInit();
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
            this.lblXmmc.AutoSize = true;
            this.lblXmmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXmmc.Location = new System.Drawing.Point(0,0);
            this.lblXmmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXmmc.Name = "lblXmmc";
            this.lblXmmc.Size = new System.Drawing.Size(41, 20);
            this.lblXmmc.TabIndex = 5;
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
            this.txtXmmc.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblZh.AutoSize = true;
            this.lblZh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZh.Location = new System.Drawing.Point(0,0);
            this.lblZh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZh.Name = "lblZh";
            this.lblZh.Size = new System.Drawing.Size(41, 20);
            this.lblZh.TabIndex = 7;
            this.lblZh.Text = "幢号";
            // 
            // txtZh
            // 
            this.txtZh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZh.EnableTouchMode = true;
            this.txtZh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZh.Location =  new System.Drawing.Point(0,0);
            this.txtZh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZh.Name = "txtZh";
            this.txtZh.Size = new System.Drawing.Size(152, 28);
            this.txtZh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblZcs.AutoSize = true;
            this.lblZcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZcs.Location = new System.Drawing.Point(0,0);
            this.lblZcs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZcs.Name = "lblZcs";
            this.lblZcs.Size = new System.Drawing.Size(41, 20);
            this.lblZcs.TabIndex = 9;
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
            this.intZcs.TabIndex = 10;
            this.intZcs.Text = "0";
            // 
            // lblID
            // 
            this.lblGhyt.AutoSize = true;
            this.lblGhyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGhyt.Location = new System.Drawing.Point(0,0);
            this.lblGhyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGhyt.Name = "lblGhyt";
            this.lblGhyt.Size = new System.Drawing.Size(41, 20);
            this.lblGhyt.TabIndex = 11;
            this.lblGhyt.Text = "规划用途";
            // 
            // cmbGhyt
            // 
            this.cmbGhyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGhyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbGhyt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGhyt.EnableTouchMode = true;
            this.cmbGhyt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGhyt.Location =  new System.Drawing.Point(0,0);
            this.cmbGhyt.Name = "cmbGhyt";
            this.cmbGhyt.Size = new System.Drawing.Size(152, 20);
            this.cmbGhyt.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblFwjg.AutoSize = true;
            this.lblFwjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFwjg.Location = new System.Drawing.Point(0,0);
            this.lblFwjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFwjg.Name = "lblFwjg";
            this.lblFwjg.Size = new System.Drawing.Size(41, 20);
            this.lblFwjg.TabIndex = 13;
            this.lblFwjg.Text = "房屋结构";
            // 
            // cmbFwjg
            // 
            this.cmbFwjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFwjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFwjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFwjg.EnableTouchMode = true;
            this.cmbFwjg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFwjg.Location =  new System.Drawing.Point(0,0);
            this.cmbFwjg.Name = "cmbFwjg";
            this.cmbFwjg.Size = new System.Drawing.Size(152, 20);
            this.cmbFwjg.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblJzmj.AutoSize = true;
            this.lblJzmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzmj.Location = new System.Drawing.Point(0,0);
            this.lblJzmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzmj.Name = "lblJzmj";
            this.lblJzmj.Size = new System.Drawing.Size(41, 20);
            this.lblJzmj.TabIndex = 15;
            this.lblJzmj.Text = "建筑面积";
            // 
            // dblJzmj
            // 
            this.dblJzmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzmj.DoubleValue = 1D;
            this.dblJzmj.EnableTouchMode = true;
            this.dblJzmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzmj.Location =  new System.Drawing.Point(0,0);
            this.dblJzmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzmj.Name = "dblJzmj";
            this.dblJzmj.NullString = "";
            this.dblJzmj.Size = new System.Drawing.Size(152, 28);
            this.dblJzmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzmj.TabIndex = 16;
            this.dblJzmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJgsj.AutoSize = true;
            this.lblJgsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgsj.Location = new System.Drawing.Point(0,0);
            this.lblJgsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgsj.Name = "lblJgsj";
            this.lblJgsj.Size = new System.Drawing.Size(41, 20);
            this.lblJgsj.TabIndex = 17;
            this.lblJgsj.Text = "竣工时间";
            // 
            // datJgsj
            // 
            this.datJgsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJgsj.BorderColor = System.Drawing.Color.Empty;
            this.datJgsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJgsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJgsj.DropDownImage = null;
            this.datJgsj.EnableTouchMode = true;
            this.datJgsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJgsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJgsj.Location =  new System.Drawing.Point(0,0);
            this.datJgsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJgsj.MinValue = new System.DateTime(((long)(0)));
            this.datJgsj.Name = "datJgsj";
            this.datJgsj.Size = new System.Drawing.Size(152, 20);
            this.datJgsj.TabIndex = 18;
            this.datJgsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJgsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblZts.AutoSize = true;
            this.lblZts.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZts.Location = new System.Drawing.Point(0,0);
            this.lblZts.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZts.Name = "lblZts";
            this.lblZts.Size = new System.Drawing.Size(41, 20);
            this.lblZts.TabIndex = 19;
            this.lblZts.Text = "总套数";
            // 
            // intZts
            // 
            this.intZts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intZts.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intZts.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intZts.EnableTouchMode = true;
            this.intZts.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intZts.IntegerValue = ((long)(0));
            this.intZts.Location = new System.Drawing.Point(0,0);
            this.intZts.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intZts.Name = "intZts";
            this.intZts.NullString = "";
            this.intZts.Size = new System.Drawing.Size(152, 28);
            this.intZts.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intZts.TabIndex = 20;
            this.intZts.Text = "0";
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
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblXmmc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtXmmc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZcs, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.intZcs, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGhyt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbGhyt, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFwjg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbFwjg, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJzmj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblJzmj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJgsj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datJgsj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZts, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.intZts, 4, 4);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);            
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";            
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 364);
            this.tableLayoutPanel1.TabIndex = 21; 
            //
            // ucFdcqxm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFdcqxm";
            this.Size = new System.Drawing.Size(500, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXmmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGhyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFwjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJgsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intZts)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXmmc;	
        private System.Windows.Forms.Label lblXmmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZh;	
        private System.Windows.Forms.Label lblZh;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZcs;	
        private System.Windows.Forms.Label lblZcs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGhyt;	
        private System.Windows.Forms.Label lblGhyt;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFwjg;	
        private System.Windows.Forms.Label lblFwjg;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzmj;	
        private System.Windows.Forms.Label lblJzmj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJgsj;	
        private System.Windows.Forms.Label lblJgsj;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intZts;	
        private System.Windows.Forms.Label lblZts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}