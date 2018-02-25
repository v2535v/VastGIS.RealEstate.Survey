using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucXZQJX
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
            this.cmbJXLX = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJXLX = new System.Windows.Forms.Label();
            this.cmbJXXZ = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblJXXZ = new System.Windows.Forms.Label();
            this.txtJXSM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblJXSM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXXZ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJXSM)).BeginInit();           
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
            this.lblID.Text = "标识码";
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
            // cmbJXLX
            // 
            this.cmbJXLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbJXLX.EnableTouchMode = true;
            this.cmbJXLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbJXLX.Location = new System.Drawing.Point(100, 90);
            this.cmbJXLX.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJXLX.Name = "cmbJXLX";           
            this.cmbJXLX.Size = new System.Drawing.Size(152, 21);
            this.cmbJXLX.TabIndex = 5;
            // 
            // lblJXLX
            // 
            this.lblJXLX.AutoSize = true;
            this.lblJXLX.Location = new System.Drawing.Point(10, 94);
            this.lblJXLX.Name = "lblJXLX";
            this.lblJXLX.Size = new System.Drawing.Size(65, 12);
            this.lblJXLX.TabIndex = 6;
            this.lblJXLX.Text = "界线类型";
            // 
            // cmbJXXZ
            // 
            this.cmbJXXZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbJXXZ.EnableTouchMode = true;
            this.cmbJXXZ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbJXXZ.Location = new System.Drawing.Point(100, 125);
            this.cmbJXXZ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJXXZ.Name = "cmbJXXZ";           
            this.cmbJXXZ.Size = new System.Drawing.Size(152, 21);
            this.cmbJXXZ.TabIndex = 7;
            // 
            // lblJXXZ
            // 
            this.lblJXXZ.AutoSize = true;
            this.lblJXXZ.Location = new System.Drawing.Point(10, 129);
            this.lblJXXZ.Name = "lblJXXZ";
            this.lblJXXZ.Size = new System.Drawing.Size(65, 12);
            this.lblJXXZ.TabIndex = 8;
            this.lblJXXZ.Text = "界线性质";
            // 
            // txtJXSM
            // 
            this.txtJXSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtJXSM.EnableTouchMode = true;
            this.txtJXSM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtJXSM.Location = new System.Drawing.Point(100, 160);
            this.txtJXSM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtJXSM.Name = "txtJXSM";           
            this.txtJXSM.Size = new System.Drawing.Size(152, 21);
            this.txtJXSM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtJXSM.TabIndex = 9;
            this.txtJXSM.Text = "";   
            // 
            // lblJXSM
            // 
            this.lblJXSM.AutoSize = true;
            this.lblJXSM.Location = new System.Drawing.Point(10, 164);
            this.lblJXSM.Name = "lblJXSM";
            this.lblJXSM.Size = new System.Drawing.Size(65, 12);
            this.lblJXSM.TabIndex = 10;
            this.lblJXSM.Text = "界线说明";
            
            // 
            // ucXZQJX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.cmbJXLX);                
            this.Controls.Add(this.lblJXLX);            
            this.Controls.Add(this.cmbJXXZ);                
            this.Controls.Add(this.lblJXXZ);            
            this.Controls.Add(this.txtJXSM);                
            this.Controls.Add(this.lblJXSM);            
            this.Name = "ucXZQJX";
            this.Size = new System.Drawing.Size(260, 205);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbJXXZ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtJXSM)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJXLX; 
        private System.Windows.Forms.Label lblJXLX; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbJXXZ; 
        private System.Windows.Forms.Label lblJXXZ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtJXSM; 
        private System.Windows.Forms.Label lblJXSM; 
    }

}