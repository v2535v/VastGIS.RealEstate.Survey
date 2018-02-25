﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    public interface IToolbarCollectionBase : IEnumerable<IToolbar>
    {
        IToolbar Add(string name, PluginIdentity identity);

        IToolbar Add(string name, string key, PluginIdentity identity);
        
        void Remove(int toolbarIndex);

        IToolbar this[int toolbarIndex] { get; }

        IMenuItem FindItem(string key, PluginIdentity identity);

        void RemoveItemsForPlugin(PluginIdentity identity);

        IEnumerable<IMenuItem> ItemsForPlugin(PluginIdentity identity);

        
    }
}
