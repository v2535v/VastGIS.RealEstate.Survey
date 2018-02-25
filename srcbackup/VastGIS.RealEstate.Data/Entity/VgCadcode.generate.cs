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
    public partial class VgCadcode:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"XH",false},{"SFCY",false},{"TC",true},{"CASSDM",false},{"TXLX",false},{"XTC",true},{"YSDM",false},{"YSLX",true},{"YSZL",false}};
        public const string TABLE_NAME = "vg_cadcode";
        public const string LAYER_NAME="";
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
	    private const string SQL_INSERT_VG_CADCODE = "INSERT INTO vg_cadcode (XH, SFCY, TC, CASSDM, TXLX, XTC, YSDM, YSLX, YSZL) VALUES ( @XH, @SFCY, @TC, @CASSDM, @TXLX, @XTC, @YSDM, @YSLX, @YSZL);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_CADCODE = "UPDATE vg_cadcode SET XH = @XH, SFCY = @SFCY, TC = @TC, CASSDM = @CASSDM, TXLX = @TXLX, XTC = @XTC, YSDM = @YSDM, YSLX = @YSLX, YSZL = @YSZL WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_CADCODE = "DELETE FROM vg_cadcode WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 内部序号
		protected string xh = default(string);
        /// SFCY
		protected long? sfcy = default(long?);
        /// 图层
		protected string tc = default(string);
        /// CASS代码
		protected string cassdm = default(string);
        /// 图形类型
		protected string txlx = default(string);
        /// 新图层
		protected string xtc = default(string);
        /// 要素代码
		protected string ysdm = default(string);
        /// 要素类型
		protected string yslx = default(string);
        /// 要素种类
		protected long? yszl = default(long?);
        
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
            get{return "VgCadcode";}
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
                return string.Format("{0} {1} ({2})","vg_cadcode",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","vg_cadcode",this.id,this.ysdm);
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
        /// 内部序号
        public string Xh 
        {
            get { return this.xh; }
			set	{ 
                  if(this.xh != value)
                    {
                        this.OnPropertyChanging("Xh");  
                        this.xh= value;                                              
                        this.OnPropertyChanged("Xh");
                    }   
                }
        }	
        /// SFCY
        public long? Sfcy 
        {
            get { return this.sfcy; }
			set	{ 
                  if(this.sfcy != value)
                    {
                        this.OnPropertyChanging("Sfcy");  
                        this.sfcy= value;                                              
                        this.OnPropertyChanged("Sfcy");
                    }   
                }
        }	
        /// 图层
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
        /// CASS代码
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
        /// 图形类型
        public string Txlx 
        {
            get { return this.txlx; }
			set	{ 
                  if(this.txlx != value)
                    {
                        this.OnPropertyChanging("Txlx");  
                        this.txlx= value;                                              
                        this.OnPropertyChanged("Txlx");
                    }   
                }
        }	
        /// 新图层
        public string Xtc 
        {
            get { return this.xtc; }
			set	{ 
                  if(this.xtc != value)
                    {
                        this.OnPropertyChanging("Xtc");  
                        this.xtc= value;                                              
                        this.OnPropertyChanged("Xtc");
                    }   
                }
        }	
        /// 要素代码
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
        /// 要素类型
        public string Yslx 
        {
            get { return this.yslx; }
			set	{ 
                  if(this.yslx != value)
                    {
                        this.OnPropertyChanging("Yslx");  
                        this.yslx= value;                                              
                        this.OnPropertyChanged("Yslx");
                    }   
                }
        }	
        /// 要素种类
        public long? Yszl 
        {
            get { return this.yszl; }
			set	{ 
                  if(this.yszl != value)
                    {
                        this.OnPropertyChanging("Yszl");  
                        this.yszl= value;                                              
                        this.OnPropertyChanged("Yszl");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgCadcode()
        {
            
            this.id=0;
            this.xh="";
            this.sfcy=0;
            this.tc="";
            this.cassdm="";
            this.txlx="";
            this.xtc="";
            this.ysdm="";
            this.yslx="";
            this.yszl=0;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgCadcode record = obj as VgCadcode;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_CADCODE,dao.Connection))
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
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_CADCODE,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_XH,this.Xh);
				command.Parameters.AddWithValue(PARAM_SFCY,this.Sfcy);
				command.Parameters.AddWithValue(PARAM_TC,EncodingHelper.String2Unicode(this.Tc));
				command.Parameters.AddWithValue(PARAM_CASSDM,this.Cassdm);
				command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);
				command.Parameters.AddWithValue(PARAM_XTC,EncodingHelper.String2Unicode(this.Xtc));
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSLX,EncodingHelper.String2Unicode(this.Yslx));
				command.Parameters.AddWithValue(PARAM_YSZL,this.Yszl);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_CADCODE,dao.Connection))
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