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
    public partial class VgAttachment:INotifyPropertyChanging,INotifyPropertyChanged,IDatabaseEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"WX_WYDM",false},{"FJMC",true},{"FJLJ",true},{"FJLX",false},{"HQSJ",false},{"FJSM",true},{"DatabaseId",false},{"FLAGS",false},{"XGR",false},{"XGSJ",false}};
        public const string TABLE_NAME = "vg_attachment";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_WX_WYDM = "WX_WYDM";
	    public const string COL_FJMC = "FJMC";
	    public const string COL_FJLJ = "FJLJ";
	    public const string COL_FJLX = "FJLX";
	    public const string COL_HQSJ = "HQSJ";
	    public const string COL_FJSM = "FJSM";
	    public const string COL_DATABASEID = "DatabaseId";
	    public const string COL_FLAGS = "FLAGS";
	    public const string COL_XGR = "XGR";
	    public const string COL_XGSJ = "XGSJ";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_WX_WYDM = "@WX_WYDM";
        public const string PARAM_FJMC = "@FJMC";
        public const string PARAM_FJLJ = "@FJLJ";
        public const string PARAM_FJLX = "@FJLX";
        public const string PARAM_HQSJ = "@HQSJ";
        public const string PARAM_FJSM = "@FJSM";
        public const string PARAM_DATABASEID = "@DatabaseId";
        public const string PARAM_FLAGS = "@FLAGS";
        public const string PARAM_XGR = "@XGR";
        public const string PARAM_XGSJ = "@XGSJ";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_ATTACHMENT = "INSERT INTO vg_attachment (WX_WYDM, FJMC, FJLJ, FJLX, HQSJ, FJSM, DatabaseId, FLAGS, XGR, XGSJ) VALUES ( @WX_WYDM, @FJMC, @FJLJ, @FJLX, @HQSJ, @FJSM, @DatabaseId, @FLAGS, @XGR, @XGSJ);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_ATTACHMENT = "UPDATE vg_attachment SET WX_WYDM = @WX_WYDM, FJMC = @FJMC, FJLJ = @FJLJ, FJLX = @FJLX, HQSJ = @HQSJ, FJSM = @FJSM, DatabaseId = @DatabaseId, FLAGS = @FLAGS, XGR = @XGR, XGSJ = @XGSJ WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_ATTACHMENT = "DELETE FROM vg_attachment WHERE  Id = @Id ";        
        private const string SQL_DELETE_FLAG_VG_ATTACHMENT = "UPDATE vg_attachment Set Flags=3,XGR = @XGR, XGSJ = @XGSJ WHERE  Id = @Id ";
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 唯一代码
		protected System.Guid? wxWydm = default(System.Guid?);
        /// 附件名称
		protected string fjmc = default(string);
        /// 附件路径
		protected string fjlj = default(string);
        /// 附件类型 - 使用字典信息(附件类型字典--FJLXZD)
		protected string fjlx = default(string);
        /// 获取时间
		protected System.DateTime? hqsj = default(System.DateTime?);
        /// 附件说明
		protected string fjsm = default(string);
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
            get{return "VgAttachment";}
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
                return string.Format("{0} {1} ","vg_attachment",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_attachment",this.id);
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
        /// 唯一代码
        public System.Guid? WxWydm 
        {
            get { return this.wxWydm; }
			set	{ 
                  if(this.wxWydm != value)
                    {
                        this.OnPropertyChanging("WxWydm");  
                        this.wxWydm= value;                                              
                        this.OnPropertyChanged("WxWydm");
                    }   
                }
        }	
        /// 附件名称
        public string Fjmc 
        {
            get { return this.fjmc; }
			set	{ 
                  if(this.fjmc != value)
                    {
                        this.OnPropertyChanging("Fjmc");  
                        this.fjmc= value;                                              
                        this.OnPropertyChanged("Fjmc");
                    }   
                }
        }	
        /// 附件路径
        public string Fjlj 
        {
            get { return this.fjlj; }
			set	{ 
                  if(this.fjlj != value)
                    {
                        this.OnPropertyChanging("Fjlj");  
                        this.fjlj= value;                                              
                        this.OnPropertyChanged("Fjlj");
                    }   
                }
        }	
        /// 附件类型 - 使用字典信息(附件类型字典--FJLXZD)
        public string Fjlx 
        {
            get { return this.fjlx; }
			set	{ 
                  if(this.fjlx != value)
                    {
                        this.OnPropertyChanging("Fjlx");  
                        this.fjlx= value;                                              
                        this.OnPropertyChanged("Fjlx");
                    }   
                }
        }	
        /// 获取时间
        public System.DateTime? Hqsj 
        {
            get { return this.hqsj; }
			set	{ 
                  if(this.hqsj != value)
                    {
                        this.OnPropertyChanging("Hqsj");  
                        this.hqsj= value;                                              
                        this.OnPropertyChanged("Hqsj");
                    }   
                }
        }	
        /// 附件说明
        public string Fjsm 
        {
            get { return this.fjsm; }
			set	{ 
                  if(this.fjsm != value)
                    {
                        this.OnPropertyChanging("Fjsm");  
                        this.fjsm= value;                                              
                        this.OnPropertyChanged("Fjsm");
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
        public  VgAttachment()
        {
            
            this.id=0;
            this.wxWydm=Guid.NewGuid();
            this.fjmc="";
            this.fjlj="";
            this.fjlx="";
            this.hqsj=DateTime.Now;
            this.fjsm="";
            this.databaseid=0;
            this.flag=1;
            this.xgr="";
            this.xgsj=DateTime.Now;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgAttachment record = obj as VgAttachment;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_ATTACHMENT,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);  
                command.Parameters.AddWithValue(PARAM_FJMC,this.Fjmc);  
                command.Parameters.AddWithValue(PARAM_FJLJ,this.Fjlj);  
                command.Parameters.AddWithValue(PARAM_FJLX,this.Fjlx);  
                command.Parameters.AddWithValue(PARAM_HQSJ,this.Hqsj);  
                command.Parameters.AddWithValue(PARAM_FJSM,this.Fjsm);  
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_ATTACHMENT,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_WX_WYDM,this.WxWydm);
				command.Parameters.AddWithValue(PARAM_FJMC,EncodingHelper.String2Unicode(this.Fjmc));
				command.Parameters.AddWithValue(PARAM_FJLJ,EncodingHelper.String2Unicode(this.Fjlj));
				command.Parameters.AddWithValue(PARAM_FJLX,this.Fjlx);
				command.Parameters.AddWithValue(PARAM_HQSJ,this.Hqsj);
				command.Parameters.AddWithValue(PARAM_FJSM,EncodingHelper.String2Unicode(this.Fjsm));
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
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_ATTACHMENT,dao.Connection))
                {
                   
    				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                    return (command.ExecuteNonQuery() == 1);
                }
            }
            else
            {
                using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_FLAG_VG_ATTACHMENT,dao.Connection))
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