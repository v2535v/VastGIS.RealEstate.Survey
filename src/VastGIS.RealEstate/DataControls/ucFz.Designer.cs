using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucFz
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
            this.lblFzry = new System.Windows.Forms.Label();
            this.txtFzry = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFzsj = new System.Windows.Forms.Label();
            this.datFzsj = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblFzmc = new System.Windows.Forms.Label();
            this.txtFzmc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFzsl = new System.Windows.Forms.Label();
            this.intFzsl = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblHfzsh = new System.Windows.Forms.Label();
            this.txtHfzsh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLzrxm = new System.Windows.Forms.Label();
            this.txtLzrxm = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLzrzjlb = new System.Windows.Forms.Label();
            this.cmbLzrzjlb = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblLzrzjh = new System.Windows.Forms.Label();
            this.txtLzrzjh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLzrdh = new System.Windows.Forms.Label();
            this.txtLzrdh = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLzrdz = new System.Windows.Forms.Label();
            this.txtLzrdz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblLzryb = new System.Windows.Forms.Label();
            this.txtLzryb = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBz = new System.Windows.Forms.Label();
            this.txtBz = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFzsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzmc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intFzsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHfzsh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrxm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLzrzjlb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrzjh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrdz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzryb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).BeginInit();
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
            this.lblFzry.AutoSize = true;
            this.lblFzry.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzry.Location = new System.Drawing.Point(0,0);
            this.lblFzry.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzry.Name = "lblFzry";
            this.lblFzry.Size = new System.Drawing.Size(41, 20);
            this.lblFzry.TabIndex = 7;
            this.lblFzry.Text = "发证人员";
            // 
            // txtFzry
            // 
            this.txtFzry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFzry.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFzry.EnableTouchMode = true;
            this.txtFzry.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFzry.Location =  new System.Drawing.Point(0,0);
            this.txtFzry.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFzry.Name = "txtFzry";
            this.txtFzry.Size = new System.Drawing.Size(152, 28);
            this.txtFzry.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFzry.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblFzsj.AutoSize = true;
            this.lblFzsj.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzsj.Location = new System.Drawing.Point(0,0);
            this.lblFzsj.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzsj.Name = "lblFzsj";
            this.lblFzsj.Size = new System.Drawing.Size(41, 20);
            this.lblFzsj.TabIndex = 9;
            this.lblFzsj.Text = "发证时间";
            // 
            // datFzsj
            // 
            this.datFzsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datFzsj.BorderColor = System.Drawing.Color.Empty;
            this.datFzsj.CalendarSize = new System.Drawing.Size(189, 176);
            this.datFzsj.CustomFormat = "yyyy年MM月dd日 hh点mm分";
            this.datFzsj.DropDownImage = null;
            this.datFzsj.EnableTouchMode = true;
            this.datFzsj.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datFzsj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFzsj.Location =  new System.Drawing.Point(0,0);
            this.datFzsj.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datFzsj.MinValue = new System.DateTime(((long)(0)));
            this.datFzsj.Name = "datFzsj";
            this.datFzsj.Size = new System.Drawing.Size(152, 20);
            this.datFzsj.TabIndex = 10;
            this.datFzsj.Value = new System.DateTime(2018, 2, 6, 15, 28, 19, 283);
            this.datFzsj.UseCurrentCulture = true;
            // 
            // lblID
            // 
            this.lblFzmc.AutoSize = true;
            this.lblFzmc.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzmc.Location = new System.Drawing.Point(0,0);
            this.lblFzmc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzmc.Name = "lblFzmc";
            this.lblFzmc.Size = new System.Drawing.Size(41, 20);
            this.lblFzmc.TabIndex = 11;
            this.lblFzmc.Text = "发证名称";
            // 
            // txtFzmc
            // 
            this.txtFzmc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFzmc.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFzmc.EnableTouchMode = true;
            this.txtFzmc.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFzmc.Location =  new System.Drawing.Point(0,0);
            this.txtFzmc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFzmc.Name = "txtFzmc";
            this.txtFzmc.Size = new System.Drawing.Size(152, 28);
            this.txtFzmc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFzmc.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblFzsl.AutoSize = true;
            this.lblFzsl.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFzsl.Location = new System.Drawing.Point(0,0);
            this.lblFzsl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblFzsl.Name = "lblFzsl";
            this.lblFzsl.Size = new System.Drawing.Size(41, 20);
            this.lblFzsl.TabIndex = 13;
            this.lblFzsl.Text = "发证数量";
            // 
            // intFzsl
            // 
            this.intFzsl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intFzsl.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intFzsl.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intFzsl.EnableTouchMode = true;
            this.intFzsl.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intFzsl.IntegerValue = ((long)(0));
            this.intFzsl.Location = new System.Drawing.Point(0,0);
            this.intFzsl.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intFzsl.Name = "intFzsl";
            this.intFzsl.NullString = "";
            this.intFzsl.Size = new System.Drawing.Size(152, 28);
            this.intFzsl.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intFzsl.TabIndex = 14;
            this.intFzsl.Text = "0";
            // 
            // lblID
            // 
            this.lblHfzsh.AutoSize = true;
            this.lblHfzsh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHfzsh.Location = new System.Drawing.Point(0,0);
            this.lblHfzsh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblHfzsh.Name = "lblHfzsh";
            this.lblHfzsh.Size = new System.Drawing.Size(41, 20);
            this.lblHfzsh.TabIndex = 15;
            this.lblHfzsh.Text = "核发证书号";
            // 
            // txtHfzsh
            // 
            this.txtHfzsh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHfzsh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtHfzsh.EnableTouchMode = true;
            this.txtHfzsh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHfzsh.Location =  new System.Drawing.Point(0,0);
            this.txtHfzsh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHfzsh.Name = "txtHfzsh";
            this.txtHfzsh.Size = new System.Drawing.Size(152, 28);
            this.txtHfzsh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHfzsh.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblLzrxm.AutoSize = true;
            this.lblLzrxm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzrxm.Location = new System.Drawing.Point(0,0);
            this.lblLzrxm.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzrxm.Name = "lblLzrxm";
            this.lblLzrxm.Size = new System.Drawing.Size(41, 20);
            this.lblLzrxm.TabIndex = 17;
            this.lblLzrxm.Text = "领证人姓名";
            // 
            // txtLzrxm
            // 
            this.txtLzrxm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLzrxm.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLzrxm.EnableTouchMode = true;
            this.txtLzrxm.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLzrxm.Location =  new System.Drawing.Point(0,0);
            this.txtLzrxm.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLzrxm.Name = "txtLzrxm";
            this.txtLzrxm.Size = new System.Drawing.Size(152, 28);
            this.txtLzrxm.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLzrxm.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblLzrzjlb.AutoSize = true;
            this.lblLzrzjlb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzrzjlb.Location = new System.Drawing.Point(0,0);
            this.lblLzrzjlb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzrzjlb.Name = "lblLzrzjlb";
            this.lblLzrzjlb.Size = new System.Drawing.Size(41, 20);
            this.lblLzrzjlb.TabIndex = 19;
            this.lblLzrzjlb.Text = "领证人证件类别";
            // 
            // cmbLzrzjlb
            // 
            this.cmbLzrzjlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLzrzjlb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.cmbLzrzjlb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLzrzjlb.EnableTouchMode = true;
            this.cmbLzrzjlb.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLzrzjlb.Location =  new System.Drawing.Point(0,0);
            this.cmbLzrzjlb.Name = "cmbLzrzjlb";
            this.cmbLzrzjlb.Size = new System.Drawing.Size(152, 20);
            this.cmbLzrzjlb.TabIndex =  20;            
            // 
            // lblID
            // 
            this.lblLzrzjh.AutoSize = true;
            this.lblLzrzjh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzrzjh.Location = new System.Drawing.Point(0,0);
            this.lblLzrzjh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzrzjh.Name = "lblLzrzjh";
            this.lblLzrzjh.Size = new System.Drawing.Size(41, 20);
            this.lblLzrzjh.TabIndex = 21;
            this.lblLzrzjh.Text = "领证人证件号";
            // 
            // txtLzrzjh
            // 
            this.txtLzrzjh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLzrzjh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLzrzjh.EnableTouchMode = true;
            this.txtLzrzjh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLzrzjh.Location =  new System.Drawing.Point(0,0);
            this.txtLzrzjh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLzrzjh.Name = "txtLzrzjh";
            this.txtLzrzjh.Size = new System.Drawing.Size(152, 28);
            this.txtLzrzjh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLzrzjh.TabIndex = 22;
            // 
            // lblID
            // 
            this.lblLzrdh.AutoSize = true;
            this.lblLzrdh.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzrdh.Location = new System.Drawing.Point(0,0);
            this.lblLzrdh.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzrdh.Name = "lblLzrdh";
            this.lblLzrdh.Size = new System.Drawing.Size(41, 20);
            this.lblLzrdh.TabIndex = 23;
            this.lblLzrdh.Text = "领证人电话";
            // 
            // txtLzrdh
            // 
            this.txtLzrdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLzrdh.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLzrdh.EnableTouchMode = true;
            this.txtLzrdh.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLzrdh.Location =  new System.Drawing.Point(0,0);
            this.txtLzrdh.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLzrdh.Name = "txtLzrdh";
            this.txtLzrdh.Size = new System.Drawing.Size(152, 28);
            this.txtLzrdh.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLzrdh.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblLzrdz.AutoSize = true;
            this.lblLzrdz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzrdz.Location = new System.Drawing.Point(0,0);
            this.lblLzrdz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzrdz.Name = "lblLzrdz";
            this.lblLzrdz.Size = new System.Drawing.Size(41, 20);
            this.lblLzrdz.TabIndex = 25;
            this.lblLzrdz.Text = "领证人地址";
            // 
            // txtLzrdz
            // 
            this.txtLzrdz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLzrdz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLzrdz.EnableTouchMode = true;
            this.txtLzrdz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLzrdz.Location =  new System.Drawing.Point(0,0);
            this.txtLzrdz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLzrdz.Name = "txtLzrdz";
            this.txtLzrdz.Size = new System.Drawing.Size(152, 28);
            this.txtLzrdz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLzrdz.TabIndex = 26;
            // 
            // lblID
            // 
            this.lblLzryb.AutoSize = true;
            this.lblLzryb.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLzryb.Location = new System.Drawing.Point(0,0);
            this.lblLzryb.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblLzryb.Name = "lblLzryb";
            this.lblLzryb.Size = new System.Drawing.Size(41, 20);
            this.lblLzryb.TabIndex = 27;
            this.lblLzryb.Text = "领证人邮编";
            // 
            // txtLzryb
            // 
            this.txtLzryb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLzryb.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtLzryb.EnableTouchMode = true;
            this.txtLzryb.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLzryb.Location =  new System.Drawing.Point(0,0);
            this.txtLzryb.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtLzryb.Name = "txtLzryb";
            this.txtLzryb.Size = new System.Drawing.Size(152, 28);
            this.txtLzryb.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtLzryb.TabIndex = 28;
            // 
            // lblID
            // 
            this.lblBz.AutoSize = true;
            this.lblBz.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBz.Location = new System.Drawing.Point(0,0);
            this.lblBz.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBz.Name = "lblBz";
            this.lblBz.Size = new System.Drawing.Size(41, 20);
            this.lblBz.TabIndex = 29;
            this.lblBz.Text = "备注";
            // 
            // txtBz
            // 
            this.txtBz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBz.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtBz.EnableTouchMode = true;
            this.txtBz.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBz.Location =  new System.Drawing.Point(0,0);
            this.txtBz.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBz.Name = "txtBz";
            this.txtBz.Size = new System.Drawing.Size(152, 28);
            this.txtBz.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBz.TabIndex = 30;
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
            this.tableLayoutPanel1.Controls.Add(this.lblFzry, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFzry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFzsj, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datFzsj, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFzmc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFzmc, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFzsl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.intFzsl, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblHfzsh, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtHfzsh, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblLzrxm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLzrxm, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLzrzjlb, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLzrzjlb, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLzrzjh, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLzrzjh, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLzrdh, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLzrdh, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLzrdz, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtLzrdz, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLzryb, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtLzryb, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBz, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBz, 4, 6);
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
            this.tableLayoutPanel1.TabIndex = 31; 
            //
            // ucFz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucFz";
            this.Size = new System.Drawing.Size(500, 296);            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYwh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYsdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFzsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFzmc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intFzsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHfzsh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrxm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLzrzjlb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrzjh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzrdz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLzryb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBz)).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFzry;	
        private System.Windows.Forms.Label lblFzry;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datFzsj;	
        private System.Windows.Forms.Label lblFzsj;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFzmc;	
        private System.Windows.Forms.Label lblFzmc;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intFzsl;	
        private System.Windows.Forms.Label lblFzsl;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHfzsh;	
        private System.Windows.Forms.Label lblHfzsh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLzrxm;	
        private System.Windows.Forms.Label lblLzrxm;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLzrzjlb;	
        private System.Windows.Forms.Label lblLzrzjlb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLzrzjh;	
        private System.Windows.Forms.Label lblLzrzjh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLzrdh;	
        private System.Windows.Forms.Label lblLzrdh;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLzrdz;	
        private System.Windows.Forms.Label lblLzrdz;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLzryb;	
        private System.Windows.Forms.Label lblLzryb;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBz;	
        private System.Windows.Forms.Label lblBz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
    }
}