using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tools.Services
{
    internal class EmptyProgress: ITaskProgress
    {
        public void Update(string msg, int value)
        {
            // do nothing
        }

        public void TryUpdate(string msg, int step, int total, ref int lastPercent)
        {
            // do nothing
        }

        public void Clear()
        {
            // do nothing
        }

        public event EventHandler<ProgressEventArgs> ProgressChanged;

        public event EventHandler Hide;
    }
}
