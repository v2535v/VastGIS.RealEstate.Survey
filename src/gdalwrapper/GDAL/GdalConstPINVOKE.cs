namespace OSGeo.GDAL
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class GdalConstPINVOKE
    {
        protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();
        protected static SWIGStringHelper swigStringHelper = new SWIGStringHelper();

        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CE_Debug_get")]
        public static extern int CE_Debug_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CE_Failure_get")]
        public static extern int CE_Failure_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CE_Fatal_get")]
        public static extern int CE_Fatal_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CE_None_get")]
        public static extern int CE_None_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CE_Warning_get")]
        public static extern int CE_Warning_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_AppDefined_get")]
        public static extern int CPLE_AppDefined_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_AssertionFailed_get")]
        public static extern int CPLE_AssertionFailed_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_FileIO_get")]
        public static extern int CPLE_FileIO_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_IllegalArg_get")]
        public static extern int CPLE_IllegalArg_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_None_get")]
        public static extern int CPLE_None_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_NotSupported_get")]
        public static extern int CPLE_NotSupported_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_NoWriteAccess_get")]
        public static extern int CPLE_NoWriteAccess_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_OpenFailed_get")]
        public static extern int CPLE_OpenFailed_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_OutOfMemory_get")]
        public static extern int CPLE_OutOfMemory_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLE_UserInterrupt_get")]
        public static extern int CPLE_UserInterrupt_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLES_BackslashQuotable_get")]
        public static extern int CPLES_BackslashQuotable_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLES_CSV_get")]
        public static extern int CPLES_CSV_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLES_SQL_get")]
        public static extern int CPLES_SQL_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLES_URL_get")]
        public static extern int CPLES_URL_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CPLES_XML_get")]
        public static extern int CPLES_XML_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CXT_Attribute_get")]
        public static extern int CXT_Attribute_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CXT_Comment_get")]
        public static extern int CXT_Comment_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CXT_Element_get")]
        public static extern int CXT_Element_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CXT_Literal_get")]
        public static extern int CXT_Literal_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_CXT_Text_get")]
        public static extern int CXT_Text_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DCAP_DEFAULT_FIELDS_get")]
        public static extern string DCAP_DEFAULT_FIELDS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DCAP_NOTNULL_FIELDS_get")]
        public static extern string DCAP_NOTNULL_FIELDS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DCAP_NOTNULL_GEOMFIELDS_get")]
        public static extern string DCAP_NOTNULL_GEOMFIELDS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DCAP_RASTER_get")]
        public static extern string DCAP_RASTER_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DCAP_VECTOR_get")]
        public static extern string DCAP_VECTOR_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_DMD_CONNECTION_PREFIX_get")]
        public static extern string DMD_CONNECTION_PREFIX_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GA_ReadOnly_get")]
        public static extern int GA_ReadOnly_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GA_Update_get")]
        public static extern int GA_Update_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GARIO_COMPLETE_get")]
        public static extern int GARIO_COMPLETE_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GARIO_ERROR_get")]
        public static extern int GARIO_ERROR_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GARIO_PENDING_get")]
        public static extern int GARIO_PENDING_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GARIO_UPDATE_get")]
        public static extern int GARIO_UPDATE_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_AlphaBand_get")]
        public static extern int GCI_AlphaBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_BlackBand_get")]
        public static extern int GCI_BlackBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_BlueBand_get")]
        public static extern int GCI_BlueBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_CyanBand_get")]
        public static extern int GCI_CyanBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_GrayIndex_get")]
        public static extern int GCI_GrayIndex_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_GreenBand_get")]
        public static extern int GCI_GreenBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_HueBand_get")]
        public static extern int GCI_HueBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_LightnessBand_get")]
        public static extern int GCI_LightnessBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_MagentaBand_get")]
        public static extern int GCI_MagentaBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_PaletteIndex_get")]
        public static extern int GCI_PaletteIndex_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_RedBand_get")]
        public static extern int GCI_RedBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_SaturationBand_get")]
        public static extern int GCI_SaturationBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_Undefined_get")]
        public static extern int GCI_Undefined_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_YCbCr_CbBand_get")]
        public static extern int GCI_YCbCr_CbBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_YCbCr_CrBand_get")]
        public static extern int GCI_YCbCr_CrBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_YCbCr_YBand_get")]
        public static extern int GCI_YCbCr_YBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GCI_YellowBand_get")]
        public static extern int GCI_YellowBand_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DATA_COVERAGE_STATUS_DATA_get")]
        public static extern int GDAL_DATA_COVERAGE_STATUS_DATA_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DATA_COVERAGE_STATUS_EMPTY_get")]
        public static extern int GDAL_DATA_COVERAGE_STATUS_EMPTY_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DATA_COVERAGE_STATUS_UNIMPLEMENTED_get")]
        public static extern int GDAL_DATA_COVERAGE_STATUS_UNIMPLEMENTED_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DCAP_CREATE_get")]
        public static extern string GDAL_DCAP_CREATE_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DCAP_CREATECOPY_get")]
        public static extern string GDAL_DCAP_CREATECOPY_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DCAP_OPEN_get")]
        public static extern string GDAL_DCAP_OPEN_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DCAP_VIRTUALIO_get")]
        public static extern string GDAL_DCAP_VIRTUALIO_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_CREATIONDATATYPES_get")]
        public static extern string GDAL_DMD_CREATIONDATATYPES_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_CREATIONFIELDDATATYPES_get")]
        public static extern string GDAL_DMD_CREATIONFIELDDATATYPES_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_CREATIONOPTIONLIST_get")]
        public static extern string GDAL_DMD_CREATIONOPTIONLIST_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_EXTENSION_get")]
        public static extern string GDAL_DMD_EXTENSION_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_EXTENSIONS_get")]
        public static extern string GDAL_DMD_EXTENSIONS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_HELPTOPIC_get")]
        public static extern string GDAL_DMD_HELPTOPIC_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_LONGNAME_get")]
        public static extern string GDAL_DMD_LONGNAME_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_MIMETYPE_get")]
        public static extern string GDAL_DMD_MIMETYPE_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDAL_DMD_SUBDATASETS_get")]
        public static extern string GDAL_DMD_SUBDATASETS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Byte_get")]
        public static extern int GDT_Byte_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_CFloat32_get")]
        public static extern int GDT_CFloat32_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_CFloat64_get")]
        public static extern int GDT_CFloat64_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_CInt16_get")]
        public static extern int GDT_CInt16_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_CInt32_get")]
        public static extern int GDT_CInt32_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Float32_get")]
        public static extern int GDT_Float32_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Float64_get")]
        public static extern int GDT_Float64_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Int16_get")]
        public static extern int GDT_Int16_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Int32_get")]
        public static extern int GDT_Int32_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_TypeCount_get")]
        public static extern int GDT_TypeCount_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_UInt16_get")]
        public static extern int GDT_UInt16_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_UInt32_get")]
        public static extern int GDT_UInt32_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GDT_Unknown_get")]
        public static extern int GDT_Unknown_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GF_Read_get")]
        public static extern int GF_Read_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GF_Write_get")]
        public static extern int GF_Write_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFT_Integer_get")]
        public static extern int GFT_Integer_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFT_Real_get")]
        public static extern int GFT_Real_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFT_String_get")]
        public static extern int GFT_String_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Alpha_get")]
        public static extern int GFU_Alpha_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_AlphaMax_get")]
        public static extern int GFU_AlphaMax_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_AlphaMin_get")]
        public static extern int GFU_AlphaMin_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Blue_get")]
        public static extern int GFU_Blue_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_BlueMax_get")]
        public static extern int GFU_BlueMax_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_BlueMin_get")]
        public static extern int GFU_BlueMin_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Generic_get")]
        public static extern int GFU_Generic_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Green_get")]
        public static extern int GFU_Green_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_GreenMax_get")]
        public static extern int GFU_GreenMax_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_GreenMin_get")]
        public static extern int GFU_GreenMin_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Max_get")]
        public static extern int GFU_Max_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_MaxCount_get")]
        public static extern int GFU_MaxCount_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Min_get")]
        public static extern int GFU_Min_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_MinMax_get")]
        public static extern int GFU_MinMax_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Name_get")]
        public static extern int GFU_Name_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_PixelCount_get")]
        public static extern int GFU_PixelCount_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_Red_get")]
        public static extern int GFU_Red_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_RedMax_get")]
        public static extern int GFU_RedMax_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GFU_RedMin_get")]
        public static extern int GFU_RedMin_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GMF_ALL_VALID_get")]
        public static extern int GMF_ALL_VALID_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GMF_ALPHA_get")]
        public static extern int GMF_ALPHA_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GMF_NODATA_get")]
        public static extern int GMF_NODATA_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GMF_PER_DATASET_get")]
        public static extern int GMF_PER_DATASET_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GPI_CMYK_get")]
        public static extern int GPI_CMYK_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GPI_Gray_get")]
        public static extern int GPI_Gray_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GPI_HLS_get")]
        public static extern int GPI_HLS_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GPI_RGB_get")]
        public static extern int GPI_RGB_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Average_get")]
        public static extern int GRA_Average_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Bilinear_get")]
        public static extern int GRA_Bilinear_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Cubic_get")]
        public static extern int GRA_Cubic_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_CubicSpline_get")]
        public static extern int GRA_CubicSpline_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Lanczos_get")]
        public static extern int GRA_Lanczos_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Max_get")]
        public static extern int GRA_Max_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Med_get")]
        public static extern int GRA_Med_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Min_get")]
        public static extern int GRA_Min_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Mode_get")]
        public static extern int GRA_Mode_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_NearestNeighbour_get")]
        public static extern int GRA_NearestNeighbour_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Q1_get")]
        public static extern int GRA_Q1_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRA_Q3_get")]
        public static extern int GRA_Q3_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Average_get")]
        public static extern int GRIORA_Average_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Bilinear_get")]
        public static extern int GRIORA_Bilinear_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Cubic_get")]
        public static extern int GRIORA_Cubic_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_CubicSpline_get")]
        public static extern int GRIORA_CubicSpline_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Gauss_get")]
        public static extern int GRIORA_Gauss_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Lanczos_get")]
        public static extern int GRIORA_Lanczos_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_Mode_get")]
        public static extern int GRIORA_Mode_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GRIORA_NearestNeighbour_get")]
        public static extern int GRIORA_NearestNeighbour_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GTO_BIT_get")]
        public static extern int GTO_BIT_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GTO_BSQ_get")]
        public static extern int GTO_BSQ_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_GTO_TIP_get")]
        public static extern int GTO_TIP_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_ALL_get")]
        public static extern int OF_ALL_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_GNM_get")]
        public static extern int OF_GNM_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_RASTER_get")]
        public static extern int OF_RASTER_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_READONLY_get")]
        public static extern int OF_READONLY_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_SHARED_get")]
        public static extern int OF_SHARED_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_UPDATE_get")]
        public static extern int OF_UPDATE_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_VECTOR_get")]
        public static extern int OF_VECTOR_get();
        [DllImport("gdalconst_wrap", EntryPoint="CSharp_OF_VERBOSE_ERROR_get")]
        public static extern int OF_VERBOSE_ERROR_get();

        protected class SWIGExceptionHelper
        {
            private static ExceptionDelegate applicationDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);
            private static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);
            private static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);
            private static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);
            private static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);
            private static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);
            private static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);
            private static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);
            private static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);
            private static ExceptionDelegate ioDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingIOException);
            private static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);
            private static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);
            private static ExceptionDelegate overflowDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);
            private static ExceptionDelegate systemDelegate = new ExceptionDelegate(GdalConstPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

            static SWIGExceptionHelper()
            {
                SWIGRegisterExceptionCallbacks_GdalConst(applicationDelegate, arithmeticDelegate, divideByZeroDelegate, indexOutOfRangeDelegate, invalidCastDelegate, invalidOperationDelegate, ioDelegate, nullReferenceDelegate, outOfMemoryDelegate, overflowDelegate, systemDelegate);
                SWIGRegisterExceptionCallbacksArgument_GdalConst(argumentDelegate, argumentNullDelegate, argumentOutOfRangeDelegate);
            }

            private static void SetPendingApplicationException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new ApplicationException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentException(string message, string paramName)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentNullException(string message, string paramName)
            {
                Exception exception = GdalConstPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                GdalConstPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
            }

            private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
            {
                Exception exception = GdalConstPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                GdalConstPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
            }

            private static void SetPendingArithmeticException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingDivideByZeroException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIndexOutOfRangeException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidCastException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidOperationException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIOException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new IOException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingNullReferenceException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOutOfMemoryException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOverflowException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new OverflowException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingSystemException(string message)
            {
                GdalConstPINVOKE.SWIGPendingException.Set(new SystemException(message, GdalConstPINVOKE.SWIGPendingException.Retrieve()));
            }

            [DllImport("gdalconst_wrap")]
            public static extern void SWIGRegisterExceptionCallbacks_GdalConst(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);
            [DllImport("gdalconst_wrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GdalConst")]
            public static extern void SWIGRegisterExceptionCallbacksArgument_GdalConst(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

            public delegate void ExceptionArgumentDelegate(string message, string paramName);

            public delegate void ExceptionDelegate(string message);
        }

        public class SWIGPendingException
        {
            private static int numExceptionsPending = 0;
            [ThreadStatic]
            private static Exception pendingException = null;

            public static Exception Retrieve()
            {
                Exception pendingException = null;
                if (numExceptionsPending > 0)
                {
                    if (GdalConstPINVOKE.SWIGPendingException.pendingException == null)
                    {
                        return pendingException;
                    }
                    pendingException = GdalConstPINVOKE.SWIGPendingException.pendingException;
                    GdalConstPINVOKE.SWIGPendingException.pendingException = null;
                    lock (typeof(GdalConstPINVOKE))
                    {
                        numExceptionsPending--;
                    }
                }
                return pendingException;
            }

            public static void Set(Exception e)
            {
                if (pendingException != null)
                {
                    throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
                }
                pendingException = e;
                lock (typeof(GdalConstPINVOKE))
                {
                    numExceptionsPending++;
                }
            }

            public static bool Pending
            {
                get
                {
                    bool flag = false;
                    if ((numExceptionsPending > 0) && (pendingException != null))
                    {
                        flag = true;
                    }
                    return flag;
                }
            }
        }

        protected class SWIGStringHelper
        {
            private static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(GdalConstPINVOKE.SWIGStringHelper.CreateString);

            static SWIGStringHelper()
            {
                SWIGRegisterStringCallback_GdalConst(stringDelegate);
            }

            private static string CreateString(string cString)
            {
                return cString;
            }

            [DllImport("gdalconst_wrap")]
            public static extern void SWIGRegisterStringCallback_GdalConst(SWIGStringDelegate stringDelegate);

            public delegate string SWIGStringDelegate(string message);
        }
    }
}

