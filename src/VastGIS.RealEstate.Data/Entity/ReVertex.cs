using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Entity
{
    public class ReVertex : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private bool _checked;
        private int _id;
        private double _x;
        private double _y;
        private int _part;

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

        public ReVertex(int id, double x, double y,bool used=true)
        {
            ID = id;
            X = x;
            Y = y;
            Checked = used;
            Part = 1;
        }
        public ReVertex(int part,int id, double x, double y, bool used = true)
        {
            ID = id;
            X = x;
            Y = y;
            Checked = used;
            Part = part;
        }

        public bool Checked
        {
            get { return _checked; }
            set
            {
                if (this._checked != value)
                {
                    this.OnPropertyChanging("Checked");
                    this._checked = value;
                    this.OnPropertyChanged("Checked");
                }
            }
        }

        public int ID
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

        public double X
        {
            get { return _x; }
            set
            {
                if (this._x != value)
                {
                    this.OnPropertyChanging("X");
                    this._x = value;
                    this.OnPropertyChanged("X");
                }
            }
        }

        public double Y
        {
            get { return _y; }
            set
            {
                if (this._y != value)
                {
                    this.OnPropertyChanging("Y");
                    this._y = value;
                    this.OnPropertyChanged("Y");
                }
            }
        }

        public int Part
        {
            get { return _part; }
            set
            {
                if (this._part != value)
                {
                    this.OnPropertyChanging("Part");
                    this._part = value;
                    this.OnPropertyChanged("Part");
                }
            }
        }

        public IGeometry GetGeometry()
        {
            
                IGeometry geometry=new Geometry(GeometryType.Point,ZValueType.None);
                geometry.Points.Add(new Coordinate(X,Y));
                return geometry;
           
        }
    }
}
