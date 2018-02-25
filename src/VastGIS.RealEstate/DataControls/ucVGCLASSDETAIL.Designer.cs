﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVgClassdetail
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblObjectTableName = new System.Windows.Forms.Label();
            this.txtObjectTableName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCreateImpl = new System.Windows.Forms.Label();
            this.txtCreateImpl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblInterfaceName = new System.Windows.Forms.Label();
            this.txtInterfaceName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObjectTableName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateImpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterfaceName)).BeginInit();
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
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGroupName.Location = new System.Drawing.Point(0,0);
            this.lblGroupName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(41, 20);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "组名";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroupName.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtGroupName.EnableTouchMode = true;
            this.txtGroupName.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGroupName.Location =  new System.Drawing.Point(0,0);
            this.txtGroupName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(152, 28);
            this.txtGroupName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGroupName.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblObjectTableName.AutoSize = true;
            this.lblObjectTableName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblObjectTableName.Location = new System.Drawing.Point(0,0);
            this.lblObjectTableName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblObjectTableName.Name = "lblObjectTableName";
            this.lblObjectTableName.Size = new System.Drawing.Size(41, 20);
            this.lblObjectTableName.TabIndex = 5;
            this.lblObjectTableName.Text = "对象名称";
            // 
            // txtObjectTableName
            // 
            this.txtObjectTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObjectTableName.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtObjectTableName.EnableTouchMode = true;
            this.txtObjectTableName.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtObjectTableName.Location =  new System.Drawing.Point(0,0);
            this.txtObjectTableName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtObjectTableName.Name = "txtObjectTableName";
            this.txtObjectTableName.Size = new System.Drawing.Size(152, 28);
            this.txtObjectTableName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtObjectTableName.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblCreateImpl.AutoSize = true;
            this.lblCreateImpl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCreateImpl.Location = new System.Drawing.Point(0,0);
            this.lblCreateImpl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblCreateImpl.Name = "lblCreateImpl";
            this.lblCreateImpl.Size = new System.Drawing.Size(41, 20);
            this.lblCreateImpl.TabIndex = 7;
            this.lblCreateImpl.Text = "是否实体";
            // 
            // txtCreateImpl
            // 
            this.txtCreateImpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreateImpl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCreateImpl.EnableTouchMode = true;
            this.txtCreateImpl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCreateImpl.Location =  new System.Drawing.Point(0,0);
            this.txtCreateImpl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCreateImpl.Name = "txtCreateImpl";
            this.txtCreateImpl.Size = new System.Drawing.Size(152, 28);
            this.txtCreateImpl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCreateImpl.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblInterfaceName.AutoSize = true;
            this.lblInterfaceName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblInterfaceName.Location = new System.Drawing.Point(0,0);
            this.lblInterfaceName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInterfaceName.Name = "lblInterfaceName";
            this.lblInterfaceName.Size = new System.Drawing.Size(41, 20);
            this.lblInterfaceName.TabIndex = 9;
            this.lblInterfaceName.Text = "接口名称";
            // 
            // txtInterfaceName
            // 
            this.txtInterfaceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInterfaceName.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtInterfaceName.EnableTouchMode = true;
            this.txtInterfaceName.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInterfaceName.Location =  new System.Drawing.Point(0,0);
            this.txtInterfaceName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtInterfaceName.Name = "txtInterfaceName";
            this.txtInterfaceName.Size = new System.Drawing.Size(152, 28);
            this.txtInterfaceName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtInterfaceName.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGroupName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGroupName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblObjectTableName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtObjectTableName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCreateImpl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCreateImpl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblInterfaceName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtInterfaceName, 1, 4);
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
            // ucVgClassdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucVgClassdetail";
            this.Size = new System.Drawing.Size(250, 191);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObjectTableName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateImpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterfaceName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGroupName;	
        private System.Windows.Forms.Label lblGroupName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtObjectTableName;	
        private System.Windows.Forms.Label lblObjectTableName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCreateImpl;	
        private System.Windows.Forms.Label lblCreateImpl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtInterfaceName;	
        private System.Windows.Forms.Label lblInterfaceName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}