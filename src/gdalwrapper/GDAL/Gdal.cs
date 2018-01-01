namespace OSGeo.GDAL
{
    using OSGeo.OGR;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    public class Gdal
    {
        internal static GdalObject theGdalObject = new GdalObject();

        internal static IntPtr __AllocCArray_GDAL_GCP(int size)
        {
            IntPtr ptr = GdalPINVOKE.__AllocCArray_GDAL_GCP(size);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        internal static void __FreeCArray_GDAL_GCP(IntPtr carray)
        {
            GdalPINVOKE.__FreeCArray_GDAL_GCP(carray);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        internal static GCP __ReadCArrayItem_GDAL_GCP(IntPtr carray, int index)
        {
            IntPtr cPtr = GdalPINVOKE.__ReadCArrayItem_GDAL_GCP(carray, index);
            GCP gcp = (cPtr == IntPtr.Zero) ? null : new GCP(cPtr, false, ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return gcp;
        }

        internal static void __WriteCArrayItem_GDAL_GCP(IntPtr carray, int index, GCP value)
        {
            GdalPINVOKE.__WriteCArrayItem_GDAL_GCP(carray, index, GCP.getCPtr(value));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void AllRegister()
        {
            GdalPINVOKE.AllRegister();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void ApplyGeoTransform(double[] padfGeoTransform, double dfPixel, double dfLine, out double pdfGeoX, out double pdfGeoY)
        {
            GdalPINVOKE.ApplyGeoTransform(padfGeoTransform, dfPixel, dfLine, out pdfGeoX, out pdfGeoY);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static Dataset ApplyVerticalShiftGrid(Dataset src_ds, Dataset grid_ds, bool inverse, double srcUnitToMeter, double dstUnitToMeter, string[] options)
        {
            IntPtr cPtr = GdalPINVOKE.ApplyVerticalShiftGrid(Dataset.getCPtr(src_ds), Dataset.getCPtr(grid_ds), inverse, srcUnitToMeter, dstUnitToMeter, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset AutoCreateWarpedVRT(Dataset src_ds, string src_wkt, string dst_wkt, ResampleAlg eResampleAlg, double maxerror)
        {
            IntPtr cPtr = GdalPINVOKE.AutoCreateWarpedVRT(Dataset.getCPtr(src_ds), src_wkt, dst_wkt, (int) eResampleAlg, maxerror);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static int ComputeMedianCutPCT(Band red, Band green, Band blue, int num_colors, ColorTable colors, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.ComputeMedianCutPCT(Band.getCPtr(red), Band.getCPtr(green), Band.getCPtr(blue), num_colors, ColorTable.getCPtr(colors), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int ComputeProximity(Band srcBand, Band proximityBand, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.ComputeProximity(Band.getCPtr(srcBand), Band.getCPtr(proximityBand), (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int ContourGenerate(Band srcBand, double contourInterval, double contourBase, int fixedLevelCount, double[] fixedLevels, int useNoData, double noDataValue, Layer dstLayer, int idField, int elevField, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.ContourGenerate(Band.getCPtr(srcBand), contourInterval, contourBase, fixedLevelCount, fixedLevels, useNoData, noDataValue, Layer.getCPtr(dstLayer), idField, elevField, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string CPLBinaryToHex(int nBytes, IntPtr pabyData)
        {
            string str = GdalPINVOKE.CPLBinaryToHex(nBytes, pabyData);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static IntPtr CPLHexToBinary(string pszHex, out int pnBytes)
        {
            IntPtr ptr = GdalPINVOKE.CPLHexToBinary(pszHex, out pnBytes);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        public static Dataset CreatePansharpenedVRT(string pszXML, Band panchroBand, int nInputSpectralBands, SWIGTYPE_p_p_GDALRasterBandShadow ahInputSpectralBands)
        {
            IntPtr cPtr = GdalPINVOKE.CreatePansharpenedVRT(pszXML, Band.getCPtr(panchroBand), nInputSpectralBands, SWIGTYPE_p_p_GDALRasterBandShadow.getCPtr(ahInputSpectralBands));
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static int DataTypeIsComplex(DataType eDataType)
        {
            int num = GdalPINVOKE.DataTypeIsComplex((int) eDataType);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void Debug(string msg_class, string message)
        {
            GdalPINVOKE.Debug(msg_class, message);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static string DecToDMS(double arg0, string arg1, int arg2)
        {
            string str = GdalPINVOKE.DecToDMS(arg0, arg1, arg2);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static double DecToPackedDMS(double dfDec)
        {
            double num = GdalPINVOKE.DecToPackedDMS(dfDec);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int DitherRGB2PCT(Band red, Band green, Band blue, Band target, ColorTable colors, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.DitherRGB2PCT(Band.getCPtr(red), Band.getCPtr(green), Band.getCPtr(blue), Band.getCPtr(target), ColorTable.getCPtr(colors), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void DontUseExceptions()
        {
            GdalPINVOKE.DontUseExceptions();
        }

        public static void Error(CPLErr msg_class, int err_code, string msg)
        {
            GdalPINVOKE.Error((int) msg_class, err_code, msg);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void ErrorReset()
        {
            GdalPINVOKE.ErrorReset();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static string EscapeString(int len, string bin_string, int scheme)
        {
            string str = GdalPINVOKE.EscapeString(len, bin_string, scheme);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static void FileFromMemBuffer(string utf8_path, byte[] bytes)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            try
            {
                FileFromMemBuffer(utf8_path, bytes.Length, handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        public static void FileFromMemBuffer(string utf8_path, int nBytes, IntPtr pabyData)
        {
            GdalPINVOKE.FileFromMemBuffer(StringToUtf8Bytes(utf8_path), nBytes, pabyData);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static int FillNodata(Band targetBand, Band maskBand, double maxSearchDist, int smoothingIterations, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.FillNodata(Band.getCPtr(targetBand), Band.getCPtr(maskBand), maxSearchDist, smoothingIterations, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void FinderClean()
        {
            GdalPINVOKE.FinderClean();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static string FindFile(string pszClass, string utf8_path)
        {
            string str = GdalPINVOKE.FindFile(pszClass, StringToUtf8Bytes(utf8_path));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static int FPolygonize(Band srcBand, Band maskBand, Layer outLayer, int iPixValField, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.FPolygonize(Band.getCPtr(srcBand), Band.getCPtr(maskBand), Layer.getCPtr(outLayer), iPixValField, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GCPsToGeoTransform(GCP[] pGCPs, double[] argout, int bApproxOK)
        {
            int num = 0;
            if ((pGCPs != null) && (pGCPs.Length > 0))
            {
                IntPtr carray = __AllocCArray_GDAL_GCP(pGCPs.Length);
                if (carray == IntPtr.Zero)
                {
                    throw new ApplicationException("Error allocating CArray with __AllocCArray_GDAL_GCP");
                }
                try
                {
                    for (int i = 0; i < pGCPs.Length; i++)
                    {
                        __WriteCArrayItem_GDAL_GCP(carray, i, pGCPs[i]);
                    }
                    num = GCPsToGeoTransform(pGCPs.Length, carray, argout, bApproxOK);
                }
                finally
                {
                    __FreeCArray_GDAL_GCP(carray);
                }
            }
            return num;
        }

        private static int GCPsToGeoTransform(int nGCPs, IntPtr pGCPs, double[] argout, int bApproxOK)
        {
            int num = GdalPINVOKE.GCPsToGeoTransform(nGCPs, pGCPs, argout, bApproxOK);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static double GDAL_GCP_GCPLine_get(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_GCPLine_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void GDAL_GCP_GCPLine_set(GCP gcp, double dfGCPLine)
        {
            GdalPINVOKE.GDAL_GCP_GCPLine_set(GCP.getCPtr(gcp), dfGCPLine);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static double GDAL_GCP_GCPPixel_get(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_GCPPixel_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void GDAL_GCP_GCPPixel_set(GCP gcp, double dfGCPPixel)
        {
            GdalPINVOKE.GDAL_GCP_GCPPixel_set(GCP.getCPtr(gcp), dfGCPPixel);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static double GDAL_GCP_GCPX_get(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_GCPX_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void GDAL_GCP_GCPX_set(GCP gcp, double dfGCPX)
        {
            GdalPINVOKE.GDAL_GCP_GCPX_set(GCP.getCPtr(gcp), dfGCPX);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static double GDAL_GCP_GCPY_get(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_GCPY_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void GDAL_GCP_GCPY_set(GCP gcp, double dfGCPY)
        {
            GdalPINVOKE.GDAL_GCP_GCPY_set(GCP.getCPtr(gcp), dfGCPY);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static double GDAL_GCP_GCPZ_get(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_GCPZ_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void GDAL_GCP_GCPZ_set(GCP gcp, double dfGCPZ)
        {
            GdalPINVOKE.GDAL_GCP_GCPZ_set(GCP.getCPtr(gcp), dfGCPZ);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static double GDAL_GCP_get_GCPLine(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_get_GCPLine(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static double GDAL_GCP_get_GCPPixel(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_get_GCPPixel(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static double GDAL_GCP_get_GCPX(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_get_GCPX(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static double GDAL_GCP_get_GCPY(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_get_GCPY(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static double GDAL_GCP_get_GCPZ(GCP gcp)
        {
            double num = GdalPINVOKE.GDAL_GCP_get_GCPZ(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string GDAL_GCP_get_Id(GCP gcp)
        {
            string str = GdalPINVOKE.GDAL_GCP_get_Id(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string GDAL_GCP_get_Info(GCP gcp)
        {
            string str = GdalPINVOKE.GDAL_GCP_get_Info(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string GDAL_GCP_Id_get(GCP gcp)
        {
            string str = GdalPINVOKE.GDAL_GCP_Id_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static void GDAL_GCP_Id_set(GCP gcp, string pszId)
        {
            GdalPINVOKE.GDAL_GCP_Id_set(GCP.getCPtr(gcp), pszId);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static string GDAL_GCP_Info_get(GCP gcp)
        {
            string str = GdalPINVOKE.GDAL_GCP_Info_get(GCP.getCPtr(gcp));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static void GDAL_GCP_Info_set(GCP gcp, string pszInfo)
        {
            GdalPINVOKE.GDAL_GCP_Info_set(GCP.getCPtr(gcp), pszInfo);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_GCPLine(GCP gcp, double dfGCPLine)
        {
            GdalPINVOKE.GDAL_GCP_set_GCPLine(GCP.getCPtr(gcp), dfGCPLine);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_GCPPixel(GCP gcp, double dfGCPPixel)
        {
            GdalPINVOKE.GDAL_GCP_set_GCPPixel(GCP.getCPtr(gcp), dfGCPPixel);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_GCPX(GCP gcp, double dfGCPX)
        {
            GdalPINVOKE.GDAL_GCP_set_GCPX(GCP.getCPtr(gcp), dfGCPX);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_GCPY(GCP gcp, double dfGCPY)
        {
            GdalPINVOKE.GDAL_GCP_set_GCPY(GCP.getCPtr(gcp), dfGCPY);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_GCPZ(GCP gcp, double dfGCPZ)
        {
            GdalPINVOKE.GDAL_GCP_set_GCPZ(GCP.getCPtr(gcp), dfGCPZ);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_Id(GCP gcp, string pszId)
        {
            GdalPINVOKE.GDAL_GCP_set_Id(GCP.getCPtr(gcp), pszId);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDAL_GCP_set_Info(GCP gcp, string pszInfo)
        {
            GdalPINVOKE.GDAL_GCP_set_Info(GCP.getCPtr(gcp), pszInfo);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void GDALDestroyDriverManager()
        {
            GdalPINVOKE.GDALDestroyDriverManager();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static string GDALInfo(Dataset hDataset, GDALInfoOptions infoOptions)
        {
            string str = GdalPINVOKE.GDALInfo(Dataset.getCPtr(hDataset), GDALInfoOptions.getCPtr(infoOptions));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string[] GeneralCmdLineProcessor(string[] papszArgv, int nOptions)
        {
            IntPtr ptr = GdalPINVOKE.GeneralCmdLineProcessor((papszArgv != null) ? new GdalPINVOKE.StringListMarshal(papszArgv)._ar : null, nOptions);
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

        public static int GetCacheMax()
        {
            int cacheMax = GdalPINVOKE.GetCacheMax();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return cacheMax;
        }

        public static int GetCacheUsed()
        {
            int cacheUsed = GdalPINVOKE.GetCacheUsed();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return cacheUsed;
        }

        public static string GetColorInterpretationName(ColorInterp eColorInterp)
        {
            string colorInterpretationName = GdalPINVOKE.GetColorInterpretationName((int) eColorInterp);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return colorInterpretationName;
        }

        public static string GetConfigOption(string pszKey, string pszDefault)
        {
            string configOption = GdalPINVOKE.GetConfigOption(pszKey, pszDefault);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return configOption;
        }

        public static DataType GetDataTypeByName(string pszDataTypeName)
        {
            DataType dataTypeByName = (DataType) GdalPINVOKE.GetDataTypeByName(pszDataTypeName);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataTypeByName;
        }

        public static string GetDataTypeName(DataType eDataType)
        {
            string dataTypeName = GdalPINVOKE.GetDataTypeName((int) eDataType);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataTypeName;
        }

        public static int GetDataTypeSize(DataType eDataType)
        {
            int dataTypeSize = GdalPINVOKE.GetDataTypeSize((int) eDataType);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataTypeSize;
        }

        public static OSGeo.GDAL.Driver GetDriver(int i)
        {
            IntPtr cPtr = GdalPINVOKE.GetDriver(i);
            OSGeo.GDAL.Driver driver = (cPtr == IntPtr.Zero) ? null : new OSGeo.GDAL.Driver(cPtr, false, ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static OSGeo.GDAL.Driver GetDriverByName(string name)
        {
            IntPtr driverByName = GdalPINVOKE.GetDriverByName(name);
            OSGeo.GDAL.Driver driver = (driverByName == IntPtr.Zero) ? null : new OSGeo.GDAL.Driver(driverByName, false, ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static int GetDriverCount()
        {
            int driverCount = GdalPINVOKE.GetDriverCount();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driverCount;
        }

        public static string GetJPEG2000StructureAsString(string pszFilename, string[] options)
        {
            string str = GdalPINVOKE.GetJPEG2000StructureAsString(pszFilename, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string GetLastErrorMsg()
        {
            string lastErrorMsg = GdalPINVOKE.GetLastErrorMsg();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return lastErrorMsg;
        }

        public static int GetLastErrorNo()
        {
            int lastErrorNo = GdalPINVOKE.GetLastErrorNo();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return lastErrorNo;
        }

        public static int GetLastErrorType()
        {
            int lastErrorType = GdalPINVOKE.GetLastErrorType();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return lastErrorType;
        }

        public static string GetPaletteInterpretationName(PaletteInterp ePaletteInterp)
        {
            string paletteInterpretationName = GdalPINVOKE.GetPaletteInterpretationName((int) ePaletteInterp);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return paletteInterpretationName;
        }

        public static string GOA2GetAccessToken(string pszRefreshToken, string pszScope)
        {
            string str = GdalPINVOKE.GOA2GetAccessToken(pszRefreshToken, pszScope);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string GOA2GetAuthorizationURL(string pszScope)
        {
            string str = GdalPINVOKE.GOA2GetAuthorizationURL(pszScope);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static string GOA2GetRefreshToken(string pszAuthToken, string pszScope)
        {
            string str = GdalPINVOKE.GOA2GetRefreshToken(pszAuthToken, pszScope);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static int HasThreadSupport()
        {
            int num = GdalPINVOKE.HasThreadSupport();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static OSGeo.GDAL.Driver IdentifyDriver(string utf8_path, string[] papszSiblings)
        {
            IntPtr cPtr = GdalPINVOKE.IdentifyDriver(StringToUtf8Bytes(utf8_path), (papszSiblings != null) ? new GdalPINVOKE.StringListMarshal(papszSiblings)._ar : null);
            OSGeo.GDAL.Driver driver = (cPtr == IntPtr.Zero) ? null : new OSGeo.GDAL.Driver(cPtr, false, ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static OSGeo.GDAL.Driver IdentifyDriverEx(string utf8_path, uint nIdentifyFlags, string[] allowed_drivers, string[] sibling_files)
        {
            IntPtr cPtr = GdalPINVOKE.IdentifyDriverEx(StringToUtf8Bytes(utf8_path), nIdentifyFlags, (allowed_drivers != null) ? new GdalPINVOKE.StringListMarshal(allowed_drivers)._ar : null, (sibling_files != null) ? new GdalPINVOKE.StringListMarshal(sibling_files)._ar : null);
            OSGeo.GDAL.Driver driver = (cPtr == IntPtr.Zero) ? null : new OSGeo.GDAL.Driver(cPtr, false, ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static int InvGeoTransform(double[] gt_in, double[] gt_out)
        {
            int num = GdalPINVOKE.InvGeoTransform(gt_in, gt_out);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int Mkdir(string utf8_path, int mode)
        {
            int num = GdalPINVOKE.Mkdir(StringToUtf8Bytes(utf8_path), mode);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset Open(string utf8_path, Access eAccess)
        {
            IntPtr cPtr = GdalPINVOKE.Open(StringToUtf8Bytes(utf8_path), (int) eAccess);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset OpenEx(string utf8_path, uint nOpenFlags, string[] allowed_drivers, string[] open_options, string[] sibling_files)
        {
            IntPtr cPtr = GdalPINVOKE.OpenEx(StringToUtf8Bytes(utf8_path), nOpenFlags, (allowed_drivers != null) ? new GdalPINVOKE.StringListMarshal(allowed_drivers)._ar : null, (open_options != null) ? new GdalPINVOKE.StringListMarshal(open_options)._ar : null, (sibling_files != null) ? new GdalPINVOKE.StringListMarshal(sibling_files)._ar : null);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset OpenShared(string utf8_path, Access eAccess)
        {
            IntPtr cPtr = GdalPINVOKE.OpenShared(StringToUtf8Bytes(utf8_path), (int) eAccess);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static double PackedDMSToDec(double dfPacked)
        {
            double num = GdalPINVOKE.PackedDMSToDec(dfPacked);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string[] ParseCommandLine(string utf8_path)
        {
            IntPtr ptr = GdalPINVOKE.ParseCommandLine(StringToUtf8Bytes(utf8_path));
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

        public static XMLNode ParseXMLString(string pszXMLString)
        {
            IntPtr cPtr = GdalPINVOKE.ParseXMLString(pszXMLString);
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public static int Polygonize(Band srcBand, Band maskBand, Layer outLayer, int iPixValField, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.Polygonize(Band.getCPtr(srcBand), Band.getCPtr(maskBand), Layer.getCPtr(outLayer), iPixValField, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void PopErrorHandler()
        {
            GdalPINVOKE.PopErrorHandler();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void PopFinderLocation()
        {
            GdalPINVOKE.PopFinderLocation();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void PushErrorHandler(GDALErrorHandlerDelegate arg0)
        {
            GdalPINVOKE.PushErrorHandler__SWIG_1(arg0);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static CPLErr PushErrorHandler(string pszCallbackName)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.PushErrorHandler__SWIG_0(pszCallbackName);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public static void PushFinderLocation(string utf8_path)
        {
            GdalPINVOKE.PushFinderLocation(StringToUtf8Bytes(utf8_path));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static int RasterizeLayer(Dataset dataset, int bands, int[] band_list, Layer layer, IntPtr pfnTransformer, IntPtr pTransformArg, int burn_values, double[] burn_values_list, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.RasterizeLayer(Dataset.getCPtr(dataset), bands, band_list, Layer.getCPtr(layer), pfnTransformer, pTransformArg, burn_values, burn_values_list, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string[] ReadDir(string utf8_path, int nMaxFiles)
        {
            IntPtr ptr = GdalPINVOKE.ReadDir(StringToUtf8Bytes(utf8_path), nMaxFiles);
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

        public static string[] ReadDirRecursive(string utf8_path)
        {
            IntPtr ptr = GdalPINVOKE.ReadDirRecursive(StringToUtf8Bytes(utf8_path));
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

        public static int RegenerateOverview(Band srcBand, Band overviewBand, string resampling, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.RegenerateOverview(Band.getCPtr(srcBand), Band.getCPtr(overviewBand), resampling, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int RegenerateOverviews(Band srcBand, int overviewBandCount, SWIGTYPE_p_p_GDALRasterBandShadow overviewBands, string resampling, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.RegenerateOverviews(Band.getCPtr(srcBand), overviewBandCount, SWIGTYPE_p_p_GDALRasterBandShadow.getCPtr(overviewBands), resampling, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int Rename(string pszOld, string pszNew)
        {
            int num = GdalPINVOKE.Rename(StringToUtf8Bytes(pszOld), StringToUtf8Bytes(pszNew));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static CPLErr ReprojectImage(Dataset src_ds, Dataset dst_ds, string src_wkt, string dst_wkt, ResampleAlg eResampleAlg, double WarpMemoryLimit, double maxerror, GDALProgressFuncDelegate callback, string callback_data, string[] options)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.ReprojectImage(Dataset.getCPtr(src_ds), Dataset.getCPtr(dst_ds), src_wkt, dst_wkt, (int) eResampleAlg, WarpMemoryLimit, maxerror, callback, callback_data, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public static int Rmdir(string utf8_path)
        {
            int num = GdalPINVOKE.Rmdir(StringToUtf8Bytes(utf8_path));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string SerializeXMLTree(XMLNode xmlnode)
        {
            string str = GdalPINVOKE.SerializeXMLTree(XMLNode.getCPtr(xmlnode));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static void SetCacheMax(int nBytes)
        {
            GdalPINVOKE.SetCacheMax(nBytes);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static void SetConfigOption(string pszKey, string pszValue)
        {
            GdalPINVOKE.SetConfigOption(pszKey, pszValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static CPLErr SetErrorHandler(string pszCallbackName)
        {
            CPLErr err = (CPLErr) GdalPINVOKE.SetErrorHandler(pszCallbackName);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return err;
        }

        public static int SieveFilter(Band srcBand, Band maskBand, Band dstBand, int threshold, int connectedness, string[] options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.SieveFilter(Band.getCPtr(srcBand), Band.getCPtr(maskBand), Band.getCPtr(dstBand), threshold, connectedness, (options != null) ? new GdalPINVOKE.StringListMarshal(options)._ar : null, callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        internal static void StringListDestroy(IntPtr buffer_ptr)
        {
            GdalPINVOKE.StringListDestroy(buffer_ptr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        internal static byte[] StringToUtf8Bytes(string str)
        {
            if (str == null)
            {
                return null;
            }
            byte[] bytes = new byte[Encoding.UTF8.GetMaxByteCount(str.Length) + 1];
            Encoding.UTF8.GetBytes(str, 0, str.Length, bytes, 0);
            return bytes;
        }

        protected static object ThisOwn_false()
        {
            return theGdalObject;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public static int Unlink(string utf8_path)
        {
            int num = GdalPINVOKE.Unlink(StringToUtf8Bytes(utf8_path));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void UseExceptions()
        {
            GdalPINVOKE.UseExceptions();
        }

        internal static string Utf8BytesToString(IntPtr pNativeData)
        {
            if (pNativeData == IntPtr.Zero)
            {
                return null;
            }
            int length = Marshal.PtrToStringAnsi(pNativeData).Length;
            byte[] destination = new byte[length];
            Marshal.Copy(pNativeData, destination, 0, length);
            return Encoding.UTF8.GetString(destination);
        }

        public static string VersionInfo(string request)
        {
            string str = GdalPINVOKE.VersionInfo(request);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static void VSICurlClearCache()
        {
            GdalPINVOKE.VSICurlClearCache();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static int VSIFCloseL(IntPtr fp)
        {
            int num = GdalPINVOKE.VSIFCloseL(fp);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static IntPtr VSIFOpenExL(string utf8_path, string pszMode, int bSetError)
        {
            IntPtr ptr = GdalPINVOKE.VSIFOpenExL(StringToUtf8Bytes(utf8_path), pszMode, bSetError);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        public static IntPtr VSIFOpenL(string utf8_path, string pszMode)
        {
            IntPtr ptr = GdalPINVOKE.VSIFOpenL(StringToUtf8Bytes(utf8_path), pszMode);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return ptr;
        }

        public static int VSIFSeekL(IntPtr fp, int offset, int whence)
        {
            int num = GdalPINVOKE.VSIFSeekL(fp, offset, whence);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int VSIFTellL(IntPtr fp)
        {
            int num = GdalPINVOKE.VSIFTellL(fp);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int VSIFTruncateL(IntPtr fp, int length)
        {
            int num = GdalPINVOKE.VSIFTruncateL(fp, length);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int VSIFWriteL(string arg0, int arg1, int arg2, IntPtr fp)
        {
            int num = GdalPINVOKE.VSIFWriteL(arg0, arg1, arg2, fp);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static string VSIGetLastErrorMsg()
        {
            string str = GdalPINVOKE.VSIGetLastErrorMsg();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static int VSIGetLastErrorNo()
        {
            int num = GdalPINVOKE.VSIGetLastErrorNo();
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset wrapper_GDALBuildVRT_names(string dest, string[] source_filenames, GDALBuildVRTOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALBuildVRT_names(StringToUtf8Bytes(dest), (source_filenames != null) ? new GdalPINVOKE.StringListMarshal(source_filenames)._ar : null, GDALBuildVRTOptions.getCPtr(options), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset wrapper_GDALBuildVRT_objects(string dest, int object_list_count, SWIGTYPE_p_p_GDALDatasetShadow poObjects, GDALBuildVRTOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALBuildVRT_objects(StringToUtf8Bytes(dest), object_list_count, SWIGTYPE_p_p_GDALDatasetShadow.getCPtr(poObjects), GDALBuildVRTOptions.getCPtr(options), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset wrapper_GDALDEMProcessing(string dest, Dataset dataset, string pszProcessing, string pszColorFilename, GDALDEMProcessingOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALDEMProcessing(StringToUtf8Bytes(dest), Dataset.getCPtr(dataset), pszProcessing, pszColorFilename, GDALDEMProcessingOptions.getCPtr(options), callback, callback_data);
            Dataset dataset2 = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset2;
        }

        public static Dataset wrapper_GDALGrid(string dest, Dataset dataset, GDALGridOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALGrid(StringToUtf8Bytes(dest), Dataset.getCPtr(dataset), GDALGridOptions.getCPtr(options), callback, callback_data);
            Dataset dataset2 = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset2;
        }

        public static int wrapper_GDALNearblackDestDS(Dataset dstDS, Dataset srcDS, GDALNearblackOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.wrapper_GDALNearblackDestDS(Dataset.getCPtr(dstDS), Dataset.getCPtr(srcDS), GDALNearblackOptions.getCPtr(options), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset wrapper_GDALNearblackDestName(string dest, Dataset srcDS, GDALNearblackOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALNearblackDestName(StringToUtf8Bytes(dest), Dataset.getCPtr(srcDS), GDALNearblackOptions.getCPtr(options), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static int wrapper_GDALRasterizeDestDS(Dataset dstDS, Dataset srcDS, GDALRasterizeOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.wrapper_GDALRasterizeDestDS(Dataset.getCPtr(dstDS), Dataset.getCPtr(srcDS), GDALRasterizeOptions.getCPtr(options), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset wrapper_GDALRasterizeDestName(string dest, Dataset srcDS, GDALRasterizeOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALRasterizeDestName(StringToUtf8Bytes(dest), Dataset.getCPtr(srcDS), GDALRasterizeOptions.getCPtr(options), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static Dataset wrapper_GDALTranslate(string dest, Dataset dataset, GDALTranslateOptions translateOptions, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALTranslate(StringToUtf8Bytes(dest), Dataset.getCPtr(dataset), GDALTranslateOptions.getCPtr(translateOptions), callback, callback_data);
            Dataset dataset2 = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset2;
        }

        public static int wrapper_GDALVectorTranslateDestDS(Dataset dstDS, Dataset srcDS, GDALVectorTranslateOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.wrapper_GDALVectorTranslateDestDS(Dataset.getCPtr(dstDS), Dataset.getCPtr(srcDS), GDALVectorTranslateOptions.getCPtr(options), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset wrapper_GDALVectorTranslateDestName(string dest, Dataset srcDS, GDALVectorTranslateOptions options, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALVectorTranslateDestName(StringToUtf8Bytes(dest), Dataset.getCPtr(srcDS), GDALVectorTranslateOptions.getCPtr(options), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public static int wrapper_GDALWarpDestDS(Dataset dstDS, int object_list_count, SWIGTYPE_p_p_GDALDatasetShadow poObjects, GDALWarpAppOptions warpAppOptions, GDALProgressFuncDelegate callback, string callback_data)
        {
            int num = GdalPINVOKE.wrapper_GDALWarpDestDS(Dataset.getCPtr(dstDS), object_list_count, SWIGTYPE_p_p_GDALDatasetShadow.getCPtr(poObjects), GDALWarpAppOptions.getCPtr(warpAppOptions), callback, callback_data);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static Dataset wrapper_GDALWarpDestName(string dest, int object_list_count, SWIGTYPE_p_p_GDALDatasetShadow poObjects, GDALWarpAppOptions warpAppOptions, GDALProgressFuncDelegate callback, string callback_data)
        {
            IntPtr cPtr = GdalPINVOKE.wrapper_GDALWarpDestName(StringToUtf8Bytes(dest), object_list_count, SWIGTYPE_p_p_GDALDatasetShadow.getCPtr(poObjects), GDALWarpAppOptions.getCPtr(warpAppOptions), callback, callback_data);
            Dataset dataset = (cPtr == IntPtr.Zero) ? null : new Dataset(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return dataset;
        }

        public delegate void GDALErrorHandlerDelegate(int eclass, int code, IntPtr msg);

        internal class GdalObject : IDisposable
        {
            public virtual void Dispose()
            {
            }
        }

        public delegate int GDALProgressFuncDelegate(double Complete, IntPtr Message, IntPtr Data);
    }
}

