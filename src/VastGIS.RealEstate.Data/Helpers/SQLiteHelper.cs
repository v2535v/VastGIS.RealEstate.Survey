using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace VastGIS.RealEstate.Data.Helpers
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
                using (SQLiteCommand command = new SQLiteCommand("SELECT InitSpatialMetaData(1);", connection))
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

        public static bool TableExists(SQLiteConnection conn, string tableName)
        {
            if (conn == null)
                throw new ArgumentNullException("conn");
            if (string.IsNullOrWhiteSpace(tableName))
                return false;

            string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name= '"+ tableName +"'";

            using (var reader = ExecuteReader(conn, sql, tableName))
            {
                return reader.HasRows;
            }
        }

        public static SQLiteDataReader ExecuteReader(SQLiteConnection conn, string query, params object[] arg)
        {
            //ExecuteReader("select * from stream where provider_type = ?", "channel");
            if (conn == null)
                throw new ArgumentNullException("conn");

            using (var cmd = new SQLiteCommand(query, conn))
            {
                setParameter(cmd, query, arg);
                return cmd.ExecuteReader();
            }
        }

        public static List<string> GetTableNameList(SQLiteConnection conn)
        {
            const string colName = "name";
            const string sql = "SELECT " + colName + " FROM sqlite_master WHERE type='table'";
            var list = new List<string>();
            var reader = ExecuteReader(conn, sql);
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        public static SQLiteDataReader TableInfo(SQLiteConnection conn, string tableName)
        {
            var query = "PRAGMA table_info(" + tableName + ")";
            return ExecuteReader(conn, query);
        }

        public static bool ColumnExists(SQLiteConnection conn, string tableName, string colName)
        {
            var reader = TableInfo(conn, tableName);
            for (int i = 0; i < reader.FieldCount; i++)//VisibleFieldCountにするべき？
            {
                if (reader.GetName(i) == colName)
                    return true;
            }
            return false;
        }

        private class DbValue
        {
            public DbType Type { get; private set; }
            public object Value { get; private set; }
            public DbValue(DbType type, object value)
            {
                this.Type = type;
                this.Value = value;
            }
        }

        private static DbValue ConvertToDbType(object value)
        {
            if (value == null)
            {
                return new DbValue(DbType.String, null);
            }
            else if (value is string)
            {
                return new DbValue(DbType.String, value);
            }
            else if (value is Int32)
            {
                return new DbValue(DbType.Int32, value);
            }
            else if (value is float || value is double)
            {
                return new DbValue(DbType.Double, value);
            }
            else if (value is DateTime)
            {
                var dateTime = (DateTime)value;
                return new DbValue(DbType.String, dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            throw new ArgumentException("错误");
        }


        private static void setParameter(SQLiteCommand cmd, string query, object[] args)
        {
            cmd.CommandText = query;
            cmd.Parameters.Clear();
            if (args != null)
            {
                foreach (var arg in args)
                {
                    var parameter = cmd.CreateParameter();
                    var dbValue = ConvertToDbType(arg);
                    parameter.DbType = dbValue.Type;
                    parameter.Value = dbValue.Value;
                    cmd.Parameters.Add(parameter);
                }
            }
            cmd.Prepare();
        }

        public static DataTable ExecuteSql(SQLiteConnection connection, string query)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                DataTable dt = new DataTable();
                SQLiteDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
        }
        public static List<Dictionary<string, string>> GetAllColumnTypes(SQLiteConnection connection,string tableName)
        {

            DataTable dt = ExecuteSql(connection,"PRAGMA table_info('" + tableName + "')");
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("name", dr["name"].ToString());
                dic.Add("notnull", dr["notnull"].ToString());
                result.Add(dic);
            }
            return result;
        }
       
        /// <summary>
        /// 获取表的所有字段名及字段类型
        /// </summary>
        public static List<string> GetAllColumns(SQLiteConnection connection, string tableName)
        {

            DataTable dt = ExecuteSql(connection, "PRAGMA table_info('" + tableName + "')");
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr["name"].ToString().ToLower());
            }
            return result;
        }
    }
}
