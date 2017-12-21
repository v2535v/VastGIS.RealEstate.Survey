// -------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Gdal.Legacy.Views;
using VastGIS.Gdal.Views;
using VastGIS.Gdal.Views.Abstract;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Gdal
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
            container.RegisterView<ITranslateRasterCustomView, TranslateRasterCustomView>()
                .RegisterView<IGdalOptionsView, GdalOptionsView>()
                .RegisterView<IGdalView, GdalView>()
                .RegisterView<IGdalConvertView, GdalConvertView>()
                .RegisterView<IGdalDriverOptionsView, GdalDriverOptionsView>();

        }
    }
}