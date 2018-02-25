using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Settings
{
    [DataContract]
    public class TextAssignConfig
    {
        public TextAssignConfig()
        {
            AssignType = AssignTextType.String;
            TextTable = "DXTZJZJ";
            TextField = "Wbnr";
            TextWhereClause = "a.TC='ZJ'";
            TextValues = null;
        }

        public TextAssignConfig(string name, string assigntable, string assignfield, AssignTextType assigntype, List<string> values)
        {
            Name = name;
            AssignTable = assigntable;
            AssignField = assignfield;
            AssignType = assigntype;
            TextTable = "DXTZJZJ";
            TextField = "Wbnr";
            TextWhereClause = "[DXTZJZJ].TC='ZJ'";
            TextValues = values;
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("assigntype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssignTextType AssignType { get; set; }
        [JsonProperty("assigntable")]
        public string AssignTable { get; set; }
        [JsonProperty("assignfield")]
        public string AssignField { get; set; }
        [JsonProperty("texttable")]
        public string TextTable { get; set; }
        [JsonProperty("textfield")]
        public string TextField { get; set; }
        [JsonProperty("whereclause")]
        public string TextWhereClause { get; set; }
        [JsonProperty("assignvalues")]
        public List<string> TextValues { get; set; }
    }
}
