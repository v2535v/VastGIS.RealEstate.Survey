namespace VastGIS.RealEstate.Data.Dao.Impl
{
    using Dapper;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using VastGIS.Api.Enums;
    using VastGIS.RealEstate.Data.Entity;
    using VastGIS.RealEstate.Data.Enums;
    using VastGIS.RealEstate.Data.Helpers;
    using VastGIS.RealEstate.Data.Interface;
    using VastGIS.RealEstate.Data.Settings;

    /// <summary>
    /// Defines the <see cref="SystemDaoImpl" />
    /// </summary>
    public partial class SystemDaoImpl
    {
        #region 常量

        /// <summary>
        /// Defines the VG_AREACODES
        /// </summary>
        protected const string VG_AREACODE =
                "CREATE TABLE [main].[vg_areacode] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[XZQHMC] NCHAR(100), [XZQHDM] CHAR(6), [XZQHJB] INTEGER);"
            ;

        /// <summary>
        /// Defines the VG_ATTACHMENTS
        /// </summary>
        protected const string VG_ATTACHMENT =
                "CREATE TABLE[vg_attachment] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[WX_WYDM] GUID,[FJMC] NCHAR(200),[FJLJ] NVARCHAR,[FJLX] CHAR(5),[HQSJ] DATETIME,[FJSM] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        /// <summary>
        /// Defines the VG_CADCODE
        /// </summary>
        protected const string VG_CADCODE =
                "CREATE TABLE [vg_cadcode] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [XH] CHAR(5),   [SFCY] INTEGER,   [TC] NCHAR(20),   [CASSDM] CHAR(10),   [TXLX] CHAR(10),   [XTC] NCHAR(20),   [YSDM] CHAR(11),   [YSLX] NCHAR(10),   [YSZL] INTEGER);"
            ;

        /// <summary>
        /// Defines the VG_CLASSDETAIL
        /// </summary>
        protected const string VG_CLASSDETAIL =
                "CREATE TABLE [vg_classgroup] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[GroupName] NCHAR(100), [CreateImpl] Boolean Default 0);"
            ;

        /// <summary>
        /// Defines the VG_CLASSGROUP
        /// </summary>
        protected const string VG_CLASSGROUP =
                "CREATE TABLE [vg_classdetail] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[GroupName] NCHAR(100), [ObjectTableName] NCHAR(100), [CreateImpl] Boolean DEFAULT 0,[InterfaceName] CHAR(30));"
            ;

        /// <summary>
        /// Defines the VG_FIELDINFO
        /// </summary>
        protected const string VG_FIELDINFO =
                "CREATE TABLE [vg_fieldinfo] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [BM] CHAR(8),   [BNSX] INTEGER,   [ZDZWMC] CHAR(13),   [ZDMC] CHAR(10),   [ZDLX] CHAR(7),   [ZDCD] INTEGER,   [ZDXSWS] INTEGER,   [SYZD] CHAR(12),   [YS] CHAR(1),[SYZDYW] CHAR(50));"
            ;

        /// <summary>
        /// Defines the VG_LAYERGROUP
        /// </summary>
        protected const string VG_LAYERGROUP =
            "CREATE TABLE[vg_layergroup]([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[ZM] NCHAR(30));";

        /// <summary>
        /// Defines the VG_LAYERGROUPDETAIL
        /// </summary>
        protected const string VG_LAYERGROUPDETAIL =
                "CREATE TABLE[vg_layergroupdetail] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[ZM] NCHAR(30), [Mc] NCHAR(30), [IDENTIFY] BOOLEAN NOT NULL DEFAULT 1,   [EDITABLE] BOOLEAN NOT NULL DEFAULT 1,   [QUERYABLE] BOOLEAN NOT NULL DEFAULT 1,   [SNAPABLE] BOOLEAN NOT NULL DEFAULT 1,   [VISIBLE] BOOLEAN NOT NULL DEFAULT 1);"
            ;

        /// <summary>
        /// Defines the VG_OBJECTCLASSES
        /// </summary>
        protected const string VG_OBJECTCLASS =
                "CREATE TABLE [vg_objectclass] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [MC] NCHAR(30),   [DXLX] INT NOT NULL DEFAULT 0,   [ZWMC] NCHAR(30),   [FBMC] NCHAR(30),   [XHZDMC] NCHAR(30),   [TXZDMC] NCHAR(30),   [TXLX] INT NOT NULL DEFAULT 0,   [IDENTIFY] BOOLEAN NOT NULL DEFAULT 1,   [EDITABLE] BOOLEAN NOT NULL DEFAULT 1,   [QUERYABLE] BOOLEAN NOT NULL DEFAULT 1,   [SNAPABLE] BOOLEAN NOT NULL DEFAULT 1,   [VISIBLE] BOOLEAN NOT NULL DEFAULT 1,   [XSSX] INTEGER NOT NULL DEFAULT 0,   [FILTER] NVARCHAR,[QSDM] CHAR(10),[BJCT] CHAR(100),[BHFJ] BOOLEAN NOT NULL DEFAULT 0);"
            ;

        /// <summary>
        /// Defines the VG_OBJECTYSDM
        /// </summary>
        protected const string VG_OBJECTYSDM =
                "CREATE TABLE[vg_objectysdm] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [YSDM] CHAR(10),[YSMC] NCHAR(50),[XSSX] INTEGER DEFAULT 0,[QSBG] CHAR(50),[QSFH] NCHAR,[SFKJ] BOOLEAN NOT NULL DEFAULT 1);"
            ;

        /// <summary>
        /// Defines the VG_SETTINGS
        /// </summary>
        protected const string VG_SETTING =
                "CREATE TABLE [vg_setting] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [CSMC] NCHAR(30),   [CSZ] NVARCHAR);"
            ;

        /// <summary>
        /// Defines the VG_UPDATEYSDM
        /// </summary>
        protected const string VG_UPDATEYSDM =
                "update [vg_objectclass] set [QSDM]=(select [vg_objectysdm].[YSDM] from  [vg_objectclass] inner join [vg_objectysdm] on [vg_objectysdm].[QSBG]=[vg_objectclass].MC);"
            ;

        #endregion

        #region 方法

        /// <summary>
        /// The AssignTextToPolygon
        /// </summary>
        /// <param name="assignType">The <see cref="AssignTextType"/></param>
        /// <param name="polyTable">The <see cref="string"/></param>
        /// <param name="polyFieldName">The <see cref="string"/></param>
        /// <param name="textTable">The <see cref="string"/></param>
        /// <param name="textFieldName">The <see cref="string"/></param>
        /// <param name="whereClause">The <see cref="string"/></param>
        /// <param name="values">The <see cref="object"/></param>
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
                            updateSQL = String.Format("update {0} set {1}='{2}' where Id={3}", polyTable, polyFieldName,
                                textContext, polyId);
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

        /// <summary>
        /// The Close
        /// </summary>
        public void Close()
        {
            connection.Close();
        }

        /// <summary>
        /// The CopyFeature
        /// </summary>
        /// <param name="sourceTable">The <see cref="string"/></param>
        /// <param name="id">The <see cref="long"/></param>
        /// <param name="targetTable">The <see cref="string"/></param>
        /// <param name="isDelete">The <see cref="bool"/></param>
        /// <param name="isAttributeAutoTransform">The <see cref="bool"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool CopyFeature(
            string sourceTable,
            long id,
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
                    Dictionary<string, string> mappingColumns =
                        SQLiteHelper.AutoMappingColumn(sourceColumns, targetColumns);
                    StringBuilder builder = new StringBuilder();
                    if (targetColumns.Contains("wx_wydm"))
                        builder.Append("insert into " + targetTable + "(wx_wydm, geometry");
                    else builder.Append("insert into " + targetTable + "(geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }
                    if (targetColumns.Contains("wx_wydm"))
                        builder.Append(") SELECT '" + Guid.NewGuid().ToString() + "', geometry");
                    else builder.Append(") SELECT geometry");
                    foreach (var mappingColumn in mappingColumns)
                    {
                        if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                        builder.Append("," + mappingColumn.Value);
                    }

                    builder.Append(" from " + sourceTable + " where Id=" + id.ToString());
                    command.CommandText = builder.ToString();
                    command.ExecuteNonQuery();
                    OnEntityChanged(targetTable, GetLayerNameFromTable(targetTable), EntityOperationType.Save, null);
                    if (isDelete)
                    {
                        //command.CommandText = "delete from " + sourceTable + " where Id=" + id.ToString();
                        //command.ExecuteNonQuery();
                        //OnEntityChanged(sourceTable, GetLayerName(sourceTable), EntityOperationType.Delete, null);
                        DeleteFeature(sourceTable, id);
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

        /// <summary>
        /// The CopyFeatures
        /// </summary>
        /// <param name="targetClass">拷贝目标要素类 <see cref="VgObjectclass"/></param>
        /// <param name="sourceFeatures">拷贝来源要素集合 <see cref="List{SearchFeature}"/></param>
        /// <param name="isDelete">是否从源图层删除 <see cref="bool"/></param>
        /// <param name="isAttributeAutoTransform">是否传递属性 <see cref="bool"/></param>
        /// <returns>是否成功拷贝<see cref="bool"/></returns>
        public bool CopyFeatures(
            VgObjectclass targetClass,
            List<SearchFeature> sourceFeatures,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    List<string> targetColumns = GetAllColumns(targetClass.Mc);
                    List<long> newIds = new List<long>();
                    foreach (var sourceFeature in sourceFeatures)
                    {
                        List<string> sourceColumns = GetAllColumns(sourceFeature.TableName);

                        Dictionary<string, string> mappingColumns =
                            SQLiteHelper.AutoMappingColumn(sourceColumns, targetColumns);
                        StringBuilder builder = new StringBuilder();
                        if (targetColumns.Contains("wx_wydm"))
                            builder.Append("insert into " + targetClass.Mc + "(wx_wydm, geometry");
                        else builder.Append("insert into " + targetClass.Mc + "(geometry");
                        foreach (var mappingColumn in mappingColumns)
                        {
                            if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                            builder.Append("," + mappingColumn.Value);
                        }
                        if (targetColumns.Contains("wx_wydm"))
                            builder.Append(") SELECT '" + Guid.NewGuid().ToString() + "', geometry");
                        else builder.Append(") SELECT geometry");
                        foreach (var mappingColumn in mappingColumns)
                        {
                            if (mappingColumn.Value.ToLower().Equals("geometry")) continue;
                            builder.Append("," + mappingColumn.Value);
                        }

                        builder.Append(" from " + sourceFeature.TableName + " where Id=" + sourceFeature.ID.ToString());
                        builder.Append(";select last_insert_rowid();");
                        command.CommandText = builder.ToString();
                        long rowid = Convert.ToInt64(command.ExecuteScalar());
                        newIds.Add(rowid);
                    }
                    OnEntityChanged(targetClass.Mc, targetClass.Zwmc, EntityOperationType.Save, newIds);
                    if (isDelete)
                    {
                        DeleteFeatures(sourceFeatures);
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

        /// <summary>
        /// The CreateEmptyDatabase
        /// </summary>
        /// <param name="dbName">The <see cref="string"/></param>
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

        /// <summary>
        /// The DeleteFeature
        /// </summary>
        /// <param name="sourceTable">The <see cref="string"/></param>
        /// <param name="id">The <see cref="long"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool DeleteFeature(string sourceTable, long id)
        {
            bool hasDatabaseId = false;
            bool hasBackFields = false;
            string sql = "";
            HasSpecialFields(sourceTable, out hasDatabaseId, out hasBackFields);
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                if (hasDatabaseId == false)
                {
                    sql = string.Format("delete from {0} where id={1} ", sourceTable, id);
                }
                else
                {
                    command.CommandText = string.Format("select databaseId from {0} where id={1}", sourceTable, id);
                    object dbRet = command.ExecuteScalar();

                    if (dbRet == null)
                    {
                        sql = string.Format("delete from {0} where id={1} ", sourceTable, id);
                    }
                    else
                    {
                        long olddbId = Convert.ToInt64(dbRet);
                        if (olddbId == 0)
                        {
                            sql = string.Format("delete from {0} where id={1} ", sourceTable, id);
                        }
                        else
                        {
                            if (!hasBackFields)
                            {
                                sql = string.Format("update {0} set Flags=3,XGR='{2}',XGSJ=date('now') where id={1} ", sourceTable, id,Environment.UserName);
                            }
                            else
                            {
                                sql = string.Format("update {0} set Flags=3,WX_dcsj=date('now'),XGR='{2}',XGSJ=date('now') where id={1} ", sourceTable,
                                    id, Environment.UserName);
                            }
                        }
                    }
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                OnEntityChanged(sourceTable, GetLayerNameFromTable(sourceTable), EntityOperationType.Delete, null);
            }
            return true;
        }

        /// <summary>
        /// The DeleteFeatures
        /// </summary>
        /// <param name="features">The <see cref="List{SearchFeature}"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool DeleteFeatures(List<SearchFeature> features)
        {
            List<SearchFeature> orderFeatures = features.OrderBy(c => c.TableName).ToList();
            string oldTableName = "";
            string oldTableCHName = "";
            bool hasDatabaseId = false;
            bool hasBackFields = false;
            string sql = "";
            List<long> _delIds = new List<long>();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                for (int i = 0; i < orderFeatures.Count; i++)
                {
                    SearchFeature oneFeature = orderFeatures[i];
                    if (!oneFeature.TableName.Equals(oldTableName))
                    {
                        if (_delIds != null && _delIds.Count > 0)
                        {
                            OnEntityChanged(oldTableName, oldTableCHName, EntityOperationType.Delete, _delIds);
                        }
                        HasSpecialFields(oneFeature.TableName, out hasDatabaseId, out hasBackFields);
                        oldTableName = oneFeature.TableName;
                        oldTableCHName = oneFeature.TableChineseName;
                        _delIds = new List<long>();
                    }
                    if (hasDatabaseId == false)
                    {
                        sql = string.Format("delete from {0} where id={1} ", oneFeature.TableName, oneFeature.ID);
                        oldTableName = oneFeature.TableName;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        _delIds.Add(oneFeature.ID);
                        continue;
                    }

                    command.CommandText = string.Format("select databaseId from {0} where id={1}", oneFeature.TableName,
                        oneFeature.ID);
                    object dbRet = command.ExecuteScalar();

                    if (dbRet == null)
                    {
                        sql = string.Format("delete from {0} where id={1} ", oneFeature.TableName, oneFeature.ID);
                    }
                    else
                    {
                        long olddbId = Convert.ToInt64(dbRet);
                        if (olddbId == 0)
                        {
                            sql = string.Format("delete from {0} where id={1} ", oneFeature.TableName, oneFeature.ID);
                        }
                        else
                        {
                            if (!hasBackFields)
                            {
                                sql = string.Format("update {0} set Flags=3 where id={1} ", oneFeature.TableName,
                                    oneFeature.ID);
                            }
                            else
                            {
                                sql = string.Format("update {0} set Flags=3,WX_dcsj='{2}' where id={1} ",
                                    oneFeature.TableName, oneFeature.ID, DateTime.Now.ToString());
                            }
                        }
                    }
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                    _delIds.Add(oneFeature.ID);
                }
                if (_delIds != null && _delIds.Count > 0)
                {
                    OnEntityChanged(oldTableName, oldTableCHName, EntityOperationType.Delete, _delIds);
                }
            }
            return true;
        }

        /// <summary>
        /// The FindChildClasses
        /// </summary>
        /// <param name="objectClasses">The <see cref="List{VgObjectClass}"/></param>
        /// <param name="key">The <see cref="string"/></param>
        /// <returns>The <see cref="List{VgObjectClass}"/></returns>
        private List<VgObjectclass> FindChildClasses(List<VgObjectclass> objectClasses, string key)
        {
            List<VgObjectclass> list = objectClasses.FindAll(c => c.Fbmc == key).OrderBy(c => c.Xssx).ToList();
            List<VgObjectclass> tmpList = new List<VgObjectclass>(list);
            foreach (VgObjectclass objectClass in tmpList)
            {
                List<VgObjectclass> tmpChildren = FindChildClasses(objectClasses, objectClass.Mc);
                if (tmpChildren != null && tmpChildren.Count > 0)
                {
                    objectClass.SubClasses = tmpChildren;
                }
            }
            return list;
        }

        /// <summary>
        /// The FindFirstRecord
        /// </summary>
        /// <param name="layers">The <see cref="string[]"/></param>
        /// <param name="dx">The <see cref="double"/></param>
        /// <param name="dy">The <see cref="double"/></param>
        /// <returns>The <see cref="IReFeature"/></returns>
        public SearchFeature FindFirstRecord(List<VgObjectclass> classes, double dx, double dy)
        {
            IReFeature pFeature = null;
            try
            {
                
                for (int i = 0; i < classes.Count; i++)
                {
                    string sql =
                        SpatialHelper.SearchSQLBuilder(classes[i].Mc, (GeometryType)classes[i].Txlx, dx, dy, 2);
                    var features = connection.Query<SearchFeature>(sql);
                    if (features != null && features.Count() > 0)
                    {
                        return features.First();
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

        /// <summary>
        /// The FindRecords
        /// </summary>
        /// <param name="classes">The <see cref="List{VgObjectclass}"/></param>
        /// <param name="dx">The <see cref="double"/></param>
        /// <param name="dy">The <see cref="double"/></param>
        /// <returns>The <see cref="List{SearchFeature}"/></returns>
        public List<SearchFeature> FindRecords(List<VgObjectclass> classes, double dx, double dy)
        {
            try
            {
                List<SearchFeature> features = new List<SearchFeature>();
                for (int i = 0; i < classes.Count; i++)
                {
                    string sql =
                        SpatialHelper.SearchSQLBuilder(classes[i].Mc, (GeometryType)classes[i].Txlx, dx, dy, 2);

                    var findfeatures = connection.Query<SearchFeature>(sql).ToList();
                    if (findfeatures != null && findfeatures.Count() > 0)
                    {
                        features.AddRange(findfeatures);
                    }
                }
                return features;
            }
            catch (Exception ex)
            {
                Trace.TraceWarning(ex.Message);
                return null;
            }
            return null;
        }

        /// <summary>
        /// The FindRecords
        /// </summary>
        /// <param name="layers">The <see cref="string[]"/></param>
        /// <param name="dx">The <see cref="double"/></param>
        /// <param name="dy">The <see cref="double"/></param>
        /// <returns>The <see cref="List{SearchFeature}"/></returns>
        public List<SearchFeature> FindRecords(string[] layers, double dx, double dy)
        {
            try
            {
                List<SearchFeature> features = new List<SearchFeature>();
                for (int i = 0; i < layers.Length; i++)
                {
                    string sql =
                        string.Format(
                            "Select Id,AsText(geometry) as Wkt,Ysdm,'{0}' as TableName from {0} Where Flags<3 AND Within( GeomFromText('POINT({1} {2})'),geometry);",
                            layers[i], dx, dy);
                    var findfeatures = connection.Query<SearchFeature>(sql).ToList();
                    if (findfeatures != null && findfeatures.Count() > 0)
                    {
                        features.AddRange(findfeatures);
                    }
                }
                return features;
            }
            catch (Exception ex)
            {
                Trace.TraceWarning(ex.Message);
                return null;
            }
            return null;
        }

        /// <summary>
        /// The FindRecords
        /// </summary>
        /// <param name="objectclass">The <see cref="VgObjectclass"/></param>
        /// <param name="ids">The <see cref="int[]"/></param>
        /// <returns>The <see cref="List{SearchFeature}"/></returns>
        public List<SearchFeature> FindRecords(VgObjectclass objectclass, int[] ids)
        {
            try
            {
                List<SearchFeature> features = new List<SearchFeature>();

                string sql = SpatialHelper.SearchSQLBuilder(objectclass.Mc, ids);

                var findfeatures = connection.Query<SearchFeature>(sql).ToList();
                if (findfeatures != null && findfeatures.Count() > 0)
                {
                    features.AddRange(findfeatures);
                }

                return features;
            }
            catch (Exception ex)
            {
                Trace.TraceWarning(ex.Message);
                return null;
            }
            return null;
        }

        /// <summary>
        /// The GetAreaCodesByJB
        /// </summary>
        /// <param name="parentCode">The <see cref="string"/></param>
        /// <param name="jb">The <see cref="int"/></param>
        /// <returns>The <see cref="IEnumerable{VgAreacode}"/></returns>
        public IEnumerable<VgAreacode> GetAreaCodesByJB(string parentCode, int jb = 1)
        {
            string sql = "";
            if (jb <= 1)
            {
                sql = "select * from vg_areacode where XZQHJB=1";
            }
            else if (jb == 2)
            {
                sql = "select * from vg_areacode where XZQHJB=2 AND XZQHDM Like '" + parentCode.Substring(0, 2) + "%'";
            }
            else
            {
                sql = "select * from vg_areacode where XZQHJB=3 AND XZQHDM Like '" + parentCode.Substring(0, 4) + "%'";
            }

            return connection.Query<VgAreacode>(sql);
        }

        /// <summary>
        /// The GetGeometryColumnSRID
        /// </summary>
        /// <param name="tableName">The <see cref="string"/></param>
        /// <param name="columnName">The <see cref="string"/></param>
        /// <returns>The <see cref="int"/></returns>
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

        /// <summary>
        /// The GetObjectclasseses
        /// </summary>
        /// <param name="isDeep">The <see cref="bool"/></param>
        /// <returns>The <see cref="List{VgObjectclass}"/></returns>
        public List<VgObjectclass> GetObjectclasses(bool isDeep)
        {
            List<VgObjectclass> objectclasseses = connection.Query<VgObjectclass>("select * from vg_objectclass")
                .ToList();
            if (isDeep == false) return objectclasseses;

            List<VgObjectclass> list = objectclasseses.FindAll(c => c.Fbmc == null || c.Fbmc == "")
                .OrderBy(c => c.Xssx).ToList();
            List<VgObjectclass> newList = new List<VgObjectclass>(list);
            foreach (VgObjectclass objectClass in newList)
            {
                List<VgObjectclass> children = FindChildClasses(objectclasseses, objectClass.Mc);
                if (children != null && children.Count > 0)
                {
                    objectClass.SubClasses = children;
                }
            }
            return newList;
        }

        /// <summary>
        /// The GetVgSettings
        /// </summary>
        /// <param name="csmc">The <see cref="string"/></param>
        /// <returns>The <see cref="VgSettings"/></returns>
        public VgSetting GetVgSettingByName(string csmc)
        {
            string sql = "select Id,CSMC,CSZ from vg_setting" + " where Csmc='" + csmc + "'";
            IEnumerable<VgSetting> vgSettings = connection.Query<VgSetting>(sql);
            if (vgSettings != null && vgSettings.Count() > 0)
            {
                return vgSettings.First();
            }
            return null;
        }

        /// <summary>
        /// The InitSettings
        /// </summary>
        public void InitSettings()
        {
            VgSetting settings = new VgSetting() { Csmc = SettingKeyHelper.SpatialReferenceID, Csz = "4539" };
            SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = SettingKeyHelper.XingZhengQuHuaDaiMa, Csz = "320200" };
            SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = SettingKeyHelper.WX_DiaoChaYuan, Csz = "王先生" };
            SaveVgSetting2(settings);

            settings = new VgSetting() { Csmc = SettingKeyHelper.WX_CeLiangYuan, Csz = "张先生" };
            SaveVgSetting2(settings);

            List<TextAssignConfig> configs = new List<TextAssignConfig>();
            TextAssignConfig config = new TextAssignConfig("居民地楼层识别", "DXTJMDM", "FSXX1", AssignTextType.Integer, null);
            config.TextField = "Wbnr";
            config.TextTable = "DXTZJZJ";
            config.TextWhereClause = "[a].TC='ZJ'";
            configs.Add(config);

            config = new TextAssignConfig("居民地材质识别", "DXTJMDM", "FSXX2", AssignTextType.String,
                new List<string>() { "混", "砖", "砼", "破", "建" });
            config.TextField = "Wbnr";
            config.TextTable = "DXTZJZJ";
            config.TextWhereClause = "[a].TC='ZJ'";
            configs.Add(config);

            string configStr = JsonConvert.SerializeObject(configs);
            VgSetting setting = new VgSetting() { Csmc = SettingKeyHelper.DiXingTuWenZiShiBie, Csz = configStr };
            SaveVgSetting2(setting);
        }

        //public SystemDaoImpl():base()
        //{
        //    connection = DbConnection.GetConnection();
        //}
        /// <summary>
        /// The InitTables
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                // int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = VG_OBJECTCLASS;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_SETTING;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CADCODE;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_AREACODE;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_OBJECTYSDM;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_LAYERGROUP;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_LAYERGROUPDETAIL;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CLASSGROUP;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CLASSDETAIL;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_FIELDINFO;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_ATTACHMENT;
                    command.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    string dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Casscode.sql");

                    StreamReader reader = File.OpenText(dataFile);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        cmd.CommandText = line;
                        cmd.ExecuteNonQuery();
                    }
                    reader.Close();

                    dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Areacode.sql");

                    reader = File.OpenText(dataFile);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        cmd.CommandText = line;
                        cmd.ExecuteNonQuery();
                    }
                    reader.Close();

                    dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Ysdm.sql");

                    reader = File.OpenText(dataFile);
                    while (reader.Peek() > -1)
                    {
                        string line = reader.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line)) continue;
                        cmd.CommandText = line;
                        cmd.ExecuteNonQuery();
                    }
                    reader.Close();

                    dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                        "Templates\\Zdxx.sql");

                    reader = File.OpenText(dataFile);
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
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = VG_UPDATEYSDM;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterGroupSql("System");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_objectclass","IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_setting", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_cadcode", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_areacode", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_objectysdm", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_layergroup", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_layergroupdetail", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_classgroup", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_classdetail", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_fieldinfo", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_attachment", "IDatabaseEntity");
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }

        /// <summary>
        /// The InternalInitTables
        /// </summary>
        public void InternalInitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                // int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = VG_OBJECTCLASS;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_SETTING;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CADCODE;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_AREACODE;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_OBJECTYSDM;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_LAYERGROUP;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_LAYERGROUPDETAIL;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CLASSGROUP;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_CLASSDETAIL;
                    command.ExecuteNonQuery();
                    command.CommandText = VG_FIELDINFO;
                    command.ExecuteNonQuery();

                    command.CommandText = VG_ATTACHMENT;
                    command.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = Properties.Resources.Casscodes;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = Properties.Resources.Areacodes;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }

            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = Properties.Resources.Ysdm;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = VG_UPDATEYSDM;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = Properties.Resources.Zdxx;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterGroupSql("System");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_objectclass", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_setting", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_cadcode", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_areacode", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_objectysdm", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_layergroup", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_layergroupdetail", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_classgroup", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_classdetail", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_fieldinfo", "IEntity");
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = GetRegisterClassSql("System", "vg_attachment","IDatabaseEntity");
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
        }

        /// <summary>
        /// The IsNumberic
        /// </summary>
        /// <param name="oText">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
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

        /// <summary>
        /// The RecalculateDBExtent
        /// </summary>
        /// <param name="xmin">The <see cref="double"/></param>
        /// <param name="ymin">The <see cref="double"/></param>
        /// <param name="xmax">The <see cref="double"/></param>
        /// <param name="ymax">The <see cref="double"/></param>
        public void RecalculateDBExtent(out double xmin, out double ymin, out double xmax, out double ymax)
        {
            string sql =
                "SELECT MIN(extent_min_x) as MinX,MIN(extent_min_y) as MinY,MAX(extent_max_x) as MaxX,MAX(extent_max_Y) as MaxY from vector_layers_statistics;";
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                xmin = reader.GetDouble(0);
                ymin = reader.GetDouble(1);
                xmax = reader.GetDouble(2);
                ymax = reader.GetDouble(3);
                reader.Close();
            }
        }

        /// <summary>
        /// The SaveNewSearchFeature
        /// </summary>
        /// <param name="feature">The <see cref="SearchFeature"/></param>
        /// <param name="fireEvents">The <see cref="bool"/></param>
        /// <returns>The <see cref="long"/></returns>
        public long SaveNewSearchFeature(SearchFeature feature, bool fireEvents = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                List<string> sourceColumns = GetAllColumns(feature.TableName);
                StringBuilder builder = new StringBuilder();
                StringBuilder valuesbuilder = new StringBuilder();
                if (sourceColumns.Contains("wx_wydm"))
                {

                    builder.Append("insert into " + feature.TableName + "(wx_wydm, geometry,ysdm");
                    valuesbuilder.Append(" VALUES(@wx_wydm,GeomFromText(@wkt,@SRID),@ysdm");

                }
                else
                {

                    builder.Append("insert into " + feature.TableName + "(geometry");
                    valuesbuilder.Append(" VALUES(GeomFromText(@wkt,@SRID)");
                }

                if (sourceColumns.Contains("databaseid"))
                {

                    builder.Append(",databaseid, flags,xgr,xrsj)");
                    valuesbuilder.Append(",0,1,@XGR,@XGSJ)");
                }
                else
                {

                    builder.Append(")");
                    valuesbuilder.Append(")");

                }

                builder.Append(valuesbuilder.ToString());
                builder.Append(";select last_insert_rowid();");

                command.CommandText = builder.ToString();
                if (sourceColumns.Contains("wx_wydm"))
                {

                    command.Parameters.AddWithValue("@wx_wydm", Guid.NewGuid());
                }
                if (sourceColumns.Contains("databaseid"))
                {

                    command.Parameters.AddWithValue("@XGR", Environment.UserName);
                    command.Parameters.AddWithValue("@XGSJ", DateTime.Now);
                }
                command.Parameters.AddWithValue("@wkt", feature.Wkt);
                command.Parameters.AddWithValue("@ysdm", feature.Ysdm);
                command.Parameters.AddWithValue("@SRID", GetSRID());
                long rowid = Convert.ToInt64(command.ExecuteScalar());
                feature.ID = rowid;
                OnEntityChanged(feature.TableName, GetLayerNameFromTable(feature.TableName), EntityOperationType.Save,
                    new List<long>() { rowid });
                return rowid;
            }
        }

        /// <summary>
        /// The SaveSearchFeature
        /// </summary>
        /// <param name="feature">The <see cref="SearchFeature"/></param>
        /// <param name="fireEvents">The <see cref="bool"/></param>
        /// <returns>The <see cref="long"/></returns>
        public long SaveSearchFeature(SearchFeature feature)
        {
            feature.Save(this);
          
            OnEntityChanged(feature.TableName, GetLayerNameFromTable(feature.TableName), EntityOperationType.Save,
                new List<long>() { feature.ID });
            return feature.ID;
        }

        /// <summary>
        /// The SaveSearchFeatures
        /// </summary>
        /// <param name="features">The <see cref="List{SearchFeature}"/></param>
        /// <returns>The <see cref="List{long}"/></returns>
        public List<long> SaveSearchFeatures(List<SearchFeature> features)
        {

            int srid = GetSRID();
            foreach (var feature in features)
            {
                feature.Save(this);
            }
            List<long> ids = features.Select(c => c.ID).ToList();
            OnEntityChanged(features[0].TableName, GetLayerNameFromTable(features[0].TableName),
                EntityOperationType.Delete, ids);
            return ids;
        }

        /// <summary>
        /// The SaveVgSettings2
        /// </summary>
        /// <param name="csmc">The <see cref="string"/></param>
        /// <param name="csz">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool SaveVgSetting2(string csmc, string csz)
        {
            VgSetting settings = new VgSetting() { Csmc = csmc, Csz = csz };
            return SaveVgSetting2(settings);
        }

        /// <summary>
        /// The SaveVgSettings2
        /// </summary>
        /// <param name="setting">The <see cref="VgSettings"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public bool SaveVgSetting2(VgSetting setting)
        {
            VgSetting oldSetting = this.GetVgSettingByName(setting.Csmc);
            if (oldSetting != null)
            {
                oldSetting.Csz = setting.Csz;
                SaveVgSetting(oldSetting);
            }
            else
            {
                SaveVgSetting(setting);
            }
            return true;
        }

        /// <summary>
        /// The SaveSearchFeature
        /// </summary>
        /// <param name="feature">The <see cref="SearchFeature"/></param>
        /// <returns>The <see cref="long"/></returns>
        public long UpdateSearchFeature(SearchFeature feature)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                List<string> sourceColumns = GetAllColumns(feature.TableName);
                StringBuilder builder = new StringBuilder();
                if (sourceColumns.Contains("wx_wydm"))
                {
                    builder.Append("update " + feature.TableName + " set wx_dcsj=@wxdjsj, geometry=GeomFromText(@wkt,@SRID),ysdm=@ysdm");
                }
                else
                {

                    builder.Append("update " + feature.TableName + " set geometry=GeomFromText(@wkt,@SRID)");

                }

                if (sourceColumns.Contains("databaseid"))
                {
                    builder.Append(", flags=2 Where Id=@Id");
                }
                else
                {
                    builder.Append(" Where Id=@Id");

                }

                builder.Append(";");

                command.CommandText = builder.ToString();
                if (sourceColumns.Contains("wx_wydm"))
                {
                    command.Parameters.AddWithValue("@wxdjsj", DateTime.Now);
                }
                command.Parameters.AddWithValue("@wkt", feature.Wkt);
                command.Parameters.AddWithValue("@ysdm", feature.Ysdm);
                command.Parameters.AddWithValue("@SRID", GetSRID());
                command.Parameters.AddWithValue("@Id", feature.ID);
                command.ExecuteNonQuery();
                OnEntityChanged(feature.TableName, GetLayerNameFromTable(feature.TableName), EntityOperationType.Save,
                    new List<long>() { feature.ID });
                return feature.ID;
            }
        }

        #endregion

        #region 附件方法
        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(string wydm)
        {
            string sql = "select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS from vg_attachment  where WX_WYDM='" + wydm+"' AND FLAGS<3";
            var vgAttachments = connection.Query<VgAttachment>(sql);
            return vgAttachments;
        }

        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(Guid wydm)
        {
            string sql = "select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS from vg_attachment  where WX_WYDM='" + wydm.ToString()+"' AND FLAGS<3";
            var vgAttachments = connection.Query<VgAttachment>(sql);
            return vgAttachments;
        }

        #endregion

        #region 表名反向

        public VgClassdetail GetVgClassdetailByTableName(string tbName)
        {
            string sql = "select Id,GroupName, ObjectTableName,CreateImpl,InterfaceName  from vg_classdetail where  UPPER(ObjectTableName) ='" + tbName.ToUpper() + "'";
            var vgClassdetails = connection.Query<VgClassdetail>(sql);
            if (vgClassdetails == null) return null;
            return vgClassdetails.First();
        }
#endregion
    }
}
