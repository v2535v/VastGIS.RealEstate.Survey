using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucBasemapPolygon
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
            this.txtTC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtCASSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCASSDM = new System.Windows.Forms.Label();
            this.txtFSXX1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFSXX1 = new System.Windows.Forms.Label();
            this.txtFSXX2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFSXX2 = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX2)).BeginInit();
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
            // txtTC
            // 
            this.txtTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTC.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtTC.EnableTouchMode = true;
            this.txtTC.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTC.Location = new System.Drawing.Point(100, 159);
            this.txtTC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(152, 28);
            this.txtTC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTC.TabIndex = 3;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(10, 163);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(29, 12);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "图层";
            // 
            // txtCASSDM
            // 
            this.txtCASSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCASSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtCASSDM.EnableTouchMode = true;
            this.txtCASSDM.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCASSDM.Location = new System.Drawing.Point(100, 194);
            this.txtCASSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASSDM.Name = "txtCASSDM";
            this.txtCASSDM.Size = new System.Drawing.Size(152, 28);
            this.txtCASSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASSDM.TabIndex = 5;
            // 
            // lblCASSDM
            // 
            this.lblCASSDM.AutoSize = true;
            this.lblCASSDM.Location = new System.Drawing.Point(10, 198);
            this.lblCASSDM.Name = "lblCASSDM";
            this.lblCASSDM.Size = new System.Drawing.Size(53, 12);
            this.lblCASSDM.TabIndex = 6;
            this.lblCASSDM.Text = "CASS代码";
            // 
            // txtFSXX1
            // 
            this.txtFSXX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFSXX1.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFSXX1.EnableTouchMode = true;
            this.txtFSXX1.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFSXX1.Location = new System.Drawing.Point(100, 54);
            this.txtFSXX1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFSXX1.Name = "txtFSXX1";
            this.txtFSXX1.Size = new System.Drawing.Size(152, 28);
            this.txtFSXX1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFSXX1.TabIndex = 7;
            // 
            // lblFSXX1
            // 
            this.lblFSXX1.AutoSize = true;
            this.lblFSXX1.Location = new System.Drawing.Point(10, 58);
            this.lblFSXX1.Name = "lblFSXX1";
            this.lblFSXX1.Size = new System.Drawing.Size(59, 12);
            this.lblFSXX1.TabIndex = 8;
            this.lblFSXX1.Text = "附加属性1";
            // 
            // txtFSXX2
            // 
            this.txtFSXX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFSXX2.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtFSXX2.EnableTouchMode = true;
            this.txtFSXX2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFSXX2.Location = new System.Drawing.Point(100, 89);
            this.txtFSXX2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFSXX2.Name = "txtFSXX2";
            this.txtFSXX2.Size = new System.Drawing.Size(152, 28);
            this.txtFSXX2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFSXX2.TabIndex = 9;
            // 
            // lblFSXX2
            // 
            this.lblFSXX2.AutoSize = true;
            this.lblFSXX2.Location = new System.Drawing.Point(10, 93);
            this.lblFSXX2.Name = "lblFSXX2";
            this.lblFSXX2.Size = new System.Drawing.Size(59, 12);
            this.lblFSXX2.TabIndex = 10;
            this.lblFSXX2.Text = "附加属性2";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYSDM.Location = new System.Drawing.Point(100, 124);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";
            this.txtYSDM.Size = new System.Drawing.Size(152, 28);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 11;
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 128);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(53, 12);
            this.lblYSDM.TabIndex = 12;
            this.lblYSDM.Text = "要素代码";
            // 
            // ucBasemapPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtCASSDM);
            this.Controls.Add(this.lblCASSDM);
            this.Controls.Add(this.txtFSXX1);
            this.Controls.Add(this.lblFSXX1);
            this.Controls.Add(this.txtFSXX2);
            this.Controls.Add(this.lblFSXX2);
            this.Controls.Add(this.txtYSDM);
            this.Controls.Add(this.lblYSDM);
            this.Name = "ucBasemapPolygon";
            this.Size = new System.Drawing.Size(260, 232);
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFSXX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTC; 
        private System.Windows.Forms.Label lblTC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCASSDM; 
        private System.Windows.Forms.Label lblCASSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFSXX1; 
        private System.Windows.Forms.Label lblFSXX1; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFSXX2; 
        private System.Windows.Forms.Label lblFSXX2; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
    }

}