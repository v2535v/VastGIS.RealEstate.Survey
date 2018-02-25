using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops.Signatures;

namespace VastGIS.Plugins.RealEstate.Viewer
{
    public partial class frmVideoViewer : Form
    {
        private List<string> _videos;
        private int _currentVideIndex;
        private string _videoPath;
       
        private bool is_playinig_;
        private bool is_pausing;
        public frmVideoViewer()
        {
            InitializeComponent();
        }

        public int CurrentVideoIndex
        {
            get { return _currentVideIndex; }
            set
            {
                if (_videos == null || _videos.Count == 0) return;
                _currentVideIndex = value;
                this.VideoPath = _videos[value];
            }
        }
        public void LoadVideos(List<string> files, string currFile)
        {
            if(_videos==null) _videos=new List<string>();
            _videos.AddRange(files);
            for(int i = 0; i < _videos.Count; i++)
            {
                if (_videos[i] == currFile)
                {
                    CurrentVideoIndex = i;
                    return;
                }
            }
        }

        private string VideoPath
        {
            get { return _videoPath; }
            set
            {
                _videoPath = value;
                //btnPlay.Enabled = File.Exists(value);
                //btnPause.Enabled = btnStop.Enabled = !btnPlay.Enabled;
            }
        }

        private void InitStatus()
        {
            btnPause.Enabled = is_pausing == false && is_playinig_;
            btnStop.Enabled = is_pausing == true && is_playinig_;
            btnPlay.Enabled =! is_playinig_ || is_pausing==true;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (File.Exists(_videoPath))
            {
                FileInfo fileInfo=new FileInfo(_videoPath);
                this.Text = "视频播放器-" + fileInfo.Name;
              vlcControl1.Play(fileInfo);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
          vlcControl1.Stop();
        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            //var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = Environment.CurrentDirectory;
            // Default libraries are stored here, but they are old, don't use them.
            // We need a better way to install them, see https://github.com/ZeBobo5/Vlc.DotNet/issues/288
            if (IntPtr.Size == 4)
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"Plugins\Media\x86\"));
            else
                e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, @"Plugins\Media\x64\"));

            if (!e.VlcLibDirectory.Exists)
            {
                var folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "选择多媒体支持库所在目录.";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    e.VlcLibDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void OnButtonPauseClicked(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void OnVlcMediaLengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            myLblMediaLength.InvokeIfRequired(l => l.Text = new DateTime(new TimeSpan((long)e.NewLength).Ticks).ToString("T"));
        }

        private void OnVlcPositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
        {
            var position = vlcControl1.GetCurrentMedia().Duration.Ticks * e.NewPosition;
            myLblVlcPosition.InvokeIfRequired(l => l.Text = new DateTime((long)position).ToString("T"));
        }
        private void frmVideoViewer_SizeChanged(object sender, EventArgs e)
        {
            ResizeVlcControl();
        }

        void ResizeVlcControl()
        {
            if (!string.IsNullOrEmpty(myCbxAspectRatio.Text))
            {
                var ratio = myCbxAspectRatio.Text.Split(':');
                int width, height;
                if (ratio.Length == 2 && int.TryParse(ratio[0], out width) && int.TryParse(ratio[1], out height))
                    vlcControl1.Width = vlcControl1.Height * width / height;
            }
        }
        private void OnVlcPaused(object sender, VlcMediaPlayerPausedEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "状态：暂停中");
        }
        private void OnVlcMediaPlayerLog(object sender, VlcMediaPlayerLogEventArgs e)
        {
            string message = string.Format("libVlc : {0} {1} @ {2}", e.Level, e.Message, e.Module);
            System.Diagnostics.Debug.WriteLine(message);
        }
        private void OnVlcStopped(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "停止");

            myCbxAspectRatio.InvokeIfRequired(c =>
                {
                    c.Text = string.Empty;
                    c.Enabled = false;
                });
            //ControlExtensions.InvokeIfRequired(myLblAudioCodec, c => c.Text = "Codec: ");
            //ControlExtensions.InvokeIfRequired(myLblAudioChannels, c => c.Text = "Channels: ");
            //ControlExtensions.InvokeIfRequired(myLblAudioRate, c => c.Text = "Rate: ");
            //ControlExtensions.InvokeIfRequired(myLblVideoCodec, c => c.Text = "Codec: ");
            //ControlExtensions.InvokeIfRequired(myLblVideoHeight, c => c.Text = "Height: ");
            //ControlExtensions.InvokeIfRequired(myLblVideoWidth, c => c.Text = "Width: ");
        }

        private void OnVlcPlaying(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            myLblState.InvokeIfRequired(l => l.Text = "播放中");

            //myLblAudioCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            //myLblAudioChannels.InvokeIfRequired(l => l.Text = "Channels: ");
            //myLblAudioRate.InvokeIfRequired(l => l.Text = "Rate: ");
            //myLblVideoCodec.InvokeIfRequired(l => l.Text = "Codec: ");
            //myLblVideoHeight.InvokeIfRequired(l => l.Text = "Height: ");
            //myLblVideoWidth.InvokeIfRequired(l => l.Text = "Width: ");

            var mediaInformations = vlcControl1.GetCurrentMedia().TracksInformations;
            foreach (var mediaInformation in mediaInformations)
            {
                if (mediaInformation.Type == MediaTrackTypes.Audio)
                {
                    //myLblAudioCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    //myLblAudioChannels.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Channels);
                    //myLblAudioRate.InvokeIfRequired(l => l.Text += mediaInformation.Audio.Rate);
                }
                else if (mediaInformation.Type == MediaTrackTypes.Video)
                {
                    //myLblVideoCodec.InvokeIfRequired(l => l.Text += mediaInformation.CodecName);
                    //myLblVideoHeight.InvokeIfRequired(l => l.Text += mediaInformation.Video.Height);
                    //myLblVideoWidth.InvokeIfRequired(l => l.Text += mediaInformation.Video.Width);
                }
            }

            myCbxAspectRatio.InvokeIfRequired(c =>
                {
                    c.Text = vlcControl1.Video.AspectRatio;
                    c.Enabled = true;
                });
        }

        private void myCbxAspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void myCbxAspectRatio_TextChanged(object sender, EventArgs e)
        {
            vlcControl1.Video.AspectRatio = myCbxAspectRatio.Text;
            ResizeVlcControl();
        }
    }

    public static class ControlExtensions
    {
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
            where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.Invoke(new Action(() => action(source)));
            }
            catch (Exception ex)
            {
                Debug.Write("Error on 'InvokeIfRequired': {0}", ex.Message);
            }
            return source;
        }
    }
}
