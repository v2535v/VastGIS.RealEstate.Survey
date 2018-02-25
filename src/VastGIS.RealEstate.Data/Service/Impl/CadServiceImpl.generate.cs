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
    public partial class CadServiceImpl : CadService
    {	
        private CadDao _cadDao;
        
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
        
        public CadServiceImpl(CadDao cadDao)
        {
            this._cadDao = cadDao;
            this._cadDao.EntityChanged += CadDao_EntityChanged;
        }
        
        private void CadDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }
        
        #region ISQLiteService接口实现
        public int GetSRID()
        {
            return ((ISQLiteService)_cadDao).GetSRID();
        }

        public SQLiteConnection Connection { get { return ((ISQLiteService)_cadDao).Connection; } }

        public string CurrentUser { get { return _cadDao.CurrentUser; } set { _cadDao.CurrentUser = value; } }

        public bool Save(IEntity entity){return _cadDao.Save(entity);}
        public void Delete(IEntity entity){ _cadDao.Delete(entity);}
        public bool Save(List<IEntity> entities){return _cadDao.Save(entities);}
        public void Delete(List<IEntity> entities){ _cadDao.Delete(entities);}
                
        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true){
            return _cadDao.CopyEntities(targetClass,sourceEntities,isDelete,isAttributeAutoTransform);
        }
        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return _cadDao.CreateEntity(currentClass);
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            return _cadDao.GetEntity(currentClass, id);
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {
            return _cadDao.GetEntities(currentClass, queryFilter);
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _cadDao.ReorderAllPolygon(tableName);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y)
        {
            return _cadDao.FindFeatures(objectClass, x, y);
        }
        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y)
        {
            return _cadDao.FindFeatures(objectClasses, x, y);
        }
        #endregion
        
        #region TmpCadd方法
        public TmpCadd GetTmpCadd(long id)
        {
            return _cadDao.GetTmpCadd(id);
        }
        
        public IEnumerable<TmpCadd> GetTmpCadds(string filter)
        {
            return _cadDao.GetTmpCadds(filter);
        }
        public bool SaveTmpCadd(TmpCadd tmpcadd)
        {
            return _cadDao.SaveTmpCadd(tmpcadd);
        }
        public void SaveTmpCadds(List<TmpCadd> tmpCadds)
        {
            _cadDao.SaveTmpCadds(tmpCadds);        
        }
        public void DeleteTmpCadd(TmpCadd rec)
        {
            _cadDao.DeleteTmpCadd(rec);
        }
        public void DeleteTmpCadd(long id)
        {
            _cadDao.DeleteTmpCadd(id);
        }
        public void DeleteTmpCadd(string filter)
        {
            _cadDao.DeleteTmpCadd(filter);
        }
        #endregion
        
        #region TmpCadm方法
        public TmpCadm GetTmpCadm(long id)
        {
            return _cadDao.GetTmpCadm(id);
        }
        
        public IEnumerable<TmpCadm> GetTmpCadms(string filter)
        {
            return _cadDao.GetTmpCadms(filter);
        }
        public bool SaveTmpCadm(TmpCadm tmpcadm)
        {
            return _cadDao.SaveTmpCadm(tmpcadm);
        }
        public void SaveTmpCadms(List<TmpCadm> tmpCadms)
        {
            _cadDao.SaveTmpCadms(tmpCadms);        
        }
        public void DeleteTmpCadm(TmpCadm rec)
        {
            _cadDao.DeleteTmpCadm(rec);
        }
        public void DeleteTmpCadm(long id)
        {
            _cadDao.DeleteTmpCadm(id);
        }
        public void DeleteTmpCadm(string filter)
        {
            _cadDao.DeleteTmpCadm(filter);
        }
        #endregion
        
        #region TmpCadx方法
        public TmpCadx GetTmpCadx(long id)
        {
            return _cadDao.GetTmpCadx(id);
        }
        
        public IEnumerable<TmpCadx> GetTmpCadxes(string filter)
        {
            return _cadDao.GetTmpCadxes(filter);
        }
        public bool SaveTmpCadx(TmpCadx tmpcadx)
        {
            return _cadDao.SaveTmpCadx(tmpcadx);
        }
        public void SaveTmpCadxes(List<TmpCadx> tmpCadxes)
        {
            _cadDao.SaveTmpCadxes(tmpCadxes);        
        }
        public void DeleteTmpCadx(TmpCadx rec)
        {
            _cadDao.DeleteTmpCadx(rec);
        }
        public void DeleteTmpCadx(long id)
        {
            _cadDao.DeleteTmpCadx(id);
        }
        public void DeleteTmpCadx(string filter)
        {
            _cadDao.DeleteTmpCadx(filter);
        }
        #endregion
        
        #region TmpCadxdata方法
        public TmpCadxdata GetTmpCadxdata(long id)
        {
            return _cadDao.GetTmpCadxdata(id);
        }
        
        public IEnumerable<TmpCadxdata> GetTmpCadxdatas(string filter)
        {
            return _cadDao.GetTmpCadxdatas(filter);
        }
        public bool SaveTmpCadxdata(TmpCadxdata tmpcadxdatum)
        {
            return _cadDao.SaveTmpCadxdata(tmpcadxdatum);
        }
        public void SaveTmpCadxdatas(List<TmpCadxdata> tmpCadxdatas)
        {
            _cadDao.SaveTmpCadxdatas(tmpCadxdatas);        
        }
        public void DeleteTmpCadxdata(TmpCadxdata rec)
        {
            _cadDao.DeleteTmpCadxdata(rec);
        }
        public void DeleteTmpCadxdata(long id)
        {
            _cadDao.DeleteTmpCadxdata(id);
        }
        public void DeleteTmpCadxdata(string filter)
        {
            _cadDao.DeleteTmpCadxdata(filter);
        }
        #endregion
        
        #region TmpCadzj方法
        public TmpCadzj GetTmpCadzj(long id)
        {
            return _cadDao.GetTmpCadzj(id);
        }
        
        public IEnumerable<TmpCadzj> GetTmpCadzjs(string filter)
        {
            return _cadDao.GetTmpCadzjs(filter);
        }
        public bool SaveTmpCadzj(TmpCadzj tmpcadzj)
        {
            return _cadDao.SaveTmpCadzj(tmpcadzj);
        }
        public void SaveTmpCadzjs(List<TmpCadzj> tmpCadzjs)
        {
            _cadDao.SaveTmpCadzjs(tmpCadzjs);        
        }
        public void DeleteTmpCadzj(TmpCadzj rec)
        {
            _cadDao.DeleteTmpCadzj(rec);
        }
        public void DeleteTmpCadzj(long id)
        {
            _cadDao.DeleteTmpCadzj(id);
        }
        public void DeleteTmpCadzj(string filter)
        {
            _cadDao.DeleteTmpCadzj(filter);
        }
        #endregion
        
        
       
        
       
        
    }
}