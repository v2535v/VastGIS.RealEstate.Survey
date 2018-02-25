using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucQxzd
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
            this.lblXzqhdm = new System.Windows.Forms.Label();
            this.txtXzqhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXzqhmc = new System.Windows.Forms.Label();
            this.txtXzqhmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqhmc)).BeginInit();
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
            this.lblXzqhdm.AutoSize = true;
            this.lblXzqhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzqhdm.Location = new System.Drawing.Point(0,0);
            this.lblXzqhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzqhdm.Name = "lblXzqhdm";
            this.lblXzqhdm.Size = new System.Drawing.Size(41, 20);
            this.lblXzqhdm.TabIndex = 3;
            this.lblXzqhdm.Text = "行政区划代码";
            // 
            // txtXzqhdm
            // 
            this.txtXzqhdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXzqhdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXzqhdm.EnableTouchMode = true;
            this.txtXzqhdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXzqhdm.Location =  new System.Drawing.Point(0,0);
            this.txtXzqhdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXzqhdm.Name = "txtXzqhdm";
            this.txtXzqhdm.Size = new System.Drawing.Size(152, 28);
            this.txtXzqhdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXzqhdm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblXzqhmc.AutoSize = true;
            this.lblXzqhmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXzqhmc.Location = new System.Drawing.Point(0,0);
            this.lblXzqhmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXzqhmc.Name = "lblXzqhmc";
            this.lblXzqhmc.Size = new System.Drawing.Size(41, 20);
            this.lblXzqhmc.TabIndex = 5;
            this.lblXzqhmc.Text = "行政区划名称";
            // 
            // txtXzqhmc
            // 
            this.txtXzqhmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXzqhmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtXzqhmc.EnableTouchMode = true;
            this.txtXzqhmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXzqhmc.Location =  new System.Drawing.Point(0,0);
            this.txtXzqhmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXzqhmc.Name = "txtXzqhmc";
            this.txtXzqhmc.Size = new System.Drawing.Size(152, 28);
            this.txtXzqhmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXzqhmc.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXzqhdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtXzqhdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblXzqhmc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtXzqhmc, 1, 2);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);            
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";            
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 364);
            this.tableLayoutPanel1.TabIndex = 7; 
            //
            // ucQxzd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQxzd";
            this.Size = new System.Drawing.Size(250, 121);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXzqhmc)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXzqhdm;	
        private System.Windows.Forms.Label lblXzqhdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXzqhmc;	
        private System.Windows.Forms.Label lblXzqhmc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}