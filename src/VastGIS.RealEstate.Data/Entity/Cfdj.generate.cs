
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
    public partial class Cfdj : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "CFDJ";	
        public const string LAYER_NAME = "查封登记";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_CFJG = "CFJG";
		public const string COL_CFLX = "CFLX";
		public const string COL_CFWJ = "CFWJ";
		public const string COL_CFWH = "CFWH";
		public const string COL_CFQSSJ = "CFQSSJ";
		public const string COL_CFJSSJ = "CFJSSJ";
		public const string COL_CFFW = "CFFW";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_JFYWH = "JFYWH";
		public const string COL_JFJG = "JFJG";
		public const string COL_JFWJ = "JFWJ";
		public const string COL_JFWH = "JFWH";
		public const string COL_JFDBR = "JFDBR";
		public const string COL_JFDJSJ = "JFDJSJ";
		public const string COL_FJ = "FJ";
		public const string COL_QSZT = "QSZT";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_CFJG = "@CFJG";	
        public const string PARAM_CFLX = "@CFLX";	
        public const string PARAM_CFWJ = "@CFWJ";	
        public const string PARAM_CFWH = "@CFWH";	
        public const string PARAM_CFQSSJ = "@CFQSSJ";	
        public const string PARAM_CFJSSJ = "@CFJSSJ";	
        public const string PARAM_CFFW = "@CFFW";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_JFYWH = "@JFYWH";	
        public const string PARAM_JFJG = "@JFJG";	
        public const string PARAM_JFWJ = "@JFWJ";	
        public const string PARAM_JFWH = "@JFWH";	
        public const string PARAM_JFDBR = "@JFDBR";	
        public const string PARAM_JFDJSJ = "@JFDJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_CFDJ ="SELECT  Id,YSDM,BDCDYH,YWH,CFJG,CFLX,CFWJ,CFWH,CFQSSJ,CFJSSJ,CFFW,QXDM,DJJG,DBR,DJSJ,JFYWH,JFJG,JFWJ,JFWH,JFDBR,JFDJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM CFDJ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_CFDJ = "INSERT INTO [CFDJ] (YSDM, BDCDYH, YWH, CFJG, CFLX, CFWJ, CFWH, CFQSSJ, CFJSSJ, CFFW, QXDM, DJJG, DBR, DJSJ, JFYWH, JFJG, JFWJ, JFWH, JFDBR, JFDJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @CFJG, @CFLX, @CFWJ, @CFWH, @CFQSSJ, @CFJSSJ, @CFFW, @QXDM, @DJJG, @DBR, @DJSJ, @JFYWH, @JFJG, @JFWJ, @JFWH, @JFDBR, @JFDJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_CFDJ = "UPDATE [CFDJ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, CFJG = @CFJG, CFLX = @CFLX, CFWJ = @CFWJ, CFWH = @CFWH, CFQSSJ = @CFQSSJ, CFJSSJ = @CFJSSJ, CFFW = @CFFW, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, JFYWH = @JFYWH, JFJG = @JFJG, JFWJ = @JFWJ, JFWH = @JFWH, JFDBR = @JFDBR, JFDJSJ = @JFDJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_CFDJ = "DELETE FROM [CFDJ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_CFDJ = "UPDATE [CFDJ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///查封机关
		protected string cfjg = default(string);
        ///查封类型[字典:查封类型字典表-CFLXZD]
		protected string cflx = default(string);
        ///查封文件
		protected byte[] cfwj = default(byte[]);
        ///查封文号
		protected string cfwh = default(string);
        ///查封起始时间
		protected System.DateTime? cfqssj = default(System.DateTime?);
        ///查封结束时间
		protected System.DateTime? cfjssj = default(System.DateTime?);
        ///查封范围
		protected string cffw = default(string);
        ///区县代码[字典:区县字典表-VG_AREACODES]
		protected string qxdm = default(string);
        ///登记机构
		protected string djjg = default(string);
        ///登簿人
		protected string dbr = default(string);
        ///登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        ///解封业务号
		protected string jfywh = default(string);
        ///解封机关
		protected string jfjg = default(string);
        ///解封文件
		protected byte[] jfwj = default(byte[]);
        ///解封文号
		protected string jfwh = default(string);
        ///解封登簿人
		protected string jfdbr = default(string);
        ///解封登记时间
		protected System.DateTime? jfdjsj = default(System.DateTime?);
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
            get{return "Cfdj";}
        }
         public string LayerName
        {
            get{return "查封登记";}
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
                return string.Format("{0} {1} ({2})","CFDJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","查封登记",this.id,this.ysdm);
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
		
        ///查封机关
        ///[Column(COL_CFJG, PARAM_CFJG )]
        public virtual string Cfjg 
        {
            get { return this.cfjg; }
			set	{ 
                  if(this.cfjg != value)
                    {
                        this.OnPropertyChanging("Cfjg"); 
                        this.cfjg = value;                        
                        this.OnPropertyChanged("Cfjg");
                    }   
                }
        }	
		
        ///查封类型
        ///[Column(COL_CFLX, PARAM_CFLX )]
        public virtual string Cflx 
        {
            get { return this.cflx; }
			set	{ 
                  if(this.cflx != value)
                    {
                        this.OnPropertyChanging("Cflx"); 
                        this.cflx = value;                        
                        this.OnPropertyChanged("Cflx");
                    }   
                }
        }	
		
        ///查封文件
        ///[Column(COL_CFWJ, PARAM_CFWJ )]
        public virtual byte[] Cfwj 
        {
            get { return this.cfwj; }
			set	{ 
                  if(this.cfwj != value)
                    {
                        this.OnPropertyChanging("Cfwj"); 
                        this.cfwj = value;                        
                        this.OnPropertyChanged("Cfwj");
                    }   
                }
        }	
		
        ///查封文号
        ///[Column(COL_CFWH, PARAM_CFWH )]
        public virtual string Cfwh 
        {
            get { return this.cfwh; }
			set	{ 
                  if(this.cfwh != value)
                    {
                        this.OnPropertyChanging("Cfwh"); 
                        this.cfwh = value;                        
                        this.OnPropertyChanged("Cfwh");
                    }   
                }
        }	
		
        ///查封起始时间
        ///[Column(COL_CFQSSJ, PARAM_CFQSSJ )]
        public virtual System.DateTime? Cfqssj 
        {
            get { return this.cfqssj; }
			set	{ 
                  if(this.cfqssj != value)
                    {
                        this.OnPropertyChanging("Cfqssj"); 
                        this.cfqssj = value;                        
                        this.OnPropertyChanged("Cfqssj");
                    }   
                }
        }	
		
        ///查封结束时间
        ///[Column(COL_CFJSSJ, PARAM_CFJSSJ )]
        public virtual System.DateTime? Cfjssj 
        {
            get { return this.cfjssj; }
			set	{ 
                  if(this.cfjssj != value)
                    {
                        this.OnPropertyChanging("Cfjssj"); 
                        this.cfjssj = value;                        
                        this.OnPropertyChanged("Cfjssj");
                    }   
                }
        }	
		
        ///查封范围
        ///[Column(COL_CFFW, PARAM_CFFW )]
        public virtual string Cffw 
        {
            get { return this.cffw; }
			set	{ 
                  if(this.cffw != value)
                    {
                        this.OnPropertyChanging("Cffw"); 
                        this.cffw = value;                        
                        this.OnPropertyChanged("Cffw");
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
		
        ///解封业务号
        ///[Column(COL_JFYWH, PARAM_JFYWH )]
        public virtual string Jfywh 
        {
            get { return this.jfywh; }
			set	{ 
                  if(this.jfywh != value)
                    {
                        this.OnPropertyChanging("Jfywh"); 
                        this.jfywh = value;                        
                        this.OnPropertyChanged("Jfywh");
                    }   
                }
        }	
		
        ///解封机关
        ///[Column(COL_JFJG, PARAM_JFJG )]
        public virtual string Jfjg 
        {
            get { return this.jfjg; }
			set	{ 
                  if(this.jfjg != value)
                    {
                        this.OnPropertyChanging("Jfjg"); 
                        this.jfjg = value;                        
                        this.OnPropertyChanged("Jfjg");
                    }   
                }
        }	
		
        ///解封文件
        ///[Column(COL_JFWJ, PARAM_JFWJ )]
        public virtual byte[] Jfwj 
        {
            get { return this.jfwj; }
			set	{ 
                  if(this.jfwj != value)
                    {
                        this.OnPropertyChanging("Jfwj"); 
                        this.jfwj = value;                        
                        this.OnPropertyChanged("Jfwj");
                    }   
                }
        }	
		
        ///解封文号
        ///[Column(COL_JFWH, PARAM_JFWH )]
        public virtual string Jfwh 
        {
            get { return this.jfwh; }
			set	{ 
                  if(this.jfwh != value)
                    {
                        this.OnPropertyChanging("Jfwh"); 
                        this.jfwh = value;                        
                        this.OnPropertyChanged("Jfwh");
                    }   
                }
        }	
		
        ///解封登簿人
        ///[Column(COL_JFDBR, PARAM_JFDBR )]
        public virtual string Jfdbr 
        {
            get { return this.jfdbr; }
			set	{ 
                  if(this.jfdbr != value)
                    {
                        this.OnPropertyChanging("Jfdbr"); 
                        this.jfdbr = value;                        
                        this.OnPropertyChanged("Jfdbr");
                    }   
                }
        }	
		
        ///解封登记时间
        ///[Column(COL_JFDJSJ, PARAM_JFDJSJ )]
        public virtual System.DateTime? Jfdjsj 
        {
            get { return this.jfdjsj; }
			set	{ 
                  if(this.jfdjsj != value)
                    {
                        this.OnPropertyChanging("Jfdjsj"); 
                        this.jfdjsj = value;                        
                        this.OnPropertyChanged("Jfdjsj");
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
        public Cfdj()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.cfjg="";
            this.cflx="";
            
            this.cfwh="";
            this.cfqssj=DateTime.Now;
            this.cfjssj=DateTime.Now;
            this.cffw="";
            this.qxdm="";
            this.djjg="";
            this.dbr="";
            this.djsj=DateTime.Now;
            this.jfywh="";
            this.jfjg="";
            
            this.jfwh="";
            this.jfdbr="";
            this.jfdjsj=DateTime.Now;
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
            Cfdj record = obj as Cfdj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_CFDJ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_CFJG, this.Cfjg);
				command.Parameters.AddWithValue(PARAM_CFLX, this.Cflx);
				command.Parameters.AddWithValue(PARAM_CFWJ, this.Cfwj);
				command.Parameters.AddWithValue(PARAM_CFWH, this.Cfwh);
				command.Parameters.AddWithValue(PARAM_CFQSSJ, this.Cfqssj);
				command.Parameters.AddWithValue(PARAM_CFJSSJ, this.Cfjssj);
				command.Parameters.AddWithValue(PARAM_CFFW, this.Cffw);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_JFYWH, this.Jfywh);
				command.Parameters.AddWithValue(PARAM_JFJG, this.Jfjg);
				command.Parameters.AddWithValue(PARAM_JFWJ, this.Jfwj);
				command.Parameters.AddWithValue(PARAM_JFWH, this.Jfwh);
				command.Parameters.AddWithValue(PARAM_JFDBR, this.Jfdbr);
				command.Parameters.AddWithValue(PARAM_JFDJSJ, this.Jfdjsj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_CFDJ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_CFJG, this.Cfjg);
				command.Parameters.AddWithValue(PARAM_CFLX, this.Cflx);
				command.Parameters.AddWithValue(PARAM_CFWJ, this.Cfwj);
				command.Parameters.AddWithValue(PARAM_CFWH, this.Cfwh);
				command.Parameters.AddWithValue(PARAM_CFQSSJ, this.Cfqssj);
				command.Parameters.AddWithValue(PARAM_CFJSSJ, this.Cfjssj);
				command.Parameters.AddWithValue(PARAM_CFFW, this.Cffw);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_JFYWH, this.Jfywh);
				command.Parameters.AddWithValue(PARAM_JFJG, this.Jfjg);
				command.Parameters.AddWithValue(PARAM_JFWJ, this.Jfwj);
				command.Parameters.AddWithValue(PARAM_JFWH, this.Jfwh);
				command.Parameters.AddWithValue(PARAM_JFDBR, this.Jfdbr);
				command.Parameters.AddWithValue(PARAM_JFDJSJ, this.Jfdjsj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_CFDJ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_CFDJ,dao.Connection))
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
			if (!reader.IsDBNull(4)) cfjg = reader.GetString(4);
			if (!reader.IsDBNull(5)) cflx = reader.GetString(5);
			if (!reader.IsDBNull(6)) cfwj = SQLiteHelper.GetBytes(reader,"CFWJ");
			if (!reader.IsDBNull(7)) cfwh = reader.GetString(7);
			if (!reader.IsDBNull(8)) cfqssj = reader.GetDateTime(8);
			if (!reader.IsDBNull(9)) cfjssj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) cffw = reader.GetString(10);
			if (!reader.IsDBNull(11)) qxdm = reader.GetString(11);
			if (!reader.IsDBNull(12)) djjg = reader.GetString(12);
			if (!reader.IsDBNull(13)) dbr = reader.GetString(13);
			if (!reader.IsDBNull(14)) djsj = reader.GetDateTime(14);
			if (!reader.IsDBNull(15)) jfywh = reader.GetString(15);
			if (!reader.IsDBNull(16)) jfjg = reader.GetString(16);
			if (!reader.IsDBNull(17)) jfwj = SQLiteHelper.GetBytes(reader,"JFWJ");
			if (!reader.IsDBNull(18)) jfwh = reader.GetString(18);
			if (!reader.IsDBNull(19)) jfdbr = reader.GetString(19);
			if (!reader.IsDBNull(20)) jfdjsj = reader.GetDateTime(20);
			if (!reader.IsDBNull(21)) fj = reader.GetString(21);
			if (!reader.IsDBNull(22)) qszt = reader.GetString(22);
			if (!reader.IsDBNull(23)) databaseid = reader.GetInt64(23);
			if (!reader.IsDBNull(24)) flags = reader.GetInt16(24);
			if (!reader.IsDBNull(25)) xgr = reader.GetString(25);
			if (!reader.IsDBNull(26)) xgsj = reader.GetDateTime(26);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Cfdj target=new Cfdj();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Cfjg=this.Cfjg;
            target.Cflx=this.Cflx;
            target.Cfwj=this.Cfwj;
            target.Cfwh=this.Cfwh;
            target.Cfqssj=this.Cfqssj;
            target.Cfjssj=this.Cfjssj;
            target.Cffw=this.Cffw;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Jfywh=this.Jfywh;
            target.Jfjg=this.Jfjg;
            target.Jfwj=this.Jfwj;
            target.Jfwh=this.Jfwh;
            target.Jfdbr=this.Jfdbr;
            target.Jfdjsj=this.Jfdjsj;
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
