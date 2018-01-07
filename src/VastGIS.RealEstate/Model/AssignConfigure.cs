using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.Plugins.RealEstate.Model
{
    [DataContract]
    public class TextAssignConfigure
    {
        public TextAssignConfigure()
        {
            AssignType= AssignTextType.String;
            TextTable = "DXTZJZJ";
            TextField = "Wbnr";
            TextWhereClause = "a.TC='ZJ'";
            TextValues = null;
        }

        public TextAssignConfigure(string name, string assigntable, string assignfield, AssignTextType assigntype,string[] values)
        {
            Name = name;
            AssignTable = assigntable;
            AssignField = assignfield;
            AssignType = assigntype;
            TextTable = "DXTZJZJ";
            TextField = "Wbnr";
            TextWhereClause = "a.TC='ZJ'";
            TextValues = values.ToList();
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("assigntype")]
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
