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
    public partial class Djq:INotifyPropertyChanging,INotifyPropertyChanged,IDatabaseFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"YSDM",false},{"DJQDM",false},{"DJQMC",true},{"WX_DCY",true},{"WX_DCSJ",false},{"WX_CLY",true},{"WX_CLSJ",false},{"WX_ZTY",true},{"WX_ZTSJ",false},{"WX_ZJY",true},{"WX_ZJSJ",false},{"WX_WYDM",false},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false},{"geometry",false}};
        public const string TABLE_NAME = "DJQ";
        public const string LAYER_NAME="地籍区";
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polygon;
	    public const string COL_ID = "Id";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_DJQDM = "DJQDM";
	    public const string COL_DJQMC = "DJQMC";
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
        public const string PARAM_DJQDM = "@DJQDM";
        public const string PARAM_DJQMC = "@DJQMC";
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
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_DJQ = "INSERT INTO DJQ (YSDM, DJQDM, DJQMC, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @DJQDM, @DJQMC, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_DJQ = "UPDATE DJQ SET YSDM = @YSDM, DJQDM = @DJQDM, DJQMC = @DJQMC, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_DJQ = "DELETE FROM DJQ WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_DJQ = "UPDATE DJQ Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 要素代码
		protected string ysdm = default(string);
        /// 地籍区代码
		protected string djqdm = default(string);
        /// 地籍区名称
		protected string djqmc = default(string);
        /// 调查员
		protected string wxDcy = default(string);
        /// 调查时间
		protected System.DateTime? wxDcsj = default(System.DateTime?);
        /// 测量员
		protected string wxCly = default(string);
        /// 测量时间
		protected System.DateTime? wxClsj = default(System.DateTime?);
        /// 制图员
		protected string wxZty = default(string);
        /// 制图时间
		protected System.DateTime? wxZtsj = default(System.DateTime?);
        /// 质检员
		protected string wxZjy = default(string);
        /// 质检时间
		protected System.DateTime? wxZjsj = default(System.DateTime?);
        /// 唯一代码
		protected System.Guid? wxWydm = default(System.Guid?);
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
        protected GeometryType _geometryType=GeometryType.Polygon;
        
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
            get{return "Djq";}
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
                return string.Format("{0} {1} ({2})","DJQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","DJQ",this.id,this.ysdm);
            }
        }        
        #endregion
        #region 字段属性信息
        /// 标识码
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
        /// 要素代码
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
        /// 地籍区代码
        public string Djqdm 
        {
            get { return this.djqdm; }
			set	{ 
                  if(this.djqdm != value)
                    {
                        this.OnPropertyChanging("Djqdm");  
                        this.djqdm= value;                                              
                        this.OnPropertyChanged("Djqdm");
                    }   
                }
        }	
        /// 地籍区名称
        public string Djqmc 
        {
            get { return this.djqmc; }
			set	{ 
                  if(this.djqmc != value)
                    {
                        this.OnPropertyChanging("Djqmc");  
                        this.djqmc= value;                                              
                        this.OnPropertyChanged("Djqmc");
                    }   
                }
        }	
        /// 调查员
        public string WxDcy 
        {
            get { return this.wxDcy; }
			set	{ 
                  if(this.wxDcy != value)
                    {
                        this.OnPropertyChanging("WxDcy");  
                        this.wxDcy= value;                                              
                        this.OnPropertyChanged("WxDcy");
                    }   
                }
        }	
        /// 调查时间
        public System.DateTime? WxDcsj 
        {
            get { return this.wxDcsj; }
			set	{ 
                  if(this.wxDcsj != value)
                    {
                        this.OnPropertyChanging("WxDcsj");  
                        this.wxDcsj= value;                                              
                        this.OnPropertyChanged("WxDcsj");
                    }   
                }
        }	
        /// 测量员
        public string WxCly 
        {
            get { return this.wxCly; }
			set	{ 
                  if(this.wxCly != value)
                    {
                        this.OnPropertyChanging("WxCly");  
                        this.wxCly= value;                                              
                        this.OnPropertyChanged("WxCly");
                    }   
                }
        }	
        /// 测量时间
        public System.DateTime? WxClsj 
        {
            get { return this.wxClsj; }
			set	{ 
                  if(this.wxClsj != value)
                    {
                        this.OnPropertyChanging("WxClsj");  
                        this.wxClsj= value;                                              
                        this.OnPropertyChanged("WxClsj");
                    }   
                }
        }	
        /// 制图员
        public string WxZty 
        {
            get { return this.wxZty; }
			set	{ 
                  if(this.wxZty != value)
                    {
                        this.OnPropertyChanging("WxZty");  
                        this.wxZty= value;                                              
                        this.OnPropertyChanged("WxZty");
                    }   
                }
        }	
        /// 制图时间
        public System.DateTime? WxZtsj 
        {
            get { return this.wxZtsj; }
			set	{ 
                  if(this.wxZtsj != value)
                    {
                        this.OnPropertyChanging("WxZtsj");  
                        this.wxZtsj= value;                                              
                        this.OnPropertyChanged("WxZtsj");
                    }   
                }
        }	
        /// 质检员
        public string WxZjy 
        {
            get { return this.wxZjy; }
			set	{ 
                  if(this.wxZjy != value)
                    {
                        this.OnPropertyChanging("WxZjy");  
                        this.wxZjy= value;                                              
                        this.OnPropertyChanged("WxZjy");
                    }   
                }
        }	
        /// 质检时间
        public System.DateTime? WxZjsj 
        {
            get { return this.wxZjsj; }
			set	{ 
                  if(this.wxZjsj != value)
                    {
                        this.OnPropertyChanging("WxZjsj");  
                        this.wxZjsj= value;                                              
                        this.OnPropertyChanged("WxZjsj");
                    }   
                }
        }	
        /// 唯一代码
        public System.Guid? WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm");  
                        this.wxWydm= value;                                              
                        this.OnPropertyChanged("WxWydm");
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
        public  Djq()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.ysdm="1002000000";
            this.djqdm="";
            this.djqmc="";
            this.wxDcy="";
            this.wxDcsj=DateTime.Now;
            this.wxCly="";
            this.wxClsj=DateTime.Now;
            this.wxZty="";
            this.wxZtsj=DateTime.Now;
            this.wxZjy="";
            this.wxZjsj=DateTime.Now;
            this.wxWydm=Guid.NewGuid();
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Djq record = obj as Djq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_DJQ,dao.Connection))
            {
                this.databaseid=0;
                this.flag=1;
                command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
                command.Parameters.AddWithValue(PARAM_DJQDM,this.Djqdm);
                command.Parameters.AddWithValue(PARAM_DJQMC,this.Djqmc);
                command.Parameters.AddWithValue(PARAM_WX_DCY,this.WxDcy);
                command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);
                command.Parameters.AddWithValue(PARAM_WX_CLY,this.WxCly);
                command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);
                command.Parameters.AddWithValue(PARAM_WX_ZTY,this.WxZty);
                command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);
                command.Parameters.AddWithValue(PARAM_WX_ZJY,this.WxZjy);
                command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);
                command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_DJQ,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_DJQDM,this.Djqdm);
				command.Parameters.AddWithValue(PARAM_DJQMC,EncodingHelper.String2Unicode(this.Djqmc));
				command.Parameters.AddWithValue(PARAM_WX_DCY,EncodingHelper.String2Unicode(this.WxDcy));
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY,EncodingHelper.String2Unicode(this.WxCly));
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY,EncodingHelper.String2Unicode(this.WxZty));
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY,EncodingHelper.String2Unicode(this.WxZjy));
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_DJQ,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_DJQ,dao.Connection))
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