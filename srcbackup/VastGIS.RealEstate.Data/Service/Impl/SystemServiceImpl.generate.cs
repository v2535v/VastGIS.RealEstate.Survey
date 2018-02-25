using System.Collections.Generic;
using System.Linq;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class SystemServiceImpl:SystemService
    {
        private SystemDao _systemDao;
        
        private event EntityChangedEventHandler entityChanged;
      
        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(string tableName, string layerName,EntityOperationType operationType,List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType,ids));
            }
        }
        
        public SystemServiceImpl(SystemDao systemDao)
        {
            this._systemDao = systemDao;
            this._systemDao.EntityChanged += SystemDao_EntityChanged;
        }
        
        private void SystemDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.TableName,e.LayerName,e.OperationType,e.Ids);
        }
        
        public VgObjectclass GetVgObjectclass(long id)
        {
            return _systemDao.GetVgObjectclass(id);
        }
        
        public IEnumerable<VgObjectclass> GetVgObjectclasses(string filter)
        {
            return _systemDao.GetVgObjectclasses(filter);
        }
        public bool SaveVgObjectclass(VgObjectclass vgObjectclass)
        {
            bool retVal=_systemDao.SaveVgObjectclass(vgObjectclass);
            return retVal;
        }
        public void SaveVgObjectclasses(List<VgObjectclass> vgObjectclasses)
        {
            _systemDao.SaveVgObjectclasses(vgObjectclasses);
            
        }
        public void DeleteVgObjectclass(long id)
        {
            _systemDao.DeleteVgObjectclass(id);
            
        }
        public void DeleteVgObjectclass(string filter)
        {
            _systemDao.DeleteVgObjectclass(filter);
            
        }
        public VgSetting GetVgSetting(long id)
        {
            return _systemDao.GetVgSetting(id);
        }
        
        public IEnumerable<VgSetting> GetVgSettings(string filter)
        {
            return _systemDao.GetVgSettings(filter);
        }
        public bool SaveVgSetting(VgSetting vgSetting)
        {
            bool retVal=_systemDao.SaveVgSetting(vgSetting);
            return retVal;
        }
        public void SaveVgSettings(List<VgSetting> vgSettings)
        {
            _systemDao.SaveVgSettings(vgSettings);
            
        }
        public void DeleteVgSetting(long id)
        {
            _systemDao.DeleteVgSetting(id);
            
        }
        public void DeleteVgSetting(string filter)
        {
            _systemDao.DeleteVgSetting(filter);
            
        }
        public VgCadcode GetVgCadcode(long id)
        {
            return _systemDao.GetVgCadcode(id);
        }
        
        public IEnumerable<VgCadcode> GetVgCadcodes(string filter)
        {
            return _systemDao.GetVgCadcodes(filter);
        }
        public bool SaveVgCadcode(VgCadcode vgCadcode)
        {
            bool retVal=_systemDao.SaveVgCadcode(vgCadcode);
            return retVal;
        }
        public void SaveVgCadcodes(List<VgCadcode> vgCadcodes)
        {
            _systemDao.SaveVgCadcodes(vgCadcodes);
            
        }
        public void DeleteVgCadcode(long id)
        {
            _systemDao.DeleteVgCadcode(id);
            
        }
        public void DeleteVgCadcode(string filter)
        {
            _systemDao.DeleteVgCadcode(filter);
            
        }
        public VgAreacode GetVgAreacode(long id)
        {
            return _systemDao.GetVgAreacode(id);
        }
        
        public IEnumerable<VgAreacode> GetVgAreacodes(string filter)
        {
            return _systemDao.GetVgAreacodes(filter);
        }
        public bool SaveVgAreacode(VgAreacode vgAreacode)
        {
            bool retVal=_systemDao.SaveVgAreacode(vgAreacode);
            return retVal;
        }
        public void SaveVgAreacodes(List<VgAreacode> vgAreacodes)
        {
            _systemDao.SaveVgAreacodes(vgAreacodes);
            
        }
        public void DeleteVgAreacode(long id)
        {
            _systemDao.DeleteVgAreacode(id);
            
        }
        public void DeleteVgAreacode(string filter)
        {
            _systemDao.DeleteVgAreacode(filter);
            
        }
        public VgObjectysdm GetVgObjectysdm(long id)
        {
            return _systemDao.GetVgObjectysdm(id);
        }
        
        public IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter)
        {
            return _systemDao.GetVgObjectysdms(filter);
        }
        public bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm)
        {
            bool retVal=_systemDao.SaveVgObjectysdm(vgObjectysdm);
            return retVal;
        }
        public void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms)
        {
            _systemDao.SaveVgObjectysdms(vgObjectysdms);
            
        }
        public void DeleteVgObjectysdm(long id)
        {
            _systemDao.DeleteVgObjectysdm(id);
            
        }
        public void DeleteVgObjectysdm(string filter)
        {
            _systemDao.DeleteVgObjectysdm(filter);
            
        }
        public VgLayergroup GetVgLayergroup(long id)
        {
            return _systemDao.GetVgLayergroup(id);
        }
        
        public IEnumerable<VgLayergroup> GetVgLayergroups(string filter)
        {
            return _systemDao.GetVgLayergroups(filter);
        }
        public bool SaveVgLayergroup(VgLayergroup vgLayergroup)
        {
            bool retVal=_systemDao.SaveVgLayergroup(vgLayergroup);
            return retVal;
        }
        public void SaveVgLayergroups(List<VgLayergroup> vgLayergroups)
        {
            _systemDao.SaveVgLayergroups(vgLayergroups);
            
        }
        public void DeleteVgLayergroup(long id)
        {
            _systemDao.DeleteVgLayergroup(id);
            
        }
        public void DeleteVgLayergroup(string filter)
        {
            _systemDao.DeleteVgLayergroup(filter);
            
        }
        public VgLayergroupdetail GetVgLayergroupdetail(long id)
        {
            return _systemDao.GetVgLayergroupdetail(id);
        }
        
        public IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter)
        {
            return _systemDao.GetVgLayergroupdetails(filter);
        }
        public bool SaveVgLayergroupdetail(VgLayergroupdetail vgLayergroupdetail)
        {
            bool retVal=_systemDao.SaveVgLayergroupdetail(vgLayergroupdetail);
            return retVal;
        }
        public void SaveVgLayergroupdetails(List<VgLayergroupdetail> vgLayergroupdetails)
        {
            _systemDao.SaveVgLayergroupdetails(vgLayergroupdetails);
            
        }
        public void DeleteVgLayergroupdetail(long id)
        {
            _systemDao.DeleteVgLayergroupdetail(id);
            
        }
        public void DeleteVgLayergroupdetail(string filter)
        {
            _systemDao.DeleteVgLayergroupdetail(filter);
            
        }
        public VgClassgroup GetVgClassgroup(long id)
        {
            return _systemDao.GetVgClassgroup(id);
        }
        
        public IEnumerable<VgClassgroup> GetVgClassgroups(string filter)
        {
            return _systemDao.GetVgClassgroups(filter);
        }
        public bool SaveVgClassgroup(VgClassgroup vgClassgroup)
        {
            bool retVal=_systemDao.SaveVgClassgroup(vgClassgroup);
            return retVal;
        }
        public void SaveVgClassgroups(List<VgClassgroup> vgClassgroups)
        {
            _systemDao.SaveVgClassgroups(vgClassgroups);
            
        }
        public void DeleteVgClassgroup(long id)
        {
            _systemDao.DeleteVgClassgroup(id);
            
        }
        public void DeleteVgClassgroup(string filter)
        {
            _systemDao.DeleteVgClassgroup(filter);
            
        }
        public VgClassdetail GetVgClassdetail(long id)
        {
            return _systemDao.GetVgClassdetail(id);
        }
        
        public IEnumerable<VgClassdetail> GetVgClassdetails(string filter)
        {
            return _systemDao.GetVgClassdetails(filter);
        }
        public bool SaveVgClassdetail(VgClassdetail vgClassdetail)
        {
            bool retVal=_systemDao.SaveVgClassdetail(vgClassdetail);
            return retVal;
        }
        public void SaveVgClassdetails(List<VgClassdetail> vgClassdetails)
        {
            _systemDao.SaveVgClassdetails(vgClassdetails);
            
        }
        public void DeleteVgClassdetail(long id)
        {
            _systemDao.DeleteVgClassdetail(id);
            
        }
        public void DeleteVgClassdetail(string filter)
        {
            _systemDao.DeleteVgClassdetail(filter);
            
        }
        public VgFieldinfo GetVgFieldinfo(long id)
        {
            return _systemDao.GetVgFieldinfo(id);
        }
        
        public IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter)
        {
            return _systemDao.GetVgFieldinfos(filter);
        }
        public bool SaveVgFieldinfo(VgFieldinfo vgFieldinfo)
        {
            bool retVal=_systemDao.SaveVgFieldinfo(vgFieldinfo);
            return retVal;
        }
        public void SaveVgFieldinfos(List<VgFieldinfo> vgFieldinfos)
        {
            _systemDao.SaveVgFieldinfos(vgFieldinfos);
            
        }
        public void DeleteVgFieldinfo(long id)
        {
            _systemDao.DeleteVgFieldinfo(id);
            
        }
        public void DeleteVgFieldinfo(string filter)
        {
            _systemDao.DeleteVgFieldinfo(filter);
            
        }
        public VgAttachment GetVgAttachment(long id)
        {
            return _systemDao.GetVgAttachment(id);
        }
        
        public IEnumerable<VgAttachment> GetVgAttachments(string filter)
        {
            return _systemDao.GetVgAttachments(filter);
        }
        public bool SaveVgAttachment(VgAttachment vgAttachment)
        {
            bool retVal=_systemDao.SaveVgAttachment(vgAttachment);
            return retVal;
        }
        public void SaveVgAttachments(List<VgAttachment> vgAttachments)
        {
            _systemDao.SaveVgAttachments(vgAttachments);
            
        }
        public void DeleteVgAttachment(long id)
        {
            _systemDao.DeleteVgAttachment(id);
            
        }
        public void DeleteVgAttachment(string filter)
        {
            _systemDao.DeleteVgAttachment(filter);
            
        }
    }

}



