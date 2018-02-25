﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Tiles.Services;
using VastGIS.Tiles.Views;
using VastGIS.Tiles.Views.Abstract;

namespace VastGIS.Tiles
{
    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        /// <summary>
        /// Composes the specified container.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<ITmsProviderView, TmsProviderView>()
                .RegisterView<IBingApiView, BingApiView>()
                .RegisterView<IWmsServerView, WmsServerView>()
                .RegisterView<IWmsCapabilitiesView, WmsCapabilitiesView>()
                .RegisterView<IProvidersView, TmsListView>()
                .RegisterService<TmsImporter>();
        }
    }
}
