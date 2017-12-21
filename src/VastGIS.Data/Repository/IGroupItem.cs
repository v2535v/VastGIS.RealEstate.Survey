using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Model;

namespace VastGIS.Data.Repository
{
    public interface IGroupItem: IExpandableItem
    {
        RepositoryGroup Group { get; }
    }
}
