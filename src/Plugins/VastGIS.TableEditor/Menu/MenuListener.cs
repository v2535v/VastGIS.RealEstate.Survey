using System;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.TableEditor.Views;
using VastGIS.UI.Docking;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.TableEditor.Menu
{
    internal class MenuListener: MenuServiceBase
    {
        private readonly TableEditorPresenter _presenter;

        public MenuListener(IAppContext context, TableEditorPlugin plugin, TableEditorPresenter presenter)
            : base(context, plugin.Identity)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (presenter == null) throw new ArgumentNullException("presenter");

            _presenter = presenter;

            plugin.ItemClicked += PluginItemClicked;
            plugin.ViewUpdating += ViewUpdating;
            plugin.MessageBroadcasted += OnPluginMessageBroadcasted;
        }

        private void OnPluginMessageBroadcasted(object sender, PluginMessageEventArgs e)
        {
            if (e.Message == PluginMessages.ShowAttributeTable)
            {
                ShowTableEditor();
            }
        }

        private void ViewUpdating(object sender, EventArgs e)
        {
            //bool visible = _context.Map.SelectedFeatureSet != null;
            //FindToolbarItem(MenuKeys.ShowTable).Enabled = visible;
            //FindMenuItem(MenuKeys.ShowTable).Enabled = visible;
        }

        private void PluginItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.ShowTable:
                    ShowTableEditor();
                    break;
            }
        }

        private void ShowTableEditor()
        {
            var layer = _context.Legend.SelectedLayer;
            if (layer.IsVector)
            {
                _presenter.OpenTable(layer);
            }

            var panel = _context.DockPanels.Find(DockPanelKeys.TableEditor);
            if (panel != null && !panel.Visible)
            {
                panel.Visible = true;
            }
        }
    }
}
