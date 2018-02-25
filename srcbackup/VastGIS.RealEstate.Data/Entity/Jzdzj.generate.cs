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
using VastGIS.Shared;

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class Jzdzj:INotifyPropertyChanging,INotifyPropertyChanged,IDatabaseFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"GLYSBH",false},{"YSDM",false},{"ZJNR",true},{"ZT",true},{"YS",false},{"BS",false},{"XZ",false},{"XHX",false},{"KD",false},{"GD",false},{"ZJDZXJXZB",false},{"ZJDZXJYZB",false},{"ZJFX",false},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false},{"geometry",false}};
        public const string TABLE_NAME = "JZDZJ";
        public const string LAYER_NAME="界址点注记";
        public const GeometryType GEOMETRY_TYPE=GeometryType.Point;
	    public const string COL_ID = "Id";
	    public const string COL_GLYSBH = "GLYSBH";
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
	    public const string COL_XGR = "XGR";
	    public const string COL_XGSJ = "XGSJ";
	    public const string COL_GEOMETRY = "geometry";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_GLYSBH = "@GLYSBH";
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
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_JZDZJ = "INSERT INTO JZDZJ (GLYSBH, YSDM, ZJNR, ZT, YS, BS, XZ, XHX, KD, GD, ZJDZXJXZB, ZJDZXJYZB, ZJFX, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @GLYSBH, @YSDM, @ZJNR, @ZT, @YS, @BS, @XZ, @XHX, @KD, @GD, @ZJDZXJXZB, @ZJDZXJYZB, @ZJFX, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_JZDZJ = "UPDATE JZDZJ SET GLYSBH = @GLYSBH, YSDM = @YSDM, ZJNR = @ZJNR, ZT = @ZT, YS = @YS, BS = @BS, XZ = @XZ, XHX = @XHX, KD = @KD, GD = @GD, ZJDZXJXZB = @ZJDZXJXZB, ZJDZXJYZB = @ZJDZXJYZB, ZJFX = @ZJFX, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_JZDZJ = "DELETE FROM JZDZJ WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_JZDZJ = "UPDATE JZDZJ Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// ID
		protected long id = default(long);
        /// GLYSBH
		protected string glysbh = default(string);
        /// YSDM
		protected string ysdm = default(string);
        /// ZJNR
		protected string zjnr = default(string);
        /// ZT
		protected string zt = default(string);
        /// YS
		protected string y = default(string);
        /// BS
		protected long? b = default(long?);
        /// XZ
		protected string xz = default(string);
        /// XHX
		protected string xhx = default(string);
        /// KD
		protected double? kd = default(double?);
        /// GD
		protected double? gd = default(double?);
        /// ZJDZXJXZB
		protected double? zjdzxjxzb = default(double?);
        /// ZJDZXJYZB
		protected double? zjdzxjyzb = default(double?);
        /// ZJFX
		protected double? zjfx = default(double?);
        /// 源数据库内序号
		protected long? databaseid = default(long?);
        /// 修改标记
		protected short? flag = default(short?);
        /// XGR
		protected string xgr = default(string);
        /// XGSJ
		protected System.DateTime? xgsj = default(System.DateTime?);
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        ///图形对象字段
        protected GeometryType _geometryType=GeometryType.Point;
		protected Jzd jzdRef;	
        
        private event PropertyChangingEventHandler propertyChanging;            
        private event PropertyChangedEventHandler propertyChanged;
        #endregion
        
        #region 事件属性
    
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
        #endregion
        
        #region IEntity属性
        //对应数据库内表名称
        public string ObjectName
        {
            get{return "Jzdzj";}
        }
        public string EntityName{
            get{return "DatabaseFeature";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZDZJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZDZJ",this.id,this.ysdm);
            }
        }        
        #endregion
        #region 字段属性信息
        /// ID
        public long ID 
        {
            get { return this.id; }
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID");  
                        this.id= value;                                              
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
        /// GLYSBH
        public string Glysbh 
        {
            get { return this.glysbh; }
			set	{ 
                  if(this.glysbh != value)
                    {
                        this.OnPropertyChanging("Glysbh");  
                        this.glysbh= value;                                              
                        this.OnPropertyChanged("Glysbh");
                    }   
                }
        }	
        /// YSDM
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm= value;                                              
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        /// ZJNR
        public string Zjnr 
        {
            get { return this.zjnr; }
			set	{ 
                  if(this.zjnr != value)
                    {
                        this.OnPropertyChanging("Zjnr");  
                        this.zjnr= value;                                              
                        this.OnPropertyChanged("Zjnr");
                    }   
                }
        }	
        /// ZT
        public string Zt 
        {
            get { return this.zt; }
			set	{ 
                  if(this.zt != value)
                    {
                        this.OnPropertyChanging("Zt");  
                        this.zt= value;                                              
                        this.OnPropertyChanged("Zt");
                    }   
                }
        }	
        /// YS
        public string Ys 
        {
            get { return this.y; }
			set	{ 
                  if(this.y != value)
                    {
                        this.OnPropertyChanging("Ys");  
                        this.y= value;                                              
                        this.OnPropertyChanged("Ys");
                    }   
                }
        }	
        /// BS
        public long? Bs 
        {
            get { return this.b; }
			set	{ 
                  if(this.b != value)
                    {
                        this.OnPropertyChanging("Bs");  
                        this.b= value;                                              
                        this.OnPropertyChanged("Bs");
                    }   
                }
        }	
        /// XZ
        public string Xz 
        {
            get { return this.xz; }
			set	{ 
                  if(this.xz != value)
                    {
                        this.OnPropertyChanging("Xz");  
                        this.xz= value;                                              
                        this.OnPropertyChanged("Xz");
                    }   
                }
        }	
        /// XHX
        public string Xhx 
        {
            get { return this.xhx; }
			set	{ 
                  if(this.xhx != value)
                    {
                        this.OnPropertyChanging("Xhx");  
                        this.xhx= value;                                              
                        this.OnPropertyChanged("Xhx");
                    }   
                }
        }	
        /// KD
        public double? Kd 
        {
            get { return this.kd; }
			set	{ 
                  if(this.kd != value)
                    {
                        this.OnPropertyChanging("Kd");  
                        this.kd= value;                                              
                        this.OnPropertyChanged("Kd");
                    }   
                }
        }	
        /// GD
        public double? Gd 
        {
            get { return this.gd; }
			set	{ 
                  if(this.gd != value)
                    {
                        this.OnPropertyChanging("Gd");  
                        this.gd= value;                                              
                        this.OnPropertyChanged("Gd");
                    }   
                }
        }	
        /// ZJDZXJXZB
        public double? Zjdzxjxzb 
        {
            get { return this.zjdzxjxzb; }
			set	{ 
                  if(this.zjdzxjxzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjxzb");  
                        this.zjdzxjxzb= value;                                              
                        this.OnPropertyChanged("Zjdzxjxzb");
                    }   
                }
        }	
        /// ZJDZXJYZB
        public double? Zjdzxjyzb 
        {
            get { return this.zjdzxjyzb; }
			set	{ 
                  if(this.zjdzxjyzb != value)
                    {
                        this.OnPropertyChanging("Zjdzxjyzb");  
                        this.zjdzxjyzb= value;                                              
                        this.OnPropertyChanged("Zjdzxjyzb");
                    }   
                }
        }	
        /// ZJFX
        public double? Zjfx 
        {
            get { return this.zjfx; }
			set	{ 
                  if(this.zjfx != value)
                    {
                        this.OnPropertyChanging("Zjfx");  
                        this.zjfx= value;                                              
                        this.OnPropertyChanged("Zjfx");
                    }   
                }
        }	
        /// 源数据库内序号
        public long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID");  
                        this.databaseid= value;                                              
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
        /// 修改标记
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag= value;                                              
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        /// XGR
        public string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr");  
                        this.xgr= value;                                              
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
        /// XGSJ
        public System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj");  
                        this.xgsj= value;                                              
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
        }	
        ///图形对象
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
        ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        ///WKT字段
        public string Wkt
        {
            get{return _wkt;}
            set{
               this.OnPropertyChanging("Geometry");  
                _wkt=value;               
                _geometry.ImportFromWkt(_wkt);
                this.OnPropertyChanged("Geometry"); 
            }
        }
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  Jzdzj()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.glysbh="";
            this.ysdm="6001080000";
            this.zjnr="";
            this.zt="";
            this.y="";
            this.b=0;
            this.xz="";
            this.xhx="";
            this.kd=0.0;
            this.gd=0.0;
            this.zjdzxjxzb=0.0;
            this.zjdzxjyzb=0.0;
            this.zjfx=0.0;
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Jzdzj record = obj as Jzdzj;           
            
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
        
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZDZJ,dao.Connection))
            {
                this.databaseid=0;
                this.flag=1;
                command.Parameters.AddWithValue(PARAM_GLYSBH,this.Glysbh);
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
                command.Parameters.AddWithValue(PARAM_DATABASEID,0);
                this.flag=1;command.Parameters.AddWithValue(PARAM_FLAGS,1);
                command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
                command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZDZJ,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_GLYSBH,this.Glysbh);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZJNR,EncodingHelper.String2Unicode(this.Zjnr));
				command.Parameters.AddWithValue(PARAM_ZT,EncodingHelper.String2Unicode(this.Zt));
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
				this.flag = (short?)(this.databaseid > 0 ? 2 :1);command.Parameters.AddWithValue(PARAM_FLAGS,this.flag);
				command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
				command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
				command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(ISQLiteDao dao)
        {
            if(this.id == default(long))
            {
                return Create(dao)>0;
            }
            else
            {
                return Update(dao);
            }
            
        }        
        

		public bool Delete(ISQLiteDao dao)
        {
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_JZDZJ,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_JZDZJ,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                    command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
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