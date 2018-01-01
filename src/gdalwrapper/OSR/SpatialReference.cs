namespace OSGeo.OSR
{
    using System;
    using System.Runtime.InteropServices;

    public class SpatialReference : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public SpatialReference(string wkt) : this(OsrPINVOKE.new_SpatialReference(wkt), true, null)
        {
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public SpatialReference(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public string __str__()
        {
            string str = OsrPINVOKE.SpatialReference___str__(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int AutoIdentifyEPSG()
        {
            int num = OsrPINVOKE.SpatialReference_AutoIdentifyEPSG(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public SpatialReference Clone()
        {
            IntPtr cPtr = OsrPINVOKE.SpatialReference_Clone(this.swigCPtr);
            SpatialReference reference = (cPtr == IntPtr.Zero) ? null : new SpatialReference(cPtr, true, ThisOwn_true());
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return reference;
        }

        public SpatialReference CloneGeogCS()
        {
            IntPtr cPtr = OsrPINVOKE.SpatialReference_CloneGeogCS(this.swigCPtr);
            SpatialReference reference = (cPtr == IntPtr.Zero) ? null : new SpatialReference(cPtr, true, ThisOwn_true());
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return reference;
        }

        public int CopyGeogCSFrom(SpatialReference rhs)
        {
            int num = OsrPINVOKE.SpatialReference_CopyGeogCSFrom(this.swigCPtr, getCPtr(rhs));
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
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
                    OsrPINVOKE.delete_SpatialReference(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public int EPSGTreatsAsLatLong()
        {
            int num = OsrPINVOKE.SpatialReference_EPSGTreatsAsLatLong(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int EPSGTreatsAsNorthingEasting()
        {
            int num = OsrPINVOKE.SpatialReference_EPSGTreatsAsNorthingEasting(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToMICoordSys(out string argout)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToMICoordSys(this.swigCPtr, out argout);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToPCI(out string proj, out string units)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToPCI(this.swigCPtr, out proj, out units);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToPrettyWkt(out string argout, int simplify)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToPrettyWkt(this.swigCPtr, out argout, simplify);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToProj4(out string argout)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToProj4(this.swigCPtr, out argout);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToUSGS(out int code, out int zone, out int datum)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToUSGS(this.swigCPtr, out code, out zone, out datum);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToWkt(out string argout)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToWkt(this.swigCPtr, out argout);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ExportToXML(out string argout, string dialect)
        {
            int num = OsrPINVOKE.SpatialReference_ExportToXML(this.swigCPtr, out argout, dialect);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        ~SpatialReference()
        {
            this.Dispose();
        }

        public int Fixup()
        {
            int num = OsrPINVOKE.SpatialReference_Fixup(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int FixupOrdering()
        {
            int num = OsrPINVOKE.SpatialReference_FixupOrdering(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetAngularUnits()
        {
            double num = OsrPINVOKE.SpatialReference_GetAngularUnits(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetAngularUnitsName()
        {
            string str = OsrPINVOKE.SpatialReference_GetAngularUnitsName(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetAttrValue(string name, int child)
        {
            string str = OsrPINVOKE.SpatialReference_GetAttrValue(this.swigCPtr, name, child);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetAuthorityCode(string target_key)
        {
            string str = OsrPINVOKE.SpatialReference_GetAuthorityCode(this.swigCPtr, target_key);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetAuthorityName(string target_key)
        {
            string str = OsrPINVOKE.SpatialReference_GetAuthorityName(this.swigCPtr, target_key);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetAxisName(string target_key, int iAxis)
        {
            string str = OsrPINVOKE.SpatialReference_GetAxisName(this.swigCPtr, target_key, iAxis);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public AxisOrientation GetAxisOrientation(string target_key, int iAxis)
        {
            AxisOrientation orientation = (AxisOrientation) OsrPINVOKE.SpatialReference_GetAxisOrientation(this.swigCPtr, target_key, iAxis);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return orientation;
        }

        public static HandleRef getCPtr(SpatialReference obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(SpatialReference obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(SpatialReference obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public double GetInvFlattening()
        {
            double num = OsrPINVOKE.SpatialReference_GetInvFlattening(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetLinearUnits()
        {
            double num = OsrPINVOKE.SpatialReference_GetLinearUnits(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetLinearUnitsName()
        {
            string str = OsrPINVOKE.SpatialReference_GetLinearUnitsName(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public double GetNormProjParm(string name, double default_val)
        {
            double num = OsrPINVOKE.SpatialReference_GetNormProjParm(this.swigCPtr, name, default_val);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetProjParm(string name, double default_val)
        {
            double num = OsrPINVOKE.SpatialReference_GetProjParm(this.swigCPtr, name, default_val);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetSemiMajor()
        {
            double num = OsrPINVOKE.SpatialReference_GetSemiMajor(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetSemiMinor()
        {
            double num = OsrPINVOKE.SpatialReference_GetSemiMinor(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public double GetTargetLinearUnits(string target_key)
        {
            double num = OsrPINVOKE.SpatialReference_GetTargetLinearUnits(this.swigCPtr, target_key);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetTOWGS84(double[] argout)
        {
            int num = OsrPINVOKE.SpatialReference_GetTOWGS84(this.swigCPtr, argout);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetUTMZone()
        {
            int num = OsrPINVOKE.SpatialReference_GetUTMZone(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromEPSG(int arg)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromEPSG(this.swigCPtr, arg);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromEPSGA(int arg)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromEPSGA(this.swigCPtr, arg);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromERM(string proj, string datum, string units)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromERM(this.swigCPtr, proj, datum, units);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromESRI(string[] ppszInput)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromESRI(this.swigCPtr, (ppszInput != null) ? new OsrPINVOKE.StringListMarshal(ppszInput)._ar : null);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromMICoordSys(string pszCoordSys)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromMICoordSys(this.swigCPtr, pszCoordSys);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromOzi(string[] papszLines)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromOzi(this.swigCPtr, (papszLines != null) ? new OsrPINVOKE.StringListMarshal(papszLines)._ar : null);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromPCI(string proj, string units, double[] argin)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromPCI(this.swigCPtr, proj, units, argin);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromProj4(string ppszInput)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromProj4(this.swigCPtr, ppszInput);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromUrl(string url)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromUrl(this.swigCPtr, url);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromUSGS(int proj_code, int zone, double[] argin, int datum_code)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromUSGS(this.swigCPtr, proj_code, zone, argin, datum_code);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromWkt(ref string ppszInput)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromWkt(this.swigCPtr, ref ppszInput);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int ImportFromXML(string xmlString)
        {
            int num = OsrPINVOKE.SpatialReference_ImportFromXML(this.swigCPtr, xmlString);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsCompound()
        {
            int num = OsrPINVOKE.SpatialReference_IsCompound(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsGeocentric()
        {
            int num = OsrPINVOKE.SpatialReference_IsGeocentric(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsGeographic()
        {
            int num = OsrPINVOKE.SpatialReference_IsGeographic(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsLocal()
        {
            int num = OsrPINVOKE.SpatialReference_IsLocal(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsProjected()
        {
            int num = OsrPINVOKE.SpatialReference_IsProjected(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsSame(SpatialReference rhs)
        {
            int num = OsrPINVOKE.SpatialReference_IsSame(this.swigCPtr, getCPtr(rhs));
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsSameGeogCS(SpatialReference rhs)
        {
            int num = OsrPINVOKE.SpatialReference_IsSameGeogCS(this.swigCPtr, getCPtr(rhs));
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsSameVertCS(SpatialReference rhs)
        {
            int num = OsrPINVOKE.SpatialReference_IsSameVertCS(this.swigCPtr, getCPtr(rhs));
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsVertical()
        {
            int num = OsrPINVOKE.SpatialReference_IsVertical(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int MorphFromESRI()
        {
            int num = OsrPINVOKE.SpatialReference_MorphFromESRI(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int MorphToESRI()
        {
            int num = OsrPINVOKE.SpatialReference_MorphToESRI(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetACEA(double stdp1, double stdp2, double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetACEA(this.swigCPtr, stdp1, stdp2, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetAE(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetAE(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetAngularUnits(string name, double to_radians)
        {
            int num = OsrPINVOKE.SpatialReference_SetAngularUnits(this.swigCPtr, name, to_radians);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetAttrValue(string name, string value)
        {
            int num = OsrPINVOKE.SpatialReference_SetAttrValue(this.swigCPtr, name, value);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetAuthority(string pszTargetKey, string pszAuthority, int nCode)
        {
            int num = OsrPINVOKE.SpatialReference_SetAuthority(this.swigCPtr, pszTargetKey, pszAuthority, nCode);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetBonne(double stdp, double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetBonne(this.swigCPtr, stdp, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetCEA(double stdp1, double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetCEA(this.swigCPtr, stdp1, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetCompoundCS(string name, SpatialReference horizcs, SpatialReference vertcs)
        {
            int num = OsrPINVOKE.SpatialReference_SetCompoundCS(this.swigCPtr, name, getCPtr(horizcs), getCPtr(vertcs));
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetCS(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetCS(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetEC(double stdp1, double stdp2, double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetEC(this.swigCPtr, stdp1, stdp2, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetEckertIV(double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetEckertIV(this.swigCPtr, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetEckertVI(double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetEckertVI(this.swigCPtr, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetEquirectangular(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetEquirectangular(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetEquirectangular2(double clat, double clong, double pseudostdparallellat, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetEquirectangular2(this.swigCPtr, clat, clong, pseudostdparallellat, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetFromUserInput(string name)
        {
            int num = OsrPINVOKE.SpatialReference_SetFromUserInput(this.swigCPtr, name);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGaussSchreiberTMercator(double clat, double clong, double sc, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetGaussSchreiberTMercator(this.swigCPtr, clat, clong, sc, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeocCS(string name)
        {
            int num = OsrPINVOKE.SpatialReference_SetGeocCS(this.swigCPtr, name);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGeogCS(string pszGeogName, string pszDatumName, string pszEllipsoidName, double dfSemiMajor, double dfInvFlattening, string pszPMName, double dfPMOffset, string pszUnits, double dfConvertToRadians)
        {
            int num = OsrPINVOKE.SpatialReference_SetGeogCS(this.swigCPtr, pszGeogName, pszDatumName, pszEllipsoidName, dfSemiMajor, dfInvFlattening, pszPMName, dfPMOffset, pszUnits, dfConvertToRadians);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGEOS(double cm, double satelliteheight, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetGEOS(this.swigCPtr, cm, satelliteheight, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGH(double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetGH(this.swigCPtr, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGnomonic(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetGnomonic(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetGS(double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetGS(this.swigCPtr, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetHOM(double clat, double clong, double azimuth, double recttoskew, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetHOM(this.swigCPtr, clat, clong, azimuth, recttoskew, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetHOM2PNO(double clat, double dfLat1, double dfLong1, double dfLat2, double dfLong2, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetHOM2PNO(this.swigCPtr, clat, dfLat1, dfLong1, dfLat2, dfLong2, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetIGH()
        {
            int num = OsrPINVOKE.SpatialReference_SetIGH(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetKrovak(double clat, double clong, double azimuth, double pseudostdparallellat, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetKrovak(this.swigCPtr, clat, clong, azimuth, pseudostdparallellat, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLAEA(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetLAEA(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLCC(double stdp1, double stdp2, double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetLCC(this.swigCPtr, stdp1, stdp2, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLCC1SP(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetLCC1SP(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLCCB(double stdp1, double stdp2, double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetLCCB(this.swigCPtr, stdp1, stdp2, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLinearUnits(string name, double to_meters)
        {
            int num = OsrPINVOKE.SpatialReference_SetLinearUnits(this.swigCPtr, name, to_meters);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLinearUnitsAndUpdateParameters(string name, double to_meters)
        {
            int num = OsrPINVOKE.SpatialReference_SetLinearUnitsAndUpdateParameters(this.swigCPtr, name, to_meters);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetLocalCS(string pszName)
        {
            int num = OsrPINVOKE.SpatialReference_SetLocalCS(this.swigCPtr, pszName);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetMC(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetMC(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetMercator(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetMercator(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetMollweide(double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetMollweide(this.swigCPtr, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetNormProjParm(string name, double val)
        {
            int num = OsrPINVOKE.SpatialReference_SetNormProjParm(this.swigCPtr, name, val);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetNZMG(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetNZMG(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetOrthographic(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetOrthographic(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetOS(double dfOriginLat, double dfCMeridian, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetOS(this.swigCPtr, dfOriginLat, dfCMeridian, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetPolyconic(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetPolyconic(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetProjCS(string name)
        {
            int num = OsrPINVOKE.SpatialReference_SetProjCS(this.swigCPtr, name);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetProjection(string arg)
        {
            int num = OsrPINVOKE.SpatialReference_SetProjection(this.swigCPtr, arg);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetProjParm(string name, double val)
        {
            int num = OsrPINVOKE.SpatialReference_SetProjParm(this.swigCPtr, name, val);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetPS(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetPS(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetRobinson(double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetRobinson(this.swigCPtr, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetSinusoidal(double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetSinusoidal(this.swigCPtr, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetSOC(double latitudeoforigin, double cm, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetSOC(this.swigCPtr, latitudeoforigin, cm, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetStatePlane(int zone, int is_nad83, string unitsname, double units)
        {
            int num = OsrPINVOKE.SpatialReference_SetStatePlane(this.swigCPtr, zone, is_nad83, unitsname, units);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetStereographic(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetStereographic(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTargetLinearUnits(string target, string name, double to_meters)
        {
            int num = OsrPINVOKE.SpatialReference_SetTargetLinearUnits(this.swigCPtr, target, name, to_meters);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTM(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetTM(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTMG(double clat, double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetTMG(this.swigCPtr, clat, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTMSO(double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetTMSO(this.swigCPtr, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTMVariant(string pszVariantName, double clat, double clong, double scale, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetTMVariant(this.swigCPtr, pszVariantName, clat, clong, scale, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetTOWGS84(double p1, double p2, double p3, double p4, double p5, double p6, double p7)
        {
            int num = OsrPINVOKE.SpatialReference_SetTOWGS84(this.swigCPtr, p1, p2, p3, p4, p5, p6, p7);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetUTM(int zone, int north)
        {
            int num = OsrPINVOKE.SpatialReference_SetUTM(this.swigCPtr, zone, north);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetVDG(double clong, double fe, double fn)
        {
            int num = OsrPINVOKE.SpatialReference_SetVDG(this.swigCPtr, clong, fe, fn);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetVertCS(string VertCSName, string VertDatumName, int VertDatumType)
        {
            int num = OsrPINVOKE.SpatialReference_SetVertCS(this.swigCPtr, VertCSName, VertDatumName, VertDatumType);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int SetWellKnownGeogCS(string name)
        {
            int num = OsrPINVOKE.SpatialReference_SetWellKnownGeogCS(this.swigCPtr, name);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int StripCTParms()
        {
            int num = OsrPINVOKE.SpatialReference_StripCTParms(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
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

        public int Validate()
        {
            int num = OsrPINVOKE.SpatialReference_Validate(this.swigCPtr);
            if (OsrPINVOKE.SWIGPendingException.Pending)
            {
                throw OsrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }
    }
}

