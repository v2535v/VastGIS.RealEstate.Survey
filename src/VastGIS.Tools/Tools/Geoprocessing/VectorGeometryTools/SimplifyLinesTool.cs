using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Geoprocessing)]
    public class SimplifyLinesTool: GisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Input("Tolerance", 1)]
        public Distance Tolerance { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_simplify.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<SimplifyLinesTool>()
                .SetDefault(t => t.Tolerance, 0.1);     // km
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Simplify lines"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Simplifies polylines by removing excessive vertices based on the given tolerance."; }
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
            if (Input.Datasource.GeometryType != GeometryType.Polyline &&
                Input.Datasource.GeometryType != GeometryType.Polygon)
            {
                MessageService.Current.Info("The tool works for polyline or polygon datasources only.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var units = Input.Datasource.GetLengthUnits();
            double tolerance = UnitConversionHelper.Convert(Tolerance.Units, units, Tolerance.Value);

            Log.Info("Tolerance in datasource units: {0} {1}", tolerance, units.EnumToString());

            var fs = Input.Datasource.SimplifyLines(tolerance, Input.SelectedOnly);

            Output.Result = fs;

            return true;
        }
    }
}
