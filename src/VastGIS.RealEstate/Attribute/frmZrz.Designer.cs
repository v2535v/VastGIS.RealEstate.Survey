using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    partial class frmZrz
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
        private void InitializeComponent()
        { 
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabAttribute = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageMain = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucLinkObject = new VastGIS.Plugins.RealEstate.DataControls.ucZrz();
            this.pageWXInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucWXInfo1 = new VastGIS.Plugins.RealEstate.DataControls.ucWXInfo();
            this.pageAttachment = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucAttachmentList1 = new VastGIS.Plugins.RealEstate.DataControls.ucAttachmentList();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pageC = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intQSCS = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.intJSCS = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.btnDeleteC = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDeleteCAll = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCreateC = new Syncfusion.Windows.Forms.ButtonAdv();
            this.lstC = new System.Windows.Forms.ListBox();
            this.ucC1 = new VastGIS.Plugins.RealEstate.DataControls.ucC();
            this.btnSaveC = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnOpenCForm = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).BeginInit();
            this.tabAttribute.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageWXInfo.SuspendLayout();
            this.pageAttachment.SuspendLayout();
            this.pageC.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intQSCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intJSCS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tabAttribute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 394);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabAttribute
            // 
            this.tabAttribute.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.BeforeTouchSize = new System.Drawing.Size(724, 348);
            this.tabAttribute.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel1.SetColumnSpan(this.tabAttribute, 3);
            this.tabAttribute.Controls.Add(this.pageMain);
            this.tabAttribute.Controls.Add(this.pageWXInfo);
            this.tabAttribute.Controls.Add(this.pageAttachment);
            this.tabAttribute.Controls.Add(this.pageC);
            this.tabAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAttribute.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.Location = new System.Drawing.Point(3, 3);
            this.tabAttribute.Name = "tabAttribute";
            this.tabAttribute.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabAttribute.ShowSeparator = false;
            this.tabAttribute.Size = new System.Drawing.Size(724, 348);
            this.tabAttribute.TabIndex = 4;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.ucLinkObject);
            this.pageMain.Image = null;
            this.pageMain.ImageSize = new System.Drawing.Size(16, 16);
            this.pageMain.Location = new System.Drawing.Point(1, 24);
            this.pageMain.Name = "pageMain";
            this.pageMain.ShowCloseButton = true;
            this.pageMain.Size = new System.Drawing.Size(721, 322);
            this.pageMain.TabIndex = 5;
            this.pageMain.Text = "属性";
            this.pageMain.ThemesEnabled = false;
            // 
            // ucLinkObject
            // 
            this.ucLinkObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkObject.Location = new System.Drawing.Point(0, 0);
            this.ucLinkObject.Name = "ucLinkObject";
            this.ucLinkObject.Size = new System.Drawing.Size(721, 322);
            this.ucLinkObject.TabIndex = 8;
            // 
            // pageWXInfo
            // 
            this.pageWXInfo.Controls.Add(this.ucWXInfo1);
            this.pageWXInfo.Image = null;
            this.pageWXInfo.ImageSize = new System.Drawing.Size(16, 16);
            this.pageWXInfo.Location = new System.Drawing.Point(1, 24);
            this.pageWXInfo.Name = "pageWXInfo";
            this.pageWXInfo.ShowCloseButton = true;
            this.pageWXInfo.Size = new System.Drawing.Size(721, 322);
            this.pageWXInfo.TabIndex = 6;
            this.pageWXInfo.Text = "作业信息";
            this.pageWXInfo.ThemesEnabled = false;
            // 
            // ucWXInfo1
            // 
            this.ucWXInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucWXInfo1.Name = "ucWXInfo1";
            this.ucWXInfo1.Size = new System.Drawing.Size(232, 214);
            this.ucWXInfo1.TabIndex = 0;
            // 
            // pageAttachment
            // 
            this.pageAttachment.Controls.Add(this.ucAttachmentList1);
            this.pageAttachment.Image = null;
            this.pageAttachment.ImageSize = new System.Drawing.Size(16, 16);
            this.pageAttachment.Location = new System.Drawing.Point(1, 24);
            this.pageAttachment.Name = "pageAttachment";
            this.pageAttachment.ShowCloseButton = true;
            this.pageAttachment.Size = new System.Drawing.Size(721, 322);
            this.pageAttachment.TabIndex = 7;
            this.pageAttachment.Text = "附件";
            this.pageAttachment.ThemesEnabled = false;
            // 
            // ucAttachmentList1
            // 
            this.ucAttachmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAttachmentList1.Location = new System.Drawing.Point(0, 0);
            this.ucAttachmentList1.Name = "ucAttachmentList1";
            this.ucAttachmentList1.Size = new System.Drawing.Size(721, 322);
            this.ucAttachmentList1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(652, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(552, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pageC
            // 
            this.pageC.Controls.Add(this.tableLayoutPanel2);
            this.pageC.Image = null;
            this.pageC.ImageSize = new System.Drawing.Size(16, 16);
            this.pageC.Location = new System.Drawing.Point(1, 24);
            this.pageC.Name = "pageC";
            this.pageC.ShowCloseButton = true;
            this.pageC.Size = new System.Drawing.Size(721, 322);
            this.pageC.TabIndex = 8;
            this.pageC.Text = "层信息";
            this.pageC.ThemesEnabled = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.intQSCS, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.intJSCS, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteC, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteCAll, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCreateC, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lstC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ucC1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveC, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOpenCForm, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(721, 322);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始层数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束层数";
            // 
            // intQSCS
            // 
            this.intQSCS.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intQSCS.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intQSCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intQSCS.EnableTouchMode = true;
            this.intQSCS.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intQSCS.IntegerValue = ((long)(1));
            this.intQSCS.Location = new System.Drawing.Point(3, 33);
            this.intQSCS.MaxValue = ((long)(200));
            this.intQSCS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intQSCS.MinValue = ((long)(-10));
            this.intQSCS.Name = "intQSCS";
            this.intQSCS.NullString = "";
            this.intQSCS.Size = new System.Drawing.Size(64, 28);
            this.intQSCS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intQSCS.TabIndex = 2;
            this.intQSCS.Text = "1";
            // 
            // intJSCS
            // 
            this.intJSCS.BackGroundColor = System.Drawing.SystemColors.Window;
            this.intJSCS.BeforeTouchSize = new System.Drawing.Size(152, 21);
            this.intJSCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intJSCS.EnableTouchMode = true;
            this.intJSCS.Font = new System.Drawing.Font("SimSun", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intJSCS.IntegerValue = ((long)(1));
            this.intJSCS.Location = new System.Drawing.Point(73, 33);
            this.intJSCS.MaxValue = ((long)(200));
            this.intJSCS.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.intJSCS.MinValue = ((long)(-10));
            this.intJSCS.Name = "intJSCS";
            this.intJSCS.NullString = "";
            this.intJSCS.Size = new System.Drawing.Size(64, 28);
            this.intJSCS.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.intJSCS.TabIndex = 3;
            this.intJSCS.Text = "1";
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.BeforeTouchSize = new System.Drawing.Size(54, 23);
            this.btnDeleteC.EnableTouchMode = true;
            this.btnDeleteC.IsBackStageButton = false;
            this.btnDeleteC.Location = new System.Drawing.Point(3, 285);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteC.TabIndex = 5;
            this.btnDeleteC.Text = "删除";
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // btnDeleteCAll
            // 
            this.btnDeleteCAll.BeforeTouchSize = new System.Drawing.Size(54, 23);
            this.btnDeleteCAll.EnableTouchMode = true;
            this.btnDeleteCAll.IsBackStageButton = false;
            this.btnDeleteCAll.Location = new System.Drawing.Point(73, 285);
            this.btnDeleteCAll.Name = "btnDeleteCAll";
            this.btnDeleteCAll.Size = new System.Drawing.Size(64, 34);
            this.btnDeleteCAll.TabIndex = 6;
            this.btnDeleteCAll.Text = "全部删除";
            this.btnDeleteCAll.Click += new System.EventHandler(this.btnDeleteCAll_Click);
            // 
            // btnCreateC
            // 
            this.btnCreateC.BeforeTouchSize = new System.Drawing.Size(74, 23);
            this.btnCreateC.EnableTouchMode = true;
            this.btnCreateC.IsBackStageButton = false;
            this.btnCreateC.Location = new System.Drawing.Point(143, 33);
            this.btnCreateC.Name = "btnCreateC";
            this.btnCreateC.Size = new System.Drawing.Size(74, 29);
            this.btnCreateC.TabIndex = 7;
            this.btnCreateC.Text = "生成";
            this.btnCreateC.Click += new System.EventHandler(this.btnCreateC_Click);
            // 
            // lstC
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.lstC, 3);
            this.lstC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstC.FormattingEnabled = true;
            this.lstC.ItemHeight = 12;
            this.lstC.Location = new System.Drawing.Point(3, 68);
            this.lstC.Name = "lstC";
            this.lstC.Size = new System.Drawing.Size(214, 211);
            this.lstC.TabIndex = 8;
            this.lstC.SelectedIndexChanged += new System.EventHandler(this.lstC_SelectedIndexChanged);
            // 
            // ucC1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.ucC1, 2);
            this.ucC1.Location = new System.Drawing.Point(223, 3);
            this.ucC1.Name = "ucC1";
            this.tableLayoutPanel2.SetRowSpan(this.ucC1, 3);
            this.ucC1.Size = new System.Drawing.Size(495, 276);
            this.ucC1.TabIndex = 9;
            // 
            // btnSaveC
            // 
            this.btnSaveC.BeforeTouchSize = new System.Drawing.Size(74, 23);
            this.btnSaveC.EnableTouchMode = true;
            this.btnSaveC.IsBackStageButton = false;
            this.btnSaveC.Location = new System.Drawing.Point(644, 285);
            this.btnSaveC.Name = "btnSaveC";
            this.btnSaveC.Size = new System.Drawing.Size(74, 34);
            this.btnSaveC.TabIndex = 10;
            this.btnSaveC.Text = "保存层信息";
            this.btnSaveC.Click += new System.EventHandler(this.btnSaveC_Click);
            // 
            // btnOpenCForm
            // 
            this.btnOpenCForm.BeforeTouchSize = new System.Drawing.Size(74, 23);
            this.btnOpenCForm.EnableTouchMode = true;
            this.btnOpenCForm.IsBackStageButton = false;
            this.btnOpenCForm.Location = new System.Drawing.Point(143, 285);
            this.btnOpenCForm.Name = "btnOpenCForm";
            this.btnOpenCForm.Size = new System.Drawing.Size(74, 34);
            this.btnOpenCForm.TabIndex = 11;
            this.btnOpenCForm.Text = "打开层窗体";
            this.btnOpenCForm.Click += new System.EventHandler(this.btnOpenCForm_Click);
            // 
            // frmZrz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZrz";
            this.Text = "自然幢属性";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).EndInit();
            this.tabAttribute.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageWXInfo.ResumeLayout(false);
            this.pageAttachment.ResumeLayout(false);
            this.pageC.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intQSCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intJSCS)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabAttribute;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageMain;
        private DataControls.ucZrz ucLinkObject;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageWXInfo;
        private DataControls.ucWXInfo ucWXInfo1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageAttachment;
        private DataControls.ucAttachmentList ucAttachmentList1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intQSCS;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox intJSCS;
        private Syncfusion.Windows.Forms.ButtonAdv btnDeleteC;
        private Syncfusion.Windows.Forms.ButtonAdv btnDeleteCAll;
        private Syncfusion.Windows.Forms.ButtonAdv btnCreateC;
        private System.Windows.Forms.ListBox lstC;
        private DataControls.ucC ucC1;
        private Syncfusion.Windows.Forms.ButtonAdv btnSaveC;
        private Syncfusion.Windows.Forms.ButtonAdv btnOpenCForm;
    }
}