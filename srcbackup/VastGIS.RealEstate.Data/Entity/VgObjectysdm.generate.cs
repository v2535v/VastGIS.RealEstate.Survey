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
    public partial class VgObjectysdm:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"YSDM",false},{"YSMC",true},{"XSSX",false},{"QSBG",false},{"QSFH",true},{"SFKJ",false}};
        public const string TABLE_NAME = "vg_objectysdm";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_YSDM = "YSDM";
	    public const string COL_YSMC = "YSMC";
	    public const string COL_XSSX = "XSSX";
	    public const string COL_QSBG = "QSBG";
	    public const string COL_QSFH = "QSFH";
	    public const string COL_SFKJ = "SFKJ";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_YSDM = "@YSDM";
        public const string PARAM_YSMC = "@YSMC";
        public const string PARAM_XSSX = "@XSSX";
        public const string PARAM_QSBG = "@QSBG";
        public const string PARAM_QSFH = "@QSFH";
        public const string PARAM_SFKJ = "@SFKJ";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_OBJECTYSDM = "INSERT INTO vg_objectysdm (YSDM, YSMC, XSSX, QSBG, QSFH, SFKJ) VALUES ( @YSDM, @YSMC, @XSSX, @QSBG, @QSFH, @SFKJ);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_OBJECTYSDM = "UPDATE vg_objectysdm SET YSDM = @YSDM, YSMC = @YSMC, XSSX = @XSSX, QSBG = @QSBG, QSFH = @QSFH, SFKJ = @SFKJ WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_OBJECTYSDM = "DELETE FROM vg_objectysdm WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 要素代码
		protected string ysdm = default(string);
        /// 要素名称
		protected string ysmc = default(string);
        /// 显示顺序
		protected long? xssx = default(long?);
        /// 缺省表格
		protected string qsbg = default(string);
        /// 缺省符号
		protected string qsfh = default(string);
        /// 是否空间要素
		protected bool sfkj = default(bool);
        
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
            get{return "VgObjectysdm";}
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
                return string.Format("{0} {1} ({2})","vg_objectysdm",this.id,this.ysdm);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ({2})","vg_objectysdm",this.id,this.ysdm);
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
        /// 要素名称
        public string Ysmc 
        {
            get { return this.ysmc; }
			set	{ 
                  if(this.ysmc != value)
                    {
                        this.OnPropertyChanging("Ysmc");  
                        this.ysmc= value;                                              
                        this.OnPropertyChanged("Ysmc");
                    }   
                }
        }	
        /// 显示顺序
        public long? Xssx 
        {
            get { return this.xssx; }
			set	{ 
                  if(this.xssx != value)
                    {
                        this.OnPropertyChanging("Xssx");  
                        this.xssx= value;                                              
                        this.OnPropertyChanged("Xssx");
                    }   
                }
        }	
        /// 缺省表格
        public string Qsbg 
        {
            get { return this.qsbg; }
			set	{ 
                  if(this.qsbg != value)
                    {
                        this.OnPropertyChanging("Qsbg");  
                        this.qsbg= value;                                              
                        this.OnPropertyChanged("Qsbg");
                    }   
                }
        }	
        /// 缺省符号
        public string Qsfh 
        {
            get { return this.qsfh; }
			set	{ 
                  if(this.qsfh != value)
                    {
                        this.OnPropertyChanging("Qsfh");  
                        this.qsfh= value;                                              
                        this.OnPropertyChanged("Qsfh");
                    }   
                }
        }	
        /// 是否空间要素
        public bool Sfkj 
        {
            get { return this.sfkj; }
			set	{ 
                  if(this.sfkj != value)
                    {
                        this.OnPropertyChanging("Sfkj");  
                        this.sfkj= value;                                              
                        this.OnPropertyChanged("Sfkj");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgObjectysdm()
        {
            
            this.id=0;
            this.ysdm="";
            this.ysmc="";
            this.xssx=0;
            this.qsbg="";
            this.qsfh="";
            this.sfkj=true;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgObjectysdm record = obj as VgObjectysdm;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTYSDM,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);  
                command.Parameters.AddWithValue(PARAM_YSMC,this.Ysmc);  
                command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx);  
                command.Parameters.AddWithValue(PARAM_QSBG,this.Qsbg);  
                command.Parameters.AddWithValue(PARAM_QSFH,this.Qsfh);  
                command.Parameters.AddWithValue(PARAM_SFKJ,this.Sfkj);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTYSDM,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_YSDM,this.Ysdm);
				command.Parameters.AddWithValue(PARAM_YSMC,EncodingHelper.String2Unicode(this.Ysmc));
				command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx);
				command.Parameters.AddWithValue(PARAM_QSBG,this.Qsbg);
				command.Parameters.AddWithValue(PARAM_QSFH,EncodingHelper.String2Unicode(this.Qsfh));
				command.Parameters.AddWithValue(PARAM_SFKJ,this.Sfkj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTYSDM,dao.Connection))
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