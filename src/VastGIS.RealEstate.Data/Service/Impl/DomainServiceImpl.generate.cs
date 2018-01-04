using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class DomainServiceImpl:DomainService
    {
        private DomainDao _domainDao;
        
        public DomainServiceImpl(DomainDao domainDao)
            {
                this._domainDao = domainDao;
            }
            public VgDictionary GetVgDictionary(long id)
            {
                return _domainDao.GetVgDictionary(id);
            }
            
            public IEnumerable<VgDictionary> GetVgDictionarys(string filter)
            {
                return _domainDao.GetVgDictionarys(filter);
            }
            public bool SaveVgDictionary(VgDictionary vgDictionary)
            {
                return _domainDao.SaveVgDictionary(vgDictionary);
            }
            public void SaveVgDictionarys(List<VgDictionary> vgDictionarys)
            {
                _domainDao.SaveVgDictionarys(vgDictionarys);
            }
            public void DeleteVgDictionary(long id)
            {
                _domainDao.DeleteVgDictionary(id);
            }
            public void DeleteVgDictionary(string filter)
            {
                _domainDao.DeleteVgDictionary(filter);
            }
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
            public void DeleteVgDictoryname(long id)
            {
                _domainDao.DeleteVgDictoryname(id);
            }
            public void DeleteVgDictoryname(string filter)
            {
                _domainDao.DeleteVgDictoryname(filter);
            }
    }

}



