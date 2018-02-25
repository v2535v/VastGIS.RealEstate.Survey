using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSgsj
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
            this.lblSjwjm = new System.Windows.Forms.Label();
            this.txtSjwjm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTwjm = new System.Windows.Forms.Label();
            this.txtTwjm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsjwjm = new System.Windows.Forms.Label();
            this.txtYsjwjm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjwjm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTwjm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsjwjm)).BeginInit();
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
            this.lblSjwjm.AutoSize = true;
            this.lblSjwjm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjwjm.Location = new System.Drawing.Point(0,0);
            this.lblSjwjm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjwjm.Name = "lblSjwjm";
            this.lblSjwjm.Size = new System.Drawing.Size(41, 20);
            this.lblSjwjm.TabIndex = 5;
            this.lblSjwjm.Text = "数据文件名";
            // 
            // txtSjwjm
            // 
            this.txtSjwjm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSjwjm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSjwjm.EnableTouchMode = true;
            this.txtSjwjm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSjwjm.Location =  new System.Drawing.Point(0,0);
            this.txtSjwjm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSjwjm.Name = "txtSjwjm";
            this.txtSjwjm.Size = new System.Drawing.Size(152, 28);
            this.txtSjwjm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSjwjm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblTwjm.AutoSize = true;
            this.lblTwjm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTwjm.Location = new System.Drawing.Point(0,0);
            this.lblTwjm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblTwjm.Name = "lblTwjm";
            this.lblTwjm.Size = new System.Drawing.Size(41, 20);
            this.lblTwjm.TabIndex = 7;
            this.lblTwjm.Text = "头文件名";
            // 
            // txtTwjm
            // 
            this.txtTwjm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTwjm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTwjm.EnableTouchMode = true;
            this.txtTwjm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTwjm.Location =  new System.Drawing.Point(0,0);
            this.txtTwjm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTwjm.Name = "txtTwjm";
            this.txtTwjm.Size = new System.Drawing.Size(152, 28);
            this.txtTwjm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTwjm.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblYsjwjm.AutoSize = true;
            this.lblYsjwjm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsjwjm.Location = new System.Drawing.Point(0,0);
            this.lblYsjwjm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsjwjm.Name = "lblYsjwjm";
            this.lblYsjwjm.Size = new System.Drawing.Size(41, 20);
            this.lblYsjwjm.TabIndex = 9;
            this.lblYsjwjm.Text = "元数据文件名";
            // 
            // txtYsjwjm
            // 
            this.txtYsjwjm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsjwjm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsjwjm.EnableTouchMode = true;
            this.txtYsjwjm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsjwjm.Location =  new System.Drawing.Point(0,0);
            this.txtYsjwjm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsjwjm.Name = "txtYsjwjm";
            this.txtYsjwjm.Size = new System.Drawing.Size(152, 28);
            this.txtYsjwjm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsjwjm.TabIndex = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.lblSjwjm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSjwjm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTwjm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTwjm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblYsjwjm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtYsjwjm, 1, 4);
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
            // ucSgsj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSgsj";
            this.Size = new System.Drawing.Size(250, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjwjm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTwjm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsjwjm)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSjwjm;	
        private System.Windows.Forms.Label lblSjwjm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTwjm;	
        private System.Windows.Forms.Label lblTwjm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsjwjm;	
        private System.Windows.Forms.Label lblYsjwjm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}