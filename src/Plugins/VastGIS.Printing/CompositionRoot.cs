// -------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Services;
using VastGIS.Plugins.Printing.Views;
using VastGIS.Plugins.Printing.Views.Abstract;
using VastGIS.Plugins.Printing.Views.Panels;

namespace VastGIS.Plugins.Printing
{
    internal static class CompositionRoot
    {
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterView<ILayoutView, LayoutView>()
                .RegisterView<IPageSetupView, PageSetupView>()
                .RegisterView<ITemplateView, TemplateView>()
                .RegisterView<ITableView, TableView>()
                .RegisterView<IChooseDpiView, ChooseDpiView>()
                .RegisterView<ICreateTableView, CreateTableView>()
                .RegisterService<PdfExportService>()
                .RegisterService<ElementsDockPanel>()
                .RegisterService<TileLoadingService>()
                .RegisterService<ElementsPresenter>();
        }
    }
}