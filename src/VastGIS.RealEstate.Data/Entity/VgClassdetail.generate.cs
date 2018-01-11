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

namespace VastGIS.RealEstate.Data.Entity
{
    public partial class VgClassdetail:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_classdetail";
        public string ObjectName
        {
         get{
                return "vg_classdetail";
               }
        }
        public string EntityName{
            get{
                return "VgClassdetail";
               }
        }
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_GROUPNAME = "GroupName";
	    public const string COL_TABLENAME = "TableName";
	    public const string COL_CREATEIMPL = "CreateImpl";
	    public const string COL_INTERFACENAME = "InterfaceName";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_GROUPNAME = "@GroupName";
        public const string PARAM_TABLENAME = "@TableName";
        public const string PARAM_CREATEIMPL = "@CreateImpl";
        public const string PARAM_INTERFACENAME = "@InterfaceName";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_CLASSDETAIL = "INSERT INTO vg_classdetail (GroupName, TableName, CreateImpl, InterfaceName) VALUES ( @GroupName, @TableName, @CreateImpl, @InterfaceName);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_CLASSDETAIL = "UPDATE vg_classdetail SET GroupName = @GroupName, TableName = @TableName, CreateImpl = @CreateImpl, InterfaceName = @InterfaceName WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_CLASSDETAIL = "DELETE FROM vg_classdetail WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string groupname = default(string);
		protected string tablename = default(string);
		protected bool? createimpl = default(bool?);
		protected string interfacename = default(string);
        
        private event PropertyChangingEventHandler propertyChanging;            
        private event PropertyChangedEventHandler propertyChanged;
        #endregion
        
        #region 属性
    
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
        
        public long ID 
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
        public string GroupName 
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
        public string TableName 
        {
            get { return this.tablename; }
			set	{ 
                  if(this.tablename != value)
                    {
                        this.OnPropertyChanging("TableName");  
                        this.tablename = value;                        
                        this.OnPropertyChanged("TableName");
                    }   
                }
        }	
        public bool? CreateImpl 
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
        public string InterfaceName 
        {
            get { return this.interfacename; }
			set	{ 
                  if(this.interfacename != value)
                    {
                        this.OnPropertyChanging("InterfaceName");  
                        this.interfacename = value;                        
                        this.OnPropertyChanged("InterfaceName");
                    }   
                }
        }	
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classdetail",this.id);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classdetail",this.id);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgClassdetail()
        {
            
            
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
        
        public bool Create(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CLASSDETAIL,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_GROUPNAME,this.GroupName); 
                 command.Parameters.AddWithValue(PARAM_TABLENAME,this.TableName); 
                 command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl); 
                 command.Parameters.AddWithValue(PARAM_INTERFACENAME,this.InterfaceName); 
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CLASSDETAIL,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID); 
				command.Parameters.AddWithValue(PARAM_GROUPNAME,this.GroupName); 
				command.Parameters.AddWithValue(PARAM_TABLENAME,this.TableName); 
				command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl); 
				command.Parameters.AddWithValue(PARAM_INTERFACENAME,this.InterfaceName); 
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(SQLiteConnection connection)
        {
            if(this.id == default(long))
            {
                return Create(connection);
            }
            else
            {
                return Update(connection);
            }            
        }

		public bool Delete(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CLASSDETAIL,connection))
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