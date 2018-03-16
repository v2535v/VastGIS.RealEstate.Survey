namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmMeasure
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnStart = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnStop = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.Controls.Add(this.lblLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblY, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLength.Location = new System.Drawing.Point(8, 5);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(136, 33);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "总长度：";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArea.Location = new System.Drawing.Point(150, 5);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(136, 33);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "面积：";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblX.Location = new System.Drawing.Point(8, 38);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(136, 33);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X=";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblY.Location = new System.Drawing.Point(150, 38);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(136, 33);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y=";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.BeforeTouchSize = new System.Drawing.Size(74, 27);
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.EnableTouchMode = true;
            this.btnStart.IsBackStageButton = false;
            this.btnStart.Location = new System.Drawing.Point(292, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "重新开始";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BeforeTouchSize = new System.Drawing.Size(74, 27);
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.EnableTouchMode = true;
            this.btnStop.IsBackStageButton = false;
            this.btnStop.Location = new System.Drawing.Point(292, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(74, 27);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "结束";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 77);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeasure";
            this.Text = "量测信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMeasure_FormClosed);
            this.Load += new System.EventHandler(this.frmMeasure_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private Syncfusion.Windows.Forms.ButtonAdv btnStart;
        private Syncfusion.Windows.Forms.ButtonAdv btnStop;
    }
}