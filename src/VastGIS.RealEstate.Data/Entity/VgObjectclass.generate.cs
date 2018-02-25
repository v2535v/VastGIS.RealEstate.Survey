
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
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.RealEstate.Data.Interface;
using VastGIS.Shared;


namespace VastGIS.RealEstate.Data.Entity
{
    public partial class VgObjectclass : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_objectclass";	
        public const string LAYER_NAME = "图形要素信息";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
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
		
		#region SQL语句
		private const string SQL_QUERY_VG_OBJECTCLASS ="SELECT  Id,MC,DXLX,ZWMC,FBMC,XHZDMC,TXZDMC,TXLX,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE,XSSX,FILTER,QSDM,BJCT,BHFJ FROM vg_objectclass ";
        
		private const string SQL_INSERT_VG_OBJECTCLASS = "INSERT INTO [vg_objectclass] (MC, DXLX, ZWMC, FBMC, XHZDMC, TXZDMC, TXLX, IDENTIFY, EDITABLE, QUERYABLE, SNAPABLE, VISIBLE, XSSX, FILTER, QSDM, BJCT, BHFJ) VALUES ( @MC, @DXLX, @ZWMC, @FBMC, @XHZDMC, @TXZDMC, @TXLX, @IDENTIFY, @EDITABLE, @QUERYABLE, @SNAPABLE, @VISIBLE, @XSSX, @FILTER, @QSDM, @BJCT, @BHFJ);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_OBJECTCLASS = "UPDATE [vg_objectclass] SET MC = @MC, DXLX = @DXLX, ZWMC = @ZWMC, FBMC = @FBMC, XHZDMC = @XHZDMC, TXZDMC = @TXZDMC, TXLX = @TXLX, IDENTIFY = @IDENTIFY, EDITABLE = @EDITABLE, QUERYABLE = @QUERYABLE, SNAPABLE = @SNAPABLE, VISIBLE = @VISIBLE, XSSX = @XSSX, FILTER = @FILTER, QSDM = @QSDM, BJCT = @BJCT, BHFJ = @BHFJ WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_OBJECTCLASS = "DELETE FROM [vg_objectclass] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///名称
		protected string mc = default(string);
        ///对象类型
		protected int dxlx = default(int);
        ///中文名称
		protected string zwmc = default(string);
        ///父表名称
		protected string fbmc = default(string);
        ///序号字段名称
		protected string xhzdmc = default(string);
        ///图形字段名称
		protected string txzdmc = default(string);
        ///图形类型
		protected int txlx = default(int);
        ///可检索
		protected bool identify = default(bool);
        ///可编辑
		protected bool editable = default(bool);
        ///可查询
		protected bool queryable = default(bool);
        ///可捕捉
		protected bool snapable = default(bool);
        ///可显示
		protected bool visible = default(bool);
        ///显示顺序
		protected long xssx = default(long);
        ///过滤
		protected string filter = default(string);
        ///缺省代码
		protected string qsdm = default(string);
        ///编辑窗体
		protected string bjct = default(string);
        ///包含附件
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
        
