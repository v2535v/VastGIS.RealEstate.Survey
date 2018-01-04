using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class ZdDaoImpl
    {
        private string CREATE_XZQ =
                "CREATE TABLE [XZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10), [XZQDM] CHAR(12), [XZQMC] NCHAR(100), [XZQMJ] FLOAT,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;
        private string CREATE_XZQJX =
                "CREATE TABLE [XZQJX] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10), [JXLX] CHAR(6), [JXXZ] CHAR(6), [JXSM] NVARCHAR(500),[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_DJQ =
                "CREATE TABLE [DJQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10), [DJQDM] CHAR(9), [DJQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME, [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID NOT NULL, [DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_DJZQ =
                "CREATE TABLE [DJZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10), [DJZQDM] CHAR(12), [DJZQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME, [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID NOT NULL, [DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_ZDJBXX =
                "CREATE TABLE [ZDJBXX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [YSDM] CHAR(10), [ZDDM] CHAR(19), [BDCDYH] CHAR(28), [ZDTZM] CHAR(2), [ZL] NCHAR(200), [ZDMJ] FLOAT, [MJDW] CHAR(2), [YT] CHAR(4), [DJ] CHAR(2), [JG] FLOAT, [QLLX] CHAR(2), [QLXZ] CHAR(4), [QLSDFS] CHAR(2), [RJL] FLOAT, [JZMD] FLOAT, [JZXG] FLOAT, [ZDSZD] NCHAR(200), [ZDSZN] NCHAR(200), [ZDSZX] NCHAR(200), [ZDSZB] NCHAR(200), [ZDT] BLOB, [TFH] CHAR(50), [DJH] CHAR(20), [DAH] CHAR, [BZ] CHAR, [ZT] CHAR(2), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME, [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID NOT NULL,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_ZDBHQK =
                "CREATE TABLE [ZDBHQK] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDDM] CHAR(19), [BHYY] NCHAR, [BHNR] NCHAR, [DJSJ] DATETIME, [DBR] NCHAR(50), [FJ] NVARCHAR,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_JZX =
                "CREATE TABLE [JZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10), [JZXCD] FLOAT, [JZXLB] CHAR(2), [JZXWZ] CHAR(1), [JXXZ] CHAR(1), [QSJXXYSBH] CHAR(30), [QSJXXYS] BLOB, [QSZYYYSBH] CHAR(30), [QSZYYYS] BLOB, [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME, [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID NOT NULL, [QSJZDBH] CHAR(29),[JZJZDBH] CHAR(29),[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_ZDTOJZD =
                "CREATE TABLE [ZDTOJZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] GUID, [JZD_WYDM] GUID, [SXH]);"
            ;

        private string CREATE_ZDTOJZX =
                "CREATE TABLE [ZDTOJZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] GUID, [JZX_WYDM] GUID, [SXH]);"
            ;

        private string CREATE_JZD =
                "CREATE TABLE [JZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10), [JZDH] CHAR(10), [SXH] INTEGER, [JBLX] CHAR(2), [JZDLX] CHAR(2), [XZBZ] FLOAT, [YZBZ] FLOAT, [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME, [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID NOT NULL,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;

        private string CREATE_ZDJBXXZJ =
                "CREATE TABLE [ZDJBXXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSDM]CHAR(29), [YSDM] CHAR(10), [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;
        private string CREATE_JZDZJ =
                "CREATE TABLE [JZDZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSDM]CHAR(29), [YSDM] CHAR(10), [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;
        private string CREATE_JZXZJ =
                "CREATE TABLE [JZXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSDM]CHAR(29), [YSDM] CHAR(10), [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER,[FLAGS] SMALLINT);"
            ;
        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    command.CommandText = CREATE_XZQ;
                        command.ExecuteNonQuery();
                        command.CommandText =
                            string.Format("SELECT AddGeometryColumn('XZQ','geometry',{0},'POLYGON','XY',0);", srid);
                        command.ExecuteNonQuery();

                    command.CommandText = CREATE_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('XZQJX','geometry',{0},'LINESTRING','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DJQ','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DJZQ','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('ZDJBXX','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZD','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZX','geometry',{0},'LINESTRING','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('ZDJBXXZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZDZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZXZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDBHQK;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDTOJZD;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDTOJZX;
                    command.ExecuteNonQuery();

                    VgObjectclasses objectclasses=new VgObjectclasses()
                                                      {
                                                          Mc="DJSJ",
                                                          Zwmc = "地籍数据",
                                                          Dxlx = 0
                                                      };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "DJQ",
                                            Zwmc = "地籍区",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "DJZQ",
                                            Zwmc = "地籍子区",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "ZDJBXX",
                                            Zwmc = "宗地",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "ZDJBXXZJ",
                                            Zwmc = "宗地注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZX",
                                            Zwmc = "界址线",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx =2
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZXZJ",
                                            Zwmc = "界址线注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZD",
                                            Zwmc = "界址点",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 2
                                        };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZDZJ",
                                            Zwmc = "界址点注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1
                                        };
                    objectclasses.Save(connection, GetSRID());

                }

                
                trans.Commit();
            }
            return true;
        }
        
    }
}



