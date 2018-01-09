using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VastGIS.RealEstate.Data.Enums
{
    public enum CADInsertMethod
    {
        DeleteByFileName = 0,
        DeleteAll = 1,
        JustInsert = 2
    }
  
    public enum AssignTextType
    {
       String =0,
        Integer =1,
        Float =2
    }

    public enum ZDBianHaoType
    {
        ZSBH,
        TYH
    }

    public enum EntityOperationType
    {
        Save,
        Delete
    }
}
