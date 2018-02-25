
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
    public partial class Zhjbxx : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseFeature,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "ZHJBXX";	
        public const string LAYER_NAME = "宗海（含无居民海岛）";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.Polygon;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZHDM = "ZHDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_ZHTZM = "ZHTZM";
		public const string COL_XMMC = "XMMC";
		public const string COL_XMXZ = "XMXZ";
		public const string COL_YHZMJ = "YHZMJ";
		public const string COL_ZHMJ = "ZHMJ";
		public const string COL_DB = "DB";
		public const string COL_ZHAX = "ZHAX";
		public const string COL_YHLXA = "YHLXA";
		public const string COL_YHLXB = "YHLXB";
		public const string COL_YHWZSM = "YHWZSM";
		public const string COL_HDMC = "HDMC";
		public const string COL_HDDM = "HDDM";
		public const string COL_YDFW = "YDFW";
		public const string COL_YDMJ = "YDMJ";
		public const string COL_HDWZ = "HDWZ";
		public const string COL_HDYT = "HDYT";
		public const string COL_ZHT = "ZHT";
		public const string COL_DAH = "DAH";
		public const string COL_ZT = "ZT";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		public const string COL_GEOMETRY = "geometry";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZHDM = "@ZHDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_ZHTZM = "@ZHTZM";	
        public const string PARAM_XMMC = "@XMMC";	
        public const string PARAM_XMXZ = "@XMXZ";	
        public const string PARAM_YHZMJ = "@YHZMJ";	
        public const string PARAM_ZHMJ = "@ZHMJ";	
        public const string PARAM_DB = "@DB";	
        public const string PARAM_ZHAX = "@ZHAX";	
        public const string PARAM_YHLXA = "@YHLXA";	
        public const string PARAM_YHLXB = "@YHLXB";	
        public const string PARAM_YHWZSM = "@YHWZSM";	
        public const string PARAM_HDMC = "@HDMC";	
        public const string PARAM_HDDM = "@HDDM";	
        public const string PARAM_YDFW = "@YDFW";	
        public const string PARAM_YDMJ = "@YDMJ";	
        public const string PARAM_HDWZ = "@HDWZ";	
        public const string PARAM_HDYT = "@HDYT";	
        public const string PARAM_ZHT = "@ZHT";	
        public const string PARAM_DAH = "@DAH";	
        public const string PARAM_ZT = "@ZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
        public const string PARAM_GEOMETRY = "@geometry";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_ZHJBXX ="SELECT  Id,YSDM,ZHDM,BDCDYH,ZHTZM,XMMC,XMXZ,YHZMJ,ZHMJ,DB,ZHAX,YHLXA,YHLXB,YHWZSM,HDMC,HDDM,YDFW,YDMJ,HDWZ,HDYT,ZHT,DAH,ZT,DatabaseId,FLAGS,XGR,XGSJ,AsText(geometry) as Wkt FROM ZHJBXX WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_ZHJBXX = "INSERT INTO [ZHJBXX] (YSDM, ZHDM, BDCDYH, ZHTZM, XMMC, XMXZ, YHZMJ, ZHMJ, DB, ZHAX, YHLXA, YHLXB, YHWZSM, HDMC, HDDM, YDFW, YDMJ, HDWZ, HDYT, ZHT, DAH, ZT, DatabaseId, FLAGS, XGR, XGSJ, geometry) VALUES ( @YSDM, @ZHDM, @BDCDYH, @ZHTZM, @XMMC, @XMXZ, @YHZMJ, @ZHMJ, @DB, @ZHAX, @YHLXA, @YHLXB, @YHWZSM, @HDMC, @HDDM, @YDFW, @YDMJ, @HDWZ, @HDYT, @ZHT, @DAH, @ZT, @DatabaseId, @FLAGS, @XGR, @XGSJ, GeomFromText(@geometry,@SRID));" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_ZHJBXX = "UPDATE [ZHJBXX] SET YSDM = @YSDM, ZHDM = @ZHDM, BDCDYH = @BDCDYH, ZHTZM = @ZHTZM, XMMC = @XMMC, XMXZ = @XMXZ, YHZMJ = @YHZMJ, ZHMJ = @ZHMJ, DB = @DB, ZHAX = @ZHAX, YHLXA = @YHLXA, YHLXB = @YHLXB, YHWZSM = @YHWZSM, HDMC = @HDMC, HDDM = @HDDM, YDFW = @YDFW, YDMJ = @YDMJ, HDWZ = @HDWZ, HDYT = @HDYT, ZHT = @ZHT, DAH = @DAH, ZT = @ZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ,  geometry = GeomFromText(@geometry,@SRID) WHERE Id = @Id";
		
		private const string SQL_DELETE_ZHJBXX = "DELETE FROM [ZHJBXX] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_ZHJBXX = "UPDATE [ZHJBXX] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///宗海代码
		protected string zhdm = default(string);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///宗海特征码[字典:宗地（宗海）特征码字典表-ZDZHTZMZD]
		protected string zhtzm = default(string);
        ///项目名称
		protected string xmmc = default(string);
        ///项目性质[字典:项目性质字典表-XMXZZD]
		protected string xmxz = default(string);
        ///用海总面积
		protected double? yhzmj = default(double?);
        ///宗海面积
		protected double? zhmj = default(double?);
        ///等别[字典:海域等别字典表-HYDBZD]
		protected string db = default(string);
        ///占海岸线
		protected double? zhax = default(double?);
        ///用海类型A[字典:海域使用类型A字典表-HYSYLXAZD]
		protected string yhlxa = default(string);
        ///用海类型B[字典:海域使用类型B字典表-HYSYLXBZD]
		protected string yhlxb = default(string);
        ///用海位置说明
		protected string yhwzsm = default(string);
        ///海岛名称
		protected string hdmc = default(string);
        ///海岛代码
		protected string hddm = default(string);
        ///用岛范围
		protected string ydfw = default(string);
        ///用岛面积
		protected double? ydmj = default(double?);
        ///海岛位置
		protected string hdwz = default(string);
        ///海岛用途[字典:无居民海岛用途字典表-WJMHDYTZD]
		protected string hdyt = default(string);
        ///宗海图
		protected byte[] zht = default(byte[]);
        ///档案号
		protected string dah = default(string);
        ///状态[字典:不动产单元状态字典表-BDCDYZTZD]
		protected string zt = default(string);
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
            get{return "Zhjbxx";}
        }
         public string LayerName
        {
            get{return "宗海（含无居民海岛）";}
        }
        public string EntityName{
            get{return "IDatabaseFeature,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return true;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","ZHJBXX",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","宗海（含无居民海岛）",this.id,this.ysdm);
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
		
        ///宗海代码
        ///[Column(COL_ZHDM, PARAM_ZHDM )]
        public virtual string Zhdm 
        {
            get { return this.zhdm; }
			set	{ 
                  if(this.zhdm != value)
                    {
                        this.OnPropertyChanging("Zhdm"); 
                        this.zhdm = value;                        
                        this.OnPropertyChanged("Zhdm");
                    }   
                }
        }	
		
        ///不动产单元号
        ///[Column(COL_BDCDYH, PARAM_BDCDYH )]
        public virtual string Bdcdyh 
        {
            get { return this.bdcdyh; }
			set	{ 
                  if(this.bdcdyh != value)
                    {
                        this.OnPropertyChanging("Bdcdyh"); 
                        this.bdcdyh = value;                        
                        this.OnPropertyChanged("Bdcdyh");
                    }   
                }
        }	
		
        ///宗海特征码
        ///[Column(COL_ZHTZM, PARAM_ZHTZM )]
        public virtual string Zhtzm 
        {
            get { return this.zhtzm; }
			set	{ 
                  if(this.zhtzm != value)
                    {
                        this.OnPropertyChanging("Zhtzm"); 
                        this.zhtzm = value;                        
                        this.OnPropertyChanged("Zhtzm");
                    }   
                }
        }	
		
        ///项目名称
        ///[Column(COL_XMMC, PARAM_XMMC )]
        public virtual string Xmmc 
        {
            get { return this.xmmc; }
			set	{ 
                  if(this.xmmc != value)
                    {
                        this.OnPropertyChanging("Xmmc"); 
                        this.xmmc = value;                        
                        this.OnPropertyChanged("Xmmc");
                    }   
                }
        }	
		
        ///项目性质
        ///[Column(COL_XMXZ, PARAM_XMXZ )]
        public virtual string Xmxz 
        {
            get { return this.xmxz; }
			set	{ 
                  if(this.xmxz != value)
                    {
                        this.OnPropertyChanging("Xmxz"); 
                        this.xmxz = value;                        
                        this.OnPropertyChanged("Xmxz");
                    }   
                }
        }	
		
        ///用海总面积
        ///[Column(COL_YHZMJ, PARAM_YHZMJ )]
        public virtual double? Yhzmj 
        {
            get { return this.yhzmj; }
			set	{ 
                  if(this.yhzmj != value)
                    {
                        this.OnPropertyChanging("Yhzmj"); 
                        this.yhzmj = value;                        
                        this.OnPropertyChanged("Yhzmj");
                    }   
                }
        }	
		
        ///宗海面积
        ///[Column(COL_ZHMJ, PARAM_ZHMJ )]
        public virtual double? Zhmj 
        {
            get { return this.zhmj; }
			set	{ 
                  if(this.zhmj != value)
                    {
                        this.OnPropertyChanging("Zhmj"); 
                        this.zhmj = value;                        
                        this.OnPropertyChanged("Zhmj");
                    }   
                }
        }	
		
        ///等别
        ///[Column(COL_DB, PARAM_DB )]
        public virtual string Db 
        {
            get { return this.db; }
			set	{ 
                  if(this.db != value)
                    {
                        this.OnPropertyChanging("Db"); 
                        this.db = value;                        
                        this.OnPropertyChanged("Db");
                    }   
                }
        }	
		
        ///占海岸线
        ///[Column(COL_ZHAX, PARAM_ZHAX )]
        public virtual double? Zhax 
        {
            get { return this.zhax; }
			set	{ 
                  if(this.zhax != value)
                    {
                        this.OnPropertyChanging("Zhax"); 
                        this.zhax = value;                        
                        this.OnPropertyChanged("Zhax");
                    }   
                }
        }	
		
        ///用海类型A
        ///[Column(COL_YHLXA, PARAM_YHLXA )]
        public virtual string Yhlxa 
        {
            get { return this.yhlxa; }
			set	{ 
                  if(this.yhlxa != value)
                    {
                        this.OnPropertyChanging("Yhlxa"); 
                        this.yhlxa = value;                        
                        this.OnPropertyChanged("Yhlxa");
                    }   
                }
        }	
		
        ///用海类型B
        ///[Column(COL_YHLXB, PARAM_YHLXB )]
        public virtual string Yhlxb 
        {
            get { return this.yhlxb; }
			set	{ 
                  if(this.yhlxb != value)
                    {
                        this.OnPropertyChanging("Yhlxb"); 
                        this.yhlxb = value;                        
                        this.OnPropertyChanged("Yhlxb");
                    }   
                }
        }	
		
        ///用海位置说明
        ///[Column(COL_YHWZSM, PARAM_YHWZSM )]
        public virtual string Yhwzsm 
        {
            get { return this.yhwzsm; }
			set	{ 
                  if(this.yhwzsm != value)
                    {
                        this.OnPropertyChanging("Yhwzsm"); 
                        this.yhwzsm = value;                        
                        this.OnPropertyChanged("Yhwzsm");
                    }   
                }
        }	
		
        ///海岛名称
        ///[Column(COL_HDMC, PARAM_HDMC )]
        public virtual string Hdmc 
        {
            get { return this.hdmc; }
			set	{ 
                  if(this.hdmc != value)
                    {
                        this.OnPropertyChanging("Hdmc"); 
                        this.hdmc = value;                        
                        this.OnPropertyChanged("Hdmc");
                    }   
                }
        }	
		
        ///海岛代码
        ///[Column(COL_HDDM, PARAM_HDDM )]
        public virtual string Hddm 
        {
            get { return this.hddm; }
			set	{ 
                  if(this.hddm != value)
                    {
                        this.OnPropertyChanging("Hddm"); 
                        this.hddm = value;                        
                        this.OnPropertyChanged("Hddm");
                    }   
                }
        }	
		
        ///用岛范围
        ///[Column(COL_YDFW, PARAM_YDFW )]
        public virtual string Ydfw 
        {
            get { return this.ydfw; }
			set	{ 
                  if(this.ydfw != value)
                    {
                        this.OnPropertyChanging("Ydfw"); 
                        this.ydfw = value;                        
                        this.OnPropertyChanged("Ydfw");
                    }   
                }
        }	
		
        ///用岛面积
        ///[Column(COL_YDMJ, PARAM_YDMJ )]
        public virtual double? Ydmj 
        {
            get { return this.ydmj; }
			set	{ 
                  if(this.ydmj != value)
                    {
                        this.OnPropertyChanging("Ydmj"); 
                        this.ydmj = value;                        
                        this.OnPropertyChanged("Ydmj");
                    }   
                }
        }	
		
        ///海岛位置
        ///[Column(COL_HDWZ, PARAM_HDWZ )]
        public virtual string Hdwz 
        {
            get { return this.hdwz; }
			set	{ 
                  if(this.hdwz != value)
                    {
                        this.OnPropertyChanging("Hdwz"); 
                        this.hdwz = value;                        
                        this.OnPropertyChanged("Hdwz");
                    }   
                }
        }	
		
        ///海岛用途
        ///[Column(COL_HDYT, PARAM_HDYT )]
        public virtual string Hdyt 
        {
            get { return this.hdyt; }
			set	{ 
                  if(this.hdyt != value)
                    {
                        this.OnPropertyChanging("Hdyt"); 
                        this.hdyt = value;                        
                        this.OnPropertyChanged("Hdyt");
                    }   
                }
        }	
		
        ///宗海图
        ///[Column(COL_ZHT, PARAM_ZHT )]
        public virtual byte[] Zht 
        {
            get { return this.zht; }
			set	{ 
                  if(this.zht != value)
                    {
                        this.OnPropertyChanging("Zht"); 
                        this.zht = value;                        
                        this.OnPropertyChanged("Zht");
                    }   
                }
        }	
		
        ///档案号
        ///[Column(COL_DAH, PARAM_DAH )]
        public virtual string Dah 
        {
            get { return this.dah; }
			set	{ 
                  if(this.dah != value)
                    {
                        this.OnPropertyChanging("Dah"); 
                        this.dah = value;                        
                        this.OnPropertyChanged("Dah");
                    }   
                }
        }	
		
        ///状态
        ///[Column(COL_ZT, PARAM_ZT )]
        public virtual string Zt 
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
        public Zhjbxx()
        {
            _geometry=new Geometry(GEOMETRY_TYPE,ZValueType.None);
            this.id=0;
            this.ysdm="";
            this.zhdm="";
            this.bdcdyh="";
            this.zhtzm="";
            this.xmmc="";
            this.xmxz="";
            this.yhzmj=0.0;
            this.zhmj=0.0;
            this.db="";
            this.zhax=0.0;
            this.yhlxa="";
            this.yhlxb="";
            this.yhwzsm="";
            this.hdmc="";
            this.hddm="";
            this.ydfw="";
            this.ydmj=0.0;
            this.hdwz="";
            this.hdyt="";
            
            this.dah="";
            this.zt="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Zhjbxx record = obj as Zhjbxx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZHJBXX,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZHDM, this.Zhdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_ZHTZM, this.Zhtzm);
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_XMXZ, this.Xmxz);
				command.Parameters.AddWithValue(PARAM_YHZMJ, this.Yhzmj);
				command.Parameters.AddWithValue(PARAM_ZHMJ, this.Zhmj);
				command.Parameters.AddWithValue(PARAM_DB, this.Db);
				command.Parameters.AddWithValue(PARAM_ZHAX, this.Zhax);
				command.Parameters.AddWithValue(PARAM_YHLXA, this.Yhlxa);
				command.Parameters.AddWithValue(PARAM_YHLXB, this.Yhlxb);
				command.Parameters.AddWithValue(PARAM_YHWZSM, this.Yhwzsm);
				command.Parameters.AddWithValue(PARAM_HDMC, this.Hdmc);
				command.Parameters.AddWithValue(PARAM_HDDM, this.Hddm);
				command.Parameters.AddWithValue(PARAM_YDFW, this.Ydfw);
				command.Parameters.AddWithValue(PARAM_YDMJ, this.Ydmj);
				command.Parameters.AddWithValue(PARAM_HDWZ, this.Hdwz);
				command.Parameters.AddWithValue(PARAM_HDYT, this.Hdyt);
				command.Parameters.AddWithValue(PARAM_ZHT, this.Zht);
				command.Parameters.AddWithValue(PARAM_DAH, this.Dah);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZHJBXX,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZHDM, this.Zhdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_ZHTZM, this.Zhtzm);
				command.Parameters.AddWithValue(PARAM_XMMC, this.Xmmc);
				command.Parameters.AddWithValue(PARAM_XMXZ, this.Xmxz);
				command.Parameters.AddWithValue(PARAM_YHZMJ, this.Yhzmj);
				command.Parameters.AddWithValue(PARAM_ZHMJ, this.Zhmj);
				command.Parameters.AddWithValue(PARAM_DB, this.Db);
				command.Parameters.AddWithValue(PARAM_ZHAX, this.Zhax);
				command.Parameters.AddWithValue(PARAM_YHLXA, this.Yhlxa);
				command.Parameters.AddWithValue(PARAM_YHLXB, this.Yhlxb);
				command.Parameters.AddWithValue(PARAM_YHWZSM, this.Yhwzsm);
				command.Parameters.AddWithValue(PARAM_HDMC, this.Hdmc);
				command.Parameters.AddWithValue(PARAM_HDDM, this.Hddm);
				command.Parameters.AddWithValue(PARAM_YDFW, this.Ydfw);
				command.Parameters.AddWithValue(PARAM_YDMJ, this.Ydmj);
				command.Parameters.AddWithValue(PARAM_HDWZ, this.Hdwz);
				command.Parameters.AddWithValue(PARAM_HDYT, this.Hdyt);
				command.Parameters.AddWithValue(PARAM_ZHT, this.Zht);
				command.Parameters.AddWithValue(PARAM_DAH, this.Dah);
				command.Parameters.AddWithValue(PARAM_ZT, this.Zt);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZHJBXX,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZHJBXX,dao.Connection))
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
			if (!reader.IsDBNull(1)) ysdm = reader.GetString(1);
			if (!reader.IsDBNull(2)) zhdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) bdcdyh = reader.GetString(3);
			if (!reader.IsDBNull(4)) zhtzm = reader.GetString(4);
			if (!reader.IsDBNull(5)) xmmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) xmxz = reader.GetString(6);
			if (!reader.IsDBNull(7)) yhzmj = reader.GetDouble(7);
			if (!reader.IsDBNull(8)) zhmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) db = reader.GetString(9);
			if (!reader.IsDBNull(10)) zhax = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) yhlxa = reader.GetString(11);
			if (!reader.IsDBNull(12)) yhlxb = reader.GetString(12);
			if (!reader.IsDBNull(13)) yhwzsm = reader.GetString(13);
			if (!reader.IsDBNull(14)) hdmc = reader.GetString(14);
			if (!reader.IsDBNull(15)) hddm = reader.GetString(15);
			if (!reader.IsDBNull(16)) ydfw = reader.GetString(16);
			if (!reader.IsDBNull(17)) ydmj = reader.GetDouble(17);
			if (!reader.IsDBNull(18)) hdwz = reader.GetString(18);
			if (!reader.IsDBNull(19)) hdyt = reader.GetString(19);
			if (!reader.IsDBNull(20)) zht = SQLiteHelper.GetBytes(reader,"ZHT");
			if (!reader.IsDBNull(21)) dah = reader.GetString(21);
			if (!reader.IsDBNull(22)) zt = reader.GetString(22);
			if (!reader.IsDBNull(23)) databaseid = reader.GetInt64(23);
			if (!reader.IsDBNull(24)) flags = reader.GetInt16(24);
			if (!reader.IsDBNull(25)) xgr = reader.GetString(25);
			if (!reader.IsDBNull(26)) xgsj = reader.GetDateTime(26);
			if (!reader.IsDBNull(27)) this.Wkt=reader.GetString(27);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Zhjbxx target=new Zhjbxx();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Zhdm=this.Zhdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Zhtzm=this.Zhtzm;
            target.Xmmc=this.Xmmc;
            target.Xmxz=this.Xmxz;
            target.Yhzmj=this.Yhzmj;
            target.Zhmj=this.Zhmj;
            target.Db=this.Db;
            target.Zhax=this.Zhax;
            target.Yhlxa=this.Yhlxa;
            target.Yhlxb=this.Yhlxb;
            target.Yhwzsm=this.Yhwzsm;
            target.Hdmc=this.Hdmc;
            target.Hddm=this.Hddm;
            target.Ydfw=this.Ydfw;
            target.Ydmj=this.Ydmj;
            target.Hdwz=this.Hdwz;
            target.Hdyt=this.Hdyt;
            target.Zht=this.Zht;
            target.Dah=this.Dah;
            target.Zt=this.Zt;
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
