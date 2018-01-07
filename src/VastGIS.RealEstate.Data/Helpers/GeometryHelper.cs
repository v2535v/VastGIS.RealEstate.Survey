using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Helpers
{
   
    public static class GeometryHelper
    {

        /// <summary>
        /// 距离交会
        /// </summary>
        /// <param name="pointA">已知点1</param>
        /// <param name="distA">到已知点1的距离</param>
        /// <param name="pointB">已知点2</param>
        /// <param name="distB">到已知点2的距离</param>
        /// <param name="interPnt1">已知点1到已知点2连线左侧的交点，也就是前进方向左侧</param>
        /// <param name="interPnt2">已知点1到已知点2连线右侧的交点，也就是前进方向右侧</param>
        /// <returns>交点个数，-1表示没有交点，1表示两个圆相切，2表示两个交点</returns>
        public static int DistanceIntersection(
            ICoordinate pointA,
            double distA,
            ICoordinate pointB,
            double distB,
            out ICoordinate interPnt1,
            out ICoordinate interPnt2)
        {
            DbGeometry circle1 = CreateCircularString(pointA.X, pointA.Y, distA);
            DbGeometry circle2 = CreateCircularString(pointB.X, pointB.Y, distB);
            DbGeometry inters = circle1.Intersection(circle2);
            if (inters == null)
            {
                interPnt1 = null;
                interPnt2 = null;
                return -1;
            }
            if (inters.PointCount == 1)
            {
                double xx1 = Convert.ToDouble(inters.PointAt(1).XCoordinate);
                double yy1 = Convert.ToDouble(inters.PointAt(1).YCoordinate);
                interPnt1 = new Coordinate(xx1,yy1);
                interPnt2 = null;
                return 1;
            }
            double x1 = Convert.ToDouble(inters.PointAt(1).XCoordinate);
            double y1 = Convert.ToDouble(inters.PointAt(1).YCoordinate);
            double x2 = Convert.ToDouble(inters.PointAt(2).XCoordinate);
            double y2 = Convert.ToDouble(inters.PointAt(2).YCoordinate);
            interPnt1 = new Coordinate(x1, y1);
            interPnt2 = new Coordinate(x2, y2);
            return 2;
        }

        public static ICoordinate CalculatePointAlongPolygonDistance(
            IGeometry geometry,
            int startPoint,
            double distance,
            bool isForward = false)
        {
            int count = geometry.Points.Count;
            int actualIndex = startPoint;
            ICoordinate startPnt;
            ICoordinate endPnt;
            double sx;
            double sy;
            double ex;
            double ey;
            if (startPoint == 0 || startPoint == geometry.Points.Count - 1)
            {
                if (isForward == false)
                {
                    actualIndex = 0;
                    geometry.GetPoint(0, out sx, out sy);
                    geometry.GetPoint(geometry.Points.Count - 2, out ex, out ey);
                } 
            }
            return null;
        }

        public static DbGeometry CreateCircularString(double centerX, double centerY, double distance)
        {
            double xx1 = centerX - distance;
            double yy1 = centerY;

            double xx2 = centerX;
            double yy2 = centerY + distance;

            double xx3 = centerX + distance;
            double yy3 = centerY;

            double xx4 = centerX;
            double yy4 = centerY - distance;
            string wkt = string.Format("CIRCULARSTRING({0} {1},{2} {3},{4} {5},{6} {7},{0} {1})", xx1, yy1, xx2, yy2,
                xx3, yy3, xx4, yy4);
            DbGeometry geometry = DbGeometry.FromText(wkt);
            return geometry;
        }


        /// <summary>
        /// 多边形合并，主要用于宗地或者房产的处理
        /// </summary>
        /// <param name="geometries"></param>
        /// <returns></returns>
        public static IGeometry UnionPolygons(List<IGeometry> geometries)
        {
            GeoAPI.Geometries.IGeometry unionall = null;
            GeometryFactory gf=new GeometryFactory();
            WKTReader reader=new WKTReader(gf);
            foreach (IGeometry geometry in geometries)
            {
                GeoAPI.Geometries.IGeometry newGeom= reader.Read(geometry.ExportToWkt());
                if (unionall == null)
                {
                    unionall = newGeom.Clone() as GeoAPI.Geometries.IGeometry;
                }
                else
                {
                    unionall=unionall.Union(newGeom);
                }
            }
            if (unionall == null) return null;
            IGeometry lastGeom=new Api.Concrete.Geometry(GeometryType.Polygon,ZValueType.None);
            lastGeom.ImportFromWkt(unionall.AsText());
            lastGeom = SpatialHelper.ReorderPolygonVertex(lastGeom);
            return lastGeom;
        }
    }
}
