using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Data.Db;
using VastGIS.Data.Enums;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Data.Views.Abstract
{
    public interface IAddConnectionView: IView<AddConnectionModel>
    {
        string Name { get; }
        void Init(ConnectionBase info);
        ConnectionBase GetConnection();
        GeoDatabaseType DatabaseType { get; set; }
        void SetRawConnection(string cs);
        event Action TestConnection;
        event Action ConnectionChanged;
    }
}
