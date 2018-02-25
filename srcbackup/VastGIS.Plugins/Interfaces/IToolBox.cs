﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;

namespace VastGIS.Plugins.Interfaces
{
    /// <summary>
    /// Methods and properties provided by MapWindow GIS toolbox.
    /// </summary>
    public interface IToolbox
    {
        /// <summary>
        /// List of groups provided by toolbox
        /// </summary>
        IToolboxGroups Groups { get; }

        /// <summary>
        /// Provides access to all tools as common list
        /// </summary>
        IToolCollection Tools { get; }

        /// <summary>
        /// Expands all the groups up to the target level
        /// </summary>
        void ExpandGroups(int level);

        /// <summary>
        /// Removes groups and tools added by specified plugin
        /// </summary>
        void RemoveItemsForPlugin(PluginIdentity identity);

        /// <summary>
        /// Adds tools to the toolbox choosing their groups based on GisToolAttribute.
        /// </summary>
        /// <param name="tools">The tools.</param>
        void AddTools(IEnumerable<ITool> tools);

        /// <summary>
        /// Opens dialog to set parameters and run the specified tool.
        /// </summary>
        void OpenToolDialog(ITool tool, bool batchMode);
    }
}


