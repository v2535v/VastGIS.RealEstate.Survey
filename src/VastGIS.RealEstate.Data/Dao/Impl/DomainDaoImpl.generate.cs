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

    public partial class DomainDaoImpl:SQLiteDao,DomainDao
    {
        public Dictionary<string, string> _entityNames;
        //private DomainDao _domainDao;
        private string SELECT_VG_DICTIONARY = "select Id,ZDZ,ZDSM,SFQS,PX from vg_dictionary";
        
        private string SELECT_VG_DICTORYNAME = "select Id,ZDMC,ZDSM from vg_dictoryname";
        
        
        public DomainDaoImpl(): base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("VG_DICTIONARY","");
            _entityNames.Add("VG_DICTORYNAME","");
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
        
        ///VgDictionary函数
        public VgDictionary GetVgDictionary(long id)
        {
            string sql="select Id,ZDZ,ZDSM,SFQS,PX from vg_dictionary" + " where id="+id.ToString();
            IEnumerable<VgDictionary> vgDictionarys=connection.Query<VgDictionary>(sql);
            if(vgDictionarys != null && vgDictionarys.Count()>0)
            {
                return vgDictionarys.First();
            }
            return null;
        }
        
        public IEnumerable<VgDictionary> GetVgDictionarys(string filter)
        {
            string sql="select Id,ZDZ,ZDSM,SFQS,PX from vg_dictionary" + " where "+filter;
            var vgDictionarys=connection.Query<VgDictionary>(sql);
            
            return vgDictionarys;
        }
        
        public bool SaveVgDictionary(VgDictionary vgDictionary)
        {
            bool retVal= vgDictionary.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_dictionary",GetLayerName("vg_dictionary"),EntityOperationType.Save,new List<long>{vgDictionary.ID});
            }
            return retVal;
        }
        
        public void SaveVgDictionarys(List<VgDictionary> vgDictionarys)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgDictionarys)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgDictionarys.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_dictionary",GetLayerName("vg_dictionary"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgDictionary(VgDictionary record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_dictionary",GetLayerName("vg_dictionary"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgDictionary(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_dictionary where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_dictionary",GetLayerName("vg_dictionary"),EntityOperationType.Delete,new List<long>{id});
            }
        }
        
        public void DeleteVgDictionary(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_dictionary";
                else
                    command.CommandText="delete from vg_dictionary where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_dictionary",GetLayerName("vg_dictionary"),EntityOperationType.Delete,null);
            }
        }
        
        
        ///VgDictoryname函数
        public VgDictoryname GetVgDictoryname(long id)
        {
            string sql="select Id,ZDMC,ZDSM from vg_dictoryname" + " where id="+id.ToString();
            IEnumerable<VgDictoryname> vgDictorynames=connection.Query<VgDictoryname>(sql);
            if(vgDictorynames != null && vgDictorynames.Count()>0)
            {
                return vgDictorynames.First();
            }
            return null;
        }
        
        public IEnumerable<VgDictoryname> GetVgDictorynames(string filter)
        {
            string sql="select Id,ZDMC,ZDSM from vg_dictoryname" + " where "+filter;
            var vgDictorynames=connection.Query<VgDictoryname>(sql);
            
            return vgDictorynames;
        }
        
        public bool SaveVgDictoryname(VgDictoryname vgDictoryname)
        {
            bool retVal= vgDictoryname.Save(connection,GetSRID());
            if(retVal)
            {
                OnEntityChanged("vg_dictoryname",GetLayerName("vg_dictoryname"),EntityOperationType.Save,new List<long>{vgDictoryname.ID});
            }
            return retVal;
        }
        
        public void SaveVgDictorynames(List<VgDictoryname> vgDictorynames)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in vgDictorynames)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
            List<long> ids=vgDictorynames.Select(a => a.ID).ToList(); 
            OnEntityChanged("vg_dictoryname",GetLayerName("vg_dictoryname"),EntityOperationType.Save,ids);
        }
        
        public void DeleteVgDictoryname(VgDictoryname record)
        {
            record.Delete(connection);
            OnEntityChanged("vg_dictoryname",GetLayerName("vg_dictoryname"),EntityOperationType.Delete,new List<long>{record.ID});
        }
        
        public void DeleteVgDictoryname(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_dictoryname where Id=" + id.ToString();
                command.ExecuteNonQuery();
                OnEntityChanged("vg_dictoryname",GetLayerName("vg_dictoryname"),EntityOperationType.Delete,new List<long>{id});
            }
        }
        
        public void DeleteVgDictoryname(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                if(string.IsNullOrEmpty(filter))
                    command.CommandText="delete from vg_dictoryname";
                else
                    command.CommandText="delete from vg_dictoryname where " + filter;
                command.ExecuteNonQuery();
                OnEntityChanged("vg_dictoryname",GetLayerName("vg_dictoryname"),EntityOperationType.Delete,null);
            }
        }
        
        
        
        
    }
}



