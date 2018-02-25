
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
    public partial class Yhzk : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "YHZK";	
        public const string LAYER_NAME = "用海状况";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_ZHDM = "ZHDM";
		public const string COL_YHFS = "YHFS";
		public const string COL_YHMJ = "YHMJ";
		public const string COL_JTYT = "JTYT";
		public const string COL_SYJSE = "SYJSE";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_ZHDM = "@ZHDM";	
        public const string PARAM_YHFS = "@YHFS";	
        public const string PARAM_YHMJ = "@YHMJ";	
        public const string PARAM_JTYT = "@JTYT";	
        public const string PARAM_SYJSE = "@SYJSE";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_YHZK ="SELECT  Id,ZHDM,YHFS,YHMJ,JTYT,SYJSE,DatabaseId,FLAGS,XGR,XGSJ FROM YHZK WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_YHZK = "INSERT INTO [YHZK] (ZHDM, YHFS, YHMJ, JTYT, SYJSE, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @ZHDM, @YHFS, @YHMJ, @JTYT, @SYJSE, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_YHZK = "UPDATE [YHZK] SET ZHDM = @ZHDM, YHFS = @YHFS, YHMJ = @YHMJ, JTYT = @JTYT, SYJSE = @SYJSE, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_YHZK = "DELETE FROM [YHZK] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_YHZK = "UPDATE [YHZK] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///宗海代码
		protected string zhdm = default(string);
        ///用海方式[字典:用海方式字典表-YHFSZD]
		protected string yhfs = default(string);
        ///用海面积
		protected double? yhmj = default(double?);
        ///具体用途
		protected string jtyt = default(string);
        ///使用金数额
		protected double? syjse = default(double?);
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
            get{return "Yhzk";}
        }
         public string LayerName
        {
            get{return "用海状况";}
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
                return string.Format("{0} {1} ","YHZK",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","用海状况",this.id);
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
		
        ///用海方式
        ///[Column(COL_YHFS, PARAM_YHFS )]
        public virtual string Yhfs 
        {
            get { return this.yhfs; }
			set	{ 
                  if(this.yhfs != value)
                    {
                        this.OnPropertyChanging("Yhfs"); 
                        this.yhfs = value;                        
                        this.OnPropertyChanged("Yhfs");
                    }   
                }
        }	
		
        ///用海面积
        ///[Column(COL_YHMJ, PARAM_YHMJ )]
        public virtual double? Yhmj 
        {
            get { return this.yhmj; }
			set	{ 
                  if(this.yhmj != value)
                    {
                        this.OnPropertyChanging("Yhmj"); 
                        this.yhmj = value;                        
                        this.OnPropertyChanged("Yhmj");
                    }   
                }
        }	
		
        ///具体用途
        ///[Column(COL_JTYT, PARAM_JTYT )]
        public virtual string Jtyt 
        {
            get { return this.jtyt; }
			set	{ 
                  if(this.jtyt != value)
                    {
                        this.OnPropertyChanging("Jtyt"); 
                        this.jtyt = value;                        
                        this.OnPropertyChanged("Jtyt");
                    }   
                }
        }	
		
        ///使用金数额
        ///[Column(COL_SYJSE, PARAM_SYJSE )]
        public virtual double? Syjse 
        {
            get { return this.syjse; }
			set	{ 
                  if(this.syjse != value)
                    {
                        this.OnPropertyChanging("Syjse"); 
                        this.syjse = value;                        
                        this.OnPropertyChanged("Syjse");
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
        public Yhzk()
        {
            this.id=0;
            this.zhdm="";
            this.yhfs="";
            this.yhmj=0.0;
            this.jtyt="";
            this.syjse=0.0;
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            Yhzk record = obj as Yhzk;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_YHZK,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_ZHDM, this.Zhdm);
				command.Parameters.AddWithValue(PARAM_YHFS, this.Yhfs);
				command.Parameters.AddWithValue(PARAM_YHMJ, this.Yhmj);
				command.Parameters.AddWithValue(PARAM_JTYT, this.Jtyt);
				command.Parameters.AddWithValue(PARAM_SYJSE, this.Syjse);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_YHZK,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_YHFS, this.Yhfs);
				command.Parameters.AddWithValue(PARAM_YHMJ, this.Yhmj);
				command.Parameters.AddWithValue(PARAM_JTYT, this.Jtyt);
				command.Parameters.AddWithValue(PARAM_SYJSE, this.Syjse);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_YHZK,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_YHZK,dao.Connection))
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
			if (!reader.IsDBNull(2)) yhfs = reader.GetString(2);
			if (!reader.IsDBNull(3)) yhmj = reader.GetDouble(3);
			if (!reader.IsDBNull(4)) jtyt = reader.GetString(4);
			if (!reader.IsDBNull(5)) syjse = reader.GetDouble(5);
			if (!reader.IsDBNull(6)) databaseid = reader.GetInt64(6);
			if (!reader.IsDBNull(7)) flags = reader.GetInt16(7);
			if (!reader.IsDBNull(8)) xgr = reader.GetString(8);
			if (!reader.IsDBNull(9)) xgsj = reader.GetDateTime(9);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            Yhzk target=new Yhzk();
            target.ID=0;
            target.Zhdm=this.Zhdm;
            target.Yhfs=this.Yhfs;
            target.Yhmj=this.Yhmj;
            target.Jtyt=this.Jtyt;
            target.Syjse=this.Syjse;
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
