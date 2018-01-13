using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGCADCODES
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
            this.txtXH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXH = new System.Windows.Forms.Label();
            this.intSFCY = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblSFCY = new System.Windows.Forms.Label();
            this.txtTC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtCASSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblCASSDM = new System.Windows.Forms.Label();
            this.txtTXLX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblTXLX = new System.Windows.Forms.Label();
            this.txtXTC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblXTC = new System.Windows.Forms.Label();
            this.txtYSDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSDM = new System.Windows.Forms.Label();
            this.txtYSLX = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSLX = new System.Windows.Forms.Label();
            this.intYSZL = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblYSZL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intSFCY)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXTC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intYSZL)).BeginInit();           
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
            // txtXH
            // 
            this.txtXH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXH.EnableTouchMode = true;
            this.txtXH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXH.Location = new System.Drawing.Point(100, 55);
            this.txtXH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXH.Name = "txtXH";           
            this.txtXH.Size = new System.Drawing.Size(152, 21);
            this.txtXH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXH.TabIndex = 3;
            this.txtXH.Text = "";   
            // 
            // lblXH
            // 
            this.lblXH.AutoSize = true;
            this.lblXH.Location = new System.Drawing.Point(10, 59);
            this.lblXH.Name = "lblXH";
            this.lblXH.Size = new System.Drawing.Size(65, 12);
            this.lblXH.TabIndex = 4;
            this.lblXH.Text = "XH";
            // 
            // intSFCY
            // 
            this.intSFCY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intSFCY.EnableTouchMode = true;
            this.intSFCY.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intSFCY.Location = new System.Drawing.Point(100, 90);
            this.intSFCY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intSFCY.Name = "intSFCY";           
            this.intSFCY.Size = new System.Drawing.Size(152, 21);
            this.intSFCY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intSFCY.TabIndex = 5;
            this.intSFCY.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intSFCY.Text = "1.00";           
            this.intSFCY.NullString = "";
            // 
            // lblSFCY
            // 
            this.lblSFCY.AutoSize = true;
            this.lblSFCY.Location = new System.Drawing.Point(10, 94);
            this.lblSFCY.Name = "lblSFCY";
            this.lblSFCY.Size = new System.Drawing.Size(65, 12);
            this.lblSFCY.TabIndex = 6;
            this.lblSFCY.Text = "SFCY";
            // 
            // txtTC
            // 
            this.txtTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTC.EnableTouchMode = true;
            this.txtTC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTC.Location = new System.Drawing.Point(100, 125);
            this.txtTC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTC.Name = "txtTC";           
            this.txtTC.Size = new System.Drawing.Size(152, 21);
            this.txtTC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTC.TabIndex = 7;
            this.txtTC.Text = "";   
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(10, 129);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(65, 12);
            this.lblTC.TabIndex = 8;
            this.lblTC.Text = "TC";
            // 
            // txtCASSDM
            // 
            this.txtCASSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtCASSDM.EnableTouchMode = true;
            this.txtCASSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtCASSDM.Location = new System.Drawing.Point(100, 160);
            this.txtCASSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtCASSDM.Name = "txtCASSDM";           
            this.txtCASSDM.Size = new System.Drawing.Size(152, 21);
            this.txtCASSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtCASSDM.TabIndex = 9;
            this.txtCASSDM.Text = "";   
            // 
            // lblCASSDM
            // 
            this.lblCASSDM.AutoSize = true;
            this.lblCASSDM.Location = new System.Drawing.Point(10, 164);
            this.lblCASSDM.Name = "lblCASSDM";
            this.lblCASSDM.Size = new System.Drawing.Size(65, 12);
            this.lblCASSDM.TabIndex = 10;
            this.lblCASSDM.Text = "CASSDM";
            // 
            // txtTXLX
            // 
            this.txtTXLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtTXLX.EnableTouchMode = true;
            this.txtTXLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtTXLX.Location = new System.Drawing.Point(100, 195);
            this.txtTXLX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTXLX.Name = "txtTXLX";           
            this.txtTXLX.Size = new System.Drawing.Size(152, 21);
            this.txtTXLX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTXLX.TabIndex = 11;
            this.txtTXLX.Text = "";   
            // 
            // lblTXLX
            // 
            this.lblTXLX.AutoSize = true;
            this.lblTXLX.Location = new System.Drawing.Point(10, 199);
            this.lblTXLX.Name = "lblTXLX";
            this.lblTXLX.Size = new System.Drawing.Size(65, 12);
            this.lblTXLX.TabIndex = 12;
            this.lblTXLX.Text = "TXLX";
            // 
            // txtXTC
            // 
            this.txtXTC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtXTC.EnableTouchMode = true;
            this.txtXTC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtXTC.Location = new System.Drawing.Point(100, 230);
            this.txtXTC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtXTC.Name = "txtXTC";           
            this.txtXTC.Size = new System.Drawing.Size(152, 21);
            this.txtXTC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtXTC.TabIndex = 13;
            this.txtXTC.Text = "";   
            // 
            // lblXTC
            // 
            this.lblXTC.AutoSize = true;
            this.lblXTC.Location = new System.Drawing.Point(10, 234);
            this.lblXTC.Name = "lblXTC";
            this.lblXTC.Size = new System.Drawing.Size(65, 12);
            this.lblXTC.TabIndex = 14;
            this.lblXTC.Text = "XTC";
            // 
            // txtYSDM
            // 
            this.txtYSDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSDM.EnableTouchMode = true;
            this.txtYSDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSDM.Location = new System.Drawing.Point(100, 265);
            this.txtYSDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSDM.Name = "txtYSDM";           
            this.txtYSDM.Size = new System.Drawing.Size(152, 21);
            this.txtYSDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSDM.TabIndex = 15;
            this.txtYSDM.Text = "";   
            // 
            // lblYSDM
            // 
            this.lblYSDM.AutoSize = true;
            this.lblYSDM.Location = new System.Drawing.Point(10, 269);
            this.lblYSDM.Name = "lblYSDM";
            this.lblYSDM.Size = new System.Drawing.Size(65, 12);
            this.lblYSDM.TabIndex = 16;
            this.lblYSDM.Text = "YSDM";
            // 
            // txtYSLX
            // 
            this.txtYSLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSLX.EnableTouchMode = true;
            this.txtYSLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSLX.Location = new System.Drawing.Point(100, 300);
            this.txtYSLX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSLX.Name = "txtYSLX";           
            this.txtYSLX.Size = new System.Drawing.Size(152, 21);
            this.txtYSLX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSLX.TabIndex = 17;
            this.txtYSLX.Text = "";   
            // 
            // lblYSLX
            // 
            this.lblYSLX.AutoSize = true;
            this.lblYSLX.Location = new System.Drawing.Point(10, 304);
            this.lblYSLX.Name = "lblYSLX";
            this.lblYSLX.Size = new System.Drawing.Size(65, 12);
            this.lblYSLX.TabIndex = 18;
            this.lblYSLX.Text = "YSLX";
            // 
            // intYSZL
            // 
            this.intYSZL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intYSZL.EnableTouchMode = true;
            this.intYSZL.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intYSZL.Location = new System.Drawing.Point(100, 335);
            this.intYSZL.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intYSZL.Name = "intYSZL";           
            this.intYSZL.Size = new System.Drawing.Size(152, 21);
            this.intYSZL.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intYSZL.TabIndex = 19;
            this.intYSZL.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intYSZL.Text = "1.00";           
            this.intYSZL.NullString = "";
            // 
            // lblYSZL
            // 
            this.lblYSZL.AutoSize = true;
            this.lblYSZL.Location = new System.Drawing.Point(10, 339);
            this.lblYSZL.Name = "lblYSZL";
            this.lblYSZL.Size = new System.Drawing.Size(65, 12);
            this.lblYSZL.TabIndex = 20;
            this.lblYSZL.Text = "YSZL";
            
            // 
            // ucVG_CADCODES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtXH);                
            this.Controls.Add(this.lblXH);            
            this.Controls.Add(this.intSFCY);                
            this.Controls.Add(this.lblSFCY);            
            this.Controls.Add(this.txtTC);                
            this.Controls.Add(this.lblTC);            
            this.Controls.Add(this.txtCASSDM);                
            this.Controls.Add(this.lblCASSDM);            
            this.Controls.Add(this.txtTXLX);                
            this.Controls.Add(this.lblTXLX);            
            this.Controls.Add(this.txtXTC);                
            this.Controls.Add(this.lblXTC);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtYSLX);                
            this.Controls.Add(this.lblYSLX);            
            this.Controls.Add(this.intYSZL);                
            this.Controls.Add(this.lblYSZL);            
            this.Name = "ucVG_CADCODES";
            this.Size = new System.Drawing.Size(260, 380);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intSFCY)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtCASSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtTXLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtXTC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intYSZL)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXH; 
        private System.Windows.Forms.Label lblXH; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intSFCY; 
        private System.Windows.Forms.Label lblSFCY; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTC; 
        private System.Windows.Forms.Label lblTC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCASSDM; 
        private System.Windows.Forms.Label lblCASSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTXLX; 
        private System.Windows.Forms.Label lblTXLX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtXTC; 
        private System.Windows.Forms.Label lblXTC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSLX; 
        private System.Windows.Forms.Label lblYSLX; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intYSZL; 
        private System.Windows.Forms.Label lblYSZL; 
    }

}