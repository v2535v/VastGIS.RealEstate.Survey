// -------------------------------------------------------------------------------------------
// <copyright file="IReAttributeForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public interface IReAttributeForm
    {
        string ObjectKey { get; set; }
        IEntity LinkedObject { get; }
        string FormName { get; set; }
        IAppContext Context { get; set; }
        void LoadEntity(string tableName,string entityName,long id);
    }
}