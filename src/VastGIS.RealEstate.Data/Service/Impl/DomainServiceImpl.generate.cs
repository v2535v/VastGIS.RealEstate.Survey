using System.Collections.Generic;
using System.Linq;
using VastGIS.RealEstate.Data.Dao;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class DomainServiceImpl:DomainService
    {
        private DomainDao _domainDao;
        
        private event EntityChangedEventHandler entityChanged;
      
        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public  void OnEntityChanged(string tableName, string layerName,EntityOperationType operationType,List<long> ids)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(tableName, layerName, operationType,ids));
            }
        }
        
        public DomainServiceImpl(DomainDao domainDao)
        {
            this._domainDao = domainDao;
            this._domainDao.EntityChanged += DomainDao_EntityChanged;
        }
        
        private void DomainDao_EntityChanged(object sender, EntityChanedEventArgs e)
        {
            OnEntityChanged(e.TableName,e.LayerName,e.OperationType,e.Ids);
        }
        
        public VgDictionary GetVgDictionary(long id)
        {
            return _domainDao.GetVgDictionary(id);
        }
        
        public IEnumerable<VgDictionary> GetVgDictionarys(string filter)
        {
            return _domainDao.GetVgDictionarys(filter);
        }
        public bool SaveVgDictionary(VgDictionary vgDictionary)
        {
            bool retVal=_domainDao.SaveVgDictionary(vgDictionary);
            return retVal;
        }
        public void SaveVgDictionarys(List<VgDictionary> vgDictionarys)
        {
            _domainDao.SaveVgDictionarys(vgDictionarys);
            
        }
        public void DeleteVgDictionary(long id)
        {
            _domainDao.DeleteVgDictionary(id);
            
        }
        public void DeleteVgDictionary(string filter)
        {
            _domainDao.DeleteVgDictionary(filter);
            
        }
        public VgDictoryname GetVgDictoryname(long id)
        {
            return _domainDao.GetVgDictoryname(id);
        }
        
        public IEnumerable<VgDictoryname> GetVgDictorynames(string filter)
        {
            return _domainDao.GetVgDictorynames(filter);
        }
        public bool SaveVgDictoryname(VgDictoryname vgDictoryname)
        {
            bool retVal=_domainDao.SaveVgDictoryname(vgDictoryname);
            return retVal;
        }
        public void SaveVgDictorynames(List<VgDictoryname> vgDictorynames)
        {
            _domainDao.SaveVgDictorynames(vgDictorynames);
            
        }
        public void DeleteVgDictoryname(long id)
        {
            _domainDao.DeleteVgDictoryname(id);
            
        }
        public void DeleteVgDictoryname(string filter)
        {
            _domainDao.DeleteVgDictoryname(filter);
            
        }
    }

}



