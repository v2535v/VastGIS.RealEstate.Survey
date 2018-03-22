namespace VastGIS.Plugins.RealEstate.Forms
{
    partial class frmSetEditLayers
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemove = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnRemoveAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOK = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lstAllLayers = new System.Windows.Forms.ListBox();
            this.lstEditLayers = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(306, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "编辑图层：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "全部图层：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstAllLayers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstEditLayers, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSelect, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnRemoveAll, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(256, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(44, 316);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.BeforeTouchSize = new System.Drawing.Size(38, 24);
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.EnableTouchMode = true;
            this.btnSelect.IsBackStageButton = false;
            this.btnSelect.Location = new System.Drawing.Point(3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(38, 44);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = ">";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BeforeTouchSize = new System.Drawing.Size(38, 24);
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.EnableTouchMode = true;
            this.btnRemove.IsBackStageButton = false;
            this.btnRemove.Location = new System.Drawing.Point(3, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(38, 44);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BeforeTouchSize = new System.Drawing.Size(38, 24);
            this.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveAll.EnableTouchMode = true;
            this.btnRemoveAll.IsBackStageButton = false;
            this.btnRemoveAll.Location = new System.Drawing.Point(3, 143);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(38, 44);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOK, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(306, 355);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 34);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.EnableTouchMode = true;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(133, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            // 
            // btnOK
            // 
            this.btnOK.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.EnableTouchMode = true;
            this.btnOK.IsBackStageButton = false;
            this.btnOK.Location = new System.Drawing.Point(9, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            // 
            // lstAllLayers
            // 
            this.lstAllLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAllLayers.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstAllLayers.FormattingEnabled = true;
            this.lstAllLayers.ItemHeight = 16;
            this.lstAllLayers.Location = new System.Drawing.Point(3, 33);
            this.lstAllLayers.Name = "lstAllLayers";
            this.lstAllLayers.Size = new System.Drawing.Size(247, 316);
            this.lstAllLayers.TabIndex = 6;
            // 
            // lstEditLayers
            // 
            this.lstEditLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEditLayers.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstEditLayers.FormattingEnabled = true;
            this.lstEditLayers.ItemHeight = 16;
            this.lstEditLayers.Location = new System.Drawing.Point(306, 33);
            this.lstEditLayers.Name = "lstEditLayers";
            this.lstEditLayers.Size = new System.Drawing.Size(248, 316);
            this.lstEditLayers.TabIndex = 7;
            // 
            // frmSetEditLayers
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(557, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSetEditLayers";
            this.Text = "编辑图层";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv btnSelect;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemove;
        private Syncfusion.Windows.Forms.ButtonAdv btnRemoveAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnOK;
        private System.Windows.Forms.ListBox lstAllLayers;
        private System.Windows.Forms.ListBox lstEditLayers;
    }
}