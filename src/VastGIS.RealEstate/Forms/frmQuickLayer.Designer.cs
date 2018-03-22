namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmQuickLayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLayerSettings = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnOpenAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCloseAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCancel = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayerSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "作业环境选择：";
            // 
            // cmbLayerSettings
            // 
            this.cmbLayerSettings.BeforeTouchSize = new System.Drawing.Size(206, 20);
            this.cmbLayerSettings.EnableTouchMode = true;
            this.cmbLayerSettings.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbLayerSettings.Location = new System.Drawing.Point(97, 5);
            this.cmbLayerSettings.Name = "cmbLayerSettings";
            this.cmbLayerSettings.Size = new System.Drawing.Size(230, 26);
            this.cmbLayerSettings.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图层组：";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 60);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(232, 180);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOpenAll.IsBackStageButton = false;
            this.btnOpenAll.Location = new System.Drawing.Point(252, 60);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAll.TabIndex = 4;
            this.btnOpenAll.Text = "全部打开";
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCloseAll.IsBackStageButton = false;
            this.btnCloseAll.Location = new System.Drawing.Point(252, 89);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAll.TabIndex = 5;
            this.btnCloseAll.Text = "全部关闭";
            // 
            // btnOK
            // 
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(138, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确认";
            // 
            // btnCancel
            // 
            this.btnCancel.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCancel.IsBackStageButton = false;
            this.btnCancel.Location = new System.Drawing.Point(252, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            // 
            // frmQuickLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 294);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnOpenAll);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLayerSettings);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuickLayer";
            this.Text = "图层快速开关";
            ((System.ComponentModel.ISupportInitialize)(this.cmbLayerSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbLayerSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Syncfusion.Windows.Forms.ButtonAdv btnOpenAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnCloseAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private Syncfusion.Windows.Forms.ButtonAdv btnCancel;
    }
}