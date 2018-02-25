
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
    public partial class Hysyq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "HYSYQ";	
        public const string LAYER_NAME = "海域(含无居民海岛)使用权";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_ZHHDDM = "ZHHDDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_DJLX = "DJLX";
		public const string COL_DJYY = "DJYY";
		public const string COL_SYQMJ = "SYQMJ";
		public const string COL_SYQQSSJ = "SYQQSSJ";
		public const string COL_SYQJSSJ = "SYQJSSJ";
		public const string COL_SYJZE = "SYJZE";
		public const string COL_SYJBZYJ = "SYJBZYJ";
		public const string COL_SYJJNQK = "SYJJNQK";
		public const string COL_BDCQZH = "BDCQZH";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_FJ = "FJ";
		public const string COL_QSZT = "QSZT";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_ZHHDDM = "@ZHHDDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_DJLX = "@DJLX";	
        public const string PARAM_DJYY = "@DJYY";	
        public const string PARAM_SYQMJ = "@SYQMJ";	
        public const string PARAM_SYQQSSJ = "@SYQQSSJ";	
        public const string PARAM_SYQJSSJ = "@SYQJSSJ";	
        public const string PARAM_SYJZE = "@SYJZE";	
        public const string PARAM_SYJBZYJ = "@SYJBZYJ";	
        public const string PARAM_SYJJNQK = "@SYJJNQK";	
        public const string PARAM_BDCQZH = "@BDCQZH";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_HYSYQ ="SELECT  Id,YSDM,ZHHDDM,BDCDYH,YWH,QLLX,DJLX,DJYY,SYQMJ,SYQQSSJ,SYQJSSJ,SYJZE,SYJBZYJ,SYJJNQK,BDCQZH,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM HYSYQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_HYSYQ = "INSERT INTO [HYSYQ] (YSDM, ZHHDDM, BDCDYH, YWH, QLLX, DJLX, DJYY, SYQMJ, SYQQSSJ, SYQJSSJ, SYJZE, SYJBZYJ, SYJJNQK, BDCQZH, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @ZHHDDM, @BDCDYH, @YWH, @QLLX, @DJLX, @DJYY, @SYQMJ, @SYQQSSJ, @SYQJSSJ, @SYJZE, @SYJBZYJ, @SYJJNQK, @BDCQZH, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_HYSYQ = "UPDATE [HYSYQ] SET YSDM = @YSDM, ZHHDDM = @ZHHDDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, DJLX = @DJLX, DJYY = @DJYY, SYQMJ = @SYQMJ, SYQQSSJ = @SYQQSSJ, SYQJSSJ = @SYQJSSJ, SYJZE = @SYJZE, SYJBZYJ = @SYJBZYJ, SYJJNQK = @SYJJNQK, BDCQZH = @BDCQZH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_HYSYQ = "DELETE FROM [HYSYQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_HYSYQ = "UPDATE [HYSYQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///宗海/海岛代码
		protected string zhhddm = default(string);
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
        ///使用权面积
		protected double? syqmj = default(double?);
        ///使用权起始时间
		protected System.DateTime? syqqssj = default(System.DateTime?);
        ///使用权结束时间
		protected System.DateTime? syqjssj = default(System.DateTime?);
        ///使用金总额
		protected double? syjze = default(double?);
        ///使用金标准依据
		protected string syjbzyj = default(string);
        ///使用金缴纳情况
		protected string syjjnqk = default(string);
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
            get{return "Hysyq";}
        }
         public string LayerName
        {
            get{return "海域(含无居民海岛)使用权";}
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
                return string.Format("{0} {1} ({2})","HYSYQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","海域(含无居民海岛)使用权",this.id,this.ysdm);
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
		
        ///宗海/海岛代码
        ///[Column(COL_ZHHDDM, PARAM_ZHHDDM )]
        public virtual string Zhhddm 
        {
            get { return this.zhhddm; }
			set	{ 
                  if(this.zhhddm != value)
                    {
                        this.OnPropertyChanging("Zhhddm"); 
                        this.zhhddm = value;                        
                        this.OnPropertyChanged("Zhhddm");
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
		
        ///使用权面积
        ///[Column(COL_SYQMJ, PARAM_SYQMJ )]
        public virtual double? Syqmj 
        {
            get { return this.syqmj; }
			set	{ 
                  if(this.syqmj != value)
                    {
                        this.OnPropertyChanging("Syqmj"); 
                        this.syqmj = value;                        
                        this.OnPropertyChanged("Syqmj");
                    }   
                }
        }	
		
        ///使用权起始时间
        ///[Column(COL_SYQQSSJ, PARAM_SYQQSSJ )]
        public virtual System.DateTime? Syqqssj 
        {
            get { return this.syqqssj; }
			set	{ 
                  if(this.syqqssj != value)
                    {
                        this.OnPropertyChanging("Syqqssj"); 
                        this.syqqssj = value;                        
                        this.OnPropertyChanged("Syqqssj");
                    }   
                }
        }	
		
        ///使用权结束时间
        ///[Column(COL_SYQJSSJ, PARAM_SYQJSSJ )]
        public virtual System.DateTime? Syqjssj 
        {
            get { return this.syqjssj; }
			set	{ 
                  if(this.syqjssj != value)
                    {
                        this.OnPropertyChanging("Syqjssj"); 
                        this.syqjssj = value;                        
                        this.OnPropertyChanged("Syqjssj");
                    }   
                }
        }	
		
        ///使用金总额
        ///[Column(COL_SYJZE, PARAM_SYJZE )]
        public virtual double? Syjze 
        {
            get { return this.syjze; }
			set	{ 
                  if(this.syjze != value)
                    {
                        this.OnPropertyChanging("Syjze"); 
                        this.syjze = value;                        
                        this.OnPropertyChanged("Syjze");
                    }   
                }
        }	
		
        ///使用金标准依据
        ///[Column(COL_SYJBZYJ, PARAM_SYJBZYJ )]
        public virtual string Syjbzyj 
        {
            get { return this.syjbzyj; }
			set	{ 
                  if(this.syjbzyj != value)
                    {
                        this.OnPropertyChanging("Syjbzyj"); 
                        this.syjbzyj = value;                        
                        this.OnPropertyChanged("Syjbzyj");
                    }   
                }
        }	
		
        ///使用金缴纳情况
        ///[Column(COL_SYJJNQK, PARAM_SYJJNQK )]
        public virtual string Syjjnqk 
        {
            get { return this.syjjnqk; }
			set	{ 
                  if(this.syjjnqk != value)
                    {
                        this.OnPropertyChanging("Syjjnqk"); 
                        this.syjjnqk = value;                        
                        this.OnPropertyChanged("Syjjnqk");
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
        public Hysyq()
        {
            this.id=0;
            this.ysdm="";
            this.zhhddm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.djlx="";
            this.djyy="";
            this.syqmj=0.0;
            this.syqqssj=DateTime.Now;
            this.syqjssj=DateTime.Now;
            this.syjze=0.0;
            this.syjbzyj="";
            this.syjjnqk="";
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
            Hysyq record = obj as Hysyq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_HYSYQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_ZHHDDM, this.Zhhddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_SYQMJ, this.Syqmj);
				command.Parameters.AddWithValue(PARAM_SYQQSSJ, this.Syqqssj);
				command.Parameters.AddWithValue(PARAM_SYQJSSJ, this.Syqjssj);
				command.Parameters.AddWithValue(PARAM_SYJZE, this.Syjze);
				command.Parameters.AddWithValue(PARAM_SYJBZYJ, this.Syjbzyj);
				command.Parameters.AddWithValue(PARAM_SYJJNQK, this.Syjjnqk);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_HYSYQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZHHDDM, this.Zhhddm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_DJLX, this.Djlx);
				command.Parameters.AddWithValue(PARAM_DJYY, this.Djyy);
				command.Parameters.AddWithValue(PARAM_SYQMJ, this.Syqmj);
				command.Parameters.AddWithValue(PARAM_SYQQSSJ, this.Syqqssj);
				command.Parameters.AddWithValue(PARAM_SYQJSSJ, this.Syqjssj);
				command.Parameters.AddWithValue(PARAM_SYJZE, this.Syjze);
				command.Parameters.AddWithValue(PARAM_SYJBZYJ, this.Syjbzyj);
				command.Parameters.AddWithValue(PARAM_SYJJNQK, this.Syjjnqk);
				command.Parameters.AddWithValue(PARAM_BDCQZH, this.Bdcqzh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_FJ, this.Fj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_HYSYQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_HYSYQ,dao.Connection))
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
			if (!reader.IsDBNull(2)) zhhddm = reader.GetString(2);
			if (!reader.IsDBNull(3)) bdcdyh = reader.GetString(3);
			if (!reader.IsDBNull(4)) ywh = reader.GetString(4);
			if (!reader.IsDBNull(5)) qllx = reader.GetString(5);
			if (!reader.IsDBNull(6)) djlx = reader.GetString(6);
			if (!reader.IsDBNull(7)) djyy = reader.GetString(7);
			if (!reader.IsDBNull(8)) syqmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) syqqssj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) syqjssj = reader.GetDateTime(10);
			if (!reader.IsDBNull(11)) syjze = reader.GetDouble(11);
			if (!reader.IsDBNull(12)) syjbzyj = reader.GetString(12);
			if (!reader.IsDBNull(13)) syjjnqk = reader.GetString(13);
			if (!reader.IsDBNull(14)) bdcqzh = reader.GetString(14);
			if (!reader.IsDBNull(15)) qxdm = reader.GetString(15);
			if (!reader.IsDBNull(16)) djjg = reader.GetString(16);
			if (!reader.IsDBNull(17)) dbr = reader.GetString(17);
			if (!reader.IsDBNull(18)) djsj = reader.GetDateTime(18);
			if (!reader.IsDBNull(19)) fj = reader.GetString(19);
			if (!reader.IsDBNull(20)) qszt = reader.GetString(20);
			if (!reader.IsDBNull(21)) databaseid = reader.GetInt64(21);
			if (!reader.IsDBNull(22)) flags = reader.GetInt16(22);
			if (!reader.IsDBNull(23)) xgr = reader.GetString(23);
			if (!reader.IsDBNull(24)) xgsj = reader.GetDateTime(24);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Hysyq target=new Hysyq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Zhhddm=this.Zhhddm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Djlx=this.Djlx;
            target.Djyy=this.Djyy;
            target.Syqmj=this.Syqmj;
            target.Syqqssj=this.Syqqssj;
            target.Syqjssj=this.Syqjssj;
            target.Syjze=this.Syjze;
            target.Syjbzyj=this.Syjbzyj;
            target.Syjjnqk=this.Syjjnqk;
            target.Bdcqzh=this.Bdcqzh;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Fj=this.Fj;
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
