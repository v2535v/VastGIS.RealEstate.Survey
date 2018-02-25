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
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class VgClassdetail:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"GroupName",true},{"ObjectTableName",true},{"CreateImpl",false},{"InterfaceName",false}};
        public const string TABLE_NAME = "vg_classdetail";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_GROUPNAME = "GroupName";
	    public const string COL_OBJECTTABLENAME = "ObjectTableName";
	    public const string COL_CREATEIMPL = "CreateImpl";
	    public const string COL_INTERFACENAME = "InterfaceName";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_GROUPNAME = "@GroupName";
        public const string PARAM_OBJECTTABLENAME = "@ObjectTableName";
        public const string PARAM_CREATEIMPL = "@CreateImpl";
        public const string PARAM_INTERFACENAME = "@InterfaceName";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_CLASSDETAIL = "INSERT INTO vg_classdetail (GroupName, ObjectTableName, CreateImpl, InterfaceName) VALUES ( @GroupName, @ObjectTableName, @CreateImpl, @InterfaceName);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_CLASSDETAIL = "UPDATE vg_classdetail SET GroupName = @GroupName, ObjectTableName = @ObjectTableName, CreateImpl = @CreateImpl, InterfaceName = @InterfaceName WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_CLASSDETAIL = "DELETE FROM vg_classdetail WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 组名
		protected string groupname = default(string);
        /// OBJECTTABLENAME
		protected string objecttablename = default(string);
        /// 是否实体
		protected bool? createimpl = default(bool?);
        /// 接口名称
		protected string interfacename = default(string);
        
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
        
        #region IEntity属性
        //对应数据库内表名称
        public string ObjectName
        {
            get{return "VgClassdetail";}
        }
        public string EntityName{
            get{return "Entity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classdetail",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classdetail",this.id);
            }
        }        
        #endregion
        #region 字段属性信息
        /// 标识码
        public long ID 
        {
            get { return this.id; }
			set	{ 
                  if(this.id != value)
                    {
                        this.OnPropertyChanging("ID");  
                        this.id= value;                                              
                        this.OnPropertyChanged("ID");
                    }   
                }
        }	
        /// 组名
        public string GroupName 
        {
            get { return this.groupname; }
			set	{ 
                  if(this.groupname != value)
                    {
                        this.OnPropertyChanging("GroupName");  
                        this.groupname= value;                                              
                        this.OnPropertyChanged("GroupName");
                    }   
                }
        }	
        /// OBJECTTABLENAME
        public string ObjectTableName 
        {
            get { return this.objecttablename; }
			set	{ 
                  if(this.objecttablename != value)
                    {
                        this.OnPropertyChanging("ObjectTableName");  
                        this.objecttablename= value;                                              
                        this.OnPropertyChanged("ObjectTableName");
                    }   
                }
        }	
        /// 是否实体
        public bool? CreateImpl 
        {
            get { return this.createimpl; }
			set	{ 
                  if(this.createimpl != value)
                    {
                        this.OnPropertyChanging("CreateImpl");  
                        this.createimpl= value;                                              
                        this.OnPropertyChanged("CreateImpl");
                    }   
                }
        }	
        /// 接口名称
        public string InterfaceName 
        {
            get { return this.interfacename; }
			set	{ 
                  if(this.interfacename != value)
                    {
                        this.OnPropertyChanging("InterfaceName");  
                        this.interfacename= value;                                              
                        this.OnPropertyChanged("InterfaceName");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgClassdetail()
        {
            
            this.id=0;
            this.groupname="";
            this.objecttablename="";
            this.createimpl=false;
            this.interfacename="";
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgClassdetail record = obj as VgClassdetail;           
            
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
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CLASSDETAIL,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_GROUPNAME,this.GroupName);  
                command.Parameters.AddWithValue(PARAM_OBJECTTABLENAME,this.ObjectTableName);  
                command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl);  
                command.Parameters.AddWithValue(PARAM_INTERFACENAME,this.InterfaceName);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CLASSDETAIL,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_GROUPNAME,EncodingHelper.String2Unicode(this.GroupName));
				command.Parameters.AddWithValue(PARAM_OBJECTTABLENAME,EncodingHelper.String2Unicode(this.ObjectTableName));
				command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl);
				command.Parameters.AddWithValue(PARAM_INTERFACENAME,this.InterfaceName);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(ISQLiteDao dao)
        {
            if(this.id == default(long))
            {
                return Create(dao) >0;
            }
            else
            {
                return Update(dao);
            }            
        }

		public bool Delete(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CLASSDETAIL,dao.Connection))
            {
               
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
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