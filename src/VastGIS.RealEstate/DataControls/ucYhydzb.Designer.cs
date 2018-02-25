using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucYhydzb
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
            this.lblZhhddm = new System.Windows.Forms.Label();
            this.txtZhhddm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXh = new System.Windows.Forms.Label();
            this.intXh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblBw = new System.Windows.Forms.Label();
            this.dblBw = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblDj = new System.Windows.Forms.Label();
            this.dblDj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhhddm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblBw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDj)).BeginInit();
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
            this.lblZhhddm.AutoSize = true;
            this.lblZhhddm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZhhddm.Location = new System.Drawing.Point(0,0);
            this.lblZhhddm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZhhddm.Name = "lblZhhddm";
            this.lblZhhddm.Size = new System.Drawing.Size(41, 20);
            this.lblZhhddm.TabIndex = 3;
            this.lblZhhddm.Text = "宗海/海岛代码";
            // 
            // txtZhhddm
            // 
            this.txtZhhddm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZhhddm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZhhddm.EnableTouchMode = true;
            this.txtZhhddm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZhhddm.Location =  new System.Drawing.Point(0,0);
            this.txtZhhddm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZhhddm.Name = "txtZhhddm";
            this.txtZhhddm.Size = new System.Drawing.Size(152, 28);
            this.txtZhhddm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZhhddm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblXh.AutoSize = true;
            this.lblXh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXh.Location = new System.Drawing.Point(0,0);
            this.lblXh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXh.Name = "lblXh";
            this.lblXh.Size = new System.Drawing.Size(41, 20);
            this.lblXh.TabIndex = 5;
            this.lblXh.Text = "序号";
            // 
            // intXh
            // 
            this.intXh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intXh.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intXh.EnableTouchMode = true;
            this.intXh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intXh.IntegerValue = ((long)(0));
            this.intXh.Location = new System.Drawing.Point(0,0);
            this.intXh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXh.Name = "intXh";
            this.intXh.NullString = "";
            this.intXh.Size = new System.Drawing.Size(152, 28);
            this.intXh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXh.TabIndex = 6;
            this.intXh.Text = "0";
            // 
            // lblID
            // 
            this.lblBw.AutoSize = true;
            this.lblBw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBw.Location = new System.Drawing.Point(0,0);
            this.lblBw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBw.Name = "lblBw";
            this.lblBw.Size = new System.Drawing.Size(41, 20);
            this.lblBw.TabIndex = 7;
            this.lblBw.Text = "北纬";
            // 
            // dblBw
            // 
            this.dblBw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblBw.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblBw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblBw.DoubleValue = 1D;
            this.dblBw.EnableTouchMode = true;
            this.dblBw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblBw.Location =  new System.Drawing.Point(0,0);
            this.dblBw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblBw.Name = "dblBw";
            this.dblBw.NullString = "";
            this.dblBw.Size = new System.Drawing.Size(152, 28);
            this.dblBw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblBw.TabIndex = 8;
            this.dblBw.Text = "1.00";
            // 
            // lblID
            // 
            this.lblDj.AutoSize = true;
            this.lblDj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDj.Location = new System.Drawing.Point(0,0);
            this.lblDj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDj.Name = "lblDj";
            this.lblDj.Size = new System.Drawing.Size(41, 20);
            this.lblDj.TabIndex = 9;
            this.lblDj.Text = "东经";
            // 
            // dblDj
            // 
            this.dblDj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblDj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblDj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblDj.DoubleValue = 1D;
            this.dblDj.EnableTouchMode = true;
            this.dblDj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblDj.Location =  new System.Drawing.Point(0,0);
            this.dblDj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblDj.Name = "dblDj";
            this.dblDj.NullString = "";
            this.dblDj.Size = new System.Drawing.Size(152, 28);
            this.dblDj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblDj.TabIndex = 10;
            this.dblDj.Text = "1.00";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZhhddm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZhhddm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblXh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.intXh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBw, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblBw, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dblDj, 1, 4);
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
            // ucYhydzb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucYhydzb";
            this.Size = new System.Drawing.Size(250, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZhhddm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblBw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblDj)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZhhddm;	
        private System.Windows.Forms.Label lblZhhddm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXh;	
        private System.Windows.Forms.Label lblXh;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblBw;	
        private System.Windows.Forms.Label lblBw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblDj;	
        private System.Windows.Forms.Label lblDj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}