using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgLayergroupdetail
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
            this.lblZm = new System.Windows.Forms.Label();
            this.txtZm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblMc = new System.Windows.Forms.Label();
            this.txtMc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblIdentify = new System.Windows.Forms.Label();
            this.txtIdentify = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblEditable = new System.Windows.Forms.Label();
            this.txtEditable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQueryable = new System.Windows.Forms.Label();
            this.txtQueryable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSnapable = new System.Windows.Forms.Label();
            this.txtSnapable = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblVisible = new System.Windows.Forms.Label();
            this.txtVisible = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisible)).BeginInit();
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
            this.lblZm.AutoSize = true;
            this.lblZm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZm.Location = new System.Drawing.Point(0,0);
            this.lblZm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZm.Name = "lblZm";
            this.lblZm.Size = new System.Drawing.Size(41, 20);
            this.lblZm.TabIndex = 3;
            this.lblZm.Text = "组名";
            // 
            // txtZm
            // 
            this.txtZm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZm.EnableTouchMode = true;
            this.txtZm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZm.Location =  new System.Drawing.Point(0,0);
            this.txtZm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZm.Name = "txtZm";
            this.txtZm.Size = new System.Drawing.Size(152, 28);
            this.txtZm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblMc.AutoSize = true;
            this.lblMc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMc.Location = new System.Drawing.Point(0,0);
            this.lblMc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblMc.Name = "lblMc";
            this.lblMc.Size = new System.Drawing.Size(41, 20);
            this.lblMc.TabIndex = 5;
            this.lblMc.Text = "名称";
            // 
            // txtMc
            // 
            this.txtMc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtMc.EnableTouchMode = true;
            this.txtMc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMc.Location =  new System.Drawing.Point(0,0);
            this.txtMc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(152, 28);
            this.txtMc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtMc.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblIdentify.AutoSize = true;
            this.lblIdentify.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIdentify.Location = new System.Drawing.Point(0,0);
            this.lblIdentify.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblIdentify.Name = "lblIdentify";
            this.lblIdentify.Size = new System.Drawing.Size(41, 20);
            this.lblIdentify.TabIndex = 7;
            this.lblIdentify.Text = "可检索";
            // 
            // txtIdentify
            // 
            this.txtIdentify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIdentify.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtIdentify.EnableTouchMode = true;
            this.txtIdentify.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdentify.Location =  new System.Drawing.Point(0,0);
            this.txtIdentify.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtIdentify.Name = "txtIdentify";
            this.txtIdentify.Size = new System.Drawing.Size(152, 28);
            this.txtIdentify.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtIdentify.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblEditable.AutoSize = true;
            this.lblEditable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEditable.Location = new System.Drawing.Point(0,0);
            this.lblEditable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblEditable.Name = "lblEditable";
            this.lblEditable.Size = new System.Drawing.Size(41, 20);
            this.lblEditable.TabIndex = 9;
            this.lblEditable.Text = "可编辑";
            // 
            // txtEditable
            // 
            this.txtEditable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtEditable.EnableTouchMode = true;
            this.txtEditable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEditable.Location =  new System.Drawing.Point(0,0);
            this.txtEditable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEditable.Name = "txtEditable";
            this.txtEditable.Size = new System.Drawing.Size(152, 28);
            this.txtEditable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEditable.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblQueryable.AutoSize = true;
            this.lblQueryable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQueryable.Location = new System.Drawing.Point(0,0);
            this.lblQueryable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQueryable.Name = "lblQueryable";
            this.lblQueryable.Size = new System.Drawing.Size(41, 20);
            this.lblQueryable.TabIndex = 11;
            this.lblQueryable.Text = "可查询";
            // 
            // txtQueryable
            // 
            this.txtQueryable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueryable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQueryable.EnableTouchMode = true;
            this.txtQueryable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQueryable.Location =  new System.Drawing.Point(0,0);
            this.txtQueryable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQueryable.Name = "txtQueryable";
            this.txtQueryable.Size = new System.Drawing.Size(152, 28);
            this.txtQueryable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQueryable.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSnapable.AutoSize = true;
            this.lblSnapable.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSnapable.Location = new System.Drawing.Point(0,0);
            this.lblSnapable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSnapable.Name = "lblSnapable";
            this.lblSnapable.Size = new System.Drawing.Size(41, 20);
            this.lblSnapable.TabIndex = 13;
            this.lblSnapable.Text = "可捕捉";
            // 
            // txtSnapable
            // 
            this.txtSnapable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSnapable.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSnapable.EnableTouchMode = true;
            this.txtSnapable.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSnapable.Location =  new System.Drawing.Point(0,0);
            this.txtSnapable.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSnapable.Name = "txtSnapable";
            this.txtSnapable.Size = new System.Drawing.Size(152, 28);
            this.txtSnapable.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSnapable.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVisible.Location = new System.Drawing.Point(0,0);
            this.lblVisible.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(41, 20);
            this.lblVisible.TabIndex = 15;
            this.lblVisible.Text = "可显示";
            // 
            // txtVisible
            // 
            this.txtVisible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVisible.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtVisible.EnableTouchMode = true;
            this.txtVisible.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVisible.Location =  new System.Drawing.Point(0,0);
            this.txtVisible.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtVisible.Name = "txtVisible";
            this.txtVisible.Size = new System.Drawing.Size(152, 28);
            this.txtVisible.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtVisible.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIdentify, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIdentify, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEditable, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEditable, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQueryable, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtQueryable, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSnapable, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSnapable, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblVisible, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtVisible, 1, 7);
            this.tableLayoutPanel1.RowCount = 8;
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
            this.tableLayoutPanel1.TabIndex = 17; 
            //
            // ucVgLayergroupdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgLayergroupdetail";
            this.Size = new System.Drawing.Size(250, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdentify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVisible)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZm;	
        private System.Windows.Forms.Label lblZm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMc;	
        private System.Windows.Forms.Label lblMc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtIdentify;	
        private System.Windows.Forms.Label lblIdentify;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEditable;	
        private System.Windows.Forms.Label lblEditable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQueryable;	
        private System.Windows.Forms.Label lblQueryable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSnapable;	
        private System.Windows.Forms.Label lblSnapable;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtVisible;	
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}