using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;

namespace VastGIS.Tools.Tools.Raster
{
    [GisTool(GroupKeys.Raster)]
    public class PolygonizeGridTool: GisTool
    {
        [Input("Input grid filename", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        public string GridFilename { get; set; }

        // TODO: dedicated band index parameter is needed
        [Input("Band index", 1)]                
        public int BandIndex { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_poly.shp", LayerType.Shapefile, false)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            configuration.Get<PolygonizeGridTool>()
                .SetDefault(t => t.BandIndex, 1);
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Polygonize grid"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "A new shapefile will be created with polygons for all connected regions of pixels in the grid sharing a common pixel value."; }
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
            if (Output.Overwrite)
            {
                if (!GeoSource.Remove(Output.Filename))
                {
                    Log.Warn("Failed to remove file: " + Output.Filename, null);
                    return false;
                }
            }

            return GisUtils.Instance.Polygonize(GridFilename, Output.Filename, BandIndex, false, null, GdalFormats.Shapefile);
        }

        /// <summary>
        /// A method called after the main IGisTool.Run method is successfully finished.
        /// Is executed on the UI thread. Typically used to save output datasources.
        /// Default implementation automatically handles values assigned to OutputLayerInfo.Result.
        /// </summary>
        public override bool AfterRun()
        {
            if (Output.AddToMap && File.Exists(Output.Filename))
            {
                Log.Info("Adding the resulting datasource to the map");

                var fs = new FeatureSet(Output.Filename);

                OutputManager.AddToMap(fs);
            }

            return true;
        }
    }
}
