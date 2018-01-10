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

        protected virtual void OnEntityChanged(string tableName, string layerName,EntityOperationType operationType,List<long> ids)
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
        
        public VgAreacodes GetVgAreacodes(long id)
        {
            return _systemDao.GetVgAreacodes(id);
        }
        
        public IEnumerable<VgAreacodes> GetVgAreacodess(string filter)
        {
            return _systemDao.GetVgAreacodess(filter);
        }
        public bool SaveVgAreacodes(VgAreacodes vgAreacode)
        {
            bool retVal=_systemDao.SaveVgAreacodes(vgAreacode);
            return retVal;
        }
        public void SaveVgAreacodess(List<VgAreacodes> vgAreacodes)
        {
            _systemDao.SaveVgAreacodess(vgAreacodes);
            
        }
        public void DeleteVgAreacodes(long id)
        {
            _systemDao.DeleteVgAreacodes(id);
            
        }
        public void DeleteVgAreacodes(string filter)
        {
            _systemDao.DeleteVgAreacodes(filter);
            
        }
        public VgCadcodes GetVgCadcodes(long id)
        {
            return _systemDao.GetVgCadcodes(id);
        }
        
        public IEnumerable<VgCadcodes> GetVgCadcodess(string filter)
        {
            return _systemDao.GetVgCadcodess(filter);
        }
        public bool SaveVgCadcodes(VgCadcodes vgCadcode)
        {
            bool retVal=_systemDao.SaveVgCadcodes(vgCadcode);
            return retVal;
        }
        public void SaveVgCadcodess(List<VgCadcodes> vgCadcodes)
        {
            _systemDao.SaveVgCadcodess(vgCadcodes);
            
        }
        public void DeleteVgCadcodes(long id)
        {
            _systemDao.DeleteVgCadcodes(id);
            
        }
        public void DeleteVgCadcodes(string filter)
        {
            _systemDao.DeleteVgCadcodes(filter);
            
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
        public VgObjectclasses GetVgObjectclasses(long id)
        {
            return _systemDao.GetVgObjectclasses(id);
        }
        
        public IEnumerable<VgObjectclasses> GetVgObjectclassess(string filter)
        {
            return _systemDao.GetVgObjectclassess(filter);
        }
        public bool SaveVgObjectclasses(VgObjectclasses vgObjectclass)
        {
            bool retVal=_systemDao.SaveVgObjectclasses(vgObjectclass);
            return retVal;
        }
        public void SaveVgObjectclassess(List<VgObjectclasses> vgObjectclasss)
        {
            _systemDao.SaveVgObjectclassess(vgObjectclasss);
            
        }
        public void DeleteVgObjectclasses(long id)
        {
            _systemDao.DeleteVgObjectclasses(id);
            
        }
        public void DeleteVgObjectclasses(string filter)
        {
            _systemDao.DeleteVgObjectclasses(filter);
            
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
        public VgSettings GetVgSettings(long id)
        {
            return _systemDao.GetVgSettings(id);
        }
        
        public IEnumerable<VgSettings> GetVgSettingss(string filter)
        {
            return _systemDao.GetVgSettingss(filter);
        }
        public bool SaveVgSettings(VgSettings vgSetting)
        {
            bool retVal=_systemDao.SaveVgSettings(vgSetting);
            return retVal;
        }
        public void SaveVgSettingss(List<VgSettings> vgSettings)
        {
            _systemDao.SaveVgSettingss(vgSettings);
            
        }
        public void DeleteVgSettings(long id)
        {
            _systemDao.DeleteVgSettings(id);
            
        }
        public void DeleteVgSettings(string filter)
        {
            _systemDao.DeleteVgSettings(filter);
            
        }
    }

}



