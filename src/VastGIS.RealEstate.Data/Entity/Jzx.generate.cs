
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
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;


namespace VastGIS.RealEstate.Data.Entity
{
    public partial class Jzx : INotifyPropertyChanging, INotifyPropertyChanged,ISurveyFeature,IYsdmEntity,IGlobalEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "JZX";	
        public const string LAYER_NAME = "界址线";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polyline;
     
		public const string COL_ID = "Id";
		public const string COL_ZDZHDM = "ZDZHDM";
		public const string COL_YSDM = "YSDM";
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
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		public const string COL_GEOMETRY = "geometry";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_ZDZHDM = "@ZDZHDM";	
        public const string PARAM_YSDM = "@YSDM";	
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
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
        public const string PARAM_GEOMETRY = "@geometry";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_JZX ="SELECT  Id,ZDZHDM,YSDM,JZXCD,JZXLB,JZXWZ,JXXZ,QSJXXYSBH,QSJXXYS,QSZYYYSBH,QSZYYYS,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM JZX WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_JZX = "INSERT INTO [JZX] (ZDZHDM, YSDM, JZXCD, JZXLB, JZXWZ, JXXZ, QSJXXYSBH, QSJXXYS, QSZYYYSBH, QSZYYYS, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @ZDZHDM, @YSDM, @JZXCD, @JZXLB, @JZXWZ, @JXXZ, @QSJXXYSBH, @QSJXXYS, @QSZYYYSBH, @QSZYYYS, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_JZX = "UPDATE [JZX] SET ZDZHDM = @ZDZHDM, YSDM = @YSDM, JZXCD = @JZXCD, JZXLB = @JZXLB, JZXWZ = @JZXWZ, JXXZ = @JXXZ, QSJXXYSBH = @QSJXXYSBH, QSJXXYS = @QSJXXYS, QSZYYYSBH = @QSZYYYSBH, QSZYYYS = @QSZYYYS, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_JZX = "DELETE FROM [JZX] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_JZX = "UPDATE [JZX] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///宗地/宗海代码
		protected string zdzhdm = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///界址线长度
		protected double? jzxcd = default(double?);
        ///界址线类别[字典:界址线类别字典表-JZXLBZD]
		protected string jzxlb = default(string);
        ///界址线位置[字典:界址线位置字典表-JZXWZZD]
		protected string jzxwz = default(string);
        ///界线性质[字典:界线性质字典表-JXXZZD]
		protected string jxxz = default(string);
        ///权属界线协议书编号
		protected string qsjxxysbh = default(string);
        ///权属界线协议书
		protected byte[] qsjxxys = default(byte[]);
        ///权属争议原由书编号
		protected string qszyyysbh = default(string);
        ///权属争议原由书
		protected byte[] qszyyys = default(byte[]);
        ///调查员
		protected string wxDcy = default(string);
        ///调查时间
		protected System.DateTime? wxDcsj = default(System.DateTime?);
        ///测量员
		protected string wxCly = default(string);
        ///测量时间
		protected System.DateTime? wxClsj = default(System.DateTime?);
        ///制图员
		protected string wxZty = default(string);
        ///制图时间
		protected System.DateTime? wxZtsj = default(System.DateTime?);
        ///质检员
		protected string wxZjy = default(string);
        ///质检时间
		protected System.DateTime? wxZjsj = default(System.DateTime?);
        ///全局唯一代码
		protected string wxWydm = default(string);
        ///原数据库内序号
		protected long? databaseid = default(long?);
        ///修改标记
		protected short? flags = default(short?);
        ///修改人
		protected string xgr = default(string);
        ///修改时间
		protected System.DateTime? xgsj = default(System.DateTime?);
        ///图形对象
        protected IGeometry _geometry;
        ///WKT字段
        protected string _wkt=default(string);
        
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
        
        #region IEntity 属性
         //对应数据库内表名称
        public string ObjectName
        {
            get{return "Jzx";}
        }
         public string LayerName
        {
            get{return "界址线";}
        }
        public string EntityName{
            get{return "ISurveyFeature,IYsdmEntity,IGlobalEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return true;}}
        public bool HasSurvey{get{return true;}}
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
                return string.Format("{0} {1} ({2})","界址线",this.id,this.ysdm);
            }
        }        
        #endregion
        
        #region 对象属性
        ///标识码
        ///[Column(COL_ID, PARAM_ID, default(long))]
        public virtual long ID 
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
		
        ///宗地/宗海代码
        ///[Column(COL_ZDZHDM, PARAM_ZDZHDM )]
        public virtual string Zdzhdm 
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
		
        ///要素代码
        ///[Column(COL_YSDM, PARAM_YSDM )]
        public virtual string Ysdm 
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
		
        ///界址线长度
        ///[Column(COL_JZXCD, PARAM_JZXCD )]
        public virtual double? Jzxcd 
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
		
        ///界址线类别
        ///[Column(COL_JZXLB, PARAM_JZXLB )]
        public virtual string Jzxlb 
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
		
        ///界址线位置
        ///[Column(COL_JZXWZ, PARAM_JZXWZ )]
        public virtual string Jzxwz 
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
		
        ///界线性质
        ///[Column(COL_JXXZ, PARAM_JXXZ )]
        public virtual string Jxxz 
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
		
        ///权属界线协议书编号
        ///[Column(COL_QSJXXYSBH, PARAM_QSJXXYSBH )]
        public virtual string Qsjxxysbh 
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
		
        ///权属界线协议书
        ///[Column(COL_QSJXXYS, PARAM_QSJXXYS )]
        public virtual byte[] Qsjxxys 
        {
            get { return this.qsjxxys; }
			set	{ 
                  if(this.qsjxxys != value)
                    {
                        this.OnPropertyChanging("Qsjxxys"); 
                        this.qsjxxys = value;                        
                        this.OnPropertyChanged("Qsjxxys");
                    }   
                }
        }	
		
        ///权属争议原由书编号
        ///[Column(COL_QSZYYYSBH, PARAM_QSZYYYSBH )]
        public virtual string Qszyyysbh 
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
		
        ///权属争议原由书
        ///[Column(COL_QSZYYYS, PARAM_QSZYYYS )]
        public virtual byte[] Qszyyys 
        {
            get { return this.qszyyys; }
			set	{ 
                  if(this.qszyyys != value)
                    {
                        this.OnPropertyChanging("Qszyyys"); 
                        this.qszyyys = value;                        
                        this.OnPropertyChanged("Qszyyys");
                    }   
                }
        }	
		
        ///调查员
        ///[Column(COL_WX_DCY, PARAM_WX_DCY )]
        public virtual string WxDcy 
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
		
        ///调查时间
        ///[Column(COL_WX_DCSJ, PARAM_WX_DCSJ )]
        public virtual System.DateTime? WxDcsj 
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
		
        ///测量员
        ///[Column(COL_WX_CLY, PARAM_WX_CLY )]
        public virtual string WxCly 
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
		
        ///测量时间
        ///[Column(COL_WX_CLSJ, PARAM_WX_CLSJ )]
        public virtual System.DateTime? WxClsj 
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
		
        ///制图员
        ///[Column(COL_WX_ZTY, PARAM_WX_ZTY )]
        public virtual string WxZty 
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
		
        ///制图时间
        ///[Column(COL_WX_ZTSJ, PARAM_WX_ZTSJ )]
        public virtual System.DateTime? WxZtsj 
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
		
        ///质检员
        ///[Column(COL_WX_ZJY, PARAM_WX_ZJY )]
        public virtual string WxZjy 
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
		
        ///质检时间
        ///[Column(COL_WX_ZJSJ, PARAM_WX_ZJSJ )]
        public virtual System.DateTime? WxZjsj 
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
		
        ///全局唯一代码
        ///[Column(COL_WX_WYDM, PARAM_WX_WYDM )]
        public virtual string WxWydm 
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
		
        ///原数据库内序号
        ///[Column(COL_DATABASEID, PARAM_DATABASEID )]
        public virtual long? DatabaseID 
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
		
        ///修改标记
        ///[Column(COL_FLAGS, PARAM_FLAGS )]
        public virtual short? Flags 
        {
            get { return this.flags; }
			set	{ 
                  if(this.flags != value)
                    {
                        this.OnPropertyChanging("Flags"); 
                        this.flags = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
		
        ///修改人
        ///[Column(COL_XGR, PARAM_XGR )]
        public virtual string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr"); 
                        this.xgr = value;                        
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
		
        ///修改时间
        ///[Column(COL_XGSJ, PARAM_XGSJ )]
        public virtual System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj"); 
                        this.xgsj = value;                        
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
        }	
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
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
        public Jzx()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.zdzhdm="";
            this.ysdm="";
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
            this.wxWydm=Guid.NewGuid().ToString();
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
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
        
		
		
		public long Create(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_JZX,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_ZDZHDM, this.Zdzhdm);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_JZXCD, this.Jzxcd);
				command.Parameters.AddWithValue(PARAM_JZXLB, this.Jzxlb);
				command.Parameters.AddWithValue(PARAM_JZXWZ, this.Jzxwz);
				command.Parameters.AddWithValue(PARAM_JXXZ, this.Jxxz);
				command.Parameters.AddWithValue(PARAM_QSJXXYSBH, this.Qsjxxysbh);
				command.Parameters.AddWithValue(PARAM_QSJXXYS, this.Qsjxxys);
				command.Parameters.AddWithValue(PARAM_QSZYYYSBH, this.Qszyyysbh);
				command.Parameters.AddWithValue(PARAM_QSZYYYS, this.Qszyyys);
				command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
				command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
				command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_JZX,dao.Connection))
            {
                if(this.databaseid>0)
                {
                    this.flags=2;
                }
                else
                {
                    this.flags=1;
                }
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now; 
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_ZDZHDM, this.Zdzhdm);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_JZXCD, this.Jzxcd);
				command.Parameters.AddWithValue(PARAM_JZXLB, this.Jzxlb);
				command.Parameters.AddWithValue(PARAM_JZXWZ, this.Jzxwz);
				command.Parameters.AddWithValue(PARAM_JXXZ, this.Jxxz);
				command.Parameters.AddWithValue(PARAM_QSJXXYSBH, this.Qsjxxysbh);
				command.Parameters.AddWithValue(PARAM_QSJXXYS, this.Qsjxxys);
				command.Parameters.AddWithValue(PARAM_QSZYYYSBH, this.Qszyyysbh);
				command.Parameters.AddWithValue(PARAM_QSZYYYS, this.Qszyyys);
				command.Parameters.AddWithValue(PARAM_WX_DCY, this.WxDcy);
				command.Parameters.AddWithValue(PARAM_WX_DCSJ, this.WxDcsj);
				command.Parameters.AddWithValue(PARAM_WX_CLY, this.WxCly);
				command.Parameters.AddWithValue(PARAM_WX_CLSJ, this.WxClsj);
				command.Parameters.AddWithValue(PARAM_WX_ZTY, this.WxZty);
				command.Parameters.AddWithValue(PARAM_WX_ZTSJ, this.WxZtsj);
				command.Parameters.AddWithValue(PARAM_WX_ZJY, this.WxZjy);
				command.Parameters.AddWithValue(PARAM_WX_ZJSJ, this.WxZjsj);
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
				command.Parameters.AddWithValue(PARAM_DATABASEID, this.DatabaseID);
				command.Parameters.AddWithValue(PARAM_FLAGS, this.Flags);
				command.Parameters.AddWithValue(PARAM_XGR, this.Xgr);
				command.Parameters.AddWithValue(PARAM_XGSJ, this.Xgsj);
                command.Parameters.AddWithValue(PARAM_GEOMETRY,this._wkt);
                command.Parameters.AddWithValue("@SRID",dao.GetSRID());
			   
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
         public bool Save(ISQLiteService dao)
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
        
        public bool Delete(ISQLiteService dao)
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
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) zdzhdm = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) jzxcd = reader.GetDouble(3);
			if (!reader.IsDBNull(4)) jzxlb = reader.GetString(4);
			if (!reader.IsDBNull(5)) jzxwz = reader.GetString(5);
			if (!reader.IsDBNull(6)) jxxz = reader.GetString(6);
			if (!reader.IsDBNull(7)) qsjxxysbh = reader.GetString(7);
			if (!reader.IsDBNull(8)) qsjxxys = SQLiteHelper.GetBytes(reader,"QSJXXYS");
			if (!reader.IsDBNull(9)) qszyyysbh = reader.GetString(9);
			if (!reader.IsDBNull(10)) qszyyys = SQLiteHelper.GetBytes(reader,"QSZYYYS");
			if (!reader.IsDBNull(11)) wxDcy = reader.GetString(11);
			if (!reader.IsDBNull(12)) wxDcsj = reader.GetDateTime(12);
			if (!reader.IsDBNull(13)) wxCly = reader.GetString(13);
			if (!reader.IsDBNull(14)) wxClsj = reader.GetDateTime(14);
			if (!reader.IsDBNull(15)) wxZty = reader.GetString(15);
			if (!reader.IsDBNull(16)) wxZtsj = reader.GetDateTime(16);
			if (!reader.IsDBNull(17)) wxZjy = reader.GetString(17);
			if (!reader.IsDBNull(18)) wxZjsj = reader.GetDateTime(18);
			if (!reader.IsDBNull(19)) wxWydm = reader.GetString(19);
			if (!reader.IsDBNull(20)) databaseid = reader.GetInt64(20);
			if (!reader.IsDBNull(21)) flags = reader.GetInt16(21);
			if (!reader.IsDBNull(22)) xgr = reader.GetString(22);
			if (!reader.IsDBNull(23)) xgsj = reader.GetDateTime(23);
			if (!reader.IsDBNull(24)) this.Wkt=reader.GetString(24);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Jzx target=new Jzx();
            target.ID=0;
            target.Zdzhdm=this.Zdzhdm;
            target.Ysdm=this.Ysdm;
            target.Jzxcd=this.Jzxcd;
            target.Jzxlb=this.Jzxlb;
            target.Jzxwz=this.Jzxwz;
            target.Jxxz=this.Jxxz;
            target.Qsjxxysbh=this.Qsjxxysbh;
            target.Qsjxxys=this.Qsjxxys;
            target.Qszyyysbh=this.Qszyyysbh;
            target.Qszyyys=this.Qszyyys;
            target.WxDcy=this.WxDcy;
            target.WxDcsj=this.WxDcsj;
            target.WxCly=this.WxCly;
            target.WxClsj=this.WxClsj;
            target.WxZty=this.WxZty;
            target.WxZtsj=this.WxZtsj;
            target.WxZjy=this.WxZjy;
            target.WxZjsj=this.WxZjsj;
            target.WxWydm=Guid.NewGuid().ToString();
            target.DatabaseID=0;
            target.Flags=1;
            target.Xgr=Environment.UserName;
            target.Xgsj=DateTime.Now;
            target.Wkt=this._wkt;
            return target as IEntity;
           
        }
        ///从另外一个不知名的Entity中获得属性字段
        public void CopyProperties(IEntity sourceEntity)
        {
            Reflection.CopyProperties(sourceEntity,this);
        }
        #endregion
		
        
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
