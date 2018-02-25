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
    public partial class Zdtojzd:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZD_WYDM",false},{"JZD_WYDM",false},{"SXH",false}};
        public const string TABLE_NAME = "ZDTOJZD";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_ZD_WYDM = "ZD_WYDM";
	    public const string COL_JZD_WYDM = "JZD_WYDM";
	    public const string COL_SXH = "SXH";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZD_WYDM = "@ZD_WYDM";
        public const string PARAM_JZD_WYDM = "@JZD_WYDM";
        public const string PARAM_SXH = "@SXH";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_ZDTOJZD = "INSERT INTO ZDTOJZD (ZD_WYDM, JZD_WYDM, SXH) VALUES ( @ZD_WYDM, @JZD_WYDM, @SXH);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_ZDTOJZD = "UPDATE ZDTOJZD SET ZD_WYDM = @ZD_WYDM, JZD_WYDM = @JZD_WYDM, SXH = @SXH WHERE Id = @Id";	
	    private const string SQL_DELETE_ZDTOJZD = "DELETE FROM ZDTOJZD WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// ID
		protected long id = default(long);
        /// ZD_WYDM
		protected System.Guid? zdWydm = default(System.Guid?);
        /// JZD_WYDM
		protected System.Guid? jzdWydm = default(System.Guid?);
        /// SXH
		protected object sxh = default(object);
        
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
            get{return "Zdtojzd";}
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
                return string.Format("{0} {1} ","ZDTOJZD",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZDTOJZD",this.id);
            }
        }        
        #endregion
        #region 字段属性信息
        /// ID
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
        /// ZD_WYDM
        public System.Guid? ZdWydm 
        {
            get { return this.zdWydm; }
			set	{ 
                  if(this.zdWydm != value)
                    {
                        this.OnPropertyChanging("ZdWydm");  
                        this.zdWydm= value;                                              
                        this.OnPropertyChanged("ZdWydm");
                    }   
                }
        }	
        /// JZD_WYDM
        public System.Guid? JzdWydm 
        {
            get { return this.jzdWydm; }
			set	{ 
                  if(this.jzdWydm != value)
                    {
                        this.OnPropertyChanging("JzdWydm");  
                        this.jzdWydm= value;                                              
                        this.OnPropertyChanged("JzdWydm");
                    }   
                }
        }	
        /// SXH
        public object Sxh 
        {
            get { return this.sxh; }
			set	{ 
                  if(this.sxh != value)
                    {
                        this.OnPropertyChanging("Sxh");  
                        this.sxh= value;                                              
                        this.OnPropertyChanged("Sxh");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  Zdtojzd()
        {
            
            this.id=0;
            this.zdWydm=Guid.NewGuid();
            this.jzdWydm=Guid.NewGuid();
            
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Zdtojzd record = obj as Zdtojzd;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDTOJZD,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_ZD_WYDM,this.ZdWydm);  
                command.Parameters.AddWithValue(PARAM_JZD_WYDM,this.JzdWydm);  
                command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDTOJZD,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ZD_WYDM,this.ZdWydm);
				command.Parameters.AddWithValue(PARAM_JZD_WYDM,this.JzdWydm);
				command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDTOJZD,dao.Connection))
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