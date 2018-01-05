using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data
{
    public static  class SQLiteHelper
    {
        
        public static bool CreateEmptyDatabase(string databaseName)
        {
            SQLiteConnection.CreateFile(databaseName);
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + databaseName + ";"))
            {
                connection.Open();
                connection.EnableExtensions(true);
                connection.LoadExtension("mod_spatialite.dll");
                using (SQLiteCommand command = new SQLiteCommand("SELECT InitSpatialMetaData();", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public static Dictionary<string, string> AutoMappingColumn(List<string> sources, List<string> targets,bool ignoreSystemColumn=true)
        {
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (string source in sources)
            {
                if (source.ToUpper().Equals("ID")) continue;
                if (ignoreSystemColumn)
                {
                    if (source.ToUpper().StartsWith("WX_")) continue;
                    if (source.ToUpper().Equals("DATABASEID")) continue;
                    if (source.ToUpper().Equals("FLAGS")) continue;
                }
                //if (source.ToUpper().Equals("GEOMETRY")) continue;
                if (targets.Contains(source))
                {
                    columns.Add(source, source);
                }
            }
            return columns;
        }

        public static string AutoMappingColumnString(List<string> sources, List<string> targets)
        {
            string sql = "";
            foreach (string source in sources)
            {
                if (source.ToUpper().Equals("ID")) continue;
                //if (source.ToUpper().Equals("GEOMETRY")) continue;
                if (targets.Contains(source))
                {
                    sql += "," + source;
                }
            }
            return sql;
        }
    }
}
