using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Model;

namespace VastGIS.Data.Repository
{
    public class TmsItemMetadata : IItemMetadata
    {
        public TmsItemMetadata(TmsProvider provider)
        {
            Provider = provider;
        }

        public TmsProvider Provider { get; set; }
    }
}
