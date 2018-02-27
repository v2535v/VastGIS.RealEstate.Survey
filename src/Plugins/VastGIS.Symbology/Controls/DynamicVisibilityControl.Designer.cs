namespace VastGIS.Plugins.Symbology.Controls
{
    partial class DynamicVisibilityControl
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.cboMaxZoom = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cboMinZoom = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDynamicScaleMode = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnSetMaxScale = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboMaxScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnSetMinScale = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboMinScale = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkDynamicVisibility = new System.Windows.Forms.CheckBox();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.panel1);
            this.groupBox13.Controls.Add(this.chkDynamicVisibility);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(0, 0);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(228, 189);
            this.groupBox13.TabIndex = 178;
            this.groupBox13.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.cboMaxZoom);
            this.panel1.Controls.Add(this.cboMinZoom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboDynamicScaleMode);
            this.panel1.Controls.Add(this.btnSetMaxScale);
            this.panel1.Controls.Add(this.cboMaxScale);
            this.panel1.Controls.Add(this.btnSetMinScale);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cboMinScale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 169);
            this.panel1.TabIndex = 136;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 20);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(38, 146);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(77, 12);
            this.lblCurrent.TabIndex = 11;
            this.lblCurrent.Text = "当前比例尺: ";
            // 
            // cboMaxZoom
            // 
            this.cboMaxZoom.BeforeTouchSize = new System.Drawing.Size(80, 21);
            this.cboMaxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaxZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMaxZoom.Location = new System.Drawing.Point(82, 127);
            this.cboMaxZoom.Name = "cboMaxZoom";
            this.cboMaxZoom.Size = new System.Drawing.Size(80, 21);
            this.cboMaxZoom.TabIndex = 10;
            // 
            // cboMinZoom
            // 
            this.cboMinZoom.BeforeTouchSize = new System.Drawing.Size(80, 21);
            this.cboMinZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMinZoom.Location = new System.Drawing.Point(82, 79);
            this.cboMinZoom.Name = "cboMinZoom";
            this.cboMinZoom.Size = new System.Drawing.Size(80, 21);
            this.cboMinZoom.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "比例模式:";
            // 
            // cboDynamicScaleMode
            // 
            this.cboDynamicScaleMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDynamicScaleMode.BeforeTouchSize = new System.Drawing.Size(199, 21);
            this.cboDynamicScaleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDynamicScaleMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboDynamicScaleMode.Location = new System.Drawing.Point(11, 26);
            this.cboDynamicScaleMode.Name = "cboDynamicScaleMode";
            this.cboDynamicScaleMode.Size = new System.Drawing.Size(199, 21);
            this.cboDynamicScaleMode.TabIndex = 7;
            this.cboDynamicScaleMode.SelectedIndexChanged += new System.EventHandler(this.cboDynamicScaleMode_SelectedIndexChanged);
            // 
            // btnSetMaxScale
            // 
            this.btnSetMaxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetMaxScale.BeforeTouchSize = new System.Drawing.Size(51, 22);
            this.btnSetMaxScale.IsBackStageButton = false;
            this.btnSetMaxScale.Location = new System.Drawing.Point(159, 114);
            this.btnSetMaxScale.Name = "btnSetMaxScale";
            this.btnSetMaxScale.Size = new System.Drawing.Size(51, 22);
            this.btnSetMaxScale.TabIndex = 5;
            this.btnSetMaxScale.Text = "当前";
            this.btnSetMaxScale.UseVisualStyleBackColor = true;
            this.btnSetMaxScale.Click += new System.EventHandler(this.btnSetMaxScale_Click);
            // 
            // cboMaxScale
            // 
            this.cboMaxScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaxScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMaxScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMaxScale.Location = new System.Drawing.Point(11, 116);
            this.cboMaxScale.Name = "cboMaxScale";
            this.cboMaxScale.Size = new System.Drawing.Size(142, 21);
            this.cboMaxScale.TabIndex = 4;
            // 
            // btnSetMinScale
            // 
            this.btnSetMinScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetMinScale.BeforeTouchSize = new System.Drawing.Size(51, 22);
            this.btnSetMinScale.IsBackStageButton = false;
            this.btnSetMinScale.Location = new System.Drawing.Point(159, 68);
            this.btnSetMinScale.Name = "btnSetMinScale";
            this.btnSetMinScale.Size = new System.Drawing.Size(51, 22);
            this.btnSetMinScale.TabIndex = 6;
            this.btnSetMinScale.Text = "当前";
            this.btnSetMinScale.UseVisualStyleBackColor = true;
            this.btnSetMinScale.Click += new System.EventHandler(this.btnSetMinScale_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "最大显示比例:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "最小显示比例:";
            // 
            // cboMinScale
            // 
            this.cboMinScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMinScale.BeforeTouchSize = new System.Drawing.Size(142, 21);
            this.cboMinScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboMinScale.Location = new System.Drawing.Point(11, 71);
            this.cboMinScale.Name = "cboMinScale";
            this.cboMinScale.Size = new System.Drawing.Size(142, 21);
            this.cboMinScale.TabIndex = 3;
            // 
            // chkDynamicVisibility
            // 
            this.chkDynamicVisibility.AutoSize = true;
            this.chkDynamicVisibility.Location = new System.Drawing.Point(10, 0);
            this.chkDynamicVisibility.Name = "chkDynamicVisibility";
            this.chkDynamicVisibility.Size = new System.Drawing.Size(96, 16);
            this.chkDynamicVisibility.TabIndex = 0;
            this.chkDynamicVisibility.Text = "使用动态显示";
            this.chkDynamicVisibility.UseVisualStyleBackColor = true;
            this.chkDynamicVisibility.CheckedChanged += new System.EventHandler(this.chkDynamicVisibility_CheckedChanged);
            // 
            // DynamicVisibilityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox13);
            this.Name = "DynamicVisibilityControl";
            this.Size = new System.Drawing.Size(228, 189);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDynamicScaleMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMinScale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboDynamicScaleMode;
        private Syncfusion.Windows.Forms.ButtonAdv btnSetMaxScale;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMaxScale;
        private Syncfusion.Windows.Forms.ButtonAdv btnSetMinScale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMinScale;
        private System.Windows.Forms.CheckBox chkDynamicVisibility;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMaxZoom;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboMinZoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrent;
    }
}
