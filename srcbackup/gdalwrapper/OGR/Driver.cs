namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class Driver : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public Driver(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public DataSource CopyDataSource(DataSource copy_ds, string utf8_path, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.Driver_CopyDataSource(this.swigCPtr, DataSource.getCPtr(copy_ds), Ogr.StringToUtf8Bytes(utf8_path), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            DataSource source = (cPtr == IntPtr.Zero) ? null : new DataSource(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public DataSource CreateDataSource(string utf8_path, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.Driver_CreateDataSource(this.swigCPtr, Ogr.StringToUtf8Bytes(utf8_path), (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            DataSource source = (cPtr == IntPtr.Zero) ? null : new DataSource(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public int DeleteDataSource(string utf8_path)
        {
            int num = OgrPINVOKE.Driver_DeleteDataSource(this.swigCPtr, Ogr.StringToUtf8Bytes(utf8_path));
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void Deregister()
        {
            OgrPINVOKE.Driver_Deregister(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
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

        public static HandleRef getCPtr(Driver obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Driver obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Driver obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public string GetName()
        {
            string str = OgrPINVOKE.Driver_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public DataSource Open(string utf8_path, int update)
        {
            IntPtr cPtr = OgrPINVOKE.Driver_Open(this.swigCPtr, Ogr.StringToUtf8Bytes(utf8_path), update);
            DataSource source = (cPtr == IntPtr.Zero) ? null : new DataSource(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public void Register()
        {
            OgrPINVOKE.Driver_Register(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public bool TestCapability(string cap)
        {
            bool flag = OgrPINVOKE.Driver_TestCapability(this.swigCPtr, cap);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public string name
        {
            get
            {
                string str = OgrPINVOKE.Driver_name_get(this.swigCPtr);
                if (OgrPINVOKE.SWIGPendingException.Pending)
                {
                    throw OgrPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }
    }
}

