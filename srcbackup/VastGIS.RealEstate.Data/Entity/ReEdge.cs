using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;

namespace VastGIS.RealEstate.Data.Entity
{
    public class ReEdge
    {
        public int Id { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        private GeoAPI.Geometries.ILineString lineString;

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
    }
}
