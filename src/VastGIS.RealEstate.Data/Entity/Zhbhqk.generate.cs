
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
    public partial class Zhbhqk : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "ZHBHQK";	
        public const string LAYER_NAME = "宗海变化情况";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_ZHDM = "ZHDM";
		public const string COL_BHYY = "BHYY";
		public const string COL_BHNR = "BHNR";
		public const string COL_DJSJ = "DJSJ";
		public const string COL_DBR = "DBR";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_ZHDM = "@ZHDM";	
        public const string PARAM_BHYY = "@BHYY";	
        public const string PARAM_BHNR = "@BHNR";	
        public const string PARAM_DJSJ = "@DJSJ";	
        public const string PARAM_DBR = "@DBR";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_ZHBHQK ="SELECT  Id,ZHDM,BHYY,BHNR,DJSJ,DBR,DatabaseId,FLAGS,XGR,XGSJ FROM ZHBHQK WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_ZHBHQK = "INSERT INTO [ZHBHQK] (ZHDM, BHYY, BHNR, DJSJ, DBR, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @ZHDM, @BHYY, @BHNR, @DJSJ, @DBR, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_ZHBHQK = "UPDATE [ZHBHQK] SET ZHDM = @ZHDM, BHYY = @BHYY, BHNR = @BHNR, DJSJ = @DJSJ, DBR = @DBR, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_ZHBHQK = "DELETE FROM [ZHBHQK] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_ZHBHQK = "UPDATE [ZHBHQK] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///宗海代码
		protected string zhdm = default(string);
        ///变化原因
		protected string bhyy = default(string);
        ///变化内容
		protected string bhnr = default(string);
        ///登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        ///登簿人
		protected string dbr = default(string);
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
            get{return "Zhbhqk";}
        }
         public string LayerName
        {
            get{return "宗海变化情况";}
        }
        public string EntityName{
            get{return "IDatabaseEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return true;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return false;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZHBHQK",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","宗海变化情况",this.id);
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
		
        ///宗海代码
        ///[Column(COL_ZHDM, PARAM_ZHDM )]
        public virtual string Zhdm 
        {
            get { return this.zhdm; }
			set	{ 
                  if(this.zhdm != value)
                    {
                        this.OnPropertyChanging("Zhdm"); 
                        this.zhdm = value;                        
                        this.OnPropertyChanged("Zhdm");
                    }   
                }
        }	
		
        ///变化原因
        ///[Column(COL_BHYY, PARAM_BHYY )]
        public virtual string Bhyy 
        {
            get { return this.bhyy; }
			set	{ 
                  if(this.bhyy != value)
                    {
                        this.OnPropertyChanging("Bhyy"); 
                        this.bhyy = value;                        
                        this.OnPropertyChanged("Bhyy");
                    }   
                }
        }	
		
        ///变化内容
        ///[Column(COL_BHNR, PARAM_BHNR )]
        public virtual string Bhnr 
        {
            get { return this.bhnr; }
			set	{ 
                  if(this.bhnr != value)
                    {
                        this.OnPropertyChanging("Bhnr"); 
                        this.bhnr = value;                        
                        this.OnPropertyChanged("Bhnr");
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
        public Zhbhqk()
        {
            this.id=0;
            this.zhdm="";
            this.bhyy="";
            this.bhnr="";
            this.djsj=DateTime.Now;
            this.dbr="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Zhbhqk record = obj as Zhbhqk;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZHBHQK,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_ZHDM, this.Zhdm);
				command.Parameters.AddWithValue(PARAM_BHYY, this.Bhyy);
				command.Parameters.AddWithValue(PARAM_BHNR, this.Bhnr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZHBHQK,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZHDM, this.Zhdm);
				command.Parameters.AddWithValue(PARAM_BHYY, this.Bhyy);
				command.Parameters.AddWithValue(PARAM_BHNR, this.Bhnr);
				command.Parameters.AddWithValue(PARAM_DJSJ, this.Djsj);
				command.Parameters.AddWithValue(PARAM_DBR, this.Dbr);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZHBHQK,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZHBHQK,dao.Connection))
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
			if (!reader.IsDBNull(1)) zhdm = reader.GetString(1);
			if (!reader.IsDBNull(2)) bhyy = reader.GetString(2);
			if (!reader.IsDBNull(3)) bhnr = reader.GetString(3);
			if (!reader.IsDBNull(4)) djsj = reader.GetDateTime(4);
			if (!reader.IsDBNull(5)) dbr = reader.GetString(5);
			if (!reader.IsDBNull(6)) databaseid = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) flags = reader.GetInt16(7);
			if (!reader.IsDBNull(8)) xgr = reader.GetString(8);
			if (!reader.IsDBNull(9)) xgsj = reader.GetDateTime(9);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Zhbhqk target=new Zhbhqk();
            target.ID=0;
            target.Zhdm=this.Zhdm;
            target.Bhyy=this.Bhyy;
            target.Bhnr=this.Bhnr;
            target.Djsj=this.Djsj;
            target.Dbr=this.Dbr;
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
