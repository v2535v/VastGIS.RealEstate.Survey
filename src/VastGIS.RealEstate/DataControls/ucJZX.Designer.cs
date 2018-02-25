using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJzx
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
            this.lblZdzhdm = new System.Windows.Forms.Label();
            this.txtZdzhdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJzxcd = new System.Windows.Forms.Label();
            this.dblJzxcd = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJzxlb = new System.Windows.Forms.Label();
            this.cmbJzxlb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJzxwz = new System.Windows.Forms.Label();
            this.cmbJzxwz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJxxz = new System.Windows.Forms.Label();
            this.cmbJxxz = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQsjxxysbh = new System.Windows.Forms.Label();
            this.txtQsjxxysbh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQsjxxys = new System.Windows.Forms.Label();
            this.txtQsjxxys = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQszyyysbh = new System.Windows.Forms.Label();
            this.txtQszyyysbh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQszyyys = new System.Windows.Forms.Label();
            this.txtQszyyys = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzxcd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzxlb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzxwz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxxz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsjxxysbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsjxxys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQszyyysbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQszyyys)).BeginInit();
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
            this.lblZdzhdm.AutoSize = true;
            this.lblZdzhdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZdzhdm.Location = new System.Drawing.Point(0,0);
            this.lblZdzhdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZdzhdm.Name = "lblZdzhdm";
            this.lblZdzhdm.Size = new System.Drawing.Size(41, 20);
            this.lblZdzhdm.TabIndex = 3;
            this.lblZdzhdm.Text = "宗地/宗海代码";
            // 
            // txtZdzhdm
            // 
            this.txtZdzhdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZdzhdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZdzhdm.EnableTouchMode = true;
            this.txtZdzhdm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZdzhdm.Location =  new System.Drawing.Point(0,0);
            this.txtZdzhdm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZdzhdm.Name = "txtZdzhdm";
            this.txtZdzhdm.Size = new System.Drawing.Size(152, 28);
            this.txtZdzhdm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZdzhdm.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblYsdm.AutoSize = true;
            this.lblYsdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsdm.Location = new System.Drawing.Point(0,0);
            this.lblYsdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsdm.Name = "lblYsdm";
            this.lblYsdm.Size = new System.Drawing.Size(41, 20);
            this.lblYsdm.TabIndex = 5;
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
            this.txtYsdm.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblJzxcd.AutoSize = true;
            this.lblJzxcd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzxcd.Location = new System.Drawing.Point(0,0);
            this.lblJzxcd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzxcd.Name = "lblJzxcd";
            this.lblJzxcd.Size = new System.Drawing.Size(41, 20);
            this.lblJzxcd.TabIndex = 7;
            this.lblJzxcd.Text = "界址线长度";
            // 
            // dblJzxcd
            // 
            this.dblJzxcd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJzxcd.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJzxcd.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJzxcd.DoubleValue = 1D;
            this.dblJzxcd.EnableTouchMode = true;
            this.dblJzxcd.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJzxcd.Location =  new System.Drawing.Point(0,0);
            this.dblJzxcd.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJzxcd.Name = "dblJzxcd";
            this.dblJzxcd.NullString = "";
            this.dblJzxcd.Size = new System.Drawing.Size(152, 28);
            this.dblJzxcd.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJzxcd.TabIndex = 8;
            this.dblJzxcd.Text = "1.00";
            // 
            // lblID
            // 
            this.lblJzxlb.AutoSize = true;
            this.lblJzxlb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzxlb.Location = new System.Drawing.Point(0,0);
            this.lblJzxlb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzxlb.Name = "lblJzxlb";
            this.lblJzxlb.Size = new System.Drawing.Size(41, 20);
            this.lblJzxlb.TabIndex = 9;
            this.lblJzxlb.Text = "界址线类别";
            // 
            // cmbJzxlb
            // 
            this.cmbJzxlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJzxlb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJzxlb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJzxlb.EnableTouchMode = true;
            this.cmbJzxlb.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJzxlb.Location =  new System.Drawing.Point(0,0);
            this.cmbJzxlb.Name = "cmbJzxlb";
            this.cmbJzxlb.Size = new System.Drawing.Size(152, 20);
            this.cmbJzxlb.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblJzxwz.AutoSize = true;
            this.lblJzxwz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJzxwz.Location = new System.Drawing.Point(0,0);
            this.lblJzxwz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJzxwz.Name = "lblJzxwz";
            this.lblJzxwz.Size = new System.Drawing.Size(41, 20);
            this.lblJzxwz.TabIndex = 11;
            this.lblJzxwz.Text = "界址线位置";
            // 
            // cmbJzxwz
            // 
            this.cmbJzxwz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJzxwz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJzxwz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJzxwz.EnableTouchMode = true;
            this.cmbJzxwz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJzxwz.Location =  new System.Drawing.Point(0,0);
            this.cmbJzxwz.Name = "cmbJzxwz";
            this.cmbJzxwz.Size = new System.Drawing.Size(152, 20);
            this.cmbJzxwz.TabIndex =  12;            
            // 
            // lblID
            // 
            this.lblJxxz.AutoSize = true;
            this.lblJxxz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJxxz.Location = new System.Drawing.Point(0,0);
            this.lblJxxz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJxxz.Name = "lblJxxz";
            this.lblJxxz.Size = new System.Drawing.Size(41, 20);
            this.lblJxxz.TabIndex = 13;
            this.lblJxxz.Text = "界线性质";
            // 
            // cmbJxxz
            // 
            this.cmbJxxz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJxxz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbJxxz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJxxz.EnableTouchMode = true;
            this.cmbJxxz.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJxxz.Location =  new System.Drawing.Point(0,0);
            this.cmbJxxz.Name = "cmbJxxz";
            this.cmbJxxz.Size = new System.Drawing.Size(152, 20);
            this.cmbJxxz.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblQsjxxysbh.AutoSize = true;
            this.lblQsjxxysbh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsjxxysbh.Location = new System.Drawing.Point(0,0);
            this.lblQsjxxysbh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsjxxysbh.Name = "lblQsjxxysbh";
            this.lblQsjxxysbh.Size = new System.Drawing.Size(41, 20);
            this.lblQsjxxysbh.TabIndex = 15;
            this.lblQsjxxysbh.Text = "权属界线协议书编号";
            // 
            // txtQsjxxysbh
            // 
            this.txtQsjxxysbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsjxxysbh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsjxxysbh.EnableTouchMode = true;
            this.txtQsjxxysbh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsjxxysbh.Location =  new System.Drawing.Point(0,0);
            this.txtQsjxxysbh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsjxxysbh.Name = "txtQsjxxysbh";
            this.txtQsjxxysbh.Size = new System.Drawing.Size(152, 28);
            this.txtQsjxxysbh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsjxxysbh.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblQsjxxys.AutoSize = true;
            this.lblQsjxxys.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQsjxxys.Location = new System.Drawing.Point(0,0);
            this.lblQsjxxys.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQsjxxys.Name = "lblQsjxxys";
            this.lblQsjxxys.Size = new System.Drawing.Size(41, 20);
            this.lblQsjxxys.TabIndex = 17;
            this.lblQsjxxys.Text = "权属界线协议书";
            // 
            // txtQsjxxys
            // 
            this.txtQsjxxys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQsjxxys.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQsjxxys.EnableTouchMode = true;
            this.txtQsjxxys.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQsjxxys.Location =  new System.Drawing.Point(0,0);
            this.txtQsjxxys.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQsjxxys.Name = "txtQsjxxys";
            this.txtQsjxxys.Size = new System.Drawing.Size(152, 28);
            this.txtQsjxxys.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQsjxxys.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblQszyyysbh.AutoSize = true;
            this.lblQszyyysbh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszyyysbh.Location = new System.Drawing.Point(0,0);
            this.lblQszyyysbh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszyyysbh.Name = "lblQszyyysbh";
            this.lblQszyyysbh.Size = new System.Drawing.Size(41, 20);
            this.lblQszyyysbh.TabIndex = 19;
            this.lblQszyyysbh.Text = "权属争议原由书编号";
            // 
            // txtQszyyysbh
            // 
            this.txtQszyyysbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQszyyysbh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQszyyysbh.EnableTouchMode = true;
            this.txtQszyyysbh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQszyyysbh.Location =  new System.Drawing.Point(0,0);
            this.txtQszyyysbh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQszyyysbh.Name = "txtQszyyysbh";
            this.txtQszyyysbh.Size = new System.Drawing.Size(152, 28);
            this.txtQszyyysbh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQszyyysbh.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblQszyyys.AutoSize = true;
            this.lblQszyyys.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszyyys.Location = new System.Drawing.Point(0,0);
            this.lblQszyyys.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszyyys.Name = "lblQszyyys";
            this.lblQszyyys.Size = new System.Drawing.Size(41, 20);
            this.lblQszyyys.TabIndex = 21;
            this.lblQszyyys.Text = "权属争议原由书";
            // 
            // txtQszyyys
            // 
            this.txtQszyyys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQszyyys.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtQszyyys.EnableTouchMode = true;
            this.txtQszyyys.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQszyyys.Location =  new System.Drawing.Point(0,0);
            this.txtQszyyys.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQszyyys.Name = "txtQszyyys";
            this.txtQszyyys.Size = new System.Drawing.Size(152, 28);
            this.txtQszyyys.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQszyyys.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZdzhdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZdzhdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJzxcd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dblJzxcd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJzxlb, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbJzxlb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblJzxwz, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbJzxwz, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJxxz, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbJxxz, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQsjxxysbh, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQsjxxysbh, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQsjxxys, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQsjxxys, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQszyyysbh, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQszyyysbh, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQszyyys, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQszyyys, 4, 4);
            this.tableLayoutPanel1.RowCount = 6;
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
            this.tableLayoutPanel1.TabIndex = 23; 
            //
            // ucJzx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucJzx";
            this.Size = new System.Drawing.Size(500, 226);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZdzhdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJzxcd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzxlb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJzxwz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJxxz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsjxxysbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQsjxxys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQszyyysbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQszyyys)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZdzhdm;	
        private System.Windows.Forms.Label lblZdzhdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJzxcd;	
        private System.Windows.Forms.Label lblJzxcd;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJzxlb;	
        private System.Windows.Forms.Label lblJzxlb;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJzxwz;	
        private System.Windows.Forms.Label lblJzxwz;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJxxz;	
        private System.Windows.Forms.Label lblJxxz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsjxxysbh;	
        private System.Windows.Forms.Label lblQsjxxysbh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQsjxxys;	
        private System.Windows.Forms.Label lblQsjxxys;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQszyyysbh;	
        private System.Windows.Forms.Label lblQszyyysbh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQszyyys;	
        private System.Windows.Forms.Label lblQszyyys;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}