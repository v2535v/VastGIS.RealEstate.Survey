using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgSetting
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
            this.lblCsmc = new System.Windows.Forms.Label();
            this.txtCsmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCsz = new System.Windows.Forms.Label();
            this.txtCsz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsz)).BeginInit();
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
            this.lblCsmc.AutoSize = true;
            this.lblCsmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCsmc.Location = new System.Drawing.Point(0,0);
            this.lblCsmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCsmc.Name = "lblCsmc";
            this.lblCsmc.Size = new System.Drawing.Size(41, 20);
            this.lblCsmc.TabIndex = 3;
            this.lblCsmc.Text = "参数名称";
            // 
            // txtCsmc
            // 
            this.txtCsmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCsmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCsmc.EnableTouchMode = true;
            this.txtCsmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCsmc.Location =  new System.Drawing.Point(0,0);
            this.txtCsmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCsmc.Name = "txtCsmc";
            this.txtCsmc.Size = new System.Drawing.Size(152, 28);
            this.txtCsmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCsmc.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblCsz.AutoSize = true;
            this.lblCsz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCsz.Location = new System.Drawing.Point(0,0);
            this.lblCsz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCsz.Name = "lblCsz";
            this.lblCsz.Size = new System.Drawing.Size(41, 20);
            this.lblCsz.TabIndex = 5;
            this.lblCsz.Text = "参数值";
            // 
            // txtCsz
            // 
            this.txtCsz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCsz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCsz.EnableTouchMode = true;
            this.txtCsz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCsz.Location =  new System.Drawing.Point(0,0);
            this.txtCsz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCsz.Name = "txtCsz";
            this.txtCsz.Size = new System.Drawing.Size(152, 28);
            this.txtCsz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCsz.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCsmc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCsmc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCsz, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCsz, 1, 2);
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
            // ucVgSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgSetting";
            this.Size = new System.Drawing.Size(250, 121);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsz)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCsmc;	
        private System.Windows.Forms.Label lblCsmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCsz;	
        private System.Windows.Forms.Label lblCsz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}