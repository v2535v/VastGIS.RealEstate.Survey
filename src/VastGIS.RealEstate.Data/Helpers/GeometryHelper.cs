using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.RealEstate.Data.Entity;
using Coordinate = VastGIS.Api.Concrete.Coordinate;
using ICoordinate = VastGIS.Api.Interfaces.ICoordinate;
using IGeometry = VastGIS.Api.Interfaces.IGeometry;

namespace VastGIS.RealEstate.Data.Helpers
{
   
    public static class GeometryHelper
    {
        //移动多边形的某一条边
        public static List<ReEdge> MoveEdgeInPolygon(List<ReEdge> edges, int edgeIndex, double dist)
        {
            ReEdge firstEdge;
            ReEdge endEdge;
            int firstEdgeIndex;
            int endEdgeIndex;
            if (edgeIndex == 0)
            {
                firstEdgeIndex = edgeIndex + 1;
                firstEdge = edges[firstEdgeIndex];
                endEdgeIndex = edges.Count- 1;
                endEdge = edges[endEdgeIndex];
            }
            else if (edgeIndex == edges.Count - 1)
            {
                firstEdgeIndex = 0;
                firstEdge = edges[firstEdgeIndex];
                endEdgeIndex = edges.Count - 2;
                endEdge = edges[endEdgeIndex];
            }
            else
            {
                firstEdgeIndex = edgeIndex + 1;
                firstEdge = edges[firstEdgeIndex];
                endEdgeIndex = edgeIndex - 1;
                endEdge = edges[endEdgeIndex];
            }

            //开始计算第一条线的距离点位，因为第一条线是本身线的后续线，连接的是终点，因此可以直接用距离即可
            double endx = 0.0;
            double endy = 0.0;

            bool retVal=firstEdge.QueryPoint(dist,out endx, out endy);
            if (retVal == false) return null;
            double newDist = endEdge.Length - dist;
            double startx = 0.0;
            double starty = 0.0;
            retVal = endEdge.QueryPoint(newDist,out startx, out starty);

            edges[edgeIndex].X1 = startx;
            edges[edgeIndex].Y1 = starty;
            edges[edgeIndex].X2 = endx;
            edges[edgeIndex].Y2 = endy;

            edges[firstEdgeIndex].X1 = endx;
            edges[firstEdgeIndex].Y1 = endy;

            edges[endEdgeIndex].X2 = startx;
            edges[endEdgeIndex].Y2 = starty;
            return edges;
        }

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
        public static string CreateRectangleWkt(double centerX, double centerY, double distance)
        {
            double xx1 = centerX - distance;
            double yy1 = centerY - distance;

            double xx2 = centerX - distance;
            double yy2 = centerY + distance;

            double xx3 = centerX + distance;
            double yy3 = centerY + distance;

            double xx4 = centerX + distance;
            double yy4 = centerY - distance;
            string wkt = string.Format("POLYGON(({0} {1},{2} {3},{4} {5},{6} {7},{0} {1}))", xx1, yy1, xx2, yy2,
                xx3, yy3, xx4, yy4);
           
            return wkt;
        }
        public static DbGeometry CreateRectangleString(double centerX, double centerY, double distance)
        {
            double xx1 = centerX - distance;
            double yy1 = centerY - distance;

            double xx2 = centerX - distance;
            double yy2 = centerY + distance;

            double xx3 = centerX + distance;
            double yy3 = centerY + distance;

            double xx4 = centerX + distance;
            double yy4 = centerY - distance;
            string wkt = string.Format("POLYGON(({0} {1},{2} {3},{4} {5},{6} {7},{0} {1}))", xx1, yy1, xx2, yy2,
                xx3, yy3, xx4, yy4);
            DbGeometry geometry = DbGeometry.FromText(wkt);
            return geometry;
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

        public static string CreateCircularWkt(double centerX, double centerY, double distance)
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
            
            return wkt;
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

        public static IGeometry UnionPolylines(List<IGeometry> geometries)
        {
            GeoAPI.Geometries.IGeometry unionall = null;
            GeometryFactory gf = new GeometryFactory();
            WKTReader reader = new WKTReader(gf);
            foreach (IGeometry geometry in geometries)
            {
                GeoAPI.Geometries.IGeometry newGeom = reader.Read(geometry.ExportToWkt());
                if (unionall == null)
                {
                    unionall = newGeom.Clone() as GeoAPI.Geometries.IGeometry;
                }
                else
                {
                    unionall = unionall.Union(newGeom);
                }
            }
            if (unionall == null) return null;
            IGeometry lastGeom = new Api.Concrete.Geometry(GeometryType.Polygon, ZValueType.None);
            lastGeom.ImportFromWkt(unionall.AsText());
            return lastGeom;
        }

        public static IGeometry CreateGeometryFromVertexes(List<ReVertex> vertexs,GeometryType geometryType, bool useChecked = true,bool usePart=true)
        {
            GeoAPI.Geometries.IGeometry editGeometry = null;
            if (geometryType == GeometryType.MultiPoint || geometryType == GeometryType.Point || geometryType == GeometryType.TextPoint)
            {
                return CreateMultiPointFromVertexes(vertexs, useChecked);
            }

            if (geometryType == GeometryType.Polyline)
            {
                return CreatePolylineFromVertexes(vertexs, useChecked,usePart);
            }

            if (geometryType == GeometryType.Polygon)
            {
                return CreatePolygonFromVertexes(vertexs, useChecked, usePart);
            }
            return null;

        }

        public static IGeometry CreatePoint(double X, double Y)
        {
            GeometryFactory gf = new GeometryFactory();
            GeoAPI.Geometries.Coordinate coordinate=new GeoAPI.Geometries.Coordinate(X,Y);
            IPoint point=gf.CreatePoint(coordinate);
            IGeometry newGeometry = new Api.Concrete.Geometry(GeometryType.Point, ZValueType.None);
            newGeometry.ImportFromWkt(point.AsText());
            return newGeometry;
        }

        public static IGeometry CreateLine(double X1, double Y1, double X2, double Y2)
        {
            GeometryFactory gf = new GeometryFactory();
            List<GeoAPI.Geometries.Coordinate> coordinates = new List<GeoAPI.Geometries.Coordinate>();
            GeoAPI.Geometries.Coordinate coordinate = new GeoAPI.Geometries.Coordinate(X1, Y1);
            coordinates.Add(coordinate);
            coordinate = new GeoAPI.Geometries.Coordinate(X2, Y2);
            coordinates.Add(coordinate);
            ILineString line = gf.CreateLineString(coordinates.ToArray());
            IGeometry newGeometry = new Api.Concrete.Geometry(GeometryType.Polyline, ZValueType.None);
            newGeometry.ImportFromWkt(line.AsText());
            return newGeometry;
        }
        public static IGeometry CreatePolygonFromVertexes(List<ReVertex> vertexs, bool useChecked = true, bool usePart = true)
        {
            if (vertexs.Count < 3) return null;
            GeometryFactory gf = new GeometryFactory();
            GeoAPI.Geometries.IGeometry editGeometry = null;
            List<ReVertex> subVertexs = useChecked ? vertexs.Where(c => c.Checked == true).ToList() : vertexs;
            List<GeoAPI.Geometries.Coordinate> coordinates = new List<GeoAPI.Geometries.Coordinate>();
            if (usePart == false)
            {
                foreach (ReVertex vertex in subVertexs)
                {
                    coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                }
                editGeometry = gf.CreatePolygon(coordinates.ToArray());
            }
            else
            {
                long oldPartId = -1;
                int pntCount = 0;
                int partCount = 0;
                List<GeoAPI.Geometries.IGeometry> editGeometries = new List<GeoAPI.Geometries.IGeometry>();
                foreach (ReVertex vertex in subVertexs)
                {
                    if (vertex.Part != oldPartId)
                    {
                        if (pntCount > 2)
                        {
                            if (coordinates[0].Equals2D(coordinates[coordinates.Count - 1], 0.01) == false)
                            {
                                coordinates.Add((GeoAPI.Geometries.Coordinate)coordinates[0].Clone());
                            }
                            GeoAPI.Geometries.IGeometry subGeometry = gf.CreatePolygon(coordinates.ToArray());
                            editGeometries.Add(subGeometry);
                            coordinates.Clear();
                            pntCount = 0;
                            partCount++;
                        }
                        coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                        pntCount++;
                        oldPartId = vertex.Part;
                    }
                    else
                    {
                        coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                        pntCount++;
                        oldPartId = vertex.Part;
                    }
                }
                if (pntCount > 2)
                {
                    if (coordinates[0].Equals2D(coordinates[coordinates.Count - 1], 0.01) == false)
                    {
                        coordinates.Add((GeoAPI.Geometries.Coordinate)coordinates[0].Clone());
                    }
                    GeoAPI.Geometries.IGeometry subGeometry = gf.CreatePolygon(coordinates.ToArray());
                    editGeometries.Add(subGeometry);
                }
                if (editGeometries.Count == 1)
                {
                    editGeometry = editGeometries[0];
                }
                else
                {
                    editGeometry = gf.BuildGeometry(editGeometries);
                }

            }
            IGeometry newGeometry = new Api.Concrete.Geometry(GeometryType.Polygon, ZValueType.None);
            newGeometry.ImportFromWkt(editGeometry.AsText());
            return newGeometry;
        }
        public static IGeometry CreatePolylineFromVertexes(List<ReVertex> vertexs, bool useChecked = true, bool usePart = true)
        {
            GeometryFactory gf = new GeometryFactory();
            GeoAPI.Geometries.IGeometry editGeometry = null;
            List <ReVertex> subVertexs = useChecked ? vertexs.Where(c => c.Checked == true).ToList() : vertexs;
            List<GeoAPI.Geometries.Coordinate> coordinates = new List<GeoAPI.Geometries.Coordinate>();
            if (usePart == false)
            {
                foreach (ReVertex vertex in subVertexs)
                {
                    coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                }
                editGeometry = gf.CreateLineString(coordinates.ToArray());
            }
            else
            {
                long oldPartId = -1;
                int pntCount = 0;
                int partCount = 0;
                List <GeoAPI.Geometries.IGeometry> editGeometries=new List<GeoAPI.Geometries.IGeometry>();
                foreach (ReVertex vertex in subVertexs)
                {
                    if (vertex.Part != oldPartId)
                    {
                        if (pntCount > 1)
                        {
                            GeoAPI.Geometries.IGeometry subGeometry = gf.CreateLineString(coordinates.ToArray());
                            editGeometries.Add(subGeometry);
                            coordinates.Clear();
                            pntCount = 0;
                            partCount++;
                        }
                        coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                        pntCount++;
                        oldPartId = vertex.Part;
                    }
                    else
                    {
                        coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X, vertex.Y));
                        pntCount++;
                    }
                }
                if (pntCount > 1)
                {
                    GeoAPI.Geometries.IGeometry subGeometry = gf.CreateLineString(coordinates.ToArray());
                    editGeometries.Add(subGeometry);
                }
                if (editGeometries.Count == 0)
                {
                    editGeometry = editGeometries[0];
                }
                else
                {
                    editGeometry = gf.BuildGeometry(editGeometries);
                }

            }
            IGeometry newGeometry = new Api.Concrete.Geometry(GeometryType.Polyline, ZValueType.None);
            newGeometry.ImportFromWkt(editGeometry.AsText());
            return newGeometry;
        }
        public static IGeometry CreateMultiPointFromVertexes(List<ReVertex> vertexs, bool useChecked = true)
        {
            GeometryFactory gf = new GeometryFactory();
            List<ReVertex> subVertexs = useChecked ? vertexs.Where(c => c.Checked == true).ToList() : vertexs;
            List<GeoAPI.Geometries.Coordinate> coordinates=new List<GeoAPI.Geometries.Coordinate>();
            foreach (ReVertex vertex in subVertexs)
            {
                coordinates.Add(new GeoAPI.Geometries.Coordinate(vertex.X,vertex.Y));
            }
            GeoAPI.Geometries.IGeometry editGeometry =gf.CreateMultiPoint(coordinates.ToArray());
            IGeometry newGeometry=new Api.Concrete.Geometry(GeometryType.MultiPoint,ZValueType.None);
            newGeometry.ImportFromWkt(editGeometry.AsText());
            return newGeometry;

        }
        public static IGeometry CreateGeometryByDbGeometry(DbGeometry dbgeometry)
        {
            IGeometry geometry=null;
            switch (dbgeometry.SpatialTypeName)
            {
                case "MultiPolygon":
                case "Polygon":
                    {
                        geometry = new Api.Concrete.Geometry(GeometryType.Polygon, ZValueType.None);
                        geometry.ImportFromWkt(dbgeometry.AsText());
                        break;
                    }
                case "Point":
                    {
                        geometry = new Api.Concrete.Geometry(GeometryType.Point, ZValueType.None);
                        geometry.ImportFromWkt(dbgeometry.AsText());
                        break;
                    }
                case "MultiPoint":
                    {
                        geometry = new Api.Concrete.Geometry(GeometryType.MultiPoint, ZValueType.None);
                        geometry.ImportFromWkt(dbgeometry.AsText());
                        break;
                    }
                case "MultiLineString":
                case "LineString":
                    {
                        geometry = new Api.Concrete.Geometry(GeometryType.Polyline, ZValueType.None);
                        geometry.ImportFromWkt(dbgeometry.AsText());
                        break;
                    }
                case "GeometryCollection": break;
                default: break;
            }
            return geometry;
        }

