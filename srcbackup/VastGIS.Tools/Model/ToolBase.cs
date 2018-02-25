﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tools.Model
{
    /// <summary>
    /// A base class for custom tools which don't task support and automatic UI generation.
    /// </summary>
    public abstract class ToolBase: ITool
    {
        protected IAppContext _context;

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public abstract string Name { get;  }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public abstract bool Run();

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public abstract PluginIdentity PluginIdentity { get;  }

        /// <summary>
        /// Initializes the tool.
        /// </summary>
        public virtual void Initialize(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        /// <summary>
        /// Returns true if a tool can be executed asynchronously using tasks.
        /// </summary>
        public bool SupportsTasks
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public bool SupportsBatchExecution
        {
            get { return false; }
        }
    }
}
