
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
    public partial class VgAttachment : INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_attachment";	
        public const string LAYER_NAME = "附件";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_WX_WYDM = "WX_WYDM";
		public const string COL_FJMC = "FJMC";
		public const string COL_FJLJ = "FJLJ";
		public const string COL_FJLX = "FJLX";
		public const string COL_HQSJ = "HQSJ";
		public const string COL_FJSM = "FJSM";
		public const string COL_DATABASEID = "DatabaseId";
		public const string COL_FLAGS = "FLAGS";
		public const string COL_XGR = "XGR";
		public const string COL_XGSJ = "XGSJ";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_WX_WYDM = "@WX_WYDM";	
        public const string PARAM_FJMC = "@FJMC";	
        public const string PARAM_FJLJ = "@FJLJ";	
        public const string PARAM_FJLX = "@FJLX";	
        public const string PARAM_HQSJ = "@HQSJ";	
        public const string PARAM_FJSM = "@FJSM";	
        public const string PARAM_DATABASEID = "@DatabaseId";	
        public const string PARAM_FLAGS = "@FLAGS";	
        public const string PARAM_XGR = "@XGR";	
        public const string PARAM_XGSJ = "@XGSJ";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_ATTACHMENT ="SELECT  Id,WX_WYDM,FJMC,FJLJ,FJLX,HQSJ,FJSM,DatabaseId,FLAGS,XGR,XGSJ FROM vg_attachment WHERE [FLAGS]<3";
        
		private const string SQL_INSERT_VG_ATTACHMENT = "INSERT INTO [vg_attachment] (WX_WYDM, FJMC, FJLJ, FJLX, HQSJ, FJSM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @WX_WYDM, @FJMC, @FJLJ, @FJLX, @HQSJ, @FJSM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_ATTACHMENT = "UPDATE [vg_attachment] SET WX_WYDM = @WX_WYDM, FJMC = @FJMC, FJLJ = @FJLJ, FJLX = @FJLX, HQSJ = @HQSJ, FJSM = @FJSM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_ATTACHMENT = "DELETE FROM [vg_attachment] WHERE  Id = @Id ";
		
        private const string SQL_DELETE_FLAG_VG_ATTACHMENT = "UPDATE [vg_attachment] Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE WHERE  Id = @Id ";
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///全局唯一代码
		protected string wxWydm = default(string);
        ///附件名称
		protected string fjmc = default(string);
        ///附件路径
		protected string fjlj = default(string);
        ///附件类型[字典:附件类型字典-FJLXZD]
		protected string fjlx = default(string);
        ///获取时间
		protected System.DateTime? hqsj = default(System.DateTime?);
        ///附件说明
		protected string fjsm = default(string);
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
            get{return "VgAttachment";}
        }
         public string LayerName
        {
            get{return "附件";}
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
                return string.Format("{0} {1} ","vg_attachment",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","附件",this.id);
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
		
        ///全局唯一代码
        ///[Column(COL_WX_WYDM, PARAM_WX_WYDM )]
        public virtual string WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm"); 
                        this.wxWydm = value;                        
                        this.OnPropertyChanged("WxWydm");
                    }   
                }
        }	
		
        ///附件名称
        ///[Column(COL_FJMC, PARAM_FJMC )]
        public virtual string Fjmc 
        {
            get { return this.fjmc; }
			set	{ 
                  if(this.fjmc != value)
                    {
                        this.OnPropertyChanging("Fjmc"); 
                        this.fjmc = value;                        
                        this.OnPropertyChanged("Fjmc");
                    }   
                }
        }	
		
        ///附件路径
        ///[Column(COL_FJLJ, PARAM_FJLJ )]
        public virtual string Fjlj 
        {
            get { return this.fjlj; }
			set	{ 
                  if(this.fjlj != value)
                    {
                        this.OnPropertyChanging("Fjlj"); 
                        this.fjlj = value;                        
                        this.OnPropertyChanged("Fjlj");
                    }   
                }
        }	
		
        ///附件类型
        ///[Column(COL_FJLX, PARAM_FJLX )]
        public virtual string Fjlx 
        {
            get { return this.fjlx; }
			set	{ 
                  if(this.fjlx != value)
                    {
                        this.OnPropertyChanging("Fjlx"); 
                        this.fjlx = value;                        
                        this.OnPropertyChanged("Fjlx");
                    }   
                }
        }	
		
        ///获取时间
        ///[Column(COL_HQSJ, PARAM_HQSJ )]
        public virtual System.DateTime? Hqsj 
        {
            get { return this.hqsj; }
			set	{ 
                  if(this.hqsj != value)
                    {
                        this.OnPropertyChanging("Hqsj"); 
                        this.hqsj = value;                        
                        this.OnPropertyChanged("Hqsj");
                    }   
                }
        }	
		
        ///附件说明
        ///[Column(COL_FJSM, PARAM_FJSM )]
        public virtual string Fjsm 
        {
            get { return this.fjsm; }
			set	{ 
                  if(this.fjsm != value)
                    {
                        this.OnPropertyChanging("Fjsm"); 
                        this.fjsm = value;                        
                        this.OnPropertyChanged("Fjsm");
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
        public VgAttachment()
        {
            this.id=0;
            this.wxWydm=Guid.NewGuid().ToString();
            this.fjmc="";
            this.fjlj="";
            this.fjlx="";
            this.hqsj=DateTime.Now;
            this.fjsm="";
            this.databaseid=0;
            this.flags=0;
            this.xgr=Environment.UserName;
            this.xgsj=DateTime.Now;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgAttachment record = obj as VgAttachment;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_ATTACHMENT,dao.Connection))
            {
                this.databaseid=0;
                this.flags=1;
                this.xgr=dao.CurrentUser;
                this.xgsj=DateTime.Now;
            
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
				command.Parameters.AddWithValue(PARAM_FJMC, this.Fjmc);
				command.Parameters.AddWithValue(PARAM_FJLJ, this.Fjlj);
				command.Parameters.AddWithValue(PARAM_FJLX, this.Fjlx);
				command.Parameters.AddWithValue(PARAM_HQSJ, this.Hqsj);
				command.Parameters.AddWithValue(PARAM_FJSM, this.Fjsm);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_ATTACHMENT,dao.Connection))
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
				command.Parameters.AddWithValue(PARAM_WX_WYDM, this.WxWydm);
				command.Parameters.AddWithValue(PARAM_FJMC, this.Fjmc);
				command.Parameters.AddWithValue(PARAM_FJLJ, this.Fjlj);
				command.Parameters.AddWithValue(PARAM_FJLX, this.Fjlx);
				command.Parameters.AddWithValue(PARAM_HQSJ, this.Hqsj);
				command.Parameters.AddWithValue(PARAM_FJSM, this.Fjsm);
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_ATTACHMENT,dao.Connection))
                {                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_VG_ATTACHMENT,dao.Connection))
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
			if (!reader.IsDBNull(1)) wxWydm = reader.GetString(1);
			if (!reader.IsDBNull(2)) fjmc = reader.GetString(2);
			if (!reader.IsDBNull(3)) fjlj = reader.GetString(3);
			if (!reader.IsDBNull(4)) fjlx = reader.GetString(4);
			if (!reader.IsDBNull(5)) hqsj = reader.GetDateTime(5);
			if (!reader.IsDBNull(6)) fjsm = reader.GetString(6);
			if (!reader.IsDBNull(7)) databaseid = reader.GetInt64(7);
			if (!reader.IsDBNull(8)) flags = reader.GetInt16(8);
			if (!reader.IsDBNull(9)) xgr = reader.GetString(9);
			if (!reader.IsDBNull(10)) xgsj = reader.GetDateTime(10);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgAttachment target=new VgAttachment();
            target.ID=0;
            target.WxWydm=Guid.NewGuid().ToString();
            target.Fjmc=this.Fjmc;
            target.Fjlj=this.Fjlj;
            target.Fjlx=this.Fjlx;
            target.Hqsj=this.Hqsj;
            target.Fjsm=this.Fjsm;
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
