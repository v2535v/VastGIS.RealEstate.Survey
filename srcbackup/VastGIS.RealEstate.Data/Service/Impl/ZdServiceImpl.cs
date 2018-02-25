using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class ZdServiceImpl
    {      
        public bool InitTables()
        {
            return _zdDao.InitTables();
        }
        
    }
}



