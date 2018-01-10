using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using Newtonsoft.Json;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Service;
using VastGIS.RealEstate.Data.Settings;

namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class BasemapDaoImpl
    {
        private string CREATE_VIEW_BASEMAPD = "CREATE VIEW DXTBASEMAPDVIEW AS select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPD Where [FLAGS] < 3;";

        private string CREATE_INSERT_TRIGGER_BASEMAPD = "CREATE TRIGGER [vw_ins_DXTBASEMAPDVIEW] INSTEAD OF INSERT ON [DXTBASEMAPDVIEW] BEGIN  INSERT OR REPLACE INTO [DXTBASEMAPD] ([Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[geometry]); END";

        private string CREATE_UPDATE_TRIGGER_BASEMAPD = "CREATE TRIGGER [vw_upd_DXTBASEMAPDVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [XZJD], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry] ON [DXTBASEMAPDVIEW] BEGIN  Update [DXTBASEMAPD] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";

        private string CREATE_DELETE_TRIGGER_BASEMAPD = "CREATE TRIGGER vw_del_DXTBASEMAPDVIEW INSTEAD OF DELETE ON DXTBASEMAPDVIEW BEGIN DELETE FROM DXTBASEMAPD WHERE ROWID=OLD.ROWID;END";

        private string GEOMETRY_REGISTER_BASEMAPDVIEW = "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtBASEMAPdview','geometry','rowid','dxtBASEMAPd','geometry',0)";

        private string SELECT_DXTBASEMAPD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPD Where [FLAGS] < 3";

        private string CREATE_VIEW_BASEMAPM = "CREATE VIEW DXTBASEMAPMVIEW AS select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPM Where [FLAGS] < 3;";

        private string CREATE_INSERT_TRIGGER_BASEMAPM = "CREATE TRIGGER [vw_ins_DXTBASEMAPMVIEW] INSTEAD OF INSERT ON [DXTBASEMAPMVIEW] BEGIN  INSERT OR REPLACE INTO [DXTBASEMAPM] ([Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[geometry]); END";

        private string CREATE_UPDATE_TRIGGER_BASEMAPM = "CREATE TRIGGER [vw_upd_DXTBASEMAPMVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry] ON [DXTBASEMAPMVIEW] BEGIN  Update [DXTBASEMAPM] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";

        private string CREATE_DELETE_TRIGGER_BASEMAPM = "CREATE TRIGGER vw_del_DXTBASEMAPMVIEW INSTEAD OF DELETE ON DXTBASEMAPMVIEW BEGIN DELETE FROM DXTBASEMAPM WHERE ROWID=OLD.ROWID;END";

        private string GEOMETRY_REGISTER_BASEMAPMVIEW = "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtBASEMAPmview','geometry','rowid','dxtBASEMAPm','geometry',0)";
        private string SELECT_DXTBASEMAPM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPM Where [FLAGS] < 3";

        private string CREATE_VIEW_BASEMAPX = "CREATE VIEW DXTBASEMAPXVIEW AS select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPX Where [FLAGS] < 3;";

        private string CREATE_INSERT_TRIGGER_BASEMAPX = "CREATE TRIGGER [vw_ins_DXTBASEMAPXVIEW] INSTEAD OF INSERT ON [DXTBASEMAPXVIEW] BEGIN  INSERT OR REPLACE INTO [DXTBASEMAPX] ([Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry]) VALUES ( NEW.[Id], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[FSXX1], NEW.[FSXX2], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[geometry]); END";

        private string CREATE_UPDATE_TRIGGER_BASEMAPX = "CREATE TRIGGER [vw_upd_DXTBASEMAPXVIEW] INSTEAD OF UPDATE OF [Id], [TC], [CASSDM], [FH], [FHDX], [FSXX1], [FSXX2], [YSDM], [DatabaseId], [FLAGS], [geometry] ON [DXTBASEMAPXVIEW] BEGIN  Update [DXTBASEMAPX] SET [Id]=NEW.[Id], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [FSXX1]=NEW.[FSXX1], [FSXX2]=NEW.[FSXX2], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";

        private string CREATE_DELETE_TRIGGER_BASEMAPX = "CREATE TRIGGER vw_del_DXTBASEMAPXVIEW INSTEAD OF DELETE ON DXTBASEMAPXVIEW BEGIN DELETE FROM DXTBASEMAPX WHERE ROWID=OLD.ROWID;END";

        private string GEOMETRY_REGISTER_BASEMAPXVIEW = "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtBASEMAPxview','geometry','rowid','dxtBASEMAPx','geometry',0)";
        private string SELECT_DXTBASEMAPX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPX Where [FLAGS] < 3";

        private string CREATE_VIEW_BASEMAPZJ = "CREATE VIEW DXTBASEMAPZJVIEW AS select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPZJ Where [FLAGS] < 3;";

        private string CREATE_INSERT_TRIGGER_BASEMAPZJ = "CREATE TRIGGER [vw_ins_DXTBASEMAPZJVIEW] INSTEAD OF INSERT ON [DXTBASEMAPZJVIEW] BEGIN  INSERT OR REPLACE INTO [DXTBASEMAPZJ] ([Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [geometry]) VALUES ( NEW.[Id], NEW.[WBNR], NEW.[TC], NEW.[CASSDM], NEW.[FH], NEW.[FHDX], NEW.[XZJD], NEW.[YSDM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[geometry]); END";

        private string CREATE_UPDATE_TRIGGER_BASEMAPZJ = "CREATE TRIGGER [vw_upd_DXTBASEMAPZJVIEW] INSTEAD OF UPDATE OF [Id], [WBNR], [TC], [CASSDM], [FH], [FHDX], [XZJD], [YSDM], [DatabaseId], [FLAGS], [geometry] ON [DXTBASEMAPZJVIEW] BEGIN  Update [DXTBASEMAPZJ] SET [Id]=NEW.[Id], [WBNR]=NEW.[WBNR], [TC]=NEW.[TC], [CASSDM]=NEW.[CASSDM], [FH]=NEW.[FH], [FHDX]=NEW.[FHDX], [XZJD]=NEW.[XZJD], [YSDM]=NEW.[YSDM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID;END";

        private string CREATE_DELETE_TRIGGER_BASEMAPZJ = "CREATE TRIGGER vw_del_DXTBASEMAPZJVIEW INSTEAD OF DELETE ON DXTBASEMAPZJVIEW BEGIN DELETE FROM DXTBASEMAPZJ WHERE ROWID=OLD.ROWID;END";

        private string GEOMETRY_REGISTER_BASEMAPZJVIEW = "insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('dxtBASEMAPzjview','geometry','rowid','dxtBASEMAPzj','geometry',0)";
        private string SELECT_DXTBASEMAPZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTBASEMAPZJ Where [FLAGS] < 3";



        string SELECT_BASEMAPD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from [DXT_LAYERNAME_D] Where [FLAGS] < 3";

        string SELECT_BASEMAPM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from [DXT_LAYERNAME_M] Where [FLAGS] < 3";

        string SELECT_BASEMAPX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from [DXT_LAYERNAME_X] Where [FLAGS] < 3";

        string SELECT_BASEMAPZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from [DXT_LAYERNAME_ZJ] Where [FLAGS] < 3";
            
        string CREATE_BASEMAPD =
            "CREATE TABLE[DXT_LAYERNAME_D] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] NCHAR(100),[CASSDM] CHAR(20),[FH] NCHAR(30),[FHDX] FLOAT,[XZJD] FLOAT,[FSXX1] NCHAR(100),[FSXX2] NCHAR(100),[YSDM] CHAR(10),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);";

        string CREATE_BASEMAPM = "CREATE TABLE[DXT_LAYERNAME_M] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] NCHAR(100),[CASSDM] CHAR(20),[FSXX1] NCHAR(100),[FSXX2] NCHAR(100),[YSDM] CHAR(10),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);";

        string CREATE_BASEMAPX = "CREATE TABLE[DXT_LAYERNAME_X] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] NCHAR(100),[CASSDM] CHAR(20),[FH] NCHAR(30),[FHDX] FLOAT,[FSXX1] NCHAR(100),[FSXX2] NCHAR(100),[YSDM] CHAR(10),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);";

        string CREATE_BASEMAPZJ =
            "CREATE TABLE[DXT_LAYERNAME_ZJ] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [WBNR] NCHAR(200),[TC] NCHAR(100),[CASSDM] CHAR(20),[FH] NCHAR(30),[FHDX] FLOAT,[XZJD] FLOAT,[YSDM] CHAR(10),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);";

        readonly string[] CREATE_BASEMAP_LAYERS = new string[] { "KZD", "JMD", "DLSS", "DLDW", "SXSS", "DMTZ", "ZJ", "QT" };
        readonly string[] CREATE_BASEMAP_LAYERS_CH = new string[] { "控制点", "居民地", "道路设施", "独立地物", "水系设施", "地貌土质", "注记", "其他图层" };
        public bool InitTables()
        {
           
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    VgObjectclasses objectclasses;
                    //VgObjectclasses objectclasses = new VgObjectclasses()
                    //                                    {
                    //                                        Mc = "DXT",
                    //                                        Zwmc = "底图数据",
                    //                                        Dxlx = 0,
                    //                                        Xssx= 1
                    //                                    };
                    //objectclasses.Save(connection, GetSRID());
                    int j = 0;
                    for (int i= CREATE_BASEMAP_LAYERS.Length-1; i>=0;i--)
                    {
                        j++;
                        string layer = CREATE_BASEMAP_LAYERS[i];
                        string chlayer = CREATE_BASEMAP_LAYERS_CH[i];
                        string tbName = "DXT" + layer;
                        command.CommandText = CREATE_BASEMAPD.Replace("_LAYERNAME_",layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}D','geometry',{0},'POINT','XY',0);", srid,tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_VIEW_BASEMAPD.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_INSERT_TRIGGER_BASEMAPD.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_UPDATE_TRIGGER_BASEMAPD.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_DELETE_TRIGGER_BASEMAPD.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = GEOMETRY_REGISTER_BASEMAPDVIEW.Replace("BASEMAP", layer.ToLower());
                        command.ExecuteNonQuery();
                        
                        command.CommandText = CREATE_BASEMAPX.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}X','geometry',{0},'LINESTRING','XY',0);",
                                srid, tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_VIEW_BASEMAPX.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_INSERT_TRIGGER_BASEMAPX.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_UPDATE_TRIGGER_BASEMAPX.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_DELETE_TRIGGER_BASEMAPX.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = GEOMETRY_REGISTER_BASEMAPXVIEW.Replace("BASEMAP", layer.ToLower());
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_BASEMAPM.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}M','geometry',{0},'POLYGON','XY',0);", srid, tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_VIEW_BASEMAPM.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_INSERT_TRIGGER_BASEMAPM.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_UPDATE_TRIGGER_BASEMAPM.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_DELETE_TRIGGER_BASEMAPM.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = GEOMETRY_REGISTER_BASEMAPMVIEW.Replace("BASEMAP", layer.ToLower());
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_BASEMAPZJ.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}ZJ','geometry',{0},'POINT','XY',0);", srid, tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_VIEW_BASEMAPZJ.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_INSERT_TRIGGER_BASEMAPZJ.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_UPDATE_TRIGGER_BASEMAPZJ.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = CREATE_DELETE_TRIGGER_BASEMAPZJ.Replace("BASEMAP", layer);
                        command.ExecuteNonQuery();
                        command.CommandText = GEOMETRY_REGISTER_BASEMAPZJVIEW.Replace("BASEMAP", layer.ToLower());
                        command.ExecuteNonQuery();

                        //command.CommandText = string.Format("CREATE VIEW DXT{0}DVIEW AS {1}", layer,
                        //    SELECT_BASEMAPD.Replace("_LAYER_NAME_", layer));
                        //command.ExecuteNonQuery();
                        //command.CommandText = string.Format("CREATE VIEW DXT{0}XVIEW AS {1}", layer,
                        //    SELECT_BASEMAPX.Replace("_LAYER_NAME_", layer));
                        //command.ExecuteNonQuery();
                        //command.CommandText = string.Format("CREATE VIEW DXT{0}MVIEW AS {1}", layer,
                        //    SELECT_BASEMAPM.Replace("_LAYER_NAME_", layer));
                        //command.CommandText = string.Format("CREATE VIEW DXT{0}ZJVIEW AS {1}", layer,
                        //    SELECT_BASEMAPZJ.Replace("_LAYER_NAME_", layer));
                        //command.ExecuteNonQuery();

                        objectclasses = new VgObjectclasses()
                                                            {
                                                                Mc = chlayer,
                                                                Zwmc = chlayer,
                                                                Dxlx = 0,
                                                                Visible = true,
                                                                Editable = true,
                                                                Identify = true,
                                                                Queryable = true,
                                                                Snapable = true,
                                                                Xssx = j
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName+"D",
                                                Zwmc = chlayer+"点",
                                                Fbmc = chlayer,
                                                Dxlx = 1,
                                                Txlx = 1,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 4,
                                                Filter = tbName + "DVIEW" //string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "X",
                                                Zwmc = chlayer + "线",
                                                Fbmc = chlayer,
                                                Dxlx = 1,
                                                Txlx = 2,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 2,
                                                Filter = tbName + "XVIEW"//string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "M",
                                                Zwmc = chlayer + "面",
                                                Fbmc = chlayer,
                                                Dxlx = 1,
                                                Txlx = 3,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx =1,
                                                Filter = tbName + "MVIEW" //string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "ZJ",
                                                Zwmc = chlayer + "注记",
                                                Fbmc = chlayer,
                                                Dxlx = 1,
                                                Txlx = 1,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 3,
                                                Filter = tbName + "ZJVIEW" //string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                    }
                    
                }
                trans.Commit();
            }
            return true;
        }

        //对图层内的多边形端点重新排序
        public bool ReorderAllPolygon(string tableName)
        {
            string sql = string.Format("SELECT ID, AsText(geometry) as Wkt,DatabaseID,Flags,'{0}' As TableName,YSDM  from {0}", tableName);
            IList<SimpleDatabaseFeature> features = connection.Query<SimpleDatabaseFeature>(sql).ToList();
            int srid = GetSRID();
            using (SQLiteTransaction trans=connection.BeginTransaction())
            {
                foreach (SimpleDatabaseFeature feature in features)
                {
                    IGeometry geometry = feature.Geometry.Clone();
                    if (geometry.PartIsClockWise(0) == false)
                    {
                        geometry.PartReserveOrder(0);
                    }
                    feature.Geometry = SpatialHelper.ReorderPolygonVertex(geometry);
                    
                    feature.Save(connection, srid);
                }
                trans.Commit();
            }
            return true;
        }

        public bool ReorderAllPolygon()
        {
            ReorderAllPolygon("DXTJMDM");
            return true;
        }

        public bool AssignTextToAttribute()
        {
            SystemDao service=new SystemDaoImpl();
            VgSettings setting = service.GetVgSettings(SettingKeyHelper.DiXingTuWenZiShiBie);
            List<TextAssignConfig> configs = JsonConvert.DeserializeObject<List<TextAssignConfig>>(setting.Csz);

            foreach (TextAssignConfig config in configs)
            {
                Console.WriteLine("{0}", config.Name);
                SpatialHelper.AssignTextToPolygon(DbConnection.GetConnection(), config);
            }
            return true;
        }
    }
}



