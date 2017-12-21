// -------------------------------------------------------------------------------------------
// <copyright file="AddConnectionModel.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;

namespace VastGIS.Data.Views
{
    public class AddConnectionModel
    {
        public AddConnectionModel(GeoDatabaseType? databaseType)
        {
            DatabaseType = databaseType;
        }

        /// <summary>
        /// Gets or sets the resulting connection selected by user.
        /// </summary>
        public DatabaseConnection Connection { get; set; }

        public GeoDatabaseType? DatabaseType { get; set; }
    }
}