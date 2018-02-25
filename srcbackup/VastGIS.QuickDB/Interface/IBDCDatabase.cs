using System.Collections.Generic;

namespace VastGIS.QuickDB.Interface
{
    public interface IBDCDatabase
    {
        string ConnectionStringBuilder();
        List<IFeatureClass> GetFeatureClasses();
        bool Open(string dbName);
    }
}