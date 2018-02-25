using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;

namespace VastGIS.Data.Db
{
    public interface IConnectionParams
    {
        string GetConnection(bool noPassword = false);
        string BuildConnection(bool noPassword = false);        // from parameters
        GeoDatabaseType DatabaseType { get; }
        string RawConnection { get; set; }
        bool IgnoreParams { get; set; }  // use raw connection instead
        string Name { get; }
        bool Validate();
    }
}
