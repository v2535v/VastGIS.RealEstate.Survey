using VastGIS.Plugins.Symbology.Controls;
using VastGIS.Plugins.Symbology.Controls.ImageCombo;
using VastGIS.UI.Controls;

namespace VastGIS.Plugins.Symbology.Forms
{
    partial class ChartStyleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartStyleForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cboChartNormalizationField = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboChartSizeField = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.listRight = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChangeScheme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panelPieChart = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelBarChart = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk3DMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkValuesFrame = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clpFrame = new VastGIS.UI.Controls.Office2007ColorPicker(this.components);
            this.cboValuesStyle = new System.Windows.Forms.ComboBox();
            this.chkValuesVisible = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFontName = new System.Windows.Forms.ComboBox();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.clpFont = new VastGIS.UI.Controls.Office2007ColorPicker(this.components);
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cboChartVerticalPosition = new System.Windows.Forms.ComboBox();
            this.groupboxChartsOffset = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabVisibility = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnSetMinScale = new System.Windows.Forms.Button();
            this.btnSetMaxScale = new System.Windows.Forms.Button();
            this.cboMaxScale = new System.Windows.Forms.ComboBox();
            this.cboMinScale = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkDynamicVisibility = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnClearChartsExpression = new System.Windows.Forms.Button();
            this.btnChartExpression = new System.Windows.Forms.Button();
            this.txtChartExpression = new System.Windows.Forms.TextBox();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optBarCharts = new System.Windows.Forms.RadioButton();
            this.optPieCharts = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.transparencyControl1 = new VastGIS.UI.Controls.TransparencyControl();
            this.btnApply = new System.Windows.Forms.Button();
            this.udPieRadius2 = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udPieRadius = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udBarHeight = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udBarWidth = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udThickness = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udTilt = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.icbColors = new VastGIS.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.udFontSize = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udChartsOffsetY = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udChartsOffsetX = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.udChartsBuffer = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panelPieChart.SuspendLayout();
            this.panelBarChart.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPosition.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupboxChartsOffset.SuspendLayout();
            this.tabVisibility.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsBuffer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPosition);
            this.tabControl1.Controls.Add(this.tabVisibility);
            this.tabControl1.Location = new System.Drawing.Point(204, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 313);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.btnDeleteAll);
            this.tabPage3.Controls.Add(this.listLeft);
            this.tabPage3.Controls.Add(this.btnAddAll);
            this.tabPage3.Controls.Add(this.listRight);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(406, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "字段";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cboChartNormalizationField);
            this.groupBox13.Controls.Add(this.label16);
            this.groupBox13.Controls.Add(this.cboChartSizeField);
            this.groupBox13.Controls.Add(this.label18);
            this.groupBox13.Location = new System.Drawing.Point(51, 199);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(307, 78);
            this.groupBox13.TabIndex = 99;
            this.groupBox13.TabStop = false;
            // 
            // cboChartNormalizationField
            // 
            this.cboChartNormalizationField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartNormalizationField.FormattingEnabled = true;
            this.cboChartNormalizationField.Location = new System.Drawing.Point(123, 47);
            this.cboChartNormalizationField.Name = "cboChartNormalizationField";
            this.cboChartNormalizationField.Size = new System.Drawing.Size(140, 20);
            this.cboChartNormalizationField.TabIndex = 98;
            this.cboChartNormalizationField.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 97;
            this.label16.Text = "常见字段";
            // 
            // cboChartSizeField
            // 
            this.cboChartSizeField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartSizeField.FormattingEnabled = true;
            this.cboChartSizeField.Location = new System.Drawing.Point(123, 17);
            this.cboChartSizeField.Name = "cboChartSizeField";
            this.cboChartSizeField.Size = new System.Drawing.Size(140, 20);
            this.cboChartSizeField.TabIndex = 96;
            this.cboChartSizeField.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 95;
            this.label18.Text = "大小字段";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "有效字段:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(187, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 24);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 24);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(187, 127);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(35, 24);
            this.btnDeleteAll.TabIndex = 16;
            this.btnDeleteAll.Text = "<<";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // listLeft
            // 
            this.listLeft.FormattingEnabled = true;
            this.listLeft.ItemHeight = 12;
            this.listLeft.Location = new System.Drawing.Point(51, 31);
            this.listLeft.Name = "listLeft";
            this.listLeft.Size = new System.Drawing.Size(130, 160);
            this.listLeft.TabIndex = 12;
            this.listLeft.DoubleClick += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(187, 98);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(35, 24);
            this.btnAddAll.TabIndex = 17;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // listRight
            // 
            this.listRight.FormattingEnabled = true;
            this.listRight.ItemHeight = 12;
            this.listRight.Location = new System.Drawing.Point(228, 31);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(130, 160);
            this.listRight.TabIndex = 13;
            this.listRight.DoubleClick += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "选择字段:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChangeScheme);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.icbColors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "柱状图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChangeScheme
            // 
            this.btnChangeScheme.Location = new System.Drawing.Point(361, 40);
            this.btnChangeScheme.Name = "btnChangeScheme";
            this.btnChangeScheme.Size = new System.Drawing.Size(25, 19);
            this.btnChangeScheme.TabIndex = 18;
            this.btnChangeScheme.Text = "...";
            this.btnChangeScheme.UseVisualStyleBackColor = true;
            this.btnChangeScheme.Click += new System.EventHandler(this.btnChangeScheme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "颜色主题";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panelPieChart);
            this.groupBox6.Controls.Add(this.panelBarChart);
            this.groupBox6.Location = new System.Drawing.Point(15, 76);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(377, 90);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "大小";
            // 
            // panelPieChart
            // 
            this.panelPieChart.Controls.Add(this.udPieRadius2);
            this.panelPieChart.Controls.Add(this.udPieRadius);
            this.panelPieChart.Controls.Add(this.label8);
            this.panelPieChart.Controls.Add(this.label9);
            this.panelPieChart.Location = new System.Drawing.Point(201, 13);
            this.panelPieChart.Name = "panelPieChart";
            this.panelPieChart.Size = new System.Drawing.Size(170, 66);
            this.panelPieChart.TabIndex = 4;
            this.panelPieChart.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "半径2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "半径";
            // 
            // panelBarChart
            // 
            this.panelBarChart.Controls.Add(this.udBarHeight);
            this.panelBarChart.Controls.Add(this.udBarWidth);
            this.panelBarChart.Controls.Add(this.label3);
            this.panelBarChart.Controls.Add(this.label2);
            this.panelBarChart.Location = new System.Drawing.Point(15, 13);
            this.panelBarChart.Name = "panelBarChart";
            this.panelBarChart.Size = new System.Drawing.Size(181, 66);
            this.panelBarChart.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "高度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "宽度";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.udThickness);
            this.groupBox7.Controls.Add(this.udTilt);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.chk3DMode);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(15, 172);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(377, 90);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "3D类型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "厚度";
            // 
            // chk3DMode
            // 
            this.chk3DMode.AutoSize = true;
            this.chk3DMode.Location = new System.Drawing.Point(201, 25);
            this.chk3DMode.Name = "chk3DMode";
            this.chk3DMode.Size = new System.Drawing.Size(60, 16);
            this.chk3DMode.TabIndex = 0;
            this.chk3DMode.Text = "3D效果";
            this.chk3DMode.UseVisualStyleBackColor = true;
            this.chk3DMode.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tilt";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.cboValuesStyle);
            this.tabPage2.Controls.Add(this.chkValuesVisible);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(406, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "值";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkValuesFrame);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.clpFrame);
            this.groupBox5.Location = new System.Drawing.Point(15, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(377, 74);
            this.groupBox5.TabIndex = 124;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "框架";
            // 
            // chkValuesFrame
            // 
            this.chkValuesFrame.AutoSize = true;
            this.chkValuesFrame.Location = new System.Drawing.Point(21, 33);
            this.chkValuesFrame.Name = "chkValuesFrame";
            this.chkValuesFrame.Size = new System.Drawing.Size(72, 16);
            this.chkValuesFrame.TabIndex = 122;
            this.chkValuesFrame.Text = "显示外框";
            this.chkValuesFrame.UseVisualStyleBackColor = true;
            this.chkValuesFrame.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 119;
            this.label11.Text = "外框颜色";
            // 
            // clpFrame
            // 
            this.clpFrame.Color = System.Drawing.Color.Black;
            this.clpFrame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFrame.DropDownHeight = 1;
            this.clpFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFrame.FormattingEnabled = true;
            this.clpFrame.IntegralHeight = false;
            this.clpFrame.Items.AddRange(new object[] {
            "Color"});
            this.clpFrame.Location = new System.Drawing.Point(190, 31);
            this.clpFrame.Name = "clpFrame";
            this.clpFrame.Size = new System.Drawing.Size(74, 22);
            this.clpFrame.TabIndex = 120;
            this.clpFrame.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // cboValuesStyle
            // 
            this.cboValuesStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValuesStyle.FormattingEnabled = true;
            this.cboValuesStyle.Location = new System.Drawing.Point(271, 32);
            this.cboValuesStyle.Name = "cboValuesStyle";
            this.cboValuesStyle.Size = new System.Drawing.Size(108, 20);
            this.cboValuesStyle.TabIndex = 117;
            this.cboValuesStyle.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkValuesVisible
            // 
            this.chkValuesVisible.AutoSize = true;
            this.chkValuesVisible.Location = new System.Drawing.Point(26, 34);
            this.chkValuesVisible.Name = "chkValuesVisible";
            this.chkValuesVisible.Size = new System.Drawing.Size(60, 16);
            this.chkValuesVisible.TabIndex = 121;
            this.chkValuesVisible.Text = "可见性";
            this.chkValuesVisible.UseVisualStyleBackColor = true;
            this.chkValuesVisible.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 118;
            this.label10.Text = "样式";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboFontName);
            this.groupBox4.Controls.Add(this.chkFontItalic);
            this.groupBox4.Controls.Add(this.chkFontBold);
            this.groupBox4.Controls.Add(this.udFontSize);
            this.groupBox4.Controls.Add(this.clpFont);
            this.groupBox4.Location = new System.Drawing.Point(15, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 122);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "字体";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 113;
            this.label4.Text = "颜色";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(18, 30);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 12);
            this.label35.TabIndex = 112;
            this.label35.Text = "字体名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 111;
            this.label5.Text = "大小";
            // 
            // cboFontName
            // 
            this.cboFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontName.FormattingEnabled = true;
            this.cboFontName.Location = new System.Drawing.Point(71, 27);
            this.cboFontName.Name = "cboFontName";
            this.cboFontName.Size = new System.Drawing.Size(176, 20);
            this.cboFontName.TabIndex = 110;
            this.cboFontName.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkFontItalic
            // 
            this.chkFontItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFontItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFontItalic.Image = ((System.Drawing.Image)(resources.GetObject("chkFontItalic.Image")));
            this.chkFontItalic.Location = new System.Drawing.Point(187, 54);
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.Size = new System.Drawing.Size(26, 24);
            this.chkFontItalic.TabIndex = 107;
            this.chkFontItalic.UseVisualStyleBackColor = true;
            this.chkFontItalic.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // chkFontBold
            // 
            this.chkFontBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFontBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFontBold.Image = ((System.Drawing.Image)(resources.GetObject("chkFontBold.Image")));
            this.chkFontBold.Location = new System.Drawing.Point(219, 54);
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.Size = new System.Drawing.Size(28, 24);
            this.chkFontBold.TabIndex = 106;
            this.chkFontBold.UseVisualStyleBackColor = true;
            this.chkFontBold.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // clpFont
            // 
            this.clpFont.Color = System.Drawing.Color.Black;
            this.clpFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clpFont.DropDownHeight = 1;
            this.clpFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clpFont.FormattingEnabled = true;
            this.clpFont.IntegralHeight = false;
            this.clpFont.Items.AddRange(new object[] {
            "Color"});
            this.clpFont.Location = new System.Drawing.Point(71, 82);
            this.clpFont.Name = "clpFont";
            this.clpFont.Size = new System.Drawing.Size(74, 22);
            this.clpFont.TabIndex = 115;
            this.clpFont.SelectedColorChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // tabPosition
            // 
            this.tabPosition.Controls.Add(this.groupBox10);
            this.tabPosition.Controls.Add(this.groupboxChartsOffset);
            this.tabPosition.Location = new System.Drawing.Point(4, 22);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Size = new System.Drawing.Size(406, 287);
            this.tabPosition.TabIndex = 3;
            this.tabPosition.Text = "定位";
            this.tabPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cboChartVerticalPosition);
            this.groupBox10.Location = new System.Drawing.Point(15, 145);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(202, 64);
            this.groupBox10.TabIndex = 167;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "竖直定位";
            // 
            // cboChartVerticalPosition
            // 
            this.cboChartVerticalPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChartVerticalPosition.FormattingEnabled = true;
            this.cboChartVerticalPosition.Location = new System.Drawing.Point(17, 28);
            this.cboChartVerticalPosition.Name = "cboChartVerticalPosition";
            this.cboChartVerticalPosition.Size = new System.Drawing.Size(167, 20);
            this.cboChartVerticalPosition.TabIndex = 165;
            this.cboChartVerticalPosition.SelectedIndexChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupboxChartsOffset
            // 
            this.groupboxChartsOffset.Controls.Add(this.udChartsOffsetY);
            this.groupboxChartsOffset.Controls.Add(this.udChartsOffsetX);
            this.groupboxChartsOffset.Controls.Add(this.udChartsBuffer);
            this.groupboxChartsOffset.Controls.Add(this.label17);
            this.groupboxChartsOffset.Controls.Add(this.label14);
            this.groupboxChartsOffset.Controls.Add(this.label15);
            this.groupboxChartsOffset.Location = new System.Drawing.Point(15, 12);
            this.groupboxChartsOffset.Name = "groupboxChartsOffset";
            this.groupboxChartsOffset.Size = new System.Drawing.Size(202, 127);
            this.groupboxChartsOffset.TabIndex = 164;
            this.groupboxChartsOffset.TabStop = false;
            this.groupboxChartsOffset.Text = "定位";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(98, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 160;
            this.label17.Text = "缓冲";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(98, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 158;
            this.label14.Text = "竖直偏移";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 155;
            this.label15.Text = "水平偏移";
            // 
            // tabVisibility
            // 
            this.tabVisibility.Controls.Add(this.groupBox11);
            this.tabVisibility.Controls.Add(this.groupBox9);
            this.tabVisibility.Location = new System.Drawing.Point(4, 22);
            this.tabVisibility.Name = "tabVisibility";
            this.tabVisibility.Size = new System.Drawing.Size(406, 287);
            this.tabVisibility.TabIndex = 4;
            this.tabVisibility.Text = "可见性";
            this.tabVisibility.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnSetMinScale);
            this.groupBox11.Controls.Add(this.btnSetMaxScale);
            this.groupBox11.Controls.Add(this.cboMaxScale);
            this.groupBox11.Controls.Add(this.cboMinScale);
            this.groupBox11.Controls.Add(this.label20);
            this.groupBox11.Controls.Add(this.label19);
            this.groupBox11.Controls.Add(this.chkDynamicVisibility);
            this.groupBox11.Location = new System.Drawing.Point(15, 147);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(377, 130);
            this.groupBox11.TabIndex = 175;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "动态显示";
            // 
            // btnSetMinScale
            // 
            this.btnSetMinScale.Location = new System.Drawing.Point(272, 59);
            this.btnSetMinScale.Name = "btnSetMinScale";
            this.btnSetMinScale.Size = new System.Drawing.Size(87, 22);
            this.btnSetMinScale.TabIndex = 8;
            this.btnSetMinScale.Text = "获取当前";
            this.btnSetMinScale.UseVisualStyleBackColor = true;
            this.btnSetMinScale.Click += new System.EventHandler(this.btnSetMinScale_Click);
            // 
            // btnSetMaxScale
            // 
            this.btnSetMaxScale.Location = new System.Drawing.Point(272, 90);
            this.btnSetMaxScale.Name = "btnSetMaxScale";
            this.btnSetMaxScale.Size = new System.Drawing.Size(87, 22);
            this.btnSetMaxScale.TabIndex = 7;
            this.btnSetMaxScale.Text = "获取当前";
            this.btnSetMaxScale.UseVisualStyleBackColor = true;
            this.btnSetMaxScale.Click += new System.EventHandler(this.btnSetMaxScale_Click);
            // 
            // cboMaxScale
            // 
            this.cboMaxScale.FormattingEnabled = true;
            this.cboMaxScale.Location = new System.Drawing.Point(144, 93);
            this.cboMaxScale.Name = "cboMaxScale";
            this.cboMaxScale.Size = new System.Drawing.Size(110, 20);
            this.cboMaxScale.TabIndex = 4;
            this.cboMaxScale.TextChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // cboMinScale
            // 
            this.cboMinScale.FormattingEnabled = true;
            this.cboMinScale.Location = new System.Drawing.Point(144, 62);
            this.cboMinScale.Name = "cboMinScale";
            this.cboMinScale.Size = new System.Drawing.Size(110, 20);
            this.cboMinScale.TabIndex = 3;
            this.cboMinScale.TextChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(26, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "最大可见比例";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "最小可见比例";
            // 
            // chkDynamicVisibility
            // 
            this.chkDynamicVisibility.AutoSize = true;
            this.chkDynamicVisibility.Location = new System.Drawing.Point(29, 30);
            this.chkDynamicVisibility.Name = "chkDynamicVisibility";
            this.chkDynamicVisibility.Size = new System.Drawing.Size(96, 16);
            this.chkDynamicVisibility.TabIndex = 0;
            this.chkDynamicVisibility.Text = "使用动态显示";
            this.chkDynamicVisibility.UseVisualStyleBackColor = true;
            this.chkDynamicVisibility.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnClearChartsExpression);
            this.groupBox9.Controls.Add(this.btnChartExpression);
            this.groupBox9.Controls.Add(this.txtChartExpression);
            this.groupBox9.Location = new System.Drawing.Point(15, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(377, 127);
            this.groupBox9.TabIndex = 167;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "可见性计算公式";
            // 
            // btnClearChartsExpression
            // 
            this.btnClearChartsExpression.Location = new System.Drawing.Point(301, 94);
            this.btnClearChartsExpression.Name = "btnClearChartsExpression";
            this.btnClearChartsExpression.Size = new System.Drawing.Size(67, 24);
            this.btnClearChartsExpression.TabIndex = 166;
            this.btnClearChartsExpression.Text = "清理";
            this.btnClearChartsExpression.UseVisualStyleBackColor = true;
            this.btnClearChartsExpression.Click += new System.EventHandler(this.btnClearChartsExpression_Click);
            // 
            // btnChartExpression
            // 
            this.btnChartExpression.Location = new System.Drawing.Point(228, 94);
            this.btnChartExpression.Name = "btnChartExpression";
            this.btnChartExpression.Size = new System.Drawing.Size(67, 24);
            this.btnChartExpression.TabIndex = 165;
            this.btnChartExpression.Text = "修改...";
            this.btnChartExpression.UseVisualStyleBackColor = true;
            this.btnChartExpression.Click += new System.EventHandler(this.btnChartExpression_Click);
            // 
            // txtChartExpression
            // 
            this.txtChartExpression.Location = new System.Drawing.Point(20, 18);
            this.txtChartExpression.Multiline = true;
            this.txtChartExpression.Name = "txtChartExpression";
            this.txtChartExpression.ReadOnly = true;
            this.txtChartExpression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChartExpression.Size = new System.Drawing.Size(348, 71);
            this.txtChartExpression.TabIndex = 164;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Location = new System.Drawing.Point(23, 18);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(48, 16);
            this.chkVisible.TabIndex = 13;
            this.chkVisible.Text = "可见";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optBarCharts);
            this.groupBox2.Controls.Add(this.optPieCharts);
            this.groupBox2.Location = new System.Drawing.Point(10, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "类型";
            // 
            // optBarCharts
            // 
            this.optBarCharts.AutoSize = true;
            this.optBarCharts.Location = new System.Drawing.Point(25, 20);
            this.optBarCharts.Name = "optBarCharts";
            this.optBarCharts.Size = new System.Drawing.Size(59, 16);
            this.optBarCharts.TabIndex = 1;
            this.optBarCharts.TabStop = true;
            this.optBarCharts.Text = "条柱状";
            this.optBarCharts.UseVisualStyleBackColor = true;
            this.optBarCharts.CheckedChanged += new System.EventHandler(this.optBarCharts_CheckedChanged);
            // 
            // optPieCharts
            // 
            this.optPieCharts.AutoSize = true;
            this.optPieCharts.Location = new System.Drawing.Point(86, 20);
            this.optPieCharts.Name = "optPieCharts";
            this.optPieCharts.Size = new System.Drawing.Size(47, 16);
            this.optPieCharts.TabIndex = 0;
            this.optPieCharts.TabStop = true;
            this.optPieCharts.Text = "饼状";
            this.optPieCharts.UseVisualStyleBackColor = true;
            this.optPieCharts.CheckedChanged += new System.EventHandler(this.optPieCharts_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(434, 326);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 24);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确认";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(527, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkVisible);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 46);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.transparencyControl1);
            this.groupBox8.Location = new System.Drawing.Point(10, 265);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(188, 60);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "透明化";
            // 
            // transparencyControl1
            // 
            this.transparencyControl1.BandColor = System.Drawing.Color.Empty;
            this.transparencyControl1.Location = new System.Drawing.Point(18, 25);
            this.transparencyControl1.MaximumSize = new System.Drawing.Size(1024, 30);
            this.transparencyControl1.MinimumSize = new System.Drawing.Size(128, 30);
            this.transparencyControl1.Name = "transparencyControl1";
            this.transparencyControl1.Size = new System.Drawing.Size(156, 30);
            this.transparencyControl1.TabIndex = 17;
            this.transparencyControl1.Value = ((byte)(255));
            this.transparencyControl1.ValueChanged += new VastGIS.UI.Controls.TransparencyControl.ValueChangedDeleg(this.transparencyControl1_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(341, 326);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 24);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // udPieRadius2
            // 
            this.udPieRadius2.Location = new System.Drawing.Point(89, 42);
            this.udPieRadius2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius2.Name = "udPieRadius2";
            this.udPieRadius2.Size = new System.Drawing.Size(49, 21);
            this.udPieRadius2.TabIndex = 9;
            this.udPieRadius2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius2.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udPieRadius
            // 
            this.udPieRadius.Location = new System.Drawing.Point(89, 13);
            this.udPieRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius.Name = "udPieRadius";
            this.udPieRadius.Size = new System.Drawing.Size(49, 21);
            this.udPieRadius.TabIndex = 5;
            this.udPieRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udPieRadius.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udBarHeight
            // 
            this.udBarHeight.Location = new System.Drawing.Point(89, 42);
            this.udBarHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarHeight.Name = "udBarHeight";
            this.udBarHeight.Size = new System.Drawing.Size(51, 21);
            this.udBarHeight.TabIndex = 16;
            this.udBarHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarHeight.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udBarWidth
            // 
            this.udBarWidth.Location = new System.Drawing.Point(89, 13);
            this.udBarWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udBarWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarWidth.Name = "udBarWidth";
            this.udBarWidth.Size = new System.Drawing.Size(51, 21);
            this.udBarWidth.TabIndex = 15;
            this.udBarWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBarWidth.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udThickness
            // 
            this.udThickness.Location = new System.Drawing.Point(104, 57);
            this.udThickness.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.udThickness.Name = "udThickness";
            this.udThickness.Size = new System.Drawing.Size(51, 21);
            this.udThickness.TabIndex = 14;
            this.udThickness.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udTilt
            // 
            this.udTilt.Location = new System.Drawing.Point(105, 23);
            this.udTilt.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.udTilt.Name = "udTilt";
            this.udTilt.Size = new System.Drawing.Size(51, 21);
            this.udTilt.TabIndex = 13;
            this.udTilt.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // icbColors
            // 
            this.icbColors.ComboStyle = VastGIS.Api.Enums.SchemeType.Graduated;
            this.icbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbColors.FormattingEnabled = true;
            this.icbColors.Location = new System.Drawing.Point(178, 40);
            this.icbColors.Name = "icbColors";
            this.icbColors.OutlineColor = System.Drawing.Color.Black;
            this.icbColors.Size = new System.Drawing.Size(176, 22);
            this.icbColors.TabIndex = 2;
            this.icbColors.Target = VastGIS.Plugins.Symbology.SchemeTarget.Vector;
            this.icbColors.SelectedIndexChanged += new System.EventHandler(this.icbColors_SelectedIndexChanged);
            // 
            // udFontSize
            // 
            this.udFontSize.Location = new System.Drawing.Point(303, 30);
            this.udFontSize.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.udFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.udFontSize.Name = "udFontSize";
            this.udFontSize.Size = new System.Drawing.Size(50, 21);
            this.udFontSize.TabIndex = 116;
            this.udFontSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.udFontSize.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udChartsOffsetY
            // 
            this.udChartsOffsetY.Location = new System.Drawing.Point(29, 62);
            this.udChartsOffsetY.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udChartsOffsetY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsOffsetY.Name = "udChartsOffsetY";
            this.udChartsOffsetY.Size = new System.Drawing.Size(54, 21);
            this.udChartsOffsetY.TabIndex = 163;
            this.udChartsOffsetY.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udChartsOffsetX
            // 
            this.udChartsOffsetX.Location = new System.Drawing.Point(29, 30);
            this.udChartsOffsetX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udChartsOffsetX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsOffsetX.Name = "udChartsOffsetX";
            this.udChartsOffsetX.Size = new System.Drawing.Size(54, 21);
            this.udChartsOffsetX.TabIndex = 162;
            this.udChartsOffsetX.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // udChartsBuffer
            // 
            this.udChartsBuffer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.udChartsBuffer.Location = new System.Drawing.Point(29, 94);
            this.udChartsBuffer.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.udChartsBuffer.Name = "udChartsBuffer";
            this.udChartsBuffer.Size = new System.Drawing.Size(54, 21);
            this.udChartsBuffer.TabIndex = 161;
            this.udChartsBuffer.ValueChanged += new System.EventHandler(this.Ui2Settings);
            // 
            // ChartStyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(623, 356);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartStyleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图表样式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChartStyle_FormClosing);
            this.Load += new System.EventHandler(this.ChartStyleForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panelPieChart.ResumeLayout(false);
            this.panelPieChart.PerformLayout();
            this.panelBarChart.ResumeLayout(false);
            this.panelBarChart.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPosition.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupboxChartsOffset.ResumeLayout(false);
            this.groupboxChartsOffset.PerformLayout();
            this.tabVisibility.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPieRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udChartsBuffer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk3DMode;
        private System.Windows.Forms.Panel panelBarChart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPieChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkValuesVisible;
        private System.Windows.Forms.Label label11;
        private Office2007ColorPicker clpFrame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboValuesStyle;
        private NumericUpDownEx udFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboFontName;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.CheckBox chkFontBold;
        private Office2007ColorPicker clpFont;
        private System.Windows.Forms.CheckBox chkValuesFrame;
        private System.Windows.Forms.RadioButton optBarCharts;
        private System.Windows.Forms.RadioButton optPieCharts;
        private ColorSchemeCombo icbColors;
        private System.Windows.Forms.GroupBox groupBox2;
        private NumericUpDownEx udTilt;
        private NumericUpDownEx udThickness;
        private NumericUpDownEx udBarHeight;
        private NumericUpDownEx udBarWidth;
        private NumericUpDownEx udPieRadius2;
        private NumericUpDownEx udPieRadius;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
        private TransparencyControl transparencyControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPosition;
        private System.Windows.Forms.GroupBox groupboxChartsOffset;
        private NumericUpDownEx udChartsOffsetY;
        private NumericUpDownEx udChartsOffsetX;
        private NumericUpDownEx udChartsBuffer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabVisibility;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cboChartNormalizationField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboChartSizeField;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnClearChartsExpression;
        private System.Windows.Forms.Button btnChartExpression;
        private System.Windows.Forms.TextBox txtChartExpression;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cboChartVerticalPosition;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cboMaxScale;
        private System.Windows.Forms.ComboBox cboMinScale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkDynamicVisibility;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChangeScheme;
        private System.Windows.Forms.Button btnSetMinScale;
        private System.Windows.Forms.Button btnSetMaxScale;
    }
}