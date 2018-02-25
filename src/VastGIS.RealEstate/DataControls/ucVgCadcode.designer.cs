using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgCadcode
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
            this.lblXh = new System.Windows.Forms.Label();
            this.txtXh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfcy = new System.Windows.Forms.Label();
            this.intSfcy = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtTc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCassdm = new System.Windows.Forms.Label();
            this.txtCassdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTxlx = new System.Windows.Forms.Label();
            this.txtTxlx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXtc = new System.Windows.Forms.Label();
            this.txtXtc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYslx = new System.Windows.Forms.Label();
            this.txtYslx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYszl = new System.Windows.Forms.Label();
            this.intYszl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSfcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTxlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXtc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYslx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intYszl)).BeginInit();
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
            this.lblXh.AutoSize = true;
            this.lblXh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXh.Location = new System.Drawing.Point(0,0);
            this.lblXh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXh.Name = "lblXh";
            this.lblXh.Size = new System.Drawing.Size(41, 20);
            this.lblXh.TabIndex = 3;
            this.lblXh.Text = "内部序号";
            // 
            // txtXh
            // 
            this.txtXh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXh.EnableTouchMode = true;
            this.txtXh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXh.Location =  new System.Drawing.Point(0,0);
            this.txtXh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(152, 28);
            this.txtXh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXh.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblSfcy.AutoSize = true;
            this.lblSfcy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfcy.Location = new System.Drawing.Point(0,0);
            this.lblSfcy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfcy.Name = "lblSfcy";
            this.lblSfcy.Size = new System.Drawing.Size(41, 20);
            this.lblSfcy.TabIndex = 5;
            this.lblSfcy.Text = "是否采用";
            // 
            // intSfcy
            // 
            this.intSfcy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSfcy.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSfcy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSfcy.EnableTouchMode = true;
            this.intSfcy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSfcy.IntegerValue = ((long)(0));
            this.intSfcy.Location = new System.Drawing.Point(0,0);
            this.intSfcy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSfcy.Name = "intSfcy";
            this.intSfcy.NullString = "";
            this.intSfcy.Size = new System.Drawing.Size(152, 28);
            this.intSfcy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSfcy.TabIndex = 6;
            this.intSfcy.Text = "0";
            // 
            // lblID
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTc.Location = new System.Drawing.Point(0,0);
            this.lblTc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(41, 20);
            this.lblTc.TabIndex = 7;
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
            this.txtTc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblCassdm.AutoSize = true;
            this.lblCassdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCassdm.Location = new System.Drawing.Point(0,0);
            this.lblCassdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCassdm.Name = "lblCassdm";
            this.lblCassdm.Size = new System.Drawing.Size(41, 20);
            this.lblCassdm.TabIndex = 9;
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
            this.txtCassdm.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblTxlx.AutoSize = true;
            this.lblTxlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTxlx.Location = new System.Drawing.Point(0,0);
            this.lblTxlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTxlx.Name = "lblTxlx";
            this.lblTxlx.Size = new System.Drawing.Size(41, 20);
            this.lblTxlx.TabIndex = 11;
            this.lblTxlx.Text = "图形类型";
            // 
            // txtTxlx
            // 
            this.txtTxlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTxlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTxlx.EnableTouchMode = true;
            this.txtTxlx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTxlx.Location =  new System.Drawing.Point(0,0);
            this.txtTxlx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTxlx.Name = "txtTxlx";
            this.txtTxlx.Size = new System.Drawing.Size(152, 28);
            this.txtTxlx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTxlx.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblXtc.AutoSize = true;
            this.lblXtc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXtc.Location = new System.Drawing.Point(0,0);
            this.lblXtc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXtc.Name = "lblXtc";
            this.lblXtc.Size = new System.Drawing.Size(41, 20);
            this.lblXtc.TabIndex = 13;
            this.lblXtc.Text = "新图层";
            // 
            // txtXtc
            // 
            this.txtXtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXtc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXtc.EnableTouchMode = true;
            this.txtXtc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXtc.Location =  new System.Drawing.Point(0,0);
            this.txtXtc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXtc.Name = "txtXtc";
            this.txtXtc.Size = new System.Drawing.Size(152, 28);
            this.txtXtc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXtc.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 15;
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
            this.txtYsdm.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblYslx.AutoSize = true;
            this.lblYslx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYslx.Location = new System.Drawing.Point(0,0);
            this.lblYslx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYslx.Name = "lblYslx";
            this.lblYslx.Size = new System.Drawing.Size(41, 20);
            this.lblYslx.TabIndex = 17;
            this.lblYslx.Text = "要素类型";
            // 
            // txtYslx
            // 
            this.txtYslx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYslx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYslx.EnableTouchMode = true;
            this.txtYslx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYslx.Location =  new System.Drawing.Point(0,0);
            this.txtYslx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYslx.Name = "txtYslx";
            this.txtYslx.Size = new System.Drawing.Size(152, 28);
            this.txtYslx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYslx.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblYszl.AutoSize = true;
            this.lblYszl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYszl.Location = new System.Drawing.Point(0,0);
            this.lblYszl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYszl.Name = "lblYszl";
            this.lblYszl.Size = new System.Drawing.Size(41, 20);
            this.lblYszl.TabIndex = 19;
            this.lblYszl.Text = "要素种类";
            // 
            // intYszl
            // 
            this.intYszl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intYszl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intYszl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intYszl.EnableTouchMode = true;
            this.intYszl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intYszl.IntegerValue = ((long)(0));
            this.intYszl.Location = new System.Drawing.Point(0,0);
            this.intYszl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intYszl.Name = "intYszl";
            this.intYszl.NullString = "";
            this.intYszl.Size = new System.Drawing.Size(152, 28);
            this.intYszl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intYszl.TabIndex = 20;
            this.intYszl.Text = "0";
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
            this.tableLayoutPanel1.Controls.Add(this.lblXh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSfcy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.intSfcy, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCassdm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCassdm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTxlx, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTxlx, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXtc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXtc, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYslx, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYslx, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYszl, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.intYszl, 4, 4);
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
            // ucVgCadcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgCadcode";
            this.Size = new System.Drawing.Size(500, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSfcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTxlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXtc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYslx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intYszl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXh;	
        private System.Windows.Forms.Label lblXh;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSfcy;	
        private System.Windows.Forms.Label lblSfcy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTc;	
        private System.Windows.Forms.Label lblTc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCassdm;	
        private System.Windows.Forms.Label lblCassdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTxlx;	
        private System.Windows.Forms.Label lblTxlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXtc;	
        private System.Windows.Forms.Label lblXtc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYslx;	
        private System.Windows.Forms.Label lblYslx;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intYszl;	
        private System.Windows.Forms.Label lblYszl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}