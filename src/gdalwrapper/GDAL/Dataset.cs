namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class Dataset : MajorObject
    {
        private HandleRef swigCPtr;

        public Dataset(IntPtr cPtr, bool cMemoryOwn, object parent) : base(GdalPINVOKE.DatasetUpcast(cPtr), cMemoryOwn, parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        private IntPtr __AllocCArray_GDAL_GCP(int size)
        {
            IntPtr ptr = GdalPINVOKE.Dataset___AllocCArray_GDAL_GCP(this.swigCPtr, size);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        private void __FreeCArray_GDAL_GCP(IntPtr carray)
        {
            GdalPINVOKE.Dataset___FreeCArray_GDAL_GCP(this.swigCPtr, carray);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        private IntPtr __GetGCPs()
        {
            IntPtr ptr = GdalPINVOKE.Dataset___GetGCPs(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        private GCP __ReadCArrayItem_GDAL_GCP(IntPtr carray, int index)
        {
            IntPtr cPtr = GdalPINVOKE.Dataset___ReadCArrayItem_GDAL_GCP(this.swigCPtr, carray, index);
            GCP gcp = (cPtr == IntPtr.Zero) ? null : new GCP(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return gcp;
        }

        private CPLErr __SetGCPs(int nGCPs, IntPtr pGCPs, string pszGCPProjection)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset___SetGCPs(this.swigCPtr, nGCPs, pGCPs, pszGCPProjection);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        private void __WriteCArrayItem_GDAL_GCP(IntPtr carray, int index, GCP value)
        {
            GdalPINVOKE.Dataset___WriteCArrayItem_GDAL_GCP(this.swigCPtr, carray, index, GCP.getCPtr(value));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public CPLErr AddBand(DataType datatype, string[] options)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_AddBand(this.swigCPtr, (int) datatype, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int BuildOverviews(string resampling, int[] overviewlist)
        {
            return this.BuildOverviews(resampling, overviewlist, null, null);
        }

        public int BuildOverviews(string resampling, int[] overviewlist, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num;
            if ((int)overviewlist.Length <= 0)
            {
                throw new ArgumentException("overviewlist size is small (BuildOverviews)");
            }
            IntPtr intPtr = Marshal.AllocHGlobal((int)overviewlist.Length * Marshal.SizeOf(overviewlist[0]));
            try
            {
                Marshal.Copy(overviewlist, 0, intPtr, (int)overviewlist.Length);
                num = this.BuildOverviews(resampling, (int)overviewlist.Length, intPtr, callback, callback_data);
            }
            finally
            {
                Marshal.FreeHGlobal(intPtr);
            }
            GC.KeepAlive(this);
            return num;
        }

        public int BuildOverviews(string resampling, int overviewlist, IntPtr pOverviews, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.Dataset_BuildOverviews(this.swigCPtr, resampling, overviewlist, pOverviews, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int CommitTransaction()
        {
            int num = GdalPINVOKE.Dataset_CommitTransaction(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr CreateMaskBand(int nFlags)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_CreateMaskBand(this.swigCPtr, nFlags);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public override void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && base.swigCMemOwn)
                {
                    base.swigCMemOwn = false;
                    GdalPINVOKE.delete_Dataset(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        ~Dataset()
        {
            this.Dispose();
        }

        public void FlushCache()
        {
            GdalPINVOKE.Dataset_FlushCache(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static HandleRef getCPtr(Dataset obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Dataset obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Dataset obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public Driver GetDriver()
        {
            IntPtr cPtr = GdalPINVOKE.Dataset_GetDriver(this.swigCPtr);
            Driver driver = (cPtr == IntPtr.Zero) ? null : new Driver(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public string[] GetFileList()
        {
            IntPtr ptr = GdalPINVOKE.Dataset_GetFileList(this.swigCPtr);
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

        public int GetGCPCount()
        {
            int num = GdalPINVOKE.Dataset_GetGCPCount(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetGCPProjection()
        {
            string str = GdalPINVOKE.Dataset_GetGCPProjection(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public GCP[] GetGCPs()
        {
            IntPtr carray = this.__GetGCPs();
            int gCPCount = this.GetGCPCount();
            GCP[] gcpArray = null;
            if ((carray != IntPtr.Zero) && (gCPCount > 0))
            {
                gcpArray = new GCP[gCPCount];
                for (int i = 0; i < gCPCount; i++)
                {
                    gcpArray[i] = this.__ReadCArrayItem_GDAL_GCP(carray, i);
                }
            }
            GC.KeepAlive(this);
            return gcpArray;
        }

        public void GetGeoTransform(double[] argout)
        {
            GdalPINVOKE.Dataset_GetGeoTransform(this.swigCPtr, argout);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public string GetProjection()
        {
            string str = GdalPINVOKE.Dataset_GetProjection(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetProjectionRef()
        {
            string str = GdalPINVOKE.Dataset_GetProjectionRef(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public Band GetRasterBand(int nBand)
        {
            IntPtr cPtr = GdalPINVOKE.Dataset_GetRasterBand(this.swigCPtr, nBand);
            Band band = (cPtr == IntPtr.Zero) ? null : new Band(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return band;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Byte, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float64, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int16, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, DataType buf_type, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_ReadRaster__SWIG_0(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Byte, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float64, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int16, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, DataType buf_type, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_ReadRaster__SWIG_1(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, RasterIOExtraArg.getCPtr(extraArg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int RollbackTransaction()
        {
            int num = GdalPINVOKE.Dataset_RollbackTransaction(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr SetGCPs(GCP[] pGCPs, string pszGCPProjection)
        {
            CPLErr err = CPLErr.CE_None;
            if ((pGCPs != null) && (pGCPs.Length > 0))
            {
                IntPtr carray = this.__AllocCArray_GDAL_GCP(pGCPs.Length);
                if (carray == IntPtr.Zero)
                {
                    throw new ApplicationException("Error allocating CArray with __AllocCArray_GDAL_GCP");
                }
                try
                {
                    for (int i = 0; i < pGCPs.Length; i++)
                    {
                        this.__WriteCArrayItem_GDAL_GCP(carray, i, pGCPs[i]);
                    }
                    err = this.__SetGCPs(pGCPs.Length, carray, pszGCPProjection);
                }
                finally
                {
                    this.__FreeCArray_GDAL_GCP(carray);
                }
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr SetGeoTransform(double[] argin)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_SetGeoTransform(this.swigCPtr, argin);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetProjection(string prj)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_SetProjection(this.swigCPtr, prj);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int StartTransaction(int force)
        {
            int num = GdalPINVOKE.Dataset_StartTransaction(this.swigCPtr, force);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Byte, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float64, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int16, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, DataType buf_type, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_WriteRaster__SWIG_0(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, bandCount, bandMap, pixelSpace, lineSpace, bandSpace);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Byte, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float64, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int16, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Int32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, DataType.GDT_Float32, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, DataType buf_type, int bandCount, int[] bandMap, int pixelSpace, int lineSpace, int bandSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Dataset_WriteRaster__SWIG_1(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, bandCount, bandMap, pixelSpace, lineSpace, bandSpace, RasterIOExtraArg.getCPtr(extraArg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int RasterCount
        {
            get
            {
                int num = GdalPINVOKE.Dataset_RasterCount_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
        }

        public int RasterXSize
        {
            get
            {
                int num = GdalPINVOKE.Dataset_RasterXSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
        }

        public int RasterYSize
        {
            get
            {
                int num = GdalPINVOKE.Dataset_RasterYSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
        }
    }
}

