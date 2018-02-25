namespace VastGIS.Plugins.RealEstate.Viewer
{
    partial class frmVideoViewer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.myLblState = new System.Windows.Forms.Label();
            this.myLblMediaLength = new System.Windows.Forms.Label();
            this.myLblVlcPosition = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.myCbxAspectRatio = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.vlcControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myLblState, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.myLblMediaLength, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.myLblVlcPosition, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStop, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPause, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPlay, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.myCbxAspectRatio, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 405);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "屏幕：";
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.vlcControl1, 8);
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(3, 3);
            this.vlcControl1.Name = "vlcControl1";
            this.tableLayoutPanel1.SetRowSpan(this.vlcControl1, 2);
            this.vlcControl1.Size = new System.Drawing.Size(577, 359);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 7;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            this.vlcControl1.LengthChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs>(this.OnVlcMediaLengthChanged);
            this.vlcControl1.Log += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLogEventArgs>(this.OnVlcMediaPlayerLog);
            this.vlcControl1.Paused += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPausedEventArgs>(this.OnVlcPaused);
            this.vlcControl1.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.OnVlcPlaying);
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.OnVlcPositionChanged);
            this.vlcControl1.Stopped += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs>(this.OnVlcStopped);
            // 
            // myLblState
            // 
            this.myLblState.AutoSize = true;
            this.myLblState.Location = new System.Drawing.Point(444, 375);
            this.myLblState.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.myLblState.Name = "myLblState";
            this.myLblState.Size = new System.Drawing.Size(35, 12);
            this.myLblState.TabIndex = 10;
            this.myLblState.Text = "状态:";
            // 
            // myLblMediaLength
            // 
            this.myLblMediaLength.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLblMediaLength.AutoSize = true;
            this.myLblMediaLength.Location = new System.Drawing.Point(379, 375);
            this.myLblMediaLength.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.myLblMediaLength.Name = "myLblMediaLength";
            this.myLblMediaLength.Size = new System.Drawing.Size(59, 30);
            this.myLblMediaLength.TabIndex = 9;
            this.myLblMediaLength.Text = "00:00:00";
            // 
            // myLblVlcPosition
            // 
            this.myLblVlcPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLblVlcPosition.AutoSize = true;
            this.myLblVlcPosition.Location = new System.Drawing.Point(314, 375);
            this.myLblVlcPosition.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.myLblVlcPosition.Name = "myLblVlcPosition";
            this.myLblVlcPosition.Size = new System.Drawing.Size(59, 30);
            this.myLblVlcPosition.TabIndex = 8;
            this.myLblVlcPosition.Text = "00:00:00";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_stop;
            this.btnStop.Location = new System.Drawing.Point(279, 371);
            this.btnStop.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 31);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_pause;
            this.btnPause.Location = new System.Drawing.Point(239, 371);
            this.btnPause.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(29, 31);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::VastGIS.Plugins.RealEstate.Properties.Resources.img_play;
            this.btnPlay.Location = new System.Drawing.Point(199, 371);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(8, 6, 3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(29, 31);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // myCbxAspectRatio
            // 
            this.myCbxAspectRatio.Enabled = false;
            this.myCbxAspectRatio.FormattingEnabled = true;
            this.myCbxAspectRatio.Items.AddRange(new object[] {
            "16:9",
            "16:10",
            "4:3"});
            this.myCbxAspectRatio.Location = new System.Drawing.Point(53, 373);
            this.myCbxAspectRatio.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.myCbxAspectRatio.Name = "myCbxAspectRatio";
            this.myCbxAspectRatio.Size = new System.Drawing.Size(121, 20);
            this.myCbxAspectRatio.TabIndex = 12;
            this.myCbxAspectRatio.TextChanged += new System.EventHandler(this.myCbxAspectRatio_TextChanged);
            // 
            // frmVideoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmVideoViewer";
            this.Text = "视频播放器";
            this.SizeChanged += new System.EventHandler(this.frmVideoViewer_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Label myLblVlcPosition;
        private System.Windows.Forms.Label myLblMediaLength;
        private System.Windows.Forms.Label myLblState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox myCbxAspectRatio;
    }
}