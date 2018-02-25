namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class Band : MajorObject
    {
        private HandleRef swigCPtr;

        public Band(IntPtr cPtr, bool cMemoryOwn, object parent) : base(GdalPINVOKE.BandUpcast(cPtr), cMemoryOwn, parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public int Checksum(int xoff, int yoff, ref int xsize, ref int ysize)
        {
            int num = GdalPINVOKE.Band_Checksum(this.swigCPtr, xoff, yoff, (IntPtr) xsize, (IntPtr) ysize);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void ComputeBandStats(double[] argout, int samplestep)
        {
            GdalPINVOKE.Band_ComputeBandStats(this.swigCPtr, argout, samplestep);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void ComputeRasterMinMax(double[] argout, int approx_ok)
        {
            GdalPINVOKE.Band_ComputeRasterMinMax(this.swigCPtr, argout, approx_ok);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public CPLErr ComputeStatistics(bool approx_ok, out double min, out double max, out double mean, out double stddev, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_ComputeStatistics(this.swigCPtr, approx_ok, out min, out max, out mean, out stddev, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr CreateMaskBand(int nFlags)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_CreateMaskBand(this.swigCPtr, nFlags);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr DeleteNoDataValue()
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_DeleteNoDataValue(this.swigCPtr);
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
                    throw new MethodAccessException("C++ destructor does not have public access");
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public CPLErr Fill(double real_fill, double imag_fill)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_Fill(this.swigCPtr, real_fill, imag_fill);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public void FlushCache()
        {
            GdalPINVOKE.Band_FlushCache(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public int GetBand()
        {
            int num = GdalPINVOKE.Band_GetBand(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetBlockSize(out int pnBlockXSize, out int pnBlockYSize)
        {
            GdalPINVOKE.Band_GetBlockSize(this.swigCPtr, out pnBlockXSize, out pnBlockYSize);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public string[] GetCategoryNames()
        {
            IntPtr ptr = GdalPINVOKE.Band_GetCategoryNames(this.swigCPtr);
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

        public ColorInterp GetColorInterpretation()
        {
            ColorInterp interp = (ColorInterp) GdalPINVOKE.Band_GetColorInterpretation(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return interp;
        }

        public ColorTable GetColorTable()
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetColorTable(this.swigCPtr);
            ColorTable table = (cPtr == IntPtr.Zero) ? null : new ColorTable(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public static HandleRef getCPtr(Band obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(Band obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(Band obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public Dataset GetDataset()
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetDataset(this.swigCPtr);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public CPLErr GetDefaultHistogram(out double min_ret, out double max_ret, out int buckets_ret, out int[] ppanHistogram, int force, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_GetDefaultHistogram(this.swigCPtr, out min_ret, out max_ret, out buckets_ret, out ppanHistogram, force, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public RasterAttributeTable GetDefaultRAT()
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetDefaultRAT(this.swigCPtr);
            RasterAttributeTable table = (cPtr == IntPtr.Zero) ? null : new RasterAttributeTable(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public CPLErr GetHistogram(double min, double max, int buckets, int[] panHistogram, int include_out_of_range, int approx_ok, Gdal.GDALProgressFuncDelegate callback, string callback_data)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_GetHistogram(this.swigCPtr, min, max, buckets, panHistogram, include_out_of_range, approx_ok, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public Band GetMaskBand()
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetMaskBand(this.swigCPtr);
            Band band = (cPtr == IntPtr.Zero) ? null : new Band(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return band;
        }

        public int GetMaskFlags()
        {
            int num = GdalPINVOKE.Band_GetMaskFlags(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void GetMaximum(out double val, out int hasval)
        {
            GdalPINVOKE.Band_GetMaximum(this.swigCPtr, out val, out hasval);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetMinimum(out double val, out int hasval)
        {
            GdalPINVOKE.Band_GetMinimum(this.swigCPtr, out val, out hasval);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetNoDataValue(out double val, out int hasval)
        {
            GdalPINVOKE.Band_GetNoDataValue(this.swigCPtr, out val, out hasval);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void GetOffset(out double val, out int hasval)
        {
            GdalPINVOKE.Band_GetOffset(this.swigCPtr, out val, out hasval);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public Band GetOverview(int i)
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetOverview(this.swigCPtr, i);
            Band band = (cPtr == IntPtr.Zero) ? null : new Band(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return band;
        }

        public int GetOverviewCount()
        {
            int num = GdalPINVOKE.Band_GetOverviewCount(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string[] GetRasterCategoryNames()
        {
            IntPtr ptr = GdalPINVOKE.Band_GetRasterCategoryNames(this.swigCPtr);
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

        public ColorInterp GetRasterColorInterpretation()
        {
            ColorInterp interp = (ColorInterp) GdalPINVOKE.Band_GetRasterColorInterpretation(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return interp;
        }

        public ColorTable GetRasterColorTable()
        {
            IntPtr cPtr = GdalPINVOKE.Band_GetRasterColorTable(this.swigCPtr);
            ColorTable table = (cPtr == IntPtr.Zero) ? null : new ColorTable(cPtr, false, base.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public void GetScale(out double val, out int hasval)
        {
            GdalPINVOKE.Band_GetScale(this.swigCPtr, out val, out hasval);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public CPLErr GetStatistics(int approx_ok, int force, out double min, out double max, out double mean, out double stddev)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_GetStatistics(this.swigCPtr, approx_ok, force, out min, out max, out mean, out stddev);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public string GetUnitType()
        {
            string str = GdalPINVOKE.Band_GetUnitType(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public bool HasArbitraryOverviews()
        {
            bool flag = GdalPINVOKE.Band_HasArbitraryOverviews(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Byte, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float64, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int16, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int32, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float32, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, OSGeo.GDAL.DataType buf_type, int pixelSpace, int lineSpace)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_ReadRaster__SWIG_0(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, pixelSpace, lineSpace);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Byte, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float64, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int16, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int32, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.ReadRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float32, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr ReadRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, OSGeo.GDAL.DataType buf_type, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_ReadRaster__SWIG_1(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, pixelSpace, lineSpace, RasterIOExtraArg.getCPtr(extraArg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetCategoryNames(string[] papszCategoryNames)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetCategoryNames(this.swigCPtr, (papszCategoryNames != null) ? new GdalPINVOKE.StringListMarshal(papszCategoryNames)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetColorInterpretation(ColorInterp val)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetColorInterpretation(this.swigCPtr, (int) val);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int SetColorTable(ColorTable arg)
        {
            int num = GdalPINVOKE.Band_SetColorTable(this.swigCPtr, ColorTable.getCPtr(arg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr SetDefaultHistogram(double min, double max, int buckets_in, int[] panHistogram_in)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetDefaultHistogram(this.swigCPtr, min, max, buckets_in, panHistogram_in);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int SetDefaultRAT(RasterAttributeTable table)
        {
            int num = GdalPINVOKE.Band_SetDefaultRAT(this.swigCPtr, RasterAttributeTable.getCPtr(table));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr SetNoDataValue(double d)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetNoDataValue(this.swigCPtr, d);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetOffset(double val)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetOffset(this.swigCPtr, val);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetRasterCategoryNames(string[] names)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetRasterCategoryNames(this.swigCPtr, (names != null) ? new GdalPINVOKE.StringListMarshal(names)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetRasterColorInterpretation(ColorInterp val)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetRasterColorInterpretation(this.swigCPtr, (int) val);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public int SetRasterColorTable(ColorTable arg)
        {
            int num = GdalPINVOKE.Band_SetRasterColorTable(this.swigCPtr, ColorTable.getCPtr(arg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public CPLErr SetScale(double val)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetScale(this.swigCPtr, val);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetStatistics(double min, double max, double mean, double stddev)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetStatistics(this.swigCPtr, min, max, mean, stddev);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr SetUnitType(string val)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_SetUnitType(this.swigCPtr, val);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Byte, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float64, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int16, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int32, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float32, pixelSpace, lineSpace);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, OSGeo.GDAL.DataType buf_type, int pixelSpace, int lineSpace)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_WriteRaster__SWIG_0(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, pixelSpace, lineSpace);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, byte[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Byte, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, double[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float64, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, short[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int16, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, int[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Int32, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, float[] buffer, int buf_xSize, int buf_ySize, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err;
            GCHandle handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            try
            {
                err = this.WriteRaster(xOff, yOff, xSize, ySize, handle.AddrOfPinnedObject(), buf_xSize, buf_ySize, OSGeo.GDAL.DataType.GDT_Float32, pixelSpace, lineSpace, extraArg);
            }
            finally
            {
                handle.Free();
            }
            GC.KeepAlive(this);
            return err;
        }

        public CPLErr WriteRaster(int xOff, int yOff, int xSize, int ySize, IntPtr buffer, int buf_xSize, int buf_ySize, OSGeo.GDAL.DataType buf_type, int pixelSpace, int lineSpace, RasterIOExtraArg extraArg)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.Band_WriteRaster__SWIG_1(this.swigCPtr, xOff, yOff, xSize, ySize, buffer, buf_xSize, buf_ySize, (int) buf_type, pixelSpace, lineSpace, RasterIOExtraArg.getCPtr(extraArg));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public OSGeo.GDAL.DataType DataType
        {
            get
            {
                OSGeo.GDAL.DataType type = (OSGeo.GDAL.DataType) GdalPINVOKE.Band_DataType_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return type;
            }
        }

        public int XSize
        {
            get
            {
                int num = GdalPINVOKE.Band_XSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
        }

        public int YSize
        {
            get
            {
                int num = GdalPINVOKE.Band_YSize_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return num;
            }
        }
    }
}

