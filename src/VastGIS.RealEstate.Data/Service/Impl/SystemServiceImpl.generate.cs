using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class SystemServiceImpl:SystemService
    {
        private SystemDao _systemDao;
        
        public SystemServiceImpl(SystemDao systemDao)
            {
                this._systemDao = systemDao;
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
                return _systemDao.SaveVgCadcodes(vgCadcode);
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
                return _systemDao.SaveVgObjectclasses(vgObjectclass);
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
                return _systemDao.SaveVgSettings(vgSetting);
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



