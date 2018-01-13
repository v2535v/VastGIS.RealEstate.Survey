using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucXZQ
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
            this.txtXZQDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXZQDM = new System.Windows.Forms.Label();
            this.txtXZQMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXZQMC = new System.Windows.Forms.Label();
            this.dblXZQMJ = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.lblXZQMJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblXZQMJ)).BeginInit();           
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
            // txtXZQDM
            // 
            this.txtXZQDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXZQDM.EnableTouchMode = true;
            this.txtXZQDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXZQDM.Location = new System.Drawing.Point(100, 90);
            this.txtXZQDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXZQDM.Name = "txtXZQDM";           
            this.txtXZQDM.Size = new System.Drawing.Size(152, 21);
            this.txtXZQDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXZQDM.TabIndex = 5;
            this.txtXZQDM.Text = "";   
            // 
            // lblXZQDM
            // 
            this.lblXZQDM.AutoSize = true;
            this.lblXZQDM.Location = new System.Drawing.Point(10, 94);
            this.lblXZQDM.Name = "lblXZQDM";
            this.lblXZQDM.Size = new System.Drawing.Size(65, 12);
            this.lblXZQDM.TabIndex = 6;
            this.lblXZQDM.Text = "行政区代码";
            // 
            // txtXZQMC
            // 
            this.txtXZQMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXZQMC.EnableTouchMode = true;
            this.txtXZQMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXZQMC.Location = new System.Drawing.Point(100, 125);
            this.txtXZQMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXZQMC.Name = "txtXZQMC";           
            this.txtXZQMC.Size = new System.Drawing.Size(152, 21);
            this.txtXZQMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXZQMC.TabIndex = 7;
            this.txtXZQMC.Text = "";   
            // 
            // lblXZQMC
            // 
            this.lblXZQMC.AutoSize = true;
            this.lblXZQMC.Location = new System.Drawing.Point(10, 129);
            this.lblXZQMC.Name = "lblXZQMC";
            this.lblXZQMC.Size = new System.Drawing.Size(65, 12);
            this.lblXZQMC.TabIndex = 8;
            this.lblXZQMC.Text = "行政区名称";
            // 
            // dblXZQMJ
            // 
            this.dblXZQMJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.dblXZQMJ.EnableTouchMode = true;
            this.dblXZQMJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.dblXZQMJ.Location = new System.Drawing.Point(100, 160);
            this.dblXZQMJ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.dblXZQMJ.Name = "dblXZQMJ";           
            this.dblXZQMJ.Size = new System.Drawing.Size(152, 21);
            this.dblXZQMJ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.dblXZQMJ.TabIndex = 9;
            this.dblXZQMJ.BackGroundColor = System.Drawing.SystemColors.Window;
            this.dblXZQMJ.Text = "1.00";
            this.dblXZQMJ.DoubleValue = 1D;
            this.dblXZQMJ.NullString = "";
            // 
            // lblXZQMJ
            // 
            this.lblXZQMJ.AutoSize = true;
            this.lblXZQMJ.Location = new System.Drawing.Point(10, 164);
            this.lblXZQMJ.Name = "lblXZQMJ";
            this.lblXZQMJ.Size = new System.Drawing.Size(65, 12);
            this.lblXZQMJ.TabIndex = 10;
            this.lblXZQMJ.Text = "行政区面积";
            
            // 
            // ucXZQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtXZQDM);                
            this.Controls.Add(this.lblXZQDM);            
            this.Controls.Add(this.txtXZQMC);                
            this.Controls.Add(this.lblXZQMC);            
            this.Controls.Add(this.dblXZQMJ);                
            this.Controls.Add(this.lblXZQMJ);            
            this.Name = "ucXZQ";
            this.Size = new System.Drawing.Size(260, 205);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXZQMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.dblXZQMJ)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXZQDM; 
        private System.Windows.Forms.Label lblXZQDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXZQMC; 
        private System.Windows.Forms.Label lblXZQMC; 
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox dblXZQMJ; 
        private System.Windows.Forms.Label lblXZQMJ; 
    }

}