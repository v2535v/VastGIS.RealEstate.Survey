namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class Envelope : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Envelope() : this(OgrPINVOKE.new_Envelope(), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Envelope(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    OgrPINVOKE.delete_Envelope(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~Envelope()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(Envelope obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Envelope obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Envelope obj, object parent)
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

        public double MaxX
        {
            get
            {
                double num = OgrPINVOKE.Envelope_MaxX_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                OgrPINVOKE.Envelope_MaxX_set(this.swigCPtr, value);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double MaxY
        {
            get
            {
                double num = OgrPINVOKE.Envelope_MaxY_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                OgrPINVOKE.Envelope_MaxY_set(this.swigCPtr, value);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double MinX
        {
            get
            {
                double num = OgrPINVOKE.Envelope_MinX_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                OgrPINVOKE.Envelope_MinX_set(this.swigCPtr, value);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public double MinY
        {
            get
            {
                double num = OgrPINVOKE.Envelope_MinY_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                OgrPINVOKE.Envelope_MinY_set(this.swigCPtr, value);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }
    }
}

