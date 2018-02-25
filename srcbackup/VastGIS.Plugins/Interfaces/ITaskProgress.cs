using System;
using VastGIS.Plugins.Events;

namespace VastGIS.Plugins.Interfaces
{
    public interface ITaskProgress
    {
        void Update(string msg, int value);

        void TryUpdate(string msg, int step, int total, ref int lastPercent);

        void Clear();

        event EventHandler<ProgressEventArgs> ProgressChanged;

        event EventHandler Hide;
    }
}
