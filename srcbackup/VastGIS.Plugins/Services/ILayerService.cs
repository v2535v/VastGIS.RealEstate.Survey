// -------------------------------------------------------------------------------------------
// <copyright file="ILayerService.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Services
{
    public interface ILayerService
    {
        bool Aborted { get; }

        int LastLayerHandle { get; }

        bool AddDatabaseLayer(string connection, string layerName, GeometryType multiGeometryType = GeometryType.None, ZValueType zValue = ZValueType.None);
        bool AddDatabaseLayer2(string connection, string layerName, GeometryType multiGeometryType = GeometryType.None, ZValueType zValue = ZValueType.None,string filter="");

        bool AddDatasource(IDatasource ds, string layerName = "");

        bool AddLayer(DataSourceType layerType);

        bool AddLayerIdentity(LayerIdentity identity);

        bool AddLayersFromFilename(string filename);

        bool AddLayersFromFilename(string filename, string layerName);

        void BeginBatch();

        void ClearSelection();

        void EndBatch();

        void LoadStyle();

        bool RemoveLayer(int layerHandle);

        bool RemoveLayer(LayerIdentity identity);

        bool RemoveSelectedLayer();

        void SaveStyle();

        void ZoomToSelected();

        void SetReprojectOnMismatch(bool autoReproject);
    }
}