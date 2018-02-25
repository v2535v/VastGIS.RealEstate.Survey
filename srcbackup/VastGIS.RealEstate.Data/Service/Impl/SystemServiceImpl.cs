using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using GeoAPI.Geometries;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class SystemServiceImpl
    {
        public void CreateEmptyDatabase(string dbName)
        {
            _systemDao.CreateEmptyDatabase(dbName);
        }

        public void InternalInitTables()
        {
            _systemDao.InternalInitTables();
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

        public int GetSystemSRID()
        {
            return _systemDao.GetSystemSRID();
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


        public SearchFeature FindFirstRecord(List<VgObjectclass> classes, double dx, double dy)
        {
            return _systemDao.FindFirstRecord(classes, dx, dy);
        }

        public List<SearchFeature> FindRecords(string[] layers, double dx, double dy)
        {
            return _systemDao.FindRecords(layers, dx, dy);
        }

        public List<SearchFeature> FindRecords(List<VgObjectclass> classes, double dx, double dy)
        {
            return _systemDao.FindRecords(classes, dx, dy);
        }

        public List<SearchFeature> FindRecords(VgObjectclass classes, int[] ids)
        {
            return _systemDao.FindRecords(classes, ids);
        }

        public bool CopyFeature(
            string sourceTable,
            long id,
            string targetTable,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            return _systemDao.CopyFeature(sourceTable, id, targetTable, isDelete, isAttributeAutoTransform);
        }

        public bool CopyFeatures(
            VgObjectclass targetClass,
            List<SearchFeature> sourceFeatures,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            return _systemDao.CopyFeatures(targetClass, sourceFeatures, isDelete, isAttributeAutoTransform);
        }

        public bool DeleteFeature(string sourceTable, long id)
        {
            return _systemDao.DeleteFeature(sourceTable, id);
        }

        public bool DeleteFeatures(List<SearchFeature> features)
        {
            return _systemDao.DeleteFeatures(features);
        }

        public List<VgObjectclass> GetObjectclasses(bool isDeep = true)
        {
            return _systemDao.GetObjectclasses(isDeep);
        }

        public bool SaveVgSetting2(VgSetting setting)
        {
            return _systemDao.SaveVgSetting2(setting);
        }

        public bool SaveVgSetting2(string csmc, string csz)
        {
            return _systemDao.SaveVgSetting2(csmc,csz);
        }

        public VgSetting GetVgSettingByName(string csmc)
        {
            return _systemDao.GetVgSettingByName(csmc);
        }

        public void InitSettings()
        {
            _systemDao.InitSettings();
        }

        public IEnumerable<VgAreacode> GetAreaCodesByJB(string parentCode, int jb = 1)
        {
            return _systemDao.GetAreaCodesByJB(parentCode, jb);
        }

        public void RecalculateDBExtent(out double xmin, out double ymin, out double xmax, out double ymax)
        {
             _systemDao.RecalculateDBExtent(out xmin, out ymin, out xmax, out ymax);
        }

        public long SaveSearchFeature(SearchFeature feature)
        {
            return _systemDao.SaveSearchFeature(feature);
        }

        public List<long> SaveSearchFeatures(List<SearchFeature> features)
        {
            return _systemDao.SaveSearchFeatures(features);
        }

        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(string wydm)
        {
            return _systemDao.GetVgAttachmentsByWydm(wydm);
        }

        public IEnumerable<VgAttachment> GetVgAttachmentsByWydm(Guid wydm)
        {
            return _systemDao.GetVgAttachmentsByWydm(wydm);
        }

        public VgClassdetail GetVgClassdetailByTableName(string tbName)
        {
            return _systemDao.GetVgClassdetailByTableName(tbName);
        }
    }
}



