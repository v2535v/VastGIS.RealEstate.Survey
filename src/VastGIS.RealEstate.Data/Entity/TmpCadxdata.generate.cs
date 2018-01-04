using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity.Spatial;
using System.ComponentModel;

namespace VastGIS.RealEstate.Data.Entity
{

    public partial class TmpCadxdata:INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region 表结构
        public const string TABLE_NAME = "TmpCadxdata";
	    public const string COL_ID = "Id";
	    public const string COL_HANDLE = "Handle";
	    public const string COL_TC = "Tc";
	    public const string COL_WBNR = "Wbnr";
	    public const string COL_CASSDM = "Cassdm";
	    public const string COL_FSXX1 = "Fsxx1";
	    public const string COL_FSXX2 = "Fsxx2";
	    public const string COL_XZJD = "Xzjd";
	    public const string COL_FH = "Fh";
	    public const string COL_FHDX = "Fhdx";
	    public const string COL_YSDM = "Ysdm";
	    public const string COL_FILENAME = "FileName";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_HANDLE = "@Handle";
        public const string PARAM_TC = "@Tc";
        public const string PARAM_WBNR = "@Wbnr";
        public const string PARAM_CASSDM = "@Cassdm";
        public const string PARAM_FSXX1 = "@Fsxx1";
        public const string PARAM_FSXX2 = "@Fsxx2";
        public const string PARAM_XZJD = "@Xzjd";
        public const string PARAM_FH = "@Fh";
        public const string PARAM_FHDX = "@Fhdx";
        public const string PARAM_YSDM = "@Ysdm";
        public const string PARAM_FILENAME = "@FileName";
	
        #endregion
        
        #region 查询
	
	    private const string SQL_INSERT_TMPCADXDATA = "INSERT INTO TmpCadxdata (Handle, Tc, Wbnr, Cassdm, Fsxx1, Fsxx2, Xzjd, Fh, Fhdx, Ysdm, FileName) VALUES ( @Handle, @Tc, @Wbnr, @Cassdm, @Fsxx1, @Fsxx2, @Xzjd, @Fh, @Fhdx, @Ysdm, @FileName);" + " SELECT last_insert_rowid();";
	
	    private const string SQL_UPDATE_TMPCADXDATA = "UPDATE TmpCadxdata SET Handle = @Handle, Tc = @Tc, Wbnr = @Wbnr, Cassdm = @Cassdm, Fsxx1 = @Fsxx1, Fsxx2 = @Fsxx2, Xzjd = @Xzjd, Fh = @Fh, Fhdx = @Fhdx, Ysdm = @Ysdm, FileName = @FileName WHERE Id = @Id";
	
	    private const string SQL_DELETE_TMPCADXDATA = "DELETE FROM TmpCadxdata WHERE  Id = @Id ";
	
        #endregion            
        
        #region 声明

		protected long id = default(long);
		protected string handle = default(string);
		protected string tc = default(string);
		protected string wbnr = default(string);
		protected string cassdm = default(string);
		protected string fsxx1 = default(string);
		protected string fsxx2 = default(string);
		protected double? xzjd = default(double?);
		protected string fh = default(string);
		protected double? fhdx = default(double?);
		protected string ysdm = default(string);
		protected string filename = default(string);
        
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
        public string Handle 
        {
            get { return this.handle; }
			set	{ 
                  if(this.handle != value)
                    {
                        this.OnPropertyChanging("Handle");  
                        this.handle = value;                        
                        this.OnPropertyChanged("Handle");
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
        public string Wbnr 
        {
            get { return this.wbnr; }
			set	{ 
                  if(this.wbnr != value)
                    {
                        this.OnPropertyChanging("Wbnr");  
                        this.wbnr = value;                        
                        this.OnPropertyChanged("Wbnr");
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
        public string Fsxx1 
        {
            get { return this.fsxx1; }
			set	{ 
                  if(this.fsxx1 != value)
                    {
                        this.OnPropertyChanging("Fsxx1");  
                        this.fsxx1 = value;                        
                        this.OnPropertyChanged("Fsxx1");
                    }   
                }
        }	
        public string Fsxx2 
        {
            get { return this.fsxx2; }
			set	{ 
                  if(this.fsxx2 != value)
                    {
                        this.OnPropertyChanging("Fsxx2");  
                        this.fsxx2 = value;                        
                        this.OnPropertyChanged("Fsxx2");
                    }   
                }
        }	
        public double? Xzjd 
        {
            get { return this.xzjd; }
			set	{ 
                  if(this.xzjd != value)
                    {
                        this.OnPropertyChanging("Xzjd");  
                        this.xzjd = value;                        
                        this.OnPropertyChanged("Xzjd");
                    }   
                }
        }	
        public string Fh 
        {
            get { return this.fh; }
			set	{ 
                  if(this.fh != value)
                    {
                        this.OnPropertyChanging("Fh");  
                        this.fh = value;                        
                        this.OnPropertyChanged("Fh");
                    }   
                }
        }	
        public double? Fhdx 
        {
            get { return this.fhdx; }
			set	{ 
                  if(this.fhdx != value)
                    {
                        this.OnPropertyChanging("Fhdx");  
                        this.fhdx = value;                        
                        this.OnPropertyChanged("Fhdx");
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
        public string FileName 
        {
            get { return this.filename; }
			set	{ 
                  if(this.filename != value)
                    {
                        this.OnPropertyChanging("FileName");  
                        this.filename = value;                        
                        this.OnPropertyChanged("FileName");
                    }   
                }
        }	
        
        
        
        #endregion            
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            TmpCadxdata record = obj as TmpCadxdata;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_TMPCADXDATA,connection))
            {	
                 command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);    				
                 command.Parameters.AddWithValue(PARAM_TC,this.Tc);    				
                 command.Parameters.AddWithValue(PARAM_WBNR,this.Wbnr);    				
                 command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);    				
                 command.Parameters.AddWithValue(PARAM_FSXX1,this.Fsxx1);    				
                 command.Parameters.AddWithValue(PARAM_FSXX2,this.Fsxx2);    				
                 command.Parameters.AddWithValue(PARAM_XZJD,this.Xzjd);    				
                 command.Parameters.AddWithValue(PARAM_FH,this.Fh);    				
                 command.Parameters.AddWithValue(PARAM_FHDX,this.Fhdx);    				
                 command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);    				
                 command.Parameters.AddWithValue(PARAM_FILENAME,this.FileName);    				
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return true;
            }
        }

		public bool Update(SQLiteConnection connection,int srid)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_TMPCADXDATA,connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);  
				command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);  
				command.Parameters.AddWithValue(PARAM_TC,this.Tc);  
				command.Parameters.AddWithValue(PARAM_WBNR,this.Wbnr);  
				command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);  
				command.Parameters.AddWithValue(PARAM_FSXX1,this.Fsxx1);  
				command.Parameters.AddWithValue(PARAM_FSXX2,this.Fsxx2);  
				command.Parameters.AddWithValue(PARAM_XZJD,this.Xzjd);  
				command.Parameters.AddWithValue(PARAM_FH,this.Fh);  
				command.Parameters.AddWithValue(PARAM_FHDX,this.Fhdx);  
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
				command.Parameters.AddWithValue(PARAM_FILENAME,this.FileName);  
			
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_TMPCADXDATA,connection))
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