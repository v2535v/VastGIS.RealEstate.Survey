﻿using System.Drawing;
using System.Drawing.Drawing2D;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Interfaces
{
    public interface IGeometryFillStyle
    {
        GradientBounds GradientBounds { get; set; }
        GradientType GradientType { get; set; }
        FillType Type { get; set; }
        double Rotation { get; set; }
        byte Transparency { get; set; }
        Color Color { get; set; }
        Color Color2 { get; set; }
        Color BgColor { get; set; }
        bool BgTransparent { get; set; }
        bool Visible { get; set; }
        HatchStyle HatchStyle { get; set; }
        void SetGradient(Color color, byte range);
        IImageSource Texture { get; set; }
    }
}
