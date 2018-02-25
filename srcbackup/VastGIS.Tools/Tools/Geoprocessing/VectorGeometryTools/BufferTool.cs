﻿// -------------------------------------------------------------------------------------------
// <copyright file="BufferTool.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Services;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [CustomLayout]
    [GisTool(GroupKeys.Geoprocessing, ToolIcon.Hammer)]
    public class BufferTool : AppendModeGisTool
    {
        [Input("Buffer distance", 1)]
        public Distance BufferDistance { get; set; }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Builds a buffer around features of input vector layer."; }
        }

        [Input("Input layer", 0)]
        public IVectorInput Input { get; set; }

        [Input("Merge results", 2)]
        public bool MergeResults { get; set; }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Buffer by distance"; }
        }

        [Input("Number of segments", 0, true)]
        public int NumSegments { get; set; }

        [Output("Save results as")]
        [OutputLayer("{input}_buffer.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Provide execution logic for the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var units = Input.Datasource.GetLengthUnits();

            double bufferDistance = UnitConversionHelper.Convert(BufferDistance.Units, units, BufferDistance.Value);

            bool success = false;

            if (Output.MemoryLayer)
            {
                Output.Result = Input.Datasource.BufferByDistance(bufferDistance, NumSegments, Input.SelectedOnly,
                    MergeResults);
            }
            else
            {
                success = GisUtils.Instance.BufferByDistance(Input.Datasource, Input.SelectedOnly, bufferDistance,
                    NumSegments, MergeResults, Output.Filename, Output.Overwrite);
            }

            return Output.Result != null || success;
        }

        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<BufferTool>().SetDefault(t => t.BufferDistance, 50).SetDefault(t => t.NumSegments, 30);
        }
    }
}