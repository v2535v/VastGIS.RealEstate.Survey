// -------------------------------------------------------------------------------------------
// <copyright file="TableViewModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Plugins.Printing.Model.Elements;

namespace VastGIS.Plugins.Printing.Views
{
    internal class TableViewModel
    {
        public TableViewModel(LayoutTable table, bool adding)
        {
            if (table == null) throw new ArgumentNullException("table");

            Table = table;
            Adding = adding;
        }

        public bool Adding { get; private set; }

        public LayoutTable Table { get; private set; }
    }
}