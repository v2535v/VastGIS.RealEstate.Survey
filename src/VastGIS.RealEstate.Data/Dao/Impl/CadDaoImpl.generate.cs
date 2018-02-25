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
    public partial class CadDaoImpl : SQLiteDao,CadDao
    {	
        public Dictionary<string,string> _entityNames;        
        
        
        #region TMPCADD SQL语句
        private string CREATE_VIEW_TMPCADD="CREATE VIEW TMPCADDVIEW AS SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadd WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_TMPCADD="CREATE TRIGGER [vw_ins_TMPCADDVIEW] INSTEAD OF INSERT ON [TMPCADDVIEW] BEGIN INSERT OR REPLACE INTO [TMPCADD] ([Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[EntityType],NEW.[Handle],NEW.[FileName],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_TMPCADD="CREATE TRIGGER [vw_upd_TMPCADDVIEW] INSTEAD OF UPDATE OF [Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [TMPCADDVIEW] BEGIN UPDATE [TMPCADD] SET [Id]=NEW.[Id],[EntityType]=NEW.[EntityType],[Handle]=NEW.[Handle],[FileName]=NEW.[FileName],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_TMPCADD="CREATE TRIGGER [vw_del_TMPCADDVIEW] INSTEAD OF DELETE ON [TMPCADDVIEW] BEGIN DELETE FROM [TmpCadd] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_TMPCADD="SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadd WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_TMPCADDVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcaddview','geometry','rowid','tmpcadd','geometry',0)";
        #endregion        
        
        
        #region TMPCADM SQL语句
        private string CREATE_VIEW_TMPCADM="CREATE VIEW TMPCADMVIEW AS SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadm WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_TMPCADM="CREATE TRIGGER [vw_ins_TMPCADMVIEW] INSTEAD OF INSERT ON [TMPCADMVIEW] BEGIN INSERT OR REPLACE INTO [TMPCADM] ([Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[EntityType],NEW.[Handle],NEW.[FileName],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_TMPCADM="CREATE TRIGGER [vw_upd_TMPCADMVIEW] INSTEAD OF UPDATE OF [Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [TMPCADMVIEW] BEGIN UPDATE [TMPCADM] SET [Id]=NEW.[Id],[EntityType]=NEW.[EntityType],[Handle]=NEW.[Handle],[FileName]=NEW.[FileName],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_TMPCADM="CREATE TRIGGER [vw_del_TMPCADMVIEW] INSTEAD OF DELETE ON [TMPCADMVIEW] BEGIN DELETE FROM [TmpCadm] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_TMPCADM="SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadm WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_TMPCADMVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadmview','geometry','rowid','tmpcadm','geometry',0)";
        #endregion        
        
        
        #region TMPCADX SQL语句
        private string CREATE_VIEW_TMPCADX="CREATE VIEW TMPCADXVIEW AS SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadx WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_TMPCADX="CREATE TRIGGER [vw_ins_TMPCADXVIEW] INSTEAD OF INSERT ON [TMPCADXVIEW] BEGIN INSERT OR REPLACE INTO [TMPCADX] ([Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[EntityType],NEW.[Handle],NEW.[FileName],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_TMPCADX="CREATE TRIGGER [vw_upd_TMPCADXVIEW] INSTEAD OF UPDATE OF [Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [TMPCADXVIEW] BEGIN UPDATE [TMPCADX] SET [Id]=NEW.[Id],[EntityType]=NEW.[EntityType],[Handle]=NEW.[Handle],[FileName]=NEW.[FileName],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_TMPCADX="CREATE TRIGGER [vw_del_TMPCADXVIEW] INSTEAD OF DELETE ON [TMPCADXVIEW] BEGIN DELETE FROM [TmpCadx] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_TMPCADX="SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadx WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_TMPCADXVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadxview','geometry','rowid','tmpcadx','geometry',0)";
        #endregion        
        
        
        #region TMPCADXDATA SQL语句
        private string CREATE_VIEW_TMPCADXDATA="CREATE VIEW TMPCADXDATAVIEW AS SELECT  Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName,DatabaseId,FLAGS,XGR,XGSJ FROM TmpCadxdata WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_TMPCADXDATA="CREATE TRIGGER [vw_ins_TMPCADXDATAVIEW] INSTEAD OF INSERT ON [TMPCADXDATAVIEW] BEGIN INSERT OR REPLACE INTO [TMPCADXDATA] ([Id],[Handle],[Tc],[Wbnr],[Cassdm],[Fsxx1],[Fsxx2],[Xzjd],[Fh],[Fhdx],[Ysdm],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ])  VALUES (NEW.[Id],NEW.[Handle],NEW.[Tc],NEW.[Wbnr],NEW.[Cassdm],NEW.[Fsxx1],NEW.[Fsxx2],NEW.[Xzjd],NEW.[Fh],NEW.[Fhdx],NEW.[Ysdm],NEW.[FileName],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ]);END";
        private string UPDATE_TRIGGER_TMPCADXDATA="CREATE TRIGGER [vw_upd_TMPCADXDATAVIEW] INSTEAD OF UPDATE OF [Id],[Handle],[Tc],[Wbnr],[Cassdm],[Fsxx1],[Fsxx2],[Xzjd],[Fh],[Fhdx],[Ysdm],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ] ON [TMPCADXDATAVIEW] BEGIN UPDATE [TMPCADXDATA] SET [Id]=NEW.[Id],[Handle]=NEW.[Handle],[Tc]=NEW.[Tc],[Wbnr]=NEW.[Wbnr],[Cassdm]=NEW.[Cassdm],[Fsxx1]=NEW.[Fsxx1],[Fsxx2]=NEW.[Fsxx2],[Xzjd]=NEW.[Xzjd],[Fh]=NEW.[Fh],[Fhdx]=NEW.[Fhdx],[Ysdm]=NEW.[Ysdm],[FileName]=NEW.[FileName],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_TMPCADXDATA="CREATE TRIGGER [vw_del_TMPCADXDATAVIEW] INSTEAD OF DELETE ON [TMPCADXDATAVIEW] BEGIN DELETE FROM [TmpCadxdata] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_TMPCADXDATA="SELECT  Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName,DatabaseId,FLAGS,XGR,XGSJ FROM TmpCadxdata WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_TMPCADXDATAVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadxdataview','geometry','rowid','tmpcadxdata','geometry',0)";
        #endregion        
        
        
        #region TMPCADZJ SQL语句
        private string CREATE_VIEW_TMPCADZJ="CREATE VIEW TMPCADZJVIEW AS SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadzj WHERE [FLAGS] < 3;";
        private string INSERT_TRIGGER_TMPCADZJ="CREATE TRIGGER [vw_ins_TMPCADZJVIEW] INSTEAD OF INSERT ON [TMPCADZJVIEW] BEGIN INSERT OR REPLACE INTO [TMPCADZJ] ([Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry])  VALUES (NEW.[Id],NEW.[EntityType],NEW.[Handle],NEW.[FileName],NEW.[DatabaseId],NEW.[FLAGS],NEW.[XGR],NEW.[XGSJ],NEW.[geometry]);END";
        private string UPDATE_TRIGGER_TMPCADZJ="CREATE TRIGGER [vw_upd_TMPCADZJVIEW] INSTEAD OF UPDATE OF [Id],[EntityType],[Handle],[FileName],[DatabaseId],[FLAGS],[XGR],[XGSJ],[geometry] ON [TMPCADZJVIEW] BEGIN UPDATE [TMPCADZJ] SET [Id]=NEW.[Id],[EntityType]=NEW.[EntityType],[Handle]=NEW.[Handle],[FileName]=NEW.[FileName],[DatabaseId]=NEW.[DatabaseId],[FLAGS]=NEW.[FLAGS],[XGR]=NEW.[XGR],[XGSJ]=NEW.[XGSJ],[geometry]=NEW.[geometry] WHERE ROWID=OLD.ROWID; END";
        private string DELETE_TRIGGER_TMPCADZJ="CREATE TRIGGER [vw_del_TMPCADZJVIEW] INSTEAD OF DELETE ON [TMPCADZJVIEW] BEGIN DELETE FROM [TmpCadzj] WHERE ROWID=OLD.ROWID;END";
        private string SELECT_TMPCADZJ="SELECT  Id,EntityType,Handle,FileName,DatabaseId,FLAGS,XGR,XGSJ,geometry FROM TmpCadzj WHERE [FLAGS] < 3;";  
        private string REGISTER_GEOMETRY_TMPCADZJVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadzjview','geometry','rowid','tmpcadzj','geometry',0)";
        #endregion        
        
        
        #region 初始化
        public CadDaoImpl():base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("TmpCadd","");
            _entityNames.Add("TmpCadm","");
            _entityNames.Add("TmpCadx","");
            _entityNames.Add("TmpCadxdata","临时交换数据附加属性");
            _entityNames.Add("TmpCadzj","");
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
        
       
        
        #region TmpCadd方法
        public TmpCadd GetTmpCadd(long id)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadd " + " where id="+id.ToString();
            IEnumerable<TmpCadd> records=connection.Query<TmpCadd>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadd> GetTmpCadds(string filter)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadd " + " where "+filter;
            var records=connection.Query<TmpCadd>(sql);            
            return records;
        }
        public bool SaveTmpCadd(TmpCadd record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveTmpCadds(List<TmpCadd> records)
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
        public void DeleteTmpCadd(TmpCadd record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteTmpCadd(long id)
        {
           TmpCadd record=GetTmpCadd(id);
           if(record !=null)
           DeleteTmpCadd(record);        
        }
        public void DeleteTmpCadd(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<TmpCadd> records=GetTmpCadds(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(TmpCadd record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region TmpCadm方法
        public TmpCadm GetTmpCadm(long id)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadm " + " where id="+id.ToString();
            IEnumerable<TmpCadm> records=connection.Query<TmpCadm>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadm> GetTmpCadms(string filter)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadm " + " where "+filter;
            var records=connection.Query<TmpCadm>(sql);            
            return records;
        }
        public bool SaveTmpCadm(TmpCadm record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveTmpCadms(List<TmpCadm> records)
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
        public void DeleteTmpCadm(TmpCadm record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteTmpCadm(long id)
        {
           TmpCadm record=GetTmpCadm(id);
           if(record !=null)
           DeleteTmpCadm(record);        
        }
        public void DeleteTmpCadm(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<TmpCadm> records=GetTmpCadms(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(TmpCadm record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region TmpCadx方法
        public TmpCadx GetTmpCadx(long id)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadx " + " where id="+id.ToString();
            IEnumerable<TmpCadx> records=connection.Query<TmpCadx>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadx> GetTmpCadxes(string filter)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadx " + " where "+filter;
            var records=connection.Query<TmpCadx>(sql);            
            return records;
        }
        public bool SaveTmpCadx(TmpCadx record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveTmpCadxes(List<TmpCadx> records)
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
        public void DeleteTmpCadx(TmpCadx record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteTmpCadx(long id)
        {
           TmpCadx record=GetTmpCadx(id);
           if(record !=null)
           DeleteTmpCadx(record);        
        }
        public void DeleteTmpCadx(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<TmpCadx> records=GetTmpCadxes(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(TmpCadx record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region TmpCadxdata方法
        public TmpCadxdata GetTmpCadxdata(long id)
        {
            string sql="SELECT  Id As ID,Handle As Handle,Tc As Tc,Wbnr As Wbnr,Cassdm As Cassdm,Fsxx1 As Fsxx1,Fsxx2 As Fsxx2,Xzjd As Xzjd,Fh As Fh,Fhdx As Fhdx,Ysdm As Ysdm,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM TmpCadxdata " + " where id="+id.ToString();
            IEnumerable<TmpCadxdata> records=connection.Query<TmpCadxdata>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadxdata> GetTmpCadxdatas(string filter)
        {
            string sql="SELECT  Id As ID,Handle As Handle,Tc As Tc,Wbnr As Wbnr,Cassdm As Cassdm,Fsxx1 As Fsxx1,Fsxx2 As Fsxx2,Xzjd As Xzjd,Fh As Fh,Fhdx As Fhdx,Ysdm As Ysdm,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj FROM TmpCadxdata " + " where "+filter;
            var records=connection.Query<TmpCadxdata>(sql);            
            return records;
        }
        public bool SaveTmpCadxdata(TmpCadxdata record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveTmpCadxdatas(List<TmpCadxdata> records)
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
        public void DeleteTmpCadxdata(TmpCadxdata record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteTmpCadxdata(long id)
        {
           TmpCadxdata record=GetTmpCadxdata(id);
           if(record !=null)
           DeleteTmpCadxdata(record);        
        }
        public void DeleteTmpCadxdata(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<TmpCadxdata> records=GetTmpCadxdatas(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(TmpCadxdata record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region TmpCadzj方法
        public TmpCadzj GetTmpCadzj(long id)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadzj " + " where id="+id.ToString();
            IEnumerable<TmpCadzj> records=connection.Query<TmpCadzj>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadzj> GetTmpCadzjs(string filter)
        {
            string sql="SELECT  Id As ID,EntityType As EntityType,Handle As Handle,FileName As FileName,DatabaseId As DatabaseID,FLAGS As Flags,XGR As Xgr,XGSJ As Xgsj,AsText(geometry) as Wkt  FROM TmpCadzj " + " where "+filter;
            var records=connection.Query<TmpCadzj>(sql);            
            return records;
        }
        public bool SaveTmpCadzj(TmpCadzj record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveTmpCadzjs(List<TmpCadzj> records)
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
        public void DeleteTmpCadzj(TmpCadzj record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteTmpCadzj(long id)
        {
           TmpCadzj record=GetTmpCadzj(id);
           if(record !=null)
           DeleteTmpCadzj(record);        
        }
        public void DeleteTmpCadzj(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<TmpCadzj> records=GetTmpCadzjs(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(TmpCadzj record in records)
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