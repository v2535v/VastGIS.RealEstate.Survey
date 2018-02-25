﻿// -------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.DebugWindow.Views;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.DebugWindow
{
    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        /// <summary>
        /// Composing the container
        /// </summary>
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterSingleton<DebugDockView>();
        }
    }
}