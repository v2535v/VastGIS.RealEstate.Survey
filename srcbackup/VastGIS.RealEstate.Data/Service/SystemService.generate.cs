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
              
        ///VgObjectclass函数
        VgObjectclass GetVgObjectclass(long id);
        IEnumerable<VgObjectclass> GetVgObjectclasses(string filter);
        bool SaveVgObjectclass(VgObjectclass vgObjectclass);
        void SaveVgObjectclasses(List<VgObjectclass> vgObjectclasses);
        void DeleteVgObjectclass(long id);
        void DeleteVgObjectclass(string filter);
            
            
        ///VgSetting函数
        VgSetting GetVgSetting(long id);
        IEnumerable<VgSetting> GetVgSettings(string filter);
        bool SaveVgSetting(VgSetting vgSetting);
        void SaveVgSettings(List<VgSetting> vgSettings);
        void DeleteVgSetting(long id);
        void DeleteVgSetting(string filter);
            
            
        ///VgCadcode函数
        VgCadcode GetVgCadcode(long id);
        IEnumerable<VgCadcode> GetVgCadcodes(string filter);
        bool SaveVgCadcode(VgCadcode vgCadcode);
        void SaveVgCadcodes(List<VgCadcode> vgCadcodes);
        void DeleteVgCadcode(long id);
        void DeleteVgCadcode(string filter);
            
            
        ///VgAreacode函数
        VgAreacode GetVgAreacode(long id);
        IEnumerable<VgAreacode> GetVgAreacodes(string filter);
        bool SaveVgAreacode(VgAreacode vgAreacode);
        void SaveVgAreacodes(List<VgAreacode> vgAreacodes);
        void DeleteVgAreacode(long id);
        void DeleteVgAreacode(string filter);
            
            
        ///VgObjectysdm函数
        VgObjectysdm GetVgObjectysdm(long id);
        IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter);
        bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm);
        void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms);
        void DeleteVgObjectysdm(long id);
        void DeleteVgObjectysdm(string filter);
            
            
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
            
            
        ///VgClassgroup函数
        VgClassgroup GetVgClassgroup(long id);
        IEnumerable<VgClassgroup> GetVgClassgroups(string filter);
        bool SaveVgClassgroup(VgClassgroup vgClassgroup);
        void SaveVgClassgroups(List<VgClassgroup> vgClassgroups);
        void DeleteVgClassgroup(long id);
        void DeleteVgClassgroup(string filter);
            
            
        ///VgClassdetail函数
        VgClassdetail GetVgClassdetail(long id);
        IEnumerable<VgClassdetail> GetVgClassdetails(string filter);
        bool SaveVgClassdetail(VgClassdetail vgClassdetail);
        void SaveVgClassdetails(List<VgClassdetail> vgClassdetails);
        void DeleteVgClassdetail(long id);
        void DeleteVgClassdetail(string filter);
            
            
        ///VgFieldinfo函数
        VgFieldinfo GetVgFieldinfo(long id);
        IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter);
        bool SaveVgFieldinfo(VgFieldinfo vgFieldinfo);
        void SaveVgFieldinfos(List<VgFieldinfo> vgFieldinfos);
        void DeleteVgFieldinfo(long id);
        void DeleteVgFieldinfo(string filter);
            
            
        ///VgAttachment函数
        VgAttachment GetVgAttachment(long id);
        IEnumerable<VgAttachment> GetVgAttachments(string filter);
        bool SaveVgAttachment(VgAttachment vgAttachment);
        void SaveVgAttachments(List<VgAttachment> vgAttachments);
        void DeleteVgAttachment(long id);
        void DeleteVgAttachment(string filter);
            
            
        
    }

}



