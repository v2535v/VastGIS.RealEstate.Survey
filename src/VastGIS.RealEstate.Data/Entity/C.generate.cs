
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
    public partial class C : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "C";	
        public const string LAYER_NAME = "层";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_CFWLX = "CFWLX";
		public const string COL_JSBL = "JSBL";
		public const string COL_CH = "CH";
		public const string COL_ZRZH = "ZRZH";
		public const string COL_YSDM = "YSDM";
		public const string COL_SJC = "SJC";
		public const string COL_MYC = "MYC";
		public const string COL_CJZMJ = "CJZMJ";
		public const string COL_CTNJZMJ = "CTNJZMJ";
		public const string COL_CYTMJ = "CYTMJ";
		public const string COL_CGYJZMJ = "CGYJZMJ";
		public const string COL_CFTJZMJ = "CFTJZMJ";
		public const string COL_CBQMJ = "CBQMJ";
		public const string COL_CG = "CG";
		public const string COL_SPTYMJ = "SPTYMJ";
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
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_CFWLX = "@CFWLX";	
        public const string PARAM_JSBL = "@JSBL";	
        public const string PARAM_CH = "@CH";	
        public const string PARAM_ZRZH = "@ZRZH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_SJC = "@SJC";	
        public const string PARAM_MYC = "@MYC";	
        public const string PARAM_CJZMJ = "@CJZMJ";	
        public const string PARAM_CTNJZMJ = "@CTNJZMJ";	
        public const string PARAM_CYTMJ = "@CYTMJ";	
        public const string PARAM_CGYJZMJ = "@CGYJZMJ";	
        public const string PARAM_CFTJZMJ = "@CFTJZMJ";	
        public const string PARAM_CBQMJ = "@CBQMJ";	
        public const string PARAM_CG = "@CG";	
        public const string PARAM_SPTYMJ = "@SPTYMJ";	
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
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_C ="SELECT  Id,CFWLX,JSBL,CH,ZRZH,YSDM,SJC,MYC,CJZMJ,CTNJZMJ,CYTMJ,CGYJZMJ,CFTJZMJ,CBQMJ,CG,SPTYMJ,WX_DCY,WX_DCSJ,WX_CLY,WX_CLSJ,WX_ZTY,WX_ZTSJ,WX_ZJY,WX_ZJSJ,WX_WYDM,DatabaseId,FLAGS,XGR,XGSJ FROM C WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_C = "INSERT INTO [C] (CFWLX, JSBL, CH, ZRZH, YSDM, SJC, MYC, CJZMJ, CTNJZMJ, CYTMJ, CGYJZMJ, CFTJZMJ, CBQMJ, CG, SPTYMJ, WX_DCY, WX_DCSJ, WX_CLY, WX_CLSJ, WX_ZTY, WX_ZTSJ, WX_ZJY, WX_ZJSJ, WX_WYDM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @CFWLX, @JSBL, @CH, @ZRZH, @YSDM, @SJC, @MYC, @CJZMJ, @CTNJZMJ, @CYTMJ, @CGYJZMJ, @CFTJZMJ, @CBQMJ, @CG, @SPTYMJ, @WX_DCY, @WX_DCSJ, @WX_CLY, @WX_CLSJ, @WX_ZTY, @WX_ZTSJ, @WX_ZJY, @WX_ZJSJ, @WX_WYDM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_C = "UPDATE [C] SET CFWLX = @CFWLX, JSBL = @JSBL, CH = @CH, ZRZH = @ZRZH, YSDM = @YSDM, SJC = @SJC, MYC = @MYC, CJZMJ = @CJZMJ, CTNJZMJ = @CTNJZMJ, CYTMJ = @CYTMJ, CGYJZMJ = @CGYJZMJ, CFTJZMJ = @CFTJZMJ, CBQMJ = @CBQMJ, CG = @CG, SPTYMJ = @SPTYMJ, WX_DCY = @WX_DCY, WX_DCSJ = @WX_DCSJ, WX_CLY = @WX_CLY, WX_CLSJ = @WX_CLSJ, WX_ZTY = @WX_ZTY, WX_ZTSJ = @WX_ZTSJ, WX_ZJY = @WX_ZJY, WX_ZJSJ = @WX_ZJSJ, WX_WYDM = @WX_WYDM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_C = "DELETE FROM [C] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_C = "UPDATE [C] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///层房屋类型[字典:层房屋类型字典-CFWLXZD]
		protected string cfwlx = default(string);
        ///计算比例
		protected double? jsbl = default(double?);
        ///层号
		protected string ch = default(string);
        ///自然幢号
		protected string zrzh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///实际层
		protected long? sjc = default(long?);
        ///名义层
		protected string myc = default(string);
        ///层建筑面积
		protected double? cjzmj = default(double?);
        ///层套内建筑面积
		protected double? ctnjzmj = default(double?);
        ///层阳台面积
		protected double? cytmj = default(double?);
        ///层共有建筑面积
		protected double? cgyjzmj = default(double?);
        ///层分摊建筑面积
		protected double? cftjzmj = default(double?);
        ///层半墙面积
		protected double? cbqmj = default(double?);
        ///层高
		protected double? cg = default(double?);
        ///水平投影面积
		protected double? sptymj = default(double?);
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
            get{return "C";}
        }
         public string LayerName
        {
            get{return "层";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IYsdmEntity,IGlobalEntity,ISurveyEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return true;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return true;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","C",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("实际第 {0}层 (名义第{1}层)",this.Sjc,this.Myc);
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
		
        ///层房屋类型
        ///[Column(COL_CFWLX, PARAM_CFWLX )]
        public virtual string Cfwlx 
        {
            get { return this.cfwlx; }
			set	{ 
                  if(this.cfwlx != value)
                    {
                        this.OnPropertyChanging("Cfwlx"); 
                        this.cfwlx = value;                        
                        this.OnPropertyChanged("Cfwlx");
                    }   
                }
        }	
		
        ///计算比例
        ///[Column(COL_JSBL, PARAM_JSBL )]
        public virtual double? Jsbl 
        {
            get { return this.jsbl; }
			set	{ 
                  if(this.jsbl != value)
                    {
                        this.OnPropertyChanging("Jsbl"); 
                        this.jsbl = value;                        
                        this.OnPropertyChanged("Jsbl");
                    }   
                }
        }	
		
        ///层号
        ///[Column(COL_CH, PARAM_CH )]
        public virtual string Ch 
        {
            get { return this.ch; }
			set	{ 
                  if(this.ch != value)
                    {
                        this.OnPropertyChanging("Ch"); 
                        this.ch = value;                        
                        this.OnPropertyChanged("Ch");
                    }   
                }
        }	
		
        ///自然幢号
        ///[Column(COL_ZRZH, PARAM_ZRZH )]
        public virtual string Zrzh 
        {
            get { return this.zrzh; }
			set	{ 
                  if(this.zrzh != value)
                    {
                        this.OnPropertyChanging("Zrzh"); 
                        this.zrzh = value;                        
                        this.OnPropertyChanged("Zrzh");
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
		
        ///实际层
        ///[Column(COL_SJC, PARAM_SJC )]
        public virtual long? Sjc 
        {
            get { return this.sjc; }
			set	{ 
                  if(this.sjc != value)
                    {
                        this.OnPropertyChanging("Sjc"); 
                        this.sjc = value;                        
                        this.OnPropertyChanged("Sjc");
                    }   
                }
        }	
		
        ///名义层
        ///[Column(COL_MYC, PARAM_MYC )]
        public virtual string Myc 
        {
            get { return this.myc; }
			set	{ 
                  if(this.myc != value)
                    {
                        this.OnPropertyChanging("Myc"); 
                        this.myc = value;                        
                        this.OnPropertyChanged("Myc");
                    }   
                }
        }	
		
        ///层建筑面积
        ///[Column(COL_CJZMJ, PARAM_CJZMJ )]
        public virtual double? Cjzmj 
        {
            get { return this.cjzmj; }
			set	{ 
                  if(this.cjzmj != value)
                    {
                        this.OnPropertyChanging("Cjzmj"); 
                        this.cjzmj = value;                        
                        this.OnPropertyChanged("Cjzmj");
                    }   
                }
        }	
		
        ///层套内建筑面积
        ///[Column(COL_CTNJZMJ, PARAM_CTNJZMJ )]
        public virtual double? Ctnjzmj 
        {
            get { return this.ctnjzmj; }
			set	{ 
                  if(this.ctnjzmj != value)
                    {
                        this.OnPropertyChanging("Ctnjzmj"); 
                        this.ctnjzmj = value;                        
                        this.OnPropertyChanged("Ctnjzmj");
                    }   
                }
        }	
		
        ///层阳台面积
        ///[Column(COL_CYTMJ, PARAM_CYTMJ )]
        public virtual double? Cytmj 
        {
            get { return this.cytmj; }
			set	{ 
                  if(this.cytmj != value)
                    {
                        this.OnPropertyChanging("Cytmj"); 
                        this.cytmj = value;                        
                        this.OnPropertyChanged("Cytmj");
                    }   
                }
        }	
		
        ///层共有建筑面积
        ///[Column(COL_CGYJZMJ, PARAM_CGYJZMJ )]
        public virtual double? Cgyjzmj 
        {
            get { return this.cgyjzmj; }
			set	{ 
                  if(this.cgyjzmj != value)
                    {
                        this.OnPropertyChanging("Cgyjzmj"); 
                        this.cgyjzmj = value;                        
                        this.OnPropertyChanged("Cgyjzmj");
                    }   
                }
        }	
		
        ///层分摊建筑面积
        ///[Column(COL_CFTJZMJ, PARAM_CFTJZMJ )]
        public virtual double? Cftjzmj 
        {
            get { return this.cftjzmj; }
			set	{ 
                  if(this.cftjzmj != value)
                    {
                        this.OnPropertyChanging("Cftjzmj"); 
                        this.cftjzmj = value;                        
                        this.OnPropertyChanged("Cftjzmj");
                    }   
                }
        }	
		
        ///层半墙面积
        ///[Column(COL_CBQMJ, PARAM_CBQMJ )]
        public virtual double? Cbqmj 
        {
            get { return this.cbqmj; }
			set	{ 
                  if(this.cbqmj != value)
                    {
                        this.OnPropertyChanging("Cbqmj"); 
                        this.cbqmj = value;                        
                        this.OnPropertyChanged("Cbqmj");
                    }   
                }
        }	
		
        ///层高
        ///[Column(COL_CG, PARAM_CG )]
        public virtual double? Cg 
        {
            get { return this.cg; }
			set	{ 
                  if(this.cg != value)
                    {
                        this.OnPropertyChanging("Cg"); 
                        this.cg = value;                        
                        this.OnPropertyChanged("Cg");
                    }   
                }
        }	
		
        ///水平投影面积
        ///[Column(COL_SPTYMJ, PARAM_SPTYMJ )]
        public virtual double? Sptymj 
        {
            get { return this.sptymj; }
			set	{ 
                  if(this.sptymj != value)
                    {
                        this.OnPropertyChanging("Sptymj"); 
                        this.sptymj = value;                        
                        this.OnPropertyChanged("Sptymj");
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
        #endregion        
        
        #region 创建方法
        public C()
        {
            this.id=0;
            this.cfwlx="";
            this.jsbl=0.0;
            this.ch="";
            this.zrzh="";
            this.ysdm="";
            this.sjc=0;
            this.myc="";
            this.cjzmj=0.0;
            this.ctnjzmj=0.0;
            this.cytmj=0.0;
            this.cgyjzmj=0.0;
            this.cftjzmj=0.0;
            this.cbqmj=0.0;
            this.cg=0.0;
            this.sptymj=0.0;
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
            C record = obj as C;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_C,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_CFWLX, this.Cfwlx);
				command.Parameters.AddWithValue(PARAM_JSBL, this.Jsbl);
				command.Parameters.AddWithValue(PARAM_CH, this.Ch);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SJC, this.Sjc);
				command.Parameters.AddWithValue(PARAM_MYC, this.Myc);
				command.Parameters.AddWithValue(PARAM_CJZMJ, this.Cjzmj);
				command.Parameters.AddWithValue(PARAM_CTNJZMJ, this.Ctnjzmj);
				command.Parameters.AddWithValue(PARAM_CYTMJ, this.Cytmj);
				command.Parameters.AddWithValue(PARAM_CGYJZMJ, this.Cgyjzmj);
				command.Parameters.AddWithValue(PARAM_CFTJZMJ, this.Cftjzmj);
				command.Parameters.AddWithValue(PARAM_CBQMJ, this.Cbqmj);
				command.Parameters.AddWithValue(PARAM_CG, this.Cg);
				command.Parameters.AddWithValue(PARAM_SPTYMJ, this.Sptymj);
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
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_C,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_CFWLX, this.Cfwlx);
				command.Parameters.AddWithValue(PARAM_JSBL, this.Jsbl);
				command.Parameters.AddWithValue(PARAM_CH, this.Ch);
				command.Parameters.AddWithValue(PARAM_ZRZH, this.Zrzh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SJC, this.Sjc);
				command.Parameters.AddWithValue(PARAM_MYC, this.Myc);
				command.Parameters.AddWithValue(PARAM_CJZMJ, this.Cjzmj);
				command.Parameters.AddWithValue(PARAM_CTNJZMJ, this.Ctnjzmj);
				command.Parameters.AddWithValue(PARAM_CYTMJ, this.Cytmj);
				command.Parameters.AddWithValue(PARAM_CGYJZMJ, this.Cgyjzmj);
				command.Parameters.AddWithValue(PARAM_CFTJZMJ, this.Cftjzmj);
				command.Parameters.AddWithValue(PARAM_CBQMJ, this.Cbqmj);
				command.Parameters.AddWithValue(PARAM_CG, this.Cg);
				command.Parameters.AddWithValue(PARAM_SPTYMJ, this.Sptymj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_C,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_C,dao.Connection))
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
			if (!reader.IsDBNull(1)) cfwlx = reader.GetString(1);
			if (!reader.IsDBNull(2)) jsbl = reader.GetDouble(2);
			if (!reader.IsDBNull(3)) ch = reader.GetString(3);
			if (!reader.IsDBNull(4)) zrzh = reader.GetString(4);
			if (!reader.IsDBNull(5)) ysdm = reader.GetString(5);
			if (!reader.IsDBNull(6)) sjc = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) myc = reader.GetString(7);
			if (!reader.IsDBNull(8)) cjzmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) ctnjzmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) cytmj = reader.GetDouble(10);
			if (!reader.IsDBNull(11)) cgyjzmj = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) cftjzmj = reader.GetDouble(12);
			if (!reader.IsDBNull(13)) cbqmj = reader.GetDouble(13);
			if (!reader.IsDBNull(14)) cg = reader.GetDouble(14);
			if (!reader.IsDBNull(15)) sptymj = reader.GetDouble(15);
			if (!reader.IsDBNull(16)) wxDcy = reader.GetString(16);
			if (!reader.IsDBNull(17)) wxDcsj = reader.GetDateTime(17);
			if (!reader.IsDBNull(18)) wxCly = reader.GetString(18);
			if (!reader.IsDBNull(19)) wxClsj = reader.GetDateTime(19);
			if (!reader.IsDBNull(20)) wxZty = reader.GetString(20);
			if (!reader.IsDBNull(21)) wxZtsj = reader.GetDateTime(21);
			if (!reader.IsDBNull(22)) wxZjy = reader.GetString(22);
			if (!reader.IsDBNull(23)) wxZjsj = reader.GetDateTime(23);
			if (!reader.IsDBNull(24)) wxWydm = reader.GetString(24);
			if (!reader.IsDBNull(25)) databaseid = reader.GetInt64(25);
			if (!reader.IsDBNull(26)) flags = reader.GetInt16(26);
			if (!reader.IsDBNull(27)) xgr = reader.GetString(27);
			if (!reader.IsDBNull(28)) xgsj = reader.GetDateTime(28);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            C target=new C();
            target.ID=0;
            target.Cfwlx=this.Cfwlx;
            target.Jsbl=this.Jsbl;
            target.Ch=this.Ch;
            target.Zrzh=this.Zrzh;
            target.Ysdm=this.Ysdm;
            target.Sjc=this.Sjc;
            target.Myc=this.Myc;
            target.Cjzmj=this.Cjzmj;
            target.Ctnjzmj=this.Ctnjzmj;
            target.Cytmj=this.Cytmj;
            target.Cgyjzmj=this.Cgyjzmj;
            target.Cftjzmj=this.Cftjzmj;
            target.Cbqmj=this.Cbqmj;
            target.Cg=this.Cg;
            target.Sptymj=this.Sptymj;
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
