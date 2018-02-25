using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class BasemapServiceImpl
    {
        public bool InitTables()
        {
            return _basemapDao.InitTables();
        }

        public bool AssignTextToAttribute()
        {
            return _basemapDao.AssignTextToAttribute();
        }

        public bool ReorderAllPolygon(string tableName)
        {
            return _basemapDao.ReorderAllPolygon(tableName);
        }

        public bool ReorderAllPolygon()
        {
            return _basemapDao.ReorderAllPolygon();
        }
    }
}



