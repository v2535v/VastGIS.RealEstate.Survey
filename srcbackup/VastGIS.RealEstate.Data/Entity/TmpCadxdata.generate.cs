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
    public partial class TmpCadxdata:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"Handle",false},{"Tc",true},{"Wbnr",true},{"Cassdm",true},{"Fsxx1",true},{"Fsxx2",true},{"Xzjd",false},{"Fh",true},{"Fhdx",false},{"Ysdm",false},{"FileName",true}};
        public const string TABLE_NAME = "TmpCadxdata";
        public const string LAYER_NAME="";
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
        /// ID
		protected long id = default(long);
        /// HANDLE
		protected string handle = default(string);
        /// TC
		protected string tc = default(string);
        /// WBNR
		protected string wbnr = default(string);
        /// CASSDM
		protected string cassdm = default(string);
        /// FSXX1
		protected string fsxx1 = default(string);
        /// FSXX2
		protected string fsxx2 = default(string);
        /// XZJD
		protected double? xzjd = default(double?);
        /// FH
		protected string fh = default(string);
        /// FHDX
		protected double? fhdx = default(double?);
        /// YSDM
		protected string ysdm = default(string);
        /// FILENAME
		protected string filename = default(string);
        
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
            get{return "TmpCadxdata";}
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
                return string.Format("{0} {1} ({2})","TmpCadxdata",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","TmpCadxdata",this.id,this.ysdm);
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
        /// HANDLE
        public string Handle 
        {
            get { return this.handle; }
			set	{ 
                  if(this.handle != value)
                    {
                        this.OnPropertyChanging("Handle");  
                        this.handle= value;                                              
                        this.OnPropertyChanged("Handle");
                    }   
                }
        }	
        /// TC
        public string Tc 
        {
            get { return this.tc; }
			set	{ 
                  if(this.tc != value)
                    {
                        this.OnPropertyChanging("Tc");  
                        this.tc= value;                                              
                        this.OnPropertyChanged("Tc");
                    }   
                }
        }	
        /// WBNR
        public string Wbnr 
        {
            get { return this.wbnr; }
			set	{ 
                  if(this.wbnr != value)
                    {
                        this.OnPropertyChanging("Wbnr");  
                        this.wbnr= value;                                              
                        this.OnPropertyChanged("Wbnr");
                    }   
                }
        }	
        /// CASSDM
        public string Cassdm 
        {
            get { return this.cassdm; }
			set	{ 
                  if(this.cassdm != value)
                    {
                        this.OnPropertyChanging("Cassdm");  
                        this.cassdm= value;                                              
                        this.OnPropertyChanged("Cassdm");
                    }   
                }
        }	
        /// FSXX1
        public string Fsxx1 
        {
            get { return this.fsxx1; }
			set	{ 
                  if(this.fsxx1 != value)
                    {
                        this.OnPropertyChanging("Fsxx1");  
                        this.fsxx1= value;                                              
                        this.OnPropertyChanged("Fsxx1");
                    }   
                }
        }	
        /// FSXX2
        public string Fsxx2 
        {
            get { return this.fsxx2; }
			set	{ 
                  if(this.fsxx2 != value)
                    {
                        this.OnPropertyChanging("Fsxx2");  
                        this.fsxx2= value;                                              
                        this.OnPropertyChanged("Fsxx2");
                    }   
                }
        }	
        /// XZJD
        public double? Xzjd 
        {
            get { return this.xzjd; }
			set	{ 
                  if(this.xzjd != value)
                    {
                        this.OnPropertyChanging("Xzjd");  
                        this.xzjd= value;                                              
                        this.OnPropertyChanged("Xzjd");
                    }   
                }
        }	
        /// FH
        public string Fh 
        {
            get { return this.fh; }
			set	{ 
                  if(this.fh != value)
                    {
                        this.OnPropertyChanging("Fh");  
                        this.fh= value;                                              
                        this.OnPropertyChanged("Fh");
                    }   
                }
        }	
        /// FHDX
        public double? Fhdx 
        {
            get { return this.fhdx; }
			set	{ 
                  if(this.fhdx != value)
                    {
                        this.OnPropertyChanging("Fhdx");  
                        this.fhdx= value;                                              
                        this.OnPropertyChanged("Fhdx");
                    }   
                }
        }	
        /// YSDM
        public string Ysdm 
        {
            get { return this.ysdm; }
			set	{ 
                  if(this.ysdm != value)
                    {
                        this.OnPropertyChanging("Ysdm");  
                        this.ysdm= value;                                              
                        this.OnPropertyChanged("Ysdm");
                    }   
                }
        }	
        /// FILENAME
        public string FileName 
        {
            get { return this.filename; }
			set	{ 
                  if(this.filename != value)
                    {
                        this.OnPropertyChanging("FileName");  
                        this.filename= value;                                              
                        this.OnPropertyChanged("FileName");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  TmpCadxdata()
        {
            
            this.id=0;
            this.handle="";
            this.tc="";
            this.wbnr="";
            this.cassdm="";
            this.fsxx1="";
            this.fsxx2="";
            this.xzjd=0.0;
            this.fh="";
            this.fhdx=0.0;
            this.ysdm="";
            this.filename="";
            
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
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_TMPCADXDATA,dao.Connection))
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
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_TMPCADXDATA,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_HANDLE,this.Handle);
				command.Parameters.AddWithValue(PARAM_TC,EncodingHelper.String2Unicode(this.Tc));
				command.Parameters.AddWithValue(PARAM_WBNR,EncodingHelper.String2Unicode(this.Wbnr));
				command.Parameters.AddWithValue(PARAM_CASSDM,EncodingHelper.String2Unicode(this.Cassdm));
				command.Parameters.AddWithValue(PARAM_FSXX1,EncodingHelper.String2Unicode(this.Fsxx1));
				command.Parameters.AddWithValue(PARAM_FSXX2,EncodingHelper.String2Unicode(this.Fsxx2));
				command.Parameters.AddWithValue(PARAM_XZJD,this.Xzjd);
				command.Parameters.AddWithValue(PARAM_FH,EncodingHelper.String2Unicode(this.Fh));
				command.Parameters.AddWithValue(PARAM_FHDX,this.Fhdx);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_FILENAME,EncodingHelper.String2Unicode(this.FileName));
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_TMPCADXDATA,dao.Connection))
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