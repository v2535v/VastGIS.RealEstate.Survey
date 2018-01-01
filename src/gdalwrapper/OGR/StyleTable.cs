namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class StyleTable : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public StyleTable() : this(OgrPINVOKE.new_StyleTable(), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public StyleTable(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public int AddStyle(string pszName, string pszStyleString)
        {
            int num = OgrPINVOKE.StyleTable_AddStyle(this.swigCPtr, pszName, pszStyleString);
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
                    OgrPINVOKE.delete_StyleTable(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~StyleTable()
        {
            this.Dispose();
        }

        public string Find(string pszName)
        {
            string str = OgrPINVOKE.StyleTable_Find(this.swigCPtr, pszName);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static HandleRef getCPtr(StyleTable obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(StyleTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(StyleTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public string GetLastStyleName()
        {
            string str = OgrPINVOKE.StyleTable_GetLastStyleName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetNextStyle()
        {
            string str = OgrPINVOKE.StyleTable_GetNextStyle(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int LoadStyleTable(string utf8_path)
        {
            int num = OgrPINVOKE.StyleTable_LoadStyleTable(this.swigCPtr, Ogr.StringToUtf8Bytes(utf8_path));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void ResetStyleStringReading()
        {
            OgrPINVOKE.StyleTable_ResetStyleStringReading(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int SaveStyleTable(string utf8_path)
        {
            int num = OgrPINVOKE.StyleTable_SaveStyleTable(this.swigCPtr, Ogr.StringToUtf8Bytes(utf8_path));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
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
    }
}

