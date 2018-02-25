﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;

namespace VastGIS.Plugins.Interfaces
{
    public interface IToolbar
    {
        string Name { get; set; }
        IMenuItemCollection Items { get; }
        bool Visible { get; set; }
        object Tag { get; set; }
        string Key { get; }
        ToolbarDockState DockState { get; set; }
        PluginIdentity PluginIdentity { get; }
        bool Enabled { get; set; }
        void Update();
        void Refresh();
    }
}
