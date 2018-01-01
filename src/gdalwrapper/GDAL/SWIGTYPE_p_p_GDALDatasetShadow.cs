namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class SWIGTYPE_p_p_GDALDatasetShadow
    {
        private HandleRef swigCPtr;

        protected SWIGTYPE_p_p_GDALDatasetShadow()
        {
            this.swigCPtr = new HandleRef(null, IntPtr.Zero);
        }

        public SWIGTYPE_p_p_GDALDatasetShadow(IntPtr cPtr, bool futureUse, object parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public static HandleRef getCPtr(SWIGTYPE_p_p_GDALDatasetShadow obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }
    }
}

