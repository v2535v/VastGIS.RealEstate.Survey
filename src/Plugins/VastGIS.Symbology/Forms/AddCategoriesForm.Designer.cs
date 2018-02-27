using VastGIS.Api.Enums;
using VastGIS.Plugins.Symbology.Controls;
using VastGIS.Plugins.Symbology.Controls.ImageCombo;

namespace VastGIS.Plugins.Symbology.Forms
{
    partial class AddCategoriesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.icbColors = new VastGIS.Plugins.Symbology.Controls.ImageCombo.ColorSchemeCombo();
            this.numericUpDownExt1 = new VastGIS.Plugins.Symbology.Controls.NumericUpDownEx(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加的目录个数";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRandom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.icbColors);
            this.groupBox1.Controls.Add(this.numericUpDownExt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(113, 90);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(72, 16);
            this.chkRandom.TabIndex = 4;
            this.chkRandom.Text = "随意颜色";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "颜色主题";
            // 
            // icbColors
            // 
            this.icbColors.ComboStyle = VastGIS.Api.Enums.SchemeType.Graduated;
            this.icbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.icbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.icbColors.FormattingEnabled = true;
            this.icbColors.Location = new System.Drawing.Point(113, 66);
            this.icbColors.Name = "icbColors";
            this.icbColors.OutlineColor = System.Drawing.Color.Black;
            this.icbColors.Size = new System.Drawing.Size(134, 22);
            this.icbColors.TabIndex = 2;
            this.icbColors.Target = VastGIS.Plugins.Symbology.SchemeTarget.Vector;
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.Location = new System.Drawing.Point(195, 28);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(52, 21);
            this.numericUpDownExt1.TabIndex = 1;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(112, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(207, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(303, 165);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCategoriesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加目录";
            this.Load += new System.EventHandler(this.AddCategoriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal NumericUpDownEx numericUpDownExt1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal ColorSchemeCombo icbColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.CheckBox chkRandom;
    }
}