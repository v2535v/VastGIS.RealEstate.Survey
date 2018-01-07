using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Zdjbxxzj:INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "ZDJBXXZJ";
	    public const string COL_ID = "Id";
	    public const string COL_GLYSDM = "GLYSDM";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_ZJNR = "ZJNR";
	    public const string COL_ZT = "ZT";
	    public const string COL_YS = "YS";
	    public const string COL_BS = "BS";
	    public const string COL_XZ = "XZ";
	    public const string COL_XHX = "XHX";
	    public const string COL_KD = "KD";
	    public const string COL_GD = "GD";
	    public const string COL_ZJDZXJXZB = "ZJDZXJXZB";
	    public const string COL_ZJDZXJYZB = "ZJDZXJYZB";
	    public const string COL_ZJFX = "ZJFX";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_GLYSDM = "@GLYSDM";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_ZJNR = "@ZJNR";
        public const string PARAM_ZT = "@ZT";
        public const string PARAM_YS = "@YS";
        public const string PARAM_BS = "@BS";
        public const string PARAM_XZ = "@XZ";
        public const string PARAM_XHX = "@XHX";
        public const string PARAM_KD = "@KD";
        public const string PARAM_GD = "@GD";
        public const string PARAM_ZJDZXJXZB = "@ZJDZXJXZB";
        public const string PARAM_ZJDZXJYZB = "@ZJDZXJYZB";
        public const string PARAM_ZJFX = "@ZJFX";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_ZDJBXXZJ = "INSERT INTO ZDJBXXZJ (GLYSDM, YSDM, ZJNR, ZT, YS, BS, XZ, XHX, KD, GD, ZJDZXJXZB, ZJDZXJYZB, ZJFX, DatabaseId, FLAGS, geometry) VALUES ( @GLYSDM, @YSDM, @ZJNR, @ZT, @YS, @BS, @XZ, @XHX, @KD, @GD, @ZJDZXJXZB, @ZJDZXJYZB, @ZJFX, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_ZDJBXXZJ = "UPDATE ZDJBXXZJ SET GLYSDM = @GLYSDM, YSDM = @YSDM, ZJNR = @ZJNR, ZT = @ZT, YS = @YS, BS = @BS, XZ = @XZ, XHX = @XHX, KD = @KD, GD = @GD, ZJDZXJXZB = @ZJDZXJXZB, ZJDZXJYZB = @ZJDZXJYZB, ZJFX = @ZJFX, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_ZDJBXXZJ = "DELETE FROM ZDJBXXZJ WHERE  Id = @Id ";
        
        private const string SQL_DELETE_FLAG_ZDJBXXZJ = "UPDATE ZDJBXXZJ Set Flags=3 WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string glysdm = default(string);
		protected string ysdm = default(string);
		protected string zjnr = default(string);
		protected string zt = default(string);
		protected string y = default(string);
		protected long? b = default(long?);
		protected string xz = default(string);
		protected string xhx = default(string);
		protected double? kd = default(double?);
		protected double? gd = default(double?);
		protected double? zjdzxjxzb = default(double?);
		protected double? zjdzxjyzb = default(double?);
		protected double? zjfx = default(double?);
		protected long? databaseid = default(long?);
		protected short? flag = default(short?);
        protected IGeometry _geometry;
        protected string _wkt=default(string);
        protected GeometryType _geometryType=GeometryType.Point;
        
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
        public string Glysdm 
        {
            get { return this.glysdm; }
			set	{ 
                  if(this.glysdm != value)
                    {
                        this.OnPropertyChanging("Glysdm");  
                        this.glysdm = value;                        
                        this.OnPropertyChanged("Glysdm");
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
        public string Zjnr 
        {
            get { return this.zjnr; }
			set	{ 
                  if(this.zjnr != value)
                    {
                        this.OnPropertyChanging("Zjnr");  
                        this.zjnr = value;                        
                        this.OnPropertyChanged("Zjnr");
                    }   
                }
        }	
        public string Zt 
        {
            get { return this.zt; }
			set	{ 
                  if(this.zt != value)
                    {
                        this.OnPropertyChanging("Zt");  
                        this.zt = value;                        
                        this.OnPropertyChanged("Zt");
                    }   
                }
        }	
        public string Ys 
        {
            get { return this.y; }
			set	{ 
                  if(this.y != value)
                    {
                        this.OnPropertyChanging("Ys");  
                        this.y = value;                        
                        this.OnPropertyChanged("Ys");
                    }   
                }
        }	
        public long? Bs 
        {
            get { return this.b; }
			set	{ 
                  if(this.b != value)
                    {
                        this.OnPropertyChanging("Bs");  
                        this.b = value;                        
                        this.OnPropertyChanged("Bs");
                    }   
                }
        }	
        public string Xz 
        {
            get { return this.xz; }
			set	{ 
                  if(this.xz != value)
                    {
                        this.OnPropertyChanging("Xz");  
                        this.xz = value;                        
                        this.OnPropertyChanged("Xz");
                    }   
                }
        }	
        public string Xhx 
        {
            get { return this.xhx; }
			set	{ 
                  if(this.xhx != value)
                    {
                        this.OnPropertyChanging("Xhx");  
                        this.xhx = value;                        
                        this.OnPropertyChanged("Xhx");
                    }   
                }
        }	
        public double? Kd 
        {
            get { return this.kd; }
			set	{ 
                  if(this.kd != value)
                    {
                        this.OnPropertyChanging("Kd");  
                        this.kd = value;                        
                        this.OnPropertyChanged("Kd");
                    }   
                }
        }	
        public double? Gd 
        {
            get { return this.gd; }
			set	{ 
                  if(this.gd != value)
                    {
                        this.OnPropertyChanging("Gd");  
                        this.gd = value;                        
                        this.OnPropertyChanged("Gd");
                    }   
                }
        }	
        public double? Zjdzxjxzb 
        {
            get { return this.zjdzxjxzb; }
			set	{ 
                  if(this.zjdzxjxzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjxzb");  
                        this.zjdzxjxzb = value;                        
                        this.OnPropertyChanged("Zjdzxjxzb");
                    }   
                }
        }	
        public double? Zjdzxjyzb 
        {
            get { return this.zjdzxjyzb; }
			set	{ 
                  if(this.zjdzxjyzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjyzb");  
                        this.zjdzxjyzb = value;                        
                        this.OnPropertyChanged("Zjdzxjyzb");
                    }   
                }
        }	
        public double? Zjfx 
        {
            get { return this.zjfx; }
			set	{ 
                  if(this.zjfx != value)
                    {
                        this.OnPropertyChanging("Zjfx");  
                        this.zjfx = value;                        
                        this.OnPropertyChanged("Zjfx");
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
        public IGeometry Geometry
        {
            get{return _geometry;}
            set{
                this.OnPropertyChanging("Geometry");  
                _geometry=value;
                _wkt = _geometry.ExportToWkt();
                this.OnPropertyChanged("Geometry");
                }
        }
        public GeometryType GeometryType
        {
            get{return _geometryType;}
            set{_geometryType=value;}
        }
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;
                //_geometry=DbGeometry.FromText(_wkt);
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  Zdjbxxzj()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.ysdm="'6001080000'";
            this.databaseid=0;
            this.flag=1;
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Zdjbxxzj record = obj as Zdjbxxzj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDJBXXZJ,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_GLYSDM,this.Glysdm);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_ZJNR,this.Zjnr);    				
                 command.Parameters.AddWithValue(PARAM_ZT,this.Zt);    				
                 command.Parameters.AddWithValue(PARAM_YS,this.Ys);    				
                 command.Parameters.AddWithValue(PARAM_BS,this.Bs);    				
                 command.Parameters.AddWithValue(PARAM_XZ,this.Xz);    				
                 command.Parameters.AddWithValue(PARAM_XHX,this.Xhx);    				
                 command.Parameters.AddWithValue(PARAM_KD,this.Kd);    				
                 command.Parameters.AddWithValue(PARAM_GD,this.Gd);    				
                 command.Parameters.AddWithValue(PARAM_ZJDZXJXZB,this.Zjdzxjxzb);    				
                 command.Parameters.AddWithValue(PARAM_ZJDZXJYZB,this.Zjdzxjyzb);    				
                 command.Parameters.AddWithValue(PARAM_ZJFX,this.Zjfx);    				
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDJBXXZJ,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_GLYSDM,this.Glysdm);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_ZJNR,this.Zjnr);  
				command.Parameters.AddWithValue(PARAM_ZT,this.Zt);  
				command.Parameters.AddWithValue(PARAM_YS,this.Ys);  
				command.Parameters.AddWithValue(PARAM_BS,this.Bs);  
				command.Parameters.AddWithValue(PARAM_XZ,this.Xz);  
				command.Parameters.AddWithValue(PARAM_XHX,this.Xhx);  
				command.Parameters.AddWithValue(PARAM_KD,this.Kd);  
				command.Parameters.AddWithValue(PARAM_GD,this.Gd);  
				command.Parameters.AddWithValue(PARAM_ZJDZXJXZB,this.Zjdzxjxzb);  
				command.Parameters.AddWithValue(PARAM_ZJDZXJYZB,this.Zjdzxjyzb);  
				command.Parameters.AddWithValue(PARAM_ZJFX,this.Zjfx);  
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDJBXXZJ,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZDJBXXZJ,connection))
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