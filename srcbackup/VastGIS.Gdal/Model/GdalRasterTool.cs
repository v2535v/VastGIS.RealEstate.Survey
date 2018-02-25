using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Gdal.Tools;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Services;

namespace VastGIS.Gdal.Model
{
    /// <summary>
    /// A base tool for translate raster and warp raster.
    /// </summary>
    public abstract class GdalRasterTool: GdalTool
    {
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Raster)]
        [Input("Input filename", 0)]
        public string InputFilename { get; set; }

        [Output("Output format", 0)]
        [ControlHint(ControlHint.Combo)]
        public virtual DatasourceDriver OutputFormat { get; set; }

        [Output("Output filename", 1)]
        [OutputLayer("{input}_tr.tif", LayerType.Image, false)]
        public override OutputLayerInfo Output { get; set; }

        public virtual string OutputType { get; set; }

        /// <summary>
        /// Configures the specified context.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var drivers = GetDrivers().ToList();
            var gtiff = drivers.FirstOrDefault(f => f.Name.ToLower() == GdalFormats.GTiff);

            configuration.Get<GdalRasterTool>()
                .AddComboList(t => t.OutputFormat, drivers)
                .SetDefault(t => t.OutputFormat, gtiff);
        }
    }
}
