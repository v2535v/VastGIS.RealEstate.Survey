﻿using System.Linq;
using System.Text;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Static;
using VastGIS.Gdal.Model;
using VastGIS.Gdal.Views;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;

namespace VastGIS.Gdal.Tools
{
    [GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(GdalConvertPresenter))]
    public partial class Ogr2OgrTool: GdalTool
    {
        [Input("Input filename", 0)]
        [ControlHint(ControlHint.Filename)]
        [DataTypeHint(DataSourceType.Vector)]
        public string InputFilename { get; set; }

        [Output("Output format")]
        [ControlHint(ControlHint.Combo)]
        public DatasourceDriver OutputFormat { get; set; }

        [Output("Output", 1)]
        [OutputLayer("{input}_conv.shp", LayerType.Shapefile, false)]
        public override OutputLayerInfo Output { get; set; }

        /// <summary>
        /// Initializes the command line options.
        /// </summary>
        protected override void InitCommandLine(CommandLineMapping mapping)
        {
            // TODO: implement
            mapping.Get<Ogr2OgrTool>()
                .SetKey(t => t.OutputFormat, "-f");
        }

        /// <summary>
        /// Adds tool configuration which can be used for generation of the UI for tool.
        /// </summary>
        protected override void Configure(IAppContext context, VastGIS.Tools.Services.ToolConfiguration configuration)
        {
            base.Configure(context, configuration);

            var drivers = GetDrivers().ToList();
            var sf = drivers.FirstOrDefault(f => f.Name.ToLower() == GdalFormats.Shapefile);

            configuration.Get<Ogr2OgrTool>()
                 .AddComboList(t => t.OutputFormat, drivers)
                 .SetDefault(t => t.OutputFormat, sf);
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Convert vector"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Converts simple features data between file formats."; }
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected override bool DriverFilter(DatasourceDriver driver)
        {
            return driver.IsVector;
        }

        /// <summary>
        /// Gets command line options.
        /// </summary>
        public override string CompileOptions(bool mainOnly = false)
        {
            string s = base.CompileOptions(mainOnly);

            var sb = new StringBuilder();
            
            sb.AppendFormat("-f \"{0}\" ", OutputFormat.Name);
            sb.Append(s);
            sb.Append("-progress ");

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
            bool result = GdalUtils.Instance.Ogr2Ogr(InputFilename, Output.Filename, options);
            return result;
        }
    }
}
