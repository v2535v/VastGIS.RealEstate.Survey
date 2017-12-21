using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Data.Views
{
    public class DatabaseLayersModel
    {
        public DatabaseLayersModel(VectorDatasource ds, DatabaseConnection connection)
        {
            if (ds == null) throw new ArgumentNullException("ds");
            if (connection == null) throw new ArgumentNullException("connection");

            Datasource = ds;
            Connection = connection;
        }

        public DatabaseConnection Connection { get; private set; }

        public VectorDatasource Datasource { get; private set; }
    }
}
