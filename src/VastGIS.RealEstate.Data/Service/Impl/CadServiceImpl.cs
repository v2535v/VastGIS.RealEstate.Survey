using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class CadServiceImpl
    {
        public bool InitTables()
        {
            return _cadDao.InitTables();
        }

        public void UpdateTmpCadYsdm()
        {
            _cadDao.UpdateTmpCadYsdm();
        }

        public void ClearCADTemps()
        {
            _cadDao.ClearCADTemps();
        }

        public void ClearCADTemps(CADInsertMethod insertMethod, string dxfName)
        {
            _cadDao.ClearCADTemps(insertMethod, dxfName);
        }

        public bool HasCADData(string fileName)
        {
            return _cadDao.HasCADData(fileName);
        }

        public void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear = true)
        {
            _cadDao.SplitTmpCADToLayer(cadLayerName, tableName, fileName, isClear);
        }
    }
}



