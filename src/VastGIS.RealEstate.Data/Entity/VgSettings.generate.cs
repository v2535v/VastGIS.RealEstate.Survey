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

    public partial class VgSettings:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_settings";
	    public const string COL_ID = "Id";
	    public const string COL_CSMC = "CSMC";
	    public const string COL_CSZ = "CSZ";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_CSMC = "@CSMC";
        public const string PARAM_CSZ = "@CSZ";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_SETTINGS = "INSERT INTO vg_settings (CSMC, CSZ) VALUES ( @CSMC, @CSZ);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_SETTINGS = "UPDATE vg_settings SET CSMC = @CSMC, CSZ = @CSZ WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_SETTINGS = "DELETE FROM vg_settings WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string csmc = default(string);
		protected string csz = default(string);
        
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
        public string Csmc 
        {
            get { return this.csmc; }
			set	{ 
                  if(this.csmc != value)
                    {
                        this.OnPropertyChanging("Csmc");  
                        this.csmc = value;                        
                        this.OnPropertyChanged("Csmc");
                    }   
                }
        }	
        public string Csz 
        {
            get { return this.csz; }
			set	{ 
                  if(this.csz != value)
                    {
                        this.OnPropertyChanging("Csz");  
                        this.csz = value;                        
                        this.OnPropertyChanged("Csz");
                    }   
                }
        }	
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgSettings()
        {
            
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgSettings record = obj as VgSettings;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_SETTINGS,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_CSMC,this.Csmc);    				
                 command.Parameters.AddWithValue(PARAM_CSZ,this.Csz);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_SETTINGS,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_CSMC,this.Csmc);  
				command.Parameters.AddWithValue(PARAM_CSZ,this.Csz);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_SETTINGS,connection))
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