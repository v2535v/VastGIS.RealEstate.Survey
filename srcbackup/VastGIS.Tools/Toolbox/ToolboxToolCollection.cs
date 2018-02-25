﻿// -------------------------------------------------------------------------------------------
// <copyright file="ToolboxToolCollection.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using Syncfusion.Windows.Forms.Tools;

namespace VastGIS.Tools.Toolbox
{
    /// <summary>
    /// Represents collection of tree nodes with tools.
    /// </summary>
    internal class ToolboxToolCollection : IToolCollection
    {
        private readonly TreeNodeAdvCollection _nodes;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolboxToolCollection"/> class.
        /// </summary>
        internal ToolboxToolCollection(TreeNodeAdvCollection nodes)
        {
            if (nodes == null) throw new NullReferenceException();

            _nodes = nodes;
        }

        /// <summary>
        /// Returns the number of groups in the list.
        /// </summary>
        public int Count
        {
            get { return _nodes.Cast<TreeNode>().Count(node => (node.Tag is ITool)); }
        }

        /// <summary>
        /// Adds new tool to the group
        /// </summary>
        public void Add(ITool item)
        {
            if (item == null) throw new ArgumentNullException("item");

            var node = new TreeNodeAdv
            {
                Tag = item,
                Text = item.Name,
                LeftImageIndices = new[] { GetIconIndex(item) }
            };

            // let's insert it in alphabetical order
            foreach (var tool in this)
            {
                if (String.CompareOrdinal(tool.Tool.Name, item.Name) > 0)
                {
                    int index = _nodes.IndexOf(tool.InternalObject);
                    _nodes.Insert(index, node);
                    return;
                }
            }

            _nodes.Add(node);
        }

        private int GetIconIndex(ITool tool)
        {
            var attr = AttributeHelper.GetAttribute<GisToolAttribute>(tool.GetType());
            return attr != null ? (int)attr.Icon : (int)ToolIcon.ToolDefault;
        }

        /// <summary>
        /// Clears all the groups
        /// </summary>
        public void Clear()
        {
            for (var i = _nodes.Count - 1; i >= 0; i++)
            {
                var tool = GetTool(_nodes[i]);
                if (tool != null)
                {
                    _nodes.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        public IEnumerator<IToolBoxToolItem> GetEnumerator()
        {
            for (var i = 0; i < _nodes.Count; i++)
            {
                if (_nodes[i].Tag is ITool)
                {
                    yield return new ToolBoxToolItem(_nodes[i]);
                }
            }
        }

        /// <summary>
        /// Removes group at specified position
        /// </summary>
        public bool Remove(ITool item)
        {
            foreach (var node in _nodes.Cast<TreeNodeAdv>().Where(node => GetTool(node) == item))
            {
                _nodes.Remove(node);
                return true;
            }

            return false;
        }

        /// <summary>
        /// The remove items for plugin.
        /// </summary>
        public void RemoveItemsForPlugin(PluginIdentity identity)
        {
            for (var i = _nodes.Count - 1; i >= 0; i--)
            {
                var tool = GetTool(_nodes[i]);
                if (tool != null && tool.PluginIdentity == identity)
                {
                    _nodes.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// The get enumerator.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private ITool GetTool(TreeNodeAdv node)
        {
            return node.Tag as ITool;
        }
    }
}