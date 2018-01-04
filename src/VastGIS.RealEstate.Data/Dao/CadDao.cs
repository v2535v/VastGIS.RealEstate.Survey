using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface CadDao
    {
        bool InitTables();

        void UpdateTmpCadYsdm();

        void ClearCADTemps();
        void ClearCADTemps(CADInsertMethod insertMethod, string dxfName);

        bool HasCADData(string fileName);

        void SplitTmpCADToLayer(string cadLayerName, string tableName, string fileName = "", bool isClear = true);

    }
}



