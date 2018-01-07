using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using System.Linq;
using netDxf;
using netDxf.Collections;
using netDxf.Entities;
using OSGeo.GDAL;
using OSGeo.OGR;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Service;
using VastGIS.Shared;
using Geometry = VastGIS.Api.Concrete.Geometry;
using Layer = VastGIS.Api.Concrete.Layer;

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
                "CREATE TABLE [TmpCadxdata] (   [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,   [Handle] CHAR(20),   [Tc] NCHAR(100),   [Wbnr] NCHAR(200),   [Cassdm] NCHAR(20),   [Fsxx1] NCHAR(200),   [Fsxx2] NCHAR(200),   [Xzjd] FLOAT,   [Fh] NCHAR(100),   [Fhdx] Float,   [Ysdm] CHAR(10),   [FileName] NCHAR(200));"
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
                command.CommandText= "update TmpCadxdata set YSDM = Replace(YSDM, \"'\", \"\")";
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
                        "   [a].[YSDM] AS [YSDM] " + " FROM [TmpCaddView] AS [a]" + " WHERE [a].[Tc]='{1}'", tableName,
                        cadLayerName);
                else
                {
                    sql = string.Format(
                        @"INSERT INTO {0}D ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[XZJD],[Fh],[YSDM])" +
                        " SELECT [a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "   [a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "   [a].[Fsxx2] AS [Fsxx2], [a].[Xzjd] AS [Xzjd], [a].[Fh] AS [Fh]," +
                        "   [a].[YSDM] AS [YSDM] " + " FROM [TmpCaddView] AS [a]", tableName);
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
                        "FROM [TmpCadxView] AS [a]  " + "WHERE [a].[Tc] = '{1}'", tableName, cadLayerName);
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
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," + "[a].[Fsxx2] AS [Fsxx2],  " +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadmView] AS [a]  " + "WHERE[a].[Tc] = '{1}'", tableName,
                        cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO {0}M ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," + "[a].[Fsxx2] AS [Fsxx2],  " +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadmView] AS [a]  ", tableName);

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
                        "[a].[Cassdm] AS [Cassdm], " + "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadzjView] AS [a]  " + "WHERE [a].[Tc] = '{1}'", tableName,
                        cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO {0}ZJ ([geometry],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[WBNR] AS [WBNR], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], " + "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadzjView] AS [a]", tableName);

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadd where Handle in (select Handle from TmpCaddView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadd";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadx where Handle in (select Handle from TmpCadxView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadx";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadm where Handle in (select Handle from TmpCadmView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadm";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadzj where Handle in (select Handle from TmpCadzjView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadzj";
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        public bool ImportDxfDrawing(string dxfName, out string errorMsg)
        {
            try
            {
                dxfName = StringHelper.StringToUtf8(dxfName, System.Text.Encoding.Default.BodyName);
                errorMsg = "";
                DxfDocument doc = DxfDocument.Load(dxfName);
                string xodePage = "";

                int codenum = Convert.ToInt32(doc.DrawingVariables.DwgCodePage.Split('_')[1]);
                xodePage = Encoding.GetEncoding(codenum).BodyName;

                int srid = GetSystemSRID();

                DeleteTmpCadd("FileName='" + dxfName + "'");
                DeleteTmpCadx("FileName='" + dxfName + "'");
                DeleteTmpCadm("FileName='" + dxfName + "'");
                DeleteTmpCadzj("FileName='" + dxfName + "'");
                DeleteTmpCadxdata("FileName='" + dxfName + "'");

                List<TmpCadd> cadds = new List<TmpCadd>();
                List<TmpCadx> cadxs = new List<TmpCadx>();
                List<TmpCadm> cadms = new List<TmpCadm>();
                List<TmpCadzj> cadzjs = new List<TmpCadzj>();
                List<TmpCadxdata> cadxdatas = new List<TmpCadxdata>();

                Ogr.RegisterAll();
                Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
                Gdal.SetConfigOption("DXF_ENCODING", xodePage);
                DataSource ds = Ogr.Open(dxfName, Convert.ToInt32(false));
                if (ds == null)
                {
                    errorMsg = "DXF文件路径中可能包含非法字符，请检查!";
                    return false;
                }

                for (int i = 0; i < ds.GetLayerCount(); i++)
                {
                    OSGeo.OGR.Layer pLayer = ds.GetLayerByIndex(i);
                    OSGeo.OGR.Feature feat = pLayer.GetNextFeature();
                    while (feat != null)
                    {
                        string handle = feat.GetFieldAsString(4);
                        string typeName = feat.GetFieldAsString(1).Trim().Replace("AcDbEntity:", "");
                        // string layerName = feat.GetFieldAsString("Layer");
                        // System.Diagnostics.Trace.TraceWarning("LayerName: "+layerName);
                        string geomtryStr = "";
                        OSGeo.OGR.Geometry geometry = feat.GetGeometryRef();
                        geometry.FlattenTo2D();
                        geometry.ExportToWkt(out geomtryStr);

                        switch (typeName)
                        {
                            case "AcDbPolyline":
                            case "AcDbLine":
                                TmpCadx cadx =
                                    new TmpCadx()
                                        {
                                            EntityType = "POLYLINE",
                                            FileName = dxfName,
                                            Handle = handle,
                                            Wkt = geomtryStr
                                        };
                                cadxs.Add(cadx);
                                //判断是否是单一的多边形，如果是，则插入多边形

                                int pntCounts = geometry.GetPointCount();
                                if (pntCounts > 3)
                                {
                                    double startx = geometry.GetX(0);
                                    double starty = geometry.GetY(0);
                                    double endx = geometry.GetX(pntCounts - 1);
                                    double endy = geometry.GetY(pntCounts - 1);

                                    if (Math.Abs(startx - endx) < 0.0001 && Math.Abs(starty - endy) < 0.0001)
                                    {
                                        //说明为多边形
                                        OSGeo.OGR.Geometry polygeometry = Ogr.ForceToPolygon(geometry);
                                        polygeometry.ExportToWkt(out geomtryStr);
                                        TmpCadm cadm =
                                            new TmpCadm()
                                                {
                                                    EntityType = "POLYGON",
                                                    FileName = dxfName,
                                                    Handle = handle,
                                                    Wkt=geomtryStr
                                                };
                                        cadms.Add(cadm);
                                    }
                                }

                                break;
                            case "AcDbBlockReference":
                                //TmpCadd cadd=new TmpCadd(handle, geomtryStr, "POINT");
                                //caddService.Create(cadd);
                                //因为GDAL直接读取了块图形，因此，块在下面的方法和属性一起读取
                                break;
                            case "AcDbText:AcDbText":
                                TmpCadzj cadzj =
                                    new TmpCadzj()
                                        {
                                            EntityType = "TEXT",
                                            FileName = dxfName,
                                            Handle = handle,
                                            Wkt=geomtryStr
                                        };
                                cadzjs.Add(cadzj);
                                break;
                            default:

                                System.Diagnostics.Trace.TraceInformation("CAD类型未处理 {0}", typeName);
                                break;
                        }

                        feat.Dispose();
                        feat = pLayer.GetNextFeature();
                    }
                }

                //开始读取点数据

                for (int i = 0; i < doc.Inserts.Count; i++)
                {
                    Insert insert = doc.Inserts[i];
                    TmpCadd cadd = new TmpCadd();
                    cadd.Handle = insert.Handle;
                    cadd.EntityType = "POINT";
                    cadd.FileName = dxfName;
                    //cadd.Wkt =string.Format("POINT({0} {1})", insert.Position.X, insert.Position.Y);
                    cadd.Wkt =
                        string.Format("POINT({0} {1})", insert.Position.X, insert.Position.Y);
                    cadds.Add(cadd);

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Block.Name, xodePage);
                    cadxdata.Fhdx = insert.Scale.X;
                    cadxdata.Xzjd = insert.Rotation;
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdatas.Add(cadxdata);
                }

                for (int i = 0; i < doc.Texts.Count; i++)
                {
                    Text insert = doc.Texts[i];

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Style.FontFamilyName, xodePage);
                    cadxdata.Fhdx = insert.Height;
                    cadxdata.Xzjd = insert.Rotation;
                    cadxdata.Wbnr = StringHelper.StringToUtf8(insert.Value, xodePage);
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdatas.Add(cadxdata);
                }

                for (int i = 0; i < doc.Lines.Count; i++)
                {
                    Line insert = doc.Lines[i];

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = insert.Linetype.Name;
                    cadxdata.Fhdx = insert.LinetypeScale;
                    cadxdata.Xzjd = 0.0;
                    cadxdata.Wbnr = "";
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdatas.Add(cadxdata);
                }

                for (int i = 0; i < doc.LwPolylines.Count; i++)
                {
                    LwPolyline insert = doc.LwPolylines[i];

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Linetype.Name, xodePage);
                    cadxdata.Fhdx = insert.LinetypeScale;
                    cadxdata.Xzjd = 0.0;
                    cadxdata.Wbnr = "";
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdatas.Add(cadxdata);
                }

                for (int i = 0; i < doc.Polylines.Count; i++)
                {
                    Polyline insert = doc.Polylines[i];

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Linetype.Name);
                    cadxdata.Fhdx = insert.LinetypeScale;
                    cadxdata.Xzjd = 0.0;
                    cadxdata.Wbnr = "";
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdatas.Add(cadxdata);
                }

                SaveTmpCadds(cadds);
                SaveTmpCadxs(cadxs);
                SaveTmpCadms(cadms);
                SaveTmpCadzjs(cadzjs);
                SaveTmpCadxdatas(cadxdatas);
                UpdateTmpCadYsdm();
                errorMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = string.Format("导入DXF发生错误，{0}", ex.Message);
                return false;
            }
        }

        public bool ImportTmpCadToBasemap(bool isClearBasemap=true,string fileName="")
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = "SELECT DISTINCT TC FROM TmpCaddView";
                SQLiteDataReader reader = command.ExecuteReader();
                string sql = "";
                while (reader.Read())
                {
                    string tcName = reader.GetString(0).ToUpper().Trim();
                    if (string.IsNullOrEmpty(tcName)) continue;
                    string baseName = "DXT" + tcName;
                    if (!SQLiteHelper.TableExists(connection,baseName + "D"))
                    {
                        continue;
                    }
                    ImportTmpCaddToBasemap(tcName,  fileName, isClearBasemap);
                }
                reader.Close();
                ImportTmpCaddToBasemap("", fileName, isClearBasemap);

                command.CommandText = "SELECT DISTINCT TC FROM TmpCadxView";
                reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    string tcName = reader.GetString(0).ToUpper().Trim();
                    if (string.IsNullOrEmpty(tcName)) continue;
                    string baseName = "DXT" + tcName;
                    if (!SQLiteHelper.TableExists(connection, baseName + "X"))
                    {
                        continue;
                    }
                    ImportTmpCadxToBasemap(tcName, fileName, isClearBasemap);
                }
                reader.Close();
                ImportTmpCadxToBasemap("", fileName, isClearBasemap);

                command.CommandText = "SELECT DISTINCT TC FROM TmpCadmView";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tcName = reader.GetString(0).ToUpper().Trim();
                    if (string.IsNullOrEmpty(tcName)) continue;
                    string baseName = "DXT" + tcName;
                    if (!SQLiteHelper.TableExists(connection, baseName + "M"))
                    {
                        continue;
                    }
                    ImportTmpCadmToBasemap(tcName, fileName, isClearBasemap);
                }
                reader.Close();
                ImportTmpCadmToBasemap("", fileName, isClearBasemap);

                command.CommandText = "SELECT DISTINCT TC FROM TmpCadzjView";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tcName = reader.GetString(0).ToUpper().Trim();
                    if (string.IsNullOrEmpty(tcName)) continue;
                    string baseName = "DXT" + tcName;
                    if (!SQLiteHelper.TableExists(connection, baseName + "ZJ"))
                    {
                        continue;
                    }
                    ImportTmpCadzjToBasemap(tcName, fileName, isClearBasemap);
                }
                reader.Close();
                ImportTmpCadzjToBasemap("", fileName, isClearBasemap);
            }
            return true;
        }

        public void ImportTmpCaddToBasemap(string cadLayerName, string fileName = "", bool isClear = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (isClear)
                {
                    command.CommandText = string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? "delete from DXTQTD":string.Format("delete from DXT{0}D", cadLayerName)  ;
                    command.ExecuteNonQuery();
                }
                //查询点
                if (!string.IsNullOrWhiteSpace(cadLayerName) && !string.IsNullOrEmpty(cadLayerName))
                    sql = string.Format(
                        @"INSERT INTO DXT{0}D ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[XZJD],[Fh],[YSDM])" +
                        " SELECT [a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "   [a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "   [a].[Fsxx2] AS [Fsxx2], [a].[Xzjd] AS [Xzjd], [a].[Fh] AS [Fh]," +
                        "   [a].[YSDM] AS [YSDM] " + " FROM [TmpCaddView] AS [a]" + " WHERE [a].[Tc]='{0}'", cadLayerName
                        );
                else
                {
                    sql = string.Format(
                        @"INSERT INTO DXTQTD ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[XZJD],[Fh],[YSDM])" +
                        " SELECT [a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "   [a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "   [a].[Fsxx2] AS [Fsxx2], [a].[Xzjd] AS [Xzjd], [a].[Fh] AS [Fh]," +
                        "   [a].[YSDM] AS [YSDM] " + " FROM [TmpCaddView] AS [a]");
                }
                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? string.Format(" Where  [a].[FileName]='{0}'", fileName): string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                
                sql = string.IsNullOrWhiteSpace(cadLayerName)
                          ? "delete from TmpCadd":string.Format(
                              "delete from TmpCadd where Handle in (select Handle from TmpCaddView where Tc = '{0}')",
                              cadLayerName)
                         ;
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
        public void ImportTmpCadxToBasemap(string cadLayerName,  string fileName = "", bool isClear = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (isClear)
                {
                  
                    command.CommandText = string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? "delete from DXTQTX" : string.Format("delete from DXT{0}X", cadLayerName);
                    command.ExecuteNonQuery();
                  
                }

                if (!string.IsNullOrWhiteSpace(cadLayerName) && !string.IsNullOrEmpty(cadLayerName))
                    sql = string.Format(
                        "INSERT INTO DXT{0}X ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[FH],[FHDX],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  [a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadxView] AS [a]  " + "WHERE [a].[Tc] = '{0}'",  cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO DXTQTX ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[FH],[FHDX],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," +
                        "[a].[Fsxx2] AS [Fsxx2],  [a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX]," + "[a].[YSDM] AS [YSDM]  " +
                        "FROM [TmpCadxView] AS [a] ");

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? string.Format(" Where  [a].[FileName]='{0}'", fileName) : string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadx where Handle in (select Handle from TmpCadxView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadx";
                command.CommandText = sql;
                command.ExecuteNonQuery();

          
            }
        }
        public void ImportTmpCadmToBasemap(string cadLayerName,  string fileName = "", bool isClear = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (isClear)
                {
                    command.CommandText = string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? "delete from DXTQTM" : string.Format("delete from DXT{0}M", cadLayerName);
                    command.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(cadLayerName) && !string.IsNullOrEmpty(cadLayerName))
                    sql = string.Format(
                        "INSERT INTO DXT{0}M ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," + "[a].[Fsxx2] AS [Fsxx2],  " +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadmView] AS [a]  " + "WHERE[a].[Tc] = '{0}'", cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO DXTQTM ([geometry],[TC],[CASSDM],[FSXX1],[FSXX2],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], [a].[Fsxx1] AS [Fsxx1]," + "[a].[Fsxx2] AS [Fsxx2],  " +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadmView] AS [a]  ");

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? string.Format(" Where  [a].[FileName]='{0}'", fileName) : string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadm where Handle in (select Handle from TmpCadmView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadm";
                command.CommandText = sql;
                command.ExecuteNonQuery();

               
            }
        }
        public void ImportTmpCadzjToBasemap(string cadLayerName,string fileName = "", bool isClear = true)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = "";
                if (isClear)
                {
                    command.CommandText = string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? "delete from DXTQTZJ" : string.Format("delete from DXT{0}ZJ", cadLayerName);
                    command.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(cadLayerName) && !string.IsNullOrEmpty(cadLayerName))
                    sql = string.Format(
                        "INSERT INTO DXT{0}ZJ ([geometry],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[WBNR] AS [WBNR], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], " + "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadzjView] AS [a]  " + "WHERE [a].[Tc] = '{0}'", cadLayerName);
                else
                    sql = string.Format(
                        "INSERT INTO DXTQTZJ ([geometry],[WBNR],[TC],[CASSDM],[FH],[FHDX],[XZJD],[YSDM]) " +
                        "SELECT[a].[geometry] AS [geometry], [a].[WBNR] AS [WBNR], [a].[Tc] AS [Tc]," +
                        "[a].[Cassdm] AS [Cassdm], " + "[a].[Fh] AS [Fh], [a].[FHDX] AS [FHDX], [a].[Xzjd] AS [Xzjd]," +
                        "[a].[YSDM] AS [YSDM]  " + "FROM [TmpCadzjView] AS [a]");

                if (!string.IsNullOrEmpty(fileName))
                {
                    sql += string.IsNullOrWhiteSpace(cadLayerName) || string.IsNullOrEmpty(cadLayerName) ? string.Format(" Where  [a].[FileName]='{0}'", fileName) : string.Format("  AND [a].[FileName]='{0}'", fileName);
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();

                sql = cadLayerName != ""
                          ? string.Format(
                              "delete from TmpCadzj where Handle in (select Handle from TmpCadzjView where Tc = '{0}')",
                              cadLayerName)
                          : "delete from TmpCadzj";
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
        private TmpCadxdata ReadXData(TmpCadxdata cadxdata, XDataDictionary datas2, string codePage)
        {
            int count = 0;
            List<string> attrs = new List<string>();
            List<XData> datas = datas2.Values.ToList();
            for (int j = 0; j < datas2.Values.Count; j++)
            {
                List<XDataRecord> records = datas[j].XDataRecord;
                for (int k = 0; k < records.Count; k++)
                {
                    string pValue = records[k].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(pValue)) attrs.Add(pValue);
                }
            }
            cadxdata.Cassdm = attrs.Count > 0 ? attrs[0] : "";
            cadxdata.Fsxx1 = attrs.Count > 1 ? StringHelper.StringToUtf8(attrs[1], codePage) : "";
            cadxdata.Fsxx2 = attrs.Count > 2 ? StringHelper.StringToUtf8(attrs[2], codePage) : "";
            return cadxdata;
        }
    }
}