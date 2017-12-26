// -------------------------------------------------------------------------------------------
// <copyright file="ITableEditorView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Editor;
using VastGIS.Plugins.TableEditor.Model;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    internal interface ITableEditorView : IMenuProvider
    {
        int ActiveColumnIndex { get; }

        IFeatureSet ActiveFeatureSet { get; }

        TableEditorGrid ActiveGrid { get; }

        int ActiveLayerHandle { get; }

        TablePanelCollection Panels { get; }

        void ClearCurrentCell();

        TablePanelInfo CreateTablePanel(ILegendLayer layer);

        void GetLayoutSpecs(TableEditorLayout layout, out int size, out DockPanelState state);

        void Initialize(IAppContext context);

        void OnActivateDockingPanel();

        void UpdateDatasource();

        void UpdatePanelCaption(int layerHandle);

        void UpdateView();

        void OnSelectionChanged();

        void ReloadDatasource(IFeatureSet fs, int layerHandle, bool isOgr);
    }
}