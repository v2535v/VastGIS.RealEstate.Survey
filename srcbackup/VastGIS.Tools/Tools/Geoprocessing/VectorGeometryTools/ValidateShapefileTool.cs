﻿using System.Collections.Generic;
using System.Linq;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [CustomLayout]
    [GisTool(GroupKeys.Validation)]
    public class ValidateShapefileTool: GisTool
    {
        private int _errorCount;

        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Output("Output layer")]
        [OutputLayer("{input}_errors.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        [Output("Create output shapefile with errors", 1)]
        public bool CreateOutput { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<ValidateShapefileTool>()
                .SetDefault(t => t.CreateOutput, true);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Validate shapefile"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Validates vector layer. " + 
                "Adds icons to the map marking the location of validation errors.";
            }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public override bool SupportsCancel
        {
            get  { return true; }
        }

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName
        {
            get { return "Validating [" + Input.Name + "]: " + (_errorCount == 0 ? "no errors" : _errorCount + " errors"); }
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var errors = GetErrors(Input.Datasource, task).ToList();

            _errorCount = errors.Count;

            if (CreateOutput && errors.Any())
            {
                CreateOutputDatasource(errors);

                Log.Info("------------------------");
                Log.Info("Number of invalid geometries: " + errors.Count);
            }

            if (!errors.Any())
            {
                Log.Info("No invalid geometries were found.");
            }

            return true;            
        }

        /// <summary>
        /// Validates shapes and returns list of errors.
        /// </summary>
        private IEnumerable<ErrorInfo> GetErrors(IFeatureSet fs, ITaskHandle task)
        {
            int lastPercent = 0;

            for (int i = 0; i < fs.NumFeatures; i++)
            {
                task.CheckPauseAndCancel();
                task.Progress.TryUpdate("Calculating...", i, fs.NumFeatures, ref lastPercent);

                var gm = fs.Features[i].Geometry;
                if (!gm.IsValid)
                {
                    var info = ValidationHelper.GetErrorInfo(fs, i, gm.IsValidReason);

                    Log.Info(info.Message);

                    yield return info;
                }
            }

            task.Progress.Clear();
        }

        /// <summary>
        /// Creates the output datasource.
        /// </summary>
        private void CreateOutputDatasource(IEnumerable<ErrorInfo> errors)
        {
            var fs = ValidationHelper.CreateErrorFeatureSet(Input.Datasource);

            foreach (var err in errors.Where(e => e.Location != null))
            {
                var gm = new Geometry(GeometryType.Point);
                gm.Points.Add(err.Location);

                var index = fs.Features.EditAdd(gm);
                if (index != -1)
                {
                    // MWShapeId has 0 index
                    fs.Table.EditCellValue(1, index, (int)err.ErrorType);
                    fs.Table.EditCellValue(2, index, err.Message);
                }
            }

            fs.Categories.ApplyExpressions();
            fs.RemoveUnusedCategories();

            Output.Result = fs;
        }

        /// <summary>
        /// Saves the output.
        /// </summary>
        public override bool AfterRun()
        {
            if (Output.Result != null)
            {
                if (!OutputManager.Save(Output.Result, Output))
                {
                    Log.Error("Failed to save output: {0}", null, Output.Filename);
                }    

                // false since there are invalid shapes, i.e. validation failed
                return false;
            }
            
            return true;
        }
    }
}
