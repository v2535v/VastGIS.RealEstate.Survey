﻿// -------------------------------------------------------------------------------------------
// <copyright file="TempDatasourceHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Concrete;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Static;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Model;

namespace VastGIS.Tools.Helpers
{
    /// <summary>
    /// Savs datasource into temporary file, reopens it as in-memory layer and remove the temp file.
    /// </summary>
    [Obsolete]
    internal static class TempDatasourceHelper
    {
        private static bool AddTempDataSource(
            IAppContext context,
            ILayerService layerService,
            string filename,
            OutputLayerInfo outputInfo)
        {
            var fs = FeatureSet.OpenAsInMemoryDatasource(filename);
            if (fs != null)
            {
                // output info name
                if (layerService.AddDatasource(fs))
                {
                    var layer = context.Layers.ItemByHandle(layerService.LastLayerHandle);
                    layer.Name = outputInfo.Name;

                    GeoSource.Remove(filename);
                    return true;
                }
            }

            return false;
        }

        private static bool SaveDatasource(IDatasource ds, string filename)
        {
            if (!GeoSource.Remove(filename))
            {
                return false;
            }

            if (LayerSourceHelper.Save(ds, filename))
            {
                Logger.Current.Info("Layer ({0}) is created.", filename);
                return true;
            }

            Logger.Current.Error("Failed to save datasource: " + ds.LastError, null);
            return false;
        }

        private static bool SaveToTempDatasource(ITempFileService tempFileService, IDatasource ds)
        {
            // We can't the resulting shapefile directly, because it was created by background thread
            // therefore is located in another apartment. This will cause creation of proxies and marshalling
            // for COM, which in turn no always supported by implementation of particular classes in MapWinGIS.
            // Therefore the best option we have is to save into temp file, open it, read into memory, delete the source.
            string filename = tempFileService.GetTempFilename(".shp");
            bool saved = SaveDatasource(ds, filename);
            ds.Dispose();

            if (!saved)
            {
                Logger.Current.Warn("Failed to save datasource to temp file.");
                return false;
            }

            return true;
        }
    }
}