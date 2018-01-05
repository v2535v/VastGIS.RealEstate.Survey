using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Dxtdldwzj:INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "DXTDLDWZJ";
	    public const string COL_ID = "Id";
	    public const string COL_WBNR = "WBNR";
	    public const string COL_TC = "TC";
	    public const string COL_CASSDM = "CASSDM";
	    public const string COL_FH = "FH";
	    public const string COL_FHDX = "FHDX";
	    public const string COL_XZJD = "XZJD";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_WBNR = "@WBNR";
        public const string PARAM_TC = "@TC";
        public const string PARAM_CASSDM = "@CASSDM";
        public const string PARAM_FH = "@FH";
        public const string PARAM_FHDX = "@FHDX";
        public const string PARAM_XZJD = "@XZJD";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_DXTDLDWZJ = "INSERT INTO DXTDLDWZJ (WBNR, TC, CASSDM, FH, FHDX, XZJD, YSDM, DatabaseId, FLAGS, geometry) VALUES ( @WBNR, @TC, @CASSDM, @FH, @FHDX, @XZJD, @YSDM, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_DXTDLDWZJ = "UPDATE DXTDLDWZJ SET WBNR = @WBNR, TC = @TC, CASSDM = @CASSDM, FH = @FH, FHDX = @FHDX, XZJD = @XZJD, YSDM = @YSDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_DXTDLDWZJ = "DELETE FROM DXTDLDWZJ WHERE  Id = @Id ";
        
        private const string SQL_DELETE_FLAG_DXTDLDWZJ = "UPDATE DXTDLDWZJ Set Flags=3 WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string wbnr = default(string);
		protected string tc = default(string);
		protected string cassdm = default(string);
		protected string fh = default(string);
		protected double? fhdx = default(double?);
		protected double? xzjd = default(double?);
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
        public string Wbnr 
        {
            get { return this.wbnr; }
			set	{ 
                  if(this.wbnr != value)
                    {
                        this.OnPropertyChanging("Wbnr");  
                        this.wbnr = value;                        
                        this.OnPropertyChanged("Wbnr");
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
        public string Fh 
        {
            get { return this.fh; }
			set	{ 
                  if(this.fh != value)
                    {
                        this.OnPropertyChanging("Fh");  
                        this.fh = value;                        
                        this.OnPropertyChanged("Fh");
                    }   
                }
        }	
        public double? Fhdx 
        {
            get { return this.fhdx; }
			set	{ 
                  if(this.fhdx != value)
                    {
                        this.OnPropertyChanging("Fhdx");  
                        this.fhdx = value;                        
                        this.OnPropertyChanged("Fhdx");
                    }   
                }
        }	
        public double? Xzjd 
        {
            get { return this.xzjd; }
			set	{ 
                  if(this.xzjd != value)
                    {
                        this.OnPropertyChanging("Xzjd");  
                        this.xzjd = value;                        
                        this.OnPropertyChanged("Xzjd");
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
        
        #region 创建方法
        public  Dxtdldwzj()
        {
            
            this.databaseid=0;
            this.flag=1;
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Dxtdldwzj record = obj as Dxtdldwzj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DXTDLDWZJ,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_WBNR,this.Wbnr);    				
                 command.Parameters.AddWithValue(PARAM_TC,this.Tc);    				
                 command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);    				
                 command.Parameters.AddWithValue(PARAM_FH,this.Fh);    				
                 command.Parameters.AddWithValue(PARAM_FHDX,this.Fhdx);    				
                 command.Parameters.AddWithValue(PARAM_XZJD,this.Xzjd);    				
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DXTDLDWZJ,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_WBNR,this.Wbnr);  
				command.Parameters.AddWithValue(PARAM_TC,this.Tc);  
				command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);  
				command.Parameters.AddWithValue(PARAM_FH,this.Fh);  
				command.Parameters.AddWithValue(PARAM_FHDX,this.Fhdx);  
				command.Parameters.AddWithValue(PARAM_XZJD,this.Xzjd);  
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
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DXTDLDWZJ,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_DXTDLDWZJ,connection))
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