        public static ICoordinate QueryLinePointByDistance(ReEdge edge, double distance, bool isForward = true)
        {
            double x1, y1, x2, y2, xx, yy;
            if (isForward == true)
            {
                x1 = edge.X1;
                y1 = edge.Y1;
                x2 = edge.X2;
                y2 = edge.Y2;
            }
            else
            {
                x2= edge.X1;
                y2 = edge.Y1;
                x1 = edge.X2;
                y1 = edge.Y2;
            }

            double lineDistance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (Math.Abs(lineDistance) < 0.001)
            {
                xx = 0;
                yy = 0;
                return null;
            }

            xx = x1 + (x2 - x1) * distance / lineDistance;
            yy = y1 + (y2 - y1) * distance / lineDistance;
            return new Coordinate(xx,yy);
        }
        public static bool QueryLinePointByDistance(
            double x1,
            double y1,
            double x2,
            double y2,
            double distance,
            out double xx,
            out double yy)
        {
            double lineDistance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (lineDistance == 0)
            {
                xx = 0;
                yy = 0;
                return false;
            }

            xx = x1 + (x2 - x1) * distance / lineDistance;
            yy = y1 + (y2 - y1) * distance / lineDistance;
            return true;
        }


        /// <summary> 
        /// A value that indicates an orientation of clockwise, or a right turn.
        /// </summary>
        public const int Clockwise = -1;
        /// <summary> 
        /// A value that indicates an orientation of clockwise, or a right turn.
        /// </summary>
        public const int Right = Clockwise;

