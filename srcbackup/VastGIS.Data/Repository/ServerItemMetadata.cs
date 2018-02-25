using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;

namespace VastGIS.Data.Repository
{
    public class ServerItemMetadata: IItemMetadata
    {
        public ServerItemMetadata(GeoDatabaseType databaseType)
        {
            DatabaseType = databaseType;
        }
        
        public GeoDatabaseType DatabaseType { get; private set; }
    }
}
