namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmAssignEditFeature
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.ucFeatureListSingle1 = new VastGIS.Plugins.RealEstate.DataControls.ucFeatureListSingle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnEdit.EnableTouchMode = true;
            this.btnEdit.IsBackStageButton = false;
            this.btnEdit.Location = new System.Drawing.Point(12, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "编辑要素";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.EnableTouchMode = true;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(130, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucFeatureListSingle1
            // 
            this.ucFeatureListSingle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFeatureListSingle1.Location = new System.Drawing.Point(0, 0);
            this.ucFeatureListSingle1.Name = "ucFeatureListSingle1";
            this.ucFeatureListSingle1.Size = new System.Drawing.Size(273, 294);
            this.ucFeatureListSingle1.TabIndex = 1;
            // 
            // frmAssignEditFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(273, 351);
            this.Controls.Add(this.ucFeatureListSingle1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAssignEditFeature";
            this.Text = "要素编辑器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAssignEditFeature_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv btnEdit;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private DataControls.ucFeatureListSingle ucFeatureListSingle1;
    }
}