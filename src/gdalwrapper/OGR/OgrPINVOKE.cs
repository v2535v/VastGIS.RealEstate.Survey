﻿namespace OSGeo.OGR
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal class OgrPINVOKE
    {
        protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();
        protected static SWIGStringHelper swigStringHelper = new SWIGStringHelper();

        [DllImport("ogr_wrap", EntryPoint="CSharp_ApproximateArcAngles")]
        public static extern IntPtr ApproximateArcAngles(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9);
        [DllImport("ogr_wrap", EntryPoint="CSharp_BuildPolygonFromEdges")]
        public static extern IntPtr BuildPolygonFromEdges(HandleRef jarg1, int jarg2, int jarg3, double jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_CreateGeometryFromGML")]
        public static extern IntPtr CreateGeometryFromGML(string jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_CreateGeometryFromJson")]
        public static extern IntPtr CreateGeometryFromJson(string jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_CreateGeometryFromWkb")]
        public static extern IntPtr CreateGeometryFromWkb(int jarg1, IntPtr jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_CreateGeometryFromWkt")]
        public static extern IntPtr CreateGeometryFromWkt(ref string jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_CommitTransaction")]
        public static extern int DataSource_CommitTransaction(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_CopyLayer")]
        public static extern IntPtr DataSource_CopyLayer(HandleRef jarg1, HandleRef jarg2, string jarg3, IntPtr[] jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_CreateLayer")]
        public static extern IntPtr DataSource_CreateLayer(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4, IntPtr[] jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_DeleteLayer")]
        public static extern int DataSource_DeleteLayer(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_ExecuteSQL")]
        public static extern IntPtr DataSource_ExecuteSQL(HandleRef jarg1, string jarg2, HandleRef jarg3, string jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_FlushCache")]
        public static extern void DataSource_FlushCache(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetDriver")]
        public static extern IntPtr DataSource_GetDriver(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetLayerByIndex")]
        public static extern IntPtr DataSource_GetLayerByIndex(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetLayerByName")]
        public static extern IntPtr DataSource_GetLayerByName(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetLayerCount")]
        public static extern int DataSource_GetLayerCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetName")]
        public static extern string DataSource_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetRefCount")]
        public static extern int DataSource_GetRefCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetStyleTable")]
        public static extern IntPtr DataSource_GetStyleTable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_GetSummaryRefCount")]
        public static extern int DataSource_GetSummaryRefCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_name_get")]
        public static extern string DataSource_name_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_ReleaseResultSet")]
        public static extern void DataSource_ReleaseResultSet(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_RollbackTransaction")]
        public static extern int DataSource_RollbackTransaction(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_SetStyleTable")]
        public static extern void DataSource_SetStyleTable(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_StartTransaction")]
        public static extern int DataSource_StartTransaction(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_SyncToDisk")]
        public static extern int DataSource_SyncToDisk(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DataSource_TestCapability")]
        public static extern bool DataSource_TestCapability(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_DataSource")]
        public static extern void delete_DataSource(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_Envelope")]
        public static extern void delete_Envelope(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_Envelope3D")]
        public static extern void delete_Envelope3D(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_Feature")]
        public static extern void delete_Feature(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_FeatureDefn")]
        public static extern void delete_FeatureDefn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_FieldDefn")]
        public static extern void delete_FieldDefn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_Geometry")]
        public static extern void delete_Geometry(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_GeomFieldDefn")]
        public static extern void delete_GeomFieldDefn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_delete_StyleTable")]
        public static extern void delete_StyleTable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_DontUseExceptions")]
        public static extern void DontUseExceptions();
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_CopyDataSource")]
        public static extern IntPtr Driver_CopyDataSource(HandleRef jarg1, HandleRef jarg2, byte[] jarg3, IntPtr[] jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_CreateDataSource")]
        public static extern IntPtr Driver_CreateDataSource(HandleRef jarg1, byte[] jarg2, IntPtr[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_DeleteDataSource")]
        public static extern int Driver_DeleteDataSource(HandleRef jarg1, byte[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_Deregister")]
        public static extern void Driver_Deregister(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_GetName")]
        public static extern string Driver_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_name_get")]
        public static extern string Driver_name_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_Open")]
        public static extern IntPtr Driver_Open(HandleRef jarg1, byte[] jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_Register")]
        public static extern void Driver_Register(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Driver_TestCapability")]
        public static extern bool Driver_TestCapability(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MaxX_get")]
        public static extern double Envelope_MaxX_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MaxX_set")]
        public static extern void Envelope_MaxX_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MaxY_get")]
        public static extern double Envelope_MaxY_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MaxY_set")]
        public static extern void Envelope_MaxY_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MinX_get")]
        public static extern double Envelope_MinX_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MinX_set")]
        public static extern void Envelope_MinX_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MinY_get")]
        public static extern double Envelope_MinY_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope_MinY_set")]
        public static extern void Envelope_MinY_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxX_get")]
        public static extern double Envelope3D_MaxX_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxX_set")]
        public static extern void Envelope3D_MaxX_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxY_get")]
        public static extern double Envelope3D_MaxY_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxY_set")]
        public static extern void Envelope3D_MaxY_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxZ_get")]
        public static extern double Envelope3D_MaxZ_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MaxZ_set")]
        public static extern void Envelope3D_MaxZ_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinX_get")]
        public static extern double Envelope3D_MinX_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinX_set")]
        public static extern void Envelope3D_MinX_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinY_get")]
        public static extern double Envelope3D_MinY_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinY_set")]
        public static extern void Envelope3D_MinY_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinZ_get")]
        public static extern double Envelope3D_MinZ_get(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Envelope3D_MinZ_set")]
        public static extern void Envelope3D_MinZ_set(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_Clone")]
        public static extern IntPtr Feature_Clone(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_DumpReadable")]
        public static extern void Feature_DumpReadable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_Equal")]
        public static extern bool Feature_Equal(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_FillUnsetWithDefault")]
        public static extern void Feature_FillUnsetWithDefault(HandleRef jarg1, int jarg2, IntPtr[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetDefnRef")]
        public static extern IntPtr Feature_GetDefnRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFID")]
        public static extern long Feature_GetFID(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsDateTime__SWIG_0")]
        public static extern void Feature_GetFieldAsDateTime__SWIG_0(HandleRef jarg1, int jarg2, out int jarg3, out int jarg4, out int jarg5, out int jarg6, out int jarg7, out float jarg8, out int jarg9);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsDateTime__SWIG_1")]
        public static extern void Feature_GetFieldAsDateTime__SWIG_1(HandleRef jarg1, string jarg2, out int jarg3, out int jarg4, out int jarg5, out int jarg6, out int jarg7, out float jarg8, out int jarg9);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsDouble__SWIG_0")]
        public static extern double Feature_GetFieldAsDouble__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsDouble__SWIG_1")]
        public static extern double Feature_GetFieldAsDouble__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsDoubleList")]
        public static extern IntPtr Feature_GetFieldAsDoubleList(HandleRef jarg1, int jarg2, out int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsInteger__SWIG_0")]
        public static extern int Feature_GetFieldAsInteger__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsInteger__SWIG_1")]
        public static extern int Feature_GetFieldAsInteger__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsInteger64__SWIG_0")]
        public static extern long Feature_GetFieldAsInteger64__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsInteger64__SWIG_1")]
        public static extern long Feature_GetFieldAsInteger64__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsIntegerList")]
        public static extern IntPtr Feature_GetFieldAsIntegerList(HandleRef jarg1, int jarg2, out int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsString__SWIG_0")]
        public static extern IntPtr Feature_GetFieldAsString__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsString__SWIG_1")]
        public static extern IntPtr Feature_GetFieldAsString__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldAsStringList")]
        public static extern IntPtr Feature_GetFieldAsStringList(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldCount")]
        public static extern int Feature_GetFieldCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldDefnRef__SWIG_0")]
        public static extern IntPtr Feature_GetFieldDefnRef__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldDefnRef__SWIG_1")]
        public static extern IntPtr Feature_GetFieldDefnRef__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldIndex")]
        public static extern int Feature_GetFieldIndex(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldType__SWIG_0")]
        public static extern int Feature_GetFieldType__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetFieldType__SWIG_1")]
        public static extern int Feature_GetFieldType__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeometryRef")]
        public static extern IntPtr Feature_GetGeometryRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldCount")]
        public static extern int Feature_GetGeomFieldCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldDefnRef__SWIG_0")]
        public static extern IntPtr Feature_GetGeomFieldDefnRef__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldDefnRef__SWIG_1")]
        public static extern IntPtr Feature_GetGeomFieldDefnRef__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldIndex")]
        public static extern int Feature_GetGeomFieldIndex(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldRef__SWIG_0")]
        public static extern IntPtr Feature_GetGeomFieldRef__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetGeomFieldRef__SWIG_1")]
        public static extern IntPtr Feature_GetGeomFieldRef__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetNativeData")]
        public static extern string Feature_GetNativeData(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetNativeMediaType")]
        public static extern string Feature_GetNativeMediaType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_GetStyleString")]
        public static extern string Feature_GetStyleString(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldNull__SWIG_0")]
        public static extern bool Feature_IsFieldNull__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldNull__SWIG_1")]
        public static extern bool Feature_IsFieldNull__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldSet__SWIG_0")]
        public static extern bool Feature_IsFieldSet__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldSet__SWIG_1")]
        public static extern bool Feature_IsFieldSet__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldSetAndNotNull__SWIG_0")]
        public static extern bool Feature_IsFieldSetAndNotNull__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_IsFieldSetAndNotNull__SWIG_1")]
        public static extern bool Feature_IsFieldSetAndNotNull__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFID")]
        public static extern int Feature_SetFID(HandleRef jarg1, long jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_0")]
        public static extern void Feature_SetField__SWIG_0(HandleRef jarg1, int jarg2, byte[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_1")]
        public static extern void Feature_SetField__SWIG_1(HandleRef jarg1, string jarg2, byte[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_2")]
        public static extern void Feature_SetField__SWIG_2(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_3")]
        public static extern void Feature_SetField__SWIG_3(HandleRef jarg1, string jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_4")]
        public static extern void Feature_SetField__SWIG_4(HandleRef jarg1, int jarg2, double jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_5")]
        public static extern void Feature_SetField__SWIG_5(HandleRef jarg1, string jarg2, double jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_6")]
        public static extern void Feature_SetField__SWIG_6(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, float jarg8, int jarg9);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetField__SWIG_7")]
        public static extern void Feature_SetField__SWIG_7(HandleRef jarg1, string jarg2, int jarg3, int jarg4, int jarg5, int jarg6, int jarg7, float jarg8, int jarg9);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldBinaryFromHexString__SWIG_0")]
        public static extern void Feature_SetFieldBinaryFromHexString__SWIG_0(HandleRef jarg1, int jarg2, string jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldBinaryFromHexString__SWIG_1")]
        public static extern void Feature_SetFieldBinaryFromHexString__SWIG_1(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldDoubleList")]
        public static extern void Feature_SetFieldDoubleList(HandleRef jarg1, int jarg2, int jarg3, double[] jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldInteger64")]
        public static extern void Feature_SetFieldInteger64(HandleRef jarg1, int jarg2, long jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldIntegerList")]
        public static extern void Feature_SetFieldIntegerList(HandleRef jarg1, int jarg2, int jarg3, int[] jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldNull__SWIG_0")]
        public static extern void Feature_SetFieldNull__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldNull__SWIG_1")]
        public static extern void Feature_SetFieldNull__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFieldStringList")]
        public static extern void Feature_SetFieldStringList(HandleRef jarg1, int jarg2, IntPtr[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFrom")]
        public static extern int Feature_SetFrom(HandleRef jarg1, HandleRef jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetFromWithMap")]
        public static extern int Feature_SetFromWithMap(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4, int[] jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeometry")]
        public static extern int Feature_SetGeometry(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeometryDirectly")]
        public static extern int Feature_SetGeometryDirectly(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeomField__SWIG_0")]
        public static extern int Feature_SetGeomField__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeomField__SWIG_1")]
        public static extern int Feature_SetGeomField__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeomFieldDirectly__SWIG_0")]
        public static extern int Feature_SetGeomFieldDirectly__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetGeomFieldDirectly__SWIG_1")]
        public static extern int Feature_SetGeomFieldDirectly__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetNativeData")]
        public static extern void Feature_SetNativeData(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetNativeMediaType")]
        public static extern void Feature_SetNativeMediaType(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_SetStyleString")]
        public static extern void Feature_SetStyleString(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_UnsetField__SWIG_0")]
        public static extern void Feature_UnsetField__SWIG_0(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_UnsetField__SWIG_1")]
        public static extern void Feature_UnsetField__SWIG_1(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Feature_Validate")]
        public static extern int Feature_Validate(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_AddFieldDefn")]
        public static extern void FeatureDefn_AddFieldDefn(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_AddGeomFieldDefn")]
        public static extern void FeatureDefn_AddGeomFieldDefn(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_DeleteGeomFieldDefn")]
        public static extern int FeatureDefn_DeleteGeomFieldDefn(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetFieldCount")]
        public static extern int FeatureDefn_GetFieldCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetFieldDefn")]
        public static extern IntPtr FeatureDefn_GetFieldDefn(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetFieldIndex")]
        public static extern int FeatureDefn_GetFieldIndex(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetGeomFieldCount")]
        public static extern int FeatureDefn_GetGeomFieldCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetGeomFieldDefn")]
        public static extern IntPtr FeatureDefn_GetGeomFieldDefn(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetGeomFieldIndex")]
        public static extern int FeatureDefn_GetGeomFieldIndex(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetGeomType")]
        public static extern int FeatureDefn_GetGeomType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetName")]
        public static extern string FeatureDefn_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_GetReferenceCount")]
        public static extern int FeatureDefn_GetReferenceCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_IsGeometryIgnored")]
        public static extern int FeatureDefn_IsGeometryIgnored(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_IsSame")]
        public static extern int FeatureDefn_IsSame(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_IsStyleIgnored")]
        public static extern int FeatureDefn_IsStyleIgnored(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_SetGeometryIgnored")]
        public static extern void FeatureDefn_SetGeometryIgnored(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_SetGeomType")]
        public static extern void FeatureDefn_SetGeomType(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FeatureDefn_SetStyleIgnored")]
        public static extern void FeatureDefn_SetStyleIgnored(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetDefault")]
        public static extern string FieldDefn_GetDefault(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetFieldType")]
        public static extern int FieldDefn_GetFieldType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetFieldTypeName")]
        public static extern string FieldDefn_GetFieldTypeName(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetJustify")]
        public static extern int FieldDefn_GetJustify(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetName")]
        public static extern string FieldDefn_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetNameRef")]
        public static extern string FieldDefn_GetNameRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetPrecision")]
        public static extern int FieldDefn_GetPrecision(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetSubType")]
        public static extern int FieldDefn_GetSubType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetTypeName")]
        public static extern string FieldDefn_GetTypeName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_GetWidth")]
        public static extern int FieldDefn_GetWidth(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_IsDefaultDriverSpecific")]
        public static extern int FieldDefn_IsDefaultDriverSpecific(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_IsIgnored")]
        public static extern int FieldDefn_IsIgnored(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_IsNullable")]
        public static extern int FieldDefn_IsNullable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetDefault")]
        public static extern void FieldDefn_SetDefault(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetIgnored")]
        public static extern void FieldDefn_SetIgnored(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetJustify")]
        public static extern void FieldDefn_SetJustify(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetName")]
        public static extern void FieldDefn_SetName(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetNullable")]
        public static extern void FieldDefn_SetNullable(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetPrecision")]
        public static extern void FieldDefn_SetPrecision(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetSubType")]
        public static extern void FieldDefn_SetSubType(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetType")]
        public static extern void FieldDefn_SetType(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_FieldDefn_SetWidth")]
        public static extern void FieldDefn_SetWidth(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceTo")]
        public static extern IntPtr ForceTo(HandleRef jarg1, int jarg2, IntPtr[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceToLineString")]
        public static extern IntPtr ForceToLineString(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceToMultiLineString")]
        public static extern IntPtr ForceToMultiLineString(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceToMultiPoint")]
        public static extern IntPtr ForceToMultiPoint(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceToMultiPolygon")]
        public static extern IntPtr ForceToMultiPolygon(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_ForceToPolygon")]
        public static extern IntPtr ForceToPolygon(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeneralCmdLineProcessor")]
        public static extern IntPtr GeneralCmdLineProcessor(IntPtr[] jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddGeometry")]
        public static extern int Geometry_AddGeometry(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddGeometryDirectly")]
        public static extern int Geometry_AddGeometryDirectly(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddPoint")]
        public static extern void Geometry_AddPoint(HandleRef jarg1, double jarg2, double jarg3, double jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddPoint_2D")]
        public static extern void Geometry_AddPoint_2D(HandleRef jarg1, double jarg2, double jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddPointM")]
        public static extern void Geometry_AddPointM(HandleRef jarg1, double jarg2, double jarg3, double jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AddPointZM")]
        public static extern void Geometry_AddPointZM(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Area")]
        public static extern double Geometry_Area(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_AssignSpatialReference")]
        public static extern void Geometry_AssignSpatialReference(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Boundary")]
        public static extern IntPtr Geometry_Boundary(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Buffer")]
        public static extern IntPtr Geometry_Buffer(HandleRef jarg1, double jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Centroid")]
        public static extern IntPtr Geometry_Centroid(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Clone")]
        public static extern IntPtr Geometry_Clone(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_CloseRings")]
        public static extern void Geometry_CloseRings(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Contains")]
        public static extern bool Geometry_Contains(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ConvexHull")]
        public static extern IntPtr Geometry_ConvexHull(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_CoordinateDimension")]
        public static extern int Geometry_CoordinateDimension(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Crosses")]
        public static extern bool Geometry_Crosses(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_DelaunayTriangulation")]
        public static extern IntPtr Geometry_DelaunayTriangulation(HandleRef jarg1, double jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Difference")]
        public static extern IntPtr Geometry_Difference(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Disjoint")]
        public static extern bool Geometry_Disjoint(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Distance")]
        public static extern double Geometry_Distance(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Distance3D")]
        public static extern double Geometry_Distance3D(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Empty")]
        public static extern void Geometry_Empty(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Equal")]
        public static extern bool Geometry_Equal(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Equals")]
        public static extern bool Geometry_Equals(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToGML__SWIG_0")]
        public static extern string Geometry_ExportToGML__SWIG_0(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToGML__SWIG_1")]
        public static extern string Geometry_ExportToGML__SWIG_1(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToIsoWkt")]
        public static extern int Geometry_ExportToIsoWkt(HandleRef jarg1, out string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToJson")]
        public static extern string Geometry_ExportToJson(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToKML")]
        public static extern string Geometry_ExportToKML(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToWkb")]
        public static extern int Geometry_ExportToWkb(HandleRef jarg1, int jarg2, IntPtr jarg3, int jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_ExportToWkt")]
        public static extern int Geometry_ExportToWkt(HandleRef jarg1, out string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_FlattenTo2D")]
        public static extern void Geometry_FlattenTo2D(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetArea")]
        public static extern double Geometry_GetArea(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetBoundary")]
        public static extern IntPtr Geometry_GetBoundary(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetCoordinateDimension")]
        public static extern int Geometry_GetCoordinateDimension(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetCurveGeometry")]
        public static extern IntPtr Geometry_GetCurveGeometry(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetDimension")]
        public static extern int Geometry_GetDimension(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetEnvelope")]
        public static extern void Geometry_GetEnvelope(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetEnvelope3D")]
        public static extern void Geometry_GetEnvelope3D(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetGeometryCount")]
        public static extern int Geometry_GetGeometryCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetGeometryName")]
        public static extern string Geometry_GetGeometryName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetGeometryRef")]
        public static extern IntPtr Geometry_GetGeometryRef(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetGeometryType")]
        public static extern int Geometry_GetGeometryType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetLinearGeometry")]
        public static extern IntPtr Geometry_GetLinearGeometry(HandleRef jarg1, double jarg2, IntPtr[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetM")]
        public static extern double Geometry_GetM(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetPoint")]
        public static extern void Geometry_GetPoint(HandleRef jarg1, int jarg2, double[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetPoint_2D")]
        public static extern void Geometry_GetPoint_2D(HandleRef jarg1, int jarg2, double[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetPointCount")]
        public static extern int Geometry_GetPointCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetPointZM")]
        public static extern void Geometry_GetPointZM(HandleRef jarg1, int jarg2, double[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetSpatialReference")]
        public static extern IntPtr Geometry_GetSpatialReference(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetX")]
        public static extern double Geometry_GetX(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetY")]
        public static extern double Geometry_GetY(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_GetZ")]
        public static extern double Geometry_GetZ(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_HasCurveGeometry")]
        public static extern int Geometry_HasCurveGeometry(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Intersect")]
        public static extern bool Geometry_Intersect(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Intersection")]
        public static extern IntPtr Geometry_Intersection(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Intersects")]
        public static extern bool Geometry_Intersects(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Is3D")]
        public static extern int Geometry_Is3D(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_IsEmpty")]
        public static extern bool Geometry_IsEmpty(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_IsMeasured")]
        public static extern int Geometry_IsMeasured(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_IsRing")]
        public static extern bool Geometry_IsRing(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_IsSimple")]
        public static extern bool Geometry_IsSimple(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_IsValid")]
        public static extern bool Geometry_IsValid(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Length")]
        public static extern double Geometry_Length(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Overlaps")]
        public static extern bool Geometry_Overlaps(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_PointOnSurface")]
        public static extern IntPtr Geometry_PointOnSurface(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Segmentize")]
        public static extern void Geometry_Segmentize(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Set3D")]
        public static extern void Geometry_Set3D(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetCoordinateDimension")]
        public static extern void Geometry_SetCoordinateDimension(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetMeasured")]
        public static extern void Geometry_SetMeasured(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetPoint")]
        public static extern void Geometry_SetPoint(HandleRef jarg1, int jarg2, double jarg3, double jarg4, double jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetPoint_2D")]
        public static extern void Geometry_SetPoint_2D(HandleRef jarg1, int jarg2, double jarg3, double jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetPointM")]
        public static extern void Geometry_SetPointM(HandleRef jarg1, int jarg2, double jarg3, double jarg4, double jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SetPointZM")]
        public static extern void Geometry_SetPointZM(HandleRef jarg1, int jarg2, double jarg3, double jarg4, double jarg5, double jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Simplify")]
        public static extern IntPtr Geometry_Simplify(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SimplifyPreserveTopology")]
        public static extern IntPtr Geometry_SimplifyPreserveTopology(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SymDifference")]
        public static extern IntPtr Geometry_SymDifference(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_SymmetricDifference")]
        public static extern IntPtr Geometry_SymmetricDifference(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Touches")]
        public static extern bool Geometry_Touches(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Transform")]
        public static extern int Geometry_Transform(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_TransformTo")]
        public static extern int Geometry_TransformTo(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Union")]
        public static extern IntPtr Geometry_Union(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_UnionCascaded")]
        public static extern IntPtr Geometry_UnionCascaded(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Value")]
        public static extern IntPtr Geometry_Value(HandleRef jarg1, double jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_Within")]
        public static extern bool Geometry_Within(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Geometry_WkbSize")]
        public static extern int Geometry_WkbSize(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeometryTypeToName")]
        public static extern string GeometryTypeToName(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_GetFieldType")]
        public static extern int GeomFieldDefn_GetFieldType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_GetName")]
        public static extern string GeomFieldDefn_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_GetNameRef")]
        public static extern string GeomFieldDefn_GetNameRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_GetSpatialRef")]
        public static extern IntPtr GeomFieldDefn_GetSpatialRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_IsIgnored")]
        public static extern int GeomFieldDefn_IsIgnored(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_IsNullable")]
        public static extern int GeomFieldDefn_IsNullable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_SetIgnored")]
        public static extern void GeomFieldDefn_SetIgnored(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_SetName")]
        public static extern void GeomFieldDefn_SetName(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_SetNullable")]
        public static extern void GeomFieldDefn_SetNullable(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_SetSpatialRef")]
        public static extern void GeomFieldDefn_SetSpatialRef(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GeomFieldDefn_SetType")]
        public static extern void GeomFieldDefn_SetType(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetDriver")]
        public static extern IntPtr GetDriver(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetDriverByName")]
        public static extern IntPtr GetDriverByName(string jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetDriverCount")]
        public static extern int GetDriverCount();
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetFieldSubTypeName")]
        public static extern string GetFieldSubTypeName(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetFieldTypeName")]
        public static extern string GetFieldTypeName(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetNonLinearGeometriesEnabledFlag")]
        public static extern int GetNonLinearGeometriesEnabledFlag();
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetOpenDS")]
        public static extern IntPtr GetOpenDS(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GetOpenDSCount")]
        public static extern int GetOpenDSCount();
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_Flatten")]
        public static extern int GT_Flatten(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_GetCollection")]
        public static extern int GT_GetCollection(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_GetCurve")]
        public static extern int GT_GetCurve(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_GetLinear")]
        public static extern int GT_GetLinear(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_HasM")]
        public static extern int GT_HasM(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_HasZ")]
        public static extern int GT_HasZ(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_IsCurve")]
        public static extern int GT_IsCurve(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_IsNonLinear")]
        public static extern int GT_IsNonLinear(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_IsSubClassOf")]
        public static extern int GT_IsSubClassOf(int jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_IsSurface")]
        public static extern int GT_IsSurface(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_SetM")]
        public static extern int GT_SetM(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_SetModifier")]
        public static extern int GT_SetModifier(int jarg1, int jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_GT_SetZ")]
        public static extern int GT_SetZ(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_AlterFieldDefn")]
        public static extern int Layer_AlterFieldDefn(HandleRef jarg1, int jarg2, HandleRef jarg3, int jarg4);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Clip")]
        public static extern int Layer_Clip(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_CommitTransaction")]
        public static extern int Layer_CommitTransaction(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_CreateFeature")]
        public static extern int Layer_CreateFeature(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_CreateField")]
        public static extern int Layer_CreateField(HandleRef jarg1, HandleRef jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_CreateGeomField")]
        public static extern int Layer_CreateGeomField(HandleRef jarg1, HandleRef jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_DeleteFeature")]
        public static extern int Layer_DeleteFeature(HandleRef jarg1, long jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_DeleteField")]
        public static extern int Layer_DeleteField(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Erase")]
        public static extern int Layer_Erase(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_FindFieldIndex")]
        public static extern int Layer_FindFieldIndex(HandleRef jarg1, string jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetExtent")]
        public static extern int Layer_GetExtent(HandleRef jarg1, HandleRef jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetFeature")]
        public static extern IntPtr Layer_GetFeature(HandleRef jarg1, long jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetFeatureCount")]
        public static extern long Layer_GetFeatureCount(HandleRef jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetFeaturesRead")]
        public static extern long Layer_GetFeaturesRead(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetFIDColumn")]
        public static extern string Layer_GetFIDColumn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetGeometryColumn")]
        public static extern string Layer_GetGeometryColumn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetGeomType")]
        public static extern int Layer_GetGeomType(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetLayerDefn")]
        public static extern IntPtr Layer_GetLayerDefn(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetName")]
        public static extern string Layer_GetName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetNextFeature")]
        public static extern IntPtr Layer_GetNextFeature(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetRefCount")]
        public static extern int Layer_GetRefCount(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetSpatialFilter")]
        public static extern IntPtr Layer_GetSpatialFilter(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetSpatialRef")]
        public static extern IntPtr Layer_GetSpatialRef(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_GetStyleTable")]
        public static extern IntPtr Layer_GetStyleTable(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Identity")]
        public static extern int Layer_Identity(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Intersection")]
        public static extern int Layer_Intersection(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_ReorderField")]
        public static extern int Layer_ReorderField(HandleRef jarg1, int jarg2, int jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_ReorderFields")]
        public static extern int Layer_ReorderFields(HandleRef jarg1, int jarg2, int[] jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_ResetReading")]
        public static extern void Layer_ResetReading(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_RollbackTransaction")]
        public static extern int Layer_RollbackTransaction(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetAttributeFilter")]
        public static extern int Layer_SetAttributeFilter(HandleRef jarg1, byte[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetFeature")]
        public static extern int Layer_SetFeature(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetIgnoredFields")]
        public static extern int Layer_SetIgnoredFields(HandleRef jarg1, IntPtr[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetNextByIndex")]
        public static extern int Layer_SetNextByIndex(HandleRef jarg1, long jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetSpatialFilter__SWIG_0")]
        public static extern void Layer_SetSpatialFilter__SWIG_0(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetSpatialFilter__SWIG_1")]
        public static extern void Layer_SetSpatialFilter__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetSpatialFilterRect__SWIG_0")]
        public static extern void Layer_SetSpatialFilterRect__SWIG_0(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetSpatialFilterRect__SWIG_1")]
        public static extern void Layer_SetSpatialFilterRect__SWIG_1(HandleRef jarg1, int jarg2, double jarg3, double jarg4, double jarg5, double jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SetStyleTable")]
        public static extern void Layer_SetStyleTable(HandleRef jarg1, HandleRef jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_StartTransaction")]
        public static extern int Layer_StartTransaction(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SymDifference")]
        public static extern int Layer_SymDifference(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_SyncToDisk")]
        public static extern int Layer_SyncToDisk(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_TestCapability")]
        public static extern bool Layer_TestCapability(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Union")]
        public static extern int Layer_Union(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_Layer_Update")]
        public static extern int Layer_Update(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, IntPtr[] jarg4, Ogr.GDALProgressFuncDelegate jarg5, string jarg6);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_Envelope")]
        public static extern IntPtr new_Envelope();
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_Envelope3D")]
        public static extern IntPtr new_Envelope3D();
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_Feature")]
        public static extern IntPtr new_Feature(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_FeatureDefn")]
        public static extern IntPtr new_FeatureDefn(string jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_FieldDefn")]
        public static extern IntPtr new_FieldDefn(string jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_Geometry")]
        public static extern IntPtr new_Geometry(int jarg1, string jarg2, int jarg3, IntPtr jarg4, string jarg5);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_GeomFieldDefn")]
        public static extern IntPtr new_GeomFieldDefn(string jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_new_StyleTable")]
        public static extern IntPtr new_StyleTable();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODrCCreateDataSource_get")]
        public static extern string ODrCCreateDataSource_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODrCDeleteDataSource_get")]
        public static extern string ODrCDeleteDataSource_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCCreateGeomFieldAfterCreateLayer_get")]
        public static extern string ODsCCreateGeomFieldAfterCreateLayer_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCCreateLayer_get")]
        public static extern string ODsCCreateLayer_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCCurveGeometries_get")]
        public static extern string ODsCCurveGeometries_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCDeleteLayer_get")]
        public static extern string ODsCDeleteLayer_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCEmulatedTransactions_get")]
        public static extern string ODsCEmulatedTransactions_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCMeasuredGeometries_get")]
        public static extern string ODsCMeasuredGeometries_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCRandomLayerRead_get")]
        public static extern string ODsCRandomLayerRead_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCRandomLayerWrite_get")]
        public static extern string ODsCRandomLayerWrite_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ODsCTransactions_get")]
        public static extern string ODsCTransactions_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_CORRUPT_DATA_get")]
        public static extern int OGRERR_CORRUPT_DATA_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_FAILURE_get")]
        public static extern int OGRERR_FAILURE_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_INVALID_HANDLE_get")]
        public static extern int OGRERR_INVALID_HANDLE_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_NON_EXISTING_FEATURE_get")]
        public static extern int OGRERR_NON_EXISTING_FEATURE_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_NONE_get")]
        public static extern int OGRERR_NONE_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_NOT_ENOUGH_DATA_get")]
        public static extern int OGRERR_NOT_ENOUGH_DATA_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_NOT_ENOUGH_MEMORY_get")]
        public static extern int OGRERR_NOT_ENOUGH_MEMORY_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_UNSUPPORTED_GEOMETRY_TYPE_get")]
        public static extern int OGRERR_UNSUPPORTED_GEOMETRY_TYPE_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_UNSUPPORTED_OPERATION_get")]
        public static extern int OGRERR_UNSUPPORTED_OPERATION_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRERR_UNSUPPORTED_SRS_get")]
        public static extern int OGRERR_UNSUPPORTED_SRS_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRNullFID_get")]
        public static extern int OGRNullFID_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OGRUnsetMarker_get")]
        public static extern int OGRUnsetMarker_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_ogrZMarker_get")]
        public static extern int ogrZMarker_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCAlterFieldDefn_get")]
        public static extern string OLCAlterFieldDefn_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCCreateField_get")]
        public static extern string OLCCreateField_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCCreateGeomField_get")]
        public static extern string OLCCreateGeomField_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCCurveGeometries_get")]
        public static extern string OLCCurveGeometries_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCDeleteFeature_get")]
        public static extern string OLCDeleteFeature_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCDeleteField_get")]
        public static extern string OLCDeleteField_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCFastFeatureCount_get")]
        public static extern string OLCFastFeatureCount_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCFastGetExtent_get")]
        public static extern string OLCFastGetExtent_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCFastSetNextByIndex_get")]
        public static extern string OLCFastSetNextByIndex_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCFastSpatialFilter_get")]
        public static extern string OLCFastSpatialFilter_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCMeasuredGeometries_get")]
        public static extern string OLCMeasuredGeometries_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCRandomRead_get")]
        public static extern string OLCRandomRead_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCRandomWrite_get")]
        public static extern string OLCRandomWrite_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCReorderFields_get")]
        public static extern string OLCReorderFields_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCSequentialWrite_get")]
        public static extern string OLCSequentialWrite_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCStringsAsUTF8_get")]
        public static extern string OLCStringsAsUTF8_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLCTransactions_get")]
        public static extern string OLCTransactions_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_OLMD_FID64_get")]
        public static extern string OLMD_FID64_get();
        [DllImport("ogr_wrap", EntryPoint="CSharp_Open")]
        public static extern IntPtr Open(byte[] jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_OpenShared")]
        public static extern IntPtr OpenShared(byte[] jarg1, int jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_RegisterAll")]
        public static extern void RegisterAll();
        [DllImport("ogr_wrap", EntryPoint="CSharp_SetGenerate_DB2_V72_BYTE_ORDER")]
        public static extern int SetGenerate_DB2_V72_BYTE_ORDER(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_SetNonLinearGeometriesEnabledFlag")]
        public static extern void SetNonLinearGeometriesEnabledFlag(int jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StringListDestroy")]
        public static extern void StringListDestroy(IntPtr jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_AddStyle")]
        public static extern int StyleTable_AddStyle(HandleRef jarg1, string jarg2, string jarg3);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_Find")]
        public static extern string StyleTable_Find(HandleRef jarg1, string jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_GetLastStyleName")]
        public static extern string StyleTable_GetLastStyleName(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_GetNextStyle")]
        public static extern string StyleTable_GetNextStyle(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_LoadStyleTable")]
        public static extern int StyleTable_LoadStyleTable(HandleRef jarg1, byte[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_ResetStyleStringReading")]
        public static extern void StyleTable_ResetStyleStringReading(HandleRef jarg1);
        [DllImport("ogr_wrap", EntryPoint="CSharp_StyleTable_SaveStyleTable")]
        public static extern int StyleTable_SaveStyleTable(HandleRef jarg1, byte[] jarg2);
        [DllImport("ogr_wrap", EntryPoint="CSharp_UseExceptions")]
        public static extern void UseExceptions();
        [DllImport("ogr_wrap", EntryPoint="CSharp_wkb25DBit_get")]
        public static extern int wkb25DBit_get();

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
            private static ExceptionDelegate applicationDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingApplicationException);
            private static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingArgumentException);
            private static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingArgumentNullException);
            private static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingArgumentOutOfRangeException);
            private static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingArithmeticException);
            private static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingDivideByZeroException);
            private static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingIndexOutOfRangeException);
            private static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingInvalidCastException);
            private static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingInvalidOperationException);
            private static ExceptionDelegate ioDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingIOException);
            private static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingNullReferenceException);
            private static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingOutOfMemoryException);
            private static ExceptionDelegate overflowDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingOverflowException);
            private static ExceptionDelegate systemDelegate = new ExceptionDelegate(OgrPINVOKE.SWIGExceptionHelper.SetPendingSystemException);

            static SWIGExceptionHelper()
            {
                SWIGRegisterExceptionCallbacks_Ogr(applicationDelegate, arithmeticDelegate, divideByZeroDelegate, indexOutOfRangeDelegate, invalidCastDelegate, invalidOperationDelegate, ioDelegate, nullReferenceDelegate, outOfMemoryDelegate, overflowDelegate, systemDelegate);
                SWIGRegisterExceptionCallbacksArgument_Ogr(argumentDelegate, argumentNullDelegate, argumentOutOfRangeDelegate);
            }

            private static void SetPendingApplicationException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new ApplicationException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentException(string message, string paramName)
            {
                OgrPINVOKE.SWIGPendingException.Set(new ArgumentException(message, paramName, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingArgumentNullException(string message, string paramName)
            {
                Exception exception = OgrPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                OgrPINVOKE.SWIGPendingException.Set(new ArgumentNullException(paramName, message));
            }

            private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
            {
                Exception exception = OgrPINVOKE.SWIGPendingException.Retrieve();
                if (exception != null)
                {
                    message = message + " Inner Exception: " + exception.Message;
                }
                OgrPINVOKE.SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
            }

            private static void SetPendingArithmeticException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new ArithmeticException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingDivideByZeroException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new DivideByZeroException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIndexOutOfRangeException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new IndexOutOfRangeException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidCastException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new InvalidCastException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingInvalidOperationException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new InvalidOperationException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingIOException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new IOException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingNullReferenceException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new NullReferenceException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOutOfMemoryException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new OutOfMemoryException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingOverflowException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new OverflowException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            private static void SetPendingSystemException(string message)
            {
                OgrPINVOKE.SWIGPendingException.Set(new SystemException(message, OgrPINVOKE.SWIGPendingException.Retrieve()));
            }

            [DllImport("ogr_wrap")]
            public static extern void SWIGRegisterExceptionCallbacks_Ogr(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);
            [DllImport("ogr_wrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_Ogr")]
            public static extern void SWIGRegisterExceptionCallbacksArgument_Ogr(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

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
                    if (OgrPINVOKE.SWIGPendingException.pendingException == null)
                    {
                        return pendingException;
                    }
                    pendingException = OgrPINVOKE.SWIGPendingException.pendingException;
                    OgrPINVOKE.SWIGPendingException.pendingException = null;
                    lock (typeof(OgrPINVOKE))
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
                lock (typeof(OgrPINVOKE))
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
            private static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(OgrPINVOKE.SWIGStringHelper.CreateString);

            static SWIGStringHelper()
            {
                SWIGRegisterStringCallback_Ogr(stringDelegate);
            }

            private static string CreateString(string cString)
            {
                return cString;
            }

            [DllImport("ogr_wrap")]
            public static extern void SWIGRegisterStringCallback_Ogr(SWIGStringDelegate stringDelegate);

            public delegate string SWIGStringDelegate(string message);
        }
    }
}

