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
    public partial class DomainDaoImpl : SQLiteDao,DomainDao
    {	
        public Dictionary<string,string> _entityNames;        
        
        
        #region 初始化
        public DomainDaoImpl():base()
        {
            _entityNames=new Dictionary<string, string>();
            _entityNames.Add("vg_dictionary","字典内容");
            _entityNames.Add("vg_dictoryname","字典");
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
        
       
        
        #region VgDictionary方法
        public VgDictionary GetVgDictionary(long id)
        {
            string sql="SELECT  Id As ID,ZDMC As Zdmc,ZDZ As Zdz,ZDSM As Zdsm,SFQS As Sfqs,PX As Px FROM vg_dictionary " + " where id="+id.ToString();
            IEnumerable<VgDictionary> records=connection.Query<VgDictionary>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgDictionary> GetVgDictionaries(string filter)
        {
            string sql="SELECT  Id As ID,ZDMC As Zdmc,ZDZ As Zdz,ZDSM As Zdsm,SFQS As Sfqs,PX As Px FROM vg_dictionary " + " where "+filter;
            var records=connection.Query<VgDictionary>(sql);            
            return records;
        }
        public bool SaveVgDictionary(VgDictionary record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgDictionaries(List<VgDictionary> records)
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
        public void DeleteVgDictionary(VgDictionary record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteVgDictionary(long id)
        {
           VgDictionary record=GetVgDictionary(id);
           if(record !=null)
           DeleteVgDictionary(record);        
        }
        public void DeleteVgDictionary(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgDictionary> records=GetVgDictionaries(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgDictionary record in records)
                    {
                        record.Delete(this);
                        backList.Add(record as IEntity);
                    }
                    OnEntityChanged(EntityOperationType.Delete, backList); 
                }
            } 
        }
        #endregion
        
        #region VgDictoryname方法
        public VgDictoryname GetVgDictoryname(long id)
        {
            string sql="SELECT  Id As ID,ZDMC As Zdmc,ZDSM As Zdsm FROM vg_dictoryname " + " where id="+id.ToString();
            IEnumerable<VgDictoryname> records=connection.Query<VgDictoryname>(sql);
            if(records != null && records.Count()>0)
            {
                return records.First();
            }
            return null;
        }
        
        public IEnumerable<VgDictoryname> GetVgDictorynames(string filter)
        {
            string sql="SELECT  Id As ID,ZDMC As Zdmc,ZDSM As Zdsm FROM vg_dictoryname " + " where "+filter;
            var records=connection.Query<VgDictoryname>(sql);            
            return records;
        }
        public bool SaveVgDictoryname(VgDictoryname record)
        {
            bool retVal= record.Save(this);
            if(retVal)
            {
                OnEntityChanged(EntityOperationType.Save, record as IEntity);
                
            }
            return retVal;
        }
        public void SaveVgDictorynames(List<VgDictoryname> records)
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
        public void DeleteVgDictoryname(VgDictoryname record)
        {
            record.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, record as IEntity); 
        }
        public void DeleteVgDictoryname(long id)
        {
           VgDictoryname record=GetVgDictoryname(id);
           if(record !=null)
           DeleteVgDictoryname(record);        
        }
        public void DeleteVgDictoryname(string filter)
        {
           using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                List<IEntity> backList=new List<IEntity>();
                IEnumerable<VgDictoryname> records=GetVgDictorynames(filter);
                if(records!=null && records.Count()>0)
                {
                    foreach(VgDictoryname record in records)
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