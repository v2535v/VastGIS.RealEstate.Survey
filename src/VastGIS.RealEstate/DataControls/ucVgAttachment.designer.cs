using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgAttachment
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
            this.lblFjmc = new System.Windows.Forms.Label();
            this.txtFjmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFjlj = new System.Windows.Forms.Label();
            this.txtFjlj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFjlx = new System.Windows.Forms.Label();
            this.cmbFjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblHqsj = new System.Windows.Forms.Label();
            this.datHqsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFjsm = new System.Windows.Forms.Label();
            this.txtFjsm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjlj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHqsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjsm)).BeginInit();
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
            this.intID.Size = new System.Drawing.Size(159, 28);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 2;
            this.intID.Text = "0";
            // 
            // lblFjmc
            // 
            this.lblFjmc.AutoSize = true;
            this.lblFjmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFjmc.Location = new System.Drawing.Point(24, 45);
            this.lblFjmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFjmc.Name = "lblFjmc";
            this.lblFjmc.Size = new System.Drawing.Size(53, 25);
            this.lblFjmc.TabIndex = 3;
            this.lblFjmc.Text = "附件名称";
            // 
            // txtFjmc
            // 
            this.txtFjmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFjmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFjmc.EnableTouchMode = true;
            this.txtFjmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFjmc.Location = new System.Drawing.Point(83, 38);
            this.txtFjmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFjmc.Name = "txtFjmc";
            this.txtFjmc.Size = new System.Drawing.Size(159, 28);
            this.txtFjmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFjmc.TabIndex = 4;
            // 
            // lblFjlj
            // 
            this.lblFjlj.AutoSize = true;
            this.lblFjlj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFjlj.Location = new System.Drawing.Point(24, 80);
            this.lblFjlj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFjlj.Name = "lblFjlj";
            this.lblFjlj.Size = new System.Drawing.Size(53, 25);
            this.lblFjlj.TabIndex = 5;
            this.lblFjlj.Text = "附件路径";
            // 
            // txtFjlj
            // 
            this.txtFjlj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFjlj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFjlj.EnableTouchMode = true;
            this.txtFjlj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFjlj.Location = new System.Drawing.Point(83, 73);
            this.txtFjlj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFjlj.Name = "txtFjlj";
            this.txtFjlj.Size = new System.Drawing.Size(159, 28);
            this.txtFjlj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFjlj.TabIndex = 6;
            // 
            // lblFjlx
            // 
            this.lblFjlx.AutoSize = true;
            this.lblFjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFjlx.Location = new System.Drawing.Point(24, 115);
            this.lblFjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFjlx.Name = "lblFjlx";
            this.lblFjlx.Size = new System.Drawing.Size(53, 25);
            this.lblFjlx.TabIndex = 7;
            this.lblFjlx.Text = "附件类型";
            // 
            // cmbFjlx
            // 
            this.cmbFjlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFjlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFjlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFjlx.EnableTouchMode = true;
            this.cmbFjlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFjlx.Location = new System.Drawing.Point(83, 108);
            this.cmbFjlx.Name = "cmbFjlx";
            this.cmbFjlx.Size = new System.Drawing.Size(159, 20);
            this.cmbFjlx.TabIndex = 8;
            // 
            // lblHqsj
            // 
            this.lblHqsj.AutoSize = true;
            this.lblHqsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHqsj.Location = new System.Drawing.Point(24, 150);
            this.lblHqsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHqsj.Name = "lblHqsj";
            this.lblHqsj.Size = new System.Drawing.Size(53, 25);
            this.lblHqsj.TabIndex = 9;
            this.lblHqsj.Text = "获取时间";
            // 
            // datHqsj
            // 
            this.datHqsj.BorderColor = System.Drawing.Color.Empty;
            this.datHqsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datHqsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datHqsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datHqsj.DropDownImage = null;
            this.datHqsj.DropDownNormalColor = System.Drawing.SystemColors.Control;
            this.datHqsj.EnableTouchMode = true;
            this.datHqsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datHqsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datHqsj.Location = new System.Drawing.Point(83, 143);
            this.datHqsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datHqsj.MinValue = new System.DateTime(((long)(0)));
            this.datHqsj.Name = "datHqsj";
            this.datHqsj.Size = new System.Drawing.Size(159, 29);
            this.datHqsj.TabIndex = 10;
            this.datHqsj.UseCurrentCulture = true;
            this.datHqsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            // 
            // lblFjsm
            // 
            this.lblFjsm.AutoSize = true;
            this.lblFjsm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFjsm.Location = new System.Drawing.Point(24, 185);
            this.lblFjsm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFjsm.Name = "lblFjsm";
            this.lblFjsm.Size = new System.Drawing.Size(53, 41);
            this.lblFjsm.TabIndex = 11;
            this.lblFjsm.Text = "附件说明";
            // 
            // txtFjsm
            // 
            this.txtFjsm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFjsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFjsm.EnableTouchMode = true;
            this.txtFjsm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFjsm.Location = new System.Drawing.Point(83, 178);
            this.txtFjsm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFjsm.Name = "txtFjsm";
            this.txtFjsm.Size = new System.Drawing.Size(159, 28);
            this.txtFjsm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFjsm.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFjmc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFjmc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFjlj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFjlj, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFjlx, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbFjlx, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHqsj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datHqsj, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFjsm, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFjsm, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 226);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ucVgAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgAttachment";
            this.Size = new System.Drawing.Size(250, 226);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjlj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHqsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFjsm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFjmc;	
        private System.Windows.Forms.Label lblFjmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFjlj;	
        private System.Windows.Forms.Label lblFjlj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFjlx;	
        private System.Windows.Forms.Label lblFjlx;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datHqsj;	
        private System.Windows.Forms.Label lblHqsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFjsm;	
        private System.Windows.Forms.Label lblFjsm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}