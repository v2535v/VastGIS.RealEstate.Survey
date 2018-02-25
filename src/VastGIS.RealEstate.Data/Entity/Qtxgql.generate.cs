
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
    public partial class Qtxgql : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "QTXGQL";	
        public const string LAYER_NAME = "其它相关权利";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_QLQSSJ = "QLQSSJ";
		public const string COL_QLJSSJ = "QLJSSJ";
		public const string COL_QSFS = "QSFS";
		public const string COL_SYLX = "SYLX";
		public const string COL_QSL = "QSL";
		public const string COL_QSYT = "QSYT";
		public const string COL_KCMJ = "KCMJ";
		public const string COL_KCFS = "KCFS";
		public const string COL_KCKZ = "KCKZ";
		public const string COL_SCGM = "SCGM";
		public const string COL_BDCQZH = "BDCQZH";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_FJ = "FJ";
		public const string COL_FT = "FT";
		public const string COL_QSZT = "QSZT";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_QLQSSJ = "@QLQSSJ";	
        public const string PARAM_QLJSSJ = "@QLJSSJ";	
        public const string PARAM_QSFS = "@QSFS";	
        public const string PARAM_SYLX = "@SYLX";	
        public const string PARAM_QSL = "@QSL";	
        public const string PARAM_QSYT = "@QSYT";	
        public const string PARAM_KCMJ = "@KCMJ";	
        public const string PARAM_KCFS = "@KCFS";	
        public const string PARAM_KCKZ = "@KCKZ";	
        public const string PARAM_SCGM = "@SCGM";	
        public const string PARAM_BDCQZH = "@BDCQZH";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_FT = "@FT";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_QTXGQL ="SELECT  Id,YSDM,BDCDYH,YWH,QLLX,DJLX,DJYY,QLQSSJ,QLJSSJ,QSFS,SYLX,QSL,QSYT,KCMJ,KCFS,KCKZ,SCGM,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,FT,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM QTXGQL WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_QTXGQL = "INSERT INTO [QTXGQL] (YSDM, BDCDYH, YWH, QLLX, DJLX, DJYY, QLQSSJ, QLJSSJ, QSFS, SYLX, QSL, QSYT, KCMJ, KCFS, KCKZ, SCGM, BDCQZH, QXDM, DJJG, DBR, DJSJ, FJ, FT, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @QLLX, @DJLX, @DJYY, @QLQSSJ, @QLJSSJ, @QSFS, @SYLX, @QSL, @QSYT, @KCMJ, @KCFS, @KCKZ, @SCGM, @BDCQZH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @FT, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_QTXGQL = "UPDATE [QTXGQL] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, DJLX = @DJLX, DJYY = @DJYY, QLQSSJ = @QLQSSJ, QLJSSJ = @QLJSSJ, QSFS = @QSFS, SYLX = @SYLX, QSL = @QSL, QSYT = @QSYT, KCMJ = @KCMJ, KCFS = @KCFS, KCKZ = @KCKZ, SCGM = @SCGM, BDCQZH = @BDCQZH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, FT = @FT, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_QTXGQL = "DELETE FROM [QTXGQL] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_QTXGQL = "UPDATE [QTXGQL] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///不动产单元号
		protected string bdcdyh = default(string);
        ///业务号
		protected string ywh = default(string);
        ///权利类型[字典:权利类型字典表-QLLXZD]
		protected string qllx = default(string);
        ///登记类型[字典:登记类型字典表-DJLXZD]
		protected string djlx = default(string);
        ///登记原因
		protected string djyy = default(string);
        ///权利起始时间
		protected System.DateTime? qlqssj = default(System.DateTime?);
        ///权利结束时间
		protected System.DateTime? qljssj = default(System.DateTime?);
        ///取水方式
		protected string qsfs = default(string);
        ///水源类型
		protected string sylx = default(string);
        ///取水量
		protected double? qsl = default(double?);
        ///取水用途
		protected string qsyt = default(string);
        ///勘查面积
		protected double? kcmj = default(double?);
        ///开采方式
		protected string kcfs = default(string);
        ///开采矿种
		protected string kckz = default(string);
        ///生产规模
		protected string scgm = default(string);
        ///不动产权证号
		protected string bdcqzh = default(string);
        ///区县代码[字典:区县字典表-VG_AREACODES]
		protected string qxdm = default(string);
        ///登记机构
		protected string djjg = default(string);
        ///登簿人
		protected string dbr = default(string);
        ///登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        ///附记
		protected string fj = default(string);
        ///附图
		protected byte[] ft = default(byte[]);
        ///权属状态[字典:权属状态字典表-QSZTZD]
		protected string qszt = default(string);
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
            get{return "Qtxgql";}
        }
         public string LayerName
        {
            get{return "其它相关权利";}
        }
        public string EntityName{
            get{return "IDatabaseEntity,IYsdmEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return true;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","QTXGQL",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","其它相关权利",this.id,this.ysdm);
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
		
        ///业务号
        ///[Column(COL_YWH, PARAM_YWH )]
        public virtual string Ywh 
        {
            get { return this.ywh; }
			set	{ 
                  if(this.ywh != value)
                    {
                        this.OnPropertyChanging("Ywh"); 
                        this.ywh = value;                        
                        this.OnPropertyChanged("Ywh");
                    }   
                }
        }	
		
        ///权利类型
        ///[Column(COL_QLLX, PARAM_QLLX )]
        public virtual string Qllx 
        {
            get { return this.qllx; }
			set	{ 
                  if(this.qllx != value)
                    {
                        this.OnPropertyChanging("Qllx"); 
                        this.qllx = value;                        
                        this.OnPropertyChanged("Qllx");
                    }   
                }
        }	
		
        ///登记类型
        ///[Column(COL_DJLX, PARAM_DJLX )]
        public virtual string Djlx 
        {
            get { return this.djlx; }
			set	{ 
                  if(this.djlx != value)
                    {
                        this.OnPropertyChanging("Djlx"); 
                        this.djlx = value;                        
                        this.OnPropertyChanged("Djlx");
                    }   
                }
        }	
		
        ///登记原因
        ///[Column(COL_DJYY, PARAM_DJYY )]
        public virtual string Djyy 
        {
            get { return this.djyy; }
			set	{ 
                  if(this.djyy != value)
                    {
                        this.OnPropertyChanging("Djyy"); 
                        this.djyy = value;                        
                        this.OnPropertyChanged("Djyy");
                    }   
                }
        }	
		
        ///权利起始时间
        ///[Column(COL_QLQSSJ, PARAM_QLQSSJ )]
        public virtual System.DateTime? Qlqssj 
        {
            get { return this.qlqssj; }
			set	{ 
                  if(this.qlqssj != value)
                    {
                        this.OnPropertyChanging("Qlqssj"); 
                        this.qlqssj = value;                        
                        this.OnPropertyChanged("Qlqssj");
                    }   
                }
        }	
		
        ///权利结束时间
        ///[Column(COL_QLJSSJ, PARAM_QLJSSJ )]
        public virtual System.DateTime? Qljssj 
        {
            get { return this.qljssj; }
			set	{ 
                  if(this.qljssj != value)
                    {
                        this.OnPropertyChanging("Qljssj"); 
                        this.qljssj = value;                        
                        this.OnPropertyChanged("Qljssj");
                    }   
                }
        }	
		
        ///取水方式
        ///[Column(COL_QSFS, PARAM_QSFS )]
        public virtual string Qsfs 
        {
            get { return this.qsfs; }
			set	{ 
                  if(this.qsfs != value)
                    {
                        this.OnPropertyChanging("Qsfs"); 
                        this.qsfs = value;                        
                        this.OnPropertyChanged("Qsfs");
                    }   
                }
        }	
		
        ///水源类型
        ///[Column(COL_SYLX, PARAM_SYLX )]
        public virtual string Sylx 
        {
            get { return this.sylx; }
			set	{ 
                  if(this.sylx != value)
                    {
                        this.OnPropertyChanging("Sylx"); 
                        this.sylx = value;                        
                        this.OnPropertyChanged("Sylx");
                    }   
                }
        }	
		
        ///取水量
        ///[Column(COL_QSL, PARAM_QSL )]
        public virtual double? Qsl 
        {
            get { return this.qsl; }
			set	{ 
                  if(this.qsl != value)
                    {
                        this.OnPropertyChanging("Qsl"); 
                        this.qsl = value;                        
                        this.OnPropertyChanged("Qsl");
                    }   
                }
        }	
		
        ///取水用途
        ///[Column(COL_QSYT, PARAM_QSYT )]
        public virtual string Qsyt 
        {
            get { return this.qsyt; }
			set	{ 
                  if(this.qsyt != value)
                    {
                        this.OnPropertyChanging("Qsyt"); 
                        this.qsyt = value;                        
                        this.OnPropertyChanged("Qsyt");
                    }   
                }
        }	
		
        ///勘查面积
        ///[Column(COL_KCMJ, PARAM_KCMJ )]
        public virtual double? Kcmj 
        {
            get { return this.kcmj; }
			set	{ 
                  if(this.kcmj != value)
                    {
                        this.OnPropertyChanging("Kcmj"); 
                        this.kcmj = value;                        
                        this.OnPropertyChanged("Kcmj");
                    }   
                }
        }	
		
        ///开采方式
        ///[Column(COL_KCFS, PARAM_KCFS )]
        public virtual string Kcfs 
        {
            get { return this.kcfs; }
			set	{ 
                  if(this.kcfs != value)
                    {
                        this.OnPropertyChanging("Kcfs"); 
                        this.kcfs = value;                        
                        this.OnPropertyChanged("Kcfs");
                    }   
                }
        }	
		
        ///开采矿种
        ///[Column(COL_KCKZ, PARAM_KCKZ )]
        public virtual string Kckz 
        {
            get { return this.kckz; }
			set	{ 
                  if(this.kckz != value)
                    {
                        this.OnPropertyChanging("Kckz"); 
                        this.kckz = value;                        
                        this.OnPropertyChanged("Kckz");
                    }   
                }
        }	
		
        ///生产规模
        ///[Column(COL_SCGM, PARAM_SCGM )]
        public virtual string Scgm 
        {
            get { return this.scgm; }
			set	{ 
                  if(this.scgm != value)
                    {
                        this.OnPropertyChanging("Scgm"); 
                        this.scgm = value;                        
                        this.OnPropertyChanged("Scgm");
                    }   
                }
        }	
		
        ///不动产权证号
        ///[Column(COL_BDCQZH, PARAM_BDCQZH )]
        public virtual string Bdcqzh 
        {
            get { return this.bdcqzh; }
			set	{ 
                  if(this.bdcqzh != value)
                    {
                        this.OnPropertyChanging("Bdcqzh"); 
                        this.bdcqzh = value;                        
                        this.OnPropertyChanged("Bdcqzh");
                    }   
                }
        }	
		
        ///区县代码
        ///[Column(COL_QXDM, PARAM_QXDM )]
        public virtual string Qxdm 
        {
            get { return this.qxdm; }
			set	{ 
                  if(this.qxdm != value)
                    {
                        this.OnPropertyChanging("Qxdm"); 
                        this.qxdm = value;                        
                        this.OnPropertyChanged("Qxdm");
                    }   
                }
        }	
		
        ///登记机构
        ///[Column(COL_DJJG, PARAM_DJJG )]
        public virtual string Djjg 
        {
            get { return this.djjg; }
			set	{ 
                  if(this.djjg != value)
                    {
                        this.OnPropertyChanging("Djjg"); 
                        this.djjg = value;                        
                        this.OnPropertyChanged("Djjg");
                    }   
                }
        }	
		
        ///登簿人
        ///[Column(COL_DBR, PARAM_DBR )]
        public virtual string Dbr 
        {
            get { return this.dbr; }
			set	{ 
                  if(this.dbr != value)
                    {
                        this.OnPropertyChanging("Dbr"); 
                        this.dbr = value;                        
                        this.OnPropertyChanged("Dbr");
                    }   
                }
        }	
		
        ///登记时间
        ///[Column(COL_DJSJ, PARAM_DJSJ )]
        public virtual System.DateTime? Djsj 
        {
            get { return this.djsj; }
			set	{ 
                  if(this.djsj != value)
                    {
                        this.OnPropertyChanging("Djsj"); 
                        this.djsj = value;                        
                        this.OnPropertyChanged("Djsj");
                    }   
                }
        }	
		
        ///附记
        ///[Column(COL_FJ, PARAM_FJ )]
        public virtual string Fj 
        {
            get { return this.fj; }
			set	{ 
                  if(this.fj != value)
                    {
                        this.OnPropertyChanging("Fj"); 
                        this.fj = value;                        
                        this.OnPropertyChanged("Fj");
                    }   
                }
        }	
		
        ///附图
        ///[Column(COL_FT, PARAM_FT )]
        public virtual byte[] Ft 
        {
            get { return this.ft; }
			set	{ 
                  if(this.ft != value)
                    {
                        this.OnPropertyChanging("Ft"); 
                        this.ft = value;                        
                        this.OnPropertyChanged("Ft");
                    }   
                }
        }	
		
        ///权属状态
        ///[Column(COL_QSZT, PARAM_QSZT )]
        public virtual string Qszt 
        {
            get { return this.qszt; }
			set	{ 
                  if(this.qszt != value)
                    {
                        this.OnPropertyChanging("Qszt"); 
                        this.qszt = value;                        
                        this.OnPropertyChanged("Qszt");
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
        public Qtxgql()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.djlx="";
            this.djyy="";
            this.qlqssj=DateTime.Now;
            this.qljssj=DateTime.Now;
            this.qsfs="";
            this.sylx="";
            this.qsl=0.0;
            this.qsyt="";
            this.kcmj=0.0;
            this.kcfs="";
            this.kckz="";
            this.scgm="";
            this.bdcqzh="";
            this.qxdm="";
            this.djjg="";
            this.dbr="";
            this.djsj=DateTime.Now;
            this.fj="";
            
            this.qszt="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Qtxgql record = obj as Qtxgql;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_QTXGQL,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_QLQSSJ, this.Qlqssj);
				command.Parameters.AddWithValue(PARAM_QLJSSJ, this.Qljssj);
				command.Parameters.AddWithValue(PARAM_QSFS, this.Qsfs);
				command.Parameters.AddWithValue(PARAM_SYLX, this.Sylx);
				command.Parameters.AddWithValue(PARAM_QSL, this.Qsl);
				command.Parameters.AddWithValue(PARAM_QSYT, this.Qsyt);
				command.Parameters.AddWithValue(PARAM_KCMJ, this.Kcmj);
				command.Parameters.AddWithValue(PARAM_KCFS, this.Kcfs);
				command.Parameters.AddWithValue(PARAM_KCKZ, this.Kckz);
				command.Parameters.AddWithValue(PARAM_SCGM, this.Scgm);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_FT, this.Ft);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_QTXGQL,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_QLQSSJ, this.Qlqssj);
				command.Parameters.AddWithValue(PARAM_QLJSSJ, this.Qljssj);
				command.Parameters.AddWithValue(PARAM_QSFS, this.Qsfs);
				command.Parameters.AddWithValue(PARAM_SYLX, this.Sylx);
				command.Parameters.AddWithValue(PARAM_QSL, this.Qsl);
				command.Parameters.AddWithValue(PARAM_QSYT, this.Qsyt);
				command.Parameters.AddWithValue(PARAM_KCMJ, this.Kcmj);
				command.Parameters.AddWithValue(PARAM_KCFS, this.Kcfs);
				command.Parameters.AddWithValue(PARAM_KCKZ, this.Kckz);
				command.Parameters.AddWithValue(PARAM_SCGM, this.Scgm);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
				command.Parameters.AddWithValue(PARAM_FT, this.Ft);
				command.Parameters.AddWithValue(PARAM_QSZT, this.Qszt);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_QTXGQL,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_QTXGQL,dao.Connection))
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
			if (!reader.IsDBNull(2)) bdcdyh = reader.GetString(2);
			if (!reader.IsDBNull(3)) ywh = reader.GetString(3);
			if (!reader.IsDBNull(4)) qllx = reader.GetString(4);
			if (!reader.IsDBNull(5)) djlx = reader.GetString(5);
			if (!reader.IsDBNull(6)) djyy = reader.GetString(6);
			if (!reader.IsDBNull(7)) qlqssj = reader.GetDateTime(7);
			if (!reader.IsDBNull(8)) qljssj = reader.GetDateTime(8);
			if (!reader.IsDBNull(9)) qsfs = reader.GetString(9);
			if (!reader.IsDBNull(10)) sylx = reader.GetString(10);
			if (!reader.IsDBNull(11)) qsl = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) qsyt = reader.GetString(12);
			if (!reader.IsDBNull(13)) kcmj = reader.GetDouble(13);
			if (!reader.IsDBNull(14)) kcfs = reader.GetString(14);
			if (!reader.IsDBNull(15)) kckz = reader.GetString(15);
			if (!reader.IsDBNull(16)) scgm = reader.GetString(16);
			if (!reader.IsDBNull(17)) bdcqzh = reader.GetString(17);
			if (!reader.IsDBNull(18)) qxdm = reader.GetString(18);
			if (!reader.IsDBNull(19)) djjg = reader.GetString(19);
			if (!reader.IsDBNull(20)) dbr = reader.GetString(20);
			if (!reader.IsDBNull(21)) djsj = reader.GetDateTime(21);
			if (!reader.IsDBNull(22)) fj = reader.GetString(22);
			if (!reader.IsDBNull(23)) ft = SQLiteHelper.GetBytes(reader,"FT");
			if (!reader.IsDBNull(24)) qszt = reader.GetString(24);
			if (!reader.IsDBNull(25)) databaseid = reader.GetInt64(25);
			if (!reader.IsDBNull(26)) flags = reader.GetInt16(26);
			if (!reader.IsDBNull(27)) xgr = reader.GetString(27);
			if (!reader.IsDBNull(28)) xgsj = reader.GetDateTime(28);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Qtxgql target=new Qtxgql();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Qlqssj=this.Qlqssj;
            target.Qljssj=this.Qljssj;
            target.Qsfs=this.Qsfs;
            target.Sylx=this.Sylx;
            target.Qsl=this.Qsl;
            target.Qsyt=this.Qsyt;
            target.Kcmj=this.Kcmj;
            target.Kcfs=this.Kcfs;
            target.Kckz=this.Kckz;
            target.Scgm=this.Scgm;
            target.Bdcqzh=this.Bdcqzh;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Fj=this.Fj;
            target.Ft=this.Ft;
            target.Qszt=this.Qszt;
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
