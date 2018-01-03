using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using Dapper;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Dao.Impl
{
    public class MainDaoImpl : MainDao
    {
        public void Close()
        {
            DbConnection.GetConnection().Close();
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

        public void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear=true)
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
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
                //≤È—Øµ„
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
                        " FROM [TmpCaddView] AS [a]" , tableName);
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
                        "FROM [TmpCadxView] AS [a] " , tableName);

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
                        "FROM [TmpCadmView] AS [a]  " , tableName);

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

                sql = cadLayerName != "" ? string.Format("delete from TmpCadd where Handle in (select Handle from TmpCaddView where Tc = '{0}')",cadLayerName): "delete from TmpCadd";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadx where Handle in (select Handle from TmpCadxView where Tc = '{0}')", cadLayerName): "delete from TmpCadx";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadm where Handle in (select Handle from TmpCadmView where Tc = '{0}')", cadLayerName):"delete from TmpCadm";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != "" ? string.Format("delete from TmpCadzj where Handle in (select Handle from TmpCadzjView where Tc = '{0}')", cadLayerName): "delete from TmpCadzj";
                command.CommandText = sql;
                command.ExecuteNonQuery();
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
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                string sql = "";
                if(string.IsNullOrEmpty(whereClause))
                    sql=string.Format(
                    "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry);",
                    textFieldName, textTable, polyTable);
                else
                    sql = string.Format(
                        "Select a.{0} as Wbnr,b.Id as polyid from {1} a JOIN {2} b on Within(a.geometry,b.geometry) where {3};",
                        textFieldName, textTable, polyTable,whereClause);
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
                            updateSQL=String.Format("update {0} set {1}='{2}' where Id={3}",polyTable,polyFieldName,textContext,polyId);
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

        public void UpdateTmpCadYsdm()
        {
            using (SQLiteCommand command = new SQLiteCommand(DbConnection.GetConnection()))
            {
                command.CommandText =
                    "update TmpCadxdata set Ysdm=(select vg_cadcodes.Ysdm from vg_cadcodes where vg_cadcodes.Cassdm=TmpCadxdata.Cassdm and vg_cadcodes.Tc=TmpCadxdata.Tc limit 1)";
                command.ExecuteNonQuery();
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