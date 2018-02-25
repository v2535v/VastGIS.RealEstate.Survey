using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Viewer
{
    public partial class frmAudioViewer : Form
    {
        private readonly MusicPlayer _musicPlayer = new MusicPlayer();
        private bool _stopSliderUpdate;
        private List<VgAttachment> _attachments;
        private IREDatabase _database;
        private string _currentAudio;
        private readonly ObservableCollection<MMDevice> _devices = new ObservableCollection<MMDevice>();
        public frmAudioViewer(IREDatabase database)
        {
            InitializeComponent();
            _database = database;
            components = new Container();
            components.Add(_musicPlayer);
            _musicPlayer.PlaybackStopped += (s, args) =>
                {
                    //WasapiOut uses SynchronizationContext.Post to raise the event
                    //There might be already a new WasapiOut-instance in the background when the async Post method brings the PlaybackStopped-Event to us.
                    if (_musicPlayer.PlaybackState != PlaybackState.Stopped)
                        btnPlay.Enabled = btnStop.Enabled = btnPause.Enabled = false;
                };
        }

        public void LoadAttachments(List<VgAttachment> attachments, long id=0)
        {
            _attachments = attachments;
            lstAudios.DataSource = _attachments;
            lstAudios.DisplayMember = "Fjmc";
            lstAudios.ValueMember = "Fjlj";
            if (_attachments == null) return;
            for (int i = 0; i < _attachments.Count; i++)
            {
                if (_attachments[i].ID == id)
                {
                    lstAudios.SelectedIndex = i;
                    return;
                }
            }
        }

        private void lstAudios_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstAudios.SelectedIndex == -1) return;
            string fileName = _database.GetAbsolutePath(lstAudios.SelectedValue.ToString());
            try
            {
                if (_musicPlayer.PlaybackState == PlaybackState.Playing)
                {
                    _musicPlayer.Stop();
                }
                _musicPlayer.Open(fileName, (MMDevice)cmbDevices.SelectedItem);
                trackbarVolume.Value = _musicPlayer.Volume;
                btnPlay.Enabled = true;
                btnPause.Enabled = btnStop.Enabled = false;
                _currentAudio = fileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("不能打开音频文件: " + ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_musicPlayer.PlaybackState != PlaybackState.Playing)
            {
                _musicPlayer.Play();
                btnPlay.Enabled =lstAudios.Enabled=btnClose.Enabled= false;
                btnPause.Enabled = btnStop.Enabled = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_musicPlayer.PlaybackState == PlaybackState.Playing)
            {
                _musicPlayer.Pause();
                btnPause.Enabled = false;
                btnPlay.Enabled = btnStop.Enabled = btnClose.Enabled = lstAudios.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_musicPlayer.PlaybackState != PlaybackState.Stopped)
            {
                _musicPlayer.Stop();
                btnPlay.Enabled = btnStop.Enabled = btnPause.Enabled = btnClose.Enabled = lstAudios.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan position = _musicPlayer.Position;
            TimeSpan length = _musicPlayer.Length;
            if (position > length)
                length = position;

            lblPosition.Text = String.Format(@"{0:mm\:ss} / {1:mm\:ss}", position, length);

            if (!_stopSliderUpdate &&
                length != TimeSpan.Zero && position != TimeSpan.Zero)
            {
                double perc = position.TotalMilliseconds / length.TotalMilliseconds * trackBar1.Maximum;
                trackBar1.Value = (int)perc;
            }
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _stopSliderUpdate = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (_stopSliderUpdate)
            {
                double perc = trackBar1.Value / (double)trackBar1.Maximum;
                TimeSpan position = TimeSpan.FromMilliseconds(_musicPlayer.Length.TotalMilliseconds * perc);
                _musicPlayer.Position = position;
            }
        }

        private void frmAudioPlayer_Load(object sender, EventArgs e)
        {
            using (var mmdeviceEnumerator = new MMDeviceEnumerator())
            {
                using (
                    var mmdeviceCollection = mmdeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                {
                    foreach (var device in mmdeviceCollection)
                    {
                        _devices.Add(device);
                    }
                }
            }

            cmbDevices.DataSource = _devices;
            cmbDevices.DisplayMember = "FriendlyName";
            cmbDevices.ValueMember = "DeviceID";
        }

        private void trackbarVolume_ValueChanged(object sender, EventArgs e)
        {
            _musicPlayer.Volume = trackbarVolume.Value;
        }
    }
}
