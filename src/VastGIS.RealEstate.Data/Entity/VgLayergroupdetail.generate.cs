
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
    public partial class VgLayergroupdetail : INotifyPropertyChanging, INotifyPropertyChanged,IEntity
    {		
		#region 表结构		
        public const string TABLE_NAME = "vg_layergroupdetail";	
        public const string LAYER_NAME = "图层组详细信息";	
        public const GeometryType GEOMETRY_TYPE=GeometryType.None;
     
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
		
		#region SQL语句
		private const string SQL_QUERY_VG_LAYERGROUPDETAIL ="SELECT  Id,ZM,Mc,IDENTIFY,EDITABLE,QUERYABLE,SNAPABLE,VISIBLE FROM vg_layergroupdetail ";
        
		private const string SQL_INSERT_VG_LAYERGROUPDETAIL = "INSERT INTO [vg_layergroupdetail] (ZM, Mc, IDENTIFY, EDITABLE, QUERYABLE, SNAPABLE, VISIBLE) VALUES ( @ZM, @Mc, @IDENTIFY, @EDITABLE, @QUERYABLE, @SNAPABLE, @VISIBLE);" + " SELECT last_insert_rowid();";
		
		private const string SQL_UPDATE_VG_LAYERGROUPDETAIL = "UPDATE [vg_layergroupdetail] SET ZM = @ZM, Mc = @Mc, IDENTIFY = @IDENTIFY, EDITABLE = @EDITABLE, QUERYABLE = @QUERYABLE, SNAPABLE = @SNAPABLE, VISIBLE = @VISIBLE WHERE Id = @Id";
		
		private const string SQL_DELETE_VG_LAYERGROUPDETAIL = "DELETE FROM [vg_layergroupdetail] WHERE  Id = @Id ";
		
        #endregion
        	  	
        #region 变量声明
		
        ///标识码
		protected long id = default(long);
        ///组名
		protected string zm = default(string);
        ///名称
		protected string mc = default(string);
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
            get{return "VgLayergroupdetail";}
        }
         public string LayerName
        {
            get{return "图层组详细信息";}
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
                return string.Format("{0} {1} ","vg_layergroupdetail",this.id);
            }
        }
        ///提示信息，用于绑定到列表时候的DisplayMember
        public string FullLabelString
        {
            get
            {
                return string.Format("{0} {1} ","层组明细",this.id);
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
		
        ///组名
        ///[Column(COL_ZM, PARAM_ZM )]
        public virtual string Zm 
        {
            get { return this.zm; }
			set	{ 
                  if(this.zm != value)
                    {
                        this.OnPropertyChanging("Zm"); 
                        this.zm = value;                        
                        this.OnPropertyChanged("Zm");
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
		
      
       ///图形类型
        public GeometryType GeometryType
        {
            get{return GEOMETRY_TYPE;}            
        }
        #endregion        
        
        #region 创建方法
        public VgLayergroupdetail()
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
        
		
		
		public long Create(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_INSERT_VG_LAYERGROUPDETAIL,dao.Connection))
            {
            
				command.Parameters.AddWithValue(PARAM_ZM, this.Zm);
				command.Parameters.AddWithValue(PARAM_MC, this.Mc);
				command.Parameters.AddWithValue(PARAM_IDENTIFY, this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE, this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE, this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE, this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE, this.Visible);
                this.ID = Convert.ToInt64(command.ExecuteScalar());
                return this.ID;
            }
        }

		public bool Update(ISQLiteService dao)
        {
            using(SQLiteCommand command  = new SQLiteCommand(SQL_UPDATE_VG_LAYERGROUPDETAIL,dao.Connection))
            {
            						
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
				command.Parameters.AddWithValue(PARAM_ZM, this.Zm);
				command.Parameters.AddWithValue(PARAM_MC, this.Mc);
				command.Parameters.AddWithValue(PARAM_IDENTIFY, this.Identify);
				command.Parameters.AddWithValue(PARAM_EDITABLE, this.Editable);
				command.Parameters.AddWithValue(PARAM_QUERYABLE, this.Queryable);
				command.Parameters.AddWithValue(PARAM_SNAPABLE, this.Snapable);
				command.Parameters.AddWithValue(PARAM_VISIBLE, this.Visible);
			   
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
            using(SQLiteCommand command  = new SQLiteCommand(SQL_DELETE_VG_LAYERGROUPDETAIL,dao.Connection))
            {                   
				command.Parameters.AddWithValue(PARAM_ID, this.ID);
                return (command.ExecuteNonQuery() == 1);
            }
        }
        
        public void  LoadFromReader(SQLiteDataReader reader)
        {
			if (!reader.IsDBNull(0)) id = reader.GetInt64(0);
			if (!reader.IsDBNull(1)) zm = reader.GetString(1);
			if (!reader.IsDBNull(2)) mc = reader.GetString(2);
			if (!reader.IsDBNull(3)) identify = reader.GetBoolean(3);
			if (!reader.IsDBNull(4)) editable = reader.GetBoolean(4);
			if (!reader.IsDBNull(5)) queryable = reader.GetBoolean(5);
			if (!reader.IsDBNull(6)) snapable = reader.GetBoolean(6);
			if (!reader.IsDBNull(7)) visible = reader.GetBoolean(7);
        }
        
        #region 拷贝
        public IEntity Copy()
        {
            VgLayergroupdetail target=new VgLayergroupdetail();
            target.ID=0;
            target.Zm=this.Zm;
            target.Mc=this.Mc;
            target.Identify=this.Identify;
            target.Editable=this.Editable;
            target.Queryable=this.Queryable;
            target.Snapable=this.Snapable;
            target.Visible=this.Visible;
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
