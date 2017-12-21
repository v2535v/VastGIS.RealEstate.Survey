using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Model;

namespace VastGIS.Data.Repository
{
    public interface ITmsItem: IRepositoryItem
    {
        TmsProvider Provider { get; }

        bool Active { get; set; }

        string Serialize();
    }
}
