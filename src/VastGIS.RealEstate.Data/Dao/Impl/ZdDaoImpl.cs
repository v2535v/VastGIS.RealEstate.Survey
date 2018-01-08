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
                "CREATE TABLE [XZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10) DEFAULT '1001010000', [XZQDM] CHAR(12), [XZQMC] NCHAR(100), [XZQMJ] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;
        private string CREATE_XZQJX =
                "CREATE TABLE [XZQJX] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)  DEFAULT '1001020000', [JXLX] CHAR(6), [JXXZ] CHAR(6), [JXSM] NVARCHAR(500),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;

        private string CREATE_DJQ =
                "CREATE TABLE [DJQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)  DEFAULT '1002000000', [DJQDM] CHAR(9), [DJQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID, [DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;

        private string CREATE_DJZQ =
                "CREATE TABLE [DJZQ] ( [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,  [YSDM] CHAR(10)   DEFAULT '1003000000', [DJZQDM] CHAR(12), [DJZQMC] NCHAR(100), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID, [DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;

        private string CREATE_ZDJBXX =
                "CREATE TABLE [ZDJBXX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [YSDM] CHAR(10) DEFAULT '6001010000', [ZDDM] CHAR(19), [BDCDYH] CHAR(28), [ZDTZM] CHAR(2), [ZL] NCHAR(200), [ZDMJ] FLOAT, [MJDW] CHAR(2), [YT] CHAR(4), [DJ] CHAR(2), [JG] FLOAT, [QLLX] CHAR(2), [QLXZ] CHAR(4), [QLSDFS] CHAR(2), [RJL] FLOAT, [JZMD] FLOAT, [JZXG] FLOAT, [ZDSZD] NCHAR(200), [ZDSZN] NCHAR(200), [ZDSZX] NCHAR(200), [ZDSZB] NCHAR(200), [ZDT] BLOB, [TFH] CHAR(50), [DJH] CHAR(20), [DAH] CHAR, [BZ] CHAR, [ZT] CHAR(2), [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;

        private string CREATE_ZDBHQK =
                "CREATE TABLE [ZDBHQK] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDDM] CHAR(19), [BHYY] NCHAR, [BHNR] NCHAR, [DJSJ] DATETIME, [DBR] NCHAR(50), [FJ] NVARCHAR,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;

        private string CREATE_JZX =
                "CREATE TABLE [JZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10)  DEFAULT '6001060000', [JZXGZBH] CHAR(29) CONSTRAINT[cn_jzx_gzbh] UNIQUE ON CONFLICT ROLLBACK,[JZXCD] FLOAT,"+
            " [JZXLB] CHAR(2), [JZXWZ] CHAR(1), [JXXZ] CHAR(1), [QSJXXYSBH] CHAR(30), [QSJXXYS] BLOB, [QSZYYYSBH] CHAR(30), [QSZYYYS] BLOB, [WX_DCY] NCHAR(30), "+
            "[WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), [WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), "+
            "[WX_ZJSJ] DATETIME, [WX_WYDM] GUID, [QSJZDBH] CHAR(29),[JZJZDBH] CHAR(29),[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);CREATE UNIQUE INDEX [ix_jzx_gzbh] ON[JZX] ([JZXGZBH]);"
            ;

        private string CREATE_ZDTOJZD =
                "CREATE TABLE [ZDTOJZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] GUID, [JZD_WYDM] GUID, [SXH]);"
            ;

        private string CREATE_ZDTOJZX =
                "CREATE TABLE [ZDTOJZX] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZD_WYDM] GUID, [JZX_WYDM] GUID, [SXH]);"
            ;

        private string CREATE_JZD =
                "CREATE TABLE [JZD] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [ZDZHDM] CHAR, [YSDM] CHAR(10) DEFAULT '6001070000', [JZDH] CHAR(10),[JZDGZBH] CHAR(29) CONSTRAINT[cn_jzd_gzbh] UNIQUE ON CONFLICT ROLLBACK,"+
            " [SXH] INTEGER, [JBLX] CHAR(2), [JZDLX] CHAR(2), [XZBZ] FLOAT, [YZBZ] FLOAT, [WX_DCY] NCHAR(30), [WX_DCSJ] DATETIME default (datetime('now', 'localtime')), [WX_CLY] NCHAR(30), "+
            "[WX_CLSJ] DATETIME, [WX_ZTY] NCHAR(30), [WX_ZTSJ] DATETIME, [WX_ZJY] NCHAR(30), [WX_ZJSJ] DATETIME, [WX_WYDM] GUID,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"+
            "CREATE UNIQUE INDEX [ix_jzd_gzbh] ON[JZD] ([JZDGZBH]);";

        private string CREATE_ZDJBXXZJ =
                "CREATE TABLE [ZDJBXXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSDM]CHAR(29), [YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;
        private string CREATE_JZDZJ =
                "CREATE TABLE [JZDZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSBH]CHAR(29) CONSTRAINT [fk_jzd_gzbh] REFERENCES [JZD]([JZDGZBH]), "+
            "[YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
            ;
        private string CREATE_JZXZJ =
                "CREATE TABLE [JZXZJ] ( [Id] INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT, [GLYSBH]CHAR(29) CONSTRAINT [fk_jzx_gzbh] REFERENCES [JZX]([JZXGZBH]), [YSDM] CHAR(10) DEFAULT '6001080000', [ZJNR] NCHAR(200), [ZT] NCHAR(50), [YS] CHAR(20), [BS] INTEGER, [XZ] CHAR(1), [XHX] CHAR(1), [KD] FLOAT, [GD] FLOAT, [ZJDZXJXZB] FLOAT, [ZJDZXJYZB] FLOAT, [ZJFX] FLOAT,[DatabaseId] INTEGER DEFAULT 0,[FLAGS] SMALLINT DEFAULT 1);"
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
                                                          Dxlx = 0,
                                                          Xssx = 8
                                                          
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "DJQ",
                                            Zwmc = "地籍区",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 1,
                                            Filter = SELECT_DJQ
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "DJZQ",
                                            Zwmc = "地籍子区",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 2,
                                            Filter = SELECT_DJZQ
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "ZDJBXX",
                                            Zwmc = "宗地",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 3,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 3,
                                            Filter =SELECT_ZDJBXX
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "ZDJBXXZJ",
                                            Zwmc = "宗地注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =4,
                                            Filter =SELECT_ZDJBXXZJ
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZX",
                                            Zwmc = "界址线",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx =2,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =5,
                                            Filter = SELECT_JZX
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZXZJ",
                                            Zwmc = "界址线注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx = 6,
                                            Filter = SELECT_JZXZJ
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZD",
                                            Zwmc = "界址点",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 2,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =7,
                                            Filter = SELECT_JZD
                    };
                    objectclasses.Save(connection, GetSRID());
                    objectclasses = new VgObjectclasses()
                                        {
                                            Mc = "JZDZJ",
                                            Zwmc = "界址点注记",
                                            Fbmc = "DJSJ",
                                            Dxlx = 1,
                                            Txlx = 1,
                                            Visible = true,
                                            Editable = true,
                                            Identify = true,
                                            Queryable = true,
                                            Snapable = true,
                                            Xssx =8,
                                            Filter = SELECT_JZDZJ
                    };
                    objectclasses.Save(connection, GetSRID());

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
            string gzbh = jzd.Jzdgzbh;
            if (deleteZj)
            {
                string deleteSql = "GLYSBH = '" + gzbh + "'";
                this.DeleteJzdzj(deleteSql);
            }
            this.DeleteJzd(jzd);
            if (deleteRelate)
            {
                string deleteSql = "[QSJZDBH]='" + gzbh + "' OR [JZJZDBH]='" + gzbh + "'";
                this.DeleteJzx(deleteSql);
            }
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



