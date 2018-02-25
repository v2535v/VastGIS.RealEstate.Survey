using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucXzqjx
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
            this.lblJxlx = new System.Windows.Forms.Label();
            this.cmbJxlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJxxz = new System.Windows.Forms.Label();
            this.cmbJxxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJxsm = new System.Windows.Forms.Label();
            this.txtJxsm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJxsm)).BeginInit();
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
            this.lblJxlx.AutoSize = true;
            this.lblJxlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJxlx.Location = new System.Drawing.Point(0,0);
            this.lblJxlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJxlx.Name = "lblJxlx";
            this.lblJxlx.Size = new System.Drawing.Size(41, 20);
            this.lblJxlx.TabIndex = 5;
            this.lblJxlx.Text = "界线类型";
            // 
            // cmbJxlx
            // 
            this.cmbJxlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJxlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJxlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJxlx.EnableTouchMode = true;
            this.cmbJxlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJxlx.Location =  new System.Drawing.Point(0,0);
            this.cmbJxlx.Name = "cmbJxlx";
            this.cmbJxlx.Size = new System.Drawing.Size(152, 20);
            this.cmbJxlx.TabIndex =  6;            
            // 
            // lblID
            // 
            this.lblJxxz.AutoSize = true;
            this.lblJxxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJxxz.Location = new System.Drawing.Point(0,0);
            this.lblJxxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJxxz.Name = "lblJxxz";
            this.lblJxxz.Size = new System.Drawing.Size(41, 20);
            this.lblJxxz.TabIndex = 7;
            this.lblJxxz.Text = "界线性质";
            // 
            // cmbJxxz
            // 
            this.cmbJxxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJxxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJxxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJxxz.EnableTouchMode = true;
            this.cmbJxxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJxxz.Location =  new System.Drawing.Point(0,0);
            this.cmbJxxz.Name = "cmbJxxz";
            this.cmbJxxz.Size = new System.Drawing.Size(152, 20);
            this.cmbJxxz.TabIndex =  8;            
            // 
            // lblID
            // 
            this.lblJxsm.AutoSize = true;
            this.lblJxsm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJxsm.Location = new System.Drawing.Point(0,0);
            this.lblJxsm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJxsm.Name = "lblJxsm";
            this.lblJxsm.Size = new System.Drawing.Size(41, 20);
            this.lblJxsm.TabIndex = 9;
            this.lblJxsm.Text = "界线说明";
            // 
            // txtJxsm
            // 
            this.txtJxsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJxsm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJxsm.EnableTouchMode = true;
            this.txtJxsm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJxsm.Location =  new System.Drawing.Point(0,0);
            this.txtJxsm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJxsm.Name = "txtJxsm";
            this.txtJxsm.Size = new System.Drawing.Size(152, 28);
            this.txtJxsm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJxsm.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJxlx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbJxlx, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJxxz, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbJxxz, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJxsm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtJxsm, 1, 4);
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
            this.tableLayoutPanel1.TabIndex = 11; 
            //
            // ucXzqjx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucXzqjx";
            this.Size = new System.Drawing.Size(250, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJxsm)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJxlx;	
        private System.Windows.Forms.Label lblJxlx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJxxz;	
        private System.Windows.Forms.Label lblJxxz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJxsm;	
        private System.Windows.Forms.Label lblJxsm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}