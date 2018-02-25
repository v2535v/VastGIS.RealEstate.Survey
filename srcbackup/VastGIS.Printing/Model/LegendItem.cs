﻿// -------------------------------------------------------------------------------------------
// <copyright file="LegendItem.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;

namespace VastGIS.Plugins.Printing.Model
{
    internal class LegendItem
    {
        public ILegendLayer Layer { get; set; }
        public string Name { get; set; }
        public IGeometryStyle Options { get; set; }
        public RasterInterval RasterBreak { get; set; }
    }
}