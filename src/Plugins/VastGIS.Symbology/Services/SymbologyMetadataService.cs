using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Services.Config;

namespace VastGIS.Plugins.Symbology.Services
{
    public class SymbologyMetadataService: LayerMetadataServiceBase<SymbologyMetadata>
    {
        public SymbologyMetadataService(IAppContext context, SymbologyPlugin plugin) : base(context, plugin)
        {
        }
    }
}
