// -------------------------------------------------------------------------------------------
// <copyright file="IToolView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Mvp;

namespace VastGIS.Tools.Views.Abstract
{
    /// <summary>
    /// The ToolView interface.
    /// </summary>
    public interface IToolView : IView<ToolViewModel>
    {
        /// <summary>
        /// Generates the controls.
        /// </summary>
        void GenerateControls();

        bool RunInBackground { get; }
    }
}