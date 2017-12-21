using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;
using VastGIS.Services.Concrete;
using VastGIS.Shared;
using VastGIS.Shared.Log;

namespace VastGIS.Tools.Services
{
    public class ToolLogger : BaseLogger, IToolLogger
    {
        private readonly List<LogEntry> _entries = new List<LogEntry>();

        protected override void Log(string msg, LogLevel level, Exception ex = null)
        {
            var entry = new LogEntry(msg, level, ex);

            lock (_entries)
            {
                _entries.Add(entry);
                FireEntryAdded(entry);
            }
        }

        public event EventHandler<LogEventArgs> EntryAdded;

        public void Lock()
        {
            Monitor.Enter(_entries);
        }

        public void UnLock()
        {
            Monitor.Exit(_entries);
        }

        public IEnumerable<ILogEntry> Entries
        {
            get { return _entries; }
        }

        private void FireEntryAdded(LogEntry entry)
        {
            var handler = EntryAdded;
            if (handler != null)
            {
                handler(this, new LogEventArgs(entry));
            }
        }
    }
}
