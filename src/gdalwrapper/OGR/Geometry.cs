namespace OSGeo.OGR
{
    using OSGeo.OSR;
    using System;
    using System.Runtime.InteropServices;

    public class Geometry : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Geometry(wkbGeometryType type) : this(OgrPINVOKE.new_Geometry((int) type, null, 0, IntPtr.Zero, null), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Geometry(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public Geometry(wkbGeometryType type, string wkt, int wkb, IntPtr wkb_buf, string gml) : this(OgrPINVOKE.new_Geometry((int) type, wkt, wkb, wkb_buf, gml), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int AddGeometry(Geometry other)
        {
            int num = OgrPINVOKE.Geometry_AddGeometry(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int AddGeometryDirectly(Geometry other_disown)
        {
            int num = OgrPINVOKE.Geometry_AddGeometryDirectly(this.swigCPtr, getCPtrAndDisown(other_disown, this.ThisOwn_false()));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void AddPoint(double x, double y, double z)
        {
            OgrPINVOKE.Geometry_AddPoint(this.swigCPtr, x, y, z);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void AddPoint_2D(double x, double y)
        {
            OgrPINVOKE.Geometry_AddPoint_2D(this.swigCPtr, x, y);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void AddPointM(double x, double y, double m)
        {
            OgrPINVOKE.Geometry_AddPointM(this.swigCPtr, x, y, m);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void AddPointZM(double x, double y, double z, double m)
        {
            OgrPINVOKE.Geometry_AddPointZM(this.swigCPtr, x, y, z, m);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public double Area()
        {
            double num = OgrPINVOKE.Geometry_Area(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void AssignSpatialReference(SpatialReference reference)
        {
            OgrPINVOKE.Geometry_AssignSpatialReference(this.swigCPtr, SpatialReference.getCPtr(reference));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Geometry Boundary()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Boundary(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry Buffer(double distance, int quadsecs)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Buffer(this.swigCPtr, distance, quadsecs);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry Centroid()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Centroid(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry Clone()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Clone(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public void CloseRings()
        {
            OgrPINVOKE.Geometry_CloseRings(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public bool Contains(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Contains(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public Geometry ConvexHull()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_ConvexHull(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public int CoordinateDimension()
        {
            int num = OgrPINVOKE.Geometry_CoordinateDimension(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Geometry CreateFromGML(string gml)
        {
            return new Geometry(wkbGeometryType.wkbUnknown, null, 0, IntPtr.Zero, gml);
        }

        public static Geometry CreateFromWkb(byte[] wkb)
        {
            Geometry geometry;
            if (wkb.Length == 0)
            {
                throw new ArgumentException("Buffer size is small (CreateFromWkb)");
            }
            IntPtr destination = Marshal.AllocHGlobal((int) (wkb.Length * Marshal.SizeOf(wkb[0])));
            try
            {
                Marshal.Copy(wkb, 0, destination, wkb.Length);
                geometry = new Geometry(wkbGeometryType.wkbUnknown, null, wkb.Length, destination, null);
            }
            finally
            {
                Marshal.FreeHGlobal(destination);
            }
            return geometry;
        }

        public static Geometry CreateFromWkt(string wkt)
        {
            return new Geometry(wkbGeometryType.wkbUnknown, wkt, 0, IntPtr.Zero, null);
        }

        public bool Crosses(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Crosses(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public Geometry DelaunayTriangulation(double dfTolerance, int bOnlyEdges)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_DelaunayTriangulation(this.swigCPtr, dfTolerance, bOnlyEdges);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry Difference(Geometry other)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Difference(this.swigCPtr, getCPtr(other));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public bool Disjoint(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Disjoint(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    OgrPINVOKE.delete_Geometry(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public double Distance(Geometry other)
        {
            double num = OgrPINVOKE.Geometry_Distance(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double Distance3D(Geometry other)
        {
            double num = OgrPINVOKE.Geometry_Distance3D(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void Empty()
        {
            OgrPINVOKE.Geometry_Empty(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public bool Equal(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Equal(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool Equals(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Equals(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public string ExportToGML()
        {
            string str = OgrPINVOKE.Geometry_ExportToGML__SWIG_0(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string ExportToGML(string[] options)
        {
            string str = OgrPINVOKE.Geometry_ExportToGML__SWIG_1(this.swigCPtr, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int ExportToIsoWkt(out string argout)
        {
            int num = OgrPINVOKE.Geometry_ExportToIsoWkt(this.swigCPtr, out argout);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string ExportToJson(string[] options)
        {
            string str = OgrPINVOKE.Geometry_ExportToJson(this.swigCPtr, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string ExportToKML(string altitude_mode)
        {
            string str = OgrPINVOKE.Geometry_ExportToKML(this.swigCPtr, altitude_mode);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int ExportToWkb(byte[] buffer)
        {
            return this.ExportToWkb(buffer, wkbByteOrder.wkbXDR);
        }

        public int ExportToWkb(byte[] buffer, wkbByteOrder byte_order)
        {
            int num;
            int bufLen = this.WkbSize();
            if (buffer.Length < bufLen)
            {
                throw new ArgumentException("Buffer size is small (ExportToWkb)");
            }
            IntPtr ptr = Marshal.AllocHGlobal((int) (bufLen * Marshal.SizeOf(buffer[0])));
            try
            {
                num = this.ExportToWkb(bufLen, ptr, byte_order);
                Marshal.Copy(ptr, buffer, 0, bufLen);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
            GC.KeepAlive(this);
            return num;
        }

        public int ExportToWkb(int bufLen, IntPtr buffer, wkbByteOrder byte_order)
        {
            int num = OgrPINVOKE.Geometry_ExportToWkb(this.swigCPtr, bufLen, buffer, (int) byte_order);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToWkt(out string argout)
        {
            int num = OgrPINVOKE.Geometry_ExportToWkt(this.swigCPtr, out argout);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        ~Geometry()
        {
            this.Dispose();
        }

        public void FlattenTo2D()
        {
            OgrPINVOKE.Geometry_FlattenTo2D(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public double GetArea()
        {
            double num = OgrPINVOKE.Geometry_GetArea(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Geometry GetBoundary()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_GetBoundary(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public int GetCoordinateDimension()
        {
            int num = OgrPINVOKE.Geometry_GetCoordinateDimension(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static HandleRef getCPtr(Geometry obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Geometry obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Geometry obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public Geometry GetCurveGeometry(string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_GetCurveGeometry(this.swigCPtr, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public int GetDimension()
        {
            int num = OgrPINVOKE.Geometry_GetDimension(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetEnvelope(Envelope env)
        {
            OgrPINVOKE.Geometry_GetEnvelope(this.swigCPtr, Envelope.getCPtr(env));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetEnvelope3D(Envelope3D env)
        {
            OgrPINVOKE.Geometry_GetEnvelope3D(this.swigCPtr, Envelope3D.getCPtr(env));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int GetGeometryCount()
        {
            int num = OgrPINVOKE.Geometry_GetGeometryCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetGeometryName()
        {
            string str = OgrPINVOKE.Geometry_GetGeometryName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public Geometry GetGeometryRef(int geom)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_GetGeometryRef(this.swigCPtr, geom);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public wkbGeometryType GetGeometryType()
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.Geometry_GetGeometryType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public Geometry GetLinearGeometry(double dfMaxAngleStepSizeDegrees, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_GetLinearGeometry(this.swigCPtr, dfMaxAngleStepSizeDegrees, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public double GetM(int point)
        {
            double num = OgrPINVOKE.Geometry_GetM(this.swigCPtr, point);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetPoint(int iPoint, double[] argout)
        {
            OgrPINVOKE.Geometry_GetPoint(this.swigCPtr, iPoint, argout);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetPoint_2D(int iPoint, double[] argout)
        {
            OgrPINVOKE.Geometry_GetPoint_2D(this.swigCPtr, iPoint, argout);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int GetPointCount()
        {
            int num = OgrPINVOKE.Geometry_GetPointCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetPointZM(int iPoint, double[] argout)
        {
            OgrPINVOKE.Geometry_GetPointZM(this.swigCPtr, iPoint, argout);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public SpatialReference GetSpatialReference()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_GetSpatialReference(this.swigCPtr);
            SpatialReference reference = (cPtr == IntPtr.Zero) ? null : new SpatialReference(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return reference;
        }

        public double GetX(int point)
        {
            double num = OgrPINVOKE.Geometry_GetX(this.swigCPtr, point);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetY(int point)
        {
            double num = OgrPINVOKE.Geometry_GetY(this.swigCPtr, point);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetZ(int point)
        {
            double num = OgrPINVOKE.Geometry_GetZ(this.swigCPtr, point);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int HasCurveGeometry(int bLookForCircular)
        {
            int num = OgrPINVOKE.Geometry_HasCurveGeometry(this.swigCPtr, bLookForCircular);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool Intersect(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Intersect(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public Geometry Intersection(Geometry other)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Intersection(this.swigCPtr, getCPtr(other));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public bool Intersects(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Intersects(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public int Is3D()
        {
            int num = OgrPINVOKE.Geometry_Is3D(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool IsEmpty()
        {
            bool flag = OgrPINVOKE.Geometry_IsEmpty(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public int IsMeasured()
        {
            int num = OgrPINVOKE.Geometry_IsMeasured(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool IsRing()
        {
            bool flag = OgrPINVOKE.Geometry_IsRing(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsSimple()
        {
            bool flag = OgrPINVOKE.Geometry_IsSimple(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsValid()
        {
            bool flag = OgrPINVOKE.Geometry_IsValid(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public double Length()
        {
            double num = OgrPINVOKE.Geometry_Length(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool Overlaps(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Overlaps(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public Geometry PointOnSurface()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_PointOnSurface(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public void Segmentize(double dfMaxLength)
        {
            OgrPINVOKE.Geometry_Segmentize(this.swigCPtr, dfMaxLength);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void Set3D(int b3D)
        {
            OgrPINVOKE.Geometry_Set3D(this.swigCPtr, b3D);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetCoordinateDimension(int dimension)
        {
            OgrPINVOKE.Geometry_SetCoordinateDimension(this.swigCPtr, dimension);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetMeasured(int bMeasured)
        {
            OgrPINVOKE.Geometry_SetMeasured(this.swigCPtr, bMeasured);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetPoint(int point, double x, double y, double z)
        {
            OgrPINVOKE.Geometry_SetPoint(this.swigCPtr, point, x, y, z);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetPoint_2D(int point, double x, double y)
        {
            OgrPINVOKE.Geometry_SetPoint_2D(this.swigCPtr, point, x, y);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetPointM(int point, double x, double y, double m)
        {
            OgrPINVOKE.Geometry_SetPointM(this.swigCPtr, point, x, y, m);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetPointZM(int point, double x, double y, double z, double m)
        {
            OgrPINVOKE.Geometry_SetPointZM(this.swigCPtr, point, x, y, z, m);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Geometry Simplify(double tolerance)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Simplify(this.swigCPtr, tolerance);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry SimplifyPreserveTopology(double tolerance)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_SimplifyPreserveTopology(this.swigCPtr, tolerance);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry SymDifference(Geometry other)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_SymDifference(this.swigCPtr, getCPtr(other));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry SymmetricDifference(Geometry other)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_SymmetricDifference(this.swigCPtr, getCPtr(other));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public bool Touches(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Touches(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public int Transform(CoordinateTransformation trans)
        {
            int num = OgrPINVOKE.Geometry_Transform(this.swigCPtr, CoordinateTransformation.getCPtr(trans));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int TransformTo(SpatialReference reference)
        {
            int num = OgrPINVOKE.Geometry_TransformTo(this.swigCPtr, SpatialReference.getCPtr(reference));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Geometry Union(Geometry other)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Union(this.swigCPtr, getCPtr(other));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry UnionCascaded()
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_UnionCascaded(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry Value(double dfDistance)
        {
            IntPtr cPtr = OgrPINVOKE.Geometry_Value(this.swigCPtr, dfDistance);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public bool Within(Geometry other)
        {
            bool flag = OgrPINVOKE.Geometry_Within(this.swigCPtr, getCPtr(other));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public int WkbSize()
        {
            int num = OgrPINVOKE.Geometry_WkbSize(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }
    }
}

