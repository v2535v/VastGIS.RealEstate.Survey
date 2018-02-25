namespace VastGIS.RealEstate.Api.Interface
{
    public interface IRealEstateContext
    {
        IREDatabase RealEstateDatabase { get; set; }

        bool CheckDatabase();
    }
}