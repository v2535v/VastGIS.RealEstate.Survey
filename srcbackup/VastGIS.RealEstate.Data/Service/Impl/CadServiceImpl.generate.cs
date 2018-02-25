using System.Collections.Generic;
using System.Linq;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class CadServiceImpl:CadService
    {
        private CadDao _cadDao;
        
        private event EntityChangedEventHandler entityChanged;
      
        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(string tableName, string layerName,EntityOperationType operationType,List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType,ids));
            }
        }
        
        public CadServiceImpl(CadDao cadDao)
        {
            this._cadDao = cadDao;
            this._cadDao.EntityChanged += CadDao_EntityChanged;
        }
        
        private void CadDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.TableName,e.LayerName,e.OperationType,e.Ids);
        }
        
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
            bool retVal=_cadDao.SaveTmpCadd(tmpcadd);
            return retVal;
        }
        public void SaveTmpCadds(List<TmpCadd> tmpCadds)
        {
            _cadDao.SaveTmpCadds(tmpCadds);
            
        }
        public void DeleteTmpCadd(long id)
        {
            _cadDao.DeleteTmpCadd(id);
            
        }
        public void DeleteTmpCadd(string filter)
        {
            _cadDao.DeleteTmpCadd(filter);
            
        }
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
            bool retVal=_cadDao.SaveTmpCadm(tmpcadm);
            return retVal;
        }
        public void SaveTmpCadms(List<TmpCadm> tmpCadms)
        {
            _cadDao.SaveTmpCadms(tmpCadms);
            
        }
        public void DeleteTmpCadm(long id)
        {
            _cadDao.DeleteTmpCadm(id);
            
        }
        public void DeleteTmpCadm(string filter)
        {
            _cadDao.DeleteTmpCadm(filter);
            
        }
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
            bool retVal=_cadDao.SaveTmpCadx(tmpcadx);
            return retVal;
        }
        public void SaveTmpCadxes(List<TmpCadx> tmpCadxes)
        {
            _cadDao.SaveTmpCadxes(tmpCadxes);
            
        }
        public void DeleteTmpCadx(long id)
        {
            _cadDao.DeleteTmpCadx(id);
            
        }
        public void DeleteTmpCadx(string filter)
        {
            _cadDao.DeleteTmpCadx(filter);
            
        }
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
            bool retVal=_cadDao.SaveTmpCadzj(tmpcadzj);
            return retVal;
        }
        public void SaveTmpCadzjs(List<TmpCadzj> tmpCadzjs)
        {
            _cadDao.SaveTmpCadzjs(tmpCadzjs);
            
        }
        public void DeleteTmpCadzj(long id)
        {
            _cadDao.DeleteTmpCadzj(id);
            
        }
        public void DeleteTmpCadzj(string filter)
        {
            _cadDao.DeleteTmpCadzj(filter);
            
        }
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
            bool retVal=_cadDao.SaveTmpCadxdata(tmpcadxdatum);
            return retVal;
        }
        public void SaveTmpCadxdatas(List<TmpCadxdata> tmpCadxdatas)
        {
            _cadDao.SaveTmpCadxdatas(tmpCadxdatas);
            
        }
        public void DeleteTmpCadxdata(long id)
        {
            _cadDao.DeleteTmpCadxdata(id);
            
        }
        public void DeleteTmpCadxdata(string filter)
        {
            _cadDao.DeleteTmpCadxdata(filter);
            
        }
    }

}



