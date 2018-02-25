namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class MajorObject : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public MajorObject(IntPtr cPtr, bool cMemoryOwn, object parent)
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
                    throw new MethodAccessException("C++ destructor does not have public access");
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public static HandleRef getCPtr(MajorObject obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(MajorObject obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(MajorObject obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public string GetDescription()
        {
            string str = GdalPINVOKE.MajorObject_GetDescription(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string[] GetMetadata(string pszDomain)
        {
            IntPtr ptr = GdalPINVOKE.MajorObject_GetMetadata(this.swigCPtr, pszDomain);
            int num = 0;
            if (ptr != IntPtr.Zero)
            {
                while (Marshal.ReadIntPtr(ptr, num * IntPtr.Size) != IntPtr.Zero)
                {
                    num++;
                }
            }
            string[] strArray = new string[num];
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    IntPtr ptr2 = Marshal.ReadIntPtr(ptr, i * Marshal.SizeOf(typeof(IntPtr)));
                    strArray[i] = (ptr2 == IntPtr.Zero) ? null : Marshal.PtrToStringAnsi(ptr2);
                }
            }
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return strArray;
        }

        public string[] GetMetadataDomainList()
        {
            IntPtr ptr = GdalPINVOKE.MajorObject_GetMetadataDomainList(this.swigCPtr);
            int num = 0;
            if (ptr != IntPtr.Zero)
            {
                while (Marshal.ReadIntPtr(ptr, num * IntPtr.Size) != IntPtr.Zero)
                {
                    num++;
                }
            }
            string[] strArray = new string[num];
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    IntPtr ptr2 = Marshal.ReadIntPtr(ptr, i * Marshal.SizeOf(typeof(IntPtr)));
                    strArray[i] = (ptr2 == IntPtr.Zero) ? null : Marshal.PtrToStringAnsi(ptr2);
                }
            }
            if (ptr != IntPtr.Zero)
            {
                GdalPINVOKE.StringListDestroy(ptr);
            }
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return strArray;
        }

        public string GetMetadataItem(string pszName, string pszDomain)
        {
            string str = GdalPINVOKE.MajorObject_GetMetadataItem(this.swigCPtr, pszName, pszDomain);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public void SetDescription(string pszNewDesc)
        {
            GdalPINVOKE.MajorObject_SetDescription(this.swigCPtr, pszNewDesc);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public CPLErr SetMetadata(string[] papszMetadata, string pszDomain)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.MajorObject_SetMetadata__SWIG_0(this.swigCPtr, (papszMetadata != null) ? new GdalPINVOKE.StringListMarshal(papszMetadata)._ar : null, pszDomain);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetMetadata(string pszMetadataString, string pszDomain)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.MajorObject_SetMetadata__SWIG_1(this.swigCPtr, pszMetadataString, pszDomain);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetMetadataItem(string pszName, string pszValue, string pszDomain)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.MajorObject_SetMetadataItem(this.swigCPtr, pszName, pszValue, pszDomain);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
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

