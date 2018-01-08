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

    public partial class BasemapDaoImpl:SQLiteDao,BasemapDao
    {
        //private BasemapDao _basemapDao;
        string SELECT_DXTDLDWD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLDWD Where [FLAGS] < 3";
        
        string SELECT_DXTDLDWM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLDWM Where [FLAGS] < 3";
        
        string SELECT_DXTDLDWX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLDWX Where [FLAGS] < 3";
        
        string SELECT_DXTDLDWZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTDLDWZJ Where [FLAGS] < 3";
        
        string SELECT_DXTDLSSD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLSSD Where [FLAGS] < 3";
        
        string SELECT_DXTDLSSM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLSSM Where [FLAGS] < 3";
        
        string SELECT_DXTDLSSX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDLSSX Where [FLAGS] < 3";
        
        string SELECT_DXTDLSSZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTDLSSZJ Where [FLAGS] < 3";
        
        string SELECT_DXTDMTZD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDMTZD Where [FLAGS] < 3";
        
        string SELECT_DXTDMTZM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDMTZM Where [FLAGS] < 3";
        
        string SELECT_DXTDMTZX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTDMTZX Where [FLAGS] < 3";
        
        string SELECT_DXTDMTZZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTDMTZZJ Where [FLAGS] < 3";
        
        string SELECT_DXTJMDD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTJMDD Where [FLAGS] < 3";
        
        string SELECT_DXTJMDM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTJMDM Where [FLAGS] < 3";
        
        string SELECT_DXTJMDX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTJMDX Where [FLAGS] < 3";
        
        string SELECT_DXTJMDZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTJMDZJ Where [FLAGS] < 3";
        
        string SELECT_DXTKZDD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTKZDD Where [FLAGS] < 3";
        
        string SELECT_DXTKZDM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTKZDM Where [FLAGS] < 3";
        
        string SELECT_DXTKZDX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTKZDX Where [FLAGS] < 3";
        
        string SELECT_DXTKZDZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTKZDZJ Where [FLAGS] < 3";
        
        string SELECT_DXTQTD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTQTD Where [FLAGS] < 3";
        
        string SELECT_DXTQTM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTQTM Where [FLAGS] < 3";
        
        string SELECT_DXTQTX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTQTX Where [FLAGS] < 3";
        
        string SELECT_DXTQTZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTQTZJ Where [FLAGS] < 3";
        
        string SELECT_DXTSXSSD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTSXSSD Where [FLAGS] < 3";
        
        string SELECT_DXTSXSSM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTSXSSM Where [FLAGS] < 3";
        
        string SELECT_DXTSXSSX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTSXSSX Where [FLAGS] < 3";
        
        string SELECT_DXTSXSSZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTSXSSZJ Where [FLAGS] < 3";
        
        string SELECT_DXTZJD = "select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTZJD Where [FLAGS] < 3";
        
        string SELECT_DXTZJM = "select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTZJM Where [FLAGS] < 3";
        
        string SELECT_DXTZJX = "select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,geometry from DXTZJX Where [FLAGS] < 3";
        
        string SELECT_DXTZJZJ = "select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,geometry from DXTZJZJ Where [FLAGS] < 3";
        
        
        ///Dxtdldwd函数
        public Dxtdldwd GetDxtdldwd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWD" + " where id="+id.ToString();
            IEnumerable<Dxtdldwd> dxtdldwds=connection.Query<Dxtdldwd>(sql);
            if(dxtdldwds != null && dxtdldwds.Count()>0)
            {
                return dxtdldwds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwd> GetDxtdldwds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWD" + " where "+filter;
            var dxtdldwds=connection.Query<Dxtdldwd>(sql);
            
            return dxtdldwds;
        }
        
        public bool SaveDxtdldwd(Dxtdldwd dxtdldwd)
        {
            return dxtdldwd.Save(connection,GetSRID());
        }
        
        public void SaveDxtdldwds(List<Dxtdldwd> dxtdldwds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdldwd(Dxtdldwd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdldwd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdldwd row=this.GetDxtdldwd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLDWD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLDWD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdldwd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdldwd> rows=GetDxtdldwds(filter);
                foreach(Dxtdldwd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdldwm函数
        public Dxtdldwm GetDxtdldwm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWM" + " where id="+id.ToString();
            IEnumerable<Dxtdldwm> dxtdldwms=connection.Query<Dxtdldwm>(sql);
            if(dxtdldwms != null && dxtdldwms.Count()>0)
            {
                return dxtdldwms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwm> GetDxtdldwms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWM" + " where "+filter;
            var dxtdldwms=connection.Query<Dxtdldwm>(sql);
            
            return dxtdldwms;
        }
        
        public bool SaveDxtdldwm(Dxtdldwm dxtdldwm)
        {
            return dxtdldwm.Save(connection,GetSRID());
        }
        
        public void SaveDxtdldwms(List<Dxtdldwm> dxtdldwms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdldwm(Dxtdldwm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdldwm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdldwm row=this.GetDxtdldwm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLDWM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLDWM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdldwm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdldwm> rows=GetDxtdldwms(filter);
                foreach(Dxtdldwm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdldwx函数
        public Dxtdldwx GetDxtdldwx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWX" + " where id="+id.ToString();
            IEnumerable<Dxtdldwx> dxtdldwxs=connection.Query<Dxtdldwx>(sql);
            if(dxtdldwxs != null && dxtdldwxs.Count()>0)
            {
                return dxtdldwxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwx> GetDxtdldwxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWX" + " where "+filter;
            var dxtdldwxs=connection.Query<Dxtdldwx>(sql);
            
            return dxtdldwxs;
        }
        
        public bool SaveDxtdldwx(Dxtdldwx dxtdldwx)
        {
            return dxtdldwx.Save(connection,GetSRID());
        }
        
        public void SaveDxtdldwxs(List<Dxtdldwx> dxtdldwxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdldwx(Dxtdldwx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdldwx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdldwx row=this.GetDxtdldwx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLDWX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLDWX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdldwx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdldwx> rows=GetDxtdldwxs(filter);
                foreach(Dxtdldwx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdldwzj函数
        public Dxtdldwzj GetDxtdldwzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdldwzj> dxtdldwzjs=connection.Query<Dxtdldwzj>(sql);
            if(dxtdldwzjs != null && dxtdldwzjs.Count()>0)
            {
                return dxtdldwzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdldwzj> GetDxtdldwzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLDWZJ" + " where "+filter;
            var dxtdldwzjs=connection.Query<Dxtdldwzj>(sql);
            
            return dxtdldwzjs;
        }
        
        public bool SaveDxtdldwzj(Dxtdldwzj dxtdldwzj)
        {
            return dxtdldwzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtdldwzjs(List<Dxtdldwzj> dxtdldwzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdldwzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdldwzj(Dxtdldwzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdldwzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdldwzj row=this.GetDxtdldwzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLDWZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLDWZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdldwzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdldwzj> rows=GetDxtdldwzjs(filter);
                foreach(Dxtdldwzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdlssd函数
        public Dxtdlssd GetDxtdlssd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSD" + " where id="+id.ToString();
            IEnumerable<Dxtdlssd> dxtdlssds=connection.Query<Dxtdlssd>(sql);
            if(dxtdlssds != null && dxtdlssds.Count()>0)
            {
                return dxtdlssds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssd> GetDxtdlssds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSD" + " where "+filter;
            var dxtdlssds=connection.Query<Dxtdlssd>(sql);
            
            return dxtdlssds;
        }
        
        public bool SaveDxtdlssd(Dxtdlssd dxtdlssd)
        {
            return dxtdlssd.Save(connection,GetSRID());
        }
        
        public void SaveDxtdlssds(List<Dxtdlssd> dxtdlssds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdlssd(Dxtdlssd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdlssd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdlssd row=this.GetDxtdlssd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLSSD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLSSD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdlssd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdlssd> rows=GetDxtdlssds(filter);
                foreach(Dxtdlssd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdlssm函数
        public Dxtdlssm GetDxtdlssm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSM" + " where id="+id.ToString();
            IEnumerable<Dxtdlssm> dxtdlssms=connection.Query<Dxtdlssm>(sql);
            if(dxtdlssms != null && dxtdlssms.Count()>0)
            {
                return dxtdlssms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssm> GetDxtdlssms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSM" + " where "+filter;
            var dxtdlssms=connection.Query<Dxtdlssm>(sql);
            
            return dxtdlssms;
        }
        
        public bool SaveDxtdlssm(Dxtdlssm dxtdlssm)
        {
            return dxtdlssm.Save(connection,GetSRID());
        }
        
        public void SaveDxtdlssms(List<Dxtdlssm> dxtdlssms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdlssm(Dxtdlssm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdlssm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdlssm row=this.GetDxtdlssm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLSSM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLSSM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdlssm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdlssm> rows=GetDxtdlssms(filter);
                foreach(Dxtdlssm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdlssx函数
        public Dxtdlssx GetDxtdlssx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSX" + " where id="+id.ToString();
            IEnumerable<Dxtdlssx> dxtdlssxs=connection.Query<Dxtdlssx>(sql);
            if(dxtdlssxs != null && dxtdlssxs.Count()>0)
            {
                return dxtdlssxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlssx> GetDxtdlssxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSX" + " where "+filter;
            var dxtdlssxs=connection.Query<Dxtdlssx>(sql);
            
            return dxtdlssxs;
        }
        
        public bool SaveDxtdlssx(Dxtdlssx dxtdlssx)
        {
            return dxtdlssx.Save(connection,GetSRID());
        }
        
        public void SaveDxtdlssxs(List<Dxtdlssx> dxtdlssxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlssxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdlssx(Dxtdlssx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdlssx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdlssx row=this.GetDxtdlssx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLSSX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLSSX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdlssx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdlssx> rows=GetDxtdlssxs(filter);
                foreach(Dxtdlssx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdlsszj函数
        public Dxtdlsszj GetDxtdlsszj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdlsszj> dxtdlsszjs=connection.Query<Dxtdlsszj>(sql);
            if(dxtdlsszjs != null && dxtdlsszjs.Count()>0)
            {
                return dxtdlsszjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdlsszj> GetDxtdlsszjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDLSSZJ" + " where "+filter;
            var dxtdlsszjs=connection.Query<Dxtdlsszj>(sql);
            
            return dxtdlsszjs;
        }
        
        public bool SaveDxtdlsszj(Dxtdlsszj dxtdlsszj)
        {
            return dxtdlsszj.Save(connection,GetSRID());
        }
        
        public void SaveDxtdlsszjs(List<Dxtdlsszj> dxtdlsszjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdlsszjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdlsszj(Dxtdlsszj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdlsszj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdlsszj row=this.GetDxtdlsszj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDLSSZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDLSSZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdlsszj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdlsszj> rows=GetDxtdlsszjs(filter);
                foreach(Dxtdlsszj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdmtzd函数
        public Dxtdmtzd GetDxtdmtzd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZD" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzd> dxtdmtzds=connection.Query<Dxtdmtzd>(sql);
            if(dxtdmtzds != null && dxtdmtzds.Count()>0)
            {
                return dxtdmtzds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzd> GetDxtdmtzds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZD" + " where "+filter;
            var dxtdmtzds=connection.Query<Dxtdmtzd>(sql);
            
            return dxtdmtzds;
        }
        
        public bool SaveDxtdmtzd(Dxtdmtzd dxtdmtzd)
        {
            return dxtdmtzd.Save(connection,GetSRID());
        }
        
        public void SaveDxtdmtzds(List<Dxtdmtzd> dxtdmtzds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdmtzd(Dxtdmtzd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdmtzd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdmtzd row=this.GetDxtdmtzd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDMTZD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDMTZD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdmtzd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdmtzd> rows=GetDxtdmtzds(filter);
                foreach(Dxtdmtzd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdmtzm函数
        public Dxtdmtzm GetDxtdmtzm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZM" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzm> dxtdmtzms=connection.Query<Dxtdmtzm>(sql);
            if(dxtdmtzms != null && dxtdmtzms.Count()>0)
            {
                return dxtdmtzms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzm> GetDxtdmtzms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZM" + " where "+filter;
            var dxtdmtzms=connection.Query<Dxtdmtzm>(sql);
            
            return dxtdmtzms;
        }
        
        public bool SaveDxtdmtzm(Dxtdmtzm dxtdmtzm)
        {
            return dxtdmtzm.Save(connection,GetSRID());
        }
        
        public void SaveDxtdmtzms(List<Dxtdmtzm> dxtdmtzms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdmtzm(Dxtdmtzm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdmtzm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdmtzm row=this.GetDxtdmtzm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDMTZM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDMTZM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdmtzm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdmtzm> rows=GetDxtdmtzms(filter);
                foreach(Dxtdmtzm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdmtzx函数
        public Dxtdmtzx GetDxtdmtzx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZX" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzx> dxtdmtzxs=connection.Query<Dxtdmtzx>(sql);
            if(dxtdmtzxs != null && dxtdmtzxs.Count()>0)
            {
                return dxtdmtzxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzx> GetDxtdmtzxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZX" + " where "+filter;
            var dxtdmtzxs=connection.Query<Dxtdmtzx>(sql);
            
            return dxtdmtzxs;
        }
        
        public bool SaveDxtdmtzx(Dxtdmtzx dxtdmtzx)
        {
            return dxtdmtzx.Save(connection,GetSRID());
        }
        
        public void SaveDxtdmtzxs(List<Dxtdmtzx> dxtdmtzxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdmtzx(Dxtdmtzx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdmtzx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdmtzx row=this.GetDxtdmtzx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDMTZX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDMTZX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdmtzx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdmtzx> rows=GetDxtdmtzxs(filter);
                foreach(Dxtdmtzx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtdmtzzj函数
        public Dxtdmtzzj GetDxtdmtzzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZZJ" + " where id="+id.ToString();
            IEnumerable<Dxtdmtzzj> dxtdmtzzjs=connection.Query<Dxtdmtzzj>(sql);
            if(dxtdmtzzjs != null && dxtdmtzzjs.Count()>0)
            {
                return dxtdmtzzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtdmtzzj> GetDxtdmtzzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTDMTZZJ" + " where "+filter;
            var dxtdmtzzjs=connection.Query<Dxtdmtzzj>(sql);
            
            return dxtdmtzzjs;
        }
        
        public bool SaveDxtdmtzzj(Dxtdmtzzj dxtdmtzzj)
        {
            return dxtdmtzzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtdmtzzjs(List<Dxtdmtzzj> dxtdmtzzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtdmtzzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtdmtzzj(Dxtdmtzzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtdmtzzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtdmtzzj row=this.GetDxtdmtzzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTDMTZZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTDMTZZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtdmtzzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtdmtzzj> rows=GetDxtdmtzzjs(filter);
                foreach(Dxtdmtzzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtjmdd函数
        public Dxtjmdd GetDxtjmdd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDD" + " where id="+id.ToString();
            IEnumerable<Dxtjmdd> dxtjmdds=connection.Query<Dxtjmdd>(sql);
            if(dxtjmdds != null && dxtjmdds.Count()>0)
            {
                return dxtjmdds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdd> GetDxtjmdds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDD" + " where "+filter;
            var dxtjmdds=connection.Query<Dxtjmdd>(sql);
            
            return dxtjmdds;
        }
        
        public bool SaveDxtjmdd(Dxtjmdd dxtjmdd)
        {
            return dxtjmdd.Save(connection,GetSRID());
        }
        
        public void SaveDxtjmdds(List<Dxtjmdd> dxtjmdds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtjmdd(Dxtjmdd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtjmdd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtjmdd row=this.GetDxtjmdd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTJMDD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTJMDD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtjmdd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtjmdd> rows=GetDxtjmdds(filter);
                foreach(Dxtjmdd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtjmdm函数
        public Dxtjmdm GetDxtjmdm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDM" + " where id="+id.ToString();
            IEnumerable<Dxtjmdm> dxtjmdms=connection.Query<Dxtjmdm>(sql);
            if(dxtjmdms != null && dxtjmdms.Count()>0)
            {
                return dxtjmdms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdm> GetDxtjmdms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDM" + " where "+filter;
            var dxtjmdms=connection.Query<Dxtjmdm>(sql);
            
            return dxtjmdms;
        }
        
        public bool SaveDxtjmdm(Dxtjmdm dxtjmdm)
        {
            return dxtjmdm.Save(connection,GetSRID());
        }
        
        public void SaveDxtjmdms(List<Dxtjmdm> dxtjmdms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtjmdm(Dxtjmdm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtjmdm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtjmdm row=this.GetDxtjmdm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTJMDM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTJMDM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtjmdm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtjmdm> rows=GetDxtjmdms(filter);
                foreach(Dxtjmdm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtjmdx函数
        public Dxtjmdx GetDxtjmdx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDX" + " where id="+id.ToString();
            IEnumerable<Dxtjmdx> dxtjmdxs=connection.Query<Dxtjmdx>(sql);
            if(dxtjmdxs != null && dxtjmdxs.Count()>0)
            {
                return dxtjmdxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdx> GetDxtjmdxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDX" + " where "+filter;
            var dxtjmdxs=connection.Query<Dxtjmdx>(sql);
            
            return dxtjmdxs;
        }
        
        public bool SaveDxtjmdx(Dxtjmdx dxtjmdx)
        {
            return dxtjmdx.Save(connection,GetSRID());
        }
        
        public void SaveDxtjmdxs(List<Dxtjmdx> dxtjmdxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtjmdx(Dxtjmdx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtjmdx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtjmdx row=this.GetDxtjmdx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTJMDX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTJMDX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtjmdx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtjmdx> rows=GetDxtjmdxs(filter);
                foreach(Dxtjmdx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtjmdzj函数
        public Dxtjmdzj GetDxtjmdzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDZJ" + " where id="+id.ToString();
            IEnumerable<Dxtjmdzj> dxtjmdzjs=connection.Query<Dxtjmdzj>(sql);
            if(dxtjmdzjs != null && dxtjmdzjs.Count()>0)
            {
                return dxtjmdzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtjmdzj> GetDxtjmdzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTJMDZJ" + " where "+filter;
            var dxtjmdzjs=connection.Query<Dxtjmdzj>(sql);
            
            return dxtjmdzjs;
        }
        
        public bool SaveDxtjmdzj(Dxtjmdzj dxtjmdzj)
        {
            return dxtjmdzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtjmdzjs(List<Dxtjmdzj> dxtjmdzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtjmdzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtjmdzj(Dxtjmdzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtjmdzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtjmdzj row=this.GetDxtjmdzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTJMDZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTJMDZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtjmdzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtjmdzj> rows=GetDxtjmdzjs(filter);
                foreach(Dxtjmdzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtkzdd函数
        public Dxtkzdd GetDxtkzdd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDD" + " where id="+id.ToString();
            IEnumerable<Dxtkzdd> dxtkzdds=connection.Query<Dxtkzdd>(sql);
            if(dxtkzdds != null && dxtkzdds.Count()>0)
            {
                return dxtkzdds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdd> GetDxtkzdds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDD" + " where "+filter;
            var dxtkzdds=connection.Query<Dxtkzdd>(sql);
            
            return dxtkzdds;
        }
        
        public bool SaveDxtkzdd(Dxtkzdd dxtkzdd)
        {
            return dxtkzdd.Save(connection,GetSRID());
        }
        
        public void SaveDxtkzdds(List<Dxtkzdd> dxtkzdds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtkzdd(Dxtkzdd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtkzdd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtkzdd row=this.GetDxtkzdd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTKZDD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTKZDD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtkzdd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtkzdd> rows=GetDxtkzdds(filter);
                foreach(Dxtkzdd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtkzdm函数
        public Dxtkzdm GetDxtkzdm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDM" + " where id="+id.ToString();
            IEnumerable<Dxtkzdm> dxtkzdms=connection.Query<Dxtkzdm>(sql);
            if(dxtkzdms != null && dxtkzdms.Count()>0)
            {
                return dxtkzdms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdm> GetDxtkzdms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDM" + " where "+filter;
            var dxtkzdms=connection.Query<Dxtkzdm>(sql);
            
            return dxtkzdms;
        }
        
        public bool SaveDxtkzdm(Dxtkzdm dxtkzdm)
        {
            return dxtkzdm.Save(connection,GetSRID());
        }
        
        public void SaveDxtkzdms(List<Dxtkzdm> dxtkzdms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtkzdm(Dxtkzdm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtkzdm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtkzdm row=this.GetDxtkzdm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTKZDM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTKZDM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtkzdm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtkzdm> rows=GetDxtkzdms(filter);
                foreach(Dxtkzdm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtkzdx函数
        public Dxtkzdx GetDxtkzdx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDX" + " where id="+id.ToString();
            IEnumerable<Dxtkzdx> dxtkzdxs=connection.Query<Dxtkzdx>(sql);
            if(dxtkzdxs != null && dxtkzdxs.Count()>0)
            {
                return dxtkzdxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdx> GetDxtkzdxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDX" + " where "+filter;
            var dxtkzdxs=connection.Query<Dxtkzdx>(sql);
            
            return dxtkzdxs;
        }
        
        public bool SaveDxtkzdx(Dxtkzdx dxtkzdx)
        {
            return dxtkzdx.Save(connection,GetSRID());
        }
        
        public void SaveDxtkzdxs(List<Dxtkzdx> dxtkzdxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtkzdx(Dxtkzdx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtkzdx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtkzdx row=this.GetDxtkzdx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTKZDX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTKZDX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtkzdx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtkzdx> rows=GetDxtkzdxs(filter);
                foreach(Dxtkzdx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtkzdzj函数
        public Dxtkzdzj GetDxtkzdzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDZJ" + " where id="+id.ToString();
            IEnumerable<Dxtkzdzj> dxtkzdzjs=connection.Query<Dxtkzdzj>(sql);
            if(dxtkzdzjs != null && dxtkzdzjs.Count()>0)
            {
                return dxtkzdzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtkzdzj> GetDxtkzdzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTKZDZJ" + " where "+filter;
            var dxtkzdzjs=connection.Query<Dxtkzdzj>(sql);
            
            return dxtkzdzjs;
        }
        
        public bool SaveDxtkzdzj(Dxtkzdzj dxtkzdzj)
        {
            return dxtkzdzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtkzdzjs(List<Dxtkzdzj> dxtkzdzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtkzdzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtkzdzj(Dxtkzdzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtkzdzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtkzdzj row=this.GetDxtkzdzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTKZDZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTKZDZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtkzdzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtkzdzj> rows=GetDxtkzdzjs(filter);
                foreach(Dxtkzdzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtqtd函数
        public Dxtqtd GetDxtqtd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTD" + " where id="+id.ToString();
            IEnumerable<Dxtqtd> dxtqtds=connection.Query<Dxtqtd>(sql);
            if(dxtqtds != null && dxtqtds.Count()>0)
            {
                return dxtqtds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtd> GetDxtqtds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTD" + " where "+filter;
            var dxtqtds=connection.Query<Dxtqtd>(sql);
            
            return dxtqtds;
        }
        
        public bool SaveDxtqtd(Dxtqtd dxtqtd)
        {
            return dxtqtd.Save(connection,GetSRID());
        }
        
        public void SaveDxtqtds(List<Dxtqtd> dxtqtds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtqtd(Dxtqtd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtqtd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtqtd row=this.GetDxtqtd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTQTD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTQTD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtqtd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtqtd> rows=GetDxtqtds(filter);
                foreach(Dxtqtd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtqtm函数
        public Dxtqtm GetDxtqtm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTM" + " where id="+id.ToString();
            IEnumerable<Dxtqtm> dxtqtms=connection.Query<Dxtqtm>(sql);
            if(dxtqtms != null && dxtqtms.Count()>0)
            {
                return dxtqtms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtm> GetDxtqtms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTM" + " where "+filter;
            var dxtqtms=connection.Query<Dxtqtm>(sql);
            
            return dxtqtms;
        }
        
        public bool SaveDxtqtm(Dxtqtm dxtqtm)
        {
            return dxtqtm.Save(connection,GetSRID());
        }
        
        public void SaveDxtqtms(List<Dxtqtm> dxtqtms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtqtm(Dxtqtm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtqtm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtqtm row=this.GetDxtqtm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTQTM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTQTM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtqtm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtqtm> rows=GetDxtqtms(filter);
                foreach(Dxtqtm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtqtx函数
        public Dxtqtx GetDxtqtx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTX" + " where id="+id.ToString();
            IEnumerable<Dxtqtx> dxtqtxs=connection.Query<Dxtqtx>(sql);
            if(dxtqtxs != null && dxtqtxs.Count()>0)
            {
                return dxtqtxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtx> GetDxtqtxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTX" + " where "+filter;
            var dxtqtxs=connection.Query<Dxtqtx>(sql);
            
            return dxtqtxs;
        }
        
        public bool SaveDxtqtx(Dxtqtx dxtqtx)
        {
            return dxtqtx.Save(connection,GetSRID());
        }
        
        public void SaveDxtqtxs(List<Dxtqtx> dxtqtxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtqtx(Dxtqtx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtqtx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtqtx row=this.GetDxtqtx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTQTX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTQTX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtqtx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtqtx> rows=GetDxtqtxs(filter);
                foreach(Dxtqtx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtqtzj函数
        public Dxtqtzj GetDxtqtzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTZJ" + " where id="+id.ToString();
            IEnumerable<Dxtqtzj> dxtqtzjs=connection.Query<Dxtqtzj>(sql);
            if(dxtqtzjs != null && dxtqtzjs.Count()>0)
            {
                return dxtqtzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtqtzj> GetDxtqtzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTQTZJ" + " where "+filter;
            var dxtqtzjs=connection.Query<Dxtqtzj>(sql);
            
            return dxtqtzjs;
        }
        
        public bool SaveDxtqtzj(Dxtqtzj dxtqtzj)
        {
            return dxtqtzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtqtzjs(List<Dxtqtzj> dxtqtzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtqtzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtqtzj(Dxtqtzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtqtzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtqtzj row=this.GetDxtqtzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTQTZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTQTZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtqtzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtqtzj> rows=GetDxtqtzjs(filter);
                foreach(Dxtqtzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtsxssd函数
        public Dxtsxssd GetDxtsxssd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSD" + " where id="+id.ToString();
            IEnumerable<Dxtsxssd> dxtsxssds=connection.Query<Dxtsxssd>(sql);
            if(dxtsxssds != null && dxtsxssds.Count()>0)
            {
                return dxtsxssds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssd> GetDxtsxssds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSD" + " where "+filter;
            var dxtsxssds=connection.Query<Dxtsxssd>(sql);
            
            return dxtsxssds;
        }
        
        public bool SaveDxtsxssd(Dxtsxssd dxtsxssd)
        {
            return dxtsxssd.Save(connection,GetSRID());
        }
        
        public void SaveDxtsxssds(List<Dxtsxssd> dxtsxssds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtsxssd(Dxtsxssd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtsxssd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtsxssd row=this.GetDxtsxssd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTSXSSD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTSXSSD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtsxssd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtsxssd> rows=GetDxtsxssds(filter);
                foreach(Dxtsxssd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtsxssm函数
        public Dxtsxssm GetDxtsxssm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSM" + " where id="+id.ToString();
            IEnumerable<Dxtsxssm> dxtsxssms=connection.Query<Dxtsxssm>(sql);
            if(dxtsxssms != null && dxtsxssms.Count()>0)
            {
                return dxtsxssms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssm> GetDxtsxssms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSM" + " where "+filter;
            var dxtsxssms=connection.Query<Dxtsxssm>(sql);
            
            return dxtsxssms;
        }
        
        public bool SaveDxtsxssm(Dxtsxssm dxtsxssm)
        {
            return dxtsxssm.Save(connection,GetSRID());
        }
        
        public void SaveDxtsxssms(List<Dxtsxssm> dxtsxssms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtsxssm(Dxtsxssm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtsxssm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtsxssm row=this.GetDxtsxssm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTSXSSM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTSXSSM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtsxssm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtsxssm> rows=GetDxtsxssms(filter);
                foreach(Dxtsxssm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtsxssx函数
        public Dxtsxssx GetDxtsxssx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSX" + " where id="+id.ToString();
            IEnumerable<Dxtsxssx> dxtsxssxs=connection.Query<Dxtsxssx>(sql);
            if(dxtsxssxs != null && dxtsxssxs.Count()>0)
            {
                return dxtsxssxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxssx> GetDxtsxssxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSX" + " where "+filter;
            var dxtsxssxs=connection.Query<Dxtsxssx>(sql);
            
            return dxtsxssxs;
        }
        
        public bool SaveDxtsxssx(Dxtsxssx dxtsxssx)
        {
            return dxtsxssx.Save(connection,GetSRID());
        }
        
        public void SaveDxtsxssxs(List<Dxtsxssx> dxtsxssxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxssxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtsxssx(Dxtsxssx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtsxssx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtsxssx row=this.GetDxtsxssx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTSXSSX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTSXSSX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtsxssx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtsxssx> rows=GetDxtsxssxs(filter);
                foreach(Dxtsxssx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtsxsszj函数
        public Dxtsxsszj GetDxtsxsszj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSZJ" + " where id="+id.ToString();
            IEnumerable<Dxtsxsszj> dxtsxsszjs=connection.Query<Dxtsxsszj>(sql);
            if(dxtsxsszjs != null && dxtsxsszjs.Count()>0)
            {
                return dxtsxsszjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtsxsszj> GetDxtsxsszjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTSXSSZJ" + " where "+filter;
            var dxtsxsszjs=connection.Query<Dxtsxsszj>(sql);
            
            return dxtsxsszjs;
        }
        
        public bool SaveDxtsxsszj(Dxtsxsszj dxtsxsszj)
        {
            return dxtsxsszj.Save(connection,GetSRID());
        }
        
        public void SaveDxtsxsszjs(List<Dxtsxsszj> dxtsxsszjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtsxsszjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtsxsszj(Dxtsxsszj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtsxsszj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtsxsszj row=this.GetDxtsxsszj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTSXSSZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTSXSSZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtsxsszj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtsxsszj> rows=GetDxtsxsszjs(filter);
                foreach(Dxtsxsszj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtzjd函数
        public Dxtzjd GetDxtzjd(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJD" + " where id="+id.ToString();
            IEnumerable<Dxtzjd> dxtzjds=connection.Query<Dxtzjd>(sql);
            if(dxtzjds != null && dxtzjds.Count()>0)
            {
                return dxtzjds.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjd> GetDxtzjds(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,XZJD,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJD" + " where "+filter;
            var dxtzjds=connection.Query<Dxtzjd>(sql);
            
            return dxtzjds;
        }
        
        public bool SaveDxtzjd(Dxtzjd dxtzjd)
        {
            return dxtzjd.Save(connection,GetSRID());
        }
        
        public void SaveDxtzjds(List<Dxtzjd> dxtzjds)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjds)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtzjd(Dxtzjd record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtzjd(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtzjd row=this.GetDxtzjd(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTZJD where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTZJD set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtzjd(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtzjd> rows=GetDxtzjds(filter);
                foreach(Dxtzjd row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtzjm函数
        public Dxtzjm GetDxtzjm(long id)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJM" + " where id="+id.ToString();
            IEnumerable<Dxtzjm> dxtzjms=connection.Query<Dxtzjm>(sql);
            if(dxtzjms != null && dxtzjms.Count()>0)
            {
                return dxtzjms.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjm> GetDxtzjms(string filter)
        {
            string sql="select Id,TC,CASSDM,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJM" + " where "+filter;
            var dxtzjms=connection.Query<Dxtzjm>(sql);
            
            return dxtzjms;
        }
        
        public bool SaveDxtzjm(Dxtzjm dxtzjm)
        {
            return dxtzjm.Save(connection,GetSRID());
        }
        
        public void SaveDxtzjms(List<Dxtzjm> dxtzjms)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjms)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtzjm(Dxtzjm record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtzjm(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtzjm row=this.GetDxtzjm(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTZJM where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTZJM set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtzjm(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtzjm> rows=GetDxtzjms(filter);
                foreach(Dxtzjm row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtzjx函数
        public Dxtzjx GetDxtzjx(long id)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJX" + " where id="+id.ToString();
            IEnumerable<Dxtzjx> dxtzjxs=connection.Query<Dxtzjx>(sql);
            if(dxtzjxs != null && dxtzjxs.Count()>0)
            {
                return dxtzjxs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjx> GetDxtzjxs(string filter)
        {
            string sql="select Id,TC,CASSDM,FH,FHDX,FSXX1,FSXX2,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJX" + " where "+filter;
            var dxtzjxs=connection.Query<Dxtzjx>(sql);
            
            return dxtzjxs;
        }
        
        public bool SaveDxtzjx(Dxtzjx dxtzjx)
        {
            return dxtzjx.Save(connection,GetSRID());
        }
        
        public void SaveDxtzjxs(List<Dxtzjx> dxtzjxs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjxs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtzjx(Dxtzjx record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtzjx(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtzjx row=this.GetDxtzjx(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTZJX where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTZJX set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtzjx(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtzjx> rows=GetDxtzjxs(filter);
                foreach(Dxtzjx row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        ///Dxtzjzj函数
        public Dxtzjzj GetDxtzjzj(long id)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJZJ" + " where id="+id.ToString();
            IEnumerable<Dxtzjzj> dxtzjzjs=connection.Query<Dxtzjzj>(sql);
            if(dxtzjzjs != null && dxtzjzjs.Count()>0)
            {
                return dxtzjzjs.First();
            }
            return null;
        }
        
        public IEnumerable<Dxtzjzj> GetDxtzjzjs(string filter)
        {
            string sql="select Id,WBNR,TC,CASSDM,FH,FHDX,XZJD,YSDM,DatabaseId,FLAGS,AsText(geometry) as Wkt from DXTZJZJ" + " where "+filter;
            var dxtzjzjs=connection.Query<Dxtzjzj>(sql);
            
            return dxtzjzjs;
        }
        
        public bool SaveDxtzjzj(Dxtzjzj dxtzjzj)
        {
            return dxtzjzj.Save(connection,GetSRID());
        }
        
        public void SaveDxtzjzjs(List<Dxtzjzj> dxtzjzjs)
        {
            SQLiteTransaction tran = connection.BeginTransaction();
            foreach(var rec in dxtzjzjs)
            {
                rec.Save(connection,GetSRID());
            }
            tran.Commit();
            tran.Dispose();
        }
        
        public void DeleteDxtzjzj(Dxtzjzj record)
        {
            record.Delete(connection);
        }
        
        public void DeleteDxtzjzj(long id)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                Dxtzjzj row=this.GetDxtzjzj(id);
                if(row.DatabaseID ==0)
                {
                    command.CommandText="delete from DXTZJZJ where Id=" + id.ToString();
                }
                else
                {
                    command.CommandText="update DXTZJZJ set Flags=3 where Id=" + id.ToString();
                }
                command.ExecuteNonQuery();
            }
        }
        
        public void DeleteDxtzjzj(string filter)
        {
            using(SQLiteCommand command=new SQLiteCommand(connection))
            {
                IEnumerable<Dxtzjzj> rows=GetDxtzjzjs(filter);
                foreach(Dxtzjzj row in rows)
                {
                    row.Delete(connection);
                }
            }
        }
        
        
        
        
    }
}



