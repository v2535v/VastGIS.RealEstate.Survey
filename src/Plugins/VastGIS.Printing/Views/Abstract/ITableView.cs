// -------------------------------------------------------------------------------------------
// <copyright file="ITableView.cs" company="MapWindow OSS Team - www.mapwindow.org">
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