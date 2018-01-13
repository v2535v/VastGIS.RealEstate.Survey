using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucBasemapText
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
            this.txtWBNR = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblWBNR = new System.Windows.Forms.Label();
            this.txtTC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtCASSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCASSDM = new System.Windows.Forms.Label();
            this.txtFH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFH = new System.Windows.Forms.Label();
            this.dblFHDX = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblFHDX = new System.Windows.Forms.Label();
            this.dblXZJD = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblXZJD = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWBNR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXZJD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();
            this.SuspendLayout();
            // 
            // intID
            // 
            this.intID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intID.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intID.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intID.EnableTouchMode = true;
            this.intID.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intID.IntegerValue = ((long)(0));
            this.intID.Location = new System.Drawing.Point(100, 20);
            this.intID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intID.Name = "intID";
            this.intID.NullString = "";
            this.intID.Size = new System.Drawing.Size(152, 28);
            this.intID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intID.TabIndex = 1;
            this.intID.Text = "0";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(10, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 12);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "标识码";
            // 
            // txtWBNR
            // 
            this.txtWBNR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWBNR.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtWBNR.EnableTouchMode = true;
            this.txtWBNR.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWBNR.Location = new System.Drawing.Point(100, 55);
            this.txtWBNR.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtWBNR.Name = "txtWBNR";
            this.txtWBNR.Size = new System.Drawing.Size(152, 28);
            this.txtWBNR.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtWBNR.TabIndex = 3;
            // 
            // lblWBNR
            // 
            this.lblWBNR.AutoSize = true;
            this.lblWBNR.Location = new System.Drawing.Point(10, 59);
            this.lblWBNR.Name = "lblWBNR";
            this.lblWBNR.Size = new System.Drawing.Size(53, 12);
            this.lblWBNR.TabIndex = 4;
            this.lblWBNR.Text = "文本内容";
            // 
            // txtTC
            // 
            this.txtTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTC.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTC.EnableTouchMode = true;
            this.txtTC.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTC.Location = new System.Drawing.Point(100, 123);
            this.txtTC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(152, 28);
            this.txtTC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTC.TabIndex = 5;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(10, 127);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(29, 12);
            this.lblTC.TabIndex = 6;
            this.lblTC.Text = "图层";
            // 
            // txtCASSDM
            // 
            this.txtCASSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCASSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCASSDM.EnableTouchMode = true;
            this.txtCASSDM.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCASSDM.Location = new System.Drawing.Point(100, 158);
            this.txtCASSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASSDM.Name = "txtCASSDM";
            this.txtCASSDM.Size = new System.Drawing.Size(152, 28);
            this.txtCASSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASSDM.TabIndex = 7;
            // 
            // lblCASSDM
            // 
            this.lblCASSDM.AutoSize = true;
            this.lblCASSDM.Location = new System.Drawing.Point(10, 162);
            this.lblCASSDM.Name = "lblCASSDM";
            this.lblCASSDM.Size = new System.Drawing.Size(53, 12);
            this.lblCASSDM.TabIndex = 8;
            this.lblCASSDM.Text = "CASS代码";
            // 
            // txtFH
            // 
            this.txtFH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFH.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFH.EnableTouchMode = true;
            this.txtFH.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFH.Location = new System.Drawing.Point(100, 193);
            this.txtFH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFH.Name = "txtFH";
            this.txtFH.Size = new System.Drawing.Size(152, 28);
            this.txtFH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFH.TabIndex = 9;
            // 
            // lblFH
            // 
            this.lblFH.AutoSize = true;
            this.lblFH.Location = new System.Drawing.Point(10, 197);
            this.lblFH.Name = "lblFH";
            this.lblFH.Size = new System.Drawing.Size(29, 12);
            this.lblFH.TabIndex = 10;
            this.lblFH.Text = "符号";
            // 
            // dblFHDX
            // 
            this.dblFHDX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dblFHDX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblFHDX.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblFHDX.DoubleValue = 1D;
            this.dblFHDX.EnableTouchMode = true;
            this.dblFHDX.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblFHDX.Location = new System.Drawing.Point(100, 228);
            this.dblFHDX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblFHDX.Name = "dblFHDX";
            this.dblFHDX.NullString = "";
            this.dblFHDX.Size = new System.Drawing.Size(152, 28);
            this.dblFHDX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblFHDX.TabIndex = 11;
            this.dblFHDX.Text = "1.00";
            // 
            // lblFHDX
            // 
            this.lblFHDX.AutoSize = true;
            this.lblFHDX.Location = new System.Drawing.Point(10, 232);
            this.lblFHDX.Name = "lblFHDX";
            this.lblFHDX.Size = new System.Drawing.Size(53, 12);
            this.lblFHDX.TabIndex = 12;
            this.lblFHDX.Text = "符号大小";
            // 
            // dblXZJD
            // 
            this.dblXZJD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dblXZJD.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXZJD.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.dblXZJD.DoubleValue = 1D;
            this.dblXZJD.EnableTouchMode = true;
            this.dblXZJD.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dblXZJD.Location = new System.Drawing.Point(100, 263);
            this.dblXZJD.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXZJD.Name = "dblXZJD";
            this.dblXZJD.NullString = "";
            this.dblXZJD.Size = new System.Drawing.Size(152, 28);
            this.dblXZJD.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXZJD.TabIndex = 13;
            this.dblXZJD.Text = "1.00";
            // 
            // lblXZJD
            // 
            this.lblXZJD.AutoSize = true;
            this.lblXZJD.Location = new System.Drawing.Point(10, 267);
            this.lblXZJD.Name = "lblXZJD";
            this.lblXZJD.Size = new System.Drawing.Size(53, 12);
            this.lblXZJD.TabIndex = 14;
            this.lblXZJD.Text = "旋转角度";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYSDM.Location = new System.Drawing.Point(100, 89);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";
            this.txtYSDM.Size = new System.Drawing.Size(152, 28);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 15;
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 93);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(53, 12);
            this.lblYSDM.TabIndex = 16;
            this.lblYSDM.Text = "要素代码";
            // 
            // ucBasemapText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtWBNR);
            this.Controls.Add(this.lblWBNR);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtCASSDM);
            this.Controls.Add(this.lblCASSDM);
            this.Controls.Add(this.txtFH);
            this.Controls.Add(this.lblFH);
            this.Controls.Add(this.dblFHDX);
            this.Controls.Add(this.lblFHDX);
            this.Controls.Add(this.dblXZJD);
            this.Controls.Add(this.lblXZJD);
            this.Controls.Add(this.txtYSDM);
            this.Controls.Add(this.lblYSDM);
            this.Name = "ucBasemapText";
            this.Size = new System.Drawing.Size(260, 304);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWBNR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblFHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblXZJD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtWBNR; 
        private System.Windows.Forms.Label lblWBNR; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTC; 
        private System.Windows.Forms.Label lblTC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCASSDM; 
        private System.Windows.Forms.Label lblCASSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFH; 
        private System.Windows.Forms.Label lblFH; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblFHDX; 
        private System.Windows.Forms.Label lblFHDX; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXZJD; 
        private System.Windows.Forms.Label lblXZJD; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
    }

}