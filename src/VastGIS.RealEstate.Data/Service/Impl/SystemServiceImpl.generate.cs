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
    public partial class SystemServiceImpl : SystemService
    {	
        private SystemDao _systemDao;
        
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
        
        public SystemServiceImpl(SystemDao systemDao)
        {
            this._systemDao = systemDao;
            this._systemDao.EntityChanged += SystemDao_EntityChanged;
        }
        
        private void SystemDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }
        
        #region ISQLiteService接口实现
        public int GetSRID()
        {
            return ((ISQLiteService)_systemDao).GetSRID();
        }

        public SQLiteConnection Connection { get { return ((ISQLiteService)_systemDao).Connection; } }

        public string CurrentUser { get { return _systemDao.CurrentUser; } set { _systemDao.CurrentUser = value; } }

        public bool Save(IEntity entity){return _systemDao.Save(entity);}
        public void Delete(IEntity entity){ _systemDao.Delete(entity);}
        public bool Save(List<IEntity> entities){return _systemDao.Save(entities);}
        public void Delete(List<IEntity> entities){ _systemDao.Delete(entities);}
                
        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true){
            return _systemDao.CopyEntities(targetClass,sourceEntities,isDelete,isAttributeAutoTransform);
        }
        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return _systemDao.CreateEntity(currentClass);
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            return _systemDao.GetEntity(currentClass, id);
        }
        public IEntity GetEntity(string tableName, long id)
        {
            return _systemDao.GetEntity(tableName, id);
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {
            return _systemDao.GetEntities(currentClass, queryFilter);
        }
        
        public List<IEntity> GetEntities(string tableName, string queryFilter)
        {
            return _systemDao.GetEntities(tableName, queryFilter);
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _systemDao.ReorderAllPolygon(tableName);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y,double torenlance=1.0)
        {
            return _systemDao.FindFeatures(objectClass, x, y,torenlance);
        }
        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y,double torenlance=1.0)
        {
            return _systemDao.FindFeatures(objectClasses, x, y,torenlance);
        }
        #endregion
        
        #region VgAreacode方法
        public VgAreacode GetVgAreacode(long id)
        {
            return _systemDao.GetVgAreacode(id);
        }
        
        public IEnumerable<VgAreacode> GetVgAreacodes(string filter)
        {
            return _systemDao.GetVgAreacodes(filter);
        }
        public bool SaveVgAreacode(VgAreacode vgAreacode)
        {
            return _systemDao.SaveVgAreacode(vgAreacode);
        }
        public void SaveVgAreacodes(List<VgAreacode> vgAreacodes)
        {
            _systemDao.SaveVgAreacodes(vgAreacodes);        
        }
        public void DeleteVgAreacode(VgAreacode rec)
        {
            _systemDao.DeleteVgAreacode(rec);
        }
        public void DeleteVgAreacode(long id)
        {
            _systemDao.DeleteVgAreacode(id);
        }
        public void DeleteVgAreacode(string filter)
        {
            _systemDao.DeleteVgAreacode(filter);
        }
        #endregion
        
        #region VgAttachment方法
        public VgAttachment GetVgAttachment(long id)
        {
            return _systemDao.GetVgAttachment(id);
        }
        
        public IEnumerable<VgAttachment> GetVgAttachments(string filter)
        {
            return _systemDao.GetVgAttachments(filter);
        }
        public bool SaveVgAttachment(VgAttachment vgAttachment)
        {
            return _systemDao.SaveVgAttachment(vgAttachment);
        }
        public void SaveVgAttachments(List<VgAttachment> vgAttachments)
        {
            _systemDao.SaveVgAttachments(vgAttachments);        
        }
        public void DeleteVgAttachment(VgAttachment rec)
        {
            _systemDao.DeleteVgAttachment(rec);
        }
        public void DeleteVgAttachment(long id)
        {
            _systemDao.DeleteVgAttachment(id);
        }
        public void DeleteVgAttachment(string filter)
        {
            _systemDao.DeleteVgAttachment(filter);
        }
        #endregion
        
        #region VgCadcode方法
        public VgCadcode GetVgCadcode(long id)
        {
            return _systemDao.GetVgCadcode(id);
        }
        
        public IEnumerable<VgCadcode> GetVgCadcodes(string filter)
        {
            return _systemDao.GetVgCadcodes(filter);
        }
        public bool SaveVgCadcode(VgCadcode vgCadcode)
        {
            return _systemDao.SaveVgCadcode(vgCadcode);
        }
        public void SaveVgCadcodes(List<VgCadcode> vgCadcodes)
        {
            _systemDao.SaveVgCadcodes(vgCadcodes);        
        }
        public void DeleteVgCadcode(VgCadcode rec)
        {
            _systemDao.DeleteVgCadcode(rec);
        }
        public void DeleteVgCadcode(long id)
        {
            _systemDao.DeleteVgCadcode(id);
        }
        public void DeleteVgCadcode(string filter)
        {
            _systemDao.DeleteVgCadcode(filter);
        }
        #endregion
        
        #region VgClassdetail方法
        public VgClassdetail GetVgClassdetail(long id)
        {
            return _systemDao.GetVgClassdetail(id);
        }
        
        public IEnumerable<VgClassdetail> GetVgClassdetails(string filter)
        {
            return _systemDao.GetVgClassdetails(filter);
        }
        public bool SaveVgClassdetail(VgClassdetail vgClassdetail)
        {
            return _systemDao.SaveVgClassdetail(vgClassdetail);
        }
        public void SaveVgClassdetails(List<VgClassdetail> vgClassdetails)
        {
            _systemDao.SaveVgClassdetails(vgClassdetails);        
        }
        public void DeleteVgClassdetail(VgClassdetail rec)
        {
            _systemDao.DeleteVgClassdetail(rec);
        }
        public void DeleteVgClassdetail(long id)
        {
            _systemDao.DeleteVgClassdetail(id);
        }
        public void DeleteVgClassdetail(string filter)
        {
            _systemDao.DeleteVgClassdetail(filter);
        }
        #endregion
        
        #region VgClassgroup方法
        public VgClassgroup GetVgClassgroup(long id)
        {
            return _systemDao.GetVgClassgroup(id);
        }
        
        public IEnumerable<VgClassgroup> GetVgClassgroups(string filter)
        {
            return _systemDao.GetVgClassgroups(filter);
        }
        public bool SaveVgClassgroup(VgClassgroup vgClassgroup)
        {
            return _systemDao.SaveVgClassgroup(vgClassgroup);
        }
        public void SaveVgClassgroups(List<VgClassgroup> vgClassgroups)
        {
            _systemDao.SaveVgClassgroups(vgClassgroups);        
        }
        public void DeleteVgClassgroup(VgClassgroup rec)
        {
            _systemDao.DeleteVgClassgroup(rec);
        }
        public void DeleteVgClassgroup(long id)
        {
            _systemDao.DeleteVgClassgroup(id);
        }
        public void DeleteVgClassgroup(string filter)
        {
            _systemDao.DeleteVgClassgroup(filter);
        }
        #endregion
        
        #region VgFieldinfo方法
        public VgFieldinfo GetVgFieldinfo(long id)
        {
            return _systemDao.GetVgFieldinfo(id);
        }
        
        public IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter)
        {
            return _systemDao.GetVgFieldinfos(filter);
        }
        public bool SaveVgFieldinfo(VgFieldinfo vgFieldinfo)
        {
            return _systemDao.SaveVgFieldinfo(vgFieldinfo);
        }
        public void SaveVgFieldinfos(List<VgFieldinfo> vgFieldinfos)
        {
            _systemDao.SaveVgFieldinfos(vgFieldinfos);        
        }
        public void DeleteVgFieldinfo(VgFieldinfo rec)
        {
            _systemDao.DeleteVgFieldinfo(rec);
        }
        public void DeleteVgFieldinfo(long id)
        {
            _systemDao.DeleteVgFieldinfo(id);
        }
        public void DeleteVgFieldinfo(string filter)
        {
            _systemDao.DeleteVgFieldinfo(filter);
        }
        #endregion
        
        #region VgLayergroup方法
        public VgLayergroup GetVgLayergroup(long id)
        {
            return _systemDao.GetVgLayergroup(id);
        }
        
        public IEnumerable<VgLayergroup> GetVgLayergroups(string filter)
        {
            return _systemDao.GetVgLayergroups(filter);
        }
        public bool SaveVgLayergroup(VgLayergroup vgLayergroup)
        {
            return _systemDao.SaveVgLayergroup(vgLayergroup);
        }
        public void SaveVgLayergroups(List<VgLayergroup> vgLayergroups)
        {
            _systemDao.SaveVgLayergroups(vgLayergroups);        
        }
        public void DeleteVgLayergroup(VgLayergroup rec)
        {
            _systemDao.DeleteVgLayergroup(rec);
        }
        public void DeleteVgLayergroup(long id)
        {
            _systemDao.DeleteVgLayergroup(id);
        }
        public void DeleteVgLayergroup(string filter)
        {
            _systemDao.DeleteVgLayergroup(filter);
        }
        #endregion
        
        #region VgLayergroupdetail方法
        public VgLayergroupdetail GetVgLayergroupdetail(long id)
        {
            return _systemDao.GetVgLayergroupdetail(id);
        }
        
        public IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter)
        {
            return _systemDao.GetVgLayergroupdetails(filter);
        }
        public bool SaveVgLayergroupdetail(VgLayergroupdetail vgLayergroupdetail)
        {
            return _systemDao.SaveVgLayergroupdetail(vgLayergroupdetail);
        }
        public void SaveVgLayergroupdetails(List<VgLayergroupdetail> vgLayergroupdetails)
        {
            _systemDao.SaveVgLayergroupdetails(vgLayergroupdetails);        
        }
        public void DeleteVgLayergroupdetail(VgLayergroupdetail rec)
        {
            _systemDao.DeleteVgLayergroupdetail(rec);
        }
        public void DeleteVgLayergroupdetail(long id)
        {
            _systemDao.DeleteVgLayergroupdetail(id);
        }
        public void DeleteVgLayergroupdetail(string filter)
        {
            _systemDao.DeleteVgLayergroupdetail(filter);
        }
        #endregion
        
        #region VgObjectysdm方法
        public VgObjectysdm GetVgObjectysdm(long id)
        {
            return _systemDao.GetVgObjectysdm(id);
        }
        
        public IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter)
        {
            return _systemDao.GetVgObjectysdms(filter);
        }
        public bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm)
        {
            return _systemDao.SaveVgObjectysdm(vgObjectysdm);
        }
        public void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms)
        {
            _systemDao.SaveVgObjectysdms(vgObjectysdms);        
        }
        public void DeleteVgObjectysdm(VgObjectysdm rec)
        {
            _systemDao.DeleteVgObjectysdm(rec);
        }
        public void DeleteVgObjectysdm(long id)
        {
            _systemDao.DeleteVgObjectysdm(id);
        }
        public void DeleteVgObjectysdm(string filter)
        {
            _systemDao.DeleteVgObjectysdm(filter);
        }
        #endregion
        
        #region VgSetting方法
        public VgSetting GetVgSetting(long id)
        {
            return _systemDao.GetVgSetting(id);
        }
        
        public IEnumerable<VgSetting> GetVgSettings(string filter)
        {
            return _systemDao.GetVgSettings(filter);
        }
        public bool SaveVgSetting(VgSetting vgSetting)
        {
            return _systemDao.SaveVgSetting(vgSetting);
        }
        public void SaveVgSettings(List<VgSetting> vgSettings)
        {
            _systemDao.SaveVgSettings(vgSettings);        
        }
        public void DeleteVgSetting(VgSetting rec)
        {
            _systemDao.DeleteVgSetting(rec);
        }
        public void DeleteVgSetting(long id)
        {
            _systemDao.DeleteVgSetting(id);
        }
        public void DeleteVgSetting(string filter)
        {
            _systemDao.DeleteVgSetting(filter);
        }
        #endregion
        
        #region VgObjectitem方法
        public VgObjectitem GetVgObjectitem(long id)
        {
            return _systemDao.GetVgObjectitem(id);
        }
        
        public IEnumerable<VgObjectitem> GetVgObjectitems(string filter)
        {
            return _systemDao.GetVgObjectitems(filter);
        }
        public bool SaveVgObjectitem(VgObjectitem vgObjectitem)
        {
            return _systemDao.SaveVgObjectitem(vgObjectitem);
        }
        public void SaveVgObjectitems(List<VgObjectitem> vgObjectitems)
        {
            _systemDao.SaveVgObjectitems(vgObjectitems);        
        }
        public void DeleteVgObjectitem(VgObjectitem rec)
        {
            _systemDao.DeleteVgObjectitem(rec);
        }
        public void DeleteVgObjectitem(long id)
        {
            _systemDao.DeleteVgObjectitem(id);
        }
        public void DeleteVgObjectitem(string filter)
        {
            _systemDao.DeleteVgObjectitem(filter);
        }
        #endregion
        
        #region VgObjectclass方法
        public VgObjectclass GetVgObjectclass(long id)
        {
            return _systemDao.GetVgObjectclass(id);
        }
        
        public IEnumerable<VgObjectclass> GetVgObjectclasses(string filter)
        {
            return _systemDao.GetVgObjectclasses(filter);
        }
        public bool SaveVgObjectclass(VgObjectclass vgObjectclass)
        {
            return _systemDao.SaveVgObjectclass(vgObjectclass);
        }
        public void SaveVgObjectclasses(List<VgObjectclass> vgObjectclasses)
        {
            _systemDao.SaveVgObjectclasses(vgObjectclasses);        
        }
        public void DeleteVgObjectclass(VgObjectclass rec)
        {
            _systemDao.DeleteVgObjectclass(rec);
        }
        public void DeleteVgObjectclass(long id)
        {
            _systemDao.DeleteVgObjectclass(id);
        }
        public void DeleteVgObjectclass(string filter)
        {
            _systemDao.DeleteVgObjectclass(filter);
        }
        #endregion
        
        #region VgClassrelation方法
        public VgClassrelation GetVgClassrelation(long id)
        {
            return _systemDao.GetVgClassrelation(id);
        }
        
        public IEnumerable<VgClassrelation> GetVgClassrelations(string filter)
        {
            return _systemDao.GetVgClassrelations(filter);
        }
        public bool SaveVgClassrelation(VgClassrelation vgClassrelation)
        {
            return _systemDao.SaveVgClassrelation(vgClassrelation);
        }
        public void SaveVgClassrelations(List<VgClassrelation> vgClassrelations)
        {
            _systemDao.SaveVgClassrelations(vgClassrelations);        
        }
        public void DeleteVgClassrelation(VgClassrelation rec)
        {
            _systemDao.DeleteVgClassrelation(rec);
        }
        public void DeleteVgClassrelation(long id)
        {
            _systemDao.DeleteVgClassrelation(id);
        }
        public void DeleteVgClassrelation(string filter)
        {
            _systemDao.DeleteVgClassrelation(filter);
        }
        #endregion
        
        
       
        
       
        
    }
}