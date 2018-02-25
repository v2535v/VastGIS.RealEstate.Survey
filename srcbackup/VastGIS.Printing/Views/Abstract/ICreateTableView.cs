// -------------------------------------------------------------------------------------------
// <copyright file="ICreateTableView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface ICreateTableView : IView<CreateTableModel>
    {
        int ColumnCount { get; }

        int RowCount { get; }
    }
}