using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{

    public partial interface DomainService 
    {
        void InternalInitTables();
        bool InitTables();

        List<VgDictionary> GetDictionaryByName(string DictionaryName);

    }
}



