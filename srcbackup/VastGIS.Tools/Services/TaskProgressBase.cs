﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tools.Services
{
    public abstract class TaskProgressBase : ITaskProgress
    {
        public abstract void Update(string msg, int value);

        public void TryUpdate(string msg, int step, int total, ref int lastPercent)
        {
            var percent = Convert.ToInt32(((double)(step + 1) / total) * 100.0);

            if (percent > lastPercent)
            {
                Update(msg, percent);
                lastPercent = percent;
            }
        }

        public abstract void Clear();

        public abstract event EventHandler<ProgressEventArgs> ProgressChanged;

        public abstract event EventHandler Hide;
    }
}
