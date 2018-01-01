namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class ColorEntry : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public ColorEntry() : this(GdalPINVOKE.new_ColorEntry(), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public ColorEntry(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    GdalPINVOKE.delete_ColorEntry(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~ColorEntry()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(ColorEntry obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(ColorEntry obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(ColorEntry obj, object parent)
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

        public short c1
        {
            get
            {
                short num = GdalPINVOKE.ColorEntry_c1_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.ColorEntry_c1_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public short c2
        {
            get
            {
                short num = GdalPINVOKE.ColorEntry_c2_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.ColorEntry_c2_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public short c3
        {
            get
            {
                short num = GdalPINVOKE.ColorEntry_c3_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.ColorEntry_c3_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }

        public short c4
        {
            get
            {
                short num = GdalPINVOKE.ColorEntry_c4_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
            set
            {
                GdalPINVOKE.ColorEntry_c4_set(this.swigCPtr, value);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
            }
        }
    }
}

