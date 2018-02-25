using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Symbology.Controls;
using VastGIS.Plugins.Symbology.Services;
using VastGIS.Plugins.Symbology.Views;
using VastGIS.Plugins.Symbology.Views.Abstract;
using VastGIS.Shared;

namespace VastGIS.Plugins.Symbology
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<IRasterStyleView, RasterStyleView>().
                RegisterView<IRasterMinMaxView, RasterMinMaxView>().
                RegisterView<IRasterColorSchemeView, RasterColorSchemeView>().
                RegisterView<IHistogramOptionsView, HistogramOptionsView>().
                RegisterView<IVectorStyleView, VectorStyleView>().
                RegisterView<IWmsStyleView, WmsStyleView>().
                RegisterService<RasterRenderingSubView>().
                RegisterService<RasterRenderingPresenter>().
                RegisterService<CategoriesPresenter>().
                RegisterService<CategoriesSubView>();

            EnumHelper.RegisterConverter(new CollisionModeConverter());
            EnumHelper.RegisterConverter(new SymbologyTypeCoverter());
            EnumHelper.RegisterConverter(new RasterRenderingConverter());
            EnumHelper.RegisterConverter(new RasterClassificationConverter());
        }
    }
}
