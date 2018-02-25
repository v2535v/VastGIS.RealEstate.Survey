using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSh
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
            this.lblJdmc = new System.Windows.Forms.Label();
            this.txtJdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSxh = new System.Windows.Forms.Label();
            this.intSxh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblShryxm = new System.Windows.Forms.Label();
            this.txtShryxm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblShkssj = new System.Windows.Forms.Label();
            this.datShkssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblShjssj = new System.Windows.Forms.Label();
            this.datShjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblShyj = new System.Windows.Forms.Label();
            this.txtShyj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCzjg = new System.Windows.Forms.Label();
            this.cmbCzjg = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShryxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datShkssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datShjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShyj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCzjg)).BeginInit();
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
            this.lblJdmc.AutoSize = true;
            this.lblJdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJdmc.Location = new System.Drawing.Point(0,0);
            this.lblJdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJdmc.Name = "lblJdmc";
            this.lblJdmc.Size = new System.Drawing.Size(41, 20);
            this.lblJdmc.TabIndex = 7;
            this.lblJdmc.Text = "节点名称";
            // 
            // txtJdmc
            // 
            this.txtJdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJdmc.EnableTouchMode = true;
            this.txtJdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJdmc.Location =  new System.Drawing.Point(0,0);
            this.txtJdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJdmc.Name = "txtJdmc";
            this.txtJdmc.Size = new System.Drawing.Size(152, 28);
            this.txtJdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJdmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblSxh.AutoSize = true;
            this.lblSxh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSxh.Location = new System.Drawing.Point(0,0);
            this.lblSxh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSxh.Name = "lblSxh";
            this.lblSxh.Size = new System.Drawing.Size(41, 20);
            this.lblSxh.TabIndex = 9;
            this.lblSxh.Text = "顺序号";
            // 
            // intSxh
            // 
            this.intSxh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSxh.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSxh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSxh.EnableTouchMode = true;
            this.intSxh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSxh.IntegerValue = ((long)(0));
            this.intSxh.Location = new System.Drawing.Point(0,0);
            this.intSxh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSxh.Name = "intSxh";
            this.intSxh.NullString = "";
            this.intSxh.Size = new System.Drawing.Size(152, 28);
            this.intSxh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSxh.TabIndex = 10;
            this.intSxh.Text = "0";
            // 
            // lblID
            // 
            this.lblShryxm.AutoSize = true;
            this.lblShryxm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblShryxm.Location = new System.Drawing.Point(0,0);
            this.lblShryxm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShryxm.Name = "lblShryxm";
            this.lblShryxm.Size = new System.Drawing.Size(41, 20);
            this.lblShryxm.TabIndex = 11;
            this.lblShryxm.Text = "审核人员姓名";
            // 
            // txtShryxm
            // 
            this.txtShryxm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShryxm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtShryxm.EnableTouchMode = true;
            this.txtShryxm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShryxm.Location =  new System.Drawing.Point(0,0);
            this.txtShryxm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtShryxm.Name = "txtShryxm";
            this.txtShryxm.Size = new System.Drawing.Size(152, 28);
            this.txtShryxm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtShryxm.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblShkssj.AutoSize = true;
            this.lblShkssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblShkssj.Location = new System.Drawing.Point(0,0);
            this.lblShkssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShkssj.Name = "lblShkssj";
            this.lblShkssj.Size = new System.Drawing.Size(41, 20);
            this.lblShkssj.TabIndex = 13;
            this.lblShkssj.Text = "审核开始时间";
            // 
            // datShkssj
            // 
            this.datShkssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datShkssj.BorderColor = System.Drawing.Color.Empty;
            this.datShkssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datShkssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datShkssj.DropDownImage = null;
            this.datShkssj.EnableTouchMode = true;
            this.datShkssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datShkssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datShkssj.Location =  new System.Drawing.Point(0,0);
            this.datShkssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datShkssj.MinValue = new System.DateTime(((long)(0)));
            this.datShkssj.Name = "datShkssj";
            this.datShkssj.Size = new System.Drawing.Size(152, 20);
            this.datShkssj.TabIndex = 14;
            this.datShkssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datShkssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblShjssj.AutoSize = true;
            this.lblShjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblShjssj.Location = new System.Drawing.Point(0,0);
            this.lblShjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShjssj.Name = "lblShjssj";
            this.lblShjssj.Size = new System.Drawing.Size(41, 20);
            this.lblShjssj.TabIndex = 15;
            this.lblShjssj.Text = "审核结束时间";
            // 
            // datShjssj
            // 
            this.datShjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datShjssj.BorderColor = System.Drawing.Color.Empty;
            this.datShjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datShjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datShjssj.DropDownImage = null;
            this.datShjssj.EnableTouchMode = true;
            this.datShjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datShjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datShjssj.Location =  new System.Drawing.Point(0,0);
            this.datShjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datShjssj.MinValue = new System.DateTime(((long)(0)));
            this.datShjssj.Name = "datShjssj";
            this.datShjssj.Size = new System.Drawing.Size(152, 20);
            this.datShjssj.TabIndex = 16;
            this.datShjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datShjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblShyj.AutoSize = true;
            this.lblShyj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblShyj.Location = new System.Drawing.Point(0,0);
            this.lblShyj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShyj.Name = "lblShyj";
            this.lblShyj.Size = new System.Drawing.Size(41, 20);
            this.lblShyj.TabIndex = 17;
            this.lblShyj.Text = "审核意见";
            // 
            // txtShyj
            // 
            this.txtShyj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShyj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtShyj.EnableTouchMode = true;
            this.txtShyj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShyj.Location =  new System.Drawing.Point(0,0);
            this.txtShyj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtShyj.Name = "txtShyj";
            this.txtShyj.Size = new System.Drawing.Size(152, 28);
            this.txtShyj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtShyj.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblCzjg.AutoSize = true;
            this.lblCzjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCzjg.Location = new System.Drawing.Point(0,0);
            this.lblCzjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCzjg.Name = "lblCzjg";
            this.lblCzjg.Size = new System.Drawing.Size(41, 20);
            this.lblCzjg.TabIndex = 19;
            this.lblCzjg.Text = "操作结果";
            // 
            // cmbCzjg
            // 
            this.cmbCzjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCzjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbCzjg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCzjg.EnableTouchMode = true;
            this.cmbCzjg.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCzjg.Location =  new System.Drawing.Point(0,0);
            this.cmbCzjg.Name = "cmbCzjg";
            this.cmbCzjg.Size = new System.Drawing.Size(152, 20);
            this.cmbCzjg.TabIndex =  20;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblJdmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtJdmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSxh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.intSxh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblShryxm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtShryxm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblShkssj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.datShkssj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblShjssj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.datShjssj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblShyj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtShyj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCzjg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbCzjg, 4, 4);
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
            // ucSh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSh";
            this.Size = new System.Drawing.Size(500, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShryxm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datShkssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datShjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShyj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCzjg)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJdmc;	
        private System.Windows.Forms.Label lblJdmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSxh;	
        private System.Windows.Forms.Label lblSxh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtShryxm;	
        private System.Windows.Forms.Label lblShryxm;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datShkssj;	
        private System.Windows.Forms.Label lblShkssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datShjssj;	
        private System.Windows.Forms.Label lblShjssj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtShyj;	
        private System.Windows.Forms.Label lblShyj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbCzjg;	
        private System.Windows.Forms.Label lblCzjg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}