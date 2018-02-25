using System;
using System.Collections.Generic;
using VastGIS.Shared.Log;

namespace VastGIS.Plugins.Interfaces
{
    public interface IToolLogger
    {
        void Info(string msg, params object[] param);

        void Debug(string msg, params object[] param);

        void Warn(string msg, Exception ex, params object[] param);

        void Error(string msg, Exception ex, params object[] param);

        void Fatal(string msg, Exception ex, params object[] param);

        void Write(string msg, VastGIS.Shared.LogLevel level, params object[] param);

        event EventHandler<LogEventArgs> EntryAdded;

        void Lock();

        void UnLock();

        IEnumerable<ILogEntry> Entries { get; }
    }
}
