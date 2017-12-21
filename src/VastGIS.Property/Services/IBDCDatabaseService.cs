using VastGIS.Plugins.Concrete;

namespace VastGIS.Property.Services
{
    public interface IBDCDatabaseService
    {
        string ConnectionString { get; }

        DatabaseConnection Connection { get;  }
      
        bool AddDatabaseToMap(string dbName);

    }
}