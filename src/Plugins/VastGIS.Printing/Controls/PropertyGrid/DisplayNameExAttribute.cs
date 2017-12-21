// -------------------------------------------------------------------------------------------
// <copyright file="DisplayNameExAttribute.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.ComponentModel;
using VastGIS.Plugins.Printing.Properties;

namespace VastGIS.Plugins.Printing.Controls.PropertyGrid
{
    internal class DisplayNameExAttribute : DisplayNameAttribute
    {
        private readonly string resourceName;

        public DisplayNameExAttribute(string resourceName)
        {
            this.resourceName = resourceName;
        }

        public override string DisplayName
        {
            get { return Strings.ResourceManager.GetString(this.resourceName); }
        }
    }
}