﻿using System;
using System.Drawing;
using System.IO;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;
using VastGIS.Shared.Log;
using stdole;
using Image = MapWinGIS.Image;

namespace VastGIS.Api.Concrete
{
    public class BitmapSource : IImageSource
    {
        protected Image _image;

        internal BitmapSource(Image image)
        {
            if (image == null)
            {
                throw new NullReferenceException("Internal reference is empty.");
            }
            _image = image;
        }

        public IPictureDisp Picture
        {
            get { return _image.Picture; }
            set { _image.Picture = value; }
        }

        #region Static methods

        internal static IImageSource Wrap(Image img)
        {
            if (img == null)
            {
                return null;
            }

            if (img.SourceType == tkImageSourceType.istGDALBased)
            {
                return new RasterSource(img);
            }
            return new BitmapSource(img);
        }

        public static BitmapSource CreateEmpty()
        {
            var img = new Image();
            return new BitmapSource(img);
        }

        public static BitmapSource CreateNew(int newWidth, int newHeight)
        {
            var img = new Image();
            if (img.CreateNew(newWidth, newHeight))
            {
                return new BitmapSource(img);
            }
            throw new ApplicationException("Failed to create image: " + img.ErrorMsg[img.LastErrorCode]);
        }

        public static IImageSource Open(string filename, bool inRam)
        {
            var img = new Image();

            if (!img.Open(filename, ImageType.USE_FILE_EXTENSION, inRam))
            {
                Logger.Current.Warn("Failed to open datasource: " + img.ErrorMsg[img.LastErrorCode]);
                return null;
            }

            return Wrap(img);
        }

        #endregion

        public virtual double Dx
        {
            get { return _image.dX; }
            set { _image.dX = value; }
        }

        public virtual double Dy
        {
            get { return _image.dY; }
            set { _image.dY = value; }
        }

        public virtual int Height
        {
            get { return _image.Height; }
        }

        public virtual int Width
        {
            get { return _image.Width; }
        }

        public virtual double XllCenter
        {
            get { return _image.XllCenter; }
            set { _image.XllCenter = value; }
        }

        public virtual double YllCenter
        {
            get { return _image.YllCenter; }
            set { _image.YllCenter = value; }
        }

        public IEnvelope GetPixelBounds(int col, int row)
        {
            double x, y, x2, y2;
            _image.ImageToProjection(col, row, out x, out y);
            _image.ImageToProjection(col + 1, row + 1, out x2, out y2);
            return new Envelope(x, x2, Math.Min(y, y2), Math.Max(y, y2));
        }

        public Color TransparentColorFrom
        {
            get { return ColorHelper.UintToColor(_image.TransparencyColor); }
            set { _image.TransparencyColor = ColorHelper.ColorToUInt(value); }
        }

        public Color TransparentColorTo
        {
            get { return ColorHelper.UintToColor(_image.TransparencyColor2); }
            set { _image.TransparencyColor2 = ColorHelper.ColorToUInt(value); }
        }

        public bool UseTransparentColor
        {
            get { return _image.UseTransparencyColor; }
            set { _image.UseTransparencyColor = value; }
        }

        public void SetTransparentColor(Color color)
        {
            TransparentColorFrom = color;
            TransparentColorTo = color;
            UseTransparentColor = true;
        }

        public void SetTransparentColorRange(Color colorFrom, Color colorTo)
        {
            TransparentColorFrom = colorFrom;
            TransparentColorTo = colorTo;
            UseTransparentColor = true;
        }

        public double Transparency
        {
            get { return _image.TransparencyPercent; }
            set { _image.TransparencyPercent = value; }
        }

        public InterpolationType DownsamplingMode
        {
            get { return (InterpolationType) _image.DownsamplingMode; }
            set { _image.DownsamplingMode = (tkInterpolationMode) value; }
        }

        public InterpolationType UpsamplingMode
        {
            get { return (InterpolationType) _image.UpsamplingMode; }
            set { _image.UpsamplingMode = (tkInterpolationMode) value; }
        }

        public ImageFormat ImageFormat
        {
            get { return (ImageFormat) _image.ImageType; }
        }

        public InRamState InRamState
        {
            get
            {
                // ReSharper disable RedundantCaseLabel
                switch (_image.SourceType)
                {
                    case tkImageSourceType.istDiskBased:
                    case tkImageSourceType.istGDIPlus:
                        return InRamState.Disk;

                    case tkImageSourceType.istGDALBased:
                        return InRamState.InRamBuffer;
                    case tkImageSourceType.istInMemory:
                    case tkImageSourceType.istUninitialized:
                    default:
                        return InRamState.InRam;
                }
            }
        }

        public ImageSourceType SourceType
        {
            get { return (ImageSourceType) _image.SourceType; }
        }

        public void Close()
        {
            _image.Close();
        }

        public string OpenDialogFilter
        {
            get { return "Bitmaps (*.bmp)|*.bmp"; }
        }

        public void Clear(Color color)
        {
            _image.Clear(ColorHelper.ColorToUInt(color));
        }

        public bool Save(string filename, bool writeWorldFile = false,
            ImageFormat fileType = ImageFormat.UseFileExtension)
        {
            return _image.Save(filename, writeWorldFile, (ImageType) fileType);
        }

