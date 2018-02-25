﻿using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Services;

namespace VastGIS.Data.Db
{
    public class PostGisConnection: ConnectionBase
    {
        public string Host { get; set; }
        public string PortString { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public PostGisConnection()
        {
            SetDefaults();
        }

        public void SetDefaults()
        {
            Database = "";
            Password = "";
            Port = 5432;
            UserName = "postgres";
            Host = "127.0.0.1";
        }

        public bool ParsePort()
        {
            int port;
            if (int.TryParse(PortString, out port))
            {
                Port = port;
                return true;
            }

            return false;
        }

        public override string BuildConnection(bool noPassword = false)
        {
            const string cs = "PG:host={0} port={1} dbname={2} user={3} password={4}";
            return string.Format(cs, Host, Port, Database, UserName, noPassword ? UnknownPassword : Password);
        }

        public override GeoDatabaseType DatabaseType
        {
            get { return GeoDatabaseType.PostGis; }
        }

        public override string Name
        {
            get { return Database; }
        }

        public override bool Validate()
        {
            if (IgnoreParams)
            {
                return !string.IsNullOrWhiteSpace(RawConnection);
            }

            if (string.IsNullOrWhiteSpace(Host))
            {
                MessageService.Current.Warn("No host name is provided.");
                return false;
            }

            // Fixing https://mapwindow.atlassian.net/browse/CORE-181
            //int port;
            //if (!int.TryParse(PortString, out port))
            //{
            //    MessageService.Current.Warn("Port must be an integer number.");
            //    return false;
            //}
            if (!ParsePort())
            {
                MessageService.Current.Warn("Port must be an integer number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(UserName))
            {
                MessageService.Current.Warn("No user name is provided.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Database))
            {
                MessageService.Current.Warn("No database name is provided.");
                return false;
            }

            return true;
        }
    }
}
