﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Attributes.Views;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Editor;
using VastGIS.Plugins.TableEditor.Views;
using VastGIS.Shared;
using VastGIS.UI.Docking;

namespace VastGIS.Plugins.TableEditor
{
    internal class ProjectListener
    {
        private readonly IAppContext _context;
        private readonly TableEditorPresenter _presenter;

        public ProjectListener(IAppContext context, TableEditorPlugin plugin, TableEditorPresenter presenter)
        {
            if (context == null) throw new ArgumentNullException("context");
            if (plugin == null) throw new ArgumentNullException("plugin");
            if (presenter == null) throw new ArgumentNullException("presenter");

            _context = context;
            _presenter = presenter;

            plugin.BeforeRemoveLayer += BeforeRemoveLayer;
            plugin.UpdateTableJoin += OnUpdateTableJoin;
            plugin.LayerRemoved += plugin_LayerRemoved;
            plugin.ProjectClosed += OnProjectClosed;
            plugin.LayerEditingChanged += OnLayerEditingChanged;
        }

        private void OnLayerEditingChanged(object sender, Api.Legend.Events.LayerEventArgs e)
        {
            var layer = _context.Layers.ItemByHandle(e.LayerHandle);
            if (layer.IsVector)
            {
                _presenter.View.ReloadDatasource(layer.FeatureSet, e.LayerHandle, layer.LayerType == LayerType.VectorLayer);
            }

            _presenter.View.UpdateView();
        }

        private void OnProjectClosed(object sender, EventArgs e)
        {
            var panel = _context.DockPanels.Find(DockPanelKeys.TableEditor);
            if (panel.Visible)
            {
                panel.Visible = false;
            }
        }

        private void OnUpdateTableJoin(object sender, Api.Events.UpdateJoinEventArgs e)
        {
            var table = sender as AttributeTable;
            if (table == null)
            {
                return;
            }

            string path = PathHelper.GetAbsolutePath(e.Filename, table.Filename);
            if (!File.Exists(path))
            {
                Logger.Current.Warn("Joined datasource wasn't found: " + path);
                return;
            }

            var model = new JoinViewModel(table);
            model.OpenDatasource(path);
            model.ReloadExternal(e.TableToFill, e.Options);
        }

        private void plugin_LayerRemoved(Api.Legend.Abstract.IMuteLegend legend, Api.Legend.Events.LayerEventArgs e)
        {
            _presenter.CloseTable(e.LayerHandle);
        }

        private void BeforeRemoveLayer(object sender, LayerCancelEventArgs e)
        {
            if (!_presenter.HasLayer(e.LayerHandle))
            {
                return;
            }

            if (!_presenter.CheckAndSaveChanges(e.LayerHandle, true))
            {
                e.Cancel = true;
            }
        }
    }
}
