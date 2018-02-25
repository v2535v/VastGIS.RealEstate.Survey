﻿using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Services;

namespace VastGIS.Tools.Tools.Attributes
{
    [CustomLayout]
    [GisTool(GroupKeys.Attributes)]
    public class DissolveTool: GisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Input("Field index", 1)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndex { get; set; }

        [Input("Group operations", 2, true)]
        public FieldOperationList GroupOperations { get; set; }

        [Output("Save results as")]
        [OutputLayer(@"{input}_dissolve.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<DissolveTool>()
                .AddField(t => t.Input, t => t.FieldIndex)
                .AddField(t => t.Input, t => t.GroupOperations);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Dissolve by attribute"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Merges together vector features which have the same value of a given field."; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets a value indicating whether the tool supports batch execution.
        /// </summary>
        public override bool SupportsBatchExecution
        {
            get { return false; }
        }

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        /// <returns></returns>
        protected override bool BeforeRun()
        {
            return GroupOperations.ValidateWithMessage(Input.Datasource);
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            Log.Info("Number of group operations specified: " + GroupOperations.Count);

            Output.Result = Input.Datasource.DissolveWithStats(FieldIndex, Input.SelectedOnly, GroupOperations);
            return true;
        }
    }
}
