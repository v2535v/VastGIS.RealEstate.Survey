namespace OSGeo.OGR
{
    using System;
    using System.Runtime.InteropServices;

    public class FieldDefn : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public FieldDefn(string name_null_ok, FieldType field_type) : this(OgrPINVOKE.new_FieldDefn(name_null_ok, (int) field_type), true, null)
        {
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public FieldDefn(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    OgrPINVOKE.delete_FieldDefn(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~FieldDefn()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(FieldDefn obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(FieldDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(FieldDefn obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public string GetDefault()
        {
            string str = OgrPINVOKE.FieldDefn_GetDefault(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public FieldType GetFieldType()
        {
            FieldType type = (FieldType) OgrPINVOKE.FieldDefn_GetFieldType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public string GetFieldTypeName(FieldType type)
        {
            string str = OgrPINVOKE.FieldDefn_GetFieldTypeName(this.swigCPtr, (int) type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public Justification GetJustify()
        {
            Justification justification = (Justification) OgrPINVOKE.FieldDefn_GetJustify(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return justification;
        }

        public string GetName()
        {
            string str = OgrPINVOKE.FieldDefn_GetName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public string GetNameRef()
        {
            string str = OgrPINVOKE.FieldDefn_GetNameRef(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int GetPrecision()
        {
            int num = OgrPINVOKE.FieldDefn_GetPrecision(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public FieldSubType GetSubType()
        {
            FieldSubType type = (FieldSubType) OgrPINVOKE.FieldDefn_GetSubType(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return type;
        }

        public string GetTypeName()
        {
            string str = OgrPINVOKE.FieldDefn_GetTypeName(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int GetWidth()
        {
            int num = OgrPINVOKE.FieldDefn_GetWidth(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsDefaultDriverSpecific()
        {
            int num = OgrPINVOKE.FieldDefn_IsDefaultDriverSpecific(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsIgnored()
        {
            int num = OgrPINVOKE.FieldDefn_IsIgnored(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public int IsNullable()
        {
            int num = OgrPINVOKE.FieldDefn_IsNullable(this.swigCPtr);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void SetDefault(string pszValue)
        {
            OgrPINVOKE.FieldDefn_SetDefault(this.swigCPtr, pszValue);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetIgnored(int bIgnored)
        {
            OgrPINVOKE.FieldDefn_SetIgnored(this.swigCPtr, bIgnored);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetJustify(Justification justify)
        {
            OgrPINVOKE.FieldDefn_SetJustify(this.swigCPtr, (int) justify);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetName(string name)
        {
            OgrPINVOKE.FieldDefn_SetName(this.swigCPtr, name);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetNullable(int bNullable)
        {
            OgrPINVOKE.FieldDefn_SetNullable(this.swigCPtr, bNullable);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetPrecision(int precision)
        {
            OgrPINVOKE.FieldDefn_SetPrecision(this.swigCPtr, precision);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetSubType(FieldSubType type)
        {
            OgrPINVOKE.FieldDefn_SetSubType(this.swigCPtr, (int) type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetType(FieldType type)
        {
            OgrPINVOKE.FieldDefn_SetType(this.swigCPtr, (int) type);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void SetWidth(int width)
        {
            OgrPINVOKE.FieldDefn_SetWidth(this.swigCPtr, width);
            if (OgrPINVOKE.SWIGPendingException.Pending)
            {
                throw OgrPINVOKE.SWIGPendingException.Retrieve();
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

