﻿using VastGIS.UI.Controls;

namespace VastGIS.Tiles.Views
{
    partial class WmsCapabilitiesView
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
            this.btnClose = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAdd = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cboServers = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.btnConnect = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnCreate = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnEdit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnDelete = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.wmsTreeView1 = new VastGIS.Tiles.Controls.WmsTreeView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cboServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmsTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.IsBackStageButton = false;
            this.btnClose.Location = new System.Drawing.Point(399, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnAdd.IsBackStageButton = false;
            this.btnAdd.Location = new System.Drawing.Point(318, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            // 
            // cboServers
            // 
            this.cboServers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServers.BeforeTouchSize = new System.Drawing.Size(370, 21);
            this.cboServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboServers.Location = new System.Drawing.Point(15, 27);
            this.cboServers.Name = "cboServers";
            this.cboServers.ShowImageInTextBox = true;
            this.cboServers.ShowImagesInComboListBox = true;
            this.cboServers.Size = new System.Drawing.Size(370, 21);
            this.cboServers.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnConnect.IsBackStageButton = false;
            this.btnConnect.Location = new System.Drawing.Point(391, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            // 
            // btnCreate
            // 
            this.btnCreate.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnCreate.IsBackStageButton = false;
            this.btnCreate.Location = new System.Drawing.Point(15, 54);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "New";
            // 
            // btnEdit
            // 
            this.btnEdit.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnEdit.IsBackStageButton = false;
            this.btnEdit.Location = new System.Drawing.Point(96, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnDelete.IsBackStageButton = false;
            this.btnDelete.Location = new System.Drawing.Point(177, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(479, 393);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Location = new System.Drawing.Point(3, 12);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(479, 393);
            this.tabControlAdv1.TabIndex = 8;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.wmsTreeView1);
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Controls.Add(this.btnDelete);
            this.tabPageAdv1.Controls.Add(this.btnEdit);
            this.tabPageAdv1.Controls.Add(this.cboServers);
            this.tabPageAdv1.Controls.Add(this.btnConnect);
            this.tabPageAdv1.Controls.Add(this.btnCreate);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(476, 366);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Layers";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // wmsTreeView1
            // 
            this.wmsTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmsTreeView1.ApplyStyle = true;
            this.wmsTreeView1.BeforeTouchSize = new System.Drawing.Size(451, 269);
            this.wmsTreeView1.BorderColor = System.Drawing.Color.DarkGray;
            this.wmsTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmsTreeView1.CanSelectDisabledNode = false;
            // 
            // 
            // 
            this.wmsTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmsTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.wmsTreeView1.HelpTextControl.Name = "helpText";
            this.wmsTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.wmsTreeView1.HelpTextControl.TabIndex = 0;
            this.wmsTreeView1.HelpTextControl.Text = "help text";
            this.wmsTreeView1.HideSelection = false;
            this.wmsTreeView1.Location = new System.Drawing.Point(15, 83);
            this.wmsTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.wmsTreeView1.Name = "wmsTreeView1";
            this.wmsTreeView1.ShowFocusRect = true;
            this.wmsTreeView1.ShowSuperTooltip = true;
            this.wmsTreeView1.Size = new System.Drawing.Size(451, 269);
            this.wmsTreeView1.TabIndex = 9;
            this.wmsTreeView1.Text = "wmsTreeView1";
            // 
            // 
            // 
            this.wmsTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.wmsTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wmsTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.wmsTreeView1.ToolTipControl.Name = "toolTip";
            this.wmsTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.wmsTreeView1.ToolTipControl.TabIndex = 1;
            this.wmsTreeView1.ToolTipControl.Text = "toolTip";
            this.wmsTreeView1.ToolTipDuration = 5000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server";
            // 
            // WmsCapabilitiesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(486, 439);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Name = "WmsCapabilitiesView";
            this.Text = "WMS Servers";
            ((System.ComponentModel.ISupportInitialize)(this.cboServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmsTreeView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv btnClose;
        private Syncfusion.Windows.Forms.ButtonAdv btnAdd;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cboServers;
        private Syncfusion.Windows.Forms.ButtonAdv btnConnect;
        private Syncfusion.Windows.Forms.ButtonAdv btnCreate;
        private Syncfusion.Windows.Forms.ButtonAdv btnEdit;
        private Syncfusion.Windows.Forms.ButtonAdv btnDelete;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private System.Windows.Forms.Label label1;
        private Controls.WmsTreeView wmsTreeView1;
    }
}