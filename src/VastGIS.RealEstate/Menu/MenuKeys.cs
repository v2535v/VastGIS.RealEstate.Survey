// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuKeys.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu keys.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace VastGIS.Plugins.RealEstate.Menu
{
    /// <summary>
    /// The menu keys.
    /// </summary>
    public class MenuKeys
    {
        #region Constants

        /// <summary>
        /// The menu item key. Used to identify which toolbar button or menu item was clicked.
        /// </summary>
        public const string ShowDockableWindow = "change this and make sure it is unique for all plug-ins";

        public const string SelectEditLayer = "reSelectEditLayer";
        public const string OpenRealEstateDatabase = "reOpenREDatabase";
        public const string StartEditingRealEstateDatabase = "reStartEditing";

        #endregion
    }
}