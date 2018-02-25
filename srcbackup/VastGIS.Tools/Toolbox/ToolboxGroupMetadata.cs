﻿// -------------------------------------------------------------------------------------------
// <copyright file="ToolboxGroupMetadata.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Tools.Toolbox
{
    internal class ToolboxGroupMetadata
    {
        public ToolboxGroupMetadata(string key, string name, PluginIdentity identity)
        {
            if (identity == null) throw new ArgumentNullException("identity");
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");

            PluginIdentity = identity;
            Key = key;
            Name = name;
        }

        public string Description { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public object Tag { get; set; }

        public PluginIdentity PluginIdentity { get; set; }
    }
}