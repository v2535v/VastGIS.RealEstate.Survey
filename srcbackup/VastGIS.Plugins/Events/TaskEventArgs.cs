using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Events
{
    public class TaskEventArgs: EventArgs
    {
        public TaskEventArgs(IGisTask task, TaskEvent taskEvent)
        {
            if (task == null) throw new ArgumentNullException("task");
            Task = task;
            Event = taskEvent;
        }

        public IGisTask Task { get; private set; }

        public TaskEvent Event { get; private set; }
    }
}
