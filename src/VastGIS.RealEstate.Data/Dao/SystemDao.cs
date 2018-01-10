using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using GeoAPI.Geometries;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao
{

    public partial interface SystemDao
    {
        void Close();

        int GetGeometryColumnSRID(string tableName, string columnName);

        void AssignTextToPolygon(
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values);



        IFeature FindFirstRecord(string[] getSearchLayers, double dx, double dy);

        List<SearchFeature> FindRecords(string[] layers, double dx, double dy);

        bool CopyFeature(string sourceTable, long id, string targetTable, bool isDelete = false, bool isAttributeAutoTransform = true);

        bool InitTables();

        List<VgObjectclasses> GetObjectclasseses(bool isDeep);

        void CreateEmptyDatabase(string dbName);

        void InternalInitTables();

        bool SaveVgSettings2(VgSettings setting);
        bool SaveVgSettings2(string csmc, string csz);

        VgSettings GetVgSettings(string csmc);

        int GetSystemSRID();

        void InitSettings();

        IEnumerable<VgAreacodes> GetAreaCodesByJB(string parentCode, int jb);
        
        void RecalculateDBExtent(out double xmin, out double ymin, out double xmax, out double ymax);

        List<SearchFeature> FindRecords(List<VgObjectclasses> classes, double dx, double dy);

        bool DeleteFeature(string sourceTable, long id);

        long SaveSearchFeature(SearchFeature feature);
    }
}



