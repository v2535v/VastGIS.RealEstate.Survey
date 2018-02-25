using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AForge.Video;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    using Point = System.Drawing.Point;
    using System.Drawing.Drawing2D;

    /// <summary>
    /// Video source player control.
    /// </summary>
    /// 
    /// <remarks><para>The control is aimed to play video sources, which implement
    /// <see cref="AForge.Video.IVideoSource"/> interface. To start playing a video
    /// the <see cref="VideoSource"/> property should be initialized first and then
    /// <see cref="Start"/> method should be called. In the case if user needs to
    /// perform some sort of image processing with video frames before they are displayed,
    /// the <see cref="NewFrame"/> event may be used.</para>
    /// 
    /// <para>Sample usage:</para>
    /// <code>
    /// // set new frame event handler if we need processing of new frames
    /// playerControl.NewFrame += new VideoSourcePlayer.NewFrameHandler( this.playerControl_NewFrame );
    /// 
    /// // create video source
    /// IVideoSource videoSource = new ...
    /// // start playing it
    /// playerControl.VideoSource = videoSource;
    /// playerControl.Start( );
    /// ...
    /// 
    /// // new frame event handler
    /// private void playerControl_NewFrame( object sender, ref Bitmap image )
    /// {
    ///     // process new frame somehow ...
    ///     
    ///     // Note: it may be even changed, so the control will display the result
    ///     // of image processing done here
    /// }
    /// </code>
    /// </remarks>
    /// 
    public partial class VideoPlayer : Control
    {
        // video source to play
        private IVideoSource videoSource = null;
        // last received frame from the video source
        private Bitmap currentFrame = null;
        // converted version of the current frame (in the case if current frame is a 16 bpp 
        // per color plane image, then the converted image is its 8 bpp version for rendering)
        private Bitmap convertedFrame = null;
        // last error message provided by video source
        private string lastMessage = null;
        // controls border color
        private Color borderColor = Color.Black;
        private Pen borderPen = null;
        private bool hasBorder = false;

        private ControlStyles controlStyles = ControlStyles.UserPaint;

        private Size frameSize = new Size(320, 240);
        private bool autosize = false;
        private bool keepRatio = false;
        private bool needSizeUpdate = false;
        private bool firstFrameNotProcessed = true;
        private volatile bool requestedToStop = false;

        // parent of the control
        private Control parent = null;

        // dummy object to lock for synchronization
        private object sync = new object();

        /// <summary>
        /// Auto size control or not.
        /// </summary>
        /// 
        /// <remarks><para>The property specifies if the control should be autosized or not.
        /// If the property is set to <see langword="true"/>, then the control will change its size according to
        /// video size and control will change its position automatically to be in the center
        /// of parent's control.</para>
        /// 
        /// <para><note>Setting the property to <see langword="true"/> has no effect if
        /// <see cref="Control.Dock"/> property is set to <see cref="DockStyle.Fill"/>.</note></para>
        /// </remarks>
        /// 
        [DefaultValue(false)]
        public bool AutoSizeControl
        {
            get { return autosize; }
            set
            {
                autosize = value;
                UpdatePosition();
            }
        }

        /// <summary>
        /// Gets or sets whether the player should keep the aspect ratio of the images being shown.
        /// </summary>
        /// 
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool KeepAspectRatio
        {
            get { return keepRatio; }
            set
            {
                keepRatio = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Control's border color.
        /// </summary>
        /// 
        /// <remarks><para>Specifies color of the border drawn around video frame.</para></remarks>
        /// 
        [Category("Appearance")]
        [DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                UpdateBorderPen();
            }
        }

        [Category("Appearance")]
        [DefaultValue(true)]
        public bool HasBorder
        {
            get { return hasBorder; }
            set
            {
                hasBorder = value;
                UpdateBorderPen();
            }
        }


        [DefaultValue(CompositingMode.SourceCopy)]
        public CompositingMode CompositingMode { get; set; }

        [DefaultValue(InterpolationMode.Low)]
        public InterpolationMode InterpolationMode { get; set; }

        [DefaultValue(SmoothingMode.None)]
        public SmoothingMode SmoothingMode { get; set; }

        [DefaultValue(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.DoubleBuffer)]
        public ControlStyles ControlStyles
        {
            get { return controlStyles; }
            set
            {
                controlStyles = value;
                SetStyle(controlStyles, true);
            }
        }

        /// <summary>
        /// Video source to play.
        /// </summary>
        /// 
        /// <remarks><para>The property sets the video source to play. After setting the property the
        /// <see cref="Start"/> method should be used to start playing the video source.</para>
        /// 
        /// <para><note>Trying to change video source while currently set video source is still playing
        /// will generate an exception. Use <see cref="IsRunning"/> property to check if current video
        /// source is still playing or <see cref="Stop"/> or <see cref="SignalToStop"/> and <see cref="WaitForStop"/>
        /// methods to stop current video source.</note></para>
        /// </remarks>
        /// 
        /// <exception cref="Exception">Video source can not be changed while current video source is still running.</exception>
        /// 
        [Browsable(false)]
        public IVideoSource VideoSource
        {
            get { return videoSource; }
            set
            {
                CheckForCrossThreadAccess();

                // detach events
                if (videoSource != null)
                {
                    videoSource.NewFrame -= new NewFrameEventHandler(OnNewFrame);
                    videoSource.VideoSourceError -= new VideoSourceErrorEventHandler(videoSource_VideoSourceError);
                    videoSource.PlayingFinished -= new PlayingFinishedEventHandler(videoSource_PlayingFinished);
                }

                lock (sync)
                {
                    if (currentFrame != null)
                    {
                        currentFrame.Dispose();
                        currentFrame = null;
                    }
                }

                videoSource = value;

                // atach events
                if (videoSource != null)
                {
                    videoSource.NewFrame += new NewFrameEventHandler(OnNewFrame);
                    videoSource.VideoSourceError += new VideoSourceErrorEventHandler(videoSource_VideoSourceError);
                    videoSource.PlayingFinished += new PlayingFinishedEventHandler(videoSource_PlayingFinished);
                }
                else
                {
                    frameSize = new Size(320, 240);
                }

                lastMessage = null;
                needSizeUpdate = true;
                firstFrameNotProcessed = true;
                // update the control
                Invalidate();
            }
        }

        /// <summary>
        /// State of the current video source.
        /// </summary>
        /// 
        /// <remarks><para>Current state of the current video source object - running or not.</para></remarks>
        /// 
        [Browsable(false)]
        public bool IsRunning
        {
            get
            {
                CheckForCrossThreadAccess();

                return (videoSource != null) ? videoSource.IsRunning : false;
            }
        }

        protected Rectangle videoArea = new Rectangle();

        [Browsable(false)]
        public Rectangle VideoArea
        {
            get { return videoArea; }
        }

        /// <summary>
        /// Delegate to notify about new frame.
        /// </summary>
        /// 
        /// <param name="sender">Event sender.</param>
        /// <param name="image">New frame.</param>
        /// 
        public delegate void NewFrameHandler(object sender, ref Bitmap image);

        /// <summary>
        /// New frame event.
        /// </summary>
        /// 
        /// <remarks><para>The event is fired on each new frame received from video source. The
        /// event is fired right after receiving and before displaying, what gives user a chance to
        /// perform some image processing on the new frame and/or update it.</para>
        /// 
        /// <para><note>Users should not keep references of the passed to the event handler image.
        /// If user needs to keep the image, it should be cloned, since the original image will be disposed
        /// by the control when it is required.</note></para>
        /// </remarks>
        /// 
        public event NewFrameHandler NewFrame;

        /// <summary>
        /// Playing finished event.
        /// </summary>
        /// 
        /// <remarks><para>The event is fired when/if video playing finishes. The reason of video
        /// stopping is provided as an argument to the event handler.</para></remarks>
        /// 
        public event PlayingFinishedEventHandler PlayingFinished;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSourcePlayer"/> class.
        /// </summary>
        public VideoPlayer()
        {
            this.HasBorder = true;
            this.KeepAspectRatio = true;

            this.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            this.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            this.videoSource = null;

            this.ForeColor = DefaultForeColor;

            InitializeComponent();

            // update control style
            this.ControlStyles = ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint |
                                 ControlStyles.DoubleBuffer;
        }

        public void UpdateBorderPen(Pen pen = null)
        {
            if (hasBorder)
            {
                if (borderPen != null && pen != null && pen != borderPen)
                {
                    borderPen.Dispose();
                    borderPen = null;
                }
                if (pen != null)
                {
                    borderPen = pen;
                }
                else if (borderPen == null)
                {
                    borderPen = new Pen(borderColor, 1);
                }
                else if (borderPen.Color != borderColor)
                {
                    borderPen.Color = borderColor;
                }
            }
            else if (borderPen != null)
            {
                borderPen.Dispose();
                borderPen = null;
            }
            Invalidate();
        }


        // Check if the control is accessed from a none UI thread
        protected void CheckForCrossThreadAccess()
        {
            // force handle creation, so InvokeRequired() will use it instead of searching through parent's chain
            if (!IsHandleCreated)
            {
                CreateControl();

                // if the control is not Visible, then CreateControl() will not be enough
                if (!IsHandleCreated)
                {
                    CreateHandle();
                }
            }

            if (InvokeRequired)
            {
                throw new InvalidOperationException("Cross thread access to the control is not allowed.");
            }
        }

        /// <summary>
        /// Start video source and displaying its frames.
        /// </summary>
        public void Start()
        {
            CheckForCrossThreadAccess();

            requestedToStop = false;

            if (videoSource != null)
            {
                firstFrameNotProcessed = true;

                videoSource.Start();
                Invalidate();
            }
        }

        /// <summary>
        /// Stop video source.
        /// </summary>
        /// 
        /// <remarks><para>The method stops video source by calling its <see cref="AForge.Video.IVideoSource.Stop"/>
        /// method, which abourts internal video source's thread. Use <see cref="SignalToStop"/> and
        /// <see cref="WaitForStop"/> for more polite video source stopping, which gives a chance for
        /// video source to perform proper shut down and clean up.
        /// </para></remarks>
        /// 
        public void Stop()
        {
            CheckForCrossThreadAccess();

            requestedToStop = true;

            if (videoSource != null)
            {
                videoSource.Stop();

                if (currentFrame != null)
                {
                    currentFrame.Dispose();
                    currentFrame = null;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Signal video source to stop. 
        /// </summary>
        /// 
        /// <remarks><para>Use <see cref="WaitForStop"/> method to wait until video source
        /// stops.</para></remarks>
        /// 
        public void SignalToStop()
        {
            CheckForCrossThreadAccess();

            requestedToStop = true;

            if (videoSource != null)
            {
                videoSource.SignalToStop();
            }
        }

        /// <summary>
        /// Wait for video source has stopped. 
        /// </summary>
        /// 
        /// <remarks><para>Waits for video source stopping after it was signaled to stop using
        /// <see cref="SignalToStop"/> method. If <see cref="SignalToStop"/> was not called, then
        /// it will be called automatically.</para></remarks>
        /// 
        public void WaitForStop()
        {
            CheckForCrossThreadAccess();

            if (!requestedToStop)
            {
                SignalToStop();
            }

            if (videoSource != null)
            {
                videoSource.WaitForStop();

                if (currentFrame != null)
                {
                    currentFrame.Dispose();
                    currentFrame = null;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Get clone of current video frame displayed by the control.
        /// </summary>
        /// 
        /// <returns>Returns copy of the video frame, which is currently displayed
        /// by the control - the last video frame received from video source. If the
        /// control did not receive any video frames yet, then the method returns
        /// <see langword="null"/>.</returns>
        /// 
        public Bitmap GetCurrentVideoFrame()
        {
            lock (sync)
            {
                return (currentFrame == null) ? null : AForge.Imaging.Image.Clone(currentFrame);
            }
        }

        protected const int WM_ERASEBKGND = 20;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_ERASEBKGND)
            {
                m.Result = IntPtr.Zero;
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        // Paint control
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!Visible)
            {
                return;
            }

            // is it required to update control's size/position
            if ((needSizeUpdate) || (firstFrameNotProcessed))
            {
                UpdatePosition();
                needSizeUpdate = false;
            }

            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;
            if (borderPen != null)
            {
                // draw rectangle
                g.DrawRectangle(borderPen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
            }
            if (videoSource == null)
            {
                using (SolidBrush drawBrush = new SolidBrush(Color.Black))
                {
                    g.Clear(this.BackColor);
                    string curMessage = lastMessage;
                    g.DrawString(string.IsNullOrEmpty(curMessage) ? "Not connected" : curMessage, Font ?? DefaultFont, drawBrush, new Point(5, 5));
                }

                videoArea = this.ClientRectangle;
                base.OnPaint(e);
                return;
            }

            Bitmap frame = null;
            lock (sync)
            {
                if ((currentFrame != null) && (lastMessage == null))
                {
                    frame = (convertedFrame != null) ? convertedFrame : currentFrame;
                    frame = frame.Clone() as Bitmap;
                    firstFrameNotProcessed = false;
                }
            }
            if (frame != null)
            {
                int a = hasBorder ? 1 : 0, b = hasBorder ? 2 : 0;
                g.CompositingMode = CompositingMode;
                g.InterpolationMode = InterpolationMode;
                g.SmoothingMode = SmoothingMode;
                if (keepRatio)
                {
                    double ratio = (double)frame.Width / frame.Height;
                    int w = rect.Width - b, h = rect.Height - b;

                    if (w < h * ratio)
                    {
                        h = (int)(w / ratio);
                    }
                    else
                    {
                        w = (int)(h * ratio);
                    }

                    videoArea.X = (rect.Width - w) / 2 + a;
                    videoArea.Y = (rect.Height - h) / 2 + a;
                    videoArea.Width = w;
                    videoArea.Height = h;
                }
                else
                {
                    videoArea.X = rect.X + a;
                    videoArea.Y = rect.Y + a;
                    videoArea.Width = rect.Width - b;
                    videoArea.Height = rect.Height - b;
                }
                // draw current frame
                g.DrawImage(frame, videoArea);
                frame.Dispose();
            }
            else
            {
                videoArea = this.ClientRectangle;
                using (SolidBrush drawBrush = new SolidBrush(this.ForeColor))
                {
                    g.Clear(this.BackColor);
                    string curMessage = lastMessage;
                    g.DrawString(string.IsNullOrEmpty(curMessage) ? "Connecting ..." : curMessage, Font ?? DefaultFont, drawBrush, new Point(5, 5));
                }
            }
            base.OnPaint(e);
        }

        // Update controls size and position
        public void UpdatePosition()
        {
            if ((autosize) && (this.Dock != DockStyle.Fill) && (this.Parent != null))
            {
                Rectangle rc = this.Parent.ClientRectangle;
                int width = frameSize.Width;
                int height = frameSize.Height;

                // update controls size and location
                this.SuspendLayout();
                this.Location = new Point((rc.Width - width - 2) / 2, (rc.Height - height - 2) / 2);
                this.Size = new Size(width + 2, height + 2);
                this.ResumeLayout();
            }
        }

        // On new frame ready
        public void OnNewFrame(object _sender, NewFrameEventArgs eventArgs)
        {
            if (!requestedToStop)
            {
                Bitmap newFrame = (Bitmap)eventArgs.Frame.Clone();

                // let user process the frame first
                if (NewFrame != null)
                {
                    NewFrame(this, ref newFrame);
                }

                // now update current frame of the control
                Bitmap old = null, oldC = null;
                lock (sync)
                {
                    // dispose previous frame
                    if (currentFrame != null)
                    {
                        if (currentFrame.Size != eventArgs.Frame.Size)
                        {
                            needSizeUpdate = true;
                        }
                        old = currentFrame;
                        currentFrame = null;
                    }
                    oldC = convertedFrame;
                    convertedFrame = null;

                    currentFrame = newFrame;
                    frameSize = currentFrame.Size;
                    lastMessage = null;

                    // check if conversion is required to lower bpp rate
                    if ((currentFrame.PixelFormat == PixelFormat.Format16bppGrayScale) ||
                        (currentFrame.PixelFormat == PixelFormat.Format48bppRgb) ||
                        (currentFrame.PixelFormat == PixelFormat.Format64bppArgb))
                    {
                        convertedFrame = AForge.Imaging.Image.Convert16bppTo8bpp(currentFrame);
                    }
                }
                if (old != null)
                {
                    old.Dispose();
                }
                if (oldC != null)
                {
                    oldC.Dispose();
                }

                // update control
                Invalidate();
            }
        }

        // Error occured in video source
        private void videoSource_VideoSourceError(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            lastMessage = eventArgs.Description;
            Invalidate();
        }

        // Video source has finished playing video
        private void videoSource_PlayingFinished(object sender, ReasonToFinishPlaying reason)
        {
            switch (reason)
            {
                case ReasonToFinishPlaying.EndOfStreamReached:
                    lastMessage = "Video has finished";
                    break;

                case ReasonToFinishPlaying.StoppedByUser:
                    lastMessage = "Video was stopped";
                    break;

                case ReasonToFinishPlaying.DeviceLost:
                    lastMessage = "Video device was unplugged";
                    break;

                case ReasonToFinishPlaying.VideoSourceError:
                    lastMessage = "Video has finished because of error in video source";
                    break;

                default:
                    lastMessage = "Video has finished for unknown reason";
                    break;
            }
            Invalidate();

            // notify users
            if (PlayingFinished != null)
            {
                PlayingFinished(this, reason);
            }
        }

        // Parent Changed event handler
        private void VideoSourcePlayer_ParentChanged(object sender, EventArgs e)
        {
            if (parent != null)
            {
                parent.SizeChanged -= new EventHandler(parent_SizeChanged);
            }

            parent = this.Parent;

            // set handler for Size Changed parent's event
            if (parent != null)
            {
                parent.SizeChanged += new EventHandler(parent_SizeChanged);
            }
        }

        // Parent control has changed its size
        private void parent_SizeChanged(object sender, EventArgs e)
        {
            UpdatePosition();
        }
    }
}
