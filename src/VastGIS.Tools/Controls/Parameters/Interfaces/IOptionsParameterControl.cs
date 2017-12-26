// -------------------------------------------------------------------------------------------
// <copyright file="IOptionsParameterControl.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

namespace VastGIS.Tools.Controls.Parameters.Interfaces
{
    /// <summary>
    /// Represents a control which can be used to display OptionsParameter
    /// </summary>
    internal interface IOptionsParameterControl
    {
        /// <summary>
        /// Sets list of options to the control. 
        /// </summary>
        /// <param name="options">An instance of class implementing IList interface.</param>
        void SetOptions(object options);
    }
}