using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJzd
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
            this.lblZdzhdm = new System.Windows.Forms.Label();
            this.txtZdzhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJzdh = new System.Windows.Forms.Label();
            this.txtJzdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSxh = new System.Windows.Forms.Label();
            this.intSxh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblJblx = new System.Windows.Forms.Label();
            this.cmbJblx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJzdlx = new System.Windows.Forms.Label();
            this.cmbJzdlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblXzbz = new System.Windows.Forms.Label();
            this.dblXzbz = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblYzbz = new System.Windows.Forms.Label();
            this.dblYzbz = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJblx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzdlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzbz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYzbz)).BeginInit();
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
            this.lblZdzhdm.AutoSize = true;
            this.lblZdzhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdzhdm.Location = new System.Drawing.Point(0,0);
            this.lblZdzhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdzhdm.Name = "lblZdzhdm";
            this.lblZdzhdm.Size = new System.Drawing.Size(41, 20);
            this.lblZdzhdm.TabIndex = 3;
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
            this.txtZdzhdm.TabIndex = 4;
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
            this.lblJzdh.AutoSize = true;
            this.lblJzdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzdh.Location = new System.Drawing.Point(0,0);
            this.lblJzdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzdh.Name = "lblJzdh";
            this.lblJzdh.Size = new System.Drawing.Size(41, 20);
            this.lblJzdh.TabIndex = 7;
            this.lblJzdh.Text = "界址点号";
            // 
            // txtJzdh
            // 
            this.txtJzdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJzdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJzdh.EnableTouchMode = true;
            this.txtJzdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJzdh.Location =  new System.Drawing.Point(0,0);
            this.txtJzdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJzdh.Name = "txtJzdh";
            this.txtJzdh.Size = new System.Drawing.Size(152, 28);
            this.txtJzdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJzdh.TabIndex = 8;
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
            this.lblJblx.AutoSize = true;
            this.lblJblx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJblx.Location = new System.Drawing.Point(0,0);
            this.lblJblx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJblx.Name = "lblJblx";
            this.lblJblx.Size = new System.Drawing.Size(41, 20);
            this.lblJblx.TabIndex = 11;
            this.lblJblx.Text = "界标类型";
            // 
            // cmbJblx
            // 
            this.cmbJblx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJblx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJblx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJblx.EnableTouchMode = true;
            this.cmbJblx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJblx.Location =  new System.Drawing.Point(0,0);
            this.cmbJblx.Name = "cmbJblx";
            this.cmbJblx.Size = new System.Drawing.Size(152, 20);
            this.cmbJblx.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblJzdlx.AutoSize = true;
            this.lblJzdlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzdlx.Location = new System.Drawing.Point(0,0);
            this.lblJzdlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzdlx.Name = "lblJzdlx";
            this.lblJzdlx.Size = new System.Drawing.Size(41, 20);
            this.lblJzdlx.TabIndex = 13;
            this.lblJzdlx.Text = "界址点类型";
            // 
            // cmbJzdlx
            // 
            this.cmbJzdlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJzdlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJzdlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJzdlx.EnableTouchMode = true;
            this.cmbJzdlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJzdlx.Location =  new System.Drawing.Point(0,0);
            this.cmbJzdlx.Name = "cmbJzdlx";
            this.cmbJzdlx.Size = new System.Drawing.Size(152, 20);
            this.cmbJzdlx.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblXzbz.AutoSize = true;
            this.lblXzbz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzbz.Location = new System.Drawing.Point(0,0);
            this.lblXzbz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzbz.Name = "lblXzbz";
            this.lblXzbz.Size = new System.Drawing.Size(41, 20);
            this.lblXzbz.TabIndex = 15;
            this.lblXzbz.Text = "X坐标值";
            // 
            // dblXzbz
            // 
            this.dblXzbz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblXzbz.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXzbz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblXzbz.DoubleValue = 1D;
            this.dblXzbz.EnableTouchMode = true;
            this.dblXzbz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblXzbz.Location =  new System.Drawing.Point(0,0);
            this.dblXzbz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXzbz.Name = "dblXzbz";
            this.dblXzbz.NullString = "";
            this.dblXzbz.Size = new System.Drawing.Size(152, 28);
            this.dblXzbz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXzbz.TabIndex = 16;
            this.dblXzbz.Text = "1.00";
            // 
            // lblID
            // 
            this.lblYzbz.AutoSize = true;
            this.lblYzbz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYzbz.Location = new System.Drawing.Point(0,0);
            this.lblYzbz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYzbz.Name = "lblYzbz";
            this.lblYzbz.Size = new System.Drawing.Size(41, 20);
            this.lblYzbz.TabIndex = 17;
            this.lblYzbz.Text = "Y坐标值";
            // 
            // dblYzbz
            // 
            this.dblYzbz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYzbz.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYzbz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYzbz.DoubleValue = 1D;
            this.dblYzbz.EnableTouchMode = true;
            this.dblYzbz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYzbz.Location =  new System.Drawing.Point(0,0);
            this.dblYzbz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYzbz.Name = "dblYzbz";
            this.dblYzbz.NullString = "";
            this.dblYzbz.Size = new System.Drawing.Size(152, 28);
            this.dblYzbz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYzbz.TabIndex = 18;
            this.dblYzbz.Text = "1.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdzhdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZdzhdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJzdh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtJzdh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSxh, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.intSxh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblJblx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbJblx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJzdlx, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbJzdlx, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblXzbz, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblXzbz, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblYzbz, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dblYzbz, 1, 8);
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
            // ucJzd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucJzd";
            this.Size = new System.Drawing.Size(250, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJblx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzdlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzbz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYzbz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdzhdm;	
        private System.Windows.Forms.Label lblZdzhdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJzdh;	
        private System.Windows.Forms.Label lblJzdh;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSxh;	
        private System.Windows.Forms.Label lblSxh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJblx;	
        private System.Windows.Forms.Label lblJblx;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJzdlx;	
        private System.Windows.Forms.Label lblJzdlx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXzbz;	
        private System.Windows.Forms.Label lblXzbz;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYzbz;	
        private System.Windows.Forms.Label lblYzbz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}