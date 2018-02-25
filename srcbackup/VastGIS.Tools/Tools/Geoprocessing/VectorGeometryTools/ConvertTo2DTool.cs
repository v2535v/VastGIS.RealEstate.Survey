using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.Tools.Model;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Tools.Geoprocessing.VectorGeometryTools
{
    [GisTool(GroupKeys.Basic)]
    public class ConvertTo2DTool: AppendModeGisTool
    {
        [Input("Input datasource", 0)]
        public IVectorInput Input { get; set; }

        [Output("Output layer", 0)]
        [OutputLayer("{input}_2d.shp", LayerType.Shapefile)]
        public OutputLayerInfo Output { get; set; }

        /// <summary>
        /// The name of the tool.
        /// </summary>
        public override string Name
        {
            get { return "Convert to 2D"; }
        }

        /// <summary>
        /// Description of the tool.
        /// </summary>
        public override string Description
        {
            get { return "Removes M, Z components from vector datasource."; }
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
            get  { return true; }
        }

        /// <summary>
        /// Is called on the UI thread before execution of the IGisTool.Run method.
        /// </summary>
        protected override bool BeforeRun()
        {
            if (Input.Datasource.ZValueType == ZValueType.None)
            {
                MessageService.Current.Info("The datasource doesn't have M, Z values: " + Input.Name);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Runs the tool.
        /// </summary>
        public override bool Run(ITaskHandle task)
        {
            var fs = Input.Datasource;

            var fsNew = fs.Clone(fs.GeometryType);

            if (!TrySaveForAppendMode(Output, fsNew))
            {
                return false;
            }

            int lastPercent = 0;

            var features = Input.Datasource.GetFeatures(Input.SelectedOnly);
            for (int i = 0; i < features.Count; i++)
            {
                task.CheckPauseAndCancel();
                task.Progress.TryUpdate("Calculating...", i, features.Count, ref lastPercent);

                var ft = features[i];

                var gm = ft.Geometry.Clone(fs.GeometryType);
                int shapeIndex = fsNew.Features.EditAdd(gm);

                if (shapeIndex != -1)
                {
                    fs.Table.CopyAttributes(ft.Index, fsNew.Table, shapeIndex);
                }
            }

            task.Progress.Clear();

            Output.Result = fsNew;

            return true;
        }
    }
}
