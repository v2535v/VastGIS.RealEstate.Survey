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
    public partial class VgClassgroup:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_classgroup";
        public string ObjectName
        {
         get{
                return "vg_classgroup";
               }
        }
        public string EntityName{
            get{
                return "VgClassgroup";
               }
        }
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_GROUPNAME = "GroupName";
	    public const string COL_CREATEIMPL = "CreateImpl";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_GROUPNAME = "@GroupName";
        public const string PARAM_CREATEIMPL = "@CreateImpl";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_CLASSGROUP = "INSERT INTO vg_classgroup (GroupName, CreateImpl) VALUES ( @GroupName, @CreateImpl);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_CLASSGROUP = "UPDATE vg_classgroup SET GroupName = @GroupName, CreateImpl = @CreateImpl WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_CLASSGROUP = "DELETE FROM vg_classgroup WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string groupname = default(string);
		protected bool? createimpl = default(bool?);
        
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
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classgroup",this.id);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_classgroup",this.id);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgClassgroup()
        {
            
            
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
        
        public bool Create(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CLASSGROUP,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_GROUPNAME,this.GroupName); 
                 command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl); 
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CLASSGROUP,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID); 
				command.Parameters.AddWithValue(PARAM_GROUPNAME,this.GroupName); 
				command.Parameters.AddWithValue(PARAM_CREATEIMPL,this.CreateImpl); 
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CLASSGROUP,connection))
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