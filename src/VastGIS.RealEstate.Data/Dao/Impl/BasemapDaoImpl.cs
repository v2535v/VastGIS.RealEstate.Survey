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

                        command.CommandText = CREATE_BASEMAPX.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}X','geometry',{0},'LINESTRING','XY',0);",
                                srid, tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_BASEMAPM.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}M','geometry',{0},'POLYGON','XY',0);", srid, tbName);
                        command.ExecuteNonQuery();

                        command.CommandText = CREATE_BASEMAPZJ.Replace("_LAYERNAME_", layer);
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('{1}ZJ','geometry',{0},'POINT','XY',0);", srid, tbName);
                        command.ExecuteNonQuery();

                        objectclasses = new VgObjectclasses()
                                                            {
                                                                Mc = tbName,
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
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 1,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 4,
                                                Filter = SELECT_BASEMAPD.Replace("_LAYERNAME_", layer) //string.Format("Select * from {0}D Where Flags<3",tbName))
                    };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "X",
                                                Zwmc = chlayer + "线",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 2,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 2,
                                                Filter = SELECT_BASEMAPX.Replace("_LAYERNAME_", layer) //string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "M",
                                                Zwmc = chlayer + "面",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 3,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx =1,
                                                Filter = SELECT_BASEMAPM.Replace("_LAYERNAME_", layer) //string.Format("Select * from {0}D Where Flags<3",tbName))
                        };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "ZJ",
                                                Zwmc = chlayer + "注记",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 1,
                                                Visible = true,
                                                Editable = true,
                                                Identify = true,
                                                Queryable = true,
                                                Snapable = true,
                                                Xssx = 3,
                                                Filter = SELECT_BASEMAPZJ.Replace("_LAYERNAME_", layer) //string.Format("Select * from {0}D Where Flags<3",tbName))
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



