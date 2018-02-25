using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGCLASSGROUP
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
            this.txtGROUPNAME = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblGROUPNAME = new System.Windows.Forms.Label();
            this.chkCREATEIMPL = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblCREATEIMPL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtGROUPNAME)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkCREATEIMPL)).BeginInit();           
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
            // txtGROUPNAME
            // 
            this.txtGROUPNAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtGROUPNAME.EnableTouchMode = true;
            this.txtGROUPNAME.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtGROUPNAME.Location = new System.Drawing.Point(100, 55);
            this.txtGROUPNAME.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtGROUPNAME.Name = "txtGROUPNAME";           
            this.txtGROUPNAME.Size = new System.Drawing.Size(152, 21);
            this.txtGROUPNAME.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtGROUPNAME.TabIndex = 3;
            this.txtGROUPNAME.Text = "";   
            // 
            // lblGROUPNAME
            // 
            this.lblGROUPNAME.AutoSize = true;
            this.lblGROUPNAME.Location = new System.Drawing.Point(10, 59);
            this.lblGROUPNAME.Name = "lblGROUPNAME";
            this.lblGROUPNAME.Size = new System.Drawing.Size(65, 12);
            this.lblGROUPNAME.TabIndex = 4;
            this.lblGROUPNAME.Text = "组名";
            // 
            // chkCREATEIMPL
            // 
            this.chkCREATEIMPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkCREATEIMPL.EnableTouchMode = true;
            this.chkCREATEIMPL.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkCREATEIMPL.Location = new System.Drawing.Point(100, 90);
            this.chkCREATEIMPL.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkCREATEIMPL.Name = "chkCREATEIMPL";           
            this.chkCREATEIMPL.Size = new System.Drawing.Size(152, 21);
            this.chkCREATEIMPL.TabIndex = 5;
            this.chkCREATEIMPL.Text = "";  
            this.chkCREATEIMPL.ThemesEnabled = false;
             this.chkCREATEIMPL.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblCREATEIMPL
            // 
            this.lblCREATEIMPL.AutoSize = true;
            this.lblCREATEIMPL.Location = new System.Drawing.Point(10, 94);
            this.lblCREATEIMPL.Name = "lblCREATEIMPL";
            this.lblCREATEIMPL.Size = new System.Drawing.Size(65, 12);
            this.lblCREATEIMPL.TabIndex = 6;
            this.lblCREATEIMPL.Text = "是否实体";
            
            // 
            // ucVG_CLASSGROUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtGROUPNAME);                
            this.Controls.Add(this.lblGROUPNAME);            
            this.Controls.Add(this.chkCREATEIMPL);                
            this.Controls.Add(this.lblCREATEIMPL);            
            this.Name = "ucVG_CLASSGROUP";
            this.Size = new System.Drawing.Size(260, 135);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtGROUPNAME)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkCREATEIMPL)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtGROUPNAME; 
        private System.Windows.Forms.Label lblGROUPNAME; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkCREATEIMPL; 
        private System.Windows.Forms.Label lblCREATEIMPL; 
    }

}