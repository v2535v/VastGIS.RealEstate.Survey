// -------------------------------------------------------------------------------------------
// <copyright file="IOuputputParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Api.Enums;
using VastGIS.Tools.Model.Layers;

namespace VastGIS.Tools.Controls.Parameters.Interfaces
{
    /// <summary>
    /// Represents control to set parameters of output. Can react to changes of input datasource.
    /// </summary>
    public interface IOuputputParameterControl
    {
        /// <summary>
        /// Called when input datasource is changed.
        /// </summary>
        void OnDatasourceChanged(IDatasourceInput input);

        /// <summary>
        /// Called when input filename is changed.
        /// </summary>
        void OnFilenameChanged(string filename);

        /// <summary>
        /// Changes output name after new format / extension is selected.
        /// </summary>
        void SetExtension(string extension);

        /// <summary>
        /// Initializes output control with specified layer type.
        /// </summary>
        void Initialize(LayerType layerType, bool supportsInMemory = true);
    }
}