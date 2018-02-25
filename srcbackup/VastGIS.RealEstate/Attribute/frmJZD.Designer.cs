using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;
namespace VastGIS.Plugins.RealEstate.Attribute
{
    partial class frmJZD
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
            this.tabAttribute = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.pageMain = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pageWXInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pageAttachment = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucWXInfo1 = new VastGIS.Plugins.RealEstate.DataControls.ucWXInfo();
            this.ucAttachmentList1 = new VastGIS.Plugins.RealEstate.DataControls.ucAttachmentList();
            this.ucLinkObject = new VastGIS.Plugins.RealEstate.DataControls.ucJZD();
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).BeginInit();
            this.tabAttribute.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageWXInfo.SuspendLayout();
            this.pageAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAttribute
            // 
            this.tabAttribute.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.BeforeTouchSize = new System.Drawing.Size(264, 407);
            this.tabAttribute.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.Controls.Add(this.pageMain);
            this.tabAttribute.Controls.Add(this.pageWXInfo);
            this.tabAttribute.Controls.Add(this.pageAttachment);
            this.tabAttribute.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabAttribute.Location = new System.Drawing.Point(-1, -1);
            this.tabAttribute.Name = "tabAttribute";
            this.tabAttribute.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabAttribute.ShowSeparator = false;
            this.tabAttribute.Size = new System.Drawing.Size(264, 407);
            this.tabAttribute.TabIndex = 0;
            // 
            // pageMain
            // 
            this.pageMain.Controls.Add(this.ucLinkObject);
            this.pageMain.Image = null;
            this.pageMain.ImageSize = new System.Drawing.Size(16, 16);
            this.pageMain.Location = new System.Drawing.Point(1, 24);
            this.pageMain.Name = "pageMain";
            this.pageMain.ShowCloseButton = true;
            this.pageMain.Size = new System.Drawing.Size(261, 381);
            this.pageMain.TabIndex = 1;
            this.pageMain.Text = "属性";
            this.pageMain.ThemesEnabled = false;
            // 
            // pageWXInfo
            // 
            this.pageWXInfo.Controls.Add(this.ucWXInfo1);
            this.pageWXInfo.Image = null;
            this.pageWXInfo.ImageSize = new System.Drawing.Size(16, 16);
            this.pageWXInfo.Location = new System.Drawing.Point(1, 24);
            this.pageWXInfo.Name = "pageWXInfo";
            this.pageWXInfo.ShowCloseButton = true;
            this.pageWXInfo.Size = new System.Drawing.Size(261, 381);
            this.pageWXInfo.TabIndex = 2;
            this.pageWXInfo.Text = "作业信息";
            this.pageWXInfo.ThemesEnabled = false;
             // 
            // pageAttachment
            // 
            this.pageAttachment.Controls.Add(this.ucAttachmentList1);
            this.pageAttachment.Image = null;
            this.pageAttachment.ImageSize = new System.Drawing.Size(16, 16);
            this.pageAttachment.Location = new System.Drawing.Point(1, 24);
            this.pageAttachment.Name = "pageAttachment";
            this.pageAttachment.ShowCloseButton = true;
            this.pageAttachment.Size = new System.Drawing.Size(261, 381);
            this.pageAttachment.TabIndex = 3;
            this.pageAttachment.Text = "附件";
            this.pageAttachment.ThemesEnabled = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(174, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(45, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucWXInfo1
            // 
            this.ucWXInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucWXInfo1.Name = "ucWXInfo1";
            this.ucWXInfo1.Size = new System.Drawing.Size(232, 214);
            this.ucWXInfo1.TabIndex = 0;
             // 
            // ucAttachmentList1
            // 
            this.ucAttachmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAttachmentList1.Location = new System.Drawing.Point(0, 0);
            this.ucAttachmentList1.Name = "ucAttachmentList1";
            this.ucAttachmentList1.Size = new System.Drawing.Size(261, 381);
            this.ucAttachmentList1.TabIndex = 0;
            // 
            // ucLinkObject
            // 
            this.ucLinkObject.Location = new System.Drawing.Point(0, 0);
            this.ucLinkObject.Name = "ucLinkObject";
            this.ucLinkObject.Size = new System.Drawing.Size(260, 380);
            this.ucLinkObject.TabIndex = 0;
            // 
            // frmJZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabAttribute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJZD";
            this.Text = "界址点属性";
            ((System.ComponentModel.ISupportInitialize)(this.tabAttribute)).EndInit();
            this.tabAttribute.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageWXInfo.ResumeLayout(false);
            this.pageAttachment.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
        
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabAttribute;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageMain;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageWXInfo;        
        private DataControls.ucWXInfo ucWXInfo1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv pageAttachment;        
        private DataControls.ucAttachmentList ucAttachmentList1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private DataControls.ucJZD ucLinkObject;
    }

}