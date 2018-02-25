﻿// -------------------------------------------------------------------------------------------
// <copyright file="RepositoryItemHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Text;
using VastGIS.Api.Static;
using VastGIS.Data.Enums;
using VastGIS.Data.Repository;
using VastGIS.Plugins.Model;
using VastGIS.Shared;

namespace VastGIS.Data.Helpers
{
    /// <summary>
    /// Extension methods for IRepositoryItem.
    /// </summary>
    public static class RepositoryItemHelper
    {
        /// <summary>
        /// Gets the description of the item to be displayed in the UI.
        /// </summary>
        public static string GetDescription(this IRepositoryItem item)
        {
            switch (item.Type)
            {
                case RepositoryItemType.TmsSource:
                    var tmsItem = item as ITmsItem;
                    return GetDescription(tmsItem);
                case RepositoryItemType.Image:
                case RepositoryItemType.Vector:
                    var fileItem = item as IFileItem;
                    if (fileItem != null)
                    {
                        return GetDescription(fileItem.Filename);
                    }
                    break;
                case RepositoryItemType.DatabaseLayer:
                    var layerItem = item as IDatabaseLayerItem;
                    return GetDescription(layerItem);
                case RepositoryItemType.Database:
                    var dbItem = item as IDatabaseItem;
                    return GetDescription(dbItem);
            }

            return string.Empty;
        }

        private static string GetDescription(IDatabaseItem dbItem)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Type: " + dbItem.Connection.DatabaseType);
            sb.AppendLine("Connection: " + dbItem.Connection.GetUIConnection());
            return sb.ToString();
        }

        private static string GetDescription(ITmsItem tms)
        {
            if (tms == null || tms.Provider == null) return string.Empty;

            var provider = tms.Provider;

            var sb = new StringBuilder();
            sb.AppendLine("Url: " + provider.Url);
            sb.AppendLine("Projection: " + provider.Projection);

            if (!string.IsNullOrWhiteSpace(provider.Description))
            {
                sb.AppendLine("Description: " + provider.Description);
            }

            var bounds = provider.Bounds;
            sb.AppendFormat("Latitude: {0} to {1}" + Environment.NewLine, bounds.MinY, bounds.MaxY);
            sb.AppendFormat("Longitude: {0} to {1}" + Environment.NewLine, bounds.MinX, bounds.MaxX);

            return sb.ToString();
        }

        private static string GetDescription(IDatabaseLayerItem item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            var s = "Geometry type: " + item.GeometryType.EnumToString() + Environment.NewLine;
            s += "Number of features: " + item.NumFeatures + Environment.NewLine;
            // s += "Projection: " + item.Projection.ExportToProj4();
            s += "Projection: " + item.Projection.Name;
            return s;
        }

        private static string GetDescription(string filename)
        {
            using (var ds = GeoSource.Open(filename))
            {
                if (ds != null)
                {
                    return ds.ToolTipText;
                }
            }

            return string.Empty;
        }
    }
}