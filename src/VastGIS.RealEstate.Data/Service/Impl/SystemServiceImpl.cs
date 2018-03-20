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
using IGeometry = VastGIS.Api.Interfaces.IGeometry;

namespace VastGIS.RealEstate.Data.Service.Impl
{

    public partial class SystemServiceImpl
    {
        public void CreateEmptyDatabase(string dbName)
        {
            _systemDao.CreateEmptyDatabase(dbName);
        }

        public void InitializeDatabase(int srid)
        {
            _systemDao.InitializeDatabase(srid);
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
        public string GetTemporaryAttachmentName()
        {
            return _systemDao.GetTemporaryAttachmentName();
        }

        public IEnumerable<Qlr> GetQlrsByBdcdyh(string bdcdhy)
        {
            return _systemDao.GetQlrsByBdcdyh(bdcdhy);
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, IGeometry geometry)
        {
            return _systemDao.FindFeatures(objectClass, geometry);
        }
    }
}



