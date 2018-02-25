// -------------------------------------------------------------------------------------------
// <copyright file="ITableView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface ITableView : IView<TableViewModel>
    {
        event Action ApplyClicked;

        void Save();
    }
}