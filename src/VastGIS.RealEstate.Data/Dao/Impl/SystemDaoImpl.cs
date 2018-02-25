using System.Collections;
using System.Data.Entity.ModelConfiguration.Conventions;

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
                "CREATE TABLE [vg_areacode] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[XZQHMC] NCHAR(100), [XZQHDM] CHAR(6), [XZQHJB] INTEGER);"
            ;

        /// <summary>
        /// Defines the VG_ATTACHMENTS
        /// </summary>
        protected const string VG_ATTACHMENT =
                "CREATE TABLE [vg_attachment] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[WX_WYDM] NVARCHAR,[FJMC] NCHAR(200),[FJLJ] NVARCHAR,[FJLX] CHAR(5),[HQSJ] DATETIME,[FJSM] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
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

        protected const string CREATE_TEMPCADDVIEW =
                "CREATE VIEW [TmpCaddView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2], [b].[Xzjd] AS [Xzjd], [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadd] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);"
            ;

        protected const string CREATE_TEMPCADXVIEW =
                "CREATE VIEW [TmpCadxView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2],  [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadx] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);"
            ;

        protected const string CREATE_TEMPCADMVIEW =
                "CREATE VIEW [TmpCadmView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2],  [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadm] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);"
            ;

        protected const string CREATE_TEMPCADZJVIEW =
                "CREATE VIEW [TmpCadzjView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Wbnr] AS [Wbnr],[b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2], [b].[Xzjd] AS [Xzjd], [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadzj] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);"
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
            List<VgObjectclass> objectclasseses =
                connection.Query<VgObjectclass>("select * from vg_objectclass").ToList();
            if (isDeep == false) return objectclasseses;

            List<VgObjectclass> list = objectclasseses.FindAll(c => c.Fbmc == null || c.Fbmc == "").OrderBy(c => c.Xssx)
                .ToList();
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
                    cmd.CommandText = Properties.Resources.Casscode;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = Properties.Resources.Areacode;
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
                    cmd.CommandText = GetRegisterClassSql("System", "vg_attachment", "IDatabaseEntity");
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
        
        #endregion

        #region 附件方法

        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(string wydm)
        {
            string sql =
                "SELECT  Id As ID,WX_WYDM As WxWydm,FJMC As Fjmc,FJLJ As Fjlj,FJLX As Fjlx,HQSJ As Hqsj,FJSM As Fjsm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM vg_attachment   where WX_WYDM='" +
                wydm + "' AND FLAGS<3";
            var vgAttachments = connection.Query<VgAttachment>(sql);
            return vgAttachments;
        }

        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(Guid wydm)
        {
            string sql =
                "SELECT  Id As ID,WX_WYDM As WxWydm,FJMC As Fjmc,FJLJ As Fjlj,FJLX As Fjlx,HQSJ As Hqsj,FJSM As Fjsm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM vg_attachment   where WX_WYDM='" +
                wydm.ToString() + "' AND FLAGS<3";
            var vgAttachments = connection.Query<VgAttachment>(sql);
            return vgAttachments;
        }

        #endregion

        #region 表名反向

        public VgClassdetail GetVgClassdetailByTableName(string tbName)
        {
            string sql =
                "select Id,GroupName, ObjectTableName,CreateImpl,InterfaceName  from vg_classdetail where  UPPER(ObjectTableName) ='" +
                tbName.ToUpper() + "'";
            var vgClassdetails = connection.Query<VgClassdetail>(sql);
            if (vgClassdetails == null) return null;
            return vgClassdetails.First();
        }

        public string GetTemporaryAttachmentName()
        {
            //先获得数据库路径
            return ProjectHelper.GetAttachmentFileName(connection.DataSource);
        }

        
        #endregion

      
        #region CAD数据视图初始化，从CADDaoImpl转过来
        public void CreateAndRegisterCadView()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = CREATE_TEMPCADDVIEW;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADXVIEW;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADMVIEW;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADZJVIEW;
                    command.ExecuteNonQuery();

                    command.CommandText =
                        "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only])" +
                        "values('tmpcaddview','geometry','rowid','tmpcadd','geometry',1)";

                    command.ExecuteNonQuery();

                    command.CommandText =
                        "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only])" +
                        "values('tmpcadxview','geometry','rowid','tmpcadx','geometry',1)";
                    command.ExecuteNonQuery();

                    command.CommandText =
                        "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only])" +
                        "values('tmpcadmview','geometry','rowid','tmpcadm','geometry',1)";
                    command.ExecuteNonQuery();

                    command.CommandText =
                        "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only])" +
                        "values('tmpcadzjview','geometry','rowid','tmpcadzj','geometry',1)";
                    command.ExecuteNonQuery();
                }
                trans.Commit();
            }
        }
        #endregion
    }
}
