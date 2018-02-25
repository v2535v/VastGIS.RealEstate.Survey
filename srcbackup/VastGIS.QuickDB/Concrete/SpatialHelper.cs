namespace VastGIS.QuickDB.Concrete
{
    public class SpatialHelper
    {
        public static string GetGeometryTypeString(int geometryType)
        {
            switch (geometryType)
            {
                case 1: return "点";
            }
            return "";
        }
    }
}