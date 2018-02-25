using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface BasemapDao
    {

        bool InitTables();

        bool AssignTextToAttribute();

        IBasemapPoint GetBasemapPoint(string tableName, long id);
        bool SaveBasemapPoint(IBasemapPoint rec);
        void DeleteBasemapPoint(IBasemapPoint rec);

        IBasemapPolyline GetBasemapPolyline(string tableName, long id);
        bool SaveBasemapPolyline(IBasemapPolyline rec);
        void DeleteBasemapPolyline(IBasemapPolyline rec);

        IBasemapPolygon GetBasemapPolygon(string tableName, long id);
        bool SaveBasemapPolygon(IBasemapPolygon rec);
        void DeleteBasemapPolygon(IBasemapPolygon rec);

        IBasemapText GetBasemapText(string tableName, long id);
        bool SaveBasemapText(IBasemapText rec);
        void DeleteBasemapText(IBasemapText rec);
    }
}



