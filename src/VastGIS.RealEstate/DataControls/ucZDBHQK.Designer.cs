using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZdbhqk
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
            this.lblZddm = new System.Windows.Forms.Label();
            this.txtZddm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBhyy = new System.Windows.Forms.Label();
            this.txtBhyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBhnr = new System.Windows.Forms.Label();
            this.txtBhnr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjsj = new System.Windows.Forms.Label();
            this.datDjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblDbr = new System.Windows.Forms.Label();
            this.txtDbr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFj = new System.Windows.Forms.Label();
            this.txtFj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhnr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
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
            this.intID.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.intID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intID.EnableTouchMode = true;
            this.intID.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intID.IntegerValue = ((long)(0));
            this.intID.Location = new System.Drawing.Point(83, 3);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";
            this.intID.NullString = "";
            this.intID.Size = new System.Drawing.Size(159, 28);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 2;
            this.intID.Text = "0";
            // 
            // lblZddm
            // 
            this.lblZddm.AutoSize = true;
            this.lblZddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZddm.Location = new System.Drawing.Point(24, 45);
            this.lblZddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZddm.Name = "lblZddm";
            this.lblZddm.Size = new System.Drawing.Size(53, 25);
            this.lblZddm.TabIndex = 3;
            this.lblZddm.Text = "宗地代码";
            // 
            // txtZddm
            // 
            this.txtZddm.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtZddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZddm.EnableTouchMode = true;
            this.txtZddm.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZddm.Location = new System.Drawing.Point(83, 38);
            this.txtZddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZddm.Name = "txtZddm";
            this.txtZddm.Size = new System.Drawing.Size(159, 28);
            this.txtZddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZddm.TabIndex = 4;
            // 
            // lblBhyy
            // 
            this.lblBhyy.AutoSize = true;
            this.lblBhyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBhyy.Location = new System.Drawing.Point(24, 80);
            this.lblBhyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBhyy.Name = "lblBhyy";
            this.lblBhyy.Size = new System.Drawing.Size(53, 25);
            this.lblBhyy.TabIndex = 5;
            this.lblBhyy.Text = "变化原因";
            // 
            // txtBhyy
            // 
            this.txtBhyy.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtBhyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBhyy.EnableTouchMode = true;
            this.txtBhyy.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBhyy.Location = new System.Drawing.Point(83, 73);
            this.txtBhyy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBhyy.Name = "txtBhyy";
            this.txtBhyy.Size = new System.Drawing.Size(159, 28);
            this.txtBhyy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBhyy.TabIndex = 6;
            // 
            // lblBhnr
            // 
            this.lblBhnr.AutoSize = true;
            this.lblBhnr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBhnr.Location = new System.Drawing.Point(24, 115);
            this.lblBhnr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBhnr.Name = "lblBhnr";
            this.lblBhnr.Size = new System.Drawing.Size(53, 25);
            this.lblBhnr.TabIndex = 7;
            this.lblBhnr.Text = "变化内容";
            // 
            // txtBhnr
            // 
            this.txtBhnr.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtBhnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBhnr.EnableTouchMode = true;
            this.txtBhnr.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBhnr.Location = new System.Drawing.Point(83, 108);
            this.txtBhnr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBhnr.Name = "txtBhnr";
            this.txtBhnr.Size = new System.Drawing.Size(159, 28);
            this.txtBhnr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBhnr.TabIndex = 8;
            // 
            // lblDjsj
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(24, 150);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(53, 25);
            this.lblDjsj.TabIndex = 9;
            this.lblDjsj.Text = "登记时间";
            // 
            // datDjsj
            // 
            this.datDjsj.BorderColor = System.Drawing.Color.Empty;
            this.datDjsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datDjsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datDjsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datDjsj.DropDownImage = null;
            this.datDjsj.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.datDjsj.EnableTouchMode = true;
            this.datDjsj.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datDjsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDjsj.Location = new System.Drawing.Point(83, 143);
            this.datDjsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datDjsj.MinValue = new System.DateTime(((long)(0)));
            this.datDjsj.Name = "datDjsj";
            this.datDjsj.Size = new System.Drawing.Size(159, 29);
            this.datDjsj.TabIndex = 10;
            this.datDjsj.UseCurrentCulture = true;
            this.datDjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            // 
            // lblDbr
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(36, 185);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 25);
            this.lblDbr.TabIndex = 11;
            this.lblDbr.Text = "登簿人";
            // 
            // txtDbr
            // 
            this.txtDbr.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtDbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbr.EnableTouchMode = true;
            this.txtDbr.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDbr.Location = new System.Drawing.Point(83, 178);
            this.txtDbr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDbr.Name = "txtDbr";
            this.txtDbr.Size = new System.Drawing.Size(159, 28);
            this.txtDbr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDbr.TabIndex = 12;
            // 
            // lblFj
            // 
            this.lblFj.AutoSize = true;
            this.lblFj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFj.Location = new System.Drawing.Point(48, 220);
            this.lblFj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFj.Name = "lblFj";
            this.lblFj.Size = new System.Drawing.Size(29, 41);
            this.lblFj.TabIndex = 13;
            this.lblFj.Text = "附记";
            // 
            // txtFj
            // 
            this.txtFj.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtFj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFj.EnableTouchMode = true;
            this.txtFj.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFj.Location = new System.Drawing.Point(83, 213);
            this.txtFj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFj.Name = "txtFj";
            this.txtFj.Size = new System.Drawing.Size(159, 28);
            this.txtFj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFj.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZddm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZddm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBhyy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBhyy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBhnr, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBhnr, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 261);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // ucZdbhqk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucZdbhqk";
            this.Size = new System.Drawing.Size(250, 261);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBhnr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZddm;	
        private System.Windows.Forms.Label lblZddm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBhyy;	
        private System.Windows.Forms.Label lblBhyy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBhnr;	
        private System.Windows.Forms.Label lblBhnr;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datDjsj;	
        private System.Windows.Forms.Label lblDjsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDbr;	
        private System.Windows.Forms.Label lblDbr;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFj;	
        private System.Windows.Forms.Label lblFj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}