﻿using System;
using System.Drawing;
using MapWinGIS;
using VastGIS.Shared;

namespace VastGIS.Api.Concrete
{
    public class ColorInterval : IEquatable<ColorInterval>
    {
        // these 2 are used to loop through breaks
        private readonly int _breakIndex = -1;
        private readonly ColorScheme _scheme;
        
        // these ones for adding a new break
        private readonly double _value;
        private Color _color;

        public double Value
        {
            get
            {
                if (_scheme != null)
                {
                    return _scheme.BreakValue[_breakIndex];
                }
                return _value;
            }
        }

        public Color Color
        {
            get
            {
                if (_scheme != null)
                {
                    return ColorHelper.UintToColor(_scheme.BreakColor[_breakIndex]);
                }
                return _color;
            }
            set
            {
                if (_scheme != null)
                {
                    _scheme.BreakColor[_breakIndex] = ColorHelper.ColorToUInt(value);
                }
                _color = value;
            }
        }

        public ColorInterval(double value, Color color)
        {
            _value = value;
            _color = color;
        }

        internal ColorInterval(ColorScheme scheme, int breakIndex)
        {
            if (scheme == null)
            {
                throw new NullReferenceException("Inner reference is null.");
            }
            if (breakIndex < 0 || breakIndex >= scheme.NumBreaks)
            {
                throw new ArgumentOutOfRangeException("breakIndex", "Color break index is out of range.");
            }
            _scheme = scheme;
            _breakIndex = breakIndex;
        }

        public bool Equals(ColorInterval other)
        {
            // TODO: use tolerance for comparison
            return other != null && other.Value.Equals(Value);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ColorInterval);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
