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
    public partial class VgAreacode:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"XZQHMC",true},{"XZQHDM",false},{"XZQHJB",false}};
        public const string TABLE_NAME = "vg_areacode";
        public const string LAYER_NAME="";
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
	    private const string SQL_INSERT_VG_AREACODE = "INSERT INTO vg_areacode (XZQHMC, XZQHDM, XZQHJB) VALUES ( @XZQHMC, @XZQHDM, @XZQHJB);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_AREACODE = "UPDATE vg_areacode SET XZQHMC = @XZQHMC, XZQHDM = @XZQHDM, XZQHJB = @XZQHJB WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_AREACODE = "DELETE FROM vg_areacode WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 行政区划名称
		protected string xzqhmc = default(string);
        /// 行政区划代码
		protected string xzqhdm = default(string);
        /// 行政区划级别
		protected long? xzqhjb = default(long?);
        
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
            get{return "VgAreacode";}
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
                return string.Format("{0} {1} ","vg_areacode",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_areacode",this.id);
            }
        }        
        #endregion
        #region 字段属性信息
        /// 标识码
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
        /// 行政区划名称
        public string Xzqhmc 
        {
            get { return this.xzqhmc; }
			set	{ 
                  if(this.xzqhmc != value)
                    {
                        this.OnPropertyChanging("Xzqhmc");  
                        this.xzqhmc= value;                                              
                        this.OnPropertyChanged("Xzqhmc");
                    }   
                }
        }	
        /// 行政区划代码
        public string Xzqhdm 
        {
            get { return this.xzqhdm; }
			set	{ 
                  if(this.xzqhdm != value)
                    {
                        this.OnPropertyChanging("Xzqhdm");  
                        this.xzqhdm= value;                                              
                        this.OnPropertyChanged("Xzqhdm");
                    }   
                }
        }	
        /// 行政区划级别
        public long? Xzqhjb 
        {
            get { return this.xzqhjb; }
			set	{ 
                  if(this.xzqhjb != value)
                    {
                        this.OnPropertyChanging("Xzqhjb");  
                        this.xzqhjb= value;                                              
                        this.OnPropertyChanged("Xzqhjb");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgAreacode()
        {
            
            this.id=0;
            this.xzqhmc="";
            this.xzqhdm="";
            this.xzqhjb=0;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgAreacode record = obj as VgAreacode;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_AREACODE,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_XZQHMC,this.Xzqhmc);  
                command.Parameters.AddWithValue(PARAM_XZQHDM,this.Xzqhdm);  
                command.Parameters.AddWithValue(PARAM_XZQHJB,this.Xzqhjb);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_AREACODE,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_XZQHMC,EncodingHelper.String2Unicode(this.Xzqhmc));
				command.Parameters.AddWithValue(PARAM_XZQHDM,this.Xzqhdm);
				command.Parameters.AddWithValue(PARAM_XZQHJB,this.Xzqhjb);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_AREACODE,dao.Connection))
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