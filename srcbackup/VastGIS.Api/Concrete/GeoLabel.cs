﻿using System;
using MapWinGIS;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Concrete
{
    public class GeoLabel: IGeoLabel
    {
        private readonly Label _label;

        internal GeoLabel(Label label)
        {
            _label = label;
        }

        public object InternalObject
        {
            get { return _label; }
        }

        public string LastError
        {
            get { return ErrorHelper.NO_ERROR; }
        }

        public string Tag
        {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public int CategoryIndex
        {
            get { return _label.Category; }
            set { _label.Category = value; }
        }

        public bool IsDrawn
        {
            get { return _label.IsDrawn; }
        }

        public double Rotation
        {
            get { return _label.Rotation; }
            set { _label.Rotation = value; }
        }

        public IEnvelope ScreenExtents
        {
            get { return new Envelope(_label.ScreenExtents); }
        }

        public string Text
        {
            get { return _label.Text; }
            set { _label.Text = value; }
        }

        public bool Visible
        {
            get { return _label.Visible; }
            set { _label.Visible = value; }
        }

        public double X
        {
            get { return _label.x; }
            set { _label.x = value; }
        }

        public double Y
        {
            get { return _label.y; }
            set { _label.y = value; }
        }
    }
}
