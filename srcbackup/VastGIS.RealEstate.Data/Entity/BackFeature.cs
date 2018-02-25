using System;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class BackFeature : Feature,ISurveyFeature
    {
        
        private string _entityName;
        protected string wxDcy = default(string);
        protected System.DateTime? wxDcsj = default(System.DateTime?);
        protected string wxCly = default(string);
        protected System.DateTime? wxClsj = default(System.DateTime?);
        protected string wxZty = default(string);
        protected System.DateTime? wxZtsj = default(System.DateTime?);
        protected string wxZjy = default(string);
        protected System.DateTime? wxZjsj = default(System.DateTime?);
        protected System.Guid? wxWydm = default(System.Guid?);
        private string _objectName;
        private string _xgr;
        private DateTime? _xgsj;

        #region ²éÑ¯

        private const string SQL_INSERT_BACKFEATURE = "INSERT INTO TABLENAME (YSDM,  WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, geometry) VALUES ( @YSDM,  @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";

        private const string SQL_UPDATE_BACKFEATURE = "UPDATE TABLENAME SET YSDM = @YSDM, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";

        private const string SQL_DELETE_BACKFEATURE = "DELETE FROM TABLENAME WHERE  Id = @Id ";

        private const string SQL_DELETE_FLAG_BACKFEATURE = "UPDATE TABLENAME Set Flags=3 WHERE  Id = @Id ";

        #endregion
       

        public string WxDcy
        {
            get { return this.wxDcy; }
            set
            {
                if (this.wxDcy != value)
                {
                    this.OnPropertyChanging("WxDcy");
                    this.wxDcy = value;
                    this.OnPropertyChanged("WxDcy");
                }
            }
        }
        public System.DateTime? WxDcsj
        {
            get { return this.wxDcsj; }
            set
            {
                if (this.wxDcsj != value)
                {
                    this.OnPropertyChanging("WxDcsj");
                    this.wxDcsj = value;
                    this.OnPropertyChanged("WxDcsj");
                }
            }
        }
        public string WxCly
        {
            get { return this.wxCly; }
            set
            {
                if (this.wxCly != value)
                {
                    this.OnPropertyChanging("WxCly");
                    this.wxCly = value;
                    this.OnPropertyChanged("WxCly");
                }
            }
        }
        public System.DateTime? WxClsj
        {
            get { return this.wxClsj; }
            set
            {
                if (this.wxClsj != value)
                {
                    this.OnPropertyChanging("WxClsj");
                    this.wxClsj = value;
                    this.OnPropertyChanged("WxClsj");
                }
            }
        }
        public string WxZty
        {
            get { return this.wxZty; }
            set
            {
                if (this.wxZty != value)
                {
                    this.OnPropertyChanging("WxZty");
                    this.wxZty = value;
                    this.OnPropertyChanged("WxZty");
                }
            }
        }
        public System.DateTime? WxZtsj
        {
            get { return this.wxZtsj; }
            set
            {
                if (this.wxZtsj != value)
                {
                    this.OnPropertyChanging("WxZtsj");
                    this.wxZtsj = value;
                    this.OnPropertyChanged("WxZtsj");
                }
            }
        }
        public string WxZjy
        {
            get { return this.wxZjy; }
            set
            {
                if (this.wxZjy != value)
                {
                    this.OnPropertyChanging("WxZjy");
                    this.wxZjy = value;
                    this.OnPropertyChanged("WxZjy");
                }
            }
        }
        public System.DateTime? WxZjsj
        {
            get { return this.wxZjsj; }
            set
            {
                if (this.wxZjsj != value)
                {
                    this.OnPropertyChanging("WxZjsj");
                    this.wxZjsj = value;
                    this.OnPropertyChanged("WxZjsj");
                }
            }
        }
        public System.Guid? WxWydm
        {
            get { return this.wxWydm; }
            set
            {
                if (this.wxWydm != value)
                {
                    this.OnPropertyChanging("WxWydm");
                    this.wxWydm = value;
                    this.OnPropertyChanged("WxWydm");
                }
            }
        }

        public override long Create(ISQLiteDao dao)
        {
            using (SQLiteCommand command = new SQLiteCommand(SQL_INSERT_BACKFEATURE.Replace("TABLENAME", this.TableName), dao.Connection))
            {
                this.databaseid = 0;
                this.flag = 1;
                command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
                command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
                command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
                command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
                command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
                command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
                command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
                command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
                command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
                command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
                command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
                command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                command.Parameters.AddWithValue("@SRID", dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

        public override bool Update(ISQLiteDao dao)
        {
            using (SQLiteCommand command = new SQLiteCommand(SQL_UPDATE_BACKFEATURE.Replace("TABLENAME", this.TableName), dao.Connection))
            {
                command.Parameters.AddWithValue(PARAM_ID, this.ID);
                command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
                command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
                command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
                command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
                command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
                command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
                command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
                command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
                command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
                command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
                this.flag = (short?)(this.databaseid > 0 ? 2 : 1);
                command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
                command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                command.Parameters.AddWithValue("@SRID", dao.GetSRID());
                return (command.ExecuteNonQuery() == 1);
            }
        }

        public bool Save(ISQLiteDao dao)
        {
            if (this.ID == default(long))
            {
                return Create(dao) > 0;
            }
            else
            {
                return Update(dao);
            }
        }


        public bool Delete(ISQLiteDao dao)
        {
            if (this.databaseid == 0)
            {
                using (SQLiteCommand command = new SQLiteCommand(SQL_DELETE_BACKFEATURE, dao.Connection))
                {

                    command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using (SQLiteCommand command = new SQLiteCommand(SQL_DELETE_FLAG_BACKFEATURE, dao.Connection))
                {

                    command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                    command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
        }

        public string Xgr
        {
            get { return _xgr; }
            set { _xgr = value; }
        }

        public DateTime? Xgsj
        {
            get { return _xgsj; }
            set { _xgsj = value; }
        }
    }
}