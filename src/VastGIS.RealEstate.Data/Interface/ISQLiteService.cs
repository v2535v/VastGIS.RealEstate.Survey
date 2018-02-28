using System.Collections.Generic;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface ISQLiteService
    {
        int GetSRID();
        SQLiteConnection Connection { get; }
        string CurrentUser { get; set; }
        bool Save(IEntity entity);
        void Delete(IEntity entity);
        bool Save(List<IEntity> entities);
        void Delete(List<IEntity> entities);

        IEntity CreateEntity(VgObjectclass currentClass);
        IEntity GetEntity(VgObjectclass currentClass, long id);
        List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter);
        bool ReorderAllPolygon(string tableName);
        List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y,double torenlance=1.0);
        List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y, double torenlance = 1.0);

        bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true);

        event EntityChangedEventHandler EntityChanged;

        void OnEntityChanged(
            EntityOperationType operationType,
            List<IEntity> entities);
    }
}