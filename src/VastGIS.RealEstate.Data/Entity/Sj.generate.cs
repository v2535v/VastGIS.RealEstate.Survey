
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
    public partial class Sj : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SJ";	
        public const string LAYER_NAME = "收件";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_SJSJ = "SJSJ";
		public const string COL_SJLX = "SJLX";
		public const string COL_SJMC = "SJMC";
		public const string COL_SJSL = "SJSL";
		public const string COL_SFSJSY = "SFSJSY";
		public const string COL_SFEWSJ = "SFEWSJ";
		public const string COL_SFBCSJ = "SFBCSJ";
		public const string COL_YS = "YS";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_SJSJ = "@SJSJ";	
        public const string PARAM_SJLX = "@SJLX";	
        public const string PARAM_SJMC = "@SJMC";	
        public const string PARAM_SJSL = "@SJSL";	
        public const string PARAM_SFSJSY = "@SFSJSY";	
        public const string PARAM_SFEWSJ = "@SFEWSJ";	
        public const string PARAM_SFBCSJ = "@SFBCSJ";	
        public const string PARAM_YS = "@YS";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SJ ="SELECT  Id,YWH,YSDM,SJSJ,SJLX,SJMC,SJSL,SFSJSY,SFEWSJ,SFBCSJ,YS,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM SJ WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SJ = "INSERT INTO [SJ] (YWH, YSDM, SJSJ, SJLX, SJMC, SJSL, SFSJSY, SFEWSJ, SFBCSJ, YS, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @SJSJ, @SJLX, @SJMC, @SJSL, @SFSJSY, @SFEWSJ, @SFBCSJ, @YS, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SJ = "UPDATE [SJ] SET YWH = @YWH, YSDM = @YSDM, SJSJ = @SJSJ, SJLX = @SJLX, SJMC = @SJMC, SJSL = @SJSL, SFSJSY = @SFSJSY, SFEWSJ = @SFEWSJ, SFBCSJ = @SFBCSJ, YS = @YS, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SJ = "DELETE FROM [SJ] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SJ = "UPDATE [SJ] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///收件时间
		protected System.DateTime? sjsj = default(System.DateTime?);
        ///收件类型[字典:收件类型字典表-SJLXZD]
		protected string sjlx = default(string);
        ///收件名称
		protected string sjmc = default(string);
        ///收件数量
		protected long? sjsl = default(long?);
        ///是否收缴收验[字典:是否字典表-SFZD]
		protected string sfsjsy = default(string);
        ///是否额外收件[字典:是否字典表-SFZD]
		protected string sfewsj = default(string);
        ///是否补充收件[字典:是否字典表-SFZD]
		protected string sfbcsj = default(string);
        ///页数
		protected long? ys = default(long?);
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
            get{return "Sj";}
        }
         public string LayerName
        {
            get{return "收件";}
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
                return string.Format("{0} {1} ({2})","SJ",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","收件",this.id,this.ysdm);
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
		
        ///收件时间
        ///[Column(COL_SJSJ, PARAM_SJSJ )]
        public virtual System.DateTime? Sjsj 
        {
            get { return this.sjsj; }
			set	{ 
                  if(this.sjsj != value)
                    {
                        this.OnPropertyChanging("Sjsj"); 
                        this.sjsj = value;                        
                        this.OnPropertyChanged("Sjsj");
                    }   
                }
        }	
		
        ///收件类型
        ///[Column(COL_SJLX, PARAM_SJLX )]
        public virtual string Sjlx 
        {
            get { return this.sjlx; }
			set	{ 
                  if(this.sjlx != value)
                    {
                        this.OnPropertyChanging("Sjlx"); 
                        this.sjlx = value;                        
                        this.OnPropertyChanged("Sjlx");
                    }   
                }
        }	
		
        ///收件名称
        ///[Column(COL_SJMC, PARAM_SJMC )]
        public virtual string Sjmc 
        {
            get { return this.sjmc; }
			set	{ 
                  if(this.sjmc != value)
                    {
                        this.OnPropertyChanging("Sjmc"); 
                        this.sjmc = value;                        
                        this.OnPropertyChanged("Sjmc");
                    }   
                }
        }	
		
        ///收件数量
        ///[Column(COL_SJSL, PARAM_SJSL )]
        public virtual long? Sjsl 
        {
            get { return this.sjsl; }
			set	{ 
                  if(this.sjsl != value)
                    {
                        this.OnPropertyChanging("Sjsl"); 
                        this.sjsl = value;                        
                        this.OnPropertyChanged("Sjsl");
                    }   
                }
        }	
		
        ///是否收缴收验
        ///[Column(COL_SFSJSY, PARAM_SFSJSY )]
        public virtual string Sfsjsy 
        {
            get { return this.sfsjsy; }
			set	{ 
                  if(this.sfsjsy != value)
                    {
                        this.OnPropertyChanging("Sfsjsy"); 
                        this.sfsjsy = value;                        
                        this.OnPropertyChanged("Sfsjsy");
                    }   
                }
        }	
		
        ///是否额外收件
        ///[Column(COL_SFEWSJ, PARAM_SFEWSJ )]
        public virtual string Sfewsj 
        {
            get { return this.sfewsj; }
			set	{ 
                  if(this.sfewsj != value)
                    {
                        this.OnPropertyChanging("Sfewsj"); 
                        this.sfewsj = value;                        
                        this.OnPropertyChanged("Sfewsj");
                    }   
                }
        }	
		
        ///是否补充收件
        ///[Column(COL_SFBCSJ, PARAM_SFBCSJ )]
        public virtual string Sfbcsj 
        {
            get { return this.sfbcsj; }
			set	{ 
                  if(this.sfbcsj != value)
                    {
                        this.OnPropertyChanging("Sfbcsj"); 
                        this.sfbcsj = value;                        
                        this.OnPropertyChanged("Sfbcsj");
                    }   
                }
        }	
		
        ///页数
        ///[Column(COL_YS, PARAM_YS )]
        public virtual long? Ys 
        {
            get { return this.ys; }
			set	{ 
                  if(this.ys != value)
                    {
                        this.OnPropertyChanging("Ys"); 
                        this.ys = value;                        
                        this.OnPropertyChanged("Ys");
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
        public Sj()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.sjsj=DateTime.Now;
            this.sjlx="";
            this.sjmc="";
            this.sjsl=0;
            this.sfsjsy="";
            this.sfewsj="";
            this.sfbcsj="";
            this.ys=0;
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
            Sj record = obj as Sj;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SJ,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SJSJ, this.Sjsj);
				command.Parameters.AddWithValue(PARAM_SJLX, this.Sjlx);
				command.Parameters.AddWithValue(PARAM_SJMC, this.Sjmc);
				command.Parameters.AddWithValue(PARAM_SJSL, this.Sjsl);
				command.Parameters.AddWithValue(PARAM_SFSJSY, this.Sfsjsy);
				command.Parameters.AddWithValue(PARAM_SFEWSJ, this.Sfewsj);
				command.Parameters.AddWithValue(PARAM_SFBCSJ, this.Sfbcsj);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SJ,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_SJSJ, this.Sjsj);
				command.Parameters.AddWithValue(PARAM_SJLX, this.Sjlx);
				command.Parameters.AddWithValue(PARAM_SJMC, this.Sjmc);
				command.Parameters.AddWithValue(PARAM_SJSL, this.Sjsl);
				command.Parameters.AddWithValue(PARAM_SFSJSY, this.Sfsjsy);
				command.Parameters.AddWithValue(PARAM_SFEWSJ, this.Sfewsj);
				command.Parameters.AddWithValue(PARAM_SFBCSJ, this.Sfbcsj);
				command.Parameters.AddWithValue(PARAM_YS, this.Ys);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SJ,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SJ,dao.Connection))
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
			if (!reader.IsDBNull(1)) ywh = reader.GetString(1);
			if (!reader.IsDBNull(2)) ysdm = reader.GetString(2);
			if (!reader.IsDBNull(3)) sjsj = reader.GetDateTime(3);
			if (!reader.IsDBNull(4)) sjlx = reader.GetString(4);
			if (!reader.IsDBNull(5)) sjmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) sjsl = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) sfsjsy = reader.GetString(7);
			if (!reader.IsDBNull(8)) sfewsj = reader.GetString(8);
			if (!reader.IsDBNull(9)) sfbcsj = reader.GetString(9);
			if (!reader.IsDBNull(10)) ys = reader.GetInt64(10);
			if (!reader.IsDBNull(11)) bz = reader.GetString(11);
			if (!reader.IsDBNull(12)) databaseid = reader.GetInt64(12);
			if (!reader.IsDBNull(13)) flags = reader.GetInt16(13);
			if (!reader.IsDBNull(14)) xgr = reader.GetString(14);
			if (!reader.IsDBNull(15)) xgsj = reader.GetDateTime(15);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Sj target=new Sj();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Sjsj=this.Sjsj;
            target.Sjlx=this.Sjlx;
            target.Sjmc=this.Sjmc;
            target.Sjsl=this.Sjsl;
            target.Sfsjsy=this.Sfsjsy;
            target.Sfewsj=this.Sfewsj;
            target.Sfbcsj=this.Sfbcsj;
            target.Ys=this.Ys;
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
