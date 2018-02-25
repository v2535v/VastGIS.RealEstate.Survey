// -------------------------------------------------------------------------------------------
// <copyright file="CategoryExAttribute.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.ComponentModel;
using VastGIS.Plugins.Printing.Properties;

namespace VastGIS.Plugins.Printing.Controls.PropertyGrid
{
    internal class CategoryExAttribute : CategoryAttribute
    {
        private readonly string resourceName;

        public CategoryExAttribute(string resourceName)
        {
            this.resourceName = resourceName;
        }

        protected override string GetLocalizedString(string value)
        {
            return Strings.ResourceManager.GetString(this.resourceName);
        }
    }
}