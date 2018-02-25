using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucYhzk
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
            this.lblZhdm = new System.Windows.Forms.Label();
            this.txtZhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYhfs = new System.Windows.Forms.Label();
            this.cmbYhfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYhmj = new System.Windows.Forms.Label();
            this.dblYhmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJtyt = new System.Windows.Forms.Label();
            this.txtJtyt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSyjse = new System.Windows.Forms.Label();
            this.dblSyjse = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYhmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJtyt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyjse)).BeginInit();
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
            this.lblZhdm.AutoSize = true;
            this.lblZhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhdm.Location = new System.Drawing.Point(0,0);
            this.lblZhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhdm.Name = "lblZhdm";
            this.lblZhdm.Size = new System.Drawing.Size(41, 20);
            this.lblZhdm.TabIndex = 3;
            this.lblZhdm.Text = "宗海代码";
            // 
            // txtZhdm
            // 
            this.txtZhdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZhdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZhdm.EnableTouchMode = true;
            this.txtZhdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZhdm.Location =  new System.Drawing.Point(0,0);
            this.txtZhdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZhdm.Name = "txtZhdm";
            this.txtZhdm.Size = new System.Drawing.Size(152, 28);
            this.txtZhdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZhdm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblYhfs.AutoSize = true;
            this.lblYhfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhfs.Location = new System.Drawing.Point(0,0);
            this.lblYhfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhfs.Name = "lblYhfs";
            this.lblYhfs.Size = new System.Drawing.Size(41, 20);
            this.lblYhfs.TabIndex = 5;
            this.lblYhfs.Text = "用海方式";
            // 
            // cmbYhfs
            // 
            this.cmbYhfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbYhfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbYhfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYhfs.EnableTouchMode = true;
            this.cmbYhfs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbYhfs.Location =  new System.Drawing.Point(0,0);
            this.cmbYhfs.Name = "cmbYhfs";
            this.cmbYhfs.Size = new System.Drawing.Size(152, 20);
            this.cmbYhfs.TabIndex =  6;            
            // 
            // lblID
            // 
            this.lblYhmj.AutoSize = true;
            this.lblYhmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYhmj.Location = new System.Drawing.Point(0,0);
            this.lblYhmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYhmj.Name = "lblYhmj";
            this.lblYhmj.Size = new System.Drawing.Size(41, 20);
            this.lblYhmj.TabIndex = 7;
            this.lblYhmj.Text = "用海面积";
            // 
            // dblYhmj
            // 
            this.dblYhmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYhmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYhmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYhmj.DoubleValue = 1D;
            this.dblYhmj.EnableTouchMode = true;
            this.dblYhmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYhmj.Location =  new System.Drawing.Point(0,0);
            this.dblYhmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYhmj.Name = "dblYhmj";
            this.dblYhmj.NullString = "";
            this.dblYhmj.Size = new System.Drawing.Size(152, 28);
            this.dblYhmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYhmj.TabIndex = 8;
            this.dblYhmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJtyt.AutoSize = true;
            this.lblJtyt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJtyt.Location = new System.Drawing.Point(0,0);
            this.lblJtyt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJtyt.Name = "lblJtyt";
            this.lblJtyt.Size = new System.Drawing.Size(41, 20);
            this.lblJtyt.TabIndex = 9;
            this.lblJtyt.Text = "具体用途";
            // 
            // txtJtyt
            // 
            this.txtJtyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJtyt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJtyt.EnableTouchMode = true;
            this.txtJtyt.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJtyt.Location =  new System.Drawing.Point(0,0);
            this.txtJtyt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJtyt.Name = "txtJtyt";
            this.txtJtyt.Size = new System.Drawing.Size(152, 28);
            this.txtJtyt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJtyt.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblSyjse.AutoSize = true;
            this.lblSyjse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSyjse.Location = new System.Drawing.Point(0,0);
            this.lblSyjse.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSyjse.Name = "lblSyjse";
            this.lblSyjse.Size = new System.Drawing.Size(41, 20);
            this.lblSyjse.TabIndex = 11;
            this.lblSyjse.Text = "使用金数额";
            // 
            // dblSyjse
            // 
            this.dblSyjse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSyjse.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSyjse.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSyjse.DoubleValue = 1D;
            this.dblSyjse.EnableTouchMode = true;
            this.dblSyjse.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSyjse.Location =  new System.Drawing.Point(0,0);
            this.dblSyjse.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSyjse.Name = "dblSyjse";
            this.dblSyjse.NullString = "";
            this.dblSyjse.Size = new System.Drawing.Size(152, 28);
            this.dblSyjse.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSyjse.TabIndex = 12;
            this.dblSyjse.Text = "1.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZhdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZhdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYhfs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbYhfs, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYhmj, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblYhmj, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJtyt, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtJtyt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSyjse, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dblSyjse, 1, 5);
            this.tableLayoutPanel1.RowCount = 6;
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
            this.tableLayoutPanel1.TabIndex = 13; 
            //
            // ucYhzk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucYhzk";
            this.Size = new System.Drawing.Size(250, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYhfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYhmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJtyt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSyjse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZhdm;	
        private System.Windows.Forms.Label lblZhdm;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbYhfs;	
        private System.Windows.Forms.Label lblYhfs;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYhmj;	
        private System.Windows.Forms.Label lblYhmj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJtyt;	
        private System.Windows.Forms.Label lblJtyt;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSyjse;	
        private System.Windows.Forms.Label lblSyjse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}