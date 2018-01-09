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

    public partial class Zdbhqk:INotifyPropertyChanging, INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        public const string TABLE_NAME = "ZDBHQK";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_ZDDM = "ZDDM";
	    public const string COL_BHYY = "BHYY";
	    public const string COL_BHNR = "BHNR";
	    public const string COL_DJSJ = "DJSJ";
	    public const string COL_DBR = "DBR";
	    public const string COL_FJ = "FJ";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDDM = "@ZDDM";
        public const string PARAM_BHYY = "@BHYY";
        public const string PARAM_BHNR = "@BHNR";
        public const string PARAM_DJSJ = "@DJSJ";
        public const string PARAM_DBR = "@DBR";
        public const string PARAM_FJ = "@FJ";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_ZDBHQK = "INSERT INTO ZDBHQK (ZDDM, BHYY, BHNR, DJSJ, DBR, FJ, DatabaseId, FLAGS) VALUES ( @ZDDM, @BHYY, @BHNR, @DJSJ, @DBR, @FJ, @DatabaseId, @FLAGS);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_ZDBHQK = "UPDATE ZDBHQK SET ZDDM = @ZDDM, BHYY = @BHYY, BHNR = @BHNR, DJSJ = @DJSJ, DBR = @DBR, FJ = @FJ, DatabaseId = @DatabaseId, FLAGS = @FLAGS WHERE Id = @Id";
	
	    private const string SQL_DELETE_ZDBHQK = "DELETE FROM ZDBHQK WHERE  Id = @Id ";
        
        private const string SQL_DELETE_FLAG_ZDBHQK = "UPDATE ZDBHQK Set Flags=3 WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string zddm = default(string);
		protected string bhyy = default(string);
		protected string bhnr = default(string);
		protected System.DateTime? djsj = default(System.DateTime?);
		protected string dbr = default(string);
		protected string fj = default(string);
		protected long? databaseid = default(long?);
		protected short? flag = default(short?);
        
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
        public string Zddm 
        {
            get { return this.zddm; }
			set	{ 
                  if(this.zddm != value)
                    {
                        this.OnPropertyChanging("Zddm");  
                        this.zddm = value;                        
                        this.OnPropertyChanged("Zddm");
                    }   
                }
        }	
        public string Bhyy 
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
        public string Bhnr 
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
        public System.DateTime? Djsj 
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
        public string Dbr 
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
        public string Fj 
        {
            get { return this.fj; }
			set	{ 
                  if(this.fj != value)
                    {
                        this.OnPropertyChanging("Fj");  
                        this.fj = value;                        
                        this.OnPropertyChanged("Fj");
                    }   
                }
        }	
        public long? DatabaseID 
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
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag = value;                        
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZDBHQK",this.id);
            }
        }
        
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZDBHQK",this.id);
            }
        }
        
        
        
        #endregion     
        
        #region 创建方法
        public  Zdbhqk()
        {
            
            
            this.databaseid=0;
            this.flag=1;
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            Zdbhqk record = obj as Zdbhqk;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDBHQK,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);    				
                 command.Parameters.AddWithValue(PARAM_BHYY,this.Bhyy);    				
                 command.Parameters.AddWithValue(PARAM_BHNR,this.Bhnr);    				
                 command.Parameters.AddWithValue(PARAM_DJSJ,this.Djsj);    				
                 command.Parameters.AddWithValue(PARAM_DBR,this.Dbr);    				
                 command.Parameters.AddWithValue(PARAM_FJ,this.Fj);    				
                 command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);    				
                 command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDBHQK,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);  
				command.Parameters.AddWithValue(PARAM_BHYY,this.Bhyy);  
				command.Parameters.AddWithValue(PARAM_BHNR,this.Bhnr);  
				command.Parameters.AddWithValue(PARAM_DJSJ,this.Djsj);  
				command.Parameters.AddWithValue(PARAM_DBR,this.Dbr);  
				command.Parameters.AddWithValue(PARAM_FJ,this.Fj);  
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);  
				command.Parameters.AddWithValue(PARAM_FLAGS,this.Flags);  
			
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
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDBHQK,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZDBHQK,connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
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