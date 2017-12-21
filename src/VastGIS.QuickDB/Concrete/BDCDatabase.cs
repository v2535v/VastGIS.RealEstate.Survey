using System.Collections.Generic;
using System.Data.SQLite;
using VastGIS.QuickDB.Interface;

namespace VastGIS.QuickDB.Concrete
{
    public class BDCDatabase
    {
        private string _dbName;
        public BDCDatabase()
        {
            
        }
        public BDCDatabase(string dbName)
        {
            _dbName = dbName;
            Open(dbName);
        }

        public string ConnectionStringBuilder()
        {
            return "Data Source=" + _dbName + ";VERSION=3;";
        }
        public bool Open(string dbName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringBuilder()))
            {
                connection.Open();
                connection.Close();
                return true;
            }
        }

        public List<IFeatureClass> GetFeatureClasses()
        {
            List<IFeatureClass> _fses;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionStringBuilder()))
            {
                connection.Open();
                SpatialiteSharp.SpatialiteLoader.Load(connection);
                using (SQLiteCommand command =
                    new SQLiteCommand("Selelct * from geometry_columns Order By ROWID", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        _fses=new List<IFeatureClass>();
                        while (reader.Read())
                        {
                            FeatureClass fs=new FeatureClass();
                            fs.Name = reader["f_table_name"].ToString();
                            fs.GeometryType = reader["f_table_name"].ToString();
                            fs.EpsgCode = reader["srid"].ToString();
                            _fses.Add(fs);
                        }
                        return _fses;
                    }
                }
            }
        }
    }
}
