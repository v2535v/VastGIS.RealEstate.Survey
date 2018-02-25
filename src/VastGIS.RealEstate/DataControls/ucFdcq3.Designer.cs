using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFdcq3
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
            this.lblBdcdyh = new System.Windows.Forms.Label();
            this.txtBdcdyh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQllx = new System.Windows.Forms.Label();
            this.cmbQllx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJgzwbh = new System.Windows.Forms.Label();
            this.txtJgzwbh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJgzwmc = new System.Windows.Forms.Label();
            this.txtJgzwmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJgzwsl = new System.Windows.Forms.Label();
            this.intJgzwsl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblJgzwmj = new System.Windows.Forms.Label();
            this.dblJgzwmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFttdmj = new System.Windows.Forms.Label();
            this.dblFttdmj = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblQxdm = new System.Windows.Forms.Label();
            this.cmbQxdm = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjjg = new System.Windows.Forms.Label();
            this.txtDjjg = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDbr = new System.Windows.Forms.Label();
            this.txtDbr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDjsj = new System.Windows.Forms.Label();
            this.datDjsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFj = new System.Windows.Forms.Label();
            this.txtFj = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQszt = new System.Windows.Forms.Label();
            this.cmbQszt = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJgzwbh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJgzwmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intJgzwsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJgzwmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQszt)).BeginInit();
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
            this.lblBdcdyh.AutoSize = true;
            this.lblBdcdyh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdyh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdyh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdyh.Name = "lblBdcdyh";
            this.lblBdcdyh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdyh.TabIndex = 5;
            this.lblBdcdyh.Text = "不动产单元号";
            // 
            // txtBdcdyh
            // 
            this.txtBdcdyh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdyh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdyh.EnableTouchMode = true;
            this.txtBdcdyh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdyh.Location =  new System.Drawing.Point(0,0);
            this.txtBdcdyh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdyh.Name = "txtBdcdyh";
            this.txtBdcdyh.Size = new System.Drawing.Size(152, 28);
            this.txtBdcdyh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdyh.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 7;
            this.lblYwh.Text = "业务号";
            // 
            // txtYwh
            // 
            this.txtYwh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYwh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYwh.EnableTouchMode = true;
            this.txtYwh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYwh.Location =  new System.Drawing.Point(0,0);
            this.txtYwh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYwh.Name = "txtYwh";
            this.txtYwh.Size = new System.Drawing.Size(152, 28);
            this.txtYwh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYwh.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblQllx.AutoSize = true;
            this.lblQllx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQllx.Location = new System.Drawing.Point(0,0);
            this.lblQllx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQllx.Name = "lblQllx";
            this.lblQllx.Size = new System.Drawing.Size(41, 20);
            this.lblQllx.TabIndex = 9;
            this.lblQllx.Text = "权利类型";
            // 
            // cmbQllx
            // 
            this.cmbQllx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQllx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQllx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQllx.EnableTouchMode = true;
            this.cmbQllx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQllx.Location =  new System.Drawing.Point(0,0);
            this.cmbQllx.Name = "cmbQllx";
            this.cmbQllx.Size = new System.Drawing.Size(152, 20);
            this.cmbQllx.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblJgzwbh.AutoSize = true;
            this.lblJgzwbh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgzwbh.Location = new System.Drawing.Point(0,0);
            this.lblJgzwbh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgzwbh.Name = "lblJgzwbh";
            this.lblJgzwbh.Size = new System.Drawing.Size(41, 20);
            this.lblJgzwbh.TabIndex = 11;
            this.lblJgzwbh.Text = "建（构）筑物编号";
            // 
            // txtJgzwbh
            // 
            this.txtJgzwbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJgzwbh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJgzwbh.EnableTouchMode = true;
            this.txtJgzwbh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJgzwbh.Location =  new System.Drawing.Point(0,0);
            this.txtJgzwbh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJgzwbh.Name = "txtJgzwbh";
            this.txtJgzwbh.Size = new System.Drawing.Size(152, 28);
            this.txtJgzwbh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJgzwbh.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblJgzwmc.AutoSize = true;
            this.lblJgzwmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgzwmc.Location = new System.Drawing.Point(0,0);
            this.lblJgzwmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgzwmc.Name = "lblJgzwmc";
            this.lblJgzwmc.Size = new System.Drawing.Size(41, 20);
            this.lblJgzwmc.TabIndex = 13;
            this.lblJgzwmc.Text = "建（构）筑物名称";
            // 
            // txtJgzwmc
            // 
            this.txtJgzwmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJgzwmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJgzwmc.EnableTouchMode = true;
            this.txtJgzwmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJgzwmc.Location =  new System.Drawing.Point(0,0);
            this.txtJgzwmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJgzwmc.Name = "txtJgzwmc";
            this.txtJgzwmc.Size = new System.Drawing.Size(152, 28);
            this.txtJgzwmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJgzwmc.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblJgzwsl.AutoSize = true;
            this.lblJgzwsl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgzwsl.Location = new System.Drawing.Point(0,0);
            this.lblJgzwsl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgzwsl.Name = "lblJgzwsl";
            this.lblJgzwsl.Size = new System.Drawing.Size(41, 20);
            this.lblJgzwsl.TabIndex = 15;
            this.lblJgzwsl.Text = "建（构）筑物数量";
            // 
            // intJgzwsl
            // 
            this.intJgzwsl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intJgzwsl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intJgzwsl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intJgzwsl.EnableTouchMode = true;
            this.intJgzwsl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intJgzwsl.IntegerValue = ((long)(0));
            this.intJgzwsl.Location = new System.Drawing.Point(0,0);
            this.intJgzwsl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intJgzwsl.Name = "intJgzwsl";
            this.intJgzwsl.NullString = "";
            this.intJgzwsl.Size = new System.Drawing.Size(152, 28);
            this.intJgzwsl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intJgzwsl.TabIndex = 16;
            this.intJgzwsl.Text = "0";
            // 
            // lblID
            // 
            this.lblJgzwmj.AutoSize = true;
            this.lblJgzwmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJgzwmj.Location = new System.Drawing.Point(0,0);
            this.lblJgzwmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJgzwmj.Name = "lblJgzwmj";
            this.lblJgzwmj.Size = new System.Drawing.Size(41, 20);
            this.lblJgzwmj.TabIndex = 17;
            this.lblJgzwmj.Text = "建（构）筑物面积";
            // 
            // dblJgzwmj
            // 
            this.dblJgzwmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblJgzwmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJgzwmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblJgzwmj.DoubleValue = 1D;
            this.dblJgzwmj.EnableTouchMode = true;
            this.dblJgzwmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblJgzwmj.Location =  new System.Drawing.Point(0,0);
            this.dblJgzwmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJgzwmj.Name = "dblJgzwmj";
            this.dblJgzwmj.NullString = "";
            this.dblJgzwmj.Size = new System.Drawing.Size(152, 28);
            this.dblJgzwmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJgzwmj.TabIndex = 18;
            this.dblJgzwmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblFttdmj.AutoSize = true;
            this.lblFttdmj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFttdmj.Location = new System.Drawing.Point(0,0);
            this.lblFttdmj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFttdmj.Name = "lblFttdmj";
            this.lblFttdmj.Size = new System.Drawing.Size(41, 20);
            this.lblFttdmj.TabIndex = 19;
            this.lblFttdmj.Text = "分摊土地面积";
            // 
            // dblFttdmj
            // 
            this.dblFttdmj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblFttdmj.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFttdmj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblFttdmj.DoubleValue = 1D;
            this.dblFttdmj.EnableTouchMode = true;
            this.dblFttdmj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblFttdmj.Location =  new System.Drawing.Point(0,0);
            this.dblFttdmj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFttdmj.Name = "dblFttdmj";
            this.dblFttdmj.NullString = "";
            this.dblFttdmj.Size = new System.Drawing.Size(152, 28);
            this.dblFttdmj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFttdmj.TabIndex = 20;
            this.dblFttdmj.Text = "1.00";
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 21;
            this.lblQxdm.Text = "区县代码";
            // 
            // cmbQxdm
            // 
            this.cmbQxdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQxdm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQxdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQxdm.EnableTouchMode = true;
            this.cmbQxdm.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQxdm.Location =  new System.Drawing.Point(0,0);
            this.cmbQxdm.Name = "cmbQxdm";
            this.cmbQxdm.Size = new System.Drawing.Size(152, 20);
            this.cmbQxdm.TabIndex =  22;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 23;
            this.lblDjjg.Text = "登记机构";
            // 
            // txtDjjg
            // 
            this.txtDjjg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjjg.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjjg.EnableTouchMode = true;
            this.txtDjjg.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjjg.Location =  new System.Drawing.Point(0,0);
            this.txtDjjg.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjjg.Name = "txtDjjg";
            this.txtDjjg.Size = new System.Drawing.Size(152, 28);
            this.txtDjjg.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjjg.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 25;
            this.lblDbr.Text = "登簿人";
            // 
            // txtDbr
            // 
            this.txtDbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDbr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDbr.EnableTouchMode = true;
            this.txtDbr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDbr.Location =  new System.Drawing.Point(0,0);
            this.txtDbr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDbr.Name = "txtDbr";
            this.txtDbr.Size = new System.Drawing.Size(152, 28);
            this.txtDbr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDbr.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 27;
            this.lblDjsj.Text = "登记时间";
            // 
            // datDjsj
            // 
            this.datDjsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datDjsj.BorderColor = System.Drawing.Color.Empty;
            this.datDjsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datDjsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datDjsj.DropDownImage = null;
            this.datDjsj.EnableTouchMode = true;
            this.datDjsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datDjsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDjsj.Location =  new System.Drawing.Point(0,0);
            this.datDjsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datDjsj.MinValue = new System.DateTime(((long)(0)));
            this.datDjsj.Name = "datDjsj";
            this.datDjsj.Size = new System.Drawing.Size(152, 20);
            this.datDjsj.TabIndex = 28;
            this.datDjsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datDjsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFj.AutoSize = true;
            this.lblFj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFj.Location = new System.Drawing.Point(0,0);
            this.lblFj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFj.Name = "lblFj";
            this.lblFj.Size = new System.Drawing.Size(41, 20);
            this.lblFj.TabIndex = 29;
            this.lblFj.Text = "附记";
            // 
            // txtFj
            // 
            this.txtFj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFj.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFj.EnableTouchMode = true;
            this.txtFj.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFj.Location =  new System.Drawing.Point(0,0);
            this.txtFj.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFj.Name = "txtFj";
            this.txtFj.Size = new System.Drawing.Size(152, 28);
            this.txtFj.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFj.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 31;
            this.lblQszt.Text = "权属状态";
            // 
            // cmbQszt
            // 
            this.cmbQszt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbQszt.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbQszt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQszt.EnableTouchMode = true;
            this.cmbQszt.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQszt.Location =  new System.Drawing.Point(0,0);
            this.cmbQszt.Name = "cmbQszt";
            this.cmbQszt.Size = new System.Drawing.Size(152, 20);
            this.cmbQszt.TabIndex =  32;            
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
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQllx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbQllx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblJgzwbh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtJgzwbh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblJgzwmc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtJgzwmc, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblJgzwsl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.intJgzwsl, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblJgzwmj, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblJgzwmj, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFttdmj, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblFttdmj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 4, 7);
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
            this.tableLayoutPanel1.TabIndex = 33; 
            //
            // ucFdcq3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFdcq3";
            this.Size = new System.Drawing.Size(500, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQllx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJgzwbh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJgzwmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intJgzwsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblJgzwmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFttdmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQxdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjjg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datDjsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbQszt)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdyh;	
        private System.Windows.Forms.Label lblBdcdyh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQllx;	
        private System.Windows.Forms.Label lblQllx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJgzwbh;	
        private System.Windows.Forms.Label lblJgzwbh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJgzwmc;	
        private System.Windows.Forms.Label lblJgzwmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intJgzwsl;	
        private System.Windows.Forms.Label lblJgzwsl;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJgzwmj;	
        private System.Windows.Forms.Label lblJgzwmj;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFttdmj;	
        private System.Windows.Forms.Label lblFttdmj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQxdm;	
        private System.Windows.Forms.Label lblQxdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjjg;	
        private System.Windows.Forms.Label lblDjjg;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDbr;	
        private System.Windows.Forms.Label lblDbr;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datDjsj;	
        private System.Windows.Forms.Label lblDjsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFj;	
        private System.Windows.Forms.Label lblFj;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQszt;	
        private System.Windows.Forms.Label lblQszt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}