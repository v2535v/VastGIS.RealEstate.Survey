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
    public partial class Jzx:INotifyPropertyChanging,INotifyPropertyChanged,ISurveyFeature
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZDZHDM",false},{"YSDM",false},{"JZXGZBH",false},{"JZXCD",false},{"JZXLB",false},{"JZXWZ",false},{"JXXZ",false},{"QSJXXYSBH",false},{"QSJXXYS",false},{"QSZYYYSBH",false},{"QSZYYYS",false},{"WX_DCY",true},{"WX_DCSJ",false},{"WX_CLY",true},{"WX_CLSJ",false},{"WX_ZTY",true},{"WX_ZTSJ",false},{"WX_ZJY",true},{"WX_ZJSJ",false},{"WX_WYDM",false},{"QSJZDBH",false},{"JZJZDBH",false},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false},{"geometry",false}};
        public const string TABLE_NAME = "JZX";
        public const string LAYER_NAME="界址线";
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polyline;
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
	    public const string COL_XGR = "XGR";
	    public const string COL_XGSJ = "XGSJ";
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
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
        public const string PARAM_GEOMETRY = "@geometry";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_JZX = "INSERT INTO JZX (ZDZHDM, YSDM, JZXGZBH, JZXCD, JZXLB, JZXWZ, JXXZ, QSJXXYSBH, QSJXXYS, QSZYYYSBH, QSZYYYS, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, QSJZDBH, JZJZDBH, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @ZDZHDM, @YSDM, @JZXGZBH, @JZXCD, @JZXLB, @JZXWZ, @JXXZ, @QSJXXYSBH, @QSJXXYS, @QSZYYYSBH, @QSZYYYS, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @QSJZDBH, @JZJZDBH, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_JZX = "UPDATE JZX SET ZDZHDM = @ZDZHDM, YSDM = @YSDM, JZXGZBH = @JZXGZBH, JZXCD = @JZXCD, JZXLB = @JZXLB, JZXWZ = @JZXWZ, JXXZ = @JXXZ, QSJXXYSBH = @QSJXXYSBH, QSJXXYS = @QSJXXYS, QSZYYYSBH = @QSZYYYSBH, QSZYYYS = @QSZYYYS, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, QSJZDBH = @QSJZDBH, JZJZDBH = @JZJZDBH, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ, geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";	
	    private const string SQL_DELETE_JZX = "DELETE FROM JZX WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_JZX = "UPDATE JZX Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 宗地/宗海代码
		protected string zdzhdm = default(string);
        /// 要素代码
		protected string ysdm = default(string);
        /// JZXGZBH
		protected string jzxgzbh = default(string);
        /// 界址线长度
		protected double? jzxcd = default(double?);
        /// 界址线类别 - 使用字典信息(界址线类别字典表--JZXLBZD)
		protected string jzxlb = default(string);
        /// 界址线位置 - 使用字典信息(界址线位置字典表--JZXWZZD)
		protected string jzxwz = default(string);
        /// 界线性质 - 使用字典信息(界线性质字典表--JXXZZD)
		protected string jxxz = default(string);
        /// 权属界线协议书编号
		protected string qsjxxysbh = default(string);
        /// 权属界线协议书
		protected byte[] qsjxxy = default(byte[]);
        /// 权属争议原由书编号
		protected string qszyyysbh = default(string);
        /// 权属争议原由书
		protected byte[] qszyyy = default(byte[]);
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
        /// QSJZDBH
		protected string qsjzdbh = default(string);
        /// JZJZDBH
		protected string jzjzdbh = default(string);
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
        protected GeometryType _geometryType=GeometryType.Polyline;
        
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
            get{return "Jzx";}
        }
        public string EntityName{
            get{return "SurveyFeature";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZX",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","JZX",this.id,this.ysdm);
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
        /// 宗地/宗海代码
        public string Zdzhdm 
        {
            get { return this.zdzhdm; }
			set	{ 
                  if(this.zdzhdm != value)
                    {
                        this.OnPropertyChanging("Zdzhdm");  
                        this.zdzhdm= value;                                              
                        this.OnPropertyChanged("Zdzhdm");
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
        /// JZXGZBH
        public string Jzxgzbh 
        {
            get { return this.jzxgzbh; }
			set	{ 
                  if(this.jzxgzbh != value)
                    {
                        this.OnPropertyChanging("Jzxgzbh");  
                        this.jzxgzbh= value;                                              
                        this.OnPropertyChanged("Jzxgzbh");
                    }   
                }
        }	
        /// 界址线长度
        public double? Jzxcd 
        {
            get { return this.jzxcd; }
			set	{ 
                  if(this.jzxcd != value)
                    {
                        this.OnPropertyChanging("Jzxcd");  
                        this.jzxcd= value;                                              
                        this.OnPropertyChanged("Jzxcd");
                    }   
                }
        }	
        /// 界址线类别 - 使用字典信息(界址线类别字典表--JZXLBZD)
        public string Jzxlb 
        {
            get { return this.jzxlb; }
			set	{ 
                  if(this.jzxlb != value)
                    {
                        this.OnPropertyChanging("Jzxlb");  
                        this.jzxlb= value;                                              
                        this.OnPropertyChanged("Jzxlb");
                    }   
                }
        }	
        /// 界址线位置 - 使用字典信息(界址线位置字典表--JZXWZZD)
        public string Jzxwz 
        {
            get { return this.jzxwz; }
			set	{ 
                  if(this.jzxwz != value)
                    {
                        this.OnPropertyChanging("Jzxwz");  
                        this.jzxwz= value;                                              
                        this.OnPropertyChanged("Jzxwz");
                    }   
                }
        }	
        /// 界线性质 - 使用字典信息(界线性质字典表--JXXZZD)
        public string Jxxz 
        {
            get { return this.jxxz; }
			set	{ 
                  if(this.jxxz != value)
                    {
                        this.OnPropertyChanging("Jxxz");  
                        this.jxxz= value;                                              
                        this.OnPropertyChanged("Jxxz");
                    }   
                }
        }	
        /// 权属界线协议书编号
        public string Qsjxxysbh 
        {
            get { return this.qsjxxysbh; }
			set	{ 
                  if(this.qsjxxysbh != value)
                    {
                        this.OnPropertyChanging("Qsjxxysbh");  
                        this.qsjxxysbh= value;                                              
                        this.OnPropertyChanged("Qsjxxysbh");
                    }   
                }
        }	
        /// 权属界线协议书
        public byte[] Qsjxxys 
        {
            get { return this.qsjxxy; }
			set	{ 
                  if(this.qsjxxy != value)
                    {
                        this.OnPropertyChanging("Qsjxxys");  
                        this.qsjxxy= value;                                              
                        this.OnPropertyChanged("Qsjxxys");
                    }   
                }
        }	
        /// 权属争议原由书编号
        public string Qszyyysbh 
        {
            get { return this.qszyyysbh; }
			set	{ 
                  if(this.qszyyysbh != value)
                    {
                        this.OnPropertyChanging("Qszyyysbh");  
                        this.qszyyysbh= value;                                              
                        this.OnPropertyChanged("Qszyyysbh");
                    }   
                }
        }	
        /// 权属争议原由书
        public byte[] Qszyyys 
        {
            get { return this.qszyyy; }
			set	{ 
                  if(this.qszyyy != value)
                    {
                        this.OnPropertyChanging("Qszyyys");  
                        this.qszyyy= value;                                              
                        this.OnPropertyChanged("Qszyyys");
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
        /// QSJZDBH
        public string Qsjzdbh 
        {
            get { return this.qsjzdbh; }
			set	{ 
                  if(this.qsjzdbh != value)
                    {
                        this.OnPropertyChanging("Qsjzdbh");  
                        this.qsjzdbh= value;                                              
                        this.OnPropertyChanged("Qsjzdbh");
                    }   
                }
        }	
        /// JZJZDBH
        public string Jzjzdbh 
        {
            get { return this.jzjzdbh; }
			set	{ 
                  if(this.jzjzdbh != value)
                    {
                        this.OnPropertyChanging("Jzjzdbh");  
                        this.jzjzdbh= value;                                              
                        this.OnPropertyChanged("Jzjzdbh");
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
        public  Jzx()
        {
            _geometry=new Geometry(_geometryType,ZValueType.None);
            this.id=0;
            this.zdzhdm="";
            this.ysdm="6001060000";
            this.jzxgzbh="";
            this.jzxcd=0.0;
            this.jzxlb="";
            this.jzxwz="";
            this.jxxz="";
            this.qsjxxysbh="";
            
            this.qszyyysbh="";
            
            this.wxDcy="";
            this.wxDcsj=DateTime.Now;
            this.wxCly="";
            this.wxClsj=DateTime.Now;
            this.wxZty="";
            this.wxZtsj=DateTime.Now;
            this.wxZjy="";
            this.wxZjsj=DateTime.Now;
            this.wxWydm=Guid.NewGuid();
            this.qsjzdbh="";
            this.jzjzdbh="";
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
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
        
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZX,dao.Connection))
            {
                this.databaseid=0;
                this.flag=1;
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZX,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_WX_DCY,EncodingHelper.String2Unicode(this.WxDcy));
				command.Parameters.AddWithValue(PARAM_WX_DCSJ,this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY,EncodingHelper.String2Unicode(this.WxCly));
				command.Parameters.AddWithValue(PARAM_WX_CLSJ,this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY,EncodingHelper.String2Unicode(this.WxZty));
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ,this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY,EncodingHelper.String2Unicode(this.WxZjy));
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ,this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
				command.Parameters.AddWithValue(PARAM_QSJZDBH,this.Qsjzdbh);
				command.Parameters.AddWithValue(PARAM_JZJZDBH,this.Jzjzdbh);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_JZX,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_JZX,dao.Connection))
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