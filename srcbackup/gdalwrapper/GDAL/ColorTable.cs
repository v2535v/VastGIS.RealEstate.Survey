namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class ColorTable : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public ColorTable(PaletteInterp palette) : this(GdalPINVOKE.new_ColorTable((int) palette), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public ColorTable(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public ColorTable Clone()
        {
            IntPtr cPtr = GdalPINVOKE.ColorTable_Clone(this.swigCPtr);
            ColorTable table = (cPtr == IntPtr.Zero) ? null : new ColorTable(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return table;
        }

        public void CreateColorRamp(int nStartIndex, ColorEntry startcolor, int nEndIndex, ColorEntry endcolor)
        {
            GdalPINVOKE.ColorTable_CreateColorRamp(this.swigCPtr, nStartIndex, ColorEntry.getCPtr(startcolor), nEndIndex, ColorEntry.getCPtr(endcolor));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    GdalPINVOKE.delete_ColorTable(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~ColorTable()
        {
            this.Dispose();
        }

        public ColorEntry GetColorEntry(int entry)
        {
            IntPtr cPtr = GdalPINVOKE.ColorTable_GetColorEntry(this.swigCPtr, entry);
            ColorEntry entry2 = (cPtr == IntPtr.Zero) ? null : new ColorEntry(cPtr, false, this.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return entry2;
        }

        public int GetColorEntryAsRGB(int entry, ColorEntry centry)
        {
            int num = GdalPINVOKE.ColorTable_GetColorEntryAsRGB(this.swigCPtr, entry, ColorEntry.getCPtr(centry));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int GetCount()
        {
            int num = GdalPINVOKE.ColorTable_GetCount(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public static HandleRef getCPtr(ColorTable obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(ColorTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(ColorTable obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public PaletteInterp GetPaletteInterpretation()
        {
            PaletteInterp interp = (PaletteInterp) GdalPINVOKE.ColorTable_GetPaletteInterpretation(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return interp;
        }

        public void SetColorEntry(int entry, ColorEntry centry)
        {
            GdalPINVOKE.ColorTable_SetColorEntry(this.swigCPtr, entry, ColorEntry.getCPtr(centry));
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

