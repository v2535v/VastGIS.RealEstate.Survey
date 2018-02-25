using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Events
{
    public class EntityChanedEventArgs
    {
        private List<long> _ids;
        public EntityChanedEventArgs()
        {
            _ids=new List<long>();
        }

        public EntityChanedEventArgs(string tableName,string layerName, EntityOperationType operationType,List<long> ids)
        {
            _ids = new List<long>();
            TableName = tableName;
            LayerName = layerName;
            OperationType = operationType;
            if(ids!=null && ids.Count>0)
            _ids.AddRange(ids);
        }
        public string TableName { get; set; }
        public string LayerName { get; set; }
        public EntityOperationType OperationType { get; set; }
        public List<long> Ids { get; set; }
    }

    public delegate void EntityChangedEventHandler(object sender, EntityChanedEventArgs e);
}
