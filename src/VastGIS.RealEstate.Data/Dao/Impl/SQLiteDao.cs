using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace VastGIS.RealEstate.Data.Dao.Impl
{
    public class SQLiteDao
    {
        protected SQLiteConnection connection;

        protected int _srid = -1;

        public SQLiteDao()
        {
            connection = DbConnection.GetConnection();
            //GetSRID();
        }
        
        public DataTable ExecuteSql(SQLiteCommand command)
        {
            Trace.TraceInformation("Execute query {0}", command.CommandText);
            DataTable dt = new DataTable();
            SQLiteDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            return dt;
        }

        public DataTable ExecuteSql(string query)
        {
            using (SQLiteCommand command=new SQLiteCommand(query,connection))
            {
                Trace.TraceInformation("Execute query {0}", query);
                DataTable dt = new DataTable();
                SQLiteDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt; 
            }
        }

        public void RegisterGroup(string groupName)
        {
            using (SQLiteCommand command = new SQLiteCommand( connection))
            {
                command.CommandText = "insert into vg_classgroup([GroupName]) values('" + groupName + "');";
                command.ExecuteNonQuery();
            }
        }

        public string GetRegisterGroupSql(string groupName)
        {
            return "insert into vg_classgroup ([GroupName]) values('" + groupName + "');";
        }

        public string GetRegisterClassSql(string groupName, string className, string interfaceName = "", bool createImpl = false)
        {
            
                int boImpl = createImpl ? 1 : 0;
               string sql =
                    string.Format(
                        "insert into vg_classdetail([GroupName],[TableName],[InterfaceName],[CreateImpl]) values('{0}','{1}','{2}',{3});",
                        groupName, className, interfaceName, boImpl);
            return sql;
      
        }

        public void RegisterClass(string groupName,string className, string interfaceName="", bool createImpl=false)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                int boImpl = createImpl ? 1 : 0;
                command.CommandText =
                    string.Format(
                        "insert into vg_classdetail([GroupName],[TableName],[InterfaceName],[CreateImpl]) values('{0}','{1}','{2}',{3});",
                        groupName, className, interfaceName, boImpl);
                command.ExecuteNonQuery();
            }
        }

        public int GetSRID()
        {
            if (_srid > 0) return _srid;
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =
                    "Select Csz from vg_settings where Csmc='SRID'";
                _srid = Convert.ToInt32(command.ExecuteScalar());
                if (_srid == 0) _srid = 4520;
                return _srid;
            }
        }

        public int GetSystemSRID()
        {
            if (_srid > 0) return _srid;
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =
                    "Select Csz from vg_settings where Csmc='SRID'";
                _srid = Convert.ToInt32(command.ExecuteScalar());
                if (_srid == 0) _srid = 4539;
                return _srid;
            }
        }

        #region 获取所有表名
        /// <summary>
        /// 获取数据库名
        /// </summary>
        public List<string> GetAllTableName()
        {

            DataTable dt = ExecuteSql("select tbl_name from sqlite_master where type='table'");
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr["tbl_name"].ToString());
            }
            return result;
        }
        #endregion

        #region 获取表的所有字段名及字段类型
        /// <summary>
        /// 获取表的所有字段名及字段类型
        /// </summary>
        public List<Dictionary<string, string>> GetAllColumnTypes(string tableName)
        {
            
            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
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
        #endregion

        #region 获取表的所有字段名
        /// <summary>
        /// 获取表的所有字段名及字段类型
        /// </summary>
        public List<string> GetAllColumns(string tableName)
        {

            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr["name"].ToString().ToLower());
            }
            return result;
        }
        #endregion


        public bool HasSpecialFields(string tableName, out bool hasDatabaseId, out bool hasBackField)
        {
            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
            hasDatabaseId = false;
            hasBackField = false;
            foreach (DataRow dr in dt.Rows)
            {
                string tbName = dr["name"].ToString().ToLower();
                if (tbName == "databaseid") hasDatabaseId = true;
                if (tbName == "wx_wydm") hasBackField = true;
            }
            return true;
        }

        public string GetLayerNameFromTable(string tableName)
        {
            tableName = tableName.ToUpper();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =string.Format("Select Zwmc from vg_objectclasses where Mc='{0}'",tableName);
                object retVal = command.ExecuteScalar();
                if (retVal == null) return "";
                return retVal.ToString();
            }
        }
    }
}