        public void ImageToProjection(int column, int row, out double projX, out double projY)
        {
            _image.ImageToProjection(column, row, out projX, out projY);
        }

        public bool ProjectionToImage(double projX, double projY, out int column, out int row)
        {
            _image.ProjectionToImage(projX, projY, out column, out row);
            return column >= 0 && column < Width && row >= 0 && row < Height;
        }

        public Color GetPixel(int row, int column)
        {
            uint val = _image.ValueWithAlpha[row, column];
            return ColorHelper.UintWithAlphaToColor(val);
        }

        public void SetPixel(int row, int column, Color color)
        {
            var val = ColorHelper.ColorToUIntWithAlpha(color);
            _image.ValueWithAlpha[row, column] = val;
        }

        #region ILayerSource members

        public object InternalObject
        {
            get { return _image; }
        }

        public IEnvelope Envelope
        {
            get { return new Envelope(_image.Extents); }
        }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(Filename); }
        }

        public string Filename
        {
            get { return _image.Filename; }
        }

        public ISpatialReference Projection
        {
            get { return new SpatialReference(_image.GeoProjection); }
        }

        /// <summary>
        /// Assigns projection to the layer if the layer doesn't have one.
        /// </summary>
        public void AssignProjection(ISpatialReference proj)
        {
            if (proj == null) throw new ArgumentNullException("proj");
            _image.GeoProjection = proj.Clone().GetInternal();
        }

        public bool IsEmpty
        {
            get { return _image.IsEmpty; }
        }

        /// <summary>
        /// Gets string with the information on datasource size, i.e. number of features, pixels, etc.
        /// </summary>
        public string SizeInfo 
        {
            get
            {
                return string.Format("[{0}×{1} pixels]", _image.Width, _image.Height);
            } 
        }

        public LayerType LayerType
        {
            get { return LayerType.Image; }
        }

        public virtual string ToolTipText
        {
            get
            {
                string s = string.Format("Size: {0}×{1}", Width, Height) + Environment.NewLine;
                s += "XllCenter: " + XllCenter + Environment.NewLine;
                s += "YllCenter: " + YllCenter + Environment.NewLine;
                s += "dX: " + Dx + Environment.NewLine;
                s += "dY: " + Dy + Environment.NewLine;
                s += "Projection: " + Projection.ExportToProj4();
                return s;
            }
        }

        public bool IsVector
        {
            get { return false; }
        }

        public bool IsRaster
        {
            get { return true; }
        }

        public IGlobalListener Callback
        {
            get { return NativeCallback.UnWrap(_image.GlobalCallback); }
            set { _image.GlobalCallback = NativeCallback.Wrap(value); }
        }

        #endregion

        public object GetInternalObject()
        {
            return _image;
        }

        public string LastError
        {
            get { return _image.ErrorMsg[_image.LastErrorCode]; }
        }

        public string Tag
        {
            get { return _image.Key; }
            set { _image.Key = value; }
        }

        public string Serialize()
        {
            // TODO: add method to serialize with pixels
            return _image.Serialize(false);
        }

        public bool Deserialize(string state)
        {
            _image.Deserialize(state);
            return true;
        }

        public void Dispose()
        {
            _image.Close();
        }

        public System.Drawing.Image ToGdiPlusBitmap()
        {
            var utils = new OleImageHelper();
            return utils.GetPictureFromIPicture(Picture);
        }

        public bool FromGdiPlusBitmap(System.Drawing.Image image)
        {
            if (image == null)
            {
                return false;
            }

            OleImageHelper utils = new OleImageHelper();
            Picture = (IPictureDisp) utils.GetIPictureFromPicture(image);
            return true;
        }

        public virtual int NumBands
        {
            get { return 3; }
        }

        public virtual GdalDataType DataType
        {
            get { return GdalDataType.Byte; }
        }

        public float Brightness
        {
            get { return _image.Brightness; }
            set { _image.Brightness = value; }
        }

        public float Contrast
        {
            get { return _image.Contrast; }
            set { _image.Contrast = value; }
        }

        public float Hue
        {
            get { return _image.Hue; }
            set { _image.Hue = value; }
        }

        public float Saturation
        {
            get { return _image.Saturation; }
            set { _image.Saturation = value; }
        }

        public float Gamma
        {
            get { return _image.Gamma; }
            set { _image.Gamma = value; }
        }

        public Color ColorizeColor
        {
            get { return ColorHelper.UintToColor(_image.ColorizeColor); }
            set { _image.ColorizeColor = ColorHelper.ColorToUInt(value); }
        }

        public float ColorizeIntensity
        {
            get { return _image.ColorizeIntensity; }
            set { _image.ColorizeIntensity = value; }
        }

        public bool Greyscale
        {
            get { return _image.SetToGrey; }
            set { _image.SetToGrey = value; }
        }

        public virtual RasterColorScheme RgbBandMapping
        {
            get
            {
                var scheme = new RasterColorScheme();

                scheme.AddInterval(new RasterInterval() {LowColor = Color.Red, Caption = "Band 1 (Red)"});
                scheme.AddInterval(new RasterInterval() {LowColor = Color.Green, Caption = "Band 2 (Green)"});
                scheme.AddInterval(new RasterInterval() {LowColor = Color.Blue, Caption = "Band 3 (Blue)"});

                return scheme;
            }
        }
    }
}
