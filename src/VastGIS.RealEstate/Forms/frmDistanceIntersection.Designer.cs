namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmDistanceIntersection
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
            this.btnPoint1 = new System.Windows.Forms.Button();
            this.txtPoint1 = new System.Windows.Forms.TextBox();
            this.ucSelectLayer1 = new VastGIS.Plugins.RealEstate.DataControls.ucSelectLayer();
            this.label1 = new System.Windows.Forms.Label();
            this.distPoint1 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.distPoint2 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoint2 = new System.Windows.Forms.TextBox();
            this.btnPoint2 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkCreate1 = new System.Windows.Forms.CheckBox();
            this.chkCreate2 = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.distPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distPoint2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint1
            // 
            this.btnPoint1.Location = new System.Drawing.Point(13, 54);
            this.btnPoint1.Name = "btnPoint1";
            this.btnPoint1.Size = new System.Drawing.Size(75, 23);
            this.btnPoint1.TabIndex = 1;
            this.btnPoint1.Text = "参考点一：";
            this.btnPoint1.UseVisualStyleBackColor = true;
            // 
            // txtPoint1
            // 
            this.txtPoint1.Location = new System.Drawing.Point(95, 54);
            this.txtPoint1.Name = "txtPoint1";
            this.txtPoint1.Size = new System.Drawing.Size(166, 21);
            this.txtPoint1.TabIndex = 2;
            // 
            // ucSelectLayer1
            // 
            this.ucSelectLayer1.GeometryType = VastGIS.Api.Enums.GeometryType.Point;
            this.ucSelectLayer1.Label = "目标图层";
            this.ucSelectLayer1.Location = new System.Drawing.Point(13, 13);
            this.ucSelectLayer1.Name = "ucSelectLayer1";
            this.ucSelectLayer1.SelectedClass = null;
            this.ucSelectLayer1.SelectedClasses = null;
            this.ucSelectLayer1.Size = new System.Drawing.Size(249, 35);
            this.ucSelectLayer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "距离：";
            // 
            // distPoint1
            // 
            this.distPoint1.BackGroundColor = System.Drawing.SystemColors.Window;
            this.distPoint1.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.distPoint1.DoubleValue = 1D;
            this.distPoint1.Location = new System.Drawing.Point(95, 86);
            this.distPoint1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.distPoint1.Name = "distPoint1";
            this.distPoint1.NullString = "";
            this.distPoint1.Size = new System.Drawing.Size(100, 21);
            this.distPoint1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.distPoint1.TabIndex = 4;
            this.distPoint1.Text = "1.00";
            // 
            // distPoint2
            // 
            this.distPoint2.BackGroundColor = System.Drawing.SystemColors.Window;
            this.distPoint2.BeforeTouchSize = new System.Drawing.Size(100, 21);
            this.distPoint2.DoubleValue = 1D;
            this.distPoint2.Location = new System.Drawing.Point(95, 145);
            this.distPoint2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.distPoint2.Name = "distPoint2";
            this.distPoint2.NullString = "";
            this.distPoint2.Size = new System.Drawing.Size(100, 21);
            this.distPoint2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.distPoint2.TabIndex = 8;
            this.distPoint2.Text = "1.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "距离：";
            // 
            // txtPoint2
            // 
            this.txtPoint2.Location = new System.Drawing.Point(95, 113);
            this.txtPoint2.Name = "txtPoint2";
            this.txtPoint2.Size = new System.Drawing.Size(166, 21);
            this.txtPoint2.TabIndex = 6;
            // 
            // btnPoint2
            // 
            this.btnPoint2.Location = new System.Drawing.Point(13, 113);
            this.btnPoint2.Name = "btnPoint2";
            this.btnPoint2.Size = new System.Drawing.Size(75, 23);
            this.btnPoint2.TabIndex = 5;
            this.btnPoint2.Text = "参考点二：";
            this.btnPoint2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(207, 143);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(55, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "求解";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // chkCreate1
            // 
            this.chkCreate1.AutoSize = true;
            this.chkCreate1.Location = new System.Drawing.Point(58, 181);
            this.chkCreate1.Name = "chkCreate1";
            this.chkCreate1.Size = new System.Drawing.Size(84, 16);
            this.chkCreate1.TabIndex = 21;
            this.chkCreate1.Text = "生成交点一";
            this.chkCreate1.UseVisualStyleBackColor = true;
            // 
            // chkCreate2
            // 
            this.chkCreate2.AutoSize = true;
            this.chkCreate2.Location = new System.Drawing.Point(166, 181);
            this.chkCreate2.Name = "chkCreate2";
            this.chkCreate2.Size = new System.Drawing.Size(84, 16);
            this.chkCreate2.TabIndex = 22;
            this.chkCreate2.Text = "生成交点二";
            this.chkCreate2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(119, 204);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCanel
            // 
            this.btnCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCanel.Location = new System.Drawing.Point(201, 204);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(60, 23);
            this.btnCanel.TabIndex = 24;
            this.btnCanel.Text = "退出";
            this.btnCanel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(12, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "清空参数";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmDistanceIntersection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.chkCreate2);
            this.Controls.Add(this.chkCreate1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.distPoint2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoint2);
            this.Controls.Add(this.btnPoint2);
            this.Controls.Add(this.distPoint1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoint1);
            this.Controls.Add(this.btnPoint1);
            this.Controls.Add(this.ucSelectLayer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistanceIntersection";
            this.Text = "距离交会";
            ((System.ComponentModel.ISupportInitialize)(this.distPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distPoint2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataControls.ucSelectLayer ucSelectLayer1;
        private System.Windows.Forms.Button btnPoint1;
        private System.Windows.Forms.TextBox txtPoint1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox distPoint1;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox distPoint2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoint2;
        private System.Windows.Forms.Button btnPoint2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkCreate1;
        private System.Windows.Forms.CheckBox chkCreate2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCanel;
        private System.Windows.Forms.Button btnClear;
    }
}