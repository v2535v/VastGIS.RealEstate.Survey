namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class Transformer : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Transformer(Dataset src, Dataset dst, string[] options) : this(GdalPINVOKE.new_Transformer(Dataset.getCPtr(src), Dataset.getCPtr(dst), (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Transformer(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    GdalPINVOKE.delete_Transformer(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~Transformer()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(Transformer obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Transformer obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Transformer obj, object parent)
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

        public int TransformGeolocations(Band xBand, Band yBand, Band zBand, Gdal.GDALProgressFuncDelegate callback, string callback_data, string[] options)
        {
            int num = GdalPINVOKE.Transformer_TransformGeolocations(this.swigCPtr, Band.getCPtr(xBand), Band.getCPtr(yBand), Band.getCPtr(zBand), callback, callback_data, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int TransformPoint(int bDstToSrc, double[] inout)
        {
            int num = GdalPINVOKE.Transformer_TransformPoint__SWIG_0(this.swigCPtr, bDstToSrc, inout);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int TransformPoint(double[] argout, int bDstToSrc, double x, double y, double z)
        {
            int num = GdalPINVOKE.Transformer_TransformPoint__SWIG_1(this.swigCPtr, argout, bDstToSrc, x, y, z);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int TransformPoints(int bDstToSrc, int nCount, double[] x, double[] y, double[] z, double[] panSuccess)
        {
            int num = GdalPINVOKE.Transformer_TransformPoints(this.swigCPtr, bDstToSrc, nCount, x, y, z, panSuccess);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }
    }
}

