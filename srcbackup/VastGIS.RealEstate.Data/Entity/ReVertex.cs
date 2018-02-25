using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Entity
{
    public class ReVertex
    {
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
        public bool Checked { get; set; }
        public int ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int Part { get; set; }

        
        public IGeometry GetGeometry()
        {
            
                IGeometry geometry=new Geometry(GeometryType.Point,ZValueType.None);
                geometry.Points.Add(new Coordinate(X,Y));
                return geometry;
           
        }
    }
}
