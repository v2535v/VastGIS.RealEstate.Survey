using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Services
{
    public interface IGeoDatabaseService
    {
        void ImportLayer();
        DatabaseConnection PromptUserForConnection(GeoDatabaseType? databaseType = null);
    }
}
