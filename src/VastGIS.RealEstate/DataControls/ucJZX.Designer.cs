using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucJZX
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
            this.intID = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtZDZHDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDZHDM = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            this.txtJZXGZBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJZXGZBH = new System.Windows.Forms.Label();
            this.dblJZXCD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJZXCD = new System.Windows.Forms.Label();
            this.cmbJZXLB = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJZXLB = new System.Windows.Forms.Label();
            this.cmbJZXWZ = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJZXWZ = new System.Windows.Forms.Label();
            this.cmbJXXZ = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJXXZ = new System.Windows.Forms.Label();
            this.txtQSJXXYSBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSJXXYSBH = new System.Windows.Forms.Label();
            this.txtQSJXXYS = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSJXXYS = new System.Windows.Forms.Label();
            this.txtQSZYYYSBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSZYYYSBH = new System.Windows.Forms.Label();
            this.txtQSZYYYS = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSZYYYS = new System.Windows.Forms.Label();
            this.txtQSJZDBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSJZDBH = new System.Windows.Forms.Label();
            this.txtJZJZDBH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJZJZDBH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZHDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZXGZBH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZXCD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJZXLB)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJZXWZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXXZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJXXYSBH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJXXYS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSZYYYSBH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSZYYYS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJZDBH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZJZDBH)).BeginInit();           
            this.SuspendLayout();
            // 
            // intID
            // 
            this.intID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intID.EnableTouchMode = true;
            this.intID.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intID.Location = new System.Drawing.Point(100, 20);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";           
            this.intID.Size = new System.Drawing.Size(152, 21);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 1;
            this.intID.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intID.Text = "1.00";           
            this.intID.NullString = "";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 12);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtZDZHDM
            // 
            this.txtZDZHDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDZHDM.EnableTouchMode = true;
            this.txtZDZHDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDZHDM.Location = new System.Drawing.Point(100, 55);
            this.txtZDZHDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDZHDM.Name = "txtZDZHDM";           
            this.txtZDZHDM.Size = new System.Drawing.Size(152, 21);
            this.txtZDZHDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDZHDM.TabIndex = 3;
            this.txtZDZHDM.Text = "";   
            // 
            // lblZDZHDM
            // 
            this.lblZDZHDM.AutoSize = true;
            this.lblZDZHDM.Location = new System.Drawing.Point(10, 59);
            this.lblZDZHDM.Name = "lblZDZHDM";
            this.lblZDZHDM.Size = new System.Drawing.Size(65, 12);
            this.lblZDZHDM.TabIndex = 4;
            this.lblZDZHDM.Text = "宗地/宗海代码";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSDM.Location = new System.Drawing.Point(100, 90);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";           
            this.txtYSDM.Size = new System.Drawing.Size(152, 21);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 5;
            this.txtYSDM.Text = "";   
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 94);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(65, 12);
            this.lblYSDM.TabIndex = 6;
            this.lblYSDM.Text = "要素代码";
            // 
            // txtJZXGZBH
            // 
            this.txtJZXGZBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtJZXGZBH.EnableTouchMode = true;
            this.txtJZXGZBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtJZXGZBH.Location = new System.Drawing.Point(100, 125);
            this.txtJZXGZBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJZXGZBH.Name = "txtJZXGZBH";           
            this.txtJZXGZBH.Size = new System.Drawing.Size(152, 21);
            this.txtJZXGZBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJZXGZBH.TabIndex = 7;
            this.txtJZXGZBH.Text = "";   
            // 
            // lblJZXGZBH
            // 
            this.lblJZXGZBH.AutoSize = true;
            this.lblJZXGZBH.Location = new System.Drawing.Point(10, 129);
            this.lblJZXGZBH.Name = "lblJZXGZBH";
            this.lblJZXGZBH.Size = new System.Drawing.Size(65, 12);
            this.lblJZXGZBH.TabIndex = 8;
            this.lblJZXGZBH.Text = "JZXGZBH";
            // 
            // dblJZXCD
            // 
            this.dblJZXCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblJZXCD.EnableTouchMode = true;
            this.dblJZXCD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblJZXCD.Location = new System.Drawing.Point(100, 160);
            this.dblJZXCD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJZXCD.Name = "dblJZXCD";           
            this.dblJZXCD.Size = new System.Drawing.Size(152, 21);
            this.dblJZXCD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJZXCD.TabIndex = 9;
            this.dblJZXCD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJZXCD.Text = "1.00";
            this.dblJZXCD.DoubleValue = 1D;
            this.dblJZXCD.NullString = "";
            // 
            // lblJZXCD
            // 
            this.lblJZXCD.AutoSize = true;
            this.lblJZXCD.Location = new System.Drawing.Point(10, 164);
            this.lblJZXCD.Name = "lblJZXCD";
            this.lblJZXCD.Size = new System.Drawing.Size(65, 12);
            this.lblJZXCD.TabIndex = 10;
            this.lblJZXCD.Text = "界址线长度";
            // 
            // cmbJZXLB
            // 
            this.cmbJZXLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbJZXLB.EnableTouchMode = true;
            this.cmbJZXLB.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbJZXLB.Location = new System.Drawing.Point(100, 195);
            this.cmbJZXLB.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJZXLB.Name = "cmbJZXLB";           
            this.cmbJZXLB.Size = new System.Drawing.Size(152, 21);
            this.cmbJZXLB.TabIndex = 11;
            // 
            // lblJZXLB
            // 
            this.lblJZXLB.AutoSize = true;
            this.lblJZXLB.Location = new System.Drawing.Point(10, 199);
            this.lblJZXLB.Name = "lblJZXLB";
            this.lblJZXLB.Size = new System.Drawing.Size(65, 12);
            this.lblJZXLB.TabIndex = 12;
            this.lblJZXLB.Text = "界址线类别";
            // 
            // cmbJZXWZ
            // 
            this.cmbJZXWZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbJZXWZ.EnableTouchMode = true;
            this.cmbJZXWZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbJZXWZ.Location = new System.Drawing.Point(100, 230);
            this.cmbJZXWZ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJZXWZ.Name = "cmbJZXWZ";           
            this.cmbJZXWZ.Size = new System.Drawing.Size(152, 21);
            this.cmbJZXWZ.TabIndex = 13;
            // 
            // lblJZXWZ
            // 
            this.lblJZXWZ.AutoSize = true;
            this.lblJZXWZ.Location = new System.Drawing.Point(10, 234);
            this.lblJZXWZ.Name = "lblJZXWZ";
            this.lblJZXWZ.Size = new System.Drawing.Size(65, 12);
            this.lblJZXWZ.TabIndex = 14;
            this.lblJZXWZ.Text = "界址线位置";
            // 
            // cmbJXXZ
            // 
            this.cmbJXXZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbJXXZ.EnableTouchMode = true;
            this.cmbJXXZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbJXXZ.Location = new System.Drawing.Point(100, 265);
            this.cmbJXXZ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJXXZ.Name = "cmbJXXZ";           
            this.cmbJXXZ.Size = new System.Drawing.Size(152, 21);
            this.cmbJXXZ.TabIndex = 15;
            // 
            // lblJXXZ
            // 
            this.lblJXXZ.AutoSize = true;
            this.lblJXXZ.Location = new System.Drawing.Point(10, 269);
            this.lblJXXZ.Name = "lblJXXZ";
            this.lblJXXZ.Size = new System.Drawing.Size(65, 12);
            this.lblJXXZ.TabIndex = 16;
            this.lblJXXZ.Text = "界线性质";
            // 
            // txtQSJXXYSBH
            // 
            this.txtQSJXXYSBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSJXXYSBH.EnableTouchMode = true;
            this.txtQSJXXYSBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSJXXYSBH.Location = new System.Drawing.Point(100, 300);
            this.txtQSJXXYSBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSJXXYSBH.Name = "txtQSJXXYSBH";           
            this.txtQSJXXYSBH.Size = new System.Drawing.Size(152, 21);
            this.txtQSJXXYSBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSJXXYSBH.TabIndex = 17;
            this.txtQSJXXYSBH.Text = "";   
            // 
            // lblQSJXXYSBH
            // 
            this.lblQSJXXYSBH.AutoSize = true;
            this.lblQSJXXYSBH.Location = new System.Drawing.Point(10, 304);
            this.lblQSJXXYSBH.Name = "lblQSJXXYSBH";
            this.lblQSJXXYSBH.Size = new System.Drawing.Size(65, 12);
            this.lblQSJXXYSBH.TabIndex = 18;
            this.lblQSJXXYSBH.Text = "权属界线协议书编号";
            // 
            // txtQSJXXYS
            // 
            this.txtQSJXXYS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSJXXYS.EnableTouchMode = true;
            this.txtQSJXXYS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSJXXYS.Location = new System.Drawing.Point(100, 335);
            this.txtQSJXXYS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSJXXYS.Name = "txtQSJXXYS";           
            this.txtQSJXXYS.Size = new System.Drawing.Size(152, 21);
            this.txtQSJXXYS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSJXXYS.TabIndex = 19;
            this.txtQSJXXYS.Text = "";   
            // 
            // lblQSJXXYS
            // 
            this.lblQSJXXYS.AutoSize = true;
            this.lblQSJXXYS.Location = new System.Drawing.Point(10, 339);
            this.lblQSJXXYS.Name = "lblQSJXXYS";
            this.lblQSJXXYS.Size = new System.Drawing.Size(65, 12);
            this.lblQSJXXYS.TabIndex = 20;
            this.lblQSJXXYS.Text = "权属界线协议书";
            // 
            // txtQSZYYYSBH
            // 
            this.txtQSZYYYSBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSZYYYSBH.EnableTouchMode = true;
            this.txtQSZYYYSBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSZYYYSBH.Location = new System.Drawing.Point(100, 370);
            this.txtQSZYYYSBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSZYYYSBH.Name = "txtQSZYYYSBH";           
            this.txtQSZYYYSBH.Size = new System.Drawing.Size(152, 21);
            this.txtQSZYYYSBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSZYYYSBH.TabIndex = 21;
            this.txtQSZYYYSBH.Text = "";   
            // 
            // lblQSZYYYSBH
            // 
            this.lblQSZYYYSBH.AutoSize = true;
            this.lblQSZYYYSBH.Location = new System.Drawing.Point(10, 374);
            this.lblQSZYYYSBH.Name = "lblQSZYYYSBH";
            this.lblQSZYYYSBH.Size = new System.Drawing.Size(65, 12);
            this.lblQSZYYYSBH.TabIndex = 22;
            this.lblQSZYYYSBH.Text = "权属争议原由书编号";
            // 
            // txtQSZYYYS
            // 
            this.txtQSZYYYS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSZYYYS.EnableTouchMode = true;
            this.txtQSZYYYS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSZYYYS.Location = new System.Drawing.Point(100, 405);
            this.txtQSZYYYS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSZYYYS.Name = "txtQSZYYYS";           
            this.txtQSZYYYS.Size = new System.Drawing.Size(152, 21);
            this.txtQSZYYYS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSZYYYS.TabIndex = 23;
            this.txtQSZYYYS.Text = "";   
            // 
            // lblQSZYYYS
            // 
            this.lblQSZYYYS.AutoSize = true;
            this.lblQSZYYYS.Location = new System.Drawing.Point(10, 409);
            this.lblQSZYYYS.Name = "lblQSZYYYS";
            this.lblQSZYYYS.Size = new System.Drawing.Size(65, 12);
            this.lblQSZYYYS.TabIndex = 24;
            this.lblQSZYYYS.Text = "权属争议原由书";
            // 
            // txtQSJZDBH
            // 
            this.txtQSJZDBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSJZDBH.EnableTouchMode = true;
            this.txtQSJZDBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSJZDBH.Location = new System.Drawing.Point(100, 755);
            this.txtQSJZDBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSJZDBH.Name = "txtQSJZDBH";           
            this.txtQSJZDBH.Size = new System.Drawing.Size(152, 21);
            this.txtQSJZDBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSJZDBH.TabIndex = 43;
            this.txtQSJZDBH.Text = "";   
            // 
            // lblQSJZDBH
            // 
            this.lblQSJZDBH.AutoSize = true;
            this.lblQSJZDBH.Location = new System.Drawing.Point(10, 759);
            this.lblQSJZDBH.Name = "lblQSJZDBH";
            this.lblQSJZDBH.Size = new System.Drawing.Size(65, 12);
            this.lblQSJZDBH.TabIndex = 44;
            this.lblQSJZDBH.Text = "QSJZDBH";
            // 
            // txtJZJZDBH
            // 
            this.txtJZJZDBH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtJZJZDBH.EnableTouchMode = true;
            this.txtJZJZDBH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtJZJZDBH.Location = new System.Drawing.Point(100, 790);
            this.txtJZJZDBH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJZJZDBH.Name = "txtJZJZDBH";           
            this.txtJZJZDBH.Size = new System.Drawing.Size(152, 21);
            this.txtJZJZDBH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJZJZDBH.TabIndex = 45;
            this.txtJZJZDBH.Text = "";   
            // 
            // lblJZJZDBH
            // 
            this.lblJZJZDBH.AutoSize = true;
            this.lblJZJZDBH.Location = new System.Drawing.Point(10, 794);
            this.lblJZJZDBH.Name = "lblJZJZDBH";
            this.lblJZJZDBH.Size = new System.Drawing.Size(65, 12);
            this.lblJZJZDBH.TabIndex = 46;
            this.lblJZJZDBH.Text = "JZJZDBH";
            
            // 
            // ucJZX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZDZHDM);                
            this.Controls.Add(this.lblZDZHDM);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtJZXGZBH);                
            this.Controls.Add(this.lblJZXGZBH);            
            this.Controls.Add(this.dblJZXCD);                
            this.Controls.Add(this.lblJZXCD);            
            this.Controls.Add(this.cmbJZXLB);                
            this.Controls.Add(this.lblJZXLB);            
            this.Controls.Add(this.cmbJZXWZ);                
            this.Controls.Add(this.lblJZXWZ);            
            this.Controls.Add(this.cmbJXXZ);                
            this.Controls.Add(this.lblJXXZ);            
            this.Controls.Add(this.txtQSJXXYSBH);                
            this.Controls.Add(this.lblQSJXXYSBH);            
            this.Controls.Add(this.txtQSJXXYS);                
            this.Controls.Add(this.lblQSJXXYS);            
            this.Controls.Add(this.txtQSZYYYSBH);                
            this.Controls.Add(this.lblQSZYYYSBH);            
            this.Controls.Add(this.txtQSZYYYS);                
            this.Controls.Add(this.lblQSZYYYS);            
            this.Controls.Add(this.txtQSJZDBH);                
            this.Controls.Add(this.lblQSJZDBH);            
            this.Controls.Add(this.txtJZJZDBH);                
            this.Controls.Add(this.lblJZJZDBH);            
            this.Name = "ucJZX";
            this.Size = new System.Drawing.Size(260, 520);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDZHDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZXGZBH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZXCD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJZXLB)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJZXWZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXXZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJXXYSBH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJXXYS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSZYYYSBH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSZYYYS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSJZDBH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJZJZDBH)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDZHDM; 
        private System.Windows.Forms.Label lblZDZHDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJZXGZBH; 
        private System.Windows.Forms.Label lblJZXGZBH; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJZXCD; 
        private System.Windows.Forms.Label lblJZXCD; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJZXLB; 
        private System.Windows.Forms.Label lblJZXLB; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJZXWZ; 
        private System.Windows.Forms.Label lblJZXWZ; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJXXZ; 
        private System.Windows.Forms.Label lblJXXZ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSJXXYSBH; 
        private System.Windows.Forms.Label lblQSJXXYSBH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSJXXYS; 
        private System.Windows.Forms.Label lblQSJXXYS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSZYYYSBH; 
        private System.Windows.Forms.Label lblQSZYYYSBH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSZYYYS; 
        private System.Windows.Forms.Label lblQSZYYYS; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSJZDBH; 
        private System.Windows.Forms.Label lblQSJZDBH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJZJZDBH; 
        private System.Windows.Forms.Label lblJZJZDBH; 
    }

}