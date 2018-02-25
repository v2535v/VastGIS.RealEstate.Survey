// -------------------------------------------------------------------------------------------
// <copyright file="TileLoadingTask.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.Plugins.Printing.Model
{
    public class TileLoadingTask
    {
        public IEnvelope Extents { get; set; }

        public string Guid { get; set; }

        public int TileProvider { get; set; }

        public int Width { get; set; }
    }
}