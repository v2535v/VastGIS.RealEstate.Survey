namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmQuickInput
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panelQlrs = new System.Windows.Forms.Panel();
            this.panelTemplates = new System.Windows.Forms.Panel();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.txtContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelQlrs, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panelTemplates, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv2, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(8, 8);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.tableLayoutPanel1.SetRowSpan(this.txtContent, 3);
            this.txtContent.Size = new System.Drawing.Size(646, 94);
            this.txtContent.TabIndex = 0;
            this.txtContent.Click += new System.EventHandler(this.txtContent_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.buttonAdv1.EnableTouchMode = true;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(660, 8);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(54, 34);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "清除";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // panelQlrs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelQlrs, 2);
            this.panelQlrs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQlrs.Location = new System.Drawing.Point(8, 113);
            this.panelQlrs.Name = "panelQlrs";
            this.panelQlrs.Size = new System.Drawing.Size(706, 34);
            this.panelQlrs.TabIndex = 2;
            // 
            // panelTemplates
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelTemplates, 2);
            this.panelTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemplates.Location = new System.Drawing.Point(8, 158);
            this.panelTemplates.Name = "panelTemplates";
            this.panelTemplates.Size = new System.Drawing.Size(706, 254);
            this.panelTemplates.TabIndex = 3;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(44, 23);
            this.buttonAdv2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdv2.EnableTouchMode = true;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.Location = new System.Drawing.Point(660, 68);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(54, 34);
            this.buttonAdv2.TabIndex = 4;
            this.buttonAdv2.Text = "确定";
            // 
            // frmQuickInput
            // 
            this.AcceptButton = this.buttonAdv2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQuickInput";
            this.Text = "快速录入";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtContent;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.Panel panelQlrs;
        private System.Windows.Forms.Panel panelTemplates;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
    }
}