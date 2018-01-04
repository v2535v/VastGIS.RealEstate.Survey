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

    public partial class DomainDaoImpl:SQLiteDao,DomainDao
    {
        //private DomainDao _domainDao;
        
        
        ///VgDictionary函数
        public VgDictionary GetVgDictionary(long id)
        {
            string sql="select Id,ZDMC,ZDZ,ZDSM,SFQS,PX from vg_dictionary" + " where id="+id.ToString();
            IEnumerable<VgDictionary> vgDictionarys=connection.Query<VgDictionary>(sql);
            if(vgDictionarys != null && vgDictionarys.Count()>0)
            {
                return vgDictionarys.First();
            }
            return null;
        }
        
        public IEnumerable<VgDictionary> GetVgDictionarys(string filter)
        {
            string sql="select Id,ZDMC,ZDZ,ZDSM,SFQS,PX from vg_dictionary" + " where "+filter;
            var vgDictionarys=connection.Query<VgDictionary>(sql);
            
            return vgDictionarys;
        }
        
        public bool SaveVgDictionary(VgDictionary vgDictionary)
        {
            return vgDictionary.Save(connection,GetSRID());
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
        }
        
        
        public void DeleteVgDictionary(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_dictionary where Id=" + id.ToString();
                command.ExecuteNonQuery();
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
            return vgDictoryname.Save(connection,GetSRID());
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
        }
        
        
        public void DeleteVgDictoryname(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from vg_dictoryname where Id=" + id.ToString();
                command.ExecuteNonQuery();
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
            }
        }
        
        
        
        
    }
}



