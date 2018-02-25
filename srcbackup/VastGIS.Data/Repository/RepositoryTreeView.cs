﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Static;
using VastGIS.Data.Enums;
using VastGIS.Data.Properties;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Model;
using VastGIS.Shared;
using VastGIS.UI.Controls;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Data.Repository
{
    /// <summary>
    /// Represents tree view to display repository items.
    /// </summary>
    public sealed class RepositoryTreeView: TreeViewBase, IRepositoryView
    {
        private HashSet<LayerIdentity> _layers;  // storing layers from the last update to be use on folder expansion
        private IRepository _repository;
        private bool _initialized;
        private HashSet<string> _expandedFolders;

        public RepositoryTreeView()
        {
            BeforeExpand += TreeViewBeforeExpand;

            AfterSelect += RepositoryTreeView_AfterSelect;

            LoadOnDemand = true;

            ToolTipDuration = 3000;

            ItemDrag += RepositoryTreeView_ItemDrag;
        }

        public new event EventHandler DoubleClick;

        protected override void OnDoubleClick(EventArgs e)
        {
            // this disabled the default behavior on double click: collapse / expand
            DelegateHelper.FireEvent(this, DoubleClick);
        }

        public void InitRepository(IRepository repository)
        {
            if (_initialized)
            {
                throw new InvalidOperationException("Attempt to initialize Repository tree view the second time.");
            }

            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            _repository = repository;

            _repository.BeforeSaved += RepositoryBeforeSaved;

            PopulateTree();

            AttachEvents();

            AfterExpand += RepositoryTreeView_AfterExpand;
            AfterCollapse += (s, e) => SaveExpandedState(e.Node);

            _initialized = true;
        }

        private void RepositoryBeforeSaved(object sender, EventArgs e)
        {
            _repository.ExpandedFolders.Clear();

            var item = GetSpecialItem(RepositoryItemType.FileSystem);
            if (item != null)
            {
                SaveExpadedFolders(item);
            }
        }

        private void SaveExpadedFolders(IRepositoryItem root)
        {
            foreach (var f in root.SubItems.OfType<IFolderItem>())
            {
                if (f.Expanded)
                {
                    _repository.ExpandedFolders.Add(f.GetPath());
                    SaveExpadedFolders(f);
                }
            }
        }

        private void SaveExpandedState(TreeNodeAdv node)
        {
            var item = RepositoryItem.Get(node) as IGroupItem;
            if (item != null)
            {
                item.Group.Expanded = node.Expanded;
            }
        }

        private void AttachEvents()
        {
            _repository.FolderAdded += RepositoryFolderAdded;
            _repository.FolderRemoved += RepositoryFolderRemoved;
            _repository.ConnectionAdded += RepositoryConnectionAdded;
            _repository.ConnectionRemoved += RepositoryConnectionRemoved;
            _repository.TmsProviders.ItemAdded += OnTmsProviderAdded;
            _repository.TmsProviders.ItemRemoved += OnTmsProviderRemoved;
            _repository.TmsProviders.ItemsCleared += TmsProvidersCleared;
        }

        private void PopulateTree()
        {
            PopulateDatabases();

            PopulateTms();

            PopulateFileSystem();

            if (Nodes.Count > 0)
            {
                SelectedNode = Nodes[0];
            }
        }

        private void PopulateTms()
        {
            var root = Items.AddItem(RepositoryItemType.TmsRoot);

            foreach (var g in _repository.TmsGroups)
            {
                bool expanded = g.Expanded;

                var groupItem = root.SubItems.AddGroup(g);

                if (expanded)
                {
                    groupItem.Expand();
                }
            }

            var group = GetGroup(RepositoryItemType.TmsRoot, TmsProvider.DefaultGroupId);
            if (group != null)
            {
                foreach (var p in _repository.DefaultTmsProviders)
                {
                    group.SubItems.AddTmsProvider(p);
                }
            }

            group = GetGroup(RepositoryItemType.TmsRoot, TmsProvider.CustomGroupId);
            if (group != null)
            {
                foreach (var item in _repository.TmsProviders)
                {
                    group.SubItems.AddTmsProvider(item);
                }
            }

            root.Expand();
        }

        private void PopulateFileSystem()
        {
            // file system
            var folders = Items.AddItem(RepositoryItemType.FileSystem);
            
            foreach (var path in _repository.Folders)
            {
                folders.SubItems.AddFolder(path, true);
            }

            folders.Expand();

             _expandedFolders = new HashSet<string>(_repository.ExpandedFolders.Select(f => f.ToLower()));

            RestoreFoldersExpandedState(folders);
        }

        private void RestoreFoldersExpandedState(IRepositoryItem root)
        {
            foreach (var f in root.SubItems.OfType<IFolderItem>())
            {
                if (_expandedFolders.Contains(f.GetPath().ToLower()))
                {
                    f.ForceExpand();

                    RestoreFoldersExpandedState(f);
                }
            }
        }

        private void PopulateDatabases()
        {
            // databases
            var dbs = Items.AddItem(RepositoryItemType.Databases);

            var dict = new Dictionary<GeoDatabaseType, IServerItem>();
            var values = Enum.GetValues(typeof(GeoDatabaseType));

            foreach (GeoDatabaseType value in values)
            {
                var item = dbs.SubItems.AddServer(value);
                dict.Add(value, item);
            }

            foreach (var cn in _repository.Connections)
            {
                var server = dict[cn.DatabaseType];
                server.SubItems.AddDatabase(cn);
            }

            dbs.Expand();

            foreach (var item in dbs.SubItems)
            {
                item.Expand();
            }
        }

        private void OnTmsProviderAdded(object sender, RepositoryListEventArgs<TmsProvider> e)
        {
            var group = GetGroup(RepositoryItemType.TmsRoot, TmsProvider.CustomGroupId);
            if (group != null)
            {
                group.SubItems.AddTmsProvider(e.Item);
            }
        }

        private void TmsProvidersCleared(object sender, EventArgs e)
        {
            var root = GetGroup(RepositoryItemType.TmsRoot, TmsProvider.CustomGroupId);
            if (root != null)
            {
                root.SubItems.Clear();
            }
        }

        private void OnTmsProviderRemoved(object sender, RepositoryListEventArgs<TmsProvider> e)
        {
            var root = GetGroup(RepositoryItemType.TmsRoot, TmsProvider.CustomGroupId);
            if (root != null)
            {
                var item = root.SubItems.OfType<ITmsItem>().FirstOrDefault(tms => tms.Provider == e.Item);
                if (item != null)
                {
                    root.SubItems.Remove(item);
                }
            }
        }

        private void RepositoryConnectionRemoved(object sender, ConnectionEventArgs e)
        {
            var item = GetServer(e.Connection.DatabaseType);
            var databaseItem = item.SubItems.OfType<IDatabaseItem>().FirstOrDefault(db => db.Connection == e.Connection);
            item.SubItems.Remove(databaseItem);
        }

        private void RepositoryConnectionAdded(object sender, ConnectionEventArgs e)
        {
            var item = GetServer(e.Connection.DatabaseType);
            item.SubItems.AddDatabase(e.Connection);
        }

        private void RepositoryFolderRemoved(object sender, FolderEventArgs e)
        {
            var item = GetSpecialItem(RepositoryItemType.FileSystem);
            var folder = item.SubItems.OfType<IFolderItem>().FirstOrDefault(f => f.GetPath().EqualsIgnoreCase(e.Path));
            if (folder != null)
            {
                item.SubItems.Remove(folder);
            }
        }

        private void RepositoryFolderAdded(object sender, FolderEventArgs e)
        {
            var item = GetSpecialItem(RepositoryItemType.FileSystem);
            item.SubItems.AddFolder(e.Path, true);
        }

        public event EventHandler<RepositoryEventArgs> ItemSelected;

        protected override IEnumerable<Bitmap> OnCreateImageList()
        {
            return new[]
            {
                Resources.img_hard_disk,
                Resources.img_folder_open,
                Resources.img_point,
                Resources.img_line,
                Resources.img_polygon,
                Resources.img_geometry,
                Resources.img_databases_16,
                Resources.img_database_16,
                Resources.img_postgis_16,
                Resources.img_raster,
                Resources.img_mssql16,
                Resources.img_sqlite16,
                Resources.img_oracle16,
                Resources.img_mysql16,
                Resources.img_tms16,
                Resources.img_map16,
                Resources.img_layer_stack16
            };
        }

        public RepositoryItemCollection Items
        {
            get { return new RepositoryItemCollection(Nodes); }
        }

        public IRepositoryItem GetServer(GeoDatabaseType databaseType)
        {
            var item = GetSpecialItem(RepositoryItemType.Databases);
            return item.SubItems.OfType<IServerItem>().FirstOrDefault(db => db.DatabaseType == databaseType);
        }

        public IGroupItem GetGroup(RepositoryItemType rootType, Guid groupId)
        {
            var root = GetSpecialItem(rootType);
            if (root == null) return null;
            return root.SubItems.OfType<IGroupItem>().FirstOrDefault(g => g.Group.Guid == groupId);
        }

        public IRepositoryItem GetSpecialItem(RepositoryItemType type)
        {
            var root = Items.FirstOrDefault(item => item.Type == type);
            
            if (root != null)
            {
                return root;
            }

            // let's seek the second level as well; currently we don't need a full blown recursion here
            foreach (var item in Items)
            {
                root = item.SubItems.FirstOrDefault(subItem => subItem.Type == type);
                if (root != null)
                {
                    return root;
                }
            }

            return null;
        }

        public IRepositoryItem SelectedItem
        {
            get
            {
                if (SelectedNode == null)
                {
                    return null;
                }

                return RepositoryItem.Get(SelectedNode);
            }
        }

        private void RepositoryTreeView_AfterSelect(object sender, EventArgs e)
        {
            FireItemSelected(SelectedNode);
        }

        private void TreeViewBeforeExpand(object sender, TreeViewAdvCancelableNodeEventArgs e)
        {
            var item = RepositoryItem.Get(e.Node);

            if (item.Type == RepositoryItemType.Folder || item.Type == RepositoryItemType.Database)
            {
                item.Expand();
            }
        }

        private void FireItemSelected(TreeNodeAdv node)
        {
            var handler = ItemSelected;
            if (handler != null)
            {
                var item = RepositoryItem.Get(node);
                handler(this, new RepositoryEventArgs(item));
            }
        }

        private void RepositoryTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var arr = e.Item as TreeNodeAdv[];
            if (arr == null || arr.Length == 0)
            {
                return;
            }

            var vectorItem = RepositoryItem.Get(arr[0]) as IFileItem;
            if (vectorItem != null)
            {
                DoDragDrop(vectorItem.Filename, DragDropEffects.Copy);
            }

            var layerItem = RepositoryItem.Get(arr[0]) as IDatabaseLayerItem;
            if (layerItem != null)
            {
                DoDragDrop(layerItem.Identity.Serialize(), DragDropEffects.Copy);
            }

            var tmsItem = RepositoryItem.Get(arr[0]) as ITmsItem;
            if (tmsItem != null)
            {
                DoDragDrop(tmsItem.Serialize(), DragDropEffects.Copy);
            }
        }

        public void UpdateTmsState(int providerId)
        {
            var root = GetSpecialItem(RepositoryItemType.TmsRoot);

            foreach (var group in root.SubItems)
            {
                foreach(var p in group.SubItems.OfType<ITmsItem>())
                {
                    p.Active = p.Provider.Id == providerId;
                }
            }
        }

        public void UpdateState(HashSet<LayerIdentity> layers)
        {
            _layers = layers;

            var fs = GetSpecialItem(RepositoryItemType.FileSystem);
            if (fs != null)
            {
                fs.SubItems.UpdateState(layers);
            }

            var root = GetSpecialItem(RepositoryItemType.Databases);
            if (root != null)
            {
                foreach (var server in root.SubItems)
                {
                    server.SubItems.UpdateState(layers);
                }
            }
        }

        public void UpdateState(IRepositoryItem item)
        {
            if (item != null && _layers != null)
            {
                item.SubItems.UpdateState(_layers);
            }
        }

        private void RepositoryTreeView_AfterExpand(object sender, TreeViewAdvNodeEventArgs e)
        {
            var item = RepositoryItem.Get(e.Node);
            UpdateState(item);

            SaveExpandedState(e.Node);
        }
    }
}
