﻿// -------------------------------------------------------------------------------------------
// <copyright file="GdalConvertView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Linq;
using VastGIS.Api.Concrete;
using VastGIS.Gdal.Helpers;
using VastGIS.Gdal.Model;
using VastGIS.Gdal.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Tools.Controls.Parameters.Interfaces;
using VastGIS.Tools.Helpers;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Parameters;
using VastGIS.Tools.Services;
using VastGIS.UI.Style;

namespace VastGIS.Gdal.Views
{
    /// <summary>
    /// UI for tools that perform conversion. 
    /// </summary>
    /// <remarks>Sets output extension and list of output types depending on the selected driver.</remarks>
    public partial class GdalConvertView : GdalDriverOptionsView, IGdalConvertView
    {
        public GdalConvertView(IAppContext context, ParameterControlGenerator controlGenerator, IStyleService styleService)
            : base(context, controlGenerator, styleService)
        {
            InitializeComponent();
        }

        protected override void OnDriverChanged(DatasourceDriver driver)
        {
            base.OnDriverChanged(driver);

            var tool = Model.Tool as IParametrizedTool;
            if (tool == null)
            {
                return;
            }

            UpdateOutputFilename(tool, driver);

            UpdateDataTypes(driver);
        }

        /// <summary>
        /// Updates list of supported data type for the current driver.
        /// </summary>
        /// <param name="driver">The driver.</param>
        private void UpdateDataTypes(DatasourceDriver driver)
        {
            var tool = Model.Tool as GisTool;
            if (tool == null)
            {
                return;
            }

            var p = tool.FindParameter<GdalRasterTool, string>(t => t.OutputType) as OptionsParameter;
            if (p == null)
            {
                return;
            }

            var ctrl = p.Control as IOptionsParameterControl;
            if (ctrl != null)
            {
                var types = driver.GetCreationDataTypes();
                ctrl.SetOptions(types);
            }
        }

        /// <summary>
        /// Updates output extension when active driver changes.
        /// </summary>
        private void UpdateOutputFilename(IParametrizedTool tool, DatasourceDriver driver)
        {
            var input = tool.GetSingleInputParameter() as FilenameParameter;
            if (input == null)
            {
                return;
            }

            foreach (var p in tool.Parameters.OfType<OutputLayerParameter>())
            {
                var ctrl = p.Control as IOuputputParameterControl;
                if (ctrl != null)
                {
                    string ext = driver.Extension;
                    if (string.IsNullOrWhiteSpace(ext))
                    {
                        // sometimes there is no extension in the driver metadata
                        ext = "???";
                    }

                    ctrl.SetExtension(ext);
                }
            }
        }
    }
}