using System.Collections.Generic;
using System.Linq;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class ZdServiceImpl:ZdService
    {
        private ZdDao _zdDao;
        
        private event EntityChangedEventHandler entityChanged;
      
        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        protected virtual void OnEntityChanged(string tableName, string layerName,EntityOperationType operationType,List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType,ids));
            }
        }
        
        public ZdServiceImpl(ZdDao zdDao)
        {
            this._zdDao = zdDao;
            this._zdDao.EntityChanged += ZdDao_EntityChanged;
        }
        
        private void ZdDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.TableName,e.LayerName,e.OperationType,e.Ids);
        }
        
        public Djq GetDjq(long id)
        {
            return _zdDao.GetDjq(id);
        }
        
        public IEnumerable<Djq> GetDjqs(string filter)
        {
            return _zdDao.GetDjqs(filter);
        }
        public bool SaveDjq(Djq djq)
        {
            bool retVal=_zdDao.SaveDjq(djq);
            return retVal;
        }
        public void SaveDjqs(List<Djq> djqs)
        {
            _zdDao.SaveDjqs(djqs);
            
        }
        public void DeleteDjq(long id)
        {
            _zdDao.DeleteDjq(id);
            
        }
        public void DeleteDjq(string filter)
        {
            _zdDao.DeleteDjq(filter);
            
        }
        public Djzq GetDjzq(long id)
        {
            return _zdDao.GetDjzq(id);
        }
        
        public IEnumerable<Djzq> GetDjzqs(string filter)
        {
            return _zdDao.GetDjzqs(filter);
        }
        public bool SaveDjzq(Djzq djzq)
        {
            bool retVal=_zdDao.SaveDjzq(djzq);
            return retVal;
        }
        public void SaveDjzqs(List<Djzq> djzqs)
        {
            _zdDao.SaveDjzqs(djzqs);
            
        }
        public void DeleteDjzq(long id)
        {
            _zdDao.DeleteDjzq(id);
            
        }
        public void DeleteDjzq(string filter)
        {
            _zdDao.DeleteDjzq(filter);
            
        }
        public Jzd GetJzd(long id)
        {
            return _zdDao.GetJzd(id);
        }
        
        public IEnumerable<Jzd> GetJzds(string filter)
        {
            return _zdDao.GetJzds(filter);
        }
        public bool SaveJzd(Jzd jzd)
        {
            bool retVal=_zdDao.SaveJzd(jzd);
            return retVal;
        }
        public void SaveJzds(List<Jzd> jzds)
        {
            _zdDao.SaveJzds(jzds);
            
        }
        public void DeleteJzd(long id)
        {
            _zdDao.DeleteJzd(id);
            
        }
        public void DeleteJzd(string filter)
        {
            _zdDao.DeleteJzd(filter);
            
        }
        public Jzdzj GetJzdzj(long id)
        {
            return _zdDao.GetJzdzj(id);
        }
        
        public IEnumerable<Jzdzj> GetJzdzjs(string filter)
        {
            return _zdDao.GetJzdzjs(filter);
        }
        public bool SaveJzdzj(Jzdzj jzdzj)
        {
            bool retVal=_zdDao.SaveJzdzj(jzdzj);
            return retVal;
        }
        public void SaveJzdzjs(List<Jzdzj> jzdzjs)
        {
            _zdDao.SaveJzdzjs(jzdzjs);
            
        }
        public void DeleteJzdzj(long id)
        {
            _zdDao.DeleteJzdzj(id);
            
        }
        public void DeleteJzdzj(string filter)
        {
            _zdDao.DeleteJzdzj(filter);
            
        }
        public Jzx GetJzx(long id)
        {
            return _zdDao.GetJzx(id);
        }
        
        public IEnumerable<Jzx> GetJzxs(string filter)
        {
            return _zdDao.GetJzxs(filter);
        }
        public bool SaveJzx(Jzx jzx)
        {
            bool retVal=_zdDao.SaveJzx(jzx);
            return retVal;
        }
        public void SaveJzxs(List<Jzx> jzxs)
        {
            _zdDao.SaveJzxs(jzxs);
            
        }
        public void DeleteJzx(long id)
        {
            _zdDao.DeleteJzx(id);
            
        }
        public void DeleteJzx(string filter)
        {
            _zdDao.DeleteJzx(filter);
            
        }
        public Jzxzj GetJzxzj(long id)
        {
            return _zdDao.GetJzxzj(id);
        }
        
        public IEnumerable<Jzxzj> GetJzxzjs(string filter)
        {
            return _zdDao.GetJzxzjs(filter);
        }
        public bool SaveJzxzj(Jzxzj jzxzj)
        {
            bool retVal=_zdDao.SaveJzxzj(jzxzj);
            return retVal;
        }
        public void SaveJzxzjs(List<Jzxzj> jzxzjs)
        {
            _zdDao.SaveJzxzjs(jzxzjs);
            
        }
        public void DeleteJzxzj(long id)
        {
            _zdDao.DeleteJzxzj(id);
            
        }
        public void DeleteJzxzj(string filter)
        {
            _zdDao.DeleteJzxzj(filter);
            
        }
        public Xzq GetXzq(long id)
        {
            return _zdDao.GetXzq(id);
        }
        
        public IEnumerable<Xzq> GetXzqs(string filter)
        {
            return _zdDao.GetXzqs(filter);
        }
        public bool SaveXzq(Xzq xzq)
        {
            bool retVal=_zdDao.SaveXzq(xzq);
            return retVal;
        }
        public void SaveXzqs(List<Xzq> xzqs)
        {
            _zdDao.SaveXzqs(xzqs);
            
        }
        public void DeleteXzq(long id)
        {
            _zdDao.DeleteXzq(id);
            
        }
        public void DeleteXzq(string filter)
        {
            _zdDao.DeleteXzq(filter);
            
        }
        public Xzqjx GetXzqjx(long id)
        {
            return _zdDao.GetXzqjx(id);
        }
        
        public IEnumerable<Xzqjx> GetXzqjxs(string filter)
        {
            return _zdDao.GetXzqjxs(filter);
        }
        public bool SaveXzqjx(Xzqjx xzqjx)
        {
            bool retVal=_zdDao.SaveXzqjx(xzqjx);
            return retVal;
        }
        public void SaveXzqjxs(List<Xzqjx> xzqjxs)
        {
            _zdDao.SaveXzqjxs(xzqjxs);
            
        }
        public void DeleteXzqjx(long id)
        {
            _zdDao.DeleteXzqjx(id);
            
        }
        public void DeleteXzqjx(string filter)
        {
            _zdDao.DeleteXzqjx(filter);
            
        }
        public Zdbhqk GetZdbhqk(long id)
        {
            return _zdDao.GetZdbhqk(id);
        }
        
        public IEnumerable<Zdbhqk> GetZdbhqks(string filter)
        {
            return _zdDao.GetZdbhqks(filter);
        }
        public bool SaveZdbhqk(Zdbhqk zdbhqk)
        {
            bool retVal=_zdDao.SaveZdbhqk(zdbhqk);
            return retVal;
        }
        public void SaveZdbhqks(List<Zdbhqk> zdbhqks)
        {
            _zdDao.SaveZdbhqks(zdbhqks);
            
        }
        public void DeleteZdbhqk(long id)
        {
            _zdDao.DeleteZdbhqk(id);
            
        }
        public void DeleteZdbhqk(string filter)
        {
            _zdDao.DeleteZdbhqk(filter);
            
        }
        public Zdjbxx GetZdjbxx(long id)
        {
            return _zdDao.GetZdjbxx(id);
        }
        
        public IEnumerable<Zdjbxx> GetZdjbxxs(string filter)
        {
            return _zdDao.GetZdjbxxs(filter);
        }
        public bool SaveZdjbxx(Zdjbxx zdjbxx)
        {
            bool retVal=_zdDao.SaveZdjbxx(zdjbxx);
            return retVal;
        }
        public void SaveZdjbxxs(List<Zdjbxx> zdjbxxs)
        {
            _zdDao.SaveZdjbxxs(zdjbxxs);
            
        }
        public void DeleteZdjbxx(long id)
        {
            _zdDao.DeleteZdjbxx(id);
            
        }
        public void DeleteZdjbxx(string filter)
        {
            _zdDao.DeleteZdjbxx(filter);
            
        }
        public Zdjbxxzj GetZdjbxxzj(long id)
        {
            return _zdDao.GetZdjbxxzj(id);
        }
        
        public IEnumerable<Zdjbxxzj> GetZdjbxxzjs(string filter)
        {
            return _zdDao.GetZdjbxxzjs(filter);
        }
        public bool SaveZdjbxxzj(Zdjbxxzj zdjbxxzj)
        {
            bool retVal=_zdDao.SaveZdjbxxzj(zdjbxxzj);
            return retVal;
        }
        public void SaveZdjbxxzjs(List<Zdjbxxzj> zdjbxxzjs)
        {
            _zdDao.SaveZdjbxxzjs(zdjbxxzjs);
            
        }
        public void DeleteZdjbxxzj(long id)
        {
            _zdDao.DeleteZdjbxxzj(id);
            
        }
        public void DeleteZdjbxxzj(string filter)
        {
            _zdDao.DeleteZdjbxxzj(filter);
            
        }
        public Zdtojzd GetZdtojzd(long id)
        {
            return _zdDao.GetZdtojzd(id);
        }
        
        public IEnumerable<Zdtojzd> GetZdtojzds(string filter)
        {
            return _zdDao.GetZdtojzds(filter);
        }
        public bool SaveZdtojzd(Zdtojzd zdtojzd)
        {
            bool retVal=_zdDao.SaveZdtojzd(zdtojzd);
            return retVal;
        }
        public void SaveZdtojzds(List<Zdtojzd> zdtojzds)
        {
            _zdDao.SaveZdtojzds(zdtojzds);
            
        }
        public void DeleteZdtojzd(long id)
        {
            _zdDao.DeleteZdtojzd(id);
            
        }
        public void DeleteZdtojzd(string filter)
        {
            _zdDao.DeleteZdtojzd(filter);
            
        }
        public Zdtojzx GetZdtojzx(long id)
        {
            return _zdDao.GetZdtojzx(id);
        }
        
        public IEnumerable<Zdtojzx> GetZdtojzxs(string filter)
        {
            return _zdDao.GetZdtojzxs(filter);
        }
        public bool SaveZdtojzx(Zdtojzx zdtojzx)
        {
            bool retVal=_zdDao.SaveZdtojzx(zdtojzx);
            return retVal;
        }
        public void SaveZdtojzxs(List<Zdtojzx> zdtojzxs)
        {
            _zdDao.SaveZdtojzxs(zdtojzxs);
            
        }
        public void DeleteZdtojzx(long id)
        {
            _zdDao.DeleteZdtojzx(id);
            
        }
        public void DeleteZdtojzx(string filter)
        {
            _zdDao.DeleteZdtojzx(filter);
            
        }
    }

}



