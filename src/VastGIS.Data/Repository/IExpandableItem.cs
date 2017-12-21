using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;

namespace VastGIS.Data.Repository
{
    public interface IExpandableItem: IRepositoryItem
    {
        bool ExpandedOnce { get; }

        bool Expanded { get; }

        bool IsParentOf(LayerIdentity identity);
    }
}
