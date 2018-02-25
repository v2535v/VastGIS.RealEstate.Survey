using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface DomainDao:IEntityChanged
    {
        string GetLayerName(string tableName);
        ///VgDictionary函数
        VgDictionary GetVgDictionary(long id);
        IEnumerable<VgDictionary> GetVgDictionaries(string filter);
        bool SaveVgDictionary(VgDictionary vgDictionary);
        void SaveVgDictionaries(List<VgDictionary> vgDictionaries);
        void DeleteVgDictionary(long id);
        void DeleteVgDictionary(string filter);
            
        ///VgDictoryname函数
        VgDictoryname GetVgDictoryname(long id);
        IEnumerable<VgDictoryname> GetVgDictorynames(string filter);
        bool SaveVgDictoryname(VgDictoryname vgDictoryname);
        void SaveVgDictorynames(List<VgDictoryname> vgDictorynames);
        void DeleteVgDictoryname(long id);
        void DeleteVgDictoryname(string filter);
            
    }

}

