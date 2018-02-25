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
    public partial class VgLayergroupdetail:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"ZM",true},{"Mc",true},{"IDENTIFY",false},{"EDITABLE",false},{"QUERYABLE",false},{"SNAPABLE",false},{"VISIBLE",false}};
        public const string TABLE_NAME = "vg_layergroupdetail";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_ZM = "ZM";
	    public const string COL_MC = "Mc";
	    public const string COL_IDENTIFY = "IDENTIFY";
	    public const string COL_EDITABLE = "EDITABLE";
	    public const string COL_QUERYABLE = "QUERYABLE";
	    public const string COL_SNAPABLE = "SNAPABLE";
	    public const string COL_VISIBLE = "VISIBLE";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_ZM = "@ZM";
        public const string PARAM_MC = "@Mc";
        public const string PARAM_IDENTIFY = "@IDENTIFY";
        public const string PARAM_EDITABLE = "@EDITABLE";
        public const string PARAM_QUERYABLE = "@QUERYABLE";
        public const string PARAM_SNAPABLE = "@SNAPABLE";
        public const string PARAM_VISIBLE = "@VISIBLE";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_LAYERGROUPDETAIL = "INSERT INTO vg_layergroupdetail (ZM, Mc, IDENTIFY, EDITABLE, QUERYABLE, SNAPABLE, VISIBLE) VALUES ( @ZM, @Mc, @IDENTIFY, @EDITABLE, @QUERYABLE, @SNAPABLE, @VISIBLE);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_LAYERGROUPDETAIL = "UPDATE vg_layergroupdetail SET ZM = @ZM, Mc = @Mc, IDENTIFY = @IDENTIFY, EDITABLE = @EDITABLE, QUERYABLE = @QUERYABLE, SNAPABLE = @SNAPABLE, VISIBLE = @VISIBLE WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_LAYERGROUPDETAIL = "DELETE FROM vg_layergroupdetail WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 组名
		protected string zm = default(string);
        /// 名称
		protected string mc = default(string);
        /// 可检索
		protected bool identify = default(bool);
        /// 可编辑
		protected bool editable = default(bool);
        /// 可查询
		protected bool queryable = default(bool);
        /// 可捕捉
		protected bool snapable = default(bool);
        /// 可显示
		protected bool visible = default(bool);
        
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
            get{return "VgLayergroupdetail";}
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
                return string.Format("{0} {1} ","vg_layergroupdetail",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_layergroupdetail",this.id);
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
        /// 组名
        public string Zm 
        {
            get { return this.zm; }
			set	{ 
                  if(this.zm != value)
                    {
                        this.OnPropertyChanging("Zm");  
                        this.zm= value;                                              
                        this.OnPropertyChanged("Zm");
                    }   
                }
        }	
        /// 名称
        public string Mc 
        {
            get { return this.mc; }
			set	{ 
                  if(this.mc != value)
                    {
                        this.OnPropertyChanging("Mc");  
                        this.mc= value;                                              
                        this.OnPropertyChanged("Mc");
                    }   
                }
        }	
        /// 可检索
        public bool Identify 
        {
            get { return this.identify; }
			set	{ 
                  if(this.identify != value)
                    {
                        this.OnPropertyChanging("Identify");  
                        this.identify= value;                                              
                        this.OnPropertyChanged("Identify");
                    }   
                }
        }	
        /// 可编辑
        public bool Editable 
        {
            get { return this.editable; }
			set	{ 
                  if(this.editable != value)
                    {
                        this.OnPropertyChanging("Editable");  
                        this.editable= value;                                              
                        this.OnPropertyChanged("Editable");
                    }   
                }
        }	
        /// 可查询
        public bool Queryable 
        {
            get { return this.queryable; }
			set	{ 
                  if(this.queryable != value)
                    {
                        this.OnPropertyChanging("Queryable");  
                        this.queryable= value;                                              
                        this.OnPropertyChanged("Queryable");
                    }   
                }
        }	
        /// 可捕捉
        public bool Snapable 
        {
            get { return this.snapable; }
			set	{ 
                  if(this.snapable != value)
                    {
                        this.OnPropertyChanging("Snapable");  
                        this.snapable= value;                                              
                        this.OnPropertyChanged("Snapable");
                    }   
                }
        }	
        /// 可显示
        public bool Visible 
        {
            get { return this.visible; }
			set	{ 
                  if(this.visible != value)
                    {
                        this.OnPropertyChanging("Visible");  
                        this.visible= value;                                              
                        this.OnPropertyChanged("Visible");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgLayergroupdetail()
        {
            
            this.id=0;
            this.zm="";
            this.mc="";
            this.identify=true;
            this.editable=true;
            this.queryable=true;
            this.snapable=true;
            this.visible=true;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgLayergroupdetail record = obj as VgLayergroupdetail;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_LAYERGROUPDETAIL,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_ZM,this.Zm);  
                command.Parameters.AddWithValue(PARAM_MC,this.Mc);  
                command.Parameters.AddWithValue(PARAM_IDENTIFY,this.Identify);  
                command.Parameters.AddWithValue(PARAM_EDITABLE,this.Editable);  
                command.Parameters.AddWithValue(PARAM_QUERYABLE,this.Queryable);  
                command.Parameters.AddWithValue(PARAM_SNAPABLE,this.Snapable);  
                command.Parameters.AddWithValue(PARAM_VISIBLE,this.Visible);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_LAYERGROUPDETAIL,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_ZM,EncodingHelper.String2Unicode(this.Zm));
				command.Parameters.AddWithValue(PARAM_MC,EncodingHelper.String2Unicode(this.Mc));
				command.Parameters.AddWithValue(PARAM_IDENTIFY,this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE,this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE,this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE,this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE,this.Visible);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_LAYERGROUPDETAIL,dao.Connection))
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