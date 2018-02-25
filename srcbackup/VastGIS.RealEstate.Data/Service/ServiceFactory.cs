using VastGIS.RealEstate.Data.Dao.Impl;
using VastGIS.RealEstate.Data.Service.Impl;

namespace VastGIS.RealEstate.Data.Service
{
    public class ServiceFactory
    {


        public static CadService GetCadService()
        {
            return new CadServiceImpl(new CadDaoImpl());
        }

        public static BasemapService GetBasemapService()
        {
            return new BasemapServiceImpl(new BasemapDaoImpl());
        }

        public static SystemService GetSystemService()
        {
            return new SystemServiceImpl(new SystemDaoImpl());
        }

        public static DomainService GetDomainService()
        {
            return new DomainServiceImpl(new DomainDaoImpl());
        }

        public static ZdService GetZdService()
        {
            return new ZdServiceImpl(new ZdDaoImpl());
        }


        public static void SetDatabaseName(string databaseName)
        {
            DbConnection.SetDatabaseName(databaseName);
        }

    }
}