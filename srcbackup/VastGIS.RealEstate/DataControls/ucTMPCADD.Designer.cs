using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucTMPCADD
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
            this.txtENTITYTYPE = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblENTITYTYPE = new System.Windows.Forms.Label();
            this.txtHANDLE = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblHANDLE = new System.Windows.Forms.Label();
            this.txtFILENAME = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFILENAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtENTITYTYPE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtHANDLE)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILENAME)).BeginInit();           
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
            // txtENTITYTYPE
            // 
            this.txtENTITYTYPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtENTITYTYPE.EnableTouchMode = true;
            this.txtENTITYTYPE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtENTITYTYPE.Location = new System.Drawing.Point(100, 55);
            this.txtENTITYTYPE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtENTITYTYPE.Name = "txtENTITYTYPE";           
            this.txtENTITYTYPE.Size = new System.Drawing.Size(152, 21);
            this.txtENTITYTYPE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtENTITYTYPE.TabIndex = 3;
            this.txtENTITYTYPE.Text = "";   
            // 
            // lblENTITYTYPE
            // 
            this.lblENTITYTYPE.AutoSize = true;
            this.lblENTITYTYPE.Location = new System.Drawing.Point(10, 59);
            this.lblENTITYTYPE.Name = "lblENTITYTYPE";
            this.lblENTITYTYPE.Size = new System.Drawing.Size(65, 12);
            this.lblENTITYTYPE.TabIndex = 4;
            this.lblENTITYTYPE.Text = "ENTITYTYPE";
            // 
            // txtHANDLE
            // 
            this.txtHANDLE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtHANDLE.EnableTouchMode = true;
            this.txtHANDLE.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtHANDLE.Location = new System.Drawing.Point(100, 90);
            this.txtHANDLE.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtHANDLE.Name = "txtHANDLE";           
            this.txtHANDLE.Size = new System.Drawing.Size(152, 21);
            this.txtHANDLE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtHANDLE.TabIndex = 5;
            this.txtHANDLE.Text = "";   
            // 
            // lblHANDLE
            // 
            this.lblHANDLE.AutoSize = true;
            this.lblHANDLE.Location = new System.Drawing.Point(10, 94);
            this.lblHANDLE.Name = "lblHANDLE";
            this.lblHANDLE.Size = new System.Drawing.Size(65, 12);
            this.lblHANDLE.TabIndex = 6;
            this.lblHANDLE.Text = "HANDLE";
            // 
            // txtFILENAME
            // 
            this.txtFILENAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFILENAME.EnableTouchMode = true;
            this.txtFILENAME.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFILENAME.Location = new System.Drawing.Point(100, 125);
            this.txtFILENAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFILENAME.Name = "txtFILENAME";           
            this.txtFILENAME.Size = new System.Drawing.Size(152, 21);
            this.txtFILENAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFILENAME.TabIndex = 7;
            this.txtFILENAME.Text = "";   
            // 
            // lblFILENAME
            // 
            this.lblFILENAME.AutoSize = true;
            this.lblFILENAME.Location = new System.Drawing.Point(10, 129);
            this.lblFILENAME.Name = "lblFILENAME";
            this.lblFILENAME.Size = new System.Drawing.Size(65, 12);
            this.lblFILENAME.TabIndex = 8;
            this.lblFILENAME.Text = "FILENAME";
            
            // 
            // ucTMPCADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtENTITYTYPE);                
            this.Controls.Add(this.lblENTITYTYPE);            
            this.Controls.Add(this.txtHANDLE);                
            this.Controls.Add(this.lblHANDLE);            
            this.Controls.Add(this.txtFILENAME);                
            this.Controls.Add(this.lblFILENAME);            
            this.Name = "ucTMPCADD";
            this.Size = new System.Drawing.Size(260, 170);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtENTITYTYPE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtHANDLE)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFILENAME)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtENTITYTYPE; 
        private System.Windows.Forms.Label lblENTITYTYPE; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtHANDLE; 
        private System.Windows.Forms.Label lblHANDLE; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFILENAME; 
        private System.Windows.Forms.Label lblFILENAME; 
    }

}