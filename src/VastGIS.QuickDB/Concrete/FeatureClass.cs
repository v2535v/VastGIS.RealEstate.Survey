using VastGIS.QuickDB.Interface;

namespace VastGIS.QuickDB.Concrete
{
    public class FeatureClass:IFeatureClass
    {
       
        public FeatureClass() { }
        public FeatureClass(string name, string geometryType, string epsgCode)
        {
            Name = name;
            GeometryType = geometryType;
            EpsgCode = epsgCode;
        }
        public string Name { get; set; }

        public string ClassType
        {
            get { return "FeatureClass"; }
        }

        public string GeometryType { get; set; }

        public string EpsgCode { get; set; }

    }
}