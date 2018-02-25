using System;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Events
{
    public class ConnectionEventArgs: EventArgs
    {
        public ConnectionEventArgs(DatabaseConnection connection)
        {
            Connection = connection;
        }

        public DatabaseConnection Connection { get; private set; }
    }
}
