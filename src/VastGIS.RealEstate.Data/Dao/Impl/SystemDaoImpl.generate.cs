using System;
using Dapper;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao.Impl
{
    public partial class SystemDaoImpl : SQLiteDao,SystemDao
    {	
        public Dictionary<string,string> _entityNames;        
        
        
        #region VG_ATTACHMENT SQL语句
        private string CREATE_VIEW_VG_ATTACHMENT="CREATE VIEW VG_ATTACHMENTVIEW AS SELECT  Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ FROM vg_attachment WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_VG_ATTACHMENT="CREATE TRIGGER [vw_ins_VG_ATTACHMENTVIEW] INSTEAD OF INSERT ON [VG_ATTACHMENTVIEW] BEGIN INSERT OR REPLACE INTO [VG_ATTACHMENT] ([Id],[WX_WYDM],[FJMC],[FJLJ],[FJLX],[HQSJ],[FJSM],[DatabaseId],[FLAGS],[XGR],[XGSJ])  VALUES (NEW.[Id],NEW.[WX_WYDM],NEW.[FJMC],NEW.[FJLJ],NEW.[FJLX],NEW.[HQSJ],NEW.[FJSM],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ]);END";
        private string UPDATE_TRIGGER_VG_ATTACHMENT="CREATE TRIGGER [vw_upd_VG_ATTACHMENTVIEW] INSTEAD OF UPDATE OF [Id],[WX_WYDM],[FJMC],[FJLJ],[FJLX],[HQSJ],[FJSM],[DatabaseId],[FLAGS],[XGR],[XGSJ] ON [VG_ATTACHMENTVIEW] BEGIN UPDATE [VG_ATTACHMENT] SET [Id]=NEW.[Id],[WX_WYDM]=NEW.[WX_WYDM],[FJMC]=NEW.[FJMC],[FJLJ]=NEW.[FJLJ],[FJLX]=NEW.[FJLX],[HQSJ]=NEW.[HQSJ],[FJSM]=NEW.[FJSM],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_VG_ATTACHMENT="CREATE TRIGGER [vw_del_VG_ATTACHMENTVIEW] INSTEAD OF DELETE ON [VG_ATTACHMENTVIEW] BEGIN DELETE FROM [vg_attachment] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_VG_ATTACHMENT="SELECT  Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ FROM vg_attachment WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_VG_ATTACHMENTVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('vg_attachmentview','geometry','rowid','vg_attachment','geometry',0)";
        #endregion        
        
        
        #region 初始化
        public SystemDaoImpl():base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("vg_areacode","行政代码");
            _entityNames.Add("vg_attachment","附件");
            _entityNames.Add("vg_cadcode","CASS代码表");
            _entityNames.Add("vg_classdetail","要素类明细");
            _entityNames.Add("vg_classgroup","要素组");
            _entityNames.Add("vg_fieldinfo","字段信息");
            _entityNames.Add("vg_layergroup","层组");
            _entityNames.Add("vg_layergroupdetail","层组明细");
            _entityNames.Add("vg_objectysdm","要素代码");
            _entityNames.Add("vg_setting","设计");
            _entityNames.Add("vg_objectitem","要素表");
            _entityNames.Add("vg_objectclass","要素类明细");
            _entityNames.Add("vg_classrelation","关联关系表");
             //RebuildSelectDictionary();
        }
        #endregion
        
                
        public string GetLayerName(string tableName)
        {
            tableName=tableName.ToUpper();
            if(_entityNames.ContainsKey(tableName))
                return _entityNames[tableName];
            else
                return "";
        }
        
       
        
        #region VgAreacode方法
        public VgAreacode GetVgAreacode(long id)
        {
            string sql="SELECT  Id As ID,XZQHMC As Xzqhmc,XZQHDM As Xzqhdm,XZQHJB As Xzqhjb FROM vg_areacode " + " where id="+id.ToString();
            IEnumerable<VgAreacode> records=connection.Query<VgAreacode>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgAreacode> GetVgAreacodes(string filter)
        {
            string sql="SELECT  Id As ID,XZQHMC As Xzqhmc,XZQHDM As Xzqhdm,XZQHJB As Xzqhjb FROM vg_areacode " + " where "+filter;
            var records=connection.Query<VgAreacode>(sql);            
            return records;
        }
        public bool SaveVgAreacode(VgAreacode record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgAreacodes(List<VgAreacode> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgAreacode(VgAreacode record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgAreacode> records=GetVgAreacodes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgAreacode record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgAttachment方法
        public VgAttachment GetVgAttachment(long id)
        {
            string sql="SELECT  Id As ID,WX_WYDM As WxWydm,FJMC As Fjmc,FJLJ As Fjlj,FJLX As Fjlx,HQSJ As Hqsj,FJSM As Fjsm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM vg_attachment " + " where id="+id.ToString();
            IEnumerable<VgAttachment> records=connection.Query<VgAttachment>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgAttachment> GetVgAttachments(string filter)
        {
            string sql="SELECT  Id As ID,WX_WYDM As WxWydm,FJMC As Fjmc,FJLJ As Fjlj,FJLX As Fjlx,HQSJ As Hqsj,FJSM As Fjsm,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM vg_attachment " + " where "+filter;
            var records=connection.Query<VgAttachment>(sql);            
            return records;
        }
        public bool SaveVgAttachment(VgAttachment record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgAttachments(List<VgAttachment> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgAttachment(VgAttachment record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgAttachment> records=GetVgAttachments(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgAttachment record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgCadcode方法
        public VgCadcode GetVgCadcode(long id)
        {
            string sql="SELECT  Id As ID,XH As Xh,SFCY As Sfcy,TC As Tc,CASSDM As Cassdm,TXLX As Txlx,XTC As Xtc,YSDM As Ysdm,YSLX As Yslx,YSZL As Yszl FROM vg_cadcode " + " where id="+id.ToString();
            IEnumerable<VgCadcode> records=connection.Query<VgCadcode>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgCadcode> GetVgCadcodes(string filter)
        {
            string sql="SELECT  Id As ID,XH As Xh,SFCY As Sfcy,TC As Tc,CASSDM As Cassdm,TXLX As Txlx,XTC As Xtc,YSDM As Ysdm,YSLX As Yslx,YSZL As Yszl FROM vg_cadcode " + " where "+filter;
            var records=connection.Query<VgCadcode>(sql);            
            return records;
        }
        public bool SaveVgCadcode(VgCadcode record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgCadcodes(List<VgCadcode> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgCadcode(VgCadcode record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgCadcode> records=GetVgCadcodes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgCadcode record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgClassdetail方法
        public VgClassdetail GetVgClassdetail(long id)
        {
            string sql="SELECT  Id As ID,GroupName As GroupName,ObjectTableName As ObjectTableName,CreateImpl As CreateImpl,InterfaceName As InterfaceName FROM vg_classdetail " + " where id="+id.ToString();
            IEnumerable<VgClassdetail> records=connection.Query<VgClassdetail>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgClassdetail> GetVgClassdetails(string filter)
        {
            string sql="SELECT  Id As ID,GroupName As GroupName,ObjectTableName As ObjectTableName,CreateImpl As CreateImpl,InterfaceName As InterfaceName FROM vg_classdetail " + " where "+filter;
            var records=connection.Query<VgClassdetail>(sql);            
            return records;
        }
        public bool SaveVgClassdetail(VgClassdetail record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgClassdetails(List<VgClassdetail> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgClassdetail(VgClassdetail record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgClassdetail> records=GetVgClassdetails(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgClassdetail record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgClassgroup方法
        public VgClassgroup GetVgClassgroup(long id)
        {
            string sql="SELECT  Id As ID,GroupName As GroupName,CreateImpl As CreateImpl FROM vg_classgroup " + " where id="+id.ToString();
            IEnumerable<VgClassgroup> records=connection.Query<VgClassgroup>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgClassgroup> GetVgClassgroups(string filter)
        {
            string sql="SELECT  Id As ID,GroupName As GroupName,CreateImpl As CreateImpl FROM vg_classgroup " + " where "+filter;
            var records=connection.Query<VgClassgroup>(sql);            
            return records;
        }
        public bool SaveVgClassgroup(VgClassgroup record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgClassgroups(List<VgClassgroup> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgClassgroup(VgClassgroup record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgClassgroup> records=GetVgClassgroups(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgClassgroup record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgFieldinfo方法
        public VgFieldinfo GetVgFieldinfo(long id)
        {
            string sql="SELECT  Id As ID,BM As Bm,BNSX As Bnsx,ZDZWMC As Zdzwmc,ZDMC As Zdmc,ZDLX As Zdlx,ZDCD As Zdcd,ZDXSWS As Zdxsws,SYZD As Syzd,YS As Ys,SYZDYW As Syzdyw FROM vg_fieldinfo " + " where id="+id.ToString();
            IEnumerable<VgFieldinfo> records=connection.Query<VgFieldinfo>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgFieldinfo> GetVgFieldinfos(string filter)
        {
            string sql="SELECT  Id As ID,BM As Bm,BNSX As Bnsx,ZDZWMC As Zdzwmc,ZDMC As Zdmc,ZDLX As Zdlx,ZDCD As Zdcd,ZDXSWS As Zdxsws,SYZD As Syzd,YS As Ys,SYZDYW As Syzdyw FROM vg_fieldinfo " + " where "+filter;
            var records=connection.Query<VgFieldinfo>(sql);            
            return records;
        }
        public bool SaveVgFieldinfo(VgFieldinfo record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgFieldinfos(List<VgFieldinfo> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgFieldinfo(VgFieldinfo record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgFieldinfo> records=GetVgFieldinfos(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgFieldinfo record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgLayergroup方法
        public VgLayergroup GetVgLayergroup(long id)
        {
            string sql="SELECT  Id As ID,ZM As Zm FROM vg_layergroup " + " where id="+id.ToString();
            IEnumerable<VgLayergroup> records=connection.Query<VgLayergroup>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgLayergroup> GetVgLayergroups(string filter)
        {
            string sql="SELECT  Id As ID,ZM As Zm FROM vg_layergroup " + " where "+filter;
            var records=connection.Query<VgLayergroup>(sql);            
            return records;
        }
        public bool SaveVgLayergroup(VgLayergroup record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgLayergroups(List<VgLayergroup> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgLayergroup(VgLayergroup record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgLayergroup> records=GetVgLayergroups(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgLayergroup record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgLayergroupdetail方法
        public VgLayergroupdetail GetVgLayergroupdetail(long id)
        {
            string sql="SELECT  Id As ID,ZM As Zm,Mc As Mc,IDENTIFY As Identify,EDITABLE As Editable,QUERYABLE As Queryable,SNAPABLE As Snapable,VISIBLE As Visible FROM vg_layergroupdetail " + " where id="+id.ToString();
            IEnumerable<VgLayergroupdetail> records=connection.Query<VgLayergroupdetail>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgLayergroupdetail> GetVgLayergroupdetails(string filter)
        {
            string sql="SELECT  Id As ID,ZM As Zm,Mc As Mc,IDENTIFY As Identify,EDITABLE As Editable,QUERYABLE As Queryable,SNAPABLE As Snapable,VISIBLE As Visible FROM vg_layergroupdetail " + " where "+filter;
            var records=connection.Query<VgLayergroupdetail>(sql);            
            return records;
        }
        public bool SaveVgLayergroupdetail(VgLayergroupdetail record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgLayergroupdetails(List<VgLayergroupdetail> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgLayergroupdetail(VgLayergroupdetail record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgLayergroupdetail> records=GetVgLayergroupdetails(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgLayergroupdetail record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgObjectysdm方法
        public VgObjectysdm GetVgObjectysdm(long id)
        {
            string sql="SELECT  Id As ID,YSDM As Ysdm,YSMC As Ysmc,XSSX As Xssx,QSBG As Qsbg,QSFH As Qsfh,SFKJ As Sfkj FROM vg_objectysdm " + " where id="+id.ToString();
            IEnumerable<VgObjectysdm> records=connection.Query<VgObjectysdm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectysdm> GetVgObjectysdms(string filter)
        {
            string sql="SELECT  Id As ID,YSDM As Ysdm,YSMC As Ysmc,XSSX As Xssx,QSBG As Qsbg,QSFH As Qsfh,SFKJ As Sfkj FROM vg_objectysdm " + " where "+filter;
            var records=connection.Query<VgObjectysdm>(sql);            
            return records;
        }
        public bool SaveVgObjectysdm(VgObjectysdm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgObjectysdms(List<VgObjectysdm> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgObjectysdm(VgObjectysdm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgObjectysdm> records=GetVgObjectysdms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgObjectysdm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgSetting方法
        public VgSetting GetVgSetting(long id)
        {
            string sql="SELECT  Id As ID,CSMC As Csmc,CSZ As Csz FROM vg_setting " + " where id="+id.ToString();
            IEnumerable<VgSetting> records=connection.Query<VgSetting>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgSetting> GetVgSettings(string filter)
        {
            string sql="SELECT  Id As ID,CSMC As Csmc,CSZ As Csz FROM vg_setting " + " where "+filter;
            var records=connection.Query<VgSetting>(sql);            
            return records;
        }
        public bool SaveVgSetting(VgSetting record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgSettings(List<VgSetting> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgSetting(VgSetting record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgSetting> records=GetVgSettings(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgSetting record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgObjectitem方法
        public VgObjectitem GetVgObjectitem(long id)
        {
            string sql="SELECT  Id As ID,YSDM As Ysdm,YSMC As Ysmc,YSBM As Ysbm,SFKJ As Sfkj,YSLX As Yslx,SM As Sm FROM vg_objectitem " + " where id="+id.ToString();
            IEnumerable<VgObjectitem> records=connection.Query<VgObjectitem>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectitem> GetVgObjectitems(string filter)
        {
            string sql="SELECT  Id As ID,YSDM As Ysdm,YSMC As Ysmc,YSBM As Ysbm,SFKJ As Sfkj,YSLX As Yslx,SM As Sm FROM vg_objectitem " + " where "+filter;
            var records=connection.Query<VgObjectitem>(sql);            
            return records;
        }
        public bool SaveVgObjectitem(VgObjectitem record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgObjectitems(List<VgObjectitem> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgObjectitem(VgObjectitem record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteVgObjectitem(long id)
        {
           VgObjectitem record=GetVgObjectitem(id);
           if(record !=null)
           DeleteVgObjectitem(record);        
        }
        public void DeleteVgObjectitem(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgObjectitem> records=GetVgObjectitems(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgObjectitem record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgObjectclass方法
        public VgObjectclass GetVgObjectclass(long id)
        {
            string sql="SELECT  Id As ID,MC As Mc,DXLX As Dxlx,ZWMC As Zwmc,FBMC As Fbmc,XHZDMC As Xhzdmc,TXZDMC As Txzdmc,TXLX As Txlx,IDENTIFY As Identify,EDITABLE As Editable,QUERYABLE As Queryable,SNAPABLE As Snapable,VISIBLE As Visible,XSSX As Xssx,FILTER As Filter,QSDM As Qsdm,BJCT As Bjct,BHFJ As Bhfj FROM vg_objectclass " + " where id="+id.ToString();
            IEnumerable<VgObjectclass> records=connection.Query<VgObjectclass>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgObjectclass> GetVgObjectclasses(string filter)
        {
            string sql="SELECT  Id As ID,MC As Mc,DXLX As Dxlx,ZWMC As Zwmc,FBMC As Fbmc,XHZDMC As Xhzdmc,TXZDMC As Txzdmc,TXLX As Txlx,IDENTIFY As Identify,EDITABLE As Editable,QUERYABLE As Queryable,SNAPABLE As Snapable,VISIBLE As Visible,XSSX As Xssx,FILTER As Filter,QSDM As Qsdm,BJCT As Bjct,BHFJ As Bhfj FROM vg_objectclass " + " where "+filter;
            var records=connection.Query<VgObjectclass>(sql);            
            return records;
        }
        public bool SaveVgObjectclass(VgObjectclass record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgObjectclasses(List<VgObjectclass> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgObjectclass(VgObjectclass record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
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
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgObjectclass> records=GetVgObjectclasses(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgObjectclass record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgClassrelation方法
        public VgClassrelation GetVgClassrelation(long id)
        {
            string sql="SELECT  Id As ID,YSBM As Ysbm,GLBM As Glbm,YSZD As Yszd,GLZD As Glzd,GLLX As Gllx,GXB As Gxb,YSGX As Ysgx,GLGX As Glgx FROM vg_classrelation " + " where id="+id.ToString();
            IEnumerable<VgClassrelation> records=connection.Query<VgClassrelation>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgClassrelation> GetVgClassrelations(string filter)
        {
            string sql="SELECT  Id As ID,YSBM As Ysbm,GLBM As Glbm,YSZD As Yszd,GLZD As Glzd,GLLX As Gllx,GXB As Gxb,YSGX As Ysgx,GLGX As Glgx FROM vg_classrelation " + " where "+filter;
            var records=connection.Query<VgClassrelation>(sql);            
            return records;
        }
        public bool SaveVgClassrelation(VgClassrelation record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgClassrelations(List<VgClassrelation> records)
        {
            List<IEntity> backList=new List<IEntity>();
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in records)
            {
                rec.Save(this);
                backList.Add(rec as IEntity);
            }
            tran.Commit();
            tran.Dispose();
            OnEntityChanged(EntityOperationType.Save, backList);    
        }
        public void DeleteVgClassrelation(VgClassrelation record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteVgClassrelation(long id)
        {
           VgClassrelation record=GetVgClassrelation(id);
           if(record !=null)
           DeleteVgClassrelation(record);        
        }
        public void DeleteVgClassrelation(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgClassrelation> records=GetVgClassrelations(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgClassrelation record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        
    }
}