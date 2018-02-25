// -------------------------------------------------------------------------------------------
// <copyright file="DriverConfigHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using VastGIS.Api.Concrete;
using VastGIS.Plugins.Helpers;
using VastGIS.Shared;
using VastGIS.Tools.Model.Parameters;

namespace VastGIS.Tools.Helpers
{
    /// <summary>
    /// Extension methods to save and restore creation options for GDAL drivers.
    /// </summary>
    internal static class DriverConfigHelper
    {
        /// <summary>
        /// Restores last used parameters of the tool from the disk based config file.
        /// </summary>
        public static void RestoreConfig(this DatasourceDriver driver, IEnumerable<BaseParameter> parameters)
        {
            string filename = driver.GetConfigPath();

            if (!File.Exists(filename))
            {
                return;
            }

            try
            {
                using (var reader = new StreamReader(filename))
                {
                    using (var xmlReader = new XmlTextReader(reader))
                    {
                        xmlReader.ReadStartElement();

                        xmlReader.ReadParameters(parameters);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to deserialize tool settings.", ex);
            }
        }

        /// <summary>
        /// Saves configuration of the tool.
        /// </summary>
        public static void SaveConfig(this DatasourceDriver driver, IEnumerable<BaseParameter> parameters)
        {
            try
            {
                string xml = parameters.Serialize("Driver");

                string filename = GetConfigPath(driver);

                PathHelper.CreateFolder(filename);

                File.WriteAllText(filename, xml);
            }
            catch (Exception ex)
            {
                Logger.Current.Warn("Failed to serialize tool settings.", ex);
            }
        }

        /// <summary>
        /// Gets path of the file with configuration info for the driver.
        /// </summary>
        private static string GetConfigPath(this DatasourceDriver driver)
        {
            return ConfigPathHelper.GetDriversConfigPath() + driver.Name + ".xml";
        }
    }
}