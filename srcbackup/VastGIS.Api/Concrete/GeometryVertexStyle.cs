﻿using System;
using System.Drawing;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class GeometryVertexStyle: IGeometryVertexStyle
    {
         private readonly ShapeDrawingOptions _style;

         public GeometryVertexStyle(ShapeDrawingOptions style)
        {
            if (style == null)
            {
                throw new NullReferenceException("Internal reference is null.");
            }
            _style = style;
        }
        
        public Color Color
        {
            get { return ColorHelper.UintToColor(_style.VerticesColor); }
            set { _style.VerticesColor = ColorHelper.ColorToUInt(value); }
        }

        public bool FillVisible
        {
            get { return _style.VerticesFillVisible; }
            set { _style.VerticesFillVisible = value; }
        }

        public int Size
        {
            get { return _style.VerticesSize; }
            set { _style.VerticesSize = value; }
        }

        public VertexType VertexType
        {
            get { return (VertexType)_style.VerticesType; }
            set { _style.VerticesType = (tkVertexType)value; }
        }

        public bool Visible
        {
            get { return _style.VerticesVisible; }
            set { _style.VerticesVisible = value; }
        }
    }
}
