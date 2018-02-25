using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Basic)]
    public class SortShapefileTool: GisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Input("Field index", 1)]
        [ControlHint(ControlHint.Field)]
        public int FieldIndex { get; set; }

        [Input("Ascending", 2)]
        public bool Ascending { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_sort.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<SortShapefileTool>()
                .AddField(t => t.Input, t => t.FieldIndex)
                .SetDefault(t => t.Ascending, true);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Sort shapefile"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Sorts shapefile by the given attribute, physically changing the order of records."; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            Output.Result = Input.Datasource.Sort(FieldIndex, Ascending);
            return true;
        }
    }
}
