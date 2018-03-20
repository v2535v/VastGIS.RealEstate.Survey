using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using Camera_NET;
using DirectShowLib;
using OpenCvSharp;
using Syncfusion.Windows.Forms.Grid.Grouping;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using Point = OpenCvSharp.Point;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmCameraCapture : Form
    {
        #region Vars

        private IAppContext _context;
        private RealEstateEditor _plugin;
        private IREDatabase _database;
        private string _currentImage;
        private bool _isInputCorner = false;
        private List<OpenCvSharp.Point> _corners;
        private VgAttachment _attachment;
        private List<VgDictionary> _typeDict;

        private int g_dst_hight = 0;
        private int g_dst_width = 0;

        // Camera object
        //private Camera _Camera;

        // Rect selection with mouse
        private NormalizedRect _MouseSelectionRect = new NormalizedRect(0, 0, 0, 0);

        private bool _bDrawMouseSelection = false;

        // Zooming
        private bool _bZoomed = false;

        private double _fZoomValue = 1.0;

        // Camera choice
        private CameraChoice _CameraChoice = new CameraChoice();

        #endregion

        #region Winforms stuff


        // On load of Form
        private void frmCameraCapture_Load(object sender, EventArgs e)
        {
            // Fill camera list combobox with available cameras
            FillCameraList();

            // Select the first one
            if (comboBoxCameraList.Items.Count > 0)
            {
                comboBoxCameraList.SelectedIndex = comboBoxCameraList.Items.Count - 1;
            }

            // Fill camera list combobox with available resolutions
            FillResolutionList();

            SwitchTab(0);
        }

        // On close of Form
        private void frmCameraCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close camera
            cameraControl.CloseCamera();
        }

        // Update buttons of GUI based on Camera state
        private void UpdateGUIButtons()
        {
            // buttonCrossbarSettings.Enabled = (cameraControl.CrossbarAvailable);
        }

        #endregion

        #region Camera creation and destroy

        // Set current camera to camera_device
        private void SetCamera(IMoniker camera_moniker, Resolution resolution)
        {
            try
            {
                // NOTE: You can debug with DirectShow logging:
                //cameraControl.DirectShowLogFilepath = @"C:\YOUR\LOG\PATH.txt";

                // Makes all magic with camera and DirectShow graph
                cameraControl.SetCamera(camera_moniker, resolution);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error while running camera");
            }

            if (!cameraControl.CameraCreated) return;

            // If you are using Direct3D surface overlay
            // (see documentation about rebuild of library for it)
            //cameraControl.UseGDI = false;

            cameraControl.MixerEnabled = true;

            cameraControl.OutputVideoSizeChanged += Camera_OutputVideoSizeChanged;

            UpdateCameraBitmap();


            // gui update
            UpdateGUIButtons();
        }

        #endregion

        public frmCameraCapture(IAppContext context, RealEstateEditor plugin)
        {
            InitializeComponent();
            _context = context;
            _plugin = plugin;
            if (_plugin == null)
            {
                _plugin = _context.Container.GetInstance<RealEstateEditor>();
            }
            _database = ((IRealEstateContext)_context).RealEstateDatabase;
            _typeDict = _database.DomainService.GetDictionaryByName("FJLXZD");
            cmbType.DataSource = _typeDict;
            cmbType.DisplayMember = "Zdsm";
            cmbType.ValueMember = "Zdz";
            cmbType.SelectedIndex = 0;
        }

        public VgAttachment GetAttachment()
        {
            _attachment = new VgAttachment();
            _attachment.Fjmc = string.IsNullOrEmpty(txtName.Text.Trim()) ? Path.GetFileName(_currentImage) : txtName.Text;
            _attachment.Fjsm = txtDesc.Text;
            _attachment.Fjlj = _database.GetRelativePath(_currentImage);
            _attachment.Hqsj = DateTime.Now;
            _attachment.Fjlx = cmbType.SelectedValue.ToString();
            return _attachment;
        }

        private void FillResolutionList()
        {
            comboBoxResolutionList.Items.Clear();

            if (!cameraControl.CameraCreated) return;

            ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

            if (resolutions == null) return;


            int index_to_select = -1;

            for (int index = 0; index < resolutions.Count; index++)
            {
                comboBoxResolutionList.Items.Add(resolutions[index].ToString());

                if (resolutions[index].CompareTo(cameraControl.Resolution) == 0)
                {
                    index_to_select = index;
                }
            }

            // select current resolution
            if (index_to_select >= 0)
            {
                comboBoxResolutionList.SelectedIndex = index_to_select;
            }
        }

        private void FillCameraList()
        {
            comboBoxCameraList.Items.Clear();

            _CameraChoice.UpdateDeviceList();

            foreach (var camera_device in _CameraChoice.Devices)
            {
                comboBoxCameraList.Items.Add(camera_device.Name);
            }
        }

        private void comboBoxCameraList_Click(object sender, EventArgs e)
        {
            if (comboBoxCameraList.SelectedIndex < 0)
            {
                cameraControl.CloseCamera();
            }
            else
            {
                // Set camera
                SetCamera(_CameraChoice.Devices[comboBoxCameraList.SelectedIndex].Mon, null);
            }

            FillResolutionList();
        }

        private void comboBoxResolutionList_Click(object sender, EventArgs e)
        {
            if (!cameraControl.CameraCreated) return;

            int comboBoxResolutionIndex = comboBoxResolutionList.SelectedIndex;
            if (comboBoxResolutionIndex < 0)
            {
                return;
            }
            ResolutionList resolutions = Camera.GetResolutionList(cameraControl.Moniker);

            if (resolutions == null) return;

            if (comboBoxResolutionIndex >= resolutions.Count) return; // throw

            if (0 == resolutions[comboBoxResolutionIndex].CompareTo(cameraControl.Resolution))
            {
                // this resolution is already selected
                return;
            }

            // Recreate camera
            SetCamera(cameraControl.Moniker, resolutions[comboBoxResolutionIndex]);
        }

        private void buttonCameraSettings_Click(object sender, EventArgs e)
        {
            if (cameraControl.CameraCreated)
            {
                Camera.DisplayPropertyPage_Device(cameraControl.Moniker, this.Handle);
            }
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (!cameraControl.CameraCreated) return;

            Bitmap bitmap = null;
            try
            {
                bitmap = cameraControl.SnapshotSourceImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error while getting a snapshot");
            }

            if (bitmap == null) return;
            string fileName = _database.CreateAttachmentName();
            bitmap.Save(fileName + ".jpg", ImageFormat.Jpeg);
            picCurrent.Image = bitmap;
            picCurrent.Tag = fileName + ".jpg";
            _currentImage = fileName + ".jpg";
            picCurrent.Update();
            _corners = null;
            SwitchTab(1);
        }

        private void LoadImageAndCorner()
        {
            Bitmap bitmap = new Bitmap(_currentImage);
            picCurrent.Image = bitmap;
            picCurrent.Update();
            DrawCorners();
        }

        private void CalculateCorners()
        {
            Mat src = Cv2.ImRead(_currentImage, ImreadModes.Color);
            Mat source = src.Clone();
            Mat img = src.Clone();
            Mat bkup = src.Clone();
            Mat gray = new Mat();
            //转向灰度
            Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);
            Mat newGray = new Mat();
            Cv2.GaussianBlur(gray, newGray, new OpenCvSharp.Size(5, 5), 0, 0);
            //Cv2.ImShow("Image 3", newGray);
            Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
            Mat newGray2 = new Mat();
            Cv2.Dilate(newGray, newGray2, element);
            //Cv2.ImShow("Image 4", newGray2);
            Mat newGray3 = new Mat();
            Cv2.Canny(newGray2, newGray3, 30, 120, 3);
            //Cv2.ImShow("Image 5", newGray3);


            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchyIndexes;
            Cv2.FindContours(newGray3, out contours, out hierarchyIndexes, mode: RetrievalModes.External,
                method: ContourApproximationModes.ApproxNone);

            double max_area = 0;
            int index = -1;
            for (int i = 0; i < contours.Length; i++)
            {
                double tmparea = Math.Abs(Cv2.ContourArea(contours[i]));
                if (tmparea > max_area)
                {
                    max_area = tmparea;
                    index = i;
                }
            }

            var contour = contours[index];

            OpenCvSharp.Point tmp = contour[0];
            for (int line_type = 1; line_type <= 3; line_type++)
            {
                Mat black = newGray3.Clone();
                black.SetTo(0);
                Scalar color = new Scalar(255);
                //Mat black2 = img.Clone();
                //black2.SetTo(0);
                // double p = Cv2.ArcLength(contour, true);
                //var polyRect= Cv2.ApproxPolyDP(contour, 0.02 * p, true);

                Cv2.DrawContours(black, contours, index, color, line_type);
                //Cv2.ImShow("Show Contours", black);

                LineSegmentPoint[] lines;
                List<OpenCvSharp.Point> corners = null;
                OpenCvSharp.Point center;
                OpenCvSharp.Point[] approx;

                int para = 10;
                int flag = 0;
                int round = 0;
                for (para = 10; para < 300; para++)
                {

                    corners = new List<OpenCvSharp.Point>();
                    approx = null;
                    center = new OpenCvSharp.Point(0, 0);
                    lines = Cv2.HoughLinesP(black, 1, Math.PI / 180, para, 30, 10);

                    List<int> erasePts = new List<int>();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (IsBadLine(lines[i].P1.X - lines[j].P1.X, lines[i].P1.Y - lines[j].P1.Y) ||
                                IsBadLine(lines[i].P2.X - lines[j].P2.X, lines[i].P2.Y - lines[j].P2.Y))
                            {
                                erasePts.Add(j);
                            }
                        }
                    }
                    List<LineSegmentPoint> lineList = lines.ToList();
                    int linenums = lineList.Count;
                    while (linenums != 0)
                    {
                        bool hasContains = erasePts.Contains(linenums);
                        if (hasContains)
                        {
                            lineList.RemoveAt(linenums - 1);
                        }
                        linenums--;
                    }
                    if (lineList.Count != 4)
                    {
                        continue;
                    }

                    for (int i = 0; i < lineList.Count; i++)
                    {
                        for (int j = i + 1; j < lineList.Count; j++)
                        {
                            OpenCvSharp.Point pt = computeIntersect(lineList[i], lineList[j]);
                            if (pt.X >= 0 && pt.Y >= 0 && pt.X <= src.Cols && pt.Y <= src.Rows) //保证交点在图像的范围之内
                                corners.Add(pt);
                        }
                    }

                    if (corners.Count != 4) continue;

                    bool IsGoodPoints = true;

                    //保证点与点的距离足够大以排除错误点
                    for (int i = 0; i < corners.Count; i++)
                    {
                        for (int j = i + 1; j < corners.Count; j++)
                        {
                            double distance = Math.Sqrt((corners[i].X - corners[j].X) * (corners[i].X - corners[j].X) +
                                                        (corners[i].Y - corners[j].Y) * (corners[i].Y - corners[j].Y));
                            if (distance < 5)
                            {
                                IsGoodPoints = false;
                            }
                        }
                    }

                    if (!IsGoodPoints) continue;
                    OpenCvSharp.Point[] corners2 = corners.ToArray();
                    approx = Cv2.ApproxPolyDP(corners2, Cv2.ArcLength(corners2, true) * 0.02, true);
                    if (lines.Length == 4 && corners.Count == 4 && approx.Length == 4)
                    {
                        flag = 1;
                        break;
                    }
                }
                double XSum = 0;
                double YSum = 0;
                for (int i = 0; i < corners.Count; i++)
                {
                    XSum += corners[i].X;
                    YSum += corners[i].Y;
                }
                center = new OpenCvSharp.Point(XSum / corners.Count, YSum / corners.Count);

                if (flag != 1)
                {
                    continue;
                }

                Scalar[] colors =
                    {
                        new Scalar(0, 0, 255), new Scalar(0, 255, 0), new Scalar(255, 100, 100),
                        new Scalar(255, 0, 255), new Scalar(0, 255, 255)
                    };

                Cv2.Circle(bkup, corners[0], 3, colors[0]);
                Cv2.Circle(bkup, corners[1], 3, colors[1]);
                Cv2.Circle(bkup, corners[2], 3, colors[2]);
                Cv2.Circle(bkup, corners[3], 3, colors[3]);
                Cv2.ImShow("Backup", bkup);

                SortCorners(corners, center);
                CalcDstSize(corners);
                _corners = new List<Point>();
                _corners.AddRange(corners);
                return;
            }
            MessageBox.Show("无法提取角点", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _corners = new List<OpenCvSharp.Point>();
            _corners.Add(new OpenCvSharp.Point(0, 0));
            _corners.Add(new OpenCvSharp.Point(src.Width, 0));
            _corners.Add(new OpenCvSharp.Point(src.Width, src.Height));
            _corners.Add(new OpenCvSharp.Point(0, src.Height));
        }

        private Point2f[] ConvertToPoint2f(List<OpenCvSharp.Point> corners)
        {
            List<Point2f> newList = new List<Point2f>();
            foreach (OpenCvSharp.Point corner in corners)
            {
                Point2f newPoint = new Point2f(corner.X, corner.Y);
                newList.Add(newPoint);
            }
            return newList.ToArray();
        }

        private void CalcDstSize(List<OpenCvSharp.Point> corners)
        {
            int h1 = (int)Math.Sqrt((corners[0].X - corners[3].X) * (corners[0].X - corners[3].X) +
                                    (corners[0].Y - corners[3].Y) * (corners[0].Y - corners[3].Y));
            int h2 = (int)Math.Sqrt((corners[1].X - corners[2].X) * (corners[1].X - corners[2].X) +
                                    (corners[1].Y - corners[2].Y) * (corners[1].Y - corners[2].Y));
            g_dst_hight = Math.Max(h1, h2);

            int w1 = (int)Math.Sqrt((corners[0].X - corners[1].X) * (corners[0].X - corners[1].X) +
                                    (corners[0].Y - corners[1].Y) * (corners[0].Y - corners[1].Y));
            int w2 = (int)Math.Sqrt((corners[2].X - corners[3].X) * (corners[2].X - corners[3].X) +
                                    (corners[2].Y - corners[3].Y) * (corners[2].Y - corners[3].Y));
            g_dst_width = Math.Max(w1, w2);
        }

        private void SortCorners(List<OpenCvSharp.Point> corners, OpenCvSharp.Point center)
        {
            List<OpenCvSharp.Point> top = new List<OpenCvSharp.Point>();
            List<OpenCvSharp.Point> bot = new List<OpenCvSharp.Point>();
            for (int i = 0; i < (int)corners.Count; i++)
            {
                if (corners[i].Y < center.Y) top.Add(corners[i]);
                else bot.Add(corners[i]);
            }
            OpenCvSharp.Point tl = top[0].X > top[1].X ? top[1] : top[0];
            OpenCvSharp.Point tr = top[0].X > top[1].X ? top[0] : top[1];
            OpenCvSharp.Point bl = bot[0].X > bot[1].X ? bot[1] : bot[0];
            OpenCvSharp.Point br = bot[0].X > bot[1].X ? bot[0] : bot[1];
            corners.Clear();
            corners.Add(tl);
            corners.Add(tr);
            corners.Add(br);
            corners.Add(bl);
        }

        private OpenCvSharp.Point computeIntersect(LineSegmentPoint a, LineSegmentPoint b)
        {
            int x1 = a.P1.X, y1 = a.P1.Y, x2 = a.P2.X, y2 = a.P2.Y;
            int x3 = b.P1.X, y3 = b.P1.Y, x4 = b.P2.X, y4 = b.P2.Y;
            double dd = ((double)(x1 - x2) * (y3 - y4)) - ((y1 - y2) * (x3 - x4));
            if (dd > 0)
            {
                OpenCvSharp.Point pt = new OpenCvSharp.Point();
                pt.X = (int)(((x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4)) / dd);
                pt.Y = (int)(((x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4)) / dd);
                return pt;
            }
            else return new OpenCvSharp.Point(-1, -1);
        }

        private bool IsBadLine(int a, int b)
        {
            if (a * a + b * b < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SwitchTab(int tabIndex)
        {
            tabControlAdv1.SelectedIndex = tabIndex;
            if (tabIndex == 0)
            {
                pageProcess.Enabled = false;
                pageCamera.Enabled = true;
            }
            else
            {
                pageProcess.Enabled = true;
                pageCamera.Enabled = false;
            }
        }

        private void btnClickCorner_Click(object sender, EventArgs e)
        {
            if (cmbPointNumber.SelectedIndex < 0)
            {
                MessageBox.Show("请先选择准备输入的角点!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isInputCorner = true;
        }

        private void picCurrent_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isInputCorner == false) return;
            if (_corners == null)
            {
                MessageBox.Show("请先进行角点识别!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _corners.RemoveAt(cmbPointNumber.SelectedIndex);
            _corners.Insert(cmbPointNumber.SelectedIndex, new Point(e.X, e.Y));
            DrawCorners();
            _isInputCorner = false;


        }

        private void Camera_OutputVideoSizeChanged(object sender, EventArgs e)
        {
            // Update camera's bitmap (new size needed)
            UpdateCameraBitmap();

            // Place Zoom button in correct place on form
            UpdateUnzoomButton();
        }

        private void cameraControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UnzoomCamera();
        }

        // Unzoom with unzoom button
        private void buttonUnZoom_Click(object sender, EventArgs e)
        {
            UnzoomCamera();
        }

        private void UpdateCameraBitmap()
        {
            if (!cameraControl.MixerEnabled) return;

            cameraControl.OverlayBitmap = GenerateColorKeyBitmap(false);

            #region D3D bitmap mixer

            //if (cameraControl.UseGDI)
            //{
            //    cameraControl.OverlayBitmap = GenerateColorKeyBitmap(false);
            //}
            //else
            //{
            //    cameraControl.OverlayBitmap = GenerateAlphaBitmap();
            //}

            #endregion
        }

        private Bitmap GenerateColorKeyBitmap(bool useAntiAlias)
        {
            int w = cameraControl.OutputVideoSize.Width;
            int h = cameraControl.OutputVideoSize.Height;

            if (w <= 0 || h <= 0) return null;

            // Create RGB bitmap
            Bitmap bmp = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);

            // configure antialiased drawing or not
            if (useAntiAlias)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
            }
            else
            {
                g.SmoothingMode = SmoothingMode.None;
                g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            }

            // Clear the bitmap with the color key
            g.Clear(cameraControl.GDIColorKey);

            // Draw selection rect --------------------------
            if (_bDrawMouseSelection && IsMouseSelectionRectCorrect())
            {
                Color color_of_pen = Color.Gray;
                if (IsMouseSelectionRectCorrectAndGood())
                {
                    color_of_pen = Color.Green;
                }

                Pen pen = new Pen(color_of_pen, 2.0f);

                Rectangle rect = new Rectangle((int)(_MouseSelectionRect.left * w), (int)(_MouseSelectionRect.top * h),
                    (int)((_MouseSelectionRect.right - _MouseSelectionRect.left) * w),
                    (int)((_MouseSelectionRect.bottom - _MouseSelectionRect.top) * h));



                g.DrawLine(pen, rect.Left - 5, rect.Top, rect.Right + 5, rect.Top);
                g.DrawLine(pen, rect.Left - 5, rect.Bottom, rect.Right + 5, rect.Bottom);
                g.DrawLine(pen, rect.Left, rect.Top - 5, rect.Left, rect.Bottom + 5);
                g.DrawLine(pen, rect.Right, rect.Top - 5, rect.Right, rect.Bottom + 5);

                pen.Dispose();

            }

            // Draw zoom text if needed
            if (_bZoomed)
            {
                Font font = new Font("Tahoma", 16);
                Brush textColorKeyed = new SolidBrush(Color.DarkBlue);

                g.DrawString("Zoom: " + Math.Round(_fZoomValue, 1).ToString("0.0") + "x", font, textColorKeyed, 4, 4);

                font.Dispose();
                textColorKeyed.Dispose();
            }

            //// Draw text logo for example
            //{
            //    Font font = new Font("Tahoma", 16);
            //    Brush textColorKeyed = new SolidBrush(Color.Yellow);

            //    g.DrawString("Sample project for Camera_NET component", font, textColorKeyed, 4, h - 30);

            //}


            // dispose Graphics
            g.Dispose();

            // return the bitmap
            return bmp;
        }

        private void cameraControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (!cameraControl.CameraCreated) return;

            if (_bZoomed) return;

            PointF point = cameraControl.ConvertWinToNorm(new PointF(e.X, e.Y));
            _MouseSelectionRect = new NormalizedRect(point.X, point.Y, point.X, point.Y);

            _bDrawMouseSelection = true;
            UpdateCameraBitmap();
        }

        private void cameraControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (_bZoomed) return;

            if (!_bDrawMouseSelection) return;

            // Zoom
            if (!IsMouseSelectionRectCorrectAndGood())
            {
                // Doesn't allow zoom too much

                _bDrawMouseSelection = false;
                UpdateCameraBitmap();
                return;
            }


            int w = cameraControl.Resolution.Width;
            int h = cameraControl.Resolution.Height;

            double rect_w = w * (_MouseSelectionRect.right - _MouseSelectionRect.left);
            double rect_h = h * (_MouseSelectionRect.bottom - _MouseSelectionRect.top);


            // Save frame proportion

            double ratio_video = ((double)w) / h;
            double ratio_rect = ((double)rect_w) / rect_h;

            //NormalizedRect norm_rect;



            if (ratio_video >= ratio_rect)
            {
                // calculate width
                double needed_rect_width = rect_h * ratio_video;

                _MouseSelectionRect.left -= (float)(((needed_rect_width - rect_w) / 2) / w);
                _MouseSelectionRect.right += (float)(((needed_rect_width - rect_w) / 2) / w);

                _fZoomValue = (double)h / rect_h;
            }
            else
            {
                // calculate height
                double needed_rect_height = rect_w / ratio_video;

                _MouseSelectionRect.top -= (float)(((needed_rect_height - rect_h) / 2) / h);
                _MouseSelectionRect.bottom += (float)(((needed_rect_height - rect_h) / 2) / h);

                _fZoomValue = (double)w / rect_w;
            }



            Rectangle rect = new Rectangle((int)(_MouseSelectionRect.left * w), (int)(_MouseSelectionRect.top * h),
                (int)((_MouseSelectionRect.right - _MouseSelectionRect.left) * w),
                (int)((_MouseSelectionRect.bottom - _MouseSelectionRect.top) * h));


            cameraControl.ZoomToRect(rect);
            _bZoomed = true;
            _bDrawMouseSelection = false;

            UpdateCameraBitmap();

            // Place Zoom button in correct place on form
            UpdateUnzoomButton();

        }

        private void cameraControl_MouseMove(object sender, MouseEventArgs e)

        {
            if (e.Button != MouseButtons.Left) return;

            if (!cameraControl.CameraCreated) return;

            if (_bZoomed) return;

            if (!_bDrawMouseSelection) return;

            PointF point = cameraControl.ConvertWinToNorm(new PointF(e.X, e.Y));
            _MouseSelectionRect.right = point.X;
            _MouseSelectionRect.bottom = point.Y;


            UpdateCameraBitmap();
        }

        private bool IsMouseSelectionRectCorrect()
        {
            if (Math.Abs(_MouseSelectionRect.right - _MouseSelectionRect.left) < float.Epsilon * 10 ||
                Math.Abs(_MouseSelectionRect.bottom - _MouseSelectionRect.top) < float.Epsilon * 10)
            {
                return false;
            }

            if (_MouseSelectionRect.left >= _MouseSelectionRect.right ||
                _MouseSelectionRect.top >= _MouseSelectionRect.bottom)
            {
                return false;
            }

            if (_MouseSelectionRect.left < 0 || _MouseSelectionRect.top < 0 || _MouseSelectionRect.right > 1.0 ||
                _MouseSelectionRect.bottom > 1.0)
            {
                return false;
            }
            return true;
        }

        private bool IsMouseSelectionRectCorrectAndGood()
        {
            if (!IsMouseSelectionRectCorrect())
            {
                return false;

            }

            // Zoom
            if (Math.Abs(_MouseSelectionRect.right - _MouseSelectionRect.left) < 0.1f ||
                Math.Abs(_MouseSelectionRect.bottom - _MouseSelectionRect.top) < 0.1f)
            {
                return false;
            }

            return true;
        }

        // Unzoom camera and update gui
        private void UnzoomCamera()
        {
            cameraControl.ZoomToRect(new Rectangle(0, 0, cameraControl.Resolution.Width,
                cameraControl.Resolution.Height));

            _bZoomed = false;
            _fZoomValue = 1.0;

            // gui updates
            UpdateCameraBitmap();
            UpdateUnzoomButton();

            _bDrawMouseSelection = false;
        }


        // Place Zoom button in correct place on form
        private void UpdateUnzoomButton()
        {
            if (_bZoomed)
            {
                buttonUnZoom.Left = cameraControl.Left +
                                    (cameraControl.ClientRectangle.Width - cameraControl.OutputVideoSize.Width) / 2 + 4;
                buttonUnZoom.Top = cameraControl.Top +
                                   (cameraControl.ClientRectangle.Height - cameraControl.OutputVideoSize.Height) / 2 +
                                   40;
                buttonUnZoom.Visible = true;
            }
            else
            {
                buttonUnZoom.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnRecamera_Click(object sender, EventArgs e)
        {
            SwitchTab(0);
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            CalculateCorners();
            if (_corners != null)
            {
                DrawCorners();
            }
        }

        private List<System.Drawing.Point> ConvertCornerToPoint()
        {
            List<System.Drawing.Point> points = new List<System.Drawing.Point>();
            foreach (var one in _corners)
            {
                points.Add(new System.Drawing.Point(one.X, one.Y));
            }
            return points;
        }

        private void DrawCorners()
        {
            // Create RGB bitmap
            picCurrent.Image = new Bitmap(_currentImage);
            picCurrent.Refresh();

            Graphics g = picCurrent.CreateGraphics();
            Pen newPen = new Pen(Color.Yellow);
            List<System.Drawing.Point> points = ConvertCornerToPoint();
            g.DrawLine(newPen, points[0], points[1]);
            g.DrawLine(newPen, points[1], points[2]);
            g.DrawLine(newPen, points[2], points[3]);
            g.DrawLine(newPen, points[3], points[0]);

            Color[] colors =
                {
                    Color.FromArgb(0, 255, 0), Color.FromArgb(255, 100, 100), Color.FromArgb(255, 0, 255),
                    Color.FromArgb(0, 255, 255)
                };

            Pen p1 = new Pen(colors[0], 3);
            Pen p2 = new Pen(colors[1], 3);
            Pen p3 = new Pen(colors[2], 3);
            Pen p4 = new Pen(colors[3], 3);

            int X = points[0].X;
            int Y = points[0].Y;
            g.DrawLine(p1, X - 5, Y - 5, X + 5, Y - 5);
            g.DrawLine(p1, X + 5, Y - 5, X + 5, Y + 5);
            g.DrawLine(p1, X + 5, Y + 5, X - 5, Y + 5);
            g.DrawLine(p1, X - 5, Y + 5, X - 5, Y - 5);

            X = points[1].X;
            Y = points[1].Y;
            g.DrawLine(p2, X - 5, Y - 5, X + 5, Y - 5);
            g.DrawLine(p2, X + 5, Y - 5, X + 5, Y + 5);
            g.DrawLine(p2, X + 5, Y + 5, X - 5, Y + 5);
            g.DrawLine(p2, X - 5, Y + 5, X - 5, Y - 5);

            X = points[2].X;
            Y = points[2].Y;
            g.DrawLine(p3, X - 5, Y - 5, X + 5, Y - 5);
            g.DrawLine(p3, X + 5, Y - 5, X + 5, Y + 5);
            g.DrawLine(p3, X + 5, Y + 5, X - 5, Y + 5);
            g.DrawLine(p3, X - 5, Y + 5, X - 5, Y - 5);

            X = points[3].X;
            Y = points[3].Y;
            g.DrawLine(p4, X - 5, Y - 5, X + 5, Y - 5);
            g.DrawLine(p4, X + 5, Y - 5, X + 5, Y + 5);
            g.DrawLine(p4, X + 5, Y + 5, X - 5, Y + 5);
            g.DrawLine(p4, X - 5, Y + 5, X - 5, Y - 5);



        }

        private void btnRectify_Click(object sender, EventArgs e)
        {
            CalcDstSize(_corners);
            Mat quad = new Mat(new OpenCvSharp.Size(g_dst_width, g_dst_hight), MatType.CV_8UC3);
            quad.SetTo(0);
            Mat src = Cv2.ImRead(_currentImage, ImreadModes.Color);
            List<Point2f> quad_pts = new List<Point2f>();
            quad_pts.Add(new Point2f(0, 0));
            quad_pts.Add(new Point2f(quad.Cols, 0));
            quad_pts.Add(new Point2f(quad.Cols, quad.Rows));
            quad_pts.Add(new Point2f(0, quad.Rows));
            Point2f[] sourcePnts = ConvertToPoint2f(_corners);
            Point2f[] quadPnts = quad_pts.ToArray();
            Mat transmtx = Cv2.GetPerspectiveTransform(sourcePnts, quadPnts);
            Cv2.WarpPerspective(src, quad, transmtx, quad.Size());
            //Cv2.ImShow("Result", quad);
            picCurrent.Image = null;
            string newName = _database.CreateAttachmentName() + ".jpg";
            Cv2.ImWrite(newName, quad);
            picCurrent.Image = new Bitmap(newName);
            _currentImage = newName;
            picCurrent.Refresh();
            CalculateCorners();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cameraControl.CloseCamera();
            DialogResult = DialogResult.OK;
        }
    }
}
