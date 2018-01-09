using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public partial class SystemDaoImpl:SQLiteDao,SystemDao
    {
        public Dictionary<string, string> _entityNames;
        //private SystemDao _systemDao;
        private string SELECT_VG_AREACODES = "select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacodes";
        
        private string SELECT_VG_CADCODES = "select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcodes";
        
        private string SELECT_VG_OBJECTCLASSES = "select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER from vg_objectclasses";
        
        private string SELECT_VG_SETTINGS = "select Id,CSMC,CSZ from vg_settings";
        
        
        public SystemDaoImpl(): base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("VG_AREACODES","");
            _entityNames.Add("VG_CADCODES","");
            _entityNames.Add("VG_OBJECTCLASSES","");
            _entityNames.Add("VG_SETTINGS","");
        }
        
        private event EntityChangedEventHandler entityChanged;

        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        protected virtual void OnEntityChanged(string tableName, string layerName, EntityOperationType operationType, List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType, ids));
            }
        }
        
        public string GetLayerName(string tableName)
        {
            tableName=tableName.ToUpper();
            if(_entityNames.ContainsKey(tableName))
                return _entityNames[tableName];
            else
                return "";
        }
        
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
            bool retVal= vgAreacode.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_areacodes",GetLayerName("vg_areacodes"),EntityOperationType.Save,new List<long>{vgAreacode.ID});
            }
            return retVal;
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
            List<long> ids=vgAreacodes.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_areacodes",GetLayerName("vg_areacodes"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgAreacodes(VgAreacodes record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_areacodes",GetLayerName("vg_areacodes"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgAreacodes(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_areacodes where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_areacodes",GetLayerName("vg_areacodes"),EntityOperationType.Delete,new List<long>{id});
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
                OnEntityChanged("vg_areacodes",GetLayerName("vg_areacodes"),EntityOperationType.Delete,null);
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
            bool retVal= vgCadcode.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_cadcodes",GetLayerName("vg_cadcodes"),EntityOperationType.Save,new List<long>{vgCadcode.ID});
            }
            return retVal;
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
            List<long> ids=vgCadcodes.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_cadcodes",GetLayerName("vg_cadcodes"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgCadcodes(VgCadcodes record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_cadcodes",GetLayerName("vg_cadcodes"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgCadcodes(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_cadcodes where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_cadcodes",GetLayerName("vg_cadcodes"),EntityOperationType.Delete,new List<long>{id});
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
                OnEntityChanged("vg_cadcodes",GetLayerName("vg_cadcodes"),EntityOperationType.Delete,null);
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
            bool retVal= vgObjectclass.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_objectclasses",GetLayerName("vg_objectclasses"),EntityOperationType.Save,new List<long>{vgObjectclass.ID});
            }
            return retVal;
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
            List<long> ids=vgObjectclasss.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_objectclasses",GetLayerName("vg_objectclasses"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgObjectclasses(VgObjectclasses record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_objectclasses",GetLayerName("vg_objectclasses"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgObjectclasses(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_objectclasses where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_objectclasses",GetLayerName("vg_objectclasses"),EntityOperationType.Delete,new List<long>{id});
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
                OnEntityChanged("vg_objectclasses",GetLayerName("vg_objectclasses"),EntityOperationType.Delete,null);
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
            bool retVal= vgSetting.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_settings",GetLayerName("vg_settings"),EntityOperationType.Save,new List<long>{vgSetting.ID});
            }
            return retVal;
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
            List<long> ids=vgSettings.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_settings",GetLayerName("vg_settings"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgSettings(VgSettings record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_settings",GetLayerName("vg_settings"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgSettings(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_settings where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_settings",GetLayerName("vg_settings"),EntityOperationType.Delete,new List<long>{id});
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
                OnEntityChanged("vg_settings",GetLayerName("vg_settings"),EntityOperationType.Delete,null);
            }
        }
        
        
        
        
    }
}