        /// <summary>
        /// A value that indicates an orientation of counterclockwise, or a left turn.
        /// </summary>
        public const int CounterClockwise = 1;
        /// <summary>
        /// A value that indicates an orientation of counterclockwise, or a left turn.
        /// </summary>
        public const int Left = CounterClockwise;

        /// <summary>
        /// A value that indicates an orientation of collinear, or no turn (straight).
        /// </summary>
        public const int Collinear = 0;
        /// <summary>
        /// A value that indicates an orientation of collinear, or no turn (straight).
        /// </summary>
        public const int Straight = Collinear;


        /// <summary> 
        /// 计算从点到线的距离.
        /// Note: NON-ROBUST!
        /// </summary>
        /// <param name="p">The point to compute the distance for.</param>
        /// <param name="A">One point of the line.</param>
        /// <param name="B">Another point of the line (must be different to A).</param>
        /// <returns> The distance from p to line segment AB.</returns>
        public static double DistancePointLine(Point p, Point A, Point B)
        {
            // if start == end, then use pt distance
            if (A.Equals(B))
                return p.Distance(A);

            // otherwise use comp.graphics.algorithms Frequently Asked Questions method
            /*(1)     	      AC dot AB
                        r =   ---------
                              ||AB||^2

                        r has the following meaning:
                        r=0 Point = A
                        r=1 Point = B
                        r<0 Point is on the backward extension of AB
                        r>1 Point is on the forward extension of AB
                        0<r<1 Point is interior to AB
            */

            double r = ((p.X - A.X) * (B.X - A.X) + (p.Y - A.Y) * (B.Y - A.Y))
                       /
                       ((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));

            if (r <= 0.0) return p.Distance(A);
            if (r >= 1.0) return p.Distance(B);


            /*(2)
                            (Ay-Cy)(Bx-Ax)-(Ax-Cx)(By-Ay)
                        s = -----------------------------
                                        Curve^2
                        Then the distance from C to Point = |s|*Curve.
            */

            double s = ((A.Y - p.Y) * (B.X - A.X) - (A.X - p.X) * (B.Y - A.Y))
                       /
                       ((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));

            return Math.Abs(s) * Math.Sqrt(((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
        }

        /// <summary> 
        /// 计算点到线的垂线距离Computes the perpendicular distance from a point p
        /// to the (infinite) line containing the points AB
        /// </summary>
        /// <param name="p">The point to compute the distance for.</param>
        /// <param name="A">One point of the line.</param>
        /// <param name="B">Another point of the line (must be different to A).</param>
        /// <returns>The perpendicular distance from p to line AB.</returns>
        public static double DistancePointLinePerpendicular(Point p, Point A, Point B)
        {
            // use comp.graphics.algorithms Frequently Asked Questions method
            /*(2)
                            (Ay-Cy)(Bx-Ax)-(Ax-Cx)(By-Ay)
                        s = -----------------------------
                                         Curve^2
                        Then the distance from C to Point = |s|*Curve.
            */

            double s = ((A.Y - p.Y) * (B.X - A.X) - (A.X - p.X) * (B.Y - A.Y))
                       /
                       ((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));

            return Math.Abs(s) * Math.Sqrt(((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
        }


        /// <summary> 
        /// 计算线到线的距离.
        /// Note: NON-ROBUST!
        /// </summary>
        /// <param name="A">A point of one line.</param>
        /// <param name="B">The second point of the line (must be different to A).</param>
        /// <param name="C">One point of the line.</param>
        /// <param name="D">Another point of the line (must be different to A).</param>
        /// <returns>The distance from line segment AB to line segment CD.</returns>
        public static double DistanceLineLine(Point A, Point B, Point C, Point D)
        {
            // check for zero-length segments
            if (A.Equals(B))
                return DistancePointLine(A, C, D);
            if (C.Equals(D))
                return DistancePointLine(D, A, B);

            // AB and CD are line segments
            /* from comp.graphics.algo
                Solving the above for r and s yields
                            (Ay-Cy)(Dx-Cx)-(Ax-Cx)(Dy-Cy)
                        r = ----------------------------- (eqn 1)
                            (Bx-Ax)(Dy-Cy)-(By-Ay)(Dx-Cx)
                            (Ay-Cy)(Bx-Ax)-(Ax-Cx)(By-Ay)
                        s = ----------------------------- (eqn 2)
                            (Bx-Ax)(Dy-Cy)-(By-Ay)(Dx-Cx)
                Let Point be the position vector of the intersection point, then
                    Point=A+r(B-A) or
                    Px=Ax+r(Bx-Ax)
                    Py=Ay+r(By-Ay)
                By examining the values of r & s, you can also determine some other
                limiting conditions:
                    If 0<=r<=1 & 0<=s<=1, intersection exists
                    r<0 or r>1 or s<0 or s>1 line segments do not intersect
                    If the denominator in eqn 1 is zero, AB & CD are parallel
                    If the numerator in eqn 1 is also zero, AB & CD are collinear.
            */
            double r_top = (A.Y - C.Y) * (D.X - C.X) - (A.X - C.X) * (D.Y - C.Y);
            double r_bot = (B.X - A.X) * (D.Y - C.Y) - (B.Y - A.Y) * (D.X - C.X);

            double s_top = (A.Y - C.Y) * (B.X - A.X) - (A.X - C.X) * (B.Y - A.Y);
            double s_bot = (B.X - A.X) * (D.Y - C.Y) - (B.Y - A.Y) * (D.X - C.X);

            if ((r_bot == 0) || (s_bot == 0))
                return Math.Min(DistancePointLine(A, C, D),
                    Math.Min(DistancePointLine(B, C, D),
                        Math.Min(DistancePointLine(C, A, B),
                            DistancePointLine(D, A, B))));


            double s = s_top / s_bot;
            double r = r_top / r_bot;

            if ((r < 0) || (r > 1) || (s < 0) || (s > 1))
                //no intersection
                return Math.Min(DistancePointLine(A, C, D),
                    Math.Min(DistancePointLine(B, C, D),
                        Math.Min(DistancePointLine(C, A, B),
                            DistancePointLine(D, A, B))));

            return 0.0; //intersection exists
        }

        /// <summary>
        /// Returns the signed area for a ring.  The area is positive ifthe ring is oriented CW.
        /// </summary>
        /// <param name="ring"></param>
        /// <returns></returns>
        public static double SignedArea(Point[] ring)
        {
            if (ring.Length < 3)
                return 0.0;

            double sum = 0.0;
            for (int i = 0; i < ring.Length - 1; i++)
            {
                double bx = ring[i].X;
                double by = ring[i].Y;
                double cx = ring[i + 1].X;
                double cy = ring[i + 1].Y;
                sum += (bx + cx) * (cy - by);
            }
            return -sum / 2.0;
        }

        /// <summary> 
        /// Computes the length of a linestring specified by a sequence of points.
        /// </summary>
        /// <param name="pts">The points specifying the linestring.</param>
        /// <returns>The length of the linestring.</returns>
        public static double Length(IList<Point> pts)
        {
            if (pts.Count < 1)
                return 0.0;

            double sum = 0.0;
            for (int i = 1; i < pts.Count; i++)
                sum += pts[i].Distance(pts[i - 1]);

            return sum;
        }
    }
}
