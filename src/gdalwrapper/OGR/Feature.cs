namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class Feature : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Feature(FeatureDefn feature_def) : this(OgrPINVOKE.new_Feature(FeatureDefn.getCPtr(feature_def)), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Feature(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public Feature Clone()
        {
            IntPtr cPtr = OgrPINVOKE.Feature_Clone(this.swigCPtr);
            Feature feature = (cPtr == IntPtr.Zero) ? null : new Feature(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return feature;
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    OgrPINVOKE.delete_Feature(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public void DumpReadable()
        {
            OgrPINVOKE.Feature_DumpReadable(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public bool Equal(Feature feature)
        {
            bool flag = OgrPINVOKE.Feature_Equal(this.swigCPtr, getCPtr(feature));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public void FillUnsetWithDefault(int bNotNullableOnly, string[] options)
        {
            OgrPINVOKE.Feature_FillUnsetWithDefault(this.swigCPtr, bNotNullableOnly, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        ~Feature()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(Feature obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Feature obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Feature obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public FeatureDefn GetDefnRef()
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetDefnRef(this.swigCPtr);
            FeatureDefn defn = (cPtr == IntPtr.Zero) ? null : new FeatureDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public long GetFID()
        {
            long num = OgrPINVOKE.Feature_GetFID(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetFieldAsDateTime(int id, out int pnYear, out int pnMonth, out int pnDay, out int pnHour, out int pnMinute, out float pfSecond, out int pnTZFlag)
        {
            OgrPINVOKE.Feature_GetFieldAsDateTime__SWIG_0(this.swigCPtr, id, out pnYear, out pnMonth, out pnDay, out pnHour, out pnMinute, out pfSecond, out pnTZFlag);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetFieldAsDateTime(string field_name, out int pnYear, out int pnMonth, out int pnDay, out int pnHour, out int pnMinute, out float pfSecond, out int pnTZFlag)
        {
            OgrPINVOKE.Feature_GetFieldAsDateTime__SWIG_1(this.swigCPtr, field_name, out pnYear, out pnMonth, out pnDay, out pnHour, out pnMinute, out pfSecond, out pnTZFlag);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public double GetFieldAsDouble(int id)
        {
            double num = OgrPINVOKE.Feature_GetFieldAsDouble__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetFieldAsDouble(string field_name)
        {
            double num = OgrPINVOKE.Feature_GetFieldAsDouble__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double[] GetFieldAsDoubleList(int id, out int count)
        {
            IntPtr source = OgrPINVOKE.Feature_GetFieldAsDoubleList(this.swigCPtr, id, out count);
            double[] destination = new double[count];
            if (count > 0)
            {
                Marshal.Copy(source, destination, 0, count);
            }
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return destination;
        }

        public int GetFieldAsInteger(int id)
        {
            int num = OgrPINVOKE.Feature_GetFieldAsInteger__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetFieldAsInteger(string field_name)
        {
            int num = OgrPINVOKE.Feature_GetFieldAsInteger__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public long GetFieldAsInteger64(int id)
        {
            long num = OgrPINVOKE.Feature_GetFieldAsInteger64__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public long GetFieldAsInteger64(string field_name)
        {
            long num = OgrPINVOKE.Feature_GetFieldAsInteger64__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int[] GetFieldAsIntegerList(int id, out int count)
        {
            IntPtr source = OgrPINVOKE.Feature_GetFieldAsIntegerList(this.swigCPtr, id, out count);
            int[] destination = new int[count];
            if (count > 0)
            {
                Marshal.Copy(source, destination, 0, count);
            }
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return destination;
        }

        public string GetFieldAsString(int id)
        {
            string str = Ogr.Utf8BytesToString(OgrPINVOKE.Feature_GetFieldAsString__SWIG_0(this.swigCPtr, id));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetFieldAsString(string field_name)
        {
            string str = Ogr.Utf8BytesToString(OgrPINVOKE.Feature_GetFieldAsString__SWIG_1(this.swigCPtr, field_name));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string[] GetFieldAsStringList(int id)
        {
            IntPtr ptr = OgrPINVOKE.Feature_GetFieldAsStringList(this.swigCPtr, id);
            int num = 0;
            if (ptr != IntPtr.Zero)
            {
                while (Marshal.ReadIntPtr(ptr, num * IntPtr.Size) != IntPtr.Zero)
                {
                    num++;
                }
            }
            string[] strArray = new string[num];
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    IntPtr ptr2 = Marshal.ReadIntPtr(ptr, i * Marshal.SizeOf(typeof(IntPtr)));
                    strArray[i] = (ptr2 == IntPtr.Zero) ? null : Marshal.PtrToStringAnsi(ptr2);
                }
            }
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return strArray;
        }

        public int GetFieldCount()
        {
            int num = OgrPINVOKE.Feature_GetFieldCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public FieldDefn GetFieldDefnRef(int id)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetFieldDefnRef__SWIG_0(this.swigCPtr, id);
            FieldDefn defn = (cPtr == IntPtr.Zero) ? null : new FieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public FieldDefn GetFieldDefnRef(string field_name)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetFieldDefnRef__SWIG_1(this.swigCPtr, field_name);
            FieldDefn defn = (cPtr == IntPtr.Zero) ? null : new FieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public int GetFieldIndex(string field_name)
        {
            int num = OgrPINVOKE.Feature_GetFieldIndex(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public FieldType GetFieldType(int id)
        {
            FieldType type = (FieldType) OgrPINVOKE.Feature_GetFieldType__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public FieldType GetFieldType(string field_name)
        {
            FieldType type = (FieldType) OgrPINVOKE.Feature_GetFieldType__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public Geometry GetGeometryRef()
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetGeometryRef(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public int GetGeomFieldCount()
        {
            int num = OgrPINVOKE.Feature_GetGeomFieldCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public GeomFieldDefn GetGeomFieldDefnRef(int id)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetGeomFieldDefnRef__SWIG_0(this.swigCPtr, id);
            GeomFieldDefn defn = (cPtr == IntPtr.Zero) ? null : new GeomFieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public GeomFieldDefn GetGeomFieldDefnRef(string field_name)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetGeomFieldDefnRef__SWIG_1(this.swigCPtr, field_name);
            GeomFieldDefn defn = (cPtr == IntPtr.Zero) ? null : new GeomFieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public int GetGeomFieldIndex(string field_name)
        {
            int num = OgrPINVOKE.Feature_GetGeomFieldIndex(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Geometry GetGeomFieldRef(int iField)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetGeomFieldRef__SWIG_0(this.swigCPtr, iField);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public Geometry GetGeomFieldRef(string field_name)
        {
            IntPtr cPtr = OgrPINVOKE.Feature_GetGeomFieldRef__SWIG_1(this.swigCPtr, field_name);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public string GetNativeData()
        {
            string str = OgrPINVOKE.Feature_GetNativeData(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetNativeMediaType()
        {
            string str = OgrPINVOKE.Feature_GetNativeMediaType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetStyleString()
        {
            string str = OgrPINVOKE.Feature_GetStyleString(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public bool IsFieldNull(int id)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldNull__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsFieldNull(string field_name)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldNull__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsFieldSet(int id)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldSet__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsFieldSet(string field_name)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldSet__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsFieldSetAndNotNull(int id)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldSetAndNotNull__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public bool IsFieldSetAndNotNull(string field_name)
        {
            bool flag = OgrPINVOKE.Feature_IsFieldSetAndNotNull__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public int SetFID(long fid)
        {
            int num = OgrPINVOKE.Feature_SetFID(this.swigCPtr, fid);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetField(int id, double value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_4(this.swigCPtr, id, value);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(int id, int value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_2(this.swigCPtr, id, value);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(int id, string value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_0(this.swigCPtr, id, Ogr.StringToUtf8Bytes(value));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(string field_name, double value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_5(this.swigCPtr, field_name, value);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(string field_name, int value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_3(this.swigCPtr, field_name, value);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(string field_name, string value)
        {
            OgrPINVOKE.Feature_SetField__SWIG_1(this.swigCPtr, field_name, Ogr.StringToUtf8Bytes(value));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(int id, int year, int month, int day, int hour, int minute, float second, int tzflag)
        {
            OgrPINVOKE.Feature_SetField__SWIG_6(this.swigCPtr, id, year, month, day, hour, minute, second, tzflag);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetField(string field_name, int year, int month, int day, int hour, int minute, float second, int tzflag)
        {
            OgrPINVOKE.Feature_SetField__SWIG_7(this.swigCPtr, field_name, year, month, day, hour, minute, second, tzflag);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldBinaryFromHexString(int id, string pszValue)
        {
            OgrPINVOKE.Feature_SetFieldBinaryFromHexString__SWIG_0(this.swigCPtr, id, pszValue);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldBinaryFromHexString(string field_name, string pszValue)
        {
            OgrPINVOKE.Feature_SetFieldBinaryFromHexString__SWIG_1(this.swigCPtr, field_name, pszValue);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldDoubleList(int id, int nList, double[] pList)
        {
            OgrPINVOKE.Feature_SetFieldDoubleList(this.swigCPtr, id, nList, pList);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldInteger64(int id, long value)
        {
            OgrPINVOKE.Feature_SetFieldInteger64(this.swigCPtr, id, value);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldIntegerList(int id, int nList, int[] pList)
        {
            OgrPINVOKE.Feature_SetFieldIntegerList(this.swigCPtr, id, nList, pList);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldNull(int id)
        {
            OgrPINVOKE.Feature_SetFieldNull__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldNull(string field_name)
        {
            OgrPINVOKE.Feature_SetFieldNull__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetFieldStringList(int id, string[] pList)
        {
            OgrPINVOKE.Feature_SetFieldStringList(this.swigCPtr, id, (pList != null) ? new OgrPINVOKE.StringListMarshal(pList)._ar : null);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int SetFrom(Feature other, int forgiving)
        {
            int num = OgrPINVOKE.Feature_SetFrom(this.swigCPtr, getCPtr(other), forgiving);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetFromWithMap(Feature other, int forgiving, int nList, int[] pList)
        {
            int num = OgrPINVOKE.Feature_SetFromWithMap(this.swigCPtr, getCPtr(other), forgiving, nList, pList);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeometry(Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeometry(this.swigCPtr, Geometry.getCPtr(geom));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeometryDirectly(Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeometryDirectly(this.swigCPtr, Geometry.getCPtrAndDisown(geom, this.ThisOwn_false()));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeomField(int iField, Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeomField__SWIG_0(this.swigCPtr, iField, Geometry.getCPtr(geom));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeomField(string field_name, Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeomField__SWIG_1(this.swigCPtr, field_name, Geometry.getCPtr(geom));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeomFieldDirectly(int iField, Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeomFieldDirectly__SWIG_0(this.swigCPtr, iField, Geometry.getCPtrAndDisown(geom, this.ThisOwn_false()));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeomFieldDirectly(string field_name, Geometry geom)
        {
            int num = OgrPINVOKE.Feature_SetGeomFieldDirectly__SWIG_1(this.swigCPtr, field_name, Geometry.getCPtrAndDisown(geom, this.ThisOwn_false()));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetNativeData(string nativeData)
        {
            OgrPINVOKE.Feature_SetNativeData(this.swigCPtr, nativeData);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetNativeMediaType(string nativeMediaType)
        {
            OgrPINVOKE.Feature_SetNativeMediaType(this.swigCPtr, nativeMediaType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetStyleString(string the_string)
        {
            OgrPINVOKE.Feature_SetStyleString(this.swigCPtr, the_string);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public void UnsetField(int id)
        {
            OgrPINVOKE.Feature_UnsetField__SWIG_0(this.swigCPtr, id);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void UnsetField(string field_name)
        {
            OgrPINVOKE.Feature_UnsetField__SWIG_1(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int Validate(int flags, int bEmitError)
        {
            int num = OgrPINVOKE.Feature_Validate(this.swigCPtr, flags, bEmitError);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }
    }
}

