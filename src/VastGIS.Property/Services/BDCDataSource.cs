using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Static;
using VastGIS.Plugins.Services;
using VastGIS.Property.Helpers;
using VastGIS.Shared;
using VastGIS.Shared.Log;

namespace VastGIS.Property.Services
{
    public class BDCDataSource:IBDCDatasource
    {
        private readonly OgrDatasource _datasource;
        private VectorLayer _zdLayer;
        private VectorLayer _jzdLayer;
        private VectorLayer _jzxLayer;
        private VectorLayer _djqLayer;
        private VectorLayer _djzqLayer;
        private VectorLayer _zjZdLayer;

        internal BDCDataSource(OgrDatasource datasource)
        {
            _datasource = datasource;
            if (datasource == null)
            {
                throw new NullReferenceException("Internal style reference is null.");
            }
        }

        public BDCDataSource()
        {
            _datasource = new OgrDatasource();
        }

        public BDCDataSource(string connectionString) : this()
        {
            if (!Open(connectionString))
            {
                throw new ApplicationException("Failed to open vector datasource:" +
                                               _datasource.ErrorMsg[_datasource.LastErrorCode]);
            }
        }

        public bool Open(string connectionString)
        {
            var opened = _datasource.Open(connectionString);
            return opened;
        }


        public object InternalObject
        {
            get { return _datasource; }
        }

        public string LastError
        {
            get { return _datasource.ErrorMsg[_datasource.LastErrorCode]; }
        }

        public string Tag
        {
            get { return _datasource.Key; }
            set { _datasource.Key = value; }
        }

        public string Name
        {
            get { return Path.GetFileNameWithoutExtension(Filename); }
        }

        public string Filename
        {
            get { return "<OGR datasource>"; }
        }

        public void Close()
        {
            _datasource.Close();
        }

        public VectorLayer GetLayer(int index, bool forUpdate = false)
        {
            var layer = _datasource.GetLayer(index, forUpdate);
            return layer != null ? new VectorLayer(layer) : null;
        }

        public VectorLayer GetLayer2(int index, bool forUpdate = false, bool newConnection = true)
        {
            var layer = _datasource.GetLayer2(index, forUpdate, newConnection);
            return layer != null ? new VectorLayer(layer) : null;
        }

        public string GetLayerName(int layerIndex)
        {
            return _datasource.GetLayerName(layerIndex);
        }

        public VectorLayer GetLayerByName(string layerName, bool forUpdate = false)
        {
            var layer = _datasource.GetLayerByName(layerName, forUpdate);
            if (layer != null)
            {
                return new VectorLayer(layer);
            }
            return null;
        }

        public VectorLayer RunQuery(string sql)
        {
            var layer = _datasource.RunQuery(sql);
            if (layer != null)
            {
                return new VectorLayer(layer);
            }
            return null;
        }

        public bool DeleteLayer(int layerIndex)
        {
            return _datasource.DeleteLayer(layerIndex);
        }

        public bool TestCapability(DatasourceCapability capability)
        {
            return _datasource.TestCapability((tkOgrDSCapability)capability);
        }

        public bool CreateLayer(string layerName, GeometryType geometryType, ISpatialReference projection = null, string creationOptions = "")
        {
            var shpType = GeometryHelper.GeometryType2ShpType(geometryType);
            GeoProjection gp = null;
            if (projection != null)
            {
                gp = projection.GetInternal();
            }
            return _datasource.CreateLayer(layerName, shpType, gp, creationOptions);
        }

        public int LayerIndexByName(string layerName)
        {
            return _datasource.LayerIndexByName(layerName);
        }

        public bool ImportLayer(IFeatureSet featureSet, string layerName, string creationOptions = "",
                                ValidationMode validationMode = ValidationMode.TryFixSkipOnFailure)
        {
            return _datasource.ImportShapefile(featureSet.GetInternal(), layerName, creationOptions, (tkShapeValidationMode)validationMode);
        }

        public bool ExecuteSql(string sql, out string errorMessage)
        {
            return _datasource.ExecuteSQL(sql, out errorMessage);
        }

        public int LayerCount
        {
            get { return _datasource.LayerCount; }
        }

        public string DriverName
        {
            get { return _datasource.DriverName; }
        }

        public string get_DriverMetadata(GdalDriverMetadata metadata)
        {
            return _datasource.DriverMetadata[(tkGdalDriverMetadata)metadata];
        }

        public int DriverMetadataCount
        {
            get { return _datasource.DriverMetadataCount; }
        }

        public string get_DriverMetadataItem(int metadataIndex)
        {
            return _datasource.DriverMetadataItem[metadataIndex];
        }

        public string GdalLastErrorMsg
        {
            get { return _datasource.GdalLastErrorMsg; }
        }

        public string OpenDialogFilter
        {
            get { return GeoSource.VectorFilter; }
        }

        public LayerType LayerType
        {
            get { return LayerType.VectorLayer; }
        }

        public string ToolTipText
        {
            get
            {
                string s = string.Empty;
                string proj = string.Empty;

                foreach (var source in this.GetLayers())
                {
                    var layer = source as IVectorLayer;
                    if (layer != null)
                    {
                        if (s != string.Empty)
                        {
                            s += "\n";
                        }

                        s += "Layer name: " + layer.Name + Environment.NewLine;
                        s += "Geometry type: " + layer.GeometryType.EnumToString() +
                             Environment.NewLine;
                        s += "Feature count: " + layer.get_FeatureCount() + Environment.NewLine;

                        // proj = layer.Projection.ExportToProj4();
                        proj = layer.Projection.Name;
                    }
                }

                s += "\n" + proj;

                return s;
            }
        }

