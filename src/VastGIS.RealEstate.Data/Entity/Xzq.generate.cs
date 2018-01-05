using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Xzq:INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "XZQ";
	    public const string COL_ID = "Id";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_XZQDM = "XZQDM";
	    public const string COL_XZQMC = "XZQMC";
	    public const string COL_XZQMJ = "XZQMJ";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_XZQDM = "@XZQDM";
        public const string PARAM_XZQMC = "@XZQMC";
        public const string PARAM_XZQMJ = "@XZQMJ";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_XZQ = "INSERT INTO XZQ (YSDM, XZQDM, XZQMC, XZQMJ, DatabaseId, FLAGS, geometry) VALUES ( @YSDM, @XZQDM, @XZQMC, @XZQMJ, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_XZQ = "UPDATE XZQ SET YSDM = @YSDM, XZQDM = @XZQDM, XZQMC = @XZQMC, XZQMJ = @XZQMJ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_XZQ = "DELETE FROM XZQ WHERE  Id = @Id ";
        
        private const string SQL_DELETE_FLAG_XZQ = "UPDATE XZQ Set Flags=3 WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string ysdm = default(string);
		protected string xzqdm = default(string);
		protected string xzqmc = default(string);
		protected double? xzqmj = default(double?);
		protected long? databaseid = default(long?);
		protected short? flag = default(short?);
        protected DbGeometry _geometry;
        protected string _wkt=default(string);
        
        private event PropertyChangingEventHandler propertyChanging;            
        private event PropertyChangedEventHandler propertyChanged;
        #endregion
        
        #region 属性
    
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
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID");  
                        this.id = value;                        
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm = value;                        
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        public string Xzqdm 
        {
            get { return this.xzqdm; }
			set	{ 
                  if(this.xzqdm != value)
                    {
                        this.OnPropertyChanging("Xzqdm");  
                        this.xzqdm = value;                        
                        this.OnPropertyChanged("Xzqdm");
                    }   
                }
        }	
        public string Xzqmc 
        {
            get { return this.xzqmc; }
			set	{ 
                  if(this.xzqmc != value)
                    {
                        this.OnPropertyChanging("Xzqmc");  
                        this.xzqmc = value;                        
                        this.OnPropertyChanged("Xzqmc");
                    }   
                }
        }	
        public double? Xzqmj 
        {
            get { return this.xzqmj; }
			set	{ 
                  if(this.xzqmj != value)
                    {
                        this.OnPropertyChanging("Xzqmj");  
                        this.xzqmj = value;                        
                        this.OnPropertyChanged("Xzqmj");
                    }   
                }
        }	
        public long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
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
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        public DbGeometry Geometry
        {
            get{return _geometry;}
            set{
                this.OnPropertyChanging("Geometry");  
                _geometry=value;
                _wkt=_geometry.AsText();
                this.OnPropertyChanged("Geometry");
                }
        }
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;
                _geometry=DbGeometry.FromText(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  Xzq()
        {
            this.ysdm="'1001010000'";
            this.databaseid=0;
            this.flag=1;
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Xzq record = obj as Xzq;           
            
            return (object.ReferenceEquals(this, record)                    
                    || (record != null            
                        && this.ID == record.ID
                        && this.ID != default(long)
                        )
                    );           
        }
        
        public override int GetHashCode()
        {            
            int hashCode = 7;
            
            hashCode = (11 * hashCode) + this.id.GetHashCode();
                        
            return hashCode;          
        }
        
        
        
        public bool Create(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_XZQ,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_XZQDM,this.Xzqdm);    				
                 command.Parameters.AddWithValue(PARAM_XZQMC,this.Xzqmc);    				
                 command.Parameters.AddWithValue(PARAM_XZQMJ,this.Xzqmj);    				
                 command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);    				
                 command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);    				
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",srid);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_XZQ,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_XZQDM,this.Xzqdm);  
				command.Parameters.AddWithValue(PARAM_XZQMC,this.Xzqmc);  
				command.Parameters.AddWithValue(PARAM_XZQMJ,this.Xzqmj);  
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);  
				command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);  
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",srid);
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(SQLiteConnection connection,int srid)
        {
            if(this.id == default(long))
            {
                return Create(connection,srid);
            }
            else
            {
                return Update(connection,srid);
            }
            
        }

		public bool Delete(SQLiteConnection connection)
        {
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_XZQ,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_XZQ,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
        }
        
        protected virtual void OnPropertyChanging(string propertyName)
        {
            if(this.propertyChanging != null)
                this.propertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(this.propertyChanged != null)
                this.propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
        #endregion
       
    }

}