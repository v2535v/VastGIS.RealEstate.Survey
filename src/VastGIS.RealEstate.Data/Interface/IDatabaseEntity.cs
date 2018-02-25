namespace VastGIS.RealEstate.Data.Interface
{
    public interface IDatabaseEntity:IEntity
    {
    
        long? DatabaseID { get; set; }
        short? Flags { get; set; }
        string Xgr { get; set; }
        System.DateTime? Xgsj { get; set; }

    }
}