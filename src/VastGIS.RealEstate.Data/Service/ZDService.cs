using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;

namespace VastGIS.RealEstate.Data.Service
{
    public interface ZDService
    {
        ZDJBXX GetZDJBXX(int id);
        ZDJBXX GetZDJBXX(string bh, ZDBianHaoType bhType= ZDBianHaoType.ZSBH);

        DbSet<ZDJBXX> GetZDBXXes(bool isDeep=false);


        JZD GetJZD(int id);
        JZD GetZJD(string bh, ZDBianHaoType bhType = ZDBianHaoType.ZSBH);
        DbSet<ZDJBXX> GetJZDs(bool isDeep = false);

        List<JZD> GetJZDsByZD(string zdbh);

        void SaveJZD(JZD jzd);


    }
}