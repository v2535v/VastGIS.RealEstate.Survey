using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucQlrSimple
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
            this.lblQlrmc = new System.Windows.Forms.Label();
            this.txtQlrmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDh = new System.Windows.Forms.Label();
            this.txtDh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDz = new System.Windows.Forms.Label();
            this.txtDz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGyfs = new System.Windows.Forms.Label();
            this.cmbGyfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGyfs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQlrmc
            // 
            this.lblQlrmc.AutoSize = true;
            this.lblQlrmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQlrmc.Location = new System.Drawing.Point(12, 10);
            this.lblQlrmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQlrmc.Name = "lblQlrmc";
            this.lblQlrmc.Size = new System.Drawing.Size(65, 25);
            this.lblQlrmc.TabIndex = 9;
            this.lblQlrmc.Text = "权利人名称";
            // 
            // txtQlrmc
            // 
            this.txtQlrmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQlrmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQlrmc.EnableTouchMode = true;
            this.txtQlrmc.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQlrmc.Location = new System.Drawing.Point(83, 3);
            this.txtQlrmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQlrmc.Name = "txtQlrmc";
            this.txtQlrmc.Size = new System.Drawing.Size(216, 28);
            this.txtQlrmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQlrmc.TabIndex = 10;
            // 
            // lblDh
            // 
            this.lblDh.AutoSize = true;
            this.lblDh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDh.Location = new System.Drawing.Point(48, 45);
            this.lblDh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDh.Name = "lblDh";
            this.lblDh.Size = new System.Drawing.Size(29, 25);
            this.lblDh.TabIndex = 31;
            this.lblDh.Text = "电话";
            // 
            // txtDh
            // 
            this.txtDh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDh.EnableTouchMode = true;
            this.txtDh.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDh.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDh.Location = new System.Drawing.Point(83, 38);
            this.txtDh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDh.Name = "txtDh";
            this.txtDh.Size = new System.Drawing.Size(216, 28);
            this.txtDh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDh.TabIndex = 32;
            // 
            // lblDz
            // 
            this.lblDz.AutoSize = true;
            this.lblDz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDz.Location = new System.Drawing.Point(348, 45);
            this.lblDz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDz.Name = "lblDz";
            this.lblDz.Size = new System.Drawing.Size(41, 25);
            this.lblDz.TabIndex = 33;
            this.lblDz.Text = "门牌号";
            // 
            // txtDz
            // 
            this.txtDz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDz.EnableTouchMode = true;
            this.txtDz.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDz.Location = new System.Drawing.Point(395, 38);
            this.txtDz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(216, 28);
            this.txtDz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDz.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblQlrmc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQlrmc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDz, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDz, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGyfs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbGyfs, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 76);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // lblGyfs
            // 
            this.lblGyfs.AutoSize = true;
            this.lblGyfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGyfs.Location = new System.Drawing.Point(336, 10);
            this.lblGyfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGyfs.Name = "lblGyfs";
            this.lblGyfs.Size = new System.Drawing.Size(53, 25);
            this.lblGyfs.TabIndex = 45;
            this.lblGyfs.Text = "共有方式";
            // 
            // cmbGyfs
            // 
            this.cmbGyfs.BeforeTouchSize = new System.Drawing.Size(152, 20);
            this.cmbGyfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGyfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGyfs.EnableTouchMode = true;
            this.cmbGyfs.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGyfs.Location = new System.Drawing.Point(395, 3);
            this.cmbGyfs.Name = "cmbGyfs";
            this.cmbGyfs.Size = new System.Drawing.Size(216, 26);
            this.cmbGyfs.TabIndex = 46;
            // 
            // ucQlrSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQlrSimple";
            this.Size = new System.Drawing.Size(614, 76);
            ((System.ComponentModel.ISupportInitialize)(this.txtQlrmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGyfs)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQlrmc;	
        private System.Windows.Forms.Label lblQlrmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDh;	
        private System.Windows.Forms.Label lblDh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDz;	
        private System.Windows.Forms.Label lblDz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGyfs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbGyfs;
    }
}