using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;

namespace VastGIS.Data.Repository
{
    public interface IServerItem: IRepositoryItem
    {
        GeoDatabaseType DatabaseType { get; }
    }
}
