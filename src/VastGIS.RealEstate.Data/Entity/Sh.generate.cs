
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
    public partial class Sh : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity,IYsdmEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "SH";	
        public const string LAYER_NAME = "审核";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_YWH = "YWH";
		public const string COL_YSDM = "YSDM";
		public const string COL_JDMC = "JDMC";
		public const string COL_SXH = "SXH";
		public const string COL_SHRYXM = "SHRYXM";
		public const string COL_SHKSSJ = "SHKSSJ";
		public const string COL_SHJSSJ = "SHJSSJ";
		public const string COL_SHYJ = "SHYJ";
		public const string COL_CZJG = "CZJG";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_YWH = "@YWH";	
        public const string PARAM_YSDM = "@YSDM";	
        public const string PARAM_JDMC = "@JDMC";	
        public const string PARAM_SXH = "@SXH";	
        public const string PARAM_SHRYXM = "@SHRYXM";	
        public const string PARAM_SHKSSJ = "@SHKSSJ";	
        public const string PARAM_SHJSSJ = "@SHJSSJ";	
        public const string PARAM_SHYJ = "@SHYJ";	
        public const string PARAM_CZJG = "@CZJG";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_SH ="SELECT  Id,YWH,YSDM,JDMC,SXH,SHRYXM,SHKSSJ,SHJSSJ,SHYJ,CZJG,DatabaseId,FLAGS,XGR,XGSJ FROM SH WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_SH = "INSERT INTO [SH] (YWH, YSDM, JDMC, SXH, SHRYXM, SHKSSJ, SHJSSJ, SHYJ, CZJG, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @YWH, @YSDM, @JDMC, @SXH, @SHRYXM, @SHKSSJ, @SHJSSJ, @SHYJ, @CZJG, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_SH = "UPDATE [SH] SET YWH = @YWH, YSDM = @YSDM, JDMC = @JDMC, SXH = @SXH, SHRYXM = @SHRYXM, SHKSSJ = @SHKSSJ, SHJSSJ = @SHJSSJ, SHYJ = @SHYJ, CZJG = @CZJG, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_SH = "DELETE FROM [SH] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_SH = "UPDATE [SH] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///业务号
		protected string ywh = default(string);
        ///要素代码
		protected string ysdm = default(string);
        ///节点名称
		protected string jdmc = default(string);
        ///顺序号
		protected long? sxh = default(long?);
        ///审核人员姓名
		protected string shryxm = default(string);
        ///审核开始时间
		protected System.DateTime? shkssj = default(System.DateTime?);
        ///审核结束时间
		protected System.DateTime? shjssj = default(System.DateTime?);
        ///审核意见
		protected string shyj = default(string);
        ///操作结果[字典:审核意见操作结果字典表-SHYJCZJGZD]
		protected string czjg = default(string);
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
            get{return "Sh";}
        }
         public string LayerName
        {
            get{return "审核";}
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
                return string.Format("{0} {1} ({2})","SH",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","审核",this.id,this.ysdm);
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
		
        ///节点名称
        ///[Column(COL_JDMC, PARAM_JDMC )]
        public virtual string Jdmc 
        {
            get { return this.jdmc; }
			set	{ 
                  if(this.jdmc != value)
                    {
                        this.OnPropertyChanging("Jdmc"); 
                        this.jdmc = value;                        
                        this.OnPropertyChanged("Jdmc");
                    }   
                }
        }	
		
        ///顺序号
        ///[Column(COL_SXH, PARAM_SXH )]
        public virtual long? Sxh 
        {
            get { return this.sxh; }
			set	{ 
                  if(this.sxh != value)
                    {
                        this.OnPropertyChanging("Sxh"); 
                        this.sxh = value;                        
                        this.OnPropertyChanged("Sxh");
                    }   
                }
        }	
		
        ///审核人员姓名
        ///[Column(COL_SHRYXM, PARAM_SHRYXM )]
        public virtual string Shryxm 
        {
            get { return this.shryxm; }
			set	{ 
                  if(this.shryxm != value)
                    {
                        this.OnPropertyChanging("Shryxm"); 
                        this.shryxm = value;                        
                        this.OnPropertyChanged("Shryxm");
                    }   
                }
        }	
		
        ///审核开始时间
        ///[Column(COL_SHKSSJ, PARAM_SHKSSJ )]
        public virtual System.DateTime? Shkssj 
        {
            get { return this.shkssj; }
			set	{ 
                  if(this.shkssj != value)
                    {
                        this.OnPropertyChanging("Shkssj"); 
                        this.shkssj = value;                        
                        this.OnPropertyChanged("Shkssj");
                    }   
                }
        }	
		
        ///审核结束时间
        ///[Column(COL_SHJSSJ, PARAM_SHJSSJ )]
        public virtual System.DateTime? Shjssj 
        {
            get { return this.shjssj; }
			set	{ 
                  if(this.shjssj != value)
                    {
                        this.OnPropertyChanging("Shjssj"); 
                        this.shjssj = value;                        
                        this.OnPropertyChanged("Shjssj");
                    }   
                }
        }	
		
        ///审核意见
        ///[Column(COL_SHYJ, PARAM_SHYJ )]
        public virtual string Shyj 
        {
            get { return this.shyj; }
			set	{ 
                  if(this.shyj != value)
                    {
                        this.OnPropertyChanging("Shyj"); 
                        this.shyj = value;                        
                        this.OnPropertyChanged("Shyj");
                    }   
                }
        }	
		
        ///操作结果
        ///[Column(COL_CZJG, PARAM_CZJG )]
        public virtual string Czjg 
        {
            get { return this.czjg; }
			set	{ 
                  if(this.czjg != value)
                    {
                        this.OnPropertyChanging("Czjg"); 
                        this.czjg = value;                        
                        this.OnPropertyChanged("Czjg");
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
        public Sh()
        {
            this.id=0;
            this.ywh="";
            this.ysdm="";
            this.jdmc="";
            this.sxh=0;
            this.shryxm="";
            this.shkssj=DateTime.Now;
            this.shjssj=DateTime.Now;
            this.shyj="";
            this.czjg="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Sh record = obj as Sh;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_SH,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_YWH, this.Ywh);
				command.Parameters.AddWithValue(PARAM_YSDM, this.Ysdm);
				command.Parameters.AddWithValue(PARAM_JDMC, this.Jdmc);
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
				command.Parameters.AddWithValue(PARAM_SHRYXM, this.Shryxm);
				command.Parameters.AddWithValue(PARAM_SHKSSJ, this.Shkssj);
				command.Parameters.AddWithValue(PARAM_SHJSSJ, this.Shjssj);
				command.Parameters.AddWithValue(PARAM_SHYJ, this.Shyj);
				command.Parameters.AddWithValue(PARAM_CZJG, this.Czjg);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_SH,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_JDMC, this.Jdmc);
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
				command.Parameters.AddWithValue(PARAM_SHRYXM, this.Shryxm);
				command.Parameters.AddWithValue(PARAM_SHKSSJ, this.Shkssj);
				command.Parameters.AddWithValue(PARAM_SHJSSJ, this.Shjssj);
				command.Parameters.AddWithValue(PARAM_SHYJ, this.Shyj);
				command.Parameters.AddWithValue(PARAM_CZJG, this.Czjg);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_SH,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_SH,dao.Connection))
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
			if (!reader.IsDBNull(3)) jdmc = reader.GetString(3);
			if (!reader.IsDBNull(4)) sxh = reader.GetInt64(4);
			if (!reader.IsDBNull(5)) shryxm = reader.GetString(5);
			if (!reader.IsDBNull(6)) shkssj = reader.GetDateTime(6);
			if (!reader.IsDBNull(7)) shjssj = reader.GetDateTime(7);
			if (!reader.IsDBNull(8)) shyj = reader.GetString(8);
			if (!reader.IsDBNull(9)) czjg = reader.GetString(9);
			if (!reader.IsDBNull(10)) databaseid = reader.GetInt64(10);
			if (!reader.IsDBNull(11)) flags = reader.GetInt16(11);
			if (!reader.IsDBNull(12)) xgr = reader.GetString(12);
			if (!reader.IsDBNull(13)) xgsj = reader.GetDateTime(13);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Sh target=new Sh();
            target.ID=0;
            target.Ywh=this.Ywh;
            target.Ysdm=this.Ysdm;
            target.Jdmc=this.Jdmc;
            target.Sxh=this.Sxh;
            target.Shryxm=this.Shryxm;
            target.Shkssj=this.Shkssj;
            target.Shjssj=this.Shjssj;
            target.Shyj=this.Shyj;
            target.Czjg=this.Czjg;
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
