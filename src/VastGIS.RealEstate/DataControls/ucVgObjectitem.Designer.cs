using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgObjectitem
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
            this.lblYsbm = new System.Windows.Forms.Label();
            this.txtYsbm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfkj = new System.Windows.Forms.Label();
            this.intSfkj = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblYslx = new System.Windows.Forms.Label();
            this.txtYslx = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSm = new System.Windows.Forms.Label();
            this.txtSm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsbm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSfkj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYslx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSm)).BeginInit();
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
            this.lblYsbm.AutoSize = true;
            this.lblYsbm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsbm.Location = new System.Drawing.Point(0,0);
            this.lblYsbm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsbm.Name = "lblYsbm";
            this.lblYsbm.Size = new System.Drawing.Size(41, 20);
            this.lblYsbm.TabIndex = 7;
            this.lblYsbm.Text = "要素编码";
            // 
            // txtYsbm
            // 
            this.txtYsbm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYsbm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYsbm.EnableTouchMode = true;
            this.txtYsbm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYsbm.Location =  new System.Drawing.Point(0,0);
            this.txtYsbm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYsbm.Name = "txtYsbm";
            this.txtYsbm.Size = new System.Drawing.Size(152, 28);
            this.txtYsbm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYsbm.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblSfkj.AutoSize = true;
            this.lblSfkj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfkj.Location = new System.Drawing.Point(0,0);
            this.lblSfkj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfkj.Name = "lblSfkj";
            this.lblSfkj.Size = new System.Drawing.Size(41, 20);
            this.lblSfkj.TabIndex = 9;
            this.lblSfkj.Text = "是否空间要素";
            // 
            // intSfkj
            // 
            this.intSfkj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intSfkj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSfkj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intSfkj.EnableTouchMode = true;
            this.intSfkj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intSfkj.IntegerValue = ((long)(0));
            this.intSfkj.Location = new System.Drawing.Point(0,0);
            this.intSfkj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSfkj.Name = "intSfkj";
            this.intSfkj.NullString = "";
            this.intSfkj.Size = new System.Drawing.Size(152, 28);
            this.intSfkj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSfkj.TabIndex = 10;
            this.intSfkj.Text = "0";
            // 
            // lblID
            // 
            this.lblYslx.AutoSize = true;
            this.lblYslx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYslx.Location = new System.Drawing.Point(0,0);
            this.lblYslx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYslx.Name = "lblYslx";
            this.lblYslx.Size = new System.Drawing.Size(41, 20);
            this.lblYslx.TabIndex = 11;
            this.lblYslx.Text = "要素类型";
            // 
            // txtYslx
            // 
            this.txtYslx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYslx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYslx.EnableTouchMode = true;
            this.txtYslx.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYslx.Location =  new System.Drawing.Point(0,0);
            this.txtYslx.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYslx.Name = "txtYslx";
            this.txtYslx.Size = new System.Drawing.Size(152, 28);
            this.txtYslx.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYslx.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSm.AutoSize = true;
            this.lblSm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSm.Location = new System.Drawing.Point(0,0);
            this.lblSm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSm.Name = "lblSm";
            this.lblSm.Size = new System.Drawing.Size(41, 20);
            this.lblSm.TabIndex = 13;
            this.lblSm.Text = "说明";
            // 
            // txtSm
            // 
            this.txtSm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSm.EnableTouchMode = true;
            this.txtSm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSm.Location =  new System.Drawing.Point(0,0);
            this.txtSm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSm.Name = "txtSm";
            this.txtSm.Size = new System.Drawing.Size(152, 28);
            this.txtSm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSm.TabIndex = 14;
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
            this.tableLayoutPanel1.Controls.Add(this.lblYsbm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYsbm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSfkj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.intSfkj, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblYslx, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtYslx, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSm, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSm, 1, 6);
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
            // ucVgObjectitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgObjectitem";
            this.Size = new System.Drawing.Size(250, 261);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsbm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intSfkj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYslx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSm)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsbm;	
        private System.Windows.Forms.Label lblYsbm;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSfkj;	
        private System.Windows.Forms.Label lblSfkj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYslx;	
        private System.Windows.Forms.Label lblYslx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSm;	
        private System.Windows.Forms.Label lblSm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}