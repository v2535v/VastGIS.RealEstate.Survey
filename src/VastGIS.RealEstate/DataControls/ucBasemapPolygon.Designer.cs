using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucBasemapPolygon
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
            this.lblFsxx1.AutoSize = true;
            this.lblFsxx1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFsxx1.Location = new System.Drawing.Point(0,0);
            this.lblFsxx1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFsxx1.Name = "lblFsxx1";
            this.lblFsxx1.Size = new System.Drawing.Size(41, 20);
            this.lblFsxx1.TabIndex = 7;
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
            this.txtFsxx1.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblFsxx2.AutoSize = true;
            this.lblFsxx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFsxx2.Location = new System.Drawing.Point(0,0);
            this.lblFsxx2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFsxx2.Name = "lblFsxx2";
            this.lblFsxx2.Size = new System.Drawing.Size(41, 20);
            this.lblFsxx2.TabIndex = 9;
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
            this.txtFsxx2.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 11;
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
            this.txtYsdm.TabIndex = 12;
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
            this.tableLayoutPanel1.Controls.Add(this.lblFsxx1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFsxx1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFsxx2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFsxx2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 5);
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
            // ucBasemapPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucBasemapPolygon";
            this.Size = new System.Drawing.Size(250, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCassdm)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFsxx1;	
        private System.Windows.Forms.Label lblFsxx1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFsxx2;	
        private System.Windows.Forms.Label lblFsxx2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}