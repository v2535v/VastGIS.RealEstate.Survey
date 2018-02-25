using VastGIS.QuickDB.Interface;

namespace VastGIS.QuickDB.Concrete
{
    public class ObjectClass : IObjectClass
    {
        

        public  string Name { get; set; }

        public string ClassType
        {
            get { return "Table"; }
        }
    }
}