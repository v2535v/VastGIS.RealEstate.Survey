using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Events
{
    public class EntityChanedEventArgs
    {
        private List<IEntity> _entities;
        public EntityChanedEventArgs()
        {
            _entities = new List<IEntity>();
        }
        public EntityChanedEventArgs(EntityOperationType operationType, IEntity entity)
        {
            _entities = new List<IEntity>();
            OperationType = operationType;
            _entities.Add(entity);
        }
        public EntityChanedEventArgs(EntityOperationType operationType,List<IEntity> entities)
        {
            _entities = new List<IEntity>();
            OperationType = operationType;
            _entities.AddRange(entities);
        }
       public EntityOperationType OperationType { get; set; }
        public List<IEntity> Entities { get { return _entities; } set { _entities = value; } }
       
    }

    public delegate void EntityChangedEventHandler(object sender, EntityChanedEventArgs e);
}
