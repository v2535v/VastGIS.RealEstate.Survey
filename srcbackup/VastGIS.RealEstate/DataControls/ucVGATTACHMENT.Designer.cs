using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucVGATTACHMENT
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
            this.txtFJMC = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFJMC = new System.Windows.Forms.Label();
            this.txtFJLJ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFJLJ = new System.Windows.Forms.Label();
            this.cmbFJLX = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.lblFJLX = new System.Windows.Forms.Label();
            this.datHQSJ = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblHQSJ = new System.Windows.Forms.Label();
            this.txtFJSM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFJSM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJMC)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJLJ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbFJLX)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.datHQSJ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJSM)).BeginInit();           
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
            // txtFJMC
            // 
            this.txtFJMC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFJMC.EnableTouchMode = true;
            this.txtFJMC.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFJMC.Location = new System.Drawing.Point(100, 90);
            this.txtFJMC.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFJMC.Name = "txtFJMC";           
            this.txtFJMC.Size = new System.Drawing.Size(152, 21);
            this.txtFJMC.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFJMC.TabIndex = 5;
            this.txtFJMC.Text = "";   
            // 
            // lblFJMC
            // 
            this.lblFJMC.AutoSize = true;
            this.lblFJMC.Location = new System.Drawing.Point(10, 94);
            this.lblFJMC.Name = "lblFJMC";
            this.lblFJMC.Size = new System.Drawing.Size(65, 12);
            this.lblFJMC.TabIndex = 6;
            this.lblFJMC.Text = "附件名称";
            // 
            // txtFJLJ
            // 
            this.txtFJLJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFJLJ.EnableTouchMode = true;
            this.txtFJLJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFJLJ.Location = new System.Drawing.Point(100, 125);
            this.txtFJLJ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFJLJ.Name = "txtFJLJ";           
            this.txtFJLJ.Size = new System.Drawing.Size(152, 21);
            this.txtFJLJ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFJLJ.TabIndex = 7;
            this.txtFJLJ.Text = "";   
            // 
            // lblFJLJ
            // 
            this.lblFJLJ.AutoSize = true;
            this.lblFJLJ.Location = new System.Drawing.Point(10, 129);
            this.lblFJLJ.Name = "lblFJLJ";
            this.lblFJLJ.Size = new System.Drawing.Size(65, 12);
            this.lblFJLJ.TabIndex = 8;
            this.lblFJLJ.Text = "附件路径";
            // 
            // cmbFJLX
            // 
            this.cmbFJLX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.cmbFJLX.EnableTouchMode = true;
            this.cmbFJLX.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.cmbFJLX.Location = new System.Drawing.Point(100, 160);
            this.cmbFJLX.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbFJLX.Name = "cmbFJLX";           
            this.cmbFJLX.Size = new System.Drawing.Size(152, 21);
            this.cmbFJLX.TabIndex = 9;
            // 
            // lblFJLX
            // 
            this.lblFJLX.AutoSize = true;
            this.lblFJLX.Location = new System.Drawing.Point(10, 164);
            this.lblFJLX.Name = "lblFJLX";
            this.lblFJLX.Size = new System.Drawing.Size(65, 12);
            this.lblFJLX.TabIndex = 10;
            this.lblFJLX.Text = "附件类型";
            // 
            // datHQSJ
            // 
            this.datHQSJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.datHQSJ.EnableTouchMode = true;
            this.datHQSJ.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.datHQSJ.BorderColor = System.Drawing.Color.Empty;
            this.datHQSJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datHQSJ.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.datHQSJ.CalendarSize = new System.Drawing.Size(189, 176);
            this.datHQSJ.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.datHQSJ.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.datHQSJ.DropDownImage = null;             
            this.datHQSJ.Location = new System.Drawing.Point(100, 195);
            this.datHQSJ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datHQSJ.Name = "datHQSJ";           
            this.datHQSJ.Size = new System.Drawing.Size(152, 21);
            this.datHQSJ.TabIndex = 11;
            this.datHQSJ.ShowCheckBox = false;
            this.datHQSJ.UseCurrentCulture = true;
            this.datHQSJ.Value = new System.DateTime(2018, 1, 11, 17, 7, 50, 851);
            this.datHQSJ.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datHQSJ.MinValue = new System.DateTime(((long)(0)));
            // 
            // lblHQSJ
            // 
            this.lblHQSJ.AutoSize = true;
            this.lblHQSJ.Location = new System.Drawing.Point(10, 199);
            this.lblHQSJ.Name = "lblHQSJ";
            this.lblHQSJ.Size = new System.Drawing.Size(65, 12);
            this.lblHQSJ.TabIndex = 12;
            this.lblHQSJ.Text = "获取时间";
            // 
            // txtFJSM
            // 
            this.txtFJSM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFJSM.EnableTouchMode = true;
            this.txtFJSM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFJSM.Location = new System.Drawing.Point(100, 230);
            this.txtFJSM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFJSM.Name = "txtFJSM";           
            this.txtFJSM.Size = new System.Drawing.Size(152, 21);
            this.txtFJSM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFJSM.TabIndex = 13;
            this.txtFJSM.Text = "";   
            // 
            // lblFJSM
            // 
            this.lblFJSM.AutoSize = true;
            this.lblFJSM.Location = new System.Drawing.Point(10, 234);
            this.lblFJSM.Name = "lblFJSM";
            this.lblFJSM.Size = new System.Drawing.Size(65, 12);
            this.lblFJSM.TabIndex = 14;
            this.lblFJSM.Text = "附件说明";
            
            // 
            // ucVG_ATTACHMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtFJMC);                
            this.Controls.Add(this.lblFJMC);            
            this.Controls.Add(this.txtFJLJ);                
            this.Controls.Add(this.lblFJLJ);            
            this.Controls.Add(this.cmbFJLX);                
            this.Controls.Add(this.lblFJLX);            
            this.Controls.Add(this.datHQSJ);                
            this.Controls.Add(this.lblHQSJ);            
            this.Controls.Add(this.txtFJSM);                
            this.Controls.Add(this.lblFJSM);            
            this.Name = "ucVG_ATTACHMENT";
            this.Size = new System.Drawing.Size(260, 240);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJMC)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJLJ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.cmbFJLX)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.datHQSJ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJSM)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFJMC; 
        private System.Windows.Forms.Label lblFJMC; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFJLJ; 
        private System.Windows.Forms.Label lblFJLJ; 
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbFJLX; 
        private System.Windows.Forms.Label lblFJLX; 
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datHQSJ; 
        private System.Windows.Forms.Label lblHQSJ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFJSM; 
        private System.Windows.Forms.Label lblFJSM; 
    }

}