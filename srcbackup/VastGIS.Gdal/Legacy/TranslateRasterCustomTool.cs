// -------------------------------------------------------------------------------------------
// <copyright file="TranslateRasterCustomTool.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.IO;
using VastGIS.Api.Static;
using VastGIS.Gdal.Legacy.Views;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;

namespace VastGIS.Gdal.Legacy
{
    //[GisTool(GroupKeys.GdalTools, ToolIcon.Hammer, typeof(TranslateRasterCustomPresenter))]
    public class TranslateRasterCustomTool : GisTool
    {
        [Input("Input filename", 0)]
        public string InputFilename { get; set; }

        [Input("Output filename", 1)]
        public OutputLayerInfo Output { get; set; }

        [Input("Options", 2)]
        public string Options { get; set; }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Converts raster data between different formats."; }
        }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Translate raster (MW4 UI)"; }
        }

        /// <summary>
        /// Gets the identity of plugin that created this tool.
        /// </summary>
        public override PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public override string TaskName
        {
            get { return "GDAL Translate: " + Path.GetFileName(Output.Filename); }
        }

        public override bool AfterRun()
        {
            return OutputManager.HandleGdalOutput(Output);
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            bool result = GdalUtils.Instance.TranslateRaster(InputFilename, Output.Filename, Options);

            if (!result)
            {
                Log.Error(@"The process did not finish successfully.", null);
                return false;
            }

            if (!File.Exists(Output.Filename))
            {
                Log.Info(@"The process did finish successfully. But the resulting file was not created.");
                return false;
            }

            return true;
        }
    }
}