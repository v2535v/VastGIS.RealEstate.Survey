using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucXzq
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
            this.lblXzqdm = new System.Windows.Forms.Label();
            this.txtXzqdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXzqmc = new System.Windows.Forms.Label();
            this.txtXzqmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXzqmj = new System.Windows.Forms.Label();
            this.dblXzqmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzqmj)).BeginInit();
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
            this.lblXzqdm.AutoSize = true;
            this.lblXzqdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzqdm.Location = new System.Drawing.Point(0,0);
            this.lblXzqdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzqdm.Name = "lblXzqdm";
            this.lblXzqdm.Size = new System.Drawing.Size(41, 20);
            this.lblXzqdm.TabIndex = 5;
            this.lblXzqdm.Text = "行政区代码";
            // 
            // txtXzqdm
            // 
            this.txtXzqdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXzqdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXzqdm.EnableTouchMode = true;
            this.txtXzqdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXzqdm.Location =  new System.Drawing.Point(0,0);
            this.txtXzqdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXzqdm.Name = "txtXzqdm";
            this.txtXzqdm.Size = new System.Drawing.Size(152, 28);
            this.txtXzqdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXzqdm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblXzqmc.AutoSize = true;
            this.lblXzqmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzqmc.Location = new System.Drawing.Point(0,0);
            this.lblXzqmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzqmc.Name = "lblXzqmc";
            this.lblXzqmc.Size = new System.Drawing.Size(41, 20);
            this.lblXzqmc.TabIndex = 7;
            this.lblXzqmc.Text = "行政区名称";
            // 
            // txtXzqmc
            // 
            this.txtXzqmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXzqmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXzqmc.EnableTouchMode = true;
            this.txtXzqmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXzqmc.Location =  new System.Drawing.Point(0,0);
            this.txtXzqmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXzqmc.Name = "txtXzqmc";
            this.txtXzqmc.Size = new System.Drawing.Size(152, 28);
            this.txtXzqmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXzqmc.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblXzqmj.AutoSize = true;
            this.lblXzqmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzqmj.Location = new System.Drawing.Point(0,0);
            this.lblXzqmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzqmj.Name = "lblXzqmj";
            this.lblXzqmj.Size = new System.Drawing.Size(41, 20);
            this.lblXzqmj.TabIndex = 9;
            this.lblXzqmj.Text = "行政区面积";
            // 
            // dblXzqmj
            // 
            this.dblXzqmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblXzqmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXzqmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblXzqmj.DoubleValue = 1D;
            this.dblXzqmj.EnableTouchMode = true;
            this.dblXzqmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblXzqmj.Location =  new System.Drawing.Point(0,0);
            this.dblXzqmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXzqmj.Name = "dblXzqmj";
            this.dblXzqmj.NullString = "";
            this.dblXzqmj.Size = new System.Drawing.Size(152, 28);
            this.dblXzqmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXzqmj.TabIndex = 10;
            this.dblXzqmj.Text = "1.00";
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
            this.tableLayoutPanel1.Controls.Add(this.lblXzqdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtXzqdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblXzqmc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtXzqmc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblXzqmj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblXzqmj, 1, 4);
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
            // ucXzq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucXzq";
            this.Size = new System.Drawing.Size(250, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXzqmj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXzqdm;	
        private System.Windows.Forms.Label lblXzqdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXzqmc;	
        private System.Windows.Forms.Label lblXzqmc;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXzqmj;	
        private System.Windows.Forms.Label lblXzqmj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}