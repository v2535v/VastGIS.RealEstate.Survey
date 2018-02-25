// -------------------------------------------------------------------------------------------
// <copyright file="ILayoutView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Controls.Layout;

namespace VastGIS.Plugins.Printing.Views.Abstract
{
    internal interface ILayoutView : IComplexView<TemplateModel>
    {
        LayoutControl LayoutControl { get; }

        object MenuManager { get; }

        object DockingManager { get; }

        IDockPanelCollection DockPanels { get; }

        void RestorePanels();

        void RestoreToolbars();

        bool TilesLoadingVisible { get; set; }
    }
}