using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Helpers;
using VastGIS.Plugins.Services;
using VastGIS.Property.Services;

namespace VastGIS.Plugins.RealEstate.Services
{
    public class RealEstateEditingService: IRealEstateEditingService
    {
        private readonly IAppContext _context;
        private readonly ILayerService _layerService;
        private readonly IFileDialogService _dialogService;
        private readonly IBroadcasterService _broadcaster;
        private readonly IBDCDatabaseService _bdcDatabaseService;
        private VectorLayer _currentEditingLayer;
       
        private bool _isEditing;
        private bool _hasChanged;
        private List<string> _databases;
        private string _editDatabase;

        public RealEstateEditingService(IAppContext context, ILayerService layerService, IFileDialogService dialogService,
                                   IBroadcasterService _broadcaster,IBDCDatabaseService bdcDatabaseService)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (layerService == null) throw new ArgumentNullException("layerService");
            if (dialogService == null) throw new ArgumentNullException("dialogService");
            if (_broadcaster == null) throw new ArgumentNullException("_broadcaster");

            _context = context;
            _layerService = layerService;
            _dialogService = dialogService;
            this._broadcaster = _broadcaster;
            _bdcDatabaseService = bdcDatabaseService;
            _databases=new List<string>();
        }
        public void OpenREDatabase()
        {
            string dbName = "";
            bool back=_dialogService.OpenFile(DataSourceType.SpatiaLite, out dbName);
            if (!back) return;
            _layerService.AddDatabaseLayer(dbName, "djq", GeometryType.Polygon, ZValueType.None);
            _layerService.AddDatabaseLayer(dbName, "djzq", GeometryType.Polygon, ZValueType.None);
            _layerService.AddDatabaseLayer(dbName, "zdjbxx", GeometryType.Polygon, ZValueType.None);
            _layerService.AddDatabaseLayer(dbName, "jzd", GeometryType.MultiPoint, ZValueType.None);
            _layerService.AddDatabaseLayer(dbName, "jzx", GeometryType.Polyline, ZValueType.None);
            if (!_databases.Contains(dbName))
            {
                _databases.Add(dbName);
            }
        }

        public bool StartEditing()
        {
            _isEditing = false;
            //if (_databases.Count ==0)
            //{
                for (int i = 0; i < _context.Map.Layers.Count; i++)
                {
                    ILayer pLayer = _context.Map.Layers[i];
                    if (pLayer is VectorLayer && pLayer.Name.ToLower().Equals("jzd"))
                    {
                        VectorLayer pVectorLayer=pLayer as VectorLayer;
                        if (!_databases.Contains(pVectorLayer.ConnectionString))
                        {
                            _databases.Add(pVectorLayer.ConnectionString);
                        }
                    }
                }
            //}
            if (_databases == null || _databases.Count == 0)
            {
                MessageService.Current.Warn("没有打开的不动产数据库!");
                _isEditing = false;
                _editDatabase = "";
                return false;
            }
            else if (_databases.Count == 1)
            {
                _editDatabase = _databases[0];
                _isEditing = true;
            }
            else
            {
                string db = DatabaseHelper.ChooseEditingDatabase(_context, _databases);
                if (string.IsNullOrEmpty(db))
                {
                    _isEditing = false;
                    _editDatabase = "";
                }
                else
                {
                    _isEditing = true;
                    _editDatabase = db;
                }
            }

            return _isEditing;
        }

        public bool SaveEditing(bool isStop)
        {
            return true;
        }

        public bool StopEditing(bool isSave)
        {
            return true;
        }

        public bool SetEditingLayer()
        {
            return false;
        }

        public string SpatialiteDB
        {
            get { return _editDatabase; }
        }

        public VectorLayer CurrentEditingLayer
        {
            get { return _currentEditingLayer; }
        }
    }
}
