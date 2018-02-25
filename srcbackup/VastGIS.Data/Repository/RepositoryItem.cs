﻿using System;
using System.Windows.Forms;
using VastGIS.Data.Enums;
using VastGIS.Data.Properties;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Data.Repository
{
    internal class RepositoryItem: IRepositoryItem
    {
        protected readonly TreeNodeAdv _node;

        internal RepositoryItem(TreeNodeAdv node)
        {
            if (node == null) throw new ArgumentNullException("node");
            _node = node;
        }

        public IRepositoryItem Parent
        {
            get { return Get(_node.Parent); }
        }

        public string DisplayName
        {
            get { return _node.Text; }
        }

        public RepositoryItemType Type
        {
            get { return (RepositoryItemType)_node.Tag; }
        }

        public RepositoryItemCollection SubItems
        {
            get { return new RepositoryItemCollection(_node.Nodes); }
        }

        public object GetInternalObject()
        {
            return _node;
        }

        public virtual void Expand()
        {
            _node.Expanded = true;
        }

        public static void ShowLoadingIndicator(TreeNodeAdv node)
        {
            var pct = new PictureBox { Image = Resources.anim_loading, SizeMode = PictureBoxSizeMode.AutoSize };
            node.CustomControl = pct;
        }

        public static void HideLoadingIndicator(TreeNodeAdv node)
        {
            node.CustomControl = null;
        }

        public static IRepositoryItem Get(TreeNodeAdv node)
        {
            var type = (RepositoryItemType) node.Tag;

            switch (type)
            {
                case RepositoryItemType.Group:
                    return new GroupItem(node);
                case RepositoryItemType.FileSystem:
                case RepositoryItemType.Databases:
                case RepositoryItemType.TmsRoot:
                    return new RepositoryItem(node);
                case RepositoryItemType.Server:
                    return new ServerItem(node);
                case RepositoryItemType.Folder:
                    return new FolderItem(node);
                case RepositoryItemType.Vector:
                case RepositoryItemType.Image:
                    return new FileItem(node);
                case RepositoryItemType.Database:
                    return new DatabaseItem(node);
                case RepositoryItemType.DatabaseLayer:
                    return new DatabaseLayerItem(node);
                case RepositoryItemType.TmsSource:
                    return new TmsItem(node);
            }

            throw new ApplicationException("Invalid repository item type.");
        }

        public void Refresh()
        {
            _node.ExpandedOnce = false;

            _node.Nodes.Clear();

            Expand();
        }

        public bool Loaded
        {
            get { return _node.ExpandedOnce; }
        }
    }
}
