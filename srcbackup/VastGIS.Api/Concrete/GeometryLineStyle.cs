﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using MapWinGIS;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class GeometryLineStyle: IGeometryLineStyle
    {
        private readonly ShapeDrawingOptions _style;

        internal GeometryLineStyle(ShapeDrawingOptions style)
        {
            if (style == null)
            {
                throw new NullReferenceException("Underlying style object is null.");
            }
            _style = style;
        }

        public byte Transparency
        {
            get { return (byte)_style.LineTransparency; }
            set { _style.LineTransparency = value; }
        }

        public bool Visible
        {
            get { return _style.LineVisible; }
            set { _style.LineVisible = value; }
        }

        public float Width
        {
            get { return _style.LineWidth; }
            set { _style.LineWidth = value; }
        }

        public Color Color
        {
            get { return ColorHelper.UintToColor(_style.LineColor); }
            set { _style.LineColor = ColorHelper.ColorToUInt(value); }
        }

        public DashStyle DashStyle
        {
            get { return (DashStyle)_style.LineStipple; }
            set { _style.LineStipple = (tkDashStyle)value; }
        }

        public bool UsePattern
        {
            get { return _style.UseLinePattern; }
            set { _style.UseLinePattern = value; }
        }

        public CompositeLine Pattern
        {
            get { return _style.LinePattern != null ? new CompositeLine(_style.LinePattern) : null; }
            set { _style.LinePattern = value.GetInternal(); }
        }
    }
}
