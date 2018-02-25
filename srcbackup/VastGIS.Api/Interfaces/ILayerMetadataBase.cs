using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using VastGIS.Shared;

namespace VastGIS.Api.Interfaces
{
    public interface ILayerMetadataBase
    {
        XmlElement Serialize();
    }
}
