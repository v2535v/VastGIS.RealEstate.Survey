﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    public interface IStatusBar: IToolbar
    {
        void ShowProgress(string message, int percent);
        void HideProgress();
        IMenuItem FindItem(string key, PluginIdentity identity);
        bool AlignNewItemsRight { get; set; }
        new IStatusItemCollection Items { get; }
        void RemoveItemsForPlugin(PluginIdentity identity);
        void ShowInfo(string message);
    }
}
