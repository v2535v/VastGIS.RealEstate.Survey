using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZDJBXX
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
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            this.txtZDDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDDM = new System.Windows.Forms.Label();
            this.txtBDCDYH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBDCDYH = new System.Windows.Forms.Label();
            this.cmbZDTZM = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZDTZM = new System.Windows.Forms.Label();
            this.txtZL = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZL = new System.Windows.Forms.Label();
            this.dblZDMJ = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblZDMJ = new System.Windows.Forms.Label();
            this.cmbMJDW = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblMJDW = new System.Windows.Forms.Label();
            this.txtYT = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYT = new System.Windows.Forms.Label();
            this.cmbDJ = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblDJ = new System.Windows.Forms.Label();
            this.dblJG = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJG = new System.Windows.Forms.Label();
            this.cmbQLLX = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQLLX = new System.Windows.Forms.Label();
            this.cmbQLXZ = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQLXZ = new System.Windows.Forms.Label();
            this.cmbQLSDFS = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblQLSDFS = new System.Windows.Forms.Label();
            this.dblRJL = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblRJL = new System.Windows.Forms.Label();
            this.dblJZMD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJZMD = new System.Windows.Forms.Label();
            this.dblJZXG = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblJZXG = new System.Windows.Forms.Label();
            this.txtZDSZD = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSZD = new System.Windows.Forms.Label();
            this.txtZDSZN = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSZN = new System.Windows.Forms.Label();
            this.txtZDSZX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSZX = new System.Windows.Forms.Label();
            this.txtZDSZB = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDSZB = new System.Windows.Forms.Label();
            this.txtZDT = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDT = new System.Windows.Forms.Label();
            this.txtTFH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTFH = new System.Windows.Forms.Label();
            this.txtDJH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDJH = new System.Windows.Forms.Label();
            this.txtDAH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDAH = new System.Windows.Forms.Label();
            this.txtBZ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBZ = new System.Windows.Forms.Label();
            this.cmbZT = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblZT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBDCDYH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbZDTZM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZL)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZDMJ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbMJDW)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYT)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbDJ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJG)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLXZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLSDFS)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblRJL)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZMD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZXG)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZD)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZN)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZB)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDT)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTFH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDAH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbZT)).BeginInit();           
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
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSDM.Location = new System.Drawing.Point(100, 55);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";           
            this.txtYSDM.Size = new System.Drawing.Size(152, 21);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 3;
            this.txtYSDM.Text = "";   
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 59);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(65, 12);
            this.lblYSDM.TabIndex = 4;
            this.lblYSDM.Text = "要素代码";
            // 
            // txtZDDM
            // 
            this.txtZDDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDDM.EnableTouchMode = true;
            this.txtZDDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDDM.Location = new System.Drawing.Point(100, 90);
            this.txtZDDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDDM.Name = "txtZDDM";           
            this.txtZDDM.Size = new System.Drawing.Size(152, 21);
            this.txtZDDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDDM.TabIndex = 5;
            this.txtZDDM.Text = "";   
            // 
            // lblZDDM
            // 
            this.lblZDDM.AutoSize = true;
            this.lblZDDM.Location = new System.Drawing.Point(10, 94);
            this.lblZDDM.Name = "lblZDDM";
            this.lblZDDM.Size = new System.Drawing.Size(65, 12);
            this.lblZDDM.TabIndex = 6;
            this.lblZDDM.Text = "宗地代码";
            // 
            // txtBDCDYH
            // 
            this.txtBDCDYH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBDCDYH.EnableTouchMode = true;
            this.txtBDCDYH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBDCDYH.Location = new System.Drawing.Point(100, 125);
            this.txtBDCDYH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBDCDYH.Name = "txtBDCDYH";           
            this.txtBDCDYH.Size = new System.Drawing.Size(152, 21);
            this.txtBDCDYH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBDCDYH.TabIndex = 7;
            this.txtBDCDYH.Text = "";   
            // 
            // lblBDCDYH
            // 
            this.lblBDCDYH.AutoSize = true;
            this.lblBDCDYH.Location = new System.Drawing.Point(10, 129);
            this.lblBDCDYH.Name = "lblBDCDYH";
            this.lblBDCDYH.Size = new System.Drawing.Size(65, 12);
            this.lblBDCDYH.TabIndex = 8;
            this.lblBDCDYH.Text = "不动产单元号";
            // 
            // cmbZDTZM
            // 
            this.cmbZDTZM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbZDTZM.EnableTouchMode = true;
            this.cmbZDTZM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbZDTZM.Location = new System.Drawing.Point(100, 160);
            this.cmbZDTZM.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZDTZM.Name = "cmbZDTZM";           
            this.cmbZDTZM.Size = new System.Drawing.Size(152, 21);
            this.cmbZDTZM.TabIndex = 9;
            // 
            // lblZDTZM
            // 
            this.lblZDTZM.AutoSize = true;
            this.lblZDTZM.Location = new System.Drawing.Point(10, 164);
            this.lblZDTZM.Name = "lblZDTZM";
            this.lblZDTZM.Size = new System.Drawing.Size(65, 12);
            this.lblZDTZM.TabIndex = 10;
            this.lblZDTZM.Text = "宗地特征码";
            // 
            // txtZL
            // 
            this.txtZL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZL.EnableTouchMode = true;
            this.txtZL.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZL.Location = new System.Drawing.Point(100, 195);
            this.txtZL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZL.Name = "txtZL";           
            this.txtZL.Size = new System.Drawing.Size(152, 21);
            this.txtZL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZL.TabIndex = 11;
            this.txtZL.Text = "";   
            // 
            // lblZL
            // 
            this.lblZL.AutoSize = true;
            this.lblZL.Location = new System.Drawing.Point(10, 199);
            this.lblZL.Name = "lblZL";
            this.lblZL.Size = new System.Drawing.Size(65, 12);
            this.lblZL.TabIndex = 12;
            this.lblZL.Text = "坐落";
            // 
            // dblZDMJ
            // 
            this.dblZDMJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblZDMJ.EnableTouchMode = true;
            this.dblZDMJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblZDMJ.Location = new System.Drawing.Point(100, 230);
            this.dblZDMJ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblZDMJ.Name = "dblZDMJ";           
            this.dblZDMJ.Size = new System.Drawing.Size(152, 21);
            this.dblZDMJ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblZDMJ.TabIndex = 13;
            this.dblZDMJ.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblZDMJ.Text = "1.00";
            this.dblZDMJ.DoubleValue = 1D;
            this.dblZDMJ.NullString = "";
            // 
            // lblZDMJ
            // 
            this.lblZDMJ.AutoSize = true;
            this.lblZDMJ.Location = new System.Drawing.Point(10, 234);
            this.lblZDMJ.Name = "lblZDMJ";
            this.lblZDMJ.Size = new System.Drawing.Size(65, 12);
            this.lblZDMJ.TabIndex = 14;
            this.lblZDMJ.Text = "宗地面积";
            // 
            // cmbMJDW
            // 
            this.cmbMJDW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbMJDW.EnableTouchMode = true;
            this.cmbMJDW.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbMJDW.Location = new System.Drawing.Point(100, 265);
            this.cmbMJDW.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMJDW.Name = "cmbMJDW";           
            this.cmbMJDW.Size = new System.Drawing.Size(152, 21);
            this.cmbMJDW.TabIndex = 15;
            // 
            // lblMJDW
            // 
            this.lblMJDW.AutoSize = true;
            this.lblMJDW.Location = new System.Drawing.Point(10, 269);
            this.lblMJDW.Name = "lblMJDW";
            this.lblMJDW.Size = new System.Drawing.Size(65, 12);
            this.lblMJDW.TabIndex = 16;
            this.lblMJDW.Text = "面积单位";
            // 
            // txtYT
            // 
            this.txtYT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYT.EnableTouchMode = true;
            this.txtYT.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYT.Location = new System.Drawing.Point(100, 300);
            this.txtYT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYT.Name = "txtYT";           
            this.txtYT.Size = new System.Drawing.Size(152, 21);
            this.txtYT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYT.TabIndex = 17;
            this.txtYT.Text = "";   
            // 
            // lblYT
            // 
            this.lblYT.AutoSize = true;
            this.lblYT.Location = new System.Drawing.Point(10, 304);
            this.lblYT.Name = "lblYT";
            this.lblYT.Size = new System.Drawing.Size(65, 12);
            this.lblYT.TabIndex = 18;
            this.lblYT.Text = "用途";
            // 
            // cmbDJ
            // 
            this.cmbDJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbDJ.EnableTouchMode = true;
            this.cmbDJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbDJ.Location = new System.Drawing.Point(100, 335);
            this.cmbDJ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbDJ.Name = "cmbDJ";           
            this.cmbDJ.Size = new System.Drawing.Size(152, 21);
            this.cmbDJ.TabIndex = 19;
            // 
            // lblDJ
            // 
            this.lblDJ.AutoSize = true;
            this.lblDJ.Location = new System.Drawing.Point(10, 339);
            this.lblDJ.Name = "lblDJ";
            this.lblDJ.Size = new System.Drawing.Size(65, 12);
            this.lblDJ.TabIndex = 20;
            this.lblDJ.Text = "等级";
            // 
            // dblJG
            // 
            this.dblJG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblJG.EnableTouchMode = true;
            this.dblJG.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblJG.Location = new System.Drawing.Point(100, 370);
            this.dblJG.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJG.Name = "dblJG";           
            this.dblJG.Size = new System.Drawing.Size(152, 21);
            this.dblJG.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJG.TabIndex = 21;
            this.dblJG.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJG.Text = "1.00";
            this.dblJG.DoubleValue = 1D;
            this.dblJG.NullString = "";
            // 
            // lblJG
            // 
            this.lblJG.AutoSize = true;
            this.lblJG.Location = new System.Drawing.Point(10, 374);
            this.lblJG.Name = "lblJG";
            this.lblJG.Size = new System.Drawing.Size(65, 12);
            this.lblJG.TabIndex = 22;
            this.lblJG.Text = "价格";
            // 
            // cmbQLLX
            // 
            this.cmbQLLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbQLLX.EnableTouchMode = true;
            this.cmbQLLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbQLLX.Location = new System.Drawing.Point(100, 405);
            this.cmbQLLX.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQLLX.Name = "cmbQLLX";           
            this.cmbQLLX.Size = new System.Drawing.Size(152, 21);
            this.cmbQLLX.TabIndex = 23;
            // 
            // lblQLLX
            // 
            this.lblQLLX.AutoSize = true;
            this.lblQLLX.Location = new System.Drawing.Point(10, 409);
            this.lblQLLX.Name = "lblQLLX";
            this.lblQLLX.Size = new System.Drawing.Size(65, 12);
            this.lblQLLX.TabIndex = 24;
            this.lblQLLX.Text = "权利类型";
            // 
            // cmbQLXZ
            // 
            this.cmbQLXZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbQLXZ.EnableTouchMode = true;
            this.cmbQLXZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbQLXZ.Location = new System.Drawing.Point(100, 440);
            this.cmbQLXZ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQLXZ.Name = "cmbQLXZ";           
            this.cmbQLXZ.Size = new System.Drawing.Size(152, 21);
            this.cmbQLXZ.TabIndex = 25;
            // 
            // lblQLXZ
            // 
            this.lblQLXZ.AutoSize = true;
            this.lblQLXZ.Location = new System.Drawing.Point(10, 444);
            this.lblQLXZ.Name = "lblQLXZ";
            this.lblQLXZ.Size = new System.Drawing.Size(65, 12);
            this.lblQLXZ.TabIndex = 26;
            this.lblQLXZ.Text = "权利性质";
            // 
            // cmbQLSDFS
            // 
            this.cmbQLSDFS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbQLSDFS.EnableTouchMode = true;
            this.cmbQLSDFS.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbQLSDFS.Location = new System.Drawing.Point(100, 475);
            this.cmbQLSDFS.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbQLSDFS.Name = "cmbQLSDFS";           
            this.cmbQLSDFS.Size = new System.Drawing.Size(152, 21);
            this.cmbQLSDFS.TabIndex = 27;
            // 
            // lblQLSDFS
            // 
            this.lblQLSDFS.AutoSize = true;
            this.lblQLSDFS.Location = new System.Drawing.Point(10, 479);
            this.lblQLSDFS.Name = "lblQLSDFS";
            this.lblQLSDFS.Size = new System.Drawing.Size(65, 12);
            this.lblQLSDFS.TabIndex = 28;
            this.lblQLSDFS.Text = "权利设定方式";
            // 
            // dblRJL
            // 
            this.dblRJL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblRJL.EnableTouchMode = true;
            this.dblRJL.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblRJL.Location = new System.Drawing.Point(100, 510);
            this.dblRJL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblRJL.Name = "dblRJL";           
            this.dblRJL.Size = new System.Drawing.Size(152, 21);
            this.dblRJL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblRJL.TabIndex = 29;
            this.dblRJL.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblRJL.Text = "1.00";
            this.dblRJL.DoubleValue = 1D;
            this.dblRJL.NullString = "";
            // 
            // lblRJL
            // 
            this.lblRJL.AutoSize = true;
            this.lblRJL.Location = new System.Drawing.Point(10, 514);
            this.lblRJL.Name = "lblRJL";
            this.lblRJL.Size = new System.Drawing.Size(65, 12);
            this.lblRJL.TabIndex = 30;
            this.lblRJL.Text = "容积率";
            // 
            // dblJZMD
            // 
            this.dblJZMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblJZMD.EnableTouchMode = true;
            this.dblJZMD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblJZMD.Location = new System.Drawing.Point(100, 545);
            this.dblJZMD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJZMD.Name = "dblJZMD";           
            this.dblJZMD.Size = new System.Drawing.Size(152, 21);
            this.dblJZMD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJZMD.TabIndex = 31;
            this.dblJZMD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJZMD.Text = "1.00";
            this.dblJZMD.DoubleValue = 1D;
            this.dblJZMD.NullString = "";
            // 
            // lblJZMD
            // 
            this.lblJZMD.AutoSize = true;
            this.lblJZMD.Location = new System.Drawing.Point(10, 549);
            this.lblJZMD.Name = "lblJZMD";
            this.lblJZMD.Size = new System.Drawing.Size(65, 12);
            this.lblJZMD.TabIndex = 32;
            this.lblJZMD.Text = "建筑密度";
            // 
            // dblJZXG
            // 
            this.dblJZXG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblJZXG.EnableTouchMode = true;
            this.dblJZXG.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblJZXG.Location = new System.Drawing.Point(100, 580);
            this.dblJZXG.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblJZXG.Name = "dblJZXG";           
            this.dblJZXG.Size = new System.Drawing.Size(152, 21);
            this.dblJZXG.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblJZXG.TabIndex = 33;
            this.dblJZXG.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblJZXG.Text = "1.00";
            this.dblJZXG.DoubleValue = 1D;
            this.dblJZXG.NullString = "";
            // 
            // lblJZXG
            // 
            this.lblJZXG.AutoSize = true;
            this.lblJZXG.Location = new System.Drawing.Point(10, 584);
            this.lblJZXG.Name = "lblJZXG";
            this.lblJZXG.Size = new System.Drawing.Size(65, 12);
            this.lblJZXG.TabIndex = 34;
            this.lblJZXG.Text = "建筑限高";
            // 
            // txtZDSZD
            // 
            this.txtZDSZD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSZD.EnableTouchMode = true;
            this.txtZDSZD.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSZD.Location = new System.Drawing.Point(100, 615);
            this.txtZDSZD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSZD.Name = "txtZDSZD";           
            this.txtZDSZD.Size = new System.Drawing.Size(152, 21);
            this.txtZDSZD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSZD.TabIndex = 35;
            this.txtZDSZD.Text = "";   
            // 
            // lblZDSZD
            // 
            this.lblZDSZD.AutoSize = true;
            this.lblZDSZD.Location = new System.Drawing.Point(10, 619);
            this.lblZDSZD.Name = "lblZDSZD";
            this.lblZDSZD.Size = new System.Drawing.Size(65, 12);
            this.lblZDSZD.TabIndex = 36;
            this.lblZDSZD.Text = "宗地四至-东";
            // 
            // txtZDSZN
            // 
            this.txtZDSZN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSZN.EnableTouchMode = true;
            this.txtZDSZN.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSZN.Location = new System.Drawing.Point(100, 650);
            this.txtZDSZN.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSZN.Name = "txtZDSZN";           
            this.txtZDSZN.Size = new System.Drawing.Size(152, 21);
            this.txtZDSZN.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSZN.TabIndex = 37;
            this.txtZDSZN.Text = "";   
            // 
            // lblZDSZN
            // 
            this.lblZDSZN.AutoSize = true;
            this.lblZDSZN.Location = new System.Drawing.Point(10, 654);
            this.lblZDSZN.Name = "lblZDSZN";
            this.lblZDSZN.Size = new System.Drawing.Size(65, 12);
            this.lblZDSZN.TabIndex = 38;
            this.lblZDSZN.Text = "宗地四至-南";
            // 
            // txtZDSZX
            // 
            this.txtZDSZX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSZX.EnableTouchMode = true;
            this.txtZDSZX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSZX.Location = new System.Drawing.Point(100, 685);
            this.txtZDSZX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSZX.Name = "txtZDSZX";           
            this.txtZDSZX.Size = new System.Drawing.Size(152, 21);
            this.txtZDSZX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSZX.TabIndex = 39;
            this.txtZDSZX.Text = "";   
            // 
            // lblZDSZX
            // 
            this.lblZDSZX.AutoSize = true;
            this.lblZDSZX.Location = new System.Drawing.Point(10, 689);
            this.lblZDSZX.Name = "lblZDSZX";
            this.lblZDSZX.Size = new System.Drawing.Size(65, 12);
            this.lblZDSZX.TabIndex = 40;
            this.lblZDSZX.Text = "宗地四至-西";
            // 
            // txtZDSZB
            // 
            this.txtZDSZB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDSZB.EnableTouchMode = true;
            this.txtZDSZB.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDSZB.Location = new System.Drawing.Point(100, 720);
            this.txtZDSZB.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDSZB.Name = "txtZDSZB";           
            this.txtZDSZB.Size = new System.Drawing.Size(152, 21);
            this.txtZDSZB.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDSZB.TabIndex = 41;
            this.txtZDSZB.Text = "";   
            // 
            // lblZDSZB
            // 
            this.lblZDSZB.AutoSize = true;
            this.lblZDSZB.Location = new System.Drawing.Point(10, 724);
            this.lblZDSZB.Name = "lblZDSZB";
            this.lblZDSZB.Size = new System.Drawing.Size(65, 12);
            this.lblZDSZB.TabIndex = 42;
            this.lblZDSZB.Text = "宗地四至-北";
            // 
            // txtZDT
            // 
            this.txtZDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDT.EnableTouchMode = true;
            this.txtZDT.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDT.Location = new System.Drawing.Point(100, 755);
            this.txtZDT.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDT.Name = "txtZDT";           
            this.txtZDT.Size = new System.Drawing.Size(152, 21);
            this.txtZDT.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDT.TabIndex = 43;
            this.txtZDT.Text = "";   
            // 
            // lblZDT
            // 
            this.lblZDT.AutoSize = true;
            this.lblZDT.Location = new System.Drawing.Point(10, 759);
            this.lblZDT.Name = "lblZDT";
            this.lblZDT.Size = new System.Drawing.Size(65, 12);
            this.lblZDT.TabIndex = 44;
            this.lblZDT.Text = "宗地图";
            // 
            // txtTFH
            // 
            this.txtTFH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTFH.EnableTouchMode = true;
            this.txtTFH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTFH.Location = new System.Drawing.Point(100, 790);
            this.txtTFH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTFH.Name = "txtTFH";           
            this.txtTFH.Size = new System.Drawing.Size(152, 21);
            this.txtTFH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTFH.TabIndex = 45;
            this.txtTFH.Text = "";   
            // 
            // lblTFH
            // 
            this.lblTFH.AutoSize = true;
            this.lblTFH.Location = new System.Drawing.Point(10, 794);
            this.lblTFH.Name = "lblTFH";
            this.lblTFH.Size = new System.Drawing.Size(65, 12);
            this.lblTFH.TabIndex = 46;
            this.lblTFH.Text = "图幅号";
            // 
            // txtDJH
            // 
            this.txtDJH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDJH.EnableTouchMode = true;
            this.txtDJH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDJH.Location = new System.Drawing.Point(100, 825);
            this.txtDJH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDJH.Name = "txtDJH";           
            this.txtDJH.Size = new System.Drawing.Size(152, 21);
            this.txtDJH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDJH.TabIndex = 47;
            this.txtDJH.Text = "";   
            // 
            // lblDJH
            // 
            this.lblDJH.AutoSize = true;
            this.lblDJH.Location = new System.Drawing.Point(10, 829);
            this.lblDJH.Name = "lblDJH";
            this.lblDJH.Size = new System.Drawing.Size(65, 12);
            this.lblDJH.TabIndex = 48;
            this.lblDJH.Text = "地籍号";
            // 
            // txtDAH
            // 
            this.txtDAH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDAH.EnableTouchMode = true;
            this.txtDAH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDAH.Location = new System.Drawing.Point(100, 860);
            this.txtDAH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDAH.Name = "txtDAH";           
            this.txtDAH.Size = new System.Drawing.Size(152, 21);
            this.txtDAH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDAH.TabIndex = 49;
            this.txtDAH.Text = "";   
            // 
            // lblDAH
            // 
            this.lblDAH.AutoSize = true;
            this.lblDAH.Location = new System.Drawing.Point(10, 864);
            this.lblDAH.Name = "lblDAH";
            this.lblDAH.Size = new System.Drawing.Size(65, 12);
            this.lblDAH.TabIndex = 50;
            this.lblDAH.Text = "档案号";
            // 
            // txtBZ
            // 
            this.txtBZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBZ.EnableTouchMode = true;
            this.txtBZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBZ.Location = new System.Drawing.Point(100, 895);
            this.txtBZ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBZ.Name = "txtBZ";           
            this.txtBZ.Size = new System.Drawing.Size(152, 21);
            this.txtBZ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBZ.TabIndex = 51;
            this.txtBZ.Text = "";   
            // 
            // lblBZ
            // 
            this.lblBZ.AutoSize = true;
            this.lblBZ.Location = new System.Drawing.Point(10, 899);
            this.lblBZ.Name = "lblBZ";
            this.lblBZ.Size = new System.Drawing.Size(65, 12);
            this.lblBZ.TabIndex = 52;
            this.lblBZ.Text = "备注";
            // 
            // cmbZT
            // 
            this.cmbZT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbZT.EnableTouchMode = true;
            this.cmbZT.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbZT.Location = new System.Drawing.Point(100, 930);
            this.cmbZT.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZT.Name = "cmbZT";           
            this.cmbZT.Size = new System.Drawing.Size(152, 21);
            this.cmbZT.TabIndex = 53;
            // 
            // lblZT
            // 
            this.lblZT.AutoSize = true;
            this.lblZT.Location = new System.Drawing.Point(10, 934);
            this.lblZT.Name = "lblZT";
            this.lblZT.Size = new System.Drawing.Size(65, 12);
            this.lblZT.TabIndex = 54;
            this.lblZT.Text = "状态";
            
            // 
            // ucZDJBXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtZDDM);                
            this.Controls.Add(this.lblZDDM);            
            this.Controls.Add(this.txtBDCDYH);                
            this.Controls.Add(this.lblBDCDYH);            
            this.Controls.Add(this.cmbZDTZM);                
            this.Controls.Add(this.lblZDTZM);            
            this.Controls.Add(this.txtZL);                
            this.Controls.Add(this.lblZL);            
            this.Controls.Add(this.dblZDMJ);                
            this.Controls.Add(this.lblZDMJ);            
            this.Controls.Add(this.cmbMJDW);                
            this.Controls.Add(this.lblMJDW);            
            this.Controls.Add(this.txtYT);                
            this.Controls.Add(this.lblYT);            
            this.Controls.Add(this.cmbDJ);                
            this.Controls.Add(this.lblDJ);            
            this.Controls.Add(this.dblJG);                
            this.Controls.Add(this.lblJG);            
            this.Controls.Add(this.cmbQLLX);                
            this.Controls.Add(this.lblQLLX);            
            this.Controls.Add(this.cmbQLXZ);                
            this.Controls.Add(this.lblQLXZ);            
            this.Controls.Add(this.cmbQLSDFS);                
            this.Controls.Add(this.lblQLSDFS);            
            this.Controls.Add(this.dblRJL);                
            this.Controls.Add(this.lblRJL);            
            this.Controls.Add(this.dblJZMD);                
            this.Controls.Add(this.lblJZMD);            
            this.Controls.Add(this.dblJZXG);                
            this.Controls.Add(this.lblJZXG);            
            this.Controls.Add(this.txtZDSZD);                
            this.Controls.Add(this.lblZDSZD);            
            this.Controls.Add(this.txtZDSZN);                
            this.Controls.Add(this.lblZDSZN);            
            this.Controls.Add(this.txtZDSZX);                
            this.Controls.Add(this.lblZDSZX);            
            this.Controls.Add(this.txtZDSZB);                
            this.Controls.Add(this.lblZDSZB);            
            this.Controls.Add(this.txtZDT);                
            this.Controls.Add(this.lblZDT);            
            this.Controls.Add(this.txtTFH);                
            this.Controls.Add(this.lblTFH);            
            this.Controls.Add(this.txtDJH);                
            this.Controls.Add(this.lblDJH);            
            this.Controls.Add(this.txtDAH);                
            this.Controls.Add(this.lblDAH);            
            this.Controls.Add(this.txtBZ);                
            this.Controls.Add(this.lblBZ);            
            this.Controls.Add(this.cmbZT);                
            this.Controls.Add(this.lblZT);            
            this.Name = "ucZDJBXX";
            this.Size = new System.Drawing.Size(260, 975);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBDCDYH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbZDTZM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZL)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblZDMJ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbMJDW)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYT)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbDJ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJG)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLXZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbQLSDFS)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblRJL)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZMD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblJZXG)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZD)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZN)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDSZB)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDT)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTFH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDAH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbZT)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDDM; 
        private System.Windows.Forms.Label lblZDDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBDCDYH; 
        private System.Windows.Forms.Label lblBDCDYH; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZDTZM; 
        private System.Windows.Forms.Label lblZDTZM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZL; 
        private System.Windows.Forms.Label lblZL; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblZDMJ; 
        private System.Windows.Forms.Label lblZDMJ; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbMJDW; 
        private System.Windows.Forms.Label lblMJDW; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYT; 
        private System.Windows.Forms.Label lblYT; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbDJ; 
        private System.Windows.Forms.Label lblDJ; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJG; 
        private System.Windows.Forms.Label lblJG; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQLLX; 
        private System.Windows.Forms.Label lblQLLX; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQLXZ; 
        private System.Windows.Forms.Label lblQLXZ; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbQLSDFS; 
        private System.Windows.Forms.Label lblQLSDFS; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblRJL; 
        private System.Windows.Forms.Label lblRJL; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJZMD; 
        private System.Windows.Forms.Label lblJZMD; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblJZXG; 
        private System.Windows.Forms.Label lblJZXG; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSZD; 
        private System.Windows.Forms.Label lblZDSZD; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSZN; 
        private System.Windows.Forms.Label lblZDSZN; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSZX; 
        private System.Windows.Forms.Label lblZDSZX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDSZB; 
        private System.Windows.Forms.Label lblZDSZB; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDT; 
        private System.Windows.Forms.Label lblZDT; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTFH; 
        private System.Windows.Forms.Label lblTFH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDJH; 
        private System.Windows.Forms.Label lblDJH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDAH; 
        private System.Windows.Forms.Label lblDAH; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBZ; 
        private System.Windows.Forms.Label lblBZ; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbZT; 
        private System.Windows.Forms.Label lblZT; 
    }

}