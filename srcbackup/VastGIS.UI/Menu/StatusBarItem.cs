﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace VastGIS.UI.Menu
{
    internal class StatusBarItem: MenuItemBase, IMenuItem
    {
        private readonly ToolStripItem _item;

        public StatusBarItem(ToolStripItem item)
        {
            if (item == null) throw new ArgumentNullException("item");
            _item = item;
        }
        public string HeaderName { get; set; }
        public string ToolStripExName { get; set; }
        public string Text
        {
            get { return _item.Text; }
            set { _item.Text = value; }
        }

        public IMenuIcon Icon
        {
            get { return new MenuIcon(_item.Image); }
            set { _item.Image = value.Image; }
        }

        public string Category
        {
            get { return Metadata.Category; }
            set { Metadata.Category = value; }
        }

        public bool Checked
        {
            get
            {
                var item = _item as ToolStripMenuItem;
                if (item != null)
                {
                    return item.Checked;
                }
                return false;
            }
            set
            {
                var item = _item as ToolStripMenuItem;
                if (item != null)
                {
                    item.Checked = value;
                }
            }
        }

        public string Tooltip
        {
            get { return ""; }
            set { ; }
        }

        public bool Enabled
        {
            get { return _item.Enabled; }
            set { _item.Enabled = value; }
        }

        public override bool HasKey
        {
            get { return _item.Tag is MenuItemMetadata; }
        }

        protected override MenuItemMetadata Metadata
        {
            get
            {
                var data = _item.Tag as MenuItemMetadata;
                if (data == null)
                {
                    throw new ApplicationException("Tag property of menu items must store an instance of MenuItemMetadata class.");
                }
                return data;
            }
        }

        public bool Visible
        {
            get { return _item.Visible; }
            set { _item.Visible = value; }
        }

        protected virtual void DetachItemListeners()
        {
            EventHelper.RemoveEventHandler(_item, "Click");      // so it can be collected by GC
        }

        public object GetInternalObject()
        {
            return _item;
        }

        public virtual event EventHandler<MenuItemEventArgs> ItemClicked
        {
            add
            {
                _item.Click += (sender, args) => value.Invoke(this, new MenuItemEventArgs(Key, true));
            }
            remove
            {
                
            }
        }

        /// <summary>
        /// Gets a value indicating whether the item should be skipped during processing (e.g. separator).
        /// </summary>
        public bool Skip 
        {
            get { return false; } 
        }

        /// <summary>
        /// Gets or sets the shortcut keys.
        /// </summary>
        public Keys ShortcutKeys { get; set; }
    }
}
