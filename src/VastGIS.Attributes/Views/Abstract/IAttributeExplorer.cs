// -------------------------------------------------------------------------------------------
// <copyright file="IAttributeExplorer.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Attributes.Views.Abstract
{
    public interface IAttributeExplorer : IView<ILayer>
    {
        event Action ZoomTo;

        event Action CurrentFeatureChanged;

        int CurrentFeatureIndex { get; }
    }
}