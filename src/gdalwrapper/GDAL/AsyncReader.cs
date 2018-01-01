namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class AsyncReader : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public AsyncReader(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    GdalPINVOKE.delete_AsyncReader(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~AsyncReader()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(AsyncReader obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(AsyncReader obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(AsyncReader obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public AsyncStatusType GetNextUpdatedRegion(double timeout, out int xoff, out int yoff, out int buf_xsize, out int buf_ysize)
        {
            AsyncStatusType type = (AsyncStatusType) GdalPINVOKE.AsyncReader_GetNextUpdatedRegion(this.swigCPtr, timeout, out xoff, out yoff, out buf_xsize, out buf_ysize);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public int LockBuffer(double timeout)
        {
            int num = GdalPINVOKE.AsyncReader_LockBuffer(this.swigCPtr, timeout);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public void UnlockBuffer()
        {
            GdalPINVOKE.AsyncReader_UnlockBuffer(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }
    }
}

