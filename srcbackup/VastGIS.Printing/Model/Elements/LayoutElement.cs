﻿// -------------------------------------------------------------------------------------------
// <copyright file="LayoutElement.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.Serialization;
using VastGIS.Plugins.Printing.Controls.Layout;
using VastGIS.Plugins.Printing.Controls.PropertyGrid;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Shared;

namespace VastGIS.Plugins.Printing.Model.Elements
{
    /// <summary>
    /// Base class for all elements that can be added to the layout control
    /// </summary>
    [DataContract]
    public abstract class LayoutElement
    {
        protected Font _font;
        protected Font _font2;
        private PointF _location;
        private String _name;
        internal SizeF _size;
        private Bitmap _thumbnail;
        private bool _initialized;
        private bool _visible;

        public LayoutElement()
        {
            Visible = true;
            Initialized = false;
        }

        /// <summary>
        /// Fires when the layout element is invalidated
        /// </summary>
        public event EventHandler Invalidated;

        /// <summary>
        /// Fires when the size of this element has been adjusted by the user
        /// </summary>
        public event EventHandler SizeChanged;

        /// <summary>
        /// Fires when the preview thumbnail for this element has been updated
        /// </summary>
        public event EventHandler ThumbnailChanged;

        /// <summary>
        /// Rendering of elements is allowed only after it set to true. 
        /// </summary>
        internal bool Initialized
        {
            get { return _initialized; }
            set
            {
                if (value && !_initialized)
                {
                    _initialized = true;
                    RefreshElement();
                }
            }
        }

