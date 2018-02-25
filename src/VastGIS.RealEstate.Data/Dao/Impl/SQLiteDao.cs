using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Events;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Dao.Impl
{

    public abstract class SQLiteDao : ISQLiteService
    {
        protected SQLiteConnection connection;
        protected int _srid = -1;
        private string _currentUser;
        #region 事件
        private event EntityChangedEventHandler entityChanged;

        public event EntityChangedEventHandler EntityChanged
        {
            add { this.entityChanged += value; }
            remove { this.entityChanged -= value; }
        }

        public void OnEntityChanged(EntityOperationType operationType, List<IEntity> entities)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(operationType, entities));
            }
        }
        public void OnEntityChanged(EntityOperationType operationType, IEntity entity)
        {
            if (this.entityChanged != null)
            {
                this.entityChanged(this, new EntityChanedEventArgs(operationType, entity));
            }
        }

        #endregion
        public SQLiteDao()
        {
            connection = DbConnection.GetConnection();
            _currentUser = Environment.UserName;
            //GetSRID();
        }

        public DataTable ExecuteSql(SQLiteCommand command)
        {
            Trace.TraceInformation("Execute query {0}", command.CommandText);
            DataTable dt = new DataTable();
            SQLiteDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            return dt;
        }

        public DataTable ExecuteSql(string query)
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                Trace.TraceInformation("Execute query {0}", query);
                DataTable dt = new DataTable();
                SQLiteDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
        }

        public void RegisterGroup(string groupName)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = "insert into vg_classgroup([GroupName]) values('" + groupName + "');";
                command.ExecuteNonQuery();
            }
        }

        public string GetRegisterGroupSql(string groupName)
        {
            return "insert into vg_classgroup ([GroupName]) values('" + groupName + "');";
        }

        public string GetRegisterClassSql(string groupName, string className, string interfaceName = "", bool createImpl = false)
        {

            int boImpl = createImpl ? 1 : 0;
            string sql =
                 string.Format(
                     "insert into vg_classdetail([GroupName],[ObjectTableName],[InterfaceName],[CreateImpl]) values('{0}','{1}','{2}',{3});",
                     groupName, className, interfaceName, boImpl);
            return sql;

        }

        public void RegisterClass(string groupName, string className, string interfaceName = "", bool createImpl = false)
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                int boImpl = createImpl ? 1 : 0;
                command.CommandText =
                    string.Format(
                        "insert into vg_classdetail([GroupName],[ObjectTableName],[InterfaceName],[CreateImpl]) values('{0}','{1}','{2}',{3});",
                        groupName, className, interfaceName, boImpl);
                command.ExecuteNonQuery();
            }
        }

        public int GetSRID()
        {
            if (_srid > 0) return _srid;
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =
                    "Select Csz from vg_setting where Csmc='SRID'";
                _srid = Convert.ToInt32(command.ExecuteScalar());
                if (_srid == 0) _srid = 4520;
                return _srid;
            }
        }

        public SQLiteConnection Connection
        {
            get { return connection; }
        }

        public string CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public bool Save(IEntity entity)
        {
            bool ret = entity.Save(this);
            if (ret) OnEntityChanged(EntityOperationType.Save, entity);
            return ret;
        }

        public bool Save(List<IEntity> entities)
        {
            foreach (var one in entities)
            {
                one.Save(this);
            }
            OnEntityChanged(EntityOperationType.Save, entities);
            return true;
        }

        public void Delete(List<IEntity> entities)
        {
            if (entities == null) return;
            foreach (var one in entities)
            {
                one.Delete(this);
            }
            OnEntityChanged(EntityOperationType.Delete, entities);
            return;
        }

        public IEntity CreateEntity(VgObjectclass currentClass)
        {
            return CreateEntity(currentClass.Mc);
        }

        public IEntity CreateEntity(string tableName)
        {
            string objectName = "VastGIS.RealEstate.Data.Entity." + StringUtil.GetEntityName(tableName);
            Type entityType = Type.GetType(objectName);
            if (entityType != null)
            {
                IEntity pEntity = Activator.CreateInstance(entityType) as IEntity;
                return pEntity;
            }
            return null;
        }
        public IEntity GetEntity(VgObjectclass currentClass, long id)
        {
            List<IEntity> entities = GetEntities(currentClass, " ID = " + id.ToString());
            if (entities != null) return entities[0];
            return null;
        }

        public long GetMaxID(string tableName)
        {
            string sql = "SELECT MAX(ID) from " + tableName;
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                long id = Convert.ToInt64(command.ExecuteScalar());
                return id;
            }
        }

        public List<IEntity> GetEntities(VgObjectclass currentClass, string queryFilter)
        {

            return GetEntities(currentClass.Mc, queryFilter);
        }

        private List<IEntity> GetEntities(string tableName, string queryFilter)
        {
            List<IEntity> entities = new List<IEntity>();
            string objectName = "VastGIS.RealEstate.Data.Entity." + StringUtil.GetEntityName(tableName);
            Type entityType = Type.GetType(objectName);

            string sqlSource = SQLHelper.Instance().GetQuerySql(tableName);
            if (string.IsNullOrEmpty(sqlSource)) return null;
            string sql =
                SpatialHelper.SearchActualSQLBuilder(sqlSource, queryFilter);
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEntity pEntity = Activator.CreateInstance(entityType) as IEntity;
                        pEntity.LoadFromReader(reader);
                        entities.Add((IEntity)pEntity);
                    }
                    reader.Close();
                }
            }
            return entities;
        }


        public bool CopyEntities(
            VgObjectclass targetClass,
            List<IEntity> sourceFeatures,
            bool isDelete = false,
            bool isAttributeAutoTransform = true)
        {
            try
            {
                string className = targetClass.Mc;
                string objectName = "VastGIS.RealEstate.Data.Entity." + StringUtil.GetEntityName(className);
                Type entityType = Type.GetType(objectName);
                List<IEntity> newFeatures = new List<IEntity>();
                foreach (var oneFeat in sourceFeatures)
                {
                    IEntity newFeature = Activator.CreateInstance(entityType) as IEntity;
                    if (isAttributeAutoTransform) newFeature.CopyProperties(oneFeat);
                    else
                    {
                        if (newFeature.HasGeometry && oneFeat.HasGeometry)
                            ((IReFeature)newFeature).Wkt = ((IReFeature)oneFeat).Wkt;
                    }
                    newFeature.Save(this);
                    newFeatures.Add(newFeature as IEntity);
                }
                OnEntityChanged(EntityOperationType.Save, newFeatures);

                if (isDelete)
                {
                    Delete(sourceFeatures.ToList<IEntity>());
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("拷贝错误:" + ex.Message);
                return false;
            }
        }

        public List<IReFeature> FindFeatures(VgObjectclass objectClass, double x, double y)
        {
            string className = objectClass.Mc;
            string objectName = "VastGIS.RealEstate.Data.Entity." + StringUtil.GetEntityName(className);
            Type entityType = Type.GetType(objectName);
            //获取查询变量
            string selectSql = SQLHelper.Instance().GetQuerySql(objectClass.Mc);
            if (string.IsNullOrEmpty(selectSql)) return null;
            string sql =
                SpatialHelper.SearchActualSQLBuilder(selectSql, (GeometryType)objectClass.Txlx, x, y, 2);
            List<IReFeature> features = new List<IReFeature>();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEntity pEntity = Activator.CreateInstance(entityType) as IEntity;
                        pEntity.LoadFromReader(reader);
                        features.Add((IReFeature)pEntity);
                    }
                    reader.Close();
                }
            }
            return features;
        }

        public List<IReFeature> FindFeatures(List<VgObjectclass> objectClasses, double x, double y)
        {
            List<IReFeature> features = new List<IReFeature>();
            foreach (VgObjectclass objectClass in objectClasses)
            {
                List<IReFeature> oneResults = FindFeatures(objectClass, x, y);
                if (oneResults != null)
                {
                    features.AddRange(oneResults);
                }
            }
            return features;
        }



        public bool ReorderAllPolygon(string tableName)
        {
            List<IEntity> entities = GetEntities(tableName, "");
            foreach (IEntity entity in entities)
            {
                IReFeature pFeature = entity as IReFeature;
                pFeature.Geometry = SpatialHelper.ReorderPolygonVertex(pFeature.Geometry.Clone());
                pFeature.Save(this);
            }
            OnEntityChanged(EntityOperationType.Save, entities);
            return true;
        }



        public void Delete(IEntity entity)
        {
            entity.Delete(this);
            OnEntityChanged(EntityOperationType.Delete, entity);
        }

        public int GetSystemSRID()
        {
            if (_srid > 0) return _srid;
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText =
                    "Select Csz from vg_setting where Csmc='SRID'";
                _srid = Convert.ToInt32(command.ExecuteScalar());
                if (_srid == 0) _srid = 4539;
                return _srid;
            }
        }

        #region 获取所有表名
        /// <summary>
        /// 获取数据库名
        /// </summary>
        public List<string> GetAllTableName()
        {

            DataTable dt = ExecuteSql("select tbl_name from sqlite_master where type='table'");
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr["tbl_name"].ToString());
            }
            return result;
        }
        #endregion

        #region 获取表的所有字段名及字段类型
        /// <summary>
        /// 获取表的所有字段名及字段类型
        /// </summary>
        public List<Dictionary<string, string>> GetAllColumnTypes(string tableName)
        {

            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("name", dr["name"].ToString());
                dic.Add("notnull", dr["notnull"].ToString());
                result.Add(dic);
            }
            return result;
        }
        #endregion

        #region 获取表的所有字段名
        /// <summary>
        /// 获取表的所有字段名及字段类型
        /// </summary>
        public List<string> GetAllColumns(string tableName)
        {

            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr["name"].ToString().ToLower());
            }
            return result;
        }
        #endregion


        public bool HasSpecialFields(string tableName, out bool hasDatabaseId, out bool hasBackField)
        {
            DataTable dt = ExecuteSql("PRAGMA table_info('" + tableName + "')");
            hasDatabaseId = false;
            hasBackField = false;
            foreach (DataRow dr in dt.Rows)
            {
                string tbName = dr["name"].ToString().ToLower();
                if (tbName == "databaseid") hasDatabaseId = true;
                if (tbName == "wx_wydm") hasBackField = true;
            }
            return true;
        }

        public string GetLayerNameFromTable(string tableName)
        {
            tableName = tableName.ToUpper();
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = string.Format("Select Zwmc from vg_objectclass where Mc='{0}'", tableName);
                object retVal = command.ExecuteScalar();
                if (retVal == null) return "";
                return retVal.ToString();
            }


        }
    }
}