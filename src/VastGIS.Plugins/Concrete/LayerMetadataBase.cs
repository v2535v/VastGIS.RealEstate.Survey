using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using VastGIS.Api.Interfaces;
using VastGIS.Shared;

namespace VastGIS.Plugins.Concrete
{
    [DataContract]
    public abstract class LayerMetadataBase : ILayerMetadataBase
    {
        public XmlElement Serialize()
        {
            return this.SerializeToElement();
        }
    }
}
