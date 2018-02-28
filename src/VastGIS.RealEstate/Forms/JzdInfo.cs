using System.ComponentModel;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;

namespace VastGIS.Plugins.RealEstate.Forms
{
    internal class JzdInfo : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private Jzd _jzd;
        private bool _selected;
        private int _zdnsxh;
        private long _id;
        private string _jzdh;
        private string _jblx;
        private string _jzdlx;
        private double _xzbz;
        private double _yzbz;

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

        public string Jzdh
        {
            get { return _jzdh; }
            set {
                if (this._jzdh != value)
                {
                    this.OnPropertyChanging("Jzdh");
                    this._jzdh = value;
                    this.OnPropertyChanged("Jzdh");
                }
            }
        }

        public string Jblx
        {
            get { return _jblx; }
            set
            {
                if (this._jblx != value)
                {
                    this.OnPropertyChanging("Jblx");
                    this._jblx = value;
                    this.OnPropertyChanged("Jblx");
                }
            }
        }

        public string Jzdlx
        {
            get { return _jzdlx; }
            set
            {
                if (this._jzdlx != value)
                {
                    this.OnPropertyChanging("Jzdlx");
                    this._jzdlx = value;
                    this.OnPropertyChanged("Jzdlx");
                }
            }
        }

        public double Xzbz
        {
            get { return _xzbz; }
            set
            {
                if (this._xzbz != value)
                {
                    this.OnPropertyChanging("Xzbz");
                    this._xzbz = value;
                    this.OnPropertyChanged("Xzbz");
                }
            }
        }

        public double Yzbz
        {
            get { return _yzbz; }
            set {
                if (this._yzbz != value)
                {
                    this.OnPropertyChanging("Yzbz");
                    this._yzbz = value;
                    this.OnPropertyChanged("Yzbz");
                }
            }
        }

        public JzdInfo(Jzd jzd)
        {
            ID = jzd.ID;
            Jzdh = jzd.Jzdh;
            Jblx = jzd.Jblx;
            Jzdlx = jzd.Jzdlx;
            Xzbz = jzd.Geometry.Points[0].X;
            Yzbz = jzd.Geometry.Points[0].Y;
            Selected = false;
            _jzd = jzd;
        }

        public JzdInfo()
        {
            Selected = true;
            ID = -1;
            _jzd = new Jzd();
        }

        public void LoadJzd(Jzd jzd)
        {
            ID = jzd.ID;
            Jzdh = jzd.Jzdh;
            Jblx = jzd.Jblx;
            Jzdlx = jzd.Jzdlx;
            Xzbz = jzd.Geometry.Points[0].X;
            Yzbz = jzd.Geometry.Points[0].Y;
            Selected = false;
            _jzd = jzd;
        }

        public Jzd GetJzd()
        {
            if (_jzd.ID <= 0)
            {
                _jzd.Jzdh = Jzdh;
                _jzd.Jblx = Jblx;
                _jzd.Jzdlx = Jzdlx;
                _jzd.Geometry = GeometryHelper.CreatePoint(Xzbz, Yzbz);
                _jzd.Xzbz = Xzbz;
                _jzd.Yzbz = Yzbz;
            }
            return _jzd;
        }
    }
}