using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSz
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
            this.lblSzmc = new System.Windows.Forms.Label();
            this.txtSzmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSzzh = new System.Windows.Forms.Label();
            this.txtSzzh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsxlh = new System.Windows.Forms.Label();
            this.txtYsxlh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSzry = new System.Windows.Forms.Label();
            this.txtSzry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSzsj = new System.Windows.Forms.Label();
            this.datSzsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzzh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsxlh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSzsj)).BeginInit();
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
            this.lblSzmc.AutoSize = true;
            this.lblSzmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSzmc.Location = new System.Drawing.Point(0,0);
            this.lblSzmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSzmc.Name = "lblSzmc";
            this.lblSzmc.Size = new System.Drawing.Size(41, 20);
            this.lblSzmc.TabIndex = 7;
            this.lblSzmc.Text = "缮证名称";
            // 
            // txtSzmc
            // 
            this.txtSzmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSzmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSzmc.EnableTouchMode = true;
            this.txtSzmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSzmc.Location =  new System.Drawing.Point(0,0);
            this.txtSzmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSzmc.Name = "txtSzmc";
            this.txtSzmc.Size = new System.Drawing.Size(152, 28);
            this.txtSzmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSzmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblSzzh.AutoSize = true;
            this.lblSzzh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSzzh.Location = new System.Drawing.Point(0,0);
            this.lblSzzh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSzzh.Name = "lblSzzh";
            this.lblSzzh.Size = new System.Drawing.Size(41, 20);
            this.lblSzzh.TabIndex = 9;
            this.lblSzzh.Text = "缮证证号";
            // 
            // txtSzzh
            // 
            this.txtSzzh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSzzh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSzzh.EnableTouchMode = true;
            this.txtSzzh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSzzh.Location =  new System.Drawing.Point(0,0);
            this.txtSzzh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSzzh.Name = "txtSzzh";
            this.txtSzzh.Size = new System.Drawing.Size(152, 28);
            this.txtSzzh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSzzh.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblYsxlh.AutoSize = true;
            this.lblYsxlh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsxlh.Location = new System.Drawing.Point(0,0);
            this.lblYsxlh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsxlh.Name = "lblYsxlh";
            this.lblYsxlh.Size = new System.Drawing.Size(41, 20);
            this.lblYsxlh.TabIndex = 11;
            this.lblYsxlh.Text = "印刷序列号";
            // 
            // txtYsxlh
            // 
            this.txtYsxlh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsxlh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsxlh.EnableTouchMode = true;
            this.txtYsxlh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsxlh.Location =  new System.Drawing.Point(0,0);
            this.txtYsxlh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsxlh.Name = "txtYsxlh";
            this.txtYsxlh.Size = new System.Drawing.Size(152, 28);
            this.txtYsxlh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsxlh.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSzry.AutoSize = true;
            this.lblSzry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSzry.Location = new System.Drawing.Point(0,0);
            this.lblSzry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSzry.Name = "lblSzry";
            this.lblSzry.Size = new System.Drawing.Size(41, 20);
            this.lblSzry.TabIndex = 13;
            this.lblSzry.Text = "缮证人员";
            // 
            // txtSzry
            // 
            this.txtSzry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSzry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSzry.EnableTouchMode = true;
            this.txtSzry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSzry.Location =  new System.Drawing.Point(0,0);
            this.txtSzry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSzry.Name = "txtSzry";
            this.txtSzry.Size = new System.Drawing.Size(152, 28);
            this.txtSzry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSzry.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblSzsj.AutoSize = true;
            this.lblSzsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSzsj.Location = new System.Drawing.Point(0,0);
            this.lblSzsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSzsj.Name = "lblSzsj";
            this.lblSzsj.Size = new System.Drawing.Size(41, 20);
            this.lblSzsj.TabIndex = 15;
            this.lblSzsj.Text = "缮证时间";
            // 
            // datSzsj
            // 
            this.datSzsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSzsj.BorderColor = System.Drawing.Color.Empty;
            this.datSzsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSzsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSzsj.DropDownImage = null;
            this.datSzsj.EnableTouchMode = true;
            this.datSzsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSzsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSzsj.Location =  new System.Drawing.Point(0,0);
            this.datSzsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSzsj.MinValue = new System.DateTime(((long)(0)));
            this.datSzsj.Name = "datSzsj";
            this.datSzsj.Size = new System.Drawing.Size(152, 20);
            this.datSzsj.TabIndex = 16;
            this.datSzsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSzsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 17;
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
            this.txtBz.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSzmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSzmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSzzh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSzzh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYsxlh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYsxlh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSzry, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSzry, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSzsj, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.datSzsj, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 1, 8);
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
            this.tableLayoutPanel1.TabIndex = 19; 
            //
            // ucSz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSz";
            this.Size = new System.Drawing.Size(250, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzzh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsxlh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSzry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSzsj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSzmc;	
        private System.Windows.Forms.Label lblSzmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSzzh;	
        private System.Windows.Forms.Label lblSzzh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsxlh;	
        private System.Windows.Forms.Label lblYsxlh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSzry;	
        private System.Windows.Forms.Label lblSzry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSzsj;	
        private System.Windows.Forms.Label lblSzsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}