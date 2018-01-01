namespace OSGeo.OGR
{
    using OSGeo.OSR;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    public class Ogr
    {
        public static readonly string ODrCCreateDataSource = OgrPINVOKE.ODrCCreateDataSource_get();
        public static readonly string ODrCDeleteDataSource = OgrPINVOKE.ODrCDeleteDataSource_get();
        public static readonly string ODsCCreateGeomFieldAfterCreateLayer = OgrPINVOKE.ODsCCreateGeomFieldAfterCreateLayer_get();
        public static readonly string ODsCCreateLayer = OgrPINVOKE.ODsCCreateLayer_get();
        public static readonly string ODsCCurveGeometries = OgrPINVOKE.ODsCCurveGeometries_get();
        public static readonly string ODsCDeleteLayer = OgrPINVOKE.ODsCDeleteLayer_get();
        public static readonly string ODsCEmulatedTransactions = OgrPINVOKE.ODsCEmulatedTransactions_get();
        public static readonly string ODsCMeasuredGeometries = OgrPINVOKE.ODsCMeasuredGeometries_get();
        public static readonly string ODsCRandomLayerRead = OgrPINVOKE.ODsCRandomLayerRead_get();
        public static readonly string ODsCRandomLayerWrite = OgrPINVOKE.ODsCRandomLayerWrite_get();
        public static readonly string ODsCTransactions = OgrPINVOKE.ODsCTransactions_get();
        public static readonly int OGRERR_CORRUPT_DATA = OgrPINVOKE.OGRERR_CORRUPT_DATA_get();
        public static readonly int OGRERR_FAILURE = OgrPINVOKE.OGRERR_FAILURE_get();
        public static readonly int OGRERR_INVALID_HANDLE = OgrPINVOKE.OGRERR_INVALID_HANDLE_get();
        public static readonly int OGRERR_NON_EXISTING_FEATURE = OgrPINVOKE.OGRERR_NON_EXISTING_FEATURE_get();
        public static readonly int OGRERR_NONE = OgrPINVOKE.OGRERR_NONE_get();
        public static readonly int OGRERR_NOT_ENOUGH_DATA = OgrPINVOKE.OGRERR_NOT_ENOUGH_DATA_get();
        public static readonly int OGRERR_NOT_ENOUGH_MEMORY = OgrPINVOKE.OGRERR_NOT_ENOUGH_MEMORY_get();
        public static readonly int OGRERR_UNSUPPORTED_GEOMETRY_TYPE = OgrPINVOKE.OGRERR_UNSUPPORTED_GEOMETRY_TYPE_get();
        public static readonly int OGRERR_UNSUPPORTED_OPERATION = OgrPINVOKE.OGRERR_UNSUPPORTED_OPERATION_get();
        public static readonly int OGRERR_UNSUPPORTED_SRS = OgrPINVOKE.OGRERR_UNSUPPORTED_SRS_get();
        public static readonly int OGRNullFID = OgrPINVOKE.OGRNullFID_get();
        public static readonly int OGRUnsetMarker = OgrPINVOKE.OGRUnsetMarker_get();
        public static readonly int ogrZMarker = OgrPINVOKE.ogrZMarker_get();
        public static readonly string OLCAlterFieldDefn = OgrPINVOKE.OLCAlterFieldDefn_get();
        public static readonly string OLCCreateField = OgrPINVOKE.OLCCreateField_get();
        public static readonly string OLCCreateGeomField = OgrPINVOKE.OLCCreateGeomField_get();
        public static readonly string OLCCurveGeometries = OgrPINVOKE.OLCCurveGeometries_get();
        public static readonly string OLCDeleteFeature = OgrPINVOKE.OLCDeleteFeature_get();
        public static readonly string OLCDeleteField = OgrPINVOKE.OLCDeleteField_get();
        public static readonly string OLCFastFeatureCount = OgrPINVOKE.OLCFastFeatureCount_get();
        public static readonly string OLCFastGetExtent = OgrPINVOKE.OLCFastGetExtent_get();
        public static readonly string OLCFastSetNextByIndex = OgrPINVOKE.OLCFastSetNextByIndex_get();
        public static readonly string OLCFastSpatialFilter = OgrPINVOKE.OLCFastSpatialFilter_get();
        public static readonly string OLCMeasuredGeometries = OgrPINVOKE.OLCMeasuredGeometries_get();
        public static readonly string OLCRandomRead = OgrPINVOKE.OLCRandomRead_get();
        public static readonly string OLCRandomWrite = OgrPINVOKE.OLCRandomWrite_get();
        public static readonly string OLCReorderFields = OgrPINVOKE.OLCReorderFields_get();
        public static readonly string OLCSequentialWrite = OgrPINVOKE.OLCSequentialWrite_get();
        public static readonly string OLCStringsAsUTF8 = OgrPINVOKE.OLCStringsAsUTF8_get();
        public static readonly string OLCTransactions = OgrPINVOKE.OLCTransactions_get();
        public static readonly string OLMD_FID64 = OgrPINVOKE.OLMD_FID64_get();
        internal static OgrObject theOgrObject = new OgrObject();
        public static readonly int wkb25DBit = OgrPINVOKE.wkb25DBit_get();

        public static Geometry ApproximateArcAngles(double dfCenterX, double dfCenterY, double dfZ, double dfPrimaryRadius, double dfSecondaryAxis, double dfRotation, double dfStartAngle, double dfEndAngle, double dfMaxAngleStepSizeDegrees)
        {
            IntPtr cPtr = OgrPINVOKE.ApproximateArcAngles(dfCenterX, dfCenterY, dfZ, dfPrimaryRadius, dfSecondaryAxis, dfRotation, dfStartAngle, dfEndAngle, dfMaxAngleStepSizeDegrees);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry BuildPolygonFromEdges(Geometry hLineCollection, int bBestEffort, int bAutoClose, double dfTolerance)
        {
            IntPtr cPtr = OgrPINVOKE.BuildPolygonFromEdges(Geometry.getCPtr(hLineCollection), bBestEffort, bAutoClose, dfTolerance);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry CreateGeometryFromGML(string input_string)
        {
            IntPtr cPtr = OgrPINVOKE.CreateGeometryFromGML(input_string);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry CreateGeometryFromJson(string input_string)
        {
            IntPtr cPtr = OgrPINVOKE.CreateGeometryFromJson(input_string);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry CreateGeometryFromWkb(int len, IntPtr bin_string, SpatialReference reference)
        {
            IntPtr cPtr = OgrPINVOKE.CreateGeometryFromWkb(len, bin_string, SpatialReference.getCPtr(reference));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry CreateGeometryFromWkt(ref string val, SpatialReference reference)
        {
            IntPtr cPtr = OgrPINVOKE.CreateGeometryFromWkt(ref val, SpatialReference.getCPtr(reference));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static void DontUseExceptions()
        {
            OgrPINVOKE.DontUseExceptions();
        }

        public static Geometry ForceTo(Geometry geom_in, wkbGeometryType eTargetType, string[] options)
        {
            IntPtr cPtr = OgrPINVOKE.ForceTo(Geometry.getCPtr(geom_in), (int) eTargetType, (options != null) ? new OgrPINVOKE.StringListMarshal(options)._ar : null);
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry ForceToLineString(Geometry geom_in)
        {
            IntPtr cPtr = OgrPINVOKE.ForceToLineString(Geometry.getCPtr(geom_in));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry ForceToMultiLineString(Geometry geom_in)
        {
            IntPtr cPtr = OgrPINVOKE.ForceToMultiLineString(Geometry.getCPtr(geom_in));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry ForceToMultiPoint(Geometry geom_in)
        {
            IntPtr cPtr = OgrPINVOKE.ForceToMultiPoint(Geometry.getCPtr(geom_in));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry ForceToMultiPolygon(Geometry geom_in)
        {
            IntPtr cPtr = OgrPINVOKE.ForceToMultiPolygon(Geometry.getCPtr(geom_in));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static Geometry ForceToPolygon(Geometry geom_in)
        {
            IntPtr cPtr = OgrPINVOKE.ForceToPolygon(Geometry.getCPtr(geom_in));
            Geometry geometry = (cPtr == IntPtr.Zero) ? null : new Geometry(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return geometry;
        }

        public static string[] GeneralCmdLineProcessor(string[] papszArgv, int nOptions)
        {
            IntPtr ptr = OgrPINVOKE.GeneralCmdLineProcessor((papszArgv != null) ? new OgrPINVOKE.StringListMarshal(papszArgv)._ar : null, nOptions);
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
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return strArray;
        }

        public static string GeometryTypeToName(wkbGeometryType eType)
        {
            string str = OgrPINVOKE.GeometryTypeToName((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public static Driver GetDriver(int driver_number)
        {
            IntPtr cPtr = OgrPINVOKE.GetDriver(driver_number);
            Driver driver = (cPtr == IntPtr.Zero) ? null : new Driver(cPtr, false, ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static Driver GetDriverByName(string name)
        {
            IntPtr driverByName = OgrPINVOKE.GetDriverByName(name);
            Driver driver = (driverByName == IntPtr.Zero) ? null : new Driver(driverByName, false, ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return driver;
        }

        public static int GetDriverCount()
        {
            int driverCount = OgrPINVOKE.GetDriverCount();
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return driverCount;
        }

        public static string GetFieldSubTypeName(FieldSubType type)
        {
            string fieldSubTypeName = OgrPINVOKE.GetFieldSubTypeName((int) type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return fieldSubTypeName;
        }

        public static string GetFieldTypeName(FieldType type)
        {
            string fieldTypeName = OgrPINVOKE.GetFieldTypeName((int) type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return fieldTypeName;
        }

        public static int GetNonLinearGeometriesEnabledFlag()
        {
            int nonLinearGeometriesEnabledFlag = OgrPINVOKE.GetNonLinearGeometriesEnabledFlag();
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return nonLinearGeometriesEnabledFlag;
        }

        public static DataSource GetOpenDS(int ds_number)
        {
            IntPtr openDS = OgrPINVOKE.GetOpenDS(ds_number);
            DataSource source = (openDS == IntPtr.Zero) ? null : new DataSource(openDS, false, ThisOwn_false());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public static int GetOpenDSCount()
        {
            int openDSCount = OgrPINVOKE.GetOpenDSCount();
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return openDSCount;
        }

        public static wkbGeometryType GT_Flatten(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_Flatten((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static wkbGeometryType GT_GetCollection(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_GetCollection((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static wkbGeometryType GT_GetCurve(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_GetCurve((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static wkbGeometryType GT_GetLinear(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_GetLinear((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static int GT_HasM(wkbGeometryType eType)
        {
            int num = OgrPINVOKE.GT_HasM((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GT_HasZ(wkbGeometryType eType)
        {
            int num = OgrPINVOKE.GT_HasZ((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GT_IsCurve(wkbGeometryType arg0)
        {
            int num = OgrPINVOKE.GT_IsCurve((int) arg0);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GT_IsNonLinear(wkbGeometryType arg0)
        {
            int num = OgrPINVOKE.GT_IsNonLinear((int) arg0);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GT_IsSubClassOf(wkbGeometryType eType, wkbGeometryType eSuperType)
        {
            int num = OgrPINVOKE.GT_IsSubClassOf((int) eType, (int) eSuperType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static int GT_IsSurface(wkbGeometryType arg0)
        {
            int num = OgrPINVOKE.GT_IsSurface((int) arg0);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static wkbGeometryType GT_SetM(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_SetM((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static wkbGeometryType GT_SetModifier(wkbGeometryType eType, int bSetZ, int bSetM)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_SetModifier((int) eType, bSetZ, bSetM);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static wkbGeometryType GT_SetZ(wkbGeometryType eType)
        {
            wkbGeometryType type = (wkbGeometryType) OgrPINVOKE.GT_SetZ((int) eType);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public static DataSource Open(string utf8_path, int update)
        {
            IntPtr cPtr = OgrPINVOKE.Open(StringToUtf8Bytes(utf8_path), update);
            DataSource source = (cPtr == IntPtr.Zero) ? null : new DataSource(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public static DataSource OpenShared(string utf8_path, int update)
        {
            IntPtr cPtr = OgrPINVOKE.OpenShared(StringToUtf8Bytes(utf8_path), update);
            DataSource source = (cPtr == IntPtr.Zero) ? null : new DataSource(cPtr, true, ThisOwn_true());
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return source;
        }

        public static void RegisterAll()
        {
            OgrPINVOKE.RegisterAll();
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public static int SetGenerate_DB2_V72_BYTE_ORDER(int bGenerate_DB2_V72_BYTE_ORDER)
        {
            int num = OgrPINVOKE.SetGenerate_DB2_V72_BYTE_ORDER(bGenerate_DB2_V72_BYTE_ORDER);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static void SetNonLinearGeometriesEnabledFlag(int bFlag)
        {
            OgrPINVOKE.SetNonLinearGeometriesEnabledFlag(bFlag);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        internal static void StringListDestroy(IntPtr buffer_ptr)
        {
            OgrPINVOKE.StringListDestroy(buffer_ptr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
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
            return theOgrObject;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }

        public static void UseExceptions()
        {
            OgrPINVOKE.UseExceptions();
        }

        internal static string Utf8BytesToString(IntPtr pNativeData)
        {
            //if (pNativeData == IntPtr.Zero)
            //{
            //    return null;
            //}
            //int length = Marshal.PtrToStringAnsi(pNativeData).Length*2;
            //byte[] destination = new byte[length];
            //Marshal.Copy(pNativeData, destination, 0, length);
            //return Encoding.UTF8.GetString(destination);

            if (pNativeData == IntPtr.Zero)
                return "";

            //下面这一长串就是获取C字符串的长度，用Marshal库中的函数获取的都有问题，所以就用下面的循环来自己找了，如果有更好的方案请告知。
            int nAnsiLength = Marshal.PtrToStringAnsi(pNativeData).Length*2;
            int nUniLength = Marshal.PtrToStringUni(pNativeData).Length;
            int nMaxLength = (nAnsiLength > nUniLength) ? nAnsiLength : nUniLength;
            int length = 0;
            for (int i = 0; i < nMaxLength; i++)
            {
                byte[] strbuf1 = new byte[1];
                Marshal.Copy(pNativeData + i, strbuf1, 0, 1);
                if (strbuf1[0] == 0)
                {
                    break;
                }
                length++;
            }

            byte[] strbuf = new byte[length];
            Marshal.Copy(pNativeData, strbuf, 0, length);
            return System.Text.Encoding.UTF8.GetString(strbuf);
        }

        public delegate void GDALErrorHandlerDelegate(int eclass, int code, IntPtr msg);

        public delegate int GDALProgressFuncDelegate(double Complete, IntPtr Message, IntPtr Data);

        internal class OgrObject : IDisposable
        {
            public virtual void Dispose()
            {
            }
        }
    }
}

