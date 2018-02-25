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
    public partial class VgObjectclass:INotifyPropertyChanging,INotifyPropertyChanged,IEntity
    {
        #region 表结构
        Dictionary<string,bool> _isUnicodes=new Dictionary<string,bool>{{"Id",false},{"MC",true},{"DXLX",false},{"ZWMC",true},{"FBMC",true},{"XHZDMC",true},{"TXZDMC",true},{"TXLX",false},{"IDENTIFY",false},{"EDITABLE",false},{"QUERYABLE",false},{"SNAPABLE",false},{"VISIBLE",false},{"XSSX",false},{"FILTER",true},{"QSDM",false},{"BJCT",false},{"BHFJ",false}};
        public const string TABLE_NAME = "vg_objectclass";
        public const string LAYER_NAME="";
	    public const string COL_ID = "Id";
	    public const string COL_MC = "MC";
	    public const string COL_DXLX = "DXLX";
	    public const string COL_ZWMC = "ZWMC";
	    public const string COL_FBMC = "FBMC";
	    public const string COL_XHZDMC = "XHZDMC";
	    public const string COL_TXZDMC = "TXZDMC";
	    public const string COL_TXLX = "TXLX";
	    public const string COL_IDENTIFY = "IDENTIFY";
	    public const string COL_EDITABLE = "EDITABLE";
	    public const string COL_QUERYABLE = "QUERYABLE";
	    public const string COL_SNAPABLE = "SNAPABLE";
	    public const string COL_VISIBLE = "VISIBLE";
	    public const string COL_XSSX = "XSSX";
	    public const string COL_FILTER = "FILTER";
	    public const string COL_QSDM = "QSDM";
	    public const string COL_BJCT = "BJCT";
	    public const string COL_BHFJ = "BHFJ";
	
        public const string PARAM_ID = "@Id";
        public const string PARAM_MC = "@MC";
        public const string PARAM_DXLX = "@DXLX";
        public const string PARAM_ZWMC = "@ZWMC";
        public const string PARAM_FBMC = "@FBMC";
        public const string PARAM_XHZDMC = "@XHZDMC";
        public const string PARAM_TXZDMC = "@TXZDMC";
        public const string PARAM_TXLX = "@TXLX";
        public const string PARAM_IDENTIFY = "@IDENTIFY";
        public const string PARAM_EDITABLE = "@EDITABLE";
        public const string PARAM_QUERYABLE = "@QUERYABLE";
        public const string PARAM_SNAPABLE = "@SNAPABLE";
        public const string PARAM_VISIBLE = "@VISIBLE";
        public const string PARAM_XSSX = "@XSSX";
        public const string PARAM_FILTER = "@FILTER";
        public const string PARAM_QSDM = "@QSDM";
        public const string PARAM_BJCT = "@BJCT";
        public const string PARAM_BHFJ = "@BHFJ";
	
        #endregion
        
        #region 查询	
	    private const string SQL_INSERT_VG_OBJECTCLASS = "INSERT INTO vg_objectclass (MC, DXLX, ZWMC, FBMC, XHZDMC, TXZDMC, TXLX, IDENTIFY, EDITABLE, QUERYABLE, SNAPABLE, VISIBLE, XSSX, FILTER, QSDM, BJCT, BHFJ) VALUES ( @MC, @DXLX, @ZWMC, @FBMC, @XHZDMC, @TXZDMC, @TXLX, @IDENTIFY, @EDITABLE, @QUERYABLE, @SNAPABLE, @VISIBLE, @XSSX, @FILTER, @QSDM, @BJCT, @BHFJ);" + " SELECT last_insert_rowid();";	
	    private const string SQL_UPDATE_VG_OBJECTCLASS = "UPDATE vg_objectclass SET MC = @MC, DXLX = @DXLX, ZWMC = @ZWMC, FBMC = @FBMC, XHZDMC = @XHZDMC, TXZDMC = @TXZDMC, TXLX = @TXLX, IDENTIFY = @IDENTIFY, EDITABLE = @EDITABLE, QUERYABLE = @QUERYABLE, SNAPABLE = @SNAPABLE, VISIBLE = @VISIBLE, XSSX = @XSSX, FILTER = @FILTER, QSDM = @QSDM, BJCT = @BJCT, BHFJ = @BHFJ WHERE Id = @Id";	
	    private const string SQL_DELETE_VG_OBJECTCLASS = "DELETE FROM vg_objectclass WHERE  Id = @Id ";        
        #endregion            
        
        #region 声明
        /// 标识码
		protected long id = default(long);
        /// 名称
		protected string mc = default(string);
        /// 对象类型
		protected int dxlx = default(int);
        /// 中文名称
		protected string zwmc = default(string);
        /// 父表名称
		protected string fbmc = default(string);
        /// 序号字段名称
		protected string xhzdmc = default(string);
        /// 图形字段名称
		protected string txzdmc = default(string);
        /// 图形类型
		protected int txlx = default(int);
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
        /// 显示顺序
		protected long xssx = default(long);
        /// 过滤
		protected string filter = default(string);
        /// 缺省代码
		protected string qsdm = default(string);
        /// 编辑窗体
		protected string bjct = default(string);
        /// 包含附件
		protected bool bhfj = default(bool);
        
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
            get{return "VgObjectclass";}
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
                return string.Format("{0} {1} ","vg_objectclass",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","vg_objectclass",this.id);
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
        /// 对象类型
        public int Dxlx 
        {
            get { return this.dxlx; }
			set	{ 
                  if(this.dxlx != value)
                    {
                        this.OnPropertyChanging("Dxlx");  
                        this.dxlx= value;                                              
                        this.OnPropertyChanged("Dxlx");
                    }   
                }
        }	
        /// 中文名称
        public string Zwmc 
        {
            get { return this.zwmc; }
			set	{ 
                  if(this.zwmc != value)
                    {
                        this.OnPropertyChanging("Zwmc");  
                        this.zwmc= value;                                              
                        this.OnPropertyChanged("Zwmc");
                    }   
                }
        }	
        /// 父表名称
        public string Fbmc 
        {
            get { return this.fbmc; }
			set	{ 
                  if(this.fbmc != value)
                    {
                        this.OnPropertyChanging("Fbmc");  
                        this.fbmc= value;                                              
                        this.OnPropertyChanged("Fbmc");
                    }   
                }
        }	
        /// 序号字段名称
        public string Xhzdmc 
        {
            get { return this.xhzdmc; }
			set	{ 
                  if(this.xhzdmc != value)
                    {
                        this.OnPropertyChanging("Xhzdmc");  
                        this.xhzdmc= value;                                              
                        this.OnPropertyChanged("Xhzdmc");
                    }   
                }
        }	
        /// 图形字段名称
        public string Txzdmc 
        {
            get { return this.txzdmc; }
			set	{ 
                  if(this.txzdmc != value)
                    {
                        this.OnPropertyChanging("Txzdmc");  
                        this.txzdmc= value;                                              
                        this.OnPropertyChanged("Txzdmc");
                    }   
                }
        }	
        /// 图形类型
        public int Txlx 
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
        /// 显示顺序
        public long Xssx 
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
        /// 过滤
        public string Filter 
        {
            get { return this.filter; }
			set	{ 
                  if(this.filter != value)
                    {
                        this.OnPropertyChanging("Filter");  
                        this.filter= value;                                              
                        this.OnPropertyChanged("Filter");
                    }   
                }
        }	
        /// 缺省代码
        public string Qsdm 
        {
            get { return this.qsdm; }
			set	{ 
                  if(this.qsdm != value)
                    {
                        this.OnPropertyChanging("Qsdm");  
                        this.qsdm= value;                                              
                        this.OnPropertyChanged("Qsdm");
                    }   
                }
        }	
        /// 编辑窗体
        public string Bjct 
        {
            get { return this.bjct; }
			set	{ 
                  if(this.bjct != value)
                    {
                        this.OnPropertyChanging("Bjct");  
                        this.bjct= value;                                              
                        this.OnPropertyChanged("Bjct");
                    }   
                }
        }	
        /// 包含附件
        public bool Bhfj 
        {
            get { return this.bhfj; }
			set	{ 
                  if(this.bhfj != value)
                    {
                        this.OnPropertyChanging("Bhfj");  
                        this.bhfj= value;                                              
                        this.OnPropertyChanged("Bhfj");
                    }   
                }
        }	
        
        
        
        
        #endregion     
        
        #region 创建方法
        public  VgObjectclass()
        {
            
            this.id=0;
            this.mc="";
            this.dxlx=0;
            this.zwmc="";
            this.fbmc="";
            this.xhzdmc="";
            this.txzdmc="";
            this.txlx=0;
            this.identify=true;
            this.editable=true;
            this.queryable=true;
            this.snapable=true;
            this.visible=true;
            this.xssx=0;
            this.filter="";
            this.qsdm="";
            this.bjct="";
            this.bhfj=false;
            
        }
        #endregion
        
        #region 方法           
    
        public override bool Equals(object obj)
        {
            VgObjectclass record = obj as VgObjectclass;           
            
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTCLASS,dao.Connection))
            {	
                command.Parameters.AddWithValue(PARAM_MC,this.Mc);  
                command.Parameters.AddWithValue(PARAM_DXLX,this.Dxlx);  
                command.Parameters.AddWithValue(PARAM_ZWMC,this.Zwmc);  
                command.Parameters.AddWithValue(PARAM_FBMC,this.Fbmc);  
                command.Parameters.AddWithValue(PARAM_XHZDMC,this.Xhzdmc);  
                command.Parameters.AddWithValue(PARAM_TXZDMC,this.Txzdmc);  
                command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);  
                command.Parameters.AddWithValue(PARAM_IDENTIFY,this.Identify);  
                command.Parameters.AddWithValue(PARAM_EDITABLE,this.Editable);  
                command.Parameters.AddWithValue(PARAM_QUERYABLE,this.Queryable);  
                command.Parameters.AddWithValue(PARAM_SNAPABLE,this.Snapable);  
                command.Parameters.AddWithValue(PARAM_VISIBLE,this.Visible);  
                command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx);  
                command.Parameters.AddWithValue(PARAM_FILTER,this.Filter);  
                command.Parameters.AddWithValue(PARAM_QSDM,this.Qsdm);  
                command.Parameters.AddWithValue(PARAM_BJCT,this.Bjct);  
                command.Parameters.AddWithValue(PARAM_BHFJ,this.Bhfj);  
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID ;
            }
        }

		public bool Update(ISQLiteDao dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTCLASS,dao.Connection))
            {							
				command.Parameters.AddWithValue(PARAM_ID,this.ID);
				command.Parameters.AddWithValue(PARAM_MC,EncodingHelper.String2Unicode(this.Mc));
				command.Parameters.AddWithValue(PARAM_DXLX,this.Dxlx);
				command.Parameters.AddWithValue(PARAM_ZWMC,EncodingHelper.String2Unicode(this.Zwmc));
				command.Parameters.AddWithValue(PARAM_FBMC,EncodingHelper.String2Unicode(this.Fbmc));
				command.Parameters.AddWithValue(PARAM_XHZDMC,EncodingHelper.String2Unicode(this.Xhzdmc));
				command.Parameters.AddWithValue(PARAM_TXZDMC,EncodingHelper.String2Unicode(this.Txzdmc));
				command.Parameters.AddWithValue(PARAM_TXLX,this.Txlx);
				command.Parameters.AddWithValue(PARAM_IDENTIFY,this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE,this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE,this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE,this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE,this.Visible);
				command.Parameters.AddWithValue(PARAM_XSSX,this.Xssx);
				command.Parameters.AddWithValue(PARAM_FILTER,EncodingHelper.String2Unicode(this.Filter));
				command.Parameters.AddWithValue(PARAM_QSDM,this.Qsdm);
				command.Parameters.AddWithValue(PARAM_BJCT,this.Bjct);
				command.Parameters.AddWithValue(PARAM_BHFJ,this.Bhfj);
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTCLASS,dao.Connection))
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