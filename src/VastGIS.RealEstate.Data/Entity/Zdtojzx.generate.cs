
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
    public partial class Zdtojzx : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "ZDTOJZX";	
        public const string LAYER_NAME = "宗地界址线关系表";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_ZD_WYDM = "ZD_WYDM";
		public const string COL_JZX_WYDM = "JZX_WYDM";
		public const string COL_SXH = "SXH";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_ZD_WYDM = "@ZD_WYDM";	
        public const string PARAM_JZX_WYDM = "@JZX_WYDM";	
        public const string PARAM_SXH = "@SXH";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_ZDTOJZX ="SELECT  Id,ZD_WYDM,JZX_WYDM,SXH,DatabaseId,FLAGS,XGR,XGSJ FROM ZDTOJZX WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_ZDTOJZX = "INSERT INTO [ZDTOJZX] (ZD_WYDM, JZX_WYDM, SXH, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @ZD_WYDM, @JZX_WYDM, @SXH, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_ZDTOJZX = "UPDATE [ZDTOJZX] SET ZD_WYDM = @ZD_WYDM, JZX_WYDM = @JZX_WYDM, SXH = @SXH, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_ZDTOJZX = "DELETE FROM [ZDTOJZX] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_ZDTOJZX = "UPDATE [ZDTOJZX] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///宗地唯一代码
		protected string zdWydm = default(string);
        ///界址线唯一代码
		protected string jzxWydm = default(string);
        ///顺序号
		protected long? sxh = default(long?);
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
            get{return "Zdtojzx";}
        }
         public string LayerName
        {
            get{return "宗地界址线关系表";}
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
                return string.Format("{0} {1} ","ZDTOJZX",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","宗地界址线关系表",this.id);
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
		
        ///宗地唯一代码
        ///[Column(COL_ZD_WYDM, PARAM_ZD_WYDM )]
        public virtual string ZdWydm 
        {
            get { return this.zdWydm; }
			set	{ 
                  if(this.zdWydm != value)
                    {
                        this.OnPropertyChanging("ZdWydm"); 
                        this.zdWydm = value;                        
                        this.OnPropertyChanged("ZdWydm");
                    }   
                }
        }	
		
        ///界址线唯一代码
        ///[Column(COL_JZX_WYDM, PARAM_JZX_WYDM )]
        public virtual string JzxWydm 
        {
            get { return this.jzxWydm; }
			set	{ 
                  if(this.jzxWydm != value)
                    {
                        this.OnPropertyChanging("JzxWydm"); 
                        this.jzxWydm = value;                        
                        this.OnPropertyChanged("JzxWydm");
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
        public Zdtojzx()
        {
            this.id=0;
            this.zdWydm="";
            this.jzxWydm="";
            this.sxh=0;
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Zdtojzx record = obj as Zdtojzx;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDTOJZX,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_ZD_WYDM, this.ZdWydm);
				command.Parameters.AddWithValue(PARAM_JZX_WYDM, this.JzxWydm);
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDTOJZX,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_ZD_WYDM, this.ZdWydm);
				command.Parameters.AddWithValue(PARAM_JZX_WYDM, this.JzxWydm);
				command.Parameters.AddWithValue(PARAM_SXH, this.Sxh);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDTOJZX,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZDTOJZX,dao.Connection))
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
			if (!reader.IsDBNull(1)) zdWydm = reader.GetString(1);
			if (!reader.IsDBNull(2)) jzxWydm = reader.GetString(2);
			if (!reader.IsDBNull(3)) sxh = reader.GetInt64(3);
			if (!reader.IsDBNull(4)) databaseid = reader.GetInt64(4);
			if (!reader.IsDBNull(5)) flags = reader.GetInt16(5);
			if (!reader.IsDBNull(6)) xgr = reader.GetString(6);
			if (!reader.IsDBNull(7)) xgsj = reader.GetDateTime(7);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Zdtojzx target=new Zdtojzx();
            target.ID=0;
            target.ZdWydm=this.ZdWydm;
            target.JzxWydm=this.JzxWydm;
            target.Sxh=this.Sxh;
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
