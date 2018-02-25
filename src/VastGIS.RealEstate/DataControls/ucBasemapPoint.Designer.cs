using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucBasemapPoint
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
            this.lblTc = new System.Windows.Forms.Label();
            this.txtTc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCassdm = new System.Windows.Forms.Label();
            this.txtCassdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFh = new System.Windows.Forms.Label();
            this.txtFh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFhdx = new System.Windows.Forms.Label();
            this.dblFhdx = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblXzjd = new System.Windows.Forms.Label();
            this.dblXzjd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFsxx1 = new System.Windows.Forms.Label();
            this.txtFsxx1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFsxx2 = new System.Windows.Forms.Label();
            this.txtFsxx2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFhdx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzjd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFsxx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFsxx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
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
            this.lblTc.AutoSize = true;
            this.lblTc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTc.Location = new System.Drawing.Point(0,0);
            this.lblTc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(41, 20);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "图层";
            // 
            // txtTc
            // 
            this.txtTc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTc.EnableTouchMode = true;
            this.txtTc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTc.Location =  new System.Drawing.Point(0,0);
            this.txtTc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(152, 28);
            this.txtTc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTc.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblCassdm.AutoSize = true;
            this.lblCassdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCassdm.Location = new System.Drawing.Point(0,0);
            this.lblCassdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCassdm.Name = "lblCassdm";
            this.lblCassdm.Size = new System.Drawing.Size(41, 20);
            this.lblCassdm.TabIndex = 5;
            this.lblCassdm.Text = "CASS代码";
            // 
            // txtCassdm
            // 
            this.txtCassdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCassdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCassdm.EnableTouchMode = true;
            this.txtCassdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCassdm.Location =  new System.Drawing.Point(0,0);
            this.txtCassdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCassdm.Name = "txtCassdm";
            this.txtCassdm.Size = new System.Drawing.Size(152, 28);
            this.txtCassdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCassdm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblFh.AutoSize = true;
            this.lblFh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFh.Location = new System.Drawing.Point(0,0);
            this.lblFh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFh.Name = "lblFh";
            this.lblFh.Size = new System.Drawing.Size(41, 20);
            this.lblFh.TabIndex = 7;
            this.lblFh.Text = "符号";
            // 
            // txtFh
            // 
            this.txtFh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFh.EnableTouchMode = true;
            this.txtFh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFh.Location =  new System.Drawing.Point(0,0);
            this.txtFh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFh.Name = "txtFh";
            this.txtFh.Size = new System.Drawing.Size(152, 28);
            this.txtFh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblFhdx.AutoSize = true;
            this.lblFhdx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFhdx.Location = new System.Drawing.Point(0,0);
            this.lblFhdx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFhdx.Name = "lblFhdx";
            this.lblFhdx.Size = new System.Drawing.Size(41, 20);
            this.lblFhdx.TabIndex = 9;
            this.lblFhdx.Text = "符号大小";
            // 
            // dblFhdx
            // 
            this.dblFhdx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblFhdx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFhdx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblFhdx.DoubleValue = 1D;
            this.dblFhdx.EnableTouchMode = true;
            this.dblFhdx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblFhdx.Location =  new System.Drawing.Point(0,0);
            this.dblFhdx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFhdx.Name = "dblFhdx";
            this.dblFhdx.NullString = "";
            this.dblFhdx.Size = new System.Drawing.Size(152, 28);
            this.dblFhdx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFhdx.TabIndex = 10;
            this.dblFhdx.Text = "1.00";
            // 
            // lblID
            // 
            this.lblXzjd.AutoSize = true;
            this.lblXzjd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzjd.Location = new System.Drawing.Point(0,0);
            this.lblXzjd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzjd.Name = "lblXzjd";
            this.lblXzjd.Size = new System.Drawing.Size(41, 20);
            this.lblXzjd.TabIndex = 11;
            this.lblXzjd.Text = "旋转角度";
            // 
            // dblXzjd
            // 
            this.dblXzjd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblXzjd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXzjd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblXzjd.DoubleValue = 1D;
            this.dblXzjd.EnableTouchMode = true;
            this.dblXzjd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblXzjd.Location =  new System.Drawing.Point(0,0);
            this.dblXzjd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXzjd.Name = "dblXzjd";
            this.dblXzjd.NullString = "";
            this.dblXzjd.Size = new System.Drawing.Size(152, 28);
            this.dblXzjd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXzjd.TabIndex = 12;
            this.dblXzjd.Text = "1.00";
            // 
            // lblID
            // 
            this.lblFsxx1.AutoSize = true;
            this.lblFsxx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFsxx1.Location = new System.Drawing.Point(0,0);
            this.lblFsxx1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFsxx1.Name = "lblFsxx1";
            this.lblFsxx1.Size = new System.Drawing.Size(41, 20);
            this.lblFsxx1.TabIndex = 13;
            this.lblFsxx1.Text = "附加属性1";
            // 
            // txtFsxx1
            // 
            this.txtFsxx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFsxx1.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFsxx1.EnableTouchMode = true;
            this.txtFsxx1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFsxx1.Location =  new System.Drawing.Point(0,0);
            this.txtFsxx1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFsxx1.Name = "txtFsxx1";
            this.txtFsxx1.Size = new System.Drawing.Size(152, 28);
            this.txtFsxx1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFsxx1.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblFsxx2.AutoSize = true;
            this.lblFsxx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFsxx2.Location = new System.Drawing.Point(0,0);
            this.lblFsxx2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFsxx2.Name = "lblFsxx2";
            this.lblFsxx2.Size = new System.Drawing.Size(41, 20);
            this.lblFsxx2.TabIndex = 15;
            this.lblFsxx2.Text = "附加属性2";
            // 
            // txtFsxx2
            // 
            this.txtFsxx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFsxx2.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFsxx2.EnableTouchMode = true;
            this.txtFsxx2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFsxx2.Location =  new System.Drawing.Point(0,0);
            this.txtFsxx2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFsxx2.Name = "txtFsxx2";
            this.txtFsxx2.Size = new System.Drawing.Size(152, 28);
            this.txtFsxx2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFsxx2.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 17;
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
            this.txtYsdm.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCassdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCassdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFhdx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblFhdx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblXzjd, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblXzjd, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFsxx1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFsxx1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFsxx2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFsxx2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 8);
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
            // ucBasemapPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucBasemapPoint";
            this.Size = new System.Drawing.Size(250, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFhdx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzjd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFsxx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFsxx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTc;	
        private System.Windows.Forms.Label lblTc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCassdm;	
        private System.Windows.Forms.Label lblCassdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFh;	
        private System.Windows.Forms.Label lblFh;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFhdx;	
        private System.Windows.Forms.Label lblFhdx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXzjd;	
        private System.Windows.Forms.Label lblXzjd;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFsxx1;	
        private System.Windows.Forms.Label lblFsxx1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFsxx2;	
        private System.Windows.Forms.Label lblFsxx2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}