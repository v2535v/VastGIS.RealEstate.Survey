﻿// -------------------------------------------------------------------------------------------
// <copyright file="ToolPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Model.Parameters;
using VastGIS.Tools.Model.Parameters.Layers;
using VastGIS.Tools.Views.Abstract;

namespace VastGIS.Tools.Views
{
    /// <summary>
    /// The gis tool presenter.
    /// </summary>
    public class ToolPresenter : BasePresenter<IToolView, ToolViewModel>
    {
        private readonly IAppContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPresenter"/> class.
        /// </summary>
        public ToolPresenter(IToolView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        protected override void Initialize()
        {
            // old values will be set to BaseParameter.PreviousValue
            Model.Tool.RestoreConfig();

            View.GenerateControls();
        }

        /// <summary>
        /// A handler for the IView.OkButton.Click event.
        /// If the method returns true, View will be closed and presenter.ReturnValue set to true.
        /// If the method return false, no actions are taken, so View.Close, presenter.ReturnValue
        /// should be called / set manually.
        /// </summary>
        /// <returns></returns>
        public override bool ViewOkClicked()
        {
            Model.Tool.SaveConfig();

            if (Model.BatchMode)
            {
                return RunBatch();
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                if (RunSingle())
                {
                    MessageService.Current.Info("Task execution has started. You can now run another task now.");
                }

                return false;
            }
            
            return RunSingleAndClose();
        }

        /// <summary>
        /// Creates and runs task for a single input datasource. Keeps the dialog open.
        /// </summary>
        /// <returns></returns>
        private bool RunSingle()
        {
            // we need a copy of tool here, since we don't want to share the instance
            // between different running tasks
            var newTool = (Model.Tool as IParametrizedTool).Clone(_context) as IGisTool;

            if (!Validate(newTool))
            {
                return false;
            }

            RunBatchTask(newTool);

            return true;
        }

        /// <summary>
        /// Creates and runs task for a single input datasource. Closes dialog after it.
        /// </summary>
        private bool RunSingleAndClose()
        {
            if (!Validate(Model.Tool))
            {
                return false;
            }

            IGisTask task = Model.CreateTask();

            if (View.RunInBackground)
            {
                // no progress / log dialog will be shown, so start tracking at once
                _context.Tasks.Add(task);
            }

            task.RunAsync();

            // on success a log window will be opened immediately
            ReturnValue = !View.RunInBackground;

            View.Close();

            return false;
        }

        /// <summary>
        /// Validates parameters and detaches controls from them on the success.
        /// </summary>
        private bool Validate(IGisTool tool)
        {
            if (!tool.Validate())
            {
                return false;
            }

            var pt = tool as IParametrizedTool;
            if (pt != null)
            {
                pt.Parameters.DetachControls();
            }

            return true;
        }

        /// <summary>
        /// Creates and runs separated tasks for a number of input datasources.
        /// </summary>
        private bool RunBatch()
        {
            var tool = Model.Tool as IParametrizedTool;
            if (tool == null)
            {
                throw new InvalidCastException("GIS tool implementing IParametrizedTool interface is expected");
            }

            if (!tool.CheckMemoryLayersHaveName())
            {
                return false;
            }

            var tools = GenerateBatchTools(tool);
            if (tools == null)
            {
                return false;
            }

            if (Model.Tool.SequentialBatchExecution)
            {
                var tasks = BatchExecutionHelper.CreateSequentialTasks(tools).Reverse().ToList();

                foreach (var t in tasks)
                {
                    _context.Tasks.Add(t);
                }

                var task = tasks.FirstOrDefault();

                task.RunAsync();
            }
            else
            {
                foreach (var newTool in tools)
                {
                    RunBatchTask(newTool);
                }
            }

            ReturnValue = false;

            View.Close();

            return false;
        }

        /// <summary>
        /// Generates a new instance of tool for each of the inputs. Validates every new instance.
        /// </summary>
        private IEnumerable<IGisTool> GenerateBatchTools(IParametrizedTool tool)
        {
            var tools = tool.GenerateBatchTools(_context);

            if (!tools.All(Validate))
            {
                return null;
            }

            return tools;
        }

        /// <summary>
        /// Creates and starts task for one of the batch inputs.
        /// </summary>
        private void RunBatchTask(IGisTool tool)
        {
            var task = new GisTask(tool);

            _context.Tasks.Add(task);
            
            task.RunAsync();
        }

    }
}