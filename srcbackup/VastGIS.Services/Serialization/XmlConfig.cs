﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlConfig
    {
        [DataMember]
        public AppConfig Settings { get; set; }

        [DataMember]
        public List<XmlPlugin> ApplicationPlugins { get; set; }
    }
}
