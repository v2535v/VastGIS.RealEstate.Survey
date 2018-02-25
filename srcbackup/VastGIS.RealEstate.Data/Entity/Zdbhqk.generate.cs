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
    public partial class Zdbhqk:INotifyPropertyChanging,INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZDDM",false},{"BHYY",true},{"BHNR",true},{"DJSJ",false},{"DBR",true},{"FJ",true},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false}};
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
	    public const string COL_XGR = "XGR";
	    public const string COL_XGSJ = "XGSJ";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZDDM = "@ZDDM";
        public const string PARAM_BHYY = "@BHYY";
        public const string PARAM_BHNR = "@BHNR";
        public const string PARAM_DJSJ = "@DJSJ";
        public const string PARAM_DBR = "@DBR";
        public const string PARAM_FJ = "@FJ";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_ZDBHQK = "INSERT INTO ZDBHQK (ZDDM, BHYY, BHNR, DJSJ, DBR, FJ, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @ZDDM, @BHYY, @BHNR, @DJSJ, @DBR, @FJ, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_ZDBHQK = "UPDATE ZDBHQK SET ZDDM = @ZDDM, BHYY = @BHYY, BHNR = @BHNR, DJSJ = @DJSJ, DBR = @DBR, FJ = @FJ, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";	
	    private const string SQL_DELETE_ZDBHQK = "DELETE FROM ZDBHQK WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_ZDBHQK = "UPDATE ZDBHQK Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// ID
		protected long id = default(long);
        /// 宗地代码
		protected string zddm = default(string);
        /// 变化原因
		protected string bhyy = default(string);
        /// 变化内容
		protected string bhnr = default(string);
        /// 登记时间
		protected System.DateTime? djsj = default(System.DateTime?);
        /// 登簿人
		protected string dbr = default(string);
        /// 附记
		protected string fj = default(string);
        /// 源数据库内序号
		protected long? databaseid = default(long?);
        /// 修改标记
		protected short? flag = default(short?);
        /// XGR
		protected string xgr = default(string);
        /// XGSJ
		protected System.DateTime? xgsj = default(System.DateTime?);
        
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
            get{return "Zdbhqk";}
        }
        public string EntityName{
            get{return "DatabaseEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        ///简化提示信息，用于绑定到列表时候的DisplayMember
        public string SimpleLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZDBHQK",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","ZDBHQK",this.id);
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
        /// 宗地代码
        public string Zddm 
        {
            get { return this.zddm; }
			set	{ 
                  if(this.zddm != value)
                    {
                        this.OnPropertyChanging("Zddm");  
                        this.zddm= value;                                              
                        this.OnPropertyChanged("Zddm");
                    }   
                }
        }	
        /// 变化原因
        public string Bhyy 
        {
            get { return this.bhyy; }
			set	{ 
                  if(this.bhyy != value)
                    {
                        this.OnPropertyChanging("Bhyy");  
                        this.bhyy= value;                                              
                        this.OnPropertyChanged("Bhyy");
                    }   
                }
        }	
        /// 变化内容
        public string Bhnr 
        {
            get { return this.bhnr; }
			set	{ 
                  if(this.bhnr != value)
                    {
                        this.OnPropertyChanging("Bhnr");  
                        this.bhnr= value;                                              
                        this.OnPropertyChanged("Bhnr");
                    }   
                }
        }	
        /// 登记时间
        public System.DateTime? Djsj 
        {
            get { return this.djsj; }
			set	{ 
                  if(this.djsj != value)
                    {
                        this.OnPropertyChanging("Djsj");  
                        this.djsj= value;                                              
                        this.OnPropertyChanged("Djsj");
                    }   
                }
        }	
        /// 登簿人
        public string Dbr 
        {
            get { return this.dbr; }
			set	{ 
                  if(this.dbr != value)
                    {
                        this.OnPropertyChanging("Dbr");  
                        this.dbr= value;                                              
                        this.OnPropertyChanged("Dbr");
                    }   
                }
        }	
        /// 附记
        public string Fj 
        {
            get { return this.fj; }
			set	{ 
                  if(this.fj != value)
                    {
                        this.OnPropertyChanging("Fj");  
                        this.fj= value;                                              
                        this.OnPropertyChanged("Fj");
                    }   
                }
        }	
        /// 源数据库内序号
        public long? DatabaseID 
        {
            get { return this.databaseid; }
			set	{ 
                  if(this.databaseid != value)
                    {
                        this.OnPropertyChanging("DatabaseID");  
                        this.databaseid= value;                                              
                        this.OnPropertyChanged("DatabaseID");
                    }   
                }
        }	
        /// 修改标记
        public short? Flags 
        {
            get { return this.flag; }
			set	{ 
                  if(this.flag != value)
                    {
                        this.OnPropertyChanging("Flags");  
                        this.flag= value;                                              
                        this.OnPropertyChanged("Flags");
                    }   
                }
        }	
        /// XGR
        public string Xgr 
        {
            get { return this.xgr; }
			set	{ 
                  if(this.xgr != value)
                    {
                        this.OnPropertyChanging("Xgr");  
                        this.xgr= value;                                              
                        this.OnPropertyChanged("Xgr");
                    }   
                }
        }	
        /// XGSJ
        public System.DateTime? Xgsj 
        {
            get { return this.xgsj; }
			set	{ 
                  if(this.xgsj != value)
                    {
                        this.OnPropertyChanging("Xgsj");  
                        this.xgsj= value;                                              
                        this.OnPropertyChanged("Xgsj");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  Zdbhqk()
        {
            
            this.id=0;
            this.zddm="";
            this.bhyy="";
            this.bhnr="";
            this.djsj=DateTime.Now;
            this.dbr="";
            this.fj="";
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
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
        
        public long Create(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_ZDBHQK,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);  
                command.Parameters.AddWithValue(PARAM_BHYY,this.Bhyy);  
                command.Parameters.AddWithValue(PARAM_BHNR,this.Bhnr);  
                command.Parameters.AddWithValue(PARAM_DJSJ,this.Djsj);  
                command.Parameters.AddWithValue(PARAM_DBR,this.Dbr);  
                command.Parameters.AddWithValue(PARAM_FJ,this.Fj);  
                command.Parameters.AddWithValue(PARAM_DATABASEID,0);  
                this.flag=1;command.Parameters.AddWithValue(PARAM_FLAGS,1);  
                command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_ZDBHQK,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ZDDM,this.Zddm);
				command.Parameters.AddWithValue(PARAM_BHYY,EncodingHelper.String2Unicode(this.Bhyy));
				command.Parameters.AddWithValue(PARAM_BHNR,EncodingHelper.String2Unicode(this.Bhnr));
				command.Parameters.AddWithValue(PARAM_DJSJ,this.Djsj);
				command.Parameters.AddWithValue(PARAM_DBR,EncodingHelper.String2Unicode(this.Dbr));
				command.Parameters.AddWithValue(PARAM_FJ,EncodingHelper.String2Unicode(this.Fj));
				command.Parameters.AddWithValue(PARAM_DATABASEID,this.DatabaseID);
				this.flag = (short?)(this.databaseid > 0 ? 2 :1);command.Parameters.AddWithValue(PARAM_FLAGS,this.flag);
				command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);
				command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);
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
            if(this.databaseid==0)
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_ZDBHQK,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_ZDBHQK,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    command.Parameters.AddWithValue(PARAM_XGR,dao.CurrentUser);  
                    command.Parameters.AddWithValue(PARAM_XGSJ,DateTime.Now);  
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