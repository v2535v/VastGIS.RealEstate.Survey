using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;

namespace VastGIS.RealEstate.Data.Entity
{
    public class SimpleDatabaseFeature: INotifyPropertyChanging, INotifyPropertyChanged
    {
        
        public const string COL_ID = "Id";
        public const string COL_YSDM = "YSDM";
        public const string COL_DATABASEID = "DatabaseId";
        public const string COL_FLAGS = "FLAGS";
        public const string COL_GEOMETRY = "geometry";

        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";


        protected long id = default(long);
        protected string ysdm = default(string);
        protected long? databaseid = default(long?);
        protected short? flag = default(short?);
        protected IGeometry _geometry;
        protected string _wkt = default(string);
        protected GeometryType _geometryType = GeometryType.Polygon;
        protected string tablename = default(string);

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

        public long ID
        {
            get { return this.id; }
            set
            {
                if (this.id != value)
                {
                    this.OnPropertyChanging("ID");
                    this.id = value;
                    this.OnPropertyChanged("ID");
                }
            }
        }

        public string TableName
        {
            get { return this.tablename; }
            set
            {
                if (this.tablename != value)
                {
                    this.tablename = value;
                }
            }
        }
        public string Ysdm
        {
            get { return this.ysdm; }
            set
            {
                if (this.ysdm != value)
                {
                    this.OnPropertyChanging("Ysdm");
                    this.ysdm = value;
                    this.OnPropertyChanged("Ysdm");
                }
            }
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
        public IGeometry Geometry
        {
            get { return _geometry; }
            set
            {
                this.OnPropertyChanging("Geometry");
                _geometry = value;
                _wkt = _geometry.ExportToWkt();
                this.OnPropertyChanged("Geometry");
            }
        }
        public GeometryType GeometryType
        {
            get { return _geometryType; }
            set
            {
                _geometryType = value;
                _geometry = new Geometry(_geometryType, ZValueType.None);
            }
        }
        public string Wkt
        {
            get { return _wkt; }
            set
            {
                this.OnPropertyChanging("Geometry");
                _wkt = value;
                //_geometry=DbGeometry.FromText(_wkt);
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry");
            }
        }

        public  SimpleDatabaseFeature()
        {
            _geometry = new Geometry(_geometryType, ZValueType.None);
            this.ysdm = "'1002000000'";
            this.databaseid = 0;
            this.flag = 1;
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

        public bool Create(SQLiteConnection connection, int srid)
        {
            string sql =
                string.Format(
                    "insert into {0} (Ysdm,geometry,DatabaseId,Flags) VALUES(@YSDM,GeomFromText(@geometry,@SRID),@DatabaseId,@FLAGS,",
                    tablename);

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
                command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
                command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                command.Parameters.AddWithValue("@SRID", srid);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

        public bool Update(SQLiteConnection connection, int srid)
        {
            string sql =
                string.Format(
                    "update {0} set Ysdm=@YSDM,geometry=GeomFromText(@geometry,@SRID),DatabaseId=@DatabaseId,Flags=@FLAGS WHERE Id=@Id",
                    tablename);
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue(PARAM_ID, this.ID);
                command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
                command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
                command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
                command.Parameters.AddWithValue(PARAM_GEOMETRY, this._wkt);
                command.Parameters.AddWithValue("@SRID", srid);
                return (command.ExecuteNonQuery() == 1);
            }
        }

        public bool Save(SQLiteConnection connection, int srid)
        {
            if (this.id == default(long))
            {
                return Create(connection, srid);
            }
            else
            {
                return Update(connection, srid);
            }

        }

        public bool Delete(SQLiteConnection connection)
        {
            string sql = "";
            if (this.DatabaseID <1)
                 sql = string.Format("delete from {0} where Id=@Id", tablename);
            else
                sql = string.Format("update {0} set Flags=3 where Id=@Id", tablename);
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {

                command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }

    }
}
