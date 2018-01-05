using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class BasemapDaoImpl
    {
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
                    VgObjectclasses objectclasses = new VgObjectclasses()
                                                        {
                                                            Mc = "DXT",
                                                            Zwmc = "底图数据",
                                                            Dxlx = 0
                                                        };
                    objectclasses.Save(connection, GetSRID());

                    for (int i=0;i<CREATE_BASEMAP_LAYERS.Length;i++)
                    {
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
                                                                Fbmc = "DXT",
                                                                Dxlx = 0
                                                            };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName+"D",
                                                Zwmc = chlayer+"点",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 1
                                            };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "X",
                                                Zwmc = chlayer + "线",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 2
                                            };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "M",
                                                Zwmc = chlayer + "面",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 3
                                            };
                        objectclasses.Save(connection, srid);
                        objectclasses = new VgObjectclasses()
                                            {
                                                Mc = tbName + "ZJ",
                                                Zwmc = chlayer + "注记",
                                                Fbmc = tbName,
                                                Dxlx = 1,
                                                Txlx = 1
                                            };
                        objectclasses.Save(connection, srid);
                    }
                    
                }
                trans.Commit();
            }
            return true;
        }

    }
}



