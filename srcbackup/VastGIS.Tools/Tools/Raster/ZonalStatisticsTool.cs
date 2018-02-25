using System;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Static;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Raster
{
    [GisTool(GroupKeys.Raster)]
    public class ZonalStatisticsTool: GisTool
    {
        [Input("Input grid filename", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        public string GridFilename { get; set; }

        [Output("Vector layer to write results to")]
        public IVectorInput Vector { get; set; }

        [Output("Overwrite fields", 1)]
        public bool OverwriteFields { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Zonal overlay statistics"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "For every shape of the shapefile statistics of the grid will be calculated and added as attributes."; }
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
            if (Vector.Datasource.GeometryType != GeometryType.Polygon)
            {
                MessageService.Current.Info("Vector layer of polygon type is expected");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var grid = new GridSource(GridFilename);

            bool result;
            try
            {
                result = GisUtils.Instance.GridStatisticsToShapefile(grid, Vector.Datasource, Vector.SelectedOnly,
                    OverwriteFields);
            }
            catch (Exception)
            {
                grid.Dispose();
                throw;
            }

            return result;
        }
    }
}
