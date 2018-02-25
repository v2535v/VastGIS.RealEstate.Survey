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

    public partial class CadDaoImpl:SQLiteDao,CadDao
    {
        public Dictionary<string, string> _entityNames;
        //private CadDao _cadDao;
         
        private string GEOMETRY_REGISTER_TmpCaddVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcaddview','geometry','rowid','tmpcadd','geometry',0)";
        private string SELECT_TMPCADD = "select Id,EntityType,Handle,FileName,geometry from TmpCadd";
        
         
        private string GEOMETRY_REGISTER_TmpCadmVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadmview','geometry','rowid','tmpcadm','geometry',0)";
        private string SELECT_TMPCADM = "select Id,EntityType,Handle,FileName,geometry from TmpCadm";
        
         
        private string GEOMETRY_REGISTER_TmpCadxVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadxview','geometry','rowid','tmpcadx','geometry',0)";
        private string SELECT_TMPCADX = "select Id,EntityType,Handle,FileName,geometry from TmpCadx";
        
         
        private string GEOMETRY_REGISTER_TmpCadzjVIEW="insert into views_geometry_columns([view_name],[view_geometry],[view_rowid],[f_table_name], [f_geometry_column], [read_only]) values('tmpcadzjview','geometry','rowid','tmpcadzj','geometry',0)";
        private string SELECT_TMPCADZJ = "select Id,EntityType,Handle,FileName,geometry from TmpCadzj";
        
        private string SELECT_TMPCADXDATA = "select Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName from TmpCadxdata";
        
        
        public CadDaoImpl(): base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("TMPCADD","");
            _entityNames.Add("TMPCADM","");
            _entityNames.Add("TMPCADX","");
            _entityNames.Add("TMPCADZJ","");
            _entityNames.Add("TMPCADXDATA","");
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
        
        ///TmpCadd函数
        public TmpCadd GetTmpCadd(long id)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadd" + " where id="+id.ToString();
            IEnumerable<TmpCadd> tmpcadds=connection.Query<TmpCadd>(sql);
            if(tmpcadds != null && tmpcadds.Count()>0)
            {
                return tmpcadds.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadd> GetTmpCadds(string filter)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadd" + " where "+filter;
            var tmpcadds=connection.Query<TmpCadd>(sql);
            
            return tmpcadds;
        }
        
        public bool SaveTmpCadd(TmpCadd tmpcadd)
        {
            bool retVal= tmpcadd.Save(this);
            if(retVal)
            {
                OnEntityChanged("tmpcadd",GetLayerName("TmpCadd"),EntityOperationType.Save,new List<long>{tmpcadd.ID});
            }
            return retVal;
        }
        
        public void SaveTmpCadds(List<TmpCadd> tmpCadds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpCadds)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=tmpCadds.Select(a => a.ID).ToList(); 
            OnEntityChanged("tmpcadd",GetLayerName("TmpCadd"),EntityOperationType.Save,ids);
        }
        
        public void DeleteTmpCadd(TmpCadd record)
        {
            record.Delete(this);
            OnEntityChanged("tmpcadd",GetLayerName("TmpCadd"),EntityOperationType.Delete,new List<long>{record.ID});
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
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from TmpCadd";
                else
                    command.CommandText="delete from TmpCadd where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("tmpcadd",GetLayerName("TmpCadd"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///TmpCadm函数
        public TmpCadm GetTmpCadm(long id)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadm" + " where id="+id.ToString();
            IEnumerable<TmpCadm> tmpcadms=connection.Query<TmpCadm>(sql);
            if(tmpcadms != null && tmpcadms.Count()>0)
            {
                return tmpcadms.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadm> GetTmpCadms(string filter)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadm" + " where "+filter;
            var tmpcadms=connection.Query<TmpCadm>(sql);
            
            return tmpcadms;
        }
        
        public bool SaveTmpCadm(TmpCadm tmpcadm)
        {
            bool retVal= tmpcadm.Save(this);
            if(retVal)
            {
                OnEntityChanged("tmpcadm",GetLayerName("TmpCadm"),EntityOperationType.Save,new List<long>{tmpcadm.ID});
            }
            return retVal;
        }
        
        public void SaveTmpCadms(List<TmpCadm> tmpCadms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpCadms)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=tmpCadms.Select(a => a.ID).ToList(); 
            OnEntityChanged("tmpcadm",GetLayerName("TmpCadm"),EntityOperationType.Save,ids);
        }
        
        public void DeleteTmpCadm(TmpCadm record)
        {
            record.Delete(this);
            OnEntityChanged("tmpcadm",GetLayerName("TmpCadm"),EntityOperationType.Delete,new List<long>{record.ID});
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
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from TmpCadm";
                else
                    command.CommandText="delete from TmpCadm where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("tmpcadm",GetLayerName("TmpCadm"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///TmpCadx函数
        public TmpCadx GetTmpCadx(long id)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadx" + " where id="+id.ToString();
            IEnumerable<TmpCadx> tmpcadxs=connection.Query<TmpCadx>(sql);
            if(tmpcadxs != null && tmpcadxs.Count()>0)
            {
                return tmpcadxs.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadx> GetTmpCadxes(string filter)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadx" + " where "+filter;
            var tmpcadxs=connection.Query<TmpCadx>(sql);
            
            return tmpcadxs;
        }
        
        public bool SaveTmpCadx(TmpCadx tmpcadx)
        {
            bool retVal= tmpcadx.Save(this);
            if(retVal)
            {
                OnEntityChanged("tmpcadx",GetLayerName("TmpCadx"),EntityOperationType.Save,new List<long>{tmpcadx.ID});
            }
            return retVal;
        }
        
        public void SaveTmpCadxes(List<TmpCadx> tmpCadxes)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpCadxes)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=tmpCadxes.Select(a => a.ID).ToList(); 
            OnEntityChanged("tmpcadx",GetLayerName("TmpCadx"),EntityOperationType.Save,ids);
        }
        
        public void DeleteTmpCadx(TmpCadx record)
        {
            record.Delete(this);
            OnEntityChanged("tmpcadx",GetLayerName("TmpCadx"),EntityOperationType.Delete,new List<long>{record.ID});
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
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from TmpCadx";
                else
                    command.CommandText="delete from TmpCadx where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("tmpcadx",GetLayerName("TmpCadx"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///TmpCadzj函数
        public TmpCadzj GetTmpCadzj(long id)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadzj" + " where id="+id.ToString();
            IEnumerable<TmpCadzj> tmpcadzjs=connection.Query<TmpCadzj>(sql);
            if(tmpcadzjs != null && tmpcadzjs.Count()>0)
            {
                return tmpcadzjs.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadzj> GetTmpCadzjs(string filter)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadzj" + " where "+filter;
            var tmpcadzjs=connection.Query<TmpCadzj>(sql);
            
            return tmpcadzjs;
        }
        
        public bool SaveTmpCadzj(TmpCadzj tmpcadzj)
        {
            bool retVal= tmpcadzj.Save(this);
            if(retVal)
            {
                OnEntityChanged("tmpcadzj",GetLayerName("TmpCadzj"),EntityOperationType.Save,new List<long>{tmpcadzj.ID});
            }
            return retVal;
        }
        
        public void SaveTmpCadzjs(List<TmpCadzj> tmpCadzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpCadzjs)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=tmpCadzjs.Select(a => a.ID).ToList(); 
            OnEntityChanged("tmpcadzj",GetLayerName("TmpCadzj"),EntityOperationType.Save,ids);
        }
        
        public void DeleteTmpCadzj(TmpCadzj record)
        {
            record.Delete(this);
            OnEntityChanged("tmpcadzj",GetLayerName("TmpCadzj"),EntityOperationType.Delete,new List<long>{record.ID});
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
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from TmpCadzj";
                else
                    command.CommandText="delete from TmpCadzj where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("tmpcadzj",GetLayerName("TmpCadzj"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///TmpCadxdata函数
        public TmpCadxdata GetTmpCadxdata(long id)
        {
            string sql="select Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName from TmpCadxdata" + " where id="+id.ToString();
            IEnumerable<TmpCadxdata> tmpcadxdatums=connection.Query<TmpCadxdata>(sql);
            if(tmpcadxdatums != null && tmpcadxdatums.Count()>0)
            {
                return tmpcadxdatums.First();
            }
            return null;
        }
        
        public IEnumerable<TmpCadxdata> GetTmpCadxdatas(string filter)
        {
            string sql="select Id,Handle,Tc,Wbnr,Cassdm,Fsxx1,Fsxx2,Xzjd,Fh,Fhdx,Ysdm,FileName from TmpCadxdata" + " where "+filter;
            var tmpcadxdatums=connection.Query<TmpCadxdata>(sql);
            
            return tmpcadxdatums;
        }
        
        public bool SaveTmpCadxdata(TmpCadxdata tmpcadxdatum)
        {
            bool retVal= tmpcadxdatum.Save(this);
            if(retVal)
            {
                OnEntityChanged("tmpcadxdata",GetLayerName("TmpCadxdata"),EntityOperationType.Save,new List<long>{tmpcadxdatum.ID});
            }
            return retVal;
        }
        
        public void SaveTmpCadxdatas(List<TmpCadxdata> tmpCadxdatas)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpCadxdatas)
            {
                rec.Save(this);
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=tmpCadxdatas.Select(a => a.ID).ToList(); 
            OnEntityChanged("tmpcadxdata",GetLayerName("TmpCadxdata"),EntityOperationType.Save,ids);
        }
        
        public void DeleteTmpCadxdata(TmpCadxdata record)
        {
            record.Delete(this);
            OnEntityChanged("tmpcadxdata",GetLayerName("TmpCadxdata"),EntityOperationType.Delete,new List<long>{record.ID});
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
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from TmpCadxdata";
                else
                    command.CommandText="delete from TmpCadxdata where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("tmpcadxdata",GetLayerName("TmpCadxdata"),EntityOperationType.Delete,null);
            }
        }
        
        
        
        
    }
}



