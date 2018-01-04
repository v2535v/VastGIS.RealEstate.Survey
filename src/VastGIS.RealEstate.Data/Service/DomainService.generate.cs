using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.RealEstate.Data.Service
{

    public partial interface DomainService
    {
       
            ///VgDictionary函数
            VgDictionary GetVgDictionary(long id);
            IEnumerable<VgDictionary> GetVgDictionarys(string filter);
            bool SaveVgDictionary(VgDictionary vgDictionary);
            void SaveVgDictionarys(List<VgDictionary> vgDictionarys);
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



