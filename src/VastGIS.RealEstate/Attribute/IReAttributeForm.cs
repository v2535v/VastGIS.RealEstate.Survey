// -------------------------------------------------------------------------------------------
// <copyright file="IReAttributeForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Attribute
{
    public interface IAttributeForm
    {
        void BindContext(IAppContext context,VgObjectclass objectClass);
        void LoadEntities(List<IEntity> entities);
        string ObjectKey { get; set; }
        IEntity LinkedObject { get; set; }
        string FormName { get; set; }

        void BindContext(IAppContext context,IEntity entity);
        void LinkObject();
        void LoadEntity(int index);

        int Current { get; set; }

        void GoToPrev();

        void GoToNext();

        void CreateNew();

        void DeleteCurrent();

        void Save();

        void FormClose();
    }
    public interface IReAttributeForm
    {
        string ObjectKey { get; set; }
        IEntity LinkedObject { get; set; }
        string FormName { get; set; }
        IAppContext Context { get; set; }
        void LoadEntity(string tableName,string entityName,long id);
        bool HasPropertyChanged { get; }
        
    }
}