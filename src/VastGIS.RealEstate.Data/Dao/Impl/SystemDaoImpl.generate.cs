using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class SystemDaoImpl:SQLiteDao,SystemDao
    {
        //private SystemDao _systemDao;
        
        
        ///VgAreacodes函数
        public VgAreacodes GetVgAreacodes(long id)
        {
            string sql="select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacodes" + " where id="+id.ToString();
            IEnumerable<VgAreacodes> vgAreacodes=connection.Query<VgAreacodes>(sql);
            if(vgAreacodes != null && vgAreacodes.Count()>0)
            {
                return vgAreacodes.First();
            }
            return null;
        }
        
        public IEnumerable<VgAreacodes> GetVgAreacodess(string filter)
        {
            string sql="select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacodes" + " where "+filter;
            var vgAreacodes=connection.Query<VgAreacodes>(sql);
            
            return vgAreacodes;
        }
        
        public bool SaveVgAreacodes(VgAreacodes vgAreacode)
        {
            return vgAreacode.Save(connection,GetSRID());
        }
        
        public void SaveVgAreacodess(List<VgAreacodes> vgAreacodes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgAreacodes)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteVgAreacodes(VgAreacodes record)
        {
            record.Delete(connection);
        }
        
        public void DeleteVgAreacodes(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_areacodes where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteVgAreacodes(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_areacodes";
                else
                    command.CommandText="delete from vg_areacodes where " + filter;
                command.ExecuteNonQuery();
            }
        }
        
        
        ///VgCadcodes函数
        public VgCadcodes GetVgCadcodes(long id)
        {
            string sql="select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcodes" + " where id="+id.ToString();
            IEnumerable<VgCadcodes> vgCadcodes=connection.Query<VgCadcodes>(sql);
            if(vgCadcodes != null && vgCadcodes.Count()>0)
            {
                return vgCadcodes.First();
            }
            return null;
        }
        
        public IEnumerable<VgCadcodes> GetVgCadcodess(string filter)
        {
            string sql="select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcodes" + " where "+filter;
            var vgCadcodes=connection.Query<VgCadcodes>(sql);
            
            return vgCadcodes;
        }
        
        public bool SaveVgCadcodes(VgCadcodes vgCadcode)
        {
            return vgCadcode.Save(connection,GetSRID());
        }
        
        public void SaveVgCadcodess(List<VgCadcodes> vgCadcodes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgCadcodes)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteVgCadcodes(VgCadcodes record)
        {
            record.Delete(connection);
        }
        
        public void DeleteVgCadcodes(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_cadcodes where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteVgCadcodes(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_cadcodes";
                else
                    command.CommandText="delete from vg_cadcodes where " + filter;
                command.ExecuteNonQuery();
            }
        }
        
        
        ///VgObjectclasses函数
        public VgObjectclasses GetVgObjectclasses(long id)
        {
            string sql="select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER from vg_objectclasses" + " where id="+id.ToString();
            IEnumerable<VgObjectclasses> vgObjectclasss=connection.Query<VgObjectclasses>(sql);
            if(vgObjectclasss != null && vgObjectclasss.Count()>0)
            {
                return vgObjectclasss.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectclasses> GetVgObjectclassess(string filter)
        {
            string sql="select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER from vg_objectclasses" + " where "+filter;
            var vgObjectclasss=connection.Query<VgObjectclasses>(sql);
            
            return vgObjectclasss;
        }
        
        public bool SaveVgObjectclasses(VgObjectclasses vgObjectclass)
        {
            return vgObjectclass.Save(connection,GetSRID());
        }
        
        public void SaveVgObjectclassess(List<VgObjectclasses> vgObjectclasss)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgObjectclasss)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteVgObjectclasses(VgObjectclasses record)
        {
            record.Delete(connection);
        }
        
        public void DeleteVgObjectclasses(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_objectclasses where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteVgObjectclasses(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_objectclasses";
                else
                    command.CommandText="delete from vg_objectclasses where " + filter;
                command.ExecuteNonQuery();
            }
        }
        
        
        ///VgSettings函数
        public VgSettings GetVgSettings(long id)
        {
            string sql="select Id,CSMC,CSZ from vg_settings" + " where id="+id.ToString();
            IEnumerable<VgSettings> vgSettings=connection.Query<VgSettings>(sql);
            if(vgSettings != null && vgSettings.Count()>0)
            {
                return vgSettings.First();
            }
            return null;
        }
        
        public IEnumerable<VgSettings> GetVgSettingss(string filter)
        {
            string sql="select Id,CSMC,CSZ from vg_settings" + " where "+filter;
            var vgSettings=connection.Query<VgSettings>(sql);
            
            return vgSettings;
        }
        
        public bool SaveVgSettings(VgSettings vgSetting)
        {
            return vgSetting.Save(connection,GetSRID());
        }
        
        public void SaveVgSettingss(List<VgSettings> vgSettings)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgSettings)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteVgSettings(VgSettings record)
        {
            record.Delete(connection);
        }
        
        public void DeleteVgSettings(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_settings where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteVgSettings(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_settings";
                else
                    command.CommandText="delete from vg_settings where " + filter;
                command.ExecuteNonQuery();
            }
        }
        
        
        
        
    }
}



