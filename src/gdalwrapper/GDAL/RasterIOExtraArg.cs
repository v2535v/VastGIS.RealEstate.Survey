namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class RasterIOExtraArg : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public RasterIOExtraArg() : this(GdalPINVOKE.new_RasterIOExtraArg(), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public RasterIOExtraArg(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    GdalPINVOKE.delete_RasterIOExtraArg(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~RasterIOExtraArg()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(RasterIOExtraArg obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(RasterIOExtraArg obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(RasterIOExtraArg obj, object parent)
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

        public int bFloatingPointWindowValidity
        {
            get
            {
                int num = GdalPINVOKE.RasterIOExtraArg_bFloatingPointWindowValidity_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_bFloatingPointWindowValidity_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double dfXOff
        {
            get
            {
                double num = GdalPINVOKE.RasterIOExtraArg_dfXOff_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_dfXOff_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double dfXSize
        {
            get
            {
                double num = GdalPINVOKE.RasterIOExtraArg_dfXSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_dfXSize_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double dfYOff
        {
            get
            {
                double num = GdalPINVOKE.RasterIOExtraArg_dfYOff_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_dfYOff_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double dfYSize
        {
            get
            {
                double num = GdalPINVOKE.RasterIOExtraArg_dfYSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_dfYSize_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public RIOResampleAlg eResampleAlg
        {
            get
            {
                RIOResampleAlg alg = (RIOResampleAlg) GdalPINVOKE.RasterIOExtraArg_eResampleAlg_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return alg;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_eResampleAlg_set(this.swigCPtr, (int) value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public int nVersion
        {
            get
            {
                int num = GdalPINVOKE.RasterIOExtraArg_nVersion_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_nVersion_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public Gdal.GDALProgressFuncDelegate pfnProgress
        {
            get
            {
                Gdal.GDALProgressFuncDelegate delegate2 = GdalPINVOKE.RasterIOExtraArg_pfnProgress_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return delegate2;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_pfnProgress_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public IntPtr pProgressData
        {
            get
            {
                IntPtr ptr = GdalPINVOKE.RasterIOExtraArg_pProgressData_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return ptr;
            }
            set
            {
                GdalPINVOKE.RasterIOExtraArg_pProgressData_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }
    }
}

