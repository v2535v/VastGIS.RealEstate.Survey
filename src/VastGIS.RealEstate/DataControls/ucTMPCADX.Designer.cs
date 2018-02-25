using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucTmpCadx
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
            this.lblEntityType = new System.Windows.Forms.Label();
            this.txtEntityType = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHandle = new System.Windows.Forms.Label();
            this.txtHandle = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName)).BeginInit();
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
            this.lblEntityType.AutoSize = true;
            this.lblEntityType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEntityType.Location = new System.Drawing.Point(0,0);
            this.lblEntityType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEntityType.Name = "lblEntityType";
            this.lblEntityType.Size = new System.Drawing.Size(41, 20);
            this.lblEntityType.TabIndex = 3;
            this.lblEntityType.Text = "图形类型";
            // 
            // txtEntityType
            // 
            this.txtEntityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEntityType.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtEntityType.EnableTouchMode = true;
            this.txtEntityType.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEntityType.Location =  new System.Drawing.Point(0,0);
            this.txtEntityType.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEntityType.Name = "txtEntityType";
            this.txtEntityType.Size = new System.Drawing.Size(152, 28);
            this.txtEntityType.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEntityType.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHandle.Location = new System.Drawing.Point(0,0);
            this.lblHandle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(41, 20);
            this.lblHandle.TabIndex = 5;
            this.lblHandle.Text = "图形句柄";
            // 
            // txtHandle
            // 
            this.txtHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHandle.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHandle.EnableTouchMode = true;
            this.txtHandle.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHandle.Location =  new System.Drawing.Point(0,0);
            this.txtHandle.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(152, 28);
            this.txtHandle.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHandle.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFileName.Location = new System.Drawing.Point(0,0);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(41, 20);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "文件名称";
            // 
            // txtFileName
            // 
            this.txtFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileName.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFileName.EnableTouchMode = true;
            this.txtFileName.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFileName.Location =  new System.Drawing.Point(0,0);
            this.txtFileName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(152, 28);
            this.txtFileName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFileName.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEntityType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEntityType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHandle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHandle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFileName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFileName, 1, 3);
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
            // ucTmpCadx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucTmpCadx";
            this.Size = new System.Drawing.Size(250, 156);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEntityType;	
        private System.Windows.Forms.Label lblEntityType;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHandle;	
        private System.Windows.Forms.Label lblHandle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFileName;	
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}