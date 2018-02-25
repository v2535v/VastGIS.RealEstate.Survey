using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VastGIS.Plugins.RealEstate.Model
{
    [DataContract]
    public class SplitLayerConfigure
    {
        [JsonProperty("name")]
        public  string Name { get; set; }
        [JsonProperty("cadlayer")]
        public string CadLayerName { get; set; }
        [JsonProperty("tablebasename")]
        public string TargetTable { get; set; }
        [JsonProperty("isclear")]
        public bool IsClear { get; set; }
        [JsonProperty("isother")]
        public bool IsOther { get; set; }
        [JsonProperty("issplitpoint")]
        public bool IsSplitPoint { get; set; }
        [JsonProperty("issplitline")]
        public bool IsSplitLine { get; set; }
        [JsonProperty("issplitarea")]
        public bool IsSplitArea { get; set; }
        [JsonProperty("issplittext")]
        public bool IsSplitText { get; set; }
        [JsonProperty("whereclause")]
        public string WhereClause { get; set; }
    }
}
