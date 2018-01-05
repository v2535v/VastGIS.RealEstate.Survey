using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;


namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class SystemServiceImpl
    {
        public void CreateEmptyDatabase(string dbName)
        {
            _systemDao.CreateEmptyDatabase(dbName);
        }

        public bool InitTables()
        {
            return _systemDao.InitTables();
        }

        public void Close()
        {
            _systemDao.Close();
        }

        public int GetGeometryColumnSRID(string tableName, string columnName)
        {
            return _systemDao.GetGeometryColumnSRID(tableName, columnName);
        }



        public void AssignTextToPolygon(
            AssignTextType assignType,
            string polyTable,
            string polyFieldName,
            string textTable,
            string textFieldName,
            string whereClause,
            object values)
        {
            _systemDao.AssignTextToPolygon(assignType, polyTable, polyFieldName, textTable, textFieldName, whereClause, values);
        }


        public IFeature FindFirstRecord(string[] getSearchLayers, double dx, double dy)
        {
            return _systemDao.FindFirstRecord(getSearchLayers, dx, dy);
        }

        public bool CopyFeature(
            string sourceTable,
            int id,
            string targetTable,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            return _systemDao.CopyFeature(sourceTable, id, targetTable, isDelete, isAttributeAutoTransform);
        }

        public List<VgObjectclasses> GetObjectclasseses(bool isDeep = true)
        {
            return _systemDao.GetObjectclasseses(isDeep);
        }
    }
}



