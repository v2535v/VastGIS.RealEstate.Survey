namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmCameraCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameraCapture));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageCamera = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.cameraControl = new Camera_NET.CameraControl();
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.comboBoxCameraList = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxResolutionList = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.buttonCameraSettings = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnStartCamera = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pageProcess = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnClickCorner = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPointNumber = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnRectify = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRecamera = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSave = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.picCurrent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.pageCamera.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCameraList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxResolutionList)).BeginInit();
            this.pageProcess.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPointNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(658, 428);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.pageCamera);
            this.tabControlAdv1.Controls.Add(this.pageProcess);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(658, 428);
            this.tabControlAdv1.TabIndex = 1;
            // 
            // pageCamera
            // 
            this.pageCamera.Controls.Add(this.tableLayoutPanel1);
            this.pageCamera.Image = null;
            this.pageCamera.ImageSize = new System.Drawing.Size(16, 16);
            this.pageCamera.Location = new System.Drawing.Point(1, 24);
            this.pageCamera.Name = "pageCamera";
            this.pageCamera.ShowCloseButton = true;
            this.pageCamera.Size = new System.Drawing.Size(655, 402);
            this.pageCamera.TabIndex = 1;
            this.pageCamera.Text = "拍照";
            this.pageCamera.ThemesEnabled = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUnZoom, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cameraControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCameraTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxCameraList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxResolutionList, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonCameraSettings, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnStartCamera, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 402);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonUnZoom
            // 
            this.buttonUnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnZoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnZoom.Image")));
            this.buttonUnZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnZoom.Location = new System.Drawing.Point(535, 300);
            this.buttonUnZoom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnZoom.Name = "buttonUnZoom";
            this.buttonUnZoom.Size = new System.Drawing.Size(113, 24);
            this.buttonUnZoom.TabIndex = 17;
            this.buttonUnZoom.Text = "还原";
            this.buttonUnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnZoom.UseVisualStyleBackColor = true;
            this.buttonUnZoom.Visible = false;
            this.buttonUnZoom.Click += new System.EventHandler(this.buttonUnZoom_Click);
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(3, 3);
            this.cameraControl.MinimumSize = new System.Drawing.Size(1, 1);
            this.cameraControl.Name = "cameraControl";
            this.tableLayoutPanel1.SetRowSpan(this.cameraControl, 11);
            this.cameraControl.Size = new System.Drawing.Size(529, 396);
            this.cameraControl.TabIndex = 16;
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(538, 7);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(71, 12);
            this.labelCameraTitle.TabIndex = 5;
            this.labelCameraTitle.Text = "选择摄像头:";
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.BeforeTouchSize = new System.Drawing.Size(121, 20);
            this.comboBoxCameraList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCameraList.EnableTouchMode = true;
            this.comboBoxCameraList.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCameraList.Location = new System.Drawing.Point(538, 33);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(114, 26);
            this.comboBoxCameraList.TabIndex = 6;
            this.comboBoxCameraList.Click += new System.EventHandler(this.comboBoxCameraList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "选择分辨率:";
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.BeforeTouchSize = new System.Drawing.Size(121, 20);
            this.comboBoxResolutionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxResolutionList.EnableTouchMode = true;
            this.comboBoxResolutionList.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxResolutionList.Location = new System.Drawing.Point(538, 93);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(114, 26);
            this.comboBoxResolutionList.TabIndex = 8;
            this.comboBoxResolutionList.Click += new System.EventHandler(this.comboBoxResolutionList_Click);
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.buttonCameraSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCameraSettings.EnableTouchMode = true;
            this.buttonCameraSettings.IsBackStageButton = false;
            this.buttonCameraSettings.Location = new System.Drawing.Point(538, 123);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(114, 24);
            this.buttonCameraSettings.TabIndex = 9;
            this.buttonCameraSettings.Text = "摄像头设置";
            this.buttonCameraSettings.Click += new System.EventHandler(this.buttonCameraSettings_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnStartCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartCamera.EnableTouchMode = true;
            this.btnStartCamera.IsBackStageButton = false;
            this.btnStartCamera.Location = new System.Drawing.Point(538, 153);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(114, 24);
            this.btnStartCamera.TabIndex = 10;
            this.btnStartCamera.Text = "拍照";
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.EnableTouchMode = true;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(538, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 24);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "取消";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pageProcess
            // 
            this.pageProcess.Controls.Add(this.tableLayoutPanel2);
            this.pageProcess.Image = null;
            this.pageProcess.ImageSize = new System.Drawing.Size(16, 16);
            this.pageProcess.Location = new System.Drawing.Point(1, 24);
            this.pageProcess.Name = "pageProcess";
            this.pageProcess.ShowCloseButton = true;
            this.pageProcess.Size = new System.Drawing.Size(655, 402);
            this.pageProcess.TabIndex = 2;
            this.pageProcess.Text = "处理";
            this.pageProcess.ThemesEnabled = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btnClose2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnClickCorner, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbPointNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRectify, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnRecamera, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.textBoxExt2, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.textBoxExt3, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.picCurrent, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(655, 402);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnClose2
            // 
            this.btnClose2.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose2.EnableTouchMode = true;
            this.btnClose2.IsBackStageButton = false;
            this.btnClose2.Location = new System.Drawing.Point(538, 153);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(114, 24);
            this.btnClose2.TabIndex = 18;
            this.btnClose2.Text = "关闭";
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnClickCorner
            // 
            this.btnClickCorner.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClickCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClickCorner.EnableTouchMode = true;
            this.btnClickCorner.IsBackStageButton = false;
            this.btnClickCorner.Location = new System.Drawing.Point(538, 63);
            this.btnClickCorner.Name = "btnClickCorner";
            this.btnClickCorner.Size = new System.Drawing.Size(114, 24);
            this.btnClickCorner.TabIndex = 17;
            this.btnClickCorner.Text = "输入角点";
            this.btnClickCorner.Click += new System.EventHandler(this.btnClickCorner_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "角点序号:";
            // 
            // cmbPointNumber
            // 
            this.cmbPointNumber.BeforeTouchSize = new System.Drawing.Size(121, 20);
            this.cmbPointNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPointNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPointNumber.EnableTouchMode = true;
            this.cmbPointNumber.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPointNumber.Items.AddRange(new object[] {
            "左上角",
            "右上角",
            "右下角",
            "左下角"});
            this.cmbPointNumber.Location = new System.Drawing.Point(538, 33);
            this.cmbPointNumber.Name = "cmbPointNumber";
            this.cmbPointNumber.Size = new System.Drawing.Size(114, 26);
            this.cmbPointNumber.TabIndex = 6;
            this.cmbPointNumber.Text = "左上角";
            // 
            // btnRectify
            // 
            this.btnRectify.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnRectify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRectify.EnableTouchMode = true;
            this.btnRectify.IsBackStageButton = false;
            this.btnRectify.Location = new System.Drawing.Point(538, 93);
            this.btnRectify.Name = "btnRectify";
            this.btnRectify.Size = new System.Drawing.Size(114, 24);
            this.btnRectify.TabIndex = 9;
            this.btnRectify.Text = "纠正";
            // 
            // btnRecamera
            // 
            this.btnRecamera.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnRecamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecamera.EnableTouchMode = true;
            this.btnRecamera.IsBackStageButton = false;
            this.btnRecamera.Location = new System.Drawing.Point(538, 123);
            this.btnRecamera.Name = "btnRecamera";
            this.btnRecamera.Size = new System.Drawing.Size(114, 24);
            this.btnRecamera.TabIndex = 10;
            this.btnRecamera.Text = "放弃，重新拍照";
            this.btnRecamera.Click += new System.EventHandler(this.btnRecamera_Click);
            // 
            // btnSave
            // 
            this.btnSave.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.EnableTouchMode = true;
            this.btnSave.IsBackStageButton = false;
            this.btnSave.Location = new System.Drawing.Point(538, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 24);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "名称:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "说明:";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.textBoxExt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExt2.EnableTouchMode = true;
            this.textBoxExt2.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExt2.Location = new System.Drawing.Point(538, 243);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(114, 28);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 14;
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BeforeTouchSize = new System.Drawing.Size(146, 21);
            this.textBoxExt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExt3.EnableTouchMode = true;
            this.textBoxExt3.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxExt3.Location = new System.Drawing.Point(538, 303);
            this.textBoxExt3.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt3.Multiline = true;
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.Size = new System.Drawing.Size(114, 96);
            this.textBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt3.TabIndex = 15;
            // 
            // picCurrent
            // 
            this.picCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCurrent.Location = new System.Drawing.Point(3, 3);
            this.picCurrent.Name = "picCurrent";
            this.tableLayoutPanel2.SetRowSpan(this.picCurrent, 11);
            this.picCurrent.Size = new System.Drawing.Size(529, 396);
            this.picCurrent.TabIndex = 19;
            this.picCurrent.TabStop = false;
            this.picCurrent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCurrent_MouseClick);
            // 
            // frmCameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 428);
            this.Controls.Add(this.tabControlAdv1);
            this.Name = "frmCameraCapture";
            this.Text = "拍照";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCameraCapture_FormClosed);
            this.Load += new System.EventHandler(this.frmCameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.pageCamera.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCameraList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxResolutionList)).EndInit();
            this.pageProcess.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPointNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Label labelCameraTitle;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxCameraList;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxResolutionList;
        private Syncfusion.Windows.Forms.ButtonAdv buttonCameraSettings;
        private Syncfusion.Windows.Forms.ButtonAdv btnStartCamera;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageProcess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbPointNumber;
        private Syncfusion.Windows.Forms.ButtonAdv btnRectify;
        private Syncfusion.Windows.Forms.ButtonAdv btnRecamera;
        private Syncfusion.Windows.Forms.ButtonAdv btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.ButtonAdv btnClickCorner;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose2;
        private System.Windows.Forms.PictureBox picCurrent;
        private System.Windows.Forms.Button buttonUnZoom;
    }
}