﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlCustomObject
    {
        [DataMember]
        public XmlElement Object { get; set; }

        [DataMember]
        public Guid Guid { get; set; }
    }
}
