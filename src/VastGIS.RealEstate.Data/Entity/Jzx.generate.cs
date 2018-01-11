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
    public partial class Jzx:INotifyPropertyChanging, INotifyPropertyChanged,IBackEntity
    {
        #region 表结构
        public const string TABLE_NAME = "JZX";
        public string ObjectName
        {
         get{
                return "JZX";
               }
        }
        public string EntityName{
            get{
                return "Jzx";
               }
        }
        public const string LAYER_NAME="界址线";
	    public const string COL_ID = "Id";
	    public const string COL_ZDZHDM = "ZDZHDM";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_JZXGZBH = "JZXGZBH";
	    public const string COL_JZXCD = "JZXCD";
	    public const string COL_JZXLB = "JZXLB";
	    public const string COL_JZXWZ = "JZXWZ";
	    public const string COL_JXXZ = "JXXZ";
	    public const string COL_QSJXXYSBH = "QSJXXYSBH";
	    public const string COL_QSJXXYS = "QSJXXYS";
	    public const string COL_QSZYYYSBH = "QSZYYYSBH";
	    public const string COL_QSZYYYS = "QSZYYYS";
	    public const string COL_WX_DCY = "WX_DCY";
	    public const string COL_WX_DCSJ = "WX_DCSJ";
	    public const string COL_WX_CLY = "WX_CLY";
	    public const string COL_WX_CLSJ = "WX_CLSJ";
	    public const string COL_WX_ZTY = "WX_ZTY";
	    public const string COL_WX_ZTSJ = "WX_ZTSJ";
	    public const string COL_WX_ZJY = "WX_ZJY";
	    public const string COL_WX_ZJSJ = "WX_ZJSJ";
	    public const string COL_WX_WYDM = "WX_WYDM";
	    public const string COL_QSJZDBH = "QSJZDBH";
	    public const string COL_JZJZDBH = "JZJZDBH";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDZHDM = "@ZDZHDM";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_JZXGZBH = "@JZXGZBH";
        public const string PARAM_JZXCD = "@JZXCD";
        public const string PARAM_JZXLB = "@JZXLB";
        public const string PARAM_JZXWZ = "@JZXWZ";
        public const string PARAM_JXXZ = "@JXXZ";
        public const string PARAM_QSJXXYSBH = "@QSJXXYSBH";
        public const string PARAM_QSJXXYS = "@QSJXXYS";
        public const string PARAM_QSZYYYSBH = "@QSZYYYSBH";
        public const string PARAM_QSZYYYS = "@QSZYYYS";
        public const string PARAM_WX_DCY = "@WX_DCY";
        public const string PARAM_WX_DCSJ = "@WX_DCSJ";
        public const string PARAM_WX_CLY = "@WX_CLY";
        public const string PARAM_WX_CLSJ = "@WX_CLSJ";
        public const string PARAM_WX_ZTY = "@WX_ZTY";
        public const string PARAM_WX_ZTSJ = "@WX_ZTSJ";
        public const string PARAM_WX_ZJY = "@WX_ZJY";
        public const string PARAM_WX_ZJSJ = "@WX_ZJSJ";
        public const string PARAM_WX_WYDM = "@WX_WYDM";
        public const string PARAM_QSJZDBH = "@QSJZDBH";
        public const string PARAM_JZJZDBH = "@JZJZDBH";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_JZX = "INSERT INTO JZX (ZDZHDM, YSDM, JZXGZBH, JZXCD, JZXLB, JZXWZ, JXXZ, QSJXXYSBH, QSJXXYS, QSZYYYSBH, QSZYYYS, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, QSJZDBH, JZJZDBH, DatabaseId, FLAGS, geometry) VALUES ( @ZDZHDM, @YSDM, @JZXGZBH, @JZXCD, @JZXLB, @JZXWZ, @JXXZ, @QSJXXYSBH, @QSJXXYS, @QSZYYYSBH, @QSZYYYS, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @QSJZDBH, @JZJZDBH, @DatabaseId, @FLAGS, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_JZX = "UPDATE JZX SET ZDZHDM = @ZDZHDM, YSDM = @YSDM, JZXGZBH = @JZXGZBH, JZXCD = @JZXCD, JZXLB = @JZXLB, JZXWZ = @JZXWZ, JXXZ = @JXXZ, QSJXXYSBH = @QSJXXYSBH, QSJXXYS = @QSJXXYS, QSZYYYSBH = @QSZYYYSBH, QSZYYYS = @QSZYYYS, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, QSJZDBH = @QSJZDBH, JZJZDBH = @JZJZDBH, DatabaseId = @DatabaseId, FLAGS = @FLAGS, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
	
	    private const string SQL_DELETE_JZX = "DELETE FROM JZX WHERE  Id = @Id ";
        
        private const string SQL_DELETE_FLAG_JZX = "UPDATE JZX Set Flags=3 WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string zdzhdm = default(string);
		protected string ysdm = default(string);
		protected string jzxgzbh = default(string);
		protected double? jzxcd = default(double?);
		protected string jzxlb = default(string);
		protected string jzxwz = default(string);
		protected string jxxz = default(string);
		protected string qsjxxysbh = default(string);
		protected byte[] qsjxxy = default(byte[]);
		protected string qszyyysbh = default(string);
		protected byte[] qszyyy = default(byte[]);
		protected string wxDcy = default(string);
		protected System.DateTime? wxDcsj = default(System.DateTime?);
		protected string wxCly = default(string);
		protected System.DateTime? wxClsj = default(System.DateTime?);
		protected string wxZty = default(string);
		protected System.DateTime? wxZtsj = default(System.DateTime?);
		protected string wxZjy = default(string);
		protected System.DateTime? wxZjsj = default(System.DateTime?);
		protected System.Guid? wxWydm = default(System.Guid?);
		protected string qsjzdbh = default(string);
		protected string jzjzdbh = default(string);
		protected long? databaseid = default(long?);
		protected short? flag = default(short?);
        protected IGeometry _geometry;
        protected string _wkt=default(string);
        protected GeometryType _geometryType=GeometryType.Polyline;
        
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
        public string Jzxgzbh 
        {
            get { return this.jzxgzbh; }
			set	{ 
                  if(this.jzxgzbh != value)
                    {
                        this.OnPropertyChanging("Jzxgzbh");  
                        this.jzxgzbh = value;                        
                        this.OnPropertyChanged("Jzxgzbh");
                    }   
                }
        }	
        public double? Jzxcd 
        {
            get { return this.jzxcd; }
			set	{ 
                  if(this.jzxcd != value)
                    {
                        this.OnPropertyChanging("Jzxcd");  
                        this.jzxcd = value;                        
                        this.OnPropertyChanged("Jzxcd");
                    }   
                }
        }	
        public string Jzxlb 
        {
            get { return this.jzxlb; }
			set	{ 
                  if(this.jzxlb != value)
                    {
                        this.OnPropertyChanging("Jzxlb");  
                        this.jzxlb = value;                        
                        this.OnPropertyChanged("Jzxlb");
                    }   
                }
        }	
        public string Jzxwz 
        {
            get { return this.jzxwz; }
			set	{ 
                  if(this.jzxwz != value)
                    {
                        this.OnPropertyChanging("Jzxwz");  
                        this.jzxwz = value;                        
                        this.OnPropertyChanged("Jzxwz");
                    }   
                }
        }	
        public string Jxxz 
        {
            get { return this.jxxz; }
			set	{ 
                  if(this.jxxz != value)
                    {
                        this.OnPropertyChanging("Jxxz");  
                        this.jxxz = value;                        
                        this.OnPropertyChanged("Jxxz");
                    }   
                }
        }	
        public string Qsjxxysbh 
        {
            get { return this.qsjxxysbh; }
			set	{ 
                  if(this.qsjxxysbh != value)
                    {
                        this.OnPropertyChanging("Qsjxxysbh");  
                        this.qsjxxysbh = value;                        
                        this.OnPropertyChanged("Qsjxxysbh");
                    }   
                }
        }	
        public byte[] Qsjxxys 
        {
            get { return this.qsjxxy; }
			set	{ 
                  if(this.qsjxxy != value)
                    {
                        this.OnPropertyChanging("Qsjxxys");  
                        this.qsjxxy = value;                        
                        this.OnPropertyChanged("Qsjxxys");
                    }   
                }
        }	
        public string Qszyyysbh 
        {
            get { return this.qszyyysbh; }
			set	{ 
                  if(this.qszyyysbh != value)
                    {
                        this.OnPropertyChanging("Qszyyysbh");  
                        this.qszyyysbh = value;                        
                        this.OnPropertyChanged("Qszyyysbh");
                    }   
                }
        }	
        public byte[] Qszyyys 
        {
            get { return this.qszyyy; }
			set	{ 
                  if(this.qszyyy != value)
                    {
                        this.OnPropertyChanging("Qszyyys");  
                        this.qszyyy = value;                        
                        this.OnPropertyChanged("Qszyyys");
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
        public System.Guid? WxWydm 
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
        public string Qsjzdbh 
        {
            get { return this.qsjzdbh; }
			set	{ 
                  if(this.qsjzdbh != value)
                    {
                        this.OnPropertyChanging("Qsjzdbh");  
                        this.qsjzdbh = value;                        
                        this.OnPropertyChanged("Qsjzdbh");
                    }   
                }
        }	
        public string Jzjzdbh 
        {
            get { return this.jzjzdbh; }
			set	{ 
                  if(this.jzjzdbh != value)
                    {
                        this.OnPropertyChanging("Jzjzdbh");  
                        this.jzjzdbh = value;                        
                        this.OnPropertyChanged("Jzjzdbh");
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
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZX",this.id,this.ysdm);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZX",this.id,this.ysdm);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  Jzx()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.ysdm="6001060000";
            this.wxWydm=Guid.NewGuid();
            this.wxDcsj=DateTime.Now;
            this.databaseid=0;
            this.flag=1;
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Jzx record = obj as Jzx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZX,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ZDZHDM,this.Zdzhdm);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_JZXGZBH,this.Jzxgzbh);    				
                 command.Parameters.AddWithValue(PARAM_JZXCD,this.Jzxcd);    				
                 command.Parameters.AddWithValue(PARAM_JZXLB,this.Jzxlb);    				
                 command.Parameters.AddWithValue(PARAM_JZXWZ,this.Jzxwz);    				
                 command.Parameters.AddWithValue(PARAM_JXXZ,this.Jxxz);    				
                 command.Parameters.AddWithValue(PARAM_QSJXXYSBH,this.Qsjxxysbh);    				
                 command.Parameters.AddWithValue(PARAM_QSJXXYS,this.Qsjxxys);    				
                 command.Parameters.AddWithValue(PARAM_QSZYYYSBH,this.Qszyyysbh);    				
                 command.Parameters.AddWithValue(PARAM_QSZYYYS,this.Qszyyys);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);    				
                 command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);    				
                 command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);    				
                 command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);    				
                 command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);    				
                 command.Parameters.AddWithValue(PARAM_QSJZDBH,this.Qsjzdbh);    				
                 command.Parameters.AddWithValue(PARAM_JZJZDBH,this.Jzjzdbh);    				
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZX,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ZDZHDM,this.Zdzhdm);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_JZXGZBH,this.Jzxgzbh);  
				command.Parameters.AddWithValue(PARAM_JZXCD,this.Jzxcd);  
				command.Parameters.AddWithValue(PARAM_JZXLB,this.Jzxlb);  
				command.Parameters.AddWithValue(PARAM_JZXWZ,this.Jzxwz);  
				command.Parameters.AddWithValue(PARAM_JXXZ,this.Jxxz);  
				command.Parameters.AddWithValue(PARAM_QSJXXYSBH,this.Qsjxxysbh);  
				command.Parameters.AddWithValue(PARAM_QSJXXYS,this.Qsjxxys);  
				command.Parameters.AddWithValue(PARAM_QSZYYYSBH,this.Qszyyysbh);  
				command.Parameters.AddWithValue(PARAM_QSZYYYS,this.Qszyyys);  
				command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);  
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);  
				command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);  
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);  
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);  
				command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);  
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);  
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);  
				command.Parameters.AddWithValue(PARAM_QSJZDBH,this.Qsjzdbh);  
				command.Parameters.AddWithValue(PARAM_JZJZDBH,this.Jzjzdbh);  
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_JZX,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_JZX,connection))
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