﻿using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using VastGIS.Tools.Views.Custom;

namespace VastGIS.Tools.Tools.Fake
{
    #if DEBUG

    [GisTool(GroupKeys.Fake, ToolIcon.ToolDefault, typeof(LongExecutionPresenter))]

    #endif

    [CustomLayout]
    public class LongExecutionTool: GisTool
    {
        [Input("Seconds per step (100 steps)", 0), DefaultValue(0.1), Range(0.1, 5.0)]
        public double SecondsPerStep { get; set; }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Long task"; }
        }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Fakes the execution of the long task"; }
        }

        public override bool SupportsCancel
        {
            get  { return true; }
        }
        
        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public override bool Run(ITaskHandle task)
        {
            var span = TimeSpan.FromSeconds(SecondsPerStep);

            Log.Info(Name + ": start");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(span);

                int val = i;

                task.CheckPauseAndCancel();

                task.Progress.Update("Running...", val);

                Log.Info("Running: " + i);
            }

            task.Progress.Clear();

            Log.Info(Name + ": end");

            return true;   // depends on the run in background check
        }
    }
}
