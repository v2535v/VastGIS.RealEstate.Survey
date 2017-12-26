// -------------------------------------------------------------------------------------------
// <copyright file="RowData.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace VastGIS.Plugins.Printing.Model.Table
{
    /// <summary>
    /// Holds data for a row
    /// </summary>
    public class RowData : List<string>
    {
        public RowData()
        {
        }

        public RowData(IEnumerable<string> collection)
            : base(collection)
        {
        }

        public object[] ToObjectArray()
        {
            // ReSharper disable once CoVariantArrayConversion
            return ToArray();
        }
    }
}