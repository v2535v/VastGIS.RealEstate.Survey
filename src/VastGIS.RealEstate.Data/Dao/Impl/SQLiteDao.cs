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
    }
}