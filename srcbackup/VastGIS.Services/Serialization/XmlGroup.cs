using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using VastGIS.Api.Legend;
using VastGIS.Api.Legend.Abstract;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlGroup
    {
        public XmlGroup(ILegendGroup group)
        {
            Name = group.Text;
            Expanded = group.Expanded;
            Layers = group.Layers.Select(l => l.Guid);
        }
        [DataMember] public IEnumerable<Guid> Layers { get; set; }
        [DataMember] public string Name { get; set; }
        [DataMember] public bool Expanded { get; set; }
    }
}
