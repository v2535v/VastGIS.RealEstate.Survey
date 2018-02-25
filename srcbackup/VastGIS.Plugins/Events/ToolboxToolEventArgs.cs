using System;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class ToolboxToolEventArgs: EventArgs
    {
        public ToolboxToolEventArgs(ITool tool, bool batchMode = false)
        {
            if (tool == null) throw new ArgumentNullException("tool");
            Tool = tool;
        }

        public ITool Tool { get; private set; }

        public bool BatchMode { get; set; }
    }
}
