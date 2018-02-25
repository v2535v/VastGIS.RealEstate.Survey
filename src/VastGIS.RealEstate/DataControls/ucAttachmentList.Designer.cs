namespace VastGIS.Plugins.RealEstate.DataControls
{
    partial class ucAttachmentList
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblList = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnAttribute = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnNewAudio = new System.Windows.Forms.Button();
            this.btnNewVideo = new System.Windows.Forms.Button();
            this.btnNewPhoto = new System.Windows.Forms.Button();
            this.gridAttachments = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblList, 8);
            this.lblList.Location = new System.Drawing.Point(9, 10);
            this.lblList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "附件列表";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAs, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAttribute, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnView, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnUpload, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewAudio, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewVideo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewPhoto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridAttachments, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblList, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 229);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentSaveAs;
            this.btnSaveAs.Location = new System.Drawing.Point(261, 182);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(28, 34);
            this.btnSaveAs.TabIndex = 27;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnAttribute
            // 
            this.btnAttribute.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.FeatureSX;
            this.btnAttribute.Location = new System.Drawing.Point(225, 182);
            this.btnAttribute.Name = "btnAttribute";
            this.btnAttribute.Size = new System.Drawing.Size(28, 34);
            this.btnAttribute.TabIndex = 26;
            this.btnAttribute.UseVisualStyleBackColor = true;
            this.btnAttribute.Click += new System.EventHandler(this.btnAttribute_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentDelete;
            this.btnDelete.Location = new System.Drawing.Point(189, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 34);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentView;
            this.btnView.Location = new System.Drawing.Point(153, 182);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(28, 34);
            this.btnView.TabIndex = 24;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentUpload;
            this.btnUpload.Location = new System.Drawing.Point(117, 182);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(28, 34);
            this.btnUpload.TabIndex = 23;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnNewAudio
            // 
            this.btnNewAudio.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttachmentAudio;
            this.btnNewAudio.Location = new System.Drawing.Point(81, 182);
            this.btnNewAudio.Name = "btnNewAudio";
            this.btnNewAudio.Size = new System.Drawing.Size(28, 34);
            this.btnNewAudio.TabIndex = 22;
            this.btnNewAudio.UseVisualStyleBackColor = true;
            this.btnNewAudio.Click += new System.EventHandler(this.btnNewAudio_Click);
            // 
            // btnNewVideo
            // 
            this.btnNewVideo.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttachmentVideo;
            this.btnNewVideo.Location = new System.Drawing.Point(45, 182);
            this.btnNewVideo.Name = "btnNewVideo";
            this.btnNewVideo.Size = new System.Drawing.Size(28, 34);
            this.btnNewVideo.TabIndex = 21;
            this.btnNewVideo.UseVisualStyleBackColor = true;
            this.btnNewVideo.Click += new System.EventHandler(this.btnNewVideo_Click);
            // 
            // btnNewPhoto
            // 
            this.btnNewPhoto.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentNew;
            this.btnNewPhoto.Location = new System.Drawing.Point(9, 182);
            this.btnNewPhoto.Name = "btnNewPhoto";
            this.btnNewPhoto.Size = new System.Drawing.Size(28, 34);
            this.btnNewPhoto.TabIndex = 20;
            this.btnNewPhoto.UseVisualStyleBackColor = true;
            this.btnNewPhoto.Click += new System.EventHandler(this.btnNewPhoto_Click);
            // 
            // gridAttachments
            // 
            this.gridAttachments.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridAttachments.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.gridAttachments, 8);
            this.gridAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAttachments.EnableTouchMode = true;
            this.gridAttachments.Location = new System.Drawing.Point(9, 33);
            this.gridAttachments.Name = "gridAttachments";
            this.gridAttachments.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridAttachments.Size = new System.Drawing.Size(282, 143);
            this.gridAttachments.TabIndex = 19;
            this.gridAttachments.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridAttachments.TableOptions.AllowDragColumns = false;
            this.gridAttachments.TableOptions.AllowDropDownCell = false;
            this.gridAttachments.TableOptions.AllowMultiColumnSort = false;
            this.gridAttachments.TableOptions.AllowSortColumns = false;
            this.gridAttachments.UseRightToLeftCompatibleTextBox = true;
            this.gridAttachments.VersionInfo = "15.1460.0.33";
            this.gridAttachments.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridAttachments_SelectedRecordsChanged);
            // 
            // ucAttachmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucAttachmentList";
            this.Size = new System.Drawing.Size(303, 229);
            this.Resize += new System.EventHandler(this.ucAttachmentList_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnAttribute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnNewAudio;
        private System.Windows.Forms.Button btnNewVideo;
        private System.Windows.Forms.Button btnNewPhoto;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridAttachments;
    }
}
