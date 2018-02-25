using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IEntityChanged
    {
        event EntityChangedEventHandler EntityChanged;

        void OnEntityChanged(
            EntityOperationType operationType,
            List<IEntity> entities);
    }
}
