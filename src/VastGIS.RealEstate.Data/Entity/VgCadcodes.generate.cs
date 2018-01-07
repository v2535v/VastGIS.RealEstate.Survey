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

    public partial class VgCadcodes:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "vg_cadcodes";
	    public const string COL_ID = "Id";
	    public const string COL_XH = "XH";
	    public const string COL_SFCY = "SFCY";
	    public const string COL_TC = "TC";
	    public const string COL_CASSDM = "CASSDM";
	    public const string COL_TXLX = "TXLX";
	    public const string COL_XTC = "XTC";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_YSLX = "YSLX";
	    public const string COL_YSZL = "YSZL";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_XH = "@XH";
        public const string PARAM_SFCY = "@SFCY";
        public const string PARAM_TC = "@TC";
        public const string PARAM_CASSDM = "@CASSDM";
        public const string PARAM_TXLX = "@TXLX";
        public const string PARAM_XTC = "@XTC";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_YSLX = "@YSLX";
        public const string PARAM_YSZL = "@YSZL";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_VG_CADCODES = "INSERT INTO vg_cadcodes (XH, SFCY, TC, CASSDM, TXLX, XTC, YSDM, YSLX, YSZL) VALUES ( @XH, @SFCY, @TC, @CASSDM, @TXLX, @XTC, @YSDM, @YSLX, @YSZL);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_VG_CADCODES = "UPDATE vg_cadcodes SET XH = @XH, SFCY = @SFCY, TC = @TC, CASSDM = @CASSDM, TXLX = @TXLX, XTC = @XTC, YSDM = @YSDM, YSLX = @YSLX, YSZL = @YSZL WHERE Id = @Id";
	
	    private const string SQL_DELETE_VG_CADCODES = "DELETE FROM vg_cadcodes WHERE  Id = @Id ";
        
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string xh = default(string);
		protected long? sfcy = default(long?);
		protected string tc = default(string);
		protected string cassdm = default(string);
		protected string txlx = default(string);
		protected string xtc = default(string);
		protected string ysdm = default(string);
		protected string yslx = default(string);
		protected long? yszl = default(long?);
        
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
        public string Xh 
        {
            get { return this.xh; }
			set	{ 
                  if(this.xh != value)
                    {
                        this.OnPropertyChanging("Xh");  
                        this.xh = value;                        
                        this.OnPropertyChanged("Xh");
                    }   
                }
        }	
        public long? Sfcy 
        {
            get { return this.sfcy; }
			set	{ 
                  if(this.sfcy != value)
                    {
                        this.OnPropertyChanging("Sfcy");  
                        this.sfcy = value;                        
                        this.OnPropertyChanged("Sfcy");
                    }   
                }
        }	
        public string Tc 
        {
            get { return this.tc; }
			set	{ 
                  if(this.tc != value)
                    {
                        this.OnPropertyChanging("Tc");  
                        this.tc = value;                        
                        this.OnPropertyChanged("Tc");
                    }   
                }
        }	
        public string Cassdm 
        {
            get { return this.cassdm; }
			set	{ 
                  if(this.cassdm != value)
                    {
                        this.OnPropertyChanging("Cassdm");  
                        this.cassdm = value;                        
                        this.OnPropertyChanged("Cassdm");
                    }   
                }
        }	
        public string Txlx 
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
        public string Xtc 
        {
            get { return this.xtc; }
			set	{ 
                  if(this.xtc != value)
                    {
                        this.OnPropertyChanging("Xtc");  
                        this.xtc = value;                        
                        this.OnPropertyChanged("Xtc");
                    }   
                }
        }	
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm = value;                        
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        public string Yslx 
        {
            get { return this.yslx; }
			set	{ 
                  if(this.yslx != value)
                    {
                        this.OnPropertyChanging("Yslx");  
                        this.yslx = value;                        
                        this.OnPropertyChanged("Yslx");
                    }   
                }
        }	
        public long? Yszl 
        {
            get { return this.yszl; }
			set	{ 
                  if(this.yszl != value)
                    {
                        this.OnPropertyChanging("Yszl");  
                        this.yszl = value;                        
                        this.OnPropertyChanged("Yszl");
                    }   
                }
        }	
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgCadcodes()
        {
            
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgCadcodes record = obj as VgCadcodes;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CADCODES,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_XH,this.Xh);    				
                 command.Parameters.AddWithValue(PARAM_SFCY,this.Sfcy);    				
                 command.Parameters.AddWithValue(PARAM_TC,this.Tc);    				
                 command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);    				
                 command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);    				
                 command.Parameters.AddWithValue(PARAM_XTC,this.Xtc);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_YSLX,this.Yslx);    				
                 command.Parameters.AddWithValue(PARAM_YSZL,this.Yszl);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CADCODES,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_XH,this.Xh);  
				command.Parameters.AddWithValue(PARAM_SFCY,this.Sfcy);  
				command.Parameters.AddWithValue(PARAM_TC,this.Tc);  
				command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);  
				command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);  
				command.Parameters.AddWithValue(PARAM_XTC,this.Xtc);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_YSLX,this.Yslx);  
				command.Parameters.AddWithValue(PARAM_YSZL,this.Yszl);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CADCODES,connection))
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