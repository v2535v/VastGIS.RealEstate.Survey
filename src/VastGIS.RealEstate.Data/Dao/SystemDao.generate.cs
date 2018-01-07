using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;

namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface SystemDao
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
            
            ///VgObjectclasses函数
            VgObjectclasses GetVgObjectclasses(long id);
            IEnumerable<VgObjectclasses> GetVgObjectclassess(string filter);
            bool SaveVgObjectclasses(VgObjectclasses vgObjectclass);
            void SaveVgObjectclassess(List<VgObjectclasses> vgObjectclasss);
            void DeleteVgObjectclasses(long id);
            void DeleteVgObjectclasses(string filter);
            
            ///VgSettings函数
            VgSettings GetVgSettings(long id);
            IEnumerable<VgSettings> GetVgSettingss(string filter);
            bool SaveVgSettings(VgSettings vgSetting);
            void SaveVgSettingss(List<VgSettings> vgSettings);
            void DeleteVgSettings(long id);
            void DeleteVgSettings(string filter);
            
    }

}

