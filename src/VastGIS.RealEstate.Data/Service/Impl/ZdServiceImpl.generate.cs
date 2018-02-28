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
    public partial class ZdServiceImpl : ZdService
    {	
        private ZdDao _zdDao;
        
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
        
        public ZdServiceImpl(ZdDao zdDao)
        {
            this._zdDao = zdDao;
            this._zdDao.EntityChanged += ZdDao_EntityChanged;
        }
        
        private void ZdDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.OperationType,e.Entities);
        }
        
        #region ISQLiteService接口实现
        public int GetSRID()
        {
            return ((ISQLiteService)_zdDao).GetSRID();
        }

        public SQLiteConnection Connection { get { return ((ISQLiteService)_zdDao).Connection; } }

        public string CurrentUser { get { return _zdDao.CurrentUser; } set { _zdDao.CurrentUser = value; } }

        public bool Save(IEntity entity){return _zdDao.Save(entity);}
        public void Delete(IEntity entity){ _zdDao.Delete(entity);}
        public bool Save(List<IEntity> entities){return _zdDao.Save(entities);}
        public void Delete(List<IEntity> entities){ _zdDao.Delete(entities);}
                
        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceEntities,
            bool isDelete = false,
            bool isAttributeAutoTransform = true){
            return _zdDao.CopyEntities(targetClass,sourceEntities,isDelete,isAttributeAutoTransform);
        }
        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return _zdDao.CreateEntity(currentClass);
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            return _zdDao.GetEntity(currentClass, id);
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {
            return _zdDao.GetEntities(currentClass, queryFilter);
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _zdDao.ReorderAllPolygon(tableName);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y,double torenlance=1.0)
        {
            return _zdDao.FindFeatures(objectClass, x, y,torenlance);
        }
        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y,double torenlance=1.0)
        {
            return _zdDao.FindFeatures(objectClasses, x, y,torenlance);
        }
        #endregion
        
        #region C方法
        public C GetC(long id)
        {
            return _zdDao.GetC(id);
        }
        
        public IEnumerable<C> GetCS(string filter)
        {
            return _zdDao.GetCS(filter);
        }
        public bool SaveC(C c)
        {
            return _zdDao.SaveC(c);
        }
        public void SaveCS(List<C> cs)
        {
            _zdDao.SaveCS(cs);        
        }
        public void DeleteC(C rec)
        {
            _zdDao.DeleteC(rec);
        }
        public void DeleteC(long id)
        {
            _zdDao.DeleteC(id);
        }
        public void DeleteC(string filter)
        {
            _zdDao.DeleteC(filter);
        }
        #endregion
        
        #region Cfdj方法
        public Cfdj GetCfdj(long id)
        {
            return _zdDao.GetCfdj(id);
        }
        
        public IEnumerable<Cfdj> GetCfdjs(string filter)
        {
            return _zdDao.GetCfdjs(filter);
        }
        public bool SaveCfdj(Cfdj cfdj)
        {
            return _zdDao.SaveCfdj(cfdj);
        }
        public void SaveCfdjs(List<Cfdj> cfdjs)
        {
            _zdDao.SaveCfdjs(cfdjs);        
        }
        public void DeleteCfdj(Cfdj rec)
        {
            _zdDao.DeleteCfdj(rec);
        }
        public void DeleteCfdj(long id)
        {
            _zdDao.DeleteCfdj(id);
        }
        public void DeleteCfdj(string filter)
        {
            _zdDao.DeleteCfdj(filter);
        }
        #endregion
        
        #region Djq方法
        public Djq GetDjq(long id)
        {
            return _zdDao.GetDjq(id);
        }
        
        public IEnumerable<Djq> GetDjqs(string filter)
        {
            return _zdDao.GetDjqs(filter);
        }
        public bool SaveDjq(Djq djq)
        {
            return _zdDao.SaveDjq(djq);
        }
        public void SaveDjqs(List<Djq> djqs)
        {
            _zdDao.SaveDjqs(djqs);        
        }
        public void DeleteDjq(Djq rec)
        {
            _zdDao.DeleteDjq(rec);
        }
        public void DeleteDjq(long id)
        {
            _zdDao.DeleteDjq(id);
        }
        public void DeleteDjq(string filter)
        {
            _zdDao.DeleteDjq(filter);
        }
        #endregion
        
        #region Djzq方法
        public Djzq GetDjzq(long id)
        {
            return _zdDao.GetDjzq(id);
        }
        
        public IEnumerable<Djzq> GetDjzqs(string filter)
        {
            return _zdDao.GetDjzqs(filter);
        }
        public bool SaveDjzq(Djzq djzq)
        {
            return _zdDao.SaveDjzq(djzq);
        }
        public void SaveDjzqs(List<Djzq> djzqs)
        {
            _zdDao.SaveDjzqs(djzqs);        
        }
        public void DeleteDjzq(Djzq rec)
        {
            _zdDao.DeleteDjzq(rec);
        }
        public void DeleteDjzq(long id)
        {
            _zdDao.DeleteDjzq(id);
        }
        public void DeleteDjzq(string filter)
        {
            _zdDao.DeleteDjzq(filter);
        }
        #endregion
        
        #region Dyaq方法
        public Dyaq GetDyaq(long id)
        {
            return _zdDao.GetDyaq(id);
        }
        
        public IEnumerable<Dyaq> GetDyaqs(string filter)
        {
            return _zdDao.GetDyaqs(filter);
        }
        public bool SaveDyaq(Dyaq dyaq)
        {
            return _zdDao.SaveDyaq(dyaq);
        }
        public void SaveDyaqs(List<Dyaq> dyaqs)
        {
            _zdDao.SaveDyaqs(dyaqs);        
        }
        public void DeleteDyaq(Dyaq rec)
        {
            _zdDao.DeleteDyaq(rec);
        }
        public void DeleteDyaq(long id)
        {
            _zdDao.DeleteDyaq(id);
        }
        public void DeleteDyaq(string filter)
        {
            _zdDao.DeleteDyaq(filter);
        }
        #endregion
        
        #region Dyiq方法
        public Dyiq GetDyiq(long id)
        {
            return _zdDao.GetDyiq(id);
        }
        
        public IEnumerable<Dyiq> GetDyiqs(string filter)
        {
            return _zdDao.GetDyiqs(filter);
        }
        public bool SaveDyiq(Dyiq dyiq)
        {
            return _zdDao.SaveDyiq(dyiq);
        }
        public void SaveDyiqs(List<Dyiq> dyiqs)
        {
            _zdDao.SaveDyiqs(dyiqs);        
        }
        public void DeleteDyiq(Dyiq rec)
        {
            _zdDao.DeleteDyiq(rec);
        }
        public void DeleteDyiq(long id)
        {
            _zdDao.DeleteDyiq(id);
        }
        public void DeleteDyiq(string filter)
        {
            _zdDao.DeleteDyiq(filter);
        }
        #endregion
        
        #region Dzdzw方法
        public Dzdzw GetDzdzw(long id)
        {
            return _zdDao.GetDzdzw(id);
        }
        
        public IEnumerable<Dzdzw> GetDzdzws(string filter)
        {
            return _zdDao.GetDzdzws(filter);
        }
        public bool SaveDzdzw(Dzdzw dzdzw)
        {
            return _zdDao.SaveDzdzw(dzdzw);
        }
        public void SaveDzdzws(List<Dzdzw> dzdzws)
        {
            _zdDao.SaveDzdzws(dzdzws);        
        }
        public void DeleteDzdzw(Dzdzw rec)
        {
            _zdDao.DeleteDzdzw(rec);
        }
        public void DeleteDzdzw(long id)
        {
            _zdDao.DeleteDzdzw(id);
        }
        public void DeleteDzdzw(string filter)
        {
            _zdDao.DeleteDzdzw(filter);
        }
        #endregion
        
        #region Fdcq1方法
        public Fdcq1 GetFdcq1(long id)
        {
            return _zdDao.GetFdcq1(id);
        }
        
        public IEnumerable<Fdcq1> GetFdcq1s(string filter)
        {
            return _zdDao.GetFdcq1s(filter);
        }
        public bool SaveFdcq1(Fdcq1 fdcq1)
        {
            return _zdDao.SaveFdcq1(fdcq1);
        }
        public void SaveFdcq1s(List<Fdcq1> fdcq1s)
        {
            _zdDao.SaveFdcq1s(fdcq1s);        
        }
        public void DeleteFdcq1(Fdcq1 rec)
        {
            _zdDao.DeleteFdcq1(rec);
        }
        public void DeleteFdcq1(long id)
        {
            _zdDao.DeleteFdcq1(id);
        }
        public void DeleteFdcq1(string filter)
        {
            _zdDao.DeleteFdcq1(filter);
        }
        #endregion
        
        #region Fdcq2方法
        public Fdcq2 GetFdcq2(long id)
        {
            return _zdDao.GetFdcq2(id);
        }
        
        public IEnumerable<Fdcq2> GetFdcq2s(string filter)
        {
            return _zdDao.GetFdcq2s(filter);
        }
        public bool SaveFdcq2(Fdcq2 fdcq2)
        {
            return _zdDao.SaveFdcq2(fdcq2);
        }
        public void SaveFdcq2s(List<Fdcq2> fdcq2s)
        {
            _zdDao.SaveFdcq2s(fdcq2s);        
        }
        public void DeleteFdcq2(Fdcq2 rec)
        {
            _zdDao.DeleteFdcq2(rec);
        }
        public void DeleteFdcq2(long id)
        {
            _zdDao.DeleteFdcq2(id);
        }
        public void DeleteFdcq2(string filter)
        {
            _zdDao.DeleteFdcq2(filter);
        }
        #endregion
        
        #region Fdcq3方法
        public Fdcq3 GetFdcq3(long id)
        {
            return _zdDao.GetFdcq3(id);
        }
        
        public IEnumerable<Fdcq3> GetFdcq3s(string filter)
        {
            return _zdDao.GetFdcq3s(filter);
        }
        public bool SaveFdcq3(Fdcq3 fdcq3)
        {
            return _zdDao.SaveFdcq3(fdcq3);
        }
        public void SaveFdcq3s(List<Fdcq3> fdcq3s)
        {
            _zdDao.SaveFdcq3s(fdcq3s);        
        }
        public void DeleteFdcq3(Fdcq3 rec)
        {
            _zdDao.DeleteFdcq3(rec);
        }
        public void DeleteFdcq3(long id)
        {
            _zdDao.DeleteFdcq3(id);
        }
        public void DeleteFdcq3(string filter)
        {
            _zdDao.DeleteFdcq3(filter);
        }
        #endregion
        
        #region Fdcqxm方法
        public Fdcqxm GetFdcqxm(long id)
        {
            return _zdDao.GetFdcqxm(id);
        }
        
        public IEnumerable<Fdcqxm> GetFdcqxms(string filter)
        {
            return _zdDao.GetFdcqxms(filter);
        }
        public bool SaveFdcqxm(Fdcqxm fdcqxm)
        {
            return _zdDao.SaveFdcqxm(fdcqxm);
        }
        public void SaveFdcqxms(List<Fdcqxm> fdcqxms)
        {
            _zdDao.SaveFdcqxms(fdcqxms);        
        }
        public void DeleteFdcqxm(Fdcqxm rec)
        {
            _zdDao.DeleteFdcqxm(rec);
        }
        public void DeleteFdcqxm(long id)
        {
            _zdDao.DeleteFdcqxm(id);
        }
        public void DeleteFdcqxm(string filter)
        {
            _zdDao.DeleteFdcqxm(filter);
        }
        #endregion
        
        #region Fz方法
        public Fz GetFz(long id)
        {
            return _zdDao.GetFz(id);
        }
        
        public IEnumerable<Fz> GetFzs(string filter)
        {
            return _zdDao.GetFzs(filter);
        }
        public bool SaveFz(Fz fz)
        {
            return _zdDao.SaveFz(fz);
        }
        public void SaveFzs(List<Fz> fzs)
        {
            _zdDao.SaveFzs(fzs);        
        }
        public void DeleteFz(Fz rec)
        {
            _zdDao.DeleteFz(rec);
        }
        public void DeleteFz(long id)
        {
            _zdDao.DeleteFz(id);
        }
        public void DeleteFz(string filter)
        {
            _zdDao.DeleteFz(filter);
        }
        #endregion
        
        #region Gd方法
        public Gd GetGd(long id)
        {
            return _zdDao.GetGd(id);
        }
        
        public IEnumerable<Gd> GetGds(string filter)
        {
            return _zdDao.GetGds(filter);
        }
        public bool SaveGd(Gd gd)
        {
            return _zdDao.SaveGd(gd);
        }
        public void SaveGds(List<Gd> gds)
        {
            _zdDao.SaveGds(gds);        
        }
        public void DeleteGd(Gd rec)
        {
            _zdDao.DeleteGd(rec);
        }
        public void DeleteGd(long id)
        {
            _zdDao.DeleteGd(id);
        }
        public void DeleteGd(string filter)
        {
            _zdDao.DeleteGd(filter);
        }
        #endregion
        
        #region Gjzwsyq方法
        public Gjzwsyq GetGjzwsyq(long id)
        {
            return _zdDao.GetGjzwsyq(id);
        }
        
        public IEnumerable<Gjzwsyq> GetGjzwsyqs(string filter)
        {
            return _zdDao.GetGjzwsyqs(filter);
        }
        public bool SaveGjzwsyq(Gjzwsyq gjzwsyq)
        {
            return _zdDao.SaveGjzwsyq(gjzwsyq);
        }
        public void SaveGjzwsyqs(List<Gjzwsyq> gjzwsyqs)
        {
            _zdDao.SaveGjzwsyqs(gjzwsyqs);        
        }
        public void DeleteGjzwsyq(Gjzwsyq rec)
        {
            _zdDao.DeleteGjzwsyq(rec);
        }
        public void DeleteGjzwsyq(long id)
        {
            _zdDao.DeleteGjzwsyq(id);
        }
        public void DeleteGjzwsyq(string filter)
        {
            _zdDao.DeleteGjzwsyq(filter);
        }
        #endregion
        
        #region Gzw方法
        public Gzw GetGzw(long id)
        {
            return _zdDao.GetGzw(id);
        }
        
        public IEnumerable<Gzw> GetGzws(string filter)
        {
            return _zdDao.GetGzws(filter);
        }
        public bool SaveGzw(Gzw gzw)
        {
            return _zdDao.SaveGzw(gzw);
        }
        public void SaveGzws(List<Gzw> gzws)
        {
            _zdDao.SaveGzws(gzws);        
        }
        public void DeleteGzw(Gzw rec)
        {
            _zdDao.DeleteGzw(rec);
        }
        public void DeleteGzw(long id)
        {
            _zdDao.DeleteGzw(id);
        }
        public void DeleteGzw(string filter)
        {
            _zdDao.DeleteGzw(filter);
        }
        #endregion
        
        #region H方法
        public H GetH(long id)
        {
            return _zdDao.GetH(id);
        }
        
        public IEnumerable<H> GetHS(string filter)
        {
            return _zdDao.GetHS(filter);
        }
        public bool SaveH(H h)
        {
            return _zdDao.SaveH(h);
        }
        public void SaveHS(List<H> hs)
        {
            _zdDao.SaveHS(hs);        
        }
        public void DeleteH(H rec)
        {
            _zdDao.DeleteH(rec);
        }
        public void DeleteH(long id)
        {
            _zdDao.DeleteH(id);
        }
        public void DeleteH(string filter)
        {
            _zdDao.DeleteH(filter);
        }
        #endregion
        
        #region Hysyq方法
        public Hysyq GetHysyq(long id)
        {
            return _zdDao.GetHysyq(id);
        }
        
        public IEnumerable<Hysyq> GetHysyqs(string filter)
        {
            return _zdDao.GetHysyqs(filter);
        }
        public bool SaveHysyq(Hysyq hysyq)
        {
            return _zdDao.SaveHysyq(hysyq);
        }
        public void SaveHysyqs(List<Hysyq> hysyqs)
        {
            _zdDao.SaveHysyqs(hysyqs);        
        }
        public void DeleteHysyq(Hysyq rec)
        {
            _zdDao.DeleteHysyq(rec);
        }
        public void DeleteHysyq(long id)
        {
            _zdDao.DeleteHysyq(id);
        }
        public void DeleteHysyq(string filter)
        {
            _zdDao.DeleteHysyq(filter);
        }
        #endregion
        
        #region Jsydsyq方法
        public Jsydsyq GetJsydsyq(long id)
        {
            return _zdDao.GetJsydsyq(id);
        }
        
        public IEnumerable<Jsydsyq> GetJsydsyqs(string filter)
        {
            return _zdDao.GetJsydsyqs(filter);
        }
        public bool SaveJsydsyq(Jsydsyq jsydsyq)
        {
            return _zdDao.SaveJsydsyq(jsydsyq);
        }
        public void SaveJsydsyqs(List<Jsydsyq> jsydsyqs)
        {
            _zdDao.SaveJsydsyqs(jsydsyqs);        
        }
        public void DeleteJsydsyq(Jsydsyq rec)
        {
            _zdDao.DeleteJsydsyq(rec);
        }
        public void DeleteJsydsyq(long id)
        {
            _zdDao.DeleteJsydsyq(id);
        }
        public void DeleteJsydsyq(string filter)
        {
            _zdDao.DeleteJsydsyq(filter);
        }
        #endregion
        
        #region Jzd方法
        public Jzd GetJzd(long id)
        {
            return _zdDao.GetJzd(id);
        }
        
        public IEnumerable<Jzd> GetJzds(string filter)
        {
            return _zdDao.GetJzds(filter);
        }
        public bool SaveJzd(Jzd jzd)
        {
            return _zdDao.SaveJzd(jzd);
        }
        public void SaveJzds(List<Jzd> jzds)
        {
            _zdDao.SaveJzds(jzds);        
        }
        public void DeleteJzd(Jzd rec)
        {
            _zdDao.DeleteJzd(rec);
        }
        public void DeleteJzd(long id)
        {
            _zdDao.DeleteJzd(id);
        }
        public void DeleteJzd(string filter)
        {
            _zdDao.DeleteJzd(filter);
        }
        #endregion
        
        #region Jzdzj方法
        public Jzdzj GetJzdzj(long id)
        {
            return _zdDao.GetJzdzj(id);
        }
        
        public IEnumerable<Jzdzj> GetJzdzjs(string filter)
        {
            return _zdDao.GetJzdzjs(filter);
        }
        public bool SaveJzdzj(Jzdzj jzdzj)
        {
            return _zdDao.SaveJzdzj(jzdzj);
        }
        public void SaveJzdzjs(List<Jzdzj> jzdzjs)
        {
            _zdDao.SaveJzdzjs(jzdzjs);        
        }
        public void DeleteJzdzj(Jzdzj rec)
        {
            _zdDao.DeleteJzdzj(rec);
        }
        public void DeleteJzdzj(long id)
        {
            _zdDao.DeleteJzdzj(id);
        }
        public void DeleteJzdzj(string filter)
        {
            _zdDao.DeleteJzdzj(filter);
        }
        #endregion
        
        #region Jzx方法
        public Jzx GetJzx(long id)
        {
            return _zdDao.GetJzx(id);
        }
        
        public IEnumerable<Jzx> GetJzxes(string filter)
        {
            return _zdDao.GetJzxes(filter);
        }
        public bool SaveJzx(Jzx jzx)
        {
            return _zdDao.SaveJzx(jzx);
        }
        public void SaveJzxes(List<Jzx> jzxes)
        {
            _zdDao.SaveJzxes(jzxes);        
        }
        public void DeleteJzx(Jzx rec)
        {
            _zdDao.DeleteJzx(rec);
        }
        public void DeleteJzx(long id)
        {
            _zdDao.DeleteJzx(id);
        }
        public void DeleteJzx(string filter)
        {
            _zdDao.DeleteJzx(filter);
        }
        #endregion
        
        #region Jzxzj方法
        public Jzxzj GetJzxzj(long id)
        {
            return _zdDao.GetJzxzj(id);
        }
        
        public IEnumerable<Jzxzj> GetJzxzjs(string filter)
        {
            return _zdDao.GetJzxzjs(filter);
        }
        public bool SaveJzxzj(Jzxzj jzxzj)
        {
            return _zdDao.SaveJzxzj(jzxzj);
        }
        public void SaveJzxzjs(List<Jzxzj> jzxzjs)
        {
            _zdDao.SaveJzxzjs(jzxzjs);        
        }
        public void DeleteJzxzj(Jzxzj rec)
        {
            _zdDao.DeleteJzxzj(rec);
        }
        public void DeleteJzxzj(long id)
        {
            _zdDao.DeleteJzxzj(id);
        }
        public void DeleteJzxzj(string filter)
        {
            _zdDao.DeleteJzxzj(filter);
        }
        #endregion
        
        #region Ljz方法
        public Ljz GetLjz(long id)
        {
            return _zdDao.GetLjz(id);
        }
        
        public IEnumerable<Ljz> GetLjzs(string filter)
        {
            return _zdDao.GetLjzs(filter);
        }
        public bool SaveLjz(Ljz ljz)
        {
            return _zdDao.SaveLjz(ljz);
        }
        public void SaveLjzs(List<Ljz> ljzs)
        {
            _zdDao.SaveLjzs(ljzs);        
        }
        public void DeleteLjz(Ljz rec)
        {
            _zdDao.DeleteLjz(rec);
        }
        public void DeleteLjz(long id)
        {
            _zdDao.DeleteLjz(id);
        }
        public void DeleteLjz(string filter)
        {
            _zdDao.DeleteLjz(filter);
        }
        #endregion
        
        #region Lq方法
        public Lq GetLq(long id)
        {
            return _zdDao.GetLq(id);
        }
        
        public IEnumerable<Lq> GetLqs(string filter)
        {
            return _zdDao.GetLqs(filter);
        }
        public bool SaveLq(Lq lq)
        {
            return _zdDao.SaveLq(lq);
        }
        public void SaveLqs(List<Lq> lqs)
        {
            _zdDao.SaveLqs(lqs);        
        }
        public void DeleteLq(Lq rec)
        {
            _zdDao.DeleteLq(rec);
        }
        public void DeleteLq(long id)
        {
            _zdDao.DeleteLq(id);
        }
        public void DeleteLq(string filter)
        {
            _zdDao.DeleteLq(filter);
        }
        #endregion
        
        #region Mzdzw方法
        public Mzdzw GetMzdzw(long id)
        {
            return _zdDao.GetMzdzw(id);
        }
        
        public IEnumerable<Mzdzw> GetMzdzws(string filter)
        {
            return _zdDao.GetMzdzws(filter);
        }
        public bool SaveMzdzw(Mzdzw mzdzw)
        {
            return _zdDao.SaveMzdzw(mzdzw);
        }
        public void SaveMzdzws(List<Mzdzw> mzdzws)
        {
            _zdDao.SaveMzdzws(mzdzws);        
        }
        public void DeleteMzdzw(Mzdzw rec)
        {
            _zdDao.DeleteMzdzw(rec);
        }
        public void DeleteMzdzw(long id)
        {
            _zdDao.DeleteMzdzw(id);
        }
        public void DeleteMzdzw(string filter)
        {
            _zdDao.DeleteMzdzw(filter);
        }
        #endregion
        
        #region Nydsyq方法
        public Nydsyq GetNydsyq(long id)
        {
            return _zdDao.GetNydsyq(id);
        }
        
        public IEnumerable<Nydsyq> GetNydsyqs(string filter)
        {
            return _zdDao.GetNydsyqs(filter);
        }
        public bool SaveNydsyq(Nydsyq nydsyq)
        {
            return _zdDao.SaveNydsyq(nydsyq);
        }
        public void SaveNydsyqs(List<Nydsyq> nydsyqs)
        {
            _zdDao.SaveNydsyqs(nydsyqs);        
        }
        public void DeleteNydsyq(Nydsyq rec)
        {
            _zdDao.DeleteNydsyq(rec);
        }
        public void DeleteNydsyq(long id)
        {
            _zdDao.DeleteNydsyq(id);
        }
        public void DeleteNydsyq(string filter)
        {
            _zdDao.DeleteNydsyq(filter);
        }
        #endregion
        
        #region Qlr方法
        public Qlr GetQlr(long id)
        {
            return _zdDao.GetQlr(id);
        }
        
        public IEnumerable<Qlr> GetQlrs(string filter)
        {
            return _zdDao.GetQlrs(filter);
        }
        public bool SaveQlr(Qlr qlr)
        {
            return _zdDao.SaveQlr(qlr);
        }
        public void SaveQlrs(List<Qlr> qlrs)
        {
            _zdDao.SaveQlrs(qlrs);        
        }
        public void DeleteQlr(Qlr rec)
        {
            _zdDao.DeleteQlr(rec);
        }
        public void DeleteQlr(long id)
        {
            _zdDao.DeleteQlr(id);
        }
        public void DeleteQlr(string filter)
        {
            _zdDao.DeleteQlr(filter);
        }
        #endregion
        
        #region Qtxgql方法
        public Qtxgql GetQtxgql(long id)
        {
            return _zdDao.GetQtxgql(id);
        }
        
        public IEnumerable<Qtxgql> GetQtxgqls(string filter)
        {
            return _zdDao.GetQtxgqls(filter);
        }
        public bool SaveQtxgql(Qtxgql qtxgql)
        {
            return _zdDao.SaveQtxgql(qtxgql);
        }
        public void SaveQtxgqls(List<Qtxgql> qtxgqls)
        {
            _zdDao.SaveQtxgqls(qtxgqls);        
        }
        public void DeleteQtxgql(Qtxgql rec)
        {
            _zdDao.DeleteQtxgql(rec);
        }
        public void DeleteQtxgql(long id)
        {
            _zdDao.DeleteQtxgql(id);
        }
        public void DeleteQtxgql(string filter)
        {
            _zdDao.DeleteQtxgql(filter);
        }
        #endregion
        
        #region Qxzd方法
        public Qxzd GetQxzd(long id)
        {
            return _zdDao.GetQxzd(id);
        }
        
        public IEnumerable<Qxzd> GetQxzds(string filter)
        {
            return _zdDao.GetQxzds(filter);
        }
        public bool SaveQxzd(Qxzd qxzd)
        {
            return _zdDao.SaveQxzd(qxzd);
        }
        public void SaveQxzds(List<Qxzd> qxzds)
        {
            _zdDao.SaveQxzds(qxzds);        
        }
        public void DeleteQxzd(Qxzd rec)
        {
            _zdDao.DeleteQxzd(rec);
        }
        public void DeleteQxzd(long id)
        {
            _zdDao.DeleteQxzd(id);
        }
        public void DeleteQxzd(string filter)
        {
            _zdDao.DeleteQxzd(filter);
        }
        #endregion
        
        #region R方法
        public R GetR(long id)
        {
            return _zdDao.GetR(id);
        }
        
        public IEnumerable<R> GetRS(string filter)
        {
            return _zdDao.GetRS(filter);
        }
        public bool SaveR(R r)
        {
            return _zdDao.SaveR(r);
        }
        public void SaveRS(List<R> rs)
        {
            _zdDao.SaveRS(rs);        
        }
        public void DeleteR(R rec)
        {
            _zdDao.DeleteR(rec);
        }
        public void DeleteR(long id)
        {
            _zdDao.DeleteR(id);
        }
        public void DeleteR(string filter)
        {
            _zdDao.DeleteR(filter);
        }
        #endregion
        
        #region Sf方法
        public Sf GetSf(long id)
        {
            return _zdDao.GetSf(id);
        }
        
        public IEnumerable<Sf> GetSfs(string filter)
        {
            return _zdDao.GetSfs(filter);
        }
        public bool SaveSf(Sf sf)
        {
            return _zdDao.SaveSf(sf);
        }
        public void SaveSfs(List<Sf> sfs)
        {
            _zdDao.SaveSfs(sfs);        
        }
        public void DeleteSf(Sf rec)
        {
            _zdDao.DeleteSf(rec);
        }
        public void DeleteSf(long id)
        {
            _zdDao.DeleteSf(id);
        }
        public void DeleteSf(string filter)
        {
            _zdDao.DeleteSf(filter);
        }
        #endregion
        
        #region Sgsj方法
        public Sgsj GetSgsj(long id)
        {
            return _zdDao.GetSgsj(id);
        }
        
        public IEnumerable<Sgsj> GetSgsjs(string filter)
        {
            return _zdDao.GetSgsjs(filter);
        }
        public bool SaveSgsj(Sgsj sgsj)
        {
            return _zdDao.SaveSgsj(sgsj);
        }
        public void SaveSgsjs(List<Sgsj> sgsjs)
        {
            _zdDao.SaveSgsjs(sgsjs);        
        }
        public void DeleteSgsj(Sgsj rec)
        {
            _zdDao.DeleteSgsj(rec);
        }
        public void DeleteSgsj(long id)
        {
            _zdDao.DeleteSgsj(id);
        }
        public void DeleteSgsj(string filter)
        {
            _zdDao.DeleteSgsj(filter);
        }
        #endregion
        
        #region Sh方法
        public Sh GetSh(long id)
        {
            return _zdDao.GetSh(id);
        }
        
        public IEnumerable<Sh> GetShes(string filter)
        {
            return _zdDao.GetShes(filter);
        }
        public bool SaveSh(Sh sh)
        {
            return _zdDao.SaveSh(sh);
        }
        public void SaveShes(List<Sh> shes)
        {
            _zdDao.SaveShes(shes);        
        }
        public void DeleteSh(Sh rec)
        {
            _zdDao.DeleteSh(rec);
        }
        public void DeleteSh(long id)
        {
            _zdDao.DeleteSh(id);
        }
        public void DeleteSh(string filter)
        {
            _zdDao.DeleteSh(filter);
        }
        #endregion
        
        #region Sj方法
        public Sj GetSj(long id)
        {
            return _zdDao.GetSj(id);
        }
        
        public IEnumerable<Sj> GetSjs(string filter)
        {
            return _zdDao.GetSjs(filter);
        }
        public bool SaveSj(Sj sj)
        {
            return _zdDao.SaveSj(sj);
        }
        public void SaveSjs(List<Sj> sjs)
        {
            _zdDao.SaveSjs(sjs);        
        }
        public void DeleteSj(Sj rec)
        {
            _zdDao.DeleteSj(rec);
        }
        public void DeleteSj(long id)
        {
            _zdDao.DeleteSj(id);
        }
        public void DeleteSj(string filter)
        {
            _zdDao.DeleteSj(filter);
        }
        #endregion
        
        #region Slsq方法
        public Slsq GetSlsq(long id)
        {
            return _zdDao.GetSlsq(id);
        }
        
        public IEnumerable<Slsq> GetSlsqs(string filter)
        {
            return _zdDao.GetSlsqs(filter);
        }
        public bool SaveSlsq(Slsq slsq)
        {
            return _zdDao.SaveSlsq(slsq);
        }
        public void SaveSlsqs(List<Slsq> slsqs)
        {
            _zdDao.SaveSlsqs(slsqs);        
        }
        public void DeleteSlsq(Slsq rec)
        {
            _zdDao.DeleteSlsq(rec);
        }
        public void DeleteSlsq(long id)
        {
            _zdDao.DeleteSlsq(id);
        }
        public void DeleteSlsq(string filter)
        {
            _zdDao.DeleteSlsq(filter);
        }
        #endregion
        
        #region Sqr方法
        public Sqr GetSqr(long id)
        {
            return _zdDao.GetSqr(id);
        }
        
        public IEnumerable<Sqr> GetSqrs(string filter)
        {
            return _zdDao.GetSqrs(filter);
        }
        public bool SaveSqr(Sqr sqr)
        {
            return _zdDao.SaveSqr(sqr);
        }
        public void SaveSqrs(List<Sqr> sqrs)
        {
            _zdDao.SaveSqrs(sqrs);        
        }
        public void DeleteSqr(Sqr rec)
        {
            _zdDao.DeleteSqr(rec);
        }
        public void DeleteSqr(long id)
        {
            _zdDao.DeleteSqr(id);
        }
        public void DeleteSqr(string filter)
        {
            _zdDao.DeleteSqr(filter);
        }
        #endregion
        
        #region Sz方法
        public Sz GetSz(long id)
        {
            return _zdDao.GetSz(id);
        }
        
        public IEnumerable<Sz> GetSzs(string filter)
        {
            return _zdDao.GetSzs(filter);
        }
        public bool SaveSz(Sz sz)
        {
            return _zdDao.SaveSz(sz);
        }
        public void SaveSzs(List<Sz> szs)
        {
            _zdDao.SaveSzs(szs);        
        }
        public void DeleteSz(Sz rec)
        {
            _zdDao.DeleteSz(rec);
        }
        public void DeleteSz(long id)
        {
            _zdDao.DeleteSz(id);
        }
        public void DeleteSz(string filter)
        {
            _zdDao.DeleteSz(filter);
        }
        #endregion
        
        #region Tdsyq方法
        public Tdsyq GetTdsyq(long id)
        {
            return _zdDao.GetTdsyq(id);
        }
        
        public IEnumerable<Tdsyq> GetTdsyqs(string filter)
        {
            return _zdDao.GetTdsyqs(filter);
        }
        public bool SaveTdsyq(Tdsyq tdsyq)
        {
            return _zdDao.SaveTdsyq(tdsyq);
        }
        public void SaveTdsyqs(List<Tdsyq> tdsyqs)
        {
            _zdDao.SaveTdsyqs(tdsyqs);        
        }
        public void DeleteTdsyq(Tdsyq rec)
        {
            _zdDao.DeleteTdsyq(rec);
        }
        public void DeleteTdsyq(long id)
        {
            _zdDao.DeleteTdsyq(id);
        }
        public void DeleteTdsyq(string filter)
        {
            _zdDao.DeleteTdsyq(filter);
        }
        #endregion
        
        #region Xzdzw方法
        public Xzdzw GetXzdzw(long id)
        {
            return _zdDao.GetXzdzw(id);
        }
        
        public IEnumerable<Xzdzw> GetXzdzws(string filter)
        {
            return _zdDao.GetXzdzws(filter);
        }
        public bool SaveXzdzw(Xzdzw xzdzw)
        {
            return _zdDao.SaveXzdzw(xzdzw);
        }
        public void SaveXzdzws(List<Xzdzw> xzdzws)
        {
            _zdDao.SaveXzdzws(xzdzws);        
        }
        public void DeleteXzdzw(Xzdzw rec)
        {
            _zdDao.DeleteXzdzw(rec);
        }
        public void DeleteXzdzw(long id)
        {
            _zdDao.DeleteXzdzw(id);
        }
        public void DeleteXzdzw(string filter)
        {
            _zdDao.DeleteXzdzw(filter);
        }
        #endregion
        
        #region Xzq方法
        public Xzq GetXzq(long id)
        {
            return _zdDao.GetXzq(id);
        }
        
        public IEnumerable<Xzq> GetXzqs(string filter)
        {
            return _zdDao.GetXzqs(filter);
        }
        public bool SaveXzq(Xzq xzq)
        {
            return _zdDao.SaveXzq(xzq);
        }
        public void SaveXzqs(List<Xzq> xzqs)
        {
            _zdDao.SaveXzqs(xzqs);        
        }
        public void DeleteXzq(Xzq rec)
        {
            _zdDao.DeleteXzq(rec);
        }
        public void DeleteXzq(long id)
        {
            _zdDao.DeleteXzq(id);
        }
        public void DeleteXzq(string filter)
        {
            _zdDao.DeleteXzq(filter);
        }
        #endregion
        
        #region Xzqjx方法
        public Xzqjx GetXzqjx(long id)
        {
            return _zdDao.GetXzqjx(id);
        }
        
        public IEnumerable<Xzqjx> GetXzqjxes(string filter)
        {
            return _zdDao.GetXzqjxes(filter);
        }
        public bool SaveXzqjx(Xzqjx xzqjx)
        {
            return _zdDao.SaveXzqjx(xzqjx);
        }
        public void SaveXzqjxes(List<Xzqjx> xzqjxes)
        {
            _zdDao.SaveXzqjxes(xzqjxes);        
        }
        public void DeleteXzqjx(Xzqjx rec)
        {
            _zdDao.DeleteXzqjx(rec);
        }
        public void DeleteXzqjx(long id)
        {
            _zdDao.DeleteXzqjx(id);
        }
        public void DeleteXzqjx(string filter)
        {
            _zdDao.DeleteXzqjx(filter);
        }
        #endregion
        
        #region Xzqzj方法
        public Xzqzj GetXzqzj(long id)
        {
            return _zdDao.GetXzqzj(id);
        }
        
        public IEnumerable<Xzqzj> GetXzqzjs(string filter)
        {
            return _zdDao.GetXzqzjs(filter);
        }
        public bool SaveXzqzj(Xzqzj xzqzj)
        {
            return _zdDao.SaveXzqzj(xzqzj);
        }
        public void SaveXzqzjs(List<Xzqzj> xzqzjs)
        {
            _zdDao.SaveXzqzjs(xzqzjs);        
        }
        public void DeleteXzqzj(Xzqzj rec)
        {
            _zdDao.DeleteXzqzj(rec);
        }
        public void DeleteXzqzj(long id)
        {
            _zdDao.DeleteXzqzj(id);
        }
        public void DeleteXzqzj(string filter)
        {
            _zdDao.DeleteXzqzj(filter);
        }
        #endregion
        
        #region Ygdj方法
        public Ygdj GetYgdj(long id)
        {
            return _zdDao.GetYgdj(id);
        }
        
        public IEnumerable<Ygdj> GetYgdjs(string filter)
        {
            return _zdDao.GetYgdjs(filter);
        }
        public bool SaveYgdj(Ygdj ygdj)
        {
            return _zdDao.SaveYgdj(ygdj);
        }
        public void SaveYgdjs(List<Ygdj> ygdjs)
        {
            _zdDao.SaveYgdjs(ygdjs);        
        }
        public void DeleteYgdj(Ygdj rec)
        {
            _zdDao.DeleteYgdj(rec);
        }
        public void DeleteYgdj(long id)
        {
            _zdDao.DeleteYgdj(id);
        }
        public void DeleteYgdj(string filter)
        {
            _zdDao.DeleteYgdj(filter);
        }
        #endregion
        
        #region Yhydzb方法
        public Yhydzb GetYhydzb(long id)
        {
            return _zdDao.GetYhydzb(id);
        }
        
        public IEnumerable<Yhydzb> GetYhydzbs(string filter)
        {
            return _zdDao.GetYhydzbs(filter);
        }
        public bool SaveYhydzb(Yhydzb yhydzb)
        {
            return _zdDao.SaveYhydzb(yhydzb);
        }
        public void SaveYhydzbs(List<Yhydzb> yhydzbs)
        {
            _zdDao.SaveYhydzbs(yhydzbs);        
        }
        public void DeleteYhydzb(Yhydzb rec)
        {
            _zdDao.DeleteYhydzb(rec);
        }
        public void DeleteYhydzb(long id)
        {
            _zdDao.DeleteYhydzb(id);
        }
        public void DeleteYhydzb(string filter)
        {
            _zdDao.DeleteYhydzb(filter);
        }
        #endregion
        
        #region Yhzk方法
        public Yhzk GetYhzk(long id)
        {
            return _zdDao.GetYhzk(id);
        }
        
        public IEnumerable<Yhzk> GetYhzks(string filter)
        {
            return _zdDao.GetYhzks(filter);
        }
        public bool SaveYhzk(Yhzk yhzk)
        {
            return _zdDao.SaveYhzk(yhzk);
        }
        public void SaveYhzks(List<Yhzk> yhzks)
        {
            _zdDao.SaveYhzks(yhzks);        
        }
        public void DeleteYhzk(Yhzk rec)
        {
            _zdDao.DeleteYhzk(rec);
        }
        public void DeleteYhzk(long id)
        {
            _zdDao.DeleteYhzk(id);
        }
        public void DeleteYhzk(string filter)
        {
            _zdDao.DeleteYhzk(filter);
        }
        #endregion
        
        #region Yydj方法
        public Yydj GetYydj(long id)
        {
            return _zdDao.GetYydj(id);
        }
        
        public IEnumerable<Yydj> GetYydjs(string filter)
        {
            return _zdDao.GetYydjs(filter);
        }
        public bool SaveYydj(Yydj yydj)
        {
            return _zdDao.SaveYydj(yydj);
        }
        public void SaveYydjs(List<Yydj> yydjs)
        {
            _zdDao.SaveYydjs(yydjs);        
        }
        public void DeleteYydj(Yydj rec)
        {
            _zdDao.DeleteYydj(rec);
        }
        public void DeleteYydj(long id)
        {
            _zdDao.DeleteYydj(id);
        }
        public void DeleteYydj(string filter)
        {
            _zdDao.DeleteYydj(filter);
        }
        #endregion
        
        #region Zdbhqk方法
        public Zdbhqk GetZdbhqk(long id)
        {
            return _zdDao.GetZdbhqk(id);
        }
        
        public IEnumerable<Zdbhqk> GetZdbhqks(string filter)
        {
            return _zdDao.GetZdbhqks(filter);
        }
        public bool SaveZdbhqk(Zdbhqk zdbhqk)
        {
            return _zdDao.SaveZdbhqk(zdbhqk);
        }
        public void SaveZdbhqks(List<Zdbhqk> zdbhqks)
        {
            _zdDao.SaveZdbhqks(zdbhqks);        
        }
        public void DeleteZdbhqk(Zdbhqk rec)
        {
            _zdDao.DeleteZdbhqk(rec);
        }
        public void DeleteZdbhqk(long id)
        {
            _zdDao.DeleteZdbhqk(id);
        }
        public void DeleteZdbhqk(string filter)
        {
            _zdDao.DeleteZdbhqk(filter);
        }
        #endregion
        
        #region Zdjbxx方法
        public Zdjbxx GetZdjbxx(long id)
        {
            return _zdDao.GetZdjbxx(id);
        }
        
        public IEnumerable<Zdjbxx> GetZdjbxxes(string filter)
        {
            return _zdDao.GetZdjbxxes(filter);
        }
        public bool SaveZdjbxx(Zdjbxx zdjbxx)
        {
            return _zdDao.SaveZdjbxx(zdjbxx);
        }
        public void SaveZdjbxxes(List<Zdjbxx> zdjbxxes)
        {
            _zdDao.SaveZdjbxxes(zdjbxxes);        
        }
        public void DeleteZdjbxx(Zdjbxx rec)
        {
            _zdDao.DeleteZdjbxx(rec);
        }
        public void DeleteZdjbxx(long id)
        {
            _zdDao.DeleteZdjbxx(id);
        }
        public void DeleteZdjbxx(string filter)
        {
            _zdDao.DeleteZdjbxx(filter);
        }
        #endregion
        
        #region Zdjbxxzj方法
        public Zdjbxxzj GetZdjbxxzj(long id)
        {
            return _zdDao.GetZdjbxxzj(id);
        }
        
        public IEnumerable<Zdjbxxzj> GetZdjbxxzjs(string filter)
        {
            return _zdDao.GetZdjbxxzjs(filter);
        }
        public bool SaveZdjbxxzj(Zdjbxxzj zdjbxxzj)
        {
            return _zdDao.SaveZdjbxxzj(zdjbxxzj);
        }
        public void SaveZdjbxxzjs(List<Zdjbxxzj> zdjbxxzjs)
        {
            _zdDao.SaveZdjbxxzjs(zdjbxxzjs);        
        }
        public void DeleteZdjbxxzj(Zdjbxxzj rec)
        {
            _zdDao.DeleteZdjbxxzj(rec);
        }
        public void DeleteZdjbxxzj(long id)
        {
            _zdDao.DeleteZdjbxxzj(id);
        }
        public void DeleteZdjbxxzj(string filter)
        {
            _zdDao.DeleteZdjbxxzj(filter);
        }
        #endregion
        
        #region Zdtojzd方法
        public Zdtojzd GetZdtojzd(long id)
        {
            return _zdDao.GetZdtojzd(id);
        }
        
        public IEnumerable<Zdtojzd> GetZdtojzds(string filter)
        {
            return _zdDao.GetZdtojzds(filter);
        }
        public bool SaveZdtojzd(Zdtojzd zdtojzd)
        {
            return _zdDao.SaveZdtojzd(zdtojzd);
        }
        public void SaveZdtojzds(List<Zdtojzd> zdtojzds)
        {
            _zdDao.SaveZdtojzds(zdtojzds);        
        }
        public void DeleteZdtojzd(Zdtojzd rec)
        {
            _zdDao.DeleteZdtojzd(rec);
        }
        public void DeleteZdtojzd(long id)
        {
            _zdDao.DeleteZdtojzd(id);
        }
        public void DeleteZdtojzd(string filter)
        {
            _zdDao.DeleteZdtojzd(filter);
        }
        #endregion
        
        #region Zdtojzx方法
        public Zdtojzx GetZdtojzx(long id)
        {
            return _zdDao.GetZdtojzx(id);
        }
        
        public IEnumerable<Zdtojzx> GetZdtojzxes(string filter)
        {
            return _zdDao.GetZdtojzxes(filter);
        }
        public bool SaveZdtojzx(Zdtojzx zdtojzx)
        {
            return _zdDao.SaveZdtojzx(zdtojzx);
        }
        public void SaveZdtojzxes(List<Zdtojzx> zdtojzxes)
        {
            _zdDao.SaveZdtojzxes(zdtojzxes);        
        }
        public void DeleteZdtojzx(Zdtojzx rec)
        {
            _zdDao.DeleteZdtojzx(rec);
        }
        public void DeleteZdtojzx(long id)
        {
            _zdDao.DeleteZdtojzx(id);
        }
        public void DeleteZdtojzx(string filter)
        {
            _zdDao.DeleteZdtojzx(filter);
        }
        #endregion
        
        #region Zhbhqk方法
        public Zhbhqk GetZhbhqk(long id)
        {
            return _zdDao.GetZhbhqk(id);
        }
        
        public IEnumerable<Zhbhqk> GetZhbhqks(string filter)
        {
            return _zdDao.GetZhbhqks(filter);
        }
        public bool SaveZhbhqk(Zhbhqk zhbhqk)
        {
            return _zdDao.SaveZhbhqk(zhbhqk);
        }
        public void SaveZhbhqks(List<Zhbhqk> zhbhqks)
        {
            _zdDao.SaveZhbhqks(zhbhqks);        
        }
        public void DeleteZhbhqk(Zhbhqk rec)
        {
            _zdDao.DeleteZhbhqk(rec);
        }
        public void DeleteZhbhqk(long id)
        {
            _zdDao.DeleteZhbhqk(id);
        }
        public void DeleteZhbhqk(string filter)
        {
            _zdDao.DeleteZhbhqk(filter);
        }
        #endregion
        
        #region Zhjbxx方法
        public Zhjbxx GetZhjbxx(long id)
        {
            return _zdDao.GetZhjbxx(id);
        }
        
        public IEnumerable<Zhjbxx> GetZhjbxxes(string filter)
        {
            return _zdDao.GetZhjbxxes(filter);
        }
        public bool SaveZhjbxx(Zhjbxx zhjbxx)
        {
            return _zdDao.SaveZhjbxx(zhjbxx);
        }
        public void SaveZhjbxxes(List<Zhjbxx> zhjbxxes)
        {
            _zdDao.SaveZhjbxxes(zhjbxxes);        
        }
        public void DeleteZhjbxx(Zhjbxx rec)
        {
            _zdDao.DeleteZhjbxx(rec);
        }
        public void DeleteZhjbxx(long id)
        {
            _zdDao.DeleteZhjbxx(id);
        }
        public void DeleteZhjbxx(string filter)
        {
            _zdDao.DeleteZhjbxx(filter);
        }
        #endregion
        
        #region Zj方法
        public Zj GetZj(long id)
        {
            return _zdDao.GetZj(id);
        }
        
        public IEnumerable<Zj> GetZjs(string filter)
        {
            return _zdDao.GetZjs(filter);
        }
        public bool SaveZj(Zj zj)
        {
            return _zdDao.SaveZj(zj);
        }
        public void SaveZjs(List<Zj> zjs)
        {
            _zdDao.SaveZjs(zjs);        
        }
        public void DeleteZj(Zj rec)
        {
            _zdDao.DeleteZj(rec);
        }
        public void DeleteZj(long id)
        {
            _zdDao.DeleteZj(id);
        }
        public void DeleteZj(string filter)
        {
            _zdDao.DeleteZj(filter);
        }
        #endregion
        
        #region Zrz方法
        public Zrz GetZrz(long id)
        {
            return _zdDao.GetZrz(id);
        }
        
        public IEnumerable<Zrz> GetZrzs(string filter)
        {
            return _zdDao.GetZrzs(filter);
        }
        public bool SaveZrz(Zrz zrz)
        {
            return _zdDao.SaveZrz(zrz);
        }
        public void SaveZrzs(List<Zrz> zrzs)
        {
            _zdDao.SaveZrzs(zrzs);        
        }
        public void DeleteZrz(Zrz rec)
        {
            _zdDao.DeleteZrz(rec);
        }
        public void DeleteZrz(long id)
        {
            _zdDao.DeleteZrz(id);
        }
        public void DeleteZrz(string filter)
        {
            _zdDao.DeleteZrz(filter);
        }
        #endregion
        
        
       
        
       
        
    }
}