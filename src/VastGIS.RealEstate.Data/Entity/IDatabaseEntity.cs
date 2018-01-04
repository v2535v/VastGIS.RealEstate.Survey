namespace VastGIS.RealEstate.Data.Entity
{
    public interface IDatabaseEntity
    {
        long ID { get; set; }
        long? DatabaseID { get; set; }
        short? Flags { get; set; }
    }
}