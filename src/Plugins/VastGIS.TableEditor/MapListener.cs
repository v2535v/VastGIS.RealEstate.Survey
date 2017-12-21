using System;
using VastGIS.Api.Events;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.TableEditor.Views;

namespace VastGIS.Plugins.TableEditor
{
    internal class MapListener
    {
        private readonly TableEditorPresenter _presenter;

        public MapListener(TableEditorPlugin plugin, TableEditorPresenter presenter)
        {
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (presenter == null) throw new ArgumentNullException("presenter");

            _presenter = presenter;

            plugin.SelectionChanged += SelectionChanged;

            plugin.LayerFeatureCountChanged += OnLayerFeatureCountChanged;
        }

        private void OnLayerFeatureCountChanged(object sender, Api.Legend.Events.LayerEventArgs e)
        {
            _presenter.RebuildTableIndex(e.LayerHandle);
        }

        private void SelectionChanged(IMuteMap map, SelectionChangedEventArgs e)
        {
            _presenter.UpdateSelection(e.LayerHandle);
        }
    }
}
