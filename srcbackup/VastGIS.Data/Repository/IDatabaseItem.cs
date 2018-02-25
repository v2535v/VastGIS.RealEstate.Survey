using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Data.Repository
{
    public interface IDatabaseItem: IExpandableItem
    {
        DatabaseConnection Connection { get; }
    }
}
