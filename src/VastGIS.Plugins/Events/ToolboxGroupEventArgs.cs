using System;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class ToolboxGroupEventArgs : EventArgs
    {
        public ToolboxGroupEventArgs(IToolboxGroup group)
        {
            if (group == null) throw new ArgumentNullException("group");
            Group = group;
        }

        public IToolboxGroup Group { get; private set; }
    }
}
