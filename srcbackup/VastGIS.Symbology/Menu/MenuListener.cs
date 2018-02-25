﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Symbology.Helpers;
using VastGIS.Plugins.Symbology.Services;
using VastGIS.UI.Menu;

namespace VastGIS.Plugins.Symbology.Menu
{
    internal class MenuListener : MenuServiceBase
    {
        public MenuListener(IAppContext context, SymbologyPlugin plugin)
            : base(context, plugin.Identity)
        {
            if (context.ViewType == MainViewType.Normal)
            {
                plugin.ItemClicked += PluginItemClicked;

                plugin.ViewUpdating += (s, e) => UpdateItems(true);

                _context.Menu.LayerMenu.DropDownOpening += MenuDropDownOpening;
            }
        }

        private void PluginItemClicked(object sender, MenuItemEventArgs e)
        {
            switch (e.ItemKey)
            {
                case MenuKeys.QueryBuilder:
                    FormHelper.ShowQueryBuilder(_context);
                    break;
                case MenuKeys.Categories:
                    FormHelper.ShowCategories(_context);
                    break;
                case MenuKeys.LabelMover:
                    _context.Map.CustomCursor = LabelMoverCursor.Instance;
                    break;
                case MenuKeys.Labels:
                    FormHelper.ShowLabels(_context);
                    break;
                case MenuKeys.Charts:
                    FormHelper.ShowCharts(_context);
                    break;
            }

            if (e.ItemKey == MenuKeys.LayerProperties)
            {
                FormHelper.ShowLayerProperties(_context);
            }
        }

        private void MenuDropDownOpening(object sender, EventArgs e)
        {
            UpdateItems(false);
        }

        public void OnPluginUnloaded()
        {
            var menu = _context.Menu.LayerMenu;

            menu.Update();

            menu.DropDownOpening -= MenuDropDownOpening;
        }

        private void UpdateItems(bool toolbar)
        {
            //var fs = _context.Map.SelectedFeatureSet;

            //FindItem(MenuKeys.QueryBuilder, toolbar).Enabled = fs != null;
            //FindItem(MenuKeys.Categories, toolbar).Enabled = fs != null;

            //if (toolbar)
            //{
            //    FindToolbarItem(MenuKeys.LabelMover).Checked = _context.Map.CustomCursor == LabelMoverCursor.Instance;
            //}
            //else
            //{
            //    FindMenuItem(MenuKeys.Labels).Enabled = fs != null;
            //    FindMenuItem(MenuKeys.Charts).Enabled = fs != null;
            //    FindMenuItem(MenuKeys.LayerProperties).Enabled = _context.Map.Layers.Current != null;
            //}
        }

        private IMenuItem FindItem(string key, bool toolbar)
        {
            Func<string, IMenuItem> fn = FindMenuItem;

            if (toolbar)
            {
                fn = FindToolbarItem;
            }

            return fn(key);
        }
    }
}
