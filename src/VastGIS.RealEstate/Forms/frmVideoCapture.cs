using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

//using AForge
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using AForge.Controls;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmVideoCapture : Form
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private string _currentVideo;
        private VgAttachment _attachment;
        private List<VgDictionary> _typeDict;
        public frmVideoCapture(IAppContext context,RealEstateEditor plugin)
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            //_typeDict = _database.DomainService.GetDictionaryByName("FJLXZD");
            //cmbType.DataSource = _typeDict;
            //cmbType.DisplayMember = "Zdsm";
            //cmbType.ValueMember = "Zdz";
            //cmbType.SelectedIndex = 0;
            InitStatus(true);
        }

        //关闭窗口响应函数
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (this.writer.IsOpen)
            {
                MessageBox.Show("视频流还没有写完，请点击结束录制。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.videoSource.SignalToStop();
            this.videoSource.WaitForStop();
            this.videoSourcePlayer.SignalToStop();
            this.videoSourcePlayer.WaitForStop();
            DialogResult=DialogResult.Cancel;
            
            //this.Hide();
            //this.Close();
            //this.Dispose();
        }

        private FilterInfoCollection videoDevices;  //摄像头设备
        private VideoCaptureDevice videoSource;     //视频的来源选择
        private VideoSourcePlayer videoSourcePlayer;    //AForge控制控件
        private VideoFileWriter writer;     //写入到视频
        private bool is_record_video = false;   //是否开始录像
        System.Timers.Timer timer_count;
        int tick_num = 0;

        //窗体初始化函数
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Visible = false;

            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.videoSource = new VideoCaptureDevice();
            this.writer = new VideoFileWriter();

            //设置视频编码格式
            this.comboBox_videoecode.Items.Add("Raw");
            this.comboBox_videoecode.Items.Add("MPEG2");
            this.comboBox_videoecode.Items.Add("FLV1");
            this.comboBox_videoecode.Items.Add("H263p");
            this.comboBox_videoecode.Items.Add("MSMPEG4v3");
            this.comboBox_videoecode.Items.Add("MSMPEG4v2");
            this.comboBox_videoecode.Items.Add("WMV2");
            this.comboBox_videoecode.Items.Add("WMV1");
            this.comboBox_videoecode.Items.Add("MPEG4");
            this.comboBox_videoecode.SelectedIndex = 1;

            //设置视频来源
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();   //没有找到摄像头设备

                foreach (FilterInfo device in videoDevices)
                {
                    this.comboBoxCamera.Items.Add(device.Name);
                }

            }
            catch (ApplicationException)
            {
                videoDevices = null;
                MessageBox.Show("没有找到摄像头设备", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //秒表
            this.timer_count = new System.Timers.Timer();   //实例化Timer类，设置间隔时间为10000毫秒；
            this.timer_count.Elapsed += new System.Timers.ElapsedEventHandler(tick_count);   //到达时间的时候执行事件；
            this.timer_count.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；
            this.timer_count.Interval = 1000;
        }

        //视频源选择下拉框选择之后的响应函数
        private void comboBoxCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_index = this.comboBoxCamera.SelectedIndex;
            if (selected_index < 0) return;
            this.videoSource = new VideoCaptureDevice(videoDevices[selected_index].MonikerString);
            // set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(show_video);
            videoSource.Start();
            videoSourcePlayer.VideoSource = videoSource;
            videoSourcePlayer.Start();
            this.label5.Text = "连接中...";
            this.label5.Visible = true;
            isshowed = true;
        }

        bool isshowed = true;
        //新帧的触发函数
        private void show_video(object sender, NewFrameEventArgs eventArgs)
        {
            if (isshowed)
            {
                //  this.label5.Visible = false;
                isshowed = false;
            }
            Bitmap bitmap = eventArgs.Frame;    //获取到一帧图像
            if (bitmap == null) return;
            pictureBox1.Image = Image.FromHbitmap(bitmap.GetHbitmap());
            if (is_record_video)
            {
                writer.WriteVideoFrame(bitmap);
            }
        }

        //拍摄图像按钮响应函数
        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (this.videoSource.IsRunning && this.videoSourcePlayer.IsRunning)
            {
                Bitmap bitmap = this.videoSourcePlayer.GetCurrentVideoFrame();
                bitmap.Save("img.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
                MessageBox.Show("摄像头没有运行", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //开始录像按钮响应函数
        private void buttonStart_Click(object sender, EventArgs e)
        {
            int width = 640;    //录制视频的宽度
            int height = 480;   //录制视频的高度
            int fps = 9;

            string fileName = _database.CreateAttachmentName();
            //创建一个视频文件
            String video_format = this.comboBox_videoecode.Text.Trim(); //获取选中的视频编码
            if (this.videoSource.IsRunning && this.videoSourcePlayer.IsRunning)
            {
                if (-1 != video_format.IndexOf("MPEG"))
                {
                    _currentVideo = fileName + ".avi";
                    writer.Open(_currentVideo, width, height, fps, VideoCodec.MPEG4);
                }
                else if (-1 != video_format.IndexOf("WMV"))
                {
                    _currentVideo = fileName + ".wmv";
                    writer.Open(_currentVideo, width, height, fps, VideoCodec.WMV1);
                }
                else
                {
                    _currentVideo = fileName + ".mkv";
                    writer.Open(_currentVideo, width, height, fps, VideoCodec.Default);
                }
            }
            else
                MessageBox.Show("没有视频源输入，无法录制视频。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            timer_count.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
            this.label5.Visible = true;
            this.label5.Text = "录制中";
            this.is_record_video = true;
            InitStatus(false);
        }

        private void InitStatus(bool enabled)
        {
            comboBoxCamera.Enabled = enabled;
            comboBox_videoecode.Enabled = enabled;
            buttonStart.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonExit.Enabled = enabled;
            buttonPause.Enabled = !enabled;
            buttonStop.Enabled = !enabled;
        }


        //停止录制视频响应函数
        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.is_record_video = false;
            this.writer.Close();
            this.timer_count.Enabled = false;
            tick_num = 0;
            InitStatus(true);
        }

        //暂停按钮响应函数
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (this.buttonPause.Text.Trim() == "暂停录像")
            {
                this.is_record_video = false;
                this.label5.Visible = false;
                this.buttonPause.Text = "恢复录像";
                timer_count.Enabled = false;    //暂停计时
                return;
            }
            if (this.buttonPause.Text.Trim() == "恢复录像")
            {
                this.is_record_video = true;
                timer_count.Enabled = true;     //恢复计时
                this.label5.Visible = true;
                this.buttonPause.Text = "暂停录像";
            }
        }

        //计时器响应函数
        public void tick_count(object source, System.Timers.ElapsedEventArgs e)
        {
            tick_num++;
            int temp = tick_num;

            int sec = temp % 60;

            int min = temp / 60;
            if (60 == min)
            {
                min = 0;
                min++;
            }

            int hour = min / 60;

            String tick = hour.ToString() + "：" + min.ToString() + "：" + sec.ToString();
            //  this.label5.Text = tick;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentVideo))
            {
                MessageBox.Show("没有视频文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.writer.IsOpen)
            {
                MessageBox.Show("视频流还没有写完，请点击结束录制。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.videoSource.SignalToStop();
            this.videoSource.WaitForStop();
            this.videoSourcePlayer.SignalToStop();
            this.videoSourcePlayer.WaitForStop();
            DialogResult = DialogResult.OK;

        }

        public VgAttachment GetAttachment()
        {
            _attachment = new VgAttachment();
            _attachment.Fjmc = Path.GetFileName(_currentVideo) ;
            _attachment.Fjsm = "";
            _attachment.Fjlj = _database.GetRelativePath(_currentVideo);
            _attachment.Hqsj = DateTime.Now;
            _attachment.Fjlx = "XCSP";
            return _attachment;
        }
    }
}