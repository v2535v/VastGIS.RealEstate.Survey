using System;
using VastGIS.Api.Helpers;
using VastGIS.Data.Enums;
using VastGIS.Shared;

namespace VastGIS.Data.Repository
{
    public class RepositoryItemTypeConverter : IEnumConverter<RepositoryItemType>
    {
        public string GetString(RepositoryItemType value)
        {
            switch (value)
            {
                case RepositoryItemType.FileSystem:
                    return "File System";
                case RepositoryItemType.Folder:
                    return "Folder";
                case RepositoryItemType.Vector:
                    return "Vector layer";
                case RepositoryItemType.Databases:
                    return "Spatial Databases";
                case RepositoryItemType.Server:
                    return "Server";
                case RepositoryItemType.Database:
                    return "Database";
                case RepositoryItemType.TmsRoot:
                    return "TMS Servers";
                case RepositoryItemType.TmsSource:
                    return "TMS Provider";
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }
    }
}
