﻿using System.Collections.Generic;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Interfaces
{
    public interface IVectorDatasource: IDatasource, IEnumerable<VectorLayer>
    {
        bool Open(string connectionString);

        IEnumerable<string> GetShemas();

        int LayerCount { get; }
        string DriverName { get; }
        int DriverMetadataCount { get; }
        string GdalLastErrorMsg { get; }
        VectorLayer GetLayer(int index, bool forUpdate = false);
        string GetLayerName(int layerIndex);
        VectorLayer GetLayerByName(string layerName, bool forUpdate = false);
        VectorLayer RunQuery(string sql);
        bool DeleteLayer(int layerIndex);
        bool TestCapability(DatasourceCapability capability);
        bool CreateLayer(string layerName, GeometryType geometryType, ISpatialReference projection = null, string creationOptions = "");
        int LayerIndexByName(string layerName);

        bool ImportLayer(IFeatureSet featureSet, string layerName, string creationOptions = "",
            ValidationMode validationMode = ValidationMode.TryFixSkipOnFailure);

        bool ExecuteSql(string sql, out string errorMessage);
        string get_DriverMetadata(GdalDriverMetadata metadata);
        string get_DriverMetadataItem(int metadataIndex);
        IEnumerator<VectorLayer> GetFastEnumerator();
    }
}
