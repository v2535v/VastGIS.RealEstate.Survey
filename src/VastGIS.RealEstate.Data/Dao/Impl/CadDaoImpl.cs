using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Dao.Impl
{
    public partial class CadDaoImpl
    {
        #region 初始化
        protected const string CREATE_TEMPCADD =
                "CREATE TABLE [TmpCadd] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [EntityType] CHAR(100),   [Handle] CHAR(20),   [FileName] NCHAR(200));"
            ;

        protected const string CREATE_TEMPCADX =
                "CREATE TABLE [TmpCadx] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [EntityType] CHAR(100),   [Handle] CHAR(20),   [FileName] NChar(200));"
            ;

        protected const string CREATE_TEMPCADM =
                "CREATE TABLE [TmpCadm] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [EntityType] CHAR(100),   [Handle] CHAR(20),   [FileName] NChar(200));"
            ;

        protected const string CREATE_TEMPCADZJ =
                "CREATE TABLE [TmpCadzj] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [EntityType] CHAR(100),   [Handle] CHAR(20),   [FileName] NChar(200));"
            ;

        protected const string CREATE_TEMPCADXDATA =
            "CREATE TABLE [TmpCadxdata] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [Handle] CHAR(20),   [Tc] NCHAR(100),   [Wbnr] NCHAR(200),   [Cassdm] NCHAR(20),   [Fsxx1] NCHAR(200),   [Fsxx2] NCHAR(200),   [Xzjd] FLOAT,   [Fh] NCHAR(100),   [Fhdx] Float,   [Ysdm] CHAR(10),   [FileName] NCHAR(200));";

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

        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = CREATE_TEMPCADD;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadd','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadx','geometry',{0},'LINESTRING','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADM;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadm','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadzj','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_TEMPCADXDATA;
                    command.ExecuteNonQuery();

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
            return true;
        }

        #endregion
        public void UpdateTmpCadYsdm()
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =
                    "update TmpCadxdata set Ysdm=(select vg_cadcodes.Ysdm from vg_cadcodes where vg_cadcodes.Cassdm=TmpCadxdata.Cassdm and vg_cadcodes.Tc=TmpCadxdata.Tc limit 1)";
                command.ExecuteNonQuery();
            }
        }

        public void ClearCADTemps()
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                command.CommandText = "delete from tmpcadd";
                command.ExecuteNonQuery();
                command.CommandText = "delete from tmpcadx";
                command.ExecuteNonQuery();
                command.CommandText = "delete from tmpcadm";
                command.ExecuteNonQuery();
                command.CommandText = "delete from tmpcadzj";
                command.ExecuteNonQuery();
                command.CommandText = "delete from tmpcadxdata";
                command.ExecuteNonQuery();
            }
        }

        public void ClearCADTemps(CADInsertMethod insertMethod, string dxfName)
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                if (insertMethod == CADInsertMethod.DeleteAll)
                {
                    command.CommandText = "delete from tmpcadd";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadx";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadm";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadzj";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadxdata";
                    command.ExecuteNonQuery();
                }
                else if (insertMethod == CADInsertMethod.DeleteByFileName)
                {
                    command.CommandText = "delete from tmpcadd where FileName='" + dxfName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadx where FileName='" + dxfName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadm where FileName='" + dxfName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadzj where FileName='" + dxfName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "delete from tmpcadxdata where FileName='" + dxfName + "'";
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool HasCADData(string fileName)
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                command.CommandText = "select Count(*) from [tmpcadx] where [FileName] = '" + fileName + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (isClear)
                {
                    command.CommandText = string.Format("delete from {0}D", tableName);
                    command.ExecuteNonQuery();
                    command.CommandText = string.Format("delete from {0}X", tableName);
                    command.ExecuteNonQuery();
                    command.CommandText = string.Format("delete from {0}M", tableName);
                    command.ExecuteNonQuery();
                    command.CommandText = string.Format("delete from {0}ZJ", tableName);
                    command.ExecuteNonQuery();


                }
                //查询点
                if (cadLayerName != "")
                    sql = string.Format(
                        @"INSERT INTO {0}D ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[XZJD],[Fh],[YSDM])" +
                        " SELECT [a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "   [a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "   [a].[Fsxx2] AS [Fsxx2], [a].[Xzjd] AS [Xzjd], [a].[Fh] AS [Fh]," +
                        "   [a].[YSDM] AS [YSDM] " +
                        " FROM [TmpCaddView] AS [a]" +
                        " WHERE [a].[Tc]='{1}'", tableName, cadLayerName);
                else
                {
                    sql = string.Format(
                        @"INSERT INTO {0}D ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[XZJD],[Fh],[YSDM])" +
                        " SELECT [a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "   [a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "   [a].[Fsxx2] AS [Fsxx2], [a].[Xzjd] AS [Xzjd], [a].[Fh] AS [Fh]," +
                        "   [a].[YSDM] AS [YSDM] " +
                        " FROM [TmpCaddView] AS [a]", tableName);
                }
                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                if (cadLayerName != "")
                    sql = string.Format(
                        "INSERT INTO {0}X ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[FH],[FHDX],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  [a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadxView] AS [a]  " +
                        "WHERE [a].[Tc] = '{1}'", tableName, cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO {0}X ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[FH],[FHDX],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  [a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadxView] AS [a] ", tableName);

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                if (cadLayerName != "")
                    sql = string.Format(
                        "INSERT INTO {0}M ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  " + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadmView] AS [a]  " +
                        "WHERE[a].[Tc] = '{1}'", tableName, cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO {0}M ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  " + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadmView] AS [a]  ", tableName);

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                if (cadLayerName != "")
                    sql = string.Format(
                        "INSERT INTO {0}ZJ ([geometry],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[WBNR] AS [WBNR], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], " +
                        "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadzjView] AS [a]  " +
                        "WHERE [a].[Tc] = '{1}'", tableName, cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO {0}ZJ ([geometry],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[WBNR] AS [WBNR], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], " +
                        "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadzjView] AS [a]", tableName);

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadd where Handle in (select Handle from TmpCaddView where Tc = '{0}')", cadLayerName) : "delete from TmpCadd";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadx where Handle in (select Handle from TmpCadxView where Tc = '{0}')", cadLayerName) : "delete from TmpCadx";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadm where Handle in (select Handle from TmpCadmView where Tc = '{0}')", cadLayerName) : "delete from TmpCadm";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadzj where Handle in (select Handle from TmpCadzjView where Tc = '{0}')", cadLayerName) : "delete from TmpCadzj";
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

    }
}