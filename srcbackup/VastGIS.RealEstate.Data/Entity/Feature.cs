using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Spatial;
using System.Data.SQLite;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;


namespace VastGIS.RealEstate.Data.Entity
{
    public abstract class Feature : IReFeature, INotifyPropertyChanging, INotifyPropertyChanged
    {
        public const string COL_ID = "Id";
        public const string COL_YSDM = "YSDM";
        public const string COL_WX_DCY = "WX_DCY";
        public const string COL_WX_DCSJ = "WX_DCSJ";
        public const string COL_WX_CLY = "WX_CLY";
        public const string COL_WX_CLSJ = "WX_CLSJ";
        public const string COL_WX_ZTY = "WX_ZTY";
        public const string COL_WX_ZTSJ = "WX_ZTSJ";
        public const string COL_WX_ZJY = "WX_ZJY";
        public const string COL_WX_ZJSJ = "WX_ZJSJ";
        public const string COL_WX_WYDM = "WX_WYDM";
        public const string COL_DATABASEID = "DatabaseId";
        public const string COL_FLAGS = "FLAGS";
        public const string COL_XGR = "XGR";
        public const string COL_XGSJ = "XGSJ";
        public const string COL_GEOMETRY = "geometry";

        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_WX_DCY = "@WX_DCY";
        public const string PARAM_WX_DCSJ = "@WX_DCSJ";
        public const string PARAM_WX_CLY = "@WX_CLY";
        public const string PARAM_WX_CLSJ = "@WX_CLSJ";
        public const string PARAM_WX_ZTY = "@WX_ZTY";
        public const string PARAM_WX_ZTSJ = "@WX_ZTSJ";
        public const string PARAM_WX_ZJY = "@WX_ZJY";
        public const string PARAM_WX_ZJSJ = "@WX_ZJSJ";
        public const string PARAM_WX_WYDM = "@WX_WYDM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
        public const string PARAM_GEOMETRY = "@geometry";

        private const string SQL_INSERT_BACKFEATURE =
                "INSERT INTO TABLENAME (YSDM,Geometry,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ) VALUES(@YSDM,GeomFromText(@geometry,@SRID),@WX_WYDM, @DatabaseId, @FLAGS,@XGR,@XGSJ);SELECT last_insert_rowid();"
            ;

        private const string SQL_INSERT_FEATURE =
                "INSERT INTO TABLENAME (YSDM,Geometry,DatabaseId,FLAGS,XGR,XGSJ) VALUES(@YSDM,GeomFromText(@geometry,@SRID), @DatabaseId, @FLAGS,@XGR,@XGSJ);SELECT last_insert_rowid();"
            ;

        private const string SQL_UPDATE_FEATURE =
            "UPDATE TABLENAME SET YSDM=@YSDM, Geometry=GeomFromText(@geometry,@SRID),FLAGS=@FLAGS,XGR = @XGR, XGSJ = @XGSJ WHERE Id=@Id";
        private const string SQL_DELETE_FEATURE =
            "DELETE FROM TABLENAME WHERE  Id = @Id ";
        private const string SQL_DELETE_FLAG_FEATURE =
            "UPDATE  TABLENAME SET FLAGS=3,XGR = @XGR, XGSJ = @XGSJ  WHERE  Id = @Id ";

        internal string _wkt;
        internal DbGeometry _dbgeometry;
        internal IGeometry _geometry;
        protected string _simpleLabelString;
        protected string _fullLabelString;
        protected long _id=default(long);
        protected string _ysdm = default(string);
        protected long? databaseid = default(long?);
        protected short? flag = default(short?);
        private string _objectName;
        private GeometryType _geometryType;

        private event PropertyChangingEventHandler propertyChanging;
        private event PropertyChangedEventHandler propertyChanged;

        event PropertyChangingEventHandler INotifyPropertyChanging.PropertyChanging
        {
            add { this.propertyChanging += value; }
            remove { this.propertyChanging -= value; }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { this.propertyChanged += value; }
            remove { this.propertyChanged -= value; }
        }

        public DbGeometry GetDbGeometry()
        {
            return _dbgeometry;
        }

        public IGeometry Geometry
        {
            get { return _geometry; }
        }

        public GeometryType GeometryType
        {
            get { return _geometryType; }
        }

        public IGeometry GetGeometry()
        {
            return _geometry;
        }

        public DbGeometry DbGeometry
        {
            get { return _dbgeometry; }
        }

