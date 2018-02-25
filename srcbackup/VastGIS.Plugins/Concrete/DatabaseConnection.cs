﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Concrete
{
    [DataContract]
    public class DatabaseConnection
    {
        private readonly string _secureConnection;

        public DatabaseConnection(GeoDatabaseType databaseType, string name, string connection, string secureConnection)
        {
            DatabaseType = databaseType;
            Name = name;
            ConnectionString = connection;
            _secureConnection = secureConnection;
        }

        [DataMember]
        public GeoDatabaseType DatabaseType { get; private set; }
        
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public string SecureConnection { get; private set; }
        
        public string GetUIConnection()
        {
            if (string.IsNullOrWhiteSpace(_secureConnection))
            {
                // it's mostly temporary to display something for existing connections
                return ConnectionString;
            }
            return _secureConnection;
        }

        [DataMember]
        public string ConnectionString { get; private set; }

        public IEnumerable<string> GetSchemas()
        {
            using (var source = new VectorDatasource())
            {
                if (source.Open(ConnectionString))
                {
                    foreach (var s in source.GetShemas())
                    {
                        yield return s;
                    }
                }
            }
        }

        public override string ToString()
        {
            return DatabaseType + ": " + Name;
        }
    }
}
