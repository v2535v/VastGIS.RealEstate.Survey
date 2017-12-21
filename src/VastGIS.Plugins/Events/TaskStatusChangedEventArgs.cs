using System;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class TaskStatusChangedEventArgs: EventArgs
    {
        public TaskStatusChangedEventArgs(IGisTask task)
        {
            if (task == null) throw new ArgumentNullException("task");
            Task = task;
        }

        public IGisTask Task { get; private set; }
    }
}
