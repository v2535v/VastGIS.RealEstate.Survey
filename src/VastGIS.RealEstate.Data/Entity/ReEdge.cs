using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;

namespace VastGIS.RealEstate.Data.Entity
{
    public class ReEdge : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public int Id
        {
            get { return _id; }
            set
            {
                if (this._id != value)
                {
                    this.OnPropertyChanging("Id");
                    this._id = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        public double X1
        {
            get { return _x1; }
            set
            {
                if (this._x1 != value)
                {
                    this.OnPropertyChanging("X1");
                    this._x1 = value;
                    this.OnPropertyChanged("X1");
                }
            }
        }

        public double Y1
        {
            get { return _y1; }
            set
            {
                if (this._y1 != value)
                {
                    this.OnPropertyChanging("Y1");
                    this._y1 = value;
                    this.OnPropertyChanged("Y1");
                }
            }
        }

        public double X2
        {
            get { return _x2; }
            set
            {
                if (this._x2 != value)
                {
                    this.OnPropertyChanging("X2");
                    this._x2 = value;
                    this.OnPropertyChanged("X2");
                }
            }
        }

        public double Y2

        {
            get { return _y2; }
            set
            {
                if (this._y2 != value)
                {
                    this.OnPropertyChanging("Y2");
                    this._y2 = value;
                    this.OnPropertyChanged("Y2");
                }
            }
        }

        private GeoAPI.Geometries.ILineString lineString;
        private int _id;
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;

        public ReEdge(int id, double x1, double y1, double x2, double y2)
        {
            Id = id;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            //GeometryFactory factory=new GeometryFactory();
            //Coordinate[] coords = new Coordinate[2];
            //coords[0]=new Coordinate(x1,y1);
            //coords[1] = new Coordinate(x2, y2);
            //lineString = factory.CreateLineString(coords);
        }

        public ReEdge Clone()
        {
            return new ReEdge(Id,X1,Y1,X2,Y2);
        }

        public double Length
        {
            get { return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)); }
        }

        public ReEdge Extend(double dist)
        {
            double lineDistance = Length;
            if (lineDistance == 0)
            {
                return null;
            }

            double xx = X1 + (X2 - X1) * dist / lineDistance;
            double yy = Y1 + (Y2 - Y1) * dist / lineDistance;
            return new ReEdge(Id,X1,Y1,xx,yy);
        }

        public bool QueryPoint(double dist, out double xx, out double yy)
        {
            double lineDistance = Length;
            if (lineDistance == 0)
            {
                xx = 0;
                yy = 0;
                return false;
            }

             xx = X1 + (X2 - X1) * dist / lineDistance;
             yy = Y1 + (Y2 - Y1) * dist / lineDistance;
            return true;
        }

        public double CenterX
        {
            get { return (X1 + X2) / 2.0; }
        }
        public double CenterY
        {
            get { return (Y1 + Y2) / 2.0; }
        }

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
    }
}
