
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
    public partial class Gd : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "GD";	
        public const string LAYER_NAME = "归档";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_DJDL = "DJDL";
		public const string COL_DJXL = "DJXL";
		public const string COL_ZL = "ZL";
		public const string COL_QZHM = "QZHM";
		public const string COL_WJJS = "WJJS";
		public const string COL_ZYS = "ZYS";
		public const string COL_GDRY = "GDRY";
		public const string COL_GDSJ = "GDSJ";
		public const string COL_BZ = "BZ";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_DJDL = "@DJDL";	
        public const string PARAM_DJXL = "@DJXL";	
        public const string PARAM_ZL = "@ZL";	
        public const string PARAM_QZHM = "@QZHM";	
        public const string PARAM_WJJS = "@WJJS";	
        public const string PARAM_ZYS = "@ZYS";	
        public const string PARAM_GDRY = "@GDRY";	
        public const string PARAM_GDSJ = "@GDSJ";	
        public const string PARAM_BZ = "@BZ";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_GD ="SELECT  Id,YWH,YSDM,DJDL,DJXL,ZL,QZHM,WJJS,ZYS,GDRY,GDSJ,BZ,DatabaseId,FLAGS,XGR,XGSJ FROM GD WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_GD = "INSERT INTO [GD] (YWH, YSDM, DJDL, DJXL, ZL, QZHM, WJJS, ZYS, GDRY, GDSJ, BZ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @DJDL, @DJXL, @ZL, @QZHM, @WJJS, @ZYS, @GDRY, @GDSJ, @BZ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_GD = "UPDATE [GD] SET YWH = @YWH, YSDM = @YSDM, DJDL = @DJDL, DJXL = @DJXL, ZL = @ZL, QZHM = @QZHM, WJJS = @WJJS, ZYS = @ZYS, GDRY = @GDRY, GDSJ = @GDSJ, BZ = @BZ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_GD = "DELETE FROM [GD] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_GD = "UPDATE [GD] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///登记大类[字典:登记类型字典表-DJLXZD]
		protected string djdl = default(string);
        ///登记小类
		protected long? djxl = default(long?);
        ///坐落
		protected string zl = default(string);
        ///权证号码
		protected string qzhm = default(string);
        ///文件件数
		protected long? wjjs = default(long?);
        ///总页数
		protected long? zys = default(long?);
        ///归档人员
		protected string gdry = default(string);
        ///归档时间
		protected System.DateTime? gdsj = default(System.DateTime?);
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
            get{return "Gd";}
        }
         public string LayerName
        {
            get{return "归档";}
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
                return string.Format("{0} {1} ({2})","GD",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","归档",this.id,this.ysdm);
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
        public virtual long? Djxl 
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
		
        ///权证号码
        ///[Column(COL_QZHM, PARAM_QZHM )]
        public virtual string Qzhm 
        {
            get { return this.qzhm; }
			set	{ 
                  if(this.qzhm != value)
                    {
                        this.OnPropertyChanging("Qzhm"); 
                        this.qzhm = value;                        
                        this.OnPropertyChanged("Qzhm");
                    }   
                }
        }	
		
        ///文件件数
        ///[Column(COL_WJJS, PARAM_WJJS )]
        public virtual long? Wjjs 
        {
            get { return this.wjjs; }
			set	{ 
                  if(this.wjjs != value)
                    {
                        this.OnPropertyChanging("Wjjs"); 
                        this.wjjs = value;                        
                        this.OnPropertyChanged("Wjjs");
                    }   
                }
        }	
		
        ///总页数
        ///[Column(COL_ZYS, PARAM_ZYS )]
        public virtual long? Zys 
        {
            get { return this.zys; }
			set	{ 
                  if(this.zys != value)
                    {
                        this.OnPropertyChanging("Zys"); 
                        this.zys = value;                        
                        this.OnPropertyChanged("Zys");
                    }   
                }
        }	
		
        ///归档人员
        ///[Column(COL_GDRY, PARAM_GDRY )]
        public virtual string Gdry 
        {
            get { return this.gdry; }
			set	{ 
                  if(this.gdry != value)
                    {
                        this.OnPropertyChanging("Gdry"); 
                        this.gdry = value;                        
                        this.OnPropertyChanged("Gdry");
                    }   
                }
        }	
		
        ///归档时间
        ///[Column(COL_GDSJ, PARAM_GDSJ )]
        public virtual System.DateTime? Gdsj 
        {
            get { return this.gdsj; }
			set	{ 
                  if(this.gdsj != value)
                    {
                        this.OnPropertyChanging("Gdsj"); 
                        this.gdsj = value;                        
                        this.OnPropertyChanged("Gdsj");
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
        public Gd()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.djdl="";
            this.djxl=0;
            this.zl="";
            this.qzhm="";
            this.wjjs=0;
            this.zys=0;
            this.gdry="";
            this.gdsj=DateTime.Now;
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
            Gd record = obj as Gd;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_GD,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_DJDL, this.Djdl);
				command.Parameters.AddWithValue(PARAM_DJXL, this.Djxl);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_QZHM, this.Qzhm);
				command.Parameters.AddWithValue(PARAM_WJJS, this.Wjjs);
				command.Parameters.AddWithValue(PARAM_ZYS, this.Zys);
				command.Parameters.AddWithValue(PARAM_GDRY, this.Gdry);
				command.Parameters.AddWithValue(PARAM_GDSJ, this.Gdsj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_GD,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_DJDL, this.Djdl);
				command.Parameters.AddWithValue(PARAM_DJXL, this.Djxl);
				command.Parameters.AddWithValue(PARAM_ZL, this.Zl);
				command.Parameters.AddWithValue(PARAM_QZHM, this.Qzhm);
				command.Parameters.AddWithValue(PARAM_WJJS, this.Wjjs);
				command.Parameters.AddWithValue(PARAM_ZYS, this.Zys);
				command.Parameters.AddWithValue(PARAM_GDRY, this.Gdry);
				command.Parameters.AddWithValue(PARAM_GDSJ, this.Gdsj);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_GD,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_GD,dao.Connection))
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
			if (!reader.IsDBNull(3)) djdl = reader.GetString(3);
			if (!reader.IsDBNull(4)) djxl = reader.GetInt64(4);
			if (!reader.IsDBNull(5)) zl = reader.GetString(5);
			if (!reader.IsDBNull(6)) qzhm = reader.GetString(6);
			if (!reader.IsDBNull(7)) wjjs = reader.GetInt64(7);
			if (!reader.IsDBNull(8)) zys = reader.GetInt64(8);
			if (!reader.IsDBNull(9)) gdry = reader.GetString(9);
			if (!reader.IsDBNull(10)) gdsj = reader.GetDateTime(10);
			if (!reader.IsDBNull(11)) bz = reader.GetString(11);
			if (!reader.IsDBNull(12)) databaseid = reader.GetInt64(12);
			if (!reader.IsDBNull(13)) flags = reader.GetInt16(13);
			if (!reader.IsDBNull(14)) xgr = reader.GetString(14);
			if (!reader.IsDBNull(15)) xgsj = reader.GetDateTime(15);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Gd target=new Gd();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Djdl=this.Djdl;
            target.Djxl=this.Djxl;
            target.Zl=this.Zl;
            target.Qzhm=this.Qzhm;
            target.Wjjs=this.Wjjs;
            target.Zys=this.Zys;
            target.Gdry=this.Gdry;
            target.Gdsj=this.Gdsj;
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
