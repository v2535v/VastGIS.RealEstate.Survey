namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class SWIGTYPE_p_p_GDALRasterBandShadow
    {
        private HandleRef swigCPtr;

        protected SWIGTYPE_p_p_GDALRasterBandShadow()
        {
            this.swigCPtr = new HandleRef(null, IntPtr.Zero);
        }

        public SWIGTYPE_p_p_GDALRasterBandShadow(IntPtr cPtr, bool futureUse, object parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public static HandleRef getCPtr(SWIGTYPE_p_p_GDALRasterBandShadow obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }
    }
}

