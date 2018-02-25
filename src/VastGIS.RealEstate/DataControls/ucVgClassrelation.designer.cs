using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgClassrelation
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
            this.lblYsbm = new System.Windows.Forms.Label();
            this.txtYsbm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGlbm = new System.Windows.Forms.Label();
            this.txtGlbm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYszd = new System.Windows.Forms.Label();
            this.txtYszd = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGlzd = new System.Windows.Forms.Label();
            this.txtGlzd = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGllx = new System.Windows.Forms.Label();
            this.intGllx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblGxb = new System.Windows.Forms.Label();
            this.txtGxb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsgx = new System.Windows.Forms.Label();
            this.txtYsgx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGlgx = new System.Windows.Forms.Label();
            this.txtGlgx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsbm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlbm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYszd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlzd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intGllx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsgx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlgx)).BeginInit();
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
            this.lblYsbm.AutoSize = true;
            this.lblYsbm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsbm.Location = new System.Drawing.Point(0,0);
            this.lblYsbm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsbm.Name = "lblYsbm";
            this.lblYsbm.Size = new System.Drawing.Size(41, 20);
            this.lblYsbm.TabIndex = 3;
            this.lblYsbm.Text = "原始表名";
            // 
            // txtYsbm
            // 
            this.txtYsbm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsbm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsbm.EnableTouchMode = true;
            this.txtYsbm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsbm.Location =  new System.Drawing.Point(0,0);
            this.txtYsbm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsbm.Name = "txtYsbm";
            this.txtYsbm.Size = new System.Drawing.Size(152, 28);
            this.txtYsbm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsbm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblGlbm.AutoSize = true;
            this.lblGlbm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGlbm.Location = new System.Drawing.Point(0,0);
            this.lblGlbm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGlbm.Name = "lblGlbm";
            this.lblGlbm.Size = new System.Drawing.Size(41, 20);
            this.lblGlbm.TabIndex = 5;
            this.lblGlbm.Text = "关联表名";
            // 
            // txtGlbm
            // 
            this.txtGlbm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlbm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGlbm.EnableTouchMode = true;
            this.txtGlbm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGlbm.Location =  new System.Drawing.Point(0,0);
            this.txtGlbm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGlbm.Name = "txtGlbm";
            this.txtGlbm.Size = new System.Drawing.Size(152, 28);
            this.txtGlbm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGlbm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblYszd.AutoSize = true;
            this.lblYszd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYszd.Location = new System.Drawing.Point(0,0);
            this.lblYszd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYszd.Name = "lblYszd";
            this.lblYszd.Size = new System.Drawing.Size(41, 20);
            this.lblYszd.TabIndex = 7;
            this.lblYszd.Text = "原始字段";
            // 
            // txtYszd
            // 
            this.txtYszd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYszd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYszd.EnableTouchMode = true;
            this.txtYszd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYszd.Location =  new System.Drawing.Point(0,0);
            this.txtYszd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYszd.Name = "txtYszd";
            this.txtYszd.Size = new System.Drawing.Size(152, 28);
            this.txtYszd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYszd.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblGlzd.AutoSize = true;
            this.lblGlzd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGlzd.Location = new System.Drawing.Point(0,0);
            this.lblGlzd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGlzd.Name = "lblGlzd";
            this.lblGlzd.Size = new System.Drawing.Size(41, 20);
            this.lblGlzd.TabIndex = 9;
            this.lblGlzd.Text = "关联字段";
            // 
            // txtGlzd
            // 
            this.txtGlzd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlzd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGlzd.EnableTouchMode = true;
            this.txtGlzd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGlzd.Location =  new System.Drawing.Point(0,0);
            this.txtGlzd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGlzd.Name = "txtGlzd";
            this.txtGlzd.Size = new System.Drawing.Size(152, 28);
            this.txtGlzd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGlzd.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblGllx.AutoSize = true;
            this.lblGllx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGllx.Location = new System.Drawing.Point(0,0);
            this.lblGllx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGllx.Name = "lblGllx";
            this.lblGllx.Size = new System.Drawing.Size(41, 20);
            this.lblGllx.TabIndex = 11;
            this.lblGllx.Text = "关联类型";
            // 
            // intGllx
            // 
            this.intGllx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intGllx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intGllx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intGllx.EnableTouchMode = true;
            this.intGllx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intGllx.IntegerValue = ((long)(0));
            this.intGllx.Location = new System.Drawing.Point(0,0);
            this.intGllx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intGllx.Name = "intGllx";
            this.intGllx.NullString = "";
            this.intGllx.Size = new System.Drawing.Size(152, 28);
            this.intGllx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intGllx.TabIndex = 12;
            this.intGllx.Text = "0";
            // 
            // lblID
            // 
            this.lblGxb.AutoSize = true;
            this.lblGxb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGxb.Location = new System.Drawing.Point(0,0);
            this.lblGxb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGxb.Name = "lblGxb";
            this.lblGxb.Size = new System.Drawing.Size(41, 20);
            this.lblGxb.TabIndex = 13;
            this.lblGxb.Text = "关系表名";
            // 
            // txtGxb
            // 
            this.txtGxb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGxb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGxb.EnableTouchMode = true;
            this.txtGxb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGxb.Location =  new System.Drawing.Point(0,0);
            this.txtGxb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGxb.Name = "txtGxb";
            this.txtGxb.Size = new System.Drawing.Size(152, 28);
            this.txtGxb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGxb.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblYsgx.AutoSize = true;
            this.lblYsgx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsgx.Location = new System.Drawing.Point(0,0);
            this.lblYsgx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsgx.Name = "lblYsgx";
            this.lblYsgx.Size = new System.Drawing.Size(41, 20);
            this.lblYsgx.TabIndex = 15;
            this.lblYsgx.Text = "原始关系";
            // 
            // txtYsgx
            // 
            this.txtYsgx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsgx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsgx.EnableTouchMode = true;
            this.txtYsgx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsgx.Location =  new System.Drawing.Point(0,0);
            this.txtYsgx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsgx.Name = "txtYsgx";
            this.txtYsgx.Size = new System.Drawing.Size(152, 28);
            this.txtYsgx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsgx.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblGlgx.AutoSize = true;
            this.lblGlgx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGlgx.Location = new System.Drawing.Point(0,0);
            this.lblGlgx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGlgx.Name = "lblGlgx";
            this.lblGlgx.Size = new System.Drawing.Size(41, 20);
            this.lblGlgx.TabIndex = 17;
            this.lblGlgx.Text = "关联关系";
            // 
            // txtGlgx
            // 
            this.txtGlgx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGlgx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGlgx.EnableTouchMode = true;
            this.txtGlgx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGlgx.Location =  new System.Drawing.Point(0,0);
            this.txtGlgx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGlgx.Name = "txtGlgx";
            this.txtGlgx.Size = new System.Drawing.Size(152, 28);
            this.txtGlgx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGlgx.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYsbm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsbm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGlbm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGlbm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYszd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYszd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGlzd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtGlzd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGllx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.intGllx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGxb, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGxb, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblYsgx, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtYsgx, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblGlgx, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtGlgx, 1, 8);
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
            // ucVgClassrelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgClassrelation";
            this.Size = new System.Drawing.Size(250, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsbm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlbm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYszd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlzd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intGllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsgx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGlgx)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsbm;	
        private System.Windows.Forms.Label lblYsbm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGlbm;	
        private System.Windows.Forms.Label lblGlbm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYszd;	
        private System.Windows.Forms.Label lblYszd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGlzd;	
        private System.Windows.Forms.Label lblGlzd;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intGllx;	
        private System.Windows.Forms.Label lblGllx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGxb;	
        private System.Windows.Forms.Label lblGxb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsgx;	
        private System.Windows.Forms.Label lblYsgx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGlgx;	
        private System.Windows.Forms.Label lblGlgx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}