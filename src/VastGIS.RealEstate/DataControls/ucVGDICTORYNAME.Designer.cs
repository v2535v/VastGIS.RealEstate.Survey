using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgDictoryname
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
            this.lblZdmc = new System.Windows.Forms.Label();
            this.txtZdmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZdsm = new System.Windows.Forms.Label();
            this.txtZdsm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdsm)).BeginInit();
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
            this.lblZdmc.AutoSize = true;
            this.lblZdmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdmc.Location = new System.Drawing.Point(0,0);
            this.lblZdmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdmc.Name = "lblZdmc";
            this.lblZdmc.Size = new System.Drawing.Size(41, 20);
            this.lblZdmc.TabIndex = 3;
            this.lblZdmc.Text = "字典名称";
            // 
            // txtZdmc
            // 
            this.txtZdmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdmc.EnableTouchMode = true;
            this.txtZdmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdmc.Location =  new System.Drawing.Point(0,0);
            this.txtZdmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdmc.Name = "txtZdmc";
            this.txtZdmc.Size = new System.Drawing.Size(152, 28);
            this.txtZdmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdmc.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblZdsm.AutoSize = true;
            this.lblZdsm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdsm.Location = new System.Drawing.Point(0,0);
            this.lblZdsm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdsm.Name = "lblZdsm";
            this.lblZdsm.Size = new System.Drawing.Size(41, 20);
            this.lblZdsm.TabIndex = 5;
            this.lblZdsm.Text = "字段说明";
            // 
            // txtZdsm
            // 
            this.txtZdsm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdsm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdsm.EnableTouchMode = true;
            this.txtZdsm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdsm.Location =  new System.Drawing.Point(0,0);
            this.txtZdsm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdsm.Name = "txtZdsm";
            this.txtZdsm.Size = new System.Drawing.Size(152, 28);
            this.txtZdsm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdsm.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdmc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZdmc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblZdsm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtZdsm, 1, 2);
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
            // ucVgDictoryname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgDictoryname";
            this.Size = new System.Drawing.Size(250, 121);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdsm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdmc;	
        private System.Windows.Forms.Label lblZdmc;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdsm;	
        private System.Windows.Forms.Label lblZdsm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}