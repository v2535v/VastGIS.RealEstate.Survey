using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucZDBHQK
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
            this.txtZDDM = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblZDDM = new System.Windows.Forms.Label();
            this.txtBHYY = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBHYY = new System.Windows.Forms.Label();
            this.txtBHNR = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblBHNR = new System.Windows.Forms.Label();
            this.datDJSJ = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.lblDJSJ = new System.Windows.Forms.Label();
            this.txtDBR = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblDBR = new System.Windows.Forms.Label();
            this.txtFJ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblFJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intID)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDDM)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBHYY)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBHNR)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.datDJSJ)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDBR)).BeginInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJ)).BeginInit();           
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
            // txtZDDM
            // 
            this.txtZDDM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtZDDM.EnableTouchMode = true;
            this.txtZDDM.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtZDDM.Location = new System.Drawing.Point(100, 55);
            this.txtZDDM.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtZDDM.Name = "txtZDDM";           
            this.txtZDDM.Size = new System.Drawing.Size(152, 21);
            this.txtZDDM.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtZDDM.TabIndex = 3;
            this.txtZDDM.Text = "";   
            // 
            // lblZDDM
            // 
            this.lblZDDM.AutoSize = true;
            this.lblZDDM.Location = new System.Drawing.Point(10, 59);
            this.lblZDDM.Name = "lblZDDM";
            this.lblZDDM.Size = new System.Drawing.Size(65, 12);
            this.lblZDDM.TabIndex = 4;
            this.lblZDDM.Text = "宗地代码";
            // 
            // txtBHYY
            // 
            this.txtBHYY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBHYY.EnableTouchMode = true;
            this.txtBHYY.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBHYY.Location = new System.Drawing.Point(100, 90);
            this.txtBHYY.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBHYY.Name = "txtBHYY";           
            this.txtBHYY.Size = new System.Drawing.Size(152, 21);
            this.txtBHYY.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBHYY.TabIndex = 5;
            this.txtBHYY.Text = "";   
            // 
            // lblBHYY
            // 
            this.lblBHYY.AutoSize = true;
            this.lblBHYY.Location = new System.Drawing.Point(10, 94);
            this.lblBHYY.Name = "lblBHYY";
            this.lblBHYY.Size = new System.Drawing.Size(65, 12);
            this.lblBHYY.TabIndex = 6;
            this.lblBHYY.Text = "变化原因";
            // 
            // txtBHNR
            // 
            this.txtBHNR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtBHNR.EnableTouchMode = true;
            this.txtBHNR.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtBHNR.Location = new System.Drawing.Point(100, 125);
            this.txtBHNR.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtBHNR.Name = "txtBHNR";           
            this.txtBHNR.Size = new System.Drawing.Size(152, 21);
            this.txtBHNR.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtBHNR.TabIndex = 7;
            this.txtBHNR.Text = "";   
            // 
            // lblBHNR
            // 
            this.lblBHNR.AutoSize = true;
            this.lblBHNR.Location = new System.Drawing.Point(10, 129);
            this.lblBHNR.Name = "lblBHNR";
            this.lblBHNR.Size = new System.Drawing.Size(65, 12);
            this.lblBHNR.TabIndex = 8;
            this.lblBHNR.Text = "变化内容";
            // 
            // datDJSJ
            // 
            this.datDJSJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.datDJSJ.EnableTouchMode = true;
            this.datDJSJ.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.datDJSJ.BorderColor = System.Drawing.Color.Empty;
            this.datDJSJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.datDJSJ.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.datDJSJ.CalendarSize = new System.Drawing.Size(189, 176);
            this.datDJSJ.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.datDJSJ.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.datDJSJ.DropDownImage = null;             
            this.datDJSJ.Location = new System.Drawing.Point(100, 160);
            this.datDJSJ.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datDJSJ.Name = "datDJSJ";           
            this.datDJSJ.Size = new System.Drawing.Size(152, 21);
            this.datDJSJ.TabIndex = 9;
            this.datDJSJ.ShowCheckBox = false;
            this.datDJSJ.UseCurrentCulture = true;
            this.datDJSJ.Value = new System.DateTime(2018, 1, 11, 17, 7, 50, 851);
            this.datDJSJ.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.datDJSJ.MinValue = new System.DateTime(((long)(0)));
            // 
            // lblDJSJ
            // 
            this.lblDJSJ.AutoSize = true;
            this.lblDJSJ.Location = new System.Drawing.Point(10, 164);
            this.lblDJSJ.Name = "lblDJSJ";
            this.lblDJSJ.Size = new System.Drawing.Size(65, 12);
            this.lblDJSJ.TabIndex = 10;
            this.lblDJSJ.Text = "登记时间";
            // 
            // txtDBR
            // 
            this.txtDBR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtDBR.EnableTouchMode = true;
            this.txtDBR.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtDBR.Location = new System.Drawing.Point(100, 195);
            this.txtDBR.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDBR.Name = "txtDBR";           
            this.txtDBR.Size = new System.Drawing.Size(152, 21);
            this.txtDBR.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDBR.TabIndex = 11;
            this.txtDBR.Text = "";   
            // 
            // lblDBR
            // 
            this.lblDBR.AutoSize = true;
            this.lblDBR.Location = new System.Drawing.Point(10, 199);
            this.lblDBR.Name = "lblDBR";
            this.lblDBR.Size = new System.Drawing.Size(65, 12);
            this.lblDBR.TabIndex = 12;
            this.lblDBR.Text = "登簿人";
            // 
            // txtFJ
            // 
            this.txtFJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));  
            this.txtFJ.EnableTouchMode = true;
            this.txtFJ.BeforeTouchSize = new System.Drawing.Size(152, 21);   
            this.txtFJ.Location = new System.Drawing.Point(100, 230);
            this.txtFJ.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtFJ.Name = "txtFJ";           
            this.txtFJ.Size = new System.Drawing.Size(152, 21);
            this.txtFJ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtFJ.TabIndex = 13;
            this.txtFJ.Text = "";   
            // 
            // lblFJ
            // 
            this.lblFJ.AutoSize = true;
            this.lblFJ.Location = new System.Drawing.Point(10, 234);
            this.lblFJ.Name = "lblFJ";
            this.lblFJ.Size = new System.Drawing.Size(65, 12);
            this.lblFJ.TabIndex = 14;
            this.lblFJ.Text = "附记";
            
            // 
            // ucZDBHQK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intID);                
            this.Controls.Add(this.lblID);            
            this.Controls.Add(this.txtZDDM);                
            this.Controls.Add(this.lblZDDM);            
            this.Controls.Add(this.txtBHYY);                
            this.Controls.Add(this.lblBHYY);            
            this.Controls.Add(this.txtBHNR);                
            this.Controls.Add(this.lblBHNR);            
            this.Controls.Add(this.datDJSJ);                
            this.Controls.Add(this.lblDJSJ);            
            this.Controls.Add(this.txtDBR);                
            this.Controls.Add(this.lblDBR);            
            this.Controls.Add(this.txtFJ);                
            this.Controls.Add(this.lblFJ);            
            this.Name = "ucZDBHQK";
            this.Size = new System.Drawing.Size(260, 275);
            
            ((System.ComponentModel.ISupportInitialize)(this.intID)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtZDDM)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBHYY)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtBHNR)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.datDJSJ)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtDBR)).EndInit();           
            ((System.ComponentModel.ISupportInitialize)(this.txtFJ)).EndInit();           
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intID; 
        private System.Windows.Forms.Label lblID; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtZDDM; 
        private System.Windows.Forms.Label lblZDDM; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBHYY; 
        private System.Windows.Forms.Label lblBHYY; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBHNR; 
        private System.Windows.Forms.Label lblBHNR; 
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv datDJSJ; 
        private System.Windows.Forms.Label lblDJSJ; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDBR; 
        private System.Windows.Forms.Label lblDBR; 
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFJ; 
        private System.Windows.Forms.Label lblFJ; 
    }

}