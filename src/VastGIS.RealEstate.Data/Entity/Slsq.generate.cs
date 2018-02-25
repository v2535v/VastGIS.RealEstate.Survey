
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
    public partial class Slsq : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SLSQ";	
        public const string LAYER_NAME = "受理申请";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_YWH = "YWH";
		public const string COL_DJDL = "DJDL";
		public const string COL_DJXL = "DJXL";
		public const string COL_SQZSBS = "SQZSBS";
		public const string COL_SQFBCZ = "SQFBCZ";
		public const string COL_QXDM = "QXDM";
		public const string COL_SLRY = "SLRY";
		public const string COL_SLSJ = "SLSJ";
		public const string COL_ZL = "ZL";
		public const string COL_TZRXM = "TZRXM";
		public const string COL_TZFS = "TZFS";
		public const string COL_TZRDH = "TZRDH";
		public const string COL_TZRYDDH = "TZRYDDH";
		public const string COL_TZRDZYJ = "TZRDZYJ";
		public const string COL_SFWTAJ = "SFWTAJ";
		public const string COL_JSSJ = "JSSJ";
		public const string COL_AJZT = "AJZT";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_DJDL = "@DJDL";	
        public const string PARAM_DJXL = "@DJXL";	
        public const string PARAM_SQZSBS = "@SQZSBS";	
        public const string PARAM_SQFBCZ = "@SQFBCZ";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_SLRY = "@SLRY";	
        public const string PARAM_SLSJ = "@SLSJ";	
        public const string PARAM_ZL = "@ZL";	
        public const string PARAM_TZRXM = "@TZRXM";	
        public const string PARAM_TZFS = "@TZFS";	
        public const string PARAM_TZRDH = "@TZRDH";	
        public const string PARAM_TZRYDDH = "@TZRYDDH";	
        public const string PARAM_TZRDZYJ = "@TZRDZYJ";	
        public const string PARAM_SFWTAJ = "@SFWTAJ";	
        public const string PARAM_JSSJ = "@JSSJ";	
        public const string PARAM_AJZT = "@AJZT";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SLSQ ="SELECT  Id,YSDM,YWH,DJDL,DJXL,SQZSBS,SQFBCZ,QXDM,SLRY,SLSJ,ZL,TZRXM,TZFS,TZRDH,TZRYDDH,TZRDZYJ,SFWTAJ,JSSJ,AJZT,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SLSQ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SLSQ = "INSERT INTO [SLSQ] (YSDM, YWH, DJDL, DJXL, SQZSBS, SQFBCZ, QXDM, SLRY, SLSJ, ZL, TZRXM, TZFS, TZRDH, TZRYDDH, TZRDZYJ, SFWTAJ, JSSJ, AJZT, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @YWH, @DJDL, @DJXL, @SQZSBS, @SQFBCZ, @QXDM, @SLRY, @SLSJ, @ZL, @TZRXM, @TZFS, @TZRDH, @TZRYDDH, @TZRDZYJ, @SFWTAJ, @JSSJ, @AJZT, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SLSQ = "UPDATE [SLSQ] SET YSDM = @YSDM, YWH = @YWH, DJDL = @DJDL, DJXL = @DJXL, SQZSBS = @SQZSBS, SQFBCZ = @SQFBCZ, QXDM = @QXDM, SLRY = @SLRY, SLSJ = @SLSJ, ZL = @ZL, TZRXM = @TZRXM, TZFS = @TZFS, TZRDH = @TZRDH, TZRYDDH = @TZRYDDH, TZRDZYJ = @TZRDZYJ, SFWTAJ = @SFWTAJ, JSSJ = @JSSJ, AJZT = @AJZT, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SLSQ = "DELETE FROM [SLSQ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SLSQ = "UPDATE [SLSQ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///要素代码
		protected string ysdm = default(string);
        ///业务号
		protected string ywh = default(string);
        ///登记大类[字典:登记类型字典表-DJLXZD]
		protected string djdl = default(string);
        ///登记小类
		protected string djxl = default(string);
        ///申请证书版式[字典:证书版式字典表-ZSBSZD]
		protected long? sqzsbs = default(long?);
        ///申请分别持证[字典:是否字典表-SFZD]
		protected long? sqfbcz = default(long?);
        ///区县代码[字典:区县字典表-VG_AREACODES]
		protected string qxdm = default(string);
        ///受理人员
		protected string slry = default(string);
        ///受理时间
		protected System.DateTime? slsj = default(System.DateTime?);
        ///坐落
		protected string zl = default(string);
        ///通知人姓名
		protected string tzrxm = default(string);
        ///通知方式[字典:通知方式字典表-TZFSZD]
		protected string tzfs = default(string);
        ///通知人电话
		protected string tzrdh = default(string);
        ///通知人移动电话
		protected string tzryddh = default(string);
        ///通知人电子邮件
		protected string tzrdzyj = default(string);
        ///是否问题案件[字典:是否字典表-SFZD]
		protected string sfwtaj = default(string);
        ///结束时间
		protected System.DateTime? jssj = default(System.DateTime?);
        ///案件状态[字典:案件状态字典表-AJZTZD]
		protected string ajzt = default(string);
        ///备注
		protected string bz = default(string);
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
            get{return "Slsq";}
        }
         public string LayerName
        {
            get{return "受理申请";}
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
                return string.Format("{0} {1} ({2})","SLSQ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","受理申请",this.id,this.ysdm);
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
		
        ///登记大类
        ///[Column(COL_DJDL, PARAM_DJDL )]
        public virtual string Djdl 
        {
            get { return this.djdl; }
			set	{ 
                  if(this.djdl != value)
                    {
                        this.OnPropertyChanging("Djdl"); 
                        this.djdl = value;                        
                        this.OnPropertyChanged("Djdl");
                    }   
                }
        }	
		
        ///登记小类
        ///[Column(COL_DJXL, PARAM_DJXL )]
        public virtual string Djxl 
        {
            get { return this.djxl; }
			set	{ 
                  if(this.djxl != value)
                    {
                        this.OnPropertyChanging("Djxl"); 
                        this.djxl = value;                        
                        this.OnPropertyChanged("Djxl");
                    }   
                }
        }	
		
        ///申请证书版式
        ///[Column(COL_SQZSBS, PARAM_SQZSBS )]
        public virtual long? Sqzsbs 
        {
            get { return this.sqzsbs; }
			set	{ 
                  if(this.sqzsbs != value)
                    {
                        this.OnPropertyChanging("Sqzsbs"); 
                        this.sqzsbs = value;                        
                        this.OnPropertyChanged("Sqzsbs");
                    }   
                }
        }	
		
        ///申请分别持证
        ///[Column(COL_SQFBCZ, PARAM_SQFBCZ )]
        public virtual long? Sqfbcz 
        {
            get { return this.sqfbcz; }
			set	{ 
                  if(this.sqfbcz != value)
                    {
                        this.OnPropertyChanging("Sqfbcz"); 
                        this.sqfbcz = value;                        
                        this.OnPropertyChanged("Sqfbcz");
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
		
        ///受理人员
        ///[Column(COL_SLRY, PARAM_SLRY )]
        public virtual string Slry 
        {
            get { return this.slry; }
			set	{ 
                  if(this.slry != value)
                    {
                        this.OnPropertyChanging("Slry"); 
                        this.slry = value;                        
                        this.OnPropertyChanged("Slry");
                    }   
                }
        }	
		
        ///受理时间
        ///[Column(COL_SLSJ, PARAM_SLSJ )]
        public virtual System.DateTime? Slsj 
        {
            get { return this.slsj; }
			set	{ 
                  if(this.slsj != value)
                    {
                        this.OnPropertyChanging("Slsj"); 
                        this.slsj = value;                        
                        this.OnPropertyChanged("Slsj");
                    }   
                }
        }	
		
        ///坐落
        ///[Column(COL_ZL, PARAM_ZL )]
        public virtual string Zl 
        {
            get { return this.zl; }
			set	{ 
                  if(this.zl != value)
                    {
                        this.OnPropertyChanging("Zl"); 
                        this.zl = value;                        
                        this.OnPropertyChanged("Zl");
                    }   
                }
        }	
		
        ///通知人姓名
        ///[Column(COL_TZRXM, PARAM_TZRXM )]
        public virtual string Tzrxm 
        {
            get { return this.tzrxm; }
			set	{ 
                  if(this.tzrxm != value)
                    {
                        this.OnPropertyChanging("Tzrxm"); 
                        this.tzrxm = value;                        
                        this.OnPropertyChanged("Tzrxm");
                    }   
                }
        }	
		
        ///通知方式
        ///[Column(COL_TZFS, PARAM_TZFS )]
        public virtual string Tzfs 
        {
            get { return this.tzfs; }
			set	{ 
                  if(this.tzfs != value)
                    {
                        this.OnPropertyChanging("Tzfs"); 
                        this.tzfs = value;                        
                        this.OnPropertyChanged("Tzfs");
                    }   
                }
        }	
		
        ///通知人电话
        ///[Column(COL_TZRDH, PARAM_TZRDH )]
        public virtual string Tzrdh 
        {
            get { return this.tzrdh; }
			set	{ 
                  if(this.tzrdh != value)
                    {
                        this.OnPropertyChanging("Tzrdh"); 
                        this.tzrdh = value;                        
                        this.OnPropertyChanged("Tzrdh");
                    }   
                }
        }	
		
        ///通知人移动电话
        ///[Column(COL_TZRYDDH, PARAM_TZRYDDH )]
        public virtual string Tzryddh 
        {
            get { return this.tzryddh; }
			set	{ 
                  if(this.tzryddh != value)
                    {
                        this.OnPropertyChanging("Tzryddh"); 
                        this.tzryddh = value;                        
                        this.OnPropertyChanged("Tzryddh");
                    }   
                }
        }	
		
        ///通知人电子邮件
        ///[Column(COL_TZRDZYJ, PARAM_TZRDZYJ )]
        public virtual string Tzrdzyj 
        {
            get { return this.tzrdzyj; }
			set	{ 
                  if(this.tzrdzyj != value)
                    {
                        this.OnPropertyChanging("Tzrdzyj"); 
                        this.tzrdzyj = value;                        
                        this.OnPropertyChanged("Tzrdzyj");
                    }   
                }
        }	
		
        ///是否问题案件
        ///[Column(COL_SFWTAJ, PARAM_SFWTAJ )]
        public virtual string Sfwtaj 
        {
            get { return this.sfwtaj; }
			set	{ 
                  if(this.sfwtaj != value)
                    {
                        this.OnPropertyChanging("Sfwtaj"); 
                        this.sfwtaj = value;                        
                        this.OnPropertyChanged("Sfwtaj");
                    }   
                }
        }	
		
        ///结束时间
        ///[Column(COL_JSSJ, PARAM_JSSJ )]
        public virtual System.DateTime? Jssj 
        {
            get { return this.jssj; }
			set	{ 
                  if(this.jssj != value)
                    {
                        this.OnPropertyChanging("Jssj"); 
                        this.jssj = value;                        
                        this.OnPropertyChanged("Jssj");
                    }   
                }
        }	
		
        ///案件状态
        ///[Column(COL_AJZT, PARAM_AJZT )]
        public virtual string Ajzt 
        {
            get { return this.ajzt; }
			set	{ 
                  if(this.ajzt != value)
                    {
                        this.OnPropertyChanging("Ajzt"); 
                        this.ajzt = value;                        
                        this.OnPropertyChanged("Ajzt");
                    }   
                }
        }	
		
        ///备注
        ///[Column(COL_BZ, PARAM_BZ )]
        public virtual string Bz 
        {
            get { return this.bz; }
			set	{ 
                  if(this.bz != value)
                    {
                        this.OnPropertyChanging("Bz"); 
                        this.bz = value;                        
                        this.OnPropertyChanged("Bz");
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
        public Slsq()
        {
            this.id=0;
            this.ysdm="";
            this.ywh="";
            this.djdl="";
            this.djxl="";
            this.sqzsbs=0;
            this.sqfbcz=0;
            this.qxdm="";
            this.slry="";
            this.slsj=DateTime.Now;
            this.zl="";
            this.tzrxm="";
            this.tzfs="";
            this.tzrdh="";
            this.tzryddh="";
            this.tzrdzyj="";
            this.sfwtaj="";
            this.jssj=DateTime.Now;
            this.ajzt="";
            this.bz="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Slsq record = obj as Slsq;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SLSQ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_DJDL, this.Djdl);
				command.Parameters.AddWithValue(PARAM_DJXL, this.Djxl);
				command.Parameters.AddWithValue(PARAM_SQZSBS, this.Sqzsbs);
				command.Parameters.AddWithValue(PARAM_SQFBCZ, this.Sqfbcz);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_SLRY, this.Slry);
				command.Parameters.AddWithValue(PARAM_SLSJ, this.Slsj);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_TZRXM, this.Tzrxm);
				command.Parameters.AddWithValue(PARAM_TZFS, this.Tzfs);
				command.Parameters.AddWithValue(PARAM_TZRDH, this.Tzrdh);
				command.Parameters.AddWithValue(PARAM_TZRYDDH, this.Tzryddh);
				command.Parameters.AddWithValue(PARAM_TZRDZYJ, this.Tzrdzyj);
				command.Parameters.AddWithValue(PARAM_SFWTAJ, this.Sfwtaj);
				command.Parameters.AddWithValue(PARAM_JSSJ, this.Jssj);
				command.Parameters.AddWithValue(PARAM_AJZT, this.Ajzt);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SLSQ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_DJDL, this.Djdl);
				command.Parameters.AddWithValue(PARAM_DJXL, this.Djxl);
				command.Parameters.AddWithValue(PARAM_SQZSBS, this.Sqzsbs);
				command.Parameters.AddWithValue(PARAM_SQFBCZ, this.Sqfbcz);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_SLRY, this.Slry);
				command.Parameters.AddWithValue(PARAM_SLSJ, this.Slsj);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_TZRXM, this.Tzrxm);
				command.Parameters.AddWithValue(PARAM_TZFS, this.Tzfs);
				command.Parameters.AddWithValue(PARAM_TZRDH, this.Tzrdh);
				command.Parameters.AddWithValue(PARAM_TZRYDDH, this.Tzryddh);
				command.Parameters.AddWithValue(PARAM_TZRDZYJ, this.Tzrdzyj);
				command.Parameters.AddWithValue(PARAM_SFWTAJ, this.Sfwtaj);
				command.Parameters.AddWithValue(PARAM_JSSJ, this.Jssj);
				command.Parameters.AddWithValue(PARAM_AJZT, this.Ajzt);
				command.Parameters.AddWithValue(PARAM_BZ, this.Bz);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SLSQ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SLSQ,dao.Connection))
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
			if (!reader.IsDBNull(2)) ywh = reader.GetString(2);
			if (!reader.IsDBNull(3)) djdl = reader.GetString(3);
			if (!reader.IsDBNull(4)) djxl = reader.GetString(4);
			if (!reader.IsDBNull(5)) sqzsbs = reader.GetInt64(5);
			if (!reader.IsDBNull(6)) sqfbcz = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) qxdm = reader.GetString(7);
			if (!reader.IsDBNull(8)) slry = reader.GetString(8);
			if (!reader.IsDBNull(9)) slsj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) zl = reader.GetString(10);
			if (!reader.IsDBNull(11)) tzrxm = reader.GetString(11);
			if (!reader.IsDBNull(12)) tzfs = reader.GetString(12);
			if (!reader.IsDBNull(13)) tzrdh = reader.GetString(13);
			if (!reader.IsDBNull(14)) tzryddh = reader.GetString(14);
			if (!reader.IsDBNull(15)) tzrdzyj = reader.GetString(15);
			if (!reader.IsDBNull(16)) sfwtaj = reader.GetString(16);
			if (!reader.IsDBNull(17)) jssj = reader.GetDateTime(17);
			if (!reader.IsDBNull(18)) ajzt = reader.GetString(18);
			if (!reader.IsDBNull(19)) bz = reader.GetString(19);
			if (!reader.IsDBNull(20)) databaseid = reader.GetInt64(20);
			if (!reader.IsDBNull(21)) flags = reader.GetInt16(21);
			if (!reader.IsDBNull(22)) xgr = reader.GetString(22);
			if (!reader.IsDBNull(23)) xgsj = reader.GetDateTime(23);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Slsq target=new Slsq();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Ywh=this.Ywh;
            target.Djdl=this.Djdl;
            target.Djxl=this.Djxl;
            target.Sqzsbs=this.Sqzsbs;
            target.Sqfbcz=this.Sqfbcz;
            target.Qxdm=this.Qxdm;
            target.Slry=this.Slry;
            target.Slsj=this.Slsj;
            target.Zl=this.Zl;
            target.Tzrxm=this.Tzrxm;
            target.Tzfs=this.Tzfs;
            target.Tzrdh=this.Tzrdh;
            target.Tzryddh=this.Tzryddh;
            target.Tzrdzyj=this.Tzrdzyj;
            target.Sfwtaj=this.Sfwtaj;
            target.Jssj=this.Jssj;
            target.Ajzt=this.Ajzt;
            target.Bz=this.Bz;
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
