﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace VastGIS.UI.Menu
{
    internal class MenuItemCollection : ItemCollectionBase
    {
        private const int TOOLBAR_ITEM_PADDING_X = 10;
        private const int TOOLBAR_ITEM_PADDING_Y = 5;
        private new readonly BarItems _items;

        internal MenuItemCollection(BarItems items, IMenuIndex menuIndex):
            base(items, menuIndex)
        {
            _items = items;
            if (items == null)
            {
                throw new NullReferenceException("Bar items reference is null.");
            }
        }

        public override IMenuItem this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                {
                    return null;
                }

                var item = _items[index];
                if (item is ParentBarItem)
                {
                    return new DropDownMenuItem(item as ParentBarItem, MenuIndex);
                }

                if (item is ComboBoxBarItem)
                {
                    return new ComboBoxMenuItem(item as ComboBoxBarItem);
                }

                return new MenuItem(item);
            }
        }

        public override IComboBoxMenuItem AddComboBox(string text, string key, PluginIdentity identity)
        {
            var item = new ComboBoxBarItem() { Padding = new Point(TOOLBAR_ITEM_PADDING_X, TOOLBAR_ITEM_PADDING_Y) };
            var menuItem = AddItem(item, identity, key) as IComboBoxMenuItem;

            if (menuItem != null)
            {
                menuItem.Text = text;
            }

            return menuItem;
        }

        public override IMenuItem AddLabel(string text, string key, PluginIdentity identity)
        {
            var item = new StaticBarItem(text) { Padding = new Point(TOOLBAR_ITEM_PADDING_X, TOOLBAR_ITEM_PADDING_Y) };
            var menuItem = AddItem(item, identity, key);
            return menuItem;
        }

        public override IMenuItem AddButton(string text, string key, Bitmap icon, PluginIdentity pluginIdentity)
        {
            var item = new BarItem(text) {Padding = new Point(TOOLBAR_ITEM_PADDING_X, TOOLBAR_ITEM_PADDING_Y)};
            var menuItem = AddItem(item, pluginIdentity, key);
            MenuIcon.AssignIcon(menuItem, icon);
            return menuItem;
        }

        protected override IDropDownMenuItem AddDropDown(string text, string key, Bitmap icon, PluginIdentity identity)
        {
            var item = new ParentBarItem(text) { Padding = new Point(TOOLBAR_ITEM_PADDING_X, TOOLBAR_ITEM_PADDING_Y) }; ;
            var menuItem = AddItem(item, identity, key) as IDropDownMenuItem;
            MenuIcon.AssignIcon(menuItem, icon);
            return menuItem;
        }

        protected IMenuItem AddItem(BarItem item, PluginIdentity identity, string key)
        {
            item.Tag = new MenuItemMetadata(identity, key);
            return AddItemCore(item, key, false, false);
        }
    }
}
