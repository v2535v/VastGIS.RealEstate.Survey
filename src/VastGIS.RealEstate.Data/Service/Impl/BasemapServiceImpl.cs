using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;

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
    

        public IBasemapPoint GetBasemapPoint(string tableName, long id)
        {
            return _basemapDao.GetBasemapPoint(tableName, id);
        }

        public bool SaveBasemapPoint(IBasemapPoint rec)
        {
            return _basemapDao.SaveBasemapPoint(rec);
        }

        public void DeleteBasemapPoint(IBasemapPoint rec)
        {
            _basemapDao.DeleteBasemapPoint(rec);
        }

        public IBasemapText GetBasemapText(string tableName, long id)
        {
            return _basemapDao.GetBasemapText(tableName, id);
        }

        public bool SaveBasemapText(IBasemapText rec)
        {
            return _basemapDao.SaveBasemapText(rec);
        }

        public void DeleteBasemapText(IBasemapText rec)
        {
            _basemapDao.DeleteBasemapText(rec);
        }

        public IBasemapPolygon GetBasemapPolygon(string tableName, long id)
        {
            return _basemapDao.GetBasemapPolygon(tableName, id);
        }

        public bool SaveBasemapPolygon(IBasemapPolygon rec)
        {
            return _basemapDao.SaveBasemapPolygon(rec);
        }

        public void DeleteBasemapPolygon(IBasemapPolygon rec)
        {
            _basemapDao.DeleteBasemapPolygon(rec);
        }

        public IBasemapPolyline GetBasemapPolyline(string tableName, long id)
        {
            return _basemapDao.GetBasemapPolyline(tableName, id);
        }

        public bool SaveBasemapPolyline(IBasemapPolyline rec)
        {
            return _basemapDao.SaveBasemapPolyline(rec);
        }

        public void DeleteBasemapPolyline(IBasemapPolyline rec)
        {
            _basemapDao.DeleteBasemapPolyline(rec);
        }


    }
}



