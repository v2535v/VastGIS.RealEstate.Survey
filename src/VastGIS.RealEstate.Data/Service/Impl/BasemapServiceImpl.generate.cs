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
    public partial class BasemapServiceImpl : BasemapService
    {	
        private BasemapDao _basemapDao;
        
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
        
        public BasemapServiceImpl(BasemapDao basemapDao)
        {
            this._basemapDao = basemapDao;
            this._basemapDao.EntityChanged += BasemapDao_EntityChanged;
        }
        
        private void BasemapDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }
        
        #region ISQLiteService接口实现
        public int GetSRID()
        {
            return ((ISQLiteService)_basemapDao).GetSRID();
        }

        public SQLiteConnection Connection { get { return ((ISQLiteService)_basemapDao).Connection; } }

        public string CurrentUser { get { return _basemapDao.CurrentUser; } set { _basemapDao.CurrentUser = value; } }

        public bool Save(IEntity entity){return _basemapDao.Save(entity);}
        public void Delete(IEntity entity){ _basemapDao.Delete(entity);}
        public bool Save(List<IEntity> entities){return _basemapDao.Save(entities);}
        public void Delete(List<IEntity> entities){ _basemapDao.Delete(entities);}
                
        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true){
            return _basemapDao.CopyEntities(targetClass,sourceEntities,isDelete,isAttributeAutoTransform);
        }
        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return _basemapDao.CreateEntity(currentClass);
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            return _basemapDao.GetEntity(currentClass, id);
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {
            return _basemapDao.GetEntities(currentClass, queryFilter);
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _basemapDao.ReorderAllPolygon(tableName);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y)
        {
            return _basemapDao.FindFeatures(objectClass, x, y);
        }
        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y)
        {
            return _basemapDao.FindFeatures(objectClasses, x, y);
        }
        #endregion
        
        #region Dxtdldwd方法
        public Dxtdldwd GetDxtdldwd(long id)
        {
            return _basemapDao.GetDxtdldwd(id);
        }
        
        public IEnumerable<Dxtdldwd> GetDxtdldwds(string filter)
        {
            return _basemapDao.GetDxtdldwds(filter);
        }
        public bool SaveDxtdldwd(Dxtdldwd dxtdldwd)
        {
            return _basemapDao.SaveDxtdldwd(dxtdldwd);
        }
        public void SaveDxtdldwds(List<Dxtdldwd> dxtdldwds)
        {
            _basemapDao.SaveDxtdldwds(dxtdldwds);        
        }
        public void DeleteDxtdldwd(Dxtdldwd rec)
        {
            _basemapDao.DeleteDxtdldwd(rec);
        }
        public void DeleteDxtdldwd(long id)
        {
            _basemapDao.DeleteDxtdldwd(id);
        }
        public void DeleteDxtdldwd(string filter)
        {
            _basemapDao.DeleteDxtdldwd(filter);
        }
        #endregion
        
        #region Dxtdldwm方法
        public Dxtdldwm GetDxtdldwm(long id)
        {
            return _basemapDao.GetDxtdldwm(id);
        }
        
        public IEnumerable<Dxtdldwm> GetDxtdldwms(string filter)
        {
            return _basemapDao.GetDxtdldwms(filter);
        }
        public bool SaveDxtdldwm(Dxtdldwm dxtdldwm)
        {
            return _basemapDao.SaveDxtdldwm(dxtdldwm);
        }
        public void SaveDxtdldwms(List<Dxtdldwm> dxtdldwms)
        {
            _basemapDao.SaveDxtdldwms(dxtdldwms);        
        }
        public void DeleteDxtdldwm(Dxtdldwm rec)
        {
            _basemapDao.DeleteDxtdldwm(rec);
        }
        public void DeleteDxtdldwm(long id)
        {
            _basemapDao.DeleteDxtdldwm(id);
        }
        public void DeleteDxtdldwm(string filter)
        {
            _basemapDao.DeleteDxtdldwm(filter);
        }
        #endregion
        
        #region Dxtdldwx方法
        public Dxtdldwx GetDxtdldwx(long id)
        {
            return _basemapDao.GetDxtdldwx(id);
        }
        
        public IEnumerable<Dxtdldwx> GetDxtdldwxes(string filter)
        {
            return _basemapDao.GetDxtdldwxes(filter);
        }
        public bool SaveDxtdldwx(Dxtdldwx dxtdldwx)
        {
            return _basemapDao.SaveDxtdldwx(dxtdldwx);
        }
        public void SaveDxtdldwxes(List<Dxtdldwx> dxtdldwxes)
        {
            _basemapDao.SaveDxtdldwxes(dxtdldwxes);        
        }
        public void DeleteDxtdldwx(Dxtdldwx rec)
        {
            _basemapDao.DeleteDxtdldwx(rec);
        }
        public void DeleteDxtdldwx(long id)
        {
            _basemapDao.DeleteDxtdldwx(id);
        }
        public void DeleteDxtdldwx(string filter)
        {
            _basemapDao.DeleteDxtdldwx(filter);
        }
        #endregion
        
        #region Dxtdldwzj方法
        public Dxtdldwzj GetDxtdldwzj(long id)
        {
            return _basemapDao.GetDxtdldwzj(id);
        }
        
        public IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter)
        {
            return _basemapDao.GetDxtdldwzjs(filter);
        }
        public bool SaveDxtdldwzj(Dxtdldwzj dxtdldwzj)
        {
            return _basemapDao.SaveDxtdldwzj(dxtdldwzj);
        }
        public void SaveDxtdldwzjs(List<Dxtdldwzj> dxtdldwzjs)
        {
            _basemapDao.SaveDxtdldwzjs(dxtdldwzjs);        
        }
        public void DeleteDxtdldwzj(Dxtdldwzj rec)
        {
            _basemapDao.DeleteDxtdldwzj(rec);
        }
        public void DeleteDxtdldwzj(long id)
        {
            _basemapDao.DeleteDxtdldwzj(id);
        }
        public void DeleteDxtdldwzj(string filter)
        {
            _basemapDao.DeleteDxtdldwzj(filter);
        }
        #endregion
        
        #region Dxtdlssd方法
        public Dxtdlssd GetDxtdlssd(long id)
        {
            return _basemapDao.GetDxtdlssd(id);
        }
        
        public IEnumerable<Dxtdlssd> GetDxtdlssds(string filter)
        {
            return _basemapDao.GetDxtdlssds(filter);
        }
        public bool SaveDxtdlssd(Dxtdlssd dxtdlssd)
        {
            return _basemapDao.SaveDxtdlssd(dxtdlssd);
        }
        public void SaveDxtdlssds(List<Dxtdlssd> dxtdlssds)
        {
            _basemapDao.SaveDxtdlssds(dxtdlssds);        
        }
        public void DeleteDxtdlssd(Dxtdlssd rec)
        {
            _basemapDao.DeleteDxtdlssd(rec);
        }
        public void DeleteDxtdlssd(long id)
        {
            _basemapDao.DeleteDxtdlssd(id);
        }
        public void DeleteDxtdlssd(string filter)
        {
            _basemapDao.DeleteDxtdlssd(filter);
        }
        #endregion
        
        #region Dxtdlssm方法
        public Dxtdlssm GetDxtdlssm(long id)
        {
            return _basemapDao.GetDxtdlssm(id);
        }
        
        public IEnumerable<Dxtdlssm> GetDxtdlssms(string filter)
        {
            return _basemapDao.GetDxtdlssms(filter);
        }
        public bool SaveDxtdlssm(Dxtdlssm dxtdlssm)
        {
            return _basemapDao.SaveDxtdlssm(dxtdlssm);
        }
        public void SaveDxtdlssms(List<Dxtdlssm> dxtdlssms)
        {
            _basemapDao.SaveDxtdlssms(dxtdlssms);        
        }
        public void DeleteDxtdlssm(Dxtdlssm rec)
        {
            _basemapDao.DeleteDxtdlssm(rec);
        }
        public void DeleteDxtdlssm(long id)
        {
            _basemapDao.DeleteDxtdlssm(id);
        }
        public void DeleteDxtdlssm(string filter)
        {
            _basemapDao.DeleteDxtdlssm(filter);
        }
        #endregion
        
        #region Dxtdlssx方法
        public Dxtdlssx GetDxtdlssx(long id)
        {
            return _basemapDao.GetDxtdlssx(id);
        }
        
        public IEnumerable<Dxtdlssx> GetDxtdlssxes(string filter)
        {
            return _basemapDao.GetDxtdlssxes(filter);
        }
        public bool SaveDxtdlssx(Dxtdlssx dxtdlssx)
        {
            return _basemapDao.SaveDxtdlssx(dxtdlssx);
        }
        public void SaveDxtdlssxes(List<Dxtdlssx> dxtdlssxes)
        {
            _basemapDao.SaveDxtdlssxes(dxtdlssxes);        
        }
        public void DeleteDxtdlssx(Dxtdlssx rec)
        {
            _basemapDao.DeleteDxtdlssx(rec);
        }
        public void DeleteDxtdlssx(long id)
        {
            _basemapDao.DeleteDxtdlssx(id);
        }
        public void DeleteDxtdlssx(string filter)
        {
            _basemapDao.DeleteDxtdlssx(filter);
        }
        #endregion
        
        #region Dxtdlsszj方法
        public Dxtdlsszj GetDxtdlsszj(long id)
        {
            return _basemapDao.GetDxtdlsszj(id);
        }
        
        public IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter)
        {
            return _basemapDao.GetDxtdlsszjs(filter);
        }
        public bool SaveDxtdlsszj(Dxtdlsszj dxtdlsszj)
        {
            return _basemapDao.SaveDxtdlsszj(dxtdlsszj);
        }
        public void SaveDxtdlsszjs(List<Dxtdlsszj> dxtdlsszjs)
        {
            _basemapDao.SaveDxtdlsszjs(dxtdlsszjs);        
        }
        public void DeleteDxtdlsszj(Dxtdlsszj rec)
        {
            _basemapDao.DeleteDxtdlsszj(rec);
        }
        public void DeleteDxtdlsszj(long id)
        {
            _basemapDao.DeleteDxtdlsszj(id);
        }
        public void DeleteDxtdlsszj(string filter)
        {
            _basemapDao.DeleteDxtdlsszj(filter);
        }
        #endregion
        
        #region Dxtdmtzd方法
        public Dxtdmtzd GetDxtdmtzd(long id)
        {
            return _basemapDao.GetDxtdmtzd(id);
        }
        
        public IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter)
        {
            return _basemapDao.GetDxtdmtzds(filter);
        }
        public bool SaveDxtdmtzd(Dxtdmtzd dxtdmtzd)
        {
            return _basemapDao.SaveDxtdmtzd(dxtdmtzd);
        }
        public void SaveDxtdmtzds(List<Dxtdmtzd> dxtdmtzds)
        {
            _basemapDao.SaveDxtdmtzds(dxtdmtzds);        
        }
        public void DeleteDxtdmtzd(Dxtdmtzd rec)
        {
            _basemapDao.DeleteDxtdmtzd(rec);
        }
        public void DeleteDxtdmtzd(long id)
        {
            _basemapDao.DeleteDxtdmtzd(id);
        }
        public void DeleteDxtdmtzd(string filter)
        {
            _basemapDao.DeleteDxtdmtzd(filter);
        }
        #endregion
        
        #region Dxtdmtzm方法
        public Dxtdmtzm GetDxtdmtzm(long id)
        {
            return _basemapDao.GetDxtdmtzm(id);
        }
        
        public IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter)
        {
            return _basemapDao.GetDxtdmtzms(filter);
        }
        public bool SaveDxtdmtzm(Dxtdmtzm dxtdmtzm)
        {
            return _basemapDao.SaveDxtdmtzm(dxtdmtzm);
        }
        public void SaveDxtdmtzms(List<Dxtdmtzm> dxtdmtzms)
        {
            _basemapDao.SaveDxtdmtzms(dxtdmtzms);        
        }
        public void DeleteDxtdmtzm(Dxtdmtzm rec)
        {
            _basemapDao.DeleteDxtdmtzm(rec);
        }
        public void DeleteDxtdmtzm(long id)
        {
            _basemapDao.DeleteDxtdmtzm(id);
        }
        public void DeleteDxtdmtzm(string filter)
        {
            _basemapDao.DeleteDxtdmtzm(filter);
        }
        #endregion
        
        #region Dxtdmtzx方法
        public Dxtdmtzx GetDxtdmtzx(long id)
        {
            return _basemapDao.GetDxtdmtzx(id);
        }
        
        public IEnumerable<Dxtdmtzx> GetDxtdmtzxes(string filter)
        {
            return _basemapDao.GetDxtdmtzxes(filter);
        }
        public bool SaveDxtdmtzx(Dxtdmtzx dxtdmtzx)
        {
            return _basemapDao.SaveDxtdmtzx(dxtdmtzx);
        }
        public void SaveDxtdmtzxes(List<Dxtdmtzx> dxtdmtzxes)
        {
            _basemapDao.SaveDxtdmtzxes(dxtdmtzxes);        
        }
        public void DeleteDxtdmtzx(Dxtdmtzx rec)
        {
            _basemapDao.DeleteDxtdmtzx(rec);
        }
        public void DeleteDxtdmtzx(long id)
        {
            _basemapDao.DeleteDxtdmtzx(id);
        }
        public void DeleteDxtdmtzx(string filter)
        {
            _basemapDao.DeleteDxtdmtzx(filter);
        }
        #endregion
        
        #region Dxtdmtzzj方法
        public Dxtdmtzzj GetDxtdmtzzj(long id)
        {
            return _basemapDao.GetDxtdmtzzj(id);
        }
        
        public IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter)
        {
            return _basemapDao.GetDxtdmtzzjs(filter);
        }
        public bool SaveDxtdmtzzj(Dxtdmtzzj dxtdmtzzj)
        {
            return _basemapDao.SaveDxtdmtzzj(dxtdmtzzj);
        }
        public void SaveDxtdmtzzjs(List<Dxtdmtzzj> dxtdmtzzjs)
        {
            _basemapDao.SaveDxtdmtzzjs(dxtdmtzzjs);        
        }
        public void DeleteDxtdmtzzj(Dxtdmtzzj rec)
        {
            _basemapDao.DeleteDxtdmtzzj(rec);
        }
        public void DeleteDxtdmtzzj(long id)
        {
            _basemapDao.DeleteDxtdmtzzj(id);
        }
        public void DeleteDxtdmtzzj(string filter)
        {
            _basemapDao.DeleteDxtdmtzzj(filter);
        }
        #endregion
        
        #region Dxtjmdd方法
        public Dxtjmdd GetDxtjmdd(long id)
        {
            return _basemapDao.GetDxtjmdd(id);
        }
        
        public IEnumerable<Dxtjmdd> GetDxtjmdds(string filter)
        {
            return _basemapDao.GetDxtjmdds(filter);
        }
        public bool SaveDxtjmdd(Dxtjmdd dxtjmdd)
        {
            return _basemapDao.SaveDxtjmdd(dxtjmdd);
        }
        public void SaveDxtjmdds(List<Dxtjmdd> dxtjmdds)
        {
            _basemapDao.SaveDxtjmdds(dxtjmdds);        
        }
        public void DeleteDxtjmdd(Dxtjmdd rec)
        {
            _basemapDao.DeleteDxtjmdd(rec);
        }
        public void DeleteDxtjmdd(long id)
        {
            _basemapDao.DeleteDxtjmdd(id);
        }
        public void DeleteDxtjmdd(string filter)
        {
            _basemapDao.DeleteDxtjmdd(filter);
        }
        #endregion
        
        #region Dxtjmdm方法
        public Dxtjmdm GetDxtjmdm(long id)
        {
            return _basemapDao.GetDxtjmdm(id);
        }
        
        public IEnumerable<Dxtjmdm> GetDxtjmdms(string filter)
        {
            return _basemapDao.GetDxtjmdms(filter);
        }
        public bool SaveDxtjmdm(Dxtjmdm dxtjmdm)
        {
            return _basemapDao.SaveDxtjmdm(dxtjmdm);
        }
        public void SaveDxtjmdms(List<Dxtjmdm> dxtjmdms)
        {
            _basemapDao.SaveDxtjmdms(dxtjmdms);        
        }
        public void DeleteDxtjmdm(Dxtjmdm rec)
        {
            _basemapDao.DeleteDxtjmdm(rec);
        }
        public void DeleteDxtjmdm(long id)
        {
            _basemapDao.DeleteDxtjmdm(id);
        }
        public void DeleteDxtjmdm(string filter)
        {
            _basemapDao.DeleteDxtjmdm(filter);
        }
        #endregion
        
        #region Dxtjmdx方法
        public Dxtjmdx GetDxtjmdx(long id)
        {
            return _basemapDao.GetDxtjmdx(id);
        }
        
        public IEnumerable<Dxtjmdx> GetDxtjmdxes(string filter)
        {
            return _basemapDao.GetDxtjmdxes(filter);
        }
        public bool SaveDxtjmdx(Dxtjmdx dxtjmdx)
        {
            return _basemapDao.SaveDxtjmdx(dxtjmdx);
        }
        public void SaveDxtjmdxes(List<Dxtjmdx> dxtjmdxes)
        {
            _basemapDao.SaveDxtjmdxes(dxtjmdxes);        
        }
        public void DeleteDxtjmdx(Dxtjmdx rec)
        {
            _basemapDao.DeleteDxtjmdx(rec);
        }
        public void DeleteDxtjmdx(long id)
        {
            _basemapDao.DeleteDxtjmdx(id);
        }
        public void DeleteDxtjmdx(string filter)
        {
            _basemapDao.DeleteDxtjmdx(filter);
        }
        #endregion
        
        #region Dxtjmdzj方法
        public Dxtjmdzj GetDxtjmdzj(long id)
        {
            return _basemapDao.GetDxtjmdzj(id);
        }
        
        public IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter)
        {
            return _basemapDao.GetDxtjmdzjs(filter);
        }
        public bool SaveDxtjmdzj(Dxtjmdzj dxtjmdzj)
        {
            return _basemapDao.SaveDxtjmdzj(dxtjmdzj);
        }
        public void SaveDxtjmdzjs(List<Dxtjmdzj> dxtjmdzjs)
        {
            _basemapDao.SaveDxtjmdzjs(dxtjmdzjs);        
        }
        public void DeleteDxtjmdzj(Dxtjmdzj rec)
        {
            _basemapDao.DeleteDxtjmdzj(rec);
        }
        public void DeleteDxtjmdzj(long id)
        {
            _basemapDao.DeleteDxtjmdzj(id);
        }
        public void DeleteDxtjmdzj(string filter)
        {
            _basemapDao.DeleteDxtjmdzj(filter);
        }
        #endregion
        
        #region Dxtkzdd方法
        public Dxtkzdd GetDxtkzdd(long id)
        {
            return _basemapDao.GetDxtkzdd(id);
        }
        
        public IEnumerable<Dxtkzdd> GetDxtkzdds(string filter)
        {
            return _basemapDao.GetDxtkzdds(filter);
        }
        public bool SaveDxtkzdd(Dxtkzdd dxtkzdd)
        {
            return _basemapDao.SaveDxtkzdd(dxtkzdd);
        }
        public void SaveDxtkzdds(List<Dxtkzdd> dxtkzdds)
        {
            _basemapDao.SaveDxtkzdds(dxtkzdds);        
        }
        public void DeleteDxtkzdd(Dxtkzdd rec)
        {
            _basemapDao.DeleteDxtkzdd(rec);
        }
        public void DeleteDxtkzdd(long id)
        {
            _basemapDao.DeleteDxtkzdd(id);
        }
        public void DeleteDxtkzdd(string filter)
        {
            _basemapDao.DeleteDxtkzdd(filter);
        }
        #endregion
        
        #region Dxtkzdm方法
        public Dxtkzdm GetDxtkzdm(long id)
        {
            return _basemapDao.GetDxtkzdm(id);
        }
        
        public IEnumerable<Dxtkzdm> GetDxtkzdms(string filter)
        {
            return _basemapDao.GetDxtkzdms(filter);
        }
        public bool SaveDxtkzdm(Dxtkzdm dxtkzdm)
        {
            return _basemapDao.SaveDxtkzdm(dxtkzdm);
        }
        public void SaveDxtkzdms(List<Dxtkzdm> dxtkzdms)
        {
            _basemapDao.SaveDxtkzdms(dxtkzdms);        
        }
        public void DeleteDxtkzdm(Dxtkzdm rec)
        {
            _basemapDao.DeleteDxtkzdm(rec);
        }
        public void DeleteDxtkzdm(long id)
        {
            _basemapDao.DeleteDxtkzdm(id);
        }
        public void DeleteDxtkzdm(string filter)
        {
            _basemapDao.DeleteDxtkzdm(filter);
        }
        #endregion
        
        #region Dxtkzdx方法
        public Dxtkzdx GetDxtkzdx(long id)
        {
            return _basemapDao.GetDxtkzdx(id);
        }
        
        public IEnumerable<Dxtkzdx> GetDxtkzdxes(string filter)
        {
            return _basemapDao.GetDxtkzdxes(filter);
        }
        public bool SaveDxtkzdx(Dxtkzdx dxtkzdx)
        {
            return _basemapDao.SaveDxtkzdx(dxtkzdx);
        }
        public void SaveDxtkzdxes(List<Dxtkzdx> dxtkzdxes)
        {
            _basemapDao.SaveDxtkzdxes(dxtkzdxes);        
        }
        public void DeleteDxtkzdx(Dxtkzdx rec)
        {
            _basemapDao.DeleteDxtkzdx(rec);
        }
        public void DeleteDxtkzdx(long id)
        {
            _basemapDao.DeleteDxtkzdx(id);
        }
        public void DeleteDxtkzdx(string filter)
        {
            _basemapDao.DeleteDxtkzdx(filter);
        }
        #endregion
        
        #region Dxtkzdzj方法
        public Dxtkzdzj GetDxtkzdzj(long id)
        {
            return _basemapDao.GetDxtkzdzj(id);
        }
        
        public IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter)
        {
            return _basemapDao.GetDxtkzdzjs(filter);
        }
        public bool SaveDxtkzdzj(Dxtkzdzj dxtkzdzj)
        {
            return _basemapDao.SaveDxtkzdzj(dxtkzdzj);
        }
        public void SaveDxtkzdzjs(List<Dxtkzdzj> dxtkzdzjs)
        {
            _basemapDao.SaveDxtkzdzjs(dxtkzdzjs);        
        }
        public void DeleteDxtkzdzj(Dxtkzdzj rec)
        {
            _basemapDao.DeleteDxtkzdzj(rec);
        }
        public void DeleteDxtkzdzj(long id)
        {
            _basemapDao.DeleteDxtkzdzj(id);
        }
        public void DeleteDxtkzdzj(string filter)
        {
            _basemapDao.DeleteDxtkzdzj(filter);
        }
        #endregion
        
        #region Dxtqtd方法
        public Dxtqtd GetDxtqtd(long id)
        {
            return _basemapDao.GetDxtqtd(id);
        }
        
        public IEnumerable<Dxtqtd> GetDxtqtds(string filter)
        {
            return _basemapDao.GetDxtqtds(filter);
        }
        public bool SaveDxtqtd(Dxtqtd dxtqtd)
        {
            return _basemapDao.SaveDxtqtd(dxtqtd);
        }
        public void SaveDxtqtds(List<Dxtqtd> dxtqtds)
        {
            _basemapDao.SaveDxtqtds(dxtqtds);        
        }
        public void DeleteDxtqtd(Dxtqtd rec)
        {
            _basemapDao.DeleteDxtqtd(rec);
        }
        public void DeleteDxtqtd(long id)
        {
            _basemapDao.DeleteDxtqtd(id);
        }
        public void DeleteDxtqtd(string filter)
        {
            _basemapDao.DeleteDxtqtd(filter);
        }
        #endregion
        
        #region Dxtqtm方法
        public Dxtqtm GetDxtqtm(long id)
        {
            return _basemapDao.GetDxtqtm(id);
        }
        
        public IEnumerable<Dxtqtm> GetDxtqtms(string filter)
        {
            return _basemapDao.GetDxtqtms(filter);
        }
        public bool SaveDxtqtm(Dxtqtm dxtqtm)
        {
            return _basemapDao.SaveDxtqtm(dxtqtm);
        }
        public void SaveDxtqtms(List<Dxtqtm> dxtqtms)
        {
            _basemapDao.SaveDxtqtms(dxtqtms);        
        }
        public void DeleteDxtqtm(Dxtqtm rec)
        {
            _basemapDao.DeleteDxtqtm(rec);
        }
        public void DeleteDxtqtm(long id)
        {
            _basemapDao.DeleteDxtqtm(id);
        }
        public void DeleteDxtqtm(string filter)
        {
            _basemapDao.DeleteDxtqtm(filter);
        }
        #endregion
        
        #region Dxtqtx方法
        public Dxtqtx GetDxtqtx(long id)
        {
            return _basemapDao.GetDxtqtx(id);
        }
        
        public IEnumerable<Dxtqtx> GetDxtqtxes(string filter)
        {
            return _basemapDao.GetDxtqtxes(filter);
        }
        public bool SaveDxtqtx(Dxtqtx dxtqtx)
        {
            return _basemapDao.SaveDxtqtx(dxtqtx);
        }
        public void SaveDxtqtxes(List<Dxtqtx> dxtqtxes)
        {
            _basemapDao.SaveDxtqtxes(dxtqtxes);        
        }
        public void DeleteDxtqtx(Dxtqtx rec)
        {
            _basemapDao.DeleteDxtqtx(rec);
        }
        public void DeleteDxtqtx(long id)
        {
            _basemapDao.DeleteDxtqtx(id);
        }
        public void DeleteDxtqtx(string filter)
        {
            _basemapDao.DeleteDxtqtx(filter);
        }
        #endregion
        
        #region Dxtqtzj方法
        public Dxtqtzj GetDxtqtzj(long id)
        {
            return _basemapDao.GetDxtqtzj(id);
        }
        
        public IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter)
        {
            return _basemapDao.GetDxtqtzjs(filter);
        }
        public bool SaveDxtqtzj(Dxtqtzj dxtqtzj)
        {
            return _basemapDao.SaveDxtqtzj(dxtqtzj);
        }
        public void SaveDxtqtzjs(List<Dxtqtzj> dxtqtzjs)
        {
            _basemapDao.SaveDxtqtzjs(dxtqtzjs);        
        }
        public void DeleteDxtqtzj(Dxtqtzj rec)
        {
            _basemapDao.DeleteDxtqtzj(rec);
        }
        public void DeleteDxtqtzj(long id)
        {
            _basemapDao.DeleteDxtqtzj(id);
        }
        public void DeleteDxtqtzj(string filter)
        {
            _basemapDao.DeleteDxtqtzj(filter);
        }
        #endregion
        
        #region Dxtsxssd方法
        public Dxtsxssd GetDxtsxssd(long id)
        {
            return _basemapDao.GetDxtsxssd(id);
        }
        
        public IEnumerable<Dxtsxssd> GetDxtsxssds(string filter)
        {
            return _basemapDao.GetDxtsxssds(filter);
        }
        public bool SaveDxtsxssd(Dxtsxssd dxtsxssd)
        {
            return _basemapDao.SaveDxtsxssd(dxtsxssd);
        }
        public void SaveDxtsxssds(List<Dxtsxssd> dxtsxssds)
        {
            _basemapDao.SaveDxtsxssds(dxtsxssds);        
        }
        public void DeleteDxtsxssd(Dxtsxssd rec)
        {
            _basemapDao.DeleteDxtsxssd(rec);
        }
        public void DeleteDxtsxssd(long id)
        {
            _basemapDao.DeleteDxtsxssd(id);
        }
        public void DeleteDxtsxssd(string filter)
        {
            _basemapDao.DeleteDxtsxssd(filter);
        }
        #endregion
        
        #region Dxtsxssm方法
        public Dxtsxssm GetDxtsxssm(long id)
        {
            return _basemapDao.GetDxtsxssm(id);
        }
        
        public IEnumerable<Dxtsxssm> GetDxtsxssms(string filter)
        {
            return _basemapDao.GetDxtsxssms(filter);
        }
        public bool SaveDxtsxssm(Dxtsxssm dxtsxssm)
        {
            return _basemapDao.SaveDxtsxssm(dxtsxssm);
        }
        public void SaveDxtsxssms(List<Dxtsxssm> dxtsxssms)
        {
            _basemapDao.SaveDxtsxssms(dxtsxssms);        
        }
        public void DeleteDxtsxssm(Dxtsxssm rec)
        {
            _basemapDao.DeleteDxtsxssm(rec);
        }
        public void DeleteDxtsxssm(long id)
        {
            _basemapDao.DeleteDxtsxssm(id);
        }
        public void DeleteDxtsxssm(string filter)
        {
            _basemapDao.DeleteDxtsxssm(filter);
        }
        #endregion
        
        #region Dxtsxssx方法
        public Dxtsxssx GetDxtsxssx(long id)
        {
            return _basemapDao.GetDxtsxssx(id);
        }
        
        public IEnumerable<Dxtsxssx> GetDxtsxssxes(string filter)
        {
            return _basemapDao.GetDxtsxssxes(filter);
        }
        public bool SaveDxtsxssx(Dxtsxssx dxtsxssx)
        {
            return _basemapDao.SaveDxtsxssx(dxtsxssx);
        }
        public void SaveDxtsxssxes(List<Dxtsxssx> dxtsxssxes)
        {
            _basemapDao.SaveDxtsxssxes(dxtsxssxes);        
        }
        public void DeleteDxtsxssx(Dxtsxssx rec)
        {
            _basemapDao.DeleteDxtsxssx(rec);
        }
        public void DeleteDxtsxssx(long id)
        {
            _basemapDao.DeleteDxtsxssx(id);
        }
        public void DeleteDxtsxssx(string filter)
        {
            _basemapDao.DeleteDxtsxssx(filter);
        }
        #endregion
        
        #region Dxtsxsszj方法
        public Dxtsxsszj GetDxtsxsszj(long id)
        {
            return _basemapDao.GetDxtsxsszj(id);
        }
        
        public IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter)
        {
            return _basemapDao.GetDxtsxsszjs(filter);
        }
        public bool SaveDxtsxsszj(Dxtsxsszj dxtsxsszj)
        {
            return _basemapDao.SaveDxtsxsszj(dxtsxsszj);
        }
        public void SaveDxtsxsszjs(List<Dxtsxsszj> dxtsxsszjs)
        {
            _basemapDao.SaveDxtsxsszjs(dxtsxsszjs);        
        }
        public void DeleteDxtsxsszj(Dxtsxsszj rec)
        {
            _basemapDao.DeleteDxtsxsszj(rec);
        }
        public void DeleteDxtsxsszj(long id)
        {
            _basemapDao.DeleteDxtsxsszj(id);
        }
        public void DeleteDxtsxsszj(string filter)
        {
            _basemapDao.DeleteDxtsxsszj(filter);
        }
        #endregion
        
        #region Dxtzjd方法
        public Dxtzjd GetDxtzjd(long id)
        {
            return _basemapDao.GetDxtzjd(id);
        }
        
        public IEnumerable<Dxtzjd> GetDxtzjds(string filter)
        {
            return _basemapDao.GetDxtzjds(filter);
        }
        public bool SaveDxtzjd(Dxtzjd dxtzjd)
        {
            return _basemapDao.SaveDxtzjd(dxtzjd);
        }
        public void SaveDxtzjds(List<Dxtzjd> dxtzjds)
        {
            _basemapDao.SaveDxtzjds(dxtzjds);        
        }
        public void DeleteDxtzjd(Dxtzjd rec)
        {
            _basemapDao.DeleteDxtzjd(rec);
        }
        public void DeleteDxtzjd(long id)
        {
            _basemapDao.DeleteDxtzjd(id);
        }
        public void DeleteDxtzjd(string filter)
        {
            _basemapDao.DeleteDxtzjd(filter);
        }
        #endregion
        
        #region Dxtzjm方法
        public Dxtzjm GetDxtzjm(long id)
        {
            return _basemapDao.GetDxtzjm(id);
        }
        
        public IEnumerable<Dxtzjm> GetDxtzjms(string filter)
        {
            return _basemapDao.GetDxtzjms(filter);
        }
        public bool SaveDxtzjm(Dxtzjm dxtzjm)
        {
            return _basemapDao.SaveDxtzjm(dxtzjm);
        }
        public void SaveDxtzjms(List<Dxtzjm> dxtzjms)
        {
            _basemapDao.SaveDxtzjms(dxtzjms);        
        }
        public void DeleteDxtzjm(Dxtzjm rec)
        {
            _basemapDao.DeleteDxtzjm(rec);
        }
        public void DeleteDxtzjm(long id)
        {
            _basemapDao.DeleteDxtzjm(id);
        }
        public void DeleteDxtzjm(string filter)
        {
            _basemapDao.DeleteDxtzjm(filter);
        }
        #endregion
        
        #region Dxtzjx方法
        public Dxtzjx GetDxtzjx(long id)
        {
            return _basemapDao.GetDxtzjx(id);
        }
        
        public IEnumerable<Dxtzjx> GetDxtzjxes(string filter)
        {
            return _basemapDao.GetDxtzjxes(filter);
        }
        public bool SaveDxtzjx(Dxtzjx dxtzjx)
        {
            return _basemapDao.SaveDxtzjx(dxtzjx);
        }
        public void SaveDxtzjxes(List<Dxtzjx> dxtzjxes)
        {
            _basemapDao.SaveDxtzjxes(dxtzjxes);        
        }
        public void DeleteDxtzjx(Dxtzjx rec)
        {
            _basemapDao.DeleteDxtzjx(rec);
        }
        public void DeleteDxtzjx(long id)
        {
            _basemapDao.DeleteDxtzjx(id);
        }
        public void DeleteDxtzjx(string filter)
        {
            _basemapDao.DeleteDxtzjx(filter);
        }
        #endregion
        
        #region Dxtzjzj方法
        public Dxtzjzj GetDxtzjzj(long id)
        {
            return _basemapDao.GetDxtzjzj(id);
        }
        
        public IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter)
        {
            return _basemapDao.GetDxtzjzjs(filter);
        }
        public bool SaveDxtzjzj(Dxtzjzj dxtzjzj)
        {
            return _basemapDao.SaveDxtzjzj(dxtzjzj);
        }
        public void SaveDxtzjzjs(List<Dxtzjzj> dxtzjzjs)
        {
            _basemapDao.SaveDxtzjzjs(dxtzjzjs);        
        }
        public void DeleteDxtzjzj(Dxtzjzj rec)
        {
            _basemapDao.DeleteDxtzjzj(rec);
        }
        public void DeleteDxtzjzj(long id)
        {
            _basemapDao.DeleteDxtzjzj(id);
        }
        public void DeleteDxtzjzj(string filter)
        {
            _basemapDao.DeleteDxtzjzj(filter);
        }
        #endregion
        
        
       
        
       
        
    }
}