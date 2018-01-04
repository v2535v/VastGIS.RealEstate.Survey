using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class CadServiceImpl:CadService
    {
        private CadDao _cadDao;
        
        public CadServiceImpl(CadDao cadDao)
            {
                this._cadDao = cadDao;
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
                return _cadDao.SaveTmpCadd(tmpcadd);
            }
            public void SaveTmpCadds(List<TmpCadd> tmpcadds)
            {
                _cadDao.SaveTmpCadds(tmpcadds);
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
                return _cadDao.SaveTmpCadm(tmpcadm);
            }
            public void SaveTmpCadms(List<TmpCadm> tmpcadms)
            {
                _cadDao.SaveTmpCadms(tmpcadms);
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
            
            public IEnumerable<TmpCadx> GetTmpCadxs(string filter)
            {
                return _cadDao.GetTmpCadxs(filter);
            }
            public bool SaveTmpCadx(TmpCadx tmpcadx)
            {
                return _cadDao.SaveTmpCadx(tmpcadx);
            }
            public void SaveTmpCadxs(List<TmpCadx> tmpcadxs)
            {
                _cadDao.SaveTmpCadxs(tmpcadxs);
            }
            public void DeleteTmpCadx(long id)
            {
                _cadDao.DeleteTmpCadx(id);
            }
            public void DeleteTmpCadx(string filter)
            {
                _cadDao.DeleteTmpCadx(filter);
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
                return _cadDao.SaveTmpCadxdata(tmpcadxdatum);
            }
            public void SaveTmpCadxdatas(List<TmpCadxdata> tmpcadxdatums)
            {
                _cadDao.SaveTmpCadxdatas(tmpcadxdatums);
            }
            public void DeleteTmpCadxdata(long id)
            {
                _cadDao.DeleteTmpCadxdata(id);
            }
            public void DeleteTmpCadxdata(string filter)
            {
                _cadDao.DeleteTmpCadxdata(filter);
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
                return _cadDao.SaveTmpCadzj(tmpcadzj);
            }
            public void SaveTmpCadzjs(List<TmpCadzj> tmpcadzjs)
            {
                _cadDao.SaveTmpCadzjs(tmpcadzjs);
            }
            public void DeleteTmpCadzj(long id)
            {
                _cadDao.DeleteTmpCadzj(id);
            }
            public void DeleteTmpCadzj(string filter)
            {
                _cadDao.DeleteTmpCadzj(filter);
            }
    }

}



