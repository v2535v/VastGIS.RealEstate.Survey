namespace OSGeo.OSR
{
    using System;
    using System.Runtime.InteropServices;

    public class CoordinateTransformation : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public CoordinateTransformation(SpatialReference src, SpatialReference dst) : this(OsrPINVOKE.new_CoordinateTransformation(SpatialReference.getCPtr(src), SpatialReference.getCPtr(dst)), true, null)
        {
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public CoordinateTransformation(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    OsrPINVOKE.delete_CoordinateTransformation(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~CoordinateTransformation()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(CoordinateTransformation obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(CoordinateTransformation obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(CoordinateTransformation obj, object parent)
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

        public void TransformPoint(double[] inout)
        {
            OsrPINVOKE.CoordinateTransformation_TransformPoint__SWIG_0(this.swigCPtr, inout);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void TransformPoint(double[] argout, double x, double y, double z)
        {
            OsrPINVOKE.CoordinateTransformation_TransformPoint__SWIG_1(this.swigCPtr, argout, x, y, z);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void TransformPoints(int nCount, double[] x, double[] y, double[] z)
        {
            OsrPINVOKE.CoordinateTransformation_TransformPoints(this.swigCPtr, nCount, x, y, z);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
        }
    }
}

