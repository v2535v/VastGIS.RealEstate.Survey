namespace OSGeo.OGR
{
    using OSGeo.OSR;
    using System;
    using System.Runtime.InteropServices;

    public class GeomFieldDefn : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public GeomFieldDefn(string name_null_ok, wkbGeometryType field_type) : this(OgrPINVOKE.new_GeomFieldDefn(name_null_ok, (int) field_type), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public GeomFieldDefn(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    OgrPINVOKE.delete_GeomFieldDefn(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~GeomFieldDefn()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(GeomFieldDefn obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(GeomFieldDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(GeomFieldDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public wkbGeometryType GetFieldType()
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GeomFieldDefn_GetFieldType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public string GetName()
        {
            string str = OgrPINVOKE.GeomFieldDefn_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetNameRef()
        {
            string str = OgrPINVOKE.GeomFieldDefn_GetNameRef(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public SpatialReference GetSpatialRef()
        {
            IntPtr cPtr = OgrPINVOKE.GeomFieldDefn_GetSpatialRef(this.swigCPtr);
            SpatialReference reference = (cPtr == IntPtr.Zero) ? null : new SpatialReference(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return reference;
        }

        public int IsIgnored()
        {
            int num = OgrPINVOKE.GeomFieldDefn_IsIgnored(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsNullable()
        {
            int num = OgrPINVOKE.GeomFieldDefn_IsNullable(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetIgnored(int bIgnored)
        {
            OgrPINVOKE.GeomFieldDefn_SetIgnored(this.swigCPtr, bIgnored);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetName(string name)
        {
            OgrPINVOKE.GeomFieldDefn_SetName(this.swigCPtr, name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetNullable(int bNullable)
        {
            OgrPINVOKE.GeomFieldDefn_SetNullable(this.swigCPtr, bNullable);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetSpatialRef(SpatialReference srs)
        {
            OgrPINVOKE.GeomFieldDefn_SetSpatialRef(this.swigCPtr, SpatialReference.getCPtr(srs));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetType(wkbGeometryType type)
        {
            OgrPINVOKE.GeomFieldDefn_SetType(this.swigCPtr, (int) type);
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

