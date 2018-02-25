﻿using System;
using System.ComponentModel;
using System.Drawing;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class RasterInterval: IComWrapper
    {
        private readonly GridColorBreak _colorBreak;

        public RasterInterval()
        {
            _colorBreak = new GridColorBreak();
        }

        internal RasterInterval(GridColorBreak colorBreak)
        {
            _colorBreak = colorBreak;
            if (colorBreak == null)
            {
                throw new NullReferenceException("Internal reference is null");
            }
        }

        [Browsable(false)]
        public object InternalObject
        {
            get { return _colorBreak; }
        }

        [Browsable(false)]
        public string LastError
        {
            get { return _colorBreak.ErrorMsg[_colorBreak.LastErrorCode]; }
        }

        [Browsable(false)]
        public string Tag
        {
            get { return _colorBreak.Key; }
            set { _colorBreak.Key = value; }
        }

        [DisplayName("Color2")]
        public Color HighColor
        {
            get { return ColorHelper.UintToColor(_colorBreak.HighColor); }
            set { _colorBreak.HighColor = ColorHelper.ColorToUInt(value); }
        }

        [DisplayName("Color")]
        public Color LowColor
        {
            get { return ColorHelper.UintToColor(_colorBreak.LowColor); }
            set { _colorBreak.LowColor = ColorHelper.ColorToUInt(value); }
        }

        [DisplayName("Value2")]
        public double HighValue
        {
            get { return _colorBreak.HighValue; }
            set { _colorBreak.HighValue = value; }
        }

        [DisplayName("Value")]
        public double LowValue
        {
            get { return _colorBreak.LowValue; }
            set { _colorBreak.LowValue = value; }
        }

        [Browsable(false)]
        public GridColoringType ColoringType
        {
            get { return (GridColoringType)_colorBreak.ColoringType; }
            set { _colorBreak.ColoringType = (ColoringType)value; }
        }

        [Browsable(false)]
        public GridGradientModel GradientModel
        {
            get { return (GridGradientModel)_colorBreak.GradientModel; }
            set { _colorBreak.GradientModel = (GradientModel)value; }
        }

        public string Range
        {
            get { return ToString(); }
        }

        public string Caption
        {
            get { return _colorBreak.Caption; }
            set { _colorBreak.Caption = value; }
        }

        [DisplayName(" ")]
        public bool Visible
        {
            get { return _colorBreak.Visible; }
            set { _colorBreak.Visible = value; }
        }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Caption))
            {
                return Caption;     // TODO: perhaps both caption and values are needed
            }

            string s = string.Empty;
            if (LowValue != HighValue)
            {
                s += string.Format("{0:g6} - {1:g6}", LowValue, HighValue);
            }
            else
            {
                s += string.Format("{0:g6}", LowValue);
            }

            return s;
        }
    }
}
