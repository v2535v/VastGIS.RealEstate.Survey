using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Dxtqtm:INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "DXTQTM";
	    public const string COL_ID = "Id";
	    public const string COL_TC = "TC";
	    public const string COL_CASSDM = "CASSDM";
	    public const string COL_FSXX1 = "FSXX1";
	    public const string COL_FSXX2 = "FSXX2";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_TC = "@TC";
        public const string PARAM_CASSDM = "@CASSDM";
        public const string PARAM_FSXX1 = "@FSXX1";
        public const string PARAM_FSXX2 = "@FSXX2";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_DXTQTM = "INSERT INTO DXTQTM (TC, CASSDM, FSXX1, FSXX2, YSDM, DatabaseId, FLAGS, geometry) VALUES ( @TC, @CASSDM, @FSXX1, @FSXX2, @YSDM, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_DXTQTM = "UPDATE DXTQTM SET TC = @TC, CASSDM = @CASSDM, FSXX1 = @FSXX1, FSXX2 = @FSXX2, YSDM = @YSDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_DXTQTM = "DELETE FROM DXTQTM WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string tc = default(string);
		protected string cassdm = default(string);
		protected string fsxx1 = default(string);
		protected string fsxx2 = default(string);
		protected string ysdm = default(string);
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
        public string Tc 
        {
            get { return this.tc; }
			set	{ 
                  if(this.tc != value)
                    {
                        this.OnPropertyChanging("Tc");  
                        this.tc = value;                        
                        this.OnPropertyChanged("Tc");
                    }   
                }
        }	
        public string Cassdm 
        {
            get { return this.cassdm; }
			set	{ 
                  if(this.cassdm != value)
                    {
                        this.OnPropertyChanging("Cassdm");  
                        this.cassdm = value;                        
                        this.OnPropertyChanged("Cassdm");
                    }   
                }
        }	
        public string Fsxx1 
        {
            get { return this.fsxx1; }
			set	{ 
                  if(this.fsxx1 != value)
                    {
                        this.OnPropertyChanging("Fsxx1");  
                        this.fsxx1 = value;                        
                        this.OnPropertyChanged("Fsxx1");
                    }   
                }
        }	
        public string Fsxx2 
        {
            get { return this.fsxx2; }
			set	{ 
                  if(this.fsxx2 != value)
                    {
                        this.OnPropertyChanging("Fsxx2");  
                        this.fsxx2 = value;                        
                        this.OnPropertyChanged("Fsxx2");
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
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Dxtqtm record = obj as Dxtqtm;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DXTQTM,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_TC,this.Tc);    				
                 command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);    				
                 command.Parameters.AddWithValue(PARAM_FSXX1,this.Fsxx1);    				
                 command.Parameters.AddWithValue(PARAM_FSXX2,this.Fsxx2);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DXTQTM,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_TC,this.Tc);  
				command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);  
				command.Parameters.AddWithValue(PARAM_FSXX1,this.Fsxx1);  
				command.Parameters.AddWithValue(PARAM_FSXX2,this.Fsxx2);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DXTQTM,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
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