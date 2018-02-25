using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class ZdDaoImpl
    {
        #region 表生成SQL
      
        private string CREATE_XZQ =
                "CREATE TABLE [XZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10) DEFAULT '1001010000', [XZQDM] CHAR(12), [XZQMC] NCHAR(100), [XZQMJ] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;
        private string CREATE_XZQJX =
                "CREATE TABLE [XZQJX] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)  DEFAULT '1001020000', [JXLX] CHAR(6), [JXXZ] CHAR(6), [JXSM] NVARCHAR(500),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_DJQ =
                "CREATE TABLE [DJQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)  DEFAULT '1002000000', [DJQDM] CHAR(9), [DJQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] NVARCHAR, [DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_DJZQ =
                "CREATE TABLE [DJZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)   DEFAULT '1003000000', [DJZQDM] CHAR(12), [DJZQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] NVARCHAR, [DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_ZDJBXX =
                "CREATE TABLE [ZDJBXX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [YSDM] CHAR(10) DEFAULT '6001010000', [ZDDM] CHAR(19), [BDCDYH] CHAR(28), [ZDTZM] CHAR(2), [ZL] NCHAR(200), [ZDMJ] FLOAT, [MJDW] CHAR(2), [YT] CHAR(4), [DJ] CHAR(2), [JG] FLOAT, [QLLX] CHAR(2), [QLXZ] CHAR(4), [QLSDFS] CHAR(2), [RJL] FLOAT, [JZMD] FLOAT, [JZXG] FLOAT, [ZDSZD] NCHAR(200), [ZDSZN] NCHAR(200), [ZDSZX] NCHAR(200), [ZDSZB] NCHAR(200), [ZDT] BLOB, [TFH] CHAR(50), [DJH] CHAR(20), [DAH] CHAR, [BZ] CHAR, [ZT] CHAR(2), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_ZDBHQK =
                "CREATE TABLE [ZDBHQK] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDDM] CHAR(19), [BHYY] NCHAR, [BHNR] NCHAR, [DJSJ] DATETIME, [DBR] NCHAR(50), [FJ] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_JZX =
                "CREATE TABLE [JZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10)  DEFAULT '6001060000', [JZXGZBH] CHAR(29) CONSTRAINT[cn_jzx_gzbh] UNIQUE ON CONFLICT ROLLBACK,[JZXCD] FLOAT,"+
            " [JZXLB] CHAR(2), [JZXWZ] CHAR(1), [JXXZ] CHAR(1), [QSJXXYSBH] CHAR(30), [QSJXXYS] BLOB, [QSZYYYSBH] CHAR(30), [QSZYYYS] BLOB, [WX_DCY] NCHAR(30), "+
            "[WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), "+
            "[WX_ZJSJ] DATETIME, [WX_WYDM] NVARCHAR, [QSJZDBH] CHAR(29),[JZJZDBH] CHAR(29),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);CREATE UNIQUE INDEX [ix_jzx_gzbh] ON[JZX] ([JZXGZBH]);"
            ;

        private string CREATE_ZDTOJZD =
                "CREATE TABLE [ZDTOJZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] NVARCHAR, [JZD_WYDM] NVARCHAR, [SXH] INTEGER DEFAULT 0);"
            ;

        private string CREATE_ZDTOJZX =
                "CREATE TABLE [ZDTOJZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] NVARCHAR, [JZX_WYDM] NVARCHAR, [SXH] INTEGER DEFAULT 0);"
            ;

        private string CREATE_JZD =
                "CREATE TABLE [JZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10) DEFAULT '6001070000', [JZDH] CHAR(10),[JZDGZBH] CHAR(29) CONSTRAINT[cn_jzd_gzbh] UNIQUE ON CONFLICT ROLLBACK,"+
            " [SXH] INTEGER, [JBLX] CHAR(2), [JZDLX] CHAR(2), [XZBZ] FLOAT, [YZBZ] FLOAT, [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), "+
            "[WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);" +
            "CREATE UNIQUE INDEX [ix_jzd_gzbh] ON[JZD] ([JZDGZBH]);";

        private string CREATE_ZDJBXXZJ =
                "CREATE TABLE [ZDJBXXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSDM]CHAR(29), [YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;
        private string CREATE_JZDZJ =
                "CREATE TABLE [JZDZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSBH]CHAR(29) CONSTRAINT [fk_jzd_gzbh] REFERENCES [JZD]([JZDGZBH]), "+
            "[YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;
        private string CREATE_JZXZJ =
                "CREATE TABLE [JZXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSBH]CHAR(29) CONSTRAINT [fk_jzx_gzbh] REFERENCES [JZX]([JZXGZBH]), [YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME);"
            ;

        private string CREATE_R = "CREATE TABLE [R]( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [YSDM] [CHAR](10) Default '6003000000',	 [QLRMC] [nvarchar](200),	 [QLRPY] [nvarchar](200), [PYSX] [nvarchar](20),	 [ZJZL] [nvarchar](2), [ZJH] [nvarchar](50) , [FZJG] [nvarchar](200) , [SSHY] [nvarchar](6) , [GJ] [nvarchar](6) , [HJSZSS] [nvarchar](6) , [XB] [nvarchar](2) , [DH] [nvarchar](50) , [DZ] [nvarchar](200) , [YB] [nvarchar](10) , [GZDW] [nvarchar](100) , [DZYJ] [nvarchar](50) ,	 [BZ] [nvarchar] ,  [WX_WYDM] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1,[XGR] VCHAR(10),[XGSJ] DATETIME )";

        private string CREATE_ZRZ =
                "CREATE TABLE [ZRZ]([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 	[YSDM] [nvarchar](10) DEFAULT '6001030110', 	[BDCDYH] [nvarchar](28), 	[ZDDM] [nvarchar](19), 	[ZRZH] [nvarchar](24), 	[XMMC] [nvarchar](100), 	[JZWMC] [nvarchar](100), 	[JGRQ] [datetime], 	[JZWGD] [float], 	[ZZDMJ] [float], 	[ZYDMJ] [float], 	[YCJZMJ] [float], 	[SCJZMJ] [float], 	[ZCS] [int], 	[DSCS] [int], 	[DXCS] [int], 	[DXSD] [float], 	[GHYT] [CHAR](2), 	[FWJG] [CHAR](2), 	[ZTS] [int], 	[JZWJBYT] [nvarchar](200), 	[DAH] [nvarchar], 	[BZ] [nvarchar], 	[ZT] [CHAR](2), 	[WX_DCY] [nvarchar](30), 	[WX_DCSJ] [datetime], 	[WX_CLY] [nvarchar](30), 	[WX_CLSJ] [datetime], 	[WX_ZTY] [nvarchar](30), 	[WX_ZTSJ] [datetime], 	[WX_ZJY] [nvarchar](30), 	[WX_ZJSJ] [datetime],	 	[WX_WYDM] NVARCHAR,   [DatabaseId] INTEGER DEFAULT 0,   [FLAGS] SMALLINT DEFAULT 1,   [XGR] NCHAR(10),   [XGSJ] DATETIME )"
            ;
        #endregion

        #region 初始化
        public bool InitTables()
        {
            using (SQLiteTransaction trans = connection.BeginTransaction())
            {
                int srid = GetSRID();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = GetRegisterGroupSql("Zd");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_XZQ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                    string.Format("SELECT AddGeometryColumn('XZQ','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();
                    command.CommandText = CREATE_VIEW_XZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_XZQ;
                    command.ExecuteNonQuery();
                    command.CommandText =UPDATE_TRIGGER_XZQ;
                    command.ExecuteNonQuery();
                    command.CommandText =DELETE_TRIGGER_XZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_XZQVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd","XZQ","IDatabaseFeature");
                    command.ExecuteNonQuery();


                    command.CommandText = CREATE_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('XZQJX','geometry',{0},'LINESTRING','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_XZQJX;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_XZQJXVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "XZQJX", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DJQ','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_DJQ;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_DJQVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "DJQ", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DJZQ','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_DJZQ;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_DJZQVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "DJZQ", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('ZDJBXX','geometry',{0},'POLYGON','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_ZDJBXX;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_ZDJBXXVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "ZDJBXX", "ISurveyFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZD','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();
                    command.CommandText = CREATE_VIEW_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_JZD;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_JZDVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "JZD", "ISurveyFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZX','geometry',{0},'LINESTRING','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_JZX;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_JZXVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "JZX", "ISurveyFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('ZDJBXXZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_ZDJBXXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_ZDJBXXZJVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "ZDJBXXZJ", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZDZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_JZDZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = REGISTER_GEOMETRY_JZDZJVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "JZDZJ", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('JZXZJ','geometry',{0},'POINT','XY',0);", srid);
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_JZXZJ;
                    command.ExecuteNonQuery();
                    command.CommandText =  REGISTER_GEOMETRY_JZXZJVIEW;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "JZXZJ", "IDatabaseFeature");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDBHQK;
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_VIEW_ZDBHQK;
                    command.ExecuteNonQuery();
                    command.CommandText = INSERT_TRIGGER_ZDBHQK;
                    command.ExecuteNonQuery();
                    command.CommandText = UPDATE_TRIGGER_ZDBHQK;
                    command.ExecuteNonQuery();
                    command.CommandText = DELETE_TRIGGER_ZDBHQK;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "ZDBHQK","IDatabaseEntity");
                    command.ExecuteNonQuery();


                    command.CommandText = CREATE_ZDTOJZD;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "ZDTOJZD","IEntity");
                    command.ExecuteNonQuery();

                    command.CommandText = CREATE_ZDTOJZX;
                    command.ExecuteNonQuery();
                    command.CommandText = GetRegisterClassSql("Zd", "ZDTOJZX","IEntity");
                    command.ExecuteNonQuery();

                    VgObjectclass objectclasses=new VgObjectclass()
                                                      {
                                                          Mc= "地籍数据",
                                                          Zwmc = "地籍数据",
                                                          Dxlx = 0,
                                                          Xssx = 10,
                                                          Visible = true,
                                                          Editable = true,
                                                          Identify = true,
                                                          Queryable = true,
                                                          Snapable = true,


                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "DJQ",
                                            Zwmc = "地籍区",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 1,
                                            Filter = "DJQVIEW",
                                            Bjct = "frmDjq"
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "DJZQ",
                                            Zwmc = "地籍子区",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 2,
                                            Filter = "DJZQVIEW",
                                            Bjct = "frmDjzq"
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "ZDJBXX",
                                            Zwmc = "宗地",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 3,
                                            Filter ="ZDJBXXVIEW",
                                            Bjct = "frmZdjbxx",
                                            Bhfj = true
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "ZDJBXXZJ",
                                            Zwmc = "宗地注记",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =4,
                                            Filter = "ZDJBXXZJVIEW",
                                            Bjct = "frmZdzj"
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "JZX",
                                            Zwmc = "界址线",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx =2,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =5,
                                            Filter = "JZXVIEW",
                                            Bjct = "frmJzx",
                                            Bhfj = true
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "JZXZJ",
                                            Zwmc = "界址线注记",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 6,
                                            Filter = "JZXZJVIEW",
                                            Bjct = "frmJzxzj"
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "JZD",
                                            Zwmc = "界址点",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =7,
                                            Filter = "JZDVIEW",
                                            Bjct = "frmJzd",
                                            Bhfj = true
                    };
                    objectclasses.Save(this);
                    objectclasses = new VgObjectclass()
                                        {
                                            Mc = "JZDZJ",
                                            Zwmc = "界址点注记",
                                            Fbmc = "地籍数据",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =8,
                                            Filter = "JZDZJVIEW",
                                            Bjct = "frmJzdzj"
                    };
                    objectclasses.Save(this);
                }

                
                trans.Commit();
            }
            return true;
        }
