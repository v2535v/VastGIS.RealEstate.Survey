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

    public partial class VgDictoryname:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_dictoryname";
	    public const string COL_ID = "Id";
	    public const string COL_ZDMC = "ZDMC";
	    public const string COL_ZDSM = "ZDSM";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDMC = "@ZDMC";
        public const string PARAM_ZDSM = "@ZDSM";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_DICTORYNAME = "INSERT INTO vg_dictoryname (ZDMC, ZDSM) VALUES ( @ZDMC, @ZDSM);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_DICTORYNAME = "UPDATE vg_dictoryname SET ZDMC = @ZDMC, ZDSM = @ZDSM WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_DICTORYNAME = "DELETE FROM vg_dictoryname WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string zdmc = default(string);
		protected string zdsm = default(string);
        
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
        public string Zdmc 
        {
            get { return this.zdmc; }
			set	{ 
                  if(this.zdmc != value)
                    {
                        this.OnPropertyChanging("Zdmc");  
                        this.zdmc = value;                        
                        this.OnPropertyChanged("Zdmc");
                    }   
                }
        }	
        public string Zdsm 
        {
            get { return this.zdsm; }
			set	{ 
                  if(this.zdsm != value)
                    {
                        this.OnPropertyChanging("Zdsm");  
                        this.zdsm = value;                        
                        this.OnPropertyChanged("Zdsm");
                    }   
                }
        }	
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgDictoryname()
        {
            
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgDictoryname record = obj as VgDictoryname;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_DICTORYNAME,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);    				
                 command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_DICTORYNAME,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_ZDMC,this.Zdmc);  
				command.Parameters.AddWithValue(PARAM_ZDSM,this.Zdsm);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_DICTORYNAME,connection))
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