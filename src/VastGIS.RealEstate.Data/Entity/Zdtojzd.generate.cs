using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class Zdtojzd:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "ZDTOJZD";
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

		protected long id = default(long);
		protected System.Guid? zdWydm = default(System.Guid?);
		protected System.Guid? jzdWydm = default(System.Guid?);
		protected object sxh = default(object);
        
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
        public System.Guid? ZdWydm 
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
        public System.Guid? JzdWydm 
        {
            get { return this.jzdWydm; }
			set	{ 
                  if(this.jzdWydm != value)
                    {
                        this.OnPropertyChanging("JzdWydm");  
                        this.jzdWydm = value;                        
                        this.OnPropertyChanged("JzdWydm");
                    }   
                }
        }	
        public object Sxh 
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
        
        
        
        #endregion     
        
        #region 创建方法
        public  Zdtojzd()
        {
            
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
        
        
        
        public bool Create(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDTOJZD,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ZD_WYDM,this.ZdWydm);    				
                 command.Parameters.AddWithValue(PARAM_JZD_WYDM,this.JzdWydm);    				
                 command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDTOJZD,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ZD_WYDM,this.ZdWydm);  
				command.Parameters.AddWithValue(PARAM_JZD_WYDM,this.JzdWydm);  
				command.Parameters.AddWithValue(PARAM_SXH,this.Sxh);  
			
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public bool Save(SQLiteConnection connection,int srid)
        {
            if(this.id == default(long))
            {
                return Create(connection,srid);
            }
            else
            {
                return Update(connection,srid);
            }
            
        }

		public bool Delete(SQLiteConnection connection)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDTOJZD,connection))
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