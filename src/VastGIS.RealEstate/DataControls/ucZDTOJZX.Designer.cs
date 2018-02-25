using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZdtojzx
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
            this.lblZdWydm = new System.Windows.Forms.Label();
            this.txtZdWydm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJzxWydm = new System.Windows.Forms.Label();
            this.txtJzxWydm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSxh = new System.Windows.Forms.Label();
            this.intSxh = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdWydm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzxWydm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).BeginInit();
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
            this.lblZdWydm.AutoSize = true;
            this.lblZdWydm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdWydm.Location = new System.Drawing.Point(0,0);
            this.lblZdWydm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdWydm.Name = "lblZdWydm";
            this.lblZdWydm.Size = new System.Drawing.Size(41, 20);
            this.lblZdWydm.TabIndex = 3;
            this.lblZdWydm.Text = "宗地唯一代码";
            // 
            // txtZdWydm
            // 
            this.txtZdWydm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdWydm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdWydm.EnableTouchMode = true;
            this.txtZdWydm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdWydm.Location =  new System.Drawing.Point(0,0);
            this.txtZdWydm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdWydm.Name = "txtZdWydm";
            this.txtZdWydm.Size = new System.Drawing.Size(152, 28);
            this.txtZdWydm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdWydm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblJzxWydm.AutoSize = true;
            this.lblJzxWydm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzxWydm.Location = new System.Drawing.Point(0,0);
            this.lblJzxWydm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzxWydm.Name = "lblJzxWydm";
            this.lblJzxWydm.Size = new System.Drawing.Size(41, 20);
            this.lblJzxWydm.TabIndex = 5;
            this.lblJzxWydm.Text = "界址线唯一代码";
            // 
            // txtJzxWydm
            // 
            this.txtJzxWydm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJzxWydm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJzxWydm.EnableTouchMode = true;
            this.txtJzxWydm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJzxWydm.Location =  new System.Drawing.Point(0,0);
            this.txtJzxWydm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJzxWydm.Name = "txtJzxWydm";
            this.txtJzxWydm.Size = new System.Drawing.Size(152, 28);
            this.txtJzxWydm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJzxWydm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblSxh.AutoSize = true;
            this.lblSxh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSxh.Location = new System.Drawing.Point(0,0);
            this.lblSxh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSxh.Name = "lblSxh";
            this.lblSxh.Size = new System.Drawing.Size(41, 20);
            this.lblSxh.TabIndex = 7;
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
            this.intSxh.TabIndex = 8;
            this.intSxh.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdWydm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZdWydm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblJzxWydm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtJzxWydm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSxh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.intSxh, 1, 3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);            
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";            
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 364);
            this.tableLayoutPanel1.TabIndex = 9; 
            //
            // ucZdtojzx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucZdtojzx";
            this.Size = new System.Drawing.Size(250, 156);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdWydm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJzxWydm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSxh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdWydm;	
        private System.Windows.Forms.Label lblZdWydm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJzxWydm;	
        private System.Windows.Forms.Label lblJzxWydm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSxh;	
        private System.Windows.Forms.Label lblSxh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}