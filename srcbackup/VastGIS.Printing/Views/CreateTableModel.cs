﻿// -------------------------------------------------------------------------------------------
// <copyright file="CreateTableModel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

namespace VastGIS.Plugins.Printing.Views
{
    internal class CreateTableModel
    {
        public CreateTableModel()
        {
            ColumnCount = 2;
            RowCount = 2;
        }

        public int ColumnCount { get; set; }

        public int RowCount { get; set; }
    }
}