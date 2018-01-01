namespace OSGeo.GDAL
{
    using System;
    using System.Runtime.InteropServices;

    public class XMLNode : IDisposable
    {
        protected bool swigCMemOwn;
        private HandleRef swigCPtr;
        protected object swigParentRef;

        public XMLNode(string pszString) : this(GdalPINVOKE.new_XMLNode__SWIG_0(pszString), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public XMLNode(XMLNodeType eType, string pszText) : this(GdalPINVOKE.new_XMLNode__SWIG_1((int) eType, pszText), true, null)
        {
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public XMLNode(IntPtr cPtr, bool cMemoryOwn, object parent)
        {
            this.swigCMemOwn = cMemoryOwn;
            this.swigParentRef = parent;
            this.swigCPtr = new HandleRef(this, cPtr);
        }

        public void AddXMLChild(XMLNode psChild)
        {
            GdalPINVOKE.XMLNode_AddXMLChild(this.swigCPtr, getCPtr(psChild));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public void AddXMLSibling(XMLNode psNewSibling)
        {
            GdalPINVOKE.XMLNode_AddXMLSibling(this.swigCPtr, getCPtr(psNewSibling));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
        }

        public XMLNode Clone()
        {
            IntPtr cPtr = GdalPINVOKE.XMLNode_Clone(this.swigCPtr);
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public XMLNode CloneXMLTree(XMLNode psTree)
        {
            IntPtr cPtr = GdalPINVOKE.XMLNode_CloneXMLTree(this.swigCPtr, getCPtr(psTree));
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, true, ThisOwn_true());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public XMLNode CreateXMLElementAndValue(string pszName, string pszValue)
        {
            IntPtr cPtr = GdalPINVOKE.XMLNode_CreateXMLElementAndValue(this.swigCPtr, pszName, pszValue);
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, this.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if ((this.swigCPtr.Handle != IntPtr.Zero) && this.swigCMemOwn)
                {
                    this.swigCMemOwn = false;
                    GdalPINVOKE.delete_XMLNode(this.swigCPtr);
                }
                this.swigCPtr = new HandleRef(null, IntPtr.Zero);
                this.swigParentRef = null;
                GC.SuppressFinalize(this);
            }
        }

        ~XMLNode()
        {
            this.Dispose();
        }

        public static HandleRef getCPtr(XMLNode obj)
        {
            return ((obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr);
        }

        public static HandleRef getCPtrAndDisown(XMLNode obj, object parent)
        {
            if (obj != null)
            {
                obj.swigCMemOwn = false;
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public static HandleRef getCPtrAndSetReference(XMLNode obj, object parent)
        {
            if (obj != null)
            {
                obj.swigParentRef = parent;
                return obj.swigCPtr;
            }
            return new HandleRef(null, IntPtr.Zero);
        }

        public XMLNode GetXMLNode(string pszPath)
        {
            IntPtr cPtr = GdalPINVOKE.XMLNode_GetXMLNode(this.swigCPtr, pszPath);
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, this.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public string GetXMLValue(string pszPath, string pszDefault)
        {
            string str = GdalPINVOKE.XMLNode_GetXMLValue(this.swigCPtr, pszPath, pszDefault);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int RemoveXMLChild(XMLNode psChild)
        {
            int num = GdalPINVOKE.XMLNode_RemoveXMLChild(this.swigCPtr, getCPtr(psChild));
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public XMLNode SearchXMLNode(string pszElement)
        {
            IntPtr cPtr = GdalPINVOKE.XMLNode_SearchXMLNode(this.swigCPtr, pszElement);
            XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, this.ThisOwn_false());
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return node;
        }

        public string SerializeXMLTree()
        {
            string str = GdalPINVOKE.XMLNode_SerializeXMLTree(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public int SetXMLValue(string pszPath, string pszValue)
        {
            int num = GdalPINVOKE.XMLNode_SetXMLValue(this.swigCPtr, pszPath, pszValue);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return num;
        }

        public void StripXMLNamespace(string pszNamespace, int bRecurse)
        {
            GdalPINVOKE.XMLNode_StripXMLNamespace(this.swigCPtr, pszNamespace, bRecurse);
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

        public string toString()
        {
            string str = GdalPINVOKE.XMLNode_toString(this.swigCPtr);
            if (GdalPINVOKE.SWIGPendingException.Pending)
            {
                throw GdalPINVOKE.SWIGPendingException.Retrieve();
            }
            return str;
        }

        public XMLNode Child
        {
            get
            {
                IntPtr cPtr = GdalPINVOKE.XMLNode_Child_get(this.swigCPtr);
                XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, this.ThisOwn_false());
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return node;
            }
        }

        public XMLNode Next
        {
            get
            {
                IntPtr cPtr = GdalPINVOKE.XMLNode_Next_get(this.swigCPtr);
                XMLNode node = (cPtr == IntPtr.Zero) ? null : new XMLNode(cPtr, false, this.ThisOwn_false());
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return node;
            }
        }

        public XMLNodeType Type
        {
            get
            {
                XMLNodeType type = (XMLNodeType) GdalPINVOKE.XMLNode_Type_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return type;
            }
        }

        public string Value
        {
            get
            {
                string str = GdalPINVOKE.XMLNode_Value_get(this.swigCPtr);
                if (GdalPINVOKE.SWIGPendingException.Pending)
                {
                    throw GdalPINVOKE.SWIGPendingException.Retrieve();
                }
                return str;
            }
        }
    }
}

