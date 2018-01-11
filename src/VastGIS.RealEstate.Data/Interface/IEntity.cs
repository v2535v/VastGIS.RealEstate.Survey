using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.RealEstate.Data.Interface
{
    public interface IEntity
    {
        long ID { get; set; }

        string EntityName { get; }
        string ObjectName { get; }

    }

    //表示有可能会和服务器进行交互，所有有两个标记字段
}
