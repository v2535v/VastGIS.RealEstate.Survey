﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using MapWinGIS;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Api.Helpers
{
    public static class LayerSourceHelper
    {
        public static ILayerSource Open(string filename, LayerType layerType)
        {
            switch (layerType)
            {
                case LayerType.Shapefile:
                    var fs = new FeatureSet(filename);
                    return fs;
                case LayerType.Image:
                    var img = BitmapSource.Open(filename, false);
                    return img;
                case LayerType.VectorLayer:
                    var ogr = new OgrLayer();
                    var vector = new VectorLayer(ogr);
                    return vector;
                default:
                    throw new ArgumentOutOfRangeException("layerType");
            }
        }

        public static bool Save(IDatasource ds, string filename)
        {
            var fs = ds as IFeatureSet;
            if (fs != null)
            {
                return fs.SaveAsEx(filename, true);
            }

            var raster = ds as IRasterSource;
            if (raster != null)
            {
                return raster.Save(filename);
            }

            throw new ApplicationException("Failed to save. Unsupported format.");
        }

        public static IDatasource Convert(object source)
        {
            if (source is OgrDatasource)
            {
                return new VectorDatasource(source as OgrDatasource);
            }
            return ConvertToLayer(source);
        }

        public static ILayerSource ConvertToLayer(object source)
        {
            if (source is Shapefile)
            {
                return new FeatureSet(source as Shapefile);
            }

            if (source is Image)
            {
                return BitmapSource.Wrap(source as Image);
            }

            if (source is OgrLayer)
            {
                return new VectorLayer(source as OgrLayer);
            }

            if (source is Grid)
            {
                return new GridSource(source as Grid);
            }

            if (source is WmsLayer)
            {
                return new WmsSource(source as WmsLayer);
            }

            return null;
        }

        public static IEnumerable<ILayerSource> GetLayers(this IDatasource ds)
        {
            var vs = ds as VectorDatasource;
            if (vs != null)
            {
                foreach (var layer in vs)
                {
                    yield return layer;
                }
            }
            else
            {
                yield return ds as ILayerSource;
            }
        }

        /// <summary>
        /// Gets the geometry type for vector datasource. GeometryType.None will be returned for raster datasource.
        /// </summary>
        public static GeometryType GetGeometryType(ILayerSource source)
        {
            if (!source.IsVector)
            {
                return GeometryType.None;
            }

            var vector = source as IVectorLayer;
            if (vector != null)
            {
                return vector.GeometryType;
            }

            var fs = source as IFeatureSet;
            if (fs != null)
            {
                return fs.GeometryType;
            }

            return GeometryType.None;
        }
    }
}
