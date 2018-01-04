﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class VgObjectclasses:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_objectclasses";
	    public const string COL_ID = "Id";
	    public const string COL_MC = "MC";
	    public const string COL_DXLX = "DXLX";
	    public const string COL_ZWMC = "ZWMC";
	    public const string COL_FBMC = "FBMC";
	    public const string COL_XHZDMC = "XHZDMC";
	    public const string COL_TXZDMC = "TXZDMC";
	    public const string COL_TXLX = "TXLX";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_MC = "@MC";
        public const string PARAM_DXLX = "@DXLX";
        public const string PARAM_ZWMC = "@ZWMC";
        public const string PARAM_FBMC = "@FBMC";
        public const string PARAM_XHZDMC = "@XHZDMC";
        public const string PARAM_TXZDMC = "@TXZDMC";
        public const string PARAM_TXLX = "@TXLX";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_OBJECTCLASSES = "INSERT INTO vg_objectclasses (MC, DXLX, ZWMC, FBMC, XHZDMC, TXZDMC, TXLX) VALUES ( @MC, @DXLX, @ZWMC, @FBMC, @XHZDMC, @TXZDMC, @TXLX);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_OBJECTCLASSES = "UPDATE vg_objectclasses SET MC = @MC, DXLX = @DXLX, ZWMC = @ZWMC, FBMC = @FBMC, XHZDMC = @XHZDMC, TXZDMC = @TXZDMC, TXLX = @TXLX WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_OBJECTCLASSES = "DELETE FROM vg_objectclasses WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string mc = default(string);
		protected int? dxlx = default(int?);
		protected string zwmc = default(string);
		protected string fbmc = default(string);
		protected string xhzdmc = default(string);
		protected string txzdmc = default(string);
		protected int? txlx = default(int?);
        
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
        public string Mc 
        {
            get { return this.mc; }
			set	{ 
                  if(this.mc != value)
                    {
                        this.OnPropertyChanging("Mc");  
                        this.mc = value;                        
                        this.OnPropertyChanged("Mc");
                    }   
                }
        }	
        public int? Dxlx 
        {
            get { return this.dxlx; }
			set	{ 
                  if(this.dxlx != value)
                    {
                        this.OnPropertyChanging("Dxlx");  
                        this.dxlx = value;                        
                        this.OnPropertyChanged("Dxlx");
                    }   
                }
        }	
        public string Zwmc 
        {
            get { return this.zwmc; }
			set	{ 
                  if(this.zwmc != value)
                    {
                        this.OnPropertyChanging("Zwmc");  
                        this.zwmc = value;                        
                        this.OnPropertyChanged("Zwmc");
                    }   
                }
        }	
        public string Fbmc 
        {
            get { return this.fbmc; }
			set	{ 
                  if(this.fbmc != value)
                    {
                        this.OnPropertyChanging("Fbmc");  
                        this.fbmc = value;                        
                        this.OnPropertyChanged("Fbmc");
                    }   
                }
        }	
        public string Xhzdmc 
        {
            get { return this.xhzdmc; }
			set	{ 
                  if(this.xhzdmc != value)
                    {
                        this.OnPropertyChanging("Xhzdmc");  
                        this.xhzdmc = value;                        
                        this.OnPropertyChanged("Xhzdmc");
                    }   
                }
        }	
        public string Txzdmc 
        {
            get { return this.txzdmc; }
			set	{ 
                  if(this.txzdmc != value)
                    {
                        this.OnPropertyChanging("Txzdmc");  
                        this.txzdmc = value;                        
                        this.OnPropertyChanged("Txzdmc");
                    }   
                }
        }	
        public int? Txlx 
        {
            get { return this.txlx; }
			set	{ 
                  if(this.txlx != value)
                    {
                        this.OnPropertyChanging("Txlx");  
                        this.txlx = value;                        
                        this.OnPropertyChanged("Txlx");
                    }   
                }
        }	
        
        
        
        #endregion            
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgObjectclasses record = obj as VgObjectclasses;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTCLASSES,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_MC,this.Mc);    				
                 command.Parameters.AddWithValue(PARAM_DXLX,this.Dxlx);    				
                 command.Parameters.AddWithValue(PARAM_ZWMC,this.Zwmc);    				
                 command.Parameters.AddWithValue(PARAM_FBMC,this.Fbmc);    				
                 command.Parameters.AddWithValue(PARAM_XHZDMC,this.Xhzdmc);    				
                 command.Parameters.AddWithValue(PARAM_TXZDMC,this.Txzdmc);    				
                 command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTCLASSES,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_MC,this.Mc);  
				command.Parameters.AddWithValue(PARAM_DXLX,this.Dxlx);  
				command.Parameters.AddWithValue(PARAM_ZWMC,this.Zwmc);  
				command.Parameters.AddWithValue(PARAM_FBMC,this.Fbmc);  
				command.Parameters.AddWithValue(PARAM_XHZDMC,this.Xhzdmc);  
				command.Parameters.AddWithValue(PARAM_TXZDMC,this.Txzdmc);  
				command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTCLASSES,connection))
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