        #region IEntity 属性
         //对应数据库内表名称
        public string ObjectName
        {
            get{return "VgObjectclass";}
        }
         public string LayerName
        {
            get{return "图形要素信息";}
        }
        public string EntityName{
            get{return "IEntity";}
        }       
        public string TableName{get{return TABLE_NAME;}}
        public string[] NoCopyName{get{return new string[]{"ID","Geometry","DatabaseID","Flags","Xgr","Xgsj","WxWydm"};}}
        public bool HasFlag{get{return false;}}
        public bool HasGlobal{get{return false;}}
        public bool HasYsdm{get{return false;}}
        public bool HasGeometry{get{return false;}}
        public bool HasSurvey{get{return false;}}
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
                return string.Format("{0} {1} ","要素类明细",this.id);
            }
        }        
        #endregion
        
        #region 对象属性
        ///标识码
        ///[Column(COL_ID, PARAM_ID, default(long))]
        public virtual long ID 
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
		
        ///名称
        ///[Column(COL_MC, PARAM_MC )]
        public virtual string Mc 
        {
            get { return this.mc; }
			set	{ 
                  if(this.mc != value)
                    {
                        this.OnPropertyChanging("Mc"); 
                        this.mc = value;                        
                        this.OnPropertyChanged("Mc");
                    }   
                }
        }	
		
        ///对象类型
        ///[Column(COL_DXLX, PARAM_DXLX, default(int))]
        public virtual int Dxlx 
        {
            get { return this.dxlx; }
			set	{ 
                  if(this.dxlx != value)
                    {
                        this.OnPropertyChanging("Dxlx"); 
                        this.dxlx = value;                        
                        this.OnPropertyChanged("Dxlx");
                    }   
                }
        }	
		
        ///中文名称
        ///[Column(COL_ZWMC, PARAM_ZWMC )]
        public virtual string Zwmc 
        {
            get { return this.zwmc; }
			set	{ 
                  if(this.zwmc != value)
                    {
                        this.OnPropertyChanging("Zwmc"); 
                        this.zwmc = value;                        
                        this.OnPropertyChanged("Zwmc");
                    }   
                }
        }	
		
        ///父表名称
        ///[Column(COL_FBMC, PARAM_FBMC )]
        public virtual string Fbmc 
        {
            get { return this.fbmc; }
			set	{ 
                  if(this.fbmc != value)
                    {
                        this.OnPropertyChanging("Fbmc"); 
                        this.fbmc = value;                        
                        this.OnPropertyChanged("Fbmc");
                    }   
                }
        }	
		
        ///序号字段名称
        ///[Column(COL_XHZDMC, PARAM_XHZDMC )]
        public virtual string Xhzdmc 
        {
            get { return this.xhzdmc; }
			set	{ 
                  if(this.xhzdmc != value)
                    {
                        this.OnPropertyChanging("Xhzdmc"); 
                        this.xhzdmc = value;                        
                        this.OnPropertyChanged("Xhzdmc");
                    }   
                }
        }	
		
        ///图形字段名称
        ///[Column(COL_TXZDMC, PARAM_TXZDMC )]
        public virtual string Txzdmc 
        {
            get { return this.txzdmc; }
			set	{ 
                  if(this.txzdmc != value)
                    {
                        this.OnPropertyChanging("Txzdmc"); 
                        this.txzdmc = value;                        
                        this.OnPropertyChanged("Txzdmc");
                    }   
                }
        }	
		
        ///图形类型
        ///[Column(COL_TXLX, PARAM_TXLX, default(int))]
        public virtual int Txlx 
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
		
        ///可检索
        ///[Column(COL_IDENTIFY, PARAM_IDENTIFY, default(bool))]
        public virtual bool Identify 
        {
            get { return this.identify; }
			set	{ 
                  if(this.identify != value)
                    {
                        this.OnPropertyChanging("Identify"); 
                        this.identify = value;                        
                        this.OnPropertyChanged("Identify");
                    }   
                }
        }	
		
        ///可编辑
        ///[Column(COL_EDITABLE, PARAM_EDITABLE, default(bool))]
        public virtual bool Editable 
        {
            get { return this.editable; }
			set	{ 
                  if(this.editable != value)
                    {
                        this.OnPropertyChanging("Editable"); 
                        this.editable = value;                        
                        this.OnPropertyChanged("Editable");
                    }   
                }
        }	
		
        ///可查询
        ///[Column(COL_QUERYABLE, PARAM_QUERYABLE, default(bool))]
        public virtual bool Queryable 
        {
            get { return this.queryable; }
			set	{ 
                  if(this.queryable != value)
                    {
                        this.OnPropertyChanging("Queryable"); 
                        this.queryable = value;                        
                        this.OnPropertyChanged("Queryable");
                    }   
                }
        }	
		
        ///可捕捉
        ///[Column(COL_SNAPABLE, PARAM_SNAPABLE, default(bool))]
        public virtual bool Snapable 
        {
            get { return this.snapable; }
			set	{ 
                  if(this.snapable != value)
                    {
                        this.OnPropertyChanging("Snapable"); 
                        this.snapable = value;                        
                        this.OnPropertyChanged("Snapable");
                    }   
                }
        }	
		
        ///可显示
        ///[Column(COL_VISIBLE, PARAM_VISIBLE, default(bool))]
        public virtual bool Visible 
        {
            get { return this.visible; }
			set	{ 
                  if(this.visible != value)
                    {
                        this.OnPropertyChanging("Visible"); 
                        this.visible = value;                        
                        this.OnPropertyChanged("Visible");
                    }   
                }
        }	
		
        ///显示顺序
        ///[Column(COL_XSSX, PARAM_XSSX, default(long))]
        public virtual long Xssx 
        {
            get { return this.xssx; }
			set	{ 
                  if(this.xssx != value)
                    {
                        this.OnPropertyChanging("Xssx"); 
                        this.xssx = value;                        
                        this.OnPropertyChanged("Xssx");
                    }   
                }
        }	
		
        ///过滤
        ///[Column(COL_FILTER, PARAM_FILTER )]
        public virtual string Filter 
        {
            get { return this.filter; }
			set	{ 
                  if(this.filter != value)
                    {
                        this.OnPropertyChanging("Filter"); 
                        this.filter = value;                        
                        this.OnPropertyChanged("Filter");
                    }   
                }
        }	
		
        ///缺省代码
        ///[Column(COL_QSDM, PARAM_QSDM )]
        public virtual string Qsdm 
        {
            get { return this.qsdm; }
			set	{ 
                  if(this.qsdm != value)
                    {
                        this.OnPropertyChanging("Qsdm"); 
                        this.qsdm = value;                        
                        this.OnPropertyChanged("Qsdm");
                    }   
                }
        }	
		
        ///编辑窗体
        ///[Column(COL_BJCT, PARAM_BJCT )]
        public virtual string Bjct 
        {
            get { return this.bjct; }
			set	{ 
                  if(this.bjct != value)
                    {
                        this.OnPropertyChanging("Bjct"); 
                        this.bjct = value;                        
                        this.OnPropertyChanged("Bjct");
                    }   
                }
        }	
		
        ///包含附件
        ///[Column(COL_BHFJ, PARAM_BHFJ, default(bool))]
        public virtual bool Bhfj 
        {
            get { return this.bhfj; }
			set	{ 
                  if(this.bhfj != value)
                    {
                        this.OnPropertyChanging("Bhfj"); 
                        this.bhfj = value;                        
                        this.OnPropertyChanged("Bhfj");
                    }   
                }
        }	
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        #endregion        
        
        #region 创建方法
        public VgObjectclass()
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
            this.bhfj=true;
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
        
		
		
		public long Create(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_OBJECTCLASS,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_MC, this.Mc);
				command.Parameters.AddWithValue(PARAM_DXLX, this.Dxlx);
				command.Parameters.AddWithValue(PARAM_ZWMC, this.Zwmc);
				command.Parameters.AddWithValue(PARAM_FBMC, this.Fbmc);
				command.Parameters.AddWithValue(PARAM_XHZDMC, this.Xhzdmc);
				command.Parameters.AddWithValue(PARAM_TXZDMC, this.Txzdmc);
				command.Parameters.AddWithValue(PARAM_TXLX, this.Txlx);
				command.Parameters.AddWithValue(PARAM_IDENTIFY, this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE, this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE, this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE, this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE, this.Visible);
				command.Parameters.AddWithValue(PARAM_XSSX, this.Xssx);
				command.Parameters.AddWithValue(PARAM_FILTER, this.Filter);
				command.Parameters.AddWithValue(PARAM_QSDM, this.Qsdm);
				command.Parameters.AddWithValue(PARAM_BJCT, this.Bjct);
				command.Parameters.AddWithValue(PARAM_BHFJ, this.Bhfj);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_OBJECTCLASS,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_MC, this.Mc);
				command.Parameters.AddWithValue(PARAM_DXLX, this.Dxlx);
				command.Parameters.AddWithValue(PARAM_ZWMC, this.Zwmc);
				command.Parameters.AddWithValue(PARAM_FBMC, this.Fbmc);
				command.Parameters.AddWithValue(PARAM_XHZDMC, this.Xhzdmc);
				command.Parameters.AddWithValue(PARAM_TXZDMC, this.Txzdmc);
				command.Parameters.AddWithValue(PARAM_TXLX, this.Txlx);
				command.Parameters.AddWithValue(PARAM_IDENTIFY, this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE, this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE, this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE, this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE, this.Visible);
				command.Parameters.AddWithValue(PARAM_XSSX, this.Xssx);
				command.Parameters.AddWithValue(PARAM_FILTER, this.Filter);
				command.Parameters.AddWithValue(PARAM_QSDM, this.Qsdm);
				command.Parameters.AddWithValue(PARAM_BJCT, this.Bjct);
				command.Parameters.AddWithValue(PARAM_BHFJ, this.Bhfj);
			   
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
         public bool Save(ISQLiteService dao)
        {
            if(this.id == default(long))
            {
                return Create(dao)>0;
            }
            else
            {
                return Update(dao);
            }
            
        }  
        
        public bool Delete(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_OBJECTCLASS,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) mc = reader.GetString(1);
			if (!reader.IsDBNull(2)) dxlx = reader.GetInt32(2);
			if (!reader.IsDBNull(3)) zwmc = reader.GetString(3);
			if (!reader.IsDBNull(4)) fbmc = reader.GetString(4);
			if (!reader.IsDBNull(5)) xhzdmc = reader.GetString(5);
			if (!reader.IsDBNull(6)) txzdmc = reader.GetString(6);
			if (!reader.IsDBNull(7)) txlx = reader.GetInt32(7);
			if (!reader.IsDBNull(8)) identify = reader.GetBoolean(8);
			if (!reader.IsDBNull(9)) editable = reader.GetBoolean(9);
			if (!reader.IsDBNull(10)) queryable = reader.GetBoolean(10);
			if (!reader.IsDBNull(11)) snapable = reader.GetBoolean(11);
			if (!reader.IsDBNull(12)) visible = reader.GetBoolean(12);
			if (!reader.IsDBNull(13)) xssx = reader.GetInt64(13);
			if (!reader.IsDBNull(14)) filter = reader.GetString(14);
			if (!reader.IsDBNull(15)) qsdm = reader.GetString(15);
			if (!reader.IsDBNull(16)) bjct = reader.GetString(16);
			if (!reader.IsDBNull(17)) bhfj = reader.GetBoolean(17);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgObjectclass target=new VgObjectclass();
            target.ID=0;
            target.Mc=this.Mc;
            target.Dxlx=this.Dxlx;
            target.Zwmc=this.Zwmc;
            target.Fbmc=this.Fbmc;
            target.Xhzdmc=this.Xhzdmc;
            target.Txzdmc=this.Txzdmc;
            target.Txlx=this.Txlx;
            target.Identify=this.Identify;
            target.Editable=this.Editable;
            target.Queryable=this.Queryable;
            target.Snapable=this.Snapable;
            target.Visible=this.Visible;
            target.Xssx=this.Xssx;
            target.Filter=this.Filter;
            target.Qsdm=this.Qsdm;
            target.Bjct=this.Bjct;
            target.Bhfj=this.Bhfj;
            return target as IEntity;
           
        }
        ///从另外一个不知名的Entity中获得属性字段
        public void CopyProperties(IEntity sourceEntity)
        {
            Reflection.CopyProperties(sourceEntity,this);
        }
        #endregion
		
        
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
