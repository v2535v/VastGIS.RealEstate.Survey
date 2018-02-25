﻿// -------------------------------------------------------------------------------------------
// <copyright file="GdalTool.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Text;
using VastGIS.Api.Concrete;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Model;

namespace VastGIS.Gdal.Model
{
    public abstract class GdalTool : GisTool, IGdalTool
    {
        protected readonly CommandLineMapping _commandLine = new CommandLineMapping();

        protected GdalTool()
        {
            InitCommandLine(_commandLine);
        }

        // The UI for them will be generated dynamically depending on driver
        public string DriverOptions { get; set; }

        public virtual OutputLayerInfo Output { get; set; }

        [Input("Additional options", -1)]
        [ControlHint(ControlHint.MultiLineString)]
        public string AdditionalOptions { get; set; }

        [Input("Override main options", -1)]
        public bool OverrideOptions { get; set; }

        [Input("Effective options", -1)]
        public string EffectiveOptions
        {
            get { return GetOptions(); }
        }

        public string GetOptions(bool mainOnly = false)
        {
            if (OverrideOptions)
            {
                return AdditionalOptions;
            }

            return CompileOptions();
        }

        /// <summary>
        /// Gets a value indicating whether current tool can specify driver creation options.
        /// </summary>
        public virtual bool SupportDriverCreationOptions
        {
            get { return false; }
        }

        /// <summary>
        /// Can be used to save results of the processing or display messages.
        /// Default implementation automatically handles values assigned to OutputLayerInfo.Result.
        /// </summary>
        public override bool AfterRun()
        {
            return OutputManager.HandleGdalOutput(Output);
        }

        /// <summary>
        /// Gets command line options.
        /// </summary>
        public virtual string CompileOptions(bool mainOnly = false)
        {
            var sb = new StringBuilder();

            string options = _commandLine.Complile(this);
            sb.Append(options);

            if (!string.IsNullOrWhiteSpace(DriverOptions))
            {
                sb.Append(DriverOptions + @" ");
            }

            if (!mainOnly)
            {
                sb.Append(@" " + AdditionalOptions + @" ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected abstract bool DriverFilter(DatasourceDriver driver);

        /// <summary>
        /// Gets the list of drivers that support the creation of new datasources.
        /// </summary>
        protected IEnumerable<DatasourceDriver> GetDrivers()
        {
            var manager = new DriverManager();
            return manager.Where(DriverFilter).OrderBy(d => d.Name).ToList();
        }

        /// <summary>
        /// Initializes the command line options.
        /// </summary>
        protected abstract void InitCommandLine(CommandLineMapping mapping);
    }
}