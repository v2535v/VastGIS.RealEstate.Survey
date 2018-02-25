using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{
    public partial interface DomainService:ISQLiteService
    {	
        #region VgDictionary方法
        VgDictionary GetVgDictionary(long id);
        IEnumerable<VgDictionary> GetVgDictionaries(string filter);
        bool SaveVgDictionary(VgDictionary vgDictionary);
        void SaveVgDictionaries(List<VgDictionary> vgDictionaries);
        void DeleteVgDictionary(VgDictionary rec);
        void DeleteVgDictionary(long id);
        void DeleteVgDictionary(string filter);
        #endregion
        
        #region VgDictoryname方法
        VgDictoryname GetVgDictoryname(long id);
        IEnumerable<VgDictoryname> GetVgDictorynames(string filter);
        bool SaveVgDictoryname(VgDictoryname vgDictoryname);
        void SaveVgDictorynames(List<VgDictoryname> vgDictorynames);
        void DeleteVgDictoryname(VgDictoryname rec);
        void DeleteVgDictoryname(long id);
        void DeleteVgDictoryname(string filter);
        #endregion
        
        
    }
}