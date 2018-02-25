namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class RasterAttributeTable : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public RasterAttributeTable() : this(GdalPINVOKE.new_RasterAttributeTable(), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public RasterAttributeTable(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public int ChangesAreWrittenToFile()
        {
            int num = GdalPINVOKE.RasterAttributeTable_ChangesAreWrittenToFile(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public RasterAttributeTable Clone()
        {
            IntPtr cPtr = GdalPINVOKE.RasterAttributeTable_Clone(this.swigCPtr);
            RasterAttributeTable table = (cPtr == IntPtr.Zero) ? null : new RasterAttributeTable(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public int CreateColumn(string pszName, RATFieldType eType, RATFieldUsage eUsage)
        {
            int num = GdalPINVOKE.RasterAttributeTable_CreateColumn(this.swigCPtr, pszName, (int) eType, (int) eUsage);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
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
                    GdalPINVOKE.delete_RasterAttributeTable(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        public void DumpReadable()
        {
            GdalPINVOKE.RasterAttributeTable_DumpReadable(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        ~RasterAttributeTable()
        {
            this.Dispose();
        }

        public int GetColOfUsage(RATFieldUsage eUsage)
        {
            int num = GdalPINVOKE.RasterAttributeTable_GetColOfUsage(this.swigCPtr, (int) eUsage);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetColumnCount()
        {
            int num = GdalPINVOKE.RasterAttributeTable_GetColumnCount(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static HandleRef getCPtr(RasterAttributeTable obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(RasterAttributeTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(RasterAttributeTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public bool GetLinearBinning(out double pdfRow0Min, out double pdfBinSize)
        {
            bool flag = GdalPINVOKE.RasterAttributeTable_GetLinearBinning(this.swigCPtr, out pdfRow0Min, out pdfBinSize);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return flag;
        }

        public string GetNameOfCol(int iCol)
        {
            string str = GdalPINVOKE.RasterAttributeTable_GetNameOfCol(this.swigCPtr, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int GetRowCount()
        {
            int num = GdalPINVOKE.RasterAttributeTable_GetRowCount(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetRowOfValue(double dfValue)
        {
            int num = GdalPINVOKE.RasterAttributeTable_GetRowOfValue(this.swigCPtr, dfValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public RATFieldType GetTypeOfCol(int iCol)
        {
            RATFieldType type = (RATFieldType) GdalPINVOKE.RasterAttributeTable_GetTypeOfCol(this.swigCPtr, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public RATFieldUsage GetUsageOfCol(int iCol)
        {
            RATFieldUsage usage = (RATFieldUsage) GdalPINVOKE.RasterAttributeTable_GetUsageOfCol(this.swigCPtr, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return usage;
        }

        public double GetValueAsDouble(int iRow, int iCol)
        {
            double num = GdalPINVOKE.RasterAttributeTable_GetValueAsDouble(this.swigCPtr, iRow, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetValueAsInt(int iRow, int iCol)
        {
            int num = GdalPINVOKE.RasterAttributeTable_GetValueAsInt(this.swigCPtr, iRow, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public string GetValueAsString(int iRow, int iCol)
        {
            string str = GdalPINVOKE.RasterAttributeTable_GetValueAsString(this.swigCPtr, iRow, iCol);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int SetLinearBinning(double dfRow0Min, double dfBinSize)
        {
            int num = GdalPINVOKE.RasterAttributeTable_SetLinearBinning(this.swigCPtr, dfRow0Min, dfBinSize);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetRowCount(int nCount)
        {
            GdalPINVOKE.RasterAttributeTable_SetRowCount(this.swigCPtr, nCount);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetValueAsDouble(int iRow, int iCol, double dfValue)
        {
            GdalPINVOKE.RasterAttributeTable_SetValueAsDouble(this.swigCPtr, iRow, iCol, dfValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetValueAsInt(int iRow, int iCol, int nValue)
        {
            GdalPINVOKE.RasterAttributeTable_SetValueAsInt(this.swigCPtr, iRow, iCol, nValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetValueAsString(int iRow, int iCol, string pszValue)
        {
            GdalPINVOKE.RasterAttributeTable_SetValueAsString(this.swigCPtr, iRow, iCol, pszValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        protected object ThisOwn_false()
        {
            return this;
        }

        protected static object ThisOwn_true()
        {
            return null;
        }
    }
}

