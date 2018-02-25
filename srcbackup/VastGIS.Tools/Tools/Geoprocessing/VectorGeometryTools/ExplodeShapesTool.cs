using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Geoprocessing)]
    public class ExplodeShapesTool: AppendModeGisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_explode.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }
        
        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Explode shapes"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Splits multi-part shapes in single part shapes."; }
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
            bool success = false;

            if (Output.MemoryLayer)
            {
                var fs = Input.Datasource.ExplodeShapes(Input.SelectedOnly);

                if (fs != null)
                {
                    Log.Info("Initial number of features: " + Input.Datasource.NumFeatures);
                    Log.Info("After exploding: " + fs.NumFeatures);
                }

                Output.Result = fs;
            }
            else
            {
                success = GisUtils.Instance.ExplodeShapes(Input.Datasource, Input.SelectedOnly, Output.Filename, Output.Overwrite);
            }

            return Output.Result != null || success;
        }
    }
}