        public bool IsVector
        {
            get { return true; }
        }

        public bool IsRaster
        {
            get { return false; }
        }

        public IGlobalListener Callback
        {
            get { return NativeCallback.UnWrap(_datasource.GlobalCallback); }
            set { _datasource.GlobalCallback = NativeCallback.Wrap(value); }
        }

        public void Dispose()
        {
            _datasource.Close();
        }

        public IEnumerator<VectorLayer> GetEnumerator()
        {
            for (int i = 0; i < _datasource.LayerCount; i++)
            {
                var layer = _datasource.GetLayer(i);
                yield return new VectorLayer(layer);
            }
        }

        public IEnumerator<VectorLayer> GetFastEnumerator()
        {
            for (int i = 0; i < _datasource.LayerCount; i++)
            {
                var layer = _datasource.GetLayer2(i, false, false);
                yield return new VectorLayer(layer);
            }
        }
        #region 宗地
        public bool InitBDCDatasource(bool overwrite, ISpatialReference projection = null)
        {
            //该方法将自动创建对应图层，因为在原本的接口中，数据库是支持多种的，如MySQL, SqlLite等，因此本身功能并不包含数据库创建
           
            CreateLayerAndField2(ZDSqlHelper.DJQ, "DJQ", GeometryType.Polygon, projection, "");
            CreateLayerAndField2(ZDSqlHelper.DJZQ,"DJZQ", GeometryType.Polygon, projection, "");
            CreateLayerAndField2(ZDSqlHelper.ZDJBXX,"ZDJBXX", GeometryType.Polygon, projection, "");
            CreateLayerAndField2(ZDSqlHelper.JZD,"JZD", GeometryType.Point, projection, "");
            CreateLayerAndField2(ZDSqlHelper.JZX,"JZX", GeometryType.Polyline, projection, "");
            CreateLayerAndField2(ZDSqlHelper.ZDTZJ,"ZDTZJ", GeometryType.Point, projection, "");
            MessageService.Current.Info("当前数据库有图层:"+LayerCount.ToString()+"个");
            return true;
        }
        private void CreateLayerAndField2(string fieldsMap, string layerName, GeometryType geometryType, ISpatialReference projection = null, string creationOptions = "")
        {
            //先创建一个Shapefile，然后导入
            var shpType = GeometryHelper.GeometryType2ShpType(geometryType);
            GeoProjection gp = null;
            if (projection != null)
            {
                gp = projection.GetInternal();
            }
            _datasource.CreateLayer(layerName, shpType, gp, creationOptions);
            string[] fields = fieldsMap.Split(',');
            string errMsg = "";
            foreach (string field in fields)
            {
                string sql = "Alter table " + layerName + " ADD COLUMN " + field;
                ExecuteSql(sql, out errMsg);
            }
        }


        private void CreateLayerAndField(string fieldsMap,string layerName, GeometryType geometryType, ISpatialReference projection = null, string creationOptions = "")
        {
            var shpType = GeometryHelper.GeometryType2ShpType(geometryType);
            GeoProjection gp = null;
            if (projection != null)
            {
                gp = projection.GetInternal();
            }
            _datasource.CreateLayer(layerName, shpType, gp, creationOptions);
            string[] fields = fieldsMap.Split(',');
            string errMsg = "";
            foreach (string field in fields)
            {
                string sql = "Alter table " + layerName + " ADD COLUMN " + field;
                ExecuteSql(sql, out errMsg);
            }
        }

        public VectorLayer ZdLayer
        {
            get
            {
                if (_zdLayer == null)
                {
                    _zdLayer= GetLayerByName("ZDJBXX", true);
                }
                return _zdLayer;
            }
        }

        public VectorLayer JzdLayer
        {
            get {
                if (_jzdLayer == null)
                {
                    _jzdLayer = GetLayerByName("JZD", true);
                }
                return _jzdLayer;
            }
        }

        public VectorLayer JzxLayer
        {
            get {
                if (_jzxLayer == null)
                {
                    _jzxLayer = GetLayerByName("JZX", true);
                }
                return _jzxLayer;
            }
        }

        public VectorLayer DjqLayer
        {
            get
            {
                if (_djqLayer == null)
                {
                    _djqLayer = GetLayerByName("DJQ", true);
                }
                return _djqLayer;
            }
        }

        public VectorLayer DjzqLayer
        {
            get
            {
                if (_djzqLayer == null)
                {
                    _djzqLayer = GetLayerByName("DJZQ", true);
                }
                return _djzqLayer;
            }
        }

        public VectorLayer ZjZdLayer
        {
            get
            {
                if (_zjZdLayer == null)
                {
                    _zjZdLayer = GetLayerByName("ZDTZJ", true);
                }
                return _zjZdLayer;
            }
        }

        public void AddToMap(IMap map, bool isClear)
        {
            if(isClear)map.Layers.Clear();
            //开始添加数据库内图层
            map.Layers.Add(DjqLayer, true);
            map.Layers.Add(DjzqLayer, true);
            map.Layers.Add(ZdLayer, true);
            map.Layers.Add(JzxLayer, true);
            map.Layers.Add(JzdLayer, true);
            map.Layers.Add(ZjZdLayer, true);
        }

        #endregion


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<string> GetShemas()
        {
            var arr = _datasource.GetSchemas() as string[];
            if (arr != null)
            {
                foreach (var item in arr.ToList())
                {
                    yield return item;
                }
            }
        }

       
    }
}