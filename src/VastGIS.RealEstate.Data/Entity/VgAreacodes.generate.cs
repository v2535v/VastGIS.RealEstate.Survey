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

    public partial class VgAreacodes:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_areacodes";
	    public const string COL_ID = "Id";
	    public const string COL_XZQHMC = "XZQHMC";
	    public const string COL_XZQHDM = "XZQHDM";
	    public const string COL_XZQHJB = "XZQHJB";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_XZQHMC = "@XZQHMC";
        public const string PARAM_XZQHDM = "@XZQHDM";
        public const string PARAM_XZQHJB = "@XZQHJB";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_AREACODES = "INSERT INTO vg_areacodes (XZQHMC, XZQHDM, XZQHJB) VALUES ( @XZQHMC, @XZQHDM, @XZQHJB);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_AREACODES = "UPDATE vg_areacodes SET XZQHMC = @XZQHMC, XZQHDM = @XZQHDM, XZQHJB = @XZQHJB WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_AREACODES = "DELETE FROM vg_areacodes WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string xzqhmc = default(string);
		protected string xzqhdm = default(string);
		protected long? xzqhjb = default(long?);
        
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
        public string Xzqhmc 
        {
            get { return this.xzqhmc; }
			set	{ 
                  if(this.xzqhmc != value)
                    {
                        this.OnPropertyChanging("Xzqhmc");  
                        this.xzqhmc = value;                        
                        this.OnPropertyChanged("Xzqhmc");
                    }   
                }
        }	
        public string Xzqhdm 
        {
            get { return this.xzqhdm; }
			set	{ 
                  if(this.xzqhdm != value)
                    {
                        this.OnPropertyChanging("Xzqhdm");  
                        this.xzqhdm = value;                        
                        this.OnPropertyChanged("Xzqhdm");
                    }   
                }
        }	
        public long? Xzqhjb 
        {
            get { return this.xzqhjb; }
			set	{ 
                  if(this.xzqhjb != value)
                    {
                        this.OnPropertyChanging("Xzqhjb");  
                        this.xzqhjb = value;                        
                        this.OnPropertyChanged("Xzqhjb");
                    }   
                }
        }	
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgAreacodes()
        {
            
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgAreacodes record = obj as VgAreacodes;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_AREACODES,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_XZQHMC,this.Xzqhmc);    				
                 command.Parameters.AddWithValue(PARAM_XZQHDM,this.Xzqhdm);    				
                 command.Parameters.AddWithValue(PARAM_XZQHJB,this.Xzqhjb);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_AREACODES,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_XZQHMC,this.Xzqhmc);  
				command.Parameters.AddWithValue(PARAM_XZQHDM,this.Xzqhdm);  
				command.Parameters.AddWithValue(PARAM_XZQHJB,this.Xzqhjb);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_AREACODES,connection))
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