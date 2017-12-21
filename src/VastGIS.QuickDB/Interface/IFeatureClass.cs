namespace VastGIS.QuickDB.Interface
{
    public interface IFeatureClass : IObjectClass
    {
        string GeometryType { get; set; }
        string EpsgCode { get; set; }
    }
}