        [Browsable(false)]
        [DefaultValue(0)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_height")]
        public float Height
        {
            get { return _size.Height; }
            set
            {
                _size.Height = value;
                SetSize();
            }
        }

        /// <summary>
        /// FOR PROPERTY GRID ONLY!!! Gets or sets the location of the top left corner of the element (in 1/100 of an inch or millimeters depending on config value).
        /// </summary>
        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_location")]
        public Point LocationUI
        {
            get
            {
                double ratio = ConfigHelper.GetUnitsConversionRatio(false);
                return new Point(Convert.ToInt32(_location.X * ratio), Convert.ToInt32(_location.Y * ratio));
            }
            set
            {
                double ratio = ConfigHelper.GetUnitsConversionRatio(false);
                _location = new PointF((float)(value.X / ratio), (float)(value.Y / ratio));
                FireInvalidated();
            }
        }

        /// <summary>
        /// Gets or sets the location of the top left corner of the control in 1/100 of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        [DataMember]
        public PointF LocationF
        {
            get { return _location; }
            set
            {
                _location = value;
                FireInvalidated();
            }
        }

        /// <summary>
        /// Gets or sets the name of the element
        /// </summary>
        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DataMember]
        [DisplayNameEx(@"prop_name")]
        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                FireInvalidated();
            }
        }

        /// <summary>
        /// Gets or sets the rectangle of the element in 1/100th of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        public RectangleF Rectangle
        {
            get { return new RectangleF(_location, _size); }
            set
            {
                AdjustMinRectSize(ref value);

                _location = value.Location;
                _size = value.Size;

                OnSizeChanged();
                FireInvalidated();
                UpdateThumbnail();
            }
        }

        private void AdjustMinRectSize(ref RectangleF value)
        {
            if (value.Width < 10)
            {
                value.Width = 10;
                if (!NumericHelper.Equal(value.X, _location.X))
                {
                    value.X = _location.X + _size.Width - 10;
                }
            }

            if (value.Height < 10)
            {
                value.Height = 10;

                if (!NumericHelper.Equal(value.Y, _location.Y))
                {
                    value.Y = _location.Y + _size.Height - 10;
                }
            }
        }

        /// <summary>
        /// Indicates if this element can handle redraw events on resize
        /// </summary>
        [Browsable(false)]
        public ResizeStyle ResizeStyle { get; set; }

        /// <summary>
        /// Disables updating redraw when resizing.
        /// </summary>
        [Browsable(false)]
        public bool Resizing { get; set; }

        /// <summary>
        /// Gets or sets the size of the element in 1/100 of an inch paper coordinats
        /// </summary>
        [Browsable(false)]
        [DataMember]
        public SizeF SizeF
        {
            get { return new SizeF(_size.Width, _size.Height); }
            set
            {
                if (value.Width < 10) value.Width = 10;
                if (value.Height < 10) value.Height = 10;

                _size = value;

                OnSizeChanged();
                FireInvalidated();
                UpdateThumbnail();
            }
        }

        /// <summary>
        /// !!!FOR PROPERTY GRID ONLY!!! Gets or sets the size of the element (in 1/100 of an inch or millimeters depending on config value).
        /// </summary>
        [Browsable(true)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_size")]
        public Size SizeUI
        {
            get
            {
                double ratio = ConfigHelper.GetUnitsConversionRatio(false);
                return new Size(Convert.ToInt32(_size.Width * ratio), Convert.ToInt32(_size.Height * ratio));
            }
            set
            {
                double ratio = ConfigHelper.GetUnitsConversionRatio(false);
                SizeF = new SizeF((float)(value.Width / ratio), (float)(value.Height / ratio));
            }
        }

        /// <summary>
        /// Gets the thumbnail that appears in the LayoutListView
        /// </summary>
        [Browsable(false)]
        public Bitmap Thumbnail
        {
            get { return _thumbnail; }
            protected set
            {
                RecycleThumbnail();
                _thumbnail = value;
                FireThumbnailChanged();
            }
        }

        [Browsable(false)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_role")]
        public abstract ElementType Type { get; }

        [Browsable(true)]
        [DefaultValue(true)]
        [CategoryEx(@"cat_layout")]
        [DataMember]
        public bool Visible
        {
            get { return _visible; }
            set
            {
                _visible = value;
                RefreshElement();
            }
        }

        [Browsable(false)]
        [CategoryEx(@"cat_layout")]
        [DisplayNameEx(@"prop_width")]
        public float Width
        {
            get { return _size.Width; }
            set
            {
                _size.Width = value;
                SetSize();
            }
        }

        private void RecycleThumbnail()
        {
            if (_thumbnail != null)
            {
                _thumbnail.Dispose();
                _thumbnail = null;
            }
        }

        /// <summary>
        /// Should initialize all private data members which aren't set by deserialization.
        /// </summary>
        protected abstract void SetDefaults();

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            SetDefaults();
        }

        public bool ClickWithin(int x, int y)
        {
            return !(x < LocationF.X || x > LocationF.X + SizeF.Width || y < LocationF.Y || y > LocationF.Y + SizeF.Height);
        }

        /// <summary>
        /// Draws element. LayoutElement.Draw must be called through this method only
        /// </summary>
        public void DrawElement(Graphics g, bool printing, bool export)
        {
            if (!Visible || !Initialized)
            {
                return;
            }

            // LogicTo96Dpi: why is it needed?
            float scaleRatio = printing ? ScreenHelper.LogicTo96Dpi : ScreenHelper.ScreenToLogicDpi;

            var font = _font;
            var font2 = _font2;

            _font = FontHelper.ScaleFont(_font, scaleRatio);
            _font2 = FontHelper.ScaleFont(_font2, scaleRatio);

            var x = printing ? 0 : LocationF.X;
            var y = printing ? 0 : LocationF.Y;

            Draw(g, printing, export, Convert.ToInt32(x), Convert.ToInt32(y));

            _font = font;
            _font2 = font2;
        }

        /// <summary>
        /// Causes the element to be refreshed
        /// </summary>
        public virtual void RefreshElement()
        {
            if (_initialized)
            {
                OnSizeChanged();
                FireInvalidated();
                UpdateThumbnail();
            }
        }

        /// <summary>
        /// This returns the objects name as a string
        /// </summary>
        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// This gets called to instruct the element to draw itself in the appropriate spot of the graphics object
        /// </summary>
        protected abstract void Draw(Graphics g, bool printing, bool export, int x, int y);

        /// <summary>
        /// Call this when it needs to updated
        /// </summary>
        protected void FireInvalidated()
        {
            DelegateHelper.FireEvent(this, Invalidated);
        }

        /// <summary>
        /// Fires when the size of the element changes
        /// </summary>
        protected virtual void OnSizeChanged()
        {
            DelegateHelper.FireEvent(this, SizeChanged);
        }

        /// <summary>
        /// Updates the thumbnail; works for all elements but map where screen buffer is used
        /// </summary>
        protected virtual void UpdateThumbnail()
        {
            if (Resizing || SizeF.Width < 1 || SizeF.Height < 1) return;

            var tempThumbnail = new Bitmap(32, 32, PixelFormat.Format32bppArgb);

            using (var graph = Graphics.FromImage(tempThumbnail))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                graph.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                if ((SizeF.Width / tempThumbnail.Width) > (SizeF.Height / tempThumbnail.Height))
                {
                    graph.ScaleTransform(32F / SizeF.Width, 32F / SizeF.Width);
                    graph.TranslateTransform(-LocationF.X, -LocationF.Y);
                }
                else
                {
                    graph.ScaleTransform(32F / SizeF.Height, 32F / SizeF.Height);
                    graph.TranslateTransform(-LocationF.X, -LocationF.Y);
                }

                graph.Clip = new Region(Rectangle);
                DrawElement(graph, false, false);
            }

            Thumbnail = tempThumbnail;
        }

        /// <summary>
        /// Fires when the thumbnail gets modified
        /// </summary>
        private void FireThumbnailChanged()
        {
            DelegateHelper.FireEvent(this, ThumbnailChanged);
        }

        private void SetSize()
        {
            if (Width < 10) Width = 10;
            if (Height < 10) Height = 10;

            OnSizeChanged();
            FireInvalidated();
            UpdateThumbnail();
        }

        /// <summary>
        /// Returns true if the point in paper coordinats intersects with the rectangle of the element
        /// </summary>
        public bool IntersectsWith(PointF paperPoint)
        {
            return IntersectsWith(new RectangleF(paperPoint.X, paperPoint.Y, 0F, 0F));
        }

        /// <summary>
        /// Returns true if the rectangle in paper coordinats intersects with the rectangle of the the element
        /// </summary>
        public bool IntersectsWith(RectangleF paperRectangle)
        {
            return new RectangleF(LocationF, SizeF).IntersectsWith(paperRectangle);
        }
    }
}