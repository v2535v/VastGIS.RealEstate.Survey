using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using VastGIS.RealEstate.Data.Service;
using VastGIS.RealEstate.Data.Service.Impl;


namespace VastGIS.RealEstate.Api.Concrete
{

    public class ReDatabase : IREDatabase
        //, IREDatabaseService
    {
        private const string DatabaseFilter = "未见不动产数据库(*.db)|*.db";
        private string _databaseName;
        private int _epsgCode;
        private CadService _cadService;
        private BasemapService _basemapService;
        private SystemService _systemService;
        private DomainService _domainService;
        private ZdService _zdService;

        #region 构造函数

        public ReDatabase(string databaseName)
        {
            _databaseName = databaseName;
            if (!File.Exists(_databaseName))
            {
                FileInfo fileInfo = ReProjectHelper.GetTemplateDBInfo();
                fileInfo.CopyTo(_databaseName);
            }
            InitService();
        }

        
        public ReDatabase(string databaseName,int epsgCode)
        {
            _databaseName = databaseName;
            _epsgCode = epsgCode;
            if (!File.Exists(_databaseName))
            {
                FileInfo fileInfo = ReProjectHelper.GetTemplateDBInfo();
                fileInfo.CopyTo(_databaseName);
            }
            InitService();
        }


        #endregion

        #region 属性

        private event EntityChangedEventHandler entityChanged;

        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        protected virtual void OnEntityChanged(EntityOperationType operationType, List<IEntity> entities)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs( operationType, entities));
            }
        }


        public void SetProjectFile(string fileName)
        {
            _databaseName=ReProjectHelper.GetProjectDatabase(fileName);
            DbConnection.SetDatabaseName(_databaseName);
            InitService();
        }

        public string DatabaseName
        {
            get { return _databaseName; }
            set
            {
                _databaseName = value;
                CheckDatabase();
                InitService();
            }
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
        public string GetAttachmentPath()
        {
            string dbPath = Path.GetDirectoryName(Path.GetDirectoryName(_databaseName));
            string path = Path.Combine(dbPath, @"Attachments");
            return path;
        }
        public string CreateAttachmentName()
        {
            string dbPath = Path.GetDirectoryName(Path.GetDirectoryName(_databaseName));
            string fileName = "J" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string path = Path.Combine(dbPath, @"Attachments\", fileName);
            return path;
        }

        public string GetRelativePath(string fileName)
        {
            string dbPath = Path.GetDirectoryName(Path.GetDirectoryName(_databaseName));
           

                Uri fromUri = new Uri(DatabaseName);
                Uri toUri = new Uri(fileName);

                Uri relativeUri = fromUri.MakeRelativeUri(toUri);
                var relativePath = Uri.UnescapeDataString(relativeUri.ToString());
                return relativePath.Replace('/', Path.DirectorySeparatorChar);
    }

        public string GetAbsolutePath(string fileName)
        {
           return Path.Combine(Path.GetDirectoryName(_databaseName),fileName);
        }

        private void InitService()
        {
            
            DbConnection.SetDatabaseName(_databaseName);
            _cadService=new CadServiceImpl(new CadDaoImpl());
            _zdService = new ZdServiceImpl(new ZdDaoImpl());
            _basemapService = new BasemapServiceImpl(new BasemapDaoImpl());
            _systemService = new SystemServiceImpl(new SystemDaoImpl());
            _domainService = new DomainServiceImpl(new DomainDaoImpl());
            ((ISQLiteService)_cadService).EntityChanged += ReDatabase_EntityChanged;
            ((ISQLiteService)_zdService).EntityChanged += ReDatabase_EntityChanged;
            ((ISQLiteService)_basemapService).EntityChanged += ReDatabase_EntityChanged;
            (_systemService).EntityChanged += ReDatabase_EntityChanged;
            ((ISQLiteService)_domainService).EntityChanged += ReDatabase_EntityChanged;
        }

        private void ReDatabase_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }

        private void ClearService()
        {
            if (_cadService != null) _cadService.EntityChanged -= ReDatabase_EntityChanged;
            if (_zdService != null) _zdService.EntityChanged -= ReDatabase_EntityChanged;
            if (_basemapService != null) _basemapService.EntityChanged -= ReDatabase_EntityChanged;
            if (_systemService != null) _systemService.EntityChanged -= ReDatabase_EntityChanged;
            if (_domainService != null) _domainService.EntityChanged -= ReDatabase_EntityChanged;
        }
        #endregion

        #region 公共方法

        public bool CheckDatabase()
        {
            if (!string.IsNullOrEmpty(_databaseName))
            {
                DbConnection.SetDatabaseName(_databaseName);
            }
            return false;
        }

        public CadService CadService
        {
            get { return _cadService; }
        }

        public BasemapService BasemapService
        {
            get { return _basemapService; }
        }

        public SystemService SystemService
        {
            get { return _systemService; }
        }

        public DomainService DomainService
        {
            get { return _domainService; }
        }

        public ZdService ZdService
        {
            get { return _zdService; }
        }

        public void InitDatabase(int epsgCode)
        {
            if (!File.Exists(_databaseName))
            {
                FileInfo fileInfo = ReProjectHelper.GetTemplateDBInfo();
                fileInfo.CopyTo(_databaseName);
            }
            DbConnection.SetDatabaseName(_databaseName);
            _systemService.InitializeDatabase(epsgCode);

            ///统一为一次性初始化
            ////_systemService.InitTables();
            //_systemService.InternalInitTables();
            //_systemService.InitSettings();
            //_systemService.SaveVgSetting2(SettingKeyHelper.SpatialReferenceID, epsgCode.ToString());
            ////_domainService.InitTables();
            //_domainService.InternalInitTables();
            //_cadService.InitTables();
            //_basemapService.InitTables();
            //_zdService.InitTables();
        }

        public void LoadDataToMap(IMuteMap contextMap)
        {
            List<VgObjectclass> dataClasses = _systemService.GetObjectclasses(true).OrderBy(c=>c.Xssx).ToList();
            string connectionString = "Data Source=" + _databaseName;
            foreach (var dataClass in dataClasses)
            {
                LoadDataToMap(contextMap, dataClass);
            }
        }

        public IEnvelope GetDatabaseEnvelope()
        {
            double xmin=0.0;
            double ymin = 0.0;
            double xmax = 0.0;
            double ymax = 0.0;
            _systemService.RecalculateDBExtent(out xmin, out ymin, out xmax, out ymax);
            //_context.Map.SetGeographicExtents(envelope);
            IEnvelope envelope = new Envelope(xmin, xmax, ymin, ymax);
            return envelope;
        }

        private void LoadDataToMap(IMuteMap contextMap, VgObjectclass dataClass)
        {
            string connectionString = "Data Source=" + _databaseName;
            if (dataClass.Dxlx == 0)
            {
                if (dataClass.SubClasses == null || dataClass.SubClasses.Count() < 1) return;
                foreach (var subClass in dataClass.SubClasses)
                {
                    LoadDataToMap(contextMap, subClass);
                }
                return;
            }
            if (dataClass.Dxlx == 1)
            {
                IVectorLayer layer = new VectorLayer();

                layer.OpenFromQuery(connectionString, dataClass.Filter);
                GeometryType multiGeometryType = (GeometryType)dataClass.Txlx;
                layer.SetActiveGeometryType(multiGeometryType, ZValueType.None);
                layer.DynamicLoading = true;
                
                var layers = layer.GetLayers();
                foreach (var onelayer in layers)
                {
                    contextMap.Layers.Add(onelayer,(bool)dataClass.Visible);
                }
                return;
            }
        }

        #endregion

        #region 私有方法
     

       
        #endregion



    }
}
