﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AggregateShapesTool.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   Defines the AggregateShapes tool.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using VastGIS.Api.Concrete;
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
    [GisTool(GroupKeys.Attributes, ToolIcon.Hammer)]
    public class AggregateShapesTool : GisTool
    {
        [Input("Input layer", 0)]
        public IVectorInput InputLayer { get; set; }

        [Input("Field", 1, false)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndex { get; set; }

        [Input("Group operations", 0, true)]
        public FieldOperationList GroupOperations { get; set; }

        [Output("Save results as")]
        [OutputLayer(@"{input}_aggregate.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<AggregateShapesTool>()
                .AddField(t => t.InputLayer, t => t.FieldIndex)
                .AddField(t => t.InputLayer, t => t.GroupOperations);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Aggregate shapes by attribute"; }
        }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Creates a new shapefile by creating multi-part shapes from shapes with the same value of specified attribute."; }
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
            return GroupOperations.ValidateWithMessage(InputLayer.Datasource);
        }

        /// <summary>
        /// Provide execution logic for the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            Log.Info("Number of group operations specified: " + GroupOperations.Count);

            Output.Result = InputLayer.Datasource.AggregateShapesWithStats(InputLayer.SelectedOnly, FieldIndex, GroupOperations);
            return true;
        }
    }
}