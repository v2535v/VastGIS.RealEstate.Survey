namespace OSGeo.OGR
{
    using OSGeo.OSR;
    using System;
    using System.Runtime.InteropServices;

    public class DataSource : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public DataSource(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public int CommitTransaction()
        {
            int num = OgrPINVOKE.DataSource_CommitTransaction(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public Layer CopyLayer(Layer src_layer, string new_name, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_CopyLayer(this.swigCPtr, Layer.getCPtr(src_layer), new_name, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            Layer layer = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return layer;
        }

        public Layer CreateLayer(string name, SpatialReference srs, wkbGeometryType geom_type, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_CreateLayer(this.swigCPtr, name, SpatialReference.getCPtr(srs), (int) geom_type, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            Layer layer = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return layer;
        }

        public int DeleteLayer(int index)
        {
            int num = OgrPINVOKE.DataSource_DeleteLayer(this.swigCPtr, index);
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
                    OgrPINVOKE.delete_DataSource(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public Layer ExecuteSQL(string statement, Geometry spatialFilter, string dialect)
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_ExecuteSQL(this.swigCPtr, statement, Geometry.getCPtr(spatialFilter), dialect);
            Layer layer = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return layer;
        }

        ~DataSource()
        {
            this.Dispose();
        }

        public void FlushCache()
        {
            OgrPINVOKE.DataSource_FlushCache(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static HandleRef getCPtr(DataSource obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(DataSource obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(DataSource obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public Driver GetDriver()
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_GetDriver(this.swigCPtr);
            Driver driver = (cPtr == IntPtr.Zero) ? null : new Driver(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public Layer GetLayerByIndex(int index)
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_GetLayerByIndex(this.swigCPtr, index);
            Layer layer = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return layer;
        }

        public Layer GetLayerByName(string layer_name)
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_GetLayerByName(this.swigCPtr, layer_name);
            Layer layer = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return layer;
        }

        public int GetLayerCount()
        {
            int num = OgrPINVOKE.DataSource_GetLayerCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetName()
        {
            string str = OgrPINVOKE.DataSource_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int GetRefCount()
        {
            int num = OgrPINVOKE.DataSource_GetRefCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public StyleTable GetStyleTable()
        {
            IntPtr cPtr = OgrPINVOKE.DataSource_GetStyleTable(this.swigCPtr);
            StyleTable table = (cPtr == IntPtr.Zero) ? null : new StyleTable(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public int GetSummaryRefCount()
        {
            int num = OgrPINVOKE.DataSource_GetSummaryRefCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void ReleaseResultSet(Layer layer)
        {
            OgrPINVOKE.DataSource_ReleaseResultSet(this.swigCPtr, Layer.getCPtrAndDisown(layer, this.ThisOwn_false()));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int RollbackTransaction()
        {
            int num = OgrPINVOKE.DataSource_RollbackTransaction(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetStyleTable(StyleTable table)
        {
            OgrPINVOKE.DataSource_SetStyleTable(this.swigCPtr, StyleTable.getCPtr(table));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int StartTransaction(int force)
        {
            int num = OgrPINVOKE.DataSource_StartTransaction(this.swigCPtr, force);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SyncToDisk()
        {
            int num = OgrPINVOKE.DataSource_SyncToDisk(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public bool TestCapability(string cap)
        {
            bool flag = OgrPINVOKE.DataSource_TestCapability(this.swigCPtr, cap);
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

        public string name
        {
            get
            {
                string str = OgrPINVOKE.DataSource_name_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }
    }
}

