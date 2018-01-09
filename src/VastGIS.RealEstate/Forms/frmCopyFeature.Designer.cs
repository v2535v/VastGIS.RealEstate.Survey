namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmCopyFeature
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radText = new System.Windows.Forms.RadioButton();
            this.radArea = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.radPoint = new System.Windows.Forms.RadioButton();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTargetLayer = new System.Windows.Forms.Button();
            this.btnSourceLayer = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUnionAndCopy = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMulti = new System.Windows.Forms.RadioButton();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radText);
            this.groupBox1.Controls.Add(this.radArea);
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Controls.Add(this.radPoint);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形类型";
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Location = new System.Drawing.Point(164, 20);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(47, 16);
            this.radText.TabIndex = 3;
            this.radText.TabStop = true;
            this.radText.Text = "注记";
            this.radText.UseVisualStyleBackColor = true;
            this.radText.CheckedChanged += new System.EventHandler(this.radText_CheckedChanged);
            // 
            // radArea
            // 
            this.radArea.AutoSize = true;
            this.radArea.Location = new System.Drawing.Point(114, 20);
            this.radArea.Name = "radArea";
            this.radArea.Size = new System.Drawing.Size(35, 16);
            this.radArea.TabIndex = 2;
            this.radArea.TabStop = true;
            this.radArea.Text = "面";
            this.radArea.UseVisualStyleBackColor = true;
            this.radArea.CheckedChanged += new System.EventHandler(this.radArea_CheckedChanged);
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Location = new System.Drawing.Point(62, 20);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(35, 16);
            this.radLine.TabIndex = 1;
            this.radLine.TabStop = true;
            this.radLine.Text = "线";
            this.radLine.UseVisualStyleBackColor = true;
            this.radLine.CheckedChanged += new System.EventHandler(this.radLine_CheckedChanged);
            // 
            // radPoint
            // 
            this.radPoint.AutoSize = true;
            this.radPoint.Location = new System.Drawing.Point(7, 21);
            this.radPoint.Name = "radPoint";
            this.radPoint.Size = new System.Drawing.Size(35, 16);
            this.radPoint.TabIndex = 0;
            this.radPoint.TabStop = true;
            this.radPoint.Text = "点";
            this.radPoint.UseVisualStyleBackColor = true;
            this.radPoint.CheckedChanged += new System.EventHandler(this.radPoint_CheckedChanged);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(95, 58);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(157, 21);
            this.txtTarget.TabIndex = 2;
            // 
            // btnTargetLayer
            // 
            this.btnTargetLayer.Location = new System.Drawing.Point(13, 56);
            this.btnTargetLayer.Name = "btnTargetLayer";
            this.btnTargetLayer.Size = new System.Drawing.Size(76, 23);
            this.btnTargetLayer.TabIndex = 3;
            this.btnTargetLayer.Text = "目标图层";
            this.btnTargetLayer.UseVisualStyleBackColor = true;
            this.btnTargetLayer.Click += new System.EventHandler(this.btnTargetLayer_Click);
            // 
            // btnSourceLayer
            // 
            this.btnSourceLayer.Location = new System.Drawing.Point(13, 83);
            this.btnSourceLayer.Name = "btnSourceLayer";
            this.btnSourceLayer.Size = new System.Drawing.Size(76, 23);
            this.btnSourceLayer.TabIndex = 5;
            this.btnSourceLayer.Text = "来源图层";
            this.btnSourceLayer.UseVisualStyleBackColor = true;
            this.btnSourceLayer.Click += new System.EventHandler(this.btnSourceLayer_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(95, 85);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(157, 21);
            this.txtSource.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "选择要素：";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUnionAndCopy
            // 
            this.btnUnionAndCopy.Location = new System.Drawing.Point(14, 279);
            this.btnUnionAndCopy.Name = "btnUnionAndCopy";
            this.btnUnionAndCopy.Size = new System.Drawing.Size(63, 23);
            this.btnUnionAndCopy.TabIndex = 12;
            this.btnUnionAndCopy.Text = "合并拷贝";
            this.btnUnionAndCopy.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(99, 279);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(63, 23);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "拷贝";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnCanel
            // 
            this.btnCanel.Location = new System.Drawing.Point(190, 279);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(60, 23);
            this.btnCanel.TabIndex = 14;
            this.btnCanel.Text = "退出";
            this.btnCanel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "从现有图层移除";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMulti);
            this.groupBox2.Controls.Add(this.radSingle);
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 44);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择模式";
            // 
            // radMulti
            // 
            this.radMulti.AutoSize = true;
            this.radMulti.Location = new System.Drawing.Point(82, 20);
            this.radMulti.Name = "radMulti";
            this.radMulti.Size = new System.Drawing.Size(47, 16);
            this.radMulti.TabIndex = 10;
            this.radMulti.TabStop = true;
            this.radMulti.Text = "多选";
            this.radMulti.UseVisualStyleBackColor = true;
            this.radMulti.CheckedChanged += new System.EventHandler(this.radMulti_CheckedChanged);
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Location = new System.Drawing.Point(7, 20);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(47, 16);
            this.radSingle.TabIndex = 9;
            this.radSingle.TabStop = true;
            this.radSingle.Text = "单一";
            this.radSingle.UseVisualStyleBackColor = true;
            this.radSingle.CheckedChanged += new System.EventHandler(this.radSingle_CheckedChanged);
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 12;
            this.lstSource.Location = new System.Drawing.Point(12, 176);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(238, 64);
            this.lstSource.TabIndex = 17;
            // 
            // frmCopyFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 309);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnUnionAndCopy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSourceLayer);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnTargetLayer);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCopyFeature";
            this.Text = "图形要素拷贝";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radText;
        private System.Windows.Forms.RadioButton radArea;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.RadioButton radPoint;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTargetLayer;
        private System.Windows.Forms.Button btnSourceLayer;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUnionAndCopy;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMulti;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.ListBox lstSource;
    }
}