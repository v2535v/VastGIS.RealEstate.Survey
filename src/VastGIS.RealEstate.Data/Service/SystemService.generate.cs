using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service
{
    public partial interface SystemService:ISQLiteService
    {	
        #region VgAreacode方法
        VgAreacode GetVgAreacode(long id);
        IEnumerable<VgAreacode> GetVgAreacodes(string filter);
        bool SaveVgAreacode(VgAreacode vgAreacode);
        void SaveVgAreacodes(List<VgAreacode> vgAreacodes);
        void DeleteVgAreacode(VgAreacode rec);
        void DeleteVgAreacode(long id);
        void DeleteVgAreacode(string filter);
        #endregion
        
        #region VgAttachment方法
        VgAttachment GetVgAttachment(long id);
        IEnumerable<VgAttachment> GetVgAttachments(string filter);
        bool SaveVgAttachment(VgAttachment vgAttachment);
        void SaveVgAttachments(List<VgAttachment> vgAttachments);
        void DeleteVgAttachment(VgAttachment rec);
        void DeleteVgAttachment(long id);
        void DeleteVgAttachment(string filter);
        #endregion
        
        #region VgCadcode方法
        VgCadcode GetVgCadcode(long id);
        IEnumerable<VgCadcode> GetVgCadcodes(string filter);
        bool SaveVgCadcode(VgCadcode vgCadcode);
        void SaveVgCadcodes(List<VgCadcode> vgCadcodes);
        void DeleteVgCadcode(VgCadcode rec);
        void DeleteVgCadcode(long id);
        void DeleteVgCadcode(string filter);
        #endregion
        
        #region VgClassdetail方法
        VgClassdetail GetVgClassdetail(long id);
        IEnumerable<VgClassdetail> GetVgClassdetails(string filter);
        bool SaveVgClassdetail(VgClassdetail vgClassdetail);
        void SaveVgClassdetails(List<VgClassdetail> vgClassdetails);
        void DeleteVgClassdetail(VgClassdetail rec);
        void DeleteVgClassdetail(long id);
        void DeleteVgClassdetail(string filter);
        #endregion
        
        #region VgClassgroup方法
        VgClassgroup GetVgClassgroup(long id);
        IEnumerable<VgClassgroup> GetVgClassgroups(string filter);
        bool SaveVgClassgroup(VgClassgroup vgClassgroup);
        void SaveVgClassgroups(List<VgClassgroup> vgClassgroups);
        void DeleteVgClassgroup(VgClassgroup rec);
        void DeleteVgClassgroup(long id);
        void DeleteVgClassgroup(string filter);
        #endregion
        
        #region VgFieldinfo方法
        VgFieldinfo GetVgFieldinfo(long id);
        IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter);
        bool SaveVgFieldinfo(VgFieldinfo vgFieldinfo);
        void SaveVgFieldinfos(List<VgFieldinfo> vgFieldinfos);
        void DeleteVgFieldinfo(VgFieldinfo rec);
        void DeleteVgFieldinfo(long id);
        void DeleteVgFieldinfo(string filter);
        #endregion
        
        #region VgLayergroup方法
        VgLayergroup GetVgLayergroup(long id);
        IEnumerable<VgLayergroup> GetVgLayergroups(string filter);
        bool SaveVgLayergroup(VgLayergroup vgLayergroup);
        void SaveVgLayergroups(List<VgLayergroup> vgLayergroups);
        void DeleteVgLayergroup(VgLayergroup rec);
        void DeleteVgLayergroup(long id);
        void DeleteVgLayergroup(string filter);
        #endregion
        
        #region VgLayergroupdetail方法
        VgLayergroupdetail GetVgLayergroupdetail(long id);
        IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter);
        bool SaveVgLayergroupdetail(VgLayergroupdetail vgLayergroupdetail);
        void SaveVgLayergroupdetails(List<VgLayergroupdetail> vgLayergroupdetails);
        void DeleteVgLayergroupdetail(VgLayergroupdetail rec);
        void DeleteVgLayergroupdetail(long id);
        void DeleteVgLayergroupdetail(string filter);
        #endregion
        
        #region VgObjectysdm方法
        VgObjectysdm GetVgObjectysdm(long id);
        IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter);
        bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm);
        void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms);
        void DeleteVgObjectysdm(VgObjectysdm rec);
        void DeleteVgObjectysdm(long id);
        void DeleteVgObjectysdm(string filter);
        #endregion
        
        #region VgSetting方法
        VgSetting GetVgSetting(long id);
        IEnumerable<VgSetting> GetVgSettings(string filter);
        bool SaveVgSetting(VgSetting vgSetting);
        void SaveVgSettings(List<VgSetting> vgSettings);
        void DeleteVgSetting(VgSetting rec);
        void DeleteVgSetting(long id);
        void DeleteVgSetting(string filter);
        #endregion
        
        #region VgObjectitem方法
        VgObjectitem GetVgObjectitem(long id);
        IEnumerable<VgObjectitem> GetVgObjectitems(string filter);
        bool SaveVgObjectitem(VgObjectitem vgObjectitem);
        void SaveVgObjectitems(List<VgObjectitem> vgObjectitems);
        void DeleteVgObjectitem(VgObjectitem rec);
        void DeleteVgObjectitem(long id);
        void DeleteVgObjectitem(string filter);
        #endregion
        
        #region VgObjectclass方法
        VgObjectclass GetVgObjectclass(long id);
        IEnumerable<VgObjectclass> GetVgObjectclasses(string filter);
        bool SaveVgObjectclass(VgObjectclass vgObjectclass);
        void SaveVgObjectclasses(List<VgObjectclass> vgObjectclasses);
        void DeleteVgObjectclass(VgObjectclass rec);
        void DeleteVgObjectclass(long id);
        void DeleteVgObjectclass(string filter);
        #endregion
        
        #region VgClassrelation方法
        VgClassrelation GetVgClassrelation(long id);
        IEnumerable<VgClassrelation> GetVgClassrelations(string filter);
        bool SaveVgClassrelation(VgClassrelation vgClassrelation);
        void SaveVgClassrelations(List<VgClassrelation> vgClassrelations);
        void DeleteVgClassrelation(VgClassrelation rec);
        void DeleteVgClassrelation(long id);
        void DeleteVgClassrelation(string filter);
        #endregion
        
        
    }
}