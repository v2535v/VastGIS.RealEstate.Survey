using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netDxf;
using netDxf.Blocks;
using netDxf.Collections;
using netDxf.Entities;
using OSGeo.GDAL;
using OSGeo.OGR;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Enums;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Service;
using VastGIS.Services.Views;
using VastGIS.Shared;

namespace VastGIS.RealEstate.Api.Concrete
{

    public class ReDatabase : IREDatabase//, IREDatabaseService
    {
        private const string DatabaseFilter = "未见不动产数据库(*.sqlite)|*.sqlite";
        private string _databaseName;
        private int _epsgCode;


        #region 构造函数

        public ReDatabase(string databaseName)
        {
            _databaseName = databaseName;
        }
        public ReDatabase(string databaseName,int epsgCode)
        {
            _databaseName = databaseName;
            _epsgCode = epsgCode;
        }



        #endregion

        #region 属性

        public string DatabaseName
        {
            get { return _databaseName; }
            set { _databaseName = value; }
        }

        public int EpsgCode
        {
            get { return _epsgCode; }
            set { _epsgCode = value; }
        }

        public bool IsEmpty
        {
            get { return _databaseName.Length == 0; }
        }


        #endregion

        #region 公共方法

        public List<IObjectClass> GetObjectClasses()
        {
            return GetClasses(true);
        }

