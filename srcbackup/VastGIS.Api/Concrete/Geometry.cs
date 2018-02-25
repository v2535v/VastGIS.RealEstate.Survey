﻿using System.Collections.Generic;
using MapWinGIS;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Concrete
{
    public class Geometry : IGeometry
    {
        private GeometryPartCollection _parts;
        private CoordinateList _points;
        private Shape _shape;
        private readonly int _partIndex;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry"/> class.
        /// </summary>
        /// <param name="type">The geometry type.</param>
        /// <param name="zValue">The z value.</param>
        public Geometry(GeometryType type, ZValueType zValue = ZValueType.None)
        {
            _shape = new Shape();
            var shpType = GeometryHelper.GeometryType2ShpType(type, zValue);
            _shape.Create(shpType);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry"/> class from shape.
        /// </summary>
        /// <param name="shape">The shape.</param>
        internal Geometry(Shape shape)
        {
            _shape = shape;
            _partIndex = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry"/> class from specified part of shape.
        /// </summary>
        internal Geometry(Shape shape, int partIndex)
        {
            _shape = shape;
            _partIndex = partIndex;
        }

        #endregion

        /// <summary>
        /// Gets parts of the geometry.
        /// </summary>
        public GeometryPartCollection Parts
        {
            get
            {
                _parts = _parts ?? new GeometryPartCollection(_shape);
                return _parts;
            }
        }

        /// <summary>
        /// Gets the center of geometry (intersection of envelope's diagonales).
        /// </summary>
        public Coordinate Center
        {
            get
            {
                var pnt = _shape.Center;
                return new Coordinate(pnt.x, pnt.y);
            }
        }

        /// <summary>
        /// Gets the centroid of geometry.
        /// </summary>
        public Coordinate Centroid
        {
            get
            {
                var pnt = _shape.Centroid;
                return new Coordinate(pnt.x, pnt.y);
            }
        }

        /// <summary>
        /// Gets the interior point of geometry.
        /// </summary>
        public Coordinate InteriorPoint
        {
            get
            {
                var pnt = _shape.InteriorPoint;
                return new Coordinate(pnt.x, pnt.y);
            }
        }

        public IEnvelope Extents
        {
            get { return new Envelope(_shape.Extents); }
        }

        public bool IsEmpty
        {
            get { return _shape.IsEmpty; }
        }

        public bool IsValid
        {
            get { return _shape.IsValid; }
        }

        public string IsValidReason
        {
            get { return _shape.IsValidReason; }
        }

        public double Length
        {
            get { return _shape.Length; }
        }

        public double Perimeter
        {
            get { return _shape.Perimeter; }
        }

        public double Area
        {
            get { return _shape.Area; }
        }

        public IGeometry Boundary()
        {
            return new Geometry(_shape.Boundary());
        }

        public IGeometry Buffer(double distance, int numSegments)
        {
            return new Geometry(_shape.Buffer(distance, numSegments));
        }

        public IGeometry BufferWithParams(double distance, int numSegments = 30, bool singleSided = false, 
            BufferCap capStyle = BufferCap.Round,
            BufferJoin joinStyle = BufferJoin.Round, double mitreLimit = 5)
        {
            return new Geometry(_shape.BufferWithParams(distance, numSegments, singleSided,
                (tkBufferCap)capStyle, (tkBufferJoin)joinStyle, mitreLimit));
        }

        public IGeometry Clip(IGeometry g, ClipOperation operation)
        {
            return new Geometry(_shape.Clip(g.GetInternal(), (tkClipOperation)operation));
        }

        public IGeometry Clone()
        {
            return new Geometry(_shape.Clone());
        }

        public void AddPart(int partIndex, IGeometry part)
        {
            //获取当前所有分段总数
            int i = _shape.NumParts;
            int pntCount = _shape.numPoints;
            _shape.InsertPart(pntCount, ref i);

            for (int j = 0; j < part.Points.Count; j++)
            {
                _shape.AddPoint(part.Points[j].X, part.Points[j].Y);
            }
            
        }

        /// <summary>
        /// Clones points and parts but allows to set different geometry type.
        /// The method doesn't check if the result geometry is valid.
        /// </summary>
        public IGeometry Clone(GeometryType type, ZValueType zValue = ZValueType.None)
        {
            var shapeType = GeometryHelper.GeometryType2ShpType(type, zValue);
            var shp = new Shape();
            shp.Create(shapeType);

            for (int i = 0; i < _shape.NumParts; i++)
            {
                int pointIndex = _shape.Part[i];
                shp.InsertPart(i, ref pointIndex);
            }

            var g = new Geometry(shp);
            foreach (var pnt in Points)
            {
                g.Points.Add(pnt.Clone());
            }

            return g;
        }

        public IGeometry ClosestPoints(IGeometry g)
        {
            return new Geometry(_shape.ClosestPoints(g.GetInternal()));
        }

        public bool Contains(IGeometry g)
        {
            return _shape.Contains(g.GetInternal());
        }

        public IGeometry ConvexHull()
        {
            return new Geometry(_shape.ConvexHull());
        }

        public bool CopyFrom(IGeometry g)
        {
            return _shape.CopyFrom(g.GetInternal());
        }

        public bool Crosses(IGeometry g)
        {
            return _shape.Crosses(g.GetInternal());
        }

        public bool Disjoint(IGeometry g)
        {
            return _shape.Disjoint(g.GetInternal());
        }

        public double Distance(IGeometry g)
        {
            return _shape.Distance(g.GetInternal());
        }
        
        public IEnumerable<IGeometry> Explode()
        {
            object o = null;
            if (_shape.Explode(ref o))
            {
                var shapes = o as object[];
                if (shapes != null)
                {
                    foreach (var shp in shapes)
                    {
                        yield return new Geometry(shp as Shape);
                    }
                }
            }
        }

        public byte[] ExportToBinary()
        {
            object o = null;
            return _shape.ExportToBinary(ref o) ? o as byte[] : null;
        }

        public string ExportToWkt()
        {
            return _shape.ExportToWKT();
        }

        public IGeometry FixUp()
        {
            Shape shape;
            _shape.FixUp(out shape);
            return shape != null ? new Geometry(shape) : null;
        }

        public IEnumerable<IGeometry> Intersection(IGeometry g)
        {
            object o = null;
            if (_shape.GetIntersection(g.GetInternal(), ref o))
            {
                var shapes = o as Shape[];
                if (shapes != null)
                {
                    foreach (var shp in shapes)
                    {
                        yield return new Geometry(shp);
                    }
                }
            }
        }

        public bool ImportFromBinary(byte[] bytes)
        {
            return _shape.ImportFromBinary(bytes);
        }

        public bool ImportFromWkt(string serialized)
        {
            return _shape.ImportFromWKT(serialized);
        }

        public bool Intersects(IGeometry g)
        {
            return _shape.Intersects(g.GetInternal());
        }

        public void Move(double offsetX, double offsetY)
        {
            _shape.Move(offsetX, offsetY);
        }

        /// <summary>
        /// Moves the point.
        /// </summary>
        /// <param name="pointIndex">Index of the point.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool MovePoint(int pointIndex, double x, double y)
        {
            return _shape.put_XY(pointIndex, x, y);
        }

        /// <summary>
        /// Sets the M-value.
        /// </summary>
        /// <param name="pointIndex">Index of the point.</param>
        /// <param name="m">The m.</param>
        /// <returns>True on success</returns>
        public bool SetM(int pointIndex, double m)
        {
            return _shape.put_M(pointIndex, m);
        }

        /// <summary>
        /// Sets the Z-value.
        /// </summary>
        /// <param name="pointIndex">Index of the point.</param>
        /// <param name="z">The z.</param>
        /// <returns>True on success</returns>
        public bool SetZ(int pointIndex, double z)
        {
            return _shape.put_Z(pointIndex, z);
        }

        public bool Overlaps(IGeometry g)
        {
            return _shape.Overlaps(g.GetInternal());
        }

        public bool PointInThisPoly(ICoordinate pt)
        {
            return _shape.PointInThisPoly(pt.GetInternal());
        }

        public bool Relates(IGeometry g, SpatialRelation relation)
        {
            return _shape.Relates(g.GetInternal(), (tkSpatialRelation)relation);
        }

        /// <summary>
        /// Rotates the geometry.
        /// </summary>
        /// <param name="originX">The origin x.</param>
        /// <param name="originY">The origin y.</param>
        /// <param name="angle">The angle, in degrees</param>
        public void Rotate(double originX, double originY, double angle)
        {
            _shape.Rotate(originX, originY, angle);
        }

        public IEnumerable<IGeometry> SplitByPolyline(IGeometry polyline)
        {
            object o = null;
            if (_shape.SplitByPolyline(polyline.GetInternal(), ref o))
            {
                var shapes = o as Shape[];
                if (shapes != null)
                {
                    foreach (var shp in shapes)
                    {
                        yield return new Geometry(shp);
                    }
                }
            }
        }

        public bool PartIsClockWise(int partIndex)
        {
            return _shape.PartIsClockWise[partIndex];
        }

        public bool PartReserveOrder(int partIndex)
        {
            return _shape.ReversePointsOrder(partIndex);
        }

        public bool Touches(IGeometry g)
        {
            return _shape.Touches(g.GetInternal());
        }

        public bool Within(IGeometry g)
        {
            return _shape.Within(g.GetInternal());
        }

        /// <summary>
        /// Gets the type of Z component for the current shape.
        /// </summary>
        public ZValueType ZValueType
        {
            get { return GeometryHelper.ShapeType2ZValueType(_shape.ShapeType); }
        }

        #region IGeometry Members        

        /// <summary>
        /// Gets list of coodinates.
        /// </summary>
        public CoordinateList Points
        {
            get
            {
                _points = _points ?? new CoordinateList(_shape, _partIndex);
                return _points;
            }
        }

        /// <summary>
        /// Gets the type of the geometry.
        /// </summary>
        public GeometryType GeometryType
        {
            get { return GeometryHelper.ShapeType2GeometryType(_shape.ShapeType); }
        }

        /// <summary>
        /// Releases inner shape reference.
        /// </summary>
        public void Dispose()
        {
            _shape = null;
        }

        #endregion

        public object InternalObject
        {
            get {  return _shape; }
        }

        public string LastError
        {
            get { return _shape.ErrorMsg[_shape.LastErrorCode]; }
        }

        public string Tag
        {
            get { return _shape.Key; }
            set { _shape.Key = value; }
        }

        public bool GetPoint(int index, out double x, out double y)
        {
            x = 0.0;
            y = 0.0;

            return _shape.XY[index, x, y];
        }
    }
}