        public void SetGeometry(DbGeometry geometry)
        {
            this.OnPropertyChanging("Geometry");
            _wkt = geometry.AsText();
            _dbgeometry = geometry;
            _geometry = GeometryHelper.CreateGeometryByDbGeometry(_dbgeometry);
            this.OnPropertyChanged("Geometry");
        }
        public long? DatabaseID
        {
            get { return this.databaseid; }
            set
            {
                if (this.databaseid != value)
                {
                    this.OnPropertyChanging("DatabaseID");
                    this.databaseid = value;
                    this.OnPropertyChanged("DatabaseID");
                }
            }
        }
        public short? Flags
        {
            get { return this.flag; }
            set
            {
                if (this.flag != value)
                {
                    this.OnPropertyChanging("Flags");
                    this.flag = value;
                    this.OnPropertyChanged("Flags");
                }
            }
        }
        public string Wkt
        {
            get { return _wkt; }
            set
            {
                this.OnPropertyChanging("Geometry");
                _wkt = value;
                _dbgeometry = DbGeometry.FromText(_wkt);
                _geometry = GeometryHelper.CreateGeometryByDbGeometry(_dbgeometry);
                this.OnPropertyChanged("Geometry");
            }
        }

        public string Ysdm
        {
            get { return _ysdm; }
            set
            {
                this.OnPropertyChanging("Ysdm");
                _ysdm = value;
                this.OnPropertyChanged("Ysdm");
            }
        }

        public long ID
        {
            get { return _id; }
            set
            {
                this.OnPropertyChanging("ID");
                _id = value;
                this.OnPropertyChanged("ID");
            }
        }

        public string EntityName { get; set; }

        public string ObjectName
        {
            get;
            set;
        }

        public string TableName { get; set; }

        public string TableChineseName { get; set; }

        public string SimpleLabelString
        {
            get { return string.Format("{0} {1} ({2})", TableName, _id, _ysdm); }
        }

        public string FullLabelString
        {
            get { return string.Format("{0} {1} ({2})", TableChineseName, _id, _ysdm); }
        }

       

        public List<string> GetAllColumns(SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand("PRAGMA table_info('" + this.TableName + "')", connection))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                List<string> result = new List<string>();
                while(reader.Read())
                {
                    result.Add(reader["name"].ToString().ToLower());
                }

                reader.Close();
                return result;
            }
        }
        public virtual long Create(ISQLiteDao dao)
        {
            List<string> sourceColumns = GetAllColumns(dao.Connection);
           
            using (SQLiteCommand command = new SQLiteCommand(dao.Connection))
            {
                this.databaseid = 0;
                this.flag = 1;
                if (sourceColumns.Contains("wx_wydm"))
                {
                    command.CommandText = SQL_INSERT_BACKFEATURE.Replace("TABLENAME" , this.TableName);
                    command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                    command.Parameters.AddWithValue(PARAM_DATABASEID,0);
                    command.Parameters.AddWithValue(PARAM_FLAGS, 1);
                    command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                    command.Parameters.AddWithValue(PARAM_WX_WYDM,Guid.NewGuid());
                    command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                    command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                    command.Parameters.AddWithValue("@SRID", dao.GetSRID());
                }
                else
                {
                    command.CommandText = SQL_INSERT_FEATURE.Replace("TABLENAME", this.TableName);
                    command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                    command.Parameters.AddWithValue(PARAM_DATABASEID, 0);
                    command.Parameters.AddWithValue(PARAM_FLAGS, 1);
                    command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                    command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                    command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                    command.Parameters.AddWithValue("@SRID", dao.GetSRID());
                }
                  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

        public virtual bool Update(ISQLiteDao dao)
        {
            using (SQLiteCommand command = new SQLiteCommand(SQL_UPDATE_FEATURE.Replace("TABLENAME", this.TableName), dao.Connection))
            {
                command.Parameters.AddWithValue(PARAM_ID, this.ID);
                command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID==null ? 0 : this.DatabaseID);
                this.flag = (short?)(this.databaseid > 0 ? 2 :1);
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
                using (SQLiteCommand command = new SQLiteCommand(SQL_DELETE_FEATURE, dao.Connection))
                {

                    command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using (SQLiteCommand command = new SQLiteCommand(SQL_DELETE_FLAG_FEATURE, dao.Connection))
                {

                    command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR, dao.CurrentUser);
                    command.Parameters.AddWithValue(PARAM_XGSJ, DateTime.Now);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
        }

        public override bool Equals(object obj)
        {
            IReFeature record = obj as IReFeature;
            if (record.TableName == TableName && record.ID == _id) return true;
            return false;
        }
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if (this.propertyChanging != null)
                this.propertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.propertyChanged != null)
                this.propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}