        public List<IObjectClass> GetClasses(bool IsRecursion = true)
        {
            List<IObjectClass> _datasets = new List<IObjectClass>();


            string connectionString = SQLiteHelpers.ConnectionStringBuilder(_databaseName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command =
                    new SQLiteCommand(
                        "select MC,ZWMC,DXLX,XHZDMC,TXZDMC,TXLX,FBMC from vg_objectclasses Order by ParentName",
                        connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IObjectClass objectClass = new ObjectClass(reader);
                            objectClass.DatabaseName = _databaseName;
                            _datasets.Add(objectClass);
                        }
                    }
                }
            }
            if (IsRecursion == false)
                return _datasets;
            else
            {
                List<IObjectClass> list = _datasets.FindAll(c => c.ParentName == "");
                List<IObjectClass> newList = new List<IObjectClass>(list);
                foreach (IObjectClass objectClass in newList)
                {
                    List<IObjectClass> children = FindChildClasses(_datasets, objectClass.Name);
                    if (children != null && children.Count > 0)
                    {
                        objectClass.SubClasses = children;
                    }
                }
                return newList;
            }
        }

        public bool InitREDatabase(int epsgCode, ProjectLoadingView loadingForm, out string errorMsg)
        {
            errorMsg = "";
            if (string.IsNullOrEmpty(_databaseName))
            {
                errorMsg = "没有设置数据库!";
                return false;
            }
            _epsgCode = epsgCode;
            FileInfo info = new FileInfo(_databaseName);
            if (!info.Exists)
            {
                loadingForm.ShowProgress(60,"创建数据库");
                System.IO.FileInfo tmpFileInfo = SQLiteHelpers.GetTemplateDBInfo();
                tmpFileInfo.CopyTo(_databaseName);
            }
            using (SQLiteConnection connection =
                new SQLiteConnection(SQLiteHelpers.ConnectionStringBuilder(_databaseName)))
            {
                connection.Open();
                connection.EnableExtensions(true);
                connection.LoadExtension("mod_spatialite.dll");

                loadingForm.ShowProgress(70, "创建系统表");
                CreateRESystemTables(connection);
                //loadingForm.ShowProgress(70, "创建数据字典");
                //ImportDictionary(connection);
                loadingForm.ShowProgress(80, "创建地籍表");
                CreateREZDTables(connection);
                loadingForm.ShowProgress(86, "创建控制点底图表");
                CreateREBasemapTables(connection, "KZD");
                loadingForm.ShowProgress(90, "创建居民地底图表");
                CreateREBasemapTables(connection,"JMD");
                loadingForm.ShowProgress(92, "创建道路底图表");
                CreateREBasemapTables(connection, "DLSS");
                loadingForm.ShowProgress(93, "创建水系底图表");
                CreateREBasemapTables(connection, "SXSS");
                loadingForm.ShowProgress(94, "创建地貌底图表");
                CreateREBasemapTables(connection, "DMTZ");
                loadingForm.ShowProgress(95, "创建独立地物底图表");
                CreateREBasemapTables(connection, "DLDW");
                loadingForm.ShowProgress(96, "创建其他底图表");
                CreateREBasemapTables(connection, "QT");
                loadingForm.ShowProgress(97, "创建注记底图表");
                CreateREBasemapTables(connection, "ZJ",true,true,true,true);
                loadingForm.ShowProgress(90, "创建临时表");
                CreateRECADTempTables(connection);
            }
            return true;
        }

        public ICodeDomain GetDomain(string domainName)
        {
            string connectionString = SQLiteHelpers.ConnectionStringBuilder(_databaseName);
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command =
                    new SQLiteCommand(
                        "select ZDZ,ZDSM,SFQS from vg_dictionary where ZDMC='" + domainName + "' Order by PX,ZDZ",
                        connection))
                {
                    ICodeDomain codeDomain = new CodeDomain() {Name = domainName};
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ICodeDomainValue codeDomainValue =
                                new CodeDomainValue(reader.GetString(0), reader.GetString(1), reader.GetBoolean(2));
                            codeDomain.Values.Add(codeDomainValue);
                            if (codeDomainValue.IsDefault)
                            {
                                codeDomain.DefaultValue = codeDomainValue;
                            }
                        }
                    }
                    return codeDomain;
                }
            }
        }

        public bool CheckDatabase()
        {
            if (!string.IsNullOrEmpty(_databaseName))
            {
                DbConnection.SetDatabaseName(_databaseName);
            }
            return false;
        }

        #endregion

        #region 私有方法

        private List<IObjectClass> FindChildClasses(List<IObjectClass> objectClasses, string key)
        {
            List<IObjectClass> list = objectClasses.FindAll(c => c.ParentName == key);
            List<IObjectClass> tmpList = new List<IObjectClass>(list);
            foreach (IObjectClass objectClass in tmpList)
            {
                List<IObjectClass> tmpChildren = FindChildClasses(objectClasses, objectClass.Name);
                if (tmpChildren != null && tmpChildren.Count > 0)
                {
                    list.AddRange(tmpChildren);
                }
            }
            return list;
        }
        private void CreateRECADTempTables(SQLiteConnection connection)
        {
            string d =
                "CREATE TABLE [TmpCadd] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [EntityType] CHAR(100),[Handle] CHAR(20),  FileName CHAR(200));";
            string x =
                "CREATE TABLE [TmpCadx] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [EntityType] CHAR(100),[Handle] CHAR(20),  FileName Char(200));";
            string m =
                "CREATE TABLE [TmpCadm] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [EntityType] CHAR(100),[Handle] CHAR(20), FileName Char(200))";
            string zj =
                "CREATE TABLE[TmpCadzj] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [EntityType] CHAR(100),[Handle] CHAR(20), FileName Char(200))";

            string xdata = 
                "CREATE TABLE[TmpCadxdata] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,[Handle] CHAR(20)," +
                " [Tc] CHAR(100),[Wbnr] CHAR(200),[Cassdm] CHAR(20),[Fsxx1] CHAR(200),[Fsxx2] CHAR(200)" +
                ",[Xzjd] FLOAT,[Fh] CHAR(100),[Fhdx] Float,[Ysdm] CHAR(10), FileName Char(200))";

            string dView =
                "CREATE VIEW [TmpCaddView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2], [b].[Xzjd] AS [Xzjd], [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadd] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);";
            string xView = "CREATE VIEW [TmpCadxView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2],  [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadx] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);";
            string mView = "CREATE VIEW [TmpCadmView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2],  [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadm] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);";
            string zjView = "CREATE VIEW [TmpCadzjView] AS SELECT [a].[ROWID] AS [ROWID], [a].[Id] AS [Id], [a].[EntityType] AS [EntityType],     [a].[Handle] AS [Handle], [a].[geometry] AS [geometry],[a].[FileName] AS [FileName],     [b].[Tc] AS [Tc], [b].[Wbnr] AS [Wbnr],[b].[Cassdm] AS [Cassdm], [b].[Fsxx1] AS [Fsxx1],     [b].[Fsxx2] AS [Fsxx2], [b].[Xzjd] AS [Xzjd], [b].[Fh] AS [Fh],     [b].[Fhdx] AS [Fhdx],[b].[Ysdm] AS [Ysdm] FROM [TmpCadzj] AS [a] JOIN [TmpCadxdata] AS [b] USING ([Handle],[FileName]);";





            using (SQLiteCommand command = new SQLiteCommand(d, connection))
            {
               
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadd','geometry',{0},'POINT','XY',0);", 
                            _epsgCode);
                    command.ExecuteNonQuery();
              
                    command.CommandText = x;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadx','geometry',{0},'LINESTRING','XY',0);",
                             _epsgCode);
                    command.ExecuteNonQuery();
              
            
                    command.CommandText = m;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadm','geometry',{0},'POLYGON','XY',0);", 
                            _epsgCode);
                    command.ExecuteNonQuery();
               
             
                    command.CommandText = zj;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('TmpCadzj','geometry',{0},'POINT','XY',0);", 
                            _epsgCode);
                    command.ExecuteNonQuery();

                command.CommandText = xdata;
                command.ExecuteNonQuery();

                command.CommandText = dView;
                command.ExecuteNonQuery();

                command.CommandText = xView;
                command.ExecuteNonQuery();

                command.CommandText = mView;
                command.ExecuteNonQuery();

                command.CommandText = zjView;
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
        }
        private void CreateREBasemapTables(SQLiteConnection connection,string layerName,bool createPoint=true, bool createLine = true, bool createArea = true, bool createText = true)
        {
            string d = string.Format(
                "CREATE TABLE[DXT{0}D] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] CHAR(100),[CASSDM] CHAR(20),[FH] CHAR(30),[FHDX] FLOAT,[XZJD] FLOAT,[FSXX1] CHAR(100),[FSXX2] CHAR(100),[YSDM] CHAR(10));",layerName);

            string m = string.Format(
                "CREATE TABLE[DXT{0}M] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] CHAR(100),[CASSDM] CHAR(20),[FSXX1] CHAR(100),[FSXX2] CHAR(100),[YSDM] CHAR(10));",
                layerName);

            string x=string.Format("CREATE TABLE[DXT{0}X] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [TC] CHAR(100),[CASSDM] CHAR(20),[FH] CHAR(30),[FHDX] FLOAT,[FSXX1] CHAR(100),[FSXX2] CHAR(100),[YSDM] CHAR(10));",
                layerName);

            string zj = string.Format(
                "CREATE TABLE[DXT{0}ZJ] ([Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, [WBNR] CHAR(200),[TC] CHAR(100),[CASSDM] CHAR(20),[FH] CHAR(30),[FHDX] FLOAT,[XZJD] FLOAT,[YSDM] CHAR(10));",
                layerName);

            using (SQLiteCommand command = new SQLiteCommand(d, connection))
            {
                if (createPoint)
                {
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DXT{0}D','geometry',{1},'POINT','XY');", layerName,
                            _epsgCode);
                    command.ExecuteNonQuery();
                }
                if (createLine)
                {
                    command.CommandText = x;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DXT{0}X','geometry',{1},'LINESTRING','XY');",
                            layerName, _epsgCode);
                    command.ExecuteNonQuery();
                }
                if (createArea)
                {
                    command.CommandText = m;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DXT{0}M','geometry',{1},'POLYGON','XY');", layerName,
                            _epsgCode);
                    command.ExecuteNonQuery();
                }
                if (createText)
                {
                    command.CommandText = zj;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        string.Format("SELECT AddGeometryColumn('DXT{0}ZJ','geometry',{1},'POINT','XY');", layerName,
                            _epsgCode);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void CreateRESystemTables(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(SQLiteHelpers.VG_OBJECTCLASSES, connection))
            {
                cmd.ExecuteNonQuery();
                //cmd.CommandText = SQLiteHelpers.VG_DICTIONARYNAME;
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = SQLiteHelpers.VG_DICTIONARY;
                //cmd.ExecuteNonQuery();


            }
        }

        private void ImportDictionary(SQLiteConnection connection)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(SQLiteHelpers.VG_OBJECTCLASSES, connection))
            {
                string dataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "Templates\\Dictionary.sql");

                StreamReader reader = File.OpenText(dataFile);
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine().Trim();
                    if (string.IsNullOrEmpty(line)) continue;
                    cmd.CommandText = line;
                    cmd.ExecuteNonQuery();
                }
                reader.Close();
            }
        }

        private void CreateREZDTables(SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(SQLiteHelpers.C, connection))
            {
                command.ExecuteNonQuery();
                command.CommandText = SQLiteHelpers.QLR;
                command.ExecuteNonQuery();
                command.CommandText = SQLiteHelpers.FDCQXM;
                command.ExecuteNonQuery();
                command.CommandText = SQLiteHelpers.H;
                command.ExecuteNonQuery();
                command.CommandText = SQLiteHelpers.JSYDSYQ;
                command.ExecuteNonQuery();
                command.CommandText = SQLiteHelpers.TDSYQ;
                command.ExecuteNonQuery();
                //行政区
                command.CommandText = SQLiteHelpers.XZQ;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('XZQ','geometry'," + _epsgCode.ToString() +
                                      ",'POLYGON','XY');";
                command.ExecuteNonQuery();
                //行政区界线
                command.CommandText = SQLiteHelpers.XZQJX;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('XZQJX','geometry'," + _epsgCode.ToString() +
                                      ",'LINESTRING','XY');";
                command.ExecuteNonQuery();
                //地籍区
                command.CommandText = SQLiteHelpers.DJQ;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('DJQ','geometry'," + _epsgCode.ToString() +
                                      ",'POLYGON','XY');";
                command.ExecuteNonQuery();
                //地籍子区
                command.CommandText = SQLiteHelpers.DJZQ;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('DJZQ','geometry'," + _epsgCode.ToString() +
                                      ",'POLYGON','XY');";
                command.ExecuteNonQuery();
                //宗地
                command.CommandText = SQLiteHelpers.ZDJBXX;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('ZDJBXX','geometry'," + _epsgCode.ToString() +
                                      ",'POLYGON','XY');";
                command.ExecuteNonQuery();
                //宗地界址线
                command.CommandText = SQLiteHelpers.JZX;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('jzx','geometry'," + _epsgCode.ToString() +
                                      ",'LINESTRING','XY');";
                command.ExecuteNonQuery();
                //界址点
                command.CommandText = SQLiteHelpers.JZD;
                command.ExecuteNonQuery();
                command.CommandText = "SELECT AddGeometryColumn('jzd','geometry'," + _epsgCode.ToString() +
                                      ",'MULTIPOINT','XY');";
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region CAD

        public void ImportDxfDrawing(string dxfName, ProjectLoadingView loadingForm,string cadCodePage="CP936", CADInsertMethod insertMethod= CADInsertMethod.DeleteByFileName)
        {
            try
            {
                dxfName = StringHelper.StringToUtf8(dxfName, System.Text.Encoding.Default.BodyName);
                loadingForm.ShowProgress(0, "导入环境初始化...");
                DxfDocument doc = DxfDocument.Load(dxfName);
                string xodePage = "";
                if (string.IsNullOrEmpty(cadCodePage))
                {
                    int codenum = Convert.ToInt32(doc.DrawingVariables.DwgCodePage.Split('_')[1]);
                    xodePage = Encoding.GetEncoding(codenum).BodyName;

                }
                else
                {
                    xodePage = Encoding.GetEncoding(cadCodePage).BodyName; ;
                }
                

                //DbConnection.GetConnection().Open();
                MainService mainService = ServiceFactory.GetMainService();
                TmpCaddService caddService = ServiceFactory.GetTmpCaddService();
                TmpCadxService cadxService = ServiceFactory.GetTmpCadxService();
                TmpCadmService cadmService = ServiceFactory.GetTmpCadmService();
                TmpCadzjService cadzjService = ServiceFactory.GetTmpCadzjService();
                TmpCadxdataService cadxdataService = ServiceFactory.GetTmpCadxdataService();

                int srid = mainService.GetGeometryColumnSRID("tmpcadd", "geometry");
                loadingForm.ShowProgress(0, "清理原有数据");
                if (insertMethod != CADInsertMethod.JustInsert)
                {
                    mainService.ClearCADTemps(insertMethod, dxfName);
                }

                Ogr.RegisterAll();
                Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
                Gdal.SetConfigOption("DXF_ENCODING", cadCodePage);
                DataSource ds = Ogr.Open(dxfName, Convert.ToInt32(false));
                if (ds == null)
                {
                    MessageService.Current.Warn("DXF文件路径中可能包含非法字符，请检查!");
                    return;
                }

                loadingForm.ShowProgress(0, "导入图形数据...");
                for (int i = 0; i < ds.GetLayerCount(); i++)
                {
                    Layer pLayer = ds.GetLayerByIndex(i);
                    Feature feat = pLayer.GetNextFeature();
                    while (feat != null)
                    {
                        string handle = feat.GetFieldAsString(4);
                        string typeName = feat.GetFieldAsString(1).Trim().Replace("AcDbEntity:", "");
                        // string layerName = feat.GetFieldAsString("Layer");
                        // System.Diagnostics.Trace.TraceWarning("LayerName: "+layerName);
                        string geomtryStr = "";
                        Geometry geometry = feat.GetGeometryRef();
                        geometry.FlattenTo2D();
                        geometry.ExportToWkt(out geomtryStr);
                        
                        switch (typeName)
                        {
                            case "AcDbPolyline":
                            case "AcDbLine":
                                TmpCadx cadx = new TmpCadx(handle, geomtryStr, "POLYLINE", dxfName);
                                cadxService.Create(cadx);
                                //判断是否是单一的多边形，如果是，则插入多边形
                               
                                    int pntCounts = geometry.GetPointCount();
                                    if (pntCounts > 3)
                                    {
                                        double startx=geometry.GetX(0);
                                        double starty = geometry.GetY(0);
                                        double endx = geometry.GetX(pntCounts - 1);
                                        double endy = geometry.GetY(pntCounts - 1);
                                  
                                        if (Math.Abs(startx-endx) < 0.0001 &&
                                            Math.Abs(starty-endy) < 0.0001)
                                        {
                                            //说明为多边形
                                            Geometry polygeometry = Ogr.ForceToPolygon(geometry);
                                            polygeometry.ExportToWkt(out geomtryStr);
                                            TmpCadm cadm = new TmpCadm(handle, geomtryStr, "POLYGON", dxfName);
                                            cadmService.Create(cadm);
                                        }
                                    }
                                
                                break;
                            case "AcDbBlockReference":
                                //TmpCadd cadd=new TmpCadd(handle, geomtryStr, "POINT");
                                //caddService.Create(cadd);
                                //因为GDAL直接读取了块图形，因此，块在下面的方法和属性一起读取
                                break;
                            case "AcDbText:AcDbText":
                                TmpCadzj cadzj = new TmpCadzj(handle, geomtryStr, "TEXT", dxfName);
                                cadzjService.Create(cadzj);
                                break;
                            default:
                                MessageService.Current.Info(typeName);
                                System.Diagnostics.Trace.TraceInformation("CAD类型未处理 {0}", typeName);
                                break;
                        }

                        feat.Dispose();
                        feat = pLayer.GetNextFeature();
                    }
                }

                //开始读取点数据
                loadingForm.ShowProgress(40, "导入块参照属性...");
                for (int i = 0; i < doc.Inserts.Count; i++)
                {
                    Insert insert = doc.Inserts[i];
                    TmpCadd cadd = new TmpCadd();
                    cadd.Handle = insert.Handle;
                    cadd.EntityType = "POINT";
                    cadd.FileName = dxfName;
                    cadd.Geometry =
                        DbGeometry.FromText(string.Format("POINT({0} {1})", insert.Position.X, insert.Position.Y));
                    caddService.Create(cadd);

                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Block.Name, xodePage);
                    cadxdata.Fhdx = insert.Scale.X;
                    cadxdata.Xzjd = insert.Rotation;
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdataService.Create(cadxdata);
                }

                //开始读取点数据
                loadingForm.ShowProgress(50, "导入文本数据...");
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
                    cadxdataService.Create(cadxdata);
                }

                //开始读取线数据
                loadingForm.ShowProgress(60, "导入线数据...");
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
                    cadxdataService.Create(cadxdata);
                }
                loadingForm.ShowProgress(80, "导入多边形数据...");
                for (int i = 0; i < doc.LwPolylines.Count; i++)
                {
                    LwPolyline insert = doc.LwPolylines[i];
                    //if (insert.IsClosed)
                    //{
                    //    //插入多边形
                    //    TmpCadx cadx = cadxService.GetTmpCadx(insert.Handle);
                    //    if (cadx != null)
                    //    {
                    //        TmpCadm cadm = new TmpCadm() { Handle = cadx.Handle, EntityType = "POLYGON", FileName = dxfName };
                    //        string wkt = cadx.Geometry.AsText();
                    //        Geometry geometry = Ogr.ForceToPolygon(Geometry.CreateFromWkt(wkt));
                    //        string geomStr = "";
                    //        geometry.ExportToWkt(out geomStr);
                    //        //geomStr = geomStr.Replace("LINESTRING", "POLYGON (") + "";
                    //        cadm.Geometry = DbGeometry.FromText(geomStr);
                    //        cadmService.Create(cadm);
                    //    }
                    //}


                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name, xodePage);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Linetype.Name, xodePage);
                    cadxdata.Fhdx = insert.LinetypeScale;
                    cadxdata.Xzjd = 0.0;
                    cadxdata.Wbnr = "";
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdataService.Create(cadxdata);
                }

                for (int i = 0; i < doc.Polylines.Count; i++)
                {
                    Polyline insert = doc.Polylines[i];
                    //if (insert.IsClosed)
                    //{
                    //    //插入多边形
                    //    TmpCadx cadx = cadxService.GetTmpCadx(insert.Handle);
                    //    if (cadx != null)
                    //    {
                    //        TmpCadm cadm = new TmpCadm() { Handle = cadx.Handle, EntityType = "POLYGON", FileName = dxfName };
                    //        string wkt = cadx.Geometry.AsText();
                    //        Geometry geometry = Ogr.ForceToPolygon(Geometry.CreateFromWkt(wkt));
                    //        string geomStr = "";
                    //        geometry.ExportToWkt(out geomStr);
                    //        geomStr = geomStr.Replace("LINESTRING", "POLYGON (") + ")";
                    //        cadm.Geometry = DbGeometry.FromText(geomStr);
                    //        cadmService.Create(cadm);
                    //    }
                    //}


                    TmpCadxdata cadxdata = new TmpCadxdata();
                    cadxdata.Handle = insert.Handle;
                    cadxdata.Tc = StringHelper.StringToUtf8(insert.Layer.Name);
                    cadxdata.Fh = StringHelper.StringToUtf8(insert.Linetype.Name);
                    cadxdata.Fhdx = insert.LinetypeScale;
                    cadxdata.Xzjd = 0.0;
                    cadxdata.Wbnr = "";
                    cadxdata.FileName = dxfName;
                    cadxdata = ReadXData(cadxdata, insert.XData, xodePage);
                    cadxdataService.Create(cadxdata);
                }


                loadingForm.ShowProgress(100, "导入完成...");
                MessageService.Current.Info(string.Format("导入DX完成{0}",dxfName));
            }
            catch (Exception ex)
            {
                 MessageService.Current.Warn(string.Format("导入DXF发生错误，{0}",ex.Message));
                return;
            }
            //mainService.Close();
        }

        public bool HasCADData(string fileName)
        {
            MainService mainService = ServiceFactory.GetMainService();
            return mainService.HasCADData(fileName);
        }

        public void SplitTmpCadIntoLayers(string cadLayerName, string tableName, string fileName = "", bool isClear = true)
        {
            MainService mainService = ServiceFactory.GetMainService();
            mainService.SplitTmpCADToLayer(cadLayerName,tableName,fileName,isClear);
        }

        private TmpCadxdata ReadXData(TmpCadxdata cadxdata, XDataDictionary datas2,string codePage)
        {
            int count = 0;
            List<string> attrs=new List<string>();
            List<XData> datas = datas2.Values.ToList();
            for (int j = 0; j < datas2.Values.Count; j++)
            {
                List<XDataRecord> records = datas[j].XDataRecord;
                for (int k = 0; k < records.Count; k++)
                {
                    string pValue = records[k].Value.ToString().Trim();
                    if(!string.IsNullOrEmpty(pValue))
                        attrs.Add(pValue);
                }
            }
            cadxdata.Cassdm=attrs.Count>0?attrs[0]:"";
            cadxdata.Fsxx1 = attrs.Count > 1 ? StringHelper.StringToUtf8(attrs[1], codePage) : "";
            cadxdata.Fsxx2 = attrs.Count > 2 ? StringHelper.StringToUtf8(attrs[2], codePage) : "";
            return cadxdata;
        }

        #endregion

    }
}
