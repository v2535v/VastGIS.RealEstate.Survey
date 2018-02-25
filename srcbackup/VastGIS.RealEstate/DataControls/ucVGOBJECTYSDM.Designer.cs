using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGOBJECTYSDM
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
            this.txtYSMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblYSMC = new System.Windows.Forms.Label();
            this.intXSSX = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.lblXSSX = new System.Windows.Forms.Label();
            this.txtQSBG = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSBG = new System.Windows.Forms.Label();
            this.txtQSFH = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblQSFH = new System.Windows.Forms.Label();
            this.chkSFKJ = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblSFKJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXSSX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSBG)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSFH)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSFKJ)).BeginInit();           
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
            // txtYSMC
            // 
            this.txtYSMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtYSMC.EnableTouchMode = true;
            this.txtYSMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtYSMC.Location = new System.Drawing.Point(100, 90);
            this.txtYSMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtYSMC.Name = "txtYSMC";           
            this.txtYSMC.Size = new System.Drawing.Size(152, 21);
            this.txtYSMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtYSMC.TabIndex = 5;
            this.txtYSMC.Text = "";   
            // 
            // lblYSMC
            // 
            this.lblYSMC.AutoSize = true;
            this.lblYSMC.Location = new System.Drawing.Point(10, 94);
            this.lblYSMC.Name = "lblYSMC";
            this.lblYSMC.Size = new System.Drawing.Size(65, 12);
            this.lblYSMC.TabIndex = 6;
            this.lblYSMC.Text = "要素名称";
            // 
            // intXSSX
            // 
            this.intXSSX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.intXSSX.EnableTouchMode = true;
            this.intXSSX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.intXSSX.Location = new System.Drawing.Point(100, 125);
            this.intXSSX.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intXSSX.Name = "intXSSX";           
            this.intXSSX.Size = new System.Drawing.Size(152, 21);
            this.intXSSX.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intXSSX.TabIndex = 7;
            this.intXSSX.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intXSSX.Text = "1.00";           
            this.intXSSX.NullString = "";
            // 
            // lblXSSX
            // 
            this.lblXSSX.AutoSize = true;
            this.lblXSSX.Location = new System.Drawing.Point(10, 129);
            this.lblXSSX.Name = "lblXSSX";
            this.lblXSSX.Size = new System.Drawing.Size(65, 12);
            this.lblXSSX.TabIndex = 8;
            this.lblXSSX.Text = "显示顺序";
            // 
            // txtQSBG
            // 
            this.txtQSBG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSBG.EnableTouchMode = true;
            this.txtQSBG.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSBG.Location = new System.Drawing.Point(100, 160);
            this.txtQSBG.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSBG.Name = "txtQSBG";           
            this.txtQSBG.Size = new System.Drawing.Size(152, 21);
            this.txtQSBG.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSBG.TabIndex = 9;
            this.txtQSBG.Text = "";   
            // 
            // lblQSBG
            // 
            this.lblQSBG.AutoSize = true;
            this.lblQSBG.Location = new System.Drawing.Point(10, 164);
            this.lblQSBG.Name = "lblQSBG";
            this.lblQSBG.Size = new System.Drawing.Size(65, 12);
            this.lblQSBG.TabIndex = 10;
            this.lblQSBG.Text = "缺省表格";
            // 
            // txtQSFH
            // 
            this.txtQSFH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtQSFH.EnableTouchMode = true;
            this.txtQSFH.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtQSFH.Location = new System.Drawing.Point(100, 195);
            this.txtQSFH.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtQSFH.Name = "txtQSFH";           
            this.txtQSFH.Size = new System.Drawing.Size(152, 21);
            this.txtQSFH.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtQSFH.TabIndex = 11;
            this.txtQSFH.Text = "";   
            // 
            // lblQSFH
            // 
            this.lblQSFH.AutoSize = true;
            this.lblQSFH.Location = new System.Drawing.Point(10, 199);
            this.lblQSFH.Name = "lblQSFH";
            this.lblQSFH.Size = new System.Drawing.Size(65, 12);
            this.lblQSFH.TabIndex = 12;
            this.lblQSFH.Text = "缺省符号";
            // 
            // chkSFKJ
            // 
            this.chkSFKJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.chkSFKJ.EnableTouchMode = true;
            this.chkSFKJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.chkSFKJ.Location = new System.Drawing.Point(100, 230);
            this.chkSFKJ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSFKJ.Name = "chkSFKJ";           
            this.chkSFKJ.Size = new System.Drawing.Size(152, 21);
            this.chkSFKJ.TabIndex = 13;
            this.chkSFKJ.Text = "";  
            this.chkSFKJ.ThemesEnabled = false;
             this.chkSFKJ.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            // 
            // lblSFKJ
            // 
            this.lblSFKJ.AutoSize = true;
            this.lblSFKJ.Location = new System.Drawing.Point(10, 234);
            this.lblSFKJ.Name = "lblSFKJ";
            this.lblSFKJ.Size = new System.Drawing.Size(65, 12);
            this.lblSFKJ.TabIndex = 14;
            this.lblSFKJ.Text = "是否空间要素";
            
            // 
            // ucVG_OBJECTYSDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtYSDM);                
            this.Controls.Add(this.lblYSDM);            
            this.Controls.Add(this.txtYSMC);                
            this.Controls.Add(this.lblYSMC);            
            this.Controls.Add(this.intXSSX);                
            this.Controls.Add(this.lblXSSX);            
            this.Controls.Add(this.txtQSBG);                
            this.Controls.Add(this.lblQSBG);            
            this.Controls.Add(this.txtQSFH);                
            this.Controls.Add(this.lblQSFH);            
            this.Controls.Add(this.chkSFKJ);                
            this.Controls.Add(this.lblSFKJ);            
            this.Name = "ucVG_OBJECTYSDM";
            this.Size = new System.Drawing.Size(260, 275);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtYSMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.intXSSX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSBG)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtQSFH)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.chkSFKJ)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSDM; 
        private System.Windows.Forms.Label lblYSDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtYSMC; 
        private System.Windows.Forms.Label lblYSMC; 
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intXSSX; 
        private System.Windows.Forms.Label lblXSSX; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSBG; 
        private System.Windows.Forms.Label lblQSBG; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtQSFH; 
        private System.Windows.Forms.Label lblQSFH; 
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkSFKJ; 
        private System.Windows.Forms.Label lblSFKJ; 
    }

}