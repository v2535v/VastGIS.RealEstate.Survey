using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    partial class frmFdcq2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.tabAttribute = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageMain = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucLinkObject = new VastGIS.Plugins.RealEstate.DataControls.ucFdcq2();
            this.pageWXInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucWXInfo1 = new VastGIS.Plugins.RealEstate.DataControls.ucWXInfo();
            this.pageAttachment = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucAttachmentList1 = new VastGIS.Plugins.RealEstate.DataControls.ucAttachmentList();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).BeginInit();
            this.tabAttribute.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageWXInfo.SuspendLayout();
            this.pageAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuery, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabAttribute, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1020, 355);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Enabled = false;
            this.btnQuery.Location = new System.Drawing.Point(453, 319);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 23);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查找";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(773, 319);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "新增";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(693, 319);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(613, 319);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(533, 319);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 23);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "上一个";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // tabAttribute
            // 
            this.tabAttribute.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.BeforeTouchSize = new System.Drawing.Size(1014, 309);
            this.tabAttribute.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel1.SetColumnSpan(this.tabAttribute, 8);
            this.tabAttribute.Controls.Add(this.pageMain);
            this.tabAttribute.Controls.Add(this.pageWXInfo);
            this.tabAttribute.Controls.Add(this.pageAttachment);
            this.tabAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAttribute.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.Location = new System.Drawing.Point(3, 3);
            this.tabAttribute.Name = "tabAttribute";
            this.tabAttribute.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabAttribute.ShowSeparator = false;
            this.tabAttribute.Size = new System.Drawing.Size(1014, 309);
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
            this.pageMain.Size = new System.Drawing.Size(1011, 283);
            this.pageMain.TabIndex = 5;
            this.pageMain.Text = "属性";
            this.pageMain.ThemesEnabled = false;
            // 
            // ucLinkObject
            // 
            this.ucLinkObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkObject.Location = new System.Drawing.Point(0, 0);
            this.ucLinkObject.Name = "ucLinkObject";
            this.ucLinkObject.Size = new System.Drawing.Size(1011, 283);
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
            this.pageWXInfo.Size = new System.Drawing.Size(1011, 283);
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
            this.pageAttachment.Size = new System.Drawing.Size(1011, 283);
            this.pageAttachment.TabIndex = 7;
            this.pageAttachment.Text = "附件";
            this.pageAttachment.ThemesEnabled = false;
            // 
            // ucAttachmentList1
            // 
            this.ucAttachmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAttachmentList1.Location = new System.Drawing.Point(0, 0);
            this.ucAttachmentList1.Name = "ucAttachmentList1";
            this.ucAttachmentList1.Size = new System.Drawing.Size(1011, 283);
            this.ucAttachmentList1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(933, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(853, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmFdcq2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFdcq2";
            this.Text = "房地产权（独幢、层、套、间房屋）属性";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).EndInit();
            this.tabAttribute.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageWXInfo.ResumeLayout(false);
            this.pageAttachment.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabAttribute;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageMain;
        private DataControls.ucFdcq2 ucLinkObject;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageWXInfo;
        private DataControls.ucWXInfo ucWXInfo1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageAttachment;
        private DataControls.ucAttachmentList ucAttachmentList1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnQuery;
    }
}