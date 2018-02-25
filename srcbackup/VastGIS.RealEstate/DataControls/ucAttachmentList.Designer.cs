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
            this.gridAttachments = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnNewAudio = new System.Windows.Forms.Button();
            this.btnNewVideo = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnNewPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachments)).BeginInit();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(3, 3);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "附件列表";
            // 
            // gridAttachments
            // 
            this.gridAttachments.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.gridAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAttachments.BackColor = System.Drawing.SystemColors.Window;
            this.gridAttachments.EnableTouchMode = true;
            this.gridAttachments.Location = new System.Drawing.Point(0, 18);
            this.gridAttachments.Name = "gridAttachments";
            this.gridAttachments.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridAttachments.Size = new System.Drawing.Size(215, 198);
            this.gridAttachments.TabIndex = 18;
            this.gridAttachments.TableDescriptor.TableOptions.CaptionRowHeight = 29;
            this.gridAttachments.TableOptions.AllowDragColumns = false;
            this.gridAttachments.TableOptions.AllowDropDownCell = false;
            this.gridAttachments.TableOptions.AllowMultiColumnSort = false;
            this.gridAttachments.TableOptions.AllowSortColumns = false;
            this.gridAttachments.UseRightToLeftCompatibleTextBox = true;
            this.gridAttachments.VersionInfo = "15.1460.0.33";
            this.gridAttachments.SelectedRecordsChanged += new Syncfusion.Grouping.SelectedRecordsChangedEventHandler(this.gridAttachments_SelectedRecordsChanged);
            // 
            // panButtons
            // 
            this.panButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panButtons.Controls.Add(this.btnNewAudio);
            this.panButtons.Controls.Add(this.btnNewVideo);
            this.panButtons.Controls.Add(this.btnSaveAs);
            this.panButtons.Controls.Add(this.btnDelete);
            this.panButtons.Controls.Add(this.btnView);
            this.panButtons.Controls.Add(this.btnNewPhoto);
            this.panButtons.Location = new System.Drawing.Point(0, 216);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(215, 38);
            this.panButtons.TabIndex = 19;
            // 
            // btnNewAudio
            // 
            this.btnNewAudio.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttachmentAudio;
            this.btnNewAudio.Location = new System.Drawing.Point(72, 1);
            this.btnNewAudio.Name = "btnNewAudio";
            this.btnNewAudio.Size = new System.Drawing.Size(28, 34);
            this.btnNewAudio.TabIndex = 5;
            this.btnNewAudio.UseVisualStyleBackColor = true;
            // 
            // btnNewVideo
            // 
            this.btnNewVideo.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttachmentVideo;
            this.btnNewVideo.Location = new System.Drawing.Point(39, 1);
            this.btnNewVideo.Name = "btnNewVideo";
            this.btnNewVideo.Size = new System.Drawing.Size(28, 34);
            this.btnNewVideo.TabIndex = 4;
            this.btnNewVideo.UseVisualStyleBackColor = true;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentSaveAs;
            this.btnSaveAs.Location = new System.Drawing.Point(171, 1);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(28, 34);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentDelete;
            this.btnDelete.Location = new System.Drawing.Point(138, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentView;
            this.btnView.Location = new System.Drawing.Point(105, 1);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(28, 34);
            this.btnView.TabIndex = 1;
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnNewPhoto
            // 
            this.btnNewPhoto.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.AttchmentNew;
            this.btnNewPhoto.Location = new System.Drawing.Point(6, 1);
            this.btnNewPhoto.Name = "btnNewPhoto";
            this.btnNewPhoto.Size = new System.Drawing.Size(28, 34);
            this.btnNewPhoto.TabIndex = 0;
            this.btnNewPhoto.UseVisualStyleBackColor = true;
            this.btnNewPhoto.Click += new System.EventHandler(this.btnNewPhoto_Click);
            // 
            // ucAttachmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.gridAttachments);
            this.Controls.Add(this.lblList);
            this.Name = "ucAttachmentList";
            this.Size = new System.Drawing.Size(215, 254);
            this.Resize += new System.EventHandler(this.ucAttachmentList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttachments)).EndInit();
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridAttachments;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnNewPhoto;
        private System.Windows.Forms.Button btnNewAudio;
        private System.Windows.Forms.Button btnNewVideo;
    }
}
