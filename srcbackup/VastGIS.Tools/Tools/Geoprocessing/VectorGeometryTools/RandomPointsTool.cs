// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RandomPointsTool.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   Generates random points within extents of selected datasource.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;
using VastGIS.Tools.Services;
using System;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    /// <summary>
    /// Generates random points within extents of selected datasource.
    /// </summary>
    [CustomLayout]
    [GisTool(GroupKeys.Geoprocessing, ToolIcon.Hammer)]
    public class RandomPointsTool : GisTool
    {
        [Input("Layer for bounding box", 0)]
        public IDatasourceInput InputLayer { get; set; }

        [Input("Number of points", 1)]
        public int NumPoints { get; set; }

        [Output("New layer name")]
        [OutputLayer("{input}_random points.shp", LayerType.Shapefile)]
        public OutputLayerInfo OutputLayer { get; set; }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Gets description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Create a new shapefile with random points."; }
        }

        /// <summary>
        /// Gets name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Random points"; }
        }

        public override bool SupportsCancel
        {
            get  { return false; }
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        /// <returns>True on success, which closes the view</returns>
        public override bool Run(ITaskHandle task)
        {
            Log.Debug("Creating {0} random points", NumPoints);

            var extents = InputLayer.Datasource.Envelope;

            var fs = new FeatureSet(GeometryType.Point);
            fs.Projection.CopyFrom(InputLayer.Datasource.Projection);

            var vector = InputLayer as IVectorInput;
            if (vector != null && vector.SelectedOnly)
            {
                // Get the extent, taking into account selected shapes:
                extents = vector.Datasource.GetSelectedExtents();
            }

            var random = new Random();
            var lastPercent = 0;

            for (int i = 0; i < NumPoints; i++)
            {
                task.CheckPauseAndCancel();
                var x = extents.MinX + (extents.Width * random.NextDouble());
                var y = extents.MinY + (extents.Height * random.NextDouble());
                var feature = new Geometry(GeometryType.Point);
                feature.Points.Add(new Coordinate(x, y));
                fs.Features.EditAdd(feature);

                task.Progress.TryUpdate("Running...", i, NumPoints, ref lastPercent);
            }

            task.Progress.Clear();
            Log.Debug("New feature set has {0} features", fs.NumFeatures);
         
            OutputLayer.Result = fs;   

            return true;
        }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="configuration"></param>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<RandomPointsTool>()
                .SetDefault(t => t.NumPoints, 500)
                .SetRange(t => t.NumPoints, 1, 1000000);
        }
    }
}