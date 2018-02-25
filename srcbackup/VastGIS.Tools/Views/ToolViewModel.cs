﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Model;

namespace VastGIS.Tools.Views
{
    public class ToolViewModel
    {
        public ToolViewModel(IGisTool tool, bool batchMode = false)
        {
            if (tool == null) throw new ArgumentNullException("tool");
            Tool = tool;
            BatchMode = batchMode;
        }

        public bool BatchMode { get; private set; }

        public IGisTool Tool { get; private set; }

        public IGisTask Task { get; private set; }

        public IGisTask CreateTask()
        {
            Task = new GisTask(Tool);
            return Task;
        }
    }
}
