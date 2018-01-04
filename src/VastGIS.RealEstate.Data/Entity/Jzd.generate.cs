using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Jzd:INotifyPropertyChanging, INotifyPropertyChanged,IBackEntity,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "JZD";
	    public const string COL_ID = "Id";
	    public const string COL_ZDZHDM = "ZDZHDM";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_JZDH = "JZDH";
	    public const string COL_SXH = "SXH";
	    public const string COL_JBLX = "JBLX";
	    public const string COL_JZDLX = "JZDLX";
	    public const string COL_XZBZ = "XZBZ";
	    public const string COL_YZBZ = "YZBZ";
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
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDZHDM = "@ZDZHDM";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_JZDH = "@JZDH";
        public const string PARAM_SXH = "@SXH";
        public const string PARAM_JBLX = "@JBLX";
        public const string PARAM_JZDLX = "@JZDLX";
        public const string PARAM_XZBZ = "@XZBZ";
        public const string PARAM_YZBZ = "@YZBZ";
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
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_JZD = "INSERT INTO JZD (ZDZHDM, YSDM, JZDH, SXH, JBLX, JZDLX, XZBZ, YZBZ, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, geometry) VALUES ( @ZDZHDM, @YSDM, @JZDH, @SXH, @JBLX, @JZDLX, @XZBZ, @YZBZ, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_JZD = "UPDATE JZD SET ZDZHDM = @ZDZHDM, YSDM = @YSDM, JZDH = @JZDH, SXH = @SXH, JBLX = @JBLX, JZDLX = @JZDLX, XZBZ = @XZBZ, YZBZ = @YZBZ, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_JZD = "DELETE FROM JZD WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string zdzhdm = default(string);
		protected string ysdm = default(string);
		protected string jzdh = default(string);
		protected long? sxh = default(long?);
		protected string jblx = default(string);
		protected string jzdlx = default(string);
		protected double? xzbz = default(double?);
		protected double? yzbz = default(double?);
		protected string wxDcy = default(string);
		protected System.DateTime? wxDcsj = default(System.DateTime?);
		protected string wxCly = default(string);
		protected System.DateTime? wxClsj = default(System.DateTime?);
		protected string wxZty = default(string);
		protected System.DateTime? wxZtsj = default(System.DateTime?);
		protected string wxZjy = default(string);
		protected System.DateTime? wxZjsj = default(System.DateTime?);
		protected System.Guid wxWydm = default(System.Guid);
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
        public string Zdzhdm 
        {
            get { return this.zdzhdm; }
			set	{ 
                  if(this.zdzhdm != value)
                    {
                        this.OnPropertyChanging("Zdzhdm");  
                        this.zdzhdm = value;                        
                        this.OnPropertyChanged("Zdzhdm");
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
        public string Jzdh 
        {
            get { return this.jzdh; }
			set	{ 
                  if(this.jzdh != value)
                    {
                        this.OnPropertyChanging("Jzdh");  
                        this.jzdh = value;                        
                        this.OnPropertyChanged("Jzdh");
                    }   
                }
        }	
        public long? Sxh 
        {
            get { return this.sxh; }
			set	{ 
                  if(this.sxh != value)
                    {
                        this.OnPropertyChanging("Sxh");  
                        this.sxh = value;                        
                        this.OnPropertyChanged("Sxh");
                    }   
                }
        }	
        public string Jblx 
        {
            get { return this.jblx; }
			set	{ 
                  if(this.jblx != value)
                    {
                        this.OnPropertyChanging("Jblx");  
                        this.jblx = value;                        
                        this.OnPropertyChanged("Jblx");
                    }   
                }
        }	
        public string Jzdlx 
        {
            get { return this.jzdlx; }
			set	{ 
                  if(this.jzdlx != value)
                    {
                        this.OnPropertyChanging("Jzdlx");  
                        this.jzdlx = value;                        
                        this.OnPropertyChanged("Jzdlx");
                    }   
                }
        }	
        public double? Xzbz 
        {
            get { return this.xzbz; }
			set	{ 
                  if(this.xzbz != value)
                    {
                        this.OnPropertyChanging("Xzbz");  
                        this.xzbz = value;                        
                        this.OnPropertyChanged("Xzbz");
                    }   
                }
        }	
        public double? Yzbz 
        {
            get { return this.yzbz; }
			set	{ 
                  if(this.yzbz != value)
                    {
                        this.OnPropertyChanging("Yzbz");  
                        this.yzbz = value;                        
                        this.OnPropertyChanged("Yzbz");
                    }   
                }
        }	
        public string WxDcy 
        {
            get { return this.wxDcy; }
			set	{ 
                  if(this.wxDcy != value)
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
			set	{ 
                  if(this.wxDcsj != value)
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
			set	{ 
                  if(this.wxCly != value)
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
			set	{ 
                  if(this.wxClsj != value)
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
			set	{ 
                  if(this.wxZty != value)
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
			set	{ 
                  if(this.wxZtsj != value)
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
			set	{ 
                  if(this.wxZjy != value)
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
			set	{ 
                  if(this.wxZjsj != value)
                    {
                        this.OnPropertyChanging("WxZjsj");  
                        this.wxZjsj = value;                        
                        this.OnPropertyChanged("WxZjsj");
                    }   
                }
        }	
        public System.Guid WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm");  
                        this.wxWydm = value;                        
                        this.OnPropertyChanged("WxWydm");
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
            Jzd record = obj as Jzd;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZD,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ZDZHDM,this.Zdzhdm);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_JZDH,this.Jzdh);    				
                 command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);    				
                 command.Parameters.AddWithValue(PARAM_JBLX,this.Jblx);    				
                 command.Parameters.AddWithValue(PARAM_JZDLX,this.Jzdlx);    				
                 command.Parameters.AddWithValue(PARAM_XZBZ,this.Xzbz);    				
                 command.Parameters.AddWithValue(PARAM_YZBZ,this.Yzbz);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);    				
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZD,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ZDZHDM,this.Zdzhdm);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_JZDH,this.Jzdh);  
				command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);  
				command.Parameters.AddWithValue(PARAM_JBLX,this.Jblx);  
				command.Parameters.AddWithValue(PARAM_JZDLX,this.Jzdlx);  
				command.Parameters.AddWithValue(PARAM_XZBZ,this.Xzbz);  
				command.Parameters.AddWithValue(PARAM_YZBZ,this.Yzbz);  
				command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);  
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);  
				command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);  
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);  
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);  
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);  
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);  
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_JZD,connection))
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