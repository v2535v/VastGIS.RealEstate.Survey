using System.Runtime.Serialization;

namespace VastGIS.Services.Serialization
{
    [DataContract]
    public class XmlVastProjectInfo
    {
        [DataMember]
        public string AttachmentPath { get; set; }

        [DataMember]
        public string DatabaseName { get; set; }

        [DataMember]
        public string MediaPath { get; set; }
        [DataMember]
        public string ProjectName { get; set; }
    }
}