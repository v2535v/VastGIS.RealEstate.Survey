﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Static;
using VastGIS.Gdal.Model;
using VastGIS.Gdal.Views;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;
using VastGIS.Tools.Services;

namespace VastGIS.Gdal.Tools
{
    [GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalPresenter))]
    public partial class BuildVrtTool: GdalTool
    {
        [ControlHint(ControlHint.MultipleFilename, 200)]
        [DataTypeHint(DataSourceType.Raster)]
        [Input("Input filename", 0)]
        public string[] Filenames { get; set; }

        [Output("Output filename", 0)]
        [OutputLayer(@"{input_folder}\datasource.vrt", LayerType.Image, false)]
        public override OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Initializes the command line options. Use _commandLine variable to do it.
        /// </summary>
        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            _commandLine.Get<BuildVrtTool>()
                .SetKey(p => p.TileIndex, "-tileindex")
                .SetKey(p => p.Resolution, "-resolution")
                .SetKey(p => p.TartetResolution, "-tr")
                .SetKey(p => p.AlignPixelsToResolution, "-tap")
                .SetKey(p => p.TargetExtents, "-te")
                .SetKey(p => p.AddAlpha, "-addalpha")
                .SetKey(p => p.HideNoData, "-hidenodata")
                .SetKey(p => p.SrcNoData, "-srcnodata")
                .SetKey(p => p.BandIndex, "-b")
                .SetKey(p => p.SubdatasetIndex, "-sd")
                .SetKey(p => p.VrtNoDataValue, "-vrtnodata")
                .SetKey(p => p.Separate, "-separate")
                .SetKey(p => p.AllowProjectionDifference, "-allow_projection_difference")
                .SetKey(p => p.TargetProjection, "-a_srs")
                .SetKey(p => p.Resampling, "-r");
        }

        /// <summary>
        /// Configures the specified context.
        /// </summary>
        protected override void Configure(IAppContext context, ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var resolutions = new[] { "", "highest", "lowest", "average", "user" };

            configuration.Get<BuildVrtTool>()
                .AddComboList(t => t.Resolution, resolutions)
                .AddComboList(t => t.Resampling, GdalHelper.GetRasterResampling());
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsRaster;
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Build virtual dataset"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Builds a virtual dataset from a list of datasets"; }
        }

        /// <summary>
        /// Gets the name to be displayed as a name of the task.
        /// </summary>
        public override string TaskName
        {
            get { return "Built VRT: " + Path.GetFileName(Output.Filename); }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public override bool SupportsBatchExecution
        {
            get { return false; }
        }

        /// <summary>
        /// Gets the options.
        /// </summary>
        public override string CompileOptions(bool mainOnly = false)
        {
            var s = base.CompileOptions(mainOnly);

            var sb = new StringBuilder(s);

            if (Output.Overwrite)
            {
                sb.Append("-overwrite ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            string options = GetOptions();

            options += StringHelper.Join(Filenames, " ");

            return GdalUtils.Instance.GdalBuildVrt(Output.Filename, options);
        }
    }
}
