using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data
{
    public static  class SQLiteHelper
    {
        public static Dictionary<string, string> AutoMappingColumn(List<string> sources, List<string> targets)
        {
            Dictionary<string, string> columns = new Dictionary<string, string>();
            foreach (string source in sources)
            {
                if (source.ToUpper().Equals("ID")) continue;
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
