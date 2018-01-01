namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class GCP : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public GCP(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public GCP(double x, double y, double z, double pixel, double line, string info, string id) : this(GdalPINVOKE.new_GCP(x, y, z, pixel, line, info, id), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    GdalPINVOKE.delete_GCP(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~GCP()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(GCP obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(GCP obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(GCP obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public double GCPLine
        {
            get
            {
                double num = GdalPINVOKE.GCP_GCPLine_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.GCP_GCPLine_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double GCPPixel
        {
            get
            {
                double num = GdalPINVOKE.GCP_GCPPixel_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.GCP_GCPPixel_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double GCPX
        {
            get
            {
                double num = GdalPINVOKE.GCP_GCPX_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.GCP_GCPX_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double GCPY
        {
            get
            {
                double num = GdalPINVOKE.GCP_GCPY_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.GCP_GCPY_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double GCPZ
        {
            get
            {
                double num = GdalPINVOKE.GCP_GCPZ_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.GCP_GCPZ_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public string Id
        {
            get
            {
                string str = GdalPINVOKE.GCP_Id_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
            set
            {
                GdalPINVOKE.GCP_Id_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public string Info
        {
            get
            {
                string str = GdalPINVOKE.GCP_Info_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
            set
            {
                GdalPINVOKE.GCP_Info_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }
    }
}

