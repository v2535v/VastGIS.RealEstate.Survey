using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using CSCore.Win32;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmAudioCapture : Form
    {
       
        private const CaptureMode CaptureMode = VastGIS.Plugins.RealEstate.Forms.CaptureMode.LoopbackCapture;

        private MMDevice _selectedDevice;
        private WasapiCapture _soundIn;
        private IWriteable _writer;
        private readonly GraphVisualization _graphVisualization = new GraphVisualization();
        private IWaveSource _finalSource;
        private BindingList<DeviceInformation> _deviceList;
        private string _currentAudio;
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private VgAttachment _attachment;
        
        public frmAudioCapture(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _deviceList =new BindingList<DeviceInformation>();
        }

        public VgAttachment GetAttachment()
        {
            _attachment = new VgAttachment();
            _attachment.Fjmc = Path.GetFileName(_currentAudio);
            _attachment.Fjsm =string.Format("现场音频，录制于{0}",DateTime.Now.ToString("yyyyMMdd hhmm"));
            _attachment.Fjlj = _database.GetRelativePath(_currentAudio);
            _attachment.Hqsj = DateTime.Now;
            _attachment.Fjlx = "XCYP";
            return _attachment;
        }
        public MMDevice SelectedDevice
        {
            get { return _selectedDevice; }
            set
            {
                _selectedDevice = value;
                if (value != null)
                    btnStart.Enabled = true;
            }
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            cmbDevices.Items.Clear();

            using (var deviceEnumerator = new MMDeviceEnumerator())
            using (var deviceCollection = deviceEnumerator.EnumAudioEndpoints(
                CaptureMode == CaptureMode.Capture ? DataFlow.Capture : DataFlow.Render, DeviceState.Active))
            {
                foreach (var device in deviceCollection)
                {
                    var deviceFormat = WaveFormatFromBlob(device.PropertyStore[
                        new PropertyKey(new Guid(0xf19f064d, 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c), 0)].BlobValue);

                    DeviceInformation item = new DeviceInformation(device.FriendlyName, device, deviceFormat.Channels.ToString(CultureInfo.InvariantCulture));
                    _deviceList.Add(item);
                }
            }
            cmbDevices.DataSource = _deviceList;
            cmbDevices.DisplayMember = "FriendlyName";
            cmbDevices.ValueMember = "Device";
            if (_deviceList.Count > 0)
            {
                cmbDevices.SelectedIndex = 0;
            }
        }

        private static WaveFormat WaveFormatFromBlob(Blob blob)
        {
            if (blob.Length == 40)
                return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormatExtensible));
            return (WaveFormat)Marshal.PtrToStructure(blob.Data, typeof(WaveFormat));
        }

        private void cmbDevices_Click(object sender, EventArgs e)
        {

        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDevices.SelectedIndex < 0)
            {
                SelectedDevice = null;
            }
            else
            {
                SelectedDevice = (MMDevice)_deviceList[cmbDevices.SelectedIndex].Device;
            }

        }

        private void frmAudioCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        private void StopCapture()
        {
            if (_soundIn != null)
            {
                _soundIn.Stop();
                _soundIn.Dispose();
                _soundIn = null;
                _finalSource.Dispose();

                if (_writer is IDisposable)
                    ((IDisposable)_writer).Dispose();

                btnStop.Enabled = false;
                btnStart.Enabled = true;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _currentAudio = _database.CreateAttachmentName() + ".wav";
                StartCapture(_currentAudio);
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

        }

        private void StartCapture(string fileName)
        {
            if (SelectedDevice == null)
                return;

            if (CaptureMode == CaptureMode.Capture)
                _soundIn = new WasapiCapture();
            else
                _soundIn = new WasapiLoopbackCapture();

            _soundIn.Device = SelectedDevice;
            _soundIn.Initialize();

            var soundInSource = new SoundInSource(_soundIn);
            var singleBlockNotificationStream = new SingleBlockNotificationStream(soundInSource.ToSampleSource());
            _finalSource = singleBlockNotificationStream.ToWaveSource();
            _writer = new WaveWriter(fileName, _finalSource.WaveFormat);

            byte[] buffer = new byte[_finalSource.WaveFormat.BytesPerSecond / 2];
            soundInSource.DataAvailable += (s, e) =>
                {
                    int read;
                    while ((read = _finalSource.Read(buffer, 0, buffer.Length)) > 0)
                        _writer.Write(buffer, 0, read);
                };

            singleBlockNotificationStream.SingleBlockRead += SingleBlockNotificationStreamOnSingleBlockRead;

            _soundIn.Start();
        }

        private void SingleBlockNotificationStreamOnSingleBlockRead(object sender, SingleBlockReadEventArgs e)
        {
            _graphVisualization.AddSamples(e.Left, e.Right);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var image = pictureBox1.Image;
            pictureBox1.Image = _graphVisualization.Draw(pictureBox1.Width, pictureBox1.Height);
            if (image != null)
                image.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentAudio))
            {
                MessageBox.Show("没有录制音频文件!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult=DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
