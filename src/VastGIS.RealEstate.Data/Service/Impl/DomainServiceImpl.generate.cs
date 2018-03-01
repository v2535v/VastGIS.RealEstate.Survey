using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;
using VastGIS.RealEstate.Data.Events;

namespace VastGIS.RealEstate.Data.Service.Impl
{
    public partial class DomainServiceImpl : DomainService
    {	
        private DomainDao _domainDao;
        
        private event EntityChangedEventHandler entityChanged;
      
        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(EntityOperationType operationType,List<IEntity> entities)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs( operationType,entities));
            }
        }
        
        public DomainServiceImpl(DomainDao domainDao)
        {
            this._domainDao = domainDao;
            this._domainDao.EntityChanged += DomainDao_EntityChanged;
        }
        
        private void DomainDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }
        
        #region ISQLiteService接口实现
        public int GetSRID()
        {
            return ((ISQLiteService)_domainDao).GetSRID();
        }

        public SQLiteConnection Connection { get { return ((ISQLiteService)_domainDao).Connection; } }

        public string CurrentUser { get { return _domainDao.CurrentUser; } set { _domainDao.CurrentUser = value; } }

        public bool Save(IEntity entity){return _domainDao.Save(entity);}
        public void Delete(IEntity entity){ _domainDao.Delete(entity);}
        public bool Save(List<IEntity> entities){return _domainDao.Save(entities);}
        public void Delete(List<IEntity> entities){ _domainDao.Delete(entities);}
                
        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true){
            return _domainDao.CopyEntities(targetClass,sourceEntities,isDelete,isAttributeAutoTransform);
        }
        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return _domainDao.CreateEntity(currentClass);
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            return _domainDao.GetEntity(currentClass, id);
        }
        public IEntity GetEntity(string tableName, long id)
        {
            return _domainDao.GetEntity(tableName, id);
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {
            return _domainDao.GetEntities(currentClass, queryFilter);
        }
        
        public List<IEntity> GetEntities(string tableName, string queryFilter)
        {
            return _domainDao.GetEntities(tableName, queryFilter);
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _domainDao.ReorderAllPolygon(tableName);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y,double torenlance=1.0)
        {
            return _domainDao.FindFeatures(objectClass, x, y,torenlance);
        }
        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y,double torenlance=1.0)
        {
            return _domainDao.FindFeatures(objectClasses, x, y,torenlance);
        }
        #endregion
        
        #region VgDictionary方法
        public VgDictionary GetVgDictionary(long id)
        {
            return _domainDao.GetVgDictionary(id);
        }
        
        public IEnumerable<VgDictionary> GetVgDictionaries(string filter)
        {
            return _domainDao.GetVgDictionaries(filter);
        }
        public bool SaveVgDictionary(VgDictionary vgDictionary)
        {
            return _domainDao.SaveVgDictionary(vgDictionary);
        }
        public void SaveVgDictionaries(List<VgDictionary> vgDictionaries)
        {
            _domainDao.SaveVgDictionaries(vgDictionaries);        
        }
        public void DeleteVgDictionary(VgDictionary rec)
        {
            _domainDao.DeleteVgDictionary(rec);
        }
        public void DeleteVgDictionary(long id)
        {
            _domainDao.DeleteVgDictionary(id);
        }
        public void DeleteVgDictionary(string filter)
        {
            _domainDao.DeleteVgDictionary(filter);
        }
        #endregion
        
        #region VgDictoryname方法
        public VgDictoryname GetVgDictoryname(long id)
        {
            return _domainDao.GetVgDictoryname(id);
        }
        
        public IEnumerable<VgDictoryname> GetVgDictorynames(string filter)
        {
            return _domainDao.GetVgDictorynames(filter);
        }
        public bool SaveVgDictoryname(VgDictoryname vgDictoryname)
        {
            return _domainDao.SaveVgDictoryname(vgDictoryname);
        }
        public void SaveVgDictorynames(List<VgDictoryname> vgDictorynames)
        {
            _domainDao.SaveVgDictorynames(vgDictorynames);        
        }
        public void DeleteVgDictoryname(VgDictoryname rec)
        {
            _domainDao.DeleteVgDictoryname(rec);
        }
        public void DeleteVgDictoryname(long id)
        {
            _domainDao.DeleteVgDictoryname(id);
        }
        public void DeleteVgDictoryname(string filter)
        {
            _domainDao.DeleteVgDictoryname(filter);
        }
        #endregion
        
        
       
        
       
        
    }
}