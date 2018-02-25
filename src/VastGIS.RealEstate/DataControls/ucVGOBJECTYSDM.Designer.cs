using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgObjectysdm
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
            this.lblYsmc = new System.Windows.Forms.Label();
            this.txtYsmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXssx = new System.Windows.Forms.Label();
            this.intXssx = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblQsbg = new System.Windows.Forms.Label();
            this.txtQsbg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQsfh = new System.Windows.Forms.Label();
            this.txtQsfh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfkj = new System.Windows.Forms.Label();
            this.txtSfkj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXssx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsfh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfkj)).BeginInit();
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
            this.lblYsmc.AutoSize = true;
            this.lblYsmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsmc.Location = new System.Drawing.Point(0,0);
            this.lblYsmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsmc.Name = "lblYsmc";
            this.lblYsmc.Size = new System.Drawing.Size(41, 20);
            this.lblYsmc.TabIndex = 5;
            this.lblYsmc.Text = "要素名称";
            // 
            // txtYsmc
            // 
            this.txtYsmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsmc.EnableTouchMode = true;
            this.txtYsmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsmc.Location =  new System.Drawing.Point(0,0);
            this.txtYsmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsmc.Name = "txtYsmc";
            this.txtYsmc.Size = new System.Drawing.Size(152, 28);
            this.txtYsmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsmc.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblXssx.AutoSize = true;
            this.lblXssx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblXssx.Location = new System.Drawing.Point(0,0);
            this.lblXssx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblXssx.Name = "lblXssx";
            this.lblXssx.Size = new System.Drawing.Size(41, 20);
            this.lblXssx.TabIndex = 7;
            this.lblXssx.Text = "显示顺序";
            // 
            // intXssx
            // 
            this.intXssx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intXssx.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXssx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intXssx.EnableTouchMode = true;
            this.intXssx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intXssx.IntegerValue = ((long)(0));
            this.intXssx.Location = new System.Drawing.Point(0,0);
            this.intXssx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXssx.Name = "intXssx";
            this.intXssx.NullString = "";
            this.intXssx.Size = new System.Drawing.Size(152, 28);
            this.intXssx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXssx.TabIndex = 8;
            this.intXssx.Text = "0";
            // 
            // lblID
            // 
            this.lblQsbg.AutoSize = true;
            this.lblQsbg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsbg.Location = new System.Drawing.Point(0,0);
            this.lblQsbg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsbg.Name = "lblQsbg";
            this.lblQsbg.Size = new System.Drawing.Size(41, 20);
            this.lblQsbg.TabIndex = 9;
            this.lblQsbg.Text = "缺省表格";
            // 
            // txtQsbg
            // 
            this.txtQsbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsbg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsbg.EnableTouchMode = true;
            this.txtQsbg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsbg.Location =  new System.Drawing.Point(0,0);
            this.txtQsbg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsbg.Name = "txtQsbg";
            this.txtQsbg.Size = new System.Drawing.Size(152, 28);
            this.txtQsbg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsbg.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblQsfh.AutoSize = true;
            this.lblQsfh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsfh.Location = new System.Drawing.Point(0,0);
            this.lblQsfh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsfh.Name = "lblQsfh";
            this.lblQsfh.Size = new System.Drawing.Size(41, 20);
            this.lblQsfh.TabIndex = 11;
            this.lblQsfh.Text = "缺省符号";
            // 
            // txtQsfh
            // 
            this.txtQsfh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsfh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsfh.EnableTouchMode = true;
            this.txtQsfh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsfh.Location =  new System.Drawing.Point(0,0);
            this.txtQsfh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsfh.Name = "txtQsfh";
            this.txtQsfh.Size = new System.Drawing.Size(152, 28);
            this.txtQsfh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsfh.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSfkj.AutoSize = true;
            this.lblSfkj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfkj.Location = new System.Drawing.Point(0,0);
            this.lblSfkj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfkj.Name = "lblSfkj";
            this.lblSfkj.Size = new System.Drawing.Size(41, 20);
            this.lblSfkj.TabIndex = 13;
            this.lblSfkj.Text = "是否空间要素";
            // 
            // txtSfkj
            // 
            this.txtSfkj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSfkj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSfkj.EnableTouchMode = true;
            this.txtSfkj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSfkj.Location =  new System.Drawing.Point(0,0);
            this.txtSfkj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSfkj.Name = "txtSfkj";
            this.txtSfkj.Size = new System.Drawing.Size(152, 28);
            this.txtSfkj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSfkj.TabIndex = 14;
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
            this.tableLayoutPanel1.Controls.Add(this.lblYsmc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsmc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblXssx, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.intXssx, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQsbg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQsbg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblQsfh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtQsfh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSfkj, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSfkj, 1, 6);
            this.tableLayoutPanel1.RowCount = 7;
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
            this.tableLayoutPanel1.TabIndex = 15; 
            //
            // ucVgObjectysdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgObjectysdm";
            this.Size = new System.Drawing.Size(250, 261);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intXssx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsbg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsfh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfkj)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsmc;	
        private System.Windows.Forms.Label lblYsmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXssx;	
        private System.Windows.Forms.Label lblXssx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsbg;	
        private System.Windows.Forms.Label lblQsbg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsfh;	
        private System.Windows.Forms.Label lblQsfh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSfkj;	
        private System.Windows.Forms.Label lblSfkj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}