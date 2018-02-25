using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucMzdzw
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
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdcdyh = new System.Windows.Forms.Label();
            this.txtBdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdzhdm = new System.Windows.Forms.Label();
            this.txtZdzhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMzdzwlx = new System.Windows.Forms.Label();
            this.txtMzdzwlx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDzwmc = new System.Windows.Forms.Label();
            this.txtDzwmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMjdw = new System.Windows.Forms.Label();
            this.cmbMjdw = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblMj = new System.Windows.Forms.Label();
            this.dblMj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblDah = new System.Windows.Forms.Label();
            this.txtDah = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZt = new System.Windows.Forms.Label();
            this.cmbZt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMzdzwlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzwmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblMj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).BeginInit();
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
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 3;
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
            this.txtYsdm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdyh.TabIndex = 5;
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
            this.txtBdcdyh.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblZdzhdm.AutoSize = true;
            this.lblZdzhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdzhdm.Location = new System.Drawing.Point(0,0);
            this.lblZdzhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdzhdm.Name = "lblZdzhdm";
            this.lblZdzhdm.Size = new System.Drawing.Size(41, 20);
            this.lblZdzhdm.TabIndex = 7;
            this.lblZdzhdm.Text = "宗地/宗海代码";
            // 
            // txtZdzhdm
            // 
            this.txtZdzhdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdzhdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdzhdm.EnableTouchMode = true;
            this.txtZdzhdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdzhdm.Location =  new System.Drawing.Point(0,0);
            this.txtZdzhdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdzhdm.Name = "txtZdzhdm";
            this.txtZdzhdm.Size = new System.Drawing.Size(152, 28);
            this.txtZdzhdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdzhdm.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblMzdzwlx.AutoSize = true;
            this.lblMzdzwlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMzdzwlx.Location = new System.Drawing.Point(0,0);
            this.lblMzdzwlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMzdzwlx.Name = "lblMzdzwlx";
            this.lblMzdzwlx.Size = new System.Drawing.Size(41, 20);
            this.lblMzdzwlx.TabIndex = 9;
            this.lblMzdzwlx.Text = "面状定着物类型";
            // 
            // txtMzdzwlx
            // 
            this.txtMzdzwlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMzdzwlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtMzdzwlx.EnableTouchMode = true;
            this.txtMzdzwlx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMzdzwlx.Location =  new System.Drawing.Point(0,0);
            this.txtMzdzwlx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMzdzwlx.Name = "txtMzdzwlx";
            this.txtMzdzwlx.Size = new System.Drawing.Size(152, 28);
            this.txtMzdzwlx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMzdzwlx.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblDzwmc.AutoSize = true;
            this.lblDzwmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDzwmc.Location = new System.Drawing.Point(0,0);
            this.lblDzwmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDzwmc.Name = "lblDzwmc";
            this.lblDzwmc.Size = new System.Drawing.Size(41, 20);
            this.lblDzwmc.TabIndex = 11;
            this.lblDzwmc.Text = "定着物名称";
            // 
            // txtDzwmc
            // 
            this.txtDzwmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDzwmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDzwmc.EnableTouchMode = true;
            this.txtDzwmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDzwmc.Location =  new System.Drawing.Point(0,0);
            this.txtDzwmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDzwmc.Name = "txtDzwmc";
            this.txtDzwmc.Size = new System.Drawing.Size(152, 28);
            this.txtDzwmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDzwmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblMjdw.AutoSize = true;
            this.lblMjdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMjdw.Location = new System.Drawing.Point(0,0);
            this.lblMjdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMjdw.Name = "lblMjdw";
            this.lblMjdw.Size = new System.Drawing.Size(41, 20);
            this.lblMjdw.TabIndex = 13;
            this.lblMjdw.Text = "面积单位";
            // 
            // cmbMjdw
            // 
            this.cmbMjdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMjdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbMjdw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMjdw.EnableTouchMode = true;
            this.cmbMjdw.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMjdw.Location =  new System.Drawing.Point(0,0);
            this.cmbMjdw.Name = "cmbMjdw";
            this.cmbMjdw.Size = new System.Drawing.Size(152, 20);
            this.cmbMjdw.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblMj.AutoSize = true;
            this.lblMj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMj.Location = new System.Drawing.Point(0,0);
            this.lblMj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMj.Name = "lblMj";
            this.lblMj.Size = new System.Drawing.Size(41, 20);
            this.lblMj.TabIndex = 15;
            this.lblMj.Text = "面积";
            // 
            // dblMj
            // 
            this.dblMj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblMj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblMj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblMj.DoubleValue = 1D;
            this.dblMj.EnableTouchMode = true;
            this.dblMj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblMj.Location =  new System.Drawing.Point(0,0);
            this.dblMj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblMj.Name = "dblMj";
            this.dblMj.NullString = "";
            this.dblMj.Size = new System.Drawing.Size(152, 28);
            this.dblMj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblMj.TabIndex = 16;
            this.dblMj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblDah.AutoSize = true;
            this.lblDah.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDah.Location = new System.Drawing.Point(0,0);
            this.lblDah.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDah.Name = "lblDah";
            this.lblDah.Size = new System.Drawing.Size(41, 20);
            this.lblDah.TabIndex = 17;
            this.lblDah.Text = "档案号";
            // 
            // txtDah
            // 
            this.txtDah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDah.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDah.EnableTouchMode = true;
            this.txtDah.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDah.Location =  new System.Drawing.Point(0,0);
            this.txtDah.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDah.Name = "txtDah";
            this.txtDah.Size = new System.Drawing.Size(152, 28);
            this.txtDah.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDah.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblZt.AutoSize = true;
            this.lblZt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZt.Location = new System.Drawing.Point(0,0);
            this.lblZt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZt.Name = "lblZt";
            this.lblZt.Size = new System.Drawing.Size(41, 20);
            this.lblZt.TabIndex = 19;
            this.lblZt.Text = "状态";
            // 
            // cmbZt
            // 
            this.cmbZt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbZt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbZt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.EnableTouchMode = true;
            this.cmbZt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.Location =  new System.Drawing.Point(0,0);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(152, 20);
            this.cmbZt.TabIndex =  20;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZdzhdm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZdzhdm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMzdzwlx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMzdzwlx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDzwmc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDzwmc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMjdw, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbMjdw, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMj, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblMj, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDah, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDah, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZt, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbZt, 4, 4);
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
            // ucMzdzw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucMzdzw";
            this.Size = new System.Drawing.Size(500, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMzdzwlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDzwmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMjdw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblMj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZt)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdzhdm;	
        private System.Windows.Forms.Label lblZdzhdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMzdzwlx;	
        private System.Windows.Forms.Label lblMzdzwlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDzwmc;	
        private System.Windows.Forms.Label lblDzwmc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbMjdw;	
        private System.Windows.Forms.Label lblMjdw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblMj;	
        private System.Windows.Forms.Label lblMj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDah;	
        private System.Windows.Forms.Label lblDah;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZt;	
        private System.Windows.Forms.Label lblZt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}