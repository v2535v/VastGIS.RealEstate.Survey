using System;
using System.ComponentModel;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.Plugins.RealEstate.Forms
{
    internal class JzxInfo : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private Jzx _jzx;
        private bool _selected;
        private int _zdnsxh;
        private long _id;
        private string _jzxlb;
        private string _jzxwz;
        private string _jxxz;
        private double _centerX;
        private double _centerY;
        private double _startX;
        private double _startY;
        private double _endX;
        private double _endY;

        private event PropertyChangingEventHandler propertyChanging;
        private event PropertyChangedEventHandler propertyChanged;
        event PropertyChangingEventHandler INotifyPropertyChanging.PropertyChanging
        {
            add { this.propertyChanging += value; }
            remove { this.propertyChanging -= value; }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { this.propertyChanged += value; }
            remove { this.propertyChanged -= value; }
        }
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if (this.propertyChanging != null)
                this.propertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.propertyChanged != null)
                this.propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool Selected
        {
            get { return _selected; }
            set
            {
                if (this._selected != value)
                {
                    this.OnPropertyChanging("Selected");
                    this._selected = value;
                    this.OnPropertyChanged("Selected");
                }
            }
        }

        public int Zdnsxh
        {
            get { return _zdnsxh; }
            set
            {
                if (this._zdnsxh != value)
                {
                    this.OnPropertyChanging("Zdnsxh");
                    this._zdnsxh = value;
                    this.OnPropertyChanged("Zdnsxh");
                }
            }
        }

        public long ID
        {
            get { return _id; }
            set
            {
                if (this._id != value)
                {
                    this.OnPropertyChanging("ID");
                    this._id = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }


        public string Jzxlb
        {
            get { return _jzxlb; }
            set
            {
                if (this._jzxlb != value)
                {
                    this.OnPropertyChanging("Jzxlb");
                    this._jzxlb = value;
                    this.OnPropertyChanged("Jzxlb");
                }
            }
        }

        public string Jzxwz
        {
            get { return _jzxwz; }
            set
            {
                if (this._jzxwz != value)
                {
                    this.OnPropertyChanging("Jzxwz");
                    this._jzxwz = value;
                    this.OnPropertyChanged("Jzxwz");
                }
            }
        }

        public string Jxxz
        {
            get { return _jxxz; }
            set
            {
                if (this._jxxz != value)
                {
                    this.OnPropertyChanging("Jxxz");
                    this._jxxz = value;
                    this.OnPropertyChanged("Jxxz");
                }
            }
        }

        public double CenterX
        {
            get { return _centerX; }
            set
            {
                if (this._centerX != value)
                {
                    this.OnPropertyChanging("CenterX");
                    this._centerX = value;
                    this.OnPropertyChanged("CenterX");
                }
            }
        }

        public double CenterY
        {
            get { return _centerY; }
            set
            {
                if (this._centerY != value)
                {
                    this.OnPropertyChanging("CenterY");
                    this._centerY = value;
                    this.OnPropertyChanged("CenterY");
                }
            }
        }

        public double StartX
        {
            get { return _startX; }
            set
            {
                if (this._startX != value)
                {
                    this.OnPropertyChanging("StartX");
                    this._startX = value;
                    this.OnPropertyChanged("StartX");
                }
            }
        }

        public double StartY
        {
            get { return _startY; }
            set
            {
                if (this._startY != value)
                {
                    this.OnPropertyChanging("StartY");
                    this._startY = value;
                    this.OnPropertyChanged("StartY");
                }
            }
        }

        public double EndX
        {
            get { return _endX; }
            set
            {
                if (this._endX != value)
                {
                    this.OnPropertyChanging("EndX");
                    this._endX = value;
                    this.OnPropertyChanged("EndX");
                }
            }
        }

        public double EndY
        {
            get { return _endY; }
            set
            {
                if (this._endY != value)
                {
                    this.OnPropertyChanging("EndY");
                    this._endY = value;
                    this.OnPropertyChanged("EndY");
                }
            }
        }

        public JzxInfo(Jzx jzx)
        {
            ID = jzx.ID;
            Jzxlb = jzx.Jzxlb;
            Jzxwz = jzx.Jzxwz;
            Jxxz = jzx.Jxxz;
            Selected = false;
            StartX = jzx.Geometry.Points[0].X;
            StartY = jzx.Geometry.Points[0].Y;
            EndX = jzx.Geometry.Points[1].X;
            EndY = jzx.Geometry.Points[1].Y;
            CenterX = (StartX + EndX) / 2.0;
            CenterY = (StartY + EndY) / 2.0;
            _jzx = jzx;
        }

        public void LoadJzx(Jzx jzx)
        {
            ID = jzx.ID;
            Jzxlb = jzx.Jzxlb;
            Jzxwz = jzx.Jzxwz;
            Jxxz = jzx.Jxxz;
            Selected = false;
            StartX = jzx.Geometry.Points[0].X;
            StartY = jzx.Geometry.Points[0].Y;
            EndX = jzx.Geometry.Points[1].X;
            EndY = jzx.Geometry.Points[1].Y;
            CenterX = (StartX + EndX) / 2.0;
            CenterY = (StartY + EndY) / 2.0;
            _jzx = jzx;
        }

        public JzxInfo()
        {
            Selected = true;
            ID = -1;
            _jzx = new Jzx();
        }

        public Jzx GetJzx()
        {
            if (_jzx.ID <= 0)
            {
                _jzx.Jzxwz = Jzxwz;
                _jzx.Jxxz  = Jxxz;
                _jzx.Jzxlb = Jzxlb;
                _jzx.Geometry = GeometryHelper.CreateLine(StartX, StartY,EndX,EndY);
                _jzx.Jzxcd = Math.Sqrt((StartX - EndX) * (StartX - EndX) + (StartY - EndY) * (StartY - EndY));

            }
            return _jzx;
        }
    }
}