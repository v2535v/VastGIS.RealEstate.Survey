// -------------------------------------------------------------------------------------------
// <copyright file="IAttributeExplorer.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
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