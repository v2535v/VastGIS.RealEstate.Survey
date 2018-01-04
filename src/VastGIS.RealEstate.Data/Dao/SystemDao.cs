using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


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

        bool CopyFeature(string sourceTable, int id, string targetTable, bool isDelete = false, bool isAttributeAutoTransform = true);

        bool InitTables();

        List<VgObjectclasses> GetObjectclasseses(bool isDeep);
    }
}



