using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    partial class frmDjq
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
            this.tabAttribute = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageMain = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucLinkObject = new VastGIS.Plugins.RealEstate.DataControls.ucDjq();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 281);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabAttribute
            // 
            this.tabAttribute.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.BeforeTouchSize = new System.Drawing.Size(254, 235);
            this.tabAttribute.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel1.SetColumnSpan(this.tabAttribute, 3);
            this.tabAttribute.Controls.Add(this.pageMain);
            this.tabAttribute.Controls.Add(this.pageWXInfo);
            this.tabAttribute.Controls.Add(this.pageAttachment);
            this.tabAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAttribute.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.Location = new System.Drawing.Point(3, 3);
            this.tabAttribute.Name = "tabAttribute";
            this.tabAttribute.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabAttribute.ShowSeparator = false;
            this.tabAttribute.Size = new System.Drawing.Size(254, 235);
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
            this.pageMain.Size = new System.Drawing.Size(251, 209);
            this.pageMain.TabIndex = 5;
            this.pageMain.Text = "属性";
            this.pageMain.ThemesEnabled = false;
            // 
            // ucLinkObject
            // 
            this.ucLinkObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinkObject.Location = new System.Drawing.Point(0, 0);
            this.ucLinkObject.Name = "ucLinkObject";
            this.ucLinkObject.Size = new System.Drawing.Size(251, 209);
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
            this.pageWXInfo.Size = new System.Drawing.Size(251, 209);
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
            this.pageAttachment.Size = new System.Drawing.Size(251, 209);
            this.pageAttachment.TabIndex = 7;
            this.pageAttachment.Text = "附件";
            this.pageAttachment.ThemesEnabled = false;
            // 
            // ucAttachmentList1
            // 
            this.ucAttachmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAttachmentList1.Location = new System.Drawing.Point(0, 0);
            this.ucAttachmentList1.Name = "ucAttachmentList1";
            this.ucAttachmentList1.Size = new System.Drawing.Size(251, 209);
            this.ucAttachmentList1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(182, 245);
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
            this.btnSave.Location = new System.Drawing.Point(82, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDjq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 281);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDjq";
            this.Text = "地籍区属性";
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
        private DataControls.ucDjq ucLinkObject;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageWXInfo;
        private DataControls.ucWXInfo ucWXInfo1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageAttachment;
        private DataControls.ucAttachmentList ucAttachmentList1;
        
    }
}