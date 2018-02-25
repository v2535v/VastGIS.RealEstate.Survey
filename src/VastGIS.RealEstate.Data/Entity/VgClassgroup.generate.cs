
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
    public partial class VgClassgroup : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_classgroup";	
        public const string LAYER_NAME = "要素组信息";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
		public const string COL_ID = "Id";
		public const string COL_GROUPNAME = "GroupName";
		public const string COL_CREATEIMPL = "CreateImpl";
		
        public const string PARAM_ID = "@Id";	
        public const string PARAM_GROUPNAME = "@GroupName";	
        public const string PARAM_CREATEIMPL = "@CreateImpl";	
		
        #endregion
		
		#region SQL语句
		private const string SQL_QUERY_VG_CLASSGROUP ="SELECT  Id,GroupName,CreateImpl FROM vg_classgroup ";
        
		private const string SQL_INSERT_VG_CLASSGROUP = "INSERT INTO [vg_classgroup] (GroupName, CreateImpl) VALUES ( @GroupName, @CreateImpl);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_CLASSGROUP = "UPDATE [vg_classgroup] SET GroupName = @GroupName, CreateImpl = @CreateImpl WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_CLASSGROUP = "DELETE FROM [vg_classgroup] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///组名
		protected string groupname = default(string);
        ///是否实体
		protected bool? createimpl = default(bool?);
        
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
            get{return "VgClassgroup";}
        }
         public string LayerName
        {
            get{return "要素组信息";}
        }
        public string EntityName{
            get{return "IEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return false;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return false;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classgroup",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","要素组",this.id);
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
		
        ///组名
        ///[Column(COL_GROUPNAME, PARAM_GROUPNAME )]
        public virtual string GroupName 
        {
            get { return this.groupname; }
			set	{ 
                  if(this.groupname != value)
                    {
                        this.OnPropertyChanging("GroupName"); 
                        this.groupname = value;                        
                        this.OnPropertyChanged("GroupName");
                    }   
                }
        }	
		
        ///是否实体
        ///[Column(COL_CREATEIMPL, PARAM_CREATEIMPL )]
        public virtual bool? CreateImpl 
        {
            get { return this.createimpl; }
			set	{ 
                  if(this.createimpl != value)
                    {
                        this.OnPropertyChanging("CreateImpl"); 
                        this.createimpl = value;                        
                        this.OnPropertyChanged("CreateImpl");
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
        public VgClassgroup()
        {
            this.id=0;
            this.groupname="";
            this.createimpl=true;
        }
        #endregion
        
        #region 方法
        
        public override bool Equals(object obj)
        {
            VgClassgroup record = obj as VgClassgroup;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CLASSGROUP,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_GROUPNAME, this.GroupName);
				command.Parameters.AddWithValue(PARAM_CREATEIMPL, this.CreateImpl);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CLASSGROUP,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_GROUPNAME, this.GroupName);
				command.Parameters.AddWithValue(PARAM_CREATEIMPL, this.CreateImpl);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CLASSGROUP,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) groupname = reader.GetString(1);
			if (!reader.IsDBNull(2)) createimpl = reader.GetBoolean(2);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgClassgroup target=new VgClassgroup();
            target.ID=0;
            target.GroupName=this.GroupName;
            target.CreateImpl=this.CreateImpl;
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
