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
        private string SELECT_VG_OBJECTCLASS = "select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER,QSDM,BJCT,BHFJ from vg_objectclass";
        
        private string SELECT_VG_SETTING = "select Id,CSMC,CSZ from vg_setting";
        
        private string SELECT_VG_CADCODE = "select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcode";
        
        private string SELECT_VG_AREACODE = "select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacode";
        
        private string SELECT_VG_OBJECTYSDM = "select Id,YSDM,YSMC,XSSX,QSBG,QSFH,SFKJ from vg_objectysdm";
        
        private string SELECT_VG_LAYERGROUP = "select Id,ZM from vg_layergroup";
        
        private string SELECT_VG_LAYERGROUPDETAIL = "select Id,ZM,Mc,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE from vg_layergroupdetail";
        
        private string SELECT_VG_CLASSGROUP = "select Id,GroupName,CreateImpl from vg_classgroup";
        
        private string SELECT_VG_CLASSDETAIL = "select Id,GroupName,ObjectTableName,CreateImpl,InterfaceName from vg_classdetail";
        
        private string SELECT_VG_FIELDINFO = "select Id,BM,BNSX,ZDZWMC,ZDMC,ZDLX,ZDCD,ZDXSWS,SYZD,YS,SYZDYW from vg_fieldinfo";
        
        private string CREATE_VIEW_VG_ATTACHMENT="CREATE VIEW vg_attachmentVIEW AS select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ from vg_attachment Where [FLAGS] < 3;";
        
        private string CREATE_INSERT_TRIGGER_vg_attachment="CREATE TRIGGER [vw_ins_vg_attachmentVIEW] INSTEAD OF INSERT ON [vg_attachmentVIEW] BEGIN  INSERT OR REPLACE INTO [vg_attachment] ([Id], [WX_WYDM], [FJMC], [FJLJ], [FJLX], [HQSJ], [FJSM], [DatabaseId], [FLAGS], [XGR], [XGSJ]) VALUES ( NEW.[Id], NEW.[WX_WYDM], NEW.[FJMC], NEW.[FJLJ], NEW.[FJLX], NEW.[HQSJ], NEW.[FJSM], NEW.[DatabaseId], NEW.[FLAGS], NEW.[XGR], NEW.[XGSJ]); END";
        
        private string CREATE_UPDATE_TRIGGER_vg_attachment="CREATE TRIGGER [vw_upd_vg_attachmentVIEW] INSTEAD OF UPDATE OF [Id], [WX_WYDM], [FJMC], [FJLJ], [FJLX], [HQSJ], [FJSM], [DatabaseId], [FLAGS], [XGR], [XGSJ] ON [vg_attachmentVIEW] BEGIN  Update [vg_attachment] SET [Id]=NEW.[Id], [WX_WYDM]=NEW.[WX_WYDM], [FJMC]=NEW.[FJMC], [FJLJ]=NEW.[FJLJ], [FJLX]=NEW.[FJLX], [HQSJ]=NEW.[HQSJ], [FJSM]=NEW.[FJSM], [DatabaseId]=NEW.[DatabaseId], [FLAGS]=NEW.[FLAGS], [XGR]=NEW.[XGR], [XGSJ]=NEW.[XGSJ] WHERE ROWID=OLD.ROWID;END";
        
        private string CREATE_DELETE_TRIGGER_vg_attachment="CREATE TRIGGER vw_del_vg_attachmentVIEW INSTEAD OF DELETE ON vg_attachmentVIEW BEGIN DELETE FROM vg_attachment WHERE ROWID=OLD.ROWID;END";
        private string SELECT_VG_ATTACHMENT = "select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ from vg_attachment Where [FLAGS] < 3";
        
        
        public SystemDaoImpl(): base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("VG_OBJECTCLASS","");
            _entityNames.Add("VG_SETTING","");
            _entityNames.Add("VG_CADCODE","");
            _entityNames.Add("VG_AREACODE","");
            _entityNames.Add("VG_OBJECTYSDM","");
            _entityNames.Add("VG_LAYERGROUP","");
            _entityNames.Add("VG_LAYERGROUPDETAIL","");
            _entityNames.Add("VG_CLASSGROUP","");
            _entityNames.Add("VG_CLASSDETAIL","");
            _entityNames.Add("VG_FIELDINFO","");
            _entityNames.Add("VG_ATTACHMENT","");
        }
        
        private event EntityChangedEventHandler entityChanged;

        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(string tableName, string layerName, EntityOperationType operationType, List<long> ids)
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
        
        ///VgObjectclass函数
        public VgObjectclass GetVgObjectclass(long id)
        {
            string sql="select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER,QSDM,BJCT,BHFJ from vg_objectclass" + " where id="+id.ToString();
            IEnumerable<VgObjectclass> vgObjectclasss=connection.Query<VgObjectclass>(sql);
            if(vgObjectclasss != null && vgObjectclasss.Count()>0)
            {
                return vgObjectclasss.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectclass> GetVgObjectclasses(string filter)
        {
            string sql="select Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER,QSDM,BJCT,BHFJ from vg_objectclass" + " where "+filter;
            var vgObjectclasss=connection.Query<VgObjectclass>(sql);
            
            return vgObjectclasss;
        }
        
        public bool SaveVgObjectclass(VgObjectclass vgObjectclass)
        {
            bool retVal= vgObjectclass.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_objectclass",GetLayerName("vg_objectclass"),EntityOperationType.Save,new List<long>{vgObjectclass.ID});
            }
            return retVal;
        }
        
        public void SaveVgObjectclasses(List<VgObjectclass> vgObjectclasses)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgObjectclasses)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgObjectclasses.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_objectclass",GetLayerName("vg_objectclass"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgObjectclass(VgObjectclass record)
        {
            record.Delete(this);
            OnEntityChanged("vg_objectclass",GetLayerName("vg_objectclass"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgObjectclass(long id)
        {
           VgObjectclass record=GetVgObjectclass(id);
           if(record !=null)
           DeleteVgObjectclass(record);           
        }
        
        public void DeleteVgObjectclass(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_objectclass";
                else
                    command.CommandText="delete from vg_objectclass where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_objectclass",GetLayerName("vg_objectclass"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgSetting函数
        public VgSetting GetVgSetting(long id)
        {
            string sql="select Id,CSMC,CSZ from vg_setting" + " where id="+id.ToString();
            IEnumerable<VgSetting> vgSettings=connection.Query<VgSetting>(sql);
            if(vgSettings != null && vgSettings.Count()>0)
            {
                return vgSettings.First();
            }
            return null;
        }
        
        public IEnumerable<VgSetting> GetVgSettings(string filter)
        {
            string sql="select Id,CSMC,CSZ from vg_setting" + " where "+filter;
            var vgSettings=connection.Query<VgSetting>(sql);
            
            return vgSettings;
        }
        
        public bool SaveVgSetting(VgSetting vgSetting)
        {
            bool retVal= vgSetting.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_setting",GetLayerName("vg_setting"),EntityOperationType.Save,new List<long>{vgSetting.ID});
            }
            return retVal;
        }
        
        public void SaveVgSettings(List<VgSetting> vgSettings)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgSettings)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgSettings.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_setting",GetLayerName("vg_setting"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgSetting(VgSetting record)
        {
            record.Delete(this);
            OnEntityChanged("vg_setting",GetLayerName("vg_setting"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgSetting(long id)
        {
           VgSetting record=GetVgSetting(id);
           if(record !=null)
           DeleteVgSetting(record);           
        }
        
        public void DeleteVgSetting(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_setting";
                else
                    command.CommandText="delete from vg_setting where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_setting",GetLayerName("vg_setting"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgCadcode函数
        public VgCadcode GetVgCadcode(long id)
        {
            string sql="select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcode" + " where id="+id.ToString();
            IEnumerable<VgCadcode> vgCadcodes=connection.Query<VgCadcode>(sql);
            if(vgCadcodes != null && vgCadcodes.Count()>0)
            {
                return vgCadcodes.First();
            }
            return null;
        }
        
        public IEnumerable<VgCadcode> GetVgCadcodes(string filter)
        {
            string sql="select Id,XH,SFCY,TC,CASSDM,TXLX,XTC,YSDM,YSLX,YSZL from vg_cadcode" + " where "+filter;
            var vgCadcodes=connection.Query<VgCadcode>(sql);
            
            return vgCadcodes;
        }
        
        public bool SaveVgCadcode(VgCadcode vgCadcode)
        {
            bool retVal= vgCadcode.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_cadcode",GetLayerName("vg_cadcode"),EntityOperationType.Save,new List<long>{vgCadcode.ID});
            }
            return retVal;
        }
        
        public void SaveVgCadcodes(List<VgCadcode> vgCadcodes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgCadcodes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgCadcodes.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_cadcode",GetLayerName("vg_cadcode"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgCadcode(VgCadcode record)
        {
            record.Delete(this);
            OnEntityChanged("vg_cadcode",GetLayerName("vg_cadcode"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgCadcode(long id)
        {
           VgCadcode record=GetVgCadcode(id);
           if(record !=null)
           DeleteVgCadcode(record);           
        }
        
        public void DeleteVgCadcode(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_cadcode";
                else
                    command.CommandText="delete from vg_cadcode where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_cadcode",GetLayerName("vg_cadcode"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgAreacode函数
        public VgAreacode GetVgAreacode(long id)
        {
            string sql="select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacode" + " where id="+id.ToString();
            IEnumerable<VgAreacode> vgAreacodes=connection.Query<VgAreacode>(sql);
            if(vgAreacodes != null && vgAreacodes.Count()>0)
            {
                return vgAreacodes.First();
            }
            return null;
        }
        
        public IEnumerable<VgAreacode> GetVgAreacodes(string filter)
        {
            string sql="select Id,XZQHMC,XZQHDM,XZQHJB from vg_areacode" + " where "+filter;
            var vgAreacodes=connection.Query<VgAreacode>(sql);
            
            return vgAreacodes;
        }
        
        public bool SaveVgAreacode(VgAreacode vgAreacode)
        {
            bool retVal= vgAreacode.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_areacode",GetLayerName("vg_areacode"),EntityOperationType.Save,new List<long>{vgAreacode.ID});
            }
            return retVal;
        }
        
        public void SaveVgAreacodes(List<VgAreacode> vgAreacodes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgAreacodes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgAreacodes.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_areacode",GetLayerName("vg_areacode"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgAreacode(VgAreacode record)
        {
            record.Delete(this);
            OnEntityChanged("vg_areacode",GetLayerName("vg_areacode"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgAreacode(long id)
        {
           VgAreacode record=GetVgAreacode(id);
           if(record !=null)
           DeleteVgAreacode(record);           
        }
        
        public void DeleteVgAreacode(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_areacode";
                else
                    command.CommandText="delete from vg_areacode where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_areacode",GetLayerName("vg_areacode"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgObjectysdm函数
        public VgObjectysdm GetVgObjectysdm(long id)
        {
            string sql="select Id,YSDM,YSMC,XSSX,QSBG,QSFH,SFKJ from vg_objectysdm" + " where id="+id.ToString();
            IEnumerable<VgObjectysdm> vgObjectysdms=connection.Query<VgObjectysdm>(sql);
            if(vgObjectysdms != null && vgObjectysdms.Count()>0)
            {
                return vgObjectysdms.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter)
        {
            string sql="select Id,YSDM,YSMC,XSSX,QSBG,QSFH,SFKJ from vg_objectysdm" + " where "+filter;
            var vgObjectysdms=connection.Query<VgObjectysdm>(sql);
            
            return vgObjectysdms;
        }
        
        public bool SaveVgObjectysdm(VgObjectysdm vgObjectysdm)
        {
            bool retVal= vgObjectysdm.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_objectysdm",GetLayerName("vg_objectysdm"),EntityOperationType.Save,new List<long>{vgObjectysdm.ID});
            }
            return retVal;
        }
        
        public void SaveVgObjectysdms(List<VgObjectysdm> vgObjectysdms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgObjectysdms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgObjectysdms.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_objectysdm",GetLayerName("vg_objectysdm"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgObjectysdm(VgObjectysdm record)
        {
            record.Delete(this);
            OnEntityChanged("vg_objectysdm",GetLayerName("vg_objectysdm"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgObjectysdm(long id)
        {
           VgObjectysdm record=GetVgObjectysdm(id);
           if(record !=null)
           DeleteVgObjectysdm(record);           
        }
        
        public void DeleteVgObjectysdm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_objectysdm";
                else
                    command.CommandText="delete from vg_objectysdm where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_objectysdm",GetLayerName("vg_objectysdm"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgLayergroup函数
        public VgLayergroup GetVgLayergroup(long id)
        {
            string sql="select Id,ZM from vg_layergroup" + " where id="+id.ToString();
            IEnumerable<VgLayergroup> vgLayergroups=connection.Query<VgLayergroup>(sql);
            if(vgLayergroups != null && vgLayergroups.Count()>0)
            {
                return vgLayergroups.First();
            }
            return null;
        }
        
        public IEnumerable<VgLayergroup> GetVgLayergroups(string filter)
        {
            string sql="select Id,ZM from vg_layergroup" + " where "+filter;
            var vgLayergroups=connection.Query<VgLayergroup>(sql);
            
            return vgLayergroups;
        }
        
        public bool SaveVgLayergroup(VgLayergroup vgLayergroup)
        {
            bool retVal= vgLayergroup.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_layergroup",GetLayerName("vg_layergroup"),EntityOperationType.Save,new List<long>{vgLayergroup.ID});
            }
            return retVal;
        }
        
        public void SaveVgLayergroups(List<VgLayergroup> vgLayergroups)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgLayergroups)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgLayergroups.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_layergroup",GetLayerName("vg_layergroup"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgLayergroup(VgLayergroup record)
        {
            record.Delete(this);
            OnEntityChanged("vg_layergroup",GetLayerName("vg_layergroup"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgLayergroup(long id)
        {
           VgLayergroup record=GetVgLayergroup(id);
           if(record !=null)
           DeleteVgLayergroup(record);           
        }
        
        public void DeleteVgLayergroup(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_layergroup";
                else
                    command.CommandText="delete from vg_layergroup where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_layergroup",GetLayerName("vg_layergroup"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgLayergroupdetail函数
        public VgLayergroupdetail GetVgLayergroupdetail(long id)
        {
            string sql="select Id,ZM,Mc,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE from vg_layergroupdetail" + " where id="+id.ToString();
            IEnumerable<VgLayergroupdetail> vgLayergroupdetails=connection.Query<VgLayergroupdetail>(sql);
            if(vgLayergroupdetails != null && vgLayergroupdetails.Count()>0)
            {
                return vgLayergroupdetails.First();
            }
            return null;
        }
        
        public IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter)
        {
            string sql="select Id,ZM,Mc,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE from vg_layergroupdetail" + " where "+filter;
            var vgLayergroupdetails=connection.Query<VgLayergroupdetail>(sql);
            
            return vgLayergroupdetails;
        }
        
        public bool SaveVgLayergroupdetail(VgLayergroupdetail vgLayergroupdetail)
        {
            bool retVal= vgLayergroupdetail.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_layergroupdetail",GetLayerName("vg_layergroupdetail"),EntityOperationType.Save,new List<long>{vgLayergroupdetail.ID});
            }
            return retVal;
        }
        
        public void SaveVgLayergroupdetails(List<VgLayergroupdetail> vgLayergroupdetails)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgLayergroupdetails)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgLayergroupdetails.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_layergroupdetail",GetLayerName("vg_layergroupdetail"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgLayergroupdetail(VgLayergroupdetail record)
        {
            record.Delete(this);
            OnEntityChanged("vg_layergroupdetail",GetLayerName("vg_layergroupdetail"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgLayergroupdetail(long id)
        {
           VgLayergroupdetail record=GetVgLayergroupdetail(id);
           if(record !=null)
           DeleteVgLayergroupdetail(record);           
        }
        
        public void DeleteVgLayergroupdetail(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_layergroupdetail";
                else
                    command.CommandText="delete from vg_layergroupdetail where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_layergroupdetail",GetLayerName("vg_layergroupdetail"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgClassgroup函数
        public VgClassgroup GetVgClassgroup(long id)
        {
            string sql="select Id,GroupName,CreateImpl from vg_classgroup" + " where id="+id.ToString();
            IEnumerable<VgClassgroup> vgClassgroups=connection.Query<VgClassgroup>(sql);
            if(vgClassgroups != null && vgClassgroups.Count()>0)
            {
                return vgClassgroups.First();
            }
            return null;
        }
        
        public IEnumerable<VgClassgroup> GetVgClassgroups(string filter)
        {
            string sql="select Id,GroupName,CreateImpl from vg_classgroup" + " where "+filter;
            var vgClassgroups=connection.Query<VgClassgroup>(sql);
            
            return vgClassgroups;
        }
        
        public bool SaveVgClassgroup(VgClassgroup vgClassgroup)
        {
            bool retVal= vgClassgroup.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_classgroup",GetLayerName("vg_classgroup"),EntityOperationType.Save,new List<long>{vgClassgroup.ID});
            }
            return retVal;
        }
        
        public void SaveVgClassgroups(List<VgClassgroup> vgClassgroups)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgClassgroups)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgClassgroups.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_classgroup",GetLayerName("vg_classgroup"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgClassgroup(VgClassgroup record)
        {
            record.Delete(this);
            OnEntityChanged("vg_classgroup",GetLayerName("vg_classgroup"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgClassgroup(long id)
        {
           VgClassgroup record=GetVgClassgroup(id);
           if(record !=null)
           DeleteVgClassgroup(record);           
        }
        
        public void DeleteVgClassgroup(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_classgroup";
                else
                    command.CommandText="delete from vg_classgroup where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_classgroup",GetLayerName("vg_classgroup"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgClassdetail函数
        public VgClassdetail GetVgClassdetail(long id)
        {
            string sql="select Id,GroupName,ObjectTableName,CreateImpl,InterfaceName from vg_classdetail" + " where id="+id.ToString();
            IEnumerable<VgClassdetail> vgClassdetails=connection.Query<VgClassdetail>(sql);
            if(vgClassdetails != null && vgClassdetails.Count()>0)
            {
                return vgClassdetails.First();
            }
            return null;
        }
        
        public IEnumerable<VgClassdetail> GetVgClassdetails(string filter)
        {
            string sql="select Id,GroupName,ObjectTableName,CreateImpl,InterfaceName from vg_classdetail" + " where "+filter;
            var vgClassdetails=connection.Query<VgClassdetail>(sql);
            
            return vgClassdetails;
        }
        
        public bool SaveVgClassdetail(VgClassdetail vgClassdetail)
        {
            bool retVal= vgClassdetail.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_classdetail",GetLayerName("vg_classdetail"),EntityOperationType.Save,new List<long>{vgClassdetail.ID});
            }
            return retVal;
        }
        
        public void SaveVgClassdetails(List<VgClassdetail> vgClassdetails)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgClassdetails)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgClassdetails.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_classdetail",GetLayerName("vg_classdetail"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgClassdetail(VgClassdetail record)
        {
            record.Delete(this);
            OnEntityChanged("vg_classdetail",GetLayerName("vg_classdetail"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgClassdetail(long id)
        {
           VgClassdetail record=GetVgClassdetail(id);
           if(record !=null)
           DeleteVgClassdetail(record);           
        }
        
        public void DeleteVgClassdetail(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_classdetail";
                else
                    command.CommandText="delete from vg_classdetail where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_classdetail",GetLayerName("vg_classdetail"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgFieldinfo函数
        public VgFieldinfo GetVgFieldinfo(long id)
        {
            string sql="select Id,BM,BNSX,ZDZWMC,ZDMC,ZDLX,ZDCD,ZDXSWS,SYZD,YS,SYZDYW from vg_fieldinfo" + " where id="+id.ToString();
            IEnumerable<VgFieldinfo> vgFieldinfos=connection.Query<VgFieldinfo>(sql);
            if(vgFieldinfos != null && vgFieldinfos.Count()>0)
            {
                return vgFieldinfos.First();
            }
            return null;
        }
        
        public IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter)
        {
            string sql="select Id,BM,BNSX,ZDZWMC,ZDMC,ZDLX,ZDCD,ZDXSWS,SYZD,YS,SYZDYW from vg_fieldinfo" + " where "+filter;
            var vgFieldinfos=connection.Query<VgFieldinfo>(sql);
            
            return vgFieldinfos;
        }
        
        public bool SaveVgFieldinfo(VgFieldinfo vgFieldinfo)
        {
            bool retVal= vgFieldinfo.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_fieldinfo",GetLayerName("vg_fieldinfo"),EntityOperationType.Save,new List<long>{vgFieldinfo.ID});
            }
            return retVal;
        }
        
        public void SaveVgFieldinfos(List<VgFieldinfo> vgFieldinfos)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgFieldinfos)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgFieldinfos.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_fieldinfo",GetLayerName("vg_fieldinfo"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgFieldinfo(VgFieldinfo record)
        {
            record.Delete(this);
            OnEntityChanged("vg_fieldinfo",GetLayerName("vg_fieldinfo"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgFieldinfo(long id)
        {
           VgFieldinfo record=GetVgFieldinfo(id);
           if(record !=null)
           DeleteVgFieldinfo(record);           
        }
        
        public void DeleteVgFieldinfo(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_fieldinfo";
                else
                    command.CommandText="delete from vg_fieldinfo where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_fieldinfo",GetLayerName("vg_fieldinfo"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgAttachment函数
        public VgAttachment GetVgAttachment(long id)
        {
            string sql="select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ from vg_attachment" + " where id="+id.ToString();
            IEnumerable<VgAttachment> vgAttachments=connection.Query<VgAttachment>(sql);
            if(vgAttachments != null && vgAttachments.Count()>0)
            {
                return vgAttachments.First();
            }
            return null;
        }
        
        public IEnumerable<VgAttachment> GetVgAttachments(string filter)
        {
            string sql="select Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ from vg_attachment" + " where "+filter;
            var vgAttachments=connection.Query<VgAttachment>(sql);
            
            return vgAttachments;
        }
        
        public bool SaveVgAttachment(VgAttachment vgAttachment)
        {
            bool retVal= vgAttachment.Save(this);
            if(retVal)
            {
                OnEntityChanged("vg_attachment",GetLayerName("vg_attachment"),EntityOperationType.Save,new List<long>{vgAttachment.ID});
            }
            return retVal;
        }
        
        public void SaveVgAttachments(List<VgAttachment> vgAttachments)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgAttachments)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgAttachments.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_attachment",GetLayerName("vg_attachment"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgAttachment(VgAttachment record)
        {
            record.Delete(this);
            OnEntityChanged("vg_attachment",GetLayerName("vg_attachment"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgAttachment(long id)
        {
           VgAttachment record=GetVgAttachment(id);
           if(record !=null)
           DeleteVgAttachment(record);           
        }
        
        public void DeleteVgAttachment(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<VgAttachment> rows=GetVgAttachments(filter);
                foreach(VgAttachment row in rows)
                {
                    row.Delete(this);
                }
                OnEntityChanged("vg_attachment",GetLayerName("vg_attachment"),EntityOperationType.Delete,null);
            }
        }
        
        
        
        
    }
}



