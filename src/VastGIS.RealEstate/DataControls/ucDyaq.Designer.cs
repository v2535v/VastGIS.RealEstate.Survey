using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucDyaq
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
            this.lblDybdclx = new System.Windows.Forms.Label();
            this.cmbDybdclx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDyr = new System.Windows.Forms.Label();
            this.txtDyr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDyfs = new System.Windows.Forms.Label();
            this.cmbDyfs = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjlx = new System.Windows.Forms.Label();
            this.cmbDjlx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDjyy = new System.Windows.Forms.Label();
            this.txtDjyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZjjzwzl = new System.Windows.Forms.Label();
            this.txtZjjzwzl = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZjjzwdyfw = new System.Windows.Forms.Label();
            this.txtZjjzwdyfw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBdbzzqse = new System.Windows.Forms.Label();
            this.dblBdbzzqse = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZwlxqssj = new System.Windows.Forms.Label();
            this.datZwlxqssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblZwlxjssj = new System.Windows.Forms.Label();
            this.datZwlxjssj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblZgzqqdss = new System.Windows.Forms.Label();
            this.txtZgzqqdss = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZgzqse = new System.Windows.Forms.Label();
            this.dblZgzqse = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZxdyywh = new System.Windows.Forms.Label();
            this.txtZxdyywh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZxdyyy = new System.Windows.Forms.Label();
            this.txtZxdyyy = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZxsj = new System.Windows.Forms.Label();
            this.datZxsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblBdcdjzmh = new System.Windows.Forms.Label();
            this.txtBdcdjzmh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbDybdclx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDyr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDyfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjjzwzl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjjzwdyfw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblBdbzzqse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZwlxqssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZwlxjssj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZgzqqdss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZgzqse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZxdyywh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZxdyyy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZxsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).BeginInit();
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
            this.lblDybdclx.AutoSize = true;
            this.lblDybdclx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDybdclx.Location = new System.Drawing.Point(0,0);
            this.lblDybdclx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDybdclx.Name = "lblDybdclx";
            this.lblDybdclx.Size = new System.Drawing.Size(41, 20);
            this.lblDybdclx.TabIndex = 9;
            this.lblDybdclx.Text = "抵押不动产类型";
            // 
            // cmbDybdclx
            // 
            this.cmbDybdclx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDybdclx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDybdclx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDybdclx.EnableTouchMode = true;
            this.cmbDybdclx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDybdclx.Location =  new System.Drawing.Point(0,0);
            this.cmbDybdclx.Name = "cmbDybdclx";
            this.cmbDybdclx.Size = new System.Drawing.Size(152, 20);
            this.cmbDybdclx.TabIndex =  10;            
            // 
            // lblID
            // 
            this.lblDyr.AutoSize = true;
            this.lblDyr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDyr.Location = new System.Drawing.Point(0,0);
            this.lblDyr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDyr.Name = "lblDyr";
            this.lblDyr.Size = new System.Drawing.Size(41, 20);
            this.lblDyr.TabIndex = 11;
            this.lblDyr.Text = "抵押人";
            // 
            // txtDyr
            // 
            this.txtDyr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDyr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDyr.EnableTouchMode = true;
            this.txtDyr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDyr.Location =  new System.Drawing.Point(0,0);
            this.txtDyr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDyr.Name = "txtDyr";
            this.txtDyr.Size = new System.Drawing.Size(152, 28);
            this.txtDyr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDyr.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblDyfs.AutoSize = true;
            this.lblDyfs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDyfs.Location = new System.Drawing.Point(0,0);
            this.lblDyfs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDyfs.Name = "lblDyfs";
            this.lblDyfs.Size = new System.Drawing.Size(41, 20);
            this.lblDyfs.TabIndex = 13;
            this.lblDyfs.Text = "抵押方式";
            // 
            // cmbDyfs
            // 
            this.cmbDyfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDyfs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDyfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDyfs.EnableTouchMode = true;
            this.cmbDyfs.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDyfs.Location =  new System.Drawing.Point(0,0);
            this.cmbDyfs.Name = "cmbDyfs";
            this.cmbDyfs.Size = new System.Drawing.Size(152, 20);
            this.cmbDyfs.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblDjlx.AutoSize = true;
            this.lblDjlx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjlx.Location = new System.Drawing.Point(0,0);
            this.lblDjlx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjlx.Name = "lblDjlx";
            this.lblDjlx.Size = new System.Drawing.Size(41, 20);
            this.lblDjlx.TabIndex = 15;
            this.lblDjlx.Text = "登记类型";
            // 
            // cmbDjlx
            // 
            this.cmbDjlx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDjlx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbDjlx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDjlx.EnableTouchMode = true;
            this.cmbDjlx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDjlx.Location =  new System.Drawing.Point(0,0);
            this.cmbDjlx.Name = "cmbDjlx";
            this.cmbDjlx.Size = new System.Drawing.Size(152, 20);
            this.cmbDjlx.TabIndex =  16;            
            // 
            // lblID
            // 
            this.lblDjyy.AutoSize = true;
            this.lblDjyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjyy.Location = new System.Drawing.Point(0,0);
            this.lblDjyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjyy.Name = "lblDjyy";
            this.lblDjyy.Size = new System.Drawing.Size(41, 20);
            this.lblDjyy.TabIndex = 17;
            this.lblDjyy.Text = "登记原因";
            // 
            // txtDjyy
            // 
            this.txtDjyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDjyy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtDjyy.EnableTouchMode = true;
            this.txtDjyy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDjyy.Location =  new System.Drawing.Point(0,0);
            this.txtDjyy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDjyy.Name = "txtDjyy";
            this.txtDjyy.Size = new System.Drawing.Size(152, 28);
            this.txtDjyy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDjyy.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblZjjzwzl.AutoSize = true;
            this.lblZjjzwzl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjjzwzl.Location = new System.Drawing.Point(0,0);
            this.lblZjjzwzl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjjzwzl.Name = "lblZjjzwzl";
            this.lblZjjzwzl.Size = new System.Drawing.Size(41, 20);
            this.lblZjjzwzl.TabIndex = 19;
            this.lblZjjzwzl.Text = "在建建筑物坐落";
            // 
            // txtZjjzwzl
            // 
            this.txtZjjzwzl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjjzwzl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjjzwzl.EnableTouchMode = true;
            this.txtZjjzwzl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjjzwzl.Location =  new System.Drawing.Point(0,0);
            this.txtZjjzwzl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjjzwzl.Name = "txtZjjzwzl";
            this.txtZjjzwzl.Size = new System.Drawing.Size(152, 28);
            this.txtZjjzwzl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjjzwzl.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblZjjzwdyfw.AutoSize = true;
            this.lblZjjzwdyfw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZjjzwdyfw.Location = new System.Drawing.Point(0,0);
            this.lblZjjzwdyfw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZjjzwdyfw.Name = "lblZjjzwdyfw";
            this.lblZjjzwdyfw.Size = new System.Drawing.Size(41, 20);
            this.lblZjjzwdyfw.TabIndex = 21;
            this.lblZjjzwdyfw.Text = "在建建筑物抵押范围";
            // 
            // txtZjjzwdyfw
            // 
            this.txtZjjzwdyfw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZjjzwdyfw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZjjzwdyfw.EnableTouchMode = true;
            this.txtZjjzwdyfw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZjjzwdyfw.Location =  new System.Drawing.Point(0,0);
            this.txtZjjzwdyfw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZjjzwdyfw.Name = "txtZjjzwdyfw";
            this.txtZjjzwdyfw.Size = new System.Drawing.Size(152, 28);
            this.txtZjjzwdyfw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZjjzwdyfw.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblBdbzzqse.AutoSize = true;
            this.lblBdbzzqse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdbzzqse.Location = new System.Drawing.Point(0,0);
            this.lblBdbzzqse.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdbzzqse.Name = "lblBdbzzqse";
            this.lblBdbzzqse.Size = new System.Drawing.Size(41, 20);
            this.lblBdbzzqse.TabIndex = 23;
            this.lblBdbzzqse.Text = "被担保主债权数额";
            // 
            // dblBdbzzqse
            // 
            this.dblBdbzzqse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblBdbzzqse.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblBdbzzqse.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblBdbzzqse.DoubleValue = 1D;
            this.dblBdbzzqse.EnableTouchMode = true;
            this.dblBdbzzqse.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblBdbzzqse.Location =  new System.Drawing.Point(0,0);
            this.dblBdbzzqse.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblBdbzzqse.Name = "dblBdbzzqse";
            this.dblBdbzzqse.NullString = "";
            this.dblBdbzzqse.Size = new System.Drawing.Size(152, 28);
            this.dblBdbzzqse.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblBdbzzqse.TabIndex = 24;
            this.dblBdbzzqse.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZwlxqssj.AutoSize = true;
            this.lblZwlxqssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZwlxqssj.Location = new System.Drawing.Point(0,0);
            this.lblZwlxqssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZwlxqssj.Name = "lblZwlxqssj";
            this.lblZwlxqssj.Size = new System.Drawing.Size(41, 20);
            this.lblZwlxqssj.TabIndex = 25;
            this.lblZwlxqssj.Text = "债务履行起始时间";
            // 
            // datZwlxqssj
            // 
            this.datZwlxqssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datZwlxqssj.BorderColor = System.Drawing.Color.Empty;
            this.datZwlxqssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datZwlxqssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datZwlxqssj.DropDownImage = null;
            this.datZwlxqssj.EnableTouchMode = true;
            this.datZwlxqssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datZwlxqssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZwlxqssj.Location =  new System.Drawing.Point(0,0);
            this.datZwlxqssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datZwlxqssj.MinValue = new System.DateTime(((long)(0)));
            this.datZwlxqssj.Name = "datZwlxqssj";
            this.datZwlxqssj.Size = new System.Drawing.Size(152, 20);
            this.datZwlxqssj.TabIndex = 26;
            this.datZwlxqssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datZwlxqssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblZwlxjssj.AutoSize = true;
            this.lblZwlxjssj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZwlxjssj.Location = new System.Drawing.Point(0,0);
            this.lblZwlxjssj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZwlxjssj.Name = "lblZwlxjssj";
            this.lblZwlxjssj.Size = new System.Drawing.Size(41, 20);
            this.lblZwlxjssj.TabIndex = 27;
            this.lblZwlxjssj.Text = "债务履行结束时间";
            // 
            // datZwlxjssj
            // 
            this.datZwlxjssj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datZwlxjssj.BorderColor = System.Drawing.Color.Empty;
            this.datZwlxjssj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datZwlxjssj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datZwlxjssj.DropDownImage = null;
            this.datZwlxjssj.EnableTouchMode = true;
            this.datZwlxjssj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datZwlxjssj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZwlxjssj.Location =  new System.Drawing.Point(0,0);
            this.datZwlxjssj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datZwlxjssj.MinValue = new System.DateTime(((long)(0)));
            this.datZwlxjssj.Name = "datZwlxjssj";
            this.datZwlxjssj.Size = new System.Drawing.Size(152, 20);
            this.datZwlxjssj.TabIndex = 28;
            this.datZwlxjssj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datZwlxjssj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblZgzqqdss.AutoSize = true;
            this.lblZgzqqdss.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZgzqqdss.Location = new System.Drawing.Point(0,0);
            this.lblZgzqqdss.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZgzqqdss.Name = "lblZgzqqdss";
            this.lblZgzqqdss.Size = new System.Drawing.Size(41, 20);
            this.lblZgzqqdss.TabIndex = 29;
            this.lblZgzqqdss.Text = "最高债权确定事实";
            // 
            // txtZgzqqdss
            // 
            this.txtZgzqqdss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZgzqqdss.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZgzqqdss.EnableTouchMode = true;
            this.txtZgzqqdss.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZgzqqdss.Location =  new System.Drawing.Point(0,0);
            this.txtZgzqqdss.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZgzqqdss.Name = "txtZgzqqdss";
            this.txtZgzqqdss.Size = new System.Drawing.Size(152, 28);
            this.txtZgzqqdss.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZgzqqdss.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblZgzqse.AutoSize = true;
            this.lblZgzqse.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZgzqse.Location = new System.Drawing.Point(0,0);
            this.lblZgzqse.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZgzqse.Name = "lblZgzqse";
            this.lblZgzqse.Size = new System.Drawing.Size(41, 20);
            this.lblZgzqse.TabIndex = 31;
            this.lblZgzqse.Text = "最高债权数额";
            // 
            // dblZgzqse
            // 
            this.dblZgzqse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZgzqse.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZgzqse.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZgzqse.DoubleValue = 1D;
            this.dblZgzqse.EnableTouchMode = true;
            this.dblZgzqse.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZgzqse.Location =  new System.Drawing.Point(0,0);
            this.dblZgzqse.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZgzqse.Name = "dblZgzqse";
            this.dblZgzqse.NullString = "";
            this.dblZgzqse.Size = new System.Drawing.Size(152, 28);
            this.dblZgzqse.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZgzqse.TabIndex = 32;
            this.dblZgzqse.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZxdyywh.AutoSize = true;
            this.lblZxdyywh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZxdyywh.Location = new System.Drawing.Point(0,0);
            this.lblZxdyywh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZxdyywh.Name = "lblZxdyywh";
            this.lblZxdyywh.Size = new System.Drawing.Size(41, 20);
            this.lblZxdyywh.TabIndex = 33;
            this.lblZxdyywh.Text = "注销抵押业务号";
            // 
            // txtZxdyywh
            // 
            this.txtZxdyywh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZxdyywh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZxdyywh.EnableTouchMode = true;
            this.txtZxdyywh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZxdyywh.Location =  new System.Drawing.Point(0,0);
            this.txtZxdyywh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZxdyywh.Name = "txtZxdyywh";
            this.txtZxdyywh.Size = new System.Drawing.Size(152, 28);
            this.txtZxdyywh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZxdyywh.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblZxdyyy.AutoSize = true;
            this.lblZxdyyy.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZxdyyy.Location = new System.Drawing.Point(0,0);
            this.lblZxdyyy.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZxdyyy.Name = "lblZxdyyy";
            this.lblZxdyyy.Size = new System.Drawing.Size(41, 20);
            this.lblZxdyyy.TabIndex = 35;
            this.lblZxdyyy.Text = "注销抵押原因";
            // 
            // txtZxdyyy
            // 
            this.txtZxdyyy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZxdyyy.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtZxdyyy.EnableTouchMode = true;
            this.txtZxdyyy.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZxdyyy.Location =  new System.Drawing.Point(0,0);
            this.txtZxdyyy.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZxdyyy.Name = "txtZxdyyy";
            this.txtZxdyyy.Size = new System.Drawing.Size(152, 28);
            this.txtZxdyyy.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZxdyyy.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblZxsj.AutoSize = true;
            this.lblZxsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZxsj.Location = new System.Drawing.Point(0,0);
            this.lblZxsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZxsj.Name = "lblZxsj";
            this.lblZxsj.Size = new System.Drawing.Size(41, 20);
            this.lblZxsj.TabIndex = 37;
            this.lblZxsj.Text = "注销时间";
            // 
            // datZxsj
            // 
            this.datZxsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datZxsj.BorderColor = System.Drawing.Color.Empty;
            this.datZxsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datZxsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datZxsj.DropDownImage = null;
            this.datZxsj.EnableTouchMode = true;
            this.datZxsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datZxsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datZxsj.Location =  new System.Drawing.Point(0,0);
            this.datZxsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datZxsj.MinValue = new System.DateTime(((long)(0)));
            this.datZxsj.Name = "datZxsj";
            this.datZxsj.Size = new System.Drawing.Size(152, 20);
            this.datZxsj.TabIndex = 38;
            this.datZxsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datZxsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblBdcdjzmh.AutoSize = true;
            this.lblBdcdjzmh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBdcdjzmh.Location = new System.Drawing.Point(0,0);
            this.lblBdcdjzmh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBdcdjzmh.Name = "lblBdcdjzmh";
            this.lblBdcdjzmh.Size = new System.Drawing.Size(41, 20);
            this.lblBdcdjzmh.TabIndex = 39;
            this.lblBdcdjzmh.Text = "不动产登记证明号";
            // 
            // txtBdcdjzmh
            // 
            this.txtBdcdjzmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBdcdjzmh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBdcdjzmh.EnableTouchMode = true;
            this.txtBdcdjzmh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBdcdjzmh.Location =  new System.Drawing.Point(0,0);
            this.txtBdcdjzmh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBdcdjzmh.Name = "txtBdcdjzmh";
            this.txtBdcdjzmh.Size = new System.Drawing.Size(152, 28);
            this.txtBdcdjzmh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBdcdjzmh.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblQxdm.AutoSize = true;
            this.lblQxdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQxdm.Location = new System.Drawing.Point(0,0);
            this.lblQxdm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQxdm.Name = "lblQxdm";
            this.lblQxdm.Size = new System.Drawing.Size(41, 20);
            this.lblQxdm.TabIndex = 41;
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
            this.cmbQxdm.TabIndex =  42;            
            // 
            // lblID
            // 
            this.lblDjjg.AutoSize = true;
            this.lblDjjg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjjg.Location = new System.Drawing.Point(0,0);
            this.lblDjjg.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjjg.Name = "lblDjjg";
            this.lblDjjg.Size = new System.Drawing.Size(41, 20);
            this.lblDjjg.TabIndex = 43;
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
            this.txtDjjg.TabIndex = 44;
            // 
            // lblID
            // 
            this.lblDbr.AutoSize = true;
            this.lblDbr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDbr.Location = new System.Drawing.Point(0,0);
            this.lblDbr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDbr.Name = "lblDbr";
            this.lblDbr.Size = new System.Drawing.Size(41, 20);
            this.lblDbr.TabIndex = 45;
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
            this.txtDbr.TabIndex = 46;
            // 
            // lblID
            // 
            this.lblDjsj.AutoSize = true;
            this.lblDjsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDjsj.Location = new System.Drawing.Point(0,0);
            this.lblDjsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblDjsj.Name = "lblDjsj";
            this.lblDjsj.Size = new System.Drawing.Size(41, 20);
            this.lblDjsj.TabIndex = 47;
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
            this.datDjsj.TabIndex = 48;
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
            this.lblFj.TabIndex = 49;
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
            this.txtFj.TabIndex = 50;
            // 
            // lblID
            // 
            this.lblQszt.AutoSize = true;
            this.lblQszt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQszt.Location = new System.Drawing.Point(0,0);
            this.lblQszt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblQszt.Name = "lblQszt";
            this.lblQszt.Size = new System.Drawing.Size(41, 20);
            this.lblQszt.TabIndex = 51;
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
            this.cmbQszt.TabIndex =  52;            
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.intID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdyh, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdyh, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDybdclx, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbDybdclx, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDyr, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDyr, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDyfs, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbDyfs, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDjlx, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbDjlx, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDjyy, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtDjyy, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblZjjzwzl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtZjjzwzl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZjjzwdyfw, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtZjjzwdyfw, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBdbzzqse, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.dblBdbzzqse, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZwlxqssj, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datZwlxqssj, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblZwlxjssj, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.datZwlxjssj, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblZgzqqdss, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtZgzqqdss, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblZgzqse, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblZgzqse, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblZxdyywh, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtZxdyywh, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblZxdyyy, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtZxdyyy, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblZxsj, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.datZxsj, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBdcdjzmh, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBdcdjzmh, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQxdm, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbQxdm, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDjjg, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDjjg, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDbr, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDbr, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDjsj, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.datDjsj, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFj, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtFj, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblQszt, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbQszt, 7, 7);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
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
            this.tableLayoutPanel1.TabIndex = 53; 
            //
            // ucDyaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucDyaq";
            this.Size = new System.Drawing.Size(750, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdyh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDybdclx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDyr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDyfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDjlx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDjyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjjzwzl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZjjzwdyfw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblBdbzzqse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZwlxqssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZwlxjssj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZgzqqdss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZgzqse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZxdyywh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZxdyyy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datZxsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBdcdjzmh)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDybdclx;	
        private System.Windows.Forms.Label lblDybdclx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDyr;	
        private System.Windows.Forms.Label lblDyr;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDyfs;	
        private System.Windows.Forms.Label lblDyfs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDjlx;	
        private System.Windows.Forms.Label lblDjlx;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDjyy;	
        private System.Windows.Forms.Label lblDjyy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjjzwzl;	
        private System.Windows.Forms.Label lblZjjzwzl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZjjzwdyfw;	
        private System.Windows.Forms.Label lblZjjzwdyfw;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblBdbzzqse;	
        private System.Windows.Forms.Label lblBdbzzqse;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datZwlxqssj;	
        private System.Windows.Forms.Label lblZwlxqssj;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datZwlxjssj;	
        private System.Windows.Forms.Label lblZwlxjssj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZgzqqdss;	
        private System.Windows.Forms.Label lblZgzqqdss;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZgzqse;	
        private System.Windows.Forms.Label lblZgzqse;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZxdyywh;	
        private System.Windows.Forms.Label lblZxdyywh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZxdyyy;	
        private System.Windows.Forms.Label lblZxdyyy;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datZxsj;	
        private System.Windows.Forms.Label lblZxsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBdcdjzmh;	
        private System.Windows.Forms.Label lblBdcdjzmh;
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