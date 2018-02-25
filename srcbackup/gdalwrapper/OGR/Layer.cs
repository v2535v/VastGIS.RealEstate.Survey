namespace OSGeo.OGR
{
    using OSGeo.OSR;
    using System;
    using System.Runtime.InteropServices;

    public class Layer : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Layer(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public int AlterFieldDefn(int iField, FieldDefn field_def, int nFlags)
        {
            int num = OgrPINVOKE.Layer_AlterFieldDefn(this.swigCPtr, iField, FieldDefn.getCPtr(field_def), nFlags);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int Clip(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Clip(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int CommitTransaction()
        {
            int num = OgrPINVOKE.Layer_CommitTransaction(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int CreateFeature(Feature feature)
        {
            int num = OgrPINVOKE.Layer_CreateFeature(this.swigCPtr, Feature.getCPtr(feature));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int CreateField(FieldDefn field_def, int approx_ok)
        {
            int num = OgrPINVOKE.Layer_CreateField(this.swigCPtr, FieldDefn.getCPtr(field_def), approx_ok);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int CreateGeomField(GeomFieldDefn field_def, int approx_ok)
        {
            int num = OgrPINVOKE.Layer_CreateGeomField(this.swigCPtr, GeomFieldDefn.getCPtr(field_def), approx_ok);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int DeleteFeature(long fid)
        {
            int num = OgrPINVOKE.Layer_DeleteFeature(this.swigCPtr, fid);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int DeleteField(int iField)
        {
            int num = OgrPINVOKE.Layer_DeleteField(this.swigCPtr, iField);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    throw new MethodAccessException("C++ destructor does not have public access");
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public int Erase(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Erase(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int FindFieldIndex(string pszFieldName, int bExactMatch)
        {
            int num = OgrPINVOKE.Layer_FindFieldIndex(this.swigCPtr, pszFieldName, bExactMatch);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static HandleRef getCPtr(Layer obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Layer obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Layer obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public int GetExtent(Envelope extent, int force)
        {
            int num = OgrPINVOKE.Layer_GetExtent(this.swigCPtr, Envelope.getCPtr(extent), force);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Feature GetFeature(long fid)
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetFeature(this.swigCPtr, fid);
            Feature feature = (cPtr == IntPtr.Zero) ? null : new Feature(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return feature;
        }

        public long GetFeatureCount(int force)
        {
            long num = OgrPINVOKE.Layer_GetFeatureCount(this.swigCPtr, force);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public long GetFeaturesRead()
        {
            long num = OgrPINVOKE.Layer_GetFeaturesRead(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetFIDColumn()
        {
            string str = OgrPINVOKE.Layer_GetFIDColumn(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetGeometryColumn()
        {
            string str = OgrPINVOKE.Layer_GetGeometryColumn(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public wkbGeometryType GetGeomType()
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.Layer_GetGeomType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public FeatureDefn GetLayerDefn()
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetLayerDefn(this.swigCPtr);
            FeatureDefn defn = (cPtr == IntPtr.Zero) ? null : new FeatureDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public string GetName()
        {
            string str = OgrPINVOKE.Layer_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public Feature GetNextFeature()
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetNextFeature(this.swigCPtr);
            Feature feature = (cPtr == IntPtr.Zero) ? null : new Feature(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return feature;
        }

        public int GetRefCount()
        {
            int num = OgrPINVOKE.Layer_GetRefCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Geometry GetSpatialFilter()
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetSpatialFilter(this.swigCPtr);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public SpatialReference GetSpatialRef()
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetSpatialRef(this.swigCPtr);
            SpatialReference reference = (cPtr == IntPtr.Zero) ? null : new SpatialReference(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return reference;
        }

        public StyleTable GetStyleTable()
        {
            IntPtr cPtr = OgrPINVOKE.Layer_GetStyleTable(this.swigCPtr);
            StyleTable table = (cPtr == IntPtr.Zero) ? null : new StyleTable(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public int Identity(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Identity(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int Intersection(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Intersection(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ReorderField(int iOldFieldPos, int iNewFieldPos)
        {
            int num = OgrPINVOKE.Layer_ReorderField(this.swigCPtr, iOldFieldPos, iNewFieldPos);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ReorderFields(int nList, int[] pList)
        {
            int num = OgrPINVOKE.Layer_ReorderFields(this.swigCPtr, nList, pList);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void ResetReading()
        {
            OgrPINVOKE.Layer_ResetReading(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int RollbackTransaction()
        {
            int num = OgrPINVOKE.Layer_RollbackTransaction(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetAttributeFilter(string filter_string)
        {
            int num = OgrPINVOKE.Layer_SetAttributeFilter(this.swigCPtr, Ogr.StringToUtf8Bytes(filter_string));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetFeature(Feature feature)
        {
            int num = OgrPINVOKE.Layer_SetFeature(this.swigCPtr, Feature.getCPtr(feature));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetIgnoredFields(string[] options)
        {
            int num = OgrPINVOKE.Layer_SetIgnoredFields(this.swigCPtr, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetNextByIndex(long new_index)
        {
            int num = OgrPINVOKE.Layer_SetNextByIndex(this.swigCPtr, new_index);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetSpatialFilter(Geometry filter)
        {
            OgrPINVOKE.Layer_SetSpatialFilter__SWIG_0(this.swigCPtr, Geometry.getCPtr(filter));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetSpatialFilter(int iGeomField, Geometry filter)
        {
            OgrPINVOKE.Layer_SetSpatialFilter__SWIG_1(this.swigCPtr, iGeomField, Geometry.getCPtr(filter));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetSpatialFilterRect(double minx, double miny, double maxx, double maxy)
        {
            OgrPINVOKE.Layer_SetSpatialFilterRect__SWIG_0(this.swigCPtr, minx, miny, maxx, maxy);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetSpatialFilterRect(int iGeomField, double minx, double miny, double maxx, double maxy)
        {
            OgrPINVOKE.Layer_SetSpatialFilterRect__SWIG_1(this.swigCPtr, iGeomField, minx, miny, maxx, maxy);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetStyleTable(StyleTable table)
        {
            OgrPINVOKE.Layer_SetStyleTable(this.swigCPtr, StyleTable.getCPtr(table));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int StartTransaction()
        {
            int num = OgrPINVOKE.Layer_StartTransaction(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SymDifference(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_SymDifference(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SyncToDisk()
        {
            int num = OgrPINVOKE.Layer_SyncToDisk(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool TestCapability(string cap)
        {
            bool flag = OgrPINVOKE.Layer_TestCapability(this.swigCPtr, cap);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public int Union(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Union(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int Update(Layer method_layer, Layer result_layer, string[] options, Ogr.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = OgrPINVOKE.Layer_Update(this.swigCPtr, getCPtr(method_layer), getCPtr(result_layer), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }
    }
}

