
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
    public partial class Fdcq3 : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "FDCQ3";	
        public const string LAYER_NAME = "建筑物区分所有权业主共有部分";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YSDM = "YSDM";
		public const string COL_BDCDYH = "BDCDYH";
		public const string COL_YWH = "YWH";
		public const string COL_QLLX = "QLLX";
		public const string COL_JGZWBH = "JGZWBH";
		public const string COL_JGZWMC = "JGZWMC";
		public const string COL_JGZWSL = "JGZWSL";
		public const string COL_JGZWMJ = "JGZWMJ";
		public const string COL_FTTDMJ = "FTTDMJ";
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
        public const string PARAM_BDCDYH = "@BDCDYH";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_QLLX = "@QLLX";	
        public const string PARAM_JGZWBH = "@JGZWBH";	
        public const string PARAM_JGZWMC = "@JGZWMC";	
        public const string PARAM_JGZWSL = "@JGZWSL";	
        public const string PARAM_JGZWMJ = "@JGZWMJ";	
        public const string PARAM_FTTDMJ = "@FTTDMJ";	
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
		private const string SQL_QUERY_FDCQ3 ="SELECT  Id,YSDM,BDCDYH,YWH,QLLX,JGZWBH,JGZWMC,JGZWSL,JGZWMJ,FTTDMJ,QXDM,DJJG,DBR,DJSJ,FJ,QSZT,DatabaseId,FLAGS,XGR,XGSJ FROM FDCQ3 WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_FDCQ3 = "INSERT INTO [FDCQ3] (YSDM, BDCDYH, YWH, QLLX, JGZWBH, JGZWMC, JGZWSL, JGZWMJ, FTTDMJ, QXDM, DJJG, DBR, DJSJ, FJ, QSZT, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YSDM, @BDCDYH, @YWH, @QLLX, @JGZWBH, @JGZWMC, @JGZWSL, @JGZWMJ, @FTTDMJ, @QXDM, @DJJG, @DBR, @DJSJ, @FJ, @QSZT, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_FDCQ3 = "UPDATE [FDCQ3] SET YSDM = @YSDM, BDCDYH = @BDCDYH, YWH = @YWH, QLLX = @QLLX, JGZWBH = @JGZWBH, JGZWMC = @JGZWMC, JGZWSL = @JGZWSL, JGZWMJ = @JGZWMJ, FTTDMJ = @FTTDMJ, QXDM = @QXDM, DJJG = @DJJG, DBR = @DBR, DJSJ = @DJSJ, FJ = @FJ, QSZT = @QSZT, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_FDCQ3 = "DELETE FROM [FDCQ3] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_FDCQ3 = "UPDATE [FDCQ3] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
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
        ///建（构）筑物编号
		protected string jgzwbh = default(string);
        ///建（构）筑物名称
		protected string jgzwmc = default(string);
        ///建（构）筑物数量
		protected long? jgzwsl = default(long?);
        ///建（构）筑物面积
		protected double? jgzwmj = default(double?);
        ///分摊土地面积
		protected double? fttdmj = default(double?);
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
            get{return "Fdcq3";}
        }
         public string LayerName
        {
            get{return "建筑物区分所有权业主共有部分";}
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
                return string.Format("{0} {1} ({2})","FDCQ3",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","建筑物区分所有权业主共有部分",this.id,this.ysdm);
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
		
        ///建（构）筑物编号
        ///[Column(COL_JGZWBH, PARAM_JGZWBH )]
        public virtual string Jgzwbh 
        {
            get { return this.jgzwbh; }
			set	{ 
                  if(this.jgzwbh != value)
                    {
                        this.OnPropertyChanging("Jgzwbh"); 
                        this.jgzwbh = value;                        
                        this.OnPropertyChanged("Jgzwbh");
                    }   
                }
        }	
		
        ///建（构）筑物名称
        ///[Column(COL_JGZWMC, PARAM_JGZWMC )]
        public virtual string Jgzwmc 
        {
            get { return this.jgzwmc; }
			set	{ 
                  if(this.jgzwmc != value)
                    {
                        this.OnPropertyChanging("Jgzwmc"); 
                        this.jgzwmc = value;                        
                        this.OnPropertyChanged("Jgzwmc");
                    }   
                }
        }	
		
        ///建（构）筑物数量
        ///[Column(COL_JGZWSL, PARAM_JGZWSL )]
        public virtual long? Jgzwsl 
        {
            get { return this.jgzwsl; }
			set	{ 
                  if(this.jgzwsl != value)
                    {
                        this.OnPropertyChanging("Jgzwsl"); 
                        this.jgzwsl = value;                        
                        this.OnPropertyChanged("Jgzwsl");
                    }   
                }
        }	
		
        ///建（构）筑物面积
        ///[Column(COL_JGZWMJ, PARAM_JGZWMJ )]
        public virtual double? Jgzwmj 
        {
            get { return this.jgzwmj; }
			set	{ 
                  if(this.jgzwmj != value)
                    {
                        this.OnPropertyChanging("Jgzwmj"); 
                        this.jgzwmj = value;                        
                        this.OnPropertyChanged("Jgzwmj");
                    }   
                }
        }	
		
        ///分摊土地面积
        ///[Column(COL_FTTDMJ, PARAM_FTTDMJ )]
        public virtual double? Fttdmj 
        {
            get { return this.fttdmj; }
			set	{ 
                  if(this.fttdmj != value)
                    {
                        this.OnPropertyChanging("Fttdmj"); 
                        this.fttdmj = value;                        
                        this.OnPropertyChanged("Fttdmj");
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
        public Fdcq3()
        {
            this.id=0;
            this.ysdm="";
            this.bdcdyh="";
            this.ywh="";
            this.qllx="";
            this.jgzwbh="";
            this.jgzwmc="";
            this.jgzwsl=0;
            this.jgzwmj=0.0;
            this.fttdmj=0.0;
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
            Fdcq3 record = obj as Fdcq3;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_FDCQ3,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_BDCDYH, this.Bdcdyh);
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_QLLX, this.Qllx);
				command.Parameters.AddWithValue(PARAM_JGZWBH, this.Jgzwbh);
				command.Parameters.AddWithValue(PARAM_JGZWMC, this.Jgzwmc);
				command.Parameters.AddWithValue(PARAM_JGZWSL, this.Jgzwsl);
				command.Parameters.AddWithValue(PARAM_JGZWMJ, this.Jgzwmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_FDCQ3,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_JGZWBH, this.Jgzwbh);
				command.Parameters.AddWithValue(PARAM_JGZWMC, this.Jgzwmc);
				command.Parameters.AddWithValue(PARAM_JGZWSL, this.Jgzwsl);
				command.Parameters.AddWithValue(PARAM_JGZWMJ, this.Jgzwmj);
				command.Parameters.AddWithValue(PARAM_FTTDMJ, this.Fttdmj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FDCQ3,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_FDCQ3,dao.Connection))
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
			if (!reader.IsDBNull(5)) jgzwbh = reader.GetString(5);
			if (!reader.IsDBNull(6)) jgzwmc = reader.GetString(6);
			if (!reader.IsDBNull(7)) jgzwsl = reader.GetInt64(7);
			if (!reader.IsDBNull(8)) jgzwmj = reader.GetDouble(8);
			if (!reader.IsDBNull(9)) fttdmj = reader.GetDouble(9);
			if (!reader.IsDBNull(10)) qxdm = reader.GetString(10);
			if (!reader.IsDBNull(11)) djjg = reader.GetString(11);
			if (!reader.IsDBNull(12)) dbr = reader.GetString(12);
			if (!reader.IsDBNull(13)) djsj = reader.GetDateTime(13);
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
            Fdcq3 target=new Fdcq3();
            target.ID=0;
            target.Ysdm=this.Ysdm;
            target.Bdcdyh=this.Bdcdyh;
            target.Ywh=this.Ywh;
            target.Qllx=this.Qllx;
            target.Jgzwbh=this.Jgzwbh;
            target.Jgzwmc=this.Jgzwmc;
            target.Jgzwsl=this.Jgzwsl;
            target.Jgzwmj=this.Jgzwmj;
            target.Fttdmj=this.Fttdmj;
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
