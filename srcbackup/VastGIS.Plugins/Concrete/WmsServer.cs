﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Plugins.Concrete
{
    /// <summary>
    /// Represents a single WMS server to be displayed in the repository.
    /// </summary>
    [DataContract]
    public class WmsServer
    {
        public WmsServer()
        {
            Name = string.Empty;

            Url = string.Empty;
        }

        public WmsServer(string name, string url)
        {
            Name = name;

            Url = url;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
