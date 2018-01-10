using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{

    public partial interface SystemService:IEntityChanged
    {
              
        ///VgAreacodes函数
        VgAreacodes GetVgAreacodes(long id);
        IEnumerable<VgAreacodes> GetVgAreacodess(string filter);
        bool SaveVgAreacodes(VgAreacodes vgAreacode);
        void SaveVgAreacodess(List<VgAreacodes> vgAreacodes);
        void DeleteVgAreacodes(long id);
        void DeleteVgAreacodes(string filter);
            
            
        ///VgCadcodes函数
        VgCadcodes GetVgCadcodes(long id);
        IEnumerable<VgCadcodes> GetVgCadcodess(string filter);
        bool SaveVgCadcodes(VgCadcodes vgCadcode);
        void SaveVgCadcodess(List<VgCadcodes> vgCadcodes);
        void DeleteVgCadcodes(long id);
        void DeleteVgCadcodes(string filter);
            
            
        ///VgLayergroup函数
        VgLayergroup GetVgLayergroup(long id);
        IEnumerable<VgLayergroup> GetVgLayergroups(string filter);
        bool SaveVgLayergroup(VgLayergroup vgLayergroup);
        void SaveVgLayergroups(List<VgLayergroup> vgLayergroups);
        void DeleteVgLayergroup(long id);
        void DeleteVgLayergroup(string filter);
            
            
        ///VgLayergroupdetail函数
        VgLayergroupdetail GetVgLayergroupdetail(long id);
        IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter);
        bool SaveVgLayergroupdetail(VgLayergroupdetail vgLayergroupdetail);
        void SaveVgLayergroupdetails(List<VgLayergroupdetail> vgLayergroupdetails);
        void DeleteVgLayergroupdetail(long id);
        void DeleteVgLayergroupdetail(string filter);
            
            
        ///VgObjectclasses函数
        VgObjectclasses GetVgObjectclasses(long id);
        IEnumerable<VgObjectclasses> GetVgObjectclassess(string filter);
        bool SaveVgObjectclasses(VgObjectclasses vgObjectclass);
        void SaveVgObjectclassess(List<VgObjectclasses> vgObjectclasss);
        void DeleteVgObjectclasses(long id);
        void DeleteVgObjectclasses(string filter);
            
            
        ///VgObjectysdm函数
        VgObjectysdm GetVgObjectysdm(long id);
        IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter);
        bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm);
        void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms);
        void DeleteVgObjectysdm(long id);
        void DeleteVgObjectysdm(string filter);
            
            
        ///VgSettings函数
        VgSettings GetVgSettings(long id);
        IEnumerable<VgSettings> GetVgSettingss(string filter);
        bool SaveVgSettings(VgSettings vgSetting);
        void SaveVgSettingss(List<VgSettings> vgSettings);
        void DeleteVgSettings(long id);
        void DeleteVgSettings(string filter);
            
            
        
    }

}



