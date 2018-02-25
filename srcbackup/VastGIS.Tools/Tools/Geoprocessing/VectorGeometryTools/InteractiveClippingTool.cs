using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Geoprocessing)]
    public class InteractiveClippingTool: GisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Input("Map extents", -1)]
        public IEnvelope Extents { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_clip.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Interactive clipping"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Clips input datasource with current map extents."; }
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
            Extents = Context.Map.Extents;
            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var g = Extents.ToGeometry();
            var fs = new FeatureSet(GeometryType.Polygon);
            fs.Features.EditAdd(g);

            var result = Input.Datasource.Clip(Input.SelectedOnly, fs, false);

            if (result != null)
            {
                Log.Info("Number of output features: " + result.NumFeatures);
            }

            Output.Result = result;
            return true;
        }
    }
}
