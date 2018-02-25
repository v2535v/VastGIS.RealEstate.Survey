﻿using VastGIS.Api.Enums;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Validation)]
    public class FixShapefileTool : AppendModeGisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Output("Output layer")]
        [OutputLayer("{input}_fix.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Fix shapefile"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Creates a new shapefile by fixing invalid geometries of the current one."; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (!Input.Datasource.HasInvalidShapes())
            {
                MessageService.Current.Info("Input shapefile doesn't have invalid shapes.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            bool success;

            if (Output.MemoryLayer)
            {
                Output.Result = Input.Datasource.FixUpShapes(Input.SelectedOnly);
                success = true;
            }
            else
            {
                success = GisUtils.Instance.FixUpShapes(Input.Datasource, Input.SelectedOnly, Output.Filename, Output.Overwrite);
            }

            if (!success)
            {
                Log.Info("Failed to fix shapefile.");
            }

            return success;
        }
    }
}
