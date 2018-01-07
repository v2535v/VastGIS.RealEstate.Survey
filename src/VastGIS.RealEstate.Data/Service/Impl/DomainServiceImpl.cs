using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class DomainServiceImpl
    {
        public void InternalInitTables()
        {
            _domainDao.InternalInitTables();
        }

        public bool InitTables()
        {
           return  _domainDao.InitTables();
        }

        public List<VgDictionary> GetDictionaryByName(string DictionaryName)
        {
            return _domainDao.GetDictionaryByName(DictionaryName);
        }
    }
}



