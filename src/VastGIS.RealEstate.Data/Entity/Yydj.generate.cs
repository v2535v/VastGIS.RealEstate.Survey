
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
    public partial class Yydj : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "YYDJ";	
        public const string LAYER_NAME = "异议登记";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_YYSX = "YYSX";
		public const string COL_BDCDJZMH = "BDCDJZMH";
		public const string COL_QXDM = "QXDM";
		public const string COL_DJJG = "DJJG";
		public const string COL_DBR = "DBR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_ZXYYYWH = "ZXYYYWH";
		public const string COL_ZXYYYY = "ZXYYYY";
		public const string COL_ZXYYDBR = "ZXYYDBR";
		public const string COL_ZXYYDJSJ = "ZXYYDJSJ";
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
        public const string PARAM_YYSX = "@YYSX";	
        public const string PARAM_BDCDJZMH = "@BDCDJZMH";	
        public const string PARAM_QXDM = "@QXDM";	
        public const string PARAM_DJJG = "@DJJG";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_ZXYYYWH = "@ZXYYYWH";	
        public const string PARAM_ZXYYYY = "@ZXYYYY";	
        public const string PARAM_ZXYYDBR = "@ZXYYDBR";	
        public const string PARAM_ZXYYDJSJ = "@ZXYYDJSJ";	
        public const string PARAM_FJ = "@FJ";	
        public const string PARAM_QSZT = "@QSZT";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_YYDJ ="SELECT  Id,YSDM,BDCDYH,YWH,YYSX,BDCDJZMH,QXDM,DJJG,DBR,DJSJ,ZXYYYWH,ZXYYYY,ZXYYDBR,ZXYYDJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM YYDJ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_YYDJ = "INSERT INTO [YYDJ] (YSDM, BDCDYH, YWH, YYSX, BDCDJZMH, QXDM, DJJG, DBR, DJSJ, ZXYYYWH, ZXYYYY, ZXYYDBR, ZXYYDJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @YYSX, @BDCDJZMH, @QXDM, @DJJG, @DBR, @DJSJ, @ZXYYYWH, @ZXYYYY, @ZXYYDBR, @ZXYYDJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_YYDJ = "UPDATE [YYDJ] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, YYSX = @YYSX, BDCDJZMH = @BDCDJZMH, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, ZXYYYWH = @ZXYYYWH, ZXYYYY = @ZXYYYY, ZXYYDBR = @ZXYYDBR, ZXYYDJSJ = @ZXYYDJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_YYDJ = "DELETE FROM [YYDJ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_YYDJ = "UPDATE [YYDJ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///异议事项
		protected string yysx = default(string);
        ///不动产登记证明号
		protected string bdcdjzmh = default(string);
        ///区县代码[字典:区县字典表-VG_AREACODES]
		protected string qxdm = default(string);
        ///登记机构
		protected string djjg = default(string);
        ///登簿人
		protected string dbr = default(string);
        ///登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        ///注销异议业务号
		protected string zxyyywh = default(string);
        ///注销异议原因
		protected string zxyyyy = default(string);
        ///注销异议登簿人
		protected string zxyydbr = default(string);
        ///注销异议登记时间
		protected System.DateTime? zxyydjsj = default(System.DateTime?);
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
            get{return "Yydj";}
        }
         public string LayerName
        {
            get{return "异议登记";}
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
                return string.Format("{0} {1} ({2})","YYDJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","异议登记",this.id,this.ysdm);
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
		
        ///异议事项
        ///[Column(COL_YYSX, PARAM_YYSX )]
        public virtual string Yysx 
        {
            get { return this.yysx; }
			set	{ 
                  if(this.yysx != value)
                    {
                        this.OnPropertyChanging("Yysx"); 
                        this.yysx = value;                        
                        this.OnPropertyChanged("Yysx");
                    }   
                }
        }	
		
        ///不动产登记证明号
        ///[Column(COL_BDCDJZMH, PARAM_BDCDJZMH )]
        public virtual string Bdcdjzmh 
        {
            get { return this.bdcdjzmh; }
			set	{ 
                  if(this.bdcdjzmh != value)
                    {
                        this.OnPropertyChanging("Bdcdjzmh"); 
                        this.bdcdjzmh = value;                        
                        this.OnPropertyChanged("Bdcdjzmh");
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
		
        ///注销异议业务号
        ///[Column(COL_ZXYYYWH, PARAM_ZXYYYWH )]
        public virtual string Zxyyywh 
        {
            get { return this.zxyyywh; }
			set	{ 
                  if(this.zxyyywh != value)
                    {
                        this.OnPropertyChanging("Zxyyywh"); 
                        this.zxyyywh = value;                        
                        this.OnPropertyChanged("Zxyyywh");
                    }   
                }
        }	
		
        ///注销异议原因
        ///[Column(COL_ZXYYYY, PARAM_ZXYYYY )]
        public virtual string Zxyyyy 
        {
            get { return this.zxyyyy; }
			set	{ 
                  if(this.zxyyyy != value)
                    {
                        this.OnPropertyChanging("Zxyyyy"); 
                        this.zxyyyy = value;                        
                        this.OnPropertyChanged("Zxyyyy");
                    }   
                }
        }	
		
        ///注销异议登簿人
        ///[Column(COL_ZXYYDBR, PARAM_ZXYYDBR )]
        public virtual string Zxyydbr 
        {
            get { return this.zxyydbr; }
			set	{ 
                  if(this.zxyydbr != value)
                    {
                        this.OnPropertyChanging("Zxyydbr"); 
                        this.zxyydbr = value;                        
                        this.OnPropertyChanged("Zxyydbr");
                    }   
                }
        }	
		
        ///注销异议登记时间
        ///[Column(COL_ZXYYDJSJ, PARAM_ZXYYDJSJ )]
        public virtual System.DateTime? Zxyydjsj 
        {
            get { return this.zxyydjsj; }
			set	{ 
                  if(this.zxyydjsj != value)
                    {
                        this.OnPropertyChanging("Zxyydjsj"); 
                        this.zxyydjsj = value;                        
                        this.OnPropertyChanged("Zxyydjsj");
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
        public Yydj()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.yysx="";
            this.bdcdjzmh="";
            this.qxdm="";
            this.djjg="";
            this.dbr="";
            this.djsj=DateTime.Now;
            this.zxyyywh="";
            this.zxyyyy="";
            this.zxyydbr="";
            this.zxyydjsj=DateTime.Now;
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
            Yydj record = obj as Yydj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_YYDJ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YYSX, this.Yysx);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_ZXYYYWH, this.Zxyyywh);
				command.Parameters.AddWithValue(PARAM_ZXYYYY, this.Zxyyyy);
				command.Parameters.AddWithValue(PARAM_ZXYYDBR, this.Zxyydbr);
				command.Parameters.AddWithValue(PARAM_ZXYYDJSJ, this.Zxyydjsj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_YYDJ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YYSX, this.Yysx);
				command.Parameters.AddWithValue(PARAM_BDCDJZMH, this.Bdcdjzmh);
				command.Parameters.AddWithValue(PARAM_QXDM, this.Qxdm);
				command.Parameters.AddWithValue(PARAM_DJJG, this.Djjg);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_ZXYYYWH, this.Zxyyywh);
				command.Parameters.AddWithValue(PARAM_ZXYYYY, this.Zxyyyy);
				command.Parameters.AddWithValue(PARAM_ZXYYDBR, this.Zxyydbr);
				command.Parameters.AddWithValue(PARAM_ZXYYDJSJ, this.Zxyydjsj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_YYDJ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_YYDJ,dao.Connection))
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
			if (!reader.IsDBNull(4)) yysx = reader.GetString(4);
			if (!reader.IsDBNull(5)) bdcdjzmh = reader.GetString(5);
			if (!reader.IsDBNull(6)) qxdm = reader.GetString(6);
			if (!reader.IsDBNull(7)) djjg = reader.GetString(7);
			if (!reader.IsDBNull(8)) dbr = reader.GetString(8);
			if (!reader.IsDBNull(9)) djsj = reader.GetDateTime(9);
			if (!reader.IsDBNull(10)) zxyyywh = reader.GetString(10);
			if (!reader.IsDBNull(11)) zxyyyy = reader.GetString(11);
			if (!reader.IsDBNull(12)) zxyydbr = reader.GetString(12);
			if (!reader.IsDBNull(13)) zxyydjsj = reader.GetDateTime(13);
			if (!reader.IsDBNull(14)) fj = reader.GetString(14);
			if (!reader.IsDBNull(15)) qszt = reader.GetString(15);
			if (!reader.IsDBNull(16)) databaseid = reader.GetInt64(16);
			if (!reader.IsDBNull(17)) flags = reader.GetInt16(17);
			if (!reader.IsDBNull(18)) xgr = reader.GetString(18);
			if (!reader.IsDBNull(19)) xgsj = reader.GetDateTime(19);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Yydj target=new Yydj();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Yysx=this.Yysx;
            target.Bdcdjzmh=this.Bdcdjzmh;
            target.Qxdm=this.Qxdm;
            target.Djjg=this.Djjg;
            target.Dbr=this.Dbr;
            target.Djsj=this.Djsj;
            target.Zxyyywh=this.Zxyyywh;
            target.Zxyyyy=this.Zxyyyy;
            target.Zxyydbr=this.Zxyydbr;
            target.Zxyydjsj=this.Zxyydjsj;
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
