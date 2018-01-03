using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VastGIS.Api.Enums;

namespace VastGIS.Plugins.RealEstate.Model
{
    [DataContract]
    public class SelectLayerConfigure
    {
        [JsonProperty("CanSelect")]
        public bool CanSelect { get; set; }
        [JsonProperty("layer")]
        public string Layer { get; set; }
        [JsonProperty("table")]
        public string Table { get; set; }
        [JsonProperty("geometrytype")]
        public GeometryType GeometryType { get; set; }

    }
}
