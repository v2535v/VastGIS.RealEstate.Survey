namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class FeatureDefn : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public FeatureDefn(string name_null_ok) : this(OgrPINVOKE.new_FeatureDefn(name_null_ok), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public FeatureDefn(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public void AddFieldDefn(FieldDefn defn)
        {
            OgrPINVOKE.FeatureDefn_AddFieldDefn(this.swigCPtr, FieldDefn.getCPtr(defn));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void AddGeomFieldDefn(GeomFieldDefn defn)
        {
            OgrPINVOKE.FeatureDefn_AddGeomFieldDefn(this.swigCPtr, GeomFieldDefn.getCPtr(defn));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int DeleteGeomFieldDefn(int idx)
        {
            int num = OgrPINVOKE.FeatureDefn_DeleteGeomFieldDefn(this.swigCPtr, idx);
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
                    OgrPINVOKE.delete_FeatureDefn(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~FeatureDefn()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(FeatureDefn obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(FeatureDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(FeatureDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public int GetFieldCount()
        {
            int num = OgrPINVOKE.FeatureDefn_GetFieldCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public FieldDefn GetFieldDefn(int i)
        {
            IntPtr cPtr = OgrPINVOKE.FeatureDefn_GetFieldDefn(this.swigCPtr, i);
            FieldDefn defn = (cPtr == IntPtr.Zero) ? null : new FieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public int GetFieldIndex(string field_name)
        {
            int num = OgrPINVOKE.FeatureDefn_GetFieldIndex(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetGeomFieldCount()
        {
            int num = OgrPINVOKE.FeatureDefn_GetGeomFieldCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public GeomFieldDefn GetGeomFieldDefn(int i)
        {
            IntPtr cPtr = OgrPINVOKE.FeatureDefn_GetGeomFieldDefn(this.swigCPtr, i);
            GeomFieldDefn defn = (cPtr == IntPtr.Zero) ? null : new GeomFieldDefn(cPtr, false, this.ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return defn;
        }

        public int GetGeomFieldIndex(string field_name)
        {
            int num = OgrPINVOKE.FeatureDefn_GetGeomFieldIndex(this.swigCPtr, field_name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public wkbGeometryType GetGeomType()
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.FeatureDefn_GetGeomType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public string GetName()
        {
            string str = OgrPINVOKE.FeatureDefn_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int GetReferenceCount()
        {
            int num = OgrPINVOKE.FeatureDefn_GetReferenceCount(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsGeometryIgnored()
        {
            int num = OgrPINVOKE.FeatureDefn_IsGeometryIgnored(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsSame(FeatureDefn other_defn)
        {
            int num = OgrPINVOKE.FeatureDefn_IsSame(this.swigCPtr, getCPtr(other_defn));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsStyleIgnored()
        {
            int num = OgrPINVOKE.FeatureDefn_IsStyleIgnored(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetGeometryIgnored(int bIgnored)
        {
            OgrPINVOKE.FeatureDefn_SetGeometryIgnored(this.swigCPtr, bIgnored);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetGeomType(wkbGeometryType geom_type)
        {
            OgrPINVOKE.FeatureDefn_SetGeomType(this.swigCPtr, (int) geom_type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetStyleIgnored(int bIgnored)
        {
            OgrPINVOKE.FeatureDefn_SetStyleIgnored(this.swigCPtr, bIgnored);
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
    }
}

