using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface BasemapDao
    {

        bool InitTables();

        bool ReorderAllPolygon(string tableName);

        bool AssignTextToAttribute();

        bool ReorderAllPolygon();
    }
}



