using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucDJQ
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
            this.txtDJQDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDJQDM = new System.Windows.Forms.Label();
            this.txtDJQMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDJQMC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJQDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJQMC)).BeginInit();           
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
            // txtDJQDM
            // 
            this.txtDJQDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDJQDM.EnableTouchMode = true;
            this.txtDJQDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDJQDM.Location = new System.Drawing.Point(100, 90);
            this.txtDJQDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDJQDM.Name = "txtDJQDM";           
            this.txtDJQDM.Size = new System.Drawing.Size(152, 21);
            this.txtDJQDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDJQDM.TabIndex = 5;
            this.txtDJQDM.Text = "";   
            // 
            // lblDJQDM
            // 
            this.lblDJQDM.AutoSize = true;
            this.lblDJQDM.Location = new System.Drawing.Point(10, 94);
            this.lblDJQDM.Name = "lblDJQDM";
            this.lblDJQDM.Size = new System.Drawing.Size(65, 12);
            this.lblDJQDM.TabIndex = 6;
            this.lblDJQDM.Text = "地籍区代码";
            // 
            // txtDJQMC
            // 
            this.txtDJQMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDJQMC.EnableTouchMode = true;
            this.txtDJQMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDJQMC.Location = new System.Drawing.Point(100, 125);
            this.txtDJQMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDJQMC.Name = "txtDJQMC";           
            this.txtDJQMC.Size = new System.Drawing.Size(152, 21);
            this.txtDJQMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDJQMC.TabIndex = 7;
            this.txtDJQMC.Text = "";   
            // 
            // lblDJQMC
            // 
            this.lblDJQMC.AutoSize = true;
            this.lblDJQMC.Location = new System.Drawing.Point(10, 129);
            this.lblDJQMC.Name = "lblDJQMC";
            this.lblDJQMC.Size = new System.Drawing.Size(65, 12);
            this.lblDJQMC.TabIndex = 8;
            this.lblDJQMC.Text = "地籍区名称";
            
            // 
            // ucDJQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtDJQDM);                
            this.Controls.Add(this.lblDJQDM);            
            this.Controls.Add(this.txtDJQMC);                
            this.Controls.Add(this.lblDJQMC);            
            this.Name = "ucDJQ";
            this.Size = new System.Drawing.Size(260, 170);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJQDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDJQMC)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDJQDM; 
        private System.Windows.Forms.Label lblDJQDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDJQMC; 
        private System.Windows.Forms.Label lblDJQMC; 
    }

}