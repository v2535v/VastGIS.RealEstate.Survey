namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class Driver : MajorObject
    {
        private HandleRef swigCPtr;

        public Driver(IntPtr cPtr, bool cMemoryOwn, object parent) : base(GdalPINVOKE.DriverUpcast(cPtr), cMemoryOwn, parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public CPLErr CopyFiles(string newName, string oldName)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Driver_CopyFiles(this.swigCPtr, newName, oldName);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public Dataset Create(string utf8_path, int xsize, int ysize, int bands, DataType eType, string[] options)
        {
            IntPtr cPtr = GdalPINVOKE.Driver_Create(this.swigCPtr, Gdal.StringToUtf8Bytes(utf8_path), xsize, ysize, bands, (int) eType, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, MajorObject.ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public Dataset CreateCopy(string utf8_path, Dataset src, int strict, string[] options, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.Driver_CreateCopy(this.swigCPtr, Gdal.StringToUtf8Bytes(utf8_path), Dataset.getCPtr(src), strict, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, MajorObject.ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public CPLErr Delete(string utf8_path)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Driver_Delete(this.swigCPtr, Gdal.StringToUtf8Bytes(utf8_path));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public void Deregister()
        {
            GdalPINVOKE.Driver_Deregister(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public override void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && base.swigCMemOwn)
                {
                    base.swigCMemOwn = false;
                    throw new MethodAccessException("C++ destructor does not have public access");
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                GC.SuppressFinalize(this);
                base.Dispose();
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

        public int Register()
        {
            int num = GdalPINVOKE.Driver_Register(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr Rename(string newName, string oldName)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Driver_Rename(this.swigCPtr, newName, oldName);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public string HelpTopic
        {
            get
            {
                string str = GdalPINVOKE.Driver_HelpTopic_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }

        public string LongName
        {
            get
            {
                string str = GdalPINVOKE.Driver_LongName_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }

        public string ShortName
        {
            get
            {
                string str = GdalPINVOKE.Driver_ShortName_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }
    }
}

