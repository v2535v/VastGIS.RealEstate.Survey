namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmCameraCapture2
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
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cameraControl = new Camera_NET.CameraControl();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtDesc = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbType = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnRectify = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBoxCameraList = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCameraList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCameraTitle.Location = new System.Drawing.Point(561, 7);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(114, 23);
            this.labelCameraTitle.TabIndex = 5;
            this.labelCameraTitle.Text = "选择摄像头:";
            this.labelCameraTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.cameraControl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCameraTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnClose2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtDesc, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.cmbType, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnRectify, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCameraList, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(678, 456);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(3, 3);
            this.cameraControl.MinimumSize = new System.Drawing.Size(1, 1);
            this.cameraControl.Name = "cameraControl";
            this.tableLayoutPanel2.SetRowSpan(this.cameraControl, 11);
            this.cameraControl.Size = new System.Drawing.Size(552, 450);
            this.cameraControl.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "说明:";
            // 
            // btnClose2
            // 
            this.btnClose2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose2.EnableTouchMode = true;
            this.btnClose2.IsBackStageButton = false;
            this.btnClose2.Location = new System.Drawing.Point(561, 68);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(114, 44);
            this.btnClose2.TabIndex = 18;
            this.btnClose2.Text = "关闭";
            // 
            // btnSave
            // 
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.EnableTouchMode = true;
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(561, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 44);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "名称:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "类型:";
            // 
            // txtName
            // 
            this.txtName.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.EnableTouchMode = true;
            this.txtName.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(561, 198);
            this.txtName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 28);
            this.txtName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtName.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.EnableTouchMode = true;
            this.txtDesc.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesc.Location = new System.Drawing.Point(561, 318);
            this.txtDesc.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(114, 135);
            this.txtDesc.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtDesc.TabIndex = 15;
            // 
            // cmbType
            // 
            this.cmbType.BeforeTouchSize = new System.Drawing.Size(114, 20);
            this.cmbType.EnableTouchMode = true;
            this.cmbType.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbType.Location = new System.Drawing.Point(561, 258);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(114, 26);
            this.cmbType.TabIndex = 22;
            // 
            // btnRectify
            // 
            this.btnRectify.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnRectify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRectify.EnableTouchMode = true;
            this.btnRectify.IsBackStageButton = false;
            this.btnRectify.Location = new System.Drawing.Point(561, 63);
            this.btnRectify.Name = "btnRectify";
            this.btnRectify.Size = new System.Drawing.Size(114, 1);
            this.btnRectify.TabIndex = 9;
            this.btnRectify.Text = "纠正";
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.BeforeTouchSize = new System.Drawing.Size(121, 20);
            this.comboBoxCameraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.EnableTouchMode = true;
            this.comboBoxCameraList.Font = new System.Drawing.Font("宋体", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCameraList.Location = new System.Drawing.Point(561, 33);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(114, 26);
            this.comboBoxCameraList.TabIndex = 24;
            this.comboBoxCameraList.Click += new System.EventHandler(this.comboBoxCameraList_Click);
            // 
            // frmCameraCapture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose2;
            this.ClientSize = new System.Drawing.Size(678, 456);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmCameraCapture2";
            this.Text = "拍照";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCameraCapture_FormClosed);
            this.Load += new System.EventHandler(this.frmCameraCapture_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCameraList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCameraTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose2;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDesc;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbType;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxCameraList;
        private Syncfusion.Windows.Forms.ButtonAdv btnRectify;
    }
}