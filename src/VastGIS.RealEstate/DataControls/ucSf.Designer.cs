using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucSf
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
            this.lblYwh = new System.Windows.Forms.Label();
            this.txtYwh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYsdm = new System.Windows.Forms.Label();
            this.txtYsdm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfry = new System.Windows.Forms.Label();
            this.txtJfry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJfrq = new System.Windows.Forms.Label();
            this.datJfrq = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblSfkmmc = new System.Windows.Forms.Label();
            this.txtSfkmmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfewsf = new System.Windows.Forms.Label();
            this.cmbSfewsf = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSfjs = new System.Windows.Forms.Label();
            this.dblSfjs = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSflx = new System.Windows.Forms.Label();
            this.cmbSflx = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblYsje = new System.Windows.Forms.Label();
            this.dblYsje = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZkhysje = new System.Windows.Forms.Label();
            this.dblZkhysje = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSfry = new System.Windows.Forms.Label();
            this.txtSfry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSfrq = new System.Windows.Forms.Label();
            this.datSfrq = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFff = new System.Windows.Forms.Label();
            this.cmbFff = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblSjffr = new System.Windows.Forms.Label();
            this.txtSjffr = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblSsje = new System.Windows.Forms.Label();
            this.dblSsje = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblSfdw = new System.Windows.Forms.Label();
            this.txtSfdw = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJfrq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfkmmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfewsf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSfjs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSflx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYsje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZkhysje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSfrq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjffr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSsje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfdw)).BeginInit();
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
            this.lblYwh.AutoSize = true;
            this.lblYwh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYwh.Location = new System.Drawing.Point(0,0);
            this.lblYwh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYwh.Name = "lblYwh";
            this.lblYwh.Size = new System.Drawing.Size(41, 20);
            this.lblYwh.TabIndex = 3;
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
            this.txtYwh.TabIndex = 4;
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
            this.lblJfry.AutoSize = true;
            this.lblJfry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfry.Location = new System.Drawing.Point(0,0);
            this.lblJfry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfry.Name = "lblJfry";
            this.lblJfry.Size = new System.Drawing.Size(41, 20);
            this.lblJfry.TabIndex = 7;
            this.lblJfry.Text = "计费人员";
            // 
            // txtJfry
            // 
            this.txtJfry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJfry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtJfry.EnableTouchMode = true;
            this.txtJfry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJfry.Location =  new System.Drawing.Point(0,0);
            this.txtJfry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJfry.Name = "txtJfry";
            this.txtJfry.Size = new System.Drawing.Size(152, 28);
            this.txtJfry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJfry.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblJfrq.AutoSize = true;
            this.lblJfrq.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJfrq.Location = new System.Drawing.Point(0,0);
            this.lblJfrq.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblJfrq.Name = "lblJfrq";
            this.lblJfrq.Size = new System.Drawing.Size(41, 20);
            this.lblJfrq.TabIndex = 9;
            this.lblJfrq.Text = "计费日期";
            // 
            // datJfrq
            // 
            this.datJfrq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datJfrq.BorderColor = System.Drawing.Color.Empty;
            this.datJfrq.CalendarSize = new System.Drawing.Size(189, 176);
            this.datJfrq.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datJfrq.DropDownImage = null;
            this.datJfrq.EnableTouchMode = true;
            this.datJfrq.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datJfrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datJfrq.Location =  new System.Drawing.Point(0,0);
            this.datJfrq.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datJfrq.MinValue = new System.DateTime(((long)(0)));
            this.datJfrq.Name = "datJfrq";
            this.datJfrq.Size = new System.Drawing.Size(152, 20);
            this.datJfrq.TabIndex = 10;
            this.datJfrq.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datJfrq.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblSfkmmc.AutoSize = true;
            this.lblSfkmmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfkmmc.Location = new System.Drawing.Point(0,0);
            this.lblSfkmmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfkmmc.Name = "lblSfkmmc";
            this.lblSfkmmc.Size = new System.Drawing.Size(41, 20);
            this.lblSfkmmc.TabIndex = 11;
            this.lblSfkmmc.Text = "收费科目名称";
            // 
            // txtSfkmmc
            // 
            this.txtSfkmmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSfkmmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSfkmmc.EnableTouchMode = true;
            this.txtSfkmmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSfkmmc.Location =  new System.Drawing.Point(0,0);
            this.txtSfkmmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSfkmmc.Name = "txtSfkmmc";
            this.txtSfkmmc.Size = new System.Drawing.Size(152, 28);
            this.txtSfkmmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSfkmmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblSfewsf.AutoSize = true;
            this.lblSfewsf.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfewsf.Location = new System.Drawing.Point(0,0);
            this.lblSfewsf.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfewsf.Name = "lblSfewsf";
            this.lblSfewsf.Size = new System.Drawing.Size(41, 20);
            this.lblSfewsf.TabIndex = 13;
            this.lblSfewsf.Text = "是否额外收费";
            // 
            // cmbSfewsf
            // 
            this.cmbSfewsf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSfewsf.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSfewsf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSfewsf.EnableTouchMode = true;
            this.cmbSfewsf.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSfewsf.Location =  new System.Drawing.Point(0,0);
            this.cmbSfewsf.Name = "cmbSfewsf";
            this.cmbSfewsf.Size = new System.Drawing.Size(152, 20);
            this.cmbSfewsf.TabIndex =  14;            
            // 
            // lblID
            // 
            this.lblSfjs.AutoSize = true;
            this.lblSfjs.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfjs.Location = new System.Drawing.Point(0,0);
            this.lblSfjs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfjs.Name = "lblSfjs";
            this.lblSfjs.Size = new System.Drawing.Size(41, 20);
            this.lblSfjs.TabIndex = 15;
            this.lblSfjs.Text = "收费基数";
            // 
            // dblSfjs
            // 
            this.dblSfjs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSfjs.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSfjs.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSfjs.DoubleValue = 1D;
            this.dblSfjs.EnableTouchMode = true;
            this.dblSfjs.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSfjs.Location =  new System.Drawing.Point(0,0);
            this.dblSfjs.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSfjs.Name = "dblSfjs";
            this.dblSfjs.NullString = "";
            this.dblSfjs.Size = new System.Drawing.Size(152, 28);
            this.dblSfjs.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSfjs.TabIndex = 16;
            this.dblSfjs.Text = "1.00";
            // 
            // lblID
            // 
            this.lblSflx.AutoSize = true;
            this.lblSflx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSflx.Location = new System.Drawing.Point(0,0);
            this.lblSflx.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSflx.Name = "lblSflx";
            this.lblSflx.Size = new System.Drawing.Size(41, 20);
            this.lblSflx.TabIndex = 17;
            this.lblSflx.Text = "收费类型";
            // 
            // cmbSflx
            // 
            this.cmbSflx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSflx.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbSflx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSflx.EnableTouchMode = true;
            this.cmbSflx.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSflx.Location =  new System.Drawing.Point(0,0);
            this.cmbSflx.Name = "cmbSflx";
            this.cmbSflx.Size = new System.Drawing.Size(152, 20);
            this.cmbSflx.TabIndex =  18;            
            // 
            // lblID
            // 
            this.lblYsje.AutoSize = true;
            this.lblYsje.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYsje.Location = new System.Drawing.Point(0,0);
            this.lblYsje.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblYsje.Name = "lblYsje";
            this.lblYsje.Size = new System.Drawing.Size(41, 20);
            this.lblYsje.TabIndex = 19;
            this.lblYsje.Text = "应收金额";
            // 
            // dblYsje
            // 
            this.dblYsje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblYsje.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblYsje.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblYsje.DoubleValue = 1D;
            this.dblYsje.EnableTouchMode = true;
            this.dblYsje.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblYsje.Location =  new System.Drawing.Point(0,0);
            this.dblYsje.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblYsje.Name = "dblYsje";
            this.dblYsje.NullString = "";
            this.dblYsje.Size = new System.Drawing.Size(152, 28);
            this.dblYsje.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblYsje.TabIndex = 20;
            this.dblYsje.Text = "1.00";
            // 
            // lblID
            // 
            this.lblZkhysje.AutoSize = true;
            this.lblZkhysje.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZkhysje.Location = new System.Drawing.Point(0,0);
            this.lblZkhysje.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblZkhysje.Name = "lblZkhysje";
            this.lblZkhysje.Size = new System.Drawing.Size(41, 20);
            this.lblZkhysje.TabIndex = 21;
            this.lblZkhysje.Text = "折扣后应收金额";
            // 
            // dblZkhysje
            // 
            this.dblZkhysje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblZkhysje.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZkhysje.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblZkhysje.DoubleValue = 1D;
            this.dblZkhysje.EnableTouchMode = true;
            this.dblZkhysje.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblZkhysje.Location =  new System.Drawing.Point(0,0);
            this.dblZkhysje.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZkhysje.Name = "dblZkhysje";
            this.dblZkhysje.NullString = "";
            this.dblZkhysje.Size = new System.Drawing.Size(152, 28);
            this.dblZkhysje.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZkhysje.TabIndex = 22;
            this.dblZkhysje.Text = "1.00";
            // 
            // lblID
            // 
            this.lblSfry.AutoSize = true;
            this.lblSfry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfry.Location = new System.Drawing.Point(0,0);
            this.lblSfry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfry.Name = "lblSfry";
            this.lblSfry.Size = new System.Drawing.Size(41, 20);
            this.lblSfry.TabIndex = 23;
            this.lblSfry.Text = "收费人员";
            // 
            // txtSfry
            // 
            this.txtSfry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSfry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSfry.EnableTouchMode = true;
            this.txtSfry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSfry.Location =  new System.Drawing.Point(0,0);
            this.txtSfry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSfry.Name = "txtSfry";
            this.txtSfry.Size = new System.Drawing.Size(152, 28);
            this.txtSfry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSfry.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblSfrq.AutoSize = true;
            this.lblSfrq.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfrq.Location = new System.Drawing.Point(0,0);
            this.lblSfrq.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfrq.Name = "lblSfrq";
            this.lblSfrq.Size = new System.Drawing.Size(41, 20);
            this.lblSfrq.TabIndex = 25;
            this.lblSfrq.Text = "收费日期";
            // 
            // datSfrq
            // 
            this.datSfrq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datSfrq.BorderColor = System.Drawing.Color.Empty;
            this.datSfrq.CalendarSize = new System.Drawing.Size(189, 176);
            this.datSfrq.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datSfrq.DropDownImage = null;
            this.datSfrq.EnableTouchMode = true;
            this.datSfrq.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datSfrq.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSfrq.Location =  new System.Drawing.Point(0,0);
            this.datSfrq.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datSfrq.MinValue = new System.DateTime(((long)(0)));
            this.datSfrq.Name = "datSfrq";
            this.datSfrq.Size = new System.Drawing.Size(152, 20);
            this.datSfrq.TabIndex = 26;
            this.datSfrq.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datSfrq.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFff.AutoSize = true;
            this.lblFff.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFff.Location = new System.Drawing.Point(0,0);
            this.lblFff.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFff.Name = "lblFff";
            this.lblFff.Size = new System.Drawing.Size(41, 20);
            this.lblFff.TabIndex = 27;
            this.lblFff.Text = "付费方";
            // 
            // cmbFff
            // 
            this.cmbFff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFff.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbFff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFff.EnableTouchMode = true;
            this.cmbFff.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFff.Location =  new System.Drawing.Point(0,0);
            this.cmbFff.Name = "cmbFff";
            this.cmbFff.Size = new System.Drawing.Size(152, 20);
            this.cmbFff.TabIndex =  28;            
            // 
            // lblID
            // 
            this.lblSjffr.AutoSize = true;
            this.lblSjffr.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSjffr.Location = new System.Drawing.Point(0,0);
            this.lblSjffr.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSjffr.Name = "lblSjffr";
            this.lblSjffr.Size = new System.Drawing.Size(41, 20);
            this.lblSjffr.TabIndex = 29;
            this.lblSjffr.Text = "实际付费人";
            // 
            // txtSjffr
            // 
            this.txtSjffr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSjffr.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSjffr.EnableTouchMode = true;
            this.txtSjffr.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSjffr.Location =  new System.Drawing.Point(0,0);
            this.txtSjffr.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSjffr.Name = "txtSjffr";
            this.txtSjffr.Size = new System.Drawing.Size(152, 28);
            this.txtSjffr.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSjffr.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblSsje.AutoSize = true;
            this.lblSsje.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSsje.Location = new System.Drawing.Point(0,0);
            this.lblSsje.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSsje.Name = "lblSsje";
            this.lblSsje.Size = new System.Drawing.Size(41, 20);
            this.lblSsje.TabIndex = 31;
            this.lblSsje.Text = "实收金额";
            // 
            // dblSsje
            // 
            this.dblSsje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dblSsje.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblSsje.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblSsje.DoubleValue = 1D;
            this.dblSsje.EnableTouchMode = true;
            this.dblSsje.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblSsje.Location =  new System.Drawing.Point(0,0);
            this.dblSsje.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblSsje.Name = "dblSsje";
            this.dblSsje.NullString = "";
            this.dblSsje.Size = new System.Drawing.Size(152, 28);
            this.dblSsje.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblSsje.TabIndex = 32;
            this.dblSsje.Text = "1.00";
            // 
            // lblID
            // 
            this.lblSfdw.AutoSize = true;
            this.lblSfdw.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSfdw.Location = new System.Drawing.Point(0,0);
            this.lblSfdw.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblSfdw.Name = "lblSfdw";
            this.lblSfdw.Size = new System.Drawing.Size(41, 20);
            this.lblSfdw.TabIndex = 33;
            this.lblSfdw.Text = "收费单位";
            // 
            // txtSfdw
            // 
            this.txtSfdw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSfdw.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtSfdw.EnableTouchMode = true;
            this.txtSfdw.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSfdw.Location =  new System.Drawing.Point(0,0);
            this.txtSfdw.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtSfdw.Name = "txtSfdw";
            this.txtSfdw.Size = new System.Drawing.Size(152, 28);
            this.txtSfdw.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtSfdw.TabIndex = 34;
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
            this.tableLayoutPanel1.Controls.Add(this.lblYwh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYwh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYsdm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtYsdm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblJfry, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtJfry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblJfrq, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datJfrq, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSfkmmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSfkmmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSfewsf, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbSfewsf, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSfjs, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dblSfjs, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSflx, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cmbSflx, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblYsje, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dblYsje, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZkhysje, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dblZkhysje, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSfry, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSfry, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSfrq, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.datSfrq, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFff, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbFff, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSjffr, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSjffr, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSsje, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.dblSsje, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSfdw, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtSfdw, 4, 7);
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
            this.tableLayoutPanel1.TabIndex = 35; 
            //
            // ucSf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSf";
            this.Size = new System.Drawing.Size(500, 331);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJfry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datJfrq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfkmmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSfewsf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSfjs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSflx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblYsje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblZkhysje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSfrq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSjffr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblSsje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSfdw)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID;	
        private System.Windows.Forms.Label lblID;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYwh;	
        private System.Windows.Forms.Label lblYwh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYsdm;	
        private System.Windows.Forms.Label lblYsdm;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJfry;	
        private System.Windows.Forms.Label lblJfry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datJfrq;	
        private System.Windows.Forms.Label lblJfrq;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSfkmmc;	
        private System.Windows.Forms.Label lblSfkmmc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSfewsf;	
        private System.Windows.Forms.Label lblSfewsf;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSfjs;	
        private System.Windows.Forms.Label lblSfjs;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSflx;	
        private System.Windows.Forms.Label lblSflx;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblYsje;	
        private System.Windows.Forms.Label lblYsje;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZkhysje;	
        private System.Windows.Forms.Label lblZkhysje;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSfry;	
        private System.Windows.Forms.Label lblSfry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datSfrq;	
        private System.Windows.Forms.Label lblSfrq;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFff;	
        private System.Windows.Forms.Label lblFff;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSjffr;	
        private System.Windows.Forms.Label lblSjffr;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblSsje;	
        private System.Windows.Forms.Label lblSsje;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSfdw;	
        private System.Windows.Forms.Label lblSfdw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}