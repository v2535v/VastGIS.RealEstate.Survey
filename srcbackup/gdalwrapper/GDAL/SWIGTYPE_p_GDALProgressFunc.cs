namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class SWIGTYPE_p_GDALProgressFunc
    {
        private HandleRef swigCPtr;

        protected SWIGTYPE_p_GDALProgressFunc()
        {
            this.swigCPtr = new HandleRef(null, IntPtr.Zero);
        }

        public SWIGTYPE_p_GDALProgressFunc(IntPtr cPtr, bool futureUse, object parent)
        {
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public static HandleRef getCPtr(SWIGTYPE_p_GDALProgressFunc obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }
    }
}