#endregion



        /// <summary>
        /// 删除宗地及附属的界址点、界址线和注记信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeepDeleteZdjbxx(Jzd jzd)
        {
            
            return true;
        }

        public bool DeepDeleteJzd(Jzd jzd,bool deleteZj=true, bool deleteRelate=false)
        {
            //string gzbh = jzd.;
            //if (deleteZj)
            //{
            //    string deleteSql = "GLYSBH = '" + gzbh + "'";
            //    this.DeleteJzdzj(deleteSql);
            //}
            //this.DeleteJzd(jzd);
            //if (deleteRelate)
            //{
            //    string deleteSql = "[QSJZDBH]='" + gzbh + "' OR [JZJZDBH]='" + gzbh + "'";
            //    this.DeleteJzx(deleteSql);
            //}
            return true;
        }

        public string GetOverlayPolyAttribute(string targetTable, string valueField, DbGeometry geometry)
        {
            return GetOverlayPolyAttribute(targetTable, valueField, geometry.AsText());
        }

        public string GetOverlayPolyAttribute(string targetTable, string valueField, string wellKnownText)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                string sql = string.Format("select {0} from {1} where Within(GeomFromText('{2}'),geometry);",
                    valueField, targetTable, wellKnownText);
                command.CommandText = sql;
                object result = command.ExecuteScalar();
                if (result == null) return string.Empty;
                return result.ToString();
            }
        }


    }
}



