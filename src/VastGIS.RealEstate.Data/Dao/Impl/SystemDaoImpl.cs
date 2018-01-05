using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Dapper;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class SystemDaoImpl:SQLiteDao
    {
        protected const string VG_CADCODES = "CREATE TABLE [vg_cadcodes] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [XH] CHAR(5),   [SFCY] INTEGER,   [TC] NCHAR(20),   [CASSDM] CHAR(10),   [TXLX] CHAR(10),   [XTC] NCHAR(20),   [YSDM] CHAR(11),   [YSLX] NCHAR(10),   [YSZL] INTEGER);";

        protected const string VG_SETTINGS =
            "CREATE TABLE [vg_settings] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [CSMC] NCHAR(30),   [CSZ] NCHAR(200));";

        protected const string VG_OBJECTCLASSES =
                "CREATE TABLE [vg_objectclasses] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[MC] NCHAR(30), [DXLX] INT DEFAULT 0,[ZWMC] NCHAR(30), [FBMC] NCHAR(30), [XHZDMC] NCHAR(30), [TXZDMC] NCHAR(30), [TXLX] INT DEFAULT 0,[IDENTIFY] BOOLEAN DEFAULT True,   [EDITABLE] BOOLEAN DEFAULT False,   [QUERYABLE] BOOLEAN DEFAULT True,   [SNAPABLE] BOOLEAN DEFAULT False,   [VISIBLE] BOOLEAN DEFAULT True,   [XSSX] INTEGER DEFAULT 0);"
            ;

       
        public SystemDaoImpl():base()
        {
            connection = DbConnection.GetConnection();
        }
        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
               // int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = VG_OBJECTCLASSES;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_SETTINGS;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CADCODES;
                    command.ExecuteNonQuery();

                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    string dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Casscodes.sql");

                    StreamReader reader = File.OpenText(dataFile);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        cmd.CommandText = line;
                        cmd.ExecuteNonQuery();
                    }
                    reader.Close();
                }
                trans.Commit();
            }
            return true;
        }

        public List<VgObjectclasses> GetObjectclasseses(bool isDeep)
        {
            List<VgObjectclasses> objectclasseses = connection
                .Query<VgObjectclasses>("select * from vg_objectclasses").ToList();
            if (isDeep == false) return objectclasseses;
            else
            {
                List<VgObjectclasses> list = objectclasseses.FindAll(c => c.Fbmc == null || c.Fbmc=="");
                List<VgObjectclasses> newList = new List<VgObjectclasses>(list);
                foreach (VgObjectclasses objectClass in newList)
                {
                    List<VgObjectclasses> children = FindChildClasses(objectclasseses, objectClass.Mc);
                    if (children != null && children.Count > 0)
                    {
                        objectClass.SubClasses = children;
                    }
                }
                return newList;
            }
        }

        public void CreateEmptyDatabase(string dbName)
        {
            SQLiteConnection.CreateFile(dbName);
            DbConnection.SetDatabaseName(dbName);
            connection = DbConnection.GetConnection();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = "SELECT InitSpatialMetaData();";
                command.ExecuteNonQuery();
            }
        }

        private List<VgObjectclasses> FindChildClasses(List<VgObjectclasses> objectClasses, string key)
        {
            List<VgObjectclasses> list = objectClasses.FindAll(c => c.Fbmc == key);
            List<VgObjectclasses> tmpList = new List<VgObjectclasses>(list);
            foreach (VgObjectclasses objectClass in tmpList)
            {
                List<VgObjectclasses> tmpChildren = FindChildClasses(objectClasses, objectClass.Mc);
                if (tmpChildren != null && tmpChildren.Count > 0)
                {
                    list.AddRange(tmpChildren);
                }
            }
            return list;
        }


        public void Close()
        {
            connection.Close();
        }
       
        public int GetGeometryColumnSRID(string tableName, string columnName)
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                command.CommandText =
                    string.Format(
                        "Select srid from geometry_columns where f_table_name='{0}' and f_geometry_column='{1}'",
                        tableName.ToLower().Trim(), columnName.ToLower().Trim());
                int srid = Convert.ToInt32(command.ExecuteScalar());
                return srid;
            }
        }

        public void AssignTextToPolygon(
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (string.IsNullOrEmpty(whereClause))
                    sql = string.Format(
                        "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry);",
                        textFieldName, textTable, polyTable);
                else
                    sql = string.Format(
                        "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry) where {3};",
                        textFieldName, textTable, polyTable, whereClause);
                command.CommandText = sql;

                SQLiteDataReader reader = command.ExecuteReader();
                string[] conValues = null;
                if (assignType == AssignTextType.String)
                {
                    conValues = values as string[];
                }
                string updateSQL = "";
                SQLiteCommand command2 = new SQLiteCommand(DbConnection.GetConnection());
                while (reader.Read())
                {
                    string textContext = reader.GetString(0).Trim();
                    int polyId = reader.GetInt32(1);
                    if (assignType == AssignTextType.String)
                    {
                        if (conValues.Contains(textContext))
                        {
                            updateSQL = String.Format("update {0} set {1}='{2}' where Id={3}", polyTable, polyFieldName, textContext, polyId);
                            command2.CommandText = updateSQL;
                            command2.ExecuteNonQuery();
                            continue;
                        }
                        continue;
                    }
                    if (assignType == AssignTextType.Integer || assignType == AssignTextType.Float)
                    {
                        if (!string.IsNullOrEmpty(textContext) && IsNumberic(textContext))
                        {
                            updateSQL = String.Format("update {0} set {1}='{2}' where Id={3}", polyTable, polyFieldName,
                                textContext, polyId);
                            command2.CommandText = updateSQL;
                            command2.ExecuteNonQuery();
                            continue;
                        }
                        continue;
                    }
                }
                reader.Close();
            }
        }



        public IFeature FindFirstRecord(string[] layers, double dx, double dy)
        {
            IFeature pFeature = null;
            try
            {
                for (int i = 0; i < layers.Length; i++)
                {
                    string sql =
                        string.Format(
                            "Select Id,AsText(geometry) as Wkt,'{0}' as TableName from {0} Where Within( GeomFromText('POINT({1} {2})'),geometry);", layers[i],
                            dx, dy);
                    var features = DbConnection.GetConnection().Query<SearchFeature>(sql);
                    if (features != null && features.Count() > 0)
                    {
                        return features.First() as IFeature;
                    }

                }
            }
            catch (Exception ex)
            {
                Trace.TraceWarning(ex.Message);
                return null;
            }
            return null;
        }

        public bool CopyFeature(
            string sourceTable,
            int id,
            string targetTable,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    List<string> sourceColumns = GetAllColumns(sourceTable);
                    List<string> targetColumns = GetAllColumns(targetTable);
                    Dictionary<string, string> mappingColumns = SQLiteHelper.AutoMappingColumn(sourceColumns, targetColumns);
                    StringBuilder builder = new StringBuilder();
                    if(targetColumns.Contains("wx_wydm"))
                        builder.Append("insert into " + targetTable + "(wx_wydm, geometry");
                    else
                        builder.Append("insert into " + targetTable + "(geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }
                    if (targetColumns.Contains("wx_wydm"))
                        builder.Append(") SELECT '"+ Guid.NewGuid().ToString()+"', geometry");
                    else
                        builder.Append(") SELECT geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }
                    builder.Append(" from " + sourceTable + " where Id=" + id.ToString());
                    command.CommandText = builder.ToString();
                    command.ExecuteNonQuery();
                    if (isDelete)
                    {
                        command.CommandText = "delete " + sourceTable + " from Id=" + id.ToString();
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("拷贝错误:" + ex.Message);
                return false;
            }
        }

       


        private bool IsNumberic(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}



