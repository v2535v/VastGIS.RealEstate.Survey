﻿namespace OSGeo.GDAL
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class GdalPINVOKE
    {
        protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();
        protected static SWIGStringHelper swigStringHelper = new SWIGStringHelper();

        [DllImport("gdal_wrap", EntryPoint="CSharp___AllocCArray_GDAL_GCP")]
        public static extern IntPtr __AllocCArray_GDAL_GCP(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp___FreeCArray_GDAL_GCP")]
        public static extern void __FreeCArray_GDAL_GCP(IntPtr jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp___ReadCArrayItem_GDAL_GCP")]
        public static extern IntPtr __ReadCArrayItem_GDAL_GCP(IntPtr jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp___WriteCArrayItem_GDAL_GCP")]
        public static extern void __WriteCArrayItem_GDAL_GCP(IntPtr jarg1, int jarg2, HandleRef jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_AllRegister")]
        public static extern void AllRegister();
        [DllImport("gdal_wrap", EntryPoint="CSharp_ApplyGeoTransform")]
        public static extern void ApplyGeoTransform(double[] jarg1, double jarg2, double jarg3, out double jarg4, out double jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ApplyVerticalShiftGrid")]
        public static extern IntPtr ApplyVerticalShiftGrid(HandleRef jarg1, HandleRef jarg2, bool jarg3, double jarg4, double jarg5, IntPtr[] jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_AsyncReader_GetNextUpdatedRegion")]
        public static extern int AsyncReader_GetNextUpdatedRegion(HandleRef jarg1, double jarg2, out int jarg3, out int jarg4, out int jarg5, out int jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_AsyncReader_LockBuffer")]
        public static extern int AsyncReader_LockBuffer(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_AsyncReader_UnlockBuffer")]
        public static extern void AsyncReader_UnlockBuffer(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_AutoCreateWarpedVRT")]
        public static extern IntPtr AutoCreateWarpedVRT(HandleRef jarg1, string jarg2, string jarg3, int jarg4, double jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_Checksum")]
        public static extern int Band_Checksum(HandleRef jarg1, int jarg2, int jarg3, IntPtr jarg4, IntPtr jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_ComputeBandStats")]
        public static extern void Band_ComputeBandStats(HandleRef jarg1, double[] jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_ComputeRasterMinMax")]
        public static extern void Band_ComputeRasterMinMax(HandleRef jarg1, double[] jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_ComputeStatistics")]
        public static extern int Band_ComputeStatistics(HandleRef jarg1, bool jarg2, out double jarg3, out double jarg4, out double jarg5, out double jarg6, Gdal.GDALProgressFuncDelegate jarg7, string jarg8);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_CreateMaskBand")]
        public static extern int Band_CreateMaskBand(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_DataType_get")]
        public static extern int Band_DataType_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_DeleteNoDataValue")]
        public static extern int Band_DeleteNoDataValue(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_Fill")]
        public static extern int Band_Fill(HandleRef jarg1, double jarg2, double jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_FlushCache")]
        public static extern void Band_FlushCache(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetBand")]
        public static extern int Band_GetBand(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetBlockSize")]
        public static extern void Band_GetBlockSize(HandleRef jarg1, out int jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetCategoryNames")]
        public static extern IntPtr Band_GetCategoryNames(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetColorInterpretation")]
        public static extern int Band_GetColorInterpretation(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetColorTable")]
        public static extern IntPtr Band_GetColorTable(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetDataset")]
        public static extern IntPtr Band_GetDataset(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetDefaultHistogram")]
        public static extern int Band_GetDefaultHistogram(HandleRef jarg1, out double jarg2, out double jarg3, out int jarg4, out int[] jarg5, int jarg6, Gdal.GDALProgressFuncDelegate jarg7, string jarg8);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetDefaultRAT")]
        public static extern IntPtr Band_GetDefaultRAT(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetHistogram")]
        public static extern int Band_GetHistogram(HandleRef jarg1, double jarg2, double jarg3, int jarg4, int[] jarg5, int jarg6, int jarg7, Gdal.GDALProgressFuncDelegate jarg8, string jarg9);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetMaskBand")]
        public static extern IntPtr Band_GetMaskBand(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetMaskFlags")]
        public static extern int Band_GetMaskFlags(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetMaximum")]
        public static extern void Band_GetMaximum(HandleRef jarg1, out double jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetMinimum")]
        public static extern void Band_GetMinimum(HandleRef jarg1, out double jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetNoDataValue")]
        public static extern void Band_GetNoDataValue(HandleRef jarg1, out double jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetOffset")]
        public static extern void Band_GetOffset(HandleRef jarg1, out double jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetOverview")]
        public static extern IntPtr Band_GetOverview(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetOverviewCount")]
        public static extern int Band_GetOverviewCount(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetRasterCategoryNames")]
        public static extern IntPtr Band_GetRasterCategoryNames(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetRasterColorInterpretation")]
        public static extern int Band_GetRasterColorInterpretation(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetRasterColorTable")]
        public static extern IntPtr Band_GetRasterColorTable(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetScale")]
        public static extern void Band_GetScale(HandleRef jarg1, out double jarg2, out int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetStatistics")]
        public static extern int Band_GetStatistics(HandleRef jarg1, int jarg2, int jarg3, out double jarg4, out double jarg5, out double jarg6, out double jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_GetUnitType")]
        public static extern string Band_GetUnitType(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_HasArbitraryOverviews")]
        public static extern bool Band_HasArbitraryOverviews(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_ReadRaster__SWIG_0")]
        public static extern int Band_ReadRaster__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int jarg11);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_ReadRaster__SWIG_1")]
        public static extern int Band_ReadRaster__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int jarg11, HandleRef jarg12);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetCategoryNames")]
        public static extern int Band_SetCategoryNames(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetColorInterpretation")]
        public static extern int Band_SetColorInterpretation(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetColorTable")]
        public static extern int Band_SetColorTable(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetDefaultHistogram")]
        public static extern int Band_SetDefaultHistogram(HandleRef jarg1, double jarg2, double jarg3, int jarg4, int[] jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetDefaultRAT")]
        public static extern int Band_SetDefaultRAT(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetNoDataValue")]
        public static extern int Band_SetNoDataValue(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetOffset")]
        public static extern int Band_SetOffset(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetRasterCategoryNames")]
        public static extern int Band_SetRasterCategoryNames(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetRasterColorInterpretation")]
        public static extern int Band_SetRasterColorInterpretation(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetRasterColorTable")]
        public static extern int Band_SetRasterColorTable(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetScale")]
        public static extern int Band_SetScale(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetStatistics")]
        public static extern int Band_SetStatistics(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_SetUnitType")]
        public static extern int Band_SetUnitType(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_WriteRaster__SWIG_0")]
        public static extern int Band_WriteRaster__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int jarg11);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_WriteRaster__SWIG_1")]
        public static extern int Band_WriteRaster__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int jarg11, HandleRef jarg12);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_XSize_get")]
        public static extern int Band_XSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Band_YSize_get")]
        public static extern int Band_YSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_BandUpcast")]
        public static extern IntPtr BandUpcast(IntPtr objectRef);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c1_get")]
        public static extern short ColorEntry_c1_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c1_set")]
        public static extern void ColorEntry_c1_set(HandleRef jarg1, short jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c2_get")]
        public static extern short ColorEntry_c2_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c2_set")]
        public static extern void ColorEntry_c2_set(HandleRef jarg1, short jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c3_get")]
        public static extern short ColorEntry_c3_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c3_set")]
        public static extern void ColorEntry_c3_set(HandleRef jarg1, short jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c4_get")]
        public static extern short ColorEntry_c4_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorEntry_c4_set")]
        public static extern void ColorEntry_c4_set(HandleRef jarg1, short jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_Clone")]
        public static extern IntPtr ColorTable_Clone(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_CreateColorRamp")]
        public static extern void ColorTable_CreateColorRamp(HandleRef jarg1, int jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_GetColorEntry")]
        public static extern IntPtr ColorTable_GetColorEntry(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_GetColorEntryAsRGB")]
        public static extern int ColorTable_GetColorEntryAsRGB(HandleRef jarg1, int jarg2, HandleRef jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_GetCount")]
        public static extern int ColorTable_GetCount(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_GetPaletteInterpretation")]
        public static extern int ColorTable_GetPaletteInterpretation(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ColorTable_SetColorEntry")]
        public static extern void ColorTable_SetColorEntry(HandleRef jarg1, int jarg2, HandleRef jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ComputeMedianCutPCT")]
        public static extern int ComputeMedianCutPCT(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ComputeProximity")]
        public static extern int ComputeProximity(HandleRef jarg1, HandleRef jarg2, IntPtr[] jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ContourGenerate")]
        public static extern int ContourGenerate(HandleRef jarg1, double jarg2, double jarg3, int jarg4, double[] jarg5, int jarg6, double jarg7, HandleRef jarg8, int jarg9, int jarg10, Gdal.GDALProgressFuncDelegate jarg11, string jarg12);
        [DllImport("gdal_wrap", EntryPoint="CSharp_CPLBinaryToHex")]
        public static extern string CPLBinaryToHex(int jarg1, IntPtr jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_CPLHexToBinary")]
        public static extern IntPtr CPLHexToBinary(string jarg1, out int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_CreatePansharpenedVRT")]
        public static extern IntPtr CreatePansharpenedVRT(string jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___AllocCArray_GDAL_GCP")]
        public static extern IntPtr Dataset___AllocCArray_GDAL_GCP(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___FreeCArray_GDAL_GCP")]
        public static extern void Dataset___FreeCArray_GDAL_GCP(HandleRef jarg1, IntPtr jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___GetGCPs")]
        public static extern IntPtr Dataset___GetGCPs(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___ReadCArrayItem_GDAL_GCP")]
        public static extern IntPtr Dataset___ReadCArrayItem_GDAL_GCP(HandleRef jarg1, IntPtr jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___SetGCPs")]
        public static extern int Dataset___SetGCPs(HandleRef jarg1, int jarg2, IntPtr jarg3, string jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset___WriteCArrayItem_GDAL_GCP")]
        public static extern void Dataset___WriteCArrayItem_GDAL_GCP(HandleRef jarg1, IntPtr jarg2, int jarg3, HandleRef jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_AddBand")]
        public static extern int Dataset_AddBand(HandleRef jarg1, int jarg2, IntPtr[] jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_BuildOverviews")]
        public static extern int Dataset_BuildOverviews(HandleRef jarg1, string jarg2, int jarg3, IntPtr jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_CommitTransaction")]
        public static extern int Dataset_CommitTransaction(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_CreateMaskBand")]
        public static extern int Dataset_CreateMaskBand(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_FlushCache")]
        public static extern void Dataset_FlushCache(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetDriver")]
        public static extern IntPtr Dataset_GetDriver(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetFileList")]
        public static extern IntPtr Dataset_GetFileList(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetGCPCount")]
        public static extern int Dataset_GetGCPCount(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetGCPProjection")]
        public static extern string Dataset_GetGCPProjection(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetGeoTransform")]
        public static extern void Dataset_GetGeoTransform(HandleRef jarg1, double[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetProjection")]
        public static extern string Dataset_GetProjection(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetProjectionRef")]
        public static extern string Dataset_GetProjectionRef(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_GetRasterBand")]
        public static extern IntPtr Dataset_GetRasterBand(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_RasterCount_get")]
        public static extern int Dataset_RasterCount_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_RasterXSize_get")]
        public static extern int Dataset_RasterXSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_RasterYSize_get")]
        public static extern int Dataset_RasterYSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_ReadRaster__SWIG_0")]
        public static extern int Dataset_ReadRaster__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int[] jarg11, int jarg12, int jarg13, int jarg14);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_ReadRaster__SWIG_1")]
        public static extern int Dataset_ReadRaster__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int[] jarg11, int jarg12, int jarg13, int jarg14, HandleRef jarg15);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_RollbackTransaction")]
        public static extern int Dataset_RollbackTransaction(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_SetGeoTransform")]
        public static extern int Dataset_SetGeoTransform(HandleRef jarg1, double[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_SetProjection")]
        public static extern int Dataset_SetProjection(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_StartTransaction")]
        public static extern int Dataset_StartTransaction(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_WriteRaster__SWIG_0")]
        public static extern int Dataset_WriteRaster__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int[] jarg11, int jarg12, int jarg13, int jarg14);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Dataset_WriteRaster__SWIG_1")]
        public static extern int Dataset_WriteRaster__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, IntPtr jarg6, int jarg7, int jarg8, int jarg9, int jarg10, int[] jarg11, int jarg12, int jarg13, int jarg14, HandleRef jarg15);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DatasetUpcast")]
        public static extern IntPtr DatasetUpcast(IntPtr objectRef);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DataTypeIsComplex")]
        public static extern int DataTypeIsComplex(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Debug")]
        public static extern void Debug(string jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DecToDMS")]
        public static extern string DecToDMS(double jarg1, string jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DecToPackedDMS")]
        public static extern double DecToPackedDMS(double jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_AsyncReader")]
        public static extern void delete_AsyncReader(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_ColorEntry")]
        public static extern void delete_ColorEntry(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_ColorTable")]
        public static extern void delete_ColorTable(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_Dataset")]
        public static extern void delete_Dataset(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GCP")]
        public static extern void delete_GCP(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALBuildVRTOptions")]
        public static extern void delete_GDALBuildVRTOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALDEMProcessingOptions")]
        public static extern void delete_GDALDEMProcessingOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALGridOptions")]
        public static extern void delete_GDALGridOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALInfoOptions")]
        public static extern void delete_GDALInfoOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALNearblackOptions")]
        public static extern void delete_GDALNearblackOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALRasterizeOptions")]
        public static extern void delete_GDALRasterizeOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALTranslateOptions")]
        public static extern void delete_GDALTranslateOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALVectorTranslateOptions")]
        public static extern void delete_GDALVectorTranslateOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_GDALWarpAppOptions")]
        public static extern void delete_GDALWarpAppOptions(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_RasterAttributeTable")]
        public static extern void delete_RasterAttributeTable(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_RasterIOExtraArg")]
        public static extern void delete_RasterIOExtraArg(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_Transformer")]
        public static extern void delete_Transformer(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_delete_XMLNode")]
        public static extern void delete_XMLNode(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DitherRGB2PCT")]
        public static extern int DitherRGB2PCT(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DontUseExceptions")]
        public static extern void DontUseExceptions();
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_CopyFiles")]
        public static extern int Driver_CopyFiles(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_Create")]
        public static extern IntPtr Driver_Create(HandleRef jarg1, byte[] jarg2, int jarg3, int jarg4, int jarg5, int jarg6, IntPtr[] jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_CreateCopy")]
        public static extern IntPtr Driver_CreateCopy(HandleRef jarg1, byte[] jarg2, HandleRef jarg3, int jarg4, IntPtr[] jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_Delete")]
        public static extern int Driver_Delete(HandleRef jarg1, byte[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_Deregister")]
        public static extern void Driver_Deregister(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_HelpTopic_get")]
        public static extern string Driver_HelpTopic_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_LongName_get")]
        public static extern string Driver_LongName_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_Register")]
        public static extern int Driver_Register(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_Rename")]
        public static extern int Driver_Rename(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Driver_ShortName_get")]
        public static extern string Driver_ShortName_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_DriverUpcast")]
        public static extern IntPtr DriverUpcast(IntPtr objectRef);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Error")]
        public static extern void Error(int jarg1, int jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ErrorReset")]
        public static extern void ErrorReset();
        [DllImport("gdal_wrap", EntryPoint="CSharp_EscapeString")]
        public static extern string EscapeString(int jarg1, string jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_FileFromMemBuffer")]
        public static extern void FileFromMemBuffer(byte[] jarg1, int jarg2, IntPtr jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_FillNodata")]
        public static extern int FillNodata(HandleRef jarg1, HandleRef jarg2, double jarg3, int jarg4, IntPtr[] jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_FinderClean")]
        public static extern void FinderClean();
        [DllImport("gdal_wrap", EntryPoint="CSharp_FindFile")]
        public static extern string FindFile(string jarg1, byte[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_FPolygonize")]
        public static extern int FPolygonize(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, IntPtr[] jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPLine_get")]
        public static extern double GCP_GCPLine_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPLine_set")]
        public static extern void GCP_GCPLine_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPPixel_get")]
        public static extern double GCP_GCPPixel_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPPixel_set")]
        public static extern void GCP_GCPPixel_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPX_get")]
        public static extern double GCP_GCPX_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPX_set")]
        public static extern void GCP_GCPX_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPY_get")]
        public static extern double GCP_GCPY_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPY_set")]
        public static extern void GCP_GCPY_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPZ_get")]
        public static extern double GCP_GCPZ_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_GCPZ_set")]
        public static extern void GCP_GCPZ_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_Id_get")]
        public static extern string GCP_Id_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_Id_set")]
        public static extern void GCP_Id_set(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_Info_get")]
        public static extern string GCP_Info_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCP_Info_set")]
        public static extern void GCP_Info_set(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GCPsToGeoTransform")]
        public static extern int GCPsToGeoTransform(int jarg1, IntPtr jarg2, double[] jarg3, int jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPLine_get")]
        public static extern double GDAL_GCP_GCPLine_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPLine_set")]
        public static extern void GDAL_GCP_GCPLine_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPPixel_get")]
        public static extern double GDAL_GCP_GCPPixel_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPPixel_set")]
        public static extern void GDAL_GCP_GCPPixel_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPX_get")]
        public static extern double GDAL_GCP_GCPX_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPX_set")]
        public static extern void GDAL_GCP_GCPX_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPY_get")]
        public static extern double GDAL_GCP_GCPY_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPY_set")]
        public static extern void GDAL_GCP_GCPY_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPZ_get")]
        public static extern double GDAL_GCP_GCPZ_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_GCPZ_set")]
        public static extern void GDAL_GCP_GCPZ_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_GCPLine")]
        public static extern double GDAL_GCP_get_GCPLine(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_GCPPixel")]
        public static extern double GDAL_GCP_get_GCPPixel(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_GCPX")]
        public static extern double GDAL_GCP_get_GCPX(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_GCPY")]
        public static extern double GDAL_GCP_get_GCPY(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_GCPZ")]
        public static extern double GDAL_GCP_get_GCPZ(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_Id")]
        public static extern string GDAL_GCP_get_Id(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_get_Info")]
        public static extern string GDAL_GCP_get_Info(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_Id_get")]
        public static extern string GDAL_GCP_Id_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_Id_set")]
        public static extern void GDAL_GCP_Id_set(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_Info_get")]
        public static extern string GDAL_GCP_Info_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_Info_set")]
        public static extern void GDAL_GCP_Info_set(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_GCPLine")]
        public static extern void GDAL_GCP_set_GCPLine(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_GCPPixel")]
        public static extern void GDAL_GCP_set_GCPPixel(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_GCPX")]
        public static extern void GDAL_GCP_set_GCPX(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_GCPY")]
        public static extern void GDAL_GCP_set_GCPY(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_GCPZ")]
        public static extern void GDAL_GCP_set_GCPZ(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_Id")]
        public static extern void GDAL_GCP_set_Id(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDAL_GCP_set_Info")]
        public static extern void GDAL_GCP_set_Info(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDALDestroyDriverManager")]
        public static extern void GDALDestroyDriverManager();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GDALInfo")]
        public static extern string GDALInfo(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GeneralCmdLineProcessor")]
        public static extern IntPtr GeneralCmdLineProcessor(IntPtr[] jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetCacheMax")]
        public static extern int GetCacheMax();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetCacheUsed")]
        public static extern int GetCacheUsed();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetColorInterpretationName")]
        public static extern string GetColorInterpretationName(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetConfigOption")]
        public static extern string GetConfigOption(string jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDataTypeByName")]
        public static extern int GetDataTypeByName(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDataTypeName")]
        public static extern string GetDataTypeName(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDataTypeSize")]
        public static extern int GetDataTypeSize(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDriver")]
        public static extern IntPtr GetDriver(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDriverByName")]
        public static extern IntPtr GetDriverByName(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetDriverCount")]
        public static extern int GetDriverCount();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetJPEG2000StructureAsString")]
        public static extern string GetJPEG2000StructureAsString(string jarg1, IntPtr[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetLastErrorMsg")]
        public static extern string GetLastErrorMsg();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetLastErrorNo")]
        public static extern int GetLastErrorNo();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetLastErrorType")]
        public static extern int GetLastErrorType();
        [DllImport("gdal_wrap", EntryPoint="CSharp_GetPaletteInterpretationName")]
        public static extern string GetPaletteInterpretationName(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GOA2GetAccessToken")]
        public static extern string GOA2GetAccessToken(string jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GOA2GetAuthorizationURL")]
        public static extern string GOA2GetAuthorizationURL(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_GOA2GetRefreshToken")]
        public static extern string GOA2GetRefreshToken(string jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_HasThreadSupport")]
        public static extern int HasThreadSupport();
        [DllImport("gdal_wrap", EntryPoint="CSharp_IdentifyDriver")]
        public static extern IntPtr IdentifyDriver(byte[] jarg1, IntPtr[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_IdentifyDriverEx")]
        public static extern IntPtr IdentifyDriverEx(byte[] jarg1, uint jarg2, IntPtr[] jarg3, IntPtr[] jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_InvGeoTransform")]
        public static extern int InvGeoTransform(double[] jarg1, double[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_GetDescription")]
        public static extern string MajorObject_GetDescription(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_GetMetadata")]
        public static extern IntPtr MajorObject_GetMetadata(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_GetMetadataDomainList")]
        public static extern IntPtr MajorObject_GetMetadataDomainList(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_GetMetadataItem")]
        public static extern string MajorObject_GetMetadataItem(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_SetDescription")]
        public static extern void MajorObject_SetDescription(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_SetMetadata__SWIG_0")]
        public static extern int MajorObject_SetMetadata__SWIG_0(HandleRef jarg1, IntPtr[] jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_SetMetadata__SWIG_1")]
        public static extern int MajorObject_SetMetadata__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_MajorObject_SetMetadataItem")]
        public static extern int MajorObject_SetMetadataItem(HandleRef jarg1, string jarg2, string jarg3, string jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Mkdir")]
        public static extern int Mkdir(byte[] jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_ColorEntry")]
        public static extern IntPtr new_ColorEntry();
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_ColorTable")]
        public static extern IntPtr new_ColorTable(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GCP")]
        public static extern IntPtr new_GCP(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5, string jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALBuildVRTOptions")]
        public static extern IntPtr new_GDALBuildVRTOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALDEMProcessingOptions")]
        public static extern IntPtr new_GDALDEMProcessingOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALGridOptions")]
        public static extern IntPtr new_GDALGridOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALInfoOptions")]
        public static extern IntPtr new_GDALInfoOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALNearblackOptions")]
        public static extern IntPtr new_GDALNearblackOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALRasterizeOptions")]
        public static extern IntPtr new_GDALRasterizeOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALTranslateOptions")]
        public static extern IntPtr new_GDALTranslateOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALVectorTranslateOptions")]
        public static extern IntPtr new_GDALVectorTranslateOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_GDALWarpAppOptions")]
        public static extern IntPtr new_GDALWarpAppOptions(IntPtr[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_RasterAttributeTable")]
        public static extern IntPtr new_RasterAttributeTable();
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_RasterIOExtraArg")]
        public static extern IntPtr new_RasterIOExtraArg();
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_Transformer")]
        public static extern IntPtr new_Transformer(HandleRef jarg1, HandleRef jarg2, IntPtr[] jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_XMLNode__SWIG_0")]
        public static extern IntPtr new_XMLNode__SWIG_0(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_new_XMLNode__SWIG_1")]
        public static extern IntPtr new_XMLNode__SWIG_1(int jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Open")]
        public static extern IntPtr Open(byte[] jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_OpenEx")]
        public static extern IntPtr OpenEx(byte[] jarg1, uint jarg2, IntPtr[] jarg3, IntPtr[] jarg4, IntPtr[] jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_OpenShared")]
        public static extern IntPtr OpenShared(byte[] jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_PackedDMSToDec")]
        public static extern double PackedDMSToDec(double jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ParseCommandLine")]
        public static extern IntPtr ParseCommandLine(byte[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ParseXMLString")]
        public static extern IntPtr ParseXMLString(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Polygonize")]
        public static extern int Polygonize(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, IntPtr[] jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_PopErrorHandler")]
        public static extern void PopErrorHandler();
        [DllImport("gdal_wrap", EntryPoint="CSharp_PopFinderLocation")]
        public static extern void PopFinderLocation();
        [DllImport("gdal_wrap", EntryPoint="CSharp_PushErrorHandler__SWIG_0")]
        public static extern int PushErrorHandler__SWIG_0(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_PushErrorHandler__SWIG_1")]
        public static extern void PushErrorHandler__SWIG_1(Gdal.GDALErrorHandlerDelegate jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_PushFinderLocation")]
        public static extern void PushFinderLocation(byte[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_ChangesAreWrittenToFile")]
        public static extern int RasterAttributeTable_ChangesAreWrittenToFile(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_Clone")]
        public static extern IntPtr RasterAttributeTable_Clone(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_CreateColumn")]
        public static extern int RasterAttributeTable_CreateColumn(HandleRef jarg1, string jarg2, int jarg3, int jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_DumpReadable")]
        public static extern void RasterAttributeTable_DumpReadable(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetColOfUsage")]
        public static extern int RasterAttributeTable_GetColOfUsage(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetColumnCount")]
        public static extern int RasterAttributeTable_GetColumnCount(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetLinearBinning")]
        public static extern bool RasterAttributeTable_GetLinearBinning(HandleRef jarg1, out double jarg2, out double jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetNameOfCol")]
        public static extern string RasterAttributeTable_GetNameOfCol(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetRowCount")]
        public static extern int RasterAttributeTable_GetRowCount(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetRowOfValue")]
        public static extern int RasterAttributeTable_GetRowOfValue(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetTypeOfCol")]
        public static extern int RasterAttributeTable_GetTypeOfCol(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetUsageOfCol")]
        public static extern int RasterAttributeTable_GetUsageOfCol(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetValueAsDouble")]
        public static extern double RasterAttributeTable_GetValueAsDouble(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetValueAsInt")]
        public static extern int RasterAttributeTable_GetValueAsInt(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_GetValueAsString")]
        public static extern string RasterAttributeTable_GetValueAsString(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_SetLinearBinning")]
        public static extern int RasterAttributeTable_SetLinearBinning(HandleRef jarg1, double jarg2, double jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_SetRowCount")]
        public static extern void RasterAttributeTable_SetRowCount(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_SetValueAsDouble")]
        public static extern void RasterAttributeTable_SetValueAsDouble(HandleRef jarg1, int jarg2, int jarg3, double jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_SetValueAsInt")]
        public static extern void RasterAttributeTable_SetValueAsInt(HandleRef jarg1, int jarg2, int jarg3, int jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterAttributeTable_SetValueAsString")]
        public static extern void RasterAttributeTable_SetValueAsString(HandleRef jarg1, int jarg2, int jarg3, string jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_bFloatingPointWindowValidity_get")]
        public static extern int RasterIOExtraArg_bFloatingPointWindowValidity_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_bFloatingPointWindowValidity_set")]
        public static extern void RasterIOExtraArg_bFloatingPointWindowValidity_set(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfXOff_get")]
        public static extern double RasterIOExtraArg_dfXOff_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfXOff_set")]
        public static extern void RasterIOExtraArg_dfXOff_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfXSize_get")]
        public static extern double RasterIOExtraArg_dfXSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfXSize_set")]
        public static extern void RasterIOExtraArg_dfXSize_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfYOff_get")]
        public static extern double RasterIOExtraArg_dfYOff_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfYOff_set")]
        public static extern void RasterIOExtraArg_dfYOff_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfYSize_get")]
        public static extern double RasterIOExtraArg_dfYSize_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_dfYSize_set")]
        public static extern void RasterIOExtraArg_dfYSize_set(HandleRef jarg1, double jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_eResampleAlg_get")]
        public static extern int RasterIOExtraArg_eResampleAlg_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_eResampleAlg_set")]
        public static extern void RasterIOExtraArg_eResampleAlg_set(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_nVersion_get")]
        public static extern int RasterIOExtraArg_nVersion_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_nVersion_set")]
        public static extern void RasterIOExtraArg_nVersion_set(HandleRef jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_pfnProgress_get")]
        public static extern Gdal.GDALProgressFuncDelegate RasterIOExtraArg_pfnProgress_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_pfnProgress_set")]
        public static extern void RasterIOExtraArg_pfnProgress_set(HandleRef jarg1, Gdal.GDALProgressFuncDelegate jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_pProgressData_get")]
        public static extern IntPtr RasterIOExtraArg_pProgressData_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterIOExtraArg_pProgressData_set")]
        public static extern void RasterIOExtraArg_pProgressData_set(HandleRef jarg1, IntPtr jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RasterizeLayer")]
        public static extern int RasterizeLayer(HandleRef jarg1, int jarg2, int[] jarg3, HandleRef jarg4, IntPtr jarg5, IntPtr jarg6, int jarg7, double[] jarg8, IntPtr[] jarg9, Gdal.GDALProgressFuncDelegate jarg10, string jarg11);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ReadDir")]
        public static extern IntPtr ReadDir(byte[] jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ReadDirRecursive")]
        public static extern IntPtr ReadDirRecursive(byte[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RegenerateOverview")]
        public static extern int RegenerateOverview(HandleRef jarg1, HandleRef jarg2, string jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_RegenerateOverviews")]
        public static extern int RegenerateOverviews(HandleRef jarg1, int jarg2, HandleRef jarg3, string jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Rename")]
        public static extern int Rename(byte[] jarg1, byte[] jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_ReprojectImage")]
        public static extern int ReprojectImage(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4, int jarg5, double jarg6, double jarg7, Gdal.GDALProgressFuncDelegate jarg8, string jarg9, IntPtr[] jarg10);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Rmdir")]
        public static extern int Rmdir(byte[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_SerializeXMLTree")]
        public static extern string SerializeXMLTree(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_SetCacheMax")]
        public static extern void SetCacheMax(int jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_SetConfigOption")]
        public static extern void SetConfigOption(string jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_SetErrorHandler")]
        public static extern int SetErrorHandler(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_SieveFilter")]
        public static extern int SieveFilter(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, int jarg5, IntPtr[] jarg6, Gdal.GDALProgressFuncDelegate jarg7, string jarg8);
        [DllImport("gdal_wrap", EntryPoint="CSharp_StringListDestroy")]
        public static extern void StringListDestroy(IntPtr jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Transformer_TransformGeolocations")]
        public static extern int Transformer_TransformGeolocations(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6, IntPtr[] jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Transformer_TransformPoint__SWIG_0")]
        public static extern int Transformer_TransformPoint__SWIG_0(HandleRef jarg1, int jarg2, double[] jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Transformer_TransformPoint__SWIG_1")]
        public static extern int Transformer_TransformPoint__SWIG_1(HandleRef jarg1, double[] jarg2, int jarg3, double jarg4, double jarg5, double jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Transformer_TransformPoints")]
        public static extern int Transformer_TransformPoints(HandleRef jarg1, int jarg2, int jarg3, double[] jarg4, double[] jarg5, double[] jarg6, double[] jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_Unlink")]
        public static extern int Unlink(byte[] jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_UseExceptions")]
        public static extern void UseExceptions();
        [DllImport("gdal_wrap", EntryPoint="CSharp_VersionInfo")]
        public static extern string VersionInfo(string jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSICurlClearCache")]
        public static extern void VSICurlClearCache();
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFCloseL")]
        public static extern int VSIFCloseL(IntPtr jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFOpenExL")]
        public static extern IntPtr VSIFOpenExL(byte[] jarg1, string jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFOpenL")]
        public static extern IntPtr VSIFOpenL(byte[] jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFSeekL")]
        public static extern int VSIFSeekL(IntPtr jarg1, int jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFTellL")]
        public static extern int VSIFTellL(IntPtr jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFTruncateL")]
        public static extern int VSIFTruncateL(IntPtr jarg1, int jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIFWriteL")]
        public static extern int VSIFWriteL(string jarg1, int jarg2, int jarg3, IntPtr jarg4);
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIGetLastErrorMsg")]
        public static extern string VSIGetLastErrorMsg();
        [DllImport("gdal_wrap", EntryPoint="CSharp_VSIGetLastErrorNo")]
        public static extern int VSIGetLastErrorNo();
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALBuildVRT_names")]
        public static extern IntPtr wrapper_GDALBuildVRT_names(byte[] jarg1, IntPtr[] jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALBuildVRT_objects")]
        public static extern IntPtr wrapper_GDALBuildVRT_objects(byte[] jarg1, int jarg2, HandleRef jarg3, HandleRef jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALDEMProcessing")]
        public static extern IntPtr wrapper_GDALDEMProcessing(byte[] jarg1, HandleRef jarg2, string jarg3, string jarg4, HandleRef jarg5, Gdal.GDALProgressFuncDelegate jarg6, string jarg7);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALGrid")]
        public static extern IntPtr wrapper_GDALGrid(byte[] jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALNearblackDestDS")]
        public static extern int wrapper_GDALNearblackDestDS(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALNearblackDestName")]
        public static extern IntPtr wrapper_GDALNearblackDestName(byte[] jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALRasterizeDestDS")]
        public static extern int wrapper_GDALRasterizeDestDS(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALRasterizeDestName")]
        public static extern IntPtr wrapper_GDALRasterizeDestName(byte[] jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALTranslate")]
        public static extern IntPtr wrapper_GDALTranslate(byte[] jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALVectorTranslateDestDS")]
        public static extern int wrapper_GDALVectorTranslateDestDS(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALVectorTranslateDestName")]
        public static extern IntPtr wrapper_GDALVectorTranslateDestName(byte[] jarg1, HandleRef jarg2, HandleRef jarg3, Gdal.GDALProgressFuncDelegate jarg4, string jarg5);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALWarpDestDS")]
        public static extern int wrapper_GDALWarpDestDS(HandleRef jarg1, int jarg2, HandleRef jarg3, HandleRef jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_wrapper_GDALWarpDestName")]
        public static extern IntPtr wrapper_GDALWarpDestName(byte[] jarg1, int jarg2, HandleRef jarg3, HandleRef jarg4, Gdal.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_AddXMLChild")]
        public static extern void XMLNode_AddXMLChild(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_AddXMLSibling")]
        public static extern void XMLNode_AddXMLSibling(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_Child_get")]
        public static extern IntPtr XMLNode_Child_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_Clone")]
        public static extern IntPtr XMLNode_Clone(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_CloneXMLTree")]
        public static extern IntPtr XMLNode_CloneXMLTree(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_CreateXMLElementAndValue")]
        public static extern IntPtr XMLNode_CreateXMLElementAndValue(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_GetXMLNode")]
        public static extern IntPtr XMLNode_GetXMLNode(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_GetXMLValue")]
        public static extern string XMLNode_GetXMLValue(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_Next_get")]
        public static extern IntPtr XMLNode_Next_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_RemoveXMLChild")]
        public static extern int XMLNode_RemoveXMLChild(HandleRef jarg1, HandleRef jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_SearchXMLNode")]
        public static extern IntPtr XMLNode_SearchXMLNode(HandleRef jarg1, string jarg2);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_SerializeXMLTree")]
        public static extern string XMLNode_SerializeXMLTree(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_SetXMLValue")]
        public static extern int XMLNode_SetXMLValue(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_StripXMLNamespace")]
        public static extern void XMLNode_StripXMLNamespace(HandleRef jarg1, string jarg2, int jarg3);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_toString")]
        public static extern string XMLNode_toString(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_Type_get")]
        public static extern int XMLNode_Type_get(HandleRef jarg1);
        [DllImport("gdal_wrap", EntryPoint="CSharp_XMLNode_Value_get")]
        public static extern string XMLNode_Value_get(HandleRef jarg1);

        public class StringListMarshal : IDisposable
        {
            public readonly IntPtr[] _ar;

            public StringListMarshal(string[] ar)
            {
                this._ar = new IntPtr[ar.Length + 1];
                for (int i = 0; i < ar.Length; i++)
                {
                    this._ar[i] = Marshal.StringToHGlobalAnsi(ar[i]);
                }
                this._ar[ar.Length] = IntPtr.Zero;
            }

            public virtual void Dispose()
            {
                for (int i = 0; i < (this._ar.Length - 1); i++)
                {
                    Marshal.FreeHGlobal(this._ar[i]);
                }
                GC.SuppressFinalize(this);
            }
        }

        protected class SWIGExceptionHelper
        {
            private static ExceptionDelegate applicationDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);
            private static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);
            private static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);
            private static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);
            private static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);
            private static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);
            private static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);
            private static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);
            private static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);
            private static ExceptionDelegate ioDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingIOException);
            private static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);
            private static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);
            private static ExceptionDelegate overflowDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);
            private static ExceptionDelegate systemDelegate = new ExceptionDelegate(GdalPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

            static SWIGExceptionHelper()
            {
                SWIGRegisterExceptionCallbacks_Gdal(applicationDelegate, arithmeticDelegate, divideByZeroDelegate, indexOutOfRangeDelegate, invalidCastDelegate, invalidOperationDelegate, ioDelegate, nullReferenceDelegate, outOfMemoryDelegate, overflowDelegate, systemDelegate);
                SWIGRegisterExceptionCallbacksArgument_Gdal(argumentDelegate, argumentNullDelegate, argumentOutOfRangeDelegate);
            }

            private static void SetPendingApplicationException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new ApplicationException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentException(string message, string paramName)
            {
                GdalPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentNullException(string message, string paramName)
            {
                Exception exception = GdalPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                GdalPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
            }

            private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
            {
                Exception exception = GdalPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                GdalPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
            }

            private static void SetPendingArithmeticException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingDivideByZeroException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIndexOutOfRangeException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidCastException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidOperationException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIOException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new IOException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingNullReferenceException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOutOfMemoryException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOverflowException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new OverflowException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingSystemException(string message)
            {
                GdalPINVOKE.SWIGPendingException.Set(new SystemException(message, GdalPINVOKE.SWIGPendingException.Retrieve()));
            }

            [DllImport("gdal_wrap")]
            public static extern void SWIGRegisterExceptionCallbacks_Gdal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);
            [DllImport("gdal_wrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_Gdal")]
            public static extern void SWIGRegisterExceptionCallbacksArgument_Gdal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

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
                    if (GdalPINVOKE.SWIGPendingException.pendingException == null)
                    {
                        return pendingException;
                    }
                    pendingException = GdalPINVOKE.SWIGPendingException.pendingException;
                    GdalPINVOKE.SWIGPendingException.pendingException = null;
                    lock (typeof(GdalPINVOKE))
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
                lock (typeof(GdalPINVOKE))
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
            private static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(GdalPINVOKE.SWIGStringHelper.CreateString);

            static SWIGStringHelper()
            {
                SWIGRegisterStringCallback_Gdal(stringDelegate);
            }

            private static string CreateString(string cString)
            {
                return cString;
            }

            [DllImport("gdal_wrap")]
            public static extern void SWIGRegisterStringCallback_Gdal(SWIGStringDelegate stringDelegate);

            public delegate string SWIGStringDelegate(string message);
        }
    }
}

