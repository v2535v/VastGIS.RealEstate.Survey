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

    public partial class CadDaoImpl:SQLiteDao,CadDao
    {
        //private CadDao _cadDao;
        
        
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
            return tmpcadd.Save(connection,GetSRID());
        }
        
        public void SaveTmpCadds(List<TmpCadd> tmpcadds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpcadds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        
        public void DeleteTmpCadd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from TmpCadd where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
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
            return tmpcadm.Save(connection,GetSRID());
        }
        
        public void SaveTmpCadms(List<TmpCadm> tmpcadms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpcadms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        
        public void DeleteTmpCadm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from TmpCadm where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
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
        
        public IEnumerable<TmpCadx> GetTmpCadxs(string filter)
        {
            string sql="select Id,EntityType,Handle,FileName,AsText(geometry) as Wkt from TmpCadx" + " where "+filter;
            var tmpcadxs=connection.Query<TmpCadx>(sql);
            
            return tmpcadxs;
        }
        
        public bool SaveTmpCadx(TmpCadx tmpcadx)
        {
            return tmpcadx.Save(connection,GetSRID());
        }
        
        public void SaveTmpCadxs(List<TmpCadx> tmpcadxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpcadxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        
        public void DeleteTmpCadx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from TmpCadx where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
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
            return tmpcadxdatum.Save(connection,GetSRID());
        }
        
        public void SaveTmpCadxdatas(List<TmpCadxdata> tmpcadxdatums)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpcadxdatums)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        
        public void DeleteTmpCadxdata(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from TmpCadxdata where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
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
            return tmpcadzj.Save(connection,GetSRID());
        }
        
        public void SaveTmpCadzjs(List<TmpCadzj> tmpcadzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in tmpcadzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        
        public void DeleteTmpCadzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                command.CommandText="delete from TmpCadzj where Id=" + id.ToString();
                command.ExecuteNonQuery();
            }
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
            }
        }
        
        
        
        
    }
}



