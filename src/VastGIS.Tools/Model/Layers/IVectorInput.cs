using VastGIS.Api.Interfaces;

namespace VastGIS.Tools.Model.Layers
{
    public interface IVectorInput: IDatasourceInput
    {
        /// <summary>
        /// Gets or sets the datasource serving as input for GIS task.
        /// </summary>
        new IFeatureSet Datasource { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether only selected features of the input layer should be processed.
        /// </summary>
        bool SelectedOnly { get; set; }
